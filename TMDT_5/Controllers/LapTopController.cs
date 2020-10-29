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
        TMDT5Entities db = new TMDT5Entities();

        public ActionResult Index()
        {
            return View();
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
        public ActionResult getGen()
        {
            var ListGen = db.laptops.GroupBy(l => l.Gen).Select(l => l.Key);
            return PartialView(ListGen);
        }
        /// Sv tự thêm các thông tin khác 
    }

}