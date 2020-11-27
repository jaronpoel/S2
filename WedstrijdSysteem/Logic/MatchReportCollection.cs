using Dal.Context;
using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MatchReportCollection
    {
        private MatchReportSqlContext matchreportSqlContext { get; } = new MatchReportSqlContext();
        public void DeleteMatchReport(MatchReport matchReport)
        {
            throw new NotImplementedException();
        }

        public List<MatchReport> GetAllMatchReports()
        {
            return DTOConverter.GetAllMatchReports(matchreportSqlContext.GetAllMatchReports());
        }

        public MatchReport GetMatchReportByID(int id)
        {
            throw new NotImplementedException();
        }

        public void AddMatchReport()
        {
            throw new NotImplementedException();
        }
    }
}
