using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Info.Facturacion;
namespace Core.Erp.Data.Facturacion_Grafinpren
{
   public class fa_guia_remision_graf_Data
    {
       string msg = string.Empty;

       #region " Grabar "
       public Boolean GrabarDB(fa_guia_remision_graf_Info info, ref decimal id, ref string msg)
       {
           try
           {
               using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
               {
                   var address = new fa_guia_remision_graf();

                   address.IdEmpresa = info.IdEmpresa;
                   address.IdSucursal = info.IdSucursal;
                   address.IdBodega = info.IdBodega;
                   address.IdGuiaRemision = (info.IdGuiaRemision == 0) ? id : info.IdGuiaRemision;
                   address.fecha_Cotizacion = info.fecha_Cotizacion;
                   address.Num_Cotizacion = info.Num_Cotizacion;
                   address.Num_OP = info.Num_OP;
                   address.IdEquipo = info.IdEquipo;
                   context.fa_guia_remision_graf.Add(address);
                   context.SaveChanges();                 
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

       #region " Modificar "
       public Boolean ModificarDB(fa_guia_remision_graf_Info info, ref string msg)
       {
           try
           {
               using (EntitiesFacturacion_Grafinpren context = new EntitiesFacturacion_Grafinpren())
               {
                   var contact = context.fa_guia_remision_graf.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdGuiaRemision == info.IdGuiaRemision);

                   if (contact != null)
                   {
                       contact.fecha_Cotizacion = info.fecha_Cotizacion;
                       contact.Num_Cotizacion = info.Num_Cotizacion;
                       contact.Num_OP = info.Num_OP;
                       contact.IdEquipo = info.IdEquipo;
                       context.SaveChanges();
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

       #region "Lista Cabecera Guia Remision"
       public List<Core.Erp.Info.Facturacion.fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, DateTime FechaIni, DateTime FechaFin)
       {
           try
           {
               List<Core.Erp.Info.Facturacion.fa_guia_remision_Info> lst = new List<Core.Erp.Info.Facturacion.fa_guia_remision_Info>();
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
               var query = from v in Base.vwfa_Guia_Remision_graf
                           where v.IdEmpresa == idEmpresa
                                     && v.IdBodega >= idBodegaIni && v.IdBodega <= idBodegaFin
                                     && v.IdSucursal >= idSucursalIni && v.IdSucursal <= idSucursalFin
                                     && v.gi_fecha >= FechaIni && v.gi_fecha <= FechaFin
                           select v;
               foreach (var item in query)
               { 
                  Core.Erp.Info.Facturacion.fa_guia_remision_Info info = new Core.Erp.Info.Facturacion.fa_guia_remision_Info();
                   info.Info_Guia_Remision_x_Grafinpren.Num_Cotizacion = Convert.ToDecimal(item.Num_Cotizacion);
                   info.Info_Guia_Remision_x_Grafinpren.Num_OP = item.Num_OP;
                   info.Info_Guia_Remision_x_Grafinpren.fecha_Cotizacion = Convert.ToDateTime(item.fecha_Cotizacion);
                   info.Info_Guia_Remision_x_Grafinpren.IdEquipo = item.IdEquipo;
                   info.Info_Guia_Remision_x_Grafinpren.nom_equipo = item.nom_Equipo;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdBodega = item.IdBodega;
                   info.Vendedor = item.Ve_Vendedor;
                   info.Cliente = item.pe_razonSocial;
                   info.IdGuiaRemision = item.IdGuiaRemision;
                   info.gi_fecha = item.gi_fecha;
                   info.gi_FecIniTraslado = item.gi_FechaIniTraslado;
                   info.gi_FecFinTraslado = item.gi_FechaFinTraslado;
                   info.gi_fech_venc = item.gi_fech_venc;
                   info.gi_TotalQuintales = item.gi_TotalQuintales;
                   info.gi_TotalKilos = item.gi_TotalKilos;
                   info.IdTransportista = item.IdTransportista;
                   info.IdVendedor = item.IdVendedor;
                   info.IdCliente = item.IdCliente;
                   info.Estado = item.Estado;
                   info.CodDocumentoTipo = item.CodDocumentoTipo;
                   info.Serie1 = item.Serie1;
                   info.Serie2 = item.Serie2;
                   info.NumGuia_Preimpresa = item.NumGuia_Preimpresa;
                   info.ruta = item.ruta;
                   info.placa = item.placa;
                   info.Direccion_Origen = item.Direccion_Origen;
                   info.Direccion_Destino = item.Direccion_Destino;
                   info.em_nombre = item.em_nombre;
                   info.RazonSocial = item.RazonSocial;
                   info.NombreComercial = item.NombreComercial;
                   info.ContribuyenteEspecial = item.ContribuyenteEspecial;
                   info.ObligadoAllevarConta = item.ObligadoAllevarConta;
                   info.em_ruc = item.em_ruc;
                   info.Cedula = item.Cedula;
                   info.nom_Transportista = item.nom_Transportista;
                   info.gi_Observacion = item.gi_Observacion;

                   info.IdTipoDocumento = item.IdTipoDocumento;
                   info.pe_cedulaRuc = item.pe_cedulaRuc;
                   info.pe_direccion = item.pe_direccion;
                   info.pe_telefonoCasa = item.pe_telefonoCasa;
                   info.pe_telefonoOfic = item.pe_telefonoOfic;
                   info.pe_celular = item.pe_celular;
                   info.pe_correo = item.pe_correo;
                   info.pe_Naturaleza = item.pe_Naturaleza;
                   info.pe_nombreCompleto = item.pe_nombreCompleto;
                   info.pe_apellido = item.pe_apellido;
                   info.pe_nombre = item.pe_nombre;
                   info.IdTipoPersona = item.IdTipoPersona;
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


       #region "Get Info guia remision"
       public fa_guia_remision_Info Gat_info_Guia(int idEmpresa, int idSucursalIni, int IdGuia)
       {
           try
           {
               fa_guia_remision_Info info = new fa_guia_remision_Info();
              
               EntitiesFacturacion_Grafinpren Base = new EntitiesFacturacion_Grafinpren();
               var query = from v in Base.vwfa_Guia_Remision_graf
                           where v.IdEmpresa == idEmpresa
                                     && v.IdSucursal >= idSucursalIni
                                     && v.IdGuiaRemision == IdGuia
                                   
                           select v;
               foreach (var item in query)
               {
                   info.Info_Guia_Remision_x_Grafinpren.Num_Cotizacion = Convert.ToDecimal(item.Num_Cotizacion);
                   info.Info_Guia_Remision_x_Grafinpren.Num_OP = item.Num_OP;
                   info.Info_Guia_Remision_x_Grafinpren.fecha_Cotizacion = Convert.ToDateTime(item.fecha_Cotizacion);
                   info.Info_Guia_Remision_x_Grafinpren.IdEquipo = item.IdEquipo;
                   info.Info_Guia_Remision_x_Grafinpren.nom_equipo = item.nom_Equipo;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdBodega = item.IdBodega;
                   info.Vendedor = item.Ve_Vendedor;
                   info.Cliente = item.pe_razonSocial;
                   info.IdGuiaRemision = item.IdGuiaRemision;
                   info.gi_fecha = item.gi_fecha;
                   info.gi_FecIniTraslado = item.gi_FechaIniTraslado;
                   info.gi_FecFinTraslado = item.gi_FechaFinTraslado;
                   info.gi_fech_venc = item.gi_fech_venc;
                   info.gi_TotalQuintales = item.gi_TotalQuintales;
                   info.gi_TotalKilos = item.gi_TotalKilos;
                   info.IdTransportista = item.IdTransportista;
                   info.IdVendedor = item.IdVendedor;
                   info.IdCliente = item.IdCliente;
                   info.Estado = item.Estado;
                   info.CodDocumentoTipo = item.CodDocumentoTipo;
                   info.Serie1 = item.Serie1;
                   info.Serie2 = item.Serie2;
                   info.NumGuia_Preimpresa = item.NumGuia_Preimpresa;
                   info.ruta = item.ruta;
                   info.placa = item.placa;
                   info.Direccion_Origen = item.Direccion_Origen;
                   info.Direccion_Destino = item.Direccion_Destino;
                   info.em_nombre = item.em_nombre;
                   info.RazonSocial = item.RazonSocial;
                   info.NombreComercial = item.NombreComercial;
                   info.ContribuyenteEspecial = item.ContribuyenteEspecial;
                   info.ObligadoAllevarConta = item.ObligadoAllevarConta;
                   info.em_ruc = item.em_ruc;
                   info.Cedula = item.Cedula;
                   info.nom_Transportista = item.nom_Transportista;
                   info.pe_correo = item.pe_correo;
                   info.IdTipoDocumento = item.IdTipoDocumento;
                   info.pe_nombreCompleto = item.pe_nombreCompleto;
                   info.pe_cedulaRuc = item.pe_cedulaRuc;
                   info.gi_Observacion = item.gi_Observacion;
                   info.pe_direccion = item.Direccion_Destino;
                   info.gi_Observacion = item.gi_Observacion;
               }

               return info;
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
   }
}
