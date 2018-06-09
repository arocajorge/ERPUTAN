using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class vwcxc_cobro_x_documentos_x_cobrar_Data
    {
        string mensaje = "";

        public List<vwcxc_cobro_x_documentos_x_cobrar_Info> Get_List_cobro_x_documentos_x_cobrar(int IdEmpresa, int IdSucursal, decimal IdCliente, string IdEstadoCobro, DateTime FechaIni
            , DateTime FechaFin, Cl_Enumeradores.eTipo_Fecha_buscar_cobro tipo, string IdCobro_tipo)
        {
            try 
	        {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                List<vwcxc_cobro_x_documentos_x_cobrar_Info> lst = new List<vwcxc_cobro_x_documentos_x_cobrar_Info>();


                DateTime FechaIni_Edi=DateTime.Now;
                DateTime FechaFin_Edi = DateTime.Now;
                DateTime FechaIni_cob = DateTime.Now;
                DateTime FechaFin_cob = DateTime.Now;


                if (tipo == Cl_Enumeradores.eTipo_Fecha_buscar_cobro.PorFechaEdicion)
                {

                    FechaIni_Edi = FechaIni;
                    FechaFin_Edi = FechaFin;
                     FechaIni_cob= DateTime.Now.AddYears(-50) ;
                     FechaFin_cob = DateTime.Now.AddYears(50);
                }

                if (tipo == Cl_Enumeradores.eTipo_Fecha_buscar_cobro.PorFechaCobro)
                {
                    FechaIni_Edi = DateTime.Now.AddYears(-50); ;
                    FechaFin_Edi = DateTime.Now.AddYears(50);
                     FechaIni_cob = FechaIni;
                     FechaFin_cob = FechaFin;
                }

                var select = from q in context.vwcxc_cobro_x_documentos_x_cobrar
                             where    q.IdEmpresa == IdEmpresa
                                   && q.IdCliente == IdCliente
                                   && q.IdSucursal ==IdSucursal
                                   && q.IdEstadoCobro.Contains(IdEstadoCobro)
                                   && q.cr_fecha >= FechaIni_Edi && q.cr_fecha <= FechaFin_Edi
                                   && q.cr_fechaCobro >= FechaIni_cob && q.cr_fechaCobro <= FechaFin_cob
                                   && q.IdCobro_tipo.Contains(IdCobro_tipo)
                             select q;

                vwcxc_cobro_x_documentos_x_cobrar_Info Info ;
                foreach(var item in select)
                {
                    Info = new vwcxc_cobro_x_documentos_x_cobrar_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdCobro = item.IdCobro;
                    Info.cr_TotalCobro= item.cr_TotalCobro;
                    Info.cr_fecha = item.cr_fecha;
                    Info.cr_fechaCobro  = item.cr_fechaCobro;
                    Info.cr_estado  = item.cr_estado;
                    Info.IdEstadoCobro = item.IdEstadoCobro;
                    Info.cr_observacion  = item.cr_observacion;
                    Info.NumDocumento  = item.NumDocumento;
                    Info.secuencial  = item.secuencial;
                    Info.TipoDoc_Aplicado  = item.TipoDoc_aplicado;
                    Info.IdBodega_Cbte_doc_aplica  = item.IdBodega_Cbte_doc_aplica;
                    Info.IdCble_vta_nota  = item.IdCbte_vta_nota;
                    Info.Documento_Aplicado  = item.Documento_Aplicado;
                    Info.Cliente  = item.Cliente;
                    Info.IdCliente  = item.IdCliente;
                    Info.IdCobro_tipo  = item.IdCobro_tipo;
                    Info.saldo  = item.Saldo;
                    Info.Sucursal = item.Sucursal;
                    Info.IdBodega_Cbte_doc_aplica = item.IdBodega_Cbte_doc_aplica;
                    Info.Bodega = item.Bodega;
                    Info.EstadoCobro = item.EstadoCobro;
                    Info.TipoCobro = item.TipoCobro;
                    Info.SubTotal_Doc_vta = item.SubTotal_Doc_vta;
                    Info.Iva_Doc_vta = item.Iva_Doc_vta;
                    Info.Total_Doc_vta = item.Total_Doc_vta;
                    Info.Fecha_vta = item.Fecha_vta;
                    lst.Add(Info);
                }
                return lst;
	        }
	        catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
