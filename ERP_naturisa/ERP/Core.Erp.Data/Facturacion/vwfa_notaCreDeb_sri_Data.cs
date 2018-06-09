using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
   public class vwfa_notaCreDeb_sri_Data
    {
       string mensaje = "";

       public List<vwfa_notaCreDeb_sri_Info> Get_List_notaCreDeb_sri(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota, string CreDeb, ref string msg)
       {
           try
           {
               List<vwfa_notaCreDeb_sri_Info> lista = new List<vwfa_notaCreDeb_sri_Info>();
               EntitiesFacturacion OEFAC = new EntitiesFacturacion();
               var consulta = from h in OEFAC.vwfa_notaCreDeb_sri
                              where h.IdEmpresa == IdEmpresa
                              && h.IdSucursal == IdSucursal
                              && h.IdBodega == IdBodega
                              && h.IdNota == IdNota
                              && h.CreDeb == CreDeb
                              select new
                              {
                                  h.IdEmpresa,
                                  h.IdSucursal,
                                  h.IdBodega,
                                  h.IdNota,
                                  h.CreDeb,
                                  h.CodNota,
                                  h.Serie1,
                                  h.Serie2,
                                  h.IdCliente,
                                  h.no_fecha,
                                  h.Estado,
                                  h.NaturalezaNota,
                                  h.NumAutorizacion,
                                  h.RazonSocial,
                                  h.NombreComercial,
                                  h.ContribuyenteEspecial,
                                  h.ObligadoAllevarConta,
                                  h.em_ruc,
                                  h.em_direccion,
                                  h.Su_Descripcion,
                                  h.Su_Direccion,
                                  h.cl_RazonSocial,
                                  h.pe_nombreCompleto,
                                  h.IdTipoDocumento,
                                  h.pe_cedulaRuc,
                                  h.pe_correo,
                                  h.NumNota_Impresa,
                                  h.num_Factura,
                                  h.fecha_fact,
                                  h.obser_fact,
                                  h.obser_Nota,
                                  h.nc_Motivo,
                                  h.tipo_doc_aplicado
                              };
               foreach (var item in consulta)
               {
                   vwfa_notaCreDeb_sri_Info info_Sri = new vwfa_notaCreDeb_sri_Info();
                   info_Sri.IdEmpresa = item.IdEmpresa;
                   info_Sri.IdSucursal = item.IdSucursal;
                   info_Sri.IdBodega = item.IdBodega;
                   info_Sri.IdNota = item.IdNota;
                   info_Sri.CreDeb = item.CreDeb;
                   info_Sri.CodNota = item.CodNota;
                   info_Sri.Serie1 = item.Serie1;
                   info_Sri.Serie2 = item.Serie2;
                   info_Sri.IdCliente = item.IdCliente;
                   info_Sri.no_fecha = item.no_fecha;
                   info_Sri.Estado = item.Estado;
                   info_Sri.NaturalezaNota = item.NaturalezaNota;
                   info_Sri.NumAutorizacion = item.NumAutorizacion;
                   info_Sri.RazonSocial = item.RazonSocial;
                   info_Sri.NombreComercial = item.NombreComercial;
                   info_Sri.ContribuyenteEspecial = item.ContribuyenteEspecial;
                   info_Sri.ObligadoAllevarConta = item.ObligadoAllevarConta;
                   info_Sri.em_ruc = item.em_ruc;
                   info_Sri.em_direccion = item.em_direccion;
                   info_Sri.Su_Descripcion = item.Su_Descripcion;
                   info_Sri.Su_Direccion = item.Su_Direccion;
                   info_Sri.cl_RazonSocial = item.cl_RazonSocial;
                   info_Sri.pe_nombreCompleto = item.pe_nombreCompleto;
                   info_Sri.IdTipoDocumento = item.IdTipoDocumento;
                   info_Sri.pe_cedulaRuc = item.pe_cedulaRuc;
                   info_Sri.pe_correo = item.pe_correo;
                   info_Sri.NumNota_Impresa = item.NumNota_Impresa;
                   info_Sri.NumDocModificado = item.num_Factura;
                   info_Sri.fechaEmisionDocSustento = item.fecha_fact;
                   info_Sri.observacion_factura = item.obser_fact;
                   info_Sri.observacion_Nota = item.obser_Nota; 
                   info_Sri.nc_Motivo = item.nc_Motivo;
                   info_Sri.tipo_doc_aplicado = item.tipo_doc_aplicado;
                   
                   lista.Add(info_Sri);
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
    }
}
