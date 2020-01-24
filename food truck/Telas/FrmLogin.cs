using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_truck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usu = txtFuncionario.Text;
            string senha = txtSenha.Text;
            if (usu == "admin" && senha == "1234")
            {
                Telas.DesignPanelMenu menu = new Telas.DesignPanelMenu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou Senha icorretos. Tente novamente");
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
