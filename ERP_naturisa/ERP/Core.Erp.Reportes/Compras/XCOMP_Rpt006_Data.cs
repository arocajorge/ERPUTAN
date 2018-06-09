using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt006_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCOMP_Rpt006_Info> get_Presupuesto_Solicitud(List<XCOMP_Rpt006_Info> lstIdPresupuestoCompra)
        {
            try
            {
                List<XCOMP_Rpt006_Info> lstInfo = new List<XCOMP_Rpt006_Info>();
                using (EntitiesCompra_reporte_Ge listado = new EntitiesCompra_reporte_Ge())
                {
                    var select = from q in lstIdPresupuestoCompra
                                 join c in listado.vwCOMP_Rpt006 on new { q.IdEmpresa, q.IdSucursal, q.IdSolicitudCompra, q.Secuencia_SC }
                                 equals new { c.IdEmpresa, c.IdSucursal, c.IdSolicitudCompra, c.Secuencia_SC }
                                 select c;

                    Cbt = empresaData.Get_Info_Empresa(lstIdPresupuestoCompra.First().IdEmpresa);

                    foreach (var item in select)
                    {
                        XCOMP_Rpt006_Info Info = new XCOMP_Rpt006_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdSolicitudCompra = item.IdSolicitudCompra;
                        Info.Secuencia_SC = item.Secuencia_SC;
                        Info.IdProducto_SC = item.IdProducto_SC;
                        Info.Su_Descripcion = item.Su_Descripcion;
                        Info.NomProducto_SC = item.NomProducto_SC;
                        Info.Cantidad_aprobada = item.Cantidad_aprobada;
                        Info.IdUsuarioAprueba = item.IdUsuarioAprueba;
                        Info.FechaHoraAprobacion = item.FechaHoraAprobacion;
                        Info.observacion = item.observacion;
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.Descripcion = item.Descripcion;
                        Info.do_precioCompra = item.do_precioCompra;
                        Info.do_porc_des = item.do_porc_des;
                        Info.do_subtotal = item.do_subtotal;
                        Info.do_iva = item.do_iva;
                        Info.do_total = item.do_total;
                        Info.do_ManejaIva = item.do_ManejaIva;
                        Info.IdPunto_cargo = item.IdPunto_cargo;
                        Info.IdDepartamento = item.IdDepartamento;
                        Info.de_descripcion = item.de_descripcion;
                        Info.IdProveedor = item.IdProveedor;
                        Info.pr_nombre = item.pr_nombre;
                        Info.IdPersona = item.IdPersona;
                        Info.nomSolicitante = item.nomSolicitante;
                        Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Info.IdEstadoPreAprobacion = item.IdEstadoPreAprobacion;
                        Info.DescrpcionEstadoAprobacion = item.DescrpcionEstadoAprobacion;
                        Info.DescrpcionEstadoPreAprobacion = item.DescrpcionEstadoPreAprobacion;
                        Info.codPunto_cargo = item.codPunto_cargo;
                        Info.nom_punto_cargo = item.nom_punto_cargo;
                        Info.NomEmpresa = Cbt.em_nombre;
                        Info.Logo = Cbt.em_logo_Image;
                        lstInfo.Add(Info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt006_Data) };
            }
        }

    }
}
