using Gestion_Gastos_.DAO;
using Gestion_Gastos_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Gastos_.Controllers
{
    public class GastoController
    {
        private readonly GastoDAO gasDAO;

        public GastoController()
        {
            gasDAO = new GastoDAO();
            gasDAO.CrearTabla();
        }

        public void Registrar(Gasto gasto)
        {
            gasDAO.InsertarGasto(gasto);
        }

        public void Actualizar(Gasto gasto)
        {
            gasDAO.Actualizar(gasto);
        }

        public List<Gasto> ListarGasto()
        {
            return gasDAO.Lista();
        }

        public void Eliminar(int id)
        {
            gasDAO.Eliminar(id);
        }
    }

}

