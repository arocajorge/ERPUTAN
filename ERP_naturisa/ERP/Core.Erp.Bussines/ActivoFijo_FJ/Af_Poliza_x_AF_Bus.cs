using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Data.ActivoFijo_FJ;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
namespace Core.Erp.Business.ActivoFijo_FJ
{
    
   public class Af_Poliza_x_AF_Bus
    {
        Af_Poliza_x_AF_Data data = new Af_Poliza_x_AF_Data();
        Af_Poliza_x_AF_det_Bus Detalle_x_activo_Bus = new Af_Poliza_x_AF_det_Bus();
        Af_Poliza_x_AF_det_cuota_Bus Detalle_x_Cuta_Bus = new Af_Poliza_x_AF_det_cuota_Bus();
        Af_Activo_fijo_Bus bus_Activo_fijo = new Af_Activo_fijo_Bus(); 
        public Boolean GuardarDB(Af_Poliza_x_AF_Info Info, ref int IdPoliza)
        {
            try
            {
                if (data.GuardarDB(Info, ref IdPoliza))
                {
                    foreach (var item in Info.lst_Det_cuota)
                    {
                        item.IdPoliza = IdPoliza;
                        
                    }
                    foreach (var item in Info.lst_Det)
                    {
                        item.IdPoliza = IdPoliza;
                        if (item.observacion_det == null || item.observacion_det=="")
                        {
                            item.observacion_det = Info.observacion;
                        }
                    }

                    if (Detalle_x_Cuta_Bus.GuardarDB(Info.lst_Det_cuota))
                        if (Detalle_x_activo_Bus.GuardarDB(Info.lst_Det))
                            bus_Activo_fijo.Grabar_Poliza_x_Activo(Info);

                }      
                   return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_Bus) };
         
            }
        }



        public Boolean ModificarDB(Af_Poliza_x_AF_Info Info)
        {
            try
            {
                if (data.ModificarDB(Info))
                {
                    if(Detalle_x_activo_Bus.EliminarDB(Info.IdEmpresa,Convert.ToInt32( Info.IdPoliza)))
                    {
                        Detalle_x_activo_Bus.GuardarDB(Info.lst_Det);
                    }

                     if(Detalle_x_Cuta_Bus.EliminarDB(Info.IdEmpresa,Convert.ToInt32( Info.IdPoliza)))
                     {
                         foreach (var item in Info.lst_Det_cuota)
                         {
                             item.IdPoliza = Info.IdPoliza;
                         }
                         Detalle_x_Cuta_Bus.GuardarDB(Info.lst_Det_cuota);
                    }
                     bus_Activo_fijo.Grabar_Poliza_x_Activo(Info);
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_Bus) };
         
            }
        }

        public Boolean AnularDB(Af_Poliza_x_AF_Info Info)
        {
            try
            {

                return data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_Bus) };
         
            }
        }


        public List<Af_Poliza_x_AF_Info> Get_List_Poliza(int IdEmpresa, DateTime fi, DateTime ff)
        {
            try
            {
                return data.Get_List_Poliza(IdEmpresa,fi,ff);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Poliza", ex.Message), ex) { EntityType = typeof(Af_Poliza_x_AF_Bus) };

            }
        }

    }
}
