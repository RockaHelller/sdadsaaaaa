using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics.Models
{
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double temp)
        {
            Degree = temp;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
}
