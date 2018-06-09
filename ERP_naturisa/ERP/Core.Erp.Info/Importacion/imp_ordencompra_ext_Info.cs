using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{    //VERSION:13052013
    public class imp_ordencompra_ext_Info
    {

        public Boolean Chek { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucusal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public string CodOrdenCompraExt { get; set; }
        public int ci_plazo { get; set; }
        public DateTime ci_fecha { get; set; }
        public decimal IdProveedor { get; set; }
        public string ci_Observacion { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public double ci_costo_Flete_externo { get; set; }
        public double ci_costo_Flete_interno { get; set; }
        public double ci_costoSeguro { get; set; }
        public double ci_costoCif { get; set; }
        public double ci_GastosTotales { get; set; }
        public string IdVia { get; set; }
        public DateTime? ci_fechaFirmaContrato { get; set; }
        public DateTime ci_fecha_aprobacion { get; set; }
        public DateTime ci_fechaFactProv { get; set; }
        public DateTime ci_fechVenciFact { get; set; }
        public DateTime ci_fechaDespProv { get; set; }
        public DateTime ci_fechaRecEmb { get; set; }
        public DateTime ci_fechaAproxSal { get; set; }
        public DateTime ci_fec_est_llegada { get; set; }
        public DateTime ci_fecha_llegada_Bodega { get; set; }
        public DateTime ci_fecha_Bodega { get; set; }
        public DateTime ci_fechaRealArri { get; set; }
        public DateTime ci_fechaDocAAA { get; set; }
        public DateTime ci_fecha_liquidacion { get; set; }
        public DateTime ci_fecha_sal_aduana { get; set; }
        public int ci_diasFecFacProv { get; set; }
        public int ci_diasFecDespProv { get; set; }
        public int ci_diasFecAproxSal { get; set; }
        public int ci_diasFecAproxLleg { get; set; }
        public int ci_diasNaciona { get; set; }
        public DateTime ci_fecha_pago { get; set; }
        public DateTime ci_fecha_salida { get; set; }
        public DateTime ci_fecha_llegada { get; set; }
        public DateTime ci_fecha_despacho { get; set; }
        public int ci_dias_estimados { get; set; }
        public double ci_valor_derecho { get; set; }
        public int IdMonedaOrigen { get; set; }
        public int IdMonedaCambiaria { get; set; }
        public double ci_EquivalenciaMoneda { get; set; }
        public string IdCicloImportacion { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_import { get; set; }
        public int IdEmbarcador { get; set; }
        public string ci_contabilizada { get; set; }
        public decimal ci_Idfecha_Bodega { get; set; }
        public DateTime ci_fechaRegsis { get; set; }
        public string IdPaisOrgCarga { get; set; }
        public string IdPaisProceCarga { get; set; }
        public string ci_dui { get; set; }
        public int ci_anio	 { get; set; }
        public int ci_mes { get; set; }
        public DateTime ci_FechaCosteo { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string NumFacturaProvedor { get; set; }
        public DateTime ci_fechaHoraAnul { get; set; }
        public string ci_userAnul { get; set; }
        public DateTime ci_ultFechaModi { get; set; }
        public string ci_ultUserModi { get; set; }
        public string  IdTerminoPago { get; set; }
        public decimal IdBanco { get; set; }
        public double ci_tonelaje { get; set; }
        public string ci_LugarEmbarque { get; set; }
        public string Importacion { get; set; }
        public string Buque { get; set; }
        public string Naviera { get; set; }
        public double  CFR{ get; set; }
        public double FOB { get; set; }
        public string IdCategoria { get; set; }
        public string IdEstadoLiquidacion { get; set; }
        public int ci_DiasEmbarque { get; set; }
        public string Tipo_Importacion { get; set; }
        public List<imp_ordencompra_ext_det_Info> ListaDetalleOrdeCompraEx { get; set; }
        public List<imp_DatosEmbarque_Info> ListaDatoEmbarque { get; set; }
        public List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> ListaGastos { get; set; }
        public List<imp_ordencompra_ext_x_Condiciones_Pago_Info> ListCondicionPago { get; set; }


        public double ci_Total { get; set; }
        public double TotGastosImp { get; set; }
        public double TotalLiquidacion { get; set; }
        public string CodCbteCble { get; set; }

        public string  motiAnulacion { get; set; }
        public string msgAnuladoReverso { get; set; }

        public double setFOB { get; set; }
       
        public string msgReversoCbteCble { get; set; }
        public string msgGenerarDiarioFOB { get; set; }
        public Boolean GenDiarioTipImpo { get; set; }

        public string IdCtaCble_CXP {get;set;}

        public string Sucursal { get; set; }
        public string Proveedor { get; set; }
        public imp_ordencompra_ext_Info() {
            ListaDatoEmbarque = new List<imp_DatosEmbarque_Info>();
            ListaDetalleOrdeCompraEx = new List<imp_ordencompra_ext_det_Info>();
            ListaGastos = new List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>();
            ListCondicionPago = new List<imp_ordencompra_ext_x_Condiciones_Pago_Info>();
            
      
        }

        public DateTime? Fecha_Maximo_Despacho { get; set; }
    }
}
