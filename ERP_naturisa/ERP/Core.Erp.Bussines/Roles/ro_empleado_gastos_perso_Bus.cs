using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_empleado_gastos_perso_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        //BUS
        ro_empleado_gastos_perso_x_Gastos_deduci_Bus oRo_empleado_gastos_perso_x_Gastos_deduci_Bus = new ro_empleado_gastos_perso_x_Gastos_deduci_Bus();
        ro_empleado_gastos_perso_x_otros_gast_deduci_Bus oRo_empleado_gastos_perso_x_otros_gast_deduci_Bus = new ro_empleado_gastos_perso_x_otros_gast_deduci_Bus();

        //DATA
        ro_empleado_gastos_perso_Data oData = new ro_empleado_gastos_perso_Data();

        public List<ro_empleado_gastos_perso_Info> Get_List_empleado_gastos_perso(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_empleado_gastos_perso(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }

        }

        public Boolean GuardarBD(ro_empleado_gastos_perso_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA
                if (oData.GetExiste(info, ref msg))
                {                   
                    valorRetornar= oData.ModificarBD(info, ref msg);               
                }else{//GRABA
                    info.Estado = "A";
                    valorRetornar= oData.GuardarBD(info, ref msg);
                }

                //GUARDA DETALLE DE GASTOS PERSONALES
                if (valorRetornar)
                {
                    //ELIMINA VALORES PREVIOS
                    oRo_empleado_gastos_perso_x_Gastos_deduci_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, info.Anio_fiscal, ref msg);

                  
                    foreach (ro_empleado_gastos_perso_x_Gastos_deduci_Info item in info.oListRo_empleado_gastos_perso_x_Gastos_deduci_Info)
                    {
                        if (!oRo_empleado_gastos_perso_x_Gastos_deduci_Bus.GrabarBD(item, ref msg)) {
                            valorRetornar = false;
                            break;
                        }
                    }
                }


                //GUARDA DETALLE DE OTROS GASTOS PERSONALES
                if (valorRetornar)
                {
                    //ELIMINA VALORES PREVIOS
                    oRo_empleado_gastos_perso_x_otros_gast_deduci_Bus.EliminarBD(info.IdEmpresa, info.IdEmpleado, info.Anio_fiscal, ref msg);

                    foreach (ro_empleado_gastos_perso_x_otros_gast_deduci_Info item in info.oListRo_empleado_gastos_perso_x_otros_gast_deduci_Info)
                    {
                        if (!oRo_empleado_gastos_perso_x_otros_gast_deduci_Bus.GrabarBD(item, ref msg))
                        {
                            valorRetornar = false;
                            break;
                        }
                    }

                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }

        }


        public List<ro_empleado_gastos_perso_Info> Get_Info_empleado_gastos_pers(int IdEmpresa, int IdEmpleado, int anio)
        {
            try
            {
                return oData.Get_Info_empleado_gastos_pers(IdEmpresa, IdEmpleado, anio);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_empleado_gastos_pers", ex.Message), ex) { EntityType = typeof(ro_empleado_gastos_perso_Bus) };
            }
        }
        
    }
}
