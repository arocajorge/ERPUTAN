using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
   public class fa_catalogo_tipo_Data
   {
       string mensaje = "";

       public List<fa_catalogo_tipo_Info> Get_List_catalogo_tipo()
        {
            try
            {
                List<fa_catalogo_tipo_Info> Lst = new List<fa_catalogo_tipo_Info>();
                EntitiesFacturacion oEnti = new EntitiesFacturacion();

                var Query = from q in oEnti.fa_catalogo_tipo
                            select q;

                foreach (var item in Query)
                {
                    fa_catalogo_tipo_Info Obj = new fa_catalogo_tipo_Info();
                    Obj.IdCatalogo_tipo = item.IdCatalogo_tipo;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Estado = item.Estado;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(int Cod)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var Existe = from q in context.fa_catalogo_tipo
                             where q.IdCatalogo_tipo == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }


        public Boolean GuardarDB(fa_catalogo_tipo_Info Info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var Address = new fa_catalogo_tipo();

                    Address.IdCatalogo_tipo = Info.IdCatalogo_tipo;
                    Address.Descripcion = Info.Descripcion;
                    Address.Estado ="A";

                    Context.fa_catalogo_tipo.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(fa_catalogo_tipo_Info info)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();

                var contenido = context.fa_catalogo_tipo.FirstOrDefault(var => var.IdCatalogo_tipo == info.IdCatalogo_tipo);
                if (contenido != null)
                {
                    contenido.Descripcion = info.Descripcion;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public fa_catalogo_tipo_Info Get_Info_catalogo_tipo(int id)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                fa_catalogo_tipo_Info fa_cata_Info = new fa_catalogo_tipo_Info();

                var contenido = context.fa_catalogo_tipo.FirstOrDefault(var => var.IdCatalogo_tipo == id);

                if (contenido != null)
                {
                    fa_cata_Info.IdCatalogo_tipo = contenido.IdCatalogo_tipo;
                    fa_cata_Info.Descripcion = contenido.Descripcion;
                }

                return fa_cata_Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
