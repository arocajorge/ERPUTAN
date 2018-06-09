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
    public class fa_registro_unidades_x_equipo_Data
    {
        string MensajeError = "";
        fa_registro_unidades_x_equipo_det_Data oData_det = new fa_registro_unidades_x_equipo_det_Data();

        public List<fa_registro_unidades_x_equipo_Info> Get_List(int idEmpresa)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_Info> Lista = new List<fa_registro_unidades_x_equipo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_registro_unidades_x_equipo
                              where idEmpresa == q.IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_Info info = new fa_registro_unidades_x_equipo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRegistro = item.IdRegistro;
                        info.Fecha = item.Fecha;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Observacion = item.Observacion;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                        info.Lst_det = oData_det.Get_List_det(info);
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

        public List<fa_registro_unidades_x_equipo_Info> Get_List_Vista(int idEmpresa, DateTime Fecha_Ini, DateTime Fecha_Fin)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_Info> Lista = new List<fa_registro_unidades_x_equipo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_registro_unidades_x_equipo
                              where idEmpresa == q.IdEmpresa
                              && Fecha_Ini <= q.Fecha && q.Fecha <= Fecha_Fin
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_Info info = new fa_registro_unidades_x_equipo_Info();
                        info.IdRegistro = item.IdRegistro;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Fecha = item.Fecha;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Observacion = item.Observacion;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.Fecha_UltMod = item.Fecha_UltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = item.Fecha_UltAnu;
                        info.MotiAnula = item.MotiAnula;
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Cliente = item.nom_Cliente;
                        info.smes = item.smes;
                        info.Estado = item.Estado;
                        info.pe_FechaIni = item.pe_FechaIni==null ? DateTime.Now : (DateTime)item.pe_FechaIni;
                        info.pe_FechaFin = item.pe_FechaFin ==null ? DateTime.Now : (DateTime) item.pe_FechaFin;
                        info.IdEstadoRegistro_cat = item.IdEstadoRegistro_cat;
                        info.nom_EstadoRegistro_cat = item.nom_EstadoRegistro_cat;
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

        public fa_registro_unidades_x_equipo_Info Get_Info(int idEmpresa,decimal IdRegistro)
        {
            try
            {
                fa_registro_unidades_x_equipo_Info info = new fa_registro_unidades_x_equipo_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_registro_unidades_x_equipo Entity = Context.fa_registro_unidades_x_equipo.FirstOrDefault(q =>
                              idEmpresa == q.IdEmpresa && IdRegistro == q.IdRegistro);

                    if (Entity!=null)
                    {
                        info.IdEmpresa = Entity.IdEmpresa;
                        info.IdRegistro = Entity.IdRegistro;
                        info.IdPeriodo = Entity.IdPeriodo;
                        info.Fecha = Entity.Fecha;
                        info.IdCentroCosto = Entity.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = Entity.IdCentroCosto_sub_centro_costo;
                        info.IdPeriodo = Entity.IdPeriodo;
                        info.Observacion = Entity.Observacion;
                        info.IdUsuarioUltMod = Entity.IdUsuarioUltMod;
                        info.Fecha_UltMod = Entity.Fecha_UltMod;
                        info.IdUsuarioUltAnu = Entity.IdUsuarioUltAnu;
                        info.Fecha_UltAnu = Entity.Fecha_UltAnu;
                        info.MotiAnula = Entity.MotiAnula;
                        info.nom_pc = Entity.nom_pc;
                        info.ip = Entity.ip;
                        info.Estado = Entity.Estado;
                        info.IdEstadoRegistro_cat = Entity.IdEstadoRegistro_cat;
                        info.Estado = Entity.Estado;
                        info.Lst_det = oData_det.Get_List_det(info);
                    }                     
                }
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

        public Decimal Get_Id(int IdEmpresa)
        {
            try
            {
                Decimal Id = 0;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_registro_unidades_x_equipo
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        Id = lst.Max(q => q.IdRegistro) + 1;
                    }
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

        public Boolean GuardarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_registro_unidades_x_equipo Entity = new fa_registro_unidades_x_equipo();

                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdRegistro = info.IdRegistro = Get_Id(info.IdEmpresa);
                    Entity.IdPeriodo = info.IdPeriodo;
                    Entity.Fecha = info.Fecha;
                    Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                    Entity.Observacion = info.Observacion;
                    Entity.nom_pc = info.nom_pc;
                    Entity.ip = info.ip;
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.Estado = "A";
                    Entity.IdEstadoRegistro_cat = info.IdEstadoRegistro_cat;
                    Context.fa_registro_unidades_x_equipo.Add(Entity);
                    Context.SaveChanges();

                    if (info.Lst_det != null)
                    {
                        foreach (var item in info.Lst_det)
                        {
                            item.IdEmpresa = info.IdEmpresa;
                            item.IdRegistro = info.IdRegistro;
                            item.IdUnidad_Medida = " ";
                            item.IdTipo_Reg_cat = " ";
                        }
                        oData_det.GuardarDB(info.Lst_det);
                    }
                }
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

        public Boolean ModificarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_registro_unidades_x_equipo Entity = Context.fa_registro_unidades_x_equipo.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdRegistro == info.IdRegistro);
                    if (Entity!=null)
                    {
                        Entity.Fecha = info.Fecha;
                        Entity.Observacion = info.Observacion;

                        Entity.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        Entity.Fecha_UltMod = info.Fecha_UltMod;
                        Entity.nom_pc = info.nom_pc;
                        Entity.ip = info.ip;
                        Entity.IdEstadoRegistro_cat = info.IdEstadoRegistro_cat;
                        Context.SaveChanges();

                        foreach (var item in info.Lst_det)
                        {
                            item.IdEmpresa = info.IdEmpresa;
                            item.IdRegistro = info.IdRegistro;
                            item.IdUnidad_Medida = " ";
                            item.IdTipo_Reg_cat = " ";
                            item.IdPeriodo = info.IdPeriodo;
                        }
                        oData_det.EliminarDB(info);
                        oData_det.GuardarDB(info.Lst_det);
                    }                    
                }
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

        

        public Boolean AnularDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_registro_unidades_x_equipo Entity = Context.fa_registro_unidades_x_equipo.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdRegistro == info.IdRegistro);
                    if (Entity != null)
                    {
                        Entity.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        Entity.Fecha_UltAnu = info.Fecha_UltAnu;
                        Entity.MotiAnula = info.MotiAnula;
                        Entity.nom_pc = info.nom_pc;
                        Entity.ip = info.ip;
                        Entity.Estado = "I";
                        Entity.IdEstadoRegistro_cat = "EST_CERRADO";
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
