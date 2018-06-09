using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.CuentasxPagar
{
    public class tbCXP_Rpt002_Data
    {
        string mensaje = "";
        public List<tbCXP_Rpt002_Info> ConsultaGeneral(int IdEmpresa, string IdUsuario, string nom_pc)
	    {
		    try
		    {
			    List<tbCXP_Rpt002_Info> Lst = new List<tbCXP_Rpt002_Info>() ;
			    EntitiesCuentasxPagar oEnti= new EntitiesCuentasxPagar();
			    var Query = from q in oEnti.tbCXP_Rpt002
                             where q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && q.nom_pc == nom_pc
				    select q;
			    foreach (var item in Query)
			    {
				    tbCXP_Rpt002_Info Obj = new tbCXP_Rpt002_Info() ;
					    Obj.IdEmpresa= item.IdEmpresa;
					    Obj.IdUsuario= item.IdUsuario;
					    Obj.Fecha_Transac= item.Fecha_Transac;
					    Obj.nom_pc= item.nom_pc;
					    Obj.IdOrden_giro_Tipo= item.IdOrden_giro_Tipo;
					    Obj.IdCbteCble_Ogiro= item.IdCbteCble_Ogiro;
					    Obj.co_serie= item.co_serie;
					    Obj.co_factura= item.co_factura;
					    Obj.co_FechaFactura= item.co_FechaFactura;
					    Obj.co_FechaFactura_vct= item.co_FechaFactura_vct;
					    Obj.co_plazo= item.co_plazo;
					    Obj.xvencer= item.xvencer;
					    Obj.uno= item.C1_30 ;
					    Obj.tresUno= item.C31_60;
					    Obj.seisUno = item.C61_90;
					    Obj.nueve = item.C_90 ;
					    Obj.total= item.total;
					    Obj.saldo= item.saldo;
					    Obj.detalle= item.detalle;
					    Obj.NomProveedor= item.NomProveedor;
					    Obj.IdProveedor= item.IdProveedor;
				    Lst.Add(Obj);
		    }
			    return Lst;
			}
		    catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<tbCXP_Rpt002_Info>(); 
            }
			}
        
        public bool  Ejecuta_spCXP_Rpt002(int IdEmpresa, decimal IdProveedorI, decimal IdProveedorF, DateTime FDesde, DateTime FHasta, string IdUsuario, string nom_pc)
        {
            try
            {
                using (EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar())
                {
                    // base_.spCXP_Rpt002(IdEmpresa, IdProveedorI, IdProveedorF, FDesde, FHasta, IdUsuario, nom_pc);
                     return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false; 
            }
        }


        public tbCXP_Rpt002_Data(){}
    }
}
