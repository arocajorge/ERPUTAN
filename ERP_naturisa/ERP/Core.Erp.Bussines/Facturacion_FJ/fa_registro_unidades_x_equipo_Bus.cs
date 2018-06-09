using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_registro_unidades_x_equipo_Bus
    {
        fa_registro_unidades_x_equipo_Data oData = new fa_registro_unidades_x_equipo_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Activo_fijo_Bus bus_af = new Af_Activo_fijo_Bus();
        fa_registro_unidades_x_equipo_det_ini_x_Af_Bus bus_Ini = new fa_registro_unidades_x_equipo_det_ini_x_Af_Bus();
        public List<fa_registro_unidades_x_equipo_Info> Get_List(int idEmpresa)
        {
            try
            {
                return oData.Get_List(idEmpresa);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public List<fa_registro_unidades_x_equipo_Info> Get_List_Vista(int idEmpresa, DateTime Fecha_Ini, DateTime Fecha_Fin)
        {
            try
            {
                return oData.Get_List_Vista(idEmpresa,Fecha_Ini,Fecha_Fin);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public fa_registro_unidades_x_equipo_Info Get_Info(int idEmpresa, decimal IdRegistro)
        {
            try
            {
                return oData.Get_Info(idEmpresa, IdRegistro);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }        

        public Boolean GuardarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.ip = param.ip;
                info.nom_pc = param.nom_pc;
                bool res = oData.GuardarDB(info);
                if (res)
                {
                    foreach (var item in info.Lst_det_x_Af_ini)
                    {
                        item.IdRegistro = info.IdRegistro;
                    }
                    res = bus_Ini.GuardarDB(info.Lst_det_x_Af_ini);
                }

                if (res && info.IdEstadoRegistro_cat=="EST_CERRADO")
                {
                    res = bus_af.Actualizar_Unidades(info.Lst_det);
                }
                return res;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public Boolean ModificarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.ip = param.ip;
                info.nom_pc = param.nom_pc;
                
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = param.Fecha_Transac;

                bool res = oData.ModificarDB(info);
                if (res)
                {
                    if (bus_Ini.EliminarDB(info))
                        res = bus_Ini.GuardarDB(info.Lst_det_x_Af_ini);
                }
                if (res && info.IdEstadoRegistro_cat == "EST_CERRADO")
                {
                    res = bus_af.Actualizar_Unidades(info.Lst_det);
                }
                return res;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public Boolean AnularDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.ip = param.ip;
                info.nom_pc = param.nom_pc;
                                
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
