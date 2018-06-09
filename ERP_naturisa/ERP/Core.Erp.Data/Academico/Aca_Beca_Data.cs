using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Academico
{
  public  class Aca_Beca_Data
    {


        #region "Get"

        public int GetId(int IdInstitucion)
        {
            int Id = 0;
            try
            {
                Entities_Academico Base = new Entities_Academico();
                int select = (from q in Base.Aca_Beca
                              where q.IdInstitucion == IdInstitucion
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Base.Aca_Beca
                                     where q.IdInstitucion == IdInstitucion
                                     select q.IdBeca).Max();
                    Id = Convert.ToInt32(select_as.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<Aca_Beca_Info> Get_List_Beca(int IdInstitucion)
        {
            List<Aca_Beca_Info> lstAspirante = new List<Aca_Beca_Info>();
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var vaspirante = from a in Base.Aca_Beca
                                     where a.IdInstitucion == IdInstitucion
                                     select a;

                    foreach (var item in vaspirante)
                    {
                        Aca_Beca_Info info = new Aca_Beca_Info();
                        info.IdInstitucion = item.IdInstitucion;
                        info.IdBeca = item.IdBeca;
                        info.nom_beca = item.nom_beca;
                        info.porcentaje = item.porcentaje;
                        info.estado = item.estado;
                        info.IdRubro = item.IdRubro;
                        lstAspirante.Add(info);
                    }

                }
                return lstAspirante;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                throw new Exception(ex.InnerException.ToString());
            }

        }
        #endregion

        #region "Insert,update, delete"
        public bool GrabarDB(Aca_Beca_Info Info, ref int IdBeca, ref string msj)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    try
                    {
                            Aca_Beca addressBeca = new Aca_Beca();

                            Info.IdBeca = IdBeca = GetId(Info.IdInstitucion);

                            addressBeca.IdInstitucion = Info.IdInstitucion;
                            addressBeca.IdBeca = Info.IdBeca;
                            addressBeca.nom_beca = Info.nom_beca;
                            addressBeca.porcentaje = Info.porcentaje;
                            addressBeca.estado = Info.estado;

                            addressBeca.Fecha_Transac = DateTime.Now;
                            addressBeca.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                            addressBeca.IdRubro = Info.IdRubro;
                            
                            context.Aca_Beca.Add(addressBeca);
                            context.SaveChanges();
                            msj = "Se ha procedido a grabar el Aspirante #: " + IdBeca.ToString() + " exitosamente.";

                            return true;
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                        msj = ex.InnerException + " " + ex.Message;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                msj = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ActualizarDB(Aca_Beca_Info info, ref string msj)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var iBeca = context.Aca_Beca.FirstOrDefault(obj => obj.IdInstitucion == info.IdInstitucion 
                        && obj.IdBeca == info.IdBeca);

                    if (iBeca != null)
                    {
                        iBeca.nom_beca = info.nom_beca;
                        iBeca.porcentaje = info.porcentaje;
                        iBeca.estado = info.estado;

                        iBeca.Fecha_UltMod = DateTime.Now;
                        iBeca.IdUsuarioUltMod = info.IdUsuarioUltMod;

                        context.SaveChanges();
                        msj = "Se ha procedido actualizar la beca #: " + info.IdBeca.ToString() + " exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msj = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                msj = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean AnularDB(Aca_Beca_Info info, ref string msj)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Beca.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdBeca == info.IdBeca);
                    if (address != null)
                    {
                        address.estado = "I";
                        address.FechaAnulacion = DateTime.Now;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        context.SaveChanges();
                        msj = "Se ha procedido anular  #: " + info.IdBeca.ToString() + " exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msj = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                msj = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        #endregion

    }
}
