using System;

namespace ConvertLib
{
    interface ITempetureConveter
    {
        decimal CelciustoFahrenheit(decimal TempinCelcius);
    }
    public class MyTempetureConverter : ITempetureConveter
    {
        public decimal CelciustoFahrenheit (decimal TempinCelcius)
        {
            // F = C (9/5) + 32
            return TempinCelcius * (9m/5m) + 32;
        }
    }
    //______________________________________________________________________________________________________

    interface ITempetureConverter1
    {
        decimal CelciustoKelvin(decimal TempinKelvin);
    }
    public class CtoKConverter : ITempetureConverter1
    {
        public decimal CelciustoKelvin(decimal TempinKelvin)
        {
            return TempinKelvin + 273.15m;
        }
    }
    //__________________________________________________________________________________________________
        interface ITempetureConveter2
    {
        decimal FahrenheittoCelcius(decimal TempinFahrenheit);
    }
    public class FtoCConverter : ITempetureConveter2
    {
        public decimal FahrenheittoCelcius(decimal TempinFahrenheit)
        {
            // F = C (9/5) + 32
            return (TempinFahrenheit - 32) * (5m/9m);
        }
    }

        interface ITempetureConveter3
    {
        decimal FahrenheittoKelvin(decimal TempinFahrenheit);
    }
    public class FtoKConverter : ITempetureConveter3
    {
        public decimal FahrenheittoKelvin(decimal TempinFahrenheit)
        {
            // F = C (9/5) + 32
            return (TempinFahrenheit - 32) * (5m/9m) + 273.15m;
        }
    }

    
    
    
}
