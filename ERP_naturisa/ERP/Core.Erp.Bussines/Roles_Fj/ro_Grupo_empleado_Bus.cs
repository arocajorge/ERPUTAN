using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_Grupo_empleado_Bus
    {
      string mensaje;
      ro_Grupo_empleado_Data data = new ro_Grupo_empleado_Data();
      ro_Grupo_empleado_det_Data data_detalle = new ro_Grupo_empleado_det_Data();
        public bool Guardar_DB(ro_Grupo_empleado_Info info)
      {
          bool ba = false;
          int idgrupo = 0;
            try
            {
                if (data.Guardar_DB(info,ref idgrupo))
                {

                    foreach (var item in info.detalle)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdGrupo = idgrupo;
                    }

                 ba=   data_detalle.Guardar_DB(info.detalle);
                }
                return ba;
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }


        public bool Modificar_DB(ro_Grupo_empleado_Info info)
        {
             bool ba = false;
            try
            {
                if (data.Modificar_DB(info))
                {

                   
                    foreach (var item in info.detalle)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdGrupo = info.IdGrupo;
                    }

                 ba=   data_detalle.Modificar_DB(info.detalle);
                }
                return ba;
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }



        public bool Anular_DB(ro_Grupo_empleado_Info info)
        {
            try
            {
                return data.Anular_DB(info);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }




        public List<ro_Grupo_empleado_Info> listado_Grupos(int IdEmpresa)
        {
            try
            {
                return data.listado_Grupos(IdEmpresa);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public double Get_valor_bono(int IdEmpresa, int IdGrupo)
        {
            try
            {
                return data.Get_valor_bono(IdEmpresa, IdGrupo);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
     
    }
}
