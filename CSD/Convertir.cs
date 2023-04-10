using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioWebServices.CSD
{
    public class Convertir
    {
        public string numeroaletras(ulong Numero)
        {
            string Respuesta;
            ConversionMoneda.NumberConversionSoapTypeClient oConvNum = new ConversionMoneda.NumberConversionSoapTypeClient("NumberConversionSoap");
            Respuesta = oConvNum.NumberToWords(Numero);
            
            return Respuesta;
        }
        public string numeroaDolares(decimal Numero)
        {
            string Respuesta;
            ConversionMoneda.NumberConversionSoapTypeClient oConvNum = new ConversionMoneda.NumberConversionSoapTypeClient("NumberConversionSoap");
            Respuesta = oConvNum.NumberToDollars(Numero);

            return Respuesta;
        }
    }
}