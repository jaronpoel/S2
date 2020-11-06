using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MatchReport
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Report { get; set; }
        public string MadeBy { get; set; }

        public MatchReport(int id, DateTime date ,string title, string report, string madeBy)
        {
            Id = id;
            Date = date;
            Title = title;
            Report = report;
            MadeBy = madeBy;
        }

        public void SetTitle(string name)
        {
            throw new NotImplementedException();
        }

        public void SetReport(string report)
        {
            throw new NotImplementedException();
        }
    }
}
