using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_truck.Telas
{
    public partial class FrmFinanceiro : Form
    {
        public FrmFinanceiro()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmFinanceiro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //dgvConsu.Width = 344;
            //dgvConsu.Height = 257;
            //pictureBox3.Visible = false;
            //pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //dgvConsu.Width = 344;
            //dgvConsu.Height = 35;
            //pictureBox3.Visible = true;
            //pictureBox4.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.DesignPanelMenu menu = new Telas.DesignPanelMenu();

            menu.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Business.DespesasGastosBusiness bus = new Business.DespesasGastosBusiness();
                List<Model.tb_conta> lista = bus.Listar();

                dvgConta.AutoGenerateColumns = false;
                dvgConta.DataSource = lista;
            }


            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                Model.tb_conta conta = dvgConta.CurrentRow.DataBoundItem as Model.tb_conta;


                //conta.dt_pagamento = dtpData.Value; ;
                //conta.dt_vencimento = dtpVenci.Value;
                //conta.nm_conta = txtNome.Text;
                //conta.tp_conta = txtTipo.Text;
                //conta.vl_conta = Convert.ToInt32(txtValor.Text);
               
               



                Business.DespesasGastosBusiness bus = new Business.DespesasGastosBusiness();
                bus.Alterar(conta);

                MessageBox.Show("Alterado com Sucesso");

            }


            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Model.tb_conta conta = new Model.tb_conta();


                conta.dt_pagamento = dtpData.Value; ;
                conta.dt_vencimento = dtpVenci.Value;
                conta.nm_conta = txtNome.Text;
                conta.tp_conta = txtTipo.Text;
                conta.vl_conta = Convert.ToInt32(txtValor.Text);





                Business.DespesasGastosBusiness bus = new Business.DespesasGastosBusiness();
                bus.Inserir(conta);

                MessageBox.Show("Conta cadastrada com Sucesso");

            }


            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_conta id = dvgConta.CurrentRow.DataBoundItem as Model.tb_conta;


                Business.DespesasGastosBusiness business = new Business.DespesasGastosBusiness();


                business.Remover(id);


                MessageBox.Show("Conta deletada com Sucesso!");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }
        }

        private void txtProdRemo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Business.DespesasGastosBusiness despesasGastos = new Business.DespesasGastosBusiness();


                string nome = txtNome.Text;

                List<Model.tb_conta> conta = despesasGastos.Consultar(nome);

                dvgConta.DataSource = conta;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro desconhecido. Tente novamente.");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
