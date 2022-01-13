using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Utility
{
    public class ResponseOb
    {
        public bool Success { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
        public string WarningMessage { get; set; }

        public static object GetError(Exception ex)
        {
            return new ResponseOb
            {
                Success = false,
                ErrorMessage = ExceptionOb.GetErrorMessage(ex)
            };
        }


        public static object GetSuccess(object response, string warningMessage = null)
        {
            return new ResponseOb
            {
                Success = true,
                Data = response,
                WarningMessage = warningMessage
            };
        }


        public static object GetCustomError(string message)
        {
            return new ResponseOb
            {
                Success = false,
                ErrorMessage = message
            };
        }
    }
}
