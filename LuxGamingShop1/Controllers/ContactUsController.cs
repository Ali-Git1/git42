using LuxGamingShop1.Models;
using LuxGamingShop1.Models.ContactUs;
using LuxGamingShop1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop1.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly DataContext _datacontext;
        public ContactUsController(DataContext dbcontext)
        {
            _datacontext = dbcontext;
        }
        public IActionResult Index()
        {
            //var contactus = new ContactUs { Id = 1, Title = "Contact1", Title1 = "Contact2", Title2 = "Contact2", Title3 = "Contact3", About = "Gamings and game", Adress = "Baku", Email = "lugx@", Phone = "+381908430" };
            HomeIndexVM homeIndexVM = new HomeIndexVM();
            //homeIndexVM.contactUs = contactus;
            homeIndexVM.contactUs = _datacontext.contactUs.FirstOrDefault();
            return View(homeIndexVM);

        }
    }
}
