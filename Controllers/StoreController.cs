using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Music_Store.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello form store.Index()";
        }
        //
        // GET: /Store/Browse
        public string Browse(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
        //
        // GET: /Store/Details
        public string Details()
        {
            return "Hello from Store.Details()";
        }
    }
}
