using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.CuentasxPagar
{
    public class tbCXP_Rpt005_Data
    {
        string mensaje = "";
        public List<tbCXP_Rpt005_Info> ConsultaGeneral(int IdEmpresa, string IdUsuario, string nom_pc)
        {
            try
            {
                List<tbCXP_Rpt005_Info> Lst = new List<tbCXP_Rpt005_Info>();
                EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();
                var Query = from q in oEnti.tbCXP_Rpt005
                            where q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && q.nom_pc == nom_pc 
                            select q;
                foreach (var item in Query)
                {
                    tbCXP_Rpt005_Info Obj = new tbCXP_Rpt005_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.nom_pc = item.nom_pc;
                    Obj.secuencia = item.secuencia;
                    Obj.FechaDoc = item.FechaDoc;
                    Obj.FechaDocVence = item.FechaDocVence;
                    Obj.NDocumento = item.NDocumento;
                    Obj.Documento = item.Documento;
                    Obj.Proveedor = item.Proveedor;
                    Obj.Observacion = item.Observacion;
                    Obj.Valor = item.Valor;
                    Obj.IdProveedor = item.IdProveedor;
                    Obj.orden = item.orden;
                    Obj.orden2 = item.orden2;
                    Obj.IdCbteCble_OG = item.IdCbteCble_OG;
                    Obj.Fecha_OG = item.Fecha_OG;
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
                return new List<tbCXP_Rpt005_Info>(); 
            }
        }

        public bool Ejecuta_spCXP_Rpt005(int IdEmpresa, decimal IdProveedorI, decimal IdProveedorF, DateTime FDesde, DateTime FHasta, string IdUsuario, string nom_pc)
        {
            try
            {
                using (EntitiesCuentasxPagar enty = new EntitiesCuentasxPagar())
                {
                   // enty.spCXP_Rpt005(IdEmpresa, IdProveedorI, IdProveedorF, FDesde, FHasta, IdUsuario, nom_pc);
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



    }
}
