using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Presupuesto;
using System.Data;
using Core.Erp.Data.General;
using Core.Erp.Data.Academico;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Facturacion
{
    public class fa_Cliente_Data
    {
     
        string mensaje = "";
        tb_persona_data dataPerson = new tb_persona_data();

        public bool Eliminar_Clientes(int idEmpresa, ref string mensaje)
        {
            try
            {
                EntitiesFacturacion OEFa_Cliente = new EntitiesFacturacion();
                OEFa_Cliente.Database.ExecuteSqlCommand("delete fa_cliente where IdEmpresa = " + idEmpresa );
              
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_Cliente_Info> Get_List_Cliente(int IdEmpresa)
        {
            try
            {
                List<fa_Cliente_Info> Lista_Clientes = new List<fa_Cliente_Info>();
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                var select_tipo_nota = from A in OEPCliente.vwfa_cliente
                                       where A.IdEmpresa == IdEmpresa
                                       select A;

                foreach (var item in select_tipo_nota)
                {
                    fa_Cliente_Info info = new fa_Cliente_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCliente = item.IdCliente;
                    info.Codigo = item.Codigo;
                    info.IdPersona = item.IdPersona;
                    info.IdSucursal = item.IdSucursal;
                    info.IdVendedor = item.IdVendedor;
                    info.nomSucursal = item.Su_Descripcion;
                    info.Idtipo_cliente = item.Idtipo_cliente;
                    info.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                    info.cl_Cat_crediticia = (item.cl_Cat_crediticia != null) ? item.cl_Cat_crediticia.Trim() : "";
                    info.cl_plazo = item.cl_plazo;
                    info.cl_porcentaje_descuento = item.cl_porcentaje_descuento;
                    
                    info.cl_Cell_Garante = (item.cl_Cell_Garante != null) ? item.cl_Cell_Garante.Trim() : "";
                    info.cl_Garante = (item.cl_Garante != null) ? item.cl_Garante.Trim() : "";
                    info.cl_Mail_Garante = (item.cl_Mail_Garante != null) ? item.cl_Mail_Garante.Trim() : "";
                    info.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                    info.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                    info.cl_Cupo = item.cl_Cupo;
                    
                    info.IdClienteRelacionado = item.IdClienteRelacionado;
                    info.cl_Rep_Legal = (item.cl_Rep_Legal != null) ? item.cl_Rep_Legal.Trim() : "";
                    info.cl_Mail_Rep_Legal = (item.cl_Mail_Rep_Legal != null) ? item.cl_Mail_Rep_Legal.Trim() : "";
                    info.cl_Cell_Rep_Legal = (item.cl_Cell_Rep_Legal != null) ? item.cl_Cell_Rep_Legal.Trim() : "";
                    info.cl_Ger_Gen = (item.cl_Ger_Gen != null) ? item.cl_Ger_Gen.Trim() : "";
                    info.cl_Mail_Ger_Gen = (item.cl_Mail_Ger_Gen != null) ? item.cl_Mail_Ger_Gen.Trim() : "";
                    info.cl_Cell_Ger_Gen = (item.cl_Cell_Ger_Gen != null) ? item.cl_Cell_Ger_Gen.Trim() : "";
                    info.cl_casilla = (item.cl_casilla != null) ? item.cl_casilla.Trim() : "";
                    info.cl_fax = (item.cl_fax != null) ? item.cl_fax.Trim() : "";
                    info.IdActividadComercial = (item.IdActividadComercial != null) ? item.IdActividadComercial.Trim() : "";
                    info.Estado = item.Estado;
                    info.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";
                    //informacion contable
                    info.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                    info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                    info.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;

                    info.IdCentroCosto_CXC_Credito = item.IdCentroCosto_CXC_Credito;
                    //informacion de provincia y pais
                    info.IdProvincia = item.IdProvincia;
                    info.IdPais = item.IdPais;
                    info.IdParroquia = item.IdParroquia;

                    //emails
                    info.Mail_Principal = item.Mail_Principal;
                    info.Mail_Secundario1 = item.Mail_Secundario1;
                    info.Mail_Secundario2 = item.Mail_Secundario2;
                    info.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);



                    //informacion de la persona
                    info.Persona_Info = new tb_persona_Info();
                    info.Persona_Info.CodPersona = item.CodPersona;
                    info.Persona_Info.IdPersona = item.IdPersona;
                    info.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    info.Persona_Info.pe_nombre =  (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                    info.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                    info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                    info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.Persona_Info.pe_direccion = item.pe_direccion;
                    info.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                    info.Persona_Info.pe_correo = item.pe_correo;
                    info.Persona_Info.pe_fax = item.pe_fax;
                    info.Persona_Info.pe_casilla = item.pe_casilla;
                    info.Persona_Info.pe_sexo = item.pe_sexo; ;
                    info.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    info.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    info.Persona_Info.pe_estado = item.pe_estado;
                    info.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    info.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                    info.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                    info.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    info.Persona_Info.pe_celular = item.pe_celular;
                    info.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                    info.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                    info.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;
                    info.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                    Lista_Clientes.Add(info);
                }
                return (Lista_Clientes);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_Cliente_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_cliente.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa 
                        && obj.IdCliente == info.IdCliente);
                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCliente = info.IdCliente ;
                        contact.Codigo = (info.Codigo == "" || info.Codigo == null) ? info.IdCliente.ToString() : info.Codigo;
                        contact.IdPersona = info.IdPersona;
                        contact.IdSucursal = info.IdSucursal;
                        contact.IdVendedor = info.IdVendedor;
                        contact.Idtipo_cliente = info.Idtipo_cliente;
                        contact.IdTipoCredito = (info.IdTipoCredito != null) ? info.IdTipoCredito : "CRE";
                        contact.cl_Cat_crediticia = (info.cl_Cat_crediticia != null) ? info.cl_Cat_crediticia : "A";
                        contact.cl_plazo = info.cl_plazo;
                        contact.cl_porcentaje_descuento = info.cl_porcentaje_descuento;
                        contact.IdCtaCble_cxc = info.IdCtaCble_cxc; 
                        contact.IdCtaCble_Anti = info.IdCtaCble_Anti;
                        contact.cl_Cell_Garante = (info.cl_Cell_Garante != null) ? info.cl_Cell_Garante : null;
                        contact.cl_Garante = (info.cl_Garante != null) ? info.cl_Garante : null;
                        contact.cl_Mail_Garante = (info.cl_Mail_Garante != null) ? info.cl_Mail_Garante : null;
                        contact.cl_observacion = (info.cl_observacion != null) ? info.cl_observacion : "";
                        contact.IdCiudad = info.IdCiudad;
                        contact.cl_Cupo =  info.cl_Cupo;

                        contact.es_empresa_relacionada = info.es_empresa_relacionada;
                        
                        contact.IdClienteRelacionado = (info.IdClienteRelacionado != null) ? info.IdClienteRelacionado : 0;
                        contact.cl_Rep_Legal = (info.cl_Rep_Legal != null) ? info.cl_Rep_Legal : ".";
                        contact.cl_Mail_Rep_Legal = (info.cl_Mail_Rep_Legal != null) ? info.cl_Mail_Rep_Legal : ".";
                        contact.cl_Cell_Rep_Legal = (info.cl_Cell_Rep_Legal != null) ? info.cl_Cell_Rep_Legal : ".";
                        contact.cl_Ger_Gen = (info.cl_Ger_Gen != null) ? info.cl_Ger_Gen : "";
                        contact.cl_Mail_Ger_Gen = (info.cl_Mail_Ger_Gen != null) ? info.cl_Mail_Ger_Gen : ".";
                        contact.cl_Cell_Ger_Gen = (info.cl_Cell_Ger_Gen != null) ? info.cl_Cell_Ger_Gen : ".";
                        contact.cl_casilla = (info.cl_casilla != null) ? info.cl_casilla : ".";
                        contact.cl_fax = (info.cl_fax != null) ? info.cl_fax : ".";
                        contact.IdActividadComercial = "NORM";
                        contact.Estado = (info.Estado != null) ? info.Estado : "A";
                        contact.IdUsuario = (info.IdUsuario != null) ? info.IdUsuario : "";
                        contact.IdUsuarioUltMod = (info.IdUsuario != null) ? info.IdUsuario : "";
                        contact.Fecha_Transac = DateTime.Now;
                        contact.Fecha_UltMod = (info.Fecha_UltMod != null) ? info.Fecha_UltMod : DateTime.Now;
                        contact.nom_pc = (info.nom_pc != null) ? info.nom_pc : "";
                        contact.ip = (info.ip != null) ? info.ip : "";
                        contact.Mail_Principal = info.Persona_Info.pe_correo;
                        contact.Mail_Secundario1 = info.Persona_Info.pe_correo_secundario1;
                        contact.Mail_Secundario2 = info.Persona_Info.pe_correo_secundario2;
                        contact.IdCentroCosto_CXC = info.IdCentroCosto_CXC;
                        contact.IdCentroCosto_Anticipo = info.IdCentroCosto_Anticipo;

                        contact.IdCtaCble_cxc_Credito = info.IdCtaCble_cxc_Credito;
                        contact.IdCentroCosto_CXC_Credito = info.IdCentroCosto_CXC_Credito;

                        contact.IdParroquia = info.IdParroquia;



                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Cliente #: " + info.IdCliente.ToString() + " exitosamente";
                    }
                    else { msg = "No se encuentra el cliente registrado."; }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_Cuentas_cbles(int IdEmpresa, string cxc_Contado, string cxc_Anticipo, string cxc_Credito, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("update fa_cliente set IdCtaCble_cxc='" + cxc_Contado + "', IdCtaCble_Anti='" + cxc_Anticipo + "', IdCtaCble_cxc_Credito='" + cxc_Credito + "' where IdEmpresa=" + IdEmpresa);
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
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                var select = from q in OEPCliente.fa_cliente
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_cliente = (from q in OEPCliente.fa_cliente
                                          where q.IdEmpresa == IdEmpresa
                                          select q.IdCliente).Max();
                    Id = Convert.ToInt32(select_cliente.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(fa_Cliente_Info info, ref decimal id,ref string msg)
        {
            //try
            //{
                try
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        fa_cliente contact = new fa_cliente();
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCliente = info.IdCliente = id = GetId(info.IdEmpresa);
                        contact.IdPersona = info.IdPersona;
                        contact.IdSucursal = info.IdSucursal;
                        contact.Codigo = (info.Codigo == "" || info.Codigo == null) ? contact.IdCliente.ToString() : info.Codigo.Trim();
                        contact.IdVendedor = info.IdVendedor;
                        contact.Idtipo_cliente = info.Idtipo_cliente;
                        contact.IdTipoCredito = (info.IdTipoCredito != null) ? info.IdTipoCredito : "CRE";
                        contact.cl_Cat_crediticia = (info.cl_Cat_crediticia != null) ? info.cl_Cat_crediticia : "A";
                        contact.cl_plazo = (info.cl_plazo != null) ? info.cl_plazo : 0;
                        contact.cl_porcentaje_descuento = (info.cl_porcentaje_descuento != null) ? info.cl_porcentaje_descuento : 0;

                        contact.cl_Cell_Garante = (info.cl_Cell_Garante != null) ? info.cl_Cell_Garante : null;
                        contact.cl_Garante = (info.cl_Garante != null) ? info.cl_Garante : null;
                        contact.cl_Mail_Garante = (info.cl_Mail_Garante != null) ? info.cl_Mail_Garante : null;
                        contact.cl_observacion = (info.cl_observacion != null) ? info.cl_observacion : "";
                        contact.IdCiudad = info.IdCiudad;
                        contact.cl_Cupo = (info.cl_Cupo != null) ? info.cl_Cupo : 0;

                        contact.IdClienteRelacionado = (info.IdClienteRelacionado != null) ? info.IdClienteRelacionado : 0;
                        contact.cl_Rep_Legal = (info.cl_Rep_Legal != null) ? info.cl_Rep_Legal : ".";
                        contact.cl_Mail_Rep_Legal = (info.cl_Mail_Rep_Legal != null) ? info.cl_Mail_Rep_Legal : ".";
                        contact.cl_Cell_Rep_Legal = (info.cl_Cell_Rep_Legal != null) ? info.cl_Cell_Rep_Legal : ".";
                        contact.cl_Ger_Gen = (info.cl_Ger_Gen != null) ? info.cl_Ger_Gen : "";
                        contact.cl_Mail_Ger_Gen = (info.cl_Mail_Ger_Gen != null) ? info.cl_Mail_Ger_Gen : ".";
                        contact.cl_Cell_Ger_Gen = (info.cl_Cell_Ger_Gen != null) ? info.cl_Cell_Ger_Gen : ".";
                        contact.cl_casilla = (info.cl_casilla != null) ? info.cl_casilla : ".";
                        contact.cl_fax = (info.cl_fax != null) ? info.cl_fax : ".";
                        contact.IdActividadComercial = "NORM";// (info.IdActividadComercial != null) ? info.IdActividadComercial : "NORM";
                        contact.Estado = (info.Estado != null) ? info.Estado : "A";
                        contact.IdUsuario = (info.IdUsuario != null) ? info.IdUsuario : "";
                        contact.IdUsuarioUltMod = (info.IdUsuario != null) ? info.IdUsuario : "";
                        contact.Fecha_Transac = DateTime.Now;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.nom_pc = (info.nom_pc != null) ? info.nom_pc : "";

                        contact.ip = (info.ip != null) ? info.ip : "";

                        contact.Mail_Principal = info.Mail_Principal;
                        contact.Mail_Secundario1 = info.Mail_Secundario1;
                        contact.Mail_Secundario2 = info.Mail_Secundario2;
                        contact.IdCentroCosto_CXC = info.IdCentroCosto_CXC;
                        contact.IdCentroCosto_Anticipo = info.IdCentroCosto_Anticipo;
                        contact.IdCentroCosto_CXC_Credito = info.IdCentroCosto_CXC_Credito;

                        contact.IdCtaCble_cxc = info.IdCtaCble_cxc;
                        contact.IdCtaCble_cxc_Credito = info.IdCtaCble_cxc_Credito;
                        contact.IdCtaCble_Anti = info.IdCtaCble_Anti;
                        contact.IdParroquia = info.IdParroquia;

                        contact.es_empresa_relacionada = info.es_empresa_relacionada;

                        context.fa_cliente.Add(contact);
                        context.SaveChanges();
                        msg = "Se ha procedido a grabar el registro del Cliente #: " + id.ToString() + " exitosamente.";
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
            //}
            //catch (Exception ex)
            //{
            //    string arreglo = ToString();
            //    string strMensaje = "";
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            //    strMensaje = ex.ToString() + " " + ex.Message;
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
            //    throw new Exception(ex.ToString());
            //}
        }

        public Boolean EliminarDB(fa_Cliente_Info info, ref  string msg)
        {
            try
            {
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();
                var select = from q in OEPTipoNota.fa_cliente
                             where q.IdEmpresa == info.IdEmpresa && q.IdCliente==info.IdCliente
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_cliente.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdCliente == info.IdCliente);
                        if (contact != null)
                        {
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = info.Fecha_UltAnu;
                            contact.Estado = "I";
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Cliente #: " + info.IdCliente.ToString() + " exitosamente";
                        }
                    }
                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Cliente #: " + info.IdCliente.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ConsultarClienteVendedor(int IdEmpresa,ref fa_Cliente_Info InfoCliente,ref fa_Vendedor_Info InfoVendedor) {
            try
            {
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                decimal idCliente=InfoCliente.IdCliente;
                decimal idVendedor = InfoVendedor.IdVendedor;


                var select_tipo_nota = from A in OEPCliente.vwfa_cliente
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdCliente == idCliente
                                       select A;

                foreach (var item in select_tipo_nota)
                {
                    InfoCliente.IdEmpresa = item.IdEmpresa;
                    InfoCliente.IdCliente = item.IdCliente;
                    InfoCliente.IdPersona = item.IdPersona;
                    InfoCliente.Codigo = item.Codigo;
                    InfoCliente.IdSucursal = item.IdSucursal;
                    InfoCliente.IdVendedor = item.IdVendedor;
                    InfoCliente.nomSucursal = item.Su_Descripcion;
                    InfoCliente.Idtipo_cliente = item.Idtipo_cliente;
                    InfoCliente.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                    InfoCliente.cl_Cat_crediticia = (item.cl_Cat_crediticia != null) ? item.cl_Cat_crediticia.Trim() : "";
                    InfoCliente.cl_plazo = item.cl_plazo;
                    InfoCliente.cl_porcentaje_descuento = item.cl_porcentaje_descuento;
                    InfoCliente.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                    InfoCliente.cl_Cell_Garante = (item.cl_Cell_Garante != null) ? item.cl_Cell_Garante.Trim() : "";
                    InfoCliente.cl_Garante = (item.cl_Garante != null) ? item.cl_Garante.Trim() : "";
                    InfoCliente.cl_Mail_Garante = (item.cl_Mail_Garante != null) ? item.cl_Mail_Garante.Trim() : "";
                    InfoCliente.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                    InfoCliente.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                    InfoCliente.cl_Cupo = item.cl_Cupo;
                    InfoCliente.IdClienteRelacionado = item.IdClienteRelacionado;
                    InfoCliente.cl_Rep_Legal = (item.cl_Rep_Legal != null) ? item.cl_Rep_Legal.Trim() : "";
                    InfoCliente.cl_Mail_Rep_Legal = (item.cl_Mail_Rep_Legal != null) ? item.cl_Mail_Rep_Legal.Trim() : "";
                    InfoCliente.cl_Cell_Rep_Legal = (item.cl_Cell_Rep_Legal != null) ? item.cl_Cell_Rep_Legal.Trim() : "";
                    InfoCliente.cl_Ger_Gen = (item.cl_Ger_Gen != null) ? item.cl_Ger_Gen.Trim() : "";
                    InfoCliente.cl_Mail_Ger_Gen = (item.cl_Mail_Ger_Gen != null) ? item.cl_Mail_Ger_Gen.Trim() : "";
                    InfoCliente.cl_Cell_Ger_Gen = (item.cl_Cell_Ger_Gen != null) ? item.cl_Cell_Ger_Gen.Trim() : "";
                    InfoCliente.cl_casilla = (item.cl_casilla != null) ? item.cl_casilla.Trim() : "";
                    InfoCliente.cl_fax = (item.cl_fax != null) ? item.cl_fax.Trim() : "";
                    InfoCliente.IdActividadComercial = (item.IdActividadComercial != null) ? item.IdActividadComercial.Trim() : "";
                    InfoCliente.Estado = item.Estado;
                    InfoCliente.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";

                    InfoCliente.IdCtaCble_Anti = item.IdCtaCble_Anti;
                    InfoCliente.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;
                    InfoCliente.IdCentroCosto_CXC_Credito = item.IdCentroCosto_CXC_Credito;

                    InfoCliente.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                    InfoCliente.IdProvincia = item.IdProvincia;
                    InfoCliente.IdPais = item.IdPais;

                    InfoCliente.Mail_Principal = item.Mail_Principal;
                    InfoCliente.Mail_Secundario1 = item.Mail_Secundario1;
                    InfoCliente.Mail_Secundario2 = item.Mail_Secundario2;
                    InfoCliente.IdParroquia = item.IdParroquia;


                    InfoCliente.Persona_Info = new tb_persona_Info();
                    InfoCliente.Persona_Info.CodPersona = item.CodPersona;
                    InfoCliente.Persona_Info.IdPersona = item.IdPersona;
                    InfoCliente.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    InfoCliente.Persona_Info.pe_nombre = (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                    InfoCliente.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                    InfoCliente.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    InfoCliente.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                    InfoCliente.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    InfoCliente.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    InfoCliente.Persona_Info.pe_direccion = item.pe_direccion;

                    InfoCliente.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                    
                    InfoCliente.Persona_Info.pe_fax = item.pe_fax;
                    InfoCliente.Persona_Info.pe_casilla = item.pe_casilla;
                    InfoCliente.Persona_Info.pe_sexo = item.pe_sexo; ;
                    InfoCliente.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    InfoCliente.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    InfoCliente.Persona_Info.pe_estado = item.pe_estado;

                    InfoCliente.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    InfoCliente.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                    InfoCliente.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                    InfoCliente.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    InfoCliente.Persona_Info.pe_celular = item.pe_celular;

                    InfoCliente.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                    InfoCliente.Persona_Info.pe_correo = item.pe_correo;
                    InfoCliente.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                    InfoCliente.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;

                    InfoCliente.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                }
                    EntitiesFacturacion OEPVendedor = new EntitiesFacturacion();

                    var select_pv = from A in OEPVendedor.fa_Vendedor
                                    where A.IdEmpresa == IdEmpresa &&A.IdVendedor==idVendedor
                                    select A;

                    foreach (var item in select_pv)
                    {
                        InfoVendedor.IdEmpresa = item.IdEmpresa;
                        InfoVendedor.IdVendedor = item.IdVendedor;
                        InfoVendedor.Ve_Vendedor = item.Ve_Vendedor.Trim();
                        InfoVendedor.Estado = item.Estado;
                        InfoVendedor.Ve_Comision = item.Ve_Comision;
                    }
                    return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }            
        }

        public fa_Cliente_Info Get_Info_Cliente_x_IdPersona(int IdEmpresa, decimal IdPersona)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_cliente
                                           where A.IdEmpresa == IdEmpresa
                                           && A.IdPersona == IdPersona
                                           select A;

                    foreach (var item in select_tipo_nota)
                    {

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.Codigo = item.Codigo;
                        info.IdSucursal = item.IdSucursal;
                        info.IdVendedor = item.IdVendedor;
                        info.nomSucursal = item.Su_Descripcion;
                        info.Idtipo_cliente = item.Idtipo_cliente;
                        info.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                        info.cl_Cat_crediticia = (item.cl_Cat_crediticia != null) ? item.cl_Cat_crediticia.Trim() : "";
                        info.cl_plazo = item.cl_plazo;
                        info.cl_porcentaje_descuento = item.cl_porcentaje_descuento;
                        info.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                        info.cl_Cell_Garante = (item.cl_Cell_Garante != null) ? item.cl_Cell_Garante.Trim() : "";
                        info.cl_Garante = (item.cl_Garante != null) ? item.cl_Garante.Trim() : "";
                        info.cl_Mail_Garante = (item.cl_Mail_Garante != null) ? item.cl_Mail_Garante.Trim() : "";
                        info.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                        info.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                        info.cl_Cupo = item.cl_Cupo;
                        info.IdClienteRelacionado = item.IdClienteRelacionado;
                        info.cl_Rep_Legal = (item.cl_Rep_Legal != null) ? item.cl_Rep_Legal.Trim() : "";
                        info.cl_Mail_Rep_Legal = (item.cl_Mail_Rep_Legal != null) ? item.cl_Mail_Rep_Legal.Trim() : "";
                        info.cl_Cell_Rep_Legal = (item.cl_Cell_Rep_Legal != null) ? item.cl_Cell_Rep_Legal.Trim() : "";
                        info.cl_Ger_Gen = (item.cl_Ger_Gen != null) ? item.cl_Ger_Gen.Trim() : "";
                        info.cl_Mail_Ger_Gen = (item.cl_Mail_Ger_Gen != null) ? item.cl_Mail_Ger_Gen.Trim() : "";
                        info.cl_Cell_Ger_Gen = (item.cl_Cell_Ger_Gen != null) ? item.cl_Cell_Ger_Gen.Trim() : "";
                        info.cl_casilla = (item.cl_casilla != null) ? item.cl_casilla.Trim() : "";
                        info.cl_fax = (item.cl_fax != null) ? item.cl_fax.Trim() : "";
                        info.IdActividadComercial = (item.IdActividadComercial != null) ? item.IdActividadComercial.Trim() : "";
                        info.Estado = item.Estado;
                        info.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";

                        info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                        info.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;
                        info.IdCentroCosto_CXC_Credito = item.IdCentroCosto_CXC_Credito;

                        info.IdProvincia = item.IdProvincia;
                        info.IdPais = item.IdPais;

                        info.Mail_Principal = item.Mail_Principal;
                        info.Mail_Secundario1 = item.Mail_Secundario1;
                        info.Mail_Secundario2 = item.Mail_Secundario2;
                        info.IdParroquia = item.IdParroquia;

                        info.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                        info.Persona_Info = new tb_persona_Info();
                        info.Persona_Info.CodPersona = item.CodPersona;
                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                        info.Persona_Info.pe_nombre = (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                        info.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                        info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.pe_direccion = item.pe_direccion;

                        info.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.Persona_Info.pe_correo = item.pe_correo;
                        info.Persona_Info.pe_fax = item.pe_fax;
                        info.Persona_Info.pe_casilla = item.pe_casilla;
                        info.Persona_Info.pe_sexo = item.pe_sexo; ;
                        info.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                        info.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.Persona_Info.pe_estado = item.pe_estado;

                        info.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                        info.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                        info.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.Persona_Info.pe_celular = item.pe_celular;

                        info.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                        info.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                        info.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;

                        info.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }        
        }

        public fa_Cliente_Info Get_Info_Cliente(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_cliente
                                           where A.IdEmpresa == IdEmpresa
                                           && A.IdCliente == IdCliente
                                           select A;

                    foreach (var item in select_tipo_nota)
                    {
                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.Codigo = item.Codigo;
                        info.IdSucursal = item.IdSucursal;
                        info.IdVendedor = item.IdVendedor;
                        info.nomSucursal = item.Su_Descripcion;
                        info.Idtipo_cliente = item.Idtipo_cliente;
                        info.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                        info.cl_Cat_crediticia = (item.cl_Cat_crediticia != null) ? item.cl_Cat_crediticia.Trim() : "";
                        info.cl_plazo = item.cl_plazo;
                        info.cl_porcentaje_descuento = item.cl_porcentaje_descuento;
                        info.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                        info.cl_Cell_Garante = (item.cl_Cell_Garante != null) ? item.cl_Cell_Garante.Trim() : "";
                        info.cl_Garante = (item.cl_Garante != null) ? item.cl_Garante.Trim() : "";
                        info.cl_Mail_Garante = (item.cl_Mail_Garante != null) ? item.cl_Mail_Garante.Trim() : "";
                        info.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                        info.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                        info.cl_Cupo = item.cl_Cupo;
                        info.IdClienteRelacionado = item.IdClienteRelacionado;
                        info.cl_Rep_Legal = (item.cl_Rep_Legal != null) ? item.cl_Rep_Legal.Trim() : "";
                        info.cl_Mail_Rep_Legal = (item.cl_Mail_Rep_Legal != null) ? item.cl_Mail_Rep_Legal.Trim() : "";
                        info.cl_Cell_Rep_Legal = (item.cl_Cell_Rep_Legal != null) ? item.cl_Cell_Rep_Legal.Trim() : "";
                        info.cl_Ger_Gen = (item.cl_Ger_Gen != null) ? item.cl_Ger_Gen.Trim() : "";
                        info.cl_Mail_Ger_Gen = (item.cl_Mail_Ger_Gen != null) ? item.cl_Mail_Ger_Gen.Trim() : "";
                        info.cl_Cell_Ger_Gen = (item.cl_Cell_Ger_Gen != null) ? item.cl_Cell_Ger_Gen.Trim() : "";
                        info.cl_casilla = (item.cl_casilla != null) ? item.cl_casilla.Trim() : "";
                        info.cl_fax = (item.cl_fax != null) ? item.cl_fax.Trim() : "";
                        info.IdActividadComercial = (item.IdActividadComercial != null) ? item.IdActividadComercial.Trim() : "";
                        info.Estado = item.Estado;
                        info.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";

                        info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                        info.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;
                        info.IdCentroCosto_CXC_Credito = item.IdCentroCosto_CXC_Credito;

                        info.IdProvincia = item.IdProvincia;
                        info.IdPais = item.IdPais;

                        info.Mail_Principal = item.Mail_Principal;
                        info.Mail_Secundario1 = item.Mail_Secundario1;
                        info.Mail_Secundario2 = item.Mail_Secundario2;
                        info.IdParroquia = item.IdParroquia;
                        info.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                        info.Persona_Info = new tb_persona_Info();
                        info.Persona_Info.CodPersona = item.CodPersona;
                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                        info.Persona_Info.pe_nombre = (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                        info.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                        info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.pe_direccion = item.pe_direccion;

                        info.Persona_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.Persona_Info.pe_correo = item.pe_correo;
                        info.Persona_Info.pe_fax = item.pe_fax;
                        info.Persona_Info.pe_casilla = item.pe_casilla;
                        info.Persona_Info.pe_sexo = item.pe_sexo; ;
                        info.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                        info.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.Persona_Info.pe_estado = item.pe_estado;

                        info.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                        info.Persona_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                        info.Persona_Info.pe_telefonoInter = item.pe_telefonoInter;
                        info.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.Persona_Info.pe_celular = item.pe_celular;
                        info.Persona_Info.pe_celularSecundario = item.pe_celularSecundario;
                        info.Persona_Info.pe_correo_secundario1 = item.pe_correo_secundario1;
                        info.Persona_Info.pe_correo_secundario2 = item.pe_correo_secundario2;

                        info.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public Boolean Get_Cliente_Es_Parte_Relacionada(int IdEmpresa, string CedulaRuc)
        {
            try
            {
                Boolean Es_Parte_Relacionada = false;

                
                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_cliente
                                           where A.IdEmpresa == IdEmpresa
                                           && A.pe_cedulaRuc == CedulaRuc
                                           select new { A.es_empresa_relacionada };

                    foreach (var item in select_tipo_nota)
                    {
                        Es_Parte_Relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);
                    }
                }
                return Es_Parte_Relacionada;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_Cliente_Info Get_info_cliente_x_codigo_para_saldo_inicial(int IdEmpresa, string cod_cliente, ref string mensajeError)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_cliente
                              where q.Codigo == cod_cliente
                              && q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.Codigo = item.Codigo;
                        info.IdCtaCble_cxc = item.IdCtaCble_cxc;
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }



        public fa_Cliente_Info Get_info_cliente_x_cedula_para_saldo_inicial(int IdEmpresa, string cedula_cliente, ref string mensajeError)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_cliente
                              where q.pe_cedulaRuc == cedula_cliente.Trim()
                              && q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.Codigo = item.Codigo;
                        info.IdCtaCble_cxc = item.IdCtaCble_cxc;
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        info.Persona_Info.pe_nombre = item.pe_nombre;
                        info.Persona_Info.pe_apellido = item.pe_apellido;
                        info.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                        info.Persona_Info.pe_direccion = item.pe_direccion;
                        info.IdSucursal = item.IdSucursal;
                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.IdPersona = item.IdPersona;
                       
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_Cliente_Data() { }
    }
}

