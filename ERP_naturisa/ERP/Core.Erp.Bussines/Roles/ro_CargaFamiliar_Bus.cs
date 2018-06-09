/*CLASE: ro_CargaFamiliar_Bus
 *MODIFICADA POR: ALBERTO MENA
 *FECHA: 24-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_CargaFamiliar_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";


        ro_CargaFamiliar_Data oRo_CargaFamiliar_Data = new ro_CargaFamiliar_Data();
     


        public List<ro_CargaFamiliar_Info> Obtener_CargaFamiliar(int idempresa, int IdEmpleado)
        {
                List<ro_CargaFamiliar_Info> lm = new List<ro_CargaFamiliar_Info>();
            try
            {
                lm = oRo_CargaFamiliar_Data.Get_List_CargaFamiliar(idempresa, IdEmpleado);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_CargaFamiliar", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }
        }

        public Boolean ModificarDB(ro_CargaFamiliar_Info info, ref string msg)
        {

            try
            {
                return oRo_CargaFamiliar_Data.ModificarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };
 
            }

        }

        public int getId()
        {
            try
            {
                //ro_CargaFamiliar_Data data = new ro_CargaFamiliar_Data();
                return oRo_CargaFamiliar_Data.getId();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }







        public Boolean GrabarBD(ro_CargaFamiliar_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetonar = false;

                if (oRo_CargaFamiliar_Data.getExiste(info))
                {
                    valorRetonar = oRo_CargaFamiliar_Data.ModificarBD(info, ref msg);
                }
                else{
                    valorRetonar = oRo_CargaFamiliar_Data.GrabarBD(info, ref msg);
                }

            return  valorRetonar;
            
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }
        }






        
        
        
        
        public Boolean AnularDB(ro_CargaFamiliar_Info info, ref string msg)
        {
            try
            {
                //ro_CargaFamiliar_Data data=new ro_CargaFamiliar_Data();
                return oRo_CargaFamiliar_Data.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }
        }

        public Boolean EliminarDB(List<ro_CargaFamiliar_Info> ListInfo, int IdEmpresa, int idEmpleado)
        {
            try
            {
                //ro_CargaFamiliar_Data data = new ro_CargaFamiliar_Data();
                return oRo_CargaFamiliar_Data.EliminarDB(ListInfo, IdEmpresa, idEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }
        }

        public Boolean getExiste(ro_CargaFamiliar_Info info)
        {

            try
            {

                return oRo_CargaFamiliar_Data.getExiste(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getExiste", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }

        public ro_CargaFamiliar_Bus() { }

        //17/12/2013 Derek Mejía Soria
        public List<ro_CargaFamiliar_Info> Obtener_CargaFamiliarHijo(int idempresa, int IdEmpleado)
        {
            try
            {
                //ro_CargaFamiliar_Data data = new ro_CargaFamiliar_Data();
                return oRo_CargaFamiliar_Data.Get_List_CargaFamiliar_x_Hijo(idempresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_CargaFamiliarHijo", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }

        public List<ro_CargaFamiliar_Info> Obtener_CargaFamiliarConyugue(int idempresa, int IdEmpleado)
        {
            try
            {
                //ro_CargaFamiliar_Data data = new ro_CargaFamiliar_Data();
                return oRo_CargaFamiliar_Data.Get_List_CargaFamiliar_x_Conyugue(idempresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_CargaFamiliarConyugue", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }

        public List<ro_CargaFamiliar_Info> Obtener_CargaFamiliarDiscapacitado(int idempresa, int IdEmpleado)
        {
            try
            {
                return oRo_CargaFamiliar_Data.Get_List_CargaFamiliar_x_Discapacitado(idempresa, IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_CargaFamiliarDiscapacitado", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }

        public Boolean eliminar1registro(ro_CargaFamiliar_Info Info)
        {
            try
            {
                return oRo_CargaFamiliar_Data.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminar1registro", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }




        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                return oRo_CargaFamiliar_Data.EliminarBD(idEmpresa, idEmpleado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }
        }



        public double pu_TotalCargasParaCalculoUtilidad(int idempresa, decimal idEmpleado)
        {
            try
            {
                double valorRetornar=0;

                ro_historico_vacaciones_x_empleado_Bus oRo_historico_vacaciones_x_empleado_Bus = new ro_historico_vacaciones_x_empleado_Bus();


                //CONTADOR DE CARGA FAMILIAR CON DISCAPACIDAD
                valorRetornar +=oRo_CargaFamiliar_Data.Get_List_CargaFamiliar_x_Discapacitado(idempresa, idEmpleado).Count();
               
                //CONTADOR DE CARGA FAMILIAR CONYUGE
                valorRetornar +=oRo_CargaFamiliar_Data.Get_List_CargaFamiliar_x_Conyugue(idempresa, idEmpleado).Count();

                //CONTADOR DE CARGA FAMILIAR - HIJOS MENORES DE 18 AÑOS
                valorRetornar += (from a in oRo_CargaFamiliar_Data.Get_List_CargaFamiliar_x_Hijo(idempresa, idEmpleado)
                                  where oRo_historico_vacaciones_x_empleado_Bus.CalcularAniosDeDiferencia(Convert.ToDateTime(a.FechaNacimiento), DateTime.Now)<18
                                  select a).Count();

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_TotalCargasParaCalculoUtilidad", ex.Message), ex) { EntityType = typeof(ro_CargaFamiliar_Bus) };

            }

        }


    }
}
