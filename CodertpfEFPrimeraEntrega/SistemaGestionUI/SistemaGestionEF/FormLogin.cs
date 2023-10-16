using SistemaGestionEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaGestionUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtUsuario.TabStop = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Coder47870" && txtPassword.Text == "TpFinal")
            {
                FormPrincipal form = new FormPrincipal();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, porfavor vuelva a intentarlo");
                txtUsuario.Clear();
                txtPassword.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }
    }
}
