using LuxGamingShop1.Models;
using LuxGamingShop1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index1()
        {
            var features = new List<Feature>();
            features.Add(new Feature { Id = 1, Title = "free storage1", Path = "featured-01.png" });
            features.Add(new Feature { Id = 2, Title = "user more2", Path = "featured-02.png" });
            features.Add(new Feature { Id = 3, Title = "reply ready3", Path = "featured-03.png" });
            features.Add(new Feature { Id = 4, Title = "easy layout4", Path = "featured-04.png" });


            var gaming = new List<Gaming>();
            gaming.Add(new Gaming { Id = 1, Tittle = "Warframe", Path = "top-game-01.jpg", CategoriesName = "Adventure" });
            gaming.Add(new Gaming { Id = 2, Tittle = "BatleGrounds", Path = "top-game-02.jpg", CategoriesName = "Pubg" });
            gaming.Add(new Gaming { Id = 3, Tittle = "Apex", Path = "top-game-03.jpg", CategoriesName = "Assasin1" });
            gaming.Add(new Gaming { Id = 4, Tittle = "Sims", Path = "top-game-04.jpg", CategoriesName = "Assasin2" });
            gaming.Add(new Gaming { Id = 5, Tittle = "Lostark", Path = "top-game-05.jpg", CategoriesName = "AssasinLostark" });


            var TrendGame = new List<TrendingGame>();
            TrendGame.Add(new TrendingGame { Id = 1, Path = "trending-01.jpg", UpTitle = "Action1", UpTitle1 = "Assasin Creed1", Price = 10 });
            TrendGame.Add(new TrendingGame { Id = 2, Path = "trending-02.jpg", UpTitle = "Action2", UpTitle1 = "Assasin Creed2", Price = 15 });
            TrendGame.Add(new TrendingGame { Id = 3, Path = "trending-03.jpg", UpTitle = "Action3", UpTitle1 = "Assasin Creed3", Price = 12 });
            TrendGame.Add(new TrendingGame { Id = 4, Path = "trending-04.jpg", UpTitle = "Action4", UpTitle1 = "Assasin Creed4", Price = 17 });



            var homeh = new HomeH { Id = 1, Tittle = "Welcome Lux", Path = "banner-image.jpg", UpTittle = "Best Gaming best", About = "Gamings and game" };




            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Features = features;
            homeIndexVM.Gamings = gaming;
            homeIndexVM.Homeh = homeh;
            homeIndexVM.trendinggame = TrendGame;

            return View(homeIndexVM);


        }



    }


}
