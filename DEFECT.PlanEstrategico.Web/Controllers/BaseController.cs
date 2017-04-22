using DEFECT.PlanEstrategico.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEFECT.PlanEstrategico.Web.Controllers
{
    public class BaseController : Controller
    {
        public DEFECTPlanEstrategicoDataContext db = new DEFECTPlanEstrategicoDataContext("AppDb")
            .WithConnectionStringFromConfiguration();
        //// GET: Base
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}