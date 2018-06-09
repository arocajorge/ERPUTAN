using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Roles
{
    public class ro_Tipo_Prestamo_Data
    {
        string mensaje = "";
        public Boolean GuardarDB( ro_Tipo_Prestamo_Info Info)
        {
            try
            {
                List<ro_Tipo_Prestamo_Info> Lst = new List<ro_Tipo_Prestamo_Info>();
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    var Address = new ro_Tipo_Prestamo();

                    Info.IdTipoPrestamo = getId(Info.IdEmpresa);
                    if (Info.tp_Orden <= 0)
                        Info.tp_Orden = getOrden(Info.IdEmpresa);
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdTipoPrestamo = Info.IdTipoPrestamo;
                    Address.tp_Descripcion = Info.tp_Descripcion;
                    Address.tp_Antiguedad = Info.tp_Antiguedad;
                    Address.tp_Monto = Info.tp_Monto;
                    Address.tp_Indice = Info.tp_Indice;
                    Address.tp_Orden = Info.tp_Orden;
                    Address.tp_Estado = Info.tp_Estado;

                    Context.ro_Tipo_Prestamo.Add(Address);
                    Context.SaveChanges();
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

        public List<ro_Tipo_Prestamo_Info> Get_List_Tipo_Prestamo(int IdEmpresa)
        {
                List<ro_Tipo_Prestamo_Info> Lst = new List<ro_Tipo_Prestamo_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_Tipo_Prestamo
                            where q.IdEmpresa == IdEmpresa
                            orderby q.tp_Orden
                            select q;

                foreach (var item in Query)
                {
                    ro_Tipo_Prestamo_Info Obj = new ro_Tipo_Prestamo_Info();

                    Obj.IdEmpresa = IdEmpresa;

                    Obj.IdTipoPrestamo = item.IdTipoPrestamo;
                    Obj.tp_Descripcion = item.tp_Descripcion;
                    Obj.tp_Antiguedad = item.tp_Antiguedad;
                    Obj.tp_Monto = item.tp_Monto;
                    Obj.tp_Indice = item.tp_Indice;
                    Obj.tp_Orden = item.tp_Orden;
                    Obj.tp_Estado = item.tp_Estado;
                    Obj.MotiAnula = item.MotivoAnulacion;

                    Lst.Add(Obj);
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

        public ro_Tipo_Prestamo_Info Get_Info_Tipo_Prestamo(int IdEmpresa, int IdTPrestamo)
        {
            EntitiesRoles oEnti = new EntitiesRoles();         
            ro_Tipo_Prestamo_Info Info = new ro_Tipo_Prestamo_Info();
            try
            {
                var Objeto = oEnti.ro_Tipo_Prestamo.First(var => var.IdEmpresa == IdEmpresa && var.IdTipoPrestamo == IdTPrestamo);

                Info.IdTipoPrestamo = Objeto.IdTipoPrestamo;
                Info.tp_Descripcion = Objeto.tp_Descripcion;
                Info.tp_Antiguedad = Objeto.tp_Antiguedad;
                Info.tp_Monto = Objeto.tp_Monto;
                Info.tp_Indice = Objeto.tp_Indice;
                Info.tp_Orden = Objeto.tp_Orden;
                Info.tp_Estado = Objeto.tp_Estado;

                return Info;
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

        public Boolean ModificarDB(ro_Tipo_Prestamo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_Tipo_Prestamo.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdTipoPrestamo == info.IdTipoPrestamo);

                    contact.tp_Descripcion = info.tp_Descripcion;
                    contact.tp_Antiguedad = info.tp_Antiguedad;
                    contact.tp_Monto = info.tp_Monto;
                    contact.tp_Indice = info.tp_Indice;
                    contact.tp_Orden = info.tp_Orden;
                    contact.tp_Estado = info.tp_Estado;
                    contact.MotivoAnulacion = "";
                    context.SaveChanges();

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

        public Boolean AnularDB(ro_Tipo_Prestamo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Tipo_Prestamo.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdTipoPrestamo == info.IdTipoPrestamo);
                    contact.tp_Estado = "I";
                    contact.MotivoAnulacion = info.MotiAnula;
                    context.SaveChanges();
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

        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_Tipo_Prestamo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_Tipo_Prestamo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdTipoPrestamo).Max();
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

        public int getOrden(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_Tipo_Prestamo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_Tipo_Prestamo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.tp_Orden).Max();
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
        

    }
}
