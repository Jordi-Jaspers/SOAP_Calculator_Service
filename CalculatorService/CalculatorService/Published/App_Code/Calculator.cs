using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Calculator
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Calculator : System.Web.Services.WebService
{
    [WebMethod]
    public int Addition(int x, int y)
    {
        return x + y;
    }

    [WebMethod]
    public int Subtraction(int x, int y)
    {
        return x - y;
    }

    [WebMethod]
    public int Multiplication(int x, int y)
    {
        return x * y;
    }

    [WebMethod]
    public int Division(int x, int y)
    {
        return x / y;
    }
}
