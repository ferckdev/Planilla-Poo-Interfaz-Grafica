using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("rojo");
            cboColorFavorito.Items.Add("verde");
            cboColorFavorito.Items.Add("negro");
            cboColorFavorito.Items.Add("azul");


        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + " su color es " + colorFavorito + ", su numero es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha de Nacimiento: " + fecha + "," + mensaje );

        }

        private void ckbChocolate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbxTipo_Enter(object sender, EventArgs e)
        {

        }

        private void cboColorFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
