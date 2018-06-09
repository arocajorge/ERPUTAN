/*CLASE: tb_persona_bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 24-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{

   public  class tb_persona_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_persona_data EmpD = new tb_persona_data();


        public List<tb_persona_Info> Get_List_Persona_x_Tipo(int IdTipoPersona)
        {
            try
            {
                return EmpD.Get_List_Persona_x_Tipo(IdTipoPersona);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPersonasXtipo", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };

            }

        }

        public Boolean Verifica_Ruc(string cedula, ref string mensaje)
        {
            try
            {
                cedula = cedula.Trim();
                //string mensaje = "";
                bool resul = false;
                string documento = "Número de documento";
                int tercer_digito = 0;
                int provincia = 0;
                int sucursal = 0;
                
                //Valido que sean solo números
                foreach (var item in cedula.ToCharArray())
                {
                    if (!Char.IsNumber(item))
                    {
                        mensaje = documento + " incorrecto";
                        return false;
                    }
                }


                //Valido que tenga 10 o 13 digitos
                if (cedula.Length != 10 && cedula.Length != 13)
                {
                    mensaje = documento + " incorrecto";
                    return false;
                }

                //Valido que los 2 primeros digitos deben ser un número de provincia
                provincia = Convert.ToInt32(cedula.Substring(0,2));
                if (provincia < 1 || provincia > 24)
                {
                    mensaje = documento + " incorrecto";
                    return false;
                }

                //Valido que el tercer digito debe ser 6,9 o menor a 6
                tercer_digito = Convert.ToInt32(cedula.Substring(2, 1));
                if (tercer_digito > 6 && tercer_digito < 9)
                {
                    mensaje = documento + " incorrecto";
                    return false;
                }

                //Valido que el numero de sucursal sea mayor a 0
                if (cedula.Length == 13)
                {
                    sucursal = Convert.ToInt32(cedula.Substring(cedula.Length - 3, 3));
                    if (sucursal <= 0)
                    {
                        mensaje = "Ruc incorrecto";
                        return false;
                    }
                }

                switch (cedula.Length)
                {
                    case 10:
                        documento = "Cédula";
                        resul = Validar_modulo10(cedula);                            
                        break;
                    case 13:
                        documento = "Ruc";                        
                        switch (tercer_digito)
                        {
                            case 6: case 9:
                                resul = Validar_modulo11(cedula, tercer_digito);
                                break;
                            case 0: case 1: case 2: case 3: case 4: case 5:
                                resul = Validar_modulo10(cedula);
                                break;
                            default:                               
                                resul = false;
                                break;
                        }
                        break;                    
                    default:                        
                        resul = false;
                        break;
                }
                if (!resul)
                    mensaje = documento + documento.Substring(documento.Length-1, 1) == "a" ? " incorrecta" : " incorrecto";
                return resul;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "tb_persona_bus", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
            }
        }

        public Boolean Validar_modulo10(string Cedula)
        {
            try
            {
                int[] coeficiente = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
                int digito_verificador = Convert.ToInt32(Cedula.Substring(9, 1));
                char[] digitos = Cedula.ToCharArray(0,9);
                int resultado_verificador = 0;
                int suma = 0;
                int residuo = 0;
                int resultado = 0;
                int numero = 0;
                int contador = digitos.Length;
                for (int i = 0; i < contador; i++)
                {
                    numero = Convert.ToInt32(digitos[i].ToString());
                    resultado = numero * Convert.ToInt32(coeficiente[i]);
                    while (resultado > 9)
                    {
                        resultado = Convert.ToInt32(resultado.ToString().Substring(0,1)) + Convert.ToInt32(resultado.ToString().Substring(1,1));
                    }
                    suma = suma + resultado;
                } 
                residuo = suma % 10;
                if (residuo == 0)
                    resultado_verificador = residuo;
                else
                    resultado_verificador = 10 - residuo;
                if (resultado_verificador == digito_verificador)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "tb_persona_bus", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
            }
        }
        public Boolean Validar_modulo11(string Ruc, int tercer_digito)
        {
            try
            {
                int[] coeficiente6 = { 3, 2, 7, 6, 5, 4, 3, 2 };
                int[] coeficiente9 = { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                int[] coeficiente;
                char[] digitos;
                int digito_verificador = 0;
                int resultado_verificador = 0;
                int suma = 0;
                int residuo = 0;
                int resultado = 0;
                int numero = 0;
                if (tercer_digito == 6)
                {
                    digitos = Ruc.ToCharArray(0, 8);
                    digito_verificador = Convert.ToInt32(Ruc.Substring(8, 1));
                    coeficiente = coeficiente6;
                }
                else
                {
                    digitos = Ruc.ToCharArray(0, 9);
                    digito_verificador = Convert.ToInt32(Ruc.Substring(9, 1));
                    coeficiente = coeficiente9;
                }
                for (int i = 0; i < digitos.Count(); i++)
                {
                    numero = Convert.ToInt32(digitos[i].ToString());
                    resultado = numero * coeficiente[i];
                    suma = suma + resultado;
                }
                residuo = suma % 11;
                if (residuo == 0)
                    resultado_verificador = residuo;
                else
                    resultado_verificador = 11 - residuo;
                if (resultado_verificador == digito_verificador)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "tb_persona_bus", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
            }
        }

       public List<tb_persona_Info> Get_List_Persona()
        {
            try
            {
                return EmpD.Get_List_Persona();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Persona", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
            }
        }

       public tb_persona_Info Get_Info_Persona(decimal idPersona)
        {
            try
            {
                return EmpD.Get_Info_Persona(idPersona);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPersona", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }
        }

        public tb_persona_Info Get_Info_Persona(string cedula)
        {
            try
            {
                return EmpD.Get_Info_Persona(cedula);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDatoPersona", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }
        }

        public decimal getIdPersona()
        {
            try
            {
                tb_persona_data data = new tb_persona_data();
                    return data.getIdPersona();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getIdPersona", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           

            }

        }
        
        public Boolean ModificarDB(tb_persona_Info info, ref string msgError)
        {
            try
            {
                return EmpD.ModificarDB(info, ref msgError);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }
        }

        public Boolean ModificaPersEmpl(tb_persona_Info info)
        {
            try
            {
                return EmpD.ModificaPersEmpl(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificaPersEmpl", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }
        }

        public Boolean GrabarDB(tb_persona_Info info, ref decimal idPersonaOut, ref string msgError)
        {
            try
            {
                Boolean valorRetornar = false;

                //VALIDACION DE DATOS
                if (validar_y_corregir_objeto(ref info, ref msgError))
                {

                    if (EmpD.GetExiste(info, ref msgError))
                    {
                        if (string.IsNullOrWhiteSpace(info.pe_UltUsuarioModi))
                        {info.pe_UltUsuarioModi = param.IdUsuario;}
                        

                        idPersonaOut = info.IdPersona;
                        
                        //ACTUALIZA EL REGISTRO
                        valorRetornar = EmpD.ModificarDB(info, ref msgError);

                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(info.pe_UltUsuarioModi))
                        { info.pe_UltUsuarioModi = param.IdUsuario; }

                        //NUEVO REGISTRO
                        valorRetornar = EmpD.GrabarDB(info, ref idPersonaOut, ref msgError);
                    }

                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }
        }

        public Boolean AnularDB(tb_persona_Info info, ref string msgError)
        {

            try
            {
                info.IdUsuarioUltAnu = param.IdUsuario;
                return EmpD.AnularDB(info, ref MensajeError);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           

            }
        }

        public Boolean VericarCedulaExiste(string cedula, ref string mensaje)
        {

            try
            {

                return EmpD.ExisteCedula(cedula, ref mensaje);



            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }

        }
        

        private Boolean validar_y_corregir_objeto(ref tb_persona_Info Info, ref string msg)
        {
            try
            {
                tb_Catalogo_Bus busCatalogoTipo = new tb_Catalogo_Bus();
                
                if (Info.IdEstadoCivil == null)
                {
                    
                    Info.IdEstadoCivil=  busCatalogoTipo.Get_List_Sexo().FirstOrDefault().codigo;
                }
                if (Info.IdTipoDocumento == null)
                {
                    Info.IdTipoDocumento = busCatalogoTipo.Get_List_TipoDoc_Personales().FirstOrDefault().codigo;
                }
                 if(Info.pe_sexo==null)
                {
                    Info.pe_sexo = busCatalogoTipo.Get_List_Sexo().FirstOrDefault().codigo;
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };
           
            }

        }

        public tb_persona_Info Get_Info_Beneficiario_OP(int IdEmpresa, string IdTipoPersona, int IdPersona, int IdEntidad)
        {
            try
            {
                return EmpD.Get_Info_Beneficiario_OP(IdEmpresa, IdTipoPersona, IdPersona, IdEntidad);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(tb_persona_bus) };

            }

        }
    }
}
