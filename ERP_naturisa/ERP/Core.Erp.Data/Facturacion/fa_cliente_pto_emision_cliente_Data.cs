using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_cliente_pto_emision_cliente_Data
    {
        public List<fa_cliente_pto_emision_cliente_Info> Get_List(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<fa_cliente_pto_emision_cliente_Info> Lista = new List<fa_cliente_pto_emision_cliente_Info>();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.fa_cliente_pto_emision_cliente
                              where q.IdEmpresa == IdEmpresa &&
                              q.IdCliente == IdCliente
                              select q;

                    foreach (var item in lst)
                    {
                        fa_cliente_pto_emision_cliente_Info info = new fa_cliente_pto_emision_cliente_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.IdPuntoEmision = item.IdPuntoEmision;
                        info.cod_ptoemision = item.cod_ptoemision;
                        info.ruc = item.ruc;
                        info.direccion = item.direccion;
                        info.telefono = item.telefono;
                        info.mail1 = item.mail1;
                        info.mail2 = item.mail2;
                        info.Estado = item.Estado;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_cliente_pto_emision_cliente_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_cliente_pto_emision_cliente Entity = new fa_cliente_pto_emision_cliente();

                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdCliente = info.IdCliente;
                    Entity.IdPuntoEmision = info.IdPuntoEmision = Get_Id(Entity.IdEmpresa);
                    Entity.cod_ptoemision = info.cod_ptoemision;
                    Entity.ruc = info.ruc;
                    Entity.direccion = info.direccion;
                    Entity.telefono = info.telefono;
                    Entity.mail1 = info.mail1;
                    Entity.mail2 = info.mail2;
                    Entity.Estado = "A";

                    Context.fa_cliente_pto_emision_cliente.Add(Entity);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_cliente_pto_emision_cliente_Info info)
        {
            try
            {

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_cliente_pto_emision_cliente Entity = Context.fa_cliente_pto_emision_cliente.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdCliente == info.IdCliente && q.IdPuntoEmision == info.IdPuntoEmision);

                    Entity.cod_ptoemision = info.cod_ptoemision;
                    Entity.ruc = info.ruc;
                    Entity.direccion = info.direccion;
                    Entity.telefono = info.telefono;
                    Entity.mail1 = info.mail1;
                    Entity.mail2 = info.mail2;
                    Entity.Estado = "A";

                    Context.fa_cliente_pto_emision_cliente.Add(Entity);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(int idEmpresa, decimal idCliente)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    Context.Database.ExecuteSqlCommand("UPDATE [dbo].[fa_cliente_pto_emision_cliente] set Estado = 'I' where IdEmpresa = "+idEmpresa+" and IdCliente = "+idCliente);
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public int Get_Id(int IdEmpresa)
        {
            try
            {
                int Id = 1;
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.fa_cliente_pto_emision_cliente
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() != 0)
                        Id = lst.Max(q => q.IdPuntoEmision) + 1;
                    else
                        Id = 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
