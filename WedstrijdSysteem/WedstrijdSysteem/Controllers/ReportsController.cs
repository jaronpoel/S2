using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using WedstrijdSysteem.Models;

namespace WedstrijdSysteem.Controllers
{
    public class ReportsController : Controller
    {
        private MatchReportCollection MatchReportCollection { get; } = new MatchReportCollection();

        public ActionResult Oversight()
        {
            AllMatchReportsViewModel ViewModel = new AllMatchReportsViewModel();
            ViewModel.ListOfMatchReports = MatchReportCollection.GetAllMatchReports();
            return View(ViewModel);
        }
        public ActionResult SingleReport()
        {
            return View();
        }
        public ActionResult NewReport()
        {
            return View();
        }
    }
}
