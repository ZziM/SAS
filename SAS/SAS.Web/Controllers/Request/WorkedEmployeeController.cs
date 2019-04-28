using SAS.Repository.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAS.Web.Controllers.Request
{
    public class WorkedEmployeeController : BaseRequestController
    {
        public WorkedEmployeeController(IUnitOfWork db) : base(db)
        {

        }
        // GET: WorkedEmployee
        public ActionResult Index()
        {
            return View("~/Views/Request/WorkedEmployee/Index.cshtml");
        }
    }
}