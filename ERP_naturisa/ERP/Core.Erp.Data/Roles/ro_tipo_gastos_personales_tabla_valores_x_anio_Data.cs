using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Roles;
namespace Core.Erp.Data.Roles
{
   public class ro_tipo_gastos_personales_tabla_valores_x_anio_Data
    {
       string mensaje = "";
        public int getId()
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_tipo_gastos_personales_tabla_valores_x_anio
                            
                             select q;

                if (select.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_tipo_gastos_personales_tabla_valores_x_anio
                                     
                                     select q.IdGasto).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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

        public Boolean GuardarDB(List< ro_tipo_gastos_personales_tabla_valores_x_anio_Info> List_Info, ref string msg)
        {
            try
            {
                foreach (var item in List_Info)
                {
                    using (EntitiesRoles Context = new EntitiesRoles())
                    {
                        var Address = new ro_tipo_gastos_personales_tabla_valores_x_anio();

                        Address.IdGasto = getId();
                        Address.IdTipoGasto = item.IdTipoGasto;
                        Address.AnioFiscal = item.AnioFiscal;
                        Address.observacion = item.observacion;
                        Address.Monto_max = item.Monto_max;
                        Address.IdUsuario = item.IdUsuario;
                        Address.Fecha_Transac = item.Fecha_Transac;
                        Address.estado = "A";
                        Context.ro_tipo_gastos_personales_tabla_valores_x_anio.Add(Address);
                        Context.SaveChanges();
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

        public List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> Get_List_tipo_gastos_personales_tabla_valores_x_anio(int Anio)
        {
           
            bool BanderaSiDatos = false;
            List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> Lst = new List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.vwRo_ro_tipo_gastos_personales_tabla_valores_x_anio
                            where q.AnioFiscal == Anio
                            select q;
                foreach (var item in Query)
                {
                    BanderaSiDatos = true;
                    ro_tipo_gastos_personales_tabla_valores_x_anio_Info Obj = new ro_tipo_gastos_personales_tabla_valores_x_anio_Info();
                    Obj.IdGasto =(int) item.IdGasto;
                    Obj.IdTipoGasto = item.IdTipoGasto;
                    Obj.observacion = item.observacion;
                    Obj.estado = item.estado;
                    Obj.Monto_max =(double) item.Monto_max;
                    Obj.IdTipoGasto=item.IdTipoGasto;
                    Obj.nom_tipo_gasto = item.nom_tipo_gasto;
                    Obj.AnioFiscal =(int) item.AnioFiscal;
                    Lst.Add(Obj);
                }

                if (BanderaSiDatos == false)
                {
                    using (EntitiesRoles Ro = new EntitiesRoles())
                    {
                        var Quer = from q in oEnti.ro_tipo_gastos_personales
                                    select q;
                        foreach (var item in Quer)
                        {
                         ro_tipo_gastos_personales_tabla_valores_x_anio_Info Obj = new ro_tipo_gastos_personales_tabla_valores_x_anio_Info();
                         Obj.IdTipoGasto = item.IdTipoGasto;
                         Obj.nom_tipo_gasto = item.nom_tipo_gasto;
                         Obj.AnioFiscal = Anio;
                         Lst.Add(Obj); 
                        }
                        
                    } 
                    
                }
                return Lst;
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

        public Boolean ModificarDB(List< ro_tipo_gastos_personales_tabla_valores_x_anio_Info > List_Info, ref string msg)
        {
            try
            {
                foreach (var item in List_Info)
                { 
                    using (EntitiesRoles context = new EntitiesRoles())
                     {
                    var contact = context.ro_tipo_gastos_personales_tabla_valores_x_anio.First(minfo => minfo.IdGasto == item.IdGasto && minfo.IdTipoGasto== item.IdTipoGasto&& minfo.AnioFiscal==item.AnioFiscal);
                    contact.observacion = item.observacion;
                    contact.estado = item.estado;
                    contact.Monto_max = item.Monto_max;
                    contact.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    contact.Fecha_UltMod = item.Fecha_UltMod;
                    contact.MotiAnula = "";
                    context.SaveChanges();
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

       
       public Boolean Anular(List< ro_tipo_gastos_personales_tabla_valores_x_anio_Info >List_Info, ref string msg)
        {
           try
            {
                foreach (var item in List_Info)
                { 
                    using (EntitiesRoles context = new EntitiesRoles())
                     {
                    var contact = context.ro_tipo_gastos_personales_tabla_valores_x_anio.First(minfo => minfo.IdGasto == item.IdGasto && minfo.IdTipoGasto== item.IdTipoGasto&& minfo.AnioFiscal==item.AnioFiscal);
                    contact.estado = "I";
                    contact.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    contact.Fecha_UltAnu = item.Fecha_UltAnu;
                    contact.MotiAnula = item.MotivoAnula;
                    context.SaveChanges();
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

       public bool SiExiste(int Anio)
        {

            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.vwRo_ro_tipo_gastos_personales_tabla_valores_x_anio
                            where q.AnioFiscal == Anio
                            select q;
                if (Query.Count() >0)
                {
                    return true;
                }
                else
                {
                    return false;
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
    }
}

    

