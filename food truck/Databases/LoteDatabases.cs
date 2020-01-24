using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class LoteDatabases
    {
        ////Variavel de Escopo de Classe Entities 

        //Model.falcomtccEntities21 db = new Model.falcomtccEntities21();



        ////Inserir Item

        //public void Inserir(Model.l)
        //{

        //    db.lote.Add(produtos);

        //    db.SaveChanges();
        //}


        ////Consulta pelo nome do Produto

        //public List<Model.tb_produtos> Consultar(string produto)
        //{

        //    List<Model.tb_produtos> pro =
        //    db.tb_produtos.Where(t => t.nm_Produto == produto).ToList();

        //    return pro;
        //}


        ////Remover item

        //public void Remover(int id)
        //{

        //    Model.tb_produtos remover = db.tb_produtos.First(t => t.id_Produto == id);

        //    db.tb_produtos.Remove(remover);
        //    db.SaveChanges();

        //}


        ////Consulta pelo ID

        //public List<Model.tb_produtos> ConsultarID(int ID)
        //{

        //    List<Model.tb_produtos> turms =
        //    db.tb_produtos.Where(t => t.id_Produto == ID).ToList();

        //    return turms;
        //}



        //// Listar tudo


        //public List<Model.tb_produtos> Listar()
        //{


        //    List<Model.tb_produtos> turms = db.tb_produtos.ToList();

        //    return turms;
        //}



        ////Alterar Produto


        //public void Alterar(Model.tb_produtos produto)
        //{
        //    Model.tb_produtos Alterar = db.lote.First(t => t.id_Produto == produto.id_Produto);

        //    Alterar.nm_Produto = produto.nm_Produto;
        //    Alterar.prc_custo = produto.prc_custo;
        //    Alterar.prc_venda = produto.prc_venda;
        //    Alterar.qtd_produto = produto.qtd_produto;
        //    Alterar.tb_marca = produto.tb_marca;

        //    db.SaveChanges();
        //}
    }
}
