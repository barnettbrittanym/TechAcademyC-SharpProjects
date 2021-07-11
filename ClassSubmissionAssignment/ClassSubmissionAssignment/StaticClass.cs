using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    //Creating a public static class
    public static class Conversions
    {
        //Creating a public static method
        public static double CelsiusToFahrenheit(string tempC)
        {
            double C = Double.Parse(tempC);

            double F = (C * 9 / 5) + 32;

            return F;
        }
    }
}
