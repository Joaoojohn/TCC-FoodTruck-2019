using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class DespesasGastosBusiness
    {
        Databases.DespesasGastosDatabases dg = new Databases.DespesasGastosDatabases();

        public void Inserir(Model.tb_conta conta)
        {

            string con = conta.nm_conta;
            string tp = conta.tp_conta;
            DateTime val = Convert.ToDateTime(conta.dt_vencimento);
            DateTime pag = Convert.ToDateTime(conta.dt_pagamento);
            decimal valor = Convert.ToDecimal(conta.vl_conta);

            if (con.Length >= 50)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }

            if (tp.Length >= 20)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }



    


            if (valor == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }

            

            if (pag == null)
            {
                throw new ArgumentException("a Data de Pagamento não pode estar vazio");
            }


            //List<Model.tb_turma> vali = db.ConsultarTurma(turrr);



            //if (vali.Exists(t => t.nm_turma.Equals(turrr)))
            //{
            //    throw new ArgumentException("O nome que foi usado no campo TURMA já exite. Por Favor, insira outro nome.");
            //}

           dg.Inserir(conta);

        }


        public void Alterar(Model.tb_conta conta)
        {


            string con = conta.nm_conta;
            string tp = conta.tp_conta;
            DateTime val = Convert.ToDateTime(conta.dt_vencimento);
            DateTime pag = Convert.ToDateTime(conta.dt_pagamento);
            decimal valor = Convert.ToDecimal(conta.vl_conta);

            if (con.Length >= 20)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }

            if (tp.Length >= 20)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }


            if (valor == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }



            if (pag == null)
            {
                throw new ArgumentException("a Data de Pagamento não pode estar vazio");
            }



            dg.Alterar(conta);

        }

        public void Remover(Model.tb_conta tb_Conta)
        {
       


            string con = tb_Conta.nm_conta;
            string tp = tb_Conta.tp_conta;
            DateTime val = Convert.ToDateTime(tb_Conta.dt_vencimento);
            DateTime pag = Convert.ToDateTime(tb_Conta.dt_pagamento);
            decimal valor = Convert.ToDecimal(tb_Conta.vl_conta);

            if (con.Length >= 20)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }

            if (tp.Length >= 20)
            {
                throw new ArgumentException("Quantidade de Caracteres Excedida");
            }



            if (valor == 0)
            {
                throw new ArgumentException("A quantidade não pode ser 0");
            }



            if (pag == null)
            {
                throw new ArgumentException("a Data de Pagamento não pode estar vazio");
            }




            dg.remover(tb_Conta);

        }

        public List<Model.tb_conta> Listar()
        {
            List<Model.tb_conta> listar = dg.Consultar();
            return listar;
        }

        public List<Model.tb_conta> conta (string nome)
        {
            List<Model.tb_conta> res =  dg.Consultar(nome);


            return res;
        }

        public List<Model.tb_conta> Consultar(string nome)
        {
         List<Model.tb_conta>res =   dg.Consultar(nome);

            return res;
        }
    }
}
