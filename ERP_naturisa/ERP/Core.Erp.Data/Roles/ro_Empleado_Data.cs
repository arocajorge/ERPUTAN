
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Roles
{
    public class ro_Empleado_Data
    {
        string mensaje = "";
        ro_HistoricoSueldo_Data oHistoricoSueldoData = new ro_HistoricoSueldo_Data();
 
        public List<ro_Empleado_Info> Obtener_Empleados(int idEmpresa)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
             try
            {

                EntitiesRoles db = new EntitiesRoles();
                var select = from A in db.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == idEmpresa
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();                

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    //info.em_estado = (item.em_estado == "A") ? true : false;
                    info.em_estado = item.em_estado;
       
                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.IdPais = item.IdPais;
                    info.IdProvincia = item.IdProvincia;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";
                               
                     // Datos de la Persona
                    tb_persona_Info InfoPersona = new tb_persona_Info();

                    InfoPersona.IdPersona = item.IdPersona;
                    InfoPersona.CodPersona = item.CodPersona;
                    InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    InfoPersona.pe_apellido = item.Apellido;
                    InfoPersona.pe_nombre = item.Nombre;
                    InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    InfoPersona.pe_direccion = item.pe_direccion;
                    InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    InfoPersona.pe_celular = item.pe_celular;
                    InfoPersona.pe_correo = item.pe_correo;
                    InfoPersona.pe_fax = item.pe_fax;
                    InfoPersona.pe_casilla = item.pe_casilla;
                    InfoPersona.pe_sexo = item.pe_sexo;
                    InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    InfoPersona.pe_estado = item.pe_estado;
                    info.InfoPersona = InfoPersona;

                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;
                    


                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;

                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;
                    info.MotivoAnulacion = item.MotivoAnulacion;
                    info.em_motivo_salisa = "";
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
             {
                 string arreglo = ToString();
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                 mensaje = ex.InnerException + " " + ex.Message;
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 throw new Exception(ex.InnerException.ToString());
             }
        }



        public ro_Empleado_Info GetInfoConsultaPorIdEmpleado(int idEmpresa, decimal idEmpleado)
        {
            try
            {

                EntitiesRoles db = new EntitiesRoles();
                var item = (from a in db.vwro_empleadoXdepXcargo
                            where a.IdEmpresa == idEmpresa && a.IdEmpleado == idEmpleado
                            select a).FirstOrDefault();


                ro_Empleado_Info info = new ro_Empleado_Info();

                // Datos del Empleado
                info.IdEmpresa = item.IdEmpresa;
                info.IdEmpleado = item.IdEmpleado;
                info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                info.IdPersona = item.IdPersona;
                info.IdSucursal = item.IdSucursal;
                info.IdTipoEmpleado = item.IdTipoEmpleado;
                info.em_codigo = item.em_codigo;
                info.em_lugarNacimiento = item.em_lugarNacimiento;
                info.em_CarnetIees = item.em_CarnetIees;
                info.em_cedulaMil = item.em_cedulaMil;
                info.em_fecha_ingreso = item.em_fechaIngaRol;
                info.em_fechaSalida = item.em_fechaSalida;
                info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                info.em_fechaIngaRol = item.em_fechaIngaRol;
                info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                info.em_tipoCta = item.em_tipoCta;
                info.em_NumCta = item.em_NumCta;
                info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                //info.em_estado = (item.em_estado == "A") ? true : false;
                info.em_estado = item.em_estado;

                info.em_foto = item.em_foto;
                info.em_empEspecial = item.em_empEspecial;
                info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                info.em_huella = item.em_huella;
                info.IdCodSectorial = item.IdCodSectorial;
                info.IdDepartamento = item.IdDepartamento;
                info.IdTipoSangre = item.IdTipoSangre;
                info.IdCargo = item.IdCargo;
                info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                info.IdUbicacion = item.IdUbicacion;
                info.em_mail = item.em_mail;
                info.IdTipoLicencia = item.IdTipoLicencia;
                info.IdCentroCosto = item.IdCentroCosto;
                info.IdBanco = item.IdBanco;

                info.Archivo = item.Archivo;//18112013 D
                info.NombreArchivo = item.NombreArchivo;//18112013 D
                //Derek 13/12/2013
                info.IdDivision = item.IdDivision;
                info.IdArea = item.IdArea;
                info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                info.ExcInc = "Incluir";

                // Datos de la Persona
                tb_persona_Info InfoPersona = new tb_persona_Info();
                InfoPersona.IdPersona = item.IdPersona;
                InfoPersona.CodPersona = item.CodPersona;
                InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                InfoPersona.pe_razonSocial = item.pe_razonSocial;
                InfoPersona.pe_apellido = item.Apellido;
                InfoPersona.pe_nombre = item.Nombre;
                InfoPersona.IdTipoPersona = item.IdTipoPersona;
                InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                InfoPersona.pe_direccion = item.pe_direccion;
                InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                InfoPersona.pe_celular = item.pe_celular;
                InfoPersona.pe_correo = item.pe_correo;
                InfoPersona.pe_fax = item.pe_fax;
                InfoPersona.pe_casilla = item.pe_casilla;
                InfoPersona.pe_sexo = item.pe_sexo;
                InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                InfoPersona.pe_estado = item.pe_estado;

                info.InfoPersona = InfoPersona;

                info.cargo_Descripcion = item.cargo;
                info.de_descripcion = item.departamento;
                info.Sucursal_Descripcion = item.Sucursal;
                info.NomCompleto = item.NomCompleto;

                //Datos adicionales
                info.por_discapacidad = item.por_discapacidad;
                info.carnet_conadis = item.carnet_conadis;
                info.recibi_uniforme = item.recibi_uniforme;
                info.talla_pant = item.talla_pant;
                info.talla_camisa = Convert.ToString(item.talla_camisa);
                info.talla_zapato = item.talla_zapato;
                info.Codigo_Biometrico = item.Codigo_Biometrico;
                info.em_status = item.em_status;

                info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;

                info.CodigoSectorialIESS = item.CodigoSectorialIESS;

                info.em_sueldoBasicoMen = GetSueldoActual(item.IdEmpresa, item.IdEmpleado);
                info.IdTipoAnticipo = item.IdTipoAnticipo;
                info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Empleado_Info> Get_List_Empleado_x_Empresa(int IdEmpresa)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == IdEmpresa
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;

                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   

                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.em_sueldoBasicoMen = GetSueldoActual(IdEmpresa, info.IdEmpleado);

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleado(int IdEmpresa, DateTime Fecha_Inicio,DateTime Fecha_Fin)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            DateTime FI = Convert.ToDateTime(Fecha_Inicio.ToShortDateString());
            DateTime FF = Convert.ToDateTime(Fecha_Fin.ToShortDateString());
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == IdEmpresa
                             && A.em_fechaIngaRol>=FI
                             && A.em_fechaIngaRol<=FF
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;

                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;

                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.em_sueldoBasicoMen = GetSueldoActual(IdEmpresa, info.IdEmpleado);

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> Get_Lis_Empleado_x_Departamento(int IdEmpresa, int IdDepartamento)
        {
            int Sec = 0;
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == IdEmpresa && A.IdDepartamento == IdDepartamento
                             orderby A.Apellido
                             select A;

                foreach (var item in select)
                {
                    Sec = Sec + 1;
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.Secuancia = Sec;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;

                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;

                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.em_sueldoBasicoMen = GetSueldoActual(IdEmpresa, info.IdEmpleado);

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public List<ro_Empleado_Info> Get_Lis_Empleado(int IdEmpresa, ro_Empleado_Info oRo_Empleado_Info)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == IdEmpresa && A.IdEmpleado == oRo_Empleado_Info.IdEmpleado
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   


                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.em_sueldoBasicoMen = GetSueldoActual(IdEmpresa, info.IdEmpleado);

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public ro_Empleado_Info Get_Info_Empleado_x_Persona(int IdEmpresa, decimal IdPersona)
        {
           

            try
            {
                ro_Empleado_Info info = new ro_Empleado_Info();

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == IdEmpresa && A.IdPersona == IdPersona
                             select A;

                foreach (var item in select)
                {
         
                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   


                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.em_sueldoBasicoMen = GetSueldoActual(IdEmpresa, info.IdEmpleado);

                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public double GetSueldoActual(int idEmpresa, decimal idEmpleado) 
        { 
            try
            {
                double valorRetornar = 0;

                valorRetornar = oHistoricoSueldoData.Get_List_HistoricoSueldo(idEmpresa, idEmpleado) .FirstOrDefault().SueldoActual;
            
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return 0;
            }
        }


        public bool Delete_Todos_Empleados(int idEmpresa,  ref string mensaje)
        {
            try
            {

                //EntitiesRoles OERol_Empleado = new EntitiesRoles();
                //decimal idEmpleado;

                //var select = from A in OERol_Empleado.ro_empleado
                //             where A.IdEmpresa == idEmpresa
                //             select A;

                //foreach (var item in select)
                //{
                //    idEmpleado = item.IdEmpleado;
                //    OERol_Empleado.Database.ExecuteSqlCommand("delete ro_empleado where IdEmpresa = " + idEmpresa + " and idEmpleado ='" + idEmpleado + "'");                

                //}


                EntitiesRoles OERol_Empleado = new EntitiesRoles();
                OERol_Empleado.Database.ExecuteSqlCommand("delete ro_empleado where IdEmpresa = " + idEmpresa );                

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> Get_List_Empleado_Info_PorNominaSaldoNegativo(int IdEmpresa, int IdNominaTipo)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();    
            
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.vwRo_Empleado_X_Nomina
                                 where a.IdEmpresa == IdEmpresa && a.IdTipoNomina==IdNominaTipo
                                 select a);

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;

                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   


                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }





        public List<ro_Empleado_Info> Get_List_Empleado_x_Nomina(int idEmpresa)





        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.vwRo_Empleado_X_Nomina
                                  where a.IdEmpresa == idEmpresa 
                                  select a);

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;
                        info.IdNomina_Tipo = item.IdTipoNomina;
                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Nomina = item.Nomina;
                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.Apellido + " " + item.Nombre;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;


                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Empleado_Info> Get_List_Empleado_x_Nomina(int idEmpresa,int IdTipoNomina)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.vwRo_Empleado_X_Nomina
                                  where a.IdEmpresa == idEmpresa && a.IdTipoNomina == IdTipoNomina
                                  select a);

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;
                        info.IdNomina_Tipo = item.IdTipoNomina;
                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Nomina = item.Nomina;
                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;


                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public double CalcularDiasDeDiferencia(DateTime primerFecha, DateTime segundaFecha)
        {
            try
            {
                TimeSpan diferencia;
                diferencia = primerFecha - segundaFecha;

                return Math.Abs(diferencia.Days);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
            
        }


        public List<ro_Empleado_Info> Get_List_Empleado_x_NominaSueldoDigno(int idEmpresa, int idNominaTipo, double sueldoDigno, int anio)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    //var select = (from a in db.vwRo_Empleado_X_Nomina
                    //              join b in db.ro_empleado_x_ro_tipoNomina on a.IdEmpleado equals b.IdEmpleado
                    //              where a.IdEmpresa == idEmpresa && b.IdTipoNomina == idNominaTipo
                    //              select a);


                    var select = (from a in db.vwRo_Empleado_X_Nomina
                                  where a.IdEmpresa == idEmpresa && a.IdTipoNomina == idNominaTipo
                                  select a);

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;

                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   


                        //SUELDO DIGNO
                        ro_Rol_Detalle_Data oRo_Rol_Detalle_Data = new ro_Rol_Detalle_Data();
                        ro_Participacion_Utilidad_Empleado_Data oRo_Participacion_Utilidad_Empleado_Data = new Roles.ro_Participacion_Utilidad_Empleado_Data();

                        info.totSueldo = oRo_Rol_Detalle_Data.GetListConsultaPorNominaRubro(idEmpresa, info.IdEmpleado, idNominaTipo, "4", ref mensaje).Where(v => v.pe_anio == anio).Sum(v => v.Valor); //4
                        info.totDecimoCuarto = oRo_Rol_Detalle_Data.GetListConsultaPorNominaRubro(idEmpresa, info.IdEmpleado, idNominaTipo, "200", ref mensaje).Where(v => v.pe_anio == anio).Sum(v => v.Valor);
                        info.totDecimoTercer = oRo_Rol_Detalle_Data.GetListConsultaPorNominaRubro(idEmpresa, info.IdEmpleado, idNominaTipo, "290", ref mensaje).Where(v => v.pe_anio == anio).Sum(v => v.Valor);
                        info.totFondoReserva = oRo_Rol_Detalle_Data.GetListConsultaPorNominaRubro(idEmpresa, info.IdEmpleado, idNominaTipo, "296", ref mensaje).Where(v => v.pe_anio == anio).Sum(v => v.Valor);
                        

                        //info.totUtilidad = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, idNominaTipo, "550", ref mensaje).Where(v => v.pe_anio == anio).Sum(v => v.Valor);
                        info.totUtilidad =oRo_Participacion_Utilidad_Empleado_Data.GetListPorIdEmpleado(info.IdEmpresa,info.IdEmpleado, ref mensaje).Where(v=>v.IdPeriodo==anio).Sum(v=>v.ValorTotal);
                        
                        info.totIngreso = info.totSueldo + info.totDecimoCuarto + info.totDecimoTercer + info.totFondoReserva + info.totUtilidad;
                        info.sueldoDigno = sueldoDigno;

                        double diasTra = CalcularDiasDeDiferencia(Convert.ToDateTime(info.em_fecha_ingreso),Convert.ToDateTime( "31/12/"+anio.ToString()));
                        if (diasTra >= 360) //VERIFICA SI TIENE MAS DE UN AÑO EN LA EMPRESA
                        {
                            info.totSueldoDigno = sueldoDigno * 12;                        
                        }else{//CALCULA EL PROPORCIONAL 
                            info.totSueldoDigno = (sueldoDigno / 30) * diasTra;
                        }


                        if (info.totIngreso >= info.totSueldoDigno)
                        {
                            info.compensacion = 0;
                        }else{
                            info.compensacion = info.totSueldoDigno - info.totIngreso;
                        }

                        info.proporcionalUtilidad = 0;
                        info.valorEntregar = 0;

                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> GetListConsultaPorPeriodoRDEP(int idEmpresa, int idPeriodo)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.sp_RO_ERDP(idEmpresa,Convert.ToString(idPeriodo))
                                   
                                  select a);

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdCargo = item.IdCargo;
                        info.IdUbicacion = item.IdUbicacion;





                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;

                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   



                        ro_Rol_Detalle_Data oRo_Rol_Detalle_Data = new ro_Rol_Detalle_Data();
                        if(item.tot_Sueldo_Ganado!=null)
                        info.totSueldo = (double) item.tot_Sueldo_Ganado;
                        if (item.tot_decimo_cuarto != null)
                        info.totDecimoCuarto =(double) item.tot_decimo_cuarto;
                        if (item.tot_decimo_tercero != null)
                        info.totDecimoTercer = (double)item.tot_decimo_tercero;
                        if (item.tot_fondo_reserva != null)
                        info.totFondoReserva = (double)item.tot_fondo_reserva;

                        //OBTENER UTILIDAD
                        if (item.tot_utilidad != null)
                        info.totUtilidad = (double)item.tot_utilidad;

                        //OBTENER COMISIONES
                        info.totComision =Convert.ToDouble( "0.00");

                        //OBTENER HORAS EXTRAS
                        if (item.tot_horasExtras != null)
                        info.totHoraExtra = (double)item.tot_horasExtras;
                        if (item.tot_ingreso != null)
                        info.totIngreso = (double)item.tot_ingreso;

                        //OBTENER SUELDO DIGNO
                        ro_Salario_Digno_Empleado_Data oRo_Salario_Digno_Empleado_Data = new ro_Salario_Digno_Empleado_Data();
                        List<ro_Salario_Digno_Empleado_Info> oListRo_Salario_Digno_Empleado_Info = new List<ro_Salario_Digno_Empleado_Info>();
                        oListRo_Salario_Digno_Empleado_Info = oRo_Salario_Digno_Empleado_Data.GetListConsultaPorIdEmpleado(info.IdEmpresa, info.IdEmpleado, idPeriodo, ref mensaje);

                        info.totSueldoDigno = oListRo_Salario_Digno_Empleado_Info.Sum(v=>v.Valor);
                        
                        ro_empleado_x_Proyeccion_Gastos_Personales_Data oRo_empleado_x_Proyeccion_Gastos_Personales_Data = new Roles.ro_empleado_x_Proyeccion_Gastos_Personales_Data();

                        if (item.tot_vivienda != null)
                        info.totGastoVivienda = (double)item.tot_vivienda;
                        if (item.tot_vivienda != null)
                        info.totGastoVestimenta = (double)item.tot_vivienda;
                        if (item.tot_salud != null)
                        info.totGastoSalud = (double)item.tot_salud;
                        if (item.tot_educacion != null)
                        info.totGastoEducacion = (double)item.tot_educacion;
                        if (item.tot_alimentacion != null)
                        info.totGastoAlimentacion = (double)item.tot_alimentacion;

                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }






        public ro_Empleado_Info GetInfoPorEmpleadoRDEP(int idEmpresa,decimal idEmpleado, int anioFiscal, ref string msg)
        {
            ro_Empleado_Info info = new ro_Empleado_Info();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var datos = (from a in db.vwro_empleadoXdepXcargo
                                             join b in db.ro_empleado_x_ro_tipoNomina on a.IdEmpleado equals b.IdEmpleado
                                             where a.IdEmpresa == idEmpresa && a.IdEmpleado == idEmpleado
                                             select a);

                    foreach (var item in datos)
                    {
                    
                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;

                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   



                        ro_Rol_Detalle_Data oRo_Rol_Detalle_Data = new ro_Rol_Detalle_Data();

                        info.totSueldo = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "4", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor); //4
                        info.totDecimoCuarto = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "200", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor);
                        info.totDecimoTercer = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "199", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor);
                        info.totFondoReserva = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "198", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor);

                        //OBTENER UTILIDAD
                        ro_Participacion_Utilidad_Empleado_Data oRo_Participacion_Utilidad_Empleado_Data = new Roles.ro_Participacion_Utilidad_Empleado_Data();
                        info.totUtilidad = oRo_Participacion_Utilidad_Empleado_Data.GetListPorIdEmpleado(info.IdEmpresa, info.IdEmpleado, ref mensaje).Where(v => v.IdPeriodo == anioFiscal).Sum(v => v.ValorTotal);

                        //OBTENER COMISIONES
                        info.totComision = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "400", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor);

                        //OBTENER HORAS EXTRAS
                        info.totHoraExtra = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "966", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor);

                        info.totIngreso = info.totSueldo + info.totDecimoCuarto + info.totDecimoTercer + info.totFondoReserva + info.totUtilidad + info.totComision + info.totHoraExtra;

                        info.totIESS = oRo_Rol_Detalle_Data.GetListConsultaPorRubro(idEmpresa, info.IdEmpleado, "6", ref mensaje).Where(v => v.pe_anio == anioFiscal).Sum(v => v.Valor);



                        //OBTENER SUELDO DIGNO
                        ro_Salario_Digno_Empleado_Data oRo_Salario_Digno_Empleado_Data = new ro_Salario_Digno_Empleado_Data();
                        List<ro_Salario_Digno_Empleado_Info> oListRo_Salario_Digno_Empleado_Info = new List<ro_Salario_Digno_Empleado_Info>();
                        oListRo_Salario_Digno_Empleado_Info = oRo_Salario_Digno_Empleado_Data.GetListConsultaPorIdEmpleado(info.IdEmpresa, info.IdEmpleado, anioFiscal, ref mensaje);

                        info.totSueldoDigno = oListRo_Salario_Digno_Empleado_Info.Sum(v => v.Valor);



                        //OBTENER GASTOS PERSONALES
                        ro_empleado_x_Proyeccion_Gastos_Personales_Data oRo_empleado_x_Proyeccion_Gastos_Personales_Data = new Roles.ro_empleado_x_Proyeccion_Gastos_Personales_Data();

                        info.totGastoVivienda = oRo_empleado_x_Proyeccion_Gastos_Personales_Data.Get_Info_empleado_x_Proyeccion_Gastos_Personales(item.IdEmpresa, item.IdEmpleado, "ALI", anioFiscal).Valor;
                        info.totGastoVestimenta = oRo_empleado_x_Proyeccion_Gastos_Personales_Data.Get_Info_empleado_x_Proyeccion_Gastos_Personales(item.IdEmpresa, item.IdEmpleado, "VES", anioFiscal).Valor;
                        info.totGastoSalud = oRo_empleado_x_Proyeccion_Gastos_Personales_Data.Get_Info_empleado_x_Proyeccion_Gastos_Personales(item.IdEmpresa, item.IdEmpleado, "SA", anioFiscal).Valor;
                        info.totGastoEducacion = oRo_empleado_x_Proyeccion_Gastos_Personales_Data.Get_Info_empleado_x_Proyeccion_Gastos_Personales(item.IdEmpresa, item.IdEmpleado, "EDU", anioFiscal).Valor;
                        info.totGastoAlimentacion = oRo_empleado_x_Proyeccion_Gastos_Personales_Data.Get_Info_empleado_x_Proyeccion_Gastos_Personales(item.IdEmpresa, item.IdEmpleado, "VIV", anioFiscal).Valor;

                    ////    oListadoInfo.Add(info);
                    }

                }

                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }






        public List<ro_Empleado_Info> GetListConsultaUtilidad(int idEmpresa, int anio)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.vwro_empleadoXdepXcargo
                                  where a.IdEmpresa == idEmpresa 
                                  && a.em_estado=="A"
                                  select a);

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;

                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   


                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }





        public ro_Empleado_Info Get_Info_Empleado_x_IdEmpleado(int IdEmpresa, decimal IdEmpleado)
        {
            ro_Empleado_Info info = new ro_Empleado_Info();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.vwro_empleadoXdepXcargo
                                  where a.IdEmpresa == IdEmpresa && a.IdEmpleado==IdEmpleado
                                  select a);

                    foreach (var item in select)
                    {
                      
                        // Datos del Empleado
                        info.IdEmpresa = item.IdEmpresa;
                      
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.IdTipoEmpleado = item.IdTipoEmpleado;
                        info.em_codigo = item.em_codigo;
                        info.em_lugarNacimiento = item.em_lugarNacimiento;
                        info.em_CarnetIees = item.em_CarnetIees;
                        info.em_cedulaMil = item.em_cedulaMil;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                        info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                        info.em_estado = item.em_estado;
                        info.em_foto = item.em_foto;
                        info.em_empEspecial = item.em_empEspecial;
                        info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                        info.em_huella = item.em_huella;
                        info.IdCodSectorial = item.IdCodSectorial;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdTipoSangre = item.IdTipoSangre;
                        info.IdCargo = item.IdCargo;
                        info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                        info.IdUbicacion = item.IdUbicacion;
                        info.em_mail = item.em_mail;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdBanco = item.IdBanco;

                        info.Archivo = item.Archivo;//18112013 D
                        info.NombreArchivo = item.NombreArchivo;//18112013 D
                        //Derek 13/12/2013
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        info.ExcInc = "Incluir";

                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.CodPersona = item.CodPersona;
                        info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                        info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.InfoPersona.pe_direccion = item.pe_direccion;
                        info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                        info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.InfoPersona.pe_celular = item.pe_celular;
                        info.InfoPersona.pe_correo = item.pe_correo;
                        info.InfoPersona.pe_fax = item.pe_fax;
                        info.InfoPersona.pe_casilla = item.pe_casilla;
                        info.InfoPersona.pe_sexo = item.pe_sexo;
                        info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                        info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.InfoPersona.pe_estado = item.pe_estado;

                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;

                        //Datos adicionales
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.recibi_uniforme = item.recibi_uniforme;
                        info.talla_pant = item.talla_pant;
                        info.talla_camisa = Convert.ToString(item.talla_camisa);
                        info.talla_zapato = item.talla_zapato;
                        info.Codigo_Biometrico = item.Codigo_Biometrico;
                        info.em_status = item.em_status;

                        info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                        info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                        info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                        info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                        info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                        info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   


                        info.em_sueldoBasicoMen = GetSueldoActual(item.IdEmpresa, item.IdEmpleado);
   
                    }

                }

                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


      
    public  int ConsultaDiasVacaciones(DateTime fechaI, DateTime fechaH)
           {
               try
               {
                        DateTime fechaIng = new DateTime();
                        DateTime fechaEstimada = new DateTime();
                        DateTime fechaHoy = new DateTime();

                        fechaIng = fechaI;
                        fechaHoy = fechaH;

                        int diferenciaDias = -1;
                        int anio = 0;
                        int diasganados = 0;

                        int anioHoy = (fechaHoy.Year);

                        int suma = 0;

                        while (diferenciaDias < 0)
                        {
                            if (diferenciaDias < 0)
                            {
                                if (anio != anioHoy)
                                {
                                    fechaEstimada = fechaIng.AddYears(1);
                                    TimeSpan dias = fechaEstimada - fechaHoy;
                                    diferenciaDias = dias.Days;

                                    diasganados = 15;

                                    suma = suma + diasganados;              
                                }

                                else
                                {
                                    fechaEstimada = fechaHoy;
                                    TimeSpan dias = fechaEstimada - fechaIng;
                                    diferenciaDias = dias.Days;
                                                               
                                    double r = 0;
                                    r = (diferenciaDias * 100) / 365;
                                    double d = 0;
                                    d = Math.Round(((r * 15) / 100), 0);
                                    int x = Convert.ToInt32(d);

                                    suma = suma + x;                
                                }
                            }
                            fechaEstimada = fechaEstimada.AddDays(1);
                            fechaIng = fechaEstimada;
                            anio = (fechaIng.Year);
                        }
                        return suma;
               }
               catch (Exception ex)
               {
                   string arreglo = ToString();
                   tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                   mensaje = ex.InnerException + " " + ex.Message;
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   throw new Exception(ex.InnerException.ToString());
               }    
        
        }

        public List<ro_Empleado_Info> Get_List_Empleados_x_Periodo(int IdEmpresa, int IdPeriodo)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();
          

                var select = from A in OERol_Empleado.vwRo_Cargo_Empleado_X_Periodo
                             where A.IdEmpresa == IdEmpresa 
                             && A.Id_Periodo == IdPeriodo
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();


                    // info.IdEmpresa = item.IdEmpresa;

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.Id_Periodo = item.Id_Periodo;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    //info.em_tipoLiquidacion = item.em_tipoLiquidacion;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;
                   
                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.ExcInc = "Incluir";

                    info.check = true;

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;

                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_pant = item.talla_pant;
                    info.talla_zapato = item.talla_zapato;

                   // info.em_AcumulaXIII = item.em_AcumulaXIII;
                    //info.em_AcumulaXIV = item.em_AcumulaXIV;
                    //info.em_AcumulaFR = item.em_AcumulaFR;
            
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleado_(int IdEmpresa)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.VWRO_empleado
                             where A.IdEmpresa == IdEmpresa
                             &&A.em_estado=="A"
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();
                    
                    //Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdNomina_Tipo = item.IdTipoNomina;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;

                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                   
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;
                    info.em_status = item.em_status;

                    
                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;

                    info.IdUbicacion = item.IdCiudad;
                    info.IdPais = item.IdPais;
                    info.IdProvincia = item.IdProvincia;

                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;
                    info.pe_NomCompleto = item.pe_apellido + " " + item.pe_nombre;
                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.em_estado = item.em_estado;
                    info.cargo = item.ca_descripcion;
                    info.de_descripcion = item.Departamento;
                    info.IdNomina_Tipo = Convert.ToInt32(item.IdTipoNomina);
                    info.IdGrupo = item.IdGrupo;
                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    //Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.pe_nombreCompleto = item.pe_apellido+" "+item.pe_nombre;
                    info.InfoPersona.pe_apellido = item.pe_apellido;
                    info.InfoPersona.pe_nombre = item.pe_nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.Codigo;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                  

                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_pant = item.talla_pant;
                    info.talla_zapato = item.talla_zapato;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.Marca_Biometrico = item.Marca_Biometrico;
                    info.em_motivo_salisa = item.em_motivo_salisa;
                    info.EstadoEmpleado = item.EstadoEmpleado;
                    info.Nomina = item.Nomina;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Empleado_Info> Get_List_Solicitud_Tarjeta(int IdEmpresa, int IdTipoNominaIni, int IdTipoNominaFin, int IdDepartamentoIni, int IdDepartamentoFin, string em_status, ref string mensaje)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from q in OERol_Empleado.VWRO_empleado
                             where q.IdEmpresa == IdEmpresa
                             && q.IdTipoNomina >= IdTipoNominaIni
                             && q.IdTipoNomina <= IdTipoNominaFin
                             && q.IdDepartamento>=IdDepartamentoIni
                             && q.IdDepartamento<=IdDepartamentoFin
                             && q.em_status.Contains(em_status)
                             select q;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();
                    //Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    //info.em_tipoLiquidacion = item.em_tipoLiquidacion;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    //haac 02/01/2014
                    info.Codigo_Biometrico = item.Codigo_Biometrico;

                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;
                    info.em_status = item.em_status;
                    //info.em_estado = (item.em_estado == "A") ? true : false;
                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;

                    info.IdUbicacion = item.IdCiudad;
                    info.IdPais = item.IdPais;
                    info.IdProvincia = item.IdProvincia;

                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;
                    info.pe_NomCompleto = item.pe_apellido + " " + item.pe_nombre;
                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.em_estado = item.em_estado;
                    info.cargo = item.ca_descripcion;
                    info.de_descripcion = item.Departamento;
                    info.IdNomina_Tipo = Convert.ToInt32(item.IdTipoNomina);

                    //Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                    info.InfoPersona.pe_apellido = item.pe_apellido;
                    info.InfoPersona.pe_nombre = item.pe_nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.Codigo;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_pant = item.talla_pant;
                    info.talla_zapato = item.talla_zapato;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleado_persona(int IdEmpresa)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.VWRO_empleado 
                             where A.IdEmpresa == IdEmpresa
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.em_codigo = item.em_codigo;
                    info.InfoPersona.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                    info.NomCompleto = item.pe_apellido + " " + item.pe_nombre; ;
                    info.Archivo = item.Archivo;//18112013 D
                    info.InfoPersona.pe_apellido = item.pe_apellido;
                    info.InfoPersona.pe_nombre = item.pe_nombre;
                    info.em_codigo = item.em_codigo; 
                    if (item.NombreArchivo == null)
                    {
                        info.NombreArchivo = null;                    
                    }

                    else
                    {
                        info.NombreArchivo = item.NombreArchivo.Trim();//18112013 D
                    }
                                                          
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.pe_cedulaRuc = item.pe_cedulaRuc;
                    
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Empleado_Info> Get_List_Empleados_Decimos(int IdEmpresa, int IdNomina_Tipo, string IdRubro,int IdPeriodoIni, int IdPeriodoFin)
        {
                List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();
            try
            {
                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select1 =
                from p in OERol_Empleado.ro_Ing_Egre_x_Empleado
                where p.IdEmpresa == IdEmpresa && p.IdRubro == IdRubro && p.IdNomina_Tipo == IdNomina_Tipo
                // && p.IdEmpleado == IdEmpleado
                && (p.IdPeriodo >= IdPeriodoIni && p.IdPeriodo <= IdPeriodoFin)
                && p.IngEgr == "I"
              group p by new
             {
              p.IdEmpresa,
              p.IdEmpleado,
              p.IdNomina_Tipo

             } into g
             select new { Category = g.Key, valor = g.Sum(p => p.Valor) };


                if (select1.Count() != 0)
                {

                    var select = from A in OERol_Empleado.VWRO_empleado
                                 where A.IdEmpresa == IdEmpresa
                                 select A;

                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;

                        info.em_codigo = item.em_codigo;
                        info.pe_NomCompleto = item.pe_apellido + " " + item.pe_apellido;
                        info.Valor_Decimo_XIII = Convert.ToDouble(Calculo_Decimos_Empleados(item.IdEmpresa, IdNomina_Tipo, IdRubro, item.IdEmpleado, IdPeriodoIni, IdPeriodoFin));



                        lM.Add(info);
                    }
                }
                else
                {
                                  
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }// haac 10/01/2014

        public Nullable<double> Calculo_Decimos_Empleados(int IdEmpresa, int IdNomina_Tipo, string IdRubro,decimal IdEmpleado, int IdPeriodoIni, int IdPeriodoFin)
        {
            try
            {

                double valor = 0;
            EntitiesRoles ORol = new EntitiesRoles();


            var select =
               from p in ORol.ro_Ing_Egre_x_Empleado
               where p.IdEmpresa == IdEmpresa && p.IdRubro == IdRubro && p.IdNomina_Tipo ==IdNomina_Tipo 
               && p.IdEmpleado==IdEmpleado
               && (p.IdPeriodo >= IdPeriodoIni && p.IdPeriodo <= IdPeriodoFin)
               && p.IngEgr == "I"
               group p by new
               {
                   p.IdEmpresa,
                   p.IdEmpleado,
                   p.IdNomina_Tipo

               } into g
               select new { Category = g.Key, valor = g.Sum(p => p.Valor) };
                 
            ro_Pago_decimos_x_Empleado_Info Reg = new ro_Pago_decimos_x_Empleado_Info();

          
                foreach (var item in select)
                {
                    Reg.Total_ganado = Math.Round(item.valor,2);

                }
                valor = Reg.Total_ganado;
         
            return valor;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_Empleado_Info Get_Info_Empleado(int IdEmpresa,decimal IdEmpleado)
        {
                ro_Empleado_Info info = new ro_Empleado_Info();
                EntitiesRoles db = new EntitiesRoles();
            try
            {

                var select = from A in db.vwro_empleadoXdepXcargo 
                             where A.IdEmpresa == IdEmpresa && A.IdEmpleado == IdEmpleado
                             select A;

                foreach (var item in select)
                {
                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    //info.em_estado = (item.em_estado == "A") ? true : false;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;
                    info.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;



                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   



                }
                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean ModificarDB(int IdEmpresa,int IdEmpleado, DateTime FechaRol,DateTime FechaIng)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado.First(obj => obj.IdEmpresa == IdEmpresa && obj.IdEmpleado == IdEmpleado);

                    contact.em_fechaIngaRol = FechaRol;
                    contact.em_fecha_ingreso = FechaIng;
                    context.SaveChanges();
                }


               

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }




        
        public Boolean ModificarDB(ro_Empleado_Info info,ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado.First(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdEmpleado == info.IdEmpleado);

                    contact.IdEmpleado_Supervisor = info.IdEmpleado_Supervisor;
                    contact.IdPersona = info.IdPersona;
                    contact.IdSucursal = info.IdSucursal;
                    contact.IdTipoEmpleado = info.IdTipoEmpleado;
                    contact.em_codigo = info.em_codigo;
                    contact.em_lugarNacimiento = info.em_lugarNacimiento;
                    contact.em_CarnetIees = info.em_CarnetIees;
                    contact.em_cedulaMil = info.em_cedulaMil;
                    contact.em_fecha_ingreso = info.em_fecha_ingreso;
                    contact.em_fechaSalida = info.em_fechaSalida;
                    contact.em_fechaTerminoContra = info.em_fechaTerminoContra;
                    contact.em_fechaIngaRol = info.em_fechaIngaRol;
                    contact.em_SeAcreditaBanco = info.em_SeAcreditaBanco;
                    contact.em_tipoCta = info.em_tipoCta;
                    contact.em_NumCta = info.em_NumCta;
                    contact.em_estado = info.em_estado;
                    contact.em_foto = info.em_foto;
                    contact.em_empEspecial = info.em_empEspecial;
                    //contact.em_pagoFdoRsv = info.em_pagoFdoRsv;
                    contact.em_huella = info.em_huella;
                    contact.IdCodSectorial = info.IdCodSectorial;
                    contact.IdDepartamento = Convert.ToInt32(info.IdDepartamento);
                    contact.IdTipoSangre = info.IdTipoSangre;
                    contact.IdCargo = info.IdCargo;

                    if (info.IdCtaCble_Emplea == "")
                    {

                        contact.IdCtaCble_Emplea = null;
                    }
                    else
                    {
                        contact.IdCtaCble_Emplea = info.IdCtaCble_Emplea;
                    }
                    contact.IdCiudad = info.IdUbicacion;
                    contact.em_mail = info.em_mail;
                    contact.IdTipoLicencia = info.IdTipoLicencia;
                    contact.IdBanco = info.IdBanco;
                    contact.Archivo = info.Archivo;//18112013 D
                    contact.NombreArchivo = info.NombreArchivo;//18112013 D                    

                    contact.IdDivision = info.IdDivision;
                    contact.IdArea = info.IdArea;

                    //Datos adicionales 
                    contact.por_discapacidad = info.por_discapacidad;
                    contact.carnet_conadis = info.carnet_conadis;
                    contact.recibi_uniforme = info.recibi_uniforme;
                    contact.talla_pant = info.talla_pant;
                    contact.talla_camisa = info.talla_camisa;
                    contact.talla_zapato = info.talla_zapato;
                    contact.em_status = info.em_status;
                    contact.IdCentroCosto = info.IdCentroCosto;
                    contact.IdCondicionDiscapacidadSRI = info.IdCondicionDiscapacidadSRI;
                    contact.IdTipoIdentDiscapacitadoSustitutoSRI = info.IdTipoIdentDiscapacitadoSustitutoSRI;
                    contact.IdentDiscapacitadoSustitutoSRI = info.IdentDiscapacitadoSustitutoSRI;
                    contact.IdAplicaConvenioDobleImposicionSRI = info.IdAplicaConvenioDobleImposicionSRI;
                    contact.IdTipoResidenciaSRI = info.IdTipoResidenciaSRI;
                    contact.IdTipoSistemaSalarioNetoSRI = info.IdTipoSistemaSalarioNetoSRI;
                    contact.es_AcreditaHorasExtras = info.es_AcreditaHorasExtras;
                    contact.IdTipoAnticipo = info.IdTipoAnticipo;
                    contact.em_AnticipoSueldo = info.em_AnticipoSueldo;
                    contact.CodigoSectorial = info.CodigoSectorialIESS;
                    contact.es_TruncarDecimalAnticipo = info.es_TruncarDecimalAnticipo;                   

                    contact.Codigo_Biometrico = info.Codigo_Biometrico;

                    contact.IdUsuarioUltModi=info.IdUsuarioUltModi;
                    contact.Fecha_UltMod=info.Fecha_UltMod;
                    contact.MotivoAnulacion = "";
                    contact.IdGrupo = info.IdGrupo;
                    contact.Marca_Biometrico = info.Marca_Biometrico;
                    contact.em_motivo_salisa = info.em_motivo_salisa;
                    contact.em_fecha_ingreso = info.em_fechaIngaRol;
                    contact.em_fechaIngaRol = info.em_fechaIngaRol;

                    context.SaveChanges();

                }


                tb_persona_data Pd = new tb_persona_data();
                //Pd.ModificaPersEmpl(info.InfoPersona);
                msg = "Se ha procedido actualizar el registro del Empleado #: " + info.IdEmpleado.ToString() + " exitosamente";

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

     


        //obtener id de un empleado
        public decimal GetId(int IdEmpresa)
        {
            decimal Id = 0;
            
            try
            {
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = (from q in OEEmpleado.ro_empleado
                             where q.IdEmpresa == IdEmpresa
                             select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_empleado
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdEmpleado).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            } 
        }

       
        
  


        public Boolean GrabarDB(ro_Empleado_Info info, ref decimal id, ref string msg)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    if (GetSiExisteEmpleado(info))
                    {

                        var address = new ro_empleado();
                        info.IdEmpleado = id = GetId(info.IdEmpresa);
                        //ASIGNA UN CODIGO MANUAL EN CASO QUE NO HAYA SIDO INGRESADO
                        info.em_codigo = (info.em_codigo == "" || info.em_codigo == null ? Convert.ToString(info.IdEmpleado) : info.em_codigo);
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdEmpleado = info.IdEmpleado;
                        address.IdEmpleado_Supervisor = info.IdEmpleado_Supervisor;
                        address.IdPersona = info.IdPersona;
                        address.IdSucursal = info.IdSucursal;
                        address.IdTipoEmpleado = info.IdTipoEmpleado;
                        address.em_codigo = info.em_codigo;
                        address.em_lugarNacimiento = info.em_lugarNacimiento;
                        address.em_CarnetIees = info.em_CarnetIees;
                        address.em_cedulaMil = info.em_cedulaMil;
                        address.em_fecha_ingreso = info.em_fecha_ingreso;
                        address.em_fechaSalida = info.em_fechaSalida;
                        address.em_fechaTerminoContra = info.em_fechaTerminoContra;
                        address.em_fechaIngaRol = info.em_fechaIngaRol;
                        address.em_SeAcreditaBanco = info.em_SeAcreditaBanco;
                        address.em_tipoCta = info.em_tipoCta;
                        address.em_NumCta = info.em_NumCta;
                        address.em_estado = "A";
                        address.em_foto = info.em_foto;
                        address.em_empEspecial = info.em_empEspecial;
                        address.em_pagoFdoRsv = info.em_pagoFdoRsv;
                        address.em_huella = info.em_huella;
                        address.IdCodSectorial = info.IdCodSectorial;
                        address.IdDepartamento = Convert.ToInt32(info.IdDepartamento);
                        address.IdTipoSangre = info.IdTipoSangre;
                        address.IdCargo = info.IdCargo;
                        address.IdCtaCble_Emplea = info.IdCtaCble_Emplea;
                        if (info.IdUbicacion == null)
                        {
                            info.IdUbicacion = "09";
                        }
                        else
                        {
                            address.IdCiudad = info.IdUbicacion.ToString().PadLeft(2,'0');

                        }
                        address.em_mail = info.em_mail;
                        address.IdTipoLicencia = info.IdTipoLicencia;
                        address.IdCentroCosto = info.IdCentroCosto;
                        address.IdBanco = info.IdBanco;
                        address.Archivo = info.Archivo;
                        address.NombreArchivo = info.NombreArchivo;
                        address.IdDivision = info.IdDivision;
                        address.IdArea = info.IdArea;
                        address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        address.por_discapacidad = info.por_discapacidad;
                        address.carnet_conadis = info.carnet_conadis;
                        address.recibi_uniforme = info.recibi_uniforme;
                        address.Codigo_Biometrico = info.Codigo_Biometrico;
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transaccion = info.Fecha_Transaccion;
                        address.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        address.Fecha_UltMod = info.Fecha_UltMod;
                        address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.por_discapacidad = info.por_discapacidad;
                        address.carnet_conadis = info.carnet_conadis;
                        address.recibi_uniforme = info.recibi_uniforme;
                        address.talla_pant = info.talla_pant;
                        address.talla_camisa = info.talla_camisa;
                        address.talla_zapato = info.talla_zapato;
                        //address.em_status = info.em_status;
                        address.em_status = "EST_ACT";

                        address.IdCondicionDiscapacidadSRI = info.IdCondicionDiscapacidadSRI;
                        address.IdTipoIdentDiscapacitadoSustitutoSRI = info.IdTipoIdentDiscapacitadoSustitutoSRI;
                        address.IdentDiscapacitadoSustitutoSRI = info.IdentDiscapacitadoSustitutoSRI;
                        address.IdAplicaConvenioDobleImposicionSRI = info.IdAplicaConvenioDobleImposicionSRI;
                        address.IdTipoResidenciaSRI = info.IdTipoResidenciaSRI;
                        address.IdTipoSistemaSalarioNetoSRI = info.IdTipoSistemaSalarioNetoSRI;
                        address.es_AcreditaHorasExtras = info.es_AcreditaHorasExtras;
                        address.IdTipoAnticipo = info.IdTipoAnticipo;
                        address.em_AnticipoSueldo = info.em_AnticipoSueldo;
                        address.CodigoSectorial = info.CodigoSectorialIESS;
                        address.es_TruncarDecimalAnticipo = info.es_TruncarDecimalAnticipo;
                        address.em_SepagaBeneficios = "N";
                        address.em_SePagaConTablaSec = "N";
                        address.IdGrupo = info.IdGrupo;
                        address.Marca_Biometrico = info.Marca_Biometrico;
                        try
                        {
                        context.ro_empleado.Add(address);
                        context.SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            
                            
                        }
                        msg = "Se ha procedido a grabar el registro del Empleado #: " + id.ToString() + " exitosamente.";
                        return true;
                    }
                    else
                    {
                        msg = "registro del Empleado #: " + id.ToString() + " Ya Existe en la Base de Dato.";
                        return false;
                    }
               
                }
                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }






        public Boolean AnularDB(ro_Empleado_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado.First(obj => obj.IdEmpleado == info.IdEmpleado && obj.IdEmpresa==info.IdEmpresa);
                    contact.em_estado = "I" ;
                    contact.MotivoAnulacion = info.MotivoAnulacion;
                    context.SaveChanges();
                    msg = "Se ha procedido anular el ID del empleado #: " + info.IdEmpleado.ToString() + " exitosamente";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ExisteEmpleado(int idempresa, decimal idpersona)
        {

            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_empleado
                             where A.IdEmpresa == idempresa && A.IdPersona == idpersona
                             select A;

                foreach (var item in select)
                {
                    Existe = true;
                }

                return Existe;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_Empleado_Info Get_Info_Empleado_vs_Persona(int idempresa, decimal idpersona)
        {
                ro_Empleado_Info info = new ro_Empleado_Info();
                EntitiesRoles OERol_Empleado = new EntitiesRoles();
            try
            {
                var select = from A in OERol_Empleado.ro_empleado
                             where A.IdEmpresa == idempresa && A.IdPersona == idpersona
                             select A;

                foreach (var item in select)
                {
                    //Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;
                    
                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdCiudad;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;

                    info.Archivo=item.Archivo;
                    info.NombreArchivo = item.NombreArchivo;
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_camisa = item.talla_camisa;
                    info.talla_pant = item.talla_pant;
                    info.talla_zapato = item.talla_zapato;
                    info.em_status = item.em_status;
                    

                }
                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_Empleado_Data(){}


        public decimal ContarEmpleados(int IdEmpresa)
        {
            decimal contador=0;
            try
            {
                EntitiesRoles OEEmpleado = new EntitiesRoles();

                contador = (from prod in OEEmpleado.ro_empleado
                            where prod.IdEmpresa == IdEmpresa
                            select prod).Count();
                return contador;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }                                                          
        }

    
        public Nullable<int> ObtenerDiasTomados(int IdEmpresa, decimal IdEmpleado, DateTime fechaIng, DateTime fechaHoy)
        {

            try
            {
                EntitiesRoles ORol = new EntitiesRoles();

                //var item = ORol.ro_Solicitud_Vacaciones.First(A => A.IdEmpresa == IdEmpresa
                             
                //              && A.IdEmpleado == IdEmpleado);
   
                 var select =
                    from p in ORol.ro_Solicitud_Vacaciones_x_empleado
                    where p.IdEmpleado == IdEmpleado && p.IdEmpresa == p.IdEmpresa && (p.Fecha >= fechaIng && p.Fecha <= fechaHoy)
                    && p.IdEstadoAprobacion=="Aprobado"
                    group p by new 
                    {
                      p.IdEmpresa,p.IdEmpleado
                    
                    }into g
                    select new { Category = g.Key, dias = g.Sum(p => p.Dias_a_disfrutar) };
            
                ro_SolicitudVacaciones_Info Reg = new ro_SolicitudVacaciones_Info();

                foreach (var item in select)
                {

                    Reg.IdEmpresa = IdEmpresa;
                    Reg.IdEmpleado = IdEmpleado;
                    Reg.DiasTomadosVaca= Convert.ToInt32(item.dias);
                }

                int x = Reg.DiasTomadosVaca;

                return x;             
           }
                            
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Empleado_Info> ConsultaEmpleadosxDep(int IDEmpresa, int IdDepartamento)
        {
                List<ro_Empleado_Info> lst = new List<ro_Empleado_Info>();
                EntitiesRoles Oemp = new EntitiesRoles();
            try
            {


                var Emple = from q in Oemp.VWRO_empleado
                            where q.IdEmpresa == IDEmpresa &&
                            q.IdDepartamento == IdDepartamento
                            select q;

                foreach (var item in Emple)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.em_codigo = item.em_codigo;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.InfoPersona.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                    info.NomCompleto = item.pe_apellido + " " + item.pe_apellido;

                    lst.Add(info);
                }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
        //

        public ro_Empleado_Info VerificarExisteEmpleado_x_CodigoBiometrico(string CodigoBiometrico, int idempresa)
        {
            ro_Empleado_Info resultado = new ro_Empleado_Info();
            try
            {
                EntitiesRoles oEnt = new EntitiesRoles();

                var info = oEnt.VWRO_empleado.First(var => var.Codigo_Biometrico == CodigoBiometrico &&
                    var.IdEmpresa == idempresa);
                if (info != null)
                {
                    resultado.IdEmpleado = info.IdEmpleado;
                    resultado.NomCompleto =info.pe_apellido+" "+info.pe_nombre;
                    resultado.em_codigo = info.em_codigo;
                    resultado.IdEmpresa = info.IdEmpresa;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
        



        public Boolean GetExiste(ro_Empleado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_empleado
                                where a.IdEmpresa == info.IdEmpresa
                                && a.IdEmpleado == info.IdEmpleado
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool Eliminar_Empleados(int idempresa, ref string message)
        {
            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();
                decimal idEmpleado;

                var select = from A in OERol_Empleado.ro_empleado
                             where A.IdEmpresa == idempresa
                             select A;

                foreach (var item in select)
                {
                    idEmpleado = item.IdEmpleado;
                    OERol_Empleado.Database.ExecuteSqlCommand("delete ro_empleado where IdEmpresa = " + idempresa + " and idEmpleado ='" + idEmpleado + "'");

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

       

        public List<ro_Empleado_Info> ProcesarDataTableRo_Empleado_Info(DataTable ds, int idempresa, int idsucursal, ref string MensajeError)
        {

            List<ro_Empleado_Info> lista = new List<ro_Empleado_Info>();
            string prueba = "";

              int COLUMNA_ERROR=0;
              string FILA_ERROR = "";
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 24 COLUMNAS
                if (ds.Columns.Count >= 24)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                           
                            ro_Empleado_Info info = new ro_Empleado_Info();
                            //RECORRE C/U DE LAS COLUMNAS
                            info.IdEmpresa = idempresa;
                            info.InfoPersona.IdEmpresa = idempresa;
                            info.InfoPersona.pe_Naturaleza = "NATU";
                            info.InfoPersona.IdTipoPersona = 0;
                            info.InfoPersona.IdTipoDocumento = "CED";



                            info.IdSucursal = idsucursal;
                            info.IdTipoEmpleado = "NO";
                            info.em_SeAcreditaBanco = "";
                            info.em_tipoCta = "";
                            info.em_NumCta = "";
                            info.em_SepagaBeneficios = "";
                            info.em_SePagaConTablaSec = "";
                            info.recibi_uniforme = "";
                          
                          
                            info.em_estado="A";
                            info.em_status = "EST_ACT";
                            info.IdTipoSistemaSalarioNetoSRI = "TSN_2";
                            info.IdAplicaConvenioDobleImposicionSRI = "ACD_NO";
                            info.IdTipoResidenciaSRI = "RDT_01";

                          
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                COLUMNA_ERROR=col;
                                switch (col)
                                {
                                    case 0://CEDULA
                                        info.pe_cedulaRuc = Convert.ToString(row[col]);
                                        info.InfoPersona.pe_cedulaRuc = Convert.ToString(row[col]);
                                        FILA_ERROR = info.pe_cedulaRuc;
                                        break;

                                    case 1://CODIGO DEL EMPLEADO
                                        info.em_codigo = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 2://NOMBRES
                                        info.InfoPersona.pe_nombre = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 3://APELLIDOS
                                        info.InfoPersona.pe_apellido = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 4://GENERO
                                        info.InfoPersona.pe_sexo = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 5://FECHA NCTO
                                        info.InfoPersona.pe_fechaNacimiento = (DateTime?)((Convert.ToString(row[col]) == "") ? null : row[col]);
                                        break;

                                    case 6://LUGAR NCTO
                                        info.em_lugarNacimiento = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 7://DIRECCION
                                        info.InfoPersona.pe_direccion = Convert.ToString(row[col]);
                                        break;

                                    case 8://ESTADO CIVIL
                                        info.InfoPersona.IdEstadoCivil = Convert.ToString(row[col]);
                                        break;

                                    case 9://TIPO DE SANGRE
                                        info.IdTipoSangre = (string)((Convert.ToString(row[col]) == "") ? null : row[col]);
                                        break;

                                    case 10://TELEFONO CONTACTO
                                        info.InfoPersona.pe_telfono_Contacto = Convert.ToString(row[col]);
                                        break;

                                    case 11://TELEFONO CELULAR
                                        info.InfoPersona.pe_celular = Convert.ToString(row[col]);
                                        break;

                                    case 12://EMAIL
                                        info.em_mail = Convert.ToString(row[col]);
                                        break;

                                    case 13://DEPARTAMENTO
                                        info.IdDepartamento = Convert.ToInt32(row[col]);
                                        break;

                                    case 14://CARGO
                                        if (Convert.ToString(row[col]) == "")
                                            info.IdCargo = null;
                                        else
                                            info.IdCargo = Convert.ToInt32(row[col]);
                                        break;

                                    case 15://SUELDO
                                        info.em_Sueldo = Convert.ToDouble(row[col]);
                                        break;

                                    case 16://ANTICIPO SUELDO
                                        info.em_AnticipoSueldo = Convert.ToDouble(row[col]);
                                        info.IdTipoAnticipo = "ANT02";//POR VALOR
                                        break;

                                    case 17://FECHA INGRESO A LA EMPRESA
                                        info.em_fecha_ingreso = (DateTime?)((Convert.ToString(row[col]) == "") ? null : row[col]);
                                        break;

                                    case 18://FECHA NOVEDAD DE INGRESO AL IESS
                                        info.em_fechaIngaRol = (DateTime?)((Convert.ToString(row[col]) == "") ? null : row[col]);
                                        break;

                                    case 19://SE ACREDITA AL BANCO EL SUELDO
                                        info.em_SeAcreditaBanco = Convert.ToString(row[col]);
                                        break;

                                    case 20://BANCO
                                        info.IdBanco = Convert.ToString(row[col]);
                                        break;

                                    case 21://TIPO DE CUENTA
                                        info.em_tipoCta = Convert.ToString(row[col]);
                                        break;

                                    case 22://NO. CUENTA BANCARIA
                                        info.em_NumCta = Convert.ToString(row[col]);
                                        break;


                                    case 23://ES DISCAPACITADO
                                        info.em_empEspecial = Convert.ToString(row[col]);

                                        if (info.em_empEspecial=="S")
                                        {
                                            info.IdCondicionDiscapacidadSRI = "CTD_02";
                                        }

                                        info.IdTipoIdentDiscapacitadoSustitutoSRI = "TID_N";
                                        break;

                                    case 24://PORCENTAJE DE DISCAPACIDAD
                                        try
                                        {
                                         info.por_discapacidad = Convert.ToInt32(row[col]);
                                        }
                                        catch (Exception)
                                        {
                                            
                                            
                                        }
                                        break;

                                    case 25://NO.CARNET CONADIS
                                        info.carnet_conadis = Convert.ToString(row[col]);
                                        break;

                                    case 26://TALLA PANTALON
                                        info.recibi_uniforme = Convert.ToString(row[col]);
                                        break;

                                    case 27://TALLA PANTALON
                                        try
                                        {
                                              info.talla_pant = Convert.ToInt32(row[col]);
                                        }
                                        catch (Exception)
                                        {
                                            
                                          
                                        }
                                        break;
                                    
                                    case 28://TALLA CAMISA
                                        info.talla_camisa = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 29://TALLA ZAPATO
                                        info.talla_zapato = Convert.ToInt32(row[col]);
                                        break;

                                    case 30: //NO. CARNET CONADIS
                                        info.em_CarnetIees = Convert.ToString(row[col]);
                                        break;

                                    case 31: //NO. CEDULA MILITAR
                                        info.em_cedulaMil = Convert.ToString(row[col]);
                                        break;
                                    
                                    case 32: //CODIGO SECTORIAL
                                        info.CodigoSectorialIESS = Convert.ToString(row[col]);
                                        break;



                                    case 33: //acumulaDecimoTercer
                                        info.acumulaDecimoTercer = Convert.ToString(row[col]);
                                        break;

                                    case 34: //acumulaDecimoCuarto
                                        info.acumulaDecimoCuarto = Convert.ToString(row[col]);
                                        break;

                                    case 35: //acumulaFondoReserva
                                        info.acumulaFondoReserva = Convert.ToString(row[col]);
                                        break;

                                    case 36: //idDivision
                                        info.IdDivision = Convert.ToInt32(row[col]);
                                        break;

                                    case 37: //IdArea
                                        info.IdArea = Convert.ToInt32(row[col]);
                                        break;

                                    case 38: //idNomina
                                        info.IdNomina_Tipo = Convert.ToInt32(row[col]);
                                        break;

                                    case 39: //idCentroCosto
                                        info.IdCentroCosto = Convert.ToString(row[col]);
                                        break;

                                    case 40: //idTipoContrato
                                        info.idTipoContrato = Convert.ToString(row[col]) == "" ? "CTR01" : Convert.ToString(row[col]);
                                        break;

                                    case 41: //NoDocumentoContrato
                                        info.NoDocumentoContrato = Convert.ToString(row[col]) == "" ? "S/N" : Convert.ToString(row[col]);
                                        break;

                                    case 42: //fechaInicioContrato
                                        info.fechaInicioContrato = Convert.ToString(row[col]) == "" ? Convert.ToDateTime(info.em_fechaIngaRol) : Convert.ToDateTime(row[col]);
                                        break;

                                    case 43: //fechaFinContrato
                                        info.fechaFinContrato = Convert.ToString(row[col]) == "" ? Convert.ToDateTime(info.em_fechaIngaRol) : Convert.ToDateTime(row[col]);
                                        break;


                                    default:
                                        break;
                                }
                            }
                            info.InfoPersona.pe_nombreCompleto = info.InfoPersona.pe_apellido + " " + info.InfoPersona.pe_nombre;
                            info.pe_NomCompleto = info.InfoPersona.pe_nombre + " " + info.InfoPersona.pe_apellido;
                            info.InfoPersona.pe_estado = info.em_estado;
                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<ro_Empleado_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
                    lista = new List<ro_Empleado_Info>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError ="Error Columna: "+COLUMNA_ERROR+  " " + ex.ToString();
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> Get_List_EmpleadosVacaciones(int idEmpresa, DateTime fechaActual)
        {
            List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
   
            try
            {
                EntitiesRoles db = new EntitiesRoles();

                //ACORTAR LA FECHA 
                fechaActual = Convert.ToDateTime(fechaActual.ToShortDateString());

                var select = from A in db.vwro_empleadoXdepXcargo
                             where A.IdEmpresa == idEmpresa
                             select A;

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    //info.em_tipoLiquidacion = item.em_tipoLiquidacion;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;
                    info.em_status = item.em_status;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";


                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;

                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;
                    info.IdTipoAnticipo = item.IdTipoAnticipo;
                    info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   

                    //VISTA vwro_empleadoXdepXcargo
                    info.cargo = item.cargo;
                    info.departamento = item.departamento;
                    info.Sucursal = item.Sucursal;

                    info.em_fecha_Actual = fechaActual;

                    //OBTENER FECHA DE INGRESO A LABORAR
                    DateTime fechaIngresa = new DateTime();
                    fechaIngresa = Convert.ToDateTime(info.em_fecha_ingreso);

                    //CALCULO DE DIAS TRABAJADOS
                    TimeSpan diasTrabaja = fechaActual.Subtract(fechaIngresa);
                    int diasTrabajados = diasTrabaja.Days;
                    info.diasTrabajo = diasTrabajados;

                    //OBTENER DIAS VACACION
                    info.diasVacacion = ConsultaDiasVacaciones(fechaIngresa, fechaActual);

                    decimal IdEmpleado = 0;
                    IdEmpleado = Convert.ToInt32(info.IdEmpleado);

                    //OBTENER DIAS TOMADOS
                    info.diasTomados = Convert.ToInt32(ObtenerDiasTomados(idEmpresa, IdEmpleado, fechaIngresa, fechaActual));
                    info.diasPendientes = info.diasVacacion - info.diasTomados;

                    oListRo_Empleado_Info.Add(info);
                }
                return (oListRo_Empleado_Info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public List<ro_Empleado_Info> GetListPorNovedadAvisoEntrada(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles db = new EntitiesRoles();


                var datos = (from a in db.vwro_empleadoXdepXcargo
                             where a.IdEmpresa == idEmpresa
                             && (a.em_fecha_ingreso>= fechaInicial && a.em_fecha_ingreso<= fechaFinal)
                             select a);

                foreach (var item in datos)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS == null ? "" : item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   

                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.SueldoActual = GetSueldoActual(idEmpresa, info.IdEmpleado);

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Empleado_Info> GetListPorNovedadAvisoSalida(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles db = new EntitiesRoles();


                var datos = (from a in db.vwro_empleadoXdepXcargo
                             where a.IdEmpresa == idEmpresa
                             && (a.em_fechaSalida >= fechaInicial && a.em_fechaSalida <= fechaFinal)
                             select a);

                foreach (var item in datos)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    info.Archivo = item.Archivo;//18112013 D
                    info.NombreArchivo = item.NombreArchivo;//18112013 D
                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.ExcInc = "Incluir";

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS == null ? "" : item.CodigoSectorialIESS;
                    info.es_TruncarDecimalAnticipo = item.es_TruncarDecimalAnticipo;                   

                    //AQUI VERIFICAR PORQUE SE TARDA MUCHO LA LECTURA DE ESTE CAMPO
                    info.SueldoActual = GetSueldoActual(idEmpresa, info.IdEmpleado);

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public double GetAvisoNovedadSueldoNuevo(int idEmpresa, decimal idEmpleado, DateTime fechaInicial, DateTime fechaFinal)
        {
            try
            {
                double valorRetornar = 0;
                valorRetornar = oHistoricoSueldoData.Get_List_HistoricoSueldo(idEmpresa, idEmpleado).Where(v => v.Fecha >= fechaInicial && v.Fecha <= fechaFinal).FirstOrDefault().SueldoActual;
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }






        public List<ro_Empleado_Info> GetListPorNovedadAvisoNuevoSueldo(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles db = new EntitiesRoles();

                var datos = (from a in db.vwRo_Empleado_Nuevo_Sueldo
                             where a.IdEmpresa == idEmpresa 
                             //&& a.IdEmpleado == idEmpleado
                             && (a.FechaNuevoSueldo >= fechaInicial && a.FechaNuevoSueldo <= fechaFinal)
                             orderby a.FechaNuevoSueldo descending
                             select a);

                foreach (var item in datos)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;

                    info.IdEmpleado_Supervisor = item.IdEmpleado_Supervisor;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoEmpleado = item.IdTipoEmpleado;
                    info.em_codigo = item.em_codigo;
                    info.em_lugarNacimiento = item.em_lugarNacimiento;
                    info.em_CarnetIees = item.em_CarnetIees;
                    info.em_cedulaMil = item.em_cedulaMil;
                    info.em_fecha_ingreso = item.em_fecha_ingreso;
                    info.em_fechaSalida = item.em_fechaSalida;
                    info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                    info.em_fechaIngaRol = item.em_fechaIngaRol;
                    info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                    info.em_tipoCta = item.em_tipoCta;
                    info.em_NumCta = item.em_NumCta;
                    info.em_SepagaBeneficios = item.em_SepagaBeneficios;
                    info.em_SePagaConTablaSec = item.em_SePagaConTablaSec;
                    info.em_estado = item.em_estado;

                    info.em_foto = item.em_foto;
                    info.em_empEspecial = item.em_empEspecial;
                    info.em_pagoFdoRsv = item.em_pagoFdoRsv;
                    info.em_huella = item.em_huella;
                    info.IdCodSectorial = item.IdCodSectorial;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdTipoSangre = item.IdTipoSangre;
                    info.IdCargo = item.IdCargo;
                    info.IdCtaCble_Emplea = item.IdCtaCble_Emplea;
                    info.IdUbicacion = item.IdUbicacion;
                    info.em_mail = item.em_mail;
                    info.IdTipoLicencia = item.IdTipoLicencia;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdBanco = item.IdBanco;

                    //Derek 13/12/2013
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;

                    // Datos de la Persona
                    info.InfoPersona.IdPersona = item.IdPersona;
                    info.InfoPersona.CodPersona = item.CodPersona;
                    info.InfoPersona.pe_Naturaleza = item.pe_Naturaleza;
                    info.InfoPersona.pe_nombreCompleto = item.Apellido+" "+item.Nombre;
                    info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                    info.InfoPersona.pe_apellido = item.Apellido;
                    info.InfoPersona.pe_nombre = item.Nombre;
                    info.InfoPersona.IdTipoPersona = item.IdTipoPersona;
                    info.InfoPersona.IdTipoDocumento = item.IdTipoDocumento;
                    info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.InfoPersona.pe_direccion = item.pe_direccion;
                    info.InfoPersona.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.InfoPersona.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.InfoPersona.pe_telefonoInter = item.pe_telefonoInter;
                    info.InfoPersona.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.InfoPersona.pe_celular = item.pe_celular;
                    info.InfoPersona.pe_correo = item.pe_correo;
                    info.InfoPersona.pe_fax = item.pe_fax;
                    info.InfoPersona.pe_casilla = item.pe_casilla;
                    info.InfoPersona.pe_sexo = item.pe_sexo;
                    info.InfoPersona.IdEstadoCivil = item.IdEstadoCivil;
                    info.InfoPersona.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.InfoPersona.pe_estado = item.pe_estado;


                    info.cargo_Descripcion = item.cargo;
                    info.de_descripcion = item.departamento;
                    info.Sucursal_Descripcion = item.Sucursal;
                    info.NomCompleto = item.NomCompleto;

                    //Datos adicionales
                    info.por_discapacidad = item.por_discapacidad;
                    info.carnet_conadis = item.carnet_conadis;
                    info.recibi_uniforme = item.recibi_uniforme;
                    info.talla_pant = item.talla_pant;
                    info.talla_camisa = Convert.ToString(item.talla_camisa);
                    info.talla_zapato = item.talla_zapato;
//                    info.Codigo_Biometrico = item.Codigo_Biometrico;
                    info.em_status = item.em_status;

                    info.IdCondicionDiscapacidadSRI = item.IdCondicionDiscapacidadSRI;
                    info.IdTipoIdentDiscapacitadoSustitutoSRI = item.IdTipoIdentDiscapacitadoSustitutoSRI;
                    info.IdentDiscapacitadoSustitutoSRI = item.IdentDiscapacitadoSustitutoSRI;
                    info.IdAplicaConvenioDobleImposicionSRI = item.IdAplicaConvenioDobleImposicionSRI;
                    info.IdTipoResidenciaSRI = item.IdTipoResidenciaSRI;
                    info.IdTipoSistemaSalarioNetoSRI = item.IdTipoSistemaSalarioNetoSRI;
                    info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                    info.CodigoSectorialIESS = item.CodigoSectorialIESS == null ? "" : item.CodigoSectorialIESS;


                    //info.SueldoActual = GetAvisoNovedadSueldoNuevo(idEmpresa, info.IdEmpleado,fechaInicial,fechaFinal);                  
                    info.SueldoActual = item.SueldoActual;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> Get_Lis_Empleado_x_Periodo_Nomina(int IdEmpresa,int idNominaTipo,int IdnominaTipo_liq, int IdPeriodo)
        {
            List<ro_Empleado_Info> lM = new List<ro_Empleado_Info>();

            try
            {

                EntitiesRoles OERol_Empleado = new EntitiesRoles();


                var select = from A in OERol_Empleado.vwRO_empleado_x_Perido_Nomina 
                             where A.IdEmpresa == IdEmpresa 
                             &&  A.IdPeriodo==IdPeriodo
                             && A.IdNominaTipo==idNominaTipo
                             && A.IdNominaTipoLiqui==IdnominaTipo_liq
                             orderby A.pe_apellido ascending
                             select A;
                

                foreach (var item in select)
                {
                    ro_Empleado_Info info = new ro_Empleado_Info();

                    // Datos del Empleado
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdNomina_Tipo = item.IdNominaTipo;
                    info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                    info.IdPeriodo = item.IdPeriodo;
                    info.IdDepartamento = item.IdDepartamento;
                    info.NomCompleto = item.pe_apellido +" "+item.pe_nombre;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public bool GetSiExisteEmpleado(ro_Empleado_Info Info)
        {
            decimal Id = 0;

            try
            {
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = (from q in OEEmpleado.ro_empleado
                              where q.IdEmpresa == Info.IdEmpresa && q.IdPersona==Info.InfoPersona.IdPersona
                              select q).Count();

                if (select == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> Get_List_Empleado_x_Nomina_Liquidar(int idEmpresa, int IdTipoNomina, ro_periodo_x_ro_Nomina_TipoLiqui_Info Periodo)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.spROL_Nomina_a_Liquidar(idEmpresa, IdTipoNomina, Periodo.IdPeriodo)
                                  where a.IdEmpresa == idEmpresa 
                                  && a.IdTipoNomina == IdTipoNomina
                                  && a.em_estado == "A"
                                  && a.em_status != "EST_LIQ"
                                  &&(a.em_fechaSalida==null 
                                  || a.em_fechaSalida>Periodo.pe_FechaIni)
                                  select a
                                   );


                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();

                        // Datos del Empleado
                        info.em_fecha_inicio_contrato_Actual = item.FechaInicio;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdPersona = item.IdPersona;
                        info.IdSucursal = item.IdSucursal;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.em_tipoCta = item.em_tipoCta;
                        info.em_NumCta = item.em_NumCta;
                        info.em_estado = item.em_estado;
                        info.IdCargo = item.IdCargo;
                        info.em_status = item.em_status;
                        info.IdNomina_Tipo = item.IdTipoNomina;
                        info.IdDivision = item.IdDivision;
                        info.IdArea = item.IdArea;
                        info.Nomina = item.Nomina;
                        info.ExcInc = "Incluir";
                        if (item.SueldoActual != null)
                            info.SueldoActual = (double)item.SueldoActual;
                        else
                            info.SueldoActual = 0;
                        info.em_AnticipoSueldo = item.em_AnticipoSueldo;
                        // Datos de la Persona
                        info.InfoPersona.IdPersona = item.IdPersona;
                        info.InfoPersona.pe_nombreCompleto = item.Apellido + " " + item.Nombre;
                        info.InfoPersona.pe_razonSocial = item.pe_razonSocial;
                        info.InfoPersona.pe_apellido = item.Apellido;
                        info.InfoPersona.pe_nombre = item.Nombre;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.IdTipoAnticipo = item.IdTipoAnticipo;
                        info.cargo_Descripcion = item.cargo;
                        info.de_descripcion = item.departamento;
                        info.Sucursal_Descripcion = item.Sucursal;
                        info.NomCompleto = item.NomCompleto;
                        info.Transporte = item.Valor_Transp;
                        info.Alimentacion = item.Valor_Alimen;
                        info.Dias_Efectivos = item.Dias_Efectivos;
                        info.Marca_Biometrico = item.Marca_Biometrico;
                        if (item.si_tiene_rubros_fijo != null)
                        {
                            info.si_tiene_rubros_fijo = true;
                        }
                        else
                        {
                            info.si_tiene_rubros_fijo = false;

                        }
                        info.Dias_SyD = item.Dias_SyD;
                        info.Valor_bono=item.Valor_bono;
                        info.IdGrupo = item.IdGrupo;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.Nomina = item.Nomina;
                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean Modificar_Estado(int IdEmpresa, int IdEmpleado,string em_status)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado.First(obj => obj.IdEmpresa == IdEmpresa && obj.IdEmpleado == IdEmpleado);

                    contact.em_status = em_status;
                    context.SaveChanges();
                }




                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        // programacion FJ

        public Boolean Modificar_Estado(int IdEmpresa,int IdNomina_Tipo, int IdEmpleado, string em_status)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empleado.First(obj => obj.IdEmpresa == IdEmpresa && obj.IdEmpleado == IdEmpleado);

                    contact.em_status = em_status;
                    context.SaveChanges();
                }




                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Empleado_Info> get_lista_emp_con_sueldo_actual_para_calculo_HE(int idEmpresa)
        {
            List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();
            try
            {
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var select = (from a in db.vwro_empleados_con_sueldo_actual_para_calculo_HE
                                  where a.IdEmpresa == idEmpresa
                                  && a.Estado=="A"
                                  && a.em_status != "ECT_LIQ"
                                  select a);
                    foreach (var item in select)
                    {
                        ro_Empleado_Info info = new ro_Empleado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNomina_Tipo = item.IdTipoNomina;
                        info.InfoPersona.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.Nomina = item.Descripcion;
                        info.IdNomina_Tipo = item.IdTipoNomina;
                        if(item.SueldoActual!=null)
                        info.SueldoActual =(double)item.SueldoActual;
                        info.InfoPersona.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.grupo.Calculo_Horas_extras_Sobre = item.Calculo_Horas_extras_Sobre;
                        info.grupo.Max_num_horas_sab_dom = item.Max_num_horas_sab_dom;
                        oListadoInfo.Add(info);
                    }
                }

                return (oListadoInfo);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Empleado_Info> Get_list_empleado_sin_registro_asistencia(int IdEmpresa,int IdNomina_tipo, DateTime Fecha, int IdDivision)
        {
            try
            {
                List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var select = (from a in db.spro_empleados_sin_registro_asistencia(IdEmpresa, Fecha, IdNomina_tipo, IdDivision)
                                  where a.IdEmpresa == IdEmpresa
                               //  && a.IdDivision == IdDivision_
                                  select a);
                    foreach (var item in select)
                    {
                        if (item.em_fechaSalida > Fecha || item.em_fechaSalida == null)
                        {
                            ro_Empleado_Info info = new ro_Empleado_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdEmpleado = item.IdEmpleado;
                            info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                            info.de_descripcion = item.de_descripcion;
                            info.cargo = item.ca_descripcion;
                            info.pe_cedulaRuc = item.pe_cedulaRuc;
                            info.CodCatalogo = item.Tipo_asistencia_Cat;
                            info.Info_marcaciones_x_empleado.es_Hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                            info.Info_turno = new ro_turno_Info();
                            info.Info_turno.es_jornada_desfasada = item.es_jornada_desfasada;
                            info.Info_turno.tu_descripcion = item.tu_descripcion;
                            info.Info_turno.IdTurno = item.IdTurno;
                            info.IdDepartamento = item.IdCargo;
                            oListadoInfo.Add(info);
                        }
                    }
                    return oListadoInfo;
                }
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Empleado_Info> Get_list_empleado_sin_registro_asistencia_eventuiales(int IdEmpresa, int IdNomina_tipo, DateTime Fecha)
        {
            try
            {
                List<ro_Empleado_Info> oListadoInfo = new List<ro_Empleado_Info>();

                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var select = (from a in db.spro_empleados_sin_registro_asistencia_Eventuales(IdEmpresa, Fecha, IdNomina_tipo)
                                  where a.IdEmpresa == IdEmpresa

                                  select a);
                    foreach (var item in select)
                    {
                        if (item.em_fechaSalida > Fecha || item.em_fechaSalida == null)
                        {
                            ro_Empleado_Info info = new ro_Empleado_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdEmpleado = item.IdEmpleado;
                            info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                            info.de_descripcion = item.de_descripcion;
                            info.cargo = item.ca_descripcion;
                            info.pe_cedulaRuc = item.pe_cedulaRuc;
                            info.CodCatalogo = item.Tipo_asistencia_Cat;
                            info.Info_marcaciones_x_empleado.es_Hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                            info.Info_turno = new ro_turno_Info();
                            //info.Info_turno.es_jornada_desfasada = item.es_jornada_desfasada;
                           // info.Info_turno.tu_descripcion = item.tu_descripcion;
                            //info.Info_turno.IdTurno = item.IdTurno;
                            info.IdDepartamento = item.IdCargo;
                            oListadoInfo.Add(info);
                        }
                    }
                    return oListadoInfo;
                }
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }



    }
}
               