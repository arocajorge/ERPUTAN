using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Data;

namespace Core.Erp.Business.Academico
{
    public class Aca_Estudiante_Bus
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Estudiante_Data da;
        #endregion
       
        public bool ExisteCedula(int idEmpresa,decimal idEstudiante, string cedulaRuc,ref string mensaje) {
            try
            {
                da = new Aca_Estudiante_Data();
                return da.ExisteCedula(idEmpresa,idEstudiante, cedulaRuc,ref mensaje);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCedula", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
            }
        }

        #region "Get"



        public Aca_Estudiante_Info Get_Info_Estudiante_x_Codigo2(int IdInstitucion,string Codigo2_Estudiante)
        {
            try
            {
                da = new Aca_Estudiante_Data();
                return da.Get_Info_Estudiante_x_Codigo2(IdInstitucion, Codigo2_Estudiante);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiantes", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
            }

        }


        public Aca_Estudiante_Info Get_Info_Estudiante_x_IdPersona(int IdInstitucion,decimal IdPersona)
        {
            try
            {
                da = new Aca_Estudiante_Data();
                return da.Get_Info_Estudiante_x_IdPersona(IdInstitucion, IdPersona);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiantes", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
            }

        }



         public List<Aca_Estudiante_Info> Get_List_Estudiantes(int IdInstitucion)
            {
                List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
                try
                {
                    da = new Aca_Estudiante_Data();
                    lM = da.Get_List_Estudiantes(IdInstitucion);
                    return (lM);
                }
                catch (Exception ex)
                {
                    Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiantes", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
                }

            }

         public List<Aca_Estudiante_Info> Get_List_Estudiantes_Sin_Matricula(int IdInstitucion)
         {
             List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
             try
             {
                 da = new Aca_Estudiante_Data();
                 lM = da.Get_List_Estudiantes_Sin_Matricula(IdInstitucion);
                 return (lM);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiantes", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
             }

         }

         public List<Aca_Estudiante_Info> GetListEstudiante_x_RepresentateEconomico(int IdInstitucion, decimal IdPersona)
         {
             List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
             try
             {
                 da = new Aca_Estudiante_Data();
                 lM = da.GetListEstudiante_x_RepresentateEconomico(IdInstitucion, IdPersona);
                 return (lM);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiantes", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
             }

         }

        public List<Aca_Estudiante_Info> Get_List_Estudiantes_Sin_Matricula_Dual(int IdInstitucion)
        {
            List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
            try
            {
                da = new Aca_Estudiante_Data();
                lM = da.Get_List_Estudiantes_Sin_Matricula_Dual(IdInstitucion);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Estudiantes_Sin_Matricula_Dual", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
            }
        }


        #endregion

        #region "Grabar,Actualizar,Eliminar"
         public Boolean ActualizarDB(Aca_Estudiante_Info infoEstudiante, ref string msj)
         {
             Boolean resultado = false;
             try
             {   da = new Aca_Estudiante_Data();
                 resultado = da.ActualizarDB(infoEstudiante, ref msj);
                 if (resultado)
                 {
                     Aca_ficha_medica_Bus negFichaMedica = new Aca_ficha_medica_Bus();
                     resultado = negFichaMedica.ActualizarDB(infoEstudiante.FichaMedica_Info, ref msj);
                     if (resultado)
                     {
                         Aca_estudiante_x_Alergia_Bus negAlergia = new Aca_estudiante_x_Alergia_Bus();
                         resultado = negAlergia.ActualizarDB(infoEstudiante.listaAlergias, ref msj);
                         if (resultado)
                         {
                             Aca_Familiar_Bus negFamiliar = new Aca_Familiar_Bus();
                             resultado = negFamiliar.ActualizarDB(infoEstudiante.listaFamiliar, infoEstudiante, ref msj);
                         }
                     }
                     else {
                         msj = "Estudiante sin ficha Médica";
                     }
                 }

                 return resultado;
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
             }
             
         }

