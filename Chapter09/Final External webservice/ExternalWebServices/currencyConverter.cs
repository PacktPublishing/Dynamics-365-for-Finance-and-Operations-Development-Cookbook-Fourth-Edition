using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalWebServices.CurrencyConverterService;
using System.ServiceModel;

namespace ExternalWebServices
{
    public class currencyConverter
    {
        public string getCurrencyRate(String cur1, string cur2)
        {
            BasicHttpBinding    httpBinding = new BasicHttpBinding();
            EndpointAddress endPoint = new EndpointAddress(@"http://currencyconverter.kowabunga.net/converter.asmx");

            var soapClient = new ConverterSoapClient(httpBinding, endPoint);
            var usdToinr = soapClient.GetConversionRate(cur1.ToString(), cur2.ToString(),DateTime.Now);
            return usdToinr.ToString();

        }
    }
}
