using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.ActivoFijo_FJ
{
  public  class Af_Poliza_x_AF_det_cuota_Data
    {
        string mensaje = "";
        public bool GuardarDB(List< Af_Poliza_x_AF_det_cuota_Info> lista)
        {
            try
            {
                int secuancia = 0;
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {

                    foreach (var item in lista)
                    {
                        secuancia++;
                        Af_Poliza_x_AF_det_cuota Address = new Af_Poliza_x_AF_det_cuota();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdPoliza = item.IdPoliza;
                        Address.cod_couta =Convert.ToString( secuancia);
                        Address.Fecha_Pago = item.Fecha_Pago;
                        Address.valor_prima = item.valor_prima;
                        Address.IdEstadoCancelacion_cat = item.IdEstadoCancelacion_cat;
                        Address.IdEstadoFacturacion_cat = item.IdEstadoFacturacion_cat;
                        Address.Sub_total_12 = item.Sub_total_12;
                        Address.Sub_total_0 = item.Sub_total_0;
                        Address.Iva = item.Iva;
                        Address.Observacion_detalle = item.Observacion_detalle;
                        Context.Af_Poliza_x_AF_det_cuota.Add(Address);
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Poliza_x_AF_det_cuota_Info> Get_List_Poliza_Detalle_Cuota(int IdEmpresa ,int IdPoliza)
        {
            List<Af_Poliza_x_AF_det_cuota_Info> Lista = new List<Af_Poliza_x_AF_det_cuota_Info>();
            try
            {
                EntitiesActivoFijo_FJ oEnti = new EntitiesActivoFijo_FJ();

                var qury = (from j in oEnti.Af_Poliza_x_AF_det_cuota
                            where j.IdEmpresa == IdEmpresa
                            && j.IdPoliza == IdPoliza
                            select j);
                foreach (var item in qury)
                {
                    Af_Poliza_x_AF_det_cuota_Info info = new Af_Poliza_x_AF_det_cuota_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdPoliza = item.IdPoliza;
                    info.cod_couta = item.cod_couta;
                    info.valor_prima = item.valor_prima;
                    info.IdEstadoCancelacion_cat = item.IdEstadoCancelacion_cat;
                    info.IdEstadoFacturacion_cat = item.IdEstadoFacturacion_cat;
                    info.Fecha_Pago = item.Fecha_Pago;
                    info.Sub_total_12 = item.Sub_total_12;
                    info.Sub_total_0 = item.Sub_total_0; 
                    info.Iva = item.Iva;
                    info.Observacion_detalle = item.Observacion_detalle;
                    Lista.Add(info);
                    
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean EliminarDB(int IdEmpresa,int IdPoliza)
        {
            try
            {
                using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
                {
                    String SQL = " delete Fj_servindustrias.Af_Poliza_x_AF_det_cuota where IdEmpresa='" + IdEmpresa + "'  and IdPoliza='" + IdPoliza + "'";
                    Context.Database.ExecuteSqlCommand(SQL);
                }

               
                return true;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

       
    }
}
