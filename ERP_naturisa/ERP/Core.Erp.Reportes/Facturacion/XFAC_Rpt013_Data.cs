using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
   public  class XFAC_Rpt013_Data
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="IdEmpresa"></param>
        /// <param name="IdSucursal">  si IdSucursal=0 extrae todos las susucursales</param>
       /// <param name="FechaIni"></param>
       /// <param name="FechaFin"></param>
       /// <returns></returns>
       public List<XFAC_Rpt013_Info> Get_List_Data_Reporte(int IdEmpresa,decimal IdCliente, DateTime FechaIni,DateTime FechaFin,ref string MensajeError)
       {
           List<XFAC_Rpt013_Info> lista = new List<XFAC_Rpt013_Info>();
           try
           {
              

               using (EntitiesFacturacion_Reportes listado = new EntitiesFacturacion_Reportes())
               {

                   FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                   FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                   var select = listado.spFAC_Rpt013(IdEmpresa,IdCliente,FechaIni,FechaFin);

                   double ? Saldo = 0;

                   foreach (var item in select)
                   {
                       XFAC_Rpt013_Info infoRpt = new XFAC_Rpt013_Info();

                       infoRpt.IdEmpresa = item.IdEmpresa;
                       infoRpt.nom_empresa = item.nom_empresa;
                       infoRpt.IdSucursal = item.IdSucursal;
                       infoRpt.nom_sucursal = item.nom_sucursal;
                       infoRpt.IdCliente = item.IdCliente;
                       infoRpt.nom_cliente = item.nom_cliente;
                       infoRpt.Cedula_Ruc = item.Cedula_Ruc;
                       infoRpt.fecha = item.fecha;
                       infoRpt.Documento = item.Documento;
                       infoRpt.Debito = item.Debito;
                       infoRpt.Credito = item.Credito;
                       
                       infoRpt.SaldoInicial = item.SaldoInicial;
                       infoRpt.SaldoFinal = item.SaldoFinal;
                       

                       Saldo = Saldo + ((item.Debito > 0) ? item.Debito : item.Credito * -1);
                       infoRpt.Saldo = Saldo;


                       infoRpt.vt_Observacion = item.vt_Observacion;



                       lista.Add(infoRpt);
                   }

               }



               return lista;
           }
           catch (Exception ex)
           {
               MensajeError = ex.InnerException.ToString();
               return lista;
           }
       
       }
    }
}
