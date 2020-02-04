using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxCobrar
{
    public class XCXC_NATU_Rpt001_Data
    {
        public List<XCXC_NATU_Rpt001_Info> Get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                List<XCXC_NATU_Rpt001_Info> Lista = new List<XCXC_NATU_Rpt001_Info>();

                using (EntitiesCuentasxCobrar_Natu_rpt Context = new EntitiesCuentasxCobrar_Natu_rpt())
                {
                    var lst = from q in Context.spCXC_NATU_Rpt001(IdEmpresa, Fecha_ini, Fecha_fin)
                              select q;

                    foreach (var item in lst)
                    {
                        XCXC_NATU_Rpt001_Info info = new XCXC_NATU_Rpt001_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbteVta = item.IdCbteVta;
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.IdTipoDocumento = item.IdTipoDocumento;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.pe_Naturaleza = item.pe_Naturaleza;
                        info.cod_parroquia = item.cod_parroquia;
                        info.nom_parroquia = item.nom_parroquia;
                        info.Cod_Ciudad = item.Cod_Ciudad;
                        info.Descripcion_Ciudad = item.Descripcion_Ciudad;
                        info.Cod_Provincia = item.Cod_Provincia;
                        info.Descripcion_Prov = item.Descripcion_Prov;
                        info.pe_sexo = item.pe_sexo;
                        info.nom_sexo = item.nom_sexo;
                        info.IdEstadoCivil = item.IdEstadoCivil;
                        info.nom_EstadoCivil = item.nom_EstadoCivil;
                        info.vt_fecha = item.vt_fecha;
                        info.vt_fecha_vcto = item.vt_fecha_vcto;
                        info.vt_fecha_exigible = item.vt_fecha_exigible;
                        info.vt_plazo = item.vt_plazo;
                        info.vt_tipo_venta = item.vt_tipo_venta;
                        info.nom_TerminoPago = item.nom_TerminoPago;
                        info.Num_Coutas = item.Num_Coutas;
                        info.num_factura = item.num_factura;
                        info.Valor_operacion = item.Valor_operacion;
                        info.Saldo_operacion = item.Saldo_operacion;
                        info.Dias_morosidad = item.Dias_morosidad;
                        info.Monto_morosidad = item.Monto_morosidad;
                        info.Monto_interes_mora = item.Monto_interes_mora;
                        info.x_vencer_0_30 = item.x_vencer_0_30;
                        info.x_vencer_31_90 = item.x_vencer_31_90;
                        info.x_vencer_91_180 = item.x_vencer_91_180;
                        info.x_vencer_181_360 = item.x_vencer_181_360;
                        info.x_vencer_mayor_360 = item.x_vencer_mayor_360;
                        info.vencido_0_30 = item.vencido_0_30;
                        info.vencido_31_90 = item.vencido_31_90;
                        info.vencido_91_180 = item.vencido_91_180;
                        info.vencido_181_360 = item.vencido_181_360;
                        info.vencido_mayor_360 = item.vencido_mayor_360;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
