using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cluken3c1
{
    public class Ex3cCalculations
    {

        public static string Calc0(int index)
        {
            string result = "Invalid Index";
            string status = "Invalid Index";
            try
            {
                string[] days = new string[] { "", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                string day = days[index];

                if (index >= 1 && index < 8)

                    return day.ToString();

                else return status.ToString();
            }
            catch { }
            return result;
        }

        public static string Calc1(string search)
        {
            search = search.Trim();
            search = search.ToUpper();
            string result = "Invalid Input";
            try
            {
                string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
                string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };

                int index = Array.IndexOf(days, search);
                string day = hours[index];

                return day.ToString();
            }
            catch { }
            return result;
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int digit in numbers)
                sum += digit;
            return sum;
        }
        public static double Calc3(double[] numbers, int digit)
        {
            double sum = 0.0;
            int i = 0;
            if (digit > 0 && digit <= numbers.GetLength(0))
            {
                for (i = 0; i < digit; i++)
                    sum += numbers[i];
                return sum;
            }
            else return 0.0;
        }
        public static double Calc5(double[] numbers)
        {
            return 0.0;
        }

        public static double[] Calc6(double[] numbers)
        {
            return new double[10];
        }
    }
}
