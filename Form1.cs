using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wLibreria
{
    public partial class Form1 : Form
    {
        public bool ValidarFormulario { get; private set; }

        public Form1()
        {
            InitializeComponent();
            IniciarFormulario();
        }
        private void IniciarFormulario()
        {
            try
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtCedula.Text = "";
                txtDireccion.Text = "";
                txtEdad.Text = "";
                txtEmail.Text = "";
                txtValorLibro.Text = "";
                txtTelefono.Text = "";

                #region[Llenar Combo Libros]
                cmbNombreLIbro.Items.Clear();
                cmbNombreLIbro.Items.Add("-------");
                cmbNombreLIbro.Items.Add("Harry Potter");
                cmbNombreLIbro.Items.Add(" Crepúsculo – La saga");
                cmbNombreLIbro.Items.Add("Lo que el viento se llevó");
                cmbNombreLIbro.Items.Add("La Culpa Es De Vaca");
                cmbNombreLIbro.Items.Add("Citas del Presidente Mao Tse - Tung");
                cmbNombreLIbro.Items.Add("El arte de la guerra");
                cmbNombreLIbro.Items.Add("El último virrey");
                cmbNombreLIbro.Items.Add("Colombia mi abuelo y yo");
                cmbNombreLIbro.Items.Add("Cien años de soledad");
                cmbNombreLIbro.Items.Add("El amor en los tiempos del cólera");
                cmbNombreLIbro.Items.Add("Crónica de una muerte anunciada");
                cmbNombreLIbro.Items.Add("Del amor y otros demonios");
                cmbNombreLIbro.Items.Add("La hojarasca");
                cmbNombreLIbro.Items.Add("Cincuenta sombras de Grey");
                cmbNombreLIbro.Items.Add("Grey ");
                #endregion

                #region[Llenar Combo Sexo]
                cmbSexo.Items.Clear();
                cmbSexo.Items.Add("Masculino");
                cmbSexo.Items.Add("Femenino");
                cmbSexo.Items.Add("Otro");
                #endregion
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarEsto_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario)
            {
                MessageBox.Show(
                     "Nombre:  \t" + txtNombre.Text + "\r\n" +
                     "Apellido: \t" + txtApellido.Text + "\r\n" +
                     "Informacion agregada");
            }
        }
    }
}
