using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MostrandoBitacora)
            {
                MessageBox.Show("Cambie a la vista de Empleados para realizar esta acción");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre_completo"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["puesto"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["departamento"].Value.ToString();
                idEmpleado = dataGridView1.CurrentRow.Cells["codigo_empleado"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
