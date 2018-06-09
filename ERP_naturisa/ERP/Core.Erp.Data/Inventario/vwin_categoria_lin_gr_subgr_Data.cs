using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
  public  class vwin_categoria_lin_gr_subgr_Data
    {
      string mensaje = "";

      public List<vwin_categoria_lin_gr_subgr_Info> Get_List_in_categoria_lin_gr_subgr(int IdEmpresa)
      {
          try
          {
              List<vwin_categoria_lin_gr_subgr_Info> lM = new List<vwin_categoria_lin_gr_subgr_Info>();

              EntitiesInventario OEUser = new EntitiesInventario();

              var select_ = from TI in OEUser.vwin_categoria_lin_gr_subgr
                            where TI.IdEmpresa == IdEmpresa
                            select TI;

              foreach (var item in select_)
              {
                  vwin_categoria_lin_gr_subgr_Info dat_ = new vwin_categoria_lin_gr_subgr_Info();
                  dat_.IdEmpresa = item.IdEmpresa;
                  dat_.ID = item.ID;
                  dat_.IDPadre = item.IDPadre;
                  dat_.Codigo = item.Codigo;
                  dat_.descripcion = item.descripcion;
                  dat_.Estado = item.Estado;
                  dat_.IdCategoria = item.IdCategoria;
                  dat_.IdLinea = Convert.ToInt32(item.IdLinea);
                  dat_.IdGrupo = Convert.ToInt32(item.IdGrupo);
                  dat_.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                  dat_.IdNivel =Convert.ToInt32( item.IdNivel);
                              
                  lM.Add(dat_);
              }
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(mensaje);
          }
      }
    }
}
