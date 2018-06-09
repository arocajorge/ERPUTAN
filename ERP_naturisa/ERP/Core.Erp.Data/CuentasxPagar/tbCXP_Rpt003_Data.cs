using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class tbCXP_Rpt003_Data
    {
        string mensaje = "";
        public List<tbCXP_Rpt003_Info> ConsultaGeneral(int IdEmpresa,string IdUsuario,string nom_pc)
        {
            try
            {
                List<tbCXP_Rpt003_Info> Lst = new List<tbCXP_Rpt003_Info>();
                using (EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar())
                {
                    var Query = from q in oEnti.tbCXP_Rpt003
                                where q.IdEmpresa == IdEmpresa && q.IdUsuario==IdUsuario && q.nom_pc==nom_pc 
                                select q;
                    foreach (var item in Query)
                    {
                        tbCXP_Rpt003_Info Obj = new tbCXP_Rpt003_Info();
                        Obj.IdEmpresa = item.IdEmpresa;
                        Obj.IdUsuario = item.IdUsuario;
                        Obj.Fecha_Transac = item.Fecha_Transac;
                        Obj.nom_pc = item.nom_pc;
                        Obj.saldoProveedor = item.saldoProveedor;
                        Obj.nombreProveedor = item.nombreProveedor;
                        Obj.IdProveedor = item.IdProveedor;
                        Lst.Add(Obj);
                    }
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
                return new List<tbCXP_Rpt003_Info>(); 
            }
        }
        
        public bool Ejecuta_spCXP_Rpt003(int IdEmpresa, decimal IdProveedorI, decimal IdProveedorF, DateTime FDesde, DateTime FHasta, string IdUsuario, string nom_pc)
        {
            try
            {
                using (EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar())
                {
                   // base_.spCXP_Rpt003(IdEmpresa, IdProveedorI, IdProveedorF, FDesde, FHasta, IdUsuario, nom_pc);
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


        public tbCXP_Rpt003_Data(){}
    }
}
