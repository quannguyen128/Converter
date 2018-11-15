using System;

namespace UnitConverterMVC.Models
{
    public class ConverterViewModel
    {
        public decimal ValuetoConvert {get; set; }
        public string ConversionType {get; set; }
        public decimal ConvertedValue {get; set;}
    
    }
}