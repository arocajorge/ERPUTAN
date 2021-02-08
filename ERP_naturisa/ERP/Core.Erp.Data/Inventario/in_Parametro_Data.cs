using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.SqlClient;

namespace Core.Erp.Data.Inventario
{
    public class in_Parametro_Data
    {
        string mensaje = "";
        public Boolean ModificarDB(in_Parametro_Info info, int IdEmpresa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE [dbo].[in_parametro]"
                        + " SET [IdMovi_inven_tipo_egresoBodegaOrigen] = " + (info.IdMovi_inven_tipo_egresoBodegaOrigen == null ? "NULL" : info.IdMovi_inven_tipo_egresoBodegaOrigen.ToString())
                                        + " ,[IdMovi_inven_tipo_ingresoBodegaDestino] = " + (info.IdMovi_inven_tipo_ingresoBodegaDestino == null ? "NULL" : info.IdMovi_inven_tipo_ingresoBodegaDestino.ToString())
                                        + " ,[Maneja_Stock_Negativo] " + (info.Maneja_Stock_Negativo == null ? "NULL" : ("'" + info.Maneja_Stock_Negativo.ToString() + "'"))
                                        + " ,[IdMovi_inven_tipo_egresoAjuste] = " + (info.IdMovi_inven_tipo_egresoAjuste == null ? "NULL" : info.IdMovi_inven_tipo_egresoAjuste.ToString())
                                        + " ,[IdMovi_inven_tipo_ingresoAjuste] = " + (info.IdMovi_inven_tipo_ingresoAjuste == null ? "NULL" : info.IdMovi_inven_tipo_ingresoAjuste.ToString())
                                        + " ,[IdTipoCbte_CostoInven] = " + (info.IdTipoCbte_CostoInven == null ? "NULL" : info.IdTipoCbte_CostoInven.ToString())
                                        + " ,[IdMovi_Inven_tipo_x_anu_Ing] = " + (info.IdMovi_Inven_tipo_x_anu_Ing == null ? "NULL" : info.IdMovi_Inven_tipo_x_anu_Ing.ToString())
                                        + " ,[IdMovi_Inven_tipo_x_anu_Egr] = " + (info.IdMovi_Inven_tipo_x_anu_Egr == null ? "NULL" : info.IdMovi_Inven_tipo_x_anu_Egr.ToString())
                                        + " ,[IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa] = " + (info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa == null ? "NULL" : info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa.ToString())
                                        + " ,[IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa] = " + (info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa == null ? "NULL" : info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa.ToString())
                                        + " ,[ApruebaAjusteFisicoAuto] = " + (info.ApruebaAjusteFisicoAuto == null ? "NULL" : ("'" + info.ApruebaAjusteFisicoAuto.ToString() + "'"))
                                        + " ,[IdEstadoAproba_x_Ing] = " + (info.IdEstadoAproba_x_Ing == null ? "NULL" : ("'" + info.IdEstadoAproba_x_Ing.ToString() + "'"))
                                        + " ,[IdEstadoAproba_x_Egr] = " + (info.IdEstadoAproba_x_Egr == null ? "NULL" : ("'" + info.IdEstadoAproba_x_Egr.ToString() + "'"))
                                        + " ,[IdMovi_Inven_tipo_x_Dev_Inv_x_Ing] = " + (info.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing == null ? "NULL" : info.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing.ToString())
                                        + " ,[IdMovi_Inven_tipo_x_Dev_Inv_x_Erg] = " + (info.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg == null ? "NULL" : info.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg.ToString())
                                        + " ,[P_Grabar_Items_x_Cada_Movi_Inven] = " + (info.P_Grabar_Items_x_Cada_Movi_Inven == null ? "NULL" : ((bool)info.P_Grabar_Items_x_Cada_Movi_Inven ? "1" : "0"))
                                        + " ,[P_Fecha_para_contabilizacion_ingr_egr] = " + (info.P_Fecha_para_contabilizacion_ingr_egr == null ? "NULL" : info.P_Fecha_para_contabilizacion_ingr_egr.ToString())
                                        + " ,[P_se_valida_parametrizacion_x_producto] = " + (info.P_se_valida_parametrizacion_x_producto == null ? "NULL" : info.P_se_valida_parametrizacion_x_producto.ToString())
                                        + " ,[P_IdCtaCble_transitoria_transf_inven] = " + (info.P_IdCtaCble_transitoria_transf_inven == null ? "NULL" : ("'" + info.P_IdCtaCble_transitoria_transf_inven.ToString() + "'"))
                                        + " ,[IdMovi_inven_tipo_mobile_ing] = " + (info.IdMovi_inven_tipo_mobile_ing == null ? "NULL" : info.IdMovi_inven_tipo_mobile_ing.ToString())
                                        + " ,[IdMovi_inven_tipo_mobile_egr] = " + (info.IdMovi_inven_tipo_mobile_egr == null ? "NULL" : info.IdMovi_inven_tipo_mobile_egr.ToString())
                                        + " ,[P_ValidarDiasHaciaAtras] = " + (info.P_ValidarDiasHaciaAtras == null ? "NULL" : info.P_ValidarDiasHaciaAtras.ToString())
                                        + " ,[IdCtaCble_Provision] = " + (info.IdCtaCble_Provision == null ? "NULL" : ("'"+info.IdCtaCble_Provision.ToString()+"'"))
                                        +" WHERE IdEmpresa = "+IdEmpresa.ToString();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                in_Parametro_Info Cbt = null;
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT [IdEmpresa],[IdCentroCosto_Padre_a_cargar],[LabelCentroCosto],[IdMovi_inven_tipo_egresoBodegaOrigen],[IdMovi_inven_tipo_ingresoBodegaDestino],[Maneja_Stock_Negativo],[Usuario_Escoge_Motivo],[IdMovi_inven_tipo_egresoAjuste]"
                                        +" ,[IdMovi_inven_tipo_ingresoAjuste],[Mostrar_CentroCosto_en_transacciones],[Rango_Busqueda_Transacciones],[pa_EstadoInicial_Pedido],[IdCtaCble_Inven],[IdCtaCble_CostoInven],[IdTipoCbte_CostoInven],[IdBodegaSuministro],[IdCentro_Costo_Inventario]"
                                        +" ,[IdCentro_Costo_Costo],[IdTipoCbte_CostoInven_Reverso],[IdMovi_Inven_tipo_x_anu_Ing],[IdMovi_Inven_tipo_x_anu_Egr],[IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa],[IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa],[ApruebaAjusteFisicoAuto],[IdSucursal_Suministro]"
                                        +" ,[IdEstadoAproba_x_Ing],[IdEstadoAproba_x_Egr],[IdMovi_Inven_tipo_x_Dev_Inv_x_Ing],[IdMovi_Inven_tipo_x_Dev_Inv_x_Erg],[P_Grabar_Items_x_Cada_Movi_Inven],[P_Fecha_para_contabilizacion_ingr_egr],[P_se_valida_parametrizacion_x_producto]"
                                        +" ,[P_Al_Conta_CtaInven_Buscar_en],[P_Al_Conta_CtaCosto_Buscar_en],[P_IdCtaCble_transitoria_transf_inven],[IdMovi_inven_tipo_mobile_ing],[IdMovi_inven_tipo_mobile_egr],[P_ValidarDiasHaciaAtras],[IdCtaCble_Provision]"
                                        +" FROM [dbo].[in_parametro]"
                                        +" where IdEmpresa = "+IdEmpresa.ToString();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cbt = new in_Parametro_Info
                        {
                            IdCentroCosto_Padre_a_cargar = reader["IdCentroCosto_Padre_a_cargar"] == DBNull.Value ? null : reader["IdCentroCosto_Padre_a_cargar"].ToString(),
                            LabelCentroCosto = reader["LabelCentroCosto"] == DBNull.Value ? null : reader["LabelCentroCosto"].ToString(),
                            IdMovi_inven_tipo_egresoBodegaOrigen = reader["IdMovi_inven_tipo_egresoBodegaOrigen"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_egresoBodegaOrigen"],
                            IdMovi_inven_tipo_ingresoBodegaDestino = reader["IdMovi_inven_tipo_ingresoBodegaDestino"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_ingresoBodegaDestino"],
                            Maneja_Stock_Negativo = reader["Maneja_Stock_Negativo"] == DBNull.Value ? null : reader["Maneja_Stock_Negativo"].ToString(),
                            Usuario_Escoge_Motivo = reader["Usuario_Escoge_Motivo"] == DBNull.Value ? null : reader["Usuario_Escoge_Motivo"].ToString(),
                            IdMovi_inven_tipo_egresoAjuste = reader["IdMovi_inven_tipo_egresoAjuste"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_egresoAjuste"],
                            IdMovi_inven_tipo_ingresoAjuste = reader["IdMovi_inven_tipo_ingresoAjuste"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_ingresoAjuste"],
                            Mostrar_CentroCosto_en_transacciones = reader["Mostrar_CentroCosto_en_transacciones"] == DBNull.Value ? null : reader["Mostrar_CentroCosto_en_transacciones"].ToString(),
                            Rango_Busqueda_Transacciones = (int)reader["Rango_Busqueda_Transacciones"],
                            ApruebaAjusteFisicoAuto = reader["ApruebaAjusteFisicoAuto"] == DBNull.Value ? null : reader["ApruebaAjusteFisicoAuto"].ToString(),
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCtaCble_Inven = reader["IdCtaCble_Inven"] == DBNull.Value ? null : reader["IdCtaCble_Inven"].ToString(),
                            IdCtaCble_CostoInven = reader["IdCtaCble_CostoInven"] == DBNull.Value ? null : reader["IdCtaCble_CostoInven"].ToString(),
                            IdCentro_Costo_Costo = reader["IdCentro_Costo_Costo"] == DBNull.Value ? null : reader["IdCentro_Costo_Costo"].ToString(),
                            IdCentro_Costo_Inventario = reader["IdCentro_Costo_Inventario"] == DBNull.Value ? null : reader["IdCentro_Costo_Inventario"].ToString(),
                            IdTipoCbte_CostoInven = reader["IdTipoCbte_CostoInven"] == DBNull.Value ? null : (int?)reader["IdTipoCbte_CostoInven"],
                            IdTipoCbte_CostoInven_Reverso = reader["IdTipoCbte_CostoInven_Reverso"] == DBNull.Value ? null : (int?)reader["IdTipoCbte_CostoInven_Reverso"],
                            IdMovi_Inven_tipo_x_anu_Egr = reader["IdMovi_Inven_tipo_x_anu_Egr"] == DBNull.Value ? null : (int?)reader["IdMovi_Inven_tipo_x_anu_Egr"],
                            IdMovi_Inven_tipo_x_anu_Ing = reader["IdMovi_Inven_tipo_x_anu_Ing"] == DBNull.Value ? null : (int?)reader["IdMovi_Inven_tipo_x_anu_Ing"],
                            IdSucursalSuministro = Convert.ToInt32(reader["IdSucursal_Suministro"]),
                            IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = reader["IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa"] == DBNull.Value ? null : (int?)reader["IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa"],
                            IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = reader["IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa"] == DBNull.Value ? null : (int?)reader["IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa"],
                            IdBodegaSuministro = Convert.ToInt32(reader["IdBodegaSuministro"]),
                            IdEstadoAproba_x_Ing = reader["IdEstadoAproba_x_Ing"] == DBNull.Value ? null : reader["IdEstadoAproba_x_Ing"].ToString(),
                            IdEstadoAproba_x_Egr = reader["IdEstadoAproba_x_Egr"] == DBNull.Value ? null : reader["IdEstadoAproba_x_Egr"].ToString(),
                            P_Grabar_Items_x_Cada_Movi_Inven = reader["P_Grabar_Items_x_Cada_Movi_Inven"] == DBNull.Value ? null : (bool?)reader["P_Grabar_Items_x_Cada_Movi_Inven"],
                            IdMovi_Inven_tipo_x_Dev_Inv_x_Erg = reader["IdMovi_Inven_tipo_x_Dev_Inv_x_Erg"] == DBNull.Value ? null : (int?)reader["IdMovi_Inven_tipo_x_Dev_Inv_x_Erg"],
                            IdMovi_Inven_tipo_x_Dev_Inv_x_Ing = reader["IdMovi_Inven_tipo_x_Dev_Inv_x_Ing"] == DBNull.Value ? null : (int?)reader["IdMovi_Inven_tipo_x_Dev_Inv_x_Ing"],
                            P_Fecha_para_contabilizacion_ingr_egr = reader["P_Fecha_para_contabilizacion_ingr_egr"] == DBNull.Value ? null : reader["P_Fecha_para_contabilizacion_ingr_egr"].ToString(),
                            P_se_valida_parametrizacion_x_producto = reader["P_se_valida_parametrizacion_x_producto"] == DBNull.Value ? null : (bool?)reader["P_se_valida_parametrizacion_x_producto"],
                            P_IdCtaCble_transitoria_transf_inven = reader["P_IdCtaCble_transitoria_transf_inven"] == DBNull.Value ? null : reader["P_IdCtaCble_transitoria_transf_inven"].ToString(),
                            IdMovi_inven_tipo_mobile_ing = reader["IdMovi_inven_tipo_mobile_ing"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_mobile_ing"],
                            IdMovi_inven_tipo_mobile_egr = reader["IdMovi_inven_tipo_mobile_egr"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_mobile_egr"],
                            P_ValidarDiasHaciaAtras = reader["P_ValidarDiasHaciaAtras"] == DBNull.Value ? null : (int?)reader["P_ValidarDiasHaciaAtras"],
                            IdCtaCble_Provision = reader["IdCtaCble_Provision"] == DBNull.Value ? null : reader["IdCtaCble_Provision"].ToString()
                        };
                    }
                    return Cbt;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
