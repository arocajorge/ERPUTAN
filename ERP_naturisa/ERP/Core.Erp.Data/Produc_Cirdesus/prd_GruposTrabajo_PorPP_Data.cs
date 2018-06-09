using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Produc_Cirdesus
{
  public  class prd_GruposTrabajo_PorPP_Data
    {
      string mensaje = "";
      public bool GrabaDB(List< prd_GruposTrabajo_PorPP_Info> Info,  ref string Error)
      {
         // Disponibilidad_PorSubgrupo_Data data = new Disponibilidad_PorSubgrupo_Data();
          try
          {
              EntitiesProduccion_Cidersus entie = new EntitiesProduccion_Cidersus();

              foreach (var item in Info)
              {
                  prd_GruposTrabajo_PorPP Add = new prd_GruposTrabajo_PorPP();
                  Add.IdProcesoProductivo = item.IdProcesoProductivo;
                  Add.IdEtapa = item.IdEtapa;
                  Add.IdGrupoTrabajo = item.IdGrupoTrabajo;
                  Add.IdSubgrupo = item.IdSubgrupo;
                  entie.prd_GruposTrabajo_PorPP.Add(Add);
                  entie.SaveChanges();

                  //data.Disponibilidad_GT(item.IdGrupoTrabajo, item.IdSubgrupo, item.IdProcesoProductivo, item.IdEtapa, 0);

              }
              
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }


      public List<prd_GruposTrabajo_PorPP_Info> GetListaGruposTrabajosEtapas(prd_GruposTrabajo_PorPP_Info Info)
      {
          try
          {
              EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
              List<prd_GruposTrabajo_PorPP_Info> lM = new List<prd_GruposTrabajo_PorPP_Info>();

              var select = from C in OEProduccion.vwin_prd_GruposTrabajosPorPProductivos
                           where C.IdEmpresa == Info.IdEmpresa
                          && C.IdProcesoProductivo == Info.IdProcesoProductivo
                          && C.IdEtapa == Info.IdEtapa
                           select C;

              foreach (var item in select)
              {
                  prd_GruposTrabajo_PorPP_Info info = new prd_GruposTrabajo_PorPP_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdProcesoProductivo = item.IdProcesoProductivo;
                  info.IdEtapa = item.IdEtapa;
                  info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                  info.IdSubgrupo = item.IdSubgrupo;
                  info.NombreEtapa = item.NombreEtapa;
                  info.NombreSubgrupo = item.NombreSubgrupo;
                  info.ProcesoProductivo = item.ProcesoProductivo;

                  info.NombreGrupos = item.GrupoTrabajo;
                  lM.Add(info);
              }
              return lM;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }



      public List<prd_GruposTrabajo_PorPP_Info> GetListEtapasProceProductivo(int Idempresa)
      {
          try
          {
              EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
              List<prd_GruposTrabajo_PorPP_Info> lM = new List<prd_GruposTrabajo_PorPP_Info>();
              var select = from C in OEProduccion.vwin_prd_EtasProcesoProductivo
                           where C.IdEmpresa == Idempresa

                           select C;

              foreach (var item in select)
              {
                  prd_GruposTrabajo_PorPP_Info info = new prd_GruposTrabajo_PorPP_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdProcesoProductivo = item.IdProcesoProductivo;
                  info.IdEtapa = item.IdEtapa;
                  info.NombreEtapa = item.NombreEtapa;
                  info.ProcesoProductivo = item.ProcesoProductivo;

                  lM.Add(info);
              }
              return lM;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}
