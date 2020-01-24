using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class CaixaDatabases
    {
        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();
        

        public void Inserir(Model.tb_caixa caixa)
        {
            db.tb_caixa.Add(caixa);
            db.SaveChanges();

        }

        public List<Model.tb_caixa> Consultar()
        {
            List<Model.tb_caixa> Consultar = db.tb_caixa.ToList();
            return Consultar;
        }

        public void Alterar(Model.tb_caixa caixa)
        {
            Model.tb_caixa alterar = db.tb_caixa.First(t => t.id_caixa == caixa.id_caixa);

            alterar.item_produto = caixa.item_produto;
            alterar.vl_produto = caixa.vl_produto;
            alterar.vl_total = caixa.vl_total;
            alterar.vl_troco = caixa.vl_troco;

            db.SaveChanges();


        }

        public void remover(int id)
        {
            Model.tb_caixa remover = db.tb_caixa.First(t => t.id_caixa == id);

            db.tb_caixa.Remove(remover);
            db.SaveChanges();
        }
    }
}


