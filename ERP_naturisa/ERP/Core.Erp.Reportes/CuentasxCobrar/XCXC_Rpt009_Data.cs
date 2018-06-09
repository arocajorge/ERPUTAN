using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt009_Data
    {
        string mensaje = "";
        tb_Empresa_Data empresaData = new tb_Empresa_Data();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        
        public List<XCXC_Rpt009_Info> get_DetalleCarteraVencida(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte, int IdTipocliente)
        {
            try
            {
                List<XCXC_Rpt009_Info> lstRpt = new List<XCXC_Rpt009_Info>();

                int IdTipocliente_Ini = 0;
                int IdTipocliente_Fin = 0;

                if (IdTipocliente == 0)
                {
                    IdTipocliente_Ini = 1;
                    IdTipocliente_Fin = 999999;
                }
                else
                {
                    IdTipocliente_Ini = IdTipocliente;
                    IdTipocliente_Fin = IdTipocliente;
                }

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt009(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte)
                                 where q.Idtipo_cliente >= IdTipocliente_Ini
                                 && q.Idtipo_cliente <= IdTipocliente_Fin
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt009_Info infoRpt = new XCXC_Rpt009_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.vt_serie1 = item.vt_serie1;
                        infoRpt.vt_serie2 = item.vt_serie2;
                        infoRpt.vt_NumFactura = item.vt_NumFactura.ToString().PadLeft(9, '0');
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.Valor_Original = item.Valor_Original;
                        infoRpt.Total_Pagado = item.Total_Pagado;
                        infoRpt.Valor_x_Vencer = item.Valor_x_Vencer;
                        infoRpt.Vencer_30_Dias = item.Vencer_30_Dias;
                        infoRpt.Vencer_60_Dias = item.Vencer_60_Dias;
                        infoRpt.Vencer_90_Dias = item.Vencer_90_Dias;
                        infoRpt.Mayor_a_90Dias = item.Mayor_a_90Dias;
                        infoRpt.vt_fech_venc = item.vt_fech_venc;
                        infoRpt.vt_fecha = item.vt_fecha;
                        infoRpt.RazonSocial = Cbt.RazonSocial;
                        infoRpt.em_logo = Cbt.em_logo;
                        infoRpt.Total = (double)item.Total;
                        infoRpt.Telefono = item.pe_telefonoOfic;
                        infoRpt.num_op = item.num_op;
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
                return new List<XCXC_Rpt009_Info>();
            }
        }

        public List<XCXC_Rpt009_Info> get_DetalleCarteraVencida(int IdEmpresa, int IdCliente, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte, int IdTipocliente)
        {
            try
            {
                decimal IdClienteIni, IdClienteFin;

                int IdTipoClienteIni, IdTipoClienteFin;


                IdClienteIni = (IdCliente == 0) ? 1 : IdCliente;
                IdClienteFin = (IdCliente == 0) ? 999999999 : IdCliente;

                IdTipoClienteIni = (IdTipocliente == 0) ? 1 : IdTipocliente;
                IdTipoClienteFin = (IdTipocliente == 0) ? 999999999 : IdTipocliente;
                
                FechaCorte = Convert.ToDateTime(FechaCorte.ToShortDateString());

                List<XCXC_Rpt009_Info> lstRpt = new List<XCXC_Rpt009_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt009(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte)
                                 where 
                                 q.IdCliente >= IdClienteIni
                                 && q.IdCliente <= IdClienteFin
                                 && q.Idtipo_cliente >= IdTipoClienteIni
                                 && q.Idtipo_cliente <= IdTipoClienteFin
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt009_Info infoRpt = new XCXC_Rpt009_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.vt_serie1 = item.vt_serie1;
                        infoRpt.vt_serie2 = item.vt_serie2;
                        infoRpt.vt_NumFactura = item.vt_NumFactura.ToString().PadLeft(9, '0');
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.Valor_Original = item.Valor_Original;
                        infoRpt.Total_Pagado = item.Total_Pagado;
                        infoRpt.Valor_x_Vencer = item.Valor_x_Vencer;
                        infoRpt.Vencer_30_Dias = item.Vencer_30_Dias;
                        infoRpt.Vencer_60_Dias = item.Vencer_60_Dias;
                        infoRpt.Vencer_90_Dias = item.Vencer_90_Dias;
                        infoRpt.Mayor_a_90Dias = item.Mayor_a_90Dias;
                        infoRpt.vt_fech_venc = item.vt_fech_venc;
                        infoRpt.vt_fecha = item.vt_fecha;
                        infoRpt.RazonSocial = Cbt.RazonSocial;
                        infoRpt.em_logo = Cbt.em_logo;
                        infoRpt.Total = (double)item.Total;
                        infoRpt.Telefono = item.pe_telefonoOfic;
                        infoRpt.num_op = item.num_op;
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
                return new List<XCXC_Rpt009_Info>();
            }
        }
    }
}
