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
    
    public partial class tb_escala
    {
        public int id_escala { get; set; }
        public Nullable<int> id_funcionario { get; set; }
        public Nullable<System.DateTime> ds_semanal { get; set; }
        public Nullable<System.TimeSpan> hr_dia { get; set; }
        public Nullable<System.DateTime> tb_folga { get; set; }
    
        public virtual tb_funcinario tb_funcinario { get; set; }
    }
}
