using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTask2.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult MainPage()
        {
            string imgpath = Server.MapPath("~/Content/Image/alphabet-tiranga-image-letter-name-tiranga-images-for-whatsapp-dp.jpg");
            byte[] bytedata = System.IO.File.ReadAllBytes(imgpath);
            string imgBase64Data = Convert.ToBase64String(bytedata);
            string imgDataURL = string.Format("data:image/jpg;base64,{0}", imgBase64Data);
            ViewBag.ImageData = imgDataURL;
            return View();
        }
    }
}