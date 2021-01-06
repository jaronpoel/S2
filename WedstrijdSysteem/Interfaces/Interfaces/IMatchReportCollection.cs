using Interfaces.DTO;
using System.Collections.Generic;

namespace Dal.Context
{
    public interface IMatchReportCollection
    {
        void AddMatchReport(MatchReportDto matchreport);
        void DeleteMatchReport(MatchReportDto matchReport);
        List<MatchReportDto> GetAllMatchReports();
        MatchReportDto GetMatchReportByID(int id);
    }
}