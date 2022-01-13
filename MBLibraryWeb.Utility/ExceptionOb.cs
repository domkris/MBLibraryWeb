using System;

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
