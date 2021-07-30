using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Net;

/// <summary>
/// Summary description for stock
/// </summary>
/// 

public class StockUtility
{
    
    public static string GetResults()
    {
        WebClient wc = new WebClient();
        wc.Encoding = System.Text.Encoding.UTF8;
        string date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
        string data = wc.DownloadString($"https://www.twse.com.tw/exchangeReport/STOCK_DAY?response=json&date={date}&stockNo=2330");
        return data;
    }

}