using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ecommerce.Models;


namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<Team> games = new List<Team>();
            games.Add(new Team { Title = "The Witcher 2", Description= "Wyprodukowana przez CD Projekt Red we współpracy z Agorą SA", Image= "https://img6.gram.pl/120110404135959.jpg", Price= 5});
            games.Add(new Team { Title = "Assassin’s Creed IV: Black Flag", Description = "Przygodowa gra akcji stworzona przez Ubisoft Montreal", Image = "https://img6.gram.pl/thumb/20130228113205.jpg?fbclid=IwAR2lP-Sig1MzqQB7oMXa8pCLT7PUymoIKmXXSAT_KDgAMWg_zvUiVrMnWcU", Price= 10 });
            games.Add(new Team { Title = "NBA 2k20", Description = "Gra koszykarska należąca do popularnego sportowego cyklu zespołu Visual Concepts i firmy 2K Sports", Image = "https://i2.wp.com/konsolowe.info/wp-content/uploads/2019/07/2KSWIN_NBA2K20_STD_NSW_FOB_ENG.jpg?fit=664%2C1080&ssl=1&fbclid=IwAR0U1qQ9TLJDGKWow96P_Ts71p--CNogQb1So-H15l_yyMU7PjX3b6wcOZE", Price = 30 });
            games.Add(new Team { Title = "Battlefield 4", Description = "Gra komputerowa z gatunku first-person shooter stworzona przez EA Digital Illusions CE.", Image = "https://eplakaty.pl/img/towary/1/2016_10/FP3000-Battlefield-4-Cover-plakat.jpg?fbclid=IwAR1mTQOxyedOVik0wqDp1UeV-B5d0q_mMn_D7wAIvEyOGEiAYhPpVWK7NGM", Price = 50 });
            games.Add(new Team { Title = "Metro 2033", Description = "Rosyjska powieść postapokaliptyczna napisana przez Dmitrija Głuchowskiego, pierwsza część trylogii.", Image = "https://ecsmedia.pl/c/uniwersum-metro-2033-metro-2033-b-iext33584448.jpg", Price = 20 });
            games.Add(new Team { Title = "Call of Duty 4", Description = "Gra komputerowa z gatunku first-person shooter, wyprodukowana przez amerykańskie studio Infinity Ward", Image = "https://www.miastogier.pl/baza/Encyklopedia/gry/News/30.08.2007/nws_callof1.JPG", Price = 50 });
            games.Add(new Team { Title = "Cyberpunk 2077", Description = "komputerowa fabularna gra akcji stworzona przez studio CD Projekt Red", Image = "https://static.muve.pl/uploads/product-cover/0077/6329/c77-pc-2d-pl.jpg", Price = 65 });
            games.Add(new Team { Title = "Risen 3: Władcy tytanów", Description = "Komputerowa gra fabularna, którą wyprodukowało studio Piranha Bytes.", Image = "https://gamedot.pl/uploads/media/user_upload/0001/28/2a581a63d89ac8b621c6e936a7fa64b77324ff7f.jpeg", Price = 15 });
            games.Add(new Team { Title = "Minecraft", Description = "komputerowa gra survivalowa o otwartym świecie stworzona przez Markusa Perssona i rozwijana przez Mojang Studios", Image = "https://bi.im-g.pl/im/92/a1/10/z17439634Q,Minecraft---okladka.jpg", Price = 47 });


            ViewBag.gamesLength = games.Count;

            return View(games);
        }

        public void AddToBasket(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
