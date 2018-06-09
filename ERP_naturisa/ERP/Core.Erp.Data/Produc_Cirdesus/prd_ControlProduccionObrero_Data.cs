using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ControlProduccionObrero_Data
    {
        string mensaje = "";
        public List<prd_ControlProduccionObrero_Info> Get_List_ControlProduccionObrero(int IdEmpresa,int IdGrupoT,DateTime FechaIni,DateTime FechaFin)
        {
            try
            {
                TimeSpan TiempoProduccion;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                List<prd_ControlProduccionObrero_Info> lM = new List<prd_ControlProduccionObrero_Info>();
                var select = from C in OEProduccion.vwprd_ControlProduccion_Obrero_Cab
                             where C.IdEmpresa == IdEmpresa
                             && C.IdGrupoTrabajo==IdGrupoT
                             && C.FechaTransaccion>=FechaIni
                             &&C.FechaTransaccion<=FechaFin
                             orderby C.FechaTransaccion ascending
                             select C;

                foreach (var item in select)
                {
                    prd_ControlProduccionObrero_Info info = new prd_ControlProduccionObrero_Info();
                    info.IdEmpresa = IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                    info.FechaHoraFinFabricacion =(DateTime) item.FechaTransaccion;
                    if (item.FechaFinProceso != null)
                    {
                        info.FechaHoraInicioFabricacion = (DateTime)item.FechaFinProceso;


                        int hh = Convert.ToInt32(((TimeSpan)(item.FechaFinProceso-item.FechaTransaccion)).TotalHours);
                        int mm = Convert.ToInt32(((TimeSpan)(item.FechaFinProceso - item.FechaTransaccion)).Minutes);
                        int ss = Convert.ToInt32(((TimeSpan)(item.FechaFinProceso - item.FechaTransaccion)).TotalSeconds);

                        TiempoProduccion = new TimeSpan(hh, mm, ss);
                        info.TiempoDuroPP = TiempoProduccion;  
                    }
                    info.NombreProcesoProductivo = item.Nombre;
                    info.Nom_grupoTrabajo = item.Descripcion;
                    info.NombreEtapa = item.NombreEtapa;
                    info.NombreProducto = item.DescripcionPieza;
                    info.Observacion = item.Observacion;
                    info.Estado = item.Estado;                                     
                    info.NombreEtapa=item.NombreEtapa;
                 

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

        public Boolean GrabarDB(int IdEmpresa, prd_ControlProduccionObrero_Info info, List<prd_ControlProduccionObreroDetalle_Info> lmDetalleInfo, ref string msg, ref decimal idgenerada)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                   
                    var address = new prd_ControlProduccion_Obrero();
                    int id = GetId(IdEmpresa, info.IdSucursal);
                    address.IdEmpresa = IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdBodega = info.IdBodega;
                    address.IdControlProduccionObrero = id;
                    //Para pasarla al winform
                    idgenerada = id;

                    address.NumCPO = id;
                    address.IdGrupoTrabajo = info.IdGrupoTrabajo;
                    address.CodObra = info.CodObra;
                    address.IdOrdenTaller = info.IdOrdenTaller;
                    address.IdEmpleado = info.IdEmpleado;
                    address.CantAsignada = info.CantAsignada;
                    address.Observacion = info.Observacion;
                    address.FechaRegistro = info.FechaRegistro;
                    address.Estado = "A";

                    context.prd_ControlProduccion_Obrero.Add(address);
                    context.SaveChanges();

                    prd_ControlProduccionObreroDetalle_Data datadetalle = new prd_ControlProduccionObreroDetalle_Data();
                    if (datadetalle.grabarDB(lmDetalleInfo, IdEmpresa, id, ref msg))
                    {
                        return true;
                        msg = "Se ha procedido a grabar el registro del Control  de Producción #: " + id.ToString() + " exitosamente.";
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
                return false;
            }
        }

        public Boolean ModificarDB(int IdEmpresa, prd_ControlProduccionObrero_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_ControlProduccion_Obrero.FirstOrDefault(obj => obj.IdEmpresa == IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdControlProduccionObrero == info.IdControlProduccionObrero );
                    if (contact != null)
                    {
                        contact.NumCPO = info.NumDoc;
                        contact.IdGrupoTrabajo = info.IdGrupoTrabajo;
                        contact.CodObra = info.CodObra;
                        contact.IdOrdenTaller = info.IdOrdenTaller;
                        contact.IdEmpleado = info.IdEmpleado;
                        contact.Observacion = info.Observacion;
                        contact.FechaRegistro = info.FechaRegistro;
                        contact.Estado = info.Estado;
                        contact.CantAsignada = info.CantAsignada;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Control de Producción #: " + info.IdControlProduccionObrero + " exitosamente";
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
                return false;
            }
        }

        public Boolean AnularDB(int IdEmpresa, prd_ControlProduccionObrero_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_ControlProduccion_Obrero.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdSucursal == info.IdSucursal && A.IdControlProduccionObrero == info.IdControlProduccionObrero);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        context.SaveChanges();
                        msg = "Se Cambio el estado del Control de Producción # :" + info.IdControlProduccionObrero.ToString() + " exitosamente";
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
                return false;
            }
        }

        public int GetId(int IdEmpresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_ControlProduccion_Obrero
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_ControlProduccion_Obrero
                                     where q.IdEmpresa == IdEmpresa && q.IdSucursal == idsucursal
                                     select q.IdControlProduccionObrero).Max();
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
                return -1;
            }

        }

        public prd_ControlProduccionObrero_Info Get_Info_ControlProduccionObrero(int IdEmpresa, int IdSucursal, decimal codGT, string CodObra, decimal codCPO)
        {

            try
            {
                EntitiesProduccion_Cidersus GTProduccion = new EntitiesProduccion_Cidersus();
                prd_ControlProduccionObrero_Info lGT = new prd_ControlProduccionObrero_Info();

               
                return lGT;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new prd_ControlProduccionObrero_Info();
            }







        }
       
    }
}
