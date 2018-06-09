using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_Conversion_CusCidersus_Data
    {
        string mensaje = "";

         int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_Conversion_CusCidersus
                             where q.IdEmpresa == IdEmpresa 
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_Conversion_CusCidersus
                                     where q.IdEmpresa == IdEmpresa 
                                     select q.IdConversion).Max();
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
        
        public Boolean GuardarDB(prd_Conversion_CusCidersus_Info Info, ref Decimal Id, ref String Mensaje )
        {
            try
            {
                List<prd_Conversion_CusCidersus_Info> Lst = new List<prd_Conversion_CusCidersus_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                    var Address = new prd_Conversion_CusCidersus();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdConversion = Id =GetId(Info.IdEmpresa);
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdBodega = Info.IdBodega;
                    Address.CodObra = Info.CodObra;
                    Address.IdOrdenTaller = Info.IdOrdenTaller;
                    Address.IdEtapa = Info.IdEtapa;
                    Address.CodBarraProducto = Info.CodBarraProducto;
                    Address.NomProducto = Info.NomProducto;
                    Address.Fecha = Info.Fecha;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_transaccion = Info.Fecha_transaccion;
                    Address.IdGrupoTrabajo = Info.IdGrupoTrabajo;
                    Address.Estado = "A";
                    Address.Observacion = Info.Observacion;

                    Context.prd_Conversion_CusCidersus.Add(Address);
                    Context.SaveChanges();

                    prd_Conversion_det_CusCidersus_Data DataDeta = new prd_Conversion_det_CusCidersus_Data();

                    Info.ListDetalle.ForEach(var => var.IdConversion = Address.IdConversion);
                    if (DataDeta.GuardarDB(Info.ListDetalle, ref Mensaje))
                    {
                      
                        Mensaje = "Se guardado Correctamente el registro # " + Id;  return true;
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
                Mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public List<prd_Conversion_CusCidersus_Info> ConsultaGeneral(int IdEmpresa, DateTime FechaIn, DateTime FechaFin) 
        {
            try
            {
                DateTime Fi =Convert.ToDateTime( FechaIn.ToShortDateString());
                DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<prd_Conversion_CusCidersus_Info> lista = new List<prd_Conversion_CusCidersus_Info>();
                prd_Conversion_CusCidersus_Info Info = null;
                EntitiesProduccion_Cidersus  Oent= new EntitiesProduccion_Cidersus();
                var Query = from C in Oent.vwprd_ConversionProCuscidersus
                            where C.cm_fecha >= Fi
                            && C.cm_fecha <= Ff
                            && C.IdMovi_inven_tipo==3
                            select C;

                foreach (var item in Query)
                {
                    Info = new prd_Conversion_CusCidersus_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdBodega = item.IdBodega;
                    Info.IdOrdenTaller =Convert.ToDecimal( item.ot_IdOrdenTaller);
                    Info.CodObra = item.ot_CodObra;
                   // Info.OrdenTallernom = item.Observacion;
                    Info.NomProducto = item.pr_descripcion;
                   // Info.Obra = item.Descripcion;
                    Info.IdMovi_inven_Tipo = item.IdMovi_inven_tipo;
                    Info.IdNumMov = item.IdNumMovi;
                    Info.Fecha = item.cm_fecha;
                    item.Estado = item.Estado;
                   // Info.Observacion = item.cm_observacion;
                    lista.Add(Info);
                    
                }
               

                return lista;
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

        public Boolean Anular(prd_Conversion_CusCidersus_Info Info, ref String Mensaje)
        {
            try
            {
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {

                    var Contact = Context.prd_Conversion_CusCidersus.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdConversion == Info.IdConversion);
                    if (Contact != null)
                    {
                        Contact.Estado = "I";
                        Contact.IdUsuarioAnu = Info.IdUsuarioAnu;
                        Contact.Fecha_transaccion = Info.Fecha_Anu;
                        Context.SaveChanges();

                        Mensaje = "Anulacion realizada Exitozamente";
                    }
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
    }
}
