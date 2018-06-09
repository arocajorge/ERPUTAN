using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Grafinpren
{
    public class fa_notaCreDeb_graf_Data
    {
        #region " Guardar "
        public Boolean GrabarDB(fa_notaCreDeb_graf_Info info, ref string msg)
        {
            try
            {
                Boolean res = false;


                using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
                {
                    

                    var contact = context.fa_notaCreDeb_graf.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa 
                        && minfo.IdSucursal == info.IdSucursal
                        && minfo.IdBodega == info.IdBodega && minfo.IdNota == info.IdNota);

                     if (contact == null) //no hay datos en la base hay q grabar
                     {

                         fa_notaCreDeb_graf address = new fa_notaCreDeb_graf();
                         address.IdEmpresa = info.IdEmpresa;
                         address.IdSucursal = info.IdSucursal;
                         address.IdBodega = info.IdBodega;
                         address.IdNota = info.IdNota;
                         address.num_op = info.num_op;
                         address.fecha_op = info.fecha_op;
                         address.num_cotizacion = info.num_cotizacion;
                         address.fecha_cotizacion = info.fecha_cotizacion;
                         address.IdEquipo = info.IdEquipo;
                         address.porc_comision = info.porc_comision;

                         context.fa_notaCreDeb_graf.Add(address);
                         context.SaveChanges();
                         res = true;
                     }
                     else
                    {
                        res = ModificarDB(info, ref msg);
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        #endregion
         
        #region " Modificar "
        public Boolean ModificarDB(fa_notaCreDeb_graf_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
                {
                    var contact = context.fa_notaCreDeb_graf.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdNota == info.IdNota);

                    if (contact != null)
                    {
                        contact.num_op = info.num_op;
                        contact.fecha_op = info.fecha_op;
                        contact.num_cotizacion = info.num_cotizacion;
                        contact.fecha_cotizacion = info.fecha_cotizacion;
                        contact.IdEquipo = info.IdEquipo;
                        contact.porc_comision = info.porc_comision;
                        context.SaveChanges();
                    }
                    else
                    {
                        GrabarDB(info, ref msg);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region " Lista Cabecera de notas "
        public List<Core.Erp.Info.Facturacion.fa_notaCreDeb_Info> Get_List_Notas(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, DateTime FechaIni, DateTime FechaFin, string CreDeb, ref string msg)
        {
            try
            {
                List<Core.Erp.Info.Facturacion.fa_notaCreDeb_Info> lst = new List<Core.Erp.Info.Facturacion.fa_notaCreDeb_Info>();
                EntitiesFacturacion OEnti = new EntitiesFacturacion();
                if (idSucursalFin == 0)
                {
                    idSucursalIni = 0;
                    idSucursalFin = 5000;
                }

                if (idBodegaFin == 0)
                {
                    idBodegaIni = 0;
                    idBodegaFin = 5000;
                }

                EntitiesFacturacion_Grafinpren Base = new EntitiesFacturacion_Grafinpren();
                var query = from v in Base.vwfa_NotaCre_graf
                            where v.IdEmpresa == idEmpresa
                                      && v.IdBodega >= idBodegaIni 
                                      && v.IdBodega <= idBodegaFin
                                      && v.IdSucursal >= idSucursalIni 
                                      && v.IdSucursal <= idSucursalFin
                                      && v.CreDeb == CreDeb
                            orderby v.IdNota descending
                            select v;
                foreach (var item in query)
                {
                    Core.Erp.Info.Facturacion.fa_notaCreDeb_Info info = new Core.Erp.Info.Facturacion.fa_notaCreDeb_Info();
                  
                    info.NotaCreDeb_Graf_Info.IdNota = item.IdNota;
                    info.NotaCreDeb_Graf_Info.num_cotizacion = item.num_cotizacion;
                    info.NotaCreDeb_Graf_Info.num_op = item.num_op;
                    info.NotaCreDeb_Graf_Info.fecha_cotizacion = item.fecha_cotizacion;
                    info.NotaCreDeb_Graf_Info.IdEquipo = item.IdEquipo;
                    info.NotaCreDeb_Graf_Info.nom_equipo = item.nom_Equipo;
                    info.NotaCreDeb_Graf_Info.porc_comision = item.porc_comision;
                    info.NotaCreDeb_Graf_Info.fecha_op = item.fecha_op;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.Vendedor = item.Vendedor;
                    info.Cliente = item.Cliente;

                    info.CodDocumentoTipo = item.CodDocumentoTipo;
                    info.Serie1 = item.Serie1;
                    info.Serie2 = item.Serie2;
                    info.NumNota_Impresa = item.NumNota_Impresa;


                    info.NaturalezaNota = item.NaturalezaNota;
                    info.IdCliente = item.IdCliente;
                    info.IdVendedor = item.IdVendedor;
                    info.IdNota = item.IdNota;
                    info.IdTipoNota = item.IdTipoNota;
                    info.IdCtaCble_TipoNota = item.IdCtaCble_TipoNota;
                    info.CodNota = item.CodNota;
                    info.no_fecha = item.no_fecha;
                    info.CreDeb = item.CreDeb;
                    info.no_fecha_venc = item.no_fecha_venc;
                    info.fecha_Ctble = item.fecha_Ctble == null ? item.no_fecha : item.fecha_Ctble;
                    info.sc_observacion = item.sc_observacion;
                    info.IdCaja = item.IdCaja;
                    info.Estado = item.Estado;
                    info.IdEmpresa_fac_doc_mod = item.IdEmpresa_fac_doc_mod;
                    info.IdSucursal_fac_doc_mod = item.IdSucursal_fac_doc_mod;
                    info.IdBodega_fac_doc_mod = item.IdBodega_fac_doc_mod;
                    info.IdCbteVta_fac_doc_mod = item.IdCbteVta_fac_doc_mod;
                    info.Total = item.sc_total == null ? 0 : (double)item.sc_total;
                    lst.Add(info);
                }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());

            }

        }

        public List<fa_notaCreDeb_graf_Info> Get_List_Notas(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, ref string msg)
        {
            try
            {
                List<fa_notaCreDeb_graf_Info> lst = new List<fa_notaCreDeb_graf_Info>();
                EntitiesFacturacion OEnti = new EntitiesFacturacion();
                
                EntitiesFacturacion_Grafinpren Base = new EntitiesFacturacion_Grafinpren();
                var query = from v in Base.vwfa_NotaCre_graf
                            where v.IdEmpresa == IdEmpresa
                            && v.IdSucursal == IdSucursal
                            && v.IdBodega == IdBodega
                            && v.IdNota == IdNota
                            select v;
                foreach (var item in query)
                {
                    fa_notaCreDeb_graf_Info info = new fa_notaCreDeb_graf_Info();

                    info.num_cotizacion = item.num_cotizacion;
                    info.num_op = item.num_op;
                    info.fecha_cotizacion = Convert.ToDateTime(item.fecha_cotizacion);
                    info.IdEquipo = item.IdEquipo;
                    info.nom_equipo = item.nom_Equipo;
                    info.porc_comision = item.porc_comision;
                    info.fecha_op = item.fecha_op;

                    //datos adicionales
                    info.sc_observacion = item.sc_observacion;
                    info.pe_direccion = item.pe_direccion;
                    info.pe_correo = item.pe_correo;

                    lst.Add(info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());

            }
        }
        #endregion

        public fa_notaCreDeb_graf_Info get_Info_graf(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                fa_notaCreDeb_graf_Info info = new fa_notaCreDeb_graf_Info();
                using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
                {
                    var contact = context.fa_notaCreDeb_graf.FirstOrDefault(minfo => minfo.IdEmpresa == IdEmpresa
                        && minfo.IdSucursal == IdSucursal
                        && minfo.IdBodega == IdBodega && minfo.IdNota == IdNota);

                    if (contact != null) //no hay datos en la base hay q grabar
                    {
                        info.IdEmpresa = contact.IdEmpresa;
                        info.IdSucursal = contact.IdSucursal;
                        info.IdBodega = contact.IdBodega;
                        info.IdNota = contact.IdNota;
                        info.num_op = contact.num_op;
                        info.fecha_op = contact.fecha_op;
                        info.num_cotizacion = contact.num_cotizacion;
                        info.fecha_cotizacion = contact.fecha_cotizacion;
                        info.IdEquipo = contact.IdEquipo;
                        info.porc_comision = contact.porc_comision;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string msg = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
    }
}
