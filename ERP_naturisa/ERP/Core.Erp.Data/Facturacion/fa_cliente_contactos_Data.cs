using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_cliente_contactos_Data
    {
        string Mensaje = "";

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesFacturacion conexion = new EntitiesFacturacion();
                int select = (from q in conexion.fa_cliente_contactos
                              where q.IdEmpresa_cli == IdEmpresa
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in conexion.fa_cliente_contactos
                                     where q.IdEmpresa_cli == IdEmpresa
                                     select q.IdCliente).Max();
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
        
        public Boolean GuardarDB(fa_cliente_contactos_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesFacturacion conexion = new EntitiesFacturacion();
                {
                    fa_cliente_contactos Base = new fa_cliente_contactos();
                    Base.IdCliente = Info.IdCliente;
                    Base.IdEmpresa_cli = Info.IdEmpresa_cli;
                    Base.IdEmpresa_cont = Info.IdEmpresa_cont;
                    Base.IdContacto = Info.IdContacto;
                    Base.observacion = Info.observacion;
                    conexion.fa_cliente_contactos.Add(Base);
                    conexion.SaveChanges();
                    mensaje = "Se ha grabado el Cliente: " + Info.IdCliente.ToString() + " exitosamente.";                    
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                Mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_cliente_contactos_Info> Lista, ref string mensaje)
        {
            try
            {
                bool resultado = false;
                foreach (var item in Lista)
                {
                    resultado = GuardarDB(item, ref mensaje);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                Mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdCliente, ref string mensaje)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var Consulta = context.Database.ExecuteSqlCommand("delete from fa_cliente_contactos where IdCliente= " + IdCliente + " and IdEmpresa_cli=" + IdEmpresa);
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

        public bool ExisteCliente(int IdEmpresa, decimal idCliente, decimal idcontacto, ref string mensaje)
        {
            try
            {
                using (EntitiesFacturacion conexion = new EntitiesFacturacion())
                {
                    if (idCliente == 0)
                    {

                        var cliente = conexion.fa_cliente_contactos.First(p => p.IdEmpresa_cli == IdEmpresa && p.IdContacto == idcontacto);
                        if (cliente.IdContacto == idcontacto)
                        {
                            mensaje = "El Cliente ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                    else
                    {
                        int existe = (from e in conexion.fa_cliente_contactos
                                      where e.IdEmpresa_cli == IdEmpresa
                                      && e.IdCliente == idCliente
                                      select e).Count();

                        if (existe != 0)
                        {
                            mensaje = "El cliente ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_contacto_Info> Get_List_Contactos_x_Clientes(int IdEmpresa, decimal Idcliente)
        {
            List<tb_contacto_Info> listaCon = new List<tb_contacto_Info>();
            try
            {
                using (EntitiesFacturacion Base = new EntitiesFacturacion())
                {
                    var select = from A in Base.vwfa_clientes_contactos
                                 where A.IdCliente == Idcliente
                                 && A.IdEmpresa_cli==IdEmpresa
                                 orderby A.IdContacto
                                 select A;

                    foreach (var item in select)
                    {
                        tb_contacto_Info info = new tb_contacto_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdContacto = item.IdContacto;
                        info.IdPersona = item.IdPersona;
                        info.CodContacto = item.CodContacto;
                        info.Organizacion = item.Organizacion;
                        info.Cargo = item.Cargo;
                        info.Mostrar_como = item.Mostrar_como;
                        info.Fecha_alta = item.Fecha_alta;
                        info.Fecha_Ult_Contacto = item.Fecha_Ult_Contacto;
                        info.IdNacionalidad = item.IdNacionalidad;
                        info.Notas = item.Notas;
                        info.Pagina_Web = item.Pagina_Web;
                        info.Codigo_postal = item.Codigo_postal;
                        info.Estado = item.Estado;
                        //info.Pais_Info.IdPais = item.IdPais;
                        //info.Ciudad_Info.IdCiudad = item.IdCiudad;
                        //info.Provi_Info.IdProvincia = item.IdProvincia;
                        //info.IdNacionalidad = item.IdNacionalidad;

                        tb_persona_Info personaInfo = new tb_persona_Info();
                        personaInfo.IdPersona = item.IdPersona;
                        personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                        personaInfo.pe_apellido = item.pe_apellido;
                        personaInfo.pe_nombre = item.pe_nombre;
                        personaInfo.pe_nombreCompleto = item.pe_nombre + item.pe_apellido;
                        personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                        personaInfo.pe_correo = item.pe_correo;
                        personaInfo.pe_celular = item.pe_celular;
                        personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                        personaInfo.pe_direccion = item.pe_direccion;
                        personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        personaInfo.pe_razonSocial = item.pe_razonSocial;
                        personaInfo.pe_Naturaleza = item.pe_Naturaleza;
                        info.Persona_Info = personaInfo;

                        tb_pais_Info paisInfo = new tb_pais_Info();
                        paisInfo.IdPais = item.IdPais;
                        info.IdPais = paisInfo.IdPais;
                        paisInfo.Nacionalidad = item.Nacionalidad;
                        

                        tb_ciudad_Info ciudadInfo = new tb_ciudad_Info();
                        ciudadInfo.IdCiudad = item.IdCiudad;
                        info.IdCiudad = ciudadInfo.IdCiudad;
                        //info.Ciudad_Info = ciudadInfo;

                        tb_provincia_Info ProvInfo = new tb_provincia_Info();
                        ProvInfo.IdProvincia = item.IdProvincia;
                        info.IdProvincia = ProvInfo.IdProvincia;
                        //info.Provi_Info = ProvInfo;


                        listaCon.Add(info);
                    }
                }
                return listaCon;
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
    }
}
