using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt002_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt002_Info> get_ImpresionAnticipo(int IdEmpresa, int IdSucursal, decimal IdAnticipo)
        {
            try
            {
                List<XCXC_Rpt002_Info> lstRpt = new List<XCXC_Rpt002_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var Select = from q in listado.vwCXC_Rpt002
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal == IdSucursal && q.IdAnticipo == IdAnticipo
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in Select)
                    {
                        XCXC_Rpt002_Info infoRpt = new XCXC_Rpt002_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdAnticipo = item.IdAnticipo;
                        infoRpt.Secuencia = item.Secuencia;
                        infoRpt.IdCobro_tipo = item.IdCobro_tipo;
                        infoRpt.IdEmpresa_Cobro = Convert.ToInt32(item.IdEmpresa_Cobro);
                        infoRpt.IdSucursal_cobro = Convert.ToInt32(item.IdSucursal_cobro);
                        infoRpt.IdCobro_cobro =Convert.ToDecimal(item.IdCobro_cobro);
                        infoRpt.cr_fechaCobro = item.cr_fechaCobro;
                        infoRpt.cr_observacion = item.cr_observacion;
                        infoRpt.cr_Banco = item.cr_Banco;
                        infoRpt.cr_cuenta = item.cr_cuenta;
                        infoRpt.cr_NumDocumento = item.cr_NumDocumento;
                        infoRpt.cr_Tarjeta = item.cr_Tarjeta;
                        infoRpt.cr_propietarioCta = item.cr_propietarioCta;
                        infoRpt.cr_TotalCobro = item.cr_TotalCobro;
                        infoRpt.Logo = Cbt.em_logo_Image;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;
                        infoRpt.pe_direccion = item.pe_direccion;

                        lstRpt.Add(infoRpt);
                    }

                }

                return lstRpt;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);    
                return new List<XCXC_Rpt002_Info>();
            }
        }

    }
}
