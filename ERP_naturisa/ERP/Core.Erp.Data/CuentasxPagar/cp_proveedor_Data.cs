using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.General;
using System.Data;
using Core.Erp.Data.Academico;
using System.Data.Entity.Validation;


namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_proveedor_Data
    { 
        string mensaje = "";

        public List<cp_proveedor_Info> Get_List_proveedor(int IdEmpresa)
        {
            try
            {
                List<cp_proveedor_Info> lM = new List<cp_proveedor_Info>();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var selectProveedor = from selec in OEUser.vwcp_ProveedorRuc
                                      where selec.IdEmpresa == IdEmpresa
                                      select selec;


                foreach (var item in selectProveedor)
                {

                    cp_proveedor_Info datI = new cp_proveedor_Info();
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdProveedor = item.IdProveedor;
                    datI.IdPersona= item.IdPersona;
                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_nombre_codigo = "[" + item.IdProveedor + "]-" + item.pr_nombre;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.IdTipoServicio = item.IdTipoServicio;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    datI.IdTipoGasto = item.IdTipoGasto;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_estado = item.pr_estado;
                    datI.IdCiudad = item.IdCiudad;
                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;
                    

                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.idCredito_Predeter = item.idCredito_Predeter;




                   //haac 17/03/2014
                    datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                    datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                    datI.IdCtaCble_Anticipo= item.IdCtaCble_Anticipo;
                    //haac 17/03/2014

                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;//17
                    datI.IdTipoGasto = item.IdTipoGasto;

                    
                    //haac 17/03/2014
                    datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                    datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                    datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    //haac 17/03/2014


                    datI.idCredito_Predeter = item.idCredito_Predeter;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdPersona = item.IdPersona;
                    datI.IdProveedor = item.IdProveedor;
                    datI.pr_contribuyenteEspecial = item.IdTipoGasto;
                    datI.IdTipoServicio = item.IdTipoServicio;
                    
                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_estado = item.pr_estado;
                    datI.IdTipoGasto = item.IdTipoGasto;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                    datI.IdCentroCosoto = item.IdCentroCosot;
                    datI.pr_nombre2 = "[" + item.IdProveedor + "] " + item.pr_nombre;
                    datI.contacto = item.contacto;
                    datI.responsable = item.responsable;
                    datI.comentario = item.comentario;
                    datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    datI.IdClaseProveedor = item.IdClaseProveedor;
                    datI.representante_legal = item.representante_legal;
                    datI.SEstado = (item.pr_estado == "A") ? "ACTIVO" : "*ANULADO*";
                    datI.pr_estado = item.pr_estado;

                    datI.IdCiudad = item.IdCiudad;
                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;


                    datI.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    datI.num_cta_acreditacion = item.num_cta_acreditacion;
                    datI.IdBanco_acreditacion = item.IdBanco_acreditacion;
                    datI.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);
                    


                    datI.Persona_Info = new tb_persona_Info();
                    datI.Persona_Info.CodPersona = item.CodPersona;
                    datI.Persona_Info.IdPersona = item.IdPersona;
                    datI.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    datI.Persona_Info.pe_nombre = item.pe_nombre;
                    datI.Persona_Info.pe_apellido = item.pe_apellido;
                    datI.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    datI.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                    datI.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    datI.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    datI.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    datI.Persona_Info.pe_direccion = item.pe_direccion;
                    datI.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                    datI.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                    datI.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                    datI.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    datI.Persona_Info.pe_celular = item.pe_celular;
                    datI.Persona_Info.pe_correo = item.pe_correo;
                    datI.Persona_Info.pe_fax = item.pe_fax;
                    datI.Persona_Info.pe_casilla = item.pe_casilla;
                    datI.Persona_Info.pe_sexo = item.pe_sexo; ;
                    datI.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    datI.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    datI.Persona_Info.pe_estado = item.pe_estado;
                    datI.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                    datI.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                    datI.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;
                    datI.IdPunto_cargo = item.IdPunto_cargo;
                    datI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;

                    lM.Add(datI);
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

        public List<cp_proveedor_Info> Get_List_proveedor_x_clase(int IdEmpresa,int IdClaseProveedor)
        {
            try
            {
                List<cp_proveedor_Info> lM = new List<cp_proveedor_Info>();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var selectProveedor = from selec in OEUser.vwcp_ProveedorRuc
                                      where selec.IdEmpresa == IdEmpresa
                                      && selec.IdClaseProveedor == IdClaseProveedor
                                      select selec;


                foreach (var item in selectProveedor)
                {

                    cp_proveedor_Info datI = new cp_proveedor_Info();
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdProveedor = item.IdProveedor;
                    datI.IdPersona = item.IdPersona;
                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_nombre_codigo = "[" + item.IdProveedor + "]-" + item.pr_nombre;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.IdTipoServicio = item.IdTipoServicio;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    datI.IdTipoGasto = item.IdTipoGasto;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_estado = item.pr_estado;
                    datI.IdCiudad = item.IdCiudad;
                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;


                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.idCredito_Predeter = item.idCredito_Predeter;

                    datI.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);


                    //haac 17/03/2014
                    datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                    datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                    datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    //haac 17/03/2014

                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;//17
                    datI.IdTipoGasto = item.IdTipoGasto;


                    //haac 17/03/2014
                    datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                    datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                    datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    //haac 17/03/2014


                    datI.idCredito_Predeter = item.idCredito_Predeter;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdPersona = item.IdPersona;
                    datI.IdProveedor = item.IdProveedor;
                    datI.pr_contribuyenteEspecial = item.IdTipoGasto;
                    datI.IdTipoServicio = item.IdTipoServicio;

                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_estado = item.pr_estado;
                    datI.IdTipoGasto = item.IdTipoGasto;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                    datI.IdCentroCosoto = item.IdCentroCosot;
                    datI.pr_nombre2 = "[" + item.IdProveedor + "] " + item.pr_nombre;
                    datI.contacto = item.contacto;
                    datI.responsable = item.responsable;
                    datI.comentario = item.comentario;
                    datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    datI.IdClaseProveedor = item.IdClaseProveedor;
                    datI.representante_legal = item.representante_legal;
                    datI.SEstado = (item.pr_estado == "A") ? "ACTIVO" : "*ANULADO*";
                    datI.pr_estado = item.pr_estado;

                    datI.IdCiudad = item.IdCiudad;
                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;


                    datI.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    datI.num_cta_acreditacion = item.num_cta_acreditacion;
                    datI.IdBanco_acreditacion = item.IdBanco_acreditacion;


                    datI.Persona_Info = new tb_persona_Info();
                    datI.Persona_Info.CodPersona = item.CodPersona;
                    datI.Persona_Info.IdPersona = item.IdPersona;
                    datI.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    datI.Persona_Info.pe_nombre = item.pe_nombre;
                    datI.Persona_Info.pe_apellido = item.pe_apellido;
                    datI.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    datI.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                    datI.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    datI.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    datI.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    datI.Persona_Info.pe_direccion = item.pe_direccion;
                    datI.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                    datI.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                    datI.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                    datI.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    datI.Persona_Info.pe_celular = item.pe_celular;
                    datI.Persona_Info.pe_correo = item.pe_correo;
                    datI.Persona_Info.pe_fax = item.pe_fax;
                    datI.Persona_Info.pe_casilla = item.pe_casilla;
                    datI.Persona_Info.pe_sexo = item.pe_sexo; ;
                    datI.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    datI.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    datI.Persona_Info.pe_estado = item.pe_estado;
                    datI.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                    datI.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                    datI.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;
                    datI.IdPunto_cargo = item.IdPunto_cargo;
                    datI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;

                    lM.Add(datI);
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

        public cp_proveedor_Info Get_Info_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                cp_proveedor_Info lM = new cp_proveedor_Info();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var selectProveedor = from selec in OEUser.vwcp_ProveedorRuc
                                      where selec.IdEmpresa == IdEmpresa && selec.IdProveedor == IdProveedor
                                      select selec;


                foreach (var item in selectProveedor)
                {

                    cp_proveedor_Info datI = new cp_proveedor_Info();

                    datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                    datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                    datI.idCredito_Predeter = item.idCredito_Predeter;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdPersona = item.IdPersona;
                    datI.IdProveedor = item.IdProveedor;
                    datI.pr_contribuyenteEspecial = item.IdTipoGasto;
                    datI.IdTipoServicio = item.IdTipoServicio;
                    
                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_estado = item.pr_estado;
                    datI.IdTipoGasto = item.IdTipoGasto;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                    datI.pr_nombre2 = item.pr_nombre + "[" + item.IdProveedor + "]";
                    datI.contacto = item.contacto;
                    datI.responsable = item.responsable;
                    datI.comentario = item.comentario;
                    datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    datI.IdCentroCosoto = item.IdCentroCosot;

                    datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    datI.IdClaseProveedor = Convert.ToInt32(item.IdClaseProveedor);

                    datI.representante_legal = item.representante_legal;
                    datI.SEstado = (item.pr_estado == "A") ? "ACTIVO" : "*ANULADO*";

                    datI.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    datI.num_cta_acreditacion = item.num_cta_acreditacion;
                    datI.IdBanco_acreditacion = item.IdBanco_acreditacion;

                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;
                    datI.IdCiudad = item.IdCiudad;
                    datI.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);


                    datI.Persona_Info = new tb_persona_Info();
                    datI.Persona_Info.CodPersona = item.CodPersona;
                    datI.Persona_Info.IdPersona = item.IdPersona;
                    datI.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    datI.Persona_Info.pe_nombre = item.pe_nombre;
                    datI.Persona_Info.pe_apellido = item.pe_apellido;
                    datI.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    datI.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                    datI.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    datI.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    datI.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    datI.Persona_Info.pe_direccion = item.pe_direccion;
                    datI.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                    datI.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                    datI.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                    datI.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    datI.Persona_Info.pe_celular = item.pe_celular;
                    datI.Persona_Info.pe_correo = item.pe_correo;
                    datI.Persona_Info.pe_fax = item.pe_fax;
                    datI.Persona_Info.pe_casilla = item.pe_casilla;
                    datI.Persona_Info.pe_sexo = item.pe_sexo; ;
                    datI.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    datI.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    datI.Persona_Info.pe_estado = item.pe_estado;
                    datI.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                    datI.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                    datI.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;

                    datI.IdPunto_cargo = item.IdPunto_cargo;
                    datI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    lM = datI;
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
        
        public cp_proveedor_Info Get_Info_Proveedor_Solo_CtasCbles(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                cp_proveedor_Info lM = new cp_proveedor_Info();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var selectProveedor = from selec in OEUser.vwcp_ProveedorRuc
                                      where selec.IdEmpresa == IdEmpresa && selec.IdProveedor == IdProveedor
                                      select new { selec.IdEmpresa, selec.IdProveedor, selec.IdCtaCble_Anticipo, selec.IdCtaCble_CXP, selec.IdCtaCble_Gasto };


                foreach (var item in selectProveedor)
                {

                    cp_proveedor_Info datI = new cp_proveedor_Info();
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdProveedor = item.IdProveedor;
                    datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    lM = datI;
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

        public cp_proveedor_Info Get_Info_Proveedor(int IdEmpresa, string Ruc_x_Proveedor)
        {

            try
            {
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                cp_proveedor_Info datI = new cp_proveedor_Info();

                var selectProveedor = from selec in OEUser.vwcp_ProveedorRuc
                                      where selec.IdEmpresa == IdEmpresa && selec.pe_cedulaRuc == Ruc_x_Proveedor
                                      select selec;

                foreach (var item in selectProveedor)
                {


                    //haac 17/03/2014
                    datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                    datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                    datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    //haac 17/03/2014

                    datI.idCredito_Predeter = item.idCredito_Predeter;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdPersona = item.IdPersona;
                    datI.IdProveedor = item.IdProveedor;
                    datI.pr_contribuyenteEspecial = item.IdTipoGasto;
                    datI.IdTipoServicio = item.IdTipoServicio;
                    datI.IdCiudad = item.IdCiudad;
                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_estado = item.pr_estado;
                    datI.IdTipoGasto = item.IdTipoGasto;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                    datI.pr_nombre2 = item.pr_nombre + "[" + item.IdProveedor + "]";
                    datI.contacto = item.contacto;
                    datI.responsable = item.responsable;
                    datI.comentario = item.comentario;
                    datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    datI.IdCentroCosoto = item.IdCentroCosot;
                    datI.IdClaseProveedor = Convert.ToInt32(item.IdClaseProveedor);
                    datI.representante_legal = item.representante_legal;

                    datI.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    datI.num_cta_acreditacion = item.num_cta_acreditacion;
                    datI.IdBanco_acreditacion = item.IdBanco_acreditacion;

                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;
                    datI.IdCiudad = item.IdCiudad;

                    datI.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                    datI.Persona_Info = new tb_persona_Info();
                    datI.Persona_Info.CodPersona = item.CodPersona;
                    datI.Persona_Info.IdPersona = item.IdPersona;
                    datI.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    datI.Persona_Info.pe_nombre = item.pe_nombre;
                    datI.Persona_Info.pe_apellido = item.pe_apellido;
                    datI.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    datI.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                    datI.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    datI.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    datI.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    datI.Persona_Info.pe_direccion = item.pe_direccion;
                    datI.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                    datI.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                    datI.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                    datI.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    datI.Persona_Info.pe_celular = item.pe_celular;
                    datI.Persona_Info.pe_correo = item.pe_correo;
                    datI.Persona_Info.pe_fax = item.pe_fax;
                    datI.Persona_Info.pe_casilla = item.pe_casilla;
                    datI.Persona_Info.pe_sexo = item.pe_sexo; ;
                    datI.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    datI.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    datI.Persona_Info.pe_estado = item.pe_estado;
                    datI.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                    datI.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                    datI.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;
                    datI.IdPunto_cargo = item.IdPunto_cargo;
                    datI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                }
                return (datI);
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

        public cp_proveedor_Info Get_Info_Proveedor_x_Persona(int IdEmpresa, decimal IdPersona, ref string msj)
        {
            try
            {
                cp_proveedor_Info info = new cp_proveedor_Info();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var selectProveedor = from selec in OEUser.vwcp_ProveedorRuc
                                      where selec.IdEmpresa == IdEmpresa && selec.IdPersona == IdPersona
                                      select selec;


                if (selectProveedor.Count() == 1)
                {

                    foreach (var item in selectProveedor)
                    {
                       
                        cp_proveedor_Info datI = new cp_proveedor_Info();
                       
                        datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        datI.codigoSRI_101_Predeter = Convert.ToInt32(item.codigoSRI_101_Predeter);
                        datI.codigoSRI_ICE_Predeter = Convert.ToInt32(item.codigoSRI_ICE_Predeter);
                        datI.idCredito_Predeter = item.idCredito_Predeter;
                        datI.IdCtaCble_CXP = item.IdCtaCble_CXP;
                        datI.IdEmpresa = item.IdEmpresa;
                        datI.IdPersona = item.IdPersona;
                        datI.IdProveedor = item.IdProveedor;
                        datI.pr_contribuyenteEspecial = item.IdTipoGasto;
                        datI.IdTipoServicio = item.IdTipoServicio;
                        
                        datI.pr_codigo = item.pr_codigo;
                        datI.pr_estado = item.pr_estado;
                        datI.IdTipoGasto = item.IdTipoGasto;
                        datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                        datI.pr_nacionalidad = item.pr_nacionalidad;
                        datI.pr_nombre = item.pr_nombre;
                        datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                        datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                        datI.pr_nombre2 = item.pr_nombre + "[" + item.IdProveedor + "]";
                        datI.contacto = item.contacto;
                        datI.responsable = item.responsable;
                        datI.comentario = item.comentario;
                        datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                        datI.IdCentroCosoto = item.IdCentroCosot;

                        datI.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        datI.IdClaseProveedor = Convert.ToInt32(item.IdClaseProveedor);

                        datI.representante_legal = item.representante_legal;

                        datI.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                        datI.num_cta_acreditacion = item.num_cta_acreditacion;
                        datI.IdBanco_acreditacion = item.IdBanco_acreditacion;

                        datI.IdPais = item.IdPais;
                        datI.IdProvincia = item.IdProvincia;
                        datI.IdCiudad = item.IdCiudad;
                        datI.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);


                        datI.Persona_Info = new tb_persona_Info();
                        datI.Persona_Info.CodPersona = item.CodPersona;
                        datI.Persona_Info.IdPersona = item.IdPersona;
                        datI.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                        datI.Persona_Info.pe_nombre = item.pe_nombre;
                        datI.Persona_Info.pe_apellido = item.pe_apellido;
                        datI.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        datI.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                        datI.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                        datI.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        datI.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        datI.Persona_Info.pe_direccion = item.pe_direccion;
                        datI.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                        datI.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                        datI.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                        datI.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        datI.Persona_Info.pe_celular = item.pe_celular;
                        datI.Persona_Info.pe_correo = item.pe_correo;
                        datI.Persona_Info.pe_fax = item.pe_fax;
                        datI.Persona_Info.pe_casilla = item.pe_casilla;
                        datI.Persona_Info.pe_sexo = item.pe_sexo; ;
                        datI.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                        datI.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        datI.Persona_Info.pe_estado = item.pe_estado;
                        datI.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                        datI.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                        datI.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;
                        datI.IdTipoCta_acreditacion_cat =item.IdTipoCta_acreditacion_cat;
                        datI. num_cta_acreditacion =item.num_cta_acreditacion;
                        datI. CodigoLegal =item.CodigoLegal;
                            datI.ba_descripcion =item.ba_descripcion;
                            datI.IdBanco_acreditacion = item.IdBanco_acreditacion;


                        msj = "";
                        return datI;
                    }
                }
                else
                {
                    if (selectProveedor.Count() == 0)
                        msj = "NUEVO";
                    else
                        msj = "Este Ruc/C.I está relacionado con " + selectProveedor.Count() + " Proveedor(es)";
                }
                return new cp_proveedor_Info();
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
       
        public Boolean GrabarDB(cp_proveedor_Info info, ref decimal idPro,ref string msg)
        {
            try
            {
                try
                {
                    decimal IdProveedor;
                    using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                    {
                        var address = new cp_proveedor();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdProveedor = info.IdProveedor= idPro=GetId(info.IdEmpresa);                       
                        address.IdPersona = info.IdPersona;
                        address.pr_codigo = info.pr_codigo == string.Empty || info.pr_codigo == null ? address.IdProveedor.ToString() : info.pr_codigo.Trim();
                        address.pr_nombre = info.pr_nombre.Trim();
                        address.pr_girar_cheque_a = info.pr_girar_cheque_a.Trim();
                        address.IdTipoServicio = info.IdTipoServicio;
                        address.IdTipoGasto = info.IdTipoGasto;
                        address.pr_contribuyenteEspecial = info.pr_contribuyenteEspecial;
                        address.pr_plazo = info.pr_plazo;
                        address.representante_legal = ".";
                        address.pr_estado = info.pr_estado;
                        address.IdCiudad = /*(info.IdCiudad == "1") ? "01":*/ info.IdCiudad;
                        address.pr_nacionalidad = info.pr_nacionalidad.Trim();
                        address.idCredito_Predeter = info.idCredito_Predeter;
                        address.codigoSRI_ICE_Predeter = info.codigoSRI_ICE_Predeter;
                        address.codigoSRI_101_Predeter = info.codigoSRI_101_Predeter;
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = DateTime.Now;
                        address.IdUsuarioUltMod = info.IdUsuario;
                        address.Fecha_UltMod = DateTime.Now;
                        address.IdUsuarioUltAnu = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.contacto = info.contacto;
                        address.responsable = (info.responsable == null)? null : info.responsable.Trim();
                        address.comentario = (info.comentario == null)? null : info.comentario.Trim();
                        address.IdCentroCosot = (info.IdCentroCosoto == null)? null : info.IdCentroCosoto.Trim();
                        address.IdCtaCble_Anticipo = (info.IdCtaCble_Anticipo == null)? null : info.IdCtaCble_Anticipo.Trim();
                        address.IdCtaCble_Gasto = (info.IdCtaCble_Gasto == null)? null: info.IdCtaCble_Gasto.Trim();
                        address.IdClaseProveedor =info.IdClaseProveedor;
                        address.IdCtaCble_CXP = (info.IdCtaCble_CXP == null)? null : info.IdCtaCble_CXP.Trim();
                        address.idCredito_Predeter = info.idCredito_Predeter;


                        address.IdTipoCta_acreditacion_cat = (info.IdTipoCta_acreditacion_cat == "") ? null : info.IdTipoCta_acreditacion_cat;
                        address.num_cta_acreditacion = info.num_cta_acreditacion;
                        address.IdBanco_acreditacion = info.IdBanco_acreditacion;

                        address.IdPunto_cargo = info.IdPunto_cargo;
                        address.IdPunto_cargo_grupo = info.IdPunto_cargo_grupo;
                        address.es_empresa_relacionada = info.es_empresa_relacionada;

                        context.cp_proveedor.Add(address);
                        context.SaveChanges();
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarEstado(cp_proveedor_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_proveedor.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProveedor == info.IdProveedor);
                    if (contact != null)
                    {
                        contact.pr_estado = "I";
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_proveedor_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var address = context.cp_proveedor.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProveedor == info.IdProveedor);
                    if (address != null)
                    {
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdProveedor = info.IdProveedor;
                        address.IdPersona = info.IdPersona;
                        address.pr_codigo = (info.pr_codigo == null)? null : info.pr_codigo.Trim();
                        address.pr_nombre = (info.pr_nombre == null)? null : info.pr_nombre.Trim();
                        address.pr_girar_cheque_a = (info.pr_girar_cheque_a == null)? null : info.pr_girar_cheque_a.Trim();
                        address.IdTipoServicio = info.IdTipoServicio;
                        address.IdTipoGasto = info.IdTipoGasto;
                        address.pr_contribuyenteEspecial = (info.pr_contribuyenteEspecial == null)? null : info.pr_contribuyenteEspecial.Trim();
                        address.pr_plazo = info.pr_plazo;
                        address.pr_plazo = info.pr_plazo;
                        address.representante_legal = ".";
                        address.pr_estado = info.pr_estado;
                        address.IdCiudad = (info.IdCiudad == null) ? "" : info.IdCiudad;
                        address.pr_nacionalidad = info.pr_nacionalidad;
                        address.idCredito_Predeter = info.idCredito_Predeter;
                        address.codigoSRI_ICE_Predeter = info.codigoSRI_ICE_Predeter;
                        address.codigoSRI_101_Predeter = info.codigoSRI_101_Predeter;
                        address.IdUsuario = info.IdUsuario;
                        address.IdUsuarioUltMod = info.IdUsuario;
                        address.Fecha_UltMod = info.Fecha_UltMod;
                        address.IdUsuarioUltAnu = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.contacto = (info.contacto == null)? null : info.contacto.Trim();
                        address.responsable = (info.responsable == null)? null : info.responsable.Trim();
                        address.comentario = (info.comentario == null)? null : info.comentario.Trim();
                        address.IdCentroCosot = info.IdCentroCosoto;
                        address.IdCtaCble_Anticipo = info.IdCtaCble_Anticipo;
                        address.IdCtaCble_Gasto = info.IdCtaCble_Gasto;
                        address.IdCtaCble_CXP = info.IdCtaCble_CXP;
                        address.IdClaseProveedor = info.IdClaseProveedor;

                        address.IdTipoCta_acreditacion_cat = (info.IdTipoCta_acreditacion_cat == "") ? null : info.IdTipoCta_acreditacion_cat;
                        address.num_cta_acreditacion = info.num_cta_acreditacion;
                        address.IdBanco_acreditacion = info.IdBanco_acreditacion;
                        address.IdPunto_cargo = info.IdPunto_cargo;
                        address.IdPunto_cargo_grupo = info.IdPunto_cargo_grupo;

                        address.es_empresa_relacionada = info.es_empresa_relacionada;

                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_Cuentas_cbles(int IdEmpresa, string IdCtaCble_CXP, string IdCtaCble_Anticipo, string IdCtaCble_Gasto, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("update cp_proveedor set IdCtaCble_CXP='" + IdCtaCble_CXP + "', IdCtaCble_Anticipo='" + IdCtaCble_Anticipo + "', IdCtaCble_Gasto='" + IdCtaCble_Gasto + "' where IdEmpresa=" + IdEmpresa);
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
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                        decimal Id;
                        EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar();

                        var q = from C in base_.cp_proveedor
                                where C.IdEmpresa == IdEmpresa
                                select C;
                        if (q.ToList().Count == 0)
                            return 1;
                        else
                        {
                            var select_ = (from CbtCble in base_.cp_proveedor
                                           where CbtCble.IdEmpresa == IdEmpresa
                                           select CbtCble.IdProveedor).Max();
                            Id = Convert.ToDecimal(select_.ToString()) + 1;
                            return Id;
                        }
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
        
        public Boolean VericarCodigoExiste(string codigo, int IdEmp, ref string mensaje)
        {
            try
            {
                    Boolean Existe;
                    string scodigo;
                    scodigo = codigo.Trim();
                    mensaje = "";
                    Existe = false;

                    if (codigo != "")
                    {

                        EntitiesCuentasxPagar B = new EntitiesCuentasxPagar();

                        var select_ = from t in B.cp_proveedor
                                      where t.pr_codigo == scodigo && t.IdEmpresa == IdEmp
                                      select t;

                        foreach (var item in select_)
                        {
                            mensaje = mensaje + " " + item.pr_nombre;
                            Existe = true;
                        }

                    }
                    return Existe;
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
       
        public List<cp_proveedor_Info> Get_List_ProveedoresXPresupuestoCusTalme(int IdEmpresa)
        {

            try
            {

                EntitiesCuentasxPagar Oent = new EntitiesCuentasxPagar();
                string Querty = "  select a.IdEmpresa,a.IdProveedor,a.IdPersona,pr_codigo,pr_nombre,pr_girar_cheque_a,IdTipoServicio,IdCtaCble_CXP,pr_contribuyenteEspecial,pr_estado, " +
                                    " codigoSRI_101_Predeter,contacto,responsable,comentario,b.Presupuesto, c.pe_cedulaRuc as ruc from cp_proveedor a" +
                                  "  inner Join prod_Proveedores_X_Presupuesto_CusTalme b " +
                                   "  on a.IdEmpresa = b.IdEmpresa and a.IdProveedor = b. IdProveedor  and  b.IdEmpresa =" + IdEmpresa + "inner join tb_persona c on a.IdPersona = c.IdPersona";
                return Oent.Database.SqlQuery<cp_proveedor_Info>(Querty).ToList();
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
        
        public bool EliminarDB_Todos(int idEmpresa, ref string mensaje)
        {  
            try
            {
                EntitiesCuentasxPagar OECp_Proveedor = new EntitiesCuentasxPagar();
                OECp_Proveedor.Database.ExecuteSqlCommand("delete cp_proveedor where IdEmpresa = " + idEmpresa );

                return true;
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

        public cp_proveedor_Info Get_Info_ProveedorVistaPrevia(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                cp_proveedor_Info lM = new cp_proveedor_Info();
                EntitiesCuentasxPagar OEUser = new EntitiesCuentasxPagar();

                var selectProveedor = from selec in OEUser.vwcp_proveedor_vista_previa
                                      where selec.IdEmpresa == IdEmpresa
                                      && selec.IdProveedor == IdProveedor
                                      select selec;


                foreach (var item in selectProveedor)
                {

                    cp_proveedor_Info datI = new cp_proveedor_Info();
                    datI.IdEmpresa = item.IdEmpresa;
                    datI.IdProveedor = item.IdProveedor;

                    datI.IdPersona= item.IdPersona;
                    datI.pr_codigo = item.pr_codigo;
                    datI.pr_nombre = item.pr_nombre;
                    datI.pr_nombre_codigo = "[" + item.IdProveedor + "]-" + item.pr_nombre;
                    datI.pr_nombre2 = "[" + item.IdProveedor + "]-" + item.pr_nombre;
                    datI.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    datI.IdTipoServicio = item.nom_TipoServicio;
                    datI.IdCtaCble_CXP = item.IdCtaCble_CXP + " - " + item.nom_CtaCble_CXP;
                    datI.IdTipoGasto = item.Nombre;
                    datI.pr_plazo = Convert.ToInt32(item.pr_plazo);
                    datI.pr_estado = item.pr_estado;
                    datI.IdCiudad = item.nom_ubicacion;
                    datI.pr_nacionalidad = item.pr_nacionalidad;
                    datI.IdCtaCble_Anticipo =item.IdCtaCble_Anticipo+" - "+ item.nom_CtaCble_Anticipo;
                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                    //datI.pe_cedulaRuc = item.pe_cedulaRuc;
                    datI.pr_contribuyenteEspecial = item.pr_contribuyenteEspecial;
                    datI.IdCentroCosoto = item.IdCentroCosot + " - " + item.nom_Centro_costo;
                    datI.pr_nombre2 = item.pr_nombre + "[" + item.IdProveedor + "]";
                    datI.contacto = item.contacto;
                    datI.responsable = item.responsable;
                    datI.IdCtaCble_Gasto = item.IdCtaCble_Gasto + " - " + item.nom_CtaCble_Gasto;
                    //datI.pe_Naturaleza = item.pe_Naturaleza;
                    datI.IdClaseProveedor = item.IdClaseProveedor;
                    datI.representante_legal = item.representante_legal;
                    datI.SEstado = (item.pr_estado == "A") ? "ACTIVO" : "*ANULADO*";
                    //datI.IdTipoDocumento = item.IdTipoDocumento;
                    //datI.Direccion = item.pe_direccion;
                    //datI.Telefono = item.pe_celular;
                    datI.comentario = item.comentario;
                    //datI.pe_cedulaRuc = item.pe_cedulaRuc;
                    datI.nom_codigoSRI_ICE = item.nom_SRI_ICE_Predeter;
                    datI.nom_codigoSRI_101 = item.nom_SRI_101_Predeter;
                    datI.nom_Credito_Predeter = item.nom_Credito_Predeter;
                    datI.Persona_Info.pe_correo = item.pe_correo;
                    datI.Persona_Info.pe_fax = item.pe_fax;
                    datI.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                    datI.Persona_Info.IdPersona = item.IdPersona;
                    datI.IdCiudad = item.IdCiudad;
                    datI.IdPais = item.IdPais;
                    datI.IdProvincia = item.IdProvincia;
                    datI.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);


                    

                    
                    lM = datI;
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

        public Boolean AnularDB(cp_proveedor_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var address = context.cp_proveedor.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProveedor == info.IdProveedor);
                    if (address != null)
                    {
                        address.pr_estado = "I";
                        address.Fecha_UltAnu = DateTime.Now;
                        address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        public cp_proveedor_Info Get_info_proveedor_x_codigo_para_saldo_inicial(int IdEmpresa, string cod_prov, ref string MensajeError)
        {
            try
            {
                cp_proveedor_Info info_proveedor = new cp_proveedor_Info();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.cp_proveedor
                              where q.pr_codigo == cod_prov
                              && q.IdEmpresa == IdEmpresa
                              select q;

                    int c_prov=0;

                    c_prov=lst.Count();


                   if (c_prov==0)
                   {
                            MensajeError = "El código del proveedor no existe [" + cod_prov + "]";
                   }

                   if (c_prov == 1)
                   {
                       foreach (var item in lst)
                       {
                           info_proveedor = new cp_proveedor_Info();
                           info_proveedor.IdProveedor = item.IdProveedor;
                           info_proveedor.IdCtaCble_CXP = item.IdCtaCble_CXP;
                           info_proveedor.pr_codigo = item.pr_codigo;
                           info_proveedor.IdTipoServicio = item.IdTipoServicio;
                           info_proveedor.pr_nombre = item.pr_nombre;
                           info_proveedor.IdClaseProveedor = item.IdClaseProveedor;
                       }

                   }

                   if (c_prov > 1)
                   {
                       MensajeError = "Existe mas de un proveedor con el mismo codigo código [" + cod_prov + "]";
                   }

                   



                    
                    
                }

                return info_proveedor;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_proveedor_Data() { }
    }
}


