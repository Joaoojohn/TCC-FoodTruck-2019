using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class DespesasGastosDatabases
    {
        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();

        public void Inserir(Model.tb_conta conta)
        {
            db.tb_conta.Add(conta);
            db.SaveChanges();

        }

        public List<Model.tb_conta> Consultar()
        {
            List<Model.tb_conta> Consultar = db.tb_conta.ToList();
            return Consultar;
        }

        public void Alterar(Model.tb_conta conta)
        {
            Model.tb_conta alterar = db.tb_conta.First(t => t.id_Contas == conta.id_Contas);

            alterar.vl_conta = conta.vl_conta;
            alterar.nm_conta = conta.nm_conta;
            alterar.tp_conta = conta.tp_conta;
            alterar.dt_vencimento = conta.dt_vencimento;
            alterar.dt_pagamento = conta.dt_pagamento;

            db.SaveChanges();


        }

        public void remover(Model.tb_conta conta)
        {
            Model.tb_conta remover = db.tb_conta.First(t => t.id_Contas == conta.id_Contas);

            remover.vl_conta = conta.vl_conta;
            remover.nm_conta = conta.nm_conta;
            remover.tp_conta = conta.tp_conta;
            remover.dt_vencimento = conta.dt_vencimento;
            remover.dt_pagamento = conta.dt_pagamento;
             

            if (remover != null)
            {

                db.tb_conta.Remove(remover);
                db.SaveChanges();

            }



        }

        public List<Model.tb_conta> Consultar(string conta)
        {

            List<Model.tb_conta> pro =
            db.tb_conta.Where(t => t.nm_conta.Contains(conta)).ToList();

            return pro;
        }


        public Model.tb_conta BuscarPorNome(string Nome)
        {


            Model.tb_conta conta =
            db.tb_conta.FirstOrDefault(t => t.nm_conta.Contains(Nome));

            return conta;
        }
    }
}

