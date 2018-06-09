using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_CambioUbicacion_Activo_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(Af_CambioUbicacion_Activo_Info Info, ref int IdCambioUbicacion, ref string msjError)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    Af_CambioUbicacion_Activo address = new Af_CambioUbicacion_Activo();
                    address.IdEmpresa = Info.IdEmpresa;
                    address.IdCambioUbicacion = IdCambioUbicacion = GetId(Info.IdEmpresa);
                    address.IdActivoFijo = Info.IdActivoFijo;
                    address.IdSucursal_Actu = Info.IdSucursal_Actu;
                    address.IdDepartamento_Actu = Info.IdDepartamento_Actu;
                    address.IdTipoCatalogo_Ubicacion_Actu = Info.IdTipoCatalogo_Ubicacion_Actu;
                    address.IdCentroCosto_Actu = Info.IdCentroCosto_Actu;
                    address.IdSucursal_Ant = Info.IdSucursal_Ant;
                    address.IdDepartamento_Ant = Info.IdDepartamento_Ant;
                    address.IdTipoCatalogo_Ubicacion_Ant = Info.IdTipoCatalogo_Ubicacion_Ant;
                    address.IdCentroCosto_Ant = Info.IdCentroCosto_Ant == "" ? null : Info.IdCentroCosto_Ant;
                    address.FechaCambio = Info.FechaCambio;
                    address.MotivoCambio = Info.MotivoCambio;
                    address.IdUsuario = Info.IdUsuario;
                    address.nom_pc = Info.nom_pc;
                    address.ip = Info.ip;
                    address.IdUnidadFact_cat = Info.IdUnidadFact_cat;
                    address.Af_ValorUnidad_Actu = Info.Af_ValorUnidad_Actu;
                    address.IdEncargado_Actu = Info.IdEncargado_Actu;
                    address.IdEncargado_Ant = Info.IdEncargado_Ant;
                    address.IdCentroCosto_sub_centro_costo_Actu = Info.IdCentroCosto_sub_centro_costo_Actu;
                    address.IdCentroCosto_sub_centro_costo_Ant = Info.IdCentroCosto_sub_centro_costo_Ant;
                    context.Af_CambioUbicacion_Activo.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_CambioUbicacion_Activo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_CambioUbicacion_Activo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdCambioUbicacion).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_CambioUbicacion_Activo_Info Get_Info_CambioUbicacion(int IdEmpresa, int IdCambioUbicacion)
        {
            try
            {
                Af_CambioUbicacion_Activo_Info Info = new Af_CambioUbicacion_Activo_Info();
                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.Af_CambioUbicacion_Activo
                                 where q.IdCambioUbicacion == IdCambioUbicacion
                                 && q.IdEmpresa == IdEmpresa
                                 select q;

                    foreach (var item in select)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCambioUbicacion = item.IdCambioUbicacion ;
                        Info.IdActivoFijo = item.IdActivoFijo;
                        Info.IdSucursal_Actu = item.IdSucursal_Actu;
                        Info.IdDepartamento_Actu = item.IdDepartamento_Actu;
                        Info.IdTipoCatalogo_Ubicacion_Actu = item.IdTipoCatalogo_Ubicacion_Actu;
                        Info.IdCentroCosto_Actu = item.IdCentroCosto_Actu;
                        Info.IdSucursal_Ant = item.IdSucursal_Ant;
                        Info.IdDepartamento_Ant = item.IdDepartamento_Ant;
                        Info.IdTipoCatalogo_Ubicacion_Ant = item.IdTipoCatalogo_Ubicacion_Ant;
                        Info.IdCentroCosto_Ant = item.IdCentroCosto_Ant;
                        Info.FechaCambio = item.FechaCambio;
                        Info.MotivoCambio = item.MotivoCambio;
                        Info.IdUsuario = item.IdUsuario;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        Info.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        Info.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        Info.IdEncargado_Actu = item.IdEncargado_Actu;
                        Info.IdEncargado_Ant = item.IdEncargado_Ant;
                        Info.IdCentroCosto_sub_centro_costo_Actu = item.IdCentroCosto_sub_centro_costo_Actu;
                        Info.IdCentroCosto_sub_centro_costo_Ant = item.IdCentroCosto_sub_centro_costo_Ant;
                    }
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwAf_CambioUbicacion_Info> Get_List_CambioUbicacion(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<vwAf_CambioUbicacion_Info> lstInfo = new List<vwAf_CambioUbicacion_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_CambioUbicacion
                                 where q.IdEmpresa == IdEmpresa
                                 && q.FechaCambio >= FechaIni && q.FechaCambio <= FechaFin
                                 select q;

                    foreach (var item in select)
                    {                        
                        vwAf_CambioUbicacion_Info info = new vwAf_CambioUbicacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCambioUbicacion = item.IdCambioUbicacion;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdSucursal_Actu = item.IdSucursal_Actu;
                        info.IdSucursal_Ant = item.IdSucursal_Ant;
                        info.IdDepartamento_Actu = item.IdDepartamento_Actu;
                        info.nom_departamento_Act = item.nom_departamento_Act;
                        info.IdDepartamento_Ant = item.IdDepartamento_Ant;
                        info.nom_departamento_Ant = item.nom_departamento_Ant;
                        info.IdTipoCatalogo_Ubicacion_Actu = item.IdTipoCatalogo_Ubicacion_Actu;
                        info.nom_ubicacion_act = item.nom_ubicacion_act;
                        info.IdTipoCatalogo_Ubicacion_Ant = item.IdTipoCatalogo_Ubicacion_Ant;
                        info.nom_ubicacion_dest = item.nom_ubicacion_dest;
                        info.IdCentroCosto_Actu = item.IdCentroCosto_Actu;
                        info.nom_CentroCosto_Actu = item.nom_CentroCosto_Actu;
                        info.IdCentroCosto_Ant = item.IdCentroCosto_Ant;
                        info.nom_CentroCosto_Ant = item.nom_CentroCosto_Ant;
                        info.FechaCambio = item.FechaCambio;
                        info.MotivoCambio = item.MotivoCambio;

                        info.IdCentroCosto_Actu = item.IdCentroCosto_Actu;

                        info.nom_Cliente_Actu = item.nom_Cliente_Actu;

                        info.IdCentroCosto_Ant = item.IdCentroCosto_Ant;
                        info.nom_Cliente_Ant = item.nom_Cliente_Ant;

                        info.IdEncargado_Actu = item.IdEncargado_Actu;
                        info.IdEncargado_Ant = item.IdEncargado_Ant;
                        info.nom_Encargado_Actu = item.nom_Encargado_Actu;
                        info.nom_Encargado_Ant = item.nom_Encargado_Ant;
                        info.IdCentroCosto_sub_centro_costo_Actu = item.IdCentroCosto_sub_centro_costo_Actu;
                        info.IdCentroCosto_sub_centro_costo_Ant = item.IdCentroCosto_sub_centro_costo_Ant;
                        info.nom_Centro_costo_sub_centro_costo_Actu = item.nom_Centro_costo_sub_centro_costo_Actu;
                        info.nom_Centro_costo_sub_centro_costo_Ant = item.nom_Centro_costo_sub_centro_costo_Ant;
                        lstInfo.Add(info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwAf_CambioUbicacion_Info> Get_List_CambioUbicacion(int IdEmpresa, int IdActivofijo)
        {
            try
            {
                List<vwAf_CambioUbicacion_Info> lstInfo = new List<vwAf_CambioUbicacion_Info>();

                using (EntitiesActivoFijo listado = new EntitiesActivoFijo())
                {
                    var select = from q in listado.vwAf_CambioUbicacion
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdActivoFijo == IdActivofijo 
                                 select q;

                    foreach (var item in select)
                    {
                        vwAf_CambioUbicacion_Info info = new vwAf_CambioUbicacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCambioUbicacion = item.IdCambioUbicacion;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdSucursal_Actu = item.IdSucursal_Actu;
                        info.IdSucursal_Ant = item.IdSucursal_Ant;
                        info.IdDepartamento_Actu = item.IdDepartamento_Actu;
                        info.nom_departamento_Act = item.nom_departamento_Act;
                        info.IdDepartamento_Ant = item.IdDepartamento_Ant;
                        info.nom_departamento_Ant = item.nom_departamento_Ant;
                        info.IdTipoCatalogo_Ubicacion_Actu = item.IdTipoCatalogo_Ubicacion_Actu;
                        info.nom_ubicacion_act = item.nom_ubicacion_act;
                        info.IdTipoCatalogo_Ubicacion_Ant = item.IdTipoCatalogo_Ubicacion_Ant;
                        info.nom_ubicacion_dest = item.nom_ubicacion_dest;
                        info.IdCentroCosto_Actu = item.IdCentroCosto_Actu;
                        info.nom_CentroCosto_Actu = item.nom_CentroCosto_Actu;
                        info.IdCentroCosto_Ant = item.IdCentroCosto_Ant;
                        info.nom_CentroCosto_Ant = item.nom_CentroCosto_Ant;
                        info.FechaCambio = item.FechaCambio;
                        info.MotivoCambio = item.MotivoCambio;

                        info.IdCentroCosto_Actu = item.IdCentroCosto_Actu;

                        info.nom_Cliente_Actu = item.nom_Cliente_Actu;

                        info.IdCentroCosto_Ant = item.IdCentroCosto_Ant;
                        info.nom_Cliente_Ant = item.nom_Cliente_Ant;
                        info.IdEncargado_Actu = item.IdEncargado_Actu;
                        info.IdEncargado_Ant = item.IdEncargado_Ant;
                        info.nom_Encargado_Actu = item.nom_Encargado_Actu;
                        info.nom_Encargado_Ant = item.nom_Encargado_Ant;
                        info.IdCentroCosto_sub_centro_costo_Actu = item.IdCentroCosto_sub_centro_costo_Actu;
                        info.IdCentroCosto_sub_centro_costo_Ant = item.IdCentroCosto_sub_centro_costo_Ant;
                        info.nom_Centro_costo_sub_centro_costo_Actu = item.nom_Centro_costo_sub_centro_costo_Actu;
                        info.nom_Centro_costo_sub_centro_costo_Ant = item.nom_Centro_costo_sub_centro_costo_Ant;
                        lstInfo.Add(info);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
