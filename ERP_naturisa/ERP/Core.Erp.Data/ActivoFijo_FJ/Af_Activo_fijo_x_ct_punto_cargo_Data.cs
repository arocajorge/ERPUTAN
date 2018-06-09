using Core.Erp.Data.General;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.ActivoFijo_FJ
{
    public class Af_Activo_fijo_x_ct_punto_cargo_Data
    {
        public Af_Activo_fijo_x_ct_punto_cargo_Info Get_Info_x_Punto_cargo(int idEmpresa, int idPunto_cargo)
        {
            try
            {
                Af_Activo_fijo_x_ct_punto_cargo_Info info = new Af_Activo_fijo_x_ct_punto_cargo_Info();

                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    var lst = from q in Context.Af_Activo_fijo_x_ct_punto_cargo
                              where idEmpresa == q.IdEmpresa_PC
                              && idPunto_cargo == q.IdPunto_cargo_PC
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa_AF = item.IdEmpresa_AF;
                        info.IdActivoFijo_AF = item.IdActivoFijo_AF;
                        info.IdEmpresa_PC = item.IdEmpresa_PC;
                        info.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        info.observacion = item.observacion;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_Activo_fijo_x_ct_punto_cargo_Info Get_Info_x_Activo_fijo(int idEmpresa, int idActivo_fijo)
        {
            try
            {
                Af_Activo_fijo_x_ct_punto_cargo_Info info = new Af_Activo_fijo_x_ct_punto_cargo_Info();

                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    var lst = from q in Context.Af_Activo_fijo_x_ct_punto_cargo
                              where idEmpresa == q.IdEmpresa_AF
                              && idActivo_fijo == q.IdActivoFijo_AF
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa_AF = item.IdEmpresa_AF;
                        info.IdActivoFijo_AF = item.IdActivoFijo_AF;
                        info.IdEmpresa_PC = item.IdEmpresa_PC;
                        info.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        info.observacion = item.observacion;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }                
        }

        public Boolean GuardarDB(Af_Activo_fijo_x_ct_punto_cargo_Info info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Af_Activo_fijo_x_ct_punto_cargo Entity = new Af_Activo_fijo_x_ct_punto_cargo();

                    Entity.IdEmpresa_AF = info.IdEmpresa_AF;
                    Entity.IdActivoFijo_AF = info.IdActivoFijo_AF;
                    Entity.IdEmpresa_PC = info.IdEmpresa_PC;
                    Entity.IdPunto_cargo_PC = info.IdPunto_cargo_PC;
                    Entity.observacion = info.observacion;

                    Context.Af_Activo_fijo_x_ct_punto_cargo.Add(Entity);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(Af_Activo_fijo_x_ct_punto_cargo_Info info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Af_Activo_fijo_x_ct_punto_cargo Entity = Context.Af_Activo_fijo_x_ct_punto_cargo.FirstOrDefault(q => q.IdActivoFijo_AF == info.IdActivoFijo_AF && q.IdEmpresa_AF == info.IdEmpresa_AF);
                    if (Entity!=null)
                    {
                        Entity.IdEmpresa_AF = info.IdEmpresa_AF;
                        Entity.IdActivoFijo_AF = info.IdActivoFijo_AF;
                        Entity.IdEmpresa_PC = info.IdEmpresa_PC;
                        Entity.IdPunto_cargo_PC = info.IdPunto_cargo_PC;
                        Entity.observacion = info.observacion;
                        Context.SaveChanges();    
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }        

        public Boolean MergeDB(Af_Activo_fijo_x_ct_punto_cargo_Info info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Af_Activo_fijo_x_ct_punto_cargo Entity = Context.Af_Activo_fijo_x_ct_punto_cargo.FirstOrDefault(q => q.IdActivoFijo_AF == info.IdActivoFijo_AF && q.IdEmpresa_AF == info.IdEmpresa_AF);
                    if (Entity != null)
                    {
                       // Entity.IdEmpresa_AF = info.IdEmpresa_AF;
                       // Entity.IdActivoFijo_AF = info.IdActivoFijo_AF;
                        //Entity.IdEmpresa_PC = info.IdEmpresa_PC;
                        //Entity.IdPunto_cargo_PC = info.IdPunto_cargo_PC;
                        Entity.observacion = info.observacion;
                        Context.SaveChanges();
                    }
                    else
                    {
                        Entity = new Af_Activo_fijo_x_ct_punto_cargo();
                        Entity.IdEmpresa_AF = info.IdEmpresa_AF;
                        Entity.IdActivoFijo_AF = info.IdActivoFijo_AF;
                        Entity.IdEmpresa_PC = info.IdEmpresa_PC;
                        Entity.IdPunto_cargo_PC = info.IdPunto_cargo_PC;
                        Entity.observacion = info.observacion;
                        Context.Af_Activo_fijo_x_ct_punto_cargo.Add(Entity);
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
