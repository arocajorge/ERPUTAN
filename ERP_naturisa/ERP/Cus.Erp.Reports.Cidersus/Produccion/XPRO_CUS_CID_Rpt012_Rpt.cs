using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Business.Inventario_Edehsa;
using System.Linq;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public partial class XPRO_CUS_CID_Rpt012_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<XPRO_CUS_CID_Rpt012_Info> listDataRpt = new List<XPRO_CUS_CID_Rpt012_Info>();
        List<XPRO_CUS_CID_Rpt012_Info> listDataReporte = new List<XPRO_CUS_CID_Rpt012_Info>();

        List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info> listDimensiones_Elementos_Ensamblados = new List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info>();
        List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info> listPeso_x_ProductoFinal = new List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info>();

        public string sCodObra = "";


        

        public XPRO_CUS_CID_Rpt012_Rpt()
        {
            InitializeComponent();
        }

        private void XPRO_CUS_CID_Rpt012_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                ////this.pFechaReporte.Value = DateTime.Now.ToString();
                ////this.pEmpresa.Value = param.InfoEmpresa.em_nombre;
                ////this.pDireccion.Value = param.InfoEmpresa.em_direccion;
                //////this.pRuc.Value = "";
                ////lblRuc.Text = param.InfoEmpresa.em_ruc;
                ////pictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XPRO_CUS_CID_Rpt012_Bus repbus = new XPRO_CUS_CID_Rpt012_Bus();
                List<XPRO_CUS_CID_Rpt012_Info> listDataRpt = new List<XPRO_CUS_CID_Rpt012_Info>();

                string mensaje = "";
                sCodObra = Convert.ToString(this.pCodigoObra.Value);


                listDataRpt = repbus.consultar_data_x_Obra(param.IdEmpresa,param.IdSucursal,sCodObra);


                listDimensiones_Elementos_Ensamblados = repbus.Dimensiones_Elementos_Ensamblados(param.IdEmpresa, param.IdSucursal, sCodObra);
                listPeso_x_ProductoFinal = listDimensiones_Elementos_Ensamblados
                                     .GroupBy(
                                         p => new
                                         {
                                             //IdEmpresa = p.IdEmpresa,//IdSucursal = p.IdSucursal,//CodObra = p.CodObra,//IdOrdenTaller = p.IdOrdenTaller,//IdEnsamblado = p.IdEnsamblado,
                                             cb_producto_final = p.cb_producto_final,
                                             //pesoSubpieza = p.pesoSubpieza //NO SE INCLUYE EL CAMPO X EL CUAL SE QUIERE HACER LA SUMATORIA
                                         }
                                         )
                                     .Select(g => new vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info
                                             {
                                                 //IdEmpresa = g.Key.IdEmpresa,//IdSucursal = g.Key.IdSucursal,//CodObra = g.Key.CodObra,//IdOrdenTaller = g.Key.IdOrdenTaller,//IdEnsamblado = g.Key.IdEnsamblado,
                                                 cb_producto_final = g.Key.cb_producto_final,
                                                 pesoProductoFinal = g.Sum(p => p.pesoSubpieza)
                                             }
                                         )
                                     .ToList();

                foreach (var itemrpt in listDataRpt)
                {
                    XPRO_CUS_CID_Rpt012_Info inforpt = new XPRO_CUS_CID_Rpt012_Info();


                    
                    inforpt.IdEmpresa = itemrpt.IdEmpresa;
                    inforpt.IdSucursal = itemrpt.IdSucursal;
                    inforpt.CodObra = itemrpt.CodObra;
                    inforpt.orden_taller = itemrpt.orden_taller;
                    inforpt.producto_final = itemrpt.producto_final;
                    inforpt.cb_producto_final = itemrpt.cb_producto_final;
                    inforpt.IdEtapaInicio = itemrpt.IdEtapaInicio;
                    inforpt.cb_producto_elemento = itemrpt.cb_producto_elemento;
                    inforpt.proveedor = itemrpt.proveedor;
                    inforpt.subgrupo = itemrpt.subgrupo;
                    inforpt.fecha_movi_inicio = itemrpt.fecha_movi_inicio;
                    inforpt.fecha_movi_fin = itemrpt.fecha_movi_fin;
                    inforpt.ca_Categoria = itemrpt.ca_Categoria;
                    inforpt.Alto = itemrpt.Alto;
                    inforpt.ancho = itemrpt.ancho;
                    inforpt.diametro = Convert.ToDouble(itemrpt.diametro);
                    inforpt.ceja = Convert.ToDouble(itemrpt.ceja);
                    inforpt.espesor = Convert.ToDouble(itemrpt.espesor);
                    inforpt.Largo = itemrpt.Largo;
                    inforpt.lider = itemrpt.lider;
                    inforpt.Chofer = itemrpt.Chofer;
                    inforpt.Placa = itemrpt.Placa;
                    inforpt.TipoTransporte = itemrpt.TipoTransporte;
                    inforpt.fecha_despacho = itemrpt.fecha_despacho;

                    inforpt.IdCategoria = itemrpt.IdCategoria;
                    inforpt.IdEnsamblado = itemrpt.IdEnsamblado;

                    foreach (var itempeso_prfinal in listPeso_x_ProductoFinal)
                    {
                        if (itempeso_prfinal.cb_producto_final == itemrpt.cb_producto_final)
                        {
                            inforpt.pesoProductoFinal = itempeso_prfinal.pesoProductoFinal;
                        }

                    }


                    listDataReporte.Add(inforpt);

                }

                this.DataSource = listDataReporte.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_CAH_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XPRO_CUS_CID_Rpt012_Rpt) };
            }
        }



       

       

    }
}
