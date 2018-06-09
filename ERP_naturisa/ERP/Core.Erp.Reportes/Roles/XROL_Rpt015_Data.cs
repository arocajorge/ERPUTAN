using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt015_Data
    {
        string mensaje = "";
        public List<XROL_Rpt015_Info> Get_Asignacion_x_empleado(int idEmpresa,int Idnomina_tipo, decimal IdEmpleado, decimal idAsignacion_Impl)
        {
            try
            {
                List<XROL_Rpt015_Info> Lista = new List<XROL_Rpt015_Info>();
                tb_Empresa_Info info_empresa = new tb_Empresa_Info();
                tb_Empresa_Data empresa_data = new tb_Empresa_Data();
                info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
                using (EntitiesRolesRptGeneral Conexion = new EntitiesRolesRptGeneral())
                {
                  var quer   = (from q in Conexion.vwROL_Rpt015
                                where q.IdEmpresa == idEmpresa
                               // &&q.IdNomina_Tipo==Idnomina_tipo
                             && q.IdAsignacion_Impl == idAsignacion_Impl
                             && q.IdEmpleado==IdEmpleado
                            select q);
                  foreach (var item in quer)
                  {
                      XROL_Rpt015_Info info = new XROL_Rpt015_Info();
                        info.em_nombre = info.em_nombre;
                        info. pe_nombreCompleto =item.pe_nombreCompleto;
                        info.IdEmpresa =item.IdEmpresa;
                        info. IdEmpleado =item.IdEmpleado;
                        info. Observacion =item.Observacion;
                        info. secuencia =item.secuencia;
                        info. Detalle =item.Detalle;
                        info. Vida_Util =item.Vida_Util;
                        info. Cantidad =item.Cantidad;
                        info. IdAsignacion_Impl =item.IdAsignacion_Impl;
                        info. pr_descripcion =item.pr_descripcion;
                        info. pr_descripcion_2 =item.pr_descripcion_2;
                        info. pr_codigo =item.pr_codigo;
                        info. Af_Nombre =item.Af_Nombre;
                        info.ca_descripcion = item.ca_descripcion;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.Fecha_Entrega = item.Fecha_Entrega;
                        info.em_logo = info_empresa.em_logo;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Lista.Add(info);
                  }
                }
                return Lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt015_Info>();
            }
        }

    }
}
