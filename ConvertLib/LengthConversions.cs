using System;

namespace ConvertLib
{
     interface ILengthConveter
    {
        decimal MeterstoFeet(decimal LengthinMeters);
    }
    public class MeterstoFeetConverter : ILengthConveter
    {
        public decimal MeterstoFeet (decimal LengthinMeters)
        {
            
            return LengthinMeters * 3.2808m;
        }
    }
     interface ILengthConveter1
    {
        decimal MeterstoYards(decimal LengthinMeters);
    }
    public class MeterstoYardsConverter : ILengthConveter1
    {
        public decimal MeterstoYards (decimal LengthinMeters)
        {
            
            return LengthinMeters * 1.09361m;
        }
    }
    interface ILengthConveter2
    {
        decimal FeettoMeters(decimal LengthinFeet);
    }
    public class FeettoMetersConverter : ILengthConveter2
    {
        public decimal FeettoMeters (decimal LengthinFeet)
        {
            
            return LengthinFeet * 0.3048m;
        }
    }

    interface ILengthConveter3
    {
        decimal FeettoYards(decimal LengthinFeet);
    }
    public class FeettoYardsConverter : ILengthConveter3
    {
        public decimal FeettoYards(decimal LengthinFeet)
        {
            
            return LengthinFeet * 0.333333m;
        }
    }
}