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
    
    public partial class tb_estoque
    {
        public tb_estoque()
        {
            this.tb_caixa = new HashSet<tb_caixa>();
        }
    
        public int id_Estoque { get; set; }
        public Nullable<int> id_produto { get; set; }
        public Nullable<int> id_Fornecedor { get; set; }
        public string ds_produto { get; set; }
        public Nullable<int> qtd_produto { get; set; }
        public Nullable<System.DateTime> dt_Entrada { get; set; }
        public Nullable<System.DateTime> dt_saida { get; set; }
        public Nullable<System.DateTime> dt_validadeproduto { get; set; }
        public Nullable<decimal> prc_custo { get; set; }
        public Nullable<decimal> prc_venda { get; set; }
    
        public virtual ICollection<tb_caixa> tb_caixa { get; set; }
        public virtual tb_produto tb_produto { get; set; }
        public virtual tb_fornecedor tb_fornecedor { get; set; }
    }
}