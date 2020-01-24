using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class FuncionarioDatabases
    {
       //Variavel de Escopo de Classe Entities

        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();



        //Inserir Item

        public void Inserir(Model.tb_funcinario funcinario)
        {

            db.tb_funcinario.Add(funcinario);

            db.SaveChanges();
        }


        //Consulta pelo nome do Produto

        public List<Model.tb_funcinario> Consultar(string fun)
        {

            List<Model.tb_funcinario> pro =
            db.tb_funcinario.Where(t => t.nm_funcionario == fun).ToList();

            return pro;
        }


        //Remover item

        public void Remover(int id)
        {

            Model.tb_funcinario remover = db.tb_funcinario.First(t => t.id_funcionario == id);

            db.tb_funcinario.Remove(remover);
            db.SaveChanges();

        }


        //Consulta pelo ID

        public List<Model.tb_funcinario> ConsultarID(int ID)
        {

            List<Model.tb_funcinario> turms =
            db.tb_funcinario.Where(t => t.id_funcionario == ID).ToList();

            return turms;
        }



        // Listar tudo


        public List<Model.tb_funcinario> Listar()
        {


            List<Model.tb_funcinario> turms = db.tb_funcinario.ToList();

            return turms;
        }



        //Alterar Produto


        public void Alterar(Model.tb_funcinario fun)
        {
            Model.tb_funcinario Alterar = db.tb_funcinario.First(t => t.id_funcionario == fun.id_funcionario);

            Alterar.nm_funcionario = fun.nm_funcionario;
            Alterar.nm_bairro = fun.nm_bairro;
            Alterar.nm_cidade = fun.nm_cidade;
            Alterar.nm_endereco = fun.nm_endereco;
            Alterar.nm_numero = fun.nm_numero;
            Alterar.tb_CPF = fun.tb_CPF;
            Alterar.tb_RG= fun.tb_RG;
            Alterar.tb_sexo = fun.tb_sexo;
            Alterar.vl_salario = fun.vl_salario;
            Alterar.vl_transpote = fun.vl_transpote;


            db.SaveChanges();
        }
    }
}
