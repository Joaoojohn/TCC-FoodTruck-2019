using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class HoleriteDatabases
    {
        //Variavel de Escopo de Classe Entities

        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();



        //Inserir Item

        public void Inserir(Model.tb_holerite hole)
        {

            db.tb_holerite.Add(hole);

            db.SaveChanges();
        }


        //Consulta pelo nome do Produto

        public List<Model.tb_holerite> Consultar(decimal fun)
        {

            List<Model.tb_holerite> pro =
            db.tb_holerite.Where(t => t.vl_bruto == fun).ToList();

            return pro;
        }


        //Remover item

        public void Remover(int id)
        {

            Model.tb_holerite remover = db.tb_holerite.First(t => t.id_holerite == id);

            db.tb_holerite.Remove(remover);
            db.SaveChanges();

        }


        //Consulta pelo ID

        public List<Model.tb_holerite> ConsultarID(int ID)
        {

            List<Model.tb_holerite> turms =
            db.tb_holerite.Where(t => t.id_holerite == ID).ToList();

            return turms;
        }



        // Listar tudo


        public List<Model.tb_holerite> Listar()
        {


            List<Model.tb_holerite> turms = db.tb_holerite.ToList();

            return turms;
        }



        //Alterar Produto


        public void Alterar(Model.tb_holerite fun)
        {
            Model.tb_holerite Alterar = db.tb_holerite.First(t => t.id_holerite == fun.id_holerite);

            Alterar.vl_VTransporte= fun.vl_VTransporte;
            Alterar.vl_VRefeicao = fun.vl_VRefeicao;
            Alterar.vl_VAlimentacao = fun.vl_VAlimentacao;
            Alterar.vl_liquido = fun.vl_liquido;
            Alterar.vl_ir = fun.vl_ir;
            Alterar.vl_inss = fun.vl_inss;
            Alterar.vl_impostoR = fun.vl_impostoR;
            Alterar.vl_fgts = fun.vl_fgts;
            Alterar.vl_bruto = fun.vl_bruto;
            Alterar.hr_extra = fun.hr_extra;
        


            db.SaveChanges();
        }
    }
}
