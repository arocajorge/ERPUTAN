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
    public class fa_orden_trabajo_plataforma_det_Data
    {
        string MensajeError = "";

        public List<fa_orden_trabajo_plataforma_det_Info> Get_List_Orden_trabajo_Det(int idEmpresa, decimal IdOrdenTrabajo_Pla)
        {
            try
            {
                List<fa_orden_trabajo_plataforma_det_Info> Lista = new List<fa_orden_trabajo_plataforma_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_orden_trabajo_plataforma_det
                              where idEmpresa == q.IdEmpresa
                              && IdOrdenTrabajo_Pla == q.IdOrdenTrabajo_Pla
                              select q;

                    foreach (var item in lst)
                    {
                        fa_orden_trabajo_plataforma_det_Info info = new fa_orden_trabajo_plataforma_det_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdOrdenTrabajo_Pla = item.IdOrdenTrabajo_Pla;
                        info.secuencia = item.secuencia;
                        info.descrip_equipo_movi = item.descrip_equipo_movi;
                        info.punto_partida = item.punto_partida;
                        info.punto_llegada = item.punto_llegada;
                        info.hora_ini = item.hora_ini;
                        info.hora_fin = item.hora_fin;
                        info.Valor = item.Valor;

                        info.hora_ini_D = DateTime.Now.Date;
                        info.hora_fin_D = DateTime.Now.Date;
                        info.hora_ini_D = info.hora_ini_D.Add(info.hora_ini.Value);
                        info.hora_fin_D = info.hora_fin_D.Add(info.hora_fin.Value);

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

        public bool GuardarDB(List<fa_orden_trabajo_plataforma_det_Info> Lst_Info)
        {
            try
            {
                int sec = 1;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_orden_trabajo_plataforma_det_Info item in Lst_Info)
                    {
                        fa_orden_trabajo_plataforma_det Entity = new fa_orden_trabajo_plataforma_det();

                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdOrdenTrabajo_Pla = item.IdOrdenTrabajo_Pla;
                        Entity.secuencia = item.secuencia = sec;
                        Entity.descrip_equipo_movi = item.descrip_equipo_movi;
                        Entity.punto_partida = item.punto_partida == null ? "" : item.punto_partida;
                        Entity.punto_llegada = item.punto_llegada == null ? "" : item.punto_llegada;
                        Entity.hora_ini = item.hora_ini;
                        Entity.hora_fin = item.hora_fin;
                        Entity.Valor = item.Valor;

                        Context.fa_orden_trabajo_plataforma_det.Add(Entity);
                        Context.SaveChanges();

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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(fa_orden_trabajo_plataforma_Info info)
        {
            try
            {

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_orden_trabajo_plataforma_det where IdOrdenTrabajo_Pla = " + info.IdOrdenTrabajo_Pla + " and IdEmpresa = " + info.IdEmpresa + " ");
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
