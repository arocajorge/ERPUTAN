using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_orden_trabajo_plataforma_Data
    {
        string MensajeError = "";
        fa_orden_trabajo_plataforma_det_Data oData_det = new fa_orden_trabajo_plataforma_det_Data();

        public List<fa_orden_trabajo_plataforma_Info> Get_List_Orden_trabajo(int idEmpresa)
        {
            try
            {
                List<fa_orden_trabajo_plataforma_Info> Lista = new List<fa_orden_trabajo_plataforma_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_orden_trabajo_plataforma
                              where idEmpresa == q.IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        fa_orden_trabajo_plataforma_Info info = new fa_orden_trabajo_plataforma_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdOrdenTrabajo_Pla = item.IdOrdenTrabajo_Pla;
                        info.codOrdenTrabajo_Pla = item.codOrdenTrabajo_Pla;
                        info.IdCliente = item.IdCliente;
                        info.Descripcion = item.Descripcion;
                        info.Equipo = item.Equipo;
                        info.serie = item.serie;
                        info.Fecha = item.Fecha;
                        info.km_salida = item.km_salida;
                        info.km_llegada = item.km_llegada;
                        info.con_atencion_a = item.con_atencion_a;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_orden_trabajo_plataforma_Info Get_Info_Orden_trabajo(int idEmpresa, decimal IdOrdenTrabajo_Pla)
        {
            try
            {
                fa_orden_trabajo_plataforma_Info info = new fa_orden_trabajo_plataforma_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_orden_trabajo_plataforma Entity = Context.fa_orden_trabajo_plataforma.FirstOrDefault(q => q.IdEmpresa == idEmpresa && q.IdOrdenTrabajo_Pla == IdOrdenTrabajo_Pla);
                    if (Entity != null)
                    {   
                        info.IdEmpresa = Entity.IdEmpresa;
                        info.IdOrdenTrabajo_Pla = Entity.IdOrdenTrabajo_Pla;
                        info.codOrdenTrabajo_Pla = Entity.codOrdenTrabajo_Pla;
                        info.IdCliente = Entity.IdCliente;
                        info.Descripcion = Entity.Descripcion;
                        info.Equipo = Entity.Equipo;
                        info.Fecha = Entity.Fecha;
                        info.serie = Entity.serie;
                        info.km_salida = Entity.km_salida;
                        info.km_llegada = Entity.km_llegada;
                        info.con_atencion_a = Entity.con_atencion_a;
                        info.IdUsuarioUltMod = Entity.IdUsuarioUltMod;
                        info.Fecha_UltMod = Entity.Fecha_UltMod;
                        info.IdUsuarioUltAnu = Entity.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = Entity.Fecha_UltAnu;
                        info.MotiAnula = Entity.MotiAnula;
                        info.nom_pc = Entity.nom_pc;
                        info.ip = Entity.ip;
                        info.Estado = Entity.Estado;                       
                    }
                }
                if(info!=null)
                info.lst_Det_Orden = oData_det.Get_List_Orden_trabajo_Det(info.IdEmpresa, info.IdOrdenTrabajo_Pla);

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal Get_Id(int idEmpresa)
        {
            try
            {
                int Id;
                Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();

                var selecte = db.fa_orden_trabajo_plataforma.Count(q => q.IdEmpresa == idEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.fa_orden_trabajo_plataforma
                                     where q.IdEmpresa == idEmpresa
                                     select q.IdOrdenTrabajo_Pla).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(fa_orden_trabajo_plataforma_Info info, ref decimal IdOrdenTrabajo_Pla)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_orden_trabajo_plataforma Entity = new fa_orden_trabajo_plataforma();

                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdOrdenTrabajo_Pla = info.IdOrdenTrabajo_Pla = IdOrdenTrabajo_Pla = Get_Id(info.IdEmpresa);
                    Entity.codOrdenTrabajo_Pla = info.codOrdenTrabajo_Pla=="" || info.codOrdenTrabajo_Pla==null ? info.IdOrdenTrabajo_Pla.ToString() : info.codOrdenTrabajo_Pla;
                    Entity.IdCliente = info.IdCliente;
                    Entity.Descripcion = info.Descripcion;
                    Entity.Equipo = info.Equipo;
                    Entity.serie = info.serie;
                    Entity.Fecha = info.Fecha;
                    Entity.km_salida = info.km_salida;
                    Entity.km_llegada = info.km_llegada;
                    Entity.con_atencion_a = info.con_atencion_a;
                    Entity.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    Entity.Fecha_UltMod = info.Fecha_UltMod;
                    Entity.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    Entity.Fecha_UltAnu = info.Fecha_UltAnu;
                    Entity.MotiAnula = info.MotiAnula;
                    Entity.nom_pc = info.nom_pc;
                    Entity.ip = info.ip;
                    Entity.Estado = info.Estado;

                    Context.fa_orden_trabajo_plataforma.Add(Entity);
                    Context.SaveChanges();
                }
                foreach (var item in info.lst_Det_Orden)
                {
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdOrdenTrabajo_Pla = info.IdOrdenTrabajo_Pla;
                    item.hora_ini = TimeSpan.Parse(item.hora_ini_D.ToShortTimeString());
                    item.hora_fin = TimeSpan.Parse(item.hora_fin_D.ToShortTimeString());
                }
                oData_det.GuardarDB(info.lst_Det_Orden);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());                
            }
        }

        public bool ModificarDB(fa_orden_trabajo_plataforma_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_orden_trabajo_plataforma Entity = Context.fa_orden_trabajo_plataforma.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenTrabajo_Pla == info.IdOrdenTrabajo_Pla);
                    if (Entity!=null)
                    {
                        Entity.IdCliente = info.IdCliente;
                        Entity.Descripcion = info.Descripcion;
                        Entity.Equipo = info.Equipo;
                        Entity.Fecha = info.Fecha;
                        Entity.serie = info.serie;
                        Entity.km_salida = info.km_salida;
                        Entity.km_llegada = info.km_llegada;
                        Entity.con_atencion_a = info.con_atencion_a;
                        Entity.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        Entity.Fecha_UltMod = info.Fecha_UltMod;
                        Entity.nom_pc = info.nom_pc;
                        Entity.ip = info.ip;
                        Entity.Estado = info.Estado;
                        Context.SaveChanges();
                    }                   
                }

                oData_det.EliminarDB(info);
                oData_det = new fa_orden_trabajo_plataforma_det_Data();
                foreach (var item in info.lst_Det_Orden)
                {
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdOrdenTrabajo_Pla = info.IdOrdenTrabajo_Pla;
                    item.hora_ini = TimeSpan.Parse(item.hora_ini_D.ToShortTimeString());
                    item.hora_fin = TimeSpan.Parse(item.hora_fin_D.ToShortTimeString());
                }
                oData_det.GuardarDB(info.lst_Det_Orden);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(fa_orden_trabajo_plataforma_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_orden_trabajo_plataforma Entity = Context.fa_orden_trabajo_plataforma.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenTrabajo_Pla == info.IdOrdenTrabajo_Pla);
                    if (Entity != null)
                    {
                        Entity.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        Entity.Fecha_UltAnu = info.Fecha_UltAnu;
                        Entity.MotiAnula = info.MotiAnula;
                        Entity.Estado = "I";

                        Context.SaveChanges();
                    }
                }

                oData_det.EliminarDB(info);
                oData_det = new fa_orden_trabajo_plataforma_det_Data();
                oData_det.GuardarDB(info.lst_Det_Orden);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_orden_trabajo_plataforma_Info> Get_List_Vista_Orden_trabajo(int idEmpresa, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                List<fa_orden_trabajo_plataforma_Info> Lista = new List<fa_orden_trabajo_plataforma_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_orden_trabajo_plataforma
                              where idEmpresa == q.IdEmpresa
                              && fechaDesde<=q.Fecha && q.Fecha <= fechaHasta
                              select q;

                    foreach (var item in lst)
                    {
                        fa_orden_trabajo_plataforma_Info info = new fa_orden_trabajo_plataforma_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdOrdenTrabajo_Pla = item.IdOrdenTrabajo_Pla;
                        info.codOrdenTrabajo_Pla = item.codOrdenTrabajo_Pla;
                        info.IdCliente = item.IdCliente;
                        info.Descripcion = item.Descripcion;
                        info.Equipo = item.Equipo;
                        info.Fecha = item.Fecha;
                        info.serie = item.serie;
                        info.km_salida = item.km_salida;
                        info.km_llegada = item.km_llegada;
                        info.con_atencion_a = item.con_atencion_a;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.Estado = item.Estado;
                        info.nom_Cliente = item.nom_Cliente;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
