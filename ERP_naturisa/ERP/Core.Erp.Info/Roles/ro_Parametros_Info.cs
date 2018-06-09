using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Parametros_Info
    {
        public int IdEmpresa { get; set; }
        public Nullable<int> IdTipoCbte_AsientoSueldoXPagar { get; set; }
        public Nullable<int> IdTipoCbte_AsientoProvision { get; set; }
        public Nullable<int> IdTipo_mov_Ingreso { get; set; }
        public Nullable<int> IdTipo_mov_Egreso { get; set; }
        public Nullable<int> Dias_considerado_ultimo_pago_quincela_Liq { get; set; }
        public Nullable<int> IdNomina_Tipo_Para_Desc_Automat { get; set; }
        public Nullable<int> IdNominatipoLiq_Para_Desc_Automat { get; set; }
        public Nullable<bool> GeneraraOP_PagoTerceros { get; set; }
        public string IdTipoOP_PagoTerceros { get; set; }
        public Nullable<int> IdTipoFlujoOP_PagoTerceros { get; set; }
        public string IdFormaOP_PagoTerceros { get; set; }
        public Nullable<int> IdBancoOP_PagoTerceros { get; set; }
        public Nullable<bool> GeneraOP_PagoPrestamos { get; set; }
        public string IdTipoOP_PagoPrestamos { get; set; }
        public Nullable<int> IdTipoFlujoOP_PagoPrestamos { get; set; }
        public string IdFormaOP_PagoPrestamos { get; set; }
        public Nullable<int> IdBancoOP_PagoPrestamos { get; set; }


        public Nullable<bool> GeneraOP_LiquidacionVacaciones { get; set; }
        public string IdTipoOP_LiquidacionVacaciones { get; set; }
        public Nullable<int> IdTipoFlujoOP_LiquidacionVacaciones { get; set; }
        public string IdFormaOP_LiquidacionVacaciones { get; set; }
        public Nullable<int> IdBancoOP_LiquidacionVacaciones { get; set; }
        public Nullable<bool> DescuentaIESS_LiquidacionVacaciones { get; set; }
        public string cta_contable_IESS_Vacaciones { get; set; }


        public Nullable<bool> GeneraOP_ActaFiniquito { get; set; }
        public string IdTipoOP_ActaFiniquito { get; set; }
        public Nullable<int> IdTipoFlujoOP_ActaFiniquito { get; set; }
        public string IdFormaPagoOP_ActaFiniquito { get; set; }
        public Nullable<int> IdBancoOP_ActaFiniquito { get; set; }


        public ro_Parametros_Info()
        {

        }
    }
}
