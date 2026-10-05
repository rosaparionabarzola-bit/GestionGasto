using Gestion_Gastos_.Config;
using Gestion_Gastos_.Controllers;
using Gestion_Gastos_.DAO;
using Gestion_Gastos_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Gastos_.Views
{
    public partial class frmGastos : Form
    {
        ConexionSqlite conectaSqlite = new ConexionSqlite();
        private readonly GastoController gasController;

        public frmGastos()
        {
            InitializeComponent();

            gasController = new GastoController();
        }

        private void Categoria(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Alimentación");
            combo.Items.Add("Transporte");
            combo.Items.Add("Salud");
            combo.Items.Add("Educación");
            combo.Items.Add("Entretenimiento");
            combo.Items.Add("Vivienda");
            combo.Items.Add("Servicios");
            combo.Items.Add("Compras");
            combo.Items.Add("Otros");
        }

        private void MetodoPago(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Efectivo");
            combo.Items.Add("Tarjeta");
            combo.Items.Add("Transferencia");
            combo.Items.Add("Yape");
            combo.Items.Add("Plin");
            combo.Items.Add("Otro");
        }


        private void frmGastos_Load(object sender, EventArgs e)
        {
            Categoria(cbxCategoria);

            MetodoPago(cbxMetodoPago);


            CargarTablaGasto(dgvPanelTabla);


            if (conectaSqlite.ProbarConexion())
            {
                // MessageBox.Show("Conexion exitosa", "ÉXITO!");
                lblEstatus.Text = "Conectado a la BD";
                lblEstatus.ForeColor = Color.Green;

            }
            else
            {
                //MessageBox.Show("No se pudo conectar a la base de datos", "ALERTA");

                lblEstatus.Text = "No se tiene conexion a la BD";
                lblEstatus.ForeColor = Color.Red;
            }
        }

        // esto es para mostrar datos en la tabla
        private void CargarTablaGasto(DataGridView data)
        {
            data.DataSource = null;
            data.DataSource = gasController.ListarGasto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripcion no puede ser vacio", "Atencion");
                return;
            }

            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algun valor", "Atencion");
                return;
            }

            if (txtMonto.Value == 0)
            {
                MessageBox.Show("Debes ingresar algún monto", "Atencion");
                return;
            }

            if (cbxMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccciona", "Atencion");
                return;
            }


            // haces una instancia
            Gasto gasto = new Gasto
            {
                Descripcion = txtDescripcion.Text,
                Categoria = cbxCategoria.Text,
                Monto = decimal.Parse(txtMonto.Value.ToString()),
                Fecha = dtpFecha.Value,
                MetodoPago = cbxMetodoPago.Text


            };

            gasController.Registrar(gasto);

            CargarTablaGasto(dgvPanelTabla);

            MessageBox.Show("Datos registrados correctamente", "Correcto!");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPanelTabla.CurrentRow == null)
            {
                return;
            }

            int idGasto = Convert.ToInt32(dgvPanelTabla.CurrentRow.Cells["IdGasto"].Value);

            gasController.Eliminar(idGasto);

            CargarTablaGasto(dgvPanelTabla);

            MessageBox.Show("Dato elimininado correctamente", "Eliminado");
        }

        private void dgvPanelTabla_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPanelTabla.CurrentRow == null)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(
            "¿Desea editar datos de esta fila?",
            "¿Desea editar?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {


                DataGridViewRow fila = dgvPanelTabla.CurrentRow;

                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
                cbxCategoria.Text = fila.Cells["Categoria"].Value?.ToString();
                txtMonto.Value = Convert.ToDecimal(fila.Cells["Monto"].Value?.ToString());


                if (fila.Cells["Fecha"].Value != null)
                {
                    dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                }

                cbxMetodoPago.Text = fila.Cells["MetodoPago"].Value?.ToString();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();

            cbxCategoria.SelectedIndex = -1;
            cbxCategoria.Text = "";

            txtMonto.Value = 0;

            dtpFecha.Value = DateTime.Now;

            cbxMetodoPago.SelectedIndex = -1;
            cbxMetodoPago.Text = "";

            txtBuscar.Clear();
            dgvPanelTabla.ClearSelection();

            txtDescripcion.Focus();
            MessageBox.Show("Formulario limpiado correctamente", "Limpiado");
        }
    }

}
    


