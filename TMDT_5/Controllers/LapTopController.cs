using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT_5.Models;

namespace TMDT_5.Controllers
{
    public class LapTopController : Controller
    {
        // GET: LapTop
        
        TMDT5Entities1 db = new TMDT5Entities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getTerm()
        {
            var ListTerm = db.laptops.GroupBy(l => l.Product).Select(l => l.Key);
            return PartialView(ListTerm);
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getScreenResolution()
        {
            var ListScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListScreenResolution);
        }
        public ActionResult getInch()
        {
            var ListInch = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInch);
        }
        public ActionResult getType()
        {
            var ListType = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListType);
        }
        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
            return PartialView(ListRam);
        }
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        public ActionResult getSpeed()
        {
            var Listspeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key);
            return PartialView(Listspeed);
        }

        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOS);
        }
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        public ActionResult getWeight()
        {
            var ListWeight = db.laptops.GroupBy(l => l.Weight).Select(l => l.Key);
            return PartialView(ListWeight);
        }
        public ActionResult getPriceLow()
        {
            var ListPriceLow = db.laptops.GroupBy(l => l.Price_euros).Select(l => l.Key);
            return PartialView(ListPriceLow);
        }
        public ActionResult getPriceHight()
        {
            var ListPriceHight = db.laptops.GroupBy(l => l.Price_euros).Select(l => l.Key);
            return PartialView(ListPriceHight);
        }
        /// Sv tự thêm các thông tin khác 
    }

}