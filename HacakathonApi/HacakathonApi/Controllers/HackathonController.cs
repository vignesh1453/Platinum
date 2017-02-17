using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace HacakathonApi.Controllers
{
    [Route("api/Hackathon")]
    public class HackathonController : ApiController
    {
        [HttpGet]
        [Route("BuildsPerDay")]
        public JsonResult<List<Models.BuildsCount>> BuildsPerDay()
        {
            var BuildLst = new List<Models.BuildsCount>();
            var TodayDate = System.DateTime.Now.Date;
            var date = TodayDate.Day;
            //var obj = new Models.BuildsCounts();
            var ran = new Random();
            for (int i = 1; i <= date; i++)
            {
                var obj = new Models.BuildsCount();
                //var ran = new Random();
                obj.Date = TodayDate.AddDays(i).ToShortDateString();
                obj.Success = ran.Next(1, 25);
                obj.Failed = ran.Next(1, 25);
                BuildLst.Add(obj);
            }
            //var FirstDate = 01;


            return Json(BuildLst);
        }
    }
}
