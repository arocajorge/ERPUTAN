using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Roles
{
  public  class ro_Capacitaciones_x_Empleado_Data
  {
      string mensaje = "";

        public Boolean GuardarDB(List<ro_Capacitaciones_x_Empleado_Info> LstInfo)
        {
            try
            {
                int sec = 0;

                foreach (var item in LstInfo)
                {
                    sec=sec+1;

                    using (EntitiesRoles Context = new EntitiesRoles())
                    {
                        var Address = new ro_Capacitaciones_x_Empleado();

                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdEmpleado = item.IdEmpleado;
                        Address.Secuencia = sec;
                        Address.Instititucion = item.Institucion;
                        Address.NombreCurso = item.NombreCurso;
                        Address.Observacion = item.Observacion;
                        Address.Horas = item.Horas;
                        Context.ro_Capacitaciones_x_Empleado.Add(Address);
                        Context.SaveChanges();

                    }
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

        public List<ro_Capacitaciones_x_Empleado_Info> Get_List_Capacitaciones_x_Empleado(int idempresa, decimal idempleado)
        {
            List<ro_Capacitaciones_x_Empleado_Info> Lst = new List<ro_Capacitaciones_x_Empleado_Info>();
            EntitiesRoles oEnti = new EntitiesRoles();
            try
            {


                var Query = from q in oEnti.ro_Capacitaciones_x_Empleado
                            where q.IdEmpresa == idempresa && q.IdEmpleado == idempleado
                            select q;
                foreach (var item in Query)
                {

                    ro_Capacitaciones_x_Empleado_Info Obj = new ro_Capacitaciones_x_Empleado_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEmpleado = item.IdEmpleado;
                    Obj.Institucion = item.Instititucion;
                    Obj.NombreCurso = item.NombreCurso;
                    Obj.Horas = item.Horas;
                    Obj.Observacion = item.Observacion;
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


        public Boolean EliminarDB(List<ro_Capacitaciones_x_Empleado_Info> List)
        {
            try
            {


                int d=0;

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    // pregunto si existe documentos por ese empleado para que no se caiga

                    ro_Capacitaciones_x_Empleado_Info info = List.FirstOrDefault();
                   
                    
                    
                    if (List.Count() > 0)
                    {

                        var Query = from q in context.ro_Capacitaciones_x_Empleado
                                    where q.IdEmpresa == info.IdEmpresa && q.IdEmpleado == info.IdEmpleado
                                    select q;


                        if (Query.Count() > 0)
                        {
                            foreach (var item in Query.ToList())
                            {
                                var address = context.ro_Capacitaciones_x_Empleado.First(A => A.IdEmpresa == item.IdEmpresa
                                             && A.IdEmpleado == item.IdEmpleado && A.Secuencia== item.Secuencia);

                                context.ro_Capacitaciones_x_Empleado.Remove(address);

                                context.SaveChanges();
                            }

                        }

                    }
                    // msg = "Guardado con exito";
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
    }
}
