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
    
    public partial class tb_conta
    {
        public int id_Contas { get; set; }
        public string nm_conta { get; set; }
        public string tp_conta { get; set; }
        public Nullable<System.DateTime> dt_pagamento { get; set; }
        public Nullable<System.DateTime> dt_vencimento { get; set; }
        public Nullable<decimal> vl_conta { get; set; }
    }
}
