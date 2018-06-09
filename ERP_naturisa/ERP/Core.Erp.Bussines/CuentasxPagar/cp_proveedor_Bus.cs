using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Data;


namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_proveedor_Bus
    {
       
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_proveedor_Data data = new cp_proveedor_Data();


        public List<cp_proveedor_Info> Get_List_proveedor(int IdEmpresa)
        {
            try
            {
                var Lista =data.Get_List_proveedor(IdEmpresa);
                
                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_proveedor", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }

        }

        public List<cp_proveedor_Info> Get_List_proveedor_x_clase(int IdEmpresa,int IdClaseProveedor)
        {
            try
            {
                var Lista = data.Get_List_proveedor_x_clase(IdEmpresa, IdClaseProveedor);

                return Lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_proveedor", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }

        }

        private Boolean validar_y_corregir_objeto(ref cp_proveedor_Info Info ,ref string msg)
        {
            try
            {
                
                
                if (Info.IdClaseProveedor == 0)
                {
                    cp_proveedor_clase_Bus BusProveeCl = new cp_proveedor_clase_Bus();
                    cp_proveedor_clase_Info InfoClaseProve = new cp_proveedor_clase_Info();
                    InfoClaseProve=BusProveeCl.Get_List_proveedor_clase(Info.IdEmpresa).FirstOrDefault();

                    if (InfoClaseProve == null)
                    {
                        msg = "Debe de existir un registro en la tabla cp_proveedor_clase";
                        return false;
                    }
                    else
                    {
                        Info.IdClaseProveedor = InfoClaseProve.IdClaseProveedor;
                    }
                }

                if (Info.IdBanco_acreditacion==0)
                {
                    tb_banco_Bus BusBanco = new tb_banco_Bus();
                    List<tb_banco_Info> ListInfoBanco = new List<tb_banco_Info>();
                    ListInfoBanco = BusBanco.Get_List_Banco();
                    if (ListInfoBanco != null)
                    {
                        Info.IdBanco_acreditacion = ListInfoBanco.FirstOrDefault().IdBanco;
                    }
               
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
                
            }
        
        }

        public Boolean GrabarDB(cp_proveedor_Info info, ref decimal idPro, ref string msg)
        {
            try
            {

                Boolean res = true;

                if (validar_y_corregir_objeto(ref info, ref msg) == true)
                {
                    res = data.GrabarDB(info, ref idPro, ref msg);

                    
                    if (info.lista_codigoSRI_Proveedor.Count != 0)
                    {
                        foreach (var item in info.lista_codigoSRI_Proveedor)
                        {
                            item.IdProveedor = idPro;
                        }

                        cp_proveedor_codigo_SRI_Data odata = new cp_proveedor_codigo_SRI_Data();
                        if (odata.GrabarDB(info.lista_codigoSRI_Proveedor))
                        {

                        }

                    }

                }
                else
                {
                    res = false;
                
                }

                return res;
            }
            catch(Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public Boolean AnularDB(cp_proveedor_Info info)
        {
            try
            {

                return data.AnularDB(info);

               
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public Boolean ModificarDB(cp_proveedor_Info  info)
        {
            try
            {

                Boolean res = true;

                res = data.ModificarDB(info);
                        
                if (info.lista_codigoSRI_Proveedor.Count != 0)
                {
                   //consultar
                    cp_proveedor_codigo_SRI_Data odata = new cp_proveedor_codigo_SRI_Data();
                    List<cp_proveedor_codigo_SRI_Info> lista = new List<cp_proveedor_codigo_SRI_Info>();
                    lista = odata.Get_List_proveedor_codigo_SRI(info.IdEmpresa, info.IdProveedor);

                    foreach (var item in info.lista_codigoSRI_Proveedor)
                    {
                        item.IdProveedor = info.IdProveedor;
                    }
                                        
                    if (lista.Count != 0)
                    {
                        if (odata.EliminarDB(info.IdEmpresa, info.IdProveedor))
                        {
                            if (odata.GrabarDB(info.lista_codigoSRI_Proveedor))
                            {

                            }
                        }
                    }
                    else
                    {
                        if (odata.GrabarDB(info.lista_codigoSRI_Proveedor))
                        {

                        }
                    
                    }                                                         
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public Boolean ModificarDB_Cuentas_cbles(int IdEmpresa, string IdCtaCble_CXP, string IdCtaCble_Anticipo, string IdCtaCble_Gasto, ref string msg)
        {
            try
            {
                Boolean respuesta = false;
                respuesta = data.ModificarDB_Cuentas_cbles(IdEmpresa, IdCtaCble_CXP, IdCtaCble_Anticipo, IdCtaCble_Gasto, ref msg);
                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB_Cuentas_cbles", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public Boolean VericarCodigoExiste(string codigo, int IdEmp, ref string mensaje)
        {
            try
            {
                return data.VericarCodigoExiste(codigo, IdEmp, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public cp_proveedor_Info Get_Info_Proveedor_Solo_CtasCbles(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return data.Get_Info_Proveedor_Solo_CtasCbles(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Proveedor", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public cp_proveedor_Info Get_Info_Proveedor(int IdEmpresa, decimal IdProveedor)
         {
            try
            {
                return data.Get_Info_Proveedor(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Proveedor", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
         }

        public cp_proveedor_Info Get_Info_Proveedor(int IdEmpresa, string Ruc_x_Proveedor)
        {
            try
            {
                return data.Get_Info_Proveedor(IdEmpresa, Ruc_x_Proveedor);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_proveedor", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public List<cp_proveedor_Info> Get_List_ProveedoresXPresupuestoCusTalme(int IdEmpresa)
         {
             try
             {
                 return data.Get_List_ProveedoresXPresupuestoCusTalme(IdEmpresa);
             }
             catch(Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProveedoresXPresupuestoCusTalme", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
             }
         }

        public cp_proveedor_Info Get_Info_Proveedor_x_Persona(int IdEmpresa, decimal IdPersona, ref string msj)
         {
             try
             {
                 return data.Get_Info_Proveedor_x_Persona(IdEmpresa, IdPersona, ref msj);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Proveedor_x_Persona", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
             }
         }

        public List<cp_proveedor_Info> ProcesarDataTablePc_Proveedor_Info(DataTable ds, int idempresa, int idsucursal, ref string MensajeError)
         {
             List<cp_proveedor_Info> lista = new List<cp_proveedor_Info>();
             string prueba = "";

             cp_proveedor_clase_Bus busClaseProv = new cp_proveedor_clase_Bus();
             List<cp_proveedor_clase_Info> listaClasProv = new List<cp_proveedor_clase_Info>();

             listaClasProv = busClaseProv.Get_List_proveedor_clase(idempresa);
             int IdClaseProveedor_x_default = 0;
             string IdCiudad_x_default = "";
             if (listaClasProv.FirstOrDefault() == null)
             {
                 MensajeError = "no existe datos en la tabla  cp_proveedor_clase ";
                 return new List<cp_proveedor_Info>(); ;
             }
             else
             {
                 IdClaseProveedor_x_default = listaClasProv.FirstOrDefault().IdClaseProveedor;
             }

             tb_Ciudad_Bus busCiudad = new tb_Ciudad_Bus();
             List<tb_ciudad_Info> listCiudad = new List<tb_ciudad_Info>();

             listCiudad= busCiudad.Get_List_Ciudad();
             if (listCiudad.FirstOrDefault() == null)
             {
                 MensajeError = "no existe datos en la tabla  tb_ciudad ";
                 return new List<cp_proveedor_Info>(); ;
             }
             else
             {
                 IdCiudad_x_default = listCiudad.FirstOrDefault().IdCiudad;
             }



            


             int COLUMNA_ERROR = 0;
             string FILA_ERROR = "";
             lista.Clear();
             try
             {
                 //VALIDAR QUE TENGA MAS DE 12 COLUMNAS
                 if (ds.Columns.Count >= 10)
                 {
                     //RECORRE EL DATATABLE REGISTRO X REGISTRO
                     if (ds.Rows.Count > 0)
                     {
                         foreach (DataRow row in ds.Rows)
                         {

                             cp_proveedor_Info info = new cp_proveedor_Info();
                             //RECORRE C/U DE LAS COLUMNAS
                             info.IdEmpresa = idempresa;
                             info.Persona_Info.IdEmpresa = idempresa;
                             info.Persona_Info.pe_sexo = "SEXO_MAS";
                             info.Persona_Info.IdEstadoCivil = "SOLTE";

                         
                             info.Persona_Info.IdTipoPersona = 0;
                          


                             info.pr_estado = "A";
                             info.pr_nacionalidad = "NAC";

                             info.IdCiudad = IdCiudad_x_default;
                             
                             info.pr_plazo = 0;


                             info.IdClaseProveedor = IdClaseProveedor_x_default;


                             info.IdTipoServicio = "T_SERVI_001";
                             info.IdTipoGasto = "T_GASTOS_001";

                             
                             for (int col = 0; col < ds.Columns.Count + 1; col++)
                             {
                                 COLUMNA_ERROR = col;
                                 switch (col)
                                 {
                                     case 0://codigo
                                         info.pr_codigo = Convert.ToString(row[col]);
                                         FILA_ERROR = info.pr_codigo;
                                         break;

                                     case 1://CEDULA
                                         info.Persona_Info.pe_cedulaRuc = Convert.ToString(row[col]);
                                         FILA_ERROR = info.Persona_Info.pe_cedulaRuc;

                                         if (info.Persona_Info.pe_cedulaRuc.Length == 10)
                                         {
                                             info.Persona_Info.IdTipoDocumento = "CED";
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

                                     case 2://nombre proveedor
                                         info.pr_nombre = Convert.ToString(row[col]);
                                         info.Persona_Info.pe_nombre = "";
                                         info.Persona_Info.pe_apellido = info.pr_nombre;
                                         info.Persona_Info.pe_razonSocial = info.pr_nombre;
                                       
                                         break;

                                     case 3://pr_girar_cheque_a
                                    
                                         info.pr_girar_cheque_a =Convert.ToString(row[col]);
                                         break;

                                     case 4://direccion
                                         info.Persona_Info.pe_direccion = Convert.ToString(row[col]);
                                         break;

                                     case 5://contri espe
                                         info.pr_contribuyenteEspecial = (Convert.ToString(row[col]) == "SI") ? "S" : "N";
                                         break;

                                     case 6://tel
                                         info.Persona_Info.pe_telfono_Contacto = Convert.ToString(row[col]);
                                         break;

                                     case 7://correo
                                         info.Persona_Info.pe_correo = Convert.ToString(row[col]);
                                         break;

                                     case 8://contacto
                                         info.contacto = Convert.ToString(row[col]);
                                         break;

                                     case 9://natura
                                         info.Persona_Info.pe_Naturaleza = Convert.ToString(row[col]);
                                         break;


                                     default:
                                         break;
                                 }
                             }
                             info.Persona_Info.pe_nombreCompleto = info.Persona_Info.pe_apellido + " " + info.Persona_Info.pe_nombre;
                             info.Persona_Info.pe_estado = info.pr_estado;
                             lista.Add(info);
                         }
                     }
                     else
                     {
                         MensajeError = "Por favor verifique que el archivo contenga Datos.";
                         lista = new List<cp_proveedor_Info>();
                     }

                 }
                 else
                 {
                     MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
                     lista = new List<cp_proveedor_Info>();
                 }
                 return lista;
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
             }

         }

        public decimal GetId(int IdEmpresa)
         {
             try
             {
                 return data.GetId(IdEmpresa);

             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
             }
         }
       
        public cp_proveedor_Bus() { }

        public bool EliminarDB_Todos(int IdEmpresa, ref string message)
        {
            try
            {
                cp_proveedor_Data data = new cp_proveedor_Data();
                return data.EliminarDB_Todos(IdEmpresa, ref message);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }

        }

        public cp_proveedor_Info Get_info_proveedor_x_codigo_para_saldo_inicial(int IdEmpresa, string cod_prov, ref string MensajeError)
        {
            try
            {
                return data.Get_info_proveedor_x_codigo_para_saldo_inicial(IdEmpresa,cod_prov, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_proveedor_x_codigo_para_saldo_inicial", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }

        public cp_proveedor_Info Get_Info_ProveedorVistaPrevia(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return data.Get_Info_ProveedorVistaPrevia(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ProveedorVistaPrevia", ex.Message), ex) { EntityType = typeof(cp_proveedor_Bus) };
            }
        }
    }
}
