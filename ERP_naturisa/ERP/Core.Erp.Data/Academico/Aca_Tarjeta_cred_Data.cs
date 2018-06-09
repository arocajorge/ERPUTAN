using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Academico
{
   public class Aca_Tarjeta_cred_Data
    {

       string MensajeError = "";

       public List<Aca_Tarjeta_cred_Info> Get_List_Tarjeta_cred()
        {
            try
            {
                List<Aca_Tarjeta_cred_Info> lista = new List<Aca_Tarjeta_cred_Info>();
                using (Entities_Academico DBBase = new Entities_Academico())
                {

                    var q = from C in DBBase.Aca_Tarjeta_cred
                            select C;

                    foreach (var item in q)
                    {
                        Aca_Tarjeta_cred_Info Info = new Aca_Tarjeta_cred_Info();

                        Info.IdTarjeta = item.IdTarjeta;
                        Info.CodTarjeta = item.CodTarjeta;
                        Info.nom_tarjeta = item.nom_tarjeta;
                        Info.estado = item.estado;
                        Info.porc_comision = item.porc_comision;
                        
                        lista.Add(Info);
                    }

                }

                return lista;

            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);

            }
        }


        public Boolean GrabarDB(Aca_Tarjeta_cred_Info info,ref Int32 IdTarjeta, ref string MensajeError)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    Entities_Academico EDB = new Entities_Academico();
                    var Q = from per in EDB.Aca_Tarjeta_cred
                            where per.IdTarjeta == info.IdTarjeta
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        var address = new Aca_Tarjeta_cred();

                        address.IdTarjeta = info.IdTarjeta = IdTarjeta = GetId(ref MensajeError);
                        address.CodTarjeta = (info.CodTarjeta == "") ? "" : info.CodTarjeta;
                        address.nom_tarjeta = (info.nom_tarjeta == "") ? "" : info.nom_tarjeta;
                        address.estado = (info.estado == "") ? "" : info.estado;
                        address.porc_comision = info.porc_comision;
                        address.FechaCreacion = DateTime.Now;
                        address.UsuarioCreacion = info.UsuarioCreacion;



                        context.Aca_Tarjeta_cred.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }


        public Int32 GetId(ref string MensajeError)
        {
            try
            {
                int Id;
                Entities_Academico base_ = new Entities_Academico();

                var q = from C in base_.Aca_Tarjeta_cred
                        select C;

                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from CbtCble in base_.Aca_Tarjeta_cred
                                   select CbtCble.IdTarjeta).Max();
                    Id = select_ + 1;

                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }


        public bool ActualizarDB(Aca_Tarjeta_cred_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {

                    var vRubro = Base.Aca_Tarjeta_cred.FirstOrDefault(j => j.IdTarjeta == info.IdTarjeta);

                    if (vRubro != null)
                    {
                        vRubro.CodTarjeta = string.IsNullOrEmpty(info.CodTarjeta) ? info.IdTarjeta.ToString() : info.CodTarjeta == "0" ? info.IdTarjeta.ToString() : info.CodTarjeta;
                        vRubro.nom_tarjeta = info.nom_tarjeta;
                        vRubro.estado = info.estado;
                        vRubro.porc_comision = info.porc_comision;
                        vRubro.FechaModificacion = DateTime.Now;
                        vRubro.UsuarioModificacion = info.UsuarioModificacion;


                        Base.SaveChanges();
                        mensaje = "Se ha procedido actualizar  #: " + info.IdTarjeta.ToString() + " exitosamente.";
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(Aca_Tarjeta_cred_Info info, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Tarjeta_cred.FirstOrDefault(a => a.IdTarjeta == info.IdTarjeta);

                    if (address != null)
                    {
                        address.estado = "I";
                        address.FechaAnulacion = DateTime.Now;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        msg = "Se ha procedido anular la tarjeta #: " + info.IdTarjeta.ToString() + " exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
