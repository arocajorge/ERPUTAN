using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_grupo_x_sub_centro_costo_det_Data
    {
        public List<fa_grupo_x_sub_centro_costo_det_Info> Get_List_Grup_Sub_Det(int IdEmpresa, decimal IdGrupo, ref string mensaje)
        {
            try
            {
                List<fa_grupo_x_sub_centro_costo_det_Info> Lista = new List<fa_grupo_x_sub_centro_costo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var contact = from q in Context.fa_grupo_x_sub_centro_costo_det
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdGrupo == IdGrupo
                                  select q;

                    foreach (var item in contact)
                    {
                        fa_grupo_x_sub_centro_costo_det_Info Info = new fa_grupo_x_sub_centro_costo_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdGrupo = item.IdGrupo;
                        Info.Secuencia = item.Secuencia;
                        Info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Info.IdCentroCosto = item.IdCentroCosto;

                        Lista.Add(Info);
                    }
                }
                return Lista;
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

        public List<fa_grupo_x_sub_centro_costo_det_Info> Get_List_Grup_Sub_Det(int IdEmpresa, string IdCentroCosto, ref string mensaje)
        {
            try
            {
                List<fa_grupo_x_sub_centro_costo_det_Info> Lista = new List<fa_grupo_x_sub_centro_costo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var contact = from q in Context.vwfa_grupo_x_sub_centro_costo_det_scc_sin_grupo
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdCentroCosto == IdCentroCosto
                                  select q;

                    foreach (var item in contact)
                    {
                        fa_grupo_x_sub_centro_costo_det_Info Info = new fa_grupo_x_sub_centro_costo_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.cod_subcentroCosto = item.cod_subcentroCosto;
                        Info.Centro_costo = item.Centro_costo;
                        Info.pc_Estado = item.pc_Estado;
                        Info.IdCtaCble = item.IdCtaCble;
                        Lista.Add(Info);
                    }
                }
                return Lista;
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

        public List<fa_grupo_x_sub_centro_costo_det_Info> Get_List_Grup_Sub_Det(int IdEmpresa, string IdCentroCosto, Decimal IdGrupo, ref string mensaje)
        {
            try
            {
                List<fa_grupo_x_sub_centro_costo_det_Info> Lista = new List<fa_grupo_x_sub_centro_costo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var contact = from q in Context.vwfa_grupo_x_sub_centro_costo_det_scc_sin_grupo
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdCentroCosto == IdCentroCosto
                                  select q;

                    var contact1 = from q in Context.vwfa_grupo_x_sub_centro_costo_det
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdCentroCosto == IdCentroCosto
                                   && q.IdGrupo == IdGrupo
                                   select q;

                    foreach (var item in contact)
                    {
                        fa_grupo_x_sub_centro_costo_det_Info Info = new fa_grupo_x_sub_centro_costo_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.cod_subcentroCosto = item.cod_subcentroCosto;
                        Info.Centro_costo = item.Centro_costo;
                        Info.pc_Estado = item.pc_Estado;
                        Info.IdCtaCble = item.IdCtaCble;
                        Lista.Add(Info);
                    }

                    foreach (var item in contact1)
                    {
                        fa_grupo_x_sub_centro_costo_det_Info Info = new fa_grupo_x_sub_centro_costo_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.cod_subcentroCosto = item.cod_subcentroCosto;
                        Info.Centro_costo = item.Centro_costo;
                        Info.pc_Estado = item.pc_Estado;
                        Info.IdCtaCble = item.IdCtaCble;
                        Lista.Add(Info);
                    }
                }
                return Lista;
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

        public bool GuardarDB(fa_grupo_x_sub_centro_costo_det_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_grupo_x_sub_centro_costo_det contact = new fa_grupo_x_sub_centro_costo_det();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdGrupo = Info.IdGrupo;
                    contact.Secuencia = Info.Secuencia;
                    contact.IdCentroCosto = Info.IdCentroCosto;
                    contact.IdCentroCosto_sub_centro_costo = Info.IdCentroCosto_sub_centro_costo;

                    Context.fa_grupo_x_sub_centro_costo_det.Add(contact);
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

        public bool GuardarDB(List<fa_grupo_x_sub_centro_costo_det_Info> Lst_Info, ref string mensaje)
        {
            try
            {
                int sec = 1;
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_grupo_x_sub_centro_costo_det_Info item in Lst_Info)
                    {
                        item.Secuencia = sec;

                        GuardarDB(item, ref mensaje);

                        sec++;
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

        public bool EliminarDB(fa_grupo_x_sub_centro_costo_Info info, ref string mensaje)
        {
            try
            {

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_grupo_x_sub_centro_costo_det where IdEmpresa = " + info.IdEmpresa + " and IdGrupo = " + info.IdGrupo + " ");
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
