using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;



namespace Core.Erp.Business.Inventario
{
   public class in_devolucion_inven_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_devolucion_inven_Data oDat = new in_devolucion_inven_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                return oDat.GetId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_Bus) };

            }
        }

        

        public Boolean GuardarDB(in_devolucion_inven_Info info, ref decimal IdDev_Inven, ref string mensaje)
        {
            Boolean Respuesta = false;

            try
            {
                int c = 0;
                Respuesta=oDat.GuardarDB(info, ref IdDev_Inven, ref mensaje);
                if (Respuesta)
                {
                    c = 0;
                    foreach (var item in info.lista_detalle)
                    {
                        item.IdDev_Inven = IdDev_Inven;
                        c++;
                        item.secuencia = c;
                    }
                    in_devolucion_inven_det_Bus BusDev_inv_det = new in_devolucion_inven_det_Bus();
                    Respuesta = BusDev_inv_det.GuardarDB(info.lista_detalle, ref mensaje);


                    in_Parametro_Bus BusParametro = new in_Parametro_Bus();
                    in_Parametro_Info InfoParametro = new in_Parametro_Info();
                    InfoParametro = BusParametro.Get_Info_Parametro(info.IdEmpresa);
                    in_movi_inven_tipo_Info InfoMovi_tipo = new in_movi_inven_tipo_Info();
                    in_movi_inven_tipo_Bus BusMovi_tipo = new in_movi_inven_tipo_Bus();


                    InfoMovi_tipo = BusMovi_tipo.Get_Info_movi_inven_tipo(info.IdEmpresa, info.IdMovi_inven_tipo);

                    //                    in_movi_inve_Bus BusMovi_Inven = new in_movi_inve_Bus();
                    //                    in_movi_inve_Info InfoMovi_Inven = new in_movi_inve_Info();                    

                    //InfoMovi_Inven  = BusMovi_Inven.Get_Info_Movi_inven(info.IdEmpresa, info.IdSucursal_movi_inven, info.IdBodega_movi_inven, info.IdMovi_inven_tipo, info.IdNumMovi);

                    in_Ing_Egr_Inven_Bus Bus_Ing_Egre = new in_Ing_Egr_Inven_Bus();
                    in_Ing_Egr_Inven_Info Info_Ing_Egr = new in_Ing_Egr_Inven_Info();

                    Info_Ing_Egr = Bus_Ing_Egre.Get_Info_Ing_Egr_Inven(info.IdEmpresa, info.IdSucursal_movi_inven, info.IdMovi_inven_tipo, info.IdNumMovi);

                    Info_Ing_Egr.IdNumMovi = 0;

                    if (InfoMovi_tipo.cm_tipo_movi == "-")// si es positivo hacer un egreso 
                    {
                        Info_Ing_Egr.IdMovi_inven_tipo = Convert.ToInt32(InfoParametro.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg);
                        Info_Ing_Egr.signo = "+";
                    }
                    else
                    {
                        Info_Ing_Egr.IdMovi_inven_tipo = Convert.ToInt32(InfoParametro.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing);
                        Info_Ing_Egr.signo = "-";
                    }

                    Info_Ing_Egr.CodMoviInven = "";
                    Info_Ing_Egr.cm_observacion = "Ing x Dev/Inv. " + info.observacion;
                    Info_Ing_Egr.cm_fecha = info.Fecha.Date;//La fecha de devolución
                    Info_Ing_Egr.IdUsuario = param.IdUsuario;
                    Info_Ing_Egr.Estado = "A";

                    c = 0;


                    foreach (var item in info.lista_detalle)
                    {

                        c = c + 1;
                        in_movi_inve_detalle_Info info_det_movi = new in_movi_inve_detalle_Info();
                        in_movi_inve_detalle_Bus bus_det_movi = new in_movi_inve_detalle_Bus();
                        info_det_movi = bus_det_movi.Get_info_Movi_inven_det(item.IdEmpresa_movi_inv, item.IdSucursal_movi_inv, item.IdBodega_movi_inv, item.IdMovi_inven_tipo_movi_inv, item.IdNumMovi_movi_inv, item.Secuencia_movi_inv);

                        in_Ing_Egr_Inven_det_Info InfoDet_Ing_Egr = new in_Ing_Egr_Inven_det_Info();

                        InfoDet_Ing_Egr.IdEmpresa = item.IdEmpresa;
                        InfoDet_Ing_Egr.IdSucursal = item.IdSucursal_movi_inv;
                        InfoDet_Ing_Egr.IdNumMovi = 0;
                        InfoDet_Ing_Egr.Secuencia = c;
                        InfoDet_Ing_Egr.IdBodega = item.IdBodega_movi_inv;
                        InfoDet_Ing_Egr.IdProducto = info_det_movi.IdProducto;
                        if (Info_Ing_Egr.signo == "+")// si es positivo hacer un egreso 
                        {
                            InfoDet_Ing_Egr.dm_cantidad_sinConversion = Math.Abs(item.cantidad_a_devolver);
                            InfoDet_Ing_Egr.dm_cantidad = Math.Abs(item.cantidad_a_devolver);
                            InfoDet_Ing_Egr.IdEstadoAproba = "APRO";//Debe ir directamente aprobado para poder vincularlo al ing/egr que se va a devolver por cuestiones del recosteo
                        }
                        else
                        {
                            InfoDet_Ing_Egr.dm_cantidad_sinConversion = Math.Abs(item.cantidad_a_devolver);
                            InfoDet_Ing_Egr.dm_cantidad = Math.Abs(item.cantidad_a_devolver) * -1;
                            InfoDet_Ing_Egr.IdEstadoAproba = "APRO";//Debe ir directamente aprobado para poder vincularlo al ing/egr que se va a devolver por cuestiones del recosteo
                        }

                        //Se pasa directamente el costo y unidad de medida convertido
                        InfoDet_Ing_Egr.mv_costo_sinConversion = (info_det_movi.mv_costo == null) ? 0 : Convert.ToDouble(info_det_movi.mv_costo);
                        InfoDet_Ing_Egr.mv_costo = (info_det_movi.mv_costo == null) ? 0 : Convert.ToDouble(info_det_movi.mv_costo);
                        InfoDet_Ing_Egr.IdUnidadMedida = info_det_movi.IdUnidadMedida;
                        InfoDet_Ing_Egr.IdUnidadMedida_Consumo = info_det_movi.IdUnidadMedida;
                        InfoDet_Ing_Egr.IdUnidadMedida_sinConversion = info_det_movi.IdUnidadMedida;

                        //Ingreso los id del detalle que esta devolviendo
                        InfoDet_Ing_Egr.IdEmpresa_dev = item.IdEmpresa_movi_inv;
                        InfoDet_Ing_Egr.IdSucursal_dev = item.IdSucursal_movi_inv;
                        InfoDet_Ing_Egr.IdBodega_dev = item.IdBodega_movi_inv;
                        InfoDet_Ing_Egr.IdMovi_inven_tipo_dev = item.IdMovi_inven_tipo_movi_inv;
                        InfoDet_Ing_Egr.IdNumMovi_dev = item.IdNumMovi_movi_inv;
                        InfoDet_Ing_Egr.Secuencia_dev = item.Secuencia_movi_inv;

                        //Campos de egresos
                        InfoDet_Ing_Egr.IdPunto_cargo = info_det_movi.IdPunto_Cargo;
                        InfoDet_Ing_Egr.IdPunto_cargo_grupo = info_det_movi.IdPunto_cargo_grupo;
                        InfoDet_Ing_Egr.IdCentroCosto = info_det_movi.IdCentroCosto;
                        InfoDet_Ing_Egr.IdCentroCosto_sub_centro_costo = info_det_movi.IdCentroCosto_sub_centro_costo;

                        Info_Ing_Egr.listIng_Egr.Add(InfoDet_Ing_Egr);

                    }

                    decimal IdNumMovi = 0;

                    Respuesta = Bus_Ing_Egre.GuardarDB(Info_Ing_Egr, ref IdNumMovi, ref mensaje);
                }


                return Respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_Bus) };

            }
        }


        public Boolean ModificarDB(in_devolucion_inven_Info info, ref string msgs)
        {
            try
            {
                return oDat.ModificarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_Bus) };

            }
        }

        public Boolean AnularDB(in_devolucion_inven_Info info, ref string msgs)
        {
            try
            {
                return oDat.AnularDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_Bus) };

            }
        }

        public List<in_devolucion_inven_Info> Get_List_in_devolucion_inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
              DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oDat.Get_List_in_devolucion_inven(IdEmpresa, IdSucursalIni, IdSucursalFin,  FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_in_devolucion_inven", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_Bus) };

            }
        }

        public in_devolucion_inven_Info Get_Info_in_devolucion_inven(int IdEmpresa, decimal IdDev_Inven)
        {
            try
            {
                return oDat.Get_Info_in_devolucion_inven(IdEmpresa, IdDev_Inven);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_in_devolucion_inven", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_Bus) };

            }
        }

    }
}
