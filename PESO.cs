using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tallernet
{
    public partial class PESO : Form
    {
        TotalKg Peso = new TotalKg();
        public PESO()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            string dato1;
            if(CbbMedida.SelectedItem =="" || TxtKilogramos.Text=="")
            {
                MessageBox.Show("Debe llenar todos los campos", "MENSAJE DE VALIDACION DE DATOS ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LblResultado.Visible =false;
                BtnLimpiar.Visible = false;
                BtnMenu.Visible = false;
                BtnSalir.Visible = false;
            }
            else
            {
                dato1 =(Convert.ToString(CbbMedida.SelectedItem));
            Peso.setKilogramos(Convert.ToDouble(TxtKilogramos.Text));
            Peso.realizarConversion(dato1);

            LblResultado.Text = Convert.ToString(Peso.calcularTotalConversion());

            LblResultado.Visible = true;
            BtnLimpiar.Visible = true;
            BtnMenu.Visible = true;
            BtnSalir.Visible = true;
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblResultado.Visible = false;
            LblResultado.Text = "";
            TxtKilogramos.Text ="";
            TxtKilogramos.Focus();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form1 MEnupp = new Form1();
            MEnupp.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
