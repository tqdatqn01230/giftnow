using GiftNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace GiftNow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Gift> gifts = new List<Gift>();
        private List<decimal> cards = new List<decimal> {20000,30000,40000 };
        private List<decimal> package = new List<decimal> { 30000, 50000, 60000 };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Gift g1 = new Gift();
            g1.GiftId = 1;
            g1.GiftName = "Cocoon Winter Melon Shower Gel";
            g1.Price = 220000;
            g1.GiftImage = "gift_images/g1.jpg";
            g1.Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum";
            g1.Quantity = 7;
            g1.CateID = 1;
            gifts.Add(g1);  

            Gift g2 = new Gift();
            g2.GiftId = 2;
            g2.Price = 140000;
            g2.Quantity = 10;
            g2.GiftImage = "gift_images/g2.jpg";
            g2.Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum";
            g2.GiftName = "Sexy Skin Perfume Shower Gel 600ml";
            g2.CateID = 1;
            g2.Quantity = 5;
            gifts.Add(g2);

            Gift g3 = new Gift();
            g3.GiftId = 3;
            g3.GiftName = "Alice In Beauty Skincare Set";
            g3.Price = 1890000;
            g3.Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum";
            g3.GiftImage = "gift_images/g3.jpg";
            g3.CateID = 2;
            g3.Quantity = 15;
            gifts.Add(g3);

            Gift g4 = new Gift();
            g4.GiftId = 4;
            g4.GiftName = "Cocoon Pomelo Shampoo + Conditioner Set";
            g4.Price = 100000;
            g4.Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum";
            g4.GiftImage = "gift_images/g4.jpg";
            g4.CateID = 3;
            g4.Quantity = 51;
            gifts.Add(g4);

            Gift g5 = new Gift();
            g5.GiftId = 5;
            g5.GiftName = "Violet Evergarden's Pendant";
            g5.Price = 2000000;
            g5.Description = "Pendant For Cosplayer, blah blah";
            g5.GiftImage = "gift_images/g5.png";
            g5.CateID = 4;
            g5.Quantity = 8;
            gifts.Add(g5);

            Gift g6 = new Gift();
            g6.GiftId = 6;
            g6.GiftName = "Wilson Glases metal frame, round eyes";
            g6.Price = 2200000;
            g6.Description = "Pendant For Cosplayer, blah blah Lorem Ipsum is not simply random text. It has roots";
            g6.GiftImage = "gift_images/g6.png";
            g6.CateID = 5;
            g6.Quantity = 5;
            gifts.Add(g6);

            Gift g7 = new Gift();
            g7.GiftId = 7;
            g7.GiftName = "Glasses kingsman";
            g7.Price = 2030000;
            g7.Description = "KingsMan, blah blah Lorem Ipsum is not simply random text. It has roots";
            g7.GiftImage = "gift_images/g7.jpg";
            g7.CateID = 5;
            g6.Quantity = 6;
            gifts.Add(g7);

            Gift g8 = new Gift();
            g8.GiftId = 8;
            g8.GiftName = "Trap Card";
            g8.Price = 10000;
            g8.Description = "are cards with purple-colored borders that have various effects. A Trap Card must first be Set and can only be activated after the current turn has finished";
            g8.GiftImage = "gift_images/g8.jpg";
            g6.CateID = 6;
            gifts.Add(g8);

            Gift g9 = new Gift();
            g9.GiftId = 8;
            g9.GiftName = "Reverse Card";
            g9.Price = 10000;
            g9.Description = "er player's turn as long as it wasn't set that turn. The effects of certain Normal Trap Cards behave like Equip Cards, but the card is still considered a Normal Trap Card.";
            g9.GiftImage = "gift_images/g9.png";
            g9.CateID = 6;
            g2.Quantity = 3;
            gifts.Add(g9);


        }
        public IActionResult CheckoutSuccess()
        {
            return View();  
        }
        public IActionResult Index()
        {
            return View(gifts);
        }
        public IActionResult SearchByName(string Name)
        {
            List<Gift> list = gifts.Where(x=> x.GiftName.Contains(Name)).ToList();
            return View("Index", list);
        }

        public IActionResult SearchByCategory(int id)
        {
            List<Gift> list = gifts.Where((x) => x.CateID == id).ToList();
            return View("Index", list);
        }
        public IActionResult Detail(int id)
        {
            return View(gifts[id - 1]);
        }
        public IActionResult Cart([FromRoute] int id)
        {
            return View(gifts[id - 1]);
        }
        public IActionResult Checkout( int id,int PackageId,int CardId)
        {
            ViewBag.card = cards[CardId];

            ViewBag.pack = package[PackageId];
            return View(gifts[id - 1]);
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
