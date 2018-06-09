using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class vwAf_ActivoFijo_Data
    {
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";

        public List<vwAf_ActivoFijo_Info> Get_List_ActivoFijo_Depre(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdUsuario)
        {
            try
            {
                List<vwAf_ActivoFijo_Info> lstInfo = new List<vwAf_ActivoFijo_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.spACTF_activos_a_depreciar(IdEmpresa, FechaIni, FechaFin, IdUsuario)
                                 select q;

                    foreach (var item in select)
                    {
                        vwAf_ActivoFijo_Info Info = new vwAf_ActivoFijo_Info();
                        Info.IdEmpresa= item.IdEmpresa;
                        Info.IdActivoFijo= item.IdActivoFijo;
                        Info.Af_Nombre= item.Af_Nombre;
                        Info.CodActivoFijo = item.CodActivoFijo;
                        Info.nom_categoria = item.nom_categoria;
                        Info.nom_tipo = item.nom_tipo;
                        Info.IdCategoriaAF = item.IdCategoriaAF;
                        Info.IdActijoFijoTipo = item.IdActijoFijoTipo;                        
                        Info.Af_costo_compra= item.Af_costo_compra;
                        Info.Valor_Depre= Convert.ToDouble(item.Af_valor_depreciacion);
                        Info.Af_porcentaje_deprec = Convert.ToDouble(item.Af_porcentaje_deprec);
                        Info.Valor_Depreciacion_Acum= Convert.ToDouble(item.Af_depreciacion_acum);
                        Info.Valor_Importe = item.Valor_importe;
                        Info.Concepto_Depre = "Depreciacion de Activo " +  Info.Af_Nombre + " Ciclo " + Info.Ciclo;

                        lstInfo.Add(Info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
