using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
///
///katiuska unific 08012014 1441
///
//
//

///Prog: Héctor Ayauca
///V 10.13 22022014
///


namespace Core.Erp.Data.Roles
{
    public class ro_Procesar_Rol_data
    {
        string mensaje = "";
        ro_calculos_formula_IESS_Data dataCalc = new ro_calculos_formula_IESS_Data();
        public Boolean PROCESAR1x1(int IDempresa, int IDproceso, int IDperiodo, decimal IDEmpleado, int IDtipo_nomina)
        {
            try
            {
                using (EntitiesRoles base_ = new EntitiesRoles())
                {
                    string query = "exec  spRo_procesa_Rol " + IDempresa + " , " + IDEmpleado + ","
                        + IDEmpleado + ", " + IDtipo_nomina + "," + IDproceso + ","
                        + IDperiodo;
                    base_.Database.ExecuteSqlCommand(query);
                    
                    return true;
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



        public Boolean PROCESARMUCHOS(int IDempresa, int IDproceso, int IDperiodo, decimal IDEmpleado1, decimal IDEmpleado2, int IDtipo_nomina)
        {
            try
            {
                using (EntitiesRoles base_ = new EntitiesRoles())
                {
                    string query = "exec  spRo_procesa_Rol " + IDempresa + " , " + IDEmpleado1 + " , "
                        + IDEmpleado2 + ", " + IDtipo_nomina + ", " + IDproceso + ", "
                        + IDperiodo;
                    base_.Database.ExecuteSqlCommand(query);
                    
                    

                    return true;

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

// haac 09/01/2014
        public Boolean Pago_Decimo_XIII(int IdPeriodo_Ini, int IdPeriodo_Fin)
        {
            try
            {
                using (EntitiesRoles base_ = new EntitiesRoles())
                {
                    string query = "exec  spRo_Calcula_Pago_XIII " + IdPeriodo_Ini + " , " + IdPeriodo_Fin;
                    base_.Database.ExecuteSqlCommand(query);

                    

                    return true;

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
        }// haac 09/01/2014

        public Boolean InsertaCalculosIESS_x_empleado(List<ro_Ing_Egre_x_Empleado> List , ref string msg)
        {
            try
            {

                using (EntitiesRoles oEnt = new EntitiesRoles())
                {
                    var i = List.First();
                    string q = "delete ro_Ing_Egre_x_Empleado where IdEmpresa = {0} and IdNomina_Tipo = {1} and IdNomina_TipoLiqui = {2} and IdRubro = {3} and IdPeriodo = {4} and IdEmpleado = {5}";
                     string qy = string.Format(q, i.IdEmpresa, i.IdNomina_Tipo, i.IdNomina_TipoLiqui, i.IdRubro, i.IdPeriodo, i.IdEmpleado );
                                oEnt.Database.ExecuteSqlCommand(qy);

                    foreach (ro_Ing_Egre_x_Empleado reg in List)
                    {
                        Boolean resul = false;
                        try
                        {
                           
                                oEnt.ro_Ing_Egre_x_Empleado.Add(reg);
                           
                        }
                        catch (Exception ex)
                        {
                            string arreglo = ToString();
                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                            mensaje = ex.InnerException + " " + ex.Message;
                            msg = ex.InnerException.ToString();
                        }
                    }
                    oEnt.SaveChanges();
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
        public Boolean InsertaCalculosIESS(List<ro_Ing_Egre_x_Empleado> List, List<ro_Config_Rubros_ParametrosGenerales_Info> listaeli,  ref string msg)
        {
            try
            {

                using (EntitiesRoles oEnt = new EntitiesRoles())
                {
                    var i = List.First();
                    foreach (var ie in listaeli)
                    {
                        string q = "delete ro_Ing_Egre_x_Empleado where IdEmpresa = {0} and IdNomina_Tipo = {1} and IdNomina_TipoLiqui = {2} and IdRubro = {3} and IdPeriodo = {4}";
                        string qy = string.Format(q, i.IdEmpresa, i.IdNomina_Tipo, i.IdNomina_TipoLiqui, ie.IdRubro, i.IdPeriodo);
                        oEnt.Database.ExecuteSqlCommand(qy);
                    }
                  

                    foreach (ro_Ing_Egre_x_Empleado reg in List)
                    {
                        Boolean resul = false;
                        try
                        {

                            oEnt.ro_Ing_Egre_x_Empleado.Add(reg);

                        }
                        catch (Exception ex)
                        {
                            string arreglo = ToString();
                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                            mensaje = ex.InnerException + " " + ex.Message;
                            msg = ex.InnerException.ToString();
                        }
                    }
                    oEnt.SaveChanges();
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
