using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Data;


namespace Core.Erp.Business.Facturacion
{
    public class fa_Cliente_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_bus bus_persona = new tb_persona_bus();
        fa_cliente_pto_emision_cliente_Bus bus_Punto_emision = new fa_cliente_pto_emision_cliente_Bus();
        fa_Cliente_Data data = new fa_Cliente_Data();

        public List<fa_Cliente_Info> Get_List_Clientes(int idempresa)
        {
            try
            {
                return data.Get_List_Cliente(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Clientes", ex.Message), ex) { EntityType = typeof(fa_Cliente_Bus) };
            }
        }

        public List<fa_Cliente_Info> Get_List_Cliente(int idempresa)
        {
            try
            {
                return data.Get_List_Cliente(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Clientes_Todos", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public List<fa_Cliente_Info> ProcesarDataTableFa_Cliente_Info(DataTable ds, int idempresa, int idsucursal, ref string MensajeError)
        {
            List<fa_Cliente_Info> lista = new List<fa_Cliente_Info>();
            string prueba = "";

            int COLUMNA_ERROR = 0;
            string FILA_ERROR = "";
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 12 COLUMNAS
                if (ds.Columns.Count >= 15)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {

                            fa_Cliente_Info info = new fa_Cliente_Info();
                            //RECORRE C/U DE LAS COLUMNAS
                            info.IdEmpresa = idempresa;
                            info.Persona_Info.IdEmpresa = idempresa;
                            info.Persona_Info.pe_sexo = "SEXO_MAS";
                            info.Persona_Info.IdEstadoCivil = "SOLTE";

                            info.Persona_Info.IdTipoPersona = 0;
                            info.IdSucursal = 1;
                            info.IdVendedor = 1;
                            info.IdCiudad = "01";
                            info.cl_plazo = 0;
                            info.Idtipo_cliente = 1;// esta relacion con la tabla clase de proveedor es oblig
                            info.IdTipoCredito = "CON";
                            info.cl_Cat_crediticia = "A";
                            info.cl_porcentaje_descuento = 0;
                            info.cl_Cupo = 0;
                            info.IdClienteRelacionado = 0;

                           if (string.IsNullOrEmpty(row[0].ToString())==false)
                           {


                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                COLUMNA_ERROR = col;
                                switch (col)
                                {
                                    case 0://codigo
                                        info.Codigo = Convert.ToString(row[col]);
                                        FILA_ERROR = info.Codigo;
                                        break;

                                    case 1://natura
                                        info.Persona_Info.pe_Naturaleza = Convert.ToString(row[col]);
                                        break;

                                    case 2://nombre cliente
                                        info.Persona_Info.pe_razonSocial = Convert.ToString(row[col]);
                                        break;

                                    case 3://pe_apellido
                                        info.Persona_Info.pe_apellido = Convert.ToString(row[col]);
                                        break;

                                    case 4://pe_nombre
                                        info.Persona_Info.pe_nombre = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                        break;

                                    case 5://CEDULA
                                        info.Persona_Info.pe_cedulaRuc = Convert.ToString(row[col]);
                                        FILA_ERROR = info.Persona_Info.pe_cedulaRuc;

                                        if (info.Persona_Info.pe_cedulaRuc.Length == 10)
                                        {
                                            info.Persona_Info.IdTipoDocumento = "CED";
                                            info.Persona_Info.pe_Naturaleza = "NATU";
                                        }
                                        else
                                        {
                                            if (info.Persona_Info.pe_cedulaRuc.Length == 13)
                                            {
                                                info.Persona_Info.IdTipoDocumento = "RUC";
                                            }
                                            else
                                            {
                                                info.Persona_Info.IdTipoDocumento = "PAS";
                                            }
                                        }

                                        break;

                                    case 6://direccion
                                        info.Persona_Info.pe_direccion = Convert.ToString(row[col]);
                                        break;

                                    case 7://telefono casa
                                        info.Persona_Info.pe_telefonoCasa = Convert.ToString(row[col]);
                                        break;

                                    case 8://telefono oficina
                                        info.Persona_Info.pe_telefonoOfic = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                        break;

                                    case 9://telefono celular
                                        info.Persona_Info.pe_celular = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                        break;

                                        case 10://correo
                                        info.Persona_Info.pe_correo = Convert.ToString(row[col]);
                                        break;

                                    case 11://pe_fax
                                        info.Persona_Info.pe_fax = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                        break;

                                    case 12://mail principal
                                        info.Mail_Principal = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                        break;

                                    case 13://mail secundario 1
                                        info.Mail_Secundario1 = (Convert.ToString(row[col]) == null) ? "" : Convert.ToString(row[col]);
                                        break;

                                    case 14://natura
                                        info.Estado = Convert.ToString(row[col]);
                                        break;

                                    case 15://DiasPlazo
                                        info.cl_plazo = Convert.ToInt32(row[col]);
                                        break;
                                        
                                    default:
                                        break;
                                }
                            }
                          
                            info.Persona_Info.pe_nombreCompleto = info.Persona_Info.pe_apellido + " " + info.Persona_Info.pe_nombre;
                            info.Persona_Info.pe_estado = info.Estado;
                            lista.Add(info);

                           }
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<fa_Cliente_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
                    lista = new List<fa_Cliente_Info>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_Cliente_Bus) };
            }

        }

        public fa_Cliente_Info Get_info_cliente_x_codigo_para_saldo_inicial(int IdEmpresa, string cod_cliente, ref string mensajeError)
        {
            try
            {
                return data.Get_info_cliente_x_codigo_para_saldo_inicial(IdEmpresa, cod_cliente, ref mensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_Cliente_Bus) };
            }
        }


