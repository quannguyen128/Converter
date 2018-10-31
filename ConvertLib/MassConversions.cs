using System;

namespace ConvertLib
{
     interface IMassConveter
    {
        decimal OuncetoPound(decimal WeightinOunces);
    }
    public class OuncetoPoundConverter : IMassConveter
    {
        public decimal OuncetoPound(decimal WeightinOunces)
        {
            
            return WeightinOunces * 0.0625m;
        }
    }

     interface IMassConveter1
    {
        decimal OuncetoGram(decimal WeightinOunces);
    }
    public class OuncetoGramConverter : IMassConveter1
    {
        public decimal OuncetoGram(decimal WeightinOunces)
        {
            
            return WeightinOunces * 28.34m;
        }
    }
     interface IMassConveter2
    {
        decimal KilogtoOunce(decimal WeightinKilograms);
    }
    public class KilogtoOunceConverter : IMassConveter2
    {
        public decimal KilogtoOunce(decimal WeightinKilograms)
        {
            
            return WeightinKilograms * 35.274m;
        }
    }
    interface IMassConveter3
    {
        decimal PoundtoGram(decimal WeightinPounds);
    }
    public class PoundtoGramConverter : IMassConveter3
    {
        public decimal PoundtoGram(decimal WeightinPounds)
        {
            
            return WeightinPounds * 453.44m;
        }
    }
}