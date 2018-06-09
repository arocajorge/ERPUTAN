using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
//Ult.Mod=Derek 06022014
namespace Core.Erp.Info.Caja
{
    public class caj_Caja_Movimiento_Info
    {
        public	int	IdEmpresa	{ get; set; }
        public	decimal	IdCbteCble	{ get; set; }
        public	int	IdTipocbte	{ get; set; }
        public	string	cm_Signo	{ get; set; }
        public	string	cm_beneficiario	{ get; set; }
        public	double 	cm_valor	{ get; set; }
        public	int?	IdTipoMovi	{ get; set; }
        public	string	cm_observacion	{ get; set; }
        public	int	IdCaja	{ get; set; }
        public	int	IdPeriodo	{ get; set; }
        public	DateTime	cm_fecha	{ get; set; }
        public	string	IdUsuario	{ get; set; }
        public	string	IdUsuario_Anu	{ get; set; }
        public	DateTime	?FechaAnulacion	{ get; set; }
        public	DateTime	Fecha_Transac	{ get; set; }
        public	DateTime?	Fecha_UltMod	{ get; set; }
        public	string	IdUsuarioUltMod	{ get; set; }
        public	string	Estado	{ get; set; }
        public	string	MotivoAnulacion	{ get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public string IngEgr { get; set; }
        public string NCaja { get; set; }
        public string NTipoMovi { get; set; }
        public decimal? IdCbteCble_Anu { get; set; }
        public int? IdTipocbte_Anu { get; set; }
        public string CodMoviCaja { get; set; }
        public string ResponsableCaja { get; set; }
        public int ? IdSucursal { get; set; }
        public string NSucursal { get; set; }
        public string NomCliente { get; set; }
        public string NomProveedor { get; set; }

        public List<caj_Caja_Movimiento_det_Info> list_Caja_Movi_det { get; set; }
        public ct_Cbtecble_Info Info_CbteCble_x_Caja_Movi { get; set; }


        public string IdBeneficiario { get; set; }
        public decimal  ? IdPersona { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal? IdEntidad { get; set; }

        public decimal? IdTipoFlujo { get; set; }
        public bool Esta_en_base { get; set; }
        public string IdCtaCble { get; set; }
        public string Nom_Beneficiario { get; set; }
                    

        public decimal IdConciliacionCaja { get; set; }
       

        
        public string IdCtaCble_Caja { get; set; }

        public int secuencial { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string NomSubCentroCosto { get; set; }

        public int IdEmpresa_movcaja { get; set; }
        public decimal IdCbteCble_movcaja { get; set; }
        public int IdTipocbte_movcaja { get; set; }


        public string nom_TipoMovi { get; set; }
        public string nom_Caja { get; set; }
        public string IdCtaCble_ValeCaja { get; set; }

        public List<cp_orden_pago_cancelaciones_Info> List_OrdenCan { get; set; }

        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }

        public Nullable<decimal> IdRecibo { get; set; }
        public Nullable<int> IdPuntoVta { get; set; }

        public caj_Caja_Movimiento_Info()
        {

            Info_CbteCble_x_Caja_Movi = new ct_Cbtecble_Info();
            List_OrdenCan = new List<cp_orden_pago_cancelaciones_Info>() ;
            this.list_Caja_Movi_det = new List<caj_Caja_Movimiento_det_Info>();
        
        }
    }
}
