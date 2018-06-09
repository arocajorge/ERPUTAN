
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Academico
{
   public  class Aca_Familiar_Bus
    {
       Aca_Familiar_Data da;
       Aca_Familiar_x_Estudiante_Data DataFamiliar_x_Estudiante;
       Aca_Familiar_x_Estudiante_Bus BusFamiliar_x_Estudiante;
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       public decimal GetIdFamiliarxIdPersona(int IdInstitucion, decimal IdPersona)
       {
           //string IdAnio_Lectivo_Activo = "";
           decimal IdFamiliar = 0;

           try
           {
               da = new Aca_Familiar_Data();
               IdFamiliar = da.GetIdFamiliarxIdPersona(IdInstitucion, IdPersona);
               return IdFamiliar;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdFamiliarxIdPersona", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }

       }
       public decimal GetIdFamiliar(int IdInstitucion, decimal IdPersona, ref string msj)
       {
           //string IdAnio_Lectivo_Activo = "";
           decimal IdFamiliar = 0;

           try
           {
               da = new Aca_Familiar_Data();
               IdFamiliar = da.GetIdFamiliar(IdInstitucion, IdPersona, ref msj);
               return IdFamiliar;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdFamiliar", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }

       }

       public bool ExisteFamiliar(Aca_Familiar_Info info) {
           try
           {
               da = new Aca_Familiar_Data();
               return da.ExisteFamiliar(info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteFamiliar", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }
       }

       public bool GrabarDB(List< Aca_Familiar_Info> listaFamiliar, Aca_Estudiante_Info infoEstudiante ,ref string msj) {
           bool resultado = false;
           decimal IdFami=0;
           try
           {
               foreach (var item in listaFamiliar)
               {
                   da = new Aca_Familiar_Data();
                   BusFamiliar_x_Estudiante = new Aca_Familiar_x_Estudiante_Bus();

                   item.IdInstitucion = infoEstudiante.IdInstitucion;
                   item.IdEstudiante = infoEstudiante.IdEstudiante;
                   item.UsuarioCreacion = infoEstudiante.UsuarioCreacion;
                   item.UsuarioModificacion = infoEstudiante.UsuarioModificacion;

                   bool validaFamiliar = ExisteFamiliar(item);
                   

                   if (validaFamiliar)
                   {
                       decimal IdFamiliarpersona = da.GetIdFamiliarxIdPersona(infoEstudiante.IdInstitucion, item.Persona_Info.IdPersona);
                       item.IdFamiliar = IdFamiliarpersona;
                       item.Persona_Info.pe_UltUsuarioModi = item.UsuarioModificacion;

                       resultado = da.ActualizarDB(item, ref msj);

                       if (resultado == true)
                       {
                           resultado = BusFamiliar_x_Estudiante.ActualizarDB(item, infoEstudiante, ref msj);
                       }
                       
                   }
                   else {
                       if (item.Persona_Info.pe_nombre == "" && item.Persona_Info.pe_apellido == "" && item.Persona_Info.pe_razonSocial=="" )
                       {
                           resultado = false;
                       }
                       else 
                       {
                           resultado = da.GrabarDB(item, true, ref msj, ref IdFami);

                           item.IdFamiliar = IdFami;
                           
                           if (resultado == true)
                           {
                               resultado = BusFamiliar_x_Estudiante.GrabarDB(item, infoEstudiante, ref msj);
                           }

                       }
                   }        
               }
               
               return resultado;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }   
       }

       public bool GrabarDBFamiliarSistemaDual(Aca_Familiar_Info infoFamiliarDual, Aca_Estudiante_Info infoEstudiante, ref string msj)
       {
           decimal IdFamiliarDual = 0;
           bool resultado = false;
           try
           {
               BusFamiliar_x_Estudiante = new Aca_Familiar_x_Estudiante_Bus();
                Aca_Familiar_Bus bus_AcaFamiDual = new Aca_Familiar_Bus();
                //Aca_Familiar_x_Estudiante_Info InfoAcaFamiliar_x_Estudiante_Dual = new Aca_Familiar_x_Estudiante_Info();

               if (bus_AcaFamiDual.ExisteFamiliar(infoFamiliarDual))
               {
                   IdFamiliarDual = bus_AcaFamiDual.GetIdFamiliarxIdPersona(infoFamiliarDual.IdInstitucion, infoFamiliarDual.Persona_Info.IdPersona);
                   infoFamiliarDual.IdFamiliar = IdFamiliarDual;
                   //GRABA SOLO ACA_FAMILIAR_X_ESTUDIANTE
                   resultado = BusFamiliar_x_Estudiante.GrabarDB(infoFamiliarDual, infoEstudiante, ref msj);
               }
               else
               {
                   //GRABA ACA_FAMILIAR
                   resultado = da.GrabarDB(infoFamiliarDual, false, ref msj, ref IdFamiliarDual);
                   //infoFamiliarDual.IdFamiliar = IdFamiliarDual;
                   if (resultado == true)
                   {
                       resultado = BusFamiliar_x_Estudiante.GrabarDB(infoFamiliarDual, infoEstudiante, ref msj);
                   }
               }
               return resultado;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDBFamiliarSistemaDual", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }   
       }


       //GRABAR FAMILIAR(AUSPICIANTE SISTEMA DUAL) 

       public bool ActualizarDB(List<Aca_Familiar_Info> listaFamiliar, Aca_Estudiante_Info infoEstudiante, ref string msj)
       {
           bool resultado = false;
           decimal IdFami = 0;
           try
           {
               foreach (var item in listaFamiliar)
               {
                   da = new Aca_Familiar_Data();
                   item.IdInstitucion = infoEstudiante.IdInstitucion;
                   item.IdEstudiante = infoEstudiante.IdEstudiante;                   
                   item.UsuarioModificacion = infoEstudiante.UsuarioModificacion;
                   item.FechaModificacion = DateTime.Now;
                   

                   bool validaFamiliar = ExisteFamiliar(item);
                   if (validaFamiliar)
                   {
                        if (item.Persona_Info.pe_nombre != "" && item.Persona_Info.pe_apellido != ""  )
                        {
                            resultado = da.ActualizarDB(item, ref msj);

                            if (resultado)
                            {
                                //if (item.IdParentescoCat == "REP_ECO" || item.IdParentescoCat == "REP_ECO_DUAL")
                                //{
                                    BusFamiliar_x_Estudiante = new Aca_Familiar_x_Estudiante_Bus();
                                    resultado = BusFamiliar_x_Estudiante.GrabarDB(item, infoEstudiante, ref msj);
                                //}
                                
                            }
                            else { resultado = true; }
                        }
                        else { resultado = true; }
                   }
                   else
                   {
                       if (item.Persona_Info.pe_nombre != "" && item.Persona_Info.pe_apellido != "") {
                          resultado = da.GrabarDB(item, true, ref msj, ref IdFami);
                       }
                   }                      
               }
             
               return resultado;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }        
       }

       public List<Aca_Familiar_Info> Get_List_Familiar_x_Estudiante(int IdInstitucion)
       {
           try
           {
               da = new Aca_Familiar_Data();
               return da.Get_List_Familiar_x_Estudiante(IdInstitucion);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Familiar_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }

       }
       public List<Aca_Familiar_Info> Get_List_Familiar_x_Estudiante(int IdInstitucion, decimal IdEstudiante)
       {
           try
           {
               da = new Aca_Familiar_Data();
               return da.Get_List_Familiar_x_Estudiante(IdInstitucion, IdEstudiante);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Familiar_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }

       }


       public Aca_Familiar_Info GetFamiliar_x_Estudiante(string cedulaRuc, ref bool existePersona)
       {
           Aca_Familiar_Info infoFamiliar=new Aca_Familiar_Info();
           try
           {
               da = new Aca_Familiar_Data();
               infoFamiliar = da.GetFamiliar_x_Estudiante(cedulaRuc,ref existePersona);
               return infoFamiliar;
           }
           catch (Exception ex) 
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetFamiliar_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }
           
       }

       public Aca_Familiar_Info GetFamiliar_x_Estudiante(decimal IdEstudiante, string cedulaRucFamiliar, ref bool existePersona)
       {
           try
           {
               Aca_Familiar_Info infoFamiliar = new Aca_Familiar_Info();
               da = new Aca_Familiar_Data();
               infoFamiliar = da.GetFamiliar_x_Estudiante(IdEstudiante, cedulaRucFamiliar, ref existePersona);
               return infoFamiliar;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetFamiliar_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }
           
       }

       public List<tb_persona_Info> Get_List_Persona_Por_Estudiante_()
       {
           try
           {
               return da.Get_List_Persona_Por_Estudiante_();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Persona_Por_Estudiante_", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }
           
       }

       public List<Aca_Familiar_Info> Get_List_RepreEco_x_Estudiante(int IdInstitucion)
       {
           try
           {
               da = new Aca_Familiar_Data();
               return da.Get_List_RepreEco_x_Estudiante(IdInstitucion);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_RepreEco_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Familiar_Bus) };
           }

       }
    }
}
