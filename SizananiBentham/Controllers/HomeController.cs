using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SizananiBentham.Models;

namespace SizananiBentham.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sizanani Bentham
        [Route("about-sizanani-bentham")]
        public ActionResult SizananiBentham()
        {
           
            return View();
        }

        // GET: Health Unit
        [Route("about-health-unit")]
        public ActionResult HealthUnit()
        {

            return View();
        }

        // GET: Research Unit
        [Route("about-research-unit")]
        public ActionResult ResearchUnit()
        {

            return View();
        }

        // GET: Specialists
        [Route("our-specialists")]
        public ActionResult Specialists()
        {

            return View();
        }

        // GET: Contact
        [Route("contact-us")]
        public ActionResult Contact()
        {
         
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: " + model.FromName + " (" + model.FromEmail + ")<br />Subject: " + model.Subject + "<br />Phone: " + model.FromPhoneNumber + "</p><p>Message:</p><p>" + model.Message + "</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("contact@sizananibentham.co.za"));
                message.Subject =  model.FromName + ": " + model.Subject;
                message.Body = string.Format(body);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}