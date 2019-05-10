using Ninject;
using SAS.Repository.UnitOfWork.Abstract;
using System;
using System.Web.Mvc;

namespace SAS.Web.Controllers
{
    public class OnApprovalController
    {
        [Inject]
        public IUnitOfWork DB { get; set; }
        // GET: OnApproval
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }
    }
}