﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_centro_costo_sub_centro_costo_Data
    {
        string mensaje = "";


        public List<ct_centro_costo_sub_centro_costo_Info> Get_list_centro_costo_sub_centro_costo(int IdEmpresa) {
            try
            {
                List<ct_centro_costo_sub_centro_costo_Info> lst = new List<ct_centro_costo_sub_centro_costo_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select b.IdEmpresa, b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo, b.cod_subcentroCosto, b.Centro_costo, "
                                + " '['+b.IdCentroCosto_sub_centro_costo+'] '+b.Centro_costo as Centro_costo2, b.pc_Estado, b.IdCtaCble, a.Centro_costo as nom_Centro_costo,"
                                + " b.IdCentroCosto+'-' + b.IdCentroCosto_sub_centro_costo as IdRegistro"
                                + " from ct_centro_costo as a inner join"
                                + " ct_centro_costo_sub_centro_costo as b on a.IdEmpresa = b.IdEmpresa and a.IdCentroCosto = b.IdCentroCosto"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " AND A.pc_Estado = 'A'";

                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lst.Add(new ct_centro_costo_sub_centro_costo_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                            IdCentroCosto_sub_centro_costo = Convert.ToString(reader["IdCentroCosto_sub_centro_costo"]),
                            cod_subcentroCosto = Convert.ToString(reader["cod_subcentroCosto"]),
                            Centro_costo = Convert.ToString(reader["Centro_costo"]),
                            Centro_costo2 = Convert.ToString(reader["Centro_costo2"]),
                            pc_Estado = Convert.ToString(reader["pc_Estado"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            nom_Centro_costo = Convert.ToString(reader["nom_Centro_costo"]),
                            IdRegistro = Convert.ToString(reader["IdRegistro"])
                        });
                    }
                    reader.Close();
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_centro_costo_sub_centro_costo_Info> Get_list_centro_costo_sub_centro_costo(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                List<ct_centro_costo_sub_centro_costo_Info> lst = new List<ct_centro_costo_sub_centro_costo_Info>();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    var consulta = conta.ct_centro_costo_sub_centro_costo.Where(q => q.IdEmpresa == IdEmpresa &&
                                         q.IdCentroCosto == IdCentroCosto).ToList();

                    foreach (var item in consulta)
                    {
                        ct_centro_costo_sub_centro_costo_Info info = new ct_centro_costo_sub_centro_costo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.cod_subcentroCosto = item.cod_subcentroCosto;
                        info.Centro_costo2 = "[" + item.IdCentroCosto_sub_centro_costo +  "] - " +  item.Centro_costo;
                        info.Centro_costo = item.Centro_costo;
                        info.pc_Estado = item.pc_Estado;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdRegistro=item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;
                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public ct_centro_costo_sub_centro_costo_Info Get_Info_centro_costo_sub_centro_costo(int IdEmpresa, string IdCentroCosto,string IdCentroCosto_sub_centro_costo)
        {
            try
            {
                ct_centro_costo_sub_centro_costo_Info info = new ct_centro_costo_sub_centro_costo_Info();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    var consulta = from q in conta.ct_centro_costo_sub_centro_costo
                                   where q.IdEmpresa == IdEmpresa &&
                                         q.IdCentroCosto == IdCentroCosto
                                         && q.IdCentroCosto_sub_centro_costo == IdCentroCosto_sub_centro_costo
                                   select q;

                    foreach (var item in consulta)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.cod_subcentroCosto = item.cod_subcentroCosto;
                        info.Centro_costo2 = "[" + item.IdCentroCosto_sub_centro_costo + "] - " + item.Centro_costo;
                        info.Centro_costo = item.Centro_costo;
                        info.pc_Estado = item.pc_Estado;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdRegistro = item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;
                        
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_centro_costo_sub_centro_costo_Info Get_Info_centro_costo_sub_centro_costo(int IdEmpresa, string IdCentroCosto_sub_centro_costo)
        {
            try
            {
                ct_centro_costo_sub_centro_costo_Info info = new ct_centro_costo_sub_centro_costo_Info();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    var consulta = from q in conta.ct_centro_costo_sub_centro_costo
                                   where q.IdEmpresa == IdEmpresa
                                         && q.IdCentroCosto_sub_centro_costo == IdCentroCosto_sub_centro_costo
                                   select q;

                    foreach (var item in consulta)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.cod_subcentroCosto = item.cod_subcentroCosto;
                        info.Centro_costo2 = "[" + item.IdCentroCosto_sub_centro_costo + "] - " + item.Centro_costo;
                        info.Centro_costo = item.Centro_costo;
                        info.pc_Estado = item.pc_Estado;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdRegistro = item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;

                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(ct_centro_costo_sub_centro_costo_Info info)
        {
            try
            {
                using (EntitiesDBConta OECentroCost = new EntitiesDBConta())
                {

                    ct_centro_costo_sub_centro_costo subCentro = new ct_centro_costo_sub_centro_costo();

                    subCentro.IdEmpresa = info.IdEmpresa;
                    subCentro.IdCentroCosto = info.IdCentroCosto;
                    subCentro.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo = GetIdSubCentroCosto(info.IdEmpresa);
                    subCentro.cod_subcentroCosto = info.cod_subcentroCosto;
                    subCentro.Centro_costo = info.Centro_costo;
                    subCentro.pc_Estado = info.pc_Estado;
                    subCentro.IdCtaCble = info.IdCtaCble;

                    OECentroCost.ct_centro_costo_sub_centro_costo.Add(subCentro);
                    OECentroCost.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_centro_costo_sub_centro_costo_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo_sub_centro_costo.FirstOrDefault(minfo => minfo.IdCentroCosto == info.IdCentroCosto && minfo.IdEmpresa == info.IdEmpresa && minfo.IdCentroCosto_sub_centro_costo == info.IdCentroCosto_sub_centro_costo);

                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        contact.cod_subcentroCosto = info.cod_subcentroCosto;
                        contact.Centro_costo = info.Centro_costo;
                        contact.pc_Estado = info.pc_Estado;
                        contact.IdCtaCble = info.IdCtaCble;
                        context.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Mover_Subcentro_costo(ct_centro_costo_sub_centro_costo_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo_sub_centro_costo.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCentroCosto_sub_centro_costo == info.IdCentroCosto_sub_centro_costo);

                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        contact.cod_subcentroCosto = info.cod_subcentroCosto;
                        contact.Centro_costo = info.Centro_costo;
                        contact.pc_Estado = info.pc_Estado;
                        contact.IdCtaCble = info.IdCtaCble;
                        context.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ct_centro_costo_sub_centro_costo_Info _Info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {

                    ct_centro_costo_sub_centro_costo subCentro = context.ct_centro_costo_sub_centro_costo.FirstOrDefault(v => v.IdCentroCosto == _Info.IdCentroCosto && v.IdEmpresa == _Info.IdEmpresa && v.IdCentroCosto_sub_centro_costo == _Info.IdCentroCosto_sub_centro_costo);
                    if (subCentro != null)
                    {
                        subCentro.pc_Estado = "I";
                        context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public String GetIdSubCentroCosto(int IdEmpresa)
        {
            int Id =0;
            try
            {
                using (EntitiesDBConta oEnti = new EntitiesDBConta())
                {
                    var lst = from C in oEnti.ct_centro_costo_sub_centro_costo
                              where C.IdEmpresa == IdEmpresa
                              select C;

                    foreach (var item in lst)
                    {
                        if (Convert.ToInt32(item.IdCentroCosto_sub_centro_costo) > Id)
                            Id = Convert.ToInt32(item.IdCentroCosto_sub_centro_costo);
                    }
                    Id = Id + 1;
                }
                return Convert.ToString((Convert.ToString(Id).Length == 1) ? "00" + Convert.ToString(Id) : (Convert.ToString(Id).Length == 2) ? "0" + Convert.ToString(Id) : Convert.ToString(Id));
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
    }
}
