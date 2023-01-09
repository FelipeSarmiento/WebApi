using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Data
{
    public class Conexion
    {
        public static string rutaConexion = @"Server=tcp:server-felipe.database.windows.net,1433;Initial Catalog=sqlprueba;Persist Security Info=False;User ID=felipe;Password=Pipe0803;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
    }
}