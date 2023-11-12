using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;

namespace QuakeHistory
{
    public partial class Form1
    {
        string apiUrl = "https://dev.narikakun.net/webapi/earthquake/last/%E9%9C%87%E6%BA%90%E3%83%BB%E9%9C%87%E5%BA%A6%E3%81%AB%E9%96%A2%E3%81%99%E3%82%8B%E6%83%85%E5%A0%B1.json";

        private string Last_eventid = "0";
        string areaName1;
        string areaName2;
        string areaName3;
        string areaName4;
        string areaName5;
        string areaName5p;
        string areaName6;
        string areaName6p;
        string areaName7;

        string Cityshindo1 = "";
        string Cityshindo2 = "";
        string Cityshindo3 = "";
        string Cityshindo4 = "";
        string Cityshindo5m = "";
        string Cityshindo5p = "";
        string Cityshindo6m = "";
        string Cityshindo6p = "";
        string Cityshindo7 = "";
        string CityshindoF = "";

        string Maxint;
        string Title;
        string HTitle;
        private string previousTitle = string.Empty;
        private string previousEventID = string.Empty;
        private string previousReport = string.Empty;
        string Tsunami;

        string url = "https://earthquake.tenki.jp/bousai/earthquake/center/";
        private async void QuinfoINtext()
        {

            using (var webClient = new WebClient())
            {
                try
                {
                    WebClient wc = new WebClient() { Encoding = Encoding.GetEncoding("UTF-8") };
                    string str = wc.DownloadString(apiUrl);
                    var Json = JObject.Parse(str);

                    string title = Json["Control"]["Title"].ToString();
                    HTitle = Json["Head"]["Title"].ToString();
                    string eventID = Json["Head"]["EventID"].ToString();
                    string report = Json["Control"]["DateTime"].ToString();

                    Last_eventid = Json["Head"]["EventID"].Value<string>();


                    // パースしたデータを使って、必要な情報にアクセスします
                    {
                        Title = title;
                        //緯度経度
                        string originTime = Json["Body"]["Earthquake"]["OriginTime"].Value<string>();
                        string reg_name = Json["Body"]["Earthquake"]["Hypocenter"]["Name"].Value<string>();
                        Last.Text = $"最後の{reg_name}での地震";


                        string qtime = null;
                        {
                            string s = Json["Body"]["Earthquake"]["OriginTime"].Value<string>();
                            string f = "yyyy-MM-dd HH:mm:ss";
                            DateTime dt2 = DateTime.ParseExact(s, f, null);
                            Ndate.Text = dt2.ToString("yyyy/MM/dd HH:mm") + "発生";
                        }
                        {
                            if (regionCodes.ContainsKey(reg_name))
                            {
                                string targetRegionCode = regionCodes[reg_name];
                                string Aurl = "https://earthquake.tenki.jp/bousai/earthquake/center/";
                                url =Aurl + targetRegionCode + "/";
                            }
                            else
                            {
                                Console.WriteLine("地域が見つかりませんでした。");
                            }
                        }

                        DateTime dt = DateTime.Now;
                        var tm = dt.AddSeconds(-2);
                        var time = tm.ToString("yyyyMMddHHmmss");

                        string startTimestring = originTime;
                        string endTimestring = time;

                        DateTime QstartTime = DateTime.ParseExact(startTimestring, "yyyy-MM-dd HH:mm:ss", null);
                        DateTime QendTime = DateTime.ParseExact(endTimestring, "yyyyMMddHHmmss", null);
                        TimeSpan differenceA = QendTime - QstartTime;

                        double seconds = differenceA.TotalSeconds;

                        if (seconds > 90)
                        {
                            {
                                var web = new HtmlWeb();
                                var doc = web.Load(url);

                                string xpath = "//td[@class='datetime']/a";
                                var dateNodes = doc.DocumentNode.SelectNodes(xpath);

                                if (dateNodes != null && dateNodes.Count >= 2)
                                {
                                    string dateAndTime = dateNodes[1].InnerText.Trim();

                                    Match match = Regex.Match(dateAndTime, @"(\d+年\d+月\d+日)(\d+時\d+分)");
                                    if (match.Success)
                                    {
                                        string datePart = match.Groups[1].Value;
                                        Date.Text = ("前回発生 : " + datePart);
                                    }

                                    {
                                        if (DateTime.TryParseExact(dateAndTime, "yyyy年MM月dd日HH時mm分頃", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime earthquakeDate))
                                        {
                                            {
                                                TimeSpan difference = DateTime.Now.Date - earthquakeDate.Date;
                                                int daysDifference = difference.Days;

                                                Day.Text = ("" + daysDifference);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            {

                                var web = new HtmlWeb();
                                var doc = web.Load(url);

                                string xpath = "//td[@class='datetime']/a";
                                var dateNode = doc.DocumentNode.SelectSingleNode(xpath);

                                if (dateNode != null)
                                {
                                    string dateAndTime = dateNode.InnerText.Trim();
                                    Match match = Regex.Match(dateAndTime, @"(\d+年\d+月\d+日)(\d+時\d+分)");
                                    if (match.Success)
                                    {
                                        string datePart = match.Groups[1].Value;
                                        Date.Text = ("前回発生 : " + datePart);
                                    }

                                    {
                                        if (DateTime.TryParseExact(dateAndTime, "yyyy年MM月dd日HH時mm分頃", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime earthquakeDate))
                                        {
                                            {
                                                TimeSpan difference = DateTime.Now.Date - earthquakeDate.Date;
                                                int daysDifference = difference.Days;

                                                Day.Text = ("" + daysDifference);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        previousEventID = eventID;
                        previousTitle = title;
                        previousReport = report;
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

    }
}
