using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt021_Data
  {
      string mensaje = "";
      tb_Empresa_Data empresa_data = new tb_Empresa_Data();
      tb_Empresa_Info info_empresa = new tb_Empresa_Info();
      public List<XROL_Rpt021_Info> Get_List_DiasFaltados(int idEmpresa, int idNomina, int idDepartamento, DateTime fi, DateTime ff)
      {
          try
          {
              List<XROL_Rpt021_Info> Listado = new List<XROL_Rpt021_Info>();
              info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
              int idempleado = 0;
              int sec = 0;
              using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
              {
                  var select = from a in enti.vwROL_Rpt021
                               where a.IdEmpresa==idEmpresa
                               && a.IdDepartamento==idDepartamento
                               && a.IdTipoNomina==idNomina
                               && a.FechaDescuentaRol >= fi
                               && a.FechaDescuentaRol <= ff
                               orderby a.pe_apellido ascending
                               select a;

                  foreach (var item in select)
                  {
                      XROL_Rpt021_Info info = new XROL_Rpt021_Info();
                      if (idempleado != item.IdEmpleado)
                      {
                          sec = sec + 1;
                      }
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTipoNomina = item.IdTipoNomina;
                      info.IdEmpleado = item.IdEmpleado;
                     
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.Descripcion = item.Descripcion;
                      info.DiasDescuento = item.DiasDescuento;
                      info.secuencia = sec;
                      info.em_logo = info_empresa.em_logo;
                      info.NombreComercial = info_empresa.NombreComercial;
                      info.RazonSocial = info_empresa.RazonSocial;
                      info.Descripcion = item.Descripcion;
                      info.de_descripcion = item.de_descripcion;




                      info.secuencia = sec;
                      idempleado =Convert.ToInt32( item.IdEmpleado);

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
              return new List<XROL_Rpt021_Info>();
          }
      }

      public List<XROL_Rpt021_Info> Get_List_DiasFaltados(int idEmpresa, int idNomina, int IdDepartamento, int IdEmpleado, DateTime fi, DateTime ff)
      {
          try
          {
              List<XROL_Rpt021_Info> Listado = new List<XROL_Rpt021_Info>();
              info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
              int idempleado = 0;
              int sec = 0;
              using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
              {
                  var select = from a in enti.vwROL_Rpt021
                               where a.IdEmpresa == idEmpresa
                               && a.IdDepartamento == IdDepartamento
                               && a.IdTipoNomina == idNomina
                               && a.IdEmpleado == IdEmpleado
                               && a.FechaDescuentaRol >= fi
                               && a.FechaDescuentaRol <= ff
                               orderby a.pe_apellido ascending
                               select a;

                  foreach (var item in select)
                  {
                      XROL_Rpt021_Info info = new XROL_Rpt021_Info();
                      if (idempleado != item.IdEmpleado)
                      {
                          sec = sec + 1;
                      }
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTipoNomina = item.IdTipoNomina;
                      info.IdEmpleado = item.IdEmpleado;

                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.Descripcion = item.Descripcion;
                      info.DiasDescuento = item.DiasDescuento;
                      info.secuencia = sec;
                      info.em_logo = info_empresa.em_logo;
                      info.NombreComercial = info_empresa.NombreComercial;
                      info.RazonSocial = info_empresa.RazonSocial;
                      info.Descripcion = item.Descripcion;
                      info.de_descripcion = item.de_descripcion;




                      info.secuencia = sec;
                      idempleado = Convert.ToInt32(item.IdEmpleado);

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
              return new List<XROL_Rpt021_Info>();
          }
      }


      public List<XROL_Rpt021_Info> Get_List_DiasFaltados(int idEmpresa, int idNomina, DateTime fi, DateTime ff)
      {
          try
          {
              List<XROL_Rpt021_Info> Listado = new List<XROL_Rpt021_Info>();
              info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
              int idempleado = 0;
              int sec = 0;
              using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
              {
                  var select = from a in enti.vwROL_Rpt021
                               where a.IdEmpresa == idEmpresa
                               && a.IdTipoNomina == idNomina
                               && a.FechaDescuentaRol >= fi
                               && a.FechaDescuentaRol <= ff
                               orderby a.pe_apellido ascending
                               select a;

                  foreach (var item in select)
                  {
                      XROL_Rpt021_Info info = new XROL_Rpt021_Info();
                      if (idempleado != item.IdEmpleado)
                      {
                          sec = sec + 1;
                      }
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTipoNomina = item.IdTipoNomina;
                      info.IdEmpleado = item.IdEmpleado;

                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.Descripcion = item.Descripcion;
                      info.DiasDescuento = item.DiasDescuento;
                      info.em_logo = info_empresa.em_logo;
                      info.NombreComercial = info_empresa.NombreComercial;
                      info.RazonSocial = info_empresa.RazonSocial;
                      info.Descripcion = item.Descripcion;
                      info.de_descripcion = item.de_descripcion;



                      info.secuencia = sec;
                      idempleado = Convert.ToInt32(item.IdEmpleado);

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
              return new List<XROL_Rpt021_Info>();
          }
      }



     
    }
}
