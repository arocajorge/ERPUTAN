using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ProcesoProductivo_Data
    {
        string mensaje = "";//IdProcesProductivo
        public List<prd_ProcesoProductivo_Info> ObtenerProcesProductivo(int Idempresa)
        {
            try
            {
                List<prd_ProcesoProductivo_Info> lm = new List<prd_ProcesoProductivo_Info>();
                EntitiesProduccion_Cidersus OEprocesoproductivo = new EntitiesProduccion_Cidersus();
                var registros = from A in OEprocesoproductivo.prd_ProcesoProductivo
                                where A.IdEmpresa == Idempresa
                                select A;
                foreach (var item in registros)
                {
                    prd_ProcesoProductivo_Info info = new prd_ProcesoProductivo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.Nombre = item.Nombre;
                    
                    info.Estado = (item.Estado == "A") ? true : false;
                    
                    lm.Add(info);
                }
                return lm;
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
        public List<prd_ProcesoProductivo_Info> ObtenerProcesProductivo(int idempresa, int IdProcesProductivo)
        {
            try
            {
                List<prd_ProcesoProductivo_Info> lm = new List<prd_ProcesoProductivo_Info>();
                EntitiesProduccion_Cidersus OEprocesoproductivo = new EntitiesProduccion_Cidersus();
                var registros = from A in OEprocesoproductivo.prd_ProcesoProductivo
                                where A.IdEmpresa == idempresa
                                && A.IdProcesoProductivo == IdProcesProductivo
                                select A;
                foreach (var item in registros)
                {
                    prd_ProcesoProductivo_Info info = new prd_ProcesoProductivo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.Nombre = item.Nombre;
                    lm.Add(info);
                }
                return lm;
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
        //obtender id del proceso productivo
        public int getIdProcesoProductivo(int IdEmpresa)
        {
            int id;
            try
            {
                EntitiesProduccion_Cidersus OEprocesoproductivo = new EntitiesProduccion_Cidersus();
                var reg = from A in OEprocesoproductivo.prd_ProcesoProductivo
                          where A.IdEmpresa == IdEmpresa
                          select A;

                if (reg.ToList().Count < 1)
                {
                    id = 1;
                }
                else
                {
                    OEprocesoproductivo = new EntitiesProduccion_Cidersus();
                    var reg1 = (from A in OEprocesoproductivo.prd_ProcesoProductivo
                                where A.IdEmpresa == IdEmpresa
                                select A.IdProcesoProductivo).Max();
                    id = Convert.ToInt32(reg1.ToString()) + 1;
                }
                return id;
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

        public Boolean GrabarItem(prd_ProcesoProductivo_Info info, ref int idpp, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var address = new prd_ProcesoProductivo();
                    idpp = getIdProcesoProductivo(info.IdEmpresa);
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdProcesoProductivo = idpp;
                    
                    address.Nombre = info.Nombre;
                    address.Estado = (info.Estado == true) ? "A" : "I";
                    context.prd_ProcesoProductivo.Add(address);
                    context.SaveChanges();

                    msg = "Se ha generado el Proceso Productivo No.:" + idpp.ToString() + " exitosamente";
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

        public Boolean GrabarModelo_x_Obra(prd_ProcesoProductivo_Info infoMP, prd_Obra_Info  InfoOBra)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var address = new prd_ProcesoProductivo_x_prd_obra();
                    address.IdEmpresa_obra = InfoOBra.IdEmpresa;
                    address.CodObra = InfoOBra.CodObra;
                    address.IdEmpresa_Pr  = infoMP.IdEmpresa;
                    address.IdProcesoProductivo = infoMP.IdProcesoProductivo;

                    context.prd_ProcesoProductivo_x_prd_obra.Add(address);
                    context.SaveChanges();
                }
                return true;
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

        public Boolean ModificarItem(prd_ProcesoProductivo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_ProcesoProductivo.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.IdProcesoProductivo == info.IdProcesoProductivo);
                    if (contact != null)
                    {
                        contact.Nombre = info.Nombre;
                        contact.Estado = (info.Estado == true) ? "A" : "I";
                        context.SaveChanges();
                        msg = "Se ha procedio a actualizar el Proceso Productivo No.:" + info.IdProcesoProductivo.ToString() + " exitosamente";
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

        public Boolean AnularItem(prd_ProcesoProductivo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.prd_ProcesoProductivo.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.IdProcesoProductivo == info.IdProcesoProductivo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedio anular el Id del Proceso Productivo # :" + info.IdProcesoProductivo.ToString() + " exitosamente";
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
    }
}
