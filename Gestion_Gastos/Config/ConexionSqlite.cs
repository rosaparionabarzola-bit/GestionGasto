using Gestion_Gastos_.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Gastos_.Config
{
    public class ConexionSqlite
    {
        private const string CadenaConexion = "Data Source=gasto.db";

        public SqliteConnection ObtenerConexion()
        {
            return new SqliteConnection(CadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
