
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoyalTravel.Areas.Administration.ViewModels;
using RoyalTravel.Data;
using RoyalTravel.Data.Models;
using RoyalTravel.Services.Hotel;
using RoyalTravel.Services.Stays;
using RoyalTravel.Services.User;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalTravel.Areas.Administration.Controllers
{
    [Area(nameof(Administration))]
    [Route("/[controller]/[action]")]
    [Authorize(Policy = "RequireAdmin")]
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IUserService userService;
        private readonly IStaysService staysService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHotelService hotelService;

        public AdministrationController(ApplicationDbContext dbContext, IUserService userService, IStaysService staysService, UserManager<ApplicationUser> userManager, IHotelService hotelService)
        {
            
            db = dbContext;
            this.userService = userService;
            this.staysService = staysService;
            this.userManager = userManager;
            this.hotelService = hotelService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllUsers()
        {
            var users = db.Users.ToList();
            var usersViewModel = new List<AllUsersViewModel>();

            foreach (var user in users)
            {
                var currentUser = user;
                if (user.Email == "yokhawand@gmail.com") { }
                else
                {
                    usersViewModel.Add(new AllUsersViewModel
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        EmailAddress = user.Email,
                        EmailIsConfirmed = user.EmailConfirmed ? "Yes" : "No",
                        UsedPoints = user.UsedPoints.ToString(),
                    });
                }

            }
            return View(usersViewModel);
        }

        public IActionResult CancelRes(int stayId)
        {
            if (stayId == 0)
            {
                return PartialView("_NoDataPartial");
            }
            var stay = db.Stays.First(s => s.Id == stayId);
            stay.IsCanceled = true;
            db.Stays.Remove(stay);
            db.SaveChanges();
            return RedirectToAction("AllReservations");

           
        }

        public IActionResult AllReservations()
        {
            var allReservations = staysService.AllReservations();
            if (allReservations == null || allReservations.Count <= 0)
            {
                return PartialView("_NoDataPartial");
            }
            var reservationsViewModel = new List<ReservationsViewModel>();

            foreach (var stay in allReservations)
            {
                var viewModel = new ReservationsViewModel
                {
                    RoomType = stay.RoomType,
                    MoneySpend = stay.MoneySpend.ToString(),
                    ArrivalDate = stay.ArrivalDate.ToString("MM/dd/yyyy"),
                    DepartureDate = stay.DepartureDate.ToString("MM/dd/yyyy"),
                    Darrival = stay.ArrivalDate,
                    Ddeparture = stay.DepartureDate,
                    PricePerNight = stay.Price.ToString(),
                    TotalPrice = stay.TotalPrice.ToString(),
                    PointsEarned = stay.PointsEarned.ToString(),
                    HotelName = hotelService.FindSingleHotelById(stay.HotelId).Result.Name,
                    UserName = userService.GetUser(stay.ApplicationUserId).UserName,
                    Adults = stay.Adults.ToString(),
                    Children = stay.Children.ToString(),
                    ConfirmationNumber = stay.ConfirmationNumber,
                    BookedOn = stay.BookedOn,
                    StayId = stay.Id
                };
                reservationsViewModel.Add(viewModel);
            }
            return View(reservationsViewModel);
        }

    }
   

}
