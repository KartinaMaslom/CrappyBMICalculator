using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class LabRat
    {
        public DateTime Birthdate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public DateTime stringToDateConverter(string userInputDate)
        {
            DateTime correctDate;
            
            bool confirmation = DateTime.TryParse(userInputDate, out correctDate);
            if (confirmation)
                return correctDate;
            else
                return DateTime.MinValue;
        }
        public double stringToDoubleConverter(string userInputDouble)
        {
            double correctDouble;

            bool confirmation = Double.TryParse(userInputDouble, out correctDouble);
            if (confirmation && correctDouble > 0)
                return correctDouble;
            else
                return Double.MinValue;
        }

    }
}