        public fa_Cliente_Info Get_info_cliente_x_cedula_para_saldo_inicial(int IdEmpresa, string cedula_cliente, ref string mensajeError)
        {
            try
            {
                return data.Get_info_cliente_x_cedula_para_saldo_inicial(IdEmpresa, cedula_cliente, ref mensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_Cliente_Bus) };
            }
        }


        


        public bool Eliminar_Clientes(int idempresa, ref string message)
        {
            try
            {
                fa_Cliente_Data data = new fa_Cliente_Data();

                return data.Eliminar_Clientes(idempresa, ref message);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_Clientes", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean ModificarDB(fa_Cliente_Info info, ref string msg)
        {
            try
            {
                Boolean respuesta=false;
                respuesta = bus_persona.ModificarDB(info.Persona_Info, ref msg);

                if (respuesta)
                {
                    //modificacion datos cliente
                    respuesta= data.ModificarDB(info, ref msg);

                    if (respuesta == true)
                    {
                        if (info.Persona_Info.list_direcciones_x_persona.Count() > 0)
                        {
                            tb_persona_direccion_Bus bus_direccion_x_persona = new tb_persona_direccion_Bus();
                            bus_direccion_x_persona.EliminarDB(info.IdPersona, ref msg);
                            bus_direccion_x_persona.GuardarDB(info.Persona_Info.list_direcciones_x_persona, info.IdPersona, ref msg);
                        }

                        if (info.list_contactos_x_cliente.Count() > 0)
                        {
                            fa_cliente_contactos_Bus BusClie_conta = new fa_cliente_contactos_Bus();
                            BusClie_conta.EliminarDB(info.IdEmpresa, info.IdCliente, ref msg);
                            BusClie_conta.GuardarDB(info.list_contactos_x_cliente, ref msg);
                        }
                        if (info.list_punto_emision_x_cliente.Count > 0)
                        {
                            fa_cliente_pto_emision_cliente_Bus bus_Punto_emision = new fa_cliente_pto_emision_cliente_Bus();
                            bus_Punto_emision.MergeDB(info);
                        }
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean ModificarDB_Cuentas_cbles(int IdEmpresa, string cxc_Contado, string cxc_Anticipo, string cxc_Credito, ref string msg)
        {
            try
            {
                Boolean respuesta = false;
                respuesta = data.ModificarDB_Cuentas_cbles(IdEmpresa, cxc_Contado, cxc_Anticipo, cxc_Credito, ref msg);
                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }
       
        public Boolean GrabarDB(fa_Cliente_Info info,ref decimal IdPersona, ref decimal id, ref string msg)
        {
            try
            {               
                Boolean Result = true;

                if (!bus_persona.VericarCedulaExiste(info.Persona_Info.pe_cedulaRuc, ref msg))
                {
                    Result = bus_persona.GrabarDB(info.Persona_Info, ref IdPersona, ref msg);
                    info.IdPersona = IdPersona;
                }
                else
                {
                    Result = bus_persona.ModificarDB(info.Persona_Info, ref msg);
                    info.IdPersona = info.Persona_Info.IdPersona;
                }

                if (Result)
                {
                    Result = data.GrabarDB(info, ref id, ref msg);
                    // si se grabo el cliente
                    if (Result == true)
                    {
                        if (info.Persona_Info.list_direcciones_x_persona.Count() > 0)
                        {
                            tb_persona_direccion_Bus bus_direccion_x_persona = new tb_persona_direccion_Bus();
                            bus_direccion_x_persona.GuardarDB(info.Persona_Info.list_direcciones_x_persona, info.IdPersona, ref msg);
                        }

                        if (info.list_contactos_x_cliente.Count() > 0)
                        {
                            fa_cliente_contactos_Bus BusClie_conta = new fa_cliente_contactos_Bus();
                            BusClie_conta.GuardarDB(info.list_contactos_x_cliente, ref msg);
                        }
                        if (info.list_punto_emision_x_cliente.Count > 0)
                        {
                            fa_cliente_pto_emision_cliente_Bus bus_Punto_emision = new fa_cliente_pto_emision_cliente_Bus();
                            bus_Punto_emision.MergeDB(info);
                        }
                    }
                }
                return Result;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean EliminarDB(fa_Cliente_Info info, ref  string msg)
        {
            try
            {
                fa_cliente_pto_emision_cliente_Bus bus_Punto_emision = new fa_cliente_pto_emision_cliente_Bus();
                Boolean result = false;

                if(data.EliminarDB(info, ref msg))
                    result = bus_Punto_emision.AnularDB(info.IdEmpresa, info.IdCliente);
                return result;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean ConsultarClienteVendedor(int IdEmpresa, ref fa_Cliente_Info Cliente, ref fa_Vendedor_Info Vendedor) 
        {
            try
            {
                return data.ConsultarClienteVendedor(IdEmpresa, ref Cliente, ref Vendedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarClienteVendedor", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public fa_Cliente_Info Get_info_Cliente_x_IdPersona(int Idempresa, decimal IdPersona)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();
                info = data.Get_Info_Cliente_x_IdPersona(Idempresa, IdPersona);
                if (info!=null)
                    info.list_punto_emision_x_cliente = bus_Punto_emision.Get_List(info.IdEmpresa, info.IdCliente);                  
                return info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_Cliente_x_IdPersona", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public fa_Cliente_Info Get_Info_Cliente(int Idempresa, decimal IdCliente)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();
                info = data.Get_Info_Cliente(Idempresa, IdCliente);
                if(info!=null)
                info.list_punto_emision_x_cliente = bus_Punto_emision.Get_List(info.IdEmpresa, info.IdCliente);
                return info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Cliente", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }
    }
}
