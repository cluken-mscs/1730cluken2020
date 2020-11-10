using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace cluken2h1
{
    public class Ex2hCalculations
    {
        public static object TextBox11 { get; private set; }

        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;

        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date;
            TimeSpan timeTillDue;
            try
            {
                date = DateTime.Parse(strDateA);
                date = DateTime.Parse(strDateB);
                timeTillDue = DateTime.Parse(strDateA) - DateTime.Parse(strDateB);
                result = timeTillDue.TotalDays.ToString() + " days";
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            string status = "On time";
            DateTime date;
            TimeSpan timeTillDue;
            try
            {
                date = DateTime.Parse(strDateA);
                date = DateTime.Parse(strDateB);
                timeTillDue = DateTime.Parse(strDateA) - DateTime.Parse(strDateB);
                if (DateTime.Parse(strDateA) > DateTime.Parse(strDateB))
                    return timeTillDue.TotalDays.ToString() + " days past due";
                else
                    return status.ToString();
            }
            catch { }

            return result;
        }
        public static string StringCalc01 (string s)
        {
            s = s.Trim();
            string result = "Invalid Input";
            try
            {
                s = s.Remove(0, 1);
                s = s.Insert(0, "cr");
                return s;
            }
            catch { }
            return result;  
        }
        public static string StringCalc02(string s)
        {
            s = s.Trim();
            string result = "Invalid Input";
            try
            {
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
                return s;
            }
            catch { }
            return result;

        }
        public static string StringCalc03(string s)
        {
            s = s.Trim();
            string result = "Invalid Input";
            try
            {
                s = s.Substring(2, +4).ToUpper();
                return s;
            }
            catch { }
            return result;
        }
        public static string StringCalc04(string s)
        {
                s = s.Trim();
                s = s.PadLeft(10, '*');
                return s;
        }
        public static string StringCalc05(string s)
        {
            s = s.Trim();
            string result = "Invalid Input";
            try
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace("-", "");
                s = s.Replace(" ", "");
                return s;
            }
            catch { }
            return result;
        }
        public static string StringCalc06(string s)
        {
                s = s.Trim();
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace("-", "");
                s = s.Replace(" ", "");
                if (s.Length == 7)
                {
                    s = s.Insert(3, ".");
                    return s;
                }
                if (s.Length == 10)
                {
                    s = s.Insert(3, ".");
                    s = s.Insert(7, ".");
                    return s;
                }
                else return "Invalid Input";
            }
        }
        public static string StringCalc07(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            if (s.Contains("pioneer"))
            {
                s = "Found";
                return s;
            }
            else s = "Not Found";
            return s;
            }
        public static string StringCalc08(string s)
        {
            s = s.Trim();
            if (s.Contains(", "))
            {
                int cityIndex = s.IndexOf(", ") + 2;
                s = s.Substring(cityIndex);
            }
            else return "Invalid Input";
            return s;
        }
        public static string StringCalc09(string s)
        {
            s = s.Trim();
            if (s.Contains(" "))
            {
                int zipIndex = s.LastIndexOf(" ") + 1;
                s = s.Substring(zipIndex);
            }
            else return "Invalid Input";
            return s;
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append((s1) + ", ");
            sb.Append((s2) + ", ");
            sb.Append(s3);
            return sb.ToString();
        }
    }
}