using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt018_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<XCONTA_Rpt018_Info> lst_rpt = new List<XCONTA_Rpt018_Info>();
        XCONTA_Rpt018_Bus bus_rpt = new XCONTA_Rpt018_Bus();

        public XCONTA_Rpt018_rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt018_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;

                int IdEmpresa = 0;
                int IdPunto_cargo_grupo = 0;
                bool Mostrar_detalle = false;
                DateTime Fecha_ini = DateTime.Now;
                DateTime Fecha_fin = DateTime.Now;

                IdEmpresa = param.IdEmpresa;
                IdPunto_cargo_grupo = Convert.ToInt32(P_IdPunto_cargo_grupo.Value);
                Mostrar_detalle = Convert.ToBoolean(P_Mostrar_detalle.Value);
                Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                
                Remover_columnas();

                lst_rpt = bus_rpt.Get_list_reporte(IdEmpresa, Fecha_ini, Fecha_fin, IdPunto_cargo_grupo, Mostrar_detalle);
                if (lst_rpt.Count==0)
                {
                    xrLmensaje.Text = "Los filtros no han generado ningún resultado";
                    xrLmensaje.Visible = true;
                }
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt018_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt018_rpt) };
            }
        }

        private void cab_grupo_GPC_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(P_IdPunto_cargo_grupo.Value) != 0)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt018_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt018_rpt) };
            }
        }

        private void pie_grupo_CUENTA_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(P_Mostrar_detalle.Value) == false)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt018_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt018_rpt) };
            }
        }

        private void cab_grupo_CUENTA_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(P_Mostrar_detalle.Value) == false)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt018_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt018_rpt) };
            }
        }

        private void Remover_columnas()
        {
            try
            {
                float width_cabecera = tbl_cabecera.WidthF;
                float width_detalle = tbl_detalle.WidthF;
                if (!Convert.ToBoolean(P_Mostrar_detalle.Value))
                {
                    //Agrego columnas
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_IdCtaCble))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_IdCtaCble);
                        tbl_detalle.Rows[0].Controls.Add(cel_IdCtaCble_det);
                    }
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_Cuenta))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_Cuenta);
                        tbl_detalle.Rows[0].Controls.Add(cel_Cuenta_det);
                    }

                    //Remuevo columnas
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_comprobante))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_comprobante);
                        tbl_detalle.Rows[0].Controls.Remove(cel_comprobante_det);
                    }
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_num_comprobante))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_num_comprobante);
                        tbl_detalle.Rows[0].Controls.Remove(cel_num_comprobante_det);
                    }
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_Observacion))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_Observacion);
                        tbl_detalle.Rows[0].Controls.Remove(cel_Observacion_det);
                    }
                    //Remuevo valor
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_Valor))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_Valor);
                        tbl_detalle.Rows[0].Controls.Remove(cel_Valor_det);
                    }
                    //Agrego valor
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_Valor))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_Valor);
                        tbl_detalle.Rows[0].Controls.Add(cel_Valor_det);
                    }
                }
                else
                {
                    //Agrego columnas
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_comprobante))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_comprobante);
                        tbl_detalle.Rows[0].Controls.Add(cel_comprobante_det);
                    }
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_num_comprobante))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_num_comprobante);
                        tbl_detalle.Rows[0].Controls.Add(cel_num_comprobante_det);
                    }
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_Observacion))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_Observacion);
                        tbl_detalle.Rows[0].Controls.Add(cel_Observacion_det);
                    }
                    //Remuevo columnas
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_IdCtaCble))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_IdCtaCble);
                        tbl_detalle.Rows[0].Controls.Remove(cel_IdCtaCble_det);
                    }
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_Cuenta))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_Cuenta);
                        tbl_detalle.Rows[0].Controls.Remove(cel_Cuenta_det);
                    }
                    //Remuevo valor
                    if (tbl_cabecera.Rows[0].Controls.Contains(cel_Valor))
                    {
                        tbl_cabecera.Rows[0].Controls.Remove(cel_Valor);
                        tbl_detalle.Rows[0].Controls.Remove(cel_Valor_det);
                    }
                    //Agrego valor
                    if (!tbl_cabecera.Rows[0].Controls.Contains(cel_Valor))
                    {
                        tbl_cabecera.Rows[0].Controls.Add(cel_Valor);
                        tbl_detalle.Rows[0].Controls.Add(cel_Valor_det);
                    }
                }
                tbl_cabecera.WidthF = width_cabecera;
                tbl_detalle.WidthF = width_detalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Remover_columnas", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt018_rpt) };
            }
        }
    }
}
