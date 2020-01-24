using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class HoleriteBusiness
    {
        public void Validar(Model.tb_holerite hole)
        {

            if (hole.vl_bruto == null)
            {
                throw new ArgumentException("Um valor Bruto precisa ser informado");
            }

            if (hole.vl_fgts == null)
            {
                throw new ArgumentException("O valor do FGTS precisa ser informado");
            }

            if (hole.vl_impostoR == null)
            {
                throw new ArgumentException("O valor do Imposto de Renda precisa ser informado");
            }

            if (hole.vl_inss == null)
            {
                throw new ArgumentException("O valor do INSS precisa ser informado");
            }

            if (hole.vl_liquido == null)
            {
                throw new ArgumentException("Um valor Liquido precisa ser informado");
            }
            if (hole.vl_VAlimentacao== null)
            {
                throw new ArgumentException("O valor do Vale Alimentação precisa ser informado");
            }
            if (hole.vl_VRefeicao == null)
            {
                throw new ArgumentException("O valor do Vale Refeição precisa ser informado");
            }
            if (hole.vl_VTransporte == null)
            {
                throw new ArgumentException("O valor do Vale Transporte precisa ser informado");
            }
         


        }
    }
}
