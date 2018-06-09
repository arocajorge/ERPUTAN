using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Facturacion_Fj
{
 public class fa_liquidaciones_det_Data
    {
     tb_sis_Log_Error_Vzen oDataLog = new tb_sis_Log_Error_Vzen();
     string MensajeError = "";
        public bool GuardarDB(List<fa_liquidaciones_det_Info> lista)
        {
            try
            {
                int secuencia = 0;
                using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lista)
                    {
                        fa_liquidaciones_det add = new fa_liquidaciones_det();
                        secuencia++;
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdLiquidaciones = item.IdLiquidaciones;
                        add.Secuencia = secuencia;
                        add.IdEmpresa_liqui_gastos = item.IdEmpresa_liqui_gastos;
                        add.IdLiquidacion_liqui_gastos = item.IdLiquidacion_liqui_gastos;
                        database.fa_liquidaciones_det.Add(add);
                        database.SaveChanges();
                        
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

        

        public bool EliminarDB(int IdEmpresa,int IdLiquidaciones)
        {
            try
            {
                using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
                {

                    string SQL = "delete Fj_servindustrias.fa_liquidaciones_det where IdEmpresa='"+IdEmpresa+"' and IdLiquidaciones='"+IdLiquidaciones+"'";
                    database.Database.ExecuteSqlCommand(SQL);
                    return true;
                }
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