         public Boolean GrabarDB(Aca_Estudiante_Info infoEstudiante, ref decimal idEstudiante, ref string msj)
         {
             Boolean resultado = false;
             try
             {   da = new Aca_Estudiante_Data();
                 resultado = da.GrabarDB(infoEstudiante, ref idEstudiante, ref msj);
                 if (resultado)
                 {
                     Aca_ficha_medica_Bus negficha_medica = new Aca_ficha_medica_Bus();
                     infoEstudiante.FichaMedica_Info.IdEstudiante = idEstudiante;
                     infoEstudiante.FichaMedica_Info.IdInstitucion = infoEstudiante.IdInstitucion;
                     if (infoEstudiante.FichaMedica_Info.GrupoSanguineoCatalogo != null)
                     {
                         resultado = negficha_medica.GrabarDB(infoEstudiante.FichaMedica_Info, ref msj);
                         if (resultado)
                         {
                             Aca_estudiante_x_Alergia_Bus negestudiante_x_Alergia = new Aca_estudiante_x_Alergia_Bus();
                             resultado = negestudiante_x_Alergia.GrabarDB(infoEstudiante.listaAlergias, idEstudiante, infoEstudiante.IdInstitucion, ref msj);

                         }
                     }

                     //grabando los familiares
                     Aca_Familiar_Bus negFamiliar = new Aca_Familiar_Bus();
                     foreach (var item in infoEstudiante.listaFamiliar)
                     {
                         item.UsuarioCreacion = infoEstudiante.UsuarioCreacion;
                         item.FechaCreacion = DateTime.Now;
                     }
                     resultado = negFamiliar.GrabarDB(infoEstudiante.listaFamiliar, infoEstudiante, ref msj);                            

                 }
                 return resultado;

             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
             }
             
         }

         public Boolean DeleteDB(List<Aca_Familiar_Info> Lista_familiares_x_estudiante, Aca_Estudiante_Info info, ref string msg)
         {
             Boolean resultado = false;
             try
             {   da = new Aca_Estudiante_Data();
                 resultado = da.AnularDB(info, ref msg);
                 if (resultado)
                 {
                     resultado = false;
                     Aca_Familiar_x_Estudiante_Bus Bus = new Aca_Familiar_x_Estudiante_Bus();
                     foreach (var item in Lista_familiares_x_estudiante)
                     {
                         item.IdParentesco_cat = item.IdParentescoCat;
                     }
                     resultado = Bus.AnularDB(Lista_familiares_x_estudiante, info, ref msg);
                 }
                 return resultado;
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DeleteDB", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
             }
             
         }
         #endregion   
    
    


