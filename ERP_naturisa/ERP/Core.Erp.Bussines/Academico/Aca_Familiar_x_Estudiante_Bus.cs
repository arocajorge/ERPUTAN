using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using Core.Erp.Data.Academico;

namespace Core.Erp.Business.Academico
{
    public class Aca_Familiar_x_Estudiante_Bus
    {
         
        Aca_Familiar_x_Estudiante_Data da;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Familiar_x_Estudiante_Info InfoFamiliar_x_Estuadiante;


        public bool GrabarDB(Aca_Familiar_Info InfoFamiliar, Aca_Estudiante_Info infoEstudiante, ref string msj)
        {
            bool resultado = false;
            try
            {
                    da = new Aca_Familiar_x_Estudiante_Data();
                    InfoFamiliar_x_Estuadiante = new Aca_Familiar_x_Estudiante_Info();

                    InfoFamiliar_x_Estuadiante.IdInstitucion = (infoEstudiante.IdInstitucion == 0) ? InfoFamiliar.IdInstitucion : infoEstudiante.IdInstitucion;
                    InfoFamiliar_x_Estuadiante.IdEstudiante = infoEstudiante.IdEstudiante;
                    InfoFamiliar_x_Estuadiante.UsuarioCreacion = (infoEstudiante.UsuarioCreacion == null) ? InfoFamiliar.UsuarioCreacion : infoEstudiante.UsuarioCreacion;
                    //InfoFamiliar_x_Estuadiante.UsuarioModificacion = (infoEstudiante.UsuarioModificacion == null) ? InfoFamiliar.UsuarioModificacion : infoEstudiante.UsuarioModificacion;
                    InfoFamiliar_x_Estuadiante.FechaCreacion = DateTime.Now;

                    InfoFamiliar_x_Estuadiante.IdParentesco_cat = InfoFamiliar.IdParentescoCat;
                    InfoFamiliar_x_Estuadiante.IdFamiliar = InfoFamiliar.IdFamiliar;
                    InfoFamiliar_x_Estuadiante.activo = true;
                    InfoFamiliar_x_Estuadiante.esta_autorizado_ret_alum = InfoFamiliar.EstaAutorizadoRetAlum;
                    InfoFamiliar_x_Estuadiante.esta_autorizado_recibir_not_mail = InfoFamiliar.EstaAutorizadoRecAlumn;
                    InfoFamiliar_x_Estuadiante.Vive_con_el_estudiante = InfoFamiliar.ViveConEl;
                    InfoFamiliar_x_Estuadiante.porcentaje_dual = InfoFamiliar.porcentaje_dual;



                    bool validaFamiliar = ExisteFamiliar(InfoFamiliar_x_Estuadiante);

                    if (validaFamiliar)
                    {
                        resultado = da.ActualizarDB(InfoFamiliar_x_Estuadiante, ref msj);
                    }
                    else
                    {
                        resultado = da.GrabarDB(InfoFamiliar_x_Estuadiante, ref msj, true);
                    }
             

                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Familiar_x_Estudiante_Bus) };
            }
            

        }

        public List<Aca_Familiar_x_Estudiante_Info> Get_list_familiar_x_estudiante(int IdInstitucion, decimal IdEstudiante)
        {
            try
            {
                da = new Aca_Familiar_x_Estudiante_Data();
                return da.Get_list_familiar_x_estudiante(IdInstitucion, IdEstudiante);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_familiar_x_estudiante", ex.Message), ex) { EntityType = typeof(Aca_Familiar_x_Estudiante_Bus) };
            }
        }

        public bool ActualizarDB(Aca_Familiar_Info InfoFamiliar, Aca_Estudiante_Info infoEstudiante, ref string msj)
        {
           
            bool resultado = false;
            try
            {
               
                    da = new Aca_Familiar_x_Estudiante_Data();
                    InfoFamiliar_x_Estuadiante = new Aca_Familiar_x_Estudiante_Info();

                    InfoFamiliar_x_Estuadiante.IdInstitucion = infoEstudiante.IdInstitucion;
                    InfoFamiliar_x_Estuadiante.IdEstudiante = infoEstudiante.IdEstudiante;
                    InfoFamiliar_x_Estuadiante.UsuarioCreacion = infoEstudiante.UsuarioCreacion;
                    InfoFamiliar_x_Estuadiante.UsuarioModificacion = infoEstudiante.UsuarioModificacion;
                    InfoFamiliar_x_Estuadiante.FechaCreacion = DateTime.Now;

                    InfoFamiliar_x_Estuadiante.IdParentesco_cat = InfoFamiliar.IdParentescoCat;
                    InfoFamiliar_x_Estuadiante.IdFamiliar = InfoFamiliar.IdFamiliar;
                    InfoFamiliar_x_Estuadiante.activo = true;
                    InfoFamiliar_x_Estuadiante.esta_autorizado_ret_alum = InfoFamiliar.EstaAutorizadoRetAlum;
                    InfoFamiliar_x_Estuadiante.esta_autorizado_recibir_not_mail = InfoFamiliar.EstaAutorizadoRecAlumn;
                    InfoFamiliar_x_Estuadiante.Vive_con_el_estudiante = InfoFamiliar.ViveConEl;
                    InfoFamiliar_x_Estuadiante.porcentaje_dual = InfoFamiliar.porcentaje_dual;
                    bool validaFamiliar = ExisteFamiliar(InfoFamiliar_x_Estuadiante);
                    if (validaFamiliar)
                    {
                        resultado = da.ActualizarDB(InfoFamiliar_x_Estuadiante, ref msj);
                    }
                    else
                    {
                        resultado = da.GrabarDB(InfoFamiliar_x_Estuadiante, ref msj, true);
                    }

                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Familiar_x_Estudiante_Bus) };
            }
        }
        public bool ExisteFamiliar(Aca_Familiar_x_Estudiante_Info info)
        {
            try
            {
                return da.ExisteFamiliar(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteFamiliar", ex.Message), ex) { EntityType = typeof(Aca_Familiar_x_Estudiante_Bus) };
            }
        }


        public bool AnularDB(List<Aca_Familiar_Info> listaFamiliar, Aca_Estudiante_Info infoEstudiante, ref string msj)
        {
            bool resultado = false;
            try
            {
                da = new Aca_Familiar_x_Estudiante_Data();
                resultado= da.AnularDB(listaFamiliar, infoEstudiante,ref msj);
                return resultado;

               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Aca_Familiar_x_Estudiante_Bus) };
            }


        }
    }
}
