using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoMaterialesDisponibles_Data
    {
        string mensaje = "";

        public int GetId(int IdEmpresa, ref string mensaje)
        {
            try
            {
                int Id;
                EntitiesCompras_Edehsa OEProd = new EntitiesCompras_Edehsa();
                var select = from q in OEProd.com_ListadoMaterialesDisponibles
                             where q.IdEmpresa == IdEmpresa

                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProd.com_ListadoMaterialesDisponibles
                                     where q.IdEmpresa == IdEmpresa

                                     select q.IdListadoMaterialesDisponibles).Max();
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

        public Boolean AnularDB(com_ListadoMaterialesDisponibles_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var address = context.com_ListadoMaterialesDisponibles.First
                        (A => A.IdEmpresa == Info.IdEmpresa
                             && A.IdListadoMaterialesDisponibles == Info.IdListadoMaterialesDisponibles
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

        public Boolean GrabarDB(com_ListadoMaterialesDisponibles_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var address = new com_ListadoMaterialesDisponibles();
                    int idEmp = GetId(info.IdEmpresa, ref mensaje);
                    id = idEmp;

                    address.IdListadoMaterialesDisponibles = id;
                    address.IdEmpresa = info.IdEmpresa;
                    address.ot_IdSucursal = info.IdSucursal;
                    address.CodObra = info.CodObra;
                  
                    address.FechaReg = info.FechaReg;
                    address.Estado = info.Estado;
                    address.Usuario = info.Usuario;
                    address.Motivo = info.Motivo.Trim();
                    address.lm_Observacion = info.lm_Observacion;

                    context.com_ListadoMaterialesDisponibles.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el Listado de Materiales #: " + id.ToString() + " exitosamente.";
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

        public Boolean ModificarDB(com_ListadoMaterialesDisponibles_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_Edehsa context = new EntitiesCompras_Edehsa())
                {
                    var contact = context.com_ListadoMaterialesDisponibles.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa
                        && obj.IdListadoMaterialesDisponibles == info.IdListadoMaterialesDisponibles);


                    if (contact != null)
                    {
                        contact.FechaReg = info.FechaReg;
                        contact.Motivo = info.Motivo;
                        contact.Usuario = info.Usuario;
                        contact.lm_Observacion = info.lm_Observacion;
                        contact.Estado = info.Estado;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar elListado de Materiales #: " + info.IdListadoMaterialesDisponibles.ToString() + " exitosamente.";
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

        public List<com_ListadoMaterialesDisponibles_Info> Get_List_ListadoMaterialesDisponibles(int idempresa)
        {

            List<com_ListadoMaterialesDisponibles_Info> Lst = new List<com_ListadoMaterialesDisponibles_Info>();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var Query = from q in oEnti.vwcom_ListadoMaterialesDisponibles
                            where q.IdEmpresa == idempresa
                            select q;
                foreach (var item in Query)
                {

                    com_ListadoMaterialesDisponibles_Info Obj = new com_ListadoMaterialesDisponibles_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdListadoMaterialesDisponibles = item.IdListadoMaterialesDisponibles;
                    Obj.IdSucursal = item.IdSucursal;
                   
                    Obj.FechaReg = item.FechaReg;
                    Obj.Estado = item.Estado;
                    Obj.ob_descripcion = "[" + item.CodObra + "] " + item.ob_descripcion;
                    
                    Obj.lm_Observacion = item.lm_Observacion;
                    Obj.CodObra = item.CodObra;
                    Obj.Usuario = item.Usuario;
                    Obj.Motivo = item.Motivo;
                    Obj.su_descripcion = item.Su_Descripcion;

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

        public com_ListadoMaterialesDisponibles_Info Get_List_ListadoMaterialesDisponibles(int idempresa, decimal idLstMater)
        {
            com_ListadoMaterialesDisponibles_Info info = new com_ListadoMaterialesDisponibles_Info();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var select = from A in oEnti.vwcom_ListadoMaterialesDisponibles
                             where A.IdEmpresa == idempresa
                             && A.IdListadoMaterialesDisponibles == idLstMater

                             select A;

                foreach (var item in select)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    
                    info.IdListadoMaterialesDisponibles = item.IdListadoMaterialesDisponibles;
                    info.FechaReg = item.FechaReg;
                    info.Estado = item.Estado;
                    info.ob_descripcion = item.ob_descripcion;
                    
                    info.lm_Observacion = item.lm_Observacion;
                    info.su_descripcion = item.Su_Descripcion;
                    info.CodObra = item.CodObra;
                    info.Motivo = item.Motivo;
                    info.Usuario = item.Usuario;
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

        public com_ListadoMaterialesDisponibles_Info Get_Info_ListadoMaterialesDisponibles(int idempresa, decimal idLstMater)
        {
            com_ListadoMaterialesDisponibles_Info info = new com_ListadoMaterialesDisponibles_Info();
            EntitiesCompras_Edehsa oEnti = new EntitiesCompras_Edehsa();
            try
            {
                var select = from A in oEnti.vwcom_ListadoMaterialesDisponibles
                             where A.IdEmpresa == idempresa
                             && A.IdListadoMaterialesDisponibles == idLstMater

                             select A;

                foreach (var item in select)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    
                    info.IdListadoMaterialesDisponibles = item.IdListadoMaterialesDisponibles;
                    info.FechaReg = item.FechaReg;
                    info.Estado = item.Estado;
                    info.ob_descripcion = item.ob_descripcion;
                    
                    info.lm_Observacion = item.lm_Observacion;
                    info.su_descripcion = item.Su_Descripcion;
                    info.CodObra = item.CodObra;
                    info.Motivo = item.Motivo;
                    info.Usuario = item.Usuario;
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
