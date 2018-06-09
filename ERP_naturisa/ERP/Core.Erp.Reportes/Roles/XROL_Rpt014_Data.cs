using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt014_Data
  {
      string mensaje = "";
      tb_Empresa_Data empresa_data = new tb_Empresa_Data();
      tb_Empresa_Info info_empresa = new tb_Empresa_Info();
      public List<XROL_Rpt014_Info> Get_list_Rubros_X_Empleados(int idEmpresa, int idNomina, int idDepartamento)
      {
          try
          {
           List<XROL_Rpt014_Info> Listado = new List<XROL_Rpt014_Info>();
           info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
          using (EntitiesRolesRptGeneral enti= new EntitiesRolesRptGeneral())
          {
              var select = from a in enti.vwROL_Rpt014
                           where a.IdEmpresa == idEmpresa
                           && a.IdTipoNomina == idNomina
                           && a.IdDepartamento == idDepartamento
                           select a;

              foreach (var item in select)
              {
                  XROL_Rpt014_Info info = new XROL_Rpt014_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdEmpleado = item.IdEmpleado;
                  info.IdTipoNomina = item.IdTipoNomina;
                  info.IdDepartamento = item.IdDepartamento;
                  info.Nombres = item.pe_apellido + " " + item.pe_nombre;
                  info.pe_cedulaRuc = item.pe_cedulaRuc;
                  info.de_descripcion = item.de_descripcion;
                  if(item.Decimo_Cuarto!=null)
                  {
                    info. Decimo_Cuarto ="SI";
                  }
                  else
                  {
                      info. Decimo_Cuarto ="NO";
                  }

                   if(item.Fondos_Reservas!=null)
                  {
                      info.Fondos_Reservas = "SI";
                  }
                  else
                  {
                      info. Fondos_Reservas ="NO";
                  }

                   if (item.Decimo_Tercero != null)
                  {
                      info.Decimo_Tercero = "SI";
                  }
                  else
                  {
                      info.Decimo_Tercero = "NO";
                  }

                   info.em_logo = info_empresa.em_logo;
                   info.NombreComercial = info_empresa.NombreComercial;
                   info.RazonSocial = info_empresa.RazonSocial;

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
                return new List<XROL_Rpt014_Info>();
          }
      }
    }
}
