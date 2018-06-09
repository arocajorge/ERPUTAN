using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_CatalogoTipo_Data
    {
        string mensaje = "";
        //Obtiene lista Tipo cata
        public List<tb_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {

            try
            {

                List<tb_CatalogoTipo_Info> lista = new List<tb_CatalogoTipo_Info>();
                EntitiesGeneral OCatalogo = new EntitiesGeneral();
                var Doc = from C in OCatalogo.tb_CatalogoTipo
                          select C;


                foreach (var item in Doc)
                {
                    tb_CatalogoTipo_Info info = new tb_CatalogoTipo_Info();
                    info.IdTipoCatalogo = item.IdTipoCatalogo;
                    info.Codigo = item.Codigo;
                    info.tc_Descripcion = item.tc_Descripcion;
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

        //Agregar un nuevo item a la tabla catalogo segun tipo
        public Boolean GrabaDB(tb_CatalogoTipo_Info info, ref string msg, ref int IdCatalogoTipo)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var existe = (from q in context.tb_CatalogoTipo
                                 where q.Codigo == info.Codigo
                                 select q).Count();

                    if(existe !=0) 
                    {
                        msg = "El Codigo Ingresado ya existe Por Favor Ingresar uno distinto";
                        return false ;
                    }

                    //var contact = tb_CatalogoTipo.Createtb_CatalogoTipo(0);
                    tb_CatalogoTipo address = new tb_CatalogoTipo();
                    int Tipo = IdCatalogoTipo= GetId();
                    address.IdTipoCatalogo = Tipo;
                    address.tc_Descripcion = info.tc_Descripcion;
                    address.Codigo = info.Codigo;
                    //contact = address;
                    context.tb_CatalogoTipo.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del catalogo #: " + Tipo.ToString();
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
                msg = "Error no se grabó ";
                throw new Exception(ex.ToString());
            }
        }

        //Modifica un item de la tabla catalogo segun tipo

        public Boolean ModificaDB(tb_CatalogoTipo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_CatalogoTipo.FirstOrDefault(obj => obj.IdTipoCatalogo == info.IdTipoCatalogo);
                    if (contact != null)
                    {
                        contact.tc_Descripcion = info.tc_Descripcion;
                        context.SaveChanges();
                        msg = "Se ha procedido a Actualizar el registro del tipo catalogo #: " + info.IdTipoCatalogo.ToString();
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
                msg = "Error no se grabó ";
                throw new Exception(ex.ToString());
            }
        }

        //obtener id de item catalogo segun tipo
        public int GetId()
        {
            try
            {
                    int Id;
                EntitiesGeneral OECatalogo = new EntitiesGeneral();
                var select = from q in OECatalogo.tb_CatalogoTipo
                             select q;

                if (select == null)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OECatalogo.tb_CatalogoTipo
                                     select q.IdTipoCatalogo).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_CatalogoTipo_Data() { }
    }
}
