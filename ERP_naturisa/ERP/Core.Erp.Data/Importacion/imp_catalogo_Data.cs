using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Importacion
{
    public    class imp_catalogo_Data
    {
        string mensaje = "";
        public List<imp_catalogo_Info> Get_List_catalogo() 
        {
                List<imp_catalogo_Info> lista = new List<imp_catalogo_Info>();
                EntitiesImportacion oEnt = new EntitiesImportacion();
            try
            {
                var select = from q in oEnt.imp_catalogo
                             select q;

                foreach (var item in select)
                {
                    imp_catalogo_Info info = new imp_catalogo_Info();


                    info.IdCatalogoImport = item.IdCatalogoImport.Trim();
                    info.IdCatalogoImport_tipo = item.IdCatalogoImport_tipo;
                    info.Nombre = item.Nombre.Trim();
                    info.NombreIngles = item.NombreIngles;
                    info.Orden = item.Orden;
                    info.Estado = item.Estado;
                    info.Abrebiatura = item.Abrebiatura;
                    lista.Add(info);                    
                }

                return lista;
                    
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(imp_catalogo_Info info)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_catalogo.FirstOrDefault(catalogo => catalogo.IdCatalogoImport == info.IdCatalogoImport && catalogo.IdCatalogoImport_tipo == info.IdCatalogoImport_tipo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(imp_catalogo_Info info, ref string  Mensaje)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    EntitiesImportacion EDB = new EntitiesImportacion();
                    var Q = (from per in EDB.imp_catalogo
                             select per.Orden).Max() + 1;


                    if ((from per in EDB.imp_catalogo where per.IdCatalogoImport == info.IdCatalogoImport select per).Count() != 0) 
                    {
                        Mensaje = "El Codigo Ingresado Ya existe por favor ingrese uno distinto";
                        return false;
                    }
                    var address = new imp_catalogo();
                    address.IdCatalogoImport = info.IdCatalogoImport;
                    address.IdCatalogoImport_tipo = info.IdCatalogoImport_tipo;
                    address.Nombre = info.Nombre;
                    address.NombreIngles = info.NombreIngles;
                    address.Abrebiatura = info.Abrebiatura;
                    address.Orden = Q;
                    address.Estado = "A";

                    context.imp_catalogo.Add(address);
                    context.SaveChanges();
                    Mensaje = "Registro Ingresado Correctamente";
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
                mensaje = ex.ToString() + " " + ex.Message;

                Mensaje = "Error al ingresar el registro ";
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(imp_catalogo_Info info)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_catalogo.FirstOrDefault(cata => cata.IdCatalogoImport == info.IdCatalogoImport && cata.IdCatalogoImport_tipo == info.IdCatalogoImport_tipo);
                    if (contact != null)
                    {
                        contact.IdCatalogoImport = info.IdCatalogoImport;
                        contact.IdCatalogoImport_tipo = info.IdCatalogoImport_tipo;
                        contact.Nombre = info.Nombre;
                        contact.NombreIngles = info.NombreIngles;
                        contact.Abrebiatura = info.Abrebiatura;
                        //contact.Orden = Q;
                        //contact.Estado = "A";
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
