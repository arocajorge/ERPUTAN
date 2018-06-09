using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt023_Data
    {
        string mensaje = "";
        tb_Empresa_Data empresa_data = new tb_Empresa_Data();
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();
        public List<XROL_Rpt023_Info> Get_List(int idEmpresa, int idempleado, int IdNovedad)
       {
           try
           {
               List<XROL_Rpt023_Info> Listado = new List<XROL_Rpt023_Info>();
               info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
               using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
               {
                   var select = from a in enti.vwROL_Rpt023
                                where a.IdEmpresa == idEmpresa
                                && a.IdEmpleado == idempleado                               
                                && a.IdNovedad ==IdNovedad
                                orderby a.pe_apellido ascending
                                select a;

                   foreach (var item in select)
                   {
                       XROL_Rpt023_Info info = new XROL_Rpt023_Info();
                       
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.pe_apellido = item.pe_apellido + " " + item.pe_nombre;
                       info.IdNovedad = item.IdNovedad;
                       info.Descripcion = item.Descripcion;
                       info.FechaPago = item.FechaPago;;
                       info.Valor = item.Valor;
                       info.Fecha_Transac = item.Fecha_Transac;
                       info.em_logo = info_empresa.em_logo;
                       info.NombreComercial = info_empresa.NombreComercial;
                       info.RazonSocial = info_empresa.RazonSocial;
                       info.ca_descripcion = item.Descripcion;
                       info.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                       info.Observacion = item.Observacion;
                       info.Descripcion = item.Descripcion;
                       info.Observacion = item.Observacion;
                       info.rub_Acuerdo_Descuento = item.rub_Acuerdo_Descuento;
                       info.Anio = item.FechaPago.Year;
                       info.mes = Convert.ToString(item.FechaPago.Month).PadLeft(2, '0');
                       info.ru_descripcion = item.ru_descripcion;
                       if (item.rub_Acuerdo_Descuento != null)
                       {
                           info.rub_Acuerdo_Descuento = info.rub_Acuerdo_Descuento.Replace("CCCCC", item.pe_apellido + " " + item.pe_nombre);
                           info.rub_Acuerdo_Descuento = info.rub_Acuerdo_Descuento.Replace("9999999999", info.pe_cedulaRuc);
                           info.rub_Acuerdo_Descuento = info.rub_Acuerdo_Descuento.Replace("00/00/0000", info.FechaPago.ToString().Substring(0, 10));
                           info.rub_Acuerdo_Descuento = info.rub_Acuerdo_Descuento.Replace("0.00", info.Valor.ToString());

                           

                            
                       }
                       Listado.Add(info);
                   }

                   return Listado;
               }



           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               return new List<XROL_Rpt023_Info>();
           }
       }


    }
}
