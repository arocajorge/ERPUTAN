using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt002_Data
    {
        string mensaje = "";
        public List<XACTF_FJ_Rpt002_Info> Get_List_Activos_Prendados(int idempresa, int idcategoria, DateTime Fecha_Inicio,DateTime Fecha_Fin)
        {

            try
            {
                 List<XACTF_FJ_Rpt002_Info> lista = new List<XACTF_FJ_Rpt002_Info>();
                 using (EntitiesActivoFijo_Reporte_FJ database = new EntitiesActivoFijo_Reporte_FJ())
            {
                var query = (from q in database.vwACTF_FJ_Rpt002
                             where q.IdEmpresa==idempresa 
                             && q.IdCategoriaAF==idcategoria
                            // && q.Fecha >= Fecha_Inicio
                             //    & q.Fecha <= Fecha_Fin
                             select q);

                foreach (var item in query)
                {
                    XACTF_FJ_Rpt002_Info info = new XACTF_FJ_Rpt002_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.IdCategoriaAF = item.IdCategoriaAF;
                    info.Marca = item.Marca;
                    info.Modelo = item.Modelo;
                    info.Num_Serie_Motor = item.Num_Serie_Motor;
                    info.Anio_Fabricacion = item.Anio_Fabricacion;
                    info.Factura_Serie = item.Factura_Serie+item.Num_Factura;
                    info.Fecha_compra = item.Fecha_compra;
                    info.Costo_Compra = item.Costo_Compra;
                    info.Af_Capacidad = item.Af_Capacidad;
                    info.Institucion_prendada = item.Institucion_prendada;
                    info.Operacion = item.Operacion;
                    info.Fecha_Avaluo = item.Fecha_Avaluo;
                    info.Garantia_Bancaria = item.Garantia_Bancaria;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
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
                return new List<XACTF_FJ_Rpt002_Info>();
               
            }
        }

        public List<XACTF_FJ_Rpt002_Info> Get_List_Activos_Prendados(int idempresa, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            try
            {
                List<XACTF_FJ_Rpt002_Info> lista = new List<XACTF_FJ_Rpt002_Info>();
                using (EntitiesActivoFijo_Reporte_FJ database = new EntitiesActivoFijo_Reporte_FJ())
                {
                    var query = (from q in database.vwACTF_FJ_Rpt002
                                 where q.IdEmpresa == idempresa
                                 && q.Fecha>=Fecha_Inicio
                                 & q.Fecha<=Fecha_Fin
                                 select q);

                    foreach (var item in query)
                    {
                        XACTF_FJ_Rpt002_Info info = new XACTF_FJ_Rpt002_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.Num_Serie_Motor = item.Num_Serie_Motor;
                        info.Anio_Fabricacion = item.Anio_Fabricacion;
                        info.Factura_Serie = item.Factura_Serie + item.Num_Factura;
                        info.Fecha_compra = item.Fecha_compra;
                        info.Costo_Compra = item.Costo_Compra;
                        info.Af_Capacidad = item.Af_Capacidad;
                        info.Institucion_prendada = item.Institucion_prendada;
                        info.Operacion = item.Operacion;
                        info.Fecha_Avaluo = item.Fecha_Avaluo;
                        info.Garantia_Bancaria = item.Garantia_Bancaria;
                        info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                        info.Categoria = item.Categoria;
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
                return new List<XACTF_FJ_Rpt002_Info>();

            }
        }
   
    }
}
