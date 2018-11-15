using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC.Models;
using ConvertLib;

namespace UnitConverterMVC.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Temp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ConvertTemp(ConverterViewModel model)
        {
            switch (model.ConversionType)
            {
                case "CtoF":
                var CtoF = new MyTempetureConverter();
                model.ConvertedValue = CtoF.CelciustoFahrenheit(model.ValuetoConvert);
                break;
                case "CtoK":
                var CtoK = new CtoKConverter();
                model.ConvertedValue = CtoK.CelciustoKelvin(model.ValuetoConvert);
                break;
                case "FtoC":
                var FtoC = new FtoCConverter();
                model.ConvertedValue = FtoC.FahrenheittoCelcius(model.ValuetoConvert);
                break;
                case "FtoK":
                var FtoK = new FtoKConverter();
                model.ConvertedValue = FtoK.FahrenheittoKelvin(model.ValuetoConvert);
                break;
                default:
                break;
                
            }
            return View(model);
        }
          public IActionResult Length()
        {
            return View();
        }
        [HttpPost]
         public IActionResult ConvertLength(ConverterViewModel model)
        {
            switch (model.ConversionType)
            {
                case "MtoF":
                var MtoF = new MeterstoFeetConverter();
                model.ConvertedValue = MtoF.MeterstoFeet(model.ValuetoConvert);
                break;
                case "MtoY":
                var MtoY = new MeterstoYardsConverter();
                model.ConvertedValue = MtoY.MeterstoYards(model.ValuetoConvert);
                break;
                case "FtoM":
                var FtoM = new FeettoMetersConverter();
                model.ConvertedValue = FtoM.FeettoMeters(model.ValuetoConvert);
                break;
                case "FtoY":
                var FtoY = new FeettoYardsConverter();
                model.ConvertedValue = FtoY.FeettoYards(model.ValuetoConvert);
                break;
                default: 
                break;
                
            }
            return View(model);
        }

          public IActionResult Mass()
        {
            return View();
        }
        [HttpPost]
         public IActionResult ConvertMass(ConverterViewModel model) //Create a convertwhatever cshtml
        {
            switch (model.ConversionType)
            {
                case "OtoP":
                var OtoP = new OuncetoPoundConverter();
                model.ConvertedValue = OtoP.OuncetoPound(model.ValuetoConvert);
                break;
                case "OtoG":
                var OtoG = new OuncetoGramConverter();
                model.ConvertedValue = OtoG.OuncetoGram(model.ValuetoConvert);
                break;
                case "KtoO":
                var KtoO = new KilogtoOunceConverter();
                model.ConvertedValue = KtoO.KilogtoOunce(model.ValuetoConvert);
                break;
                case "PtoG":
                var PtoG = new PoundtoGramConverter();
                model.ConvertedValue = PtoG.PoundtoGram(model.ValuetoConvert);
                break;
                default: 
                break;
                
            }
            return View(model);
        }
       
    }
}
