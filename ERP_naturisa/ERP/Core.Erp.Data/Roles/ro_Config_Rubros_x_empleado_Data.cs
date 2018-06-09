/*CLASE: ro_Config_Rubros_x_empleado_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 16-03-2015
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
    public class ro_Config_Rubros_x_empleado_Data
    {
        string mensaje = "";
        int d = 0;

        public Boolean GuardarDB(ro_Config_Rubros_x_empleado_Info Info, ref string msg)
        {
            try
            {
                List<ro_Config_Rubros_x_empleado_Info> Lst = new List<ro_Config_Rubros_x_empleado_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_Config_Rubros_x_empleado();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdRubro = Info.IdRubro;
                    Address.OrdenPres = getId(Info.IdEmpresa);
                    Address.Estado = "A";

                    Context.ro_Config_Rubros_x_empleado.Add(Address);
                    Context.SaveChanges();
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

        public Boolean GuardarDBIE(ro_Config_Rubros_x_empleado_Info Info)
        {
            try
            {
                List<ro_Config_Rubros_x_empleado_Info> Lst = new List<ro_Config_Rubros_x_empleado_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_Config_Rubros_x_empleado();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdRubro = Info.IdRubro;
                    Address.OrdenPres = (Info.OrdenPres == 1) ? getIdI(Info.IdEmpresa) : getIdE(Info.IdEmpresa);
                    //Address.OrdenPres = getId(Info.IdEmpresa);
                    Address.Estado = "A";

                    Context.ro_Config_Rubros_x_empleado.Add(Address);
                    Context.SaveChanges();
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
        
        public Boolean GuardarConfigRubroxEmpleadoI(List<ro_Config_Rubros_x_empleado_Info> Info, ref string msg)
        {
            try
            {                
                foreach (var item in Info){
                    GuardarDB(item,ref msg);    
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

        public Boolean GuardarConfigRubroxEmpleadoE(List<ro_Config_Rubros_x_empleado_Info> Info, ref string msg)
        {
            try
            {
                foreach (var item in Info)
                {
                    GuardarDB(item,ref msg);
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

        public Boolean ModificarDBIE(ro_Config_Rubros_x_empleado_Info Info,int d)
        {
            try
            {
                if (d == 1) {
                    BorrarConfigRubroxEmpleadoE(Info);
                }                                        
                    List<ro_Config_Rubros_x_empleado_Info> Lst = new List<ro_Config_Rubros_x_empleado_Info>();
                    using (EntitiesRoles Context = new EntitiesRoles())
                    {
                        var Address = new ro_Config_Rubros_x_empleado();

                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdRubro = Info.IdRubro;
                        //Address.OrdenPres = (Info.OrdenPres == 1) ? getIdI(Info.IdEmpresa) : getIdE(Info.IdEmpresa);
                        //Address.OrdenPres = getId(Info.IdEmpresa);
                        Address.OrdenPres = d;
                        Address.Estado = "A";

                        Context.ro_Config_Rubros_x_empleado.Add(Address);
                        Context.SaveChanges();
                    }       
                return true; }           
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

        public Boolean ModificarConfigRubroxEmpleadoI(List<ro_Config_Rubros_x_empleado_Info> Info)
        {
            try
            {                
                foreach (var item in Info)
                {
                    d++;
                    ModificarDBIE(item,d);
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

        public Boolean ModificarConfigRubroxEmpleadoE(List<ro_Config_Rubros_x_empleado_Info> Info)
        {
            try
            {                
                foreach (var item in Info)
                {
                    d++;
                    ModificarDBIE(item,d);
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

        public Boolean BorrarConfigRubroxEmpleadoE(ro_Config_Rubros_x_empleado_Info Info)
        {
            try
            {
                //31/10/2013
                using (EntitiesRoles context  = new EntitiesRoles())
                {                  
                        string query = "delete from ro_Config_Rubros_x_empleado where IdEmpresa = "+Info.IdEmpresa;
                        context.Database.ExecuteSqlCommand(query);                    
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

        public Boolean modificarEspecificoRubrosxEmpleado(ro_Config_Rubros_x_empleado_Info Info, string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Config_Rubros_x_empleado.First(
                        var => var.IdEmpresa == Info.IdEmpresa
                            && var.IdRubro == Info.IdRubro);

                    contact.OrdenPres = Info.OrdenPres;
                    contact.Estado = Info.Estado;

                    context.SaveChanges();
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

        public List<ro_Config_Rubros_x_empleado_Info> Get_List_Config_Rubros_x_empleado(int IdEmpresa)
        {
              List<ro_Config_Rubros_x_empleado_Info> Lst = new List<ro_Config_Rubros_x_empleado_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_Config_Rubros_x_empleado
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in Query)
                {
                    ro_Config_Rubros_x_empleado_Info Obj = new ro_Config_Rubros_x_empleado_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.OrdenPres = item.OrdenPres;
                    Obj.Estado = item.Estado;

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

        public List<ro_Config_Rubros_x_empleado_Info> Get_List_Config_Rubros_x_Ingreso(int IdEmpresa)
        {     
            int i = 0;//Contador de secuencia para que aparezca en pantalla
                List<ro_Config_Rubros_x_empleado_Info> Lst = new List<ro_Config_Rubros_x_empleado_Info>();
            try
            {
          
                EntitiesRoles oEnti = new EntitiesRoles();

                var Query = from q in oEnti.ro_Config_Rubros_x_empleado
                            join w in oEnti.ro_rubro_tipo
                            on q.IdRubro equals w.IdRubro
                            where w.ru_tipo == "I" && q.IdEmpresa == IdEmpresa
                            orderby q.OrdenPres
                            select new { q.IdEmpresa,q.IdRubro,q.Estado,q.OrdenPres};

                foreach (var item in Query)
                {
                    i++;//Contador de secuencia para que aparezca en pantalla
                    ro_Config_Rubros_x_empleado_Info Obj = new ro_Config_Rubros_x_empleado_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.OrdenPres = item.OrdenPres;
                    Obj.Estado = item.Estado;
                    Obj.Secuencia = i;
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

        public List<ro_Config_Rubros_x_empleado_Info> Get_List_Config_Rubros_x_Egreso(int IdEmpresa)
        {
                int i = 0;//Contador de secuencia para que aparezca en pantalla
                List<ro_Config_Rubros_x_empleado_Info> Lst = new List<ro_Config_Rubros_x_empleado_Info>();
                EntitiesRoles oEnti = new EntitiesRoles();
            try
            {
                var Query = from q in oEnti.ro_Config_Rubros_x_empleado
                            join w in oEnti.ro_rubro_tipo
                            on q.IdRubro equals w.IdRubro
                            where w.ru_tipo == "E" && q.IdEmpresa == IdEmpresa
                            orderby q.OrdenPres
                            select new { q.IdEmpresa, q.IdRubro, q.Estado, q.OrdenPres };

                foreach (var item in Query)
                {
                    i++;//Contador de secuencia para que aparezca en pantalla
                    ro_Config_Rubros_x_empleado_Info Obj = new ro_Config_Rubros_x_empleado_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.OrdenPres = item.OrdenPres;
                    Obj.Estado = item.Estado;
                    Obj.Secuencia = i;
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

        public ro_Config_Rubros_x_empleado_Info Get_Info_Config_Rubros(string IdRubro)
        {
            EntitiesRoles oEnti = new EntitiesRoles();
            ro_Config_Rubros_x_empleado_Info Info = new ro_Config_Rubros_x_empleado_Info();
            try
            {

                var Objeto = oEnti.ro_Config_Rubros_x_empleado.First(var => var.IdRubro == IdRubro);
                Info.IdEmpresa = Objeto.IdEmpresa;
                Info.OrdenPres = Objeto.OrdenPres;
                Info.Estado = Objeto.Estado;

                return Info;
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

        public Boolean ModificarDB(ro_Config_Rubros_x_empleado_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Config_Rubros_x_empleado.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdRubro == info.IdRubro);
                    contact.OrdenPres = info.OrdenPres;
                    contact.Estado = info.Estado;

                    context.SaveChanges();

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

        public Boolean Borrar(ro_Config_Rubros_x_empleado_Info Info)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Config_Rubros_x_empleado.FirstOrDefault(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdRubro == Info.IdRubro);

                    context.ro_Config_Rubros_x_empleado.Remove(contact);
                    context.SaveChanges();
                    context.Dispose();

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

        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_Config_Rubros_x_empleado
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_Config_Rubros_x_empleado
                                     where q.IdEmpresa == IdEmpresa
                                     select q.OrdenPres).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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
         
        public int getIdI(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles oEnti = new EntitiesRoles();

                var select = from q in oEnti.ro_Config_Rubros_x_empleado
                            join w in oEnti.ro_rubro_tipo
                            on q.IdRubro equals w.IdRubro
                            where w.ru_tipo == "I" && q.IdEmpresa == IdEmpresa
                            select new { q.IdEmpresa, q.IdRubro, q.Estado, q.OrdenPres};

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in oEnti.ro_Config_Rubros_x_empleado
                                     join w in oEnti.ro_rubro_tipo
                                     on q.IdRubro equals w.IdRubro
                                     where w.ru_tipo == "I" && q.IdEmpresa == IdEmpresa
                                     select new {q.OrdenPres}).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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
        
        public int getIdE(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles oEnti = new EntitiesRoles();

                var select = from q in oEnti.ro_Config_Rubros_x_empleado
                             join w in oEnti.ro_rubro_tipo
                             on q.IdRubro equals w.IdRubro
                             where w.ru_tipo == "E" && q.IdEmpresa == IdEmpresa
                             select new { q.IdEmpresa, q.IdRubro, q.Estado, q.OrdenPres };

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in oEnti.ro_Config_Rubros_x_empleado
                                     join w in oEnti.ro_rubro_tipo
                                     on q.IdRubro equals w.IdRubro
                                     where w.ru_tipo == "E" && q.IdEmpresa == IdEmpresa
                                     select new { q.OrdenPres }).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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

        public Boolean modificarRubrosxEmpleado(ro_Config_Rubros_x_empleado_Info Info, string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Config_Rubros_x_empleado.First(
                        var => var.IdEmpresa == Info.IdEmpresa
                            && var.IdRubro == Info.IdRubro);

                    contact.OrdenPres = Info.OrdenPres;
                    contact.Estado = Info.Estado;
                    
                    context.SaveChanges();
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
