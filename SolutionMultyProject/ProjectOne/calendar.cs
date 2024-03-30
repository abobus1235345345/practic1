using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOne
{
    internal class calendar
    {
        public static void Main()
        {
            DateTime now = GetCurrentDate();
            MessageBox.Show($"Today's date is {now}");
            Console.ReadLine();
        }

        static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}
