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
    public class Af_Activo_fijo_x_ct_centro_costo_Data
    {
        public Boolean GuardarDB(Af_Activo_fijo_x_ct_centro_costo_Info info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Af_Activo_fijo_x_ct_centro_costo Entity = new Af_Activo_fijo_x_ct_centro_costo();

                    Entity.IdEmpresa_AF = info.IdEmpresa_AF;
                    Entity.IdActivoFijo_AF = info.IdActivoFijo_AF;
                    Entity.IdEmpresa_cc = info.IdEmpresa_cc;
                    Entity.IdCentroCosto_cc = info.IdCentroCosto_cc;
                    Entity.Estado = true;

                    Context.Af_Activo_fijo_x_ct_centro_costo.Add(Entity);
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

        public List<Af_Activo_fijo_x_ct_centro_costo_Info> Get_List_Af_x_CC(int idEmpresa, string idCentro_costo)
        {
            try
            {
                List<Af_Activo_fijo_x_ct_centro_costo_Info> Lista = new List<Af_Activo_fijo_x_ct_centro_costo_Info>();

                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    var lst = from q in Context.vwAf_Activo_fijo_x_ct_centro_costo
                              where idEmpresa == q.IdEmpresa && idCentro_costo == q.IdCentroCosto
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_x_ct_centro_costo_Info info = new Af_Activo_fijo_x_ct_centro_costo_Info();

                        info.IdEmpresa_AF = item.IdEmpresa;
                        info.IdActivoFijo_AF = item.IdActivoFijo;
                        info.IdEmpresa_cc = (int)item.IdEmpresa_cc;
                        info.IdCentroCosto_cc = item.IdCentroCosto;
                        info.Estado = item.Estado_Ubicación ==null ? false : (bool)item.Estado_Ubicación;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Estado_Ubicación = item.Estado_Ubicación;
                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdEmpresa_PC = item.IdEmpresa_PC;
                        info.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.Asignado = true;

                        Lista.Add(info);
                    }
                }

                return Lista;
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

        public List<Af_Activo_fijo_x_ct_centro_costo_Info> Get_List_Af_x_CC_x_Registro(int idEmpresa, string idCentro_costo, decimal idRegistro)
        {
            try
            {
                List<Af_Activo_fijo_x_ct_centro_costo_Info> Lista = new List<Af_Activo_fijo_x_ct_centro_costo_Info>();

                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    var lst = from q in Context.vwAf_Activo_fijo_x_ct_centro_costo_x_Registro
                              where idEmpresa == q.IdEmpresa && idRegistro == q.IdRegistro
                              select q;

                    var lst_Completa = from q in Context.vwAf_Activo_fijo_x_ct_centro_costo
                              where idEmpresa == q.IdEmpresa && idCentro_costo == q.IdCentroCosto
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_x_ct_centro_costo_Info info = new Af_Activo_fijo_x_ct_centro_costo_Info();

                        info.IdEmpresa_AF = item.IdEmpresa;
                        info.IdActivoFijo_AF = item.IdActivoFijo;                        
                        info.IdEmpresa_cc = (int)item.IdEmpresa_cc;
                        info.IdCentroCosto_cc = item.IdCentroCosto;
                        info.Estado = item.Estado_Ubicación == null ? false : (bool)item.Estado_Ubicación;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Estado_Ubicación = item.Estado_Ubicación;
                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdEmpresa_PC = item.IdEmpresa_PC;
                        info.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.Asignado = true;

                        Lista.Add(info);
                    }

                    foreach (var item in lst_Completa)
                    {
                        int cont = Lista.Where(q => q.IdEmpresa_AF == item.IdEmpresa && q.IdActivoFijo_AF == item.IdActivoFijo && q.IdCentroCosto == item.IdCentroCosto).Count();
                        if (cont==0)
                        {
                            Af_Activo_fijo_x_ct_centro_costo_Info info = new Af_Activo_fijo_x_ct_centro_costo_Info();

                        info.IdEmpresa_AF = item.IdEmpresa;
                        info.IdActivoFijo_AF = item.IdActivoFijo;                        
                        info.IdEmpresa_cc = (int)item.IdEmpresa_cc;
                        info.IdCentroCosto_cc = item.IdCentroCosto;
                        info.Estado = item.Estado_Ubicación == null ? false : (bool)item.Estado_Ubicación;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Estado_Ubicación = item.Estado_Ubicación;
                        info.IdEmpresa_cli = item.IdEmpresa_cli;
                        info.IdCliente_cli = item.IdCliente_cli;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdEmpresa_PC = item.IdEmpresa_PC;
                        info.IdPunto_cargo_PC = item.IdPunto_cargo_PC;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_UnidadFact = item.nom_UnidadFact;
                        info.Asignado = false;

                        Lista.Add(info);
                        }
                    }
                }

                return Lista;
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

        public Boolean Anular_Activos_x_centro_costo(int idEmpresa, string idCentro_costo)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Context.Database.ExecuteSqlCommand("Update Fj_servindustrias.Af_Activo_fijo_x_ct_centro_costo set Estado = 0 where IdEmpresa_AF =" + idEmpresa + " and IdCentroCosto_cc = '" + idCentro_costo + "'");
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

        public Boolean AnularDB(Af_Activo_fijo_x_ct_centro_costo_Info info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Af_Activo_fijo_x_ct_centro_costo Entity = Context.Af_Activo_fijo_x_ct_centro_costo.FirstOrDefault(q => q.IdActivoFijo_AF == info.IdActivoFijo_AF && q.IdEmpresa_AF == info.IdEmpresa_AF && q.Estado == true);
                    if (Entity != null)
                    {   
                        Entity.Estado = false;
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

        /// <summary>
        /// Envia un info, si existe el activo fijo en algun centro de costo lo anula
        /// y busca uno anulado en el mismo centro de costo si existe lo activa
        /// si no existe lo crea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Boolean MergeDB(Af_Activo_fijo_x_ct_centro_costo_Info info)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    Af_Activo_fijo_x_ct_centro_costo Entity = Context.Af_Activo_fijo_x_ct_centro_costo.FirstOrDefault(q => q.IdActivoFijo_AF == info.IdActivoFijo_AF && q.IdEmpresa_AF == info.IdEmpresa_AF );
                    if (Entity != null)
                    {
                        Entity.Estado = false;
                        Context.SaveChanges();

                        Entity = Context.Af_Activo_fijo_x_ct_centro_costo.FirstOrDefault(q => q.IdActivoFijo_AF == info.IdActivoFijo_AF && q.IdEmpresa_AF == info.IdEmpresa_AF && q.IdEmpresa_cc==info.IdEmpresa_cc && q.IdCentroCosto_cc == info.IdCentroCosto_cc);
                        if (Entity != null)
                        {
                            Entity.Estado = true;
                            Context.SaveChanges();
                        }
                        else
                        {
                            GuardarDB(info);
                        }
                    }
                    else
                    {
                        GuardarDB(info);
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
