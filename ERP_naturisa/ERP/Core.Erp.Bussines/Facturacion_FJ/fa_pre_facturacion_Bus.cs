using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_pre_facturacion_Bus
    {
        fa_pre_facturacion_det_egr_x_bod_Bus bus_det_egr = new fa_pre_facturacion_det_egr_x_bod_Bus();
        fa_pre_facturacion_det_cobro_x_Poliza_Bus bus_det_poliza = new fa_pre_facturacion_det_cobro_x_Poliza_Bus();
        fa_pre_facturacion_det_Fact_x_Gastos_Bus bus_det_fact_x_gastos = new fa_pre_facturacion_det_Fact_x_Gastos_Bus();
        fa_pre_facturacion_det_cobro_x_Movilizacion_Bus bus_det_Movilizacion = new fa_pre_facturacion_det_cobro_x_Movilizacion_Bus();
        fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus bus_det_Depreciacion = new fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus();
        fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Bus bus_det_Unidades = new fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Bus();
        fa_pre_facturacion_det_Otros_Bus bus_otros = new fa_pre_facturacion_det_Otros_Bus();
        fa_pre_facturacion_Data oData = new fa_pre_facturacion_Data();

        public List<fa_pre_facturacion_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public fa_pre_facturacion_Info Get_Info(int IdEmpresa, decimal IdPreFacturacion)
        {
            try
            {
                return oData.Get_Info(IdEmpresa, IdPreFacturacion);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public fa_pre_facturacion_Info Get_Info_x_periodo(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                return oData.Get_Info_x_periodo(IdEmpresa, IdPeriodo);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public Boolean GuardarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public Boolean ModificarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                if (oData.ModificarDB(info))
                {
                    if (bus_det_egr.EliminarDB(info))
                        bus_det_egr.Guardar(info.lst_det_egr_x_bod);
                    if (bus_det_poliza.EliminarDB(info))
                        bus_det_poliza.GuardarDB(info.lst_det_poliza);
                    if (bus_det_fact_x_gastos.EliminarDB(info))
                        bus_det_fact_x_gastos.GuardarDB(info.lst_det_fact);
                    if (bus_det_Movilizacion.EliminarDB(info))
                        bus_det_Movilizacion.GuardarDB(info.lst_det_Movi);
                    if (bus_det_Depreciacion.EliminarDB(info))
                        bus_det_Depreciacion.GuardarDB(info.lst_det_Depreciacion);
                    if (bus_det_Unidades.EliminarDB(info))
                        bus_det_Unidades.GuardarDB(info.lst_det_Unidades);
                    foreach (var item in info.lst_det_Otros)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                    }
                    if(bus_otros.EliminarDB(info.IdEmpresa,Convert.ToInt32( info.IdPreFacturacion)))
                        bus_otros.GuardarDB(info.lst_det_Otros);

                }
                 return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public Boolean AnularDB(fa_pre_facturacion_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public Decimal PreFacturar_x_periodo(fa_pre_facturacion_Info info)
        {
            try
            {
                return oData.PreFacturar_x_periodo(info);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
