using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt001_Data
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       public List<XCXP_Rpt001_Info> consultar_data
       (int IdEmpresa, Decimal IdProveedor
           , DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, eFiltro_Estado_Pago TipoEstadoPago, eFiltro_Mostrar_Pagos MostrarPagos, 
           ref String mensaje)
        {
            try
            {

                List<XCXP_Rpt001_Info> listadedatos = new List<XCXP_Rpt001_Info>();
                tb_Empresa_Info Cbt = new tb_Empresa_Info();

                Cbt = param.InfoEmpresa;

                DateTime FechaIni = Convert.ToDateTime(co_fechaOg_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(co_fechaOg_Fin.ToShortDateString());

                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;

                if (IdProveedor == 0)
                {
                    IdProveedorIni = 1;
                    IdProveedorFin = 9999999999;

                }
                else
                {
                    IdProveedorIni = IdProveedor;
                    IdProveedorFin = IdProveedor;

                }               

                List<string> listTipoPagos = new List<string>();

                switch (MostrarPagos)
                {
                    case eFiltro_Mostrar_Pagos.SI:
                        listTipoPagos.Add("CBTE_PAGO");
                        listTipoPagos.Add("CBTE_CXP");
                        break;

                    case eFiltro_Mostrar_Pagos.NO:
                        listTipoPagos.Add("CBTE_CXP");
                        break;
                }


                List<XCXP_Rpt001_Info> lista = new List<XCXP_Rpt001_Info>();

                using (EntitiesCXP_General Estactaprovee = new EntitiesCXP_General())
                {
                    var consulta = from h in Estactaprovee.vwCXP_Rpt001
                                       where h.IdEmpresa == IdEmpresa
                                       && IdProveedorIni <= h.IdProveedor && h.IdProveedor <= IdProveedorFin
                                       && FechaIni <= h.co_fechaOg && h.co_fechaOg <= FechaFin                                       
                                       && listTipoPagos.Contains(h.Tipo_cbte.Trim())
                                       select h;
                    
                    foreach (var item in consulta)
                    {
                        XCXP_Rpt001_Info itemInfo = new XCXP_Rpt001_Info();

                        itemInfo.co_fechaOg = item.co_fechaOg;
                        itemInfo.cod_tipo_doc = item.cod_tipo_doc;
                        itemInfo.Documento = item.Documento;
                        itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.nom_tipo_doc = item.nom_tipo_doc;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.Valor_debe = item.Valor_debe;
                        itemInfo.Valor_Haber = item.Valor_Haber;
                        itemInfo.Valor_a_pagar = item.Valor_a_pagar;
                        itemInfo.Logo = Cbt.em_logo_Image;
                        itemInfo.Ruc_Proveedor = item.Ruc_Proveedor;
                        itemInfo.representante_Legal = item.representante_legal;
                        itemInfo.Tipo_cbte = item.Tipo_cbte;
                        itemInfo.IdEmpresa_pago = item.IdEmpresa_pago;
                        itemInfo.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        itemInfo.IdCbteCble_pago = item.IdCbteCble_pago;
                        itemInfo.cb_Observacion_pago = item.cb_Observacion_pago;
                        itemInfo.tc_TipoCbte_pago = item.tc_TipoCbte_pago;
                        itemInfo.cb_Cheque_pago = item.cb_Cheque_pago;
                        itemInfo.Saldo = item.Saldo;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt001_Info>();
            }
        }

    
    
    
    }
}
