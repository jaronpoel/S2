using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.MatchReport
{
    class GetMatchReportFailedException : Exception
    {
        public GetMatchReportFailedException()
        {

        }

        public AuthenticationFailedException(string message) : base(message)
        {

        }
    }
}
