using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//versi 0507
namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Conversion_det_CusCidersus_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<prd_Conversion_det_CusCidersus_Info> Lista, ref string Mensaje)
        {
            try
            {
                int c = 1;
                foreach (var Info in Lista)
                {
                    using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                    {
                        var Address = new prd_Conversion_det_CusCidersus();

                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdConversion = Info.IdConversion;
                        Address.IdSucursal = Info.IdSucursal;
                        Address.IdBodega = Info.IdBodega;
                        Address.Secuencial = c;
                        c++;
                        Address.IdProducto = Info.IdProducto;
                        Address.CodBarra = Info.CodBarra;
                        Address.TipoPro = Info.TipoPro;
                        Address.Observacion = Info.Observacion;
                        Context.prd_Conversion_det_CusCidersus.Add(Address);
                        Context.SaveChanges();
                        Mensaje = "Grabado Ok";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                Mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_Conversion_det_CusCidersus_Info> Counsultar(int IdEmpresa, decimal IdConversion) 
        {
            try
            {
                List<prd_Conversion_det_CusCidersus_Info> lista = new List<prd_Conversion_det_CusCidersus_Info>();
                string Query = "select * from vwprd_ConversionDetalle_CusCidersus where IdEmpresa = "+IdEmpresa+" And IdConversion ="+IdConversion;

                EntitiesProduccion_Cidersus Oen = new EntitiesProduccion_Cidersus();
                var COnsulta = Oen.Database.SqlQuery<prd_Conversion_det_CusCidersus_Info>(Query);
                lista = COnsulta.ToList();


                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
