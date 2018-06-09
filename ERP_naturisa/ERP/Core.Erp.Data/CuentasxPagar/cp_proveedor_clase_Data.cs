using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_proveedor_clase_Data
    {
        string mensaje = "";
        public List<cp_proveedor_clase_Info> Get_List_proveedor_clase(int IdEmpresa)
        {
            try
            {
                List<cp_proveedor_clase_Info> Lst = new List<cp_proveedor_clase_Info>();

                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var consultar = from q in CxP.cp_proveedor_clase
                                    where q.IdEmpresa == IdEmpresa
                                    select q;

                    foreach (var item in consultar)
                    {
                        cp_proveedor_clase_Info info = new cp_proveedor_clase_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdClaseProveedor = item.IdClaseProveedor;
                        info.cod_clase_proveedor =(item.cod_clase_proveedor==null)?"": item.cod_clase_proveedor.Trim();
                        info.descripcion_clas_prove =(item.descripcion_clas_prove==null)?"": item.descripcion_clas_prove.Trim();
                        info.IdCtaCble_CXP = (item.IdCtaCble_CXP == null) ? null : item.IdCtaCble_CXP.Trim();
                        info.IdCtaCble_Anticipo =(item.IdCtaCble_Anticipo==null)?null: item.IdCtaCble_Anticipo.Trim();
                        info.IdCtaCble_gasto =(item.IdCtaCble_gasto==null)?null: item.IdCtaCble_gasto.Trim();
                        info.IdCentroCosto =(item.IdCentroCosto==null)?null: item.IdCentroCosto.Trim();
                        info.IdCentroCosto_sub_centro_costo =(item.IdCentroCosto_sub_centro_costo==null)?null: item.IdCentroCosto_sub_centro_costo.Trim();
                        info.descripcion_clas_prove2 = "[" + (item.cod_clase_proveedor == null ? item.IdClaseProveedor.ToString() : item.cod_clase_proveedor.Trim()) + "] " + item.descripcion_clas_prove;
                        info.Estado = item.Estado;

                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public cp_proveedor_clase_Info Get_Info_proveedor_clase(int IdEmpresa, int IdClaseProveedor)
        {
            try
            {
                cp_proveedor_clase_Info info = new cp_proveedor_clase_Info();

                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var consultar = from q in CxP.cp_proveedor_clase
                                    where q.IdEmpresa == IdEmpresa
                                    && q.IdClaseProveedor == IdClaseProveedor
                                    select q;

                    foreach (var item in consultar)
                    {
                        //cp_proveedor_clase_Info info = new cp_proveedor_clase_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdClaseProveedor = item.IdClaseProveedor;
                        info.cod_clase_proveedor = item.cod_clase_proveedor;
                        info.descripcion_clas_prove = item.descripcion_clas_prove;
                        info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        info.IdCtaCble_gasto = item.IdCtaCble_gasto;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.Estado = item.Estado;

                        info.IdCtaCble_CXP = item.IdCtaCble_CXP;
                       // Lst.Add(info);
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GuardarDB(cp_proveedor_clase_Info info,ref int id ,ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var Address = new cp_proveedor_clase();
                    

                    Address.IdEmpresa=info.IdEmpresa;
                    Address.IdClaseProveedor = info.IdClaseProveedor = GetIdProveedor_clase(info.IdEmpresa);

                    id = Address.IdClaseProveedor;

                    Address.cod_clase_proveedor = info.cod_clase_proveedor == "" ? Convert.ToString(id) : info.cod_clase_proveedor;
                    Address.descripcion_clas_prove=info.descripcion_clas_prove;
                    Address.IdCtaCble_Anticipo=info.IdCtaCble_Anticipo;
                    Address.IdCtaCble_gasto=info.IdCtaCble_gasto;
                    Address.IdCentroCosto=info.IdCentroCosto;
                    Address.IdCentroCosto_sub_centro_costo=info.IdCentroCosto_sub_centro_costo;
                    Address.Estado=info.Estado;
                    Address.IdUsuario=info.IdUsuario;
                    Address.IdUsuarioUltModi = info.IdUsuario;
                    Address.FechaTransac=info.FechaTransac;
                    Address.FechaUltModi = info.FechaTransac;

                    Address.IdCtaCble_CXP = info.IdCtaCble_CXP;

                    Context.cp_proveedor_clase.Add(Address);
                    Context.SaveChanges();
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
       
        public int  GetIdProveedor_clase(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesCuentasxPagar contex = new EntitiesCuentasxPagar();
                var selecte = contex.cp_proveedor_clase.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.cp_proveedor_clase
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdClaseProveedor).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(cp_proveedor_clase_Info info,ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_proveedor_clase.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdClaseProveedor == info.IdClaseProveedor);
                    if (contact != null)
                    {
                        contact.cod_clase_proveedor = info.cod_clase_proveedor;
                        contact.descripcion_clas_prove = info.descripcion_clas_prove;
                        contact.IdCtaCble_Anticipo = info.IdCtaCble_Anticipo;
                        contact.IdCtaCble_gasto = info.IdCtaCble_gasto;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        contact.Estado = info.Estado;
                        contact.MotivoAnu = info.MotivoAnu;
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.FechaUltModi = info.FechaUltModi;
                        contact.IdCtaCble_CXP = info.IdCtaCble_CXP;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(cp_proveedor_clase_Info info,ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_proveedor_clase.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdClaseProveedor == info.IdClaseProveedor);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioAnu = info.IdUsuarioAnu;
                        contact.FechaAnu = info.FechaAnu;
                        contact.MotivoAnu = info.MotivoAnu;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_proveedor_clase_Data()
       {

       }
    }
}
