using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pApp_Serv_WEB.Modelos;

namespace pApp_Serv_WEB.Clases
{
    public class clsCliente
    {
        //Comentario de PRUEBAA
        //Comentario de Prueba 2
        //comentario zara
        //comentario niultn
        DBVentaRopaEntities dbVentaRopa = new DBVentaRopaEntities();
        public tblCliente Cliente = new tblCliente();

        public tblCliente Consultar(string idCliente)
        {
            return dbVentaRopa.tblClientes.FirstOrDefault( x => x.idCliente == idCliente);
        }
    }
}
