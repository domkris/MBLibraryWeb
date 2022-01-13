using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Utility
{
    public class ExceptionOb
    {
        public static string GetErrorMessage(Exception ex)
        {
            if (ex.InnerException != null)
                return ex.InnerException.Message;

            return ex.Message;
        }
    }
}
