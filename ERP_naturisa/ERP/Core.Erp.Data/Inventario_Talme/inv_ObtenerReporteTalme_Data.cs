using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario_Talme
{
    public class inv_ObtenerReporteTalme_Data
    {
        string mensaje = "";
        public List<tbINV_TAL_Rpt001_Info> OptenerData_spINV_TAL_Rpt001(int IdEmpresa, int IdSucursal,
            int IdBodega,
            string IdCategorias, int IdMovimiento, DateTime fechaIni, DateTime fechaFin,string IdUsuario, string nom_pc)
        {
            List<tbINV_TAL_Rpt001_Info> ListData = new List<tbINV_TAL_Rpt001_Info>();

            try
            {

                using (EntitiesInventario_Talme base_ = new EntitiesInventario_Talme())
                {
                    ///base_.spINV_TAL_Rpt001(IdEmpresa, IdSucursal, IdBodega, IdCategorias, IdMovimiento, fechaIni, fechaFin, IdUsuario, nom_pc);


                    string query = "Select * from tbINV_TAL_Rpt001 where IdUsuario = '" + IdUsuario + "' and nom_pc = '" + nom_pc + "'";
                    ListData = base_.Database.SqlQuery<tbINV_TAL_Rpt001_Info>(query).ToList();
                }
                return ListData;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public List<tbINV_TAL_Rpt002_Info> OptenerData_spINV_TAL_Rpt002(int IdEmpresa, int IdSucursalini, 
            int IdSucursalfin, int IdBodegaini, int IdBodegafin,
            string IdCategorias, DateTime fechaCorte,  string IdUsuario, string nom_pc)
        {
            List<tbINV_TAL_Rpt002_Info> ListData = new List<tbINV_TAL_Rpt002_Info>();

            try
            {
               
                //using (EntitiesInventario base_ = new EntitiesInventario())
                //{
                //    base_.spINV_TAL_Rpt002(IdEmpresa, IdSucursalini, IdSucursalfin, IdBodegaini, IdBodegafin, IdCategorias, fechaCorte, IdUsuario, nom_pc);


                //    string query = "Select * from tbINV_TAL_Rpt002 where IdUsuario = '" +IdUsuario+ "' and nom_pc = '"+nom_pc+"'";
                //    ListData = base_.Database.SqlQuery<tbINV_TAL_Rpt002_Info>(query).ToList();
                //}
                return ListData;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public List<tbINV_TAL_Rpt003_Info> OptenerData_spINV_TAL_Rpt006( List<tb_Empresa_Info> empresas,List<tb_Sucursal_Info> sucursales,
            List<in_categorias_Info>categorias, DateTime fechaCorte, string IdUsuario, string nom_pc)
        {
            List<tbINV_TAL_Rpt003_Info> ListData = new List<tbINV_TAL_Rpt003_Info>();

            try
            {


                using (EntitiesInventario_Talme base_ = new EntitiesInventario_Talme())
                {
                    string queryz = " Delete from tbINV_TAL_Rpt003_Filtro_Empresa where Usuario = '" + IdUsuario + "' and PC = '" + nom_pc + "'";
                    string query2 = " Delete from tbINV_TAL_Rpt003_Filtro_Sucursal where Usuario = '" + IdUsuario + "' and PC = '" + nom_pc + "'";
                    string query3 = " Delete from tbINV_TAL_Rpt003_Filtro_Cate where Usuario = '" + IdUsuario + "' and PC = '" + nom_pc + "'";
                    string query = queryz + query2 + query3;
                    base_.Database.ExecuteSqlCommand(queryz);
                    base_.Database.ExecuteSqlCommand(query2);
                    base_.Database.ExecuteSqlCommand(query3);

                    foreach (var item in empresas)
                    {
                        tbINV_TAL_Rpt003_Filtro_Empresa empr = new tbINV_TAL_Rpt003_Filtro_Empresa();
                        empr.IdEmpresa = item.IdEmpresa;
                        empr.Nombre = item.em_nombre;
                        empr.Usuario = IdUsuario;
                        empr.PC = nom_pc;
                        base_.tbINV_TAL_Rpt003_Filtro_Empresa.Add(empr);
                    }

                    base_.SaveChanges();
               
                    foreach (var item in sucursales )
                    {
                        tbINV_TAL_Rpt003_Filtro_Sucursal  suc = new tbINV_TAL_Rpt003_Filtro_Sucursal();
                        suc.IdSucursal= item.IdSucursal;
                        suc.Nombre = item.Su_Descripcion ;
                        suc.Usuario = IdUsuario;
                        suc.PC = nom_pc;
                        base_.tbINV_TAL_Rpt003_Filtro_Sucursal.Add(suc);
                    }
                    base_.SaveChanges();
                    foreach (var item in categorias)
                    {
                        tbINV_TAL_Rpt003_Filtro_Cate  cat = new tbINV_TAL_Rpt003_Filtro_Cate ();
                        cat.IdCategoria = item.IdCategoria ;
                        cat.Nombre = item.ca_Categoria ;
                        cat.Usuario = IdUsuario;
                        cat.PC = nom_pc;
                        base_.tbINV_TAL_Rpt003_Filtro_Cate.Add(cat);
                    }

                    base_.SaveChanges();

                    //base_.spINV_TAL_Rpt006(fechaCorte, IdUsuario, nom_pc);
                    string querya = "Select * from tbINV_TAL_Rpt003 where IdUsuario_SP = '" + IdUsuario + "' and nom_pc = '" + nom_pc + "'";
                    ListData = base_.Database.SqlQuery<tbINV_TAL_Rpt003_Info>(querya).ToList();
                }
                return ListData;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
