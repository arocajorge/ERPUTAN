using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_EtapaProduccion_Data
    {
        string mensaje = "";
        public List<prd_EtapaProduccion_Info> ObtenerListaEtapas(int idempresa, int idProcesoProductivo)
        {
            try
            {
                List<prd_EtapaProduccion_Info> lm = new List<prd_EtapaProduccion_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.prd_EtapaProduccion
                                where A.IdEmpresa == idempresa && A.IdProcesoProductivo == idProcesoProductivo
                                orderby A.Posicion
                                select A;
                foreach (var item in registros)
                {
                    prd_EtapaProduccion_Info info = new prd_EtapaProduccion_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.IdEtapa = item.IdEtapa;
                    info.NombreEtapa = item.NombreEtapa;
                    info.PorcentajeEtapa = item.PorcentajeEtapa;
                    info.Posicion = item.Posicion;
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
        public List<prd_EtapaProduccion_Info> ObtenerListaEtapas(int idempresa)
        {
            try
            {
                List<prd_EtapaProduccion_Info> lm = new List<prd_EtapaProduccion_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.prd_EtapaProduccion
                                where A.IdEmpresa == idempresa
                                orderby A.Posicion
                                select A;
                foreach (var item in registros)
                {
                    prd_EtapaProduccion_Info info = new prd_EtapaProduccion_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.IdEtapa = item.IdEtapa;
                    info.NombreEtapa = item.NombreEtapa;
                    info.PorcentajeEtapa = item.PorcentajeEtapa;
                    info.Posicion = item.Posicion;
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
        //obtender id de la Etapa
        public int getIdEtapa(int IdEmpresa, int IdProcesoProductivo)
        {
            int id;
            try
            {
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var reg = from A in OEEtapa.prd_EtapaProduccion
                          where A.IdEmpresa == IdEmpresa && A.IdProcesoProductivo == IdProcesoProductivo
                          select A;

                if (reg.ToList().Count < 1)
                {
                    id = 1;
                }
                else
                {
                    OEEtapa = new EntitiesProduccion_Cidersus();
                    var reg1 = (from A in OEEtapa.prd_EtapaProduccion
                                where A.IdEmpresa == IdEmpresa && A.IdProcesoProductivo == IdProcesoProductivo
                                select A.IdEtapa).Max();
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

        public Boolean GrabarListaEtapas(List<prd_EtapaProduccion_Info> ListInfo, int IdEmpresa, int IdModeloProductivo, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    foreach (var item in ListInfo)
                    {
                        var address = new prd_EtapaProduccion();

                        //int idEtapa = getIdEtapa(IdEmpresa, IdModeloProductivo);
                        address.IdEmpresa = IdEmpresa;
                        address.IdProcesoProductivo = IdModeloProductivo;
                        //address.IdEtapa = idEtapa;
                        address.IdEtapa = item.IdEtapa;
                        address.NombreEtapa = item.NombreEtapa;
                        address.PorcentajeEtapa = item.PorcentajeEtapa;
                        address.Posicion = item.Posicion;

                        context.prd_EtapaProduccion.Add(address);
                        context.SaveChanges();
                    }

                    msg = "Se ha procedido a grabar las Etapas de producción del modelo  #: " + IdModeloProductivo.ToString() + " exitosamente.";
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

        //Funcion para eliminar la lista
        public Boolean eliminarLisEtapas(List<prd_EtapaProduccion_Info> ListInfo, int IdEmpresa, int IdModeloProductivo, ref string msg)
        {
            try
            {

                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {

                    foreach (var item in ListInfo)
                    {
                        var address = context.prd_EtapaProduccion.FirstOrDefault(A => A.IdEmpresa == IdEmpresa && A.IdProcesoProductivo == IdModeloProductivo);
                        if (address != null)
                        {
                            context.prd_EtapaProduccion.Remove(address);
                            context.SaveChanges();
                            msg = "Se ha procedido a Eliminar las Etapas de producción del modelo  #: " + IdModeloProductivo.ToString() + " exitosamente.";
                        }
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


        public prd_EtapaProduccion_Info ObtenerEtapa(int IdEmpresa, int IdEtapa, int IdProcesoProductivo) 
        {
            try
            {
                prd_EtapaProduccion_Info Info = new prd_EtapaProduccion_Info();
                EntitiesRoles Oent= new EntitiesRoles();

                string Query = "select * from prd_EtapaProduccion where IdEtapa = "+IdEtapa+"  and IdProcesoProductivo = "+IdProcesoProductivo+" and IdEmpresa = "+IdEmpresa;
                var Consulta = Oent.Database.SqlQuery<prd_EtapaProduccion_Info>(Query);
                if(Consulta!=null)
                    Info = Consulta.First();


                return Info;
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
        public prd_EtapaProduccion_Info ObtenerEtapaAnterior(int IdEmpresa, int IdPosicion, int IdProcesoProductivo) 
        {
            try
            {
                prd_EtapaProduccion_Info Info = new prd_EtapaProduccion_Info();
                EntitiesRoles Oent= new EntitiesRoles();

                string Query = "select * from prd_EtapaProduccion where IdProcesoProductivo = "+IdProcesoProductivo+" and IdEmpresa = "+IdEmpresa+" and Posicion = "+IdPosicion;
                var Consulta = Oent.Database.SqlQuery<prd_EtapaProduccion_Info>(Query);
                if(Consulta!=null)
                    Info = Consulta.First();

                return Info;
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

        public List<prd_EtapaProduccion_Info> EtapaMaxObra(string CodObra, ref string msg)
        {
            try
            {
                List<prd_EtapaProduccion_Info> etapa = new List<prd_EtapaProduccion_Info>();

                string Query = "select top 1 ob.CodObra,et.IdEtapa,et.Posicion,et.IdProcesoProductivo "
                        + "from prd_EtapaProduccion et "
                        + "inner join prd_ProcesoProductivo pp "
                        + "on et.IdEmpresa = pp.IdEmpresa and et.IdProcesoProductivo = pp.IdProcesoProductivo "
                        + "inner join prd_ProcesoProductivo_x_prd_obra ob "
                        + "on pp.IdEmpresa = ob.IdEmpresa_obra and pp.IdProcesoProductivo = ob.IdProcesoProductivo "
                        + "where ob.CodObra = '" + CodObra.Trim() + "' order by et.Posicion desc";

                using (EntitiesProduccion oent = new EntitiesProduccion())
                {
                    var Consulta = oent.Database.SqlQuery<prd_EtapaProduccion_Info>(Query);


                    etapa = Consulta.ToList();
                }
                msg = "Consulta correcta.";
                return etapa;
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
