using GiftNow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            //Cate 1: body care product / cate 2: skin care / cate 3: hair care product / cate 4: jewels /  cate 5: glasses
            // cate 6: card 
            //
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
            g7.Quantity = 6;
            gifts.Add(g7);

            Gift g10 = new Gift();
            g10.GiftId = 8;
            g10.GiftName = "Ví cầm tay nữ";
            g10.Price = 60000;
            g10.Description = "Ví Cầm tay nữ";
            g10.GiftImage = "gift_images/g10.png";
            g10.CateID = 9;
            g10.Quantity = 3;
            gifts.Add(g10);


            Gift g11 = new Gift();
            g11.GiftId = 9;
            g11.GiftName = "Túi xách đeo bên vai";
            g11.Price = 99000;
            g11.Description = "Túi xách đeo bên vai";
            g11.GiftImage = "gift_images/g11.jpg";
            g11.CateID = 8;
            g11.Quantity = 3;
            gifts.Add(g11);
            
            Gift g12 = new Gift();
            g12.GiftId = 10;
            g12.GiftName = "Tom Ford Oud Wood";
            g12.Price = 370000;
            g12.Description = "Tom Ford Oud Wood";
            g12.GiftImage = "gift_images/g12.jpg";
            g12.CateID = 1;
            g12.Quantity = 3;
            gifts.Add(g12);

            Gift g13 = new Gift();
            g13.GiftId = 11;
            g13.GiftName = "Cọ Trang Điểm";
            g13.Price = 180000;
            g13.Description = "Cọ Trang Điểm";
            g13.GiftImage = "gift_images/g13.png";
            g13.CateID = 1;
            g13.Quantity = 3;
            gifts.Add(g13);

            Gift g14 = new Gift();
            g14.GiftId = 12;
            g14.GiftName = "Some One Like You";
            g14.Price = 625000;
            g14.Description = "Some One Like You";
            g14.GiftImage = "gift_images/g14.png";
            g14.CateID = 1;
            g14.Quantity = 3;
            gifts.Add(g14);
            
            Gift g15 = new Gift();
            g15.GiftId = 13;
            g15.GiftName = "Bear";
            g15.Price = 70000;
            g15.Description = "Bear";
            g15.GiftImage = "gift_images/g15.png";
            g15.CateID = 8;
            g15.Quantity = 3;
            gifts.Add(g15);

            Gift g16 = new Gift();
            g15.GiftId = 14;
            g15.GiftName = "Bear";
            g15.Price = 70000;
            g15.Description = "Bear";
            g15.GiftImage = "gift_images/g15.png";
            g15.CateID = 8;
            g15.Quantity = 3;
            gifts.Add(g15);

            //cate 8 : hand bag // cate 9: wallet /cate 7: bag



        }
        public IActionResult CheckoutSuccess(string firstName,string lastName,string address
            , string city, string phone,string email, string giftname)
        {
            SendMail(firstName,lastName,address,city,phone,email,giftname);
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
        public void SendMail(string firstName, string lastName, string address
            , string city, string phone, string email1, string giftname)
        {
            String SendMailFrom = "tqdatqn01230@gmail.com";
            String SendMailTo = "giftnow.customercare@gmail.com";
            String SendMailSubject = "New Order";
            String SendMailBody =
                "Gift Name: "+giftname+"\n"
                +"Customer's Name: "+ firstName+" "+lastName+"\n"
                + "Address: " + address+"\n"+
                "City: "+city+"\n"
                +"Phone: "+phone+"\n"
                +"Email: "+email1;

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage email = new MailMessage();
                // START
                email.From = new MailAddress(SendMailFrom);
                email.To.Add(SendMailTo);
                email.CC.Add(SendMailFrom);
                email.Subject = SendMailSubject;
                email.Body = SendMailBody;
                //END
                SmtpServer.Timeout = 5000;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential(SendMailFrom, "fhvwbnydtwefxapg");
                SmtpServer.Send(email);

                Console.WriteLine("Email Successfully Sent");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
