using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
    public static class ChequeComprobante
    {
       public static string XML = "<?xml version=\"1.0\" encoding=\"utf-8\"?> "+
                        "<ArrayOfXBAN_Rpt005_Info xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> "+
                        "  <XBAN_Rpt005_Info> "+
                        "    <IdEmpresa>1</IdEmpresa> "+
                        "    <IdCbteCble>1</IdCbteCble> "+
                        "    <IdTipocbte>2</IdTipocbte> "+
                        "    <Cod_Cbtecble>CHE 1</Cod_Cbtecble> "+
                        "    <cb_Observacion>prueba conciliacion 1</cb_Observacion> "+
                        "    <cb_secuencia>199</cb_secuencia> "+
                        "    <cb_Valor>10</cb_Valor> "+
                        "    <cb_Cheque>0000004</cb_Cheque> "+
                        "    <cb_ChequeImpreso>S</cb_ChequeImpreso> "+
                        "    <cb_FechaCheque>2015-03-20T00:00:00</cb_FechaCheque> "+
                        "    <Fecha_Transac>2015-03-20T15:05:16.52</Fecha_Transac> "+
                        "    <Estado>A</Estado> "+
                        "    <cb_giradoA>AMBATRANSS444</cb_giradoA> "+
                        "    <cb_ciudadChq>GUAYAQUIL</cb_ciudadChq> "+
                        "    <CodTipoCbteBan>CHEQ</CodTipoCbteBan> "+
                        "    <cb_Fecha>2015-03-20T00:00:00</cb_Fecha> "+
                        "    <con_Fecha>2015-03-20T00:00:00</con_Fecha> "+
                        "    <con_Valor>10</con_Valor> "+
                        "    <con_Observacion> Girado a AMBATRANSS444 del Banco BOLIVARIANO #9003224</con_Observacion> "+
                        "    <con_IdCbteCble>1</con_IdCbteCble> "+
                        "    <IdCtaCble>221301</IdCtaCble> "+
                        "    <pc_Cuenta>PROVEEDORES LOCALES</pc_Cuenta> "+
                        "  </XBAN_Rpt005_Info> "+
                        "  <XBAN_Rpt005_Info> "+
                        "    <IdEmpresa>1</IdEmpresa> "+
                        "    <IdCbteCble>1</IdCbteCble> "+
                        "    <IdTipocbte>2</IdTipocbte> "+
                        "    <Cod_Cbtecble>CHE 1</Cod_Cbtecble> "+
                        "    <cb_Observacion>prueba conciliacion 1</cb_Observacion> "+
                        "    <cb_secuencia>199</cb_secuencia> "+
                        "    <cb_Valor>10</cb_Valor> "+
                        "    <cb_Cheque>0000004</cb_Cheque> "+
                        "    <cb_ChequeImpreso>S</cb_ChequeImpreso> "+
                        "    <cb_FechaCheque>2015-03-20T00:00:00</cb_FechaCheque> "+
                        "    <Fecha_Transac>2015-03-20T15:05:16.52</Fecha_Transac> "+
                        "    <Estado>A</Estado> "+
                        "    <cb_giradoA>AMBATRANSS444</cb_giradoA> "+
                        "    <cb_ciudadChq>GUAYAQUIL</cb_ciudadChq> "+
                        "    <CodTipoCbteBan>CHEQ</CodTipoCbteBan> "+
                        "    <cb_Fecha>2015-03-20T00:00:00</cb_Fecha> "+
                        "    <con_Fecha>2015-03-20T00:00:00</con_Fecha> "+
                        "    <con_Valor>10</con_Valor> "+
                        "    <con_Observacion> Girado a AMBATRANSS444 del Banco BOLIVARIANO #9003224</con_Observacion> "+
                        "    <con_IdCbteCble>1</con_IdCbteCble> "+
                        "    <IdCtaCble>11010302</IdCtaCble> "+
                        "    <pc_Cuenta>BANCO BOLIVARIANO CTA CTE 9270-4</pc_Cuenta> "+
                        "  </XBAN_Rpt005_Info> "+
                        "</ArrayOfXBAN_Rpt005_Info> ";
    }
}
