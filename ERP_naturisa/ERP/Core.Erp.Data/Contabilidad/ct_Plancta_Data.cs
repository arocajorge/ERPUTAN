using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using System.Resources;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.SqlClient;

namespace Core.Erp.Data.Contabilidad
{ 
    
    public class ct_Plancta_Data
    {
        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select a.IdEmpresa, a.IdCtaCble, a.pc_Cuenta, '{'+a.pc_clave_corta+'} ['+ a.IdCtaCble+'] '+ a.pc_Cuenta as pc_Cuenta2,"
                                +" a.IdCtaCblePadre, a.IdCatalogo, a.pc_Naturaleza,a.IdNivelCta, a.IdGrupoCble, a.pc_Estado, "
                                + " a.pc_EsMovimiento, a.pc_es_flujo_efectivo, b.pc_Cuenta as CuentaPadre, A.pc_clave_corta,"
                                +" a.IdTipoCtaCble,  case when a.pc_Estado = 'A' then 'ACTIVO' ELSE '*ANULADO*' END AS SEstado"
                                +" from ct_plancta as a left join"
                                +" ct_plancta as b on a.IdEmpresa = b.IdEmpresa and a.IdCtaCblePadre = b.IdCtaCble"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new ct_Plancta_Info
                        {
                            pc_clave_corta = Convert.ToString(reader["pc_clave_corta"]),
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            pc_Cuenta = Convert.ToString(reader["pc_Cuenta"]),
                            pc_Cuenta2 = Convert.ToString(reader["pc_Cuenta2"]),
                            IdCtaCblePadre = Convert.ToString(reader["IdCtaCblePadre"]),
                            pc_Naturaleza = Convert.ToString(reader["pc_Naturaleza"]),
                            IdNivelCta = Convert.ToInt32(reader["IdNivelCta"]),
                            IdGrupoCble = Convert.ToString(reader["IdGrupoCble"]),
                            pc_Estado = Convert.ToString(reader["pc_Estado"]),
                            pc_EsMovimiento = Convert.ToString(reader["pc_EsMovimiento"]),
                            pc_es_flujo_efectivo = Convert.ToString(reader["pc_es_flujo_efectivo"]),
                            CuentaPadre = Convert.ToString(reader["CuentaPadre"]),
                            IdTipoCtaCble = Convert.ToString(reader["IdTipoCtaCble"]),
                            SEstado = Convert.ToString(reader["SEstado"])
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

        public List<ct_Plancta_Info> Get_List_Plancta_x_Tipo_Balance(int IdEmpresa,string Tipo_Balance, ref string MensajeError)
        {
            try
            {

                string ClaveCorta = "";

                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    join N in OEselectPlancta.ct_plancta_nivel on new { C.IdEmpresa, C.IdNivelCta } equals new { N.IdEmpresa, N.IdNivelCta }
                                    join G in OEselectPlancta.ct_grupocble on new { C.IdGrupoCble } equals new { G.IdGrupoCble }
                                    join M in OEselectPlancta.ct_grupocble_Mayor on new { G.IdGrupo_Mayor } equals new { M.IdGrupo_Mayor}
                                    where C.IdEmpresa == IdEmpresa
                                    && G.gc_estado_financiero == Tipo_Balance
                                    orderby C.IdCtaCble
                                    select new
                                    {
                                        C.IdEmpresa,
                                        C.IdCtaCble,
                                        C.pc_Cuenta,
                                        C.IdCtaCblePadre,
                                        C.IdCatalogo,
                                        C.pc_Naturaleza,
                                        C.IdNivelCta,
                                        C.IdGrupoCble,
                                        C.pc_Estado,
                                        C.pc_EsMovimiento,
                                        C.pc_es_flujo_efectivo,
                                        N.nv_NumDigitos,
                                        C.pc_clave_corta,
                                        C.IdTipoCtaCble,
                                        G.gc_GrupoCble,
                                        G.gc_estado_financiero,
                                        G.gc_Orden,
                                        M.IdGrupo_Mayor,
                                        M.nom_grupo_mayor,
                                        M.orden,
                                        C.IdTipo_Gasto
                                    };

                foreach (var item in selectPlancta)
                {

                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info NivelO = new ct_Plancta_nivel_Info();


                    ClaveCorta = (item.pc_clave_corta == null || item.pc_clave_corta == "") ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdEmpresa = item.IdEmpresa;
                    _PlantaCtaInfo.IdCtaCble = item.IdCtaCble.Trim();
                    _PlantaCtaInfo.pc_Cuenta = item.pc_Cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta + "[" + item.IdCtaCble.Trim() + "] - " + item.pc_Cuenta.Trim();
                    _PlantaCtaInfo.IdCtaCblePadre = (item.IdCtaCblePadre == null) ? "" : item.IdCtaCblePadre.Trim();
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.IdCatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_Naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.IdNivelCta;
                    _PlantaCtaInfo.IdGrupoCble = item.IdGrupoCble.Trim();
                    _PlantaCtaInfo.pc_Estado = item.pc_Estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                    _PlantaCtaInfo._Plancta_nivel_Info = NivelO;
                    _PlantaCtaInfo._Plancta_nivel_Info.IdEmpresa = item.IdEmpresa;
                    _PlantaCtaInfo._Plancta_nivel_Info.IdNivelCta = item.IdNivelCta;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo._Plancta_nivel_Info.nv_NumDigitos = item.nv_NumDigitos;

                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.IdTipoCtaCble = item.IdTipoCtaCble;
                    _PlantaCtaInfo.Nom_GrupoCble = item.gc_GrupoCble;
                    _PlantaCtaInfo.gc_estado_financiero = item.gc_estado_financiero;
                    _PlantaCtaInfo.OrderGrupoCble = item.gc_Orden;
                    
                    _PlantaCtaInfo.orden = item.orden;
                    _PlantaCtaInfo.IdGrupo_Mayor = item.IdGrupo_Mayor;
                    _PlantaCtaInfo.nom_grupo_mayor = item.nom_grupo_mayor;
                    _PlantaCtaInfo.IdTipo_Gasto = item.IdTipo_Gasto;
                    lM.Add(_PlantaCtaInfo);
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

        public List<ct_Plancta_Info> ProcesarDataTableCt_Plancta_Info(DataTable ds, int idempresa, ref string MensajeError)
        {
            List<ct_Plancta_Info> lista = new List<ct_Plancta_Info>();
            lista.Clear();
            string IdCtaCble_var = "";
            string msgE = "";
            try
            {
                //VALIDAR QUE TENGA MAS DE 9 COLUMNAS
                if (ds.Columns.Count >= 8)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        int c = 0;

                        foreach (DataRow row in ds.Rows)
                        {
                            
                            ct_Plancta_Info info = new ct_Plancta_Info();
                            //RECORRE C/U DE LAS COLUMNAS
                            info.IdEmpresa = idempresa;
                            object[] arreglo = row.ItemArray;
                            c = c + 1;
                            if (c == 430) 
                            { 
                                c++; 
                            }
                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0:
                                        info.IdCtaCble = Convert.ToString(row[col]);
                                        IdCtaCble_var = Convert.ToString(row[col]);
                                        break;
                                    case 1:
                                        info.pc_Cuenta = Convert.ToString(row[col]);
                                        info.pc_Cuenta2 = Convert.ToString(row[col]);
                                        break;
                                    case 2:
                                        info.IdCtaCblePadre = Convert.ToString(row[col]);
                                        break;
                                    case 3:
                                        info.IdNivelCta = Convert.ToInt32(row[col]);
                                        msgE = "IdNivel de Cta";
                                        break;
                                    case 4:
                                        info.pc_EsMovimiento = Convert.ToString(row[col]);
                                        break;
                                    case 5:
                                        info.IdGrupoCble = Convert.ToString(row[col]);
                                        break;
                                    case 6:
                                        info.pc_Naturaleza = Convert.ToString(row[col]);
                                        break;
                                    case 7:
                                        info.pc_Estado = Convert.ToString(row[col]);
                                        break;
                                    //case 8:
                                    //    info.pc_clave_corta = Convert.ToString(row[col]);
                                    //    break;
                                    default:
                                        break;
                                }
                            }
                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos.";
                        lista = new List<ct_Plancta_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 11 columnas.";
                    lista = new List<ct_Plancta_Info>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                MensajeError = "Error en" + msgE + ex.Message + IdCtaCble_var;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_PlanctaUltNivel(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();

                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.vwct_Plancta_UltimoNivel
                                    select C;

                foreach (var item in selectPlancta)
                {

                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();
                    _PlantaCtaInfo.pc_Cuenta = item.pc_Cuenta;
                    _PlantaCtaInfo.IdCtaCble = item.IdCtaCble;


                    lM.Add(_PlantaCtaInfo);
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

        public List<ct_Plancta_Info> Get_List_Plan_ctaPadre(int IdEmpresa ,ref string MensajeError)
        {
            try
            {
                string ClaveCorta = "";

                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    where C.IdEmpresa == IdEmpresa && C.pc_EsMovimiento == "N"
                                    select C;
                                        

                foreach (var item in selectPlancta)
                {
                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();

                    ClaveCorta = (item.pc_clave_corta == null) ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdCtaCble = item.IdCtaCble.Trim();
                    _PlantaCtaInfo.pc_Cuenta = item.pc_Cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta+ "[" + item.IdCtaCble.Trim() + "] - " + item.pc_Cuenta.Trim();
                    _PlantaCtaInfo.IdEmpresa = item.IdEmpresa;
                    _PlantaCtaInfo.IdCtaCblePadre = (item.IdCtaCblePadre!=null)?item.IdCtaCblePadre.Trim():"";
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.IdCatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_Naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.IdNivelCta;
                    _PlantaCtaInfo.IdGrupoCble = item.IdGrupoCble;
                    _PlantaCtaInfo.pc_Estado = item.pc_Estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.IdTipoCtaCble = item.IdTipoCtaCble;
                    _PlantaCtaInfo.IdTipo_Gasto = item.IdTipo_Gasto;
                    lM.Add(_PlantaCtaInfo);
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

        public List<ct_Plancta_Info> Get_List_Plancta_x_ctas_Movimiento(int IdEmpresa, Boolean Mostrar_Todo_El_Plan_cta=false)
        {
            
            try
            {
                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select a.IdEmpresa, a.IdCtaCble, a.pc_Cuenta, '{'+a.pc_clave_corta+'} ['+ a.IdCtaCble+'] '+ a.pc_Cuenta as pc_Cuenta2,"
                                +" a.IdCtaCblePadre, a.IdCatalogo, a.pc_Naturaleza,a.IdNivelCta, a.IdGrupoCble, a.pc_Estado, "
                                + " a.pc_EsMovimiento, a.pc_es_flujo_efectivo, b.pc_Cuenta as CuentaPadre, A.pc_clave_corta,"
                                +" a.IdTipoCtaCble,  case when a.pc_Estado = 'A' then 'ACTIVO' ELSE '*ANULADO*' END AS SEstado"
                                +" from ct_plancta as a left join"
                                +" ct_plancta as b on a.IdEmpresa = b.IdEmpresa and a.IdCtaCblePadre = b.IdCtaCble"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.pc_EsMovimiento = " + (Mostrar_Todo_El_Plan_cta ? "a.pc_EsMovimiento" : "'S'") + " AND A.pc_Estado = 'A'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new ct_Plancta_Info
                        {
                            pc_clave_corta = Convert.ToString(reader["pc_clave_corta"]),
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            pc_Cuenta = Convert.ToString(reader["pc_Cuenta"]),
                            pc_Cuenta2 = Convert.ToString(reader["pc_Cuenta2"]),
                            IdCtaCblePadre = Convert.ToString(reader["IdCtaCblePadre"]),
                            pc_Naturaleza = Convert.ToString(reader["pc_Naturaleza"]),
                            IdNivelCta = Convert.ToInt32(reader["IdNivelCta"]),
                            IdGrupoCble = Convert.ToString(reader["IdGrupoCble"]),
                            pc_Estado = Convert.ToString(reader["pc_Estado"]),
                            pc_EsMovimiento = Convert.ToString(reader["pc_EsMovimiento"]),
                            pc_es_flujo_efectivo = Convert.ToString(reader["pc_es_flujo_efectivo"]),
                            CuentaPadre = Convert.ToString(reader["CuentaPadre"]),
                            IdTipoCtaCble = Convert.ToString(reader["IdTipoCtaCble"]),
                            SEstado = Convert.ToString(reader["SEstado"])
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

        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, string IdCtaIni, string IdCtaFin, ref string MensajeError)
        {
            try
            {
                string ClaveCorta = "";
                List<ct_Plancta_Info> lM = new List<ct_Plancta_Info>();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta
                                    where C.IdEmpresa == IdEmpresa && C.pc_EsMovimiento == "S" && (C.IdCtaCble.CompareTo(IdCtaIni.Trim()) >= 0 && C.IdCtaCble.CompareTo(IdCtaFin.Trim()) <= 0)
                                    select C;
                foreach (var item in selectPlancta)
                {
                    ct_Plancta_Info _PlantaCtaInfo = new ct_Plancta_Info();

                    ClaveCorta = (item.pc_clave_corta == null || item.pc_clave_corta=="") ? "" : "{" + item.pc_clave_corta + "}";

                    _PlantaCtaInfo.IdCtaCble = item.IdCtaCble;// se quito el trim
                    _PlantaCtaInfo.pc_Cuenta = item.pc_Cuenta.Trim();
                    _PlantaCtaInfo.pc_Cuenta2 = ClaveCorta+ "[" + item.IdCtaCble.Trim() + "] - " + item.pc_Cuenta.Trim();
                    _PlantaCtaInfo.IdEmpresa = item.IdEmpresa;
                    _PlantaCtaInfo.IdCtaCblePadre = item.IdCtaCblePadre;
                    _PlantaCtaInfo.IdCatalogo = Convert.ToDecimal(item.IdCatalogo);
                    _PlantaCtaInfo.pc_Naturaleza = item.pc_Naturaleza;
                    _PlantaCtaInfo.IdNivelCta = item.IdNivelCta;
                    _PlantaCtaInfo.IdGrupoCble = item.IdGrupoCble;
                    _PlantaCtaInfo.pc_Estado = item.pc_Estado;
                    _PlantaCtaInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                    _PlantaCtaInfo.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    _PlantaCtaInfo.pc_clave_corta = item.pc_clave_corta;
                    _PlantaCtaInfo.IdTipoCtaCble = item.IdTipoCtaCble;

                    lM.Add(_PlantaCtaInfo);
                }
                return lM;
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

        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, int IdNivel)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();
                ct_Plancta_Info lM = new ct_Plancta_Info();
                EntitiesDBConta OEselectPlancta = new EntitiesDBConta();
                var selectPlancta = from C in OEselectPlancta.ct_plancta                                    
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdNivelCta == IdNivel
                                    select new
                                    {
                                        C.IdEmpresa,
                                        C.IdCtaCble,
                                        C.pc_Cuenta,
                                        C.IdCtaCblePadre,
                                        C.IdCatalogo,
                                        C.pc_Naturaleza,
                                        C.IdNivelCta,
                                        C.IdGrupoCble,
                                        C.pc_Estado,
                                        C.pc_EsMovimiento,
                                        C.pc_es_flujo_efectivo,                                 
                                        C.pc_clave_corta,
                                        C.IdTipoCtaCble,
                                        C.IdTipo_Gasto
                                    };

                foreach (var item in selectPlancta)
                {
                    lM = new ct_Plancta_Info();
                    lM.IdEmpresa = item.IdEmpresa;
                    lM.IdCtaCble = item.IdCtaCble.Trim();
                    lM.pc_Cuenta = item.pc_Cuenta.Trim();
                    lM.IdCtaCblePadre = (item.IdCtaCblePadre == null) ? "" : item.IdCtaCblePadre.Trim();
                    lM.IdCatalogo = Convert.ToDecimal(item.IdCatalogo);
                    lM.pc_Naturaleza = item.pc_Naturaleza;
                    lM.IdNivelCta = item.IdNivelCta;
                    lM.IdGrupoCble = item.IdGrupoCble.Trim();
                    lM.pc_Estado = item.pc_Estado;
                    lM.pc_EsMovimiento = item.pc_EsMovimiento;
                    lM.pc_es_flujo_efectivo = item.pc_es_flujo_efectivo;
                    lM.pc_clave_corta = item.pc_clave_corta;
                    lM.IdTipoCtaCble = item.IdTipoCtaCble;
                    lM.IdTipo_Gasto = item.IdTipo_Gasto;
                    Lista.Add(lM);

                }
            
                return Lista;
            }

            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> Get_List_Plancta_para_asiento_cierre(int IdEmpresa, int Anio)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.spCON_saldo_cuentas_x_anio_para_cierre(IdEmpresa, Anio)
                              select q;

                    foreach (var item in lst)
                    {
                        ct_Plancta_Info info = new ct_Plancta_Info();
                        info.IdEmpresa = IdEmpresa;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Saldo = item.dc_Valor == null ? 0 : Convert.ToDouble(item.dc_Valor);
                        Lista.Add(info);
                    }
                }
                
                return Lista;
            }

            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Id(int IdEmpresa, string codPadre, ref string MensajeError)
        {
            string idHijo="";

            try
            {
                //declaracion de variables
                int numDigitosxPadre=0;
                int i_nivelPadre=0;
                int numDigitosxHijo=0;
                int i_nivelHijo=0;

                EntitiesDBConta OEPlanCta = new EntitiesDBConta();
                var tb = from C in OEPlanCta.ct_plancta
                         where C.IdEmpresa == IdEmpresa && C.IdCtaCble == codPadre
                         select new { C.IdNivelCta };
                foreach (var item in tb)
                {
                    //obtengo el nivel del padre de dicha cta
                    i_nivelPadre = Convert.ToInt32(item.IdNivelCta); 
                }
                                         
                OEPlanCta.Dispose();
                OEPlanCta = new EntitiesDBConta();
                var tb1 = from D in OEPlanCta.ct_plancta_nivel
                          where D.IdEmpresa == IdEmpresa && D.IdNivelCta == i_nivelPadre
                          select new { D.nv_NumDigitos };
                foreach (var item in tb1)
                {
                    // obtengo los numeros de digitos del padre
                    numDigitosxPadre = Convert.ToInt32(item.nv_NumDigitos);
                }
                // al nivel del hijo le sumo uno
                i_nivelHijo = i_nivelPadre + 1;

                OEPlanCta.Dispose();
                OEPlanCta = new EntitiesDBConta();
                var tb2 = from E in OEPlanCta.ct_plancta_nivel
                          where E.IdEmpresa == IdEmpresa && E.IdNivelCta == i_nivelHijo
                          select new { E.nv_NumDigitos };
                foreach (var item in tb2)
                {
                    //Obtengo los numeros de digitos del hijo
                    numDigitosxHijo = Convert.ToInt32(item.nv_NumDigitos);
                }
                
                OEPlanCta.Dispose();
                OEPlanCta = new EntitiesDBConta();
                var tb3 = from F in OEPlanCta.ct_plancta
                          where F.IdEmpresa == IdEmpresa && F.IdCtaCblePadre==codPadre && F.IdNivelCta == i_nivelHijo
                          select new { id = F.IdCtaCble.Substring(F.IdCtaCblePadre.Trim().Length)};   
                List<int> lista = new List<int>();
                foreach (var item in tb3)
                {
                    lista.Add(Convert.ToInt32(item.id));
                }

                if (lista.Count > 0)
                {
                    //obtengo el max de los id
                    var temp = (from A in lista
                                select A).Max() + 1;
                    idHijo = temp.ToString();
                    idHijo = "000000000" + idHijo;
                }
                else
                {
                    //asigno el primer valor cuando no obtengo nada de la lista
                    idHijo = "000000001" ;
                }
                int value = idHijo.Length - numDigitosxHijo;
                string result = idHijo.Substring(value, numDigitosxHijo);

                return result;
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
        
        public Boolean ModificarDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta.FirstOrDefault(minfo => minfo.IdCtaCble == info.IdCtaCble && minfo.IdEmpresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.pc_Cuenta = info.pc_Cuenta;

                        if (info.IdCtaCblePadre == "")
                        {
                            contact.IdCtaCblePadre = null;
                        }


                        contact.IdCatalogo = info.IdCatalogo;
                        contact.pc_Naturaleza = info.pc_Naturaleza;
                        contact.IdNivelCta = Convert.ToByte(info.IdNivelCta);
                        contact.IdGrupoCble = info.IdGrupoCble;
                        contact.pc_Estado = info.pc_Estado;
                        contact.pc_EsMovimiento = info.pc_EsMovimiento;
                        contact.pc_es_flujo_efectivo = info.pc_es_flujo_efectivo;

                        contact.IdUsuarioUltMod = info.IdUsuario;
                        contact.Fecha_UltMod = DateTime.Now;
                        //contact.IdTipoCtaCble = info.IdTipoCtaCble;
                        contact.IdTipo_Gasto = info.IdTipo_Gasto;

                        contact.pc_clave_corta = info.pc_clave_corta;
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

        public Boolean ValidaIdCtaCble(int IdEmpresa, string IdCuenta, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_plancta
                            where per.IdEmpresa == IdEmpresa 
                            && per.IdCtaCble.Trim() == IdCuenta.Trim()
                            select per;
                    return (Q.ToList().Count > 0) ? true : false;
                }  

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

        public Boolean GrabarDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_plancta
                            where per.IdEmpresa == info.IdEmpresa 
                            && per.IdCtaCble == info.IdCtaCble
                            select per;
                    if (Q.ToList().Count == 0)
                    {

                        var address = new ct_plancta();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdCtaCble = info.IdCtaCble;
                        address.pc_Cuenta = info.pc_Cuenta;
                        address.IdCtaCblePadre = info.IdCtaCblePadre == "" ? null : info.IdCtaCblePadre;
                        address.IdCatalogo = info.IdCatalogo;
                        address.pc_Naturaleza = info.pc_Naturaleza;
                        address.IdNivelCta = Convert.ToByte(info.IdNivelCta);
                        address.IdGrupoCble = info.IdGrupoCble;
                        address.pc_Estado = info.pc_Estado;
                        address.pc_EsMovimiento = info.pc_EsMovimiento;
                        address.pc_es_flujo_efectivo = info.pc_es_flujo_efectivo;

                        decimal Idpc_clave_corta = 0;
                        if (info.pc_EsMovimiento == "S")
                        {
                            if (string.IsNullOrEmpty(info.pc_clave_corta))
                            {
                                Idpc_clave_corta = GetIdClave(info.IdEmpresa);
                                address.pc_clave_corta = Idpc_clave_corta.ToString();
                            }
                            else
                            {
                                address.pc_clave_corta = info.pc_clave_corta;
                            }
                        }else
                            address.pc_clave_corta = "0";

                        address.IdUsuario = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.Fecha_Transac = DateTime.Now;

                        address.IdUsuarioUltMod = info.IdUsuario;
                        address.Fecha_UltMod = DateTime.Now;

                        address.IdTipoCtaCble = info.IdTipoCtaCble;
                        address.IdTipo_Gasto = info.IdTipo_Gasto;

                        context.ct_plancta.Add(address);
                        context.SaveChanges();
                    }
                    else
                    {
                        ModificarDB(info, ref MensajeError);
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
                MensajeError = ex + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                       context.Database.ExecuteSqlCommand("delete ct_plancta where IdEmpresa = " + IdEmpresa );
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

        public Boolean AnularDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                Boolean res = false;

                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta.FirstOrDefault(minfo => minfo.IdCtaCble == info.IdCtaCble && minfo.IdEmpresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        var padre = (from C in context.ct_plancta
                                     where C.IdCtaCblePadre == info.IdCtaCble
                                     select C.IdCtaCble).Count();
                        if (padre == 0)
                        {
                            contact.pc_Estado = "I";
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = DateTime.Now;
                            contact.MotivoAnulacion = info.MotivoAnulacion;

                            context.SaveChanges();
                            res= true;
                        }
                        else
                        {
                            res= false;
                        }
                    }
                }
                return res;
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

        public Boolean VerificaNivel(int idnivel, int idempresa, ref string MensajeError)
        {
            
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = (from reg in tabla.ct_plancta_nivel
                         where reg.IdEmpresa==idempresa
                         select reg.IdNivelCta).Max();
                return (Convert.ToInt32(q.ToString()) == idnivel) ? true : false;
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

        public List<ct_Plancta_Info> Get_List_Plancta_x_Grupo(int IdEmpresa, string IdGrupoCble)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.ct_plancta
                              where q.IdEmpresa == IdEmpresa
                              select q;
                    
                    if (IdGrupoCble!="")
                    {
                        lst = lst.Where(q => q.IdGrupoCble == IdGrupoCble);
                    }
                    string ClaveCorta = "";
                    foreach (var item in lst)
                    {
                        ct_Plancta_Info info = new ct_Plancta_Info();
                        ClaveCorta = (item.pc_clave_corta == null || item.pc_clave_corta == "") ? "" : "{" + item.pc_clave_corta + "}";

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCtaCble = item.IdCtaCble.Trim();
                        info.pc_Cuenta = item.pc_Cuenta.Trim();
                        info.pc_Cuenta2 = ClaveCorta + "[" + item.IdCtaCble.Trim() + "] - " + item.pc_Cuenta.Trim();
                        info.IdCtaCblePadre = (item.IdCtaCblePadre == null) ? "" : item.IdCtaCblePadre.Trim();
                        info.IdCatalogo = Convert.ToDecimal(item.IdCatalogo);
                        info.pc_Naturaleza = item.pc_Naturaleza;
                        info.IdNivelCta = item.IdNivelCta;
                        info.IdGrupoCble = item.IdGrupoCble.Trim();
                        info.pc_Estado = item.pc_Estado;
                        info.pc_EsMovimiento = item.pc_EsMovimiento;
                        info.pc_clave_corta = item.pc_clave_corta;
                        info.IdTipoCtaCble = item.IdTipoCtaCble;
                        info.IdGrupoCble = item.IdGrupoCble;
                        info.IdTipo_Gasto = item.IdTipo_Gasto;
                        Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError="";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Plancta_Data()
        {
            
        }

        private decimal GetIdClave(int IdEmpresa)
        {
            decimal Id = 0;
            try
            {
                EntitiesDBConta contex = new EntitiesDBConta();
                var selecte = from q in contex.ct_plancta
                              where q.IdEmpresa == IdEmpresa
                              && q.pc_clave_corta != ""
                              && q.pc_clave_corta != null
                              select q;                   

                if (selecte.Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    List<decimal> lista_decimal = new List<decimal>();
                    foreach (var item in selecte)
                    {
                        lista_decimal.Add(Convert.ToDecimal(item.pc_clave_corta));
                    }

                    Id = lista_decimal.Max() + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Plancta_Info> GetListCuentasConSaldo(int IdEmpresa, DateTime FechaCorte)
        {
            try
            {
                List<ct_Plancta_Info> Lista = new List<ct_Plancta_Info>();
                FechaCorte = FechaCorte.Date;
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select a.IdEmpresa, a.IdCtaCble, a.pc_Cuenta, a.IdCtaCblePadre, a.pc_EsMovimiento, isnull(round(sum(b.dc_Valor),2),0) as dc_Valor, a.IdNivelCta"
                                +" from ct_plancta as a left join"
                                +" ct_cbtecble_det as b on a.IdEmpresa = b.IdEmpresa and a.IdCtaCble = b.IdCtaCble left join"
                                +" ct_cbtecble as c on b.IdEmpresa = c.IdEmpresa and b.IdTipoCbte = c.IdTipoCbte and b.IdCbteCble = c.IdCbteCble"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and isnull(c.cb_Fecha,DATEFROMPARTS(" + FechaCorte.Year.ToString() + "," + FechaCorte.Month.ToString() + "," + FechaCorte.Day.ToString() + ")) <= DATEFROMPARTS(" + FechaCorte.Year.ToString() + "," + FechaCorte.Month.ToString() + "," + FechaCorte.Day.ToString() + ")"
                                + " group by a.IdEmpresa, a.IdCtaCble, a.pc_Cuenta, a.IdCtaCblePadre, a.pc_EsMovimiento, a.IdNivelCta"
                                //+ " having (isnull(round(sum(b.dc_Valor),2),0) <> case when a.pc_EsMovimiento = 'S' then 0 else -999999999999999999 end)"
                                +" order by a.IdEmpresa, a.IdCtaCble";
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new ct_Plancta_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdCtaCble = Convert.ToString(reader["IdCtaCble"]),
                            pc_Cuenta = Convert.ToString(reader["pc_Cuenta"]),
                            IdCtaCblePadre = Convert.ToString(reader["IdCtaCblePadre"]),
                            pc_EsMovimiento = Convert.ToString(reader["pc_EsMovimiento"]),
                            Saldo = Convert.ToDouble(reader["dc_Valor"]),
                            IdNivelCta = Convert.ToInt32(reader["IdNivelCta"]),
                        });
                    }
                }
                Lista = SumarRecursivamente(Lista);
                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public double GetSaldoFechaCorte(int IdEmpresa, string IdCtaCble, DateTime FechaCorte, string IdCentroCosto, string IdCentroCosto_sub_centro_costo, bool ConsiderarCentroCosto)
        {
            double Saldo = 0;
            using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select ROUND(sum(a.dc_Valor),2) Saldo"
                                    + " from ct_cbtecble_det as a inner join"
                                    + " ct_cbtecble as b on a.idempresa = b.idempresa and a.IdTipoCbte = b.IdTipoCbte and a.IdCbteCble = b.IdCbteCble"
                                    + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdCtaCble = '" + IdCtaCble + "' and b.cb_Fecha <= DATEFROMPARTS(" + FechaCorte.Year.ToString() + "," + FechaCorte.Month.ToString() + "," + FechaCorte.Day.ToString() + ")";

                if (ConsiderarCentroCosto)
                {
                    if(!string.IsNullOrEmpty(IdCentroCosto_sub_centro_costo))
                        command.CommandText += " and a.IdCentroCosto = '"+IdCentroCosto+"' and a.IdCentroCosto_sub_centro_costo = '"+IdCentroCosto_sub_centro_costo+"'";
                    else
                        command.CommandText += " and a.IdCentroCosto is null and a.IdCentroCosto_sub_centro_costo is null";
                }

                var ValidateValue = command.ExecuteScalar();
                if (ValidateValue != null)
                    Saldo = Convert.ToDouble(ValidateValue);
            }
            return Saldo;
        }

        public List<ct_Plancta_Info> SumarRecursivamente(List<ct_Plancta_Info> Lista)
        {
            try
            {
                List<ct_Plancta_Info> ListaRecursiva = new List<ct_Plancta_Info>();

                if (Lista.Count == 0)
                    return Lista;

                int MaxNivel = Lista.Max(q => q.IdNivelCta);
                while (MaxNivel > 0)
                {
                    ListaRecursiva = Lista.Where(q => q.IdNivelCta == MaxNivel).GroupBy(q => new { q.IdNivelCta, q.IdCtaCblePadre }).Select(q => new ct_Plancta_Info
                    {
                        IdNivelCta = q.Key.IdNivelCta,
                        IdCtaCble = q.Key.IdCtaCblePadre,
                        Saldo = q.Sum(g => g.Saldo)
                    }).ToList();


                    ListaRecursiva = Lista.GroupJoin(
                        ListaRecursiva,
                        foo => foo.IdCtaCble,
                        bar => bar.IdCtaCble,
                        (x, y) => new { Foo = x, Bars = y })
                    .SelectMany(
                        x => x.Bars.DefaultIfEmpty(),
                        (x, y) => new ct_Plancta_Info{ 
                            IdEmpresa = x.Foo.IdEmpresa,
                            IdCtaCble = x.Foo.IdCtaCble,
                            pc_Cuenta = x.Foo.pc_Cuenta,
                            IdCtaCblePadre = x.Foo.IdCtaCblePadre,
                            pc_EsMovimiento = x.Foo.pc_EsMovimiento,
                            IdNivelCta = x.Foo.IdNivelCta,
                            Saldo = (y == null ? x.Foo.Saldo : y.Saldo)
                        }).ToList();
                    Lista = ListaRecursiva;
                    MaxNivel--;
                }

                return Lista.OrderBy(Q=> Q.IdCtaCble).ToList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
