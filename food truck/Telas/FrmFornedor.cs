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
    public partial class FrmFornedor : Form
    {
        public FrmFornedor()
        {
            InitializeComponent();
        }

        private void FrmFornedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Telas.DesignPanelMenu menu = new DesignPanelMenu();

            menu.Show();

            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Model.tb_fornecedor forne = new Model.tb_fornecedor();


                forne.nm_Fornecedor = txtNome.Text; 
                forne.nm_endereco = txtEnde.Text;
                forne.nm_cidade = txtCidade.Text;
                forne.nm_bairro = txtBairro.Text;
                forne.doc_CNPJ = txtCNPJ.Text;
                forne.dt_Contrato = dtpContra.Value;
                forne.tb_email = txtEmail.Text;
                forne.tp_pessoaFJ = cboTIpo.Text;
                forne.tl_celular = txtCell.Text;
                forne.tl_fixo = txtTEl.Text;



                Business.FornecedorBusiness bus = new Business.FornecedorBusiness();
                bus.Inserir(forne);

                MessageBox.Show("Fornecedor Cadastrado com Sucesso");

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
                Model.tb_fornecedor conta = dgvForne.CurrentRow.DataBoundItem as Model.tb_fornecedor;

                Business.FornecedorBusiness bus = new Business.FornecedorBusiness();
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_fornecedor conta = dgvForne.CurrentRow.DataBoundItem as Model.tb_fornecedor;

                Business.FornecedorBusiness bus = new Business.FornecedorBusiness();
                bus.Remover(conta);

                MessageBox.Show("Removido com Sucesso");

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Business.FornecedorBusiness bus = new Business.FornecedorBusiness();
                List<Model.tb_fornecedor> lista = bus.Listar();

                dgvForne.AutoGenerateColumns = false;
                dgvForne.DataSource = lista;
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

        private void txtForne_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Business.FornecedorBusiness despesasGastos = new Business.FornecedorBusiness();


                string nome = txtForne.Text;

                List<Model.tb_fornecedor> conta = despesasGastos.Consultar(nome);

                dgvForne.DataSource = conta;

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

        private void dgvForne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.FrmWhatsApp whatsApp = new FrmWhatsApp();

            whatsApp.Show();

            this.Hide();
        }
    }
}
