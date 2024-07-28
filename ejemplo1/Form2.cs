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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbChocolate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtFerrarri_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechadeNacimiento.Value;
            string Velocidad = ckbChocolate.Checked == true ? " Le gusta la Velocidad" : " Odia la Velocidad ";

            string tipoAutos;
            if (rbtFerrarri.Checked)
                tipoAutos = "Ferrarri";
            else if (rbtLamborgini.Checked)
                tipoAutos = "Lamborgini";
            else tipoAutos = "Porchee";

            string ColorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numFavorito.Value.ToString();

            string mensaje = Velocidad + ", su auto favorito es " + tipoAutos + " Su color favorito es: " + ColorFavorito + " su numero favorito es: " + numeroFavorito;
            MessageBox.Show(" Su Nombre es: " + nombre + " Nacio en: " + fecha  + mensaje);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemen = txtNombre.Text;
            lwElementos.Items.Add(elemen);

        }
    }
}
