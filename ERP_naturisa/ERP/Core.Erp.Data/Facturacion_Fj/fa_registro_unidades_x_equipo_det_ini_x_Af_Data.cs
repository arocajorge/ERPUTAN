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
    public class fa_registro_unidades_x_equipo_det_ini_x_Af_Data
    {
        public List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Get_List_Inicial_x_Af(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lista = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_registro_unidades_x_equipo_det_ini_x_Af
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdRegistro == info.IdRegistro
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_ini_x_Af_Info info_det = new fa_registro_unidades_x_equipo_det_ini_x_Af_Info();

                        info_det.IdEmpresa = item.IdEmpresa;
                        info_det.IdActivoFijo = item.IdActivoFijo;
                        info_det.IdRegistro = item.IdRegistro;
                        info_det.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info_det.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        Lista.Add(info_det);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det_ini_x_Af Entity = new fa_registro_unidades_x_equipo_det_ini_x_Af();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdRegistro = item.IdRegistro;
                        Entity.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        Context.fa_registro_unidades_x_equipo_det_ini_x_Af.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete [Fj_servindustrias].[fa_registro_unidades_x_equipo_det_ini_x_Af] where IdEmpresa = " + info.IdEmpresa + " and IdRegistro = " + info.IdRegistro);
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
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
