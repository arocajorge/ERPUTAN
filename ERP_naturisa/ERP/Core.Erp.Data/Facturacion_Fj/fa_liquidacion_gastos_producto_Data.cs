using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_gastos_producto_Data
    {
        public List<fa_liquidacion_gastos_producto_Info> Get_List_Liqui_Gas_Producto(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<fa_liquidacion_gastos_producto_Info> Lista_Liquidacion = new List<fa_liquidacion_gastos_producto_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var select = from q in Context.fa_liquidacion_gastos_producto
                              where IdEmpresa == q.IdEmpresa
                              select q;

                    foreach (var item in select)
                    {
                        fa_liquidacion_gastos_producto_Info contact = new fa_liquidacion_gastos_producto_Info();

                        contact.IdEmpresa = item.IdEmpresa;
                        contact.IdProducto_Liqui = item.IdProducto_Liqui;
                        contact.nom_producto_Liqui = item.nom_producto_Liqui;
                        contact.estado = item.estado;
                        contact.IdProducto = item.IdProducto;

                        Lista_Liquidacion.Add(contact);
                    }
                }
                return Lista_Liquidacion;
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

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ();
                int select = (from q in Context.fa_liquidacion_gastos_producto
                              where q.IdEmpresa == IdEmpresa 
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Context.fa_liquidacion_gastos_producto
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdProducto_Liqui).Max();
                    Id = Convert.ToInt32(select_as.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public bool GuardarDB(fa_liquidacion_gastos_producto_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos_producto contact = new fa_liquidacion_gastos_producto();

                    contact.IdEmpresa = Info.IdEmpresa;
                    if (Info.IdProducto_Liqui == 0)
                        contact.IdProducto_Liqui = getId(Info.IdEmpresa);
                    else
                        contact.IdProducto_Liqui = Info.IdProducto_Liqui;
                    contact.nom_producto_Liqui = Info.nom_producto_Liqui;
                    contact.estado = Info.estado;
                    contact.IdProducto = Info.IdProducto;
                    Context.fa_liquidacion_gastos_producto.Add(contact);
                    Context.SaveChanges();
                }
                return true;
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

        public bool ModificiarDB(fa_liquidacion_gastos_producto_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos_producto contact = Context.fa_liquidacion_gastos_producto.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdProducto_Liqui == Info.IdProducto_Liqui);

                    if (contact != null)
                    {
                        contact.nom_producto_Liqui = Info.nom_producto_Liqui;
                        contact.IdProducto = Info.IdProducto;
                        contact.estado = Info.estado;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(fa_liquidacion_gastos_producto_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_gastos_producto contact = Context.fa_liquidacion_gastos_producto.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdProducto_Liqui == Info.IdProducto_Liqui);

                    if (contact != null)
                    {
                        contact.estado = "I";
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
