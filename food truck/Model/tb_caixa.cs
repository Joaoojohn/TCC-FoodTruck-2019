//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace food_truck.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_caixa
    {
        public tb_caixa()
        {
            this.tb_pedido_venda_item = new HashSet<tb_pedido_venda_item>();
        }
    
        public int id_caixa { get; set; }
        public Nullable<int> id_estoque { get; set; }
        public Nullable<decimal> vl_produto { get; set; }
        public Nullable<int> item_produto { get; set; }
        public Nullable<decimal> vl_total { get; set; }
        public Nullable<decimal> vL_recebido { get; set; }
        public Nullable<decimal> vl_troco { get; set; }
        public Nullable<decimal> fm_dinheiro { get; set; }
        public Nullable<decimal> fm_credito { get; set; }
        public Nullable<decimal> fm_debito { get; set; }
    
        public virtual tb_estoque tb_estoque { get; set; }
        public virtual ICollection<tb_pedido_venda_item> tb_pedido_venda_item { get; set; }
    }
}