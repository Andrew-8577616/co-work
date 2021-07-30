<%@ WebService Language="C#" Class="WebService" %>

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Net;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    //[WebMethod]
    //public Result test()
    //{

    //    using (WebClient wc = new WebClient())
    //    {
    //        var url = "http://www.twse.com.tw/exchangeReport/STOCK_DAY?response=json&date=20210714&stockNo=2330";
    //        var json = wc.DownloadString("url");
    //    }
    //    return;
    //}

}