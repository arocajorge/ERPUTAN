using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt012_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt012_Info> get_DetalleDiasxVencer(int IdEmpresa, decimal IdCliente, DateTime FechaCorte)
        {
            try
            {
                List<XCXC_Rpt012_Info> lstRpt = new List<XCXC_Rpt012_Info>();
                                
                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt012(IdEmpresa, IdCliente, FechaCorte)
                                 where q.Saldo != 0
                                 select q;

                    
                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt012_Info infoRpt = new XCXC_Rpt012_Info();
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.DiasVencidos = item.DiasVencidos;
                        infoRpt.Valor_Original = item.Valor_Original;
                        infoRpt.TotalCobrado = item.TotalCobrado;
                        infoRpt.Saldo = item.Saldo;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.vt_fecha = item.vt_fecha;
                        infoRpt.vt_fecha_venc = item.vt_fech_venc;
                        infoRpt.numDocumento = item.numDocumento;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.vt_Observacion = item.vt_Observacion;
                        infoRpt.Nom_Empresa = Cbt.em_nombre;
                        infoRpt.Direccion = Cbt.em_direccion;
                        infoRpt.Fecha_dia = DateTime.Now;
                        infoRpt.em_Telefono = Cbt.em_telefonos;
                        infoRpt.em_fax = Cbt.em_fax;
                        infoRpt.Valor_x_Vencer_f = item.Valor_x_Vencer_f;
                        infoRpt.Vencer_30_Dias = item.Vencer_30_Dias;
                        infoRpt.Vencer_60_Dias = item.Vencer_60_Dias;
                        infoRpt.Vencer_90_Dias = item.Vencer_90_Dias;
                        infoRpt.Mayor_a_90Dias = item.Mayor_a_90Dias;
                        lstRpt.Add(infoRpt);
                    }
                }
                return lstRpt.OrderBy(q=>q.vt_fecha).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt012_Info>();
            }
        }
    }
}
