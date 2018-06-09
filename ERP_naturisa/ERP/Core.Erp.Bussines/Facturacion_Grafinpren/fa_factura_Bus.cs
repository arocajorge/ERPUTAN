using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.CuentasxCobrar;

using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Data.Facturacion_Grafinpren;

using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;

using System.Xml.Serialization;
using System.IO;
using Core.Erp.Info.Facturacion_Grafinpren;

namespace Core.Erp.Business.Facturacion_Grafinpren
{
    public class fa_factura_Bus
    {
        string mesage = "";

        string campoAdicional = null;
        string format = "dd/MM/yyyy";

        Facturacion.fa_factura_Bus Factura = new Facturacion.fa_factura_Bus();
        fa_factura_graf_Bus Factura_Graf = new fa_factura_graf_Bus();
        fa_Factura_Data data = new fa_Factura_Data();
        

        public Boolean GuardarDB(fa_factura_Info Factura_info, ref decimal IdCbt_vta, ref string numDocFactura, ref string msg, ref string mensajeDocumentoDupli)
        {
            try
            {
                bool resultado = false;
                resultado = Factura.GuardarDB(Factura_info, ref IdCbt_vta, ref numDocFactura, ref msg, ref mensajeDocumentoDupli);
                if (resultado)
                {
                    Factura_info.Factura_Graf.IdCbteVta = IdCbt_vta;
                    resultado = Factura_Graf.GrabarDB(Factura_info.Factura_Graf, IdCbt_vta, ref mesage);
                }
                else
                    resultado = false;

                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public Boolean ModificarDB(fa_factura_Info info, ref string msg)
        {
            try
            {
                bool resultado = false;

                resultado = Factura.ModificarDB(info, ref msg);
                if (resultado)
                {

                    if (info.lista_formaPago_x_Factura.Count() > 0)
                    {
                        fa_factura_x_formaPago_Bus BusFac_x_fo = new fa_factura_x_formaPago_Bus();
                        if (BusFac_x_fo.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta, ref msg))
                        {
                            BusFac_x_fo.GuardarDB(info.lista_formaPago_x_Factura, ref msg);
                        }
                    }


                    info.Factura_Graf.IdCbteVta = info.IdCbteVta;
                    resultado = Factura_Graf.ModificarDB(info.Factura_Graf, ref mesage);
                   

                }
                else
                    resultado = false;

                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public Boolean AnularDB(fa_factura_Info info, DateTime fecha_Anulacion, ref string msg)
        {
            try
            {
                return Factura.AnularDB(info, fecha_Anulacion, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public fa_factura_Info Get_Info_factura(int idEmpresa, int idSucursal, int idBodega, decimal IdCbteVta)
        {
            try
            {
                return Factura.Get_Info_factura(idEmpresa, idSucursal, idBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public fa_factura_Info Get_Info_factura_x_Numero_Factura(int idEmpresa, int idSucursal, int idBodega, String NumFac)
        {
            try
            {
                return Factura.Get_Info_factura_x_Numero_Factura(idEmpresa, idSucursal, idBodega, NumFac);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabeceraNumDoc", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public List<fa_factura_Info> Get_List_factura(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Factura_Graf.Get_List_factura(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaFactura", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }
        public fa_factura_graf_Info Get_Info_graf(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return Factura_Graf.Get_Info_graf(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_graf", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }


        public Boolean GenerarXml_Factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, string RutaDescarga, ref string msg)
        {
            try
            {
                string sIdCbteFact = "";

                List<vwfa_factura_sri_Info> lista_Factura_sri = new List<vwfa_factura_sri_Info>();
                List<Core.Erp.Info.Facturacion_Grafinpren.fa_factura_graf_Info> Lista_Campos_Adicionales = new List<Core.Erp.Info.Facturacion_Grafinpren.fa_factura_graf_Info>();
                vwfa_factura_sri_Bus Bus_Factura = new vwfa_factura_sri_Bus();

                lista_Factura_sri = Bus_Factura.Get_list_Factura_Sri(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);

                if (lista_Factura_sri.Count != 0)
                {
                    //validar objeto
                    if (!Factura.ValidarObjeto_XML_Factura(lista_Factura_sri, ref  msg))
                        return false;

                    List<factura> lista = new List<factura>();
                    lista = Factura.Get_List_Xml_Factura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);

                    //campos adicionales
                    Lista_Campos_Adicionales = Factura_Graf.Get_List_factura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);

                    Info.Facturacion_Grafinpren.fa_factura_graf_Info info = new Info.Facturacion_Grafinpren.fa_factura_graf_Info();
                    info = Lista_Campos_Adicionales.FirstOrDefault();

                    foreach (var item in lista)
                    {
                        if (item.infoAdicional==null)
                            item.infoAdicional = new List<Info.class_sri.FacturaV2.facturaCampoAdicional>();
                        if (info.Observacion != null)
                        {
                            facturaCampoAdicional ad = new facturaCampoAdicional();
                            ad.nombre = "Observacion";
                            ad.Value = info.Observacion;
                            item.infoAdicional.Add(ad);
                        }

                        if (info.pe_direccion != null)
                        {
                            facturaCampoAdicional ad = new facturaCampoAdicional();
                            ad.nombre = "Direccion";
                            ad.Value = info.pe_direccion;
                            item.infoAdicional.Add(ad);
                        }
                    }

                    if (lista.Count != 0)
                    {
                        foreach (var item in lista)
                        {
                            try
                            {
                                sIdCbteFact = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.FAC + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(factura));
                                StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbteFact + ".xml");
                                mySerializer.Serialize(myWriter, item, NamespaceObject);
                                myWriter.Close();
                            }
                            catch (Exception)
                            {
                                msg = "No se generó el XML, posiblemente porque su máquina no tiene acceso a la ruta "+RutaDescarga;
                                return false;
                            }
                            
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public Boolean get_Keys_CteCble_x_Costo(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref int ct_IdEmpresa, ref int ct_IdTipoCbte, ref decimal ct_IdCbteCble)
        {
            try
            {
                return Factura.get_Keys_CteCble_x_Costo(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref ct_IdEmpresa, ref ct_IdTipoCbte, ref ct_IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }
    }
}