         public List<Aca_Estudiante_Info> ProcesarDataTable_Aca_Estudiante_Info(DataTable ds, int IdInstitucion, ref string MensajeError)
         {
             List<Aca_Estudiante_Info> list_Info_Estudiante = new List<Aca_Estudiante_Info>();
             

             int COLUMNA_ERROR = 0;
             string FILA_ERROR = "";
             list_Info_Estudiante.Clear();
             try
             {

                 tb_pais_Bus BusPais = new tb_pais_Bus();
                 tb_pais_Info InfoPais = new tb_pais_Info();
                 InfoPais  = BusPais.Get_List_pais().FirstOrDefault();

                tb_Provincia_Bus BusProvincia = new tb_Provincia_Bus();
                tb_provincia_Info InfoProvincia = new tb_provincia_Info();
                InfoProvincia = BusProvincia.Get_List_Provincia(InfoPais.IdPais).FirstOrDefault();

                 tb_Ciudad_Bus BusCiudad = new tb_Ciudad_Bus();
                 tb_ciudad_Info InfoCiudad = new tb_ciudad_Info();
                 InfoCiudad = BusCiudad.Get_List_Ciudad(InfoProvincia.IdProvincia).FirstOrDefault();
                 



                     //RECORRE EL DATATABLE REGISTRO X REGISTRO
                     if (ds.Rows.Count > 0)
                     {
                         foreach (DataRow row in ds.Rows)
                         {

                             Aca_Estudiante_Info info_Estudiante = new Aca_Estudiante_Info();
                             //RECORRE C/U DE LAS COLUMNAS

                             info_Estudiante.IdInstitucion = IdInstitucion;

                             info_Estudiante.Persona_Info.pe_sexo = "SEXO_MAS";
                             info_Estudiante.Persona_Info.IdEstadoCivil = "SOLTE";
                             info_Estudiante.Persona_Info.IdTipoPersona = 1;
                             info_Estudiante.Persona_Info.IdUsuario = "sysWizard";
                             info_Estudiante.Persona_Info.pe_UltUsuarioModi = "sysWizard";



                             info_Estudiante.UsuarioCreacion = "sysWizard";
                             info_Estudiante.UsuarioModificacion = "sysWizard";
                             info_Estudiante.Pais_Info = InfoPais;
                             info_Estudiante.Pais_Info2 = InfoPais;
                             info_Estudiante.Pais_Info3 = InfoPais;
                             info_Estudiante.barrio = "";
                             info_Estudiante.lugar = "";
                             info_Estudiante.estado = "A";



                             


                             if (string.IsNullOrEmpty(row[0].ToString()) == false)
                             {


                                 for (int col = 0; col < ds.Columns.Count + 1; col++)
                                 {
                                     COLUMNA_ERROR = col;
                                     switch (col)
                                     {
                                         case 0://Codigo_Alumno
                                             info_Estudiante.cod_estudiante = Convert.ToString(row[col]);
                                             info_Estudiante.cod_estudiante2 = info_Estudiante.cod_estudiante;
                                             FILA_ERROR = info_Estudiante.cod_estudiante;
                                             break;

                                         case 1://nombre_alum
                                             info_Estudiante.Persona_Info.pe_nombre = Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_nombre = info_Estudiante.Persona_Info.pe_nombre.Trim();
                                             FILA_ERROR = info_Estudiante.Persona_Info.pe_nombre;
                                             break;

                                         case 2://apellido_alum
                                             info_Estudiante.Persona_Info.pe_apellido = Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_apellido = info_Estudiante.Persona_Info.pe_apellido.Trim();
                                             FILA_ERROR = info_Estudiante.Persona_Info.pe_apellido;
                                             break;

                                         case 3://Cedula_Ruc
                                                 info_Estudiante.Persona_Info.pe_cedulaRuc = Convert.ToString(row[col]);
                                                 info_Estudiante.Persona_Info.pe_cedulaRuc = info_Estudiante.Persona_Info.pe_cedulaRuc.Trim();

                                                 info_Estudiante.Persona_Info.pe_Naturaleza = "JURI";

                                                 if (info_Estudiante.Persona_Info.pe_cedulaRuc.Length == 10)
                                                 {
                                                     info_Estudiante.Persona_Info.IdTipoDocumento = "CED";
                                                     info_Estudiante.Persona_Info.pe_Naturaleza = "NATU";
                                                 }
                                                 else
                                                 {
                                                     if (info_Estudiante.Persona_Info.pe_cedulaRuc.Length == 13)
                                                     {
                                                         info_Estudiante.Persona_Info.IdTipoDocumento = "RUC";
                                                     }
                                                     else
                                                     {
                                                         info_Estudiante.Persona_Info.IdTipoDocumento = "PAS";
                                                     }
                                                 }
                                                    FILA_ERROR = info_Estudiante.Persona_Info.pe_cedulaRuc;

                                                break;

                                         case 4://Lugar_Nac
                                             //info_Estudiante.Persona_Info. = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             break;

                                         case 5://Fecha_Nacimiento
                                             info_Estudiante.Persona_Info.pe_fechaNacimiento = Convert.ToDateTime(row[col]);
                                             FILA_ERROR = info_Estudiante.Persona_Info.pe_fechaNacimiento.ToString();

                                             break;

                                         case 6://Direcc_Alumn
                                             info_Estudiante.Persona_Info.pe_direccion = Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_direccion = info_Estudiante.Persona_Info.pe_direccion.Trim();

                                             break;

                                         case 7://Telef_Alun
                                             info_Estudiante.Persona_Info.pe_telefonoCasa = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_telefonoCasa = info_Estudiante.Persona_Info.pe_telefonoCasa.Trim();

                                             break;

                                         case 8://Telefono_emer
                                             info_Estudiante.Persona_Info.pe_telefonoOfic = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_telefonoOfic = info_Estudiante.Persona_Info.pe_telefonoOfic.Trim();

                                             break;

                                         case 9://Celular
                                             info_Estudiante.Persona_Info.pe_celular = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_celular = info_Estudiante.Persona_Info.pe_celular.Trim();
                                             break;

                                         case 10://Correo_alum
                                             info_Estudiante.Persona_Info.pe_correo = Convert.ToString(row[col]);
                                             info_Estudiante.Persona_Info.pe_correo = info_Estudiante.Persona_Info.pe_correo.Trim();
                                             break;

                                         case 11://Nacionalidad
                                             //info_Estudiante.Persona_Info.pais = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             break;

                                         case 12://Cedula_Madre
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_cedulaRuc = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_cedulaRuc = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_cedulaRuc.Trim();



                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_sexo = "SEXO_MAS";
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.IdEstadoCivil = "SOLTE";
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.IdTipoPersona = 1;
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_Naturaleza = "JURI";


                                                if (info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_cedulaRuc.Length == 10)
                                                 {
                                                     info_Estudiante.Info_Familiar_Madre.Persona_Info.IdTipoDocumento = "CED";
                                                     info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_Naturaleza = "NATU";
                                                 }
                                                 else
                                                 {
                                                     if (info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_cedulaRuc.Length == 13)
                                                     {
                                                         info_Estudiante.Info_Familiar_Madre.Persona_Info.IdTipoDocumento = "RUC";
                                                     }
                                                     else
                                                     {
                                                         info_Estudiante.Info_Familiar_Madre.Persona_Info.IdTipoDocumento = "PAS";
                                                     }
                                                 }

                                                FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_cedulaRuc;



                                             break;

                                         case 13://nombre_madre
                                             
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_nombre = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_nombre = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_nombre.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_nombre;

                                             break;

                                         case 14://apellido_madre
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_apellido = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_apellido = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_apellido.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_apellido;
                                             break;

                                         case 15://tel_madre
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_telefonoCasa = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_telefonoCasa = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_telefonoCasa.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_telefonoCasa;
                                             break;

                                         case 16://Direccion_madre
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_direccion = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_direccion = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_direccion.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_direccion;
                                             break;

                                         case 17://email_madre
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_correo = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_correo = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_correo.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_correo;
                                             break;

                                         case 18://CelularMadre
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_celular  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_celular = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_celular.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_celular;
                                             break;

                                             /////////////PADRE ///////////////////////////////////////////////
                                         case 19://Cedula_Padre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_cedulaRuc  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_cedulaRuc = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_cedulaRuc.Trim();

                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_sexo = "SEXO_MAS";
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.IdEstadoCivil = "SOLTE";
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.IdTipoPersona = 1;
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_Naturaleza = "JURI";


                                             if (info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_cedulaRuc.Length == 10)
                                                 {
                                                     info_Estudiante.Info_Familiar_Padre.Persona_Info.IdTipoDocumento = "CED";
                                                     info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_Naturaleza = "NATU";
                                                 }
                                                 else
                                                 {
                                                     if (info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_cedulaRuc.Length == 13)
                                                     {
                                                         info_Estudiante.Info_Familiar_Padre.Persona_Info.IdTipoDocumento = "RUC";
                                                     }
                                                     else
                                                     {
                                                         info_Estudiante.Info_Familiar_Padre.Persona_Info.IdTipoDocumento = "PAS";
                                                     }
                                                 }

                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_cedulaRuc;






                                             break;

                                         case 20://nombre_padre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_nombre  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_nombre = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_nombre.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_nombre;
                                             break;

                                         case 21://apellido_padre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_apellido  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_apellido = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_apellido.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_apellido;

                                             break;

                                         case 22://tel_padre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_telefonoCasa  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_telefonoCasa = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_telefonoCasa.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_telefonoCasa;
                                             break;

                                         case 23://Direccion_padre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_direccion  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_direccion = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_direccion.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_direccion;
                                             break;

                                         case 24://email_padre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_correo  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_correo = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_correo.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_correo;
                                             break;

                                         case 25://Celularpadre
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_celular  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_celular = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_celular.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_celular;
                                             break;

                                             ////////////////// REPRESENTANTE ECONOMICO //////////////////////////////
                                         case 26://Cedula_Rep_Econo
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc.Trim();


                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_sexo = "SEXO_MAS";
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.IdEstadoCivil = "SOLTE";
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.IdTipoPersona = 1;
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_Naturaleza = "JURI";


                                             if (info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc.Length == 10)
                                                 {
                                                     info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.IdTipoDocumento = "CED";
                                                     info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_Naturaleza = "NATU";
                                                 }
                                                 else
                                                 {
                                                     if (info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc.Length == 13)
                                                     {
                                                         info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.IdTipoDocumento = "RUC";
                                                     }
                                                     else
                                                     {
                                                         info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.IdTipoDocumento = "PAS";
                                                     }
                                                 }

                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_cedulaRuc;



                                             break;


                                         case 27://nombre_rep_econ

                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_nombre  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_nombre = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_nombre.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_nombre;
                                             break;


                                         case 28://apellido_rep_econo
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_apellido  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_apellido = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_apellido.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_apellido;
                                             break;


                                         case 29://tel_rep_econo
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_telefonoCasa  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_telefonoCasa = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_telefonoCasa.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_telefonoCasa;
                                             break;


                                         case 30://Direccion_rep_econo
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_direccion  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_direccion = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_direccion.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_direccion;
                                             break;


                                         case 31://email_rep_econo

                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_correo  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_correo = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_correo.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_correo;
                                             break;

                                             ///////////////////////////////  CEDULA REPRESENTANTE LEGAL /////////////////////////

                                         case 32://Cedula_Rep_legal

                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_cedulaRuc = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_cedulaRuc = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_cedulaRuc.Trim();




                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_sexo = "SEXO_MAS";
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.IdEstadoCivil = "SOLTE";
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.IdTipoPersona = 1;
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_Naturaleza = "JURI";


                                             if (info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_cedulaRuc.Length == 10)
                                                 {
                                                     info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.IdTipoDocumento = "CED";
                                                     info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_Naturaleza = "NATU";
                                                 }
                                                 else
                                                 {
                                                     if (info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_cedulaRuc.Length == 13)
                                                     {
                                                         info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.IdTipoDocumento = "RUC";
                                                     }
                                                     else
                                                     {
                                                         info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.IdTipoDocumento = "PAS";
                                                     }
                                                 }
                                             
                                             
                                             
                                             
                                             
                                             
                                             
                                             
                                             
                                             
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_cedulaRuc;









                                             break;

                                         case 33://nombre_rep_legal

                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_nombre  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_nombre = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_nombre.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_nombre;
                                             break;

                                         case 34://apellido_rep_legal

                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_apellido  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_apellido = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_apellido.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_apellido;
                                             break;

                                         case 35://tel_rep_legal

                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_telefonoCasa  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_telefonoCasa = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_telefonoCasa.Trim();

                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_telefonoCasa;
                                             break;

                                         case 36://Direccion_rep_legal

                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_direccion  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_direccion = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_direccion.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_direccion;
                                             break;

                                         case 37://email_rep_legal

                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_correo  = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                             info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_correo = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_correo.Trim();
                                             FILA_ERROR = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_correo;
                                             break;


                                         default:
                                             break;
                                     }
                                 }

                                 info_Estudiante.Persona_Info.pe_nombreCompleto = info_Estudiante.Persona_Info.pe_apellido + " " + info_Estudiante.Persona_Info.pe_nombre;
                                 info_Estudiante.Persona_Info.pe_estado = "A";


                                 info_Estudiante.Info_Familiar_Madre.IdInstitucion = 1;
                                 info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_nombreCompleto = info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_apellido + " " + info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_nombre;
                                 info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_estado = "A";
                                 info_Estudiante.Info_Familiar_Madre.Persona_Info.pe_UltUsuarioModi = "sysWizard";
                                 info_Estudiante.Info_Familiar_Madre.Persona_Info.IdUsuario = "sysWizard";
                                 info_Estudiante.Info_Familiar_Madre.UsuarioCreacion = "sysWizard";
                                 info_Estudiante.Info_Familiar_Madre.UsuarioModificacion = "sysWizard";

                                 info_Estudiante.Info_Familiar_Madre.activo = true;
                                 info_Estudiante.Info_Familiar_Madre.IdCatalogoIdiomaNativo = "ESPA";
                                 info_Estudiante.Info_Familiar_Madre.IdCatalogoReligion = "CATOL";
                                 info_Estudiante.Info_Familiar_Madre.IdCatalogoTipoSangre = "O+";
                                 info_Estudiante.Info_Familiar_Madre.IdNivelEducativo = "SECU";
                                 info_Estudiante.Info_Familiar_Madre.IdParentesco_cat = "MADR";
                                 info_Estudiante.Info_Familiar_Madre.IdParentescoCat = "MADR";
                                 info_Estudiante.Info_Familiar_Madre.IdPais = InfoPais.IdPais;
                                 info_Estudiante.Info_Familiar_Madre.IdProvincia = InfoProvincia.IdProvincia;
                                 info_Estudiante.Info_Familiar_Madre.IdCiudad = InfoCiudad.IdCiudad;

                                 

                                 info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_nombreCompleto = info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_apellido + " " + info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_nombre;
                                 info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_estado = "A";
                                 info_Estudiante.Info_Familiar_Padre.Persona_Info.pe_UltUsuarioModi = "sysWizard";
                                 info_Estudiante.Info_Familiar_Padre.Persona_Info.IdUsuario = "sysWizard";
                                 info_Estudiante.Info_Familiar_Padre.UsuarioCreacion = "sysWizard";
                                 info_Estudiante.Info_Familiar_Padre.UsuarioModificacion = "sysWizard";

                                 info_Estudiante.Info_Familiar_Padre.activo = true;
                                 info_Estudiante.Info_Familiar_Padre.IdCatalogoIdiomaNativo = "ESPA";
                                 info_Estudiante.Info_Familiar_Padre.IdCatalogoReligion = "CATOL";
                                 info_Estudiante.Info_Familiar_Padre.IdCatalogoTipoSangre = "O+";
                                 info_Estudiante.Info_Familiar_Padre.IdNivelEducativo = "SECU";
                                 info_Estudiante.Info_Familiar_Padre.IdParentesco_cat = "PADR";
                                 info_Estudiante.Info_Familiar_Padre.IdParentescoCat = "PADR";
                                 info_Estudiante.Info_Familiar_Padre.IdPais = InfoPais.IdPais;
                                 info_Estudiante.Info_Familiar_Padre.IdProvincia = InfoProvincia.IdProvincia;
                                 info_Estudiante.Info_Familiar_Padre.IdCiudad = InfoCiudad.IdCiudad;



                                 info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_nombreCompleto = info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_apellido + " " + info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_nombre;
                                 info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_estado = "A";
                                 info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.pe_UltUsuarioModi = "sysWizard";
                                 info_Estudiante.Info_Familiar_Repre_Econo.Persona_Info.IdUsuario = "sysWizard";
                                 info_Estudiante.Info_Familiar_Repre_Econo.UsuarioCreacion = "sysWizard";
                                 info_Estudiante.Info_Familiar_Repre_Econo.UsuarioModificacion = "sysWizard";

                                 info_Estudiante.Info_Familiar_Repre_Econo.activo = true;
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdCatalogoIdiomaNativo = "ESPA";
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdCatalogoReligion = "CATOL";
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdCatalogoTipoSangre = "O+";
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdNivelEducativo = "SECU";
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdParentesco_cat = "REP_ECO";
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdParentescoCat = "REP_ECO";
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdPais = InfoPais.IdPais;
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdProvincia = InfoProvincia.IdProvincia;
                                 info_Estudiante.Info_Familiar_Repre_Econo.IdCiudad = InfoCiudad.IdCiudad;



                                 info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_nombreCompleto = info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_apellido + " " + info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_nombre;
                                 info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_estado = "A";
                                 info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.IdUsuario = "sysWizard";
                                 info_Estudiante.Info_Familiar_Repre_Legal.Persona_Info.pe_UltUsuarioModi = "sysWizard";
                                 info_Estudiante.Info_Familiar_Repre_Legal.UsuarioCreacion = "sysWizard";
                                 info_Estudiante.Info_Familiar_Repre_Legal.UsuarioModificacion = "sysWizard";

                                 info_Estudiante.Info_Familiar_Repre_Legal.activo = true;
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdCatalogoIdiomaNativo = "ESPA";
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdCatalogoReligion = "CATOL";
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdCatalogoTipoSangre = "O+";
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdNivelEducativo = "SECU";
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdParentesco_cat = "REP_LEGAL";
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdParentescoCat = "REP_LEGAL";
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdPais = InfoPais.IdPais;
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdProvincia = InfoProvincia.IdProvincia;
                                 info_Estudiante.Info_Familiar_Repre_Legal.IdCiudad = InfoCiudad.IdCiudad;


                                 List<Aca_Familiar_Info> List_Familiares = new List<Aca_Familiar_Info>();

                                 
                                 List_Familiares.Add(info_Estudiante.Info_Familiar_Repre_Legal);
                                 List_Familiares.Add(info_Estudiante.Info_Familiar_Repre_Econo);
                                 List_Familiares.Add(info_Estudiante.Info_Familiar_Madre);
                                 List_Familiares.Add(info_Estudiante.Info_Familiar_Padre);


                                 info_Estudiante.listaFamiliar = List_Familiares;

                                 list_Info_Estudiante.Add(info_Estudiante);

                             }
                         }
                     }
                     else
                     {
                         MensajeError = "Por favor verifique que el archivo contenga Datos.";
                         list_Info_Estudiante = new List<Aca_Estudiante_Info>();
                     }

                 
                 return list_Info_Estudiante;
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(Aca_Estudiante_Bus) };
             }

         }
    
    }
}
