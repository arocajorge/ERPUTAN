﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;


namespace Core.Erp.Data.Contabilidad
{
    public class ct_Centro_costo_Data
    {
        
        public ct_Centro_costo_Info _CentroCostoInfo = new ct_Centro_costo_Info();

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo(int IdEmpresa)
        {
            try
            {

                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select a.IdEmpresa, a.IdCentroCosto, a.CodCentroCosto, a.Centro_costo, '['+a.IdCentroCosto+'] '+ a.Centro_costo Centro_costo2,"
                                +" a.IdCatalogo, a.pc_EsMovimiento, a.IdNivel, a.pc_Estado, a.IdCtaCble"
                                +" from ct_centro_costo as a"
                                +" where a.IdEmpresa = "+IdEmpresa.ToString();

                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new ct_Centro_costo_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                            CodCentroCosto = Convert.ToString(reader["CodCentroCosto"]),
                            Centro_costo = Convert.ToString(reader["Centro_costo"]),
                            Centro_costo2 = Convert.ToString(reader["Centro_costo2"]),
                            IdCatalogo = Convert.ToDecimal(reader["IdCatalogo"]),
                            pc_EsMovimiento = Convert.ToString(reader["pc_EsMovimiento"]),
                            IdNivel = Convert.ToInt32(reader["IdNivel"]),
                            pc_Estado = Convert.ToString(reader["pc_Estado"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"])
                        });
                    }
                    reader.Close();
                }
                return lM;
            }
            catch (Exception ex)
            {
                string MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public List<ct_Centro_costo_Info> Get_list_Centro_costo_x_IdCuentas_Padre(int IdEmpresa, string IdCuenta_Padre, ref string MensajeError)
        {
            try
            {

                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                EntitiesDBConta OECentroCost = new EntitiesDBConta();
                var selectCentroCost = from C in OECentroCost.ct_centro_costo
                                       where C.IdEmpresa == IdEmpresa 
                                       && C.IdCentroCostoPadre == IdCuenta_Padre
                                       select C;

                foreach (var item in selectCentroCost)
                {
                    ct_Centro_costo_Info Cbt = new ct_Centro_costo_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdCentroCosto = item.IdCentroCosto.Trim();
                    Cbt.CodCentroCosto = item.CodCentroCosto;
                    Cbt.Centro_costo = item.Centro_costo.Trim();
                    Cbt.Centro_costo2 = "[" + item.CodCentroCosto.Trim() + "] - " + item.Centro_costo.Trim();
                    Cbt.IdCentroCostoPadre = item.IdCentroCostoPadre.Trim();
                    Cbt.IdCatalogo = Convert.ToDecimal(item.IdCatalogo);
                    Cbt.pc_EsMovimiento = item.pc_EsMovimiento;
                    Cbt.IdNivel = item.IdNivel;
                    Cbt.pc_Estado = item.pc_Estado;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.CodCentroCosto = item.CodCentroCosto;
                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }
        
        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_de_Movimiento(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select a.IdEmpresa, a.IdCentroCosto, a.CodCentroCosto, a.Centro_costo, '['+a.IdCentroCosto+'] '+ a.Centro_costo as Centro_costo2,"
                                +" a.IdCentroCostoPadre, a.IdCatalogo, a.pc_EsMovimiento, a.IdNivel, a.IdCtaCble, a.pc_Estado, "
                                +" case when a.pc_Estado = 'A' THEN 'ACTIVO' ELSE '*ANULADO*' END AS Sestado"
                                +" from ct_centro_costo as a"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.pc_EsMovimiento = 'S' AND a.pc_Estado = 'A'";
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new ct_Centro_costo_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                            CodCentroCosto = Convert.ToString(reader["CodCentroCosto"]),
                            Centro_costo = Convert.ToString(reader["Centro_costo"]),
                            Centro_costo2 = Convert.ToString(reader["Centro_costo2"]),
                            IdCentroCostoPadre = Convert.ToString(reader["IdCentroCostoPadre"]),
                            IdCatalogo = Convert.ToDecimal(reader["IdCatalogo"]),
                            pc_EsMovimiento = Convert.ToString(reader["pc_EsMovimiento"]),
                            IdNivel = Convert.ToInt32(reader["IdNivel"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            pc_Estado = Convert.ToString(reader["pc_Estado"]),
                            Sestado = Convert.ToString(reader["Sestado"])
                        });
                    }
                    reader.Close();
                }
                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_padre(int IdEmpresa, ref string MensajeError)
        {
         
            try
            {
                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                EntitiesDBConta OECentroCost = new EntitiesDBConta();
                var selectCentroCost = from C in OECentroCost.vwct_centro_costo
                                       where C.IdEmpresa == IdEmpresa 
                                       //&& C.pc_EsMovimiento == "N" Comentada debido a que en el caso de grafinpren todos generan movimientos
                                       select C;

                foreach (var item in selectCentroCost)
                {
                    ct_Centro_costo_Info Cbt = new ct_Centro_costo_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdCentroCosto = item.IdCentroCosto; //se quito el trim
                    Cbt.CodCentroCosto = item.CodCentroCosto;
                    Cbt.Centro_costo2 = "[" + item.IdCentroCosto.Trim() + "] - " + item.Centro_costo.Trim();
                    Cbt.Centro_costo = item.Centro_costo;
                    Cbt.IdCentroCostoPadre = item.IdCentroCostoPadre;
                    Cbt.pc_EsMovimiento = item.pc_EsMovimiento;
                    Cbt.IdNivel = item.IdNivel;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.Centro_costoPadre = item.Centro_costoPadre;

                    lM.Add(Cbt);
                }
                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }        

        public string Get_IdCentroCosto_x_Raiz(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                int Id;
                int Digito_x_Nivel1 = 0;
                string IdCentroCosto = "";
                EntitiesDBConta base_ = new EntitiesDBConta();

                var q1 = from C in base_.ct_centro_costo_nivel
                        where C.IdEmpresa == IdEmpresa
                        && C.IdNivel==1
                        select C;

                foreach (var item in q1)
                {
                    Digito_x_Nivel1 = item.ni_digitos;
                }

                if (Digito_x_Nivel1 > 0)
                {

                    var q = from C in base_.ct_centro_costo
                            where C.IdEmpresa == IdEmpresa
                            select C;
                    if (q.ToList().Count == 0)
                    {
                        IdCentroCosto = "1";
                        IdCentroCosto = IdCentroCosto.PadLeft(Digito_x_Nivel1, '0');
                    }

                    else
                    {

                        var select_ = (from CbtCble in base_.ct_centro_costo
                                       where CbtCble.IdEmpresa == IdEmpresa
                                       && CbtCble.IdNivel==1
                                       select CbtCble.IdCentroCosto).Count();
                        Id = Convert.ToInt32(select_) + 1;

                        IdCentroCosto = Id.ToString();
                        IdCentroCosto = IdCentroCosto.PadLeft(Digito_x_Nivel1, '0');
                        //IdCentroCosto.PadLeft(Digito_x_Nivel1, '0');

                    }
                }

                return IdCentroCosto;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        
        
        }
        
        public Boolean ModificarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo.FirstOrDefault(minfo => minfo.IdCentroCosto == info.IdCentroCosto && minfo.IdEmpresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.CodCentroCosto = (info.CodCentroCosto == null) ? info.IdCentroCosto : info.CodCentroCosto.Trim();
                        contact.Centro_costo = info.Centro_costo;
                        contact.IdCentroCostoPadre = (info.IdCentroCostoPadre == "") ? null : info.IdCentroCostoPadre;
                        contact.IdCatalogo = info.IdCatalogo;
                        contact.IdNivel = Convert.ToByte(info.IdNivel);
                        contact.pc_EsMovimiento = (info.pc_EsMovimiento == "")? "S" : Convert.ToString(info.pc_EsMovimiento);
                        contact.IdCtaCble = info.IdCtaCble;
                        contact.pc_Estado = info.pc_Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean GrabarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_centro_costo
                            where per.IdCentroCosto.Trim() == info.IdCentroCosto.Trim() && per.IdEmpresa == info.IdEmpresa
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_centro_costo();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdCentroCosto = info.IdCentroCosto;
                        address.CodCentroCosto = (info.CodCentroCosto == null) ? info.IdCentroCosto : info.CodCentroCosto.Trim();
                        address.Centro_costo = info.Centro_costo;
                        address.IdCentroCostoPadre = (info.IdCentroCostoPadre == "") ? null : info.IdCentroCostoPadre;
                        address.IdCatalogo = info.IdCatalogo;
                        address.pc_EsMovimiento = info.pc_EsMovimiento;
                        address.IdCtaCble = (info.IdCtaCble == null) ? "1" : info.IdCtaCble;
                        address.IdNivel = (info.IdNivel == 0) ? 1 : info.IdNivel;
                        address.pc_Estado = info.pc_Estado;
                        address.Fecha_Transac = info.Fecha_Transac;
                        address.IdUsuario = info.IdUsuario;
                        context.ct_centro_costo.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean AnularDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo.FirstOrDefault(dinfo => dinfo.IdEmpresa == info.IdEmpresa && dinfo.IdCentroCosto == info.IdCentroCosto);

                    if (contact != null)
                    {
                        contact.pc_Estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificaNivel(int IdNivel, int IdEmpresa, ref string MensajeError)
        {
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = (from reg in tabla.ct_centro_costo_nivel
                         where reg.IdEmpresa == IdEmpresa
                         select reg.IdNivel).Max();
                return (Convert.ToInt32(q.ToString()) == IdNivel) ? true : false;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public ct_Centro_costo_Data()
        {
            
        }
    }
}

