using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_cobro_x_Anticipo_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cxc_cobro_x_Anticipo_Data data = new cxc_cobro_x_Anticipo_Data();
        cxc_cobro_x_Anticipo_det_Data data_det = new cxc_cobro_x_Anticipo_det_Data();


        
        public List<cxc_cobro_x_Anticipo_Info> Get_List_cobro_x_Anticipo(int IdEmpresa, ref string mensaje)
        {
            try
            {
                return data.Get_List_cobro_x_Anticipo(IdEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        
        }

        public  Boolean validar_objeto(cxc_cobro_x_Anticipo_Info info,ref string mensaje)
        {
            try 
            {
                Boolean res=true;

                if (info.listDetalle_Anticipo == null || info.listDetalle_Anticipo.Count == 0)
                {
                    mensaje = "No hay detalle en el objeto ";
                    res = false;
                }

                if (info.IdEmpresa == 0 || info.IdSucursal==0 || info.IdCaja==0)
                {
                    mensaje = "no hay idempresa o idsucursao o idcaja  ";
                    res = false;
                }



                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public Boolean GuardarDB(cxc_cobro_x_Anticipo_Info infoAnticipo, ref string mensaje, Boolean Generar_Cobro_x_det, Cl_Enumeradores.PantallaEjecucion Accion)
        {
            try
            {
                Boolean resGrabar=true;

                if (validar_objeto(infoAnticipo, ref mensaje))
                {

                    cxc_cobro_Bus cobroBus = new cxc_cobro_Bus();
                    //grabando cabecera de anticipo
                    resGrabar = data.GrabarDB(infoAnticipo, ref mensaje);

                    foreach (var item in infoAnticipo.listDetalle_Anticipo)
                    {
                        item.IdEmpresa = infoAnticipo.IdEmpresa;
                        item.IdAnticipo = infoAnticipo.IdAnticipo;
                    }
                    //grabando detalle de anticipo
                    data_det.GuardarDB(infoAnticipo.listDetalle_Anticipo, ref mensaje);


                    if (Generar_Cobro_x_det)
                    {

                        int contCobro = 1;
                        foreach (var item in infoAnticipo.listCobros)
                        {
                                cxc_cobro_x_Anticipo_det_Info AnticipoDetalle = new cxc_cobro_x_Anticipo_det_Info();
                                cxc_cobro_Info infoCobro = item;

                                AnticipoDetalle = infoAnticipo.listDetalle_Anticipo.Find(v => v.IdFila == contCobro);
                                infoCobro.Infocxc_cobro_x_Anticipo_det = AnticipoDetalle;
                                decimal IdCobro = 0;

                                if (cobroBus.GuardarDB(Accion, ref infoCobro, ref mensaje) == false)
                                {
                                    return false;
                                }                                                      

                                AnticipoDetalle.IdEmpresa_Cobro = infoCobro.IdEmpresa;
                                AnticipoDetalle.IdCobro_cobro = infoCobro.IdCobro;
                                AnticipoDetalle.IdSucursal_cobro = infoCobro.IdSucursal;
                           
                                contCobro++;
                        }
                    }

                }
                else
                {
                    resGrabar = false;
                }


                return resGrabar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }


        public Boolean ModificarDB(cxc_cobro_x_Anticipo_Info info, ref string mensaje)
        {
            try
            {
                return data.ModificarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public decimal Existe(int IdCliente, ref string mensaje)
        {
            try
            {
                return data.Existe(IdCliente, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Existe", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }

        public List<cxc_cobro_x_Anticipo_Info> Get_List_cobro_x_Anticipo(int IdEmpresa, int IdAnticipo, ref string mensaje)
        {
            try
            {
                return data.Get_List_cobro_x_Anticipo(IdEmpresa, IdAnticipo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_Anticipo_Bus) };
            }
        }
    
    }
}
