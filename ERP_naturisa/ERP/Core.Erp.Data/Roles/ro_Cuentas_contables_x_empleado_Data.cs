using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
  public  class ro_Cuentas_contables_x_empleado_Data
    {
        string mensaje = "";
        public List<ro_Cuentas_contables_x_empleado_Info> Get_List_Cuentas_contables_x_empleados(int IdEmpresa,decimal IdEmpleado)
        {
            List<ro_Cuentas_contables_x_empleado_Info> Lst = new List<ro_Cuentas_contables_x_empleado_Info>();
            try
            {
                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_Cuentas_contables_x_empleado
                            where q.IdEmpresa == IdEmpresa
                            && q.IdEmpleado==IdEmpleado
                            select q;

                foreach (var item in Query)
                {
                    ro_Cuentas_contables_x_empleado_Info Obj = new ro_Cuentas_contables_x_empleado_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdCtaCble = item.IdCtaCble;
                   
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Cuentas_contables_x_empleado_Info> Get_List_Cuentas_contables_x_empleados(int IdEmpresa)
        {
            List<ro_Cuentas_contables_x_empleado_Info> Lst = new List<ro_Cuentas_contables_x_empleado_Info>();
            try
            {
                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_Cuentas_contables_x_empleado
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in Query)
                {
                    ro_Cuentas_contables_x_empleado_Info Obj = new ro_Cuentas_contables_x_empleado_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdCtaCble = item.IdCtaCble;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

      public bool GuardarDB(List<ro_Cuentas_contables_x_empleado_Info> lista)
      {
           try
            {
                EntitiesRoles oEnti = new EntitiesRoles();


                foreach (var item in lista)
                {
                    ro_Cuentas_contables_x_empleado addres = new ro_Cuentas_contables_x_empleado();
                    addres.IdEmpresa = item.IdEmpresa;
                    addres.IdEmpleado = item.IdEmpleado;
                    addres.IdRubro = item.IdRubro;
                    addres.IdCtaCble = item.IdCtaCble;
                    oEnti.ro_Cuentas_contables_x_empleado.Add(addres);
                    oEnti.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
      }



      public bool EliminarDB(int IdEmpresa,decimal IdEmpleado)
      {
          try
          {
              EntitiesRoles oEnti = new EntitiesRoles();
              string SQL = "delete ro_Cuentas_contables_x_empleado where IdEmpresa='" + IdEmpresa + "' and IdEmpleado='"+IdEmpleado+"'";
              oEnti.Database.ExecuteSqlCommand(SQL);
             
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.InnerException.ToString());
          }
      }


    }
}
