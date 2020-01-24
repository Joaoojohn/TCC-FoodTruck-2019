using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class EstqueDatabases
    {
        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();

        public void Inserir(Model.tb_estoque estoque)
        {
            db.tb_estoque.Add(estoque);
            db.SaveChanges();

        }

        public List<Model.tb_estoque> Consultar()
        {
            List<Model.tb_estoque> Consultar = db.tb_estoque.ToList();
            return Consultar;
        }

        public List<Model.tb_estoque> ConsultarPorProduto(int id)
        {
            List<Model.tb_estoque> Consultar = db.tb_estoque.Where(t => t.id_produto==id).ToList();
            return Consultar;
        }

        public List<Model.tb_estoque> ConsultarPorNome(string nome)
        {
            List<Model.tb_estoque> Consultar = db.tb_estoque.Where(t => t.tb_produto.nm_produto.Contains(nome)).ToList();
            return Consultar;
        }


        public void Alterar(Model.tb_estoque estoque)
        {
            Model.tb_estoque alterar = db.tb_estoque.First(t => t.id_Estoque == estoque.id_Estoque);



            alterar.id_produto = estoque.id_produto;
            alterar.id_Fornecedor = estoque.id_Fornecedor;
            alterar.prc_custo = estoque.prc_custo;
            alterar.prc_venda = estoque.prc_venda;
            alterar.qtd_produto = estoque.qtd_produto;
            alterar.ds_produto = estoque.ds_produto;
            alterar.dt_Entrada = estoque.dt_Entrada;
            alterar.dt_saida = estoque.dt_saida;
            alterar.dt_validadeproduto = estoque.dt_validadeproduto;

            db.SaveChanges();


        }

        public void remover(Model.tb_estoque id)
        {
            Model.tb_estoque remover = db.tb_estoque.First(t => t.id_Estoque == id.id_Estoque);

            db.tb_estoque.Remove(remover);
            db.SaveChanges();
        }

        public void AlterarTeste(Model.tb_estoque estoque)
        {
            Model.falcomtccEntities2 db = new Model.falcomtccEntities2();
            Model.tb_estoque alt = db.tb_estoque.First(t => t.id_Estoque == estoque.id_Estoque);

            alt.ds_produto = estoque.ds_produto;
            alt.dt_Entrada = estoque.dt_Entrada;
            alt.dt_saida = estoque.dt_saida;
            alt.dt_validadeproduto = estoque.dt_validadeproduto;
           

        }

      
    }
}
