using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;


namespace Core.Erp.Business.ActivoFijo
{
    public class vwAf_ActivoFijo_Bus
    {
        vwAf_ActivoFijo_Data dataAf = new vwAf_ActivoFijo_Data();

        public List<vwAf_ActivoFijo_Info> Get_List_ActivoFijo_Depre(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdUsuario)
        {
            try
            {
                return dataAf.Get_List_ActivoFijo_Depre(IdEmpresa, FechaIni, FechaFin, IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo_Depre", ex.Message), ex) { EntityType = typeof(vwAf_ActivoFijo_Bus) };
            }
        }



        private List<vwAf_ActivoFijo_Info> Get_List_ActivoFijo_Depre(List<vwAf_ActivoFijo_Info> lstInfo, DateTime FechaIni)
        {
            try
            {
                List<vwAf_ActivoFijo_Info> lstVwAf = new List<vwAf_ActivoFijo_Info>();

                int diasPeriodo = 0;
                int diasActivo = 0;
                double Valor_x_Dias = 0;
                diasPeriodo = DateTime.DaysInMonth(FechaIni.Year, FechaIni.Month);

                foreach (var item in lstInfo)
                {
                    
                    vwAf_ActivoFijo_Info Info = new vwAf_ActivoFijo_Info();
                    Info = item;
                    Valor_x_Dias = item.Valor_Depre / diasPeriodo;

                    //pregunto x la fecha inicial
                    if (item.Af_fecha_ini_depre.Month == FechaIni.Month
                        && item.Af_fecha_ini_depre.Year == FechaIni.Year)
                    {
                        diasActivo = diasPeriodo - item.Af_fecha_ini_depre.Day;
                        Info.Valor_Depre = Valor_x_Dias * diasActivo;
                    }
                    else
                    {
                        //pregunto x la fecha final
                        if (item.Af_fecha_fin_depre.Month == FechaIni.Month
                        && item.Af_fecha_fin_depre.Year == FechaIni.Year)
                        {
                            Info.Valor_Depre = Valor_x_Dias * item.Af_fecha_fin_depre.Day;
                        }
                        else
                        {
                            Info.Valor_Depre = Valor_x_Dias * diasPeriodo;
                        }
                    }

                    Info.Valor_Depreciacion_Acum = item.Valor_Depreciacion_Acum  + Info.Valor_Depre;
                    Info.Valor_Importe = item.Af_costo_compra - Info.Valor_Depreciacion_Acum;

                    lstVwAf.Add(Info);

                }
                

                return lstVwAf;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CalcularValoresDepre", ex.Message), ex) { EntityType = typeof(vwAf_ActivoFijo_Bus) };
            }
        }




        public vwAf_ActivoFijo_Bus()
        {

        }
    }
}
