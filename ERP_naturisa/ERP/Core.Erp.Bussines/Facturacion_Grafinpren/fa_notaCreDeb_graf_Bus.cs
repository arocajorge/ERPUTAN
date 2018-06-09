using Core.Erp.Business.Facturacion;
using Core.Erp.Data.Facturacion_Grafinpren;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_Grafinpren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.class_sri.NotaCredito;

using System.Xml.Serialization;
using System.IO;

namespace Core.Erp.Business.Facturacion_Grafinpren
{
    public class fa_notaCreDeb_graf_Bus
    {
        #region "Variables Y Propiedades "
        Facturacion.fa_notaCredDeb_Bus BusGeneral = new Facturacion.fa_notaCredDeb_Bus();
        fa_notaCreDeb_det_bus BusGeneral_det = new fa_notaCreDeb_det_bus();
        fa_notaCreDeb_graf_Data data = new fa_notaCreDeb_graf_Data();
        fa_notaCreDeb_Data oData_NotaCredDeb = new fa_notaCreDeb_Data();
        #endregion

        #region " Grabar "
        public Boolean GrabarDB(fa_notaCreDeb_Info info, ref decimal idnota,  ref string mensajeDocumentoDupli, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                


                res = BusGeneral.GuardarDB(info, ref idnota, ref mensajeDocumentoDupli, ref mensaje);
                if (res)
                {
                    info.NotaCreDeb_Graf_Info.IdNota = idnota;
                    data.GrabarDB(info.NotaCreDeb_Graf_Info, ref mensaje);
                    res = true;
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
        #endregion 

        #region " Modificar "
        public Boolean ModificarDB(fa_notaCreDeb_Info info, ref string msg, ref string mensajeDocumentoDupli)
        {
            try
            {
                Boolean Res = false;
                Res = BusGeneral.ActualizarDB(info, ref msg, ref mensajeDocumentoDupli);
                if (Res)
                {
                    data.ModificarDB(info.NotaCreDeb_Graf_Info, ref msg);
                    Res = true;
                }
                return Res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
        #endregion

        #region " Anular "
        public Boolean AnularDB(fa_notaCreDeb_Info oNota, ref string mensajeError)
        {
            try
            {
                return BusGeneral.AnularDB(oNota, ref mensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularNota", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
        #endregion

        #region " Verificar Codigo "
        public Boolean VerificarCodigo(string Codigo)
        {
            try
            {
                return BusGeneral.VerificarCodigo(Codigo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
        #endregion

        #region " Generar XML NCD "
        public Boolean GenerarXml_notaCreDeb(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, string CreDeb, string RutaDescarga, ref string msg)
        {
            try
            {
                string sIdCbteNotCreDeb = "";

                List<vwfa_notaCreDeb_sri_Info> lista_NotaCreDeb_sri = new List<vwfa_notaCreDeb_sri_Info>();
                List<fa_notaCreDeb_graf_Info> Lista_Campos_Adicionales = new List<fa_notaCreDeb_graf_Info>();
                lista_NotaCreDeb_sri = oData_NotaCredDeb.Get_list_NotaCreDeb_Sri(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref msg);

                if (lista_NotaCreDeb_sri.Count != 0)
                {
                    // validar objeto

                    if (!BusGeneral.ValidarObjeto_XML_notaCreDeb(lista_NotaCreDeb_sri, ref  msg))
                        return false;

                    if (CreDeb == "C")
                    {
                        List<notaCredito> lista = new List<notaCredito>();
                        //xml
                        lista = BusGeneral.Get_List_GenerarXml_NotaCredito(IdEmpresa, IdSucursal, IdBodega, IdNota, CreDeb, ref msg);
                        
                        //campos adicionales del xml
                        Lista_Campos_Adicionales = Get_List_Notas(IdEmpresa, IdSucursal, IdBodega, IdNota, ref msg);
                       
                        fa_notaCreDeb_graf_Info info= new fa_notaCreDeb_graf_Info();
                        info=Lista_Campos_Adicionales.FirstOrDefault();
                        foreach (var item in lista)
                        {
                            if(item.infoAdicional==null)
                                item.infoAdicional = new List<notaCreditoCampoAdicional>();
                            if (info.sc_observacion != null)
                            {
                                notaCreditoCampoAdicional ad = new notaCreditoCampoAdicional();
                                ad.nombre = "Observacion";
                                ad.Value = info.sc_observacion;
                                item.infoAdicional.Add(ad);
                            }

                            if (info.pe_direccion != null)
                            {
                                notaCreditoCampoAdicional ad = new notaCreditoCampoAdicional();
                                ad.nombre = "Direccion";
                                ad.Value = info.pe_direccion;
                                item.infoAdicional.Add(ad);
                            }
                        }
                        if (lista.Count != 0)
                        {
                            foreach (var item in lista)
                            {
                                sIdCbteNotCreDeb = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.NTC + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                                XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                                NamespaceObject.Add("", "");
                                XmlSerializer mySerializer = new XmlSerializer(typeof(notaCredito));
                                StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbteNotCreDeb + ".xml");
                                mySerializer.Serialize(myWriter, item, NamespaceObject);
                                myWriter.Close();
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarXml_notaCreDeb", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_Bus) };
            }
        }
        #endregion

        #region " Lista Cabecera Notas CD "
        public List<fa_notaCreDeb_Info> Get_List_Notas(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, DateTime FechaIni, DateTime FechaFin, string CreDeb, ref string mensaje)
        {
            try
            {
                return data.Get_List_Notas(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin, CreDeb, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Notas", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }

        public List<fa_notaCreDeb_graf_Info> Get_List_Notas(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, ref string msg)
        {
            try
            {
                return data.Get_List_Notas(IdEmpresa, IdSucursal, IdBodega, IdNota, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Notas", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
        #endregion

        #region " Lista Detalle Notas CD "
        public List<fa_notaCreDeb_det_Info> Get_List_notaCreDeb_det(fa_notaCreDeb_Info info)
        {
            try
            {
                return BusGeneral_det.Get_List_notaCreDeb_det(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_notaCreDeb_det", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
        #endregion

        public fa_notaCreDeb_graf_Info get_Info_graf(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return data.get_Info_graf(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Info_graf", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_graf_Bus) };
            }
        }
    }
}
