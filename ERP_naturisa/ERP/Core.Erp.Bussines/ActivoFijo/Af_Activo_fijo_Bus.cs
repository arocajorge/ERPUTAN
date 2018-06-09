using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.ActivoFijo_FJ;
using System.Data;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Activo_fijo_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Af_Activo_fijo_Data data = new Af_Activo_fijo_Data();
        Af_Activo_fijo_CtasCbles_Bus busCtaCble = new Af_Activo_fijo_CtasCbles_Bus();
        List<Af_Activo_fijo_CtasCbles_Info> lstCbleAf = new List<Af_Activo_fijo_CtasCbles_Info>();
        Af_Activo_fijo_x_Af_Activo_fijo_Bus activos_relacionados = new Af_Activo_fijo_x_Af_Activo_fijo_Bus();

        

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo(int IdEmpresa)
        {
            try
            {
                return data.Get_List_ActivoFijo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo_x_categoria(int IdEmpresa, int idCategoria)
        {
            try
            {
                return data.Get_List_ActivoFijo_x_categoria(IdEmpresa,idCategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo_x_categoria", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }
        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo_x_Tipo(int IdEmpresa, int IdTipo)
        {
            try
            {
                return data.Get_List_ActivoFijo_x_Tipo(IdEmpresa, IdTipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo_x_categoria", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }
        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria(int IdEmpresa, int idCategoria)
        {
            try
            {
                return data.Get_List_Vista_Af_x_Categoria(IdEmpresa, idCategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Vista_Af_x_Categoria", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria_x_tarifario(int idEmpresa, int idCategoria, decimal IdTarifario)
        {
            try
            {
                return data.Get_List_Vista_Af_x_Categoria_x_tarifario(idEmpresa, idCategoria, IdTarifario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Vista_Af_x_Categoria", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria_disponibles(int idEmpresa, int idCategoria)
        {
            try
            {
                return data.Get_List_Vista_Af_x_Categoria_disponibles(idEmpresa, idCategoria);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Vista_Af_x_Categoria_disponibles", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo(int IdEmpresa, string EstadoProceso)
        {       
            try
            {

                return data.Get_List_ActivoFijo(IdEmpresa, EstadoProceso);                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af(int idEmpresa)
        {
            try
            {
                return data.Get_List_Vista_Af(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Vista_Af", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Af_Activo_fijo_Info Get_Info_ActivoFijo(int IdEmpresa, int IdActivoFijo)
        {
            try
            {

                return data.Get_Info_ActivoFijo(IdEmpresa, IdActivoFijo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Info_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Af_Activo_fijo_Info Get_ActivoFijo(int IdEmpresa, string codigo)
        {
            try
            {

                return data.Get_ActivoFijo(IdEmpresa, codigo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Info_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Activo_fijo_Info info, ref string msg)
        {
            try
            {
                Boolean respuesta = false;

                respuesta=data.ModificarDB(info, ref msg);

                if (respuesta)
                {
                                                  
                                   respuesta = activos_relacionados.EliminarDB(info.IdEmpresa, info.IdActivoFijo);
                                   if (info.Es_carroceria==true)
                                   {
                                       foreach (var item in info.lista_Activo_relacionados)
                                       {
                                           item.IdEmpresa = info.IdEmpresa;
                                           item.IdActivoFijo_hijo = info.IdActivoFijo;
                                       }

                                       respuesta = activos_relacionados.EliminarDB(info.IdEmpresa, info.IdActivoFijo);
                                       respuesta = activos_relacionados.GuardarDB(info.lista_Activo_relacionados);    
                                   }

                                   Af_Activo_fijo_CtasCbles_Bus BusCtas_AF = new Af_Activo_fijo_CtasCbles_Bus();
                                   BusCtas_AF.EliminarDB(info.IdEmpresa, info.IdActivoFijo);

                                    int c=1;
                                   foreach (var item in info.ListAf_Activo_fijo_CtasCbles)
                                   {
                                       item.Secuencia = c++;
                                   }
                                   BusCtas_AF.GuardarDB(info.ListAf_Activo_fijo_CtasCbles, ref msg);

                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Boolean ModificarUbicacion(Af_CambioUbicacion_Activo_Info Info, ref string msg)
        {
            try
            {
                return data.ModificarUbicacion(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarUbicacion", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Boolean GrabarDB(Af_Activo_fijo_Info info, ref int id, ref string CodActivo, ref string msg)
        {
            try
            {
                Boolean respuesta = false;


                respuesta =Validar_y_corregir_objeto(ref info, ref msg);

                if (respuesta == true)
                {

                    respuesta = data.GrabarDB(info, ref id, ref CodActivo, ref msg);

                    if (respuesta)
                    {
                        
                        activos_relacionados.EliminarDB(info.IdEmpresa, info.IdActivoFijo);
                        if ((bool)info.Es_carroceria)
                        {
                            if (info.lista_Activo_relacionados != null)
                            {
                                foreach (var item in info.lista_Activo_relacionados)
                                {
                                    item.IdEmpresa = info.IdEmpresa;
                                    item.IdActivoFijo_hijo = id;
                                }
                                activos_relacionados.EliminarDB(info.IdEmpresa, id);
                                activos_relacionados.GuardarDB(info.lista_Activo_relacionados);
                            }
                        }


                        Af_Activo_fijo_CtasCbles_Bus BusCtas_AF = new Af_Activo_fijo_CtasCbles_Bus();
                        BusCtas_AF.EliminarDB(info.IdEmpresa, info.IdActivoFijo);

                        int c = 1;
                        foreach (var item in info.ListAf_Activo_fijo_CtasCbles)
                        {
                            item.IdActivoFijo = info.IdActivoFijo;
                            item.Secuencia = c++;
                        }

                        BusCtas_AF.GuardarDB(info.ListAf_Activo_fijo_CtasCbles, ref msg);

                    }

                }

                return respuesta;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Boolean EliminarDB(Af_Activo_fijo_Info info, ref  string msg)
        {
            try
            {
                return data.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public bool Actualizar_Unidades(List<fa_registro_unidades_x_equipo_det_Info> Lista)
        {
            try
            {
                return data.Actualizar_Unidades(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_Unidades", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public Boolean Grabar_Poliza_x_Activo(Af_Poliza_x_AF_Info info)
        {
            try
            {
                return data.Grabar_Poliza_x_Activo(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar_Poliza_x_Activo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        Boolean Validar_y_corregir_objeto(ref Af_Activo_fijo_Info Info,ref string msg)
        {
            try
            {
                #region 'Validaciones'
                /*--- validaciones */


                if (Info.IdEmpresa <= 0 && Info.IdSucursal <= 0 )
                {
                    msg = "Error en la cabecera  uno de los PK es <=0";
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(Af_Activo_fijo_Bus) };
                }

                              
                /*--- Fin validaciones */


                /*--- corrigiendo data */

                Info.Estado = (string.IsNullOrEmpty(Info.Estado) == true) ? "A" : Info.Estado;
                Info.Es_carroceria = (Info.Es_carroceria == null) ? false : Info.Es_carroceria;
                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CtasCbles_AF", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };

            }
        }

        public Af_Activo_fijo_Bus()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CtasCbles_AF", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }
        }

        public bool EliminarDB_Todos(int IdEmpresa, ref string message)
        {
            try
            {
                Af_Activo_fijo_Data data = new Af_Activo_fijo_Data();
                return data.EliminarDB_Todos(IdEmpresa, ref message);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }

        }
       
        public List<Af_Activo_fijo_Info> ProcesarDataTablePc_ActivoFijo_Info(DataTable ds, int idempresa, int idsucursal, ref string MensajeError)
        {
            List<Af_Activo_fijo_Info> lista = new List<Af_Activo_fijo_Info>();
            string prueba = "";

            int COLUMNA_ERROR = 0;
            string FILA_ERROR = "";
            
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 7 COLUMNAS
                if (ds.Columns.Count >= 8)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {

                        foreach (DataRow row in ds.Rows)
                        {
                            Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                            //RECORRE C/U DE LAS COLUMNAS}
                            info.IdEmpresa= idempresa;
                            info.IdSucursal =idsucursal;
                            info.IdActijoFijoTipo = 1;
                            info.IdCategoriaAF = 1;
                            info.Estado = "A";
                            info.IdTipoDepreciacion = 1;
                            info.IdCatalogo_Marca = "TIP_MARCA_0000001";
                            info.IdCatalogo_Modelo = "TIP_DISEÑO_0000001";
                            info.IdCatalogo_Color = "TIP_COLOR_0000007";
                            info.IdTipoCatalogo_Ubicacion = "TIP_UBICACION_0000001";
                            
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                COLUMNA_ERROR = col;

                                //if (string.IsNullOrEmpty(Convert.ToString(row[0])) == false)
                                //{
                                    switch (col)
                                    {

                                        case 0://Codigo Activo Fijo
                                            info.CodActivoFijo = Convert.ToString(row[col]);
                                            FILA_ERROR = info.CodActivoFijo;
                                            break;

                                        case 1://Activo fijo Nombre
                                            info.Af_Nombre = Convert.ToString(row[col]);
                                            break;

                                        case 2://Observacion
                                            info.Af_observacion = Convert.ToString(row[col]);

                                            break;

                                        case 3://Af_Fecha_compra
                                            info.Af_fecha_compra = Convert.ToDateTime(row[col]);

                                            break;

                                        case 4://Af_fecha_ini_depre
                                            info.Af_fecha_ini_depre = (Convert.ToDateTime(row[col]));
                                            break;

                                        case 5://Af_fecha_fin_depre
                                            info.Af_fecha_fin_depre = Convert.ToDateTime(row[col]);
                                            break;

                                        case 6://Af_costo_compra
                                            info.Af_costo_compra = Convert.ToDouble(row[col]);
                                            break;

                                        case 7://Af_depreciacion_acumulada
                                            info.Af_Depreciacion_acum = Convert.ToDouble(row[col]);
                                            break;

                                        case 8://Af_Costo_historico
                                            info.Af_Costo_historico = Convert.ToDouble(row[col]);
                                            break;

                                        default:
                                            break;
                                    }

                                }
                                lista.Add(info);

                        //    }
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<Af_Activo_fijo_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
                    lista = new List<Af_Activo_fijo_Info>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Bus) };
            }

        }
    }
}
