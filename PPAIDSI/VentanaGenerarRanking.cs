using PPAIDSI.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAIDSI
{
    public partial class VentanaGenerarRanking : Form
    {
        ControladorGenerarReporte _controlador;

        public VentanaGenerarRanking()
        {
            InitializeComponent();
            _controlador = new ControladorGenerarReporte(this);
            seleccionarGenerarRanking();
        }

        private void seleccionarGenerarRanking()
        {
            habilitarVentana();
        }

        public void habilitarVentana()
        {
            _controlador.generarRanking();
        }

        public void solicitarFechaDesdeHasta()
        {
            grbFechas.Enabled = true;
        }

        public void solicitarTipoReseña()
        {
            grbTipoRes.Enabled = true;
            grbFechas.Enabled = false;
        }

        public void solicitarFormaVisualizacion()
        {
            grbVisualizacion.Enabled = true;
            grbTipoRes.Enabled = false;
        }

        public void solicitarConfirmacion()
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar sus selecciones?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Confirmacion Exitosa.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _controlador.tomarConfirmacion();
            }
        }

        public void SeleccionarFechaDesdeHasta(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            _controlador.TomarFechaDesdeHasta(desde, hasta);
        }

        public void SeleccionarTipoResena(object sender, EventArgs e)
        {
            if (rbtnSommelier.Checked == true)
            {
                _controlador.tomarSeleccionSommelier();
            }

        }

        public void seleccionarFormaVisualizacion(object sender, EventArgs e)
        {
            if (rbtnExcel.Checked)
            {
                _controlador.TomarSeleccionExcel();
            }
        }


        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarExcel()
        {
            var process = Process.Start(new ProcessStartInfo("RankingVinos.xlsx") { UseShellExecute = true });

            if (process != null)
            {
                process.WaitForExit();
            }

            Environment.Exit(0);
        }
    }
}
