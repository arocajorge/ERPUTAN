using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Compras;


namespace Core.Erp.Data.Produc_Cirdesus
{
   public class prd_CotizacionCompras_Data
    {
        string mensaje = "";
        public List<prd_CotizacionCompras_Info> ObtenerListaCotiza(int IdEmpresa, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    string Query = "declare @IdEmpresa int = " + IdEmpresa +
                        "select * from prd_Obra where CodObra not in(select CodObra from prd_ProcesoProductivo_x_prd_obra where " +
                        " IdProcesoProductivo not in (select IdProcesoProductivo from prd_ProcesoProductivo where IdEmpresa ="
                        + IdEmpresa + " and Estado = 'I') and IdEmpresa = " + IdEmpresa + ") and IdEmpresa =" + IdEmpresa;

                    msg = "Proceso exitoso";
                    //return context.ExecuteStoreQuery<prd_CotizacionCompras_Info>(Query).ToList();

                    return new List<prd_CotizacionCompras_Info>();
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

        public List<prd_CotizacionCompras_Info> ObtenerListaCotizacion(int IdEmpresa)
        {
            try
            {
                List<prd_CotizacionCompras_Info> lm = new List<prd_CotizacionCompras_Info>();
                EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
                var registros = from A in OEEtapa.prd_Obra
                                where A.IdEmpresa == IdEmpresa
                                orderby A.CodObra
                                select A;
                foreach (var item in registros)
                {
                    prd_CotizacionCompras_Info info = new prd_CotizacionCompras_Info();
           
                    info.IdEmpresa = item.IdEmpresa;
                 
                    
                    info.Observacion = item.Estado;
                   

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

        //public prd_CotizacionCompras_Info ObtenerListaCotizacion(int IdEmpresa, string CodObra)
        //{
        //    try
        //    {
        //        EntitiesProduccion_Cidersus OEEtapa = new EntitiesProduccion_Cidersus();
        //        var registros = from A in OEEtapa.prd_Obra
        //                        where A.IdEmpresa == IdEmpresa && A.CodObra == CodObra
        //                        select A;
        //        if (registros.ToList().Count > 0)
        //        {
        //            prd_Obra_Info info = new prd_Obra_Info();
        //            foreach (var item in registros)
        //            {
        //                info.CodObra = item.CodObra;
        //                info.IdEmpresa = item.IdEmpresa;
        //                info.IdCentroCosto = item.IdCentroCosto;
        //                info.Descripcion = item.Descripcion;
        //                info.Estado = item.Estado;
        //                info.Fecha = item.Fecha;
        //                info.DetalleObra = "[" + item.CodObra.Trim() + "] - " + item.Descripcion.Trim();
        //            }
        //            //return info;
        //        }
        //        else
        //            return new prd_CotizacionCompras_Info();
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        mensaje = ex.ToString() + " " + ex.Message;
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        return new prd_CotizacionCompras_Info();
        //    }
        //}

        public decimal getId(int IdEmpresa)
        {
            decimal Id = 0;
            try
            {
                EntitiesCompras contex = new EntitiesCompras();
                var selecte = contex.com_cotizacion_compra.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.com_cotizacion_compra
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdCotizacion).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return 0;
            }
        }

        public Boolean GuardarDB(prd_CotizacionCompras_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {

                    var Address = new com_cotizacion_compra();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdCotizacion = getId(info.IdEmpresa);
                    Address.IdSucursal = info.IdSucursal;
                    Address.Observacion = info.Observacion;

                    Context.com_cotizacion_compra.Add(Address);
                    Context.SaveChanges();


                    //grbar detalle



                }
                msg = "Grabación exitosa..";
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



        public Boolean ModificarDB(prd_CotizacionCompras_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var contact = Context.prd_Obra.FirstOrDefault(A => A.IdEmpresa == info.IdEmpresa && A.IdEmpresa == info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.Estado = info.Observacion;
                        Context.SaveChanges();
                        msg = "Grabación exitosa..";
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

        public Boolean VerificarExisteCodigo(string CodObra)
        {
            try
            {

                EntitiesCompras oen = new EntitiesCompras();

                var select = from q in oen.com_ListadoMateriales_Det
                             where q.CodObra == CodObra
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
       
        public prd_CotizacionCompras_Info ObtenerUnaCotiza(int IdEmpresa, string CodObra)
        {
            throw new NotImplementedException();
        }
    }
}
