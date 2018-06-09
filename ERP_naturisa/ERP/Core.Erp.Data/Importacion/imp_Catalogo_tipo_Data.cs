using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Importacion
{
    public class imp_Catalogo_tipo_Data
    {
        string mensaje = "";
        public List<imp_Catalogo_tipo_info> Get_List_Catalogo_tipo()
        {
                List<imp_Catalogo_tipo_info> lst = new List<imp_Catalogo_tipo_info>();
                EntitiesImportacion oEntImportacion = new EntitiesImportacion();
            try
            {
                var select = from q in oEntImportacion.imp_catalogo_tipo
                             select q;

                foreach (var item in select)
                {
                    imp_Catalogo_tipo_info info = new imp_Catalogo_tipo_info();
                    info.IdCatalogoImport_tipo = item.IdCatalogoImport_tipo;
                    info.Descripcion = item.Descripcion;
                    info.Estado = item.Estado;

                    lst.Add(info);
                }
                return lst;
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

        public int GetId(imp_Catalogo_tipo_info inf)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    EntitiesImportacion EDB = new EntitiesImportacion();
                    var Q = (from per in EDB.imp_catalogo_tipo
                                select per.IdCatalogoImport_tipo).Max() + 1;

                    return Convert.ToInt32(Q);
                }
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

        public Boolean GrabarDB(imp_Catalogo_tipo_info inf)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    EntitiesImportacion EDB = new EntitiesImportacion();
                    var Q = (from per in EDB.imp_catalogo_tipo                           
                            select per.IdCatalogoImport_tipo).Max() + 1;
                    //if (Q.ToList().Count == 0)
                    //{
                        var address = new imp_catalogo_tipo();
                        address.IdCatalogoImport_tipo = Q;
                        address.Descripcion = inf.Descripcion;
                        address.Estado = "A";
                        context.imp_catalogo_tipo.Add(address);
                        context.SaveChanges();
                
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


        public Boolean ModificarDB(imp_Catalogo_tipo_info inf)
        {
            try
            {
                using (EntitiesImportacion context = new EntitiesImportacion())
                {
                    var contact = context.imp_catalogo_tipo.FirstOrDefault(vanio => vanio.IdCatalogoImport_tipo == inf.IdCatalogoImport_tipo);
                    if (contact != null)
                    {
                        contact.Descripcion = inf.Descripcion;
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
