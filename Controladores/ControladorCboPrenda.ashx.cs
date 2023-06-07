using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pApp_Serv_WEB.Clases;
using Newtonsoft.Json;

namespace pApp_Serv_WEB.Controladores
{
    /// <summary>
    /// Summary description for ControladorPrenda
    /// </summary>
    public class ControladorPrenda : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(LlenarComboPrenda());
        }

        private string LlenarComboPrenda()
        {
            clsPrenda Prenda = new clsPrenda();
            return JsonConvert.SerializeObject(Prenda.LlenarComboPrenda());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}