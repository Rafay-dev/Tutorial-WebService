using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://xyzcompany.org/webservice")] // Rename it to your company domain or anyting to make it unique
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod] // ** This makes this method part of our public WebService
        // :1
        // Create method Add
        public int Add(int fNum, int sNum)
        {
            return fNum + sNum;
        }


    }
}
