using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Utility
{
    public static class ErrorResponseMessage
    {
        // this can be used for i18 translations on frontend side
        public readonly static string NoDataInDatabase = "NoDataInDB";
        public readonly static string NoDataInDatabaseWithId = "NoDataWithSpecifiedIdInDB";
        public readonly static string FetchDataError = "FetchDataError";
    }
}
