using SAS.Repository.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAS.Web.Controllers.Request
{
    public abstract class BaseRequestController : Controller
    {
        protected IUnitOfWork DB { get; }

        protected BaseRequestController(IUnitOfWork db)
        {
            DB = db;
        }
    }
}