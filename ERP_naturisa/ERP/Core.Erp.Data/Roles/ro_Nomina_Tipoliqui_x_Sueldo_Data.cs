using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Nomina_Tipoliqui_x_Sueldo_Data
    {
        string mensaje = "";
        public List<ro_Nomina_Tipoliqui_x_Sueldo_Info> Get_List_Nomina_Tipoliqui_x_Sueldo(int IdEmpresa)
        {
            try
            {                
                using (EntitiesRoles base_ = new EntitiesRoles())
                {
                    List<ro_Nomina_Tipoliqui_x_Sueldo_Info> Consulta = (from q in base_.spRo_Nomina_Tipoliqui_x_Sueldo(IdEmpresa)
                                                                       select new ro_Nomina_Tipoliqui_x_Sueldo_Info{ 
                                                                           IdEmpresa = q.IdEmpresa,IdNomina_Tipo = q.IdNomina_Tipo,
                                                                       IdNomina_TipoLiqui=q.IdNomina_TipoLiqui,
                                                                       TipoNominaDescripcion=q.DescripcionProcesoNomina,
                                                                           LiquidacionDescripcion = q.Descripcion,
                                                                       PorSueldo =q.Sueldo}).ToList();                  
                    
                    return Consulta;                                 
                }
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarBD(List<ro_Nomina_Tipoliqui_x_Sueldo_Info> Info)
        {
            try
            {
                Boolean valorRetornar = false;

                if (EliminarBD(Info)){
                    using (EntitiesRoles ro = new EntitiesRoles())
                    {
                        foreach (var item in Info)
                        {
                            ro_Nomina_Tipoliqui_x_Sueldo paramTipo = new ro_Nomina_Tipoliqui_x_Sueldo();
                            paramTipo.IdEmpresa = item.IdEmpresa;
                            paramTipo.IdNomina_Tipo = item.IdNomina_Tipo;
                            paramTipo.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;                           
                            paramTipo.PorSueldo = item.PorSueldo;

                            ro.ro_Nomina_Tipoliqui_x_Sueldo.Add(paramTipo);
                            ro.SaveChanges();
                        }
                    }
                    valorRetornar = true;
                }
                return valorRetornar;
           }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarBD(List<ro_Nomina_Tipoliqui_x_Sueldo_Info> Info)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    foreach (var item in Info)
                    {
//ro_Nomina_Tipoliqui_x_Sueldo paramTipo = ro.ro_Nomina_Tipoliqui_x_Sueldo.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa);
//ro.ro_Nomina_Tipoliqui_x_Sueldo.Remove(paramTipo);
//ro.SaveChanges();

                        db.Database.ExecuteSqlCommand("delete from dbo.ro_Nomina_Tipoliqui_x_Sueldo where IdEmpresa =" + item.IdEmpresa.ToString()
                        //+ " AND IdNomina_Tipo=" + item.IdNomina_Tipo.ToString()
                        //+ " AND IdNomina_TipoLiqui=" + item.IdNomina_TipoLiqui.ToString()
                        );
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
