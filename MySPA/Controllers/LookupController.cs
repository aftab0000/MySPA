using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Model;
using MySPA.Data.Contracts;

namespace MySPA.Controllers
{
    public class ApiControllerBase : ApiController
    {
        protected IMySpaUow Uow { get; set; }
    }
    public class LookupController : ApiControllerBase
    {

        public LookupController(IMySpaUow uow)
        {
            Uow = uow;
        }

        [System.Web.Http.ActionName("LogItem")]
        public IEnumerable<LogItem> GetLogItems()
        {
            return Uow.LogItem.GetAll();
        }

    // GET: Lookup
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}