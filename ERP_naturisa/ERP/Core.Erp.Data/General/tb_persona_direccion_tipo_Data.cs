using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{

   public class tb_persona_direccion_tipo_Data
    {
        string mensaje = "";



        public Boolean GuardarDB(tb_persona_direccion_tipo_Info Info, ref int IdTipoDireccion, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = new tb_persona_direccion_tipo();
                    Address.IdTipoDireccion = Info.IdTipoDireccion = IdTipoDireccion = GetId();
                    Address.nom_TipoDireccion = Info.nom_TipoDireccion;
                    
                    Context.tb_persona_direccion_tipo.Add(Address);
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
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId()
        {
            try
            {
                int Id;
                EntitiesGeneral ocxc = new EntitiesGeneral();
                var select = (from q in ocxc.tb_persona_direccion_tipo
                              select q);

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in ocxc.tb_persona_direccion_tipo
                                     select q.IdTipoDireccion).Max();

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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_persona_direccion_tipo_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var contact = Context.tb_persona_direccion_tipo.FirstOrDefault
                        (af => af.IdTipoDireccion == Info.IdTipoDireccion);

                    if (contact != null)
                    {
                        contact.nom_TipoDireccion = Info.nom_TipoDireccion;
    
                        
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
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<tb_persona_direccion_tipo_Info> ListInfo, ref string msjError)
        {
            try
            {
                foreach (var item in ListInfo)
                {
                    ModificarDB(item, ref msjError);
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
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }


        public List<tb_persona_direccion_tipo_Info> Get_List_persona_direccion()
        {
            try
            {
                List<tb_persona_direccion_tipo_Info> lstPais = new List<tb_persona_direccion_tipo_Info>();
                EntitiesGeneral objEnti = new EntitiesGeneral();

                var pais = from p in objEnti.tb_persona_direccion_tipo
                           select p;

                foreach (var item in pais)
                {
                    tb_persona_direccion_tipo_Info info = new tb_persona_direccion_tipo_Info();
                    info.IdTipoDireccion = item.IdTipoDireccion;
                    info.nom_TipoDireccion = item.nom_TipoDireccion;
                    lstPais.Add(info);
                }

                return lstPais;
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

        public tb_persona_direccion_tipo_Info Get_Info_persona_direccion(decimal IdTipoDireccion)
        {
            try
            {
                tb_persona_direccion_tipo_Info info = new tb_persona_direccion_tipo_Info();
                EntitiesGeneral objEnti = new EntitiesGeneral();

                var pais = from p in objEnti.tb_persona_direccion_tipo
                           where p.IdTipoDireccion == IdTipoDireccion
                           select p;

                foreach (var item in pais)
                {
                    info = new tb_persona_direccion_tipo_Info();
                    info.IdTipoDireccion = item.IdTipoDireccion;
                    info.nom_TipoDireccion = item.nom_TipoDireccion;
                    
                }

                return info;
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
