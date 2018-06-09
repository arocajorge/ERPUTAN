using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo
{
   public class Af_Tipo_Depreciacion_Data
    {
        string mensaje = "";
        public List<Af_Tipo_Depreciacion_Info> Get_List_ActivoFijo(int idempresa)
        {
            List<Af_Tipo_Depreciacion_Info> lM = new List<Af_Tipo_Depreciacion_Info>();
            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Tipo_Depreciacion
                             select A;

                foreach (var item in select)
                {
                    Af_Tipo_Depreciacion_Info info = new Af_Tipo_Depreciacion_Info();
                    info.IdTipoDepreciacion = item.IdTipoDepreciacion;
                    info.cod_tipo_depreciacion = item.cod_tipo_depreciacion;
                    info.nom_tipo_depreciacion = item.nom_tipo_depreciacion;
                    info.estado = item.estado;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod = item.Fecha_UltMod;
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu = item.Fecha_UltAnu;
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

       public int Get_IdTipoDepre(string CodTipoDepreciacion)
        {
            try
            {
                int IdTipoDepreciaion = 0;
                List<Af_Tipo_Depreciacion_Info> lM = new List<Af_Tipo_Depreciacion_Info>();
                using (EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo())
                {
                    var select = from A in OEPActivoFijo.Af_Tipo_Depreciacion
                                 where A.cod_tipo_depreciacion == CodTipoDepreciacion
                                 select A;

                    foreach (var item in select)
                    {
                        IdTipoDepreciaion = item.IdTipoDepreciacion;                       
                    }
                }
                return IdTipoDepreciaion;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

       public Boolean ModificarDB(Af_Tipo_Depreciacion_Info info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Tipo_Depreciacion.FirstOrDefault(obj => obj.IdTipoDepreciacion == info.IdTipoDepreciacion);
                    if (contact != null)
                    {
                        contact.cod_tipo_depreciacion = info.cod_tipo_depreciacion;
                        contact.nom_tipo_depreciacion = info.nom_tipo_depreciacion;
                        contact.estado = info.estado;
                        contact.IdUsuario = info.IdUsuario;
                        contact.Fecha_Transac = info.Fecha_Transac;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Activo Fijo #: " + info.IdTipoDepreciacion.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(Af_Tipo_Depreciacion_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {                  
                    Af_Tipo_Depreciacion address = new Af_Tipo_Depreciacion();
                    int idpv = GetId();
                    id = idpv;
                    address.IdTipoDepreciacion = idpv;
                    address.cod_tipo_depreciacion = info.cod_tipo_depreciacion;
                    address.nom_tipo_depreciacion = info.nom_tipo_depreciacion;
                    address.estado = info.estado;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    address.Fecha_UltMod = info.Fecha_UltMod;
                    address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    address.Fecha_UltAnu = info.Fecha_UltAnu;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Fecha_Transac = DateTime.Now;
                    address.estado = "A";

                    context.Af_Tipo_Depreciacion.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Activo Fijo #: " + id.ToString() + " exitosamente.";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(Af_Tipo_Depreciacion_Info info, ref  string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Tipo_Depreciacion.FirstOrDefault(obj => obj.IdTipoDepreciacion == info.IdTipoDepreciacion);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro del Activo Fijo #: " + info.IdTipoDepreciacion.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
               
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId()
        {
            try
            {
                int Id;
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Tipo_Depreciacion
                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_Tipo_Depreciacion
                                     select q.IdTipoDepreciacion).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_Tipo_Depreciacion_Data()
        {
            try
            {

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
