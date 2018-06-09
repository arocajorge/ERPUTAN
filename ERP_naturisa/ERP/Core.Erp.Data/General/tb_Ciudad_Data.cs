using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
 public class tb_Ciudad_Data
    {

        string mensaje = "";
        public Boolean Guardar_DB(tb_ciudad_Info Info_Ciu, ref string IdCiudad, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var Address = new tb_ciudad();
                    Address.IdCiudad = Info_Ciu.IdCiudad = IdCiudad = GetId();
                    Address.Cod_Ciudad = (Info_Ciu.CodCiudad == "" || Info_Ciu.CodCiudad == null) ? "Ciud_" + Info_Ciu.IdCiudad : Info_Ciu.CodCiudad;
                    Address.Descripcion_Ciudad = Info_Ciu.Descripcion;
                    Address.Estado = "A";
                    Address.IdProvincia = Info_Ciu.IdProvincia;

                    Address.IdUsuario = Info_Ciu.IdUsuario;
                    Address.Fecha_Transac = Info_Ciu.Fecha_Transac;
                    Address.nom_pc = Info_Ciu.nom_pc;
                    Address.ip = Info_Ciu.ip;

                    Context.tb_ciudad.Add(Address);
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

        public string GetId()
        {
            try
            {
                string Id;
                EntitiesGeneral ocxc = new EntitiesGeneral();
                var select = (from q in ocxc.tb_ciudad
                              select q);

                if (select.ToList().Count == 0)
                {
                    Id = Convert.ToString(1);
                }
                else
                {
                    var select_pv = (from q in ocxc.tb_ciudad
                                     select q.IdCiudad).Max();

                    Id = Convert.ToString(Convert.ToInt32(select_pv.ToString()) + 1);
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

        public Boolean Modificar_DB(tb_ciudad_Info Info_Ciu, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var contact = Context.tb_ciudad.FirstOrDefault(af => af.IdCiudad == Info_Ciu.IdCiudad);
                    if (contact != null)
                    {
                        contact.Cod_Ciudad = Info_Ciu.CodCiudad;
                        contact.Descripcion_Ciudad = Info_Ciu.Descripcion;
                        contact.IdProvincia = Info_Ciu.IdProvincia;
                        contact.IdUsuarioUltMod = Info_Ciu.IdUsuarioUltMod;
                        contact.Fecha_UltMod = Info_Ciu.Fecha_UltMod;
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


        public Boolean Anular_DB(tb_ciudad_Info Info_Ciu, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var contact = Context.tb_ciudad.FirstOrDefault(af => af.IdCiudad == Info_Ciu.IdCiudad);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = Info_Ciu.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info_Ciu.Fecha_UltAnu;
                        contact.MotivoAnula = Info_Ciu.MotivoAnula;
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

        public List<tb_ciudad_Info> Get_List_Ciudad(string IdProvincia)
     {                 
         try
         {
             List<tb_ciudad_Info> lstCiudad = new List<tb_ciudad_Info>(); 

             using (EntitiesGeneral Base = new EntitiesGeneral())
             {
                 var vciudad = from c in Base.vwtb_Ciudad
                               where c.IdProvincia.StartsWith(IdProvincia)
                               select c;
                 foreach (var item in vciudad)
                 {
                     tb_ciudad_Info infoCiudad = new tb_ciudad_Info();
                     infoCiudad.CodCiudad = item.Cod_Ciudad;
                     infoCiudad.IdCiudad = item.IdCiudad;
                     infoCiudad.Descripcion = item.Descripcion_Ciudad;
                     infoCiudad.Estado = item.Estado;
                     infoCiudad.IdProvincia = item.IdProvincia;
                     infoCiudad.IdPais = item.IdPais;
                     lstCiudad.Add(infoCiudad);
                 }
             }
             return lstCiudad;
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

        public List<tb_ciudad_Info> Get_List_Ciudad()
        {
            try
            {
                List<tb_ciudad_Info> lstCiudad = new List<tb_ciudad_Info>();

                using (EntitiesGeneral Base = new EntitiesGeneral())
                {
                    var vciudad = from c in Base.vwtb_Ciudad
                                  select c;
                    foreach (var item in vciudad)
                    {
                        tb_ciudad_Info infoCiudad = new tb_ciudad_Info();
                        infoCiudad.CodCiudad = item.Cod_Ciudad;
                        infoCiudad.IdCiudad = item.IdCiudad;
                        infoCiudad.Descripcion = item.Descripcion_Ciudad;
                        infoCiudad.Estado = item.Estado;
                        infoCiudad.IdProvincia = item.IdProvincia;
                        infoCiudad.IdPais = item.IdPais;
                        lstCiudad.Add(infoCiudad);
                    }
                }
                return lstCiudad;
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

        public tb_ciudad_Info Get_Info_Ciudad(string IdCiudad)
     {
         try
         {
             tb_ciudad_Info infoCiudad = new tb_ciudad_Info();

             using (EntitiesGeneral Base = new EntitiesGeneral())
             {
                 var vciudad = from c in Base.vwtb_Ciudad
                               where c.IdCiudad == IdCiudad
                               select c;
                 foreach (var item in vciudad)
                 {
                     infoCiudad = new tb_ciudad_Info();
                     infoCiudad.CodCiudad = item.Cod_Ciudad;
                     infoCiudad.IdCiudad = item.IdCiudad;
                     infoCiudad.Descripcion = item.Descripcion_Ciudad;
                     infoCiudad.Estado = item.Estado;
                     infoCiudad.IdProvincia = item.IdProvincia;
                     infoCiudad.IdPais = item.IdPais;
                 }
             }
             return infoCiudad;
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
