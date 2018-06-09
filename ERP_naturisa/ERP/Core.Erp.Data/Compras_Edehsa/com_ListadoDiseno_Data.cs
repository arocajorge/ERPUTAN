using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoDiseno_Data
    {
        string mensaje = "";

        public int GetId(int IdEmpresa, ref string mensaje)
        {
            try
            {
                int Id;
                EntitiesCompras_Edehsa OEProd = new EntitiesCompras_Edehsa();
                var select = from q in OEProd.com_ListadoDiseno
                             where q.IdEmpresa == IdEmpresa

                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProd.com_ListadoDiseno
                                     where q.IdEmpresa == IdEmpresa

                                     select q.IdListadoDiseno).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(com_ListadoDiseno_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var address = context.com_ListadoDiseno.First
                        (A => A.IdEmpresa == Info.IdEmpresa
                             && A.IdListadoDiseno == Info.IdListadoDiseno
                            );

                    address.Estado = "I";
                    address.Usuario = Info.Usuario;
                    address.lm_Observacion = Info.lm_Observacion;
                    //contact = address;
                    context.SaveChanges();

                }
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Error no se guardó " + ex.Message + " ";
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GrabarDB(com_ListadoDiseno_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var address = new com_ListadoDiseno();
                    int idEmp = GetId(info.IdEmpresa, ref mensaje);
                    id = idEmp;

                    address.IdListadoDiseno = id;
                    address.IdEmpresa = info.IdEmpresa;
                    address.ot_IdSucursal = info.IdSucursal;
                    address.CodObra = info.CodObra;
                    //address.IdOrdenTaller = (decimal)info.IdOrdenTaller;
                    address.FechaReg = info.FechaReg;
                    address.Estado = info.Estado;
                    address.Usuario = info.Usuario;
                    address.Motivo = info.Motivo.Trim();
                    address.tipo_listado = info.tipo_listado;
                    address.lm_Observacion = info.lm_Observacion;

                    context.com_ListadoDiseno.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el Listado de Diseno #: " + id.ToString() + " exitosamente.";
                }
                return true;
            }
            //catch (Exception ex)
            //{
            //    string arreglo = ToString();
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
            //                        "", "", "", "", DateTime.Now);
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            //    mensaje = ex.InnerException + " " + ex.Message;

            //    msg = "Se ha producido el siguiente error: " + ex.Message;
            //    throw new Exception(ex.ToString());
            //}
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                } throw new Exception(dbEx.ToString());
            }
        }

        public Boolean ModificarDB(com_ListadoDiseno_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var contact = context.com_ListadoDiseno.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa
                        && obj.IdListadoDiseno == info.IdListadoDiseno);


                    if (contact != null)
                    {
                        contact.FechaReg = info.FechaReg;
                        contact.Motivo = info.Motivo;
                        contact.Usuario = info.Usuario;
                        contact.lm_Observacion = info.lm_Observacion;
                        contact.Estado = info.Estado;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar elListado de Diseno #: " + info.IdListadoDiseno.ToString() + " exitosamente.";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ListadoDiseno_Info> Get_List_ListadoDiseno(int idempresa)
        {

            List<com_ListadoDiseno_Info> Lst = new List<com_ListadoDiseno_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoDiseno
                            where q.IdEmpresa == idempresa
                            select q;


                //var selectCbtecble = from C in Oentities.in_Producto
                //                     join t in Oentities.in_ProductoTipo
                //                     on new { C.IdEmpresa, C.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }
                //                     where C.IdEmpresa == IdEmpresa
                //                     && t.EsProductoTerminado == "S"
                //                     select C;


                foreach (var item in Query)
                {

                    com_ListadoDiseno_Info Obj = new com_ListadoDiseno_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdListadoDiseno = item.IdListadoDiseno;
                    Obj.IdSucursal = item.IdSucursal;
                 
                    Obj.FechaReg = item.FechaReg;
                    Obj.Estado = item.Estado;
                    Obj.ob_descripcion = "[" + item.CodObra + "] " + item.ob_descripcion;

                    Obj.lm_Observacion = item.lm_Observacion;
                    Obj.CodObra = item.CodObra;
                    Obj.Usuario = item.Usuario;
                    Obj.Motivo = item.Motivo;
                    Obj.su_descripcion = item.Su_Descripcion;
                    Obj.tipo_listado = item.TipoListadoDiseno;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public List<com_ListadoDiseno_Info> Get_List_ListadoDisenoCMB(int idempresa, int IdSucursal, string CodObra)
        {

            List<com_ListadoDiseno_Info> Lst = new List<com_ListadoDiseno_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoDiseno
                            where q.IdEmpresa == idempresa && q.IdSucursal == IdSucursal && q.CodObra == CodObra
                            select q;

                foreach (var item in Query)
                {

                    com_ListadoDiseno_Info Obj = new com_ListadoDiseno_Info();

                    //Obj.IdEmpresa = item.IdEmpresa;
                    Obj.CodObra = item.CodObra;
                    Obj.IdListadoDiseno = item.IdListadoDiseno;
                   // Obj.IdSucursal = item.IdSucursal;
                  
                    //Obj.Estado = item.Estado;
                    //Obj.ob_descripcion = "[" + item.CodObra + "] " + item.ob_descripcion;

                    //Obj.lm_Observacion = item.lm_Observacion;
                    
                    //Obj.Usuario = item.Usuario;
                    //Obj.Motivo = item.Motivo;
                   // Obj.su_descripcion = item.Su_Descripcion;
                    Obj.TipoListadoDiseno = item.TipoListadoDiseno;
                    Obj.DetalleListadoDiseno = "[" + item.IdListadoDiseno + "] " + item.lm_Observacion + " "+ item.TipoListadoDiseno;
                    Obj.lm_Observacion = item.lm_Observacion;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }


        public com_ListadoDiseno_Info Get_Info_ListadoDiseno(int idempresa, decimal idLstMater)
        {
            com_ListadoDiseno_Info info = new com_ListadoDiseno_Info();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var select = from A in oEnti.vwcom_ListadoDiseno
                             where A.IdEmpresa == idempresa
                             && A.IdListadoDiseno == idLstMater

                             select A;

                foreach (var item in select)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    
                    info.IdListadoDiseno = item.IdListadoDiseno;
                    info.FechaReg = item.FechaReg;
                    info.Estado = item.Estado;
                    info.ob_descripcion = item.ob_descripcion;
                    
                    info.lm_Observacion = item.lm_Observacion;
                    info.su_descripcion = item.Su_Descripcion;
                    info.CodObra = item.CodObra;
                    info.Motivo = item.Motivo;
                    info.Usuario = item.Usuario;

                    info.DetalleListadoDiseno = "[" + item.IdListadoDiseno + "] - " + item.TipoListadoDiseno.Trim();
                }
                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
