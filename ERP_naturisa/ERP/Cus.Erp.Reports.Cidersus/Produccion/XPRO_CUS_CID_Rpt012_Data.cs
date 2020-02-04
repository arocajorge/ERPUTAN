using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario_Edehsa;
using Core.Erp.Info.Inventario_Edehsa;
//using Cus.Erp.Reports.Cidersus.Produccion;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public class XPRO_CUS_CID_Rpt012_Data
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<in_Categoria_x_Formula_Info> Categoria_x_FormulaList = new List<in_Categoria_x_Formula_Info>();
        in_Categoria_x_Formula_Info Categoria_x_FormulaInfo = new in_Categoria_x_Formula_Info();
        in_Categoria_x_Formula_bus Categoria_x_FormulaBus = new in_Categoria_x_Formula_bus();

        public List<XPRO_CUS_CID_Rpt012_Info> consultar_data_x_Obra(int IdEmpresa,int IdSucursal,string CodObra)
        {
            try
            {
                List<XPRO_CUS_CID_Rpt012_Info> listadatos = new List<XPRO_CUS_CID_Rpt012_Info>();

                using (EntitiesProduccion_Edehsa_Rpt ECompras = new EntitiesProduccion_Edehsa_Rpt())
                {
                    var select = from q in ECompras.vwPRO_CUS_CID_Rpt012
                                 where q.CodObra == CodObra
                                 && q.IdSucursal == IdSucursal
                                 && q.IdEmpresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        XPRO_CUS_CID_Rpt012_Info itemInfo = new XPRO_CUS_CID_Rpt012_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.CodObra = item.CodObra;
                        itemInfo.orden_taller = item.orden_taller;
                        itemInfo.producto_final = item.producto_final;
                        itemInfo.cb_producto_final = item.cb_producto_final;
                        itemInfo.IdEtapaInicio = item.IdEtapaInicio;
                        itemInfo.cb_producto_elemento = item.cb_producto_elemento;
                        itemInfo.proveedor = item.proveedor;
                        itemInfo.subgrupo = item.subgrupo;
                        itemInfo.fecha_movi_inicio = item.fecha_movi_inicio;
                        itemInfo.fecha_movi_fin = item.fecha_movi_fin;
                        itemInfo.ca_Categoria = item.ca_Categoria;
                        itemInfo.Alto = item.Alto;
                        itemInfo.ancho = item.ancho;
                        itemInfo.diametro = Convert.ToDouble(item.diametro);
                        itemInfo.ceja = Convert.ToDouble(item.ceja);
                        itemInfo.espesor = Convert.ToDouble(item.espesor);
                        itemInfo.Largo = item.Largo;
                        itemInfo.lider = item.lider;
                        itemInfo.Chofer = item.Chofer;
                        itemInfo.Placa = item.Placa;
                        itemInfo.TipoTransporte = item.TipoTransporte;
                        itemInfo.fecha_despacho = item.fecha_despacho;

                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.IdEnsamblado = item.IdEnsamblado;

                        itemInfo.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                        itemInfo.NumFacturaProveedor = item.NumFacturaProveedor;

                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XPRO_CUS_CID_Rpt012_Info>();
            }
        }

        public List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info> Dimensiones_Elementos_Ensamblados(int IdEmpresa, int IdSucursal, string CodObra)
        {
            try
            {
                List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info> listadatos = new List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info>();

                using (EntitiesProduccion_Edehsa_Rpt ECompras = new EntitiesProduccion_Edehsa_Rpt())
                {
                    var select = from q in ECompras.vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados
                                 where q.CodObra == CodObra
                                 && q.IdSucursal == IdSucursal
                                 && q.IdEmpresa == IdEmpresa
                                 select q;
                    foreach (var item in select)
                    {
                        vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info itemInfo = new vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.CodObra = item.CodObra;

                        itemInfo.IdOrdenTaller = item.IdOrdenTaller;
                        itemInfo.orden_taller = item.orden_taller;
                        
                        itemInfo.IdEnsamblado = item.IdEnsamblado;
                        itemInfo.cb_producto_final = item.cb_producto_final;
                        itemInfo.cb_producto_elemento = item.cb_producto_elemento;
                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.ca_Categoria = item.ca_Categoria;
                        itemInfo.Alto = item.Alto;
                        itemInfo.ancho = item.ancho;
                        itemInfo.diametro = Convert.ToDouble(item.diametro);
                        itemInfo.ceja = Convert.ToDouble(item.ceja);
                        itemInfo.espesor = Convert.ToDouble(item.espesor);
                        itemInfo.Largo = item.Largo;

                        itemInfo.pesoSubpieza = calcularPesoMP(itemInfo.IdEmpresa, Convert.ToInt32(itemInfo.IdCategoria), Convert.ToDouble(itemInfo.Alto), Convert.ToDouble(itemInfo.ancho), Convert.ToDouble(itemInfo.ceja), Convert.ToDouble(itemInfo.Largo), Convert.ToDouble(itemInfo.espesor), Convert.ToDouble(itemInfo.diametro));

                        listadatos.Add(itemInfo);
                    }

                }
                return listadatos;

            }
            catch (Exception ex)
            {
                return new List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info>();
            }
        }

        public double calcularPesoMP(int IdEmpresa, int idcategoria, double alto = 0, double ancho = 0, double ceja = 0, double longitud = 0, double espesor = 0, double diametro = 0)
        {
            try
            {
                double dPesoTeorico = 0;
                //iAlto = (infoRpt.Alto == "") ? 0 : Convert.ToDouble(txeAlto.Text);
                //iAncho = (txeAncho.Text == "") ? 0 : Convert.ToDouble(txeAncho.Text);
                //iCeja = (txeCeja.Text == "") ? 0 : Convert.ToDouble(txeCeja.Text);
                //iLargo = (txeLargo.Text == "") ? 0 : Convert.ToDouble(txeLargo.Text);
                //iEspesor = (txeEspesor.Text == "") ? 0 : Convert.ToDouble(txeEspesor.Text);
                //iDiametro = (txeDiametro.Text == "") ? 0 : Convert.ToDouble(txeDiametro.Text);

                dPesoTeorico = Categoria_x_FormulaBus.CalcularPesoTeorico(IdEmpresa, idcategoria, alto, ancho, ceja, longitud, espesor, diametro);

                return dPesoTeorico;
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
