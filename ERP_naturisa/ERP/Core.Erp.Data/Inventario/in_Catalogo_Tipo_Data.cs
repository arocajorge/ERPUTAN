using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public class in_Catalogo_Tipo_Data
    {
        string mensaje = "";

        public List<in_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
                List<in_CatalogoTipo_Info> lst = new List<in_CatalogoTipo_Info>();
                EntitiesInventario  oEntImportacion = new EntitiesInventario();
            
            try
            {
                var select = from q in oEntImportacion.in_CatalogoTipo
                             select q;

                foreach (var item in select)
                {
                    in_CatalogoTipo_Info info = new in_CatalogoTipo_Info();
                    info.IdCatalogo_tipo = item.IdCatalogo_tipo;
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

        public Boolean GuardarDB(in_CatalogoTipo_Info Info,ref string Mensaje)
        {
            try
            {
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {

                    var registo = new in_CatalogoTipo();

                        registo.IdCatalogo_tipo = Info.IdCatalogo_tipo = GetIdCatalogo_Tipo();
                        registo.Descripcion = Info.Descripcion;
                        registo.Estado = "A";

                        oEnti.in_CatalogoTipo.Add(registo);
                        oEnti.SaveChanges();

                
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

        public Boolean ModificarDB(in_CatalogoTipo_Info inf)
        {
            try
            {
                using (EntitiesInventario  context = new EntitiesInventario())
                {
                    var contact = context.in_CatalogoTipo.FirstOrDefault(vanio => vanio.IdCatalogo_tipo == inf.IdCatalogo_tipo);
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

        public int GetIdCatalogo_Tipo()
        {
            int Id = 0;
            try
            {
                EntitiesInventario oEnti = new EntitiesInventario();

                var consulta = (from C in oEnti.in_CatalogoTipo
                                select C.IdCatalogo_tipo ).Max();

                Id = Convert.ToInt32(consulta) + 1;

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
