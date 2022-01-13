using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRR.BL
{
    public class Week
    {
        public Week()
        {

        }

        public Week(int weekId)
        {
            WeekId = weekId;
        }

        public int WeekId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DateTime> days { get; private set; }

        public bool Validate()
        {
            bool isValid = false;
            var timeDiff = (EndDate - StartDate).Days;
            Console.WriteLine(timeDiff.ToString());
            if (timeDiff == 6)
                isValid = true;
            return isValid;

        }
        public void GenerateDates()
        {
            if (Validate())
            {
                days = new List<DateTime>();
                for (int i = 0; i < 7; i++)
                {
                    days.Add(StartDate.AddDays(i));
                }
            }
            else
            {
                days = null;
                // TODO: Log error
            }
        }
    }
}
