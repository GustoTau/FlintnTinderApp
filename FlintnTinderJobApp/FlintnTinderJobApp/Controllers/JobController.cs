using FlintnTinderJobApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlintnTinderJobApp.Controllers
{
    public class JobController : Controller
    {
        //
        // GET: /Job/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllJobs(string search)
        {
            JobObject model = new JobObject();
            Jobs newjobsList = new Jobs();

            using (StreamReader rd = new StreamReader(@"c:\users\gontse.tauyane\documents\visual studio 2012\Projects\FlintnTinderJobApp\FlintnTinderJobApp\Jobs.json"))
            {
                string json = rd.ReadToEnd();
                model = Newtonsoft.Json.JsonConvert.DeserializeObject<JobObject>(json);
            }
            
            //Attempting to do the search
            if (!String.IsNullOrEmpty(search))
            {
                for (int i = 0; i < model.jobs.Count; i++)
                {
                    if (model.jobs[i].Client.IndexOf(search, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        newjobsList = model.jobs[i];
                    }
                }
            }
            else
            {
                return View(model);
            }
            return View(newjobsList);
        }
    }
}
