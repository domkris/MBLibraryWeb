using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Utility
{
    public static class ErrorResponseMessage
    {
        public readonly static string NoDataInDatabase = "NoDataInDB";
        public readonly static string NoDataInDatabaseWithId = "NoDataWithSpecifiedIdInDB";
        public readonly static string FetchDataError = "FetchDataError";
    }
}
