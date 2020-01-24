using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Model
{
    partial class tb_estoque
    {
        public string nm_fornecedor { get { return this.tb_fornecedor.nm_Fornecedor; } }
        public string nm_produto { get { return this.tb_produto.nm_produto; } }
    }
}
