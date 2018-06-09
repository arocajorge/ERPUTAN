using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt001_Data
    {
        string mensaje = "";
        public List<XACTF_FJ_Rpt001_Info> Get_List_Activos_Prendados(int idempresa, DateTime Fecha_Fin)
        {

            try
            {
                List<XACTF_FJ_Rpt001_Info> lista = new List<XACTF_FJ_Rpt001_Info>();
                using (EntitiesActivoFijo_Reporte_FJ database = new EntitiesActivoFijo_Reporte_FJ())
                {
                    var query = (from q in database.spACTF_Rpt001(idempresa,Fecha_Fin)
                                 
                                 select q);

                    foreach (var item in query)
                    {
                        XACTF_FJ_Rpt001_Info info = new XACTF_FJ_Rpt001_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPrestamo = item.IdPrestamo;
                        info.CodPrestamo = item.CodPrestamo;
                        info.IdBanco = item.IdBanco;
                        info.IdMetCalc = item.IdMetCalc;
                        info.IdMotivo_Prestamo = item.IdMotivo_Prestamo;
                        info.Estado = item.Estado;
                        info.Fecha = item.Fecha;
                        info.MontoSol = item.MontoSol;
                        info.TasaInteres = item.TasaInteres;
                        info.TotalPrestamo = item.TotalPrestamo;
                        info.Observacion = item.Observacion;
                        info.TotalCuota = item.TotalCuota;
                        info.FechaVencimiento = item.FechaVencimiento;
                        info.Interes = item.Interes;
                        info.RazonSocial = item.RazonSocial;
                        info.Plazo = item.Plazo;
                        info.ba_descripcion = item.ba_descripcion;
                        if (item.Plazo > 1080)
                            info.Deuda_LargoPlazo = item.TotalCuota;
                        else
                            info.Deuda_CortoPlazo = item.TotalCuota;

                        lista.Add(info);
                    }


                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XACTF_FJ_Rpt001_Info>();

            }
        }
   
    }
}
