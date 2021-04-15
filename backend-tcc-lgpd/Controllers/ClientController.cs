using backend_tcc_lgpd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_tcc_lgpd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        // GET: ClientController
        [HttpGet]
        [Route("{Id}")]
        public ActionResult<Client> Index(int Id)
        {
            if (Id == 768805383)
            {
                Client c = new Client();
                c.client_id = "768805383";
                c.status = "Existing Customer";
                c.age = 45;
                c.gender = 'M';
                c.dependent_count = 3;
                c.education_Level = "High School";
                c.marital_Status = "Married";
                c.income_category = "$60K - $80K";
                c.card_category = "Blue";
                c.mounths_active = 39;
                c.credit_limit = 12691;
                c.credit_remaining = 777;
                c.credit_usage = 11914;
                c.total_trans_amt = 1144;
                c.total_trans_ct = 42;
                c.avg_utilization_ratio = 61;
                return Json(c);
            }
            return new JsonResult(new JsonError()
            {
                Error = "Cannot find id",
            })
            { StatusCode = StatusCodes.Status404NotFound };
        }

        // POST: ClientController/Create
        [HttpPost]
        public ActionResult<ClientId> Create(User user)
        {
            if (user.username.ToLower() == "admin" && user.password == "admin")
            {
                ClientId clientId = new ClientId() { client_id = "768805383" };
                return clientId;
            }
            return new JsonResult(new JsonError()
            {
                Error = "Cannot find username or password",
            })
            { StatusCode = StatusCodes.Status404NotFound };
        }
    }
}
