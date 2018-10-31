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
    public class ConverterController : Controller
    {
        public decimal CtoF(string type, string unitvalue)
        {
            decimal val = Convert.ToDecimal(unitvalue);

            // return $"{type} and {unitvalue}";
            MyTempetureConverter convert = new MyTempetureConverter();
            decimal result = convert.CelciustoFahrenheit(val);
            return result;
        }

        public decimal Ctok(string type, string unitvalue)
        {
             decimal value = Convert.ToDecimal(unitvalue);
             CtoKConverter c = new CtoKConverter();
             decimal result = c.CelciustoKelvin(value);
             return result;
        }

        
        public decimal FtoC(string type, string unitvalue)
        {
             decimal v = Convert.ToDecimal(unitvalue);
             FtoCConverter cc = new FtoCConverter();
             decimal result = cc.FahrenheittoCelcius(v);
             return result;
        }

        public decimal FtoK(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            FtoKConverter cc = new FtoKConverter();
            decimal result = cc.FahrenheittoKelvin(v);
            return result;
        }

        public decimal MtoF(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            MeterstoFeetConverter m = new MeterstoFeetConverter();
            decimal result = m.MeterstoFeet(v);
            return result;
        }

        public decimal MtoY(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            MeterstoYardsConverter m = new MeterstoYardsConverter();
            decimal result = m.MeterstoYards(v);
            return result;
        }
        public decimal FtoM(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            FeettoMetersConverter m = new FeettoMetersConverter();
            decimal result = m.FeettoMeters(v);
            return result;

        }

        public decimal FtoY(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            FeettoYardsConverter m = new FeettoYardsConverter();
            decimal result = m.FeettoYards(v);
            return result;

        }

        public decimal OtoP(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            OuncetoPoundConverter o = new OuncetoPoundConverter();
            decimal result = o.OuncetoPound(v);
            return result;
        }
        
        public decimal OtoG(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            OuncetoGramConverter o = new OuncetoGramConverter();
            decimal result = o.OuncetoGram(v);
            return result;
        }
         public decimal KgtoO(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            KilogtoOunceConverter o = new KilogtoOunceConverter();
            decimal result = o.KilogtoOunce(v);
            return result;
        }
         public decimal PtoG(string type, string unitvalue)
        {
            decimal v = Convert.ToDecimal(unitvalue);
            PoundtoGramConverter o = new PoundtoGramConverter();
            decimal result = o.PoundtoGram(v);
            return result;
        } 

    }
}