using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_TipoNota_x_Empresa_x_Sucursal_Data
    {
        string mensaje = "";

        public List<fa_TipoNota_x_Empresa_x_Sucursal_Info> Get_List_TipoNota_x_Empresa_x_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<fa_TipoNota_x_Empresa_x_Sucursal_Info> Lista = new List<fa_TipoNota_x_Empresa_x_Sucursal_Info>();
                EntitiesFacturacion fact=new EntitiesFacturacion();
                var select = from q in fact.fa_TipoNota_x_Empresa_x_Sucursal where q.IdEmpresa==IdEmpresa && q.IdSucursal==IdSucursal select q;

                foreach (var item in select)
                {
                    fa_TipoNota_x_Empresa_x_Sucursal_Info info = new fa_TipoNota_x_Empresa_x_Sucursal_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoNota = item.IdTipoNota;
                    info.IdCtaCble = Convert.ToString(item.IdCtaCble);
                    Lista.Add(info);
                }
                return Lista;
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

        public Boolean GuardarDB(List<fa_TipoNota_x_Empresa_x_Sucursal_Info>  List ,ref string Mensaje)
        {
            try
            {
                if (List.Count() == 0)
                    return false;
                foreach (var item in List)
                {

                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {
                        var Address = new fa_TipoNota_x_Empresa_x_Sucursal();
                        Address.IdCtaCble = item.IdCtaCble;
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.IdTipoNota = item.IdTipoNota;

                        Context.fa_TipoNota_x_Empresa_x_Sucursal.Add(Address);
                        Context.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                Mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_TipoNota_x_Empresa_x_Sucursal_Info> Get_List_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(int IdEmpresa, int idTipoNota)
        {
            try
            {
                List<fa_TipoNota_x_Empresa_x_Sucursal_Info> Lista = new List<fa_TipoNota_x_Empresa_x_Sucursal_Info>();
                EntitiesFacturacion fact = new EntitiesFacturacion();
                var select = from q in fact.fa_TipoNota_x_Empresa_x_Sucursal where q.IdEmpresa == IdEmpresa && q.IdTipoNota == idTipoNota select q;

                foreach (var item in select)
                {
                    fa_TipoNota_x_Empresa_x_Sucursal_Info info = new fa_TipoNota_x_Empresa_x_Sucursal_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoNota = item.IdTipoNota;
                    info.IdCtaCble = Convert.ToString(item.IdCtaCble);
                    info.EstaEnBase = "S";
                    Lista.Add(info);
                }
                return Lista;
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

        public fa_TipoNota_x_Empresa_x_Sucursal_Info Get_Info_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(int IdEmpresa, int IdSucursal, int idTipoNota)
        {
            try
            {
                fa_TipoNota_x_Empresa_x_Sucursal_Info info = new fa_TipoNota_x_Empresa_x_Sucursal_Info();
                EntitiesFacturacion fact = new EntitiesFacturacion();
                var select = from q in fact.fa_TipoNota_x_Empresa_x_Sucursal 
                             where q.IdEmpresa == IdEmpresa 
                             && q.IdTipoNota == idTipoNota
                             && q.IdSucursal == IdSucursal
                             select q;

                foreach (var item in select)
                {
                   
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdTipoNota = item.IdTipoNota;
                    info.IdCtaCble = Convert.ToString(item.IdCtaCble);
                    info.EstaEnBase = "S";
                    
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


        public Boolean ModificarDB(List<fa_TipoNota_x_Empresa_x_Sucursal_Info> List, ref string Mensaje)
        {
            try
            {
                foreach (var item in List)
                {

                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {

                        var Address = Context.fa_TipoNota_x_Empresa_x_Sucursal.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == v.IdSucursal && v.IdTipoNota == item.IdTipoNota);
                        if (Address != null)
                        {
                            Address.IdCtaCble = item.IdCtaCble;

                            Context.SaveChanges();
                        }
                    }


                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                Mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref Mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
