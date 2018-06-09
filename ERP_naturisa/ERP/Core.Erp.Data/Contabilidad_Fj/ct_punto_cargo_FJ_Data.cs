using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Data.Contabilidad_Fj
{
    public class ct_punto_cargo_FJ_Data
    {
        string mensaje = "";

        public ct_punto_cargo_FJ_Info Get_info_punto_cargo(int IdEmpresa, int IdPunto_cargo)
        {
            try
            {
                ct_punto_cargo_FJ_Info info = new ct_punto_cargo_FJ_Info();

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.ct_punto_cargo_FJ
                              where q.IdEmpresa == IdEmpresa
                              && q.IdPunto_cargo == IdPunto_cargo
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    }
                }

                return info;
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

        public bool GuardarDB(ct_punto_cargo_FJ_Info info)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.ct_punto_cargo_FJ
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdPunto_cargo == info.IdPunto_cargo
                              select q;
                    if (lst.Count() == 0)
                    {
                        ct_punto_cargo_FJ Entity = new ct_punto_cargo_FJ();

                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdPunto_cargo = info.IdPunto_cargo;
                        Entity.IdCentroCosto = info.IdCentroCosto == "" ? null : info.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo == "" ? null : info.IdCentroCosto_sub_centro_costo;

                        Context.ct_punto_cargo_FJ.Add(Entity);
                        Context.SaveChanges();
                    }
                    else
                        ModificarDB(info);
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

        public bool ModificarDB(ct_punto_cargo_FJ_Info info)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    ct_punto_cargo_FJ Entity = Context.ct_punto_cargo_FJ.First(q => q.IdEmpresa == info.IdEmpresa && q.IdPunto_cargo == info.IdPunto_cargo);
                    if (Entity != null)
                    {
                        Entity.IdCentroCosto = info.IdCentroCosto == "" ? null : info.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo == "" ? null : info.IdCentroCosto_sub_centro_costo;
                        Context.SaveChanges();
                    }
                    else
                        GuardarDB(info);
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

