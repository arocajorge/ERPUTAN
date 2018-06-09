using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_cbtecble_Plantilla_Bus
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ct_cbtecble_Plantilla_Data data = new ct_cbtecble_Plantilla_Data();
        #endregion
                
        public List<ct_cbtecble_Plantilla_Info> Get_list_cbtecble_Plantilla(int IdEmpresa)
        {
            try
            {
             return data.Get_list_Plantilla(IdEmpresa); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Plantilla", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_Bus) };
            }

        }

        public Boolean ModificarDB(ct_cbtecble_Plantilla_Info Pla_I)
        {
            try
            {
               return data.ModificarDB(Pla_I);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_Bus) };
            }

        }

        public Boolean GrabarDB( ct_cbtecble_Plantilla_Info info, ref decimal IdPlantilla, ref string msg)
        {
            try
            {
                ct_cbtecble_Plantilla_Info _Info = new ct_cbtecble_Plantilla_Info();
                List<ct_cbtecble_Plantilla_det_Info> Lst_det = new List<ct_cbtecble_Plantilla_det_Info>();
                _Info.cb_Estado = "A";
                _Info.cb_Fecha = info.cb_Fecha;
                _Info.cb_Observacion = info.cb_Observacion;
                _Info.IdEmpresa = info.IdEmpresa;
                _Info.IdTipoCbte = info.IdTipoCbte;
                _Info.IdUsuario = info.IdUsuario;
                _Info.IdUsuarioUltModi = info.IdUsuarioUltModi;
                _Info.IdUsuarioAnu = info.IdUsuarioAnu;
                _Info.cb_FechaAnu = info.cb_FechaAnu;
                _Info.cb_FechaTransac = info.cb_FechaTransac;
                _Info.cb_FechaUltModi = info.cb_FechaUltModi;
                _Info.IdPlantilla = info.IdPlantilla;
                _Info.LstDet = info.LstDet;
                Boolean estado = false;


                foreach (var item in _Info.LstDet )
                {
                    if (item.Debe_Aux > 0)
                    {
                        item.dc_Valor = item.Debe_Aux;
                    }
                    if (item.Haber_Aux > 0)
                    {
                        item.dc_Valor = item.Haber_Aux * -1;
                    }

                    if (item.dc_Observacion == "" || info.cb_Observacion != null)
                    {
                        item.dc_Observacion = info.cb_Observacion;
                    }
                }

                estado = data.GrabarDB(_Info, ref IdPlantilla, ref msg);


                return estado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_Bus) };
            }
        }

        public Boolean EliminarDB(ct_cbtecble_Plantilla_Info info)
        {
            try
            {
                 return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_Bus) };
            }

        }

        public ct_cbtecble_Plantilla_Info Get_Info_Plantilla(int IdEmpresa, int IdTipoCbte, decimal IdPlantilla)
        {
            try
            {
                 return data.Get_Info_Plantilla(IdEmpresa, IdTipoCbte, IdPlantilla);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Plantilla", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_Bus) };
            }

        }
      
        public ct_Cbtecble_Info Get_Info_Plantilla_CbteCble(int IdEmpresa, int IdTipoCbte, decimal IdPlantilla)
        {
            try
            {
                 ct_cbtecble_Plantilla_Info info = new ct_cbtecble_Plantilla_Info();
                    ct_Cbtecble_Info _Info = new ct_Cbtecble_Info();
                    List<ct_Cbtecble_det_Info> Lst_det = new List<ct_Cbtecble_det_Info>();

                    info= data.Get_Info_Plantilla(IdEmpresa, IdTipoCbte, IdPlantilla);

                    _Info.Estado = "A";
                    _Info.cb_Fecha = info.cb_Fecha;
                    _Info.cb_Observacion = info.cb_Observacion;
                    _Info.IdEmpresa = info.IdEmpresa;
                    _Info.IdTipoCbte = info.IdTipoCbte;
                    _Info.IdUsuario = info.IdUsuario;
                    _Info.IdUsuarioUltModi = info.IdUsuarioUltModi;
                    _Info.IdUsuarioAnu = info.IdUsuarioAnu;
                    _Info.cb_FechaAnu = info.cb_FechaAnu;
                    _Info.cb_FechaTransac = info.cb_FechaTransac;
                    _Info.cb_FechaUltModi = info.cb_FechaUltModi;
                    _Info.IdCbteCble = info.IdPlantilla;

                    foreach (var item in info.LstDet)
                    {
                        ct_Cbtecble_det_Info det_i = new ct_Cbtecble_det_Info();

                        det_i.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        det_i.IdPunto_cargo = item.IdPunto_cargo;
                        det_i.IdEmpresa = item.IdEmpresa;
                        det_i.IdTipoCbte = item.IdTipoCbte;
                        det_i.IdCtaCble = item.IdCtaCble;
                        det_i.IdCbteCble = item.IdPlantilla;

                        if (item.IdCentroCosto != "")
                        {
                            det_i.IdCentroCosto = item.IdCentroCosto;
                        }

                        det_i.secuencia = item.secuencia;
                        det_i.dc_Valor = item.dc_Valor;
                        det_i.dc_Observacion = item.dc_Observacion;

                        Lst_det.Add(det_i);
                    }

                    _Info._cbteCble_det_lista_info = Lst_det;
                

                    return _Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Plantilla_CbteCble", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Plantilla_Bus) };
            }
        }

        public ct_cbtecble_Plantilla_Bus()
        {
        }
            
    }
}
