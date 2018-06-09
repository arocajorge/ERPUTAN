using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_SubGrupoTrabajo_Data
    {
        string mensaje = "";
        public List<prd_SubGrupoTrabajo_Info> ObtenerGrupoTrabajoCab(int idempresa)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_SubGrupoTrabajo_Info> lM = new List<prd_SubGrupoTrabajo_Info>();
                var select = from C in OEProduccion.vwprd_GrupoTrabajoCab
                                     where C.IdEmpresa == idempresa
                                     orderby C.IdGrupoTrabajo ascending
                                     select C;

                foreach (var item in select)
                {
                    prd_SubGrupoTrabajo_Info info = new prd_SubGrupoTrabajo_Info();
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.Descripcion = item.gt_Descripcion;
                    info.FechaCreacion = item.FechaCreacion;
                    info.IdLider = item.IdLider;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.IdEtapa = item.IdEtapa;
                    info.Estado = item.Estado;
                    info.DescripModelo = item.DescripModelo;
                    info.NombreEtapa = item.NombreEtapa;
                    info.pe_nombreCompleto = item.pe_nombreCompleto;                  
                    info.Su_Descripcion = item.Su_Descripcion;
                    info.idGrupo = (int)item.IdGrupo;
                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

         
        public prd_SubGrupoTrabajo_Info OBtenerGTxEtapa(int idempresa, int idsucursal, int idGT )
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                prd_SubGrupoTrabajo_Info info = new prd_SubGrupoTrabajo_Info();
                var select = from C in OEProduccion.vwprd_GrupoTrabajo_x_Etapa
                             where C.IdEmpresa == idempresa 
                             && C.IdSucursal == idsucursal 
                             && C.IdGrupoTrabajo == idGT 
                             select C;

                foreach (var item in select)
                {
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                    info.CodObra = item.CodObra;
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.Descripcion = item.gt_descripcion;
                    
                    info.IdLider = item.IdLider;
                    info.IdEtapa = item.IdEtapa;
                    info.NombreEtapa = item.NombreEtapa;
                }

                return info;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
                
        public prd_SubGrupoTrabajo_Info OBtenerGT(int idempresa, int idsucursal, decimal idGT )
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                prd_SubGrupoTrabajo_Info info = new prd_SubGrupoTrabajo_Info();
                var select = from C in OEProduccion.vwprd_GrupoTrabajoCab
                             where C.IdEmpresa == idempresa 
                             && C.IdSucursal == idsucursal
                             && C.IdGrupoTrabajo == idGT
                                    
                             select C;
               

                foreach (var item in select)
                {
                    
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                   
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.Descripcion = item.gt_Descripcion;
                    info.FechaCreacion = item.FechaCreacion;
                      info.IdLider = item.IdLider;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.IdEtapa = item.IdEtapa;
                    info.Estado = item.Estado;
                    info.DescripModelo = item.DescripModelo;
                    info.NombreEtapa = item.NombreEtapa;
                    info.pe_nombreCompleto = item.pe_nombreCompleto;

                    
                    info.Su_Descripcion = item.Su_Descripcion;

                    
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
       
        /// </summary>
        /// <param name="idempresa"></param>
        /// <param name="IdCentroCosto"></param>
        /// <returns></returns>
        public List<prd_SubGrupoTrabajo_Info> ObtenerGrupoTrabajoCab_x_OT(int idempresa,int idsucursal, decimal idordentaller)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_SubGrupoTrabajo_Info> lM = new List<prd_SubGrupoTrabajo_Info>();
                var select = from C in OEProduccion.vwprd_GrupoTrabajoCab
                             where C.IdEmpresa == idempresa 
                             && C.IdSucursal == idsucursal 
                               
                             orderby C.IdGrupoTrabajo ascending
                             select C;

                foreach (var item in select)
                {
                    prd_SubGrupoTrabajo_Info info = new prd_SubGrupoTrabajo_Info();
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                  
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.Descripcion = item.gt_Descripcion;
                    info.FechaCreacion = item.FechaCreacion;
                    info.idGrupo =(int) item.IdGrupo;
                    
                    info.IdLider = item.IdLider;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.IdEtapa = item.IdEtapa;
                    info.Estado = item.Estado;
                    info.DescripModelo = item.DescripModelo;
                    info.NombreEtapa = item.NombreEtapa;
                    info.pe_nombreCompleto = item.pe_nombreCompleto;

                    
                    info.Su_Descripcion = item.Su_Descripcion;

                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        //Graba Cabecera  del grupo de trabajo 

        public Boolean GrabarCabeceraDB(int idempresa, prd_SubGrupoTrabajo_Info info, List<prd_SubGrupoTrabajoDetalle_Info> lmDetalleInfo, ref string msg, ref decimal idgenerada)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {

                    var address = new prd_GrupoTrabajo();
                    int id = getId(idempresa, info.IdSucursal);
                    address.IdEmpresa = idempresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdGrupoTrabajo = id;
                    idgenerada = id;
                    address.Descripcion = info.Descripcion;
                    address.FechaCreacion = info.FechaCreacion;
                    address.IdLider = info.IdLider;
                    address.IdProcesoProductivo = info.IdProcesoProductivo;
                    address.IdEtapa = info.IdEtapa;
                    address.Estado = info.Estado;
                    address.IdGrupo = info.idGrupo;
                    context.prd_GrupoTrabajo.Add(address);
                    context.SaveChanges();

                    lmDetalleInfo.ForEach(var => { var.CodObra = info.CodObra; 
                        var.IdEmpresa = info.IdEmpresa; var.IdSucursal = info.IdSucursal;
                        var.IdGrupotrabajo = id;});
                    prd_SubGrupoTrabajoDetalle_Data datadetalle = new prd_SubGrupoTrabajoDetalle_Data();
                    if (datadetalle.grabarDB(lmDetalleInfo, idempresa, id, ref msg))
                    {


                        //Disponibilidad_PorSubgrupo_Data DataGT = new Disponibilidad_PorSubgrupo_Data();
                        //DataGT.Disponibilidad_GT(info.idGrupo, id, info.IdProcesoProductivo, info.IdEtapa, 0);
                        return true;
                        msg = "Se ha procedido a grabar el Grupo de trabajo #: " + id.ToString() + " exitosamente.";
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(int idempresa, prd_SubGrupoTrabajo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_GrupoTrabajo.FirstOrDefault(obj => obj.IdEmpresa == idempresa && obj.IdSucursal == info.IdSucursal && obj.IdGrupoTrabajo == info.IdGrupoTrabajo);
                    if (contact != null)
                    {
                        contact.Descripcion = info.Descripcion;
                        contact.FechaCreacion = info.FechaCreacion;

                        contact.IdGrupo = info.idGrupo;
                        contact.IdLider = info.IdLider;
                        contact.IdProcesoProductivo = info.IdProcesoProductivo;
                        contact.IdEtapa = info.IdEtapa;
                        contact.Estado = info.Estado;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Grupo de trabajo #: " + info.IdGrupoTrabajo + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularReactiva(int idempresa, prd_SubGrupoTrabajo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_GrupoTrabajo.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdSucursal == info.IdSucursal && A.IdGrupoTrabajo == info.IdGrupoTrabajo);
                    if (contact != null)
                    {
                        contact.Estado = info.Estado;
                        context.SaveChanges();
                        msg = "Se Cambio el estado del Grupo de trabajo # :" + info.IdGrupoTrabajo.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public int getId(int idempresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_GrupoTrabajo
                             where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal 
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_GrupoTrabajo
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal 
                                     select q.IdGrupoTrabajo).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_SubGrupoTrabajo_Info> GetListSubGruposTrabajo(int idempresa, int idsucursal)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_SubGrupoTrabajo_Info> lM = new List<prd_SubGrupoTrabajo_Info>();
                var select = from C in OEProduccion.vwprd_SubgruposTrabajos
                             where C.IdEmpresa == idempresa
                             && C.IdSucursal == idsucursal

                             orderby C.IdGrupoTrabajo ascending
                             select C;

                foreach (var item in select)
                {
                    prd_SubGrupoTrabajo_Info info = new prd_SubGrupoTrabajo_Info();
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.idGrupo =(int) item.IdGrupo;
                    info.NombreGrupos = item.NombreGrupos;
                    info.NombreSubgrupo = item.NombreSubgrupo;
                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_SubGrupoTrabajo_Info> GetListSubGruposTrabajo(int idempresa, int idsucursal,int IdGrupo)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_SubGrupoTrabajo_Info> lM = new List<prd_SubGrupoTrabajo_Info>();
                var select = from C in OEProduccion.vwprd_SubgruposTrabajos
                             where C.IdEmpresa == idempresa
                             && C.IdSucursal == idsucursal
                             && C.IdGrupo==IdGrupo
                             orderby C.IdGrupoTrabajo ascending
                             select C;

                foreach (var item in select)
                {
                    prd_SubGrupoTrabajo_Info info = new prd_SubGrupoTrabajo_Info();
                    info.IdEmpresa = idempresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.idGrupo = (int)item.IdGrupo;
                    info.NombreGrupos = item.NombreGrupos;
                    info.NombreSubgrupo = item.NombreSubgrupo;


                    lM.Add(info);
                }
                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
