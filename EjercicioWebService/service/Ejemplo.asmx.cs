using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EjercicioWebService.service
{
    /// <summary>
    /// Descripción breve de Ejemplo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Ejemplo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public double SumarNumeros(double num1, double num2)
        {
            var resul = num1 + num2;
            return resul;
        }
        /**
         * Metodo ejemplo de un servicio en asmx donde se reciben 2 numeros tipo doble
         * 
         * */
        [WebMethod]
        public string SumarNumValidados(double num1,double num2)
        {
            string result = "";
            if (string.IsNullOrEmpty(num1.ToString()) || string.IsNullOrEmpty(num2.ToString()))
            {
                result = "Se debe de ingresar un numero para realizar la suma";
            }
            else
            {
                result = ("El resultado es: " + (num1 + num2).ToString());
            }

            return result;
        }

     
    }
}
