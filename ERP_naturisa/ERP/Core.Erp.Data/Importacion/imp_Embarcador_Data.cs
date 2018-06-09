using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Importacion
{
    public class imp_Embarcador_Data
    {
        string mensaje = "";
        public int GetId(int IdEmpresa)
        {
            try
            {
                int ID = 0;


                EntitiesImportacion oEntities = new EntitiesImportacion();
                var select = from q in oEntities.imp_Embarcador
                             where q.IdEmpresa == IdEmpresa
                             select q;
                if (select.ToList().Count < 1)
                {
                    ID = 1;
                }
                else
                {
                    var GetiD = (from q in oEntities.imp_Embarcador
                                 select q.IdEmbarcador).Max();

                    ID = Convert.ToInt32(GetiD.ToString()) + 1;
                }
                return ID;

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

        public List<imp_Embarcador_Info> Get_List_Embarcador() 
        {
                List<imp_Embarcador_Info> lst = new List<imp_Embarcador_Info>();
                EntitiesImportacion oEnt = new EntitiesImportacion();
            try
            {
                var select = from q in oEnt.imp_Embarcador
                             select q;
                foreach (var item in select)
                {
                    imp_Embarcador_Info info = new imp_Embarcador_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmbarcador = item.IdEmbarcador;
                    info.em_descripcion = item.em_descripcion.Trim(); ;
                    info.em_direccion = item.em_direccion;
                    info.em_telefono = item.em_telefono;
                    info.em_contacto = item.em_contacto;
                    info.em_email = item.em_email;
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

        public Boolean GuardarDB(ref imp_Embarcador_Info Info)
        {
            try
            {
                List<imp_Embarcador_Info> Lst = new List<imp_Embarcador_Info>();
                using (EntitiesImportacion Context = new EntitiesImportacion())
                {
                    var Address = new imp_Embarcador();

                    Info.IdEmbarcador =Address.IdEmbarcador = GetId(Info.IdEmpresa);
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.em_descripcion = Info.em_descripcion;
                    Address.em_direccion = Info.em_direccion;
                    Address.em_telefono = Info.em_telefono;
                    Address.em_contacto = Info.em_contacto;
                    Address.em_email = Info.em_email;
                    Address.Estado = "A";

                    Context.imp_Embarcador.Add(Address);
                    Context.SaveChanges();
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

        public imp_Embarcador_Info Get_Info_Embarcador(int IdEmpresa, int IdEmbarcador)
	    {
			    EntitiesImportacion oEnti= new EntitiesImportacion();
		        imp_Embarcador_Info Info = new imp_Embarcador_Info() ;
		    try
		    {
			    var Objeto = oEnti.imp_Embarcador.FirstOrDefault(var => var.IdEmpresa==IdEmpresa && var.IdEmbarcador == IdEmbarcador);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdEmbarcador = Objeto.IdEmbarcador;
                    Info.em_descripcion = Objeto.em_descripcion;
                    Info.em_direccion = Objeto.em_direccion;
                    Info.em_telefono = Objeto.em_telefono;
                    Info.em_contacto = Objeto.em_contacto;
                    Info.em_email = Objeto.em_email;
                    Info.Estado = Objeto.Estado;
                }
				return Info;
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

        public Boolean ModificarDB(imp_Embarcador_Info Info)
        {
            try
            {
                
                using (EntitiesImportacion Context = new EntitiesImportacion())
                {
                    var contact = Context.imp_Embarcador.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdEmbarcador == Info.IdEmbarcador);
                    if (contact != null)
                    {
                        contact.em_descripcion = Info.em_descripcion;
                        contact.em_direccion = Info.em_direccion;
                        contact.em_telefono = Info.em_telefono;
                        contact.em_contacto = Info.em_contacto;
                        contact.em_email = Info.em_email;
                        Context.SaveChanges();
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

        public Boolean AnularDB(imp_Embarcador_Info Info)
        {
            try
            {

                using (EntitiesImportacion Context = new EntitiesImportacion())
                {
                    var contact = Context.imp_Embarcador.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdEmbarcador == Info.IdEmbarcador);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        Context.SaveChanges();
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
