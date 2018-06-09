using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles_Fj
{
    public class ro_Calculo_Pago_Variable_Porcentaje_Data
    {
        string mensaje = "";

        public ro_Calculo_Pago_Variable_Porcentaje_Info Get_Info_Calculo_Pago_Porcentaje(int IdEmpresa, int IdTipo_Nomina)
        {
            try
            {
                ro_Calculo_Pago_Variable_Porcentaje_Info Info = new ro_Calculo_Pago_Variable_Porcentaje_Info();
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    var contact = from q in Context.ro_Calculo_Pago_Variable_Porcentaje
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdTipo_Nomina == IdTipo_Nomina
                                  select q;

                    foreach (var item in contact)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdTipo_Nomina = item.IdTipo_Nomina;
                        Info.IdEfectividad = item.IdEfectividad;
                        Info.Efec_Entrega_Rango = item.Efec_Entrega_Rango;
                        Info.Efec_Entrega_Aplica = item.Efec_Entrega_Aplica;
                        Info.Efec_Volumen_Rango = item.Efec_Volumen_Rango;
                        Info.Efec_Volumen_Aplica = item.Efec_Volumen_Aplica;
                        Info.Recup_Cartera_Rango = item.Recup_Cartera_Rango;
                        Info.Recup_Cartera_Aplica = item.Recup_Cartera_Aplica;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = item.Fecha_Transaccion;
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                    }
                }
                return Info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<ro_Calculo_Pago_Variable_Porcentaje_Info> Get_List_Calculo_Pago_Porcentaje(int IdEmpresa, int IdTipo_Nomina)
        {
            try
            {
                List<ro_Calculo_Pago_Variable_Porcentaje_Info> Lista_Calculo = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();
                
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    var contact = from q in Context.ro_Calculo_Pago_Variable_Porcentaje
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdTipo_Nomina == IdTipo_Nomina
                                  select q;

                    foreach (var item in contact)
                    {
                        ro_Calculo_Pago_Variable_Porcentaje_Info Info = new ro_Calculo_Pago_Variable_Porcentaje_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdTipo_Nomina = item.IdTipo_Nomina;
                        Info.IdEfectividad = item.IdEfectividad;
                        Info.Efec_Entrega_Rango = item.Efec_Entrega_Rango;
                        Info.Efec_Entrega_Aplica = item.Efec_Entrega_Aplica;
                        Info.Efec_Volumen_Rango = item.Efec_Volumen_Rango;
                        Info.Efec_Volumen_Aplica = item.Efec_Volumen_Aplica;
                        Info.Recup_Cartera_Rango = item.Recup_Cartera_Rango;
                        Info.Recup_Cartera_Aplica = item.Recup_Cartera_Aplica;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = item.Fecha_Transaccion;
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        Lista_Calculo.Add(Info);
                    }
                }
                return Lista_Calculo;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int Get_Id(int IdEmpresa, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                int Id;
                EntityRoles_FJ db = new EntityRoles_FJ();
                var selecte = db.ro_Calculo_Pago_Variable_Porcentaje.Count(q => q.IdEmpresa == IdEmpresa && q.IdTipo_Nomina == IdTipo_Nomina);
                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_Calculo_Pago_Variable_Porcentaje
                                     where q.IdEmpresa == IdEmpresa
                                     && q.IdTipo_Nomina == IdTipo_Nomina
                                     select q.IdEfectividad).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(ro_Calculo_Pago_Variable_Porcentaje_Info Info, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                IdTipo_Nomina = Get_Id(Info.IdEmpresa, Info.IdTipo_Nomina, ref mensaje);

                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    ro_Calculo_Pago_Variable_Porcentaje contact = new ro_Calculo_Pago_Variable_Porcentaje();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdTipo_Nomina = Info.IdTipo_Nomina;
                    contact.IdEfectividad = IdTipo_Nomina;
                    contact.Efec_Entrega_Rango = Info.Efec_Entrega_Rango;
                    contact.Efec_Entrega_Aplica = Info.Efec_Entrega_Aplica;
                    contact.Efec_Volumen_Rango = Info.Efec_Volumen_Rango;
                    contact.Efec_Volumen_Aplica = Info.Efec_Volumen_Aplica;
                    contact.Recup_Cartera_Rango = Info.Recup_Cartera_Rango;
                    contact.Recup_Cartera_Aplica = Info.Recup_Cartera_Aplica;
                    //campos de auditoria
                    contact.Estado = Info.Estado;
                    contact.IdUsuario = Info.IdUsuario;
                    contact.Fecha_Transaccion = Info.Fecha_Transaccion;
                    contact.nom_pc = Info.nom_pc;
                    contact.ip = Info.ip;

                    Context.ro_Calculo_Pago_Variable_Porcentaje.Add(contact);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(List<ro_Calculo_Pago_Variable_Porcentaje_Info> List_Info, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                foreach (var item in List_Info)
                {
                    GuardarDB(item, IdTipo_Nomina, ref mensaje);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(ro_Calculo_Pago_Variable_Porcentaje_Info Info, ref string mensaje)
        {
            try
            {
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    ro_Calculo_Pago_Variable_Porcentaje contact = Context.ro_Calculo_Pago_Variable_Porcentaje.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdTipo_Nomina == Info.IdTipo_Nomina);
                    if (contact != null)
                    {
                        contact.Efec_Entrega_Rango = Info.Efec_Entrega_Rango;
                        contact.Efec_Entrega_Aplica = Info.Efec_Entrega_Aplica;
                        contact.Efec_Volumen_Rango = Info.Efec_Volumen_Rango;
                        contact.Efec_Volumen_Aplica = Info.Efec_Volumen_Aplica;
                        contact.Recup_Cartera_Rango = Info.Recup_Cartera_Rango;
                        contact.Recup_Cartera_Aplica = Info.Recup_Cartera_Aplica;
                        contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;

                        contact.Fecha_UltMod = DateTime.Now;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(ro_Calculo_Pago_Variable_Porcentaje_Info Info, ref string mensaje)
        {
            try
            {
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    ro_Calculo_Pago_Variable_Porcentaje contact = Context.ro_Calculo_Pago_Variable_Porcentaje.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdTipo_Nomina == Info.IdTipo_Nomina);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.Estado = false;

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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, int IdTipo_Nomina, ref string mensaje)
        {
            try
            {
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    Context.Database.ExecuteSqlCommand("Delete Fj_servindustrias.ro_Calculo_Pago_Variable_Porcentaje Where IdEmpresa =" + IdEmpresa + "and IdTipo_Nomina =" + IdTipo_Nomina);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
