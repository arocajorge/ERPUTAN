using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.General
{
   public class tb_persona_direccion_Data
    {

        string mensaje = "";

        public Boolean GuardarDB(tb_persona_direccion_Info Info, ref int IdDireccion, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = new tb_persona_direccion();
                    Address.IdDireccion = Info.IdDireccion = IdDireccion = GetId(Info.IdPersona);
                    Address.IdPersona = Info.IdPersona;
                    Address.Direccion = Info.Direccion;
                    Address.estado = Info.estado;
                    Address.prioridad = Info.prioridad;
                    Address.referencia = Info.referencia;

                    Address.calle = Info.calle;
                    Address.Ciudad = Info.Ciudad;
                    Address.cod_postal = Info.cod_postal;
                    Address.IdTipoDireccion = Info.IdTipoDireccion;

                    Context.tb_persona_direccion.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId(decimal IdPersona)
        {
            try
            {
                int Id;
                EntitiesGeneral ocxc = new EntitiesGeneral();
                var select = (from q in ocxc.tb_persona_direccion
                              where q.IdPersona == IdPersona
                              select q);

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in ocxc.tb_persona_direccion
                                     where q.IdPersona == IdPersona
                                     select q.IdDireccion).Max();

                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_persona_direccion_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var contact = Context.tb_persona_direccion.FirstOrDefault(af => af.IdPersona == Info.IdPersona && af.IdDireccion==Info.IdDireccion);
                    if (contact != null)
                    {
                        contact.Direccion = Info.Direccion;
                        contact.estado = Info.estado;
                        contact.prioridad = Info.prioridad;
                        contact.referencia = Info.referencia;
                        contact.calle = Info.calle;
                        contact.Ciudad = Info.Ciudad;
                        contact.cod_postal = Info.cod_postal;
                        contact.IdTipoDireccion = Info.IdTipoDireccion;

                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(List<tb_persona_direccion_Info> ListInfo, ref string msjError)
        {
            try
            {
                foreach (var item in ListInfo)
                {
                    ModificarDB(item, ref msjError);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(decimal IdPersona,int IdDireccion, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var contact = Context.tb_persona_direccion.FirstOrDefault(af => af.IdPersona == IdPersona && af.IdDireccion == IdDireccion);
                    if (contact != null)
                    {
                        contact.estado = false;
                        //contact.IdUsuarioUltAnu = Info_Pais.IdUsuarioUltAnu;
                        //contact.Fecha_UltAnu = Info_Pais.Fecha_UltAnu;
                        //contact.MotivoAnula = Info_Pais.MotivoAnula;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_persona_direccion_Info> Get_List_persona_direccion(decimal IdPersona)
        {
            try
            {
                List<tb_persona_direccion_Info> lstPais = new List<tb_persona_direccion_Info>();
                EntitiesGeneral objEnti = new EntitiesGeneral();

                var pais = from p in objEnti.tb_persona_direccion
                           where p.IdPersona == IdPersona
                           select p;

                foreach (var item in pais)
                {
                    tb_persona_direccion_Info info = new tb_persona_direccion_Info();
                    info.IdPersona = item.IdPersona;
                    info.IdDireccion = item.IdDireccion;
                    info.prioridad = item.prioridad;
                    info.Direccion = item.Direccion;
                    info.referencia = item.referencia;
                    info.estado = item.estado;

                    info.calle = item.calle;
                    info.Ciudad = item.Ciudad;
                    info.cod_postal = item.cod_postal;
                    info.IdTipoDireccion = item.IdTipoDireccion;
                    lstPais.Add(info);
                }

                return lstPais;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_direccion_Info Get_Info_persona_direccion(decimal IdPersona,int IdDireccion)
        {
            try
            {
                tb_persona_direccion_Info info = new tb_persona_direccion_Info();
                EntitiesGeneral objEnti = new EntitiesGeneral();
                
                var pais = from p in objEnti.tb_persona_direccion
                           where p.IdPersona == IdPersona
                           && p.IdDireccion == IdDireccion
                           select p;

                foreach (var item in pais)
                {
                    info = new tb_persona_direccion_Info();
                    info.Direccion = item.Direccion;
                    info.estado = item.estado;
                    info.IdDireccion = item.IdDireccion;
                    info.IdPersona = item.IdPersona;
                    info.prioridad = item.prioridad;
                    info.referencia = item.referencia;

                    info.calle = item.calle;
                    info.Ciudad = item.Ciudad;
                    info.cod_postal = item.cod_postal;
                    info.IdTipoDireccion = item.IdTipoDireccion;

                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(tb_persona_direccion_Info Info, decimal IdPersona, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var Address = new tb_persona_direccion();
                    Address.IdDireccion = GetId(IdPersona);
                    Address.IdPersona = IdPersona;
                    Address.Direccion = Info.Direccion;
                    Address.estado = true;
                    Address.prioridad = 0;
                    Address.IdTipoDireccion = Info.IdTipoDireccion;
                    Context.tb_persona_direccion.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<tb_persona_direccion_Info> Lista, decimal IdPersona, ref string msg)
        {
            try
            {
                foreach (var item in Lista)
                {
                    GuardarDB(item, IdPersona, ref msg);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Eliminar( decimal IdPersona, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("delete from tb_persona_direccion where IdPersona= " + IdPersona + "");
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
                throw new Exception(ex.ToString());
            }
        }
    }
}