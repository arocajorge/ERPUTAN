/*CLASE: ro_empleado_gastos_perso_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 03-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
    public class ro_empleado_gastos_perso_Data
    {
        string mensaje = "";
        public List<ro_empleado_gastos_perso_Info> Get_List_empleado_gastos_perso(int IdEmpresa) 
        {
             List<ro_empleado_gastos_perso_Info> lst = new List<ro_empleado_gastos_perso_Info>();      
            try
            {
          
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_empleado_gastos_perso
                                   where q.IdEmpresa == IdEmpresa
                                   orderby q.IdEmpleado
                                   select q;
                    foreach (var item in Consulta)
                    {
                        ro_empleado_gastos_perso_Info info = new ro_empleado_gastos_perso_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Anio_fiscal = item.Anio_fiscal;
                        info.fecha = item.fecha;
                        info.observacion = item.observacion;
                        info.Estado = item.Estado;
                        info.Tipo_Iden = item.Tipo_Iden;
                        info.Num_Identificacion = item.Num_Identificacion;
                        info.Apellidos_Nombres = item.Apellidos_Nombres;
                        info.telefono = item.telefono;
                        info.calle_prin = item.calle_prin;
                        info.Numero = item.Numero;
                        info.Intersecion = item.Intersecion;
                        info.IdProvincia = item.IdProvincia;
                        info.IdCidudad = item.IdCidudad;
                        lst.Add(info);                        
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_empleado_gastos_perso_Info> Get_Info_empleado_gastos_pers(int IdEmpresa, int IdEmpleado, int anio)
        {
               List<ro_empleado_gastos_perso_Info> lst = new List<ro_empleado_gastos_perso_Info>();
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_empleado_gastos_perso
                                                             where q.IdEmpresa == IdEmpresa
                                                             && q.IdEmpleado == IdEmpleado
                                                             && q.Anio_fiscal == anio
                                                             orderby q.IdEmpleado
                                                             select q;
                    foreach (var item in Consulta)
                    {
                        ro_empleado_gastos_perso_Info info = new ro_empleado_gastos_perso_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Anio_fiscal = item.Anio_fiscal;
                        info.fecha = item.fecha;
                        info.observacion = item.observacion;
                        info.Estado = item.Estado;
                        info.Tipo_Iden = item.Tipo_Iden;
                        info.Num_Identificacion = item.Num_Identificacion;
                        info.Apellidos_Nombres = item.Apellidos_Nombres;
                        info.telefono = item.telefono;
                        info.calle_prin = item.calle_prin;
                        info.Numero = item.Numero;
                        info.Intersecion = item.Intersecion;
                        info.IdProvincia = item.IdProvincia;
                        info.IdCidudad = item.IdCidudad;
                        lst.Add(info);                        
                    }
                }
                return lst;                                                      
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean GetExiste(ro_empleado_gastos_perso_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_empleado_gastos_perso
                               where a.IdEmpresa==info.IdEmpresa && a.IdEmpleado==info.IdEmpleado
                               && a.Anio_fiscal==info.Anio_fiscal
                               select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean GuardarBD(ro_empleado_gastos_perso_Info info, ref string msg){
            try
            {
                    using (EntitiesRoles db = new EntitiesRoles())
                    {
                        ro_empleado_gastos_perso item = new ro_empleado_gastos_perso();
                        item.IdEmpleado = info.IdEmpleado;
                        item.Anio_fiscal = info.Anio_fiscal;
                        item.fecha = info.fecha;
                        item.observacion = info.observacion;
                        item.Estado = info.Estado;
                        item.Tipo_Iden = info.Tipo_Iden;
                        item.Num_Identificacion = info.Num_Identificacion;
                        item.Apellidos_Nombres = info.Apellidos_Nombres;
                        item.telefono = info.telefono;
                        item.calle_prin = info.calle_prin;
                        item.Numero = info.Numero;
                        item.Intersecion = info.Intersecion;
                        item.IdProvincia = info.IdProvincia;
                        item.IdCidudad = info.IdCidudad;
                        item.IdEmpresa = info.IdEmpresa;

                        db.ro_empleado_gastos_perso.Add(item);
                        db.SaveChanges();
                    }                    
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje =msg= ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }                                            
        }



        public Boolean ModificarBD(ro_empleado_gastos_perso_Info info, ref string msg)
        {
            try
            {


                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_empleado_gastos_perso item = (from a in db.ro_empleado_gastos_perso
                                                    where a.IdEmpresa==info.IdEmpresa && a.IdEmpleado==info.IdEmpleado
                                                    && a.Anio_fiscal==info.Anio_fiscal
                                                    select a).FirstOrDefault();

                    item.fecha = info.fecha;
                    item.observacion = info.observacion;
                    item.Estado = info.Estado;
                    item.Tipo_Iden = info.Tipo_Iden;
                    item.Num_Identificacion = info.Num_Identificacion;
                    item.Apellidos_Nombres = info.Apellidos_Nombres;
                    item.telefono = info.telefono;
                    item.calle_prin = info.calle_prin;
                    item.Numero = info.Numero;
                    item.Intersecion = info.Intersecion;
                    item.IdProvincia = info.IdProvincia;
                    item.IdCidudad = info.IdCidudad;
                    item.IdEmpresa = info.IdEmpresa;
                    
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        
        
        
        
        public Boolean EliminarEmpleadoGastosPersona(ro_empleado_gastos_perso_Info info) {
            try
            {
                using (EntitiesRoles ro = new EntitiesRoles())
                {
                    ro_empleado_gastos_perso EmpleadoGastosPerso = ro.ro_empleado_gastos_perso.First(v => v.IdEmpleado == info.IdEmpleado && v.Anio_fiscal == info.Anio_fiscal && v.IdEmpresa == info.IdEmpresa);
                    ro.ro_empleado_gastos_perso.Remove(EmpleadoGastosPerso);
                    ro.SaveChanges();               
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }            
        }       

    }
}
