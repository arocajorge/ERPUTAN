using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;


namespace Core.Erp.Data.General
{
   public class tbSys_Ge_Comparativo_Modulo_vs_Contas_Data
    {

        string mensaje = "";
        //Obtiene lista Tipo cata
        public List<tbSys_Ge_Comparativo_Modulo_vs_Contas_Info> Get_List_Comparativo_Modulo_vs_Contas(int IdEmpresa,DateTime Fecha_Ini,DateTime Fecha_Fin)
        {

            try
            {

                List<tbSys_Ge_Comparativo_Modulo_vs_Contas_Info> lista = new List<tbSys_Ge_Comparativo_Modulo_vs_Contas_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.spSys_Ge_Comparativo_Modulo_vs_Contas(IdEmpresa,Fecha_Ini,Fecha_Fin)
                          select C;


                foreach (var item in Doc)
                {
                    tbSys_Ge_Comparativo_Modulo_vs_Contas_Info info = new tbSys_Ge_Comparativo_Modulo_vs_Contas_Info();


                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.cod_sucu = item.cod_sucu;
                    info.IdBodega = item.IdBodega;
                    info.IdCbteVta = item.IdCbteVta;
                    info.vt_tipoDoc = item.vt_tipoDoc;
                    info.vt_serie1 = item.vt_serie1;
                    info.vt_serie2 = item.vt_serie2;
                    info.vt_NumFactura = item.vt_NumFactura;
                    info.IdCliente = item.IdCliente;
                    info.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.vt_fecha = item.vt_fecha;
                    info.vt_Observacion = item.vt_Observacion;
                    info.Debito_Vta = item.Debito_Vta;
                    info.Credito_Vta = item.Credito_Vta;
                    info.cb_Fecha = item.cb_Fecha;
                    info.cb_Observacion = item.cb_Observacion;
                    info.IdCtaCble = item.IdCtaCble;
                    info.Debito_Conta = item.Debito_Conta;
                    info.Credito_Conta = item.Credito_Conta;
                    info.pc_Cuenta = item.pc_Cuenta;
                    info.IdEmpresa_ct = item.IdEmpresa_ct;
                    info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                    info.IdCbteCble_ct = item.IdCbteCble_ct;
                    info.secuencia = item.secuencia;
                    info.TIPO = item.TIPO;
                    info.referencia = item.referencia;
                    info.Diferencia = (info.Debito_Vta + info.Credito_Vta) - (info.Debito_Conta + info.Credito_Conta);
                    info.Diferencia = Math.Round( Convert.ToDouble(info.Diferencia), 2);
                    

                    

                    lista.Add(info);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
