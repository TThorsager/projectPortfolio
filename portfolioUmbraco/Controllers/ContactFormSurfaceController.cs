using portfolioUmbraco.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;

namespace portfolioUmbraco.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            TempData["success"] = true;

            IContent comment = Services.ContentService.CreateContent(model.Subject, CurrentPage.Id, "message");
            comment.SetValue("messageName", model.Name);
            comment.SetValue("email", model.Email);
            comment.SetValue("subject", model.Subject);
            comment.SetValue("messageContent", model.Message);
            comment.SetValue("umbracoNaviHide", true);

            //Gemmer den indtastede data
            Services.ContentService.Save(comment);

            

            return RedirectToCurrentUmbracoPage();

        }
    }
}