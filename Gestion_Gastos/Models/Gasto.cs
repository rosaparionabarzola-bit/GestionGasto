using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Gastos_.Models
{
    public class Gasto
    {
        public int IdGasto { get; set; }

        public string Descripcion { get; set; }

        public string Categoria { get; set; }

        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; }

        public string MetodoPago { get; set; }
    }
}
