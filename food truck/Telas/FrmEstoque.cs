using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_truck.telas
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();



            Databases.FornercedorDatabases business = new Databases.FornercedorDatabases();
            List<Model.tb_fornecedor> turams = business.Listar();

            cboForne.DisplayMember = nameof(Model.tb_fornecedor.nm_Fornecedor);
            cboForne.DataSource = turams;

            Databases.ProdutoDatabases bus = new Databases.ProdutoDatabases();
            List<Model.tb_produto> prod = bus.Listar();

            cboProduto.DisplayMember = nameof(Model.tb_produto.nm_produto);
            cboProduto.DataSource = prod;
        }

      

      

        private void txtProdAlter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto selecio = new Model.tb_produto();


                string nome = txtProdRemo.Text;

                selecio.nm_produto = nome;

                Databases.EstqueDatabases db = new Databases.EstqueDatabases();

                List<Model.tb_estoque> turams = db.ConsultarPorNome(nome);



                dgvConsu.DataSource = turams;
               

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                Business.EstoqueBusiness bus = new Business.EstoqueBusiness();
                List<Model.tb_estoque> lista = bus.Listar();

                dgvConsu.AutoGenerateColumns = false;
                dgvConsu.DataSource = lista;
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

       

      

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_estoque id = dgvConsu.CurrentRow.DataBoundItem as Model.tb_estoque;


                Business.EstoqueBusiness business = new Business.EstoqueBusiness();


                business.Remover(id);


                MessageBox.Show("Estoque deletado com Sucesso!");

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

      



        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Model.tb_estoque estoque = new Model.tb_estoque();
                Business.EstoqueBusiness bus = new Business.EstoqueBusiness();


                Model.tb_fornecedor f = cboForne.SelectedItem as Model.tb_fornecedor; 
                Model.tb_produto p = cboProduto.SelectedItem as Model.tb_produto;



                estoque.ds_produto = txtDescrição.Text;
                estoque.dt_Entrada = dtpEntra.Value;
                estoque.prc_custo = nudCusto.Value;
                estoque.prc_venda = nudVenda.Value;
                estoque.qtd_produto = Convert.ToInt32(nudUnidade.Value);
                estoque.dt_saida = dtpSai.Value;
                estoque.dt_validadeproduto = dtpVal.Value;
                estoque.prc_venda = nudVenda.Value;

                estoque.id_produto = p.id_produto;
                estoque.id_Fornecedor = f.id_fornecedor;

                bus.Inserir(estoque);


                MessageBox.Show("Estoque Inserido com Sucesso!");

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

                Model.tb_estoque estoque = dgvConsu.CurrentRow.DataBoundItem as Model.tb_estoque;

                Model.tb_fornecedor f = cboForne.SelectedItem as Model.tb_fornecedor;
                Model.tb_produto p = cboProduto.SelectedItem as Model.tb_produto;

                estoque.id_Fornecedor = f.id_fornecedor;
                estoque.id_produto = p.id_produto;

                estoque.ds_produto = txtDescrição.Text;
                estoque.dt_Entrada = dtpEntra.Value;
                estoque.prc_custo = nudCusto.Value;
                estoque.prc_venda = nudVenda.Value;
                estoque.qtd_produto = Convert.ToInt32(nudUnidade.Value);
                estoque.dt_saida = dtpSai.Value;
                estoque.dt_validadeproduto = dtpVal.Value;
                estoque.prc_venda = nudVenda.Value;
                


                Business.EstoqueBusiness bus = new Business.EstoqueBusiness();
                bus.Alterar(estoque);

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Business.EstoqueBusiness bus = new Business.EstoqueBusiness();
                List<Model.tb_estoque> lista = bus.Listar();

                dgvConsu.AutoGenerateColumns = false;
                dgvConsu.DataSource = lista;
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Model.tb_estoque id = dgvConsu.CurrentRow.DataBoundItem as Model.tb_estoque;


                Business.EstoqueBusiness business = new Business.EstoqueBusiness();


                business.Remover(id);


                MessageBox.Show("Estoque deletado com Sucesso!");

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

        private void dgvConsu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Model.tb_estoque alt = dgvConsu.CurrentRow.DataBoundItem as Model.tb_estoque;


            cboProduto.Text = alt.nm_produto;
            cboForne.Text = alt.nm_fornecedor;
            txtDescrição.Text = alt.ds_produto;
            dtpEntra.Value = Convert.ToDateTime(alt.dt_Entrada);
            dtpSai.Value = Convert.ToDateTime( alt.dt_saida);
            dtpVal.Value = Convert.ToDateTime(alt.dt_validadeproduto);
            nudCusto.Value = Convert.ToDecimal( alt.prc_custo);
            nudVenda.Value = Convert.ToDecimal(alt.prc_venda);
            nudUnidade.Value = Convert.ToDecimal(alt.qtd_produto);
            

         
        }

        private void txtProdRemo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto selecio = new Model.tb_produto();


                string nome = txtProdRemo.Text;

                selecio.nm_produto = nome;

                Databases.EstqueDatabases db = new Databases.EstqueDatabases();

                List<Model.tb_estoque> turams = db.ConsultarPorNome(nome);



                dgvConsu.DataSource = turams;


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

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                Business.EstoqueBusiness bus = new Business.EstoqueBusiness();
                List<Model.tb_estoque> lista = bus.Listar();

                dgvConsu.AutoGenerateColumns = false;
                dgvConsu.DataSource = lista;
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
                Model.tb_estoque id = dgvConsu.CurrentRow.DataBoundItem as Model.tb_estoque;


                Business.EstoqueBusiness business = new Business.EstoqueBusiness();


                business.Remover(id);


                MessageBox.Show("Estoque deletado com Sucesso!");

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

        private void txtIDFonecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.tb_produto p = cboProduto.SelectedItem as Model.tb_produto;
            if (p != null)
            {
                txtDescrição.Text = p.ds_produto;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.DesignPanelMenu telas = new Telas.DesignPanelMenu();
            telas.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Telas.DesignPanelMenu menu = new Telas.DesignPanelMenu();
                
            menu.Show();

            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtDescrição_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cboForne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudUnidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudCusto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

