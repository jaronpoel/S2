using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exceptions.MatchReport;
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
        public ActionResult SingleReport(int id)
        {
            MatchReport list = MatchReportCollection.GetMatchReportByID(id);
            if (list == null)
            {
                return RedirectToAction("Reports", "Oversight");
            }
            ViewBag.Matchreport = list;
            return View();
        }
        public ActionResult NewReport()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMatchReportAdded(MatchReportViewModel matchreport)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("NewReport", "Reports");
            }

            try
            {
                MatchReport newreport = new MatchReport(0, DateTime.Now, matchreport.Title, matchreport.Report, null);
                MatchReportCollection.AddMatchReport(newreport);
                return RedirectToAction("Oversight", "Reports");
            }
            catch (AddMatchReportFailedException exception)
            {
                ModelState.AddModelError("", exception.Message);
                return RedirectToAction("NewReport", "Reports");
            }
        }
    }
}
