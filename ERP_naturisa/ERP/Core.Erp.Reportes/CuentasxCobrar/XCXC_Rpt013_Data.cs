using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.CuentasxCobrar
{
   public class XCXC_Rpt013_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public enum eFiltro_Fecha_Busqueda
        { 
            por_fecha_cobro,
            por_fecha_documento
        }



        public List<XCXC_Rpt013_Info> Get_Data_Reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,bool Mostrar_fact_sin_rt,eFiltro_Fecha_Busqueda Fecha_busqueda,decimal IdCliente)
        {
            try
            {
                List<XCXC_Rpt013_Info> lstRpt = new List<XCXC_Rpt013_Info>();


                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                DateTime FechaIni_Cobro = FechaIni;
                DateTime FechaFin_Cobro = FechaFin;
                DateTime FechaIni_Documento = FechaIni;
                DateTime FechaFin_Documento = FechaFin;

                decimal IdClienteIni = IdCliente;
                decimal IdClienteFin = IdCliente;

                if (IdCliente == 0)
                {
                    IdClienteIni = 1;
                    IdClienteFin = 999999999;
                }

                if (Fecha_busqueda == eFiltro_Fecha_Busqueda.por_fecha_cobro)
                {
                    FechaIni_Documento = DateTime.Now.AddYears(-20);
                    FechaFin_Documento = DateTime.Now.AddYears(20);
                
                }

                if (Fecha_busqueda == eFiltro_Fecha_Busqueda.por_fecha_documento)
                {
                     FechaIni_Cobro =  DateTime.Now.AddYears(-20);
                     FechaFin_Cobro = DateTime.Now.AddYears(20);
                }



                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.vwCXC_Rpt013
                                 where q.IdEmpresa == IdEmpresa
                                 && q.Fecha_cobro >= FechaIni_Cobro && q.Fecha_cobro <= FechaFin_Cobro
                                 && q.Fecha_Retencion >= FechaIni_Documento && q.Fecha_Retencion <= FechaFin_Documento
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 select q;

                    if (!Mostrar_fact_sin_rt) select = select.Where(q => q.Tipo_Retencion != "SIN_RT");
                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt013_Info infoRpt = new XCXC_Rpt013_Info();
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.nom_sucursal = item.nom_sucursal;
                        infoRpt.IdCobro = item.IdCobro;
                        infoRpt.Fecha_cobro = item.Fecha_cobro;
                        infoRpt.Fecha_Retencion = item.Fecha_Retencion;
                        infoRpt.Num_Retencion = item.Num_Retencion;
                        infoRpt.IdCobro_tipo = item.IdCobro_tipo;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.nom_cliente = item.nom_cliente;
                        infoRpt.ruc_ced = item.ruc_ced;
                        infoRpt.PorcentajeRet = item.PorcentajeRet;
                        infoRpt.Base_RIva = item.Base_RIva;
                        infoRpt.Base_RFte = item.Base_RFte;
                        infoRpt.Valor_Ret = item.Valor_Ret;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.num_factura = item.num_factura;
                        infoRpt.Fecha_Fact = item.Fecha_Fact;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.Tipo_Retencion = item.Tipo_Retencion;
                        infoRpt.nomTipo_Retencion = item.nomTipo_Retencion;
                        infoRpt.nomTipoCobro = item.nomTipoCobro;
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
                return new List<XCXC_Rpt013_Info>();
            }
        }
    }
}
