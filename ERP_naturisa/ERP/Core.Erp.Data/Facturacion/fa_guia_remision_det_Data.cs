using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_guia_remision_det_Data
    {
        string mensaje = "";
        
        public Boolean GuardarDB(List<fa_guia_remision_det_Info> listDetalle_Guia_Info)
        {
            try
            {
                int c =1;
                listDetalle_Guia_Info.ForEach(var => {var.Secuencia = c; c++; });

                foreach (var item in listDetalle_Guia_Info)
                {
                        
                        using (EntitiesFacturacion Context = new EntitiesFacturacion())
                        {
                            var Address = new fa_guia_remision_det();

                            Address.IdEmpresa = item.IdEmpresa;
                            Address.IdSucursal = item.IdSucursal;
                            Address.IdBodega = item.IdBodega;
                            Address.IdGuiaRemision = item.IdGuiaRemision;
                            Address.Secuencia = item.Secuencia;
                            Address.IdProducto = item.IdProducto;
                            Address.gi_peso = (item.gi_peso == null) ? 0 : item.gi_peso;
                            Address.gi_cantidad = item.gi_cantidad;
                            Address.gi_Precio = item.gi_Precio;
                            Address.gi_PorDescUnitario = item.gi_PorDescUnitario;
                            Address.gi_DescUnitario = item.gi_DescUnitario;
                            Address.gi_PrecioFinal = item.gi_Precio - item.gi_DescUnitario;
                            Address.gi_Subtotal = item.Subtotal;
                            Address.gi_iva = item.gi_iva;
                            Address.gi_total = item.gi_total;
                            Address.gi_costo = item.gi_costo;
                            Address.gi_tieneIVA = item.gi_tieneIVA;
                            Address.gi_detallexItems = (item.gi_detallexItems == null) ? "" : item.gi_detallexItems;

                            Context.fa_guia_remision_det.Add(Address);
                            Context.SaveChanges();
                            Context.Dispose();
                        }
                }
                return true;
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

        public Boolean ModificarDB(List<fa_guia_remision_det_Info> listDetalle_Guia_Info) 
        {
            try
            {
                foreach (var item in listDetalle_Guia_Info)
                {

                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {
                        if (item.Secuencia != 0)
                        {
                            var Contact = Context.fa_guia_remision_det.FirstOrDefault(var => var.IdEmpresa == item.IdEmpresa && var.IdSucursal == item.IdSucursal && var.IdBodega == item.IdBodega && var.IdGuiaRemision == item.IdGuiaRemision && var.IdProducto == item.IdProducto && var.Secuencia == item.Secuencia);
                            if (Contact != null)
                            {
                                Contact.gi_Precio = item.gi_Precio;
                                Contact.gi_cantidad = item.gi_cantidad;
                                Contact.gi_iva = item.gi_iva;
                                Contact.gi_DescUnitario = item.gi_DescUnitario;
                                Contact.gi_Subtotal = item.Subtotal;
                                Contact.gi_total = item.gi_total;
                                Contact.gi_tieneIVA = item.gi_tieneIVA;
                                Contact.gi_detallexItems = item.gi_detallexItems;


                                Context.SaveChanges();
                                Context.Dispose();
                            }
                        }
                        else
                        {

                            item.Secuencia = listDetalle_Guia_Info.Where(var => var.IdEmpresa == item.IdEmpresa && var.IdGuiaRemision == item.IdGuiaRemision && var.IdBodega == item.IdBodega && var.IdSucursal == item.IdSucursal).Count();
                            var Address = new fa_guia_remision_det();
                            Address.IdEmpresa = item.IdEmpresa;
                            Address.IdSucursal = item.IdSucursal;
                            Address.IdBodega = item.IdBodega;
                            Address.IdGuiaRemision = item.IdGuiaRemision;
                            Address.Secuencia = item.Secuencia;
                            Address.IdProducto = item.IdProducto;
                            Address.gi_peso = (item.gi_peso == null) ? 0 : item.gi_peso;
                            Address.gi_cantidad = item.gi_cantidad;
                            Address.gi_Precio = item.gi_Precio;
                            Address.gi_PorDescUnitario = item.gi_PorDescUnitario;
                            Address.gi_DescUnitario = item.gi_DescUnitario;
                            Address.gi_PrecioFinal = item.gi_Precio - item.gi_DescUnitario;
                            Address.gi_Subtotal = item.Subtotal;
                            Address.gi_iva = item.gi_iva;
                            Address.gi_total = item.gi_total;
                            Address.gi_costo = item.gi_costo;
                            Address.gi_tieneIVA = item.gi_tieneIVA;
                            Address.gi_detallexItems = (item.gi_detallexItems == null) ? "" : item.gi_detallexItems;

                            Context.fa_guia_remision_det.Add(Address);
                            Context.SaveChanges();
                            Context.Dispose();
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }        
        }

        public List<fa_guia_remision_det_Info> Get_List_guia_remision_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdGuiaRemision) 
        {
            try
            {
                List<fa_guia_remision_det_Info> lst = new List<fa_guia_remision_det_Info>();
                EntitiesFacturacion oentities = new EntitiesFacturacion();
                var consulta = from q in oentities.fa_guia_remision_det
                                where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal 
                                && q.IdBodega == IdBodega 
                                && q.IdGuiaRemision == IdGuiaRemision
                               select q;

                foreach (var item in consulta)
                {
                    fa_guia_remision_det_Info temp = new fa_guia_remision_det_Info();
                    temp.Secuencia = item.Secuencia;
                    temp.IdProducto = item.IdProducto;
                    temp.gi_cantidad = item.gi_cantidad;
                    temp.gi_costo = item.gi_costo;
                    temp.gi_DescUnitario = item.gi_DescUnitario;
                    temp.gi_detallexItems = item.gi_detallexItems;
                    temp.gi_iva = item.gi_iva;
                    temp.gi_PorDescUnitario = item.gi_PorDescUnitario;
                    temp.gi_Precio = item.gi_Precio;
                    temp.gi_PrecioFinal = item.gi_PrecioFinal;
                    if (item.gi_tieneIVA == "S")
                        temp.TieneIva = true;
                    else
                        temp.TieneIva = false;
                    temp.gi_total = item.gi_total;
                    temp.Subtotal = item.gi_Subtotal;
                    temp.gi_peso = item.gi_peso;

                    lst.Add(temp);
                }
                return lst;
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

        public List<fa_guia_remision_det_Info> Get_List_guia_remision_det(int IdEmpresa, int IdSucursal, int IdGuia)
        {
            try
            {
                List<fa_guia_remision_det_Info> lst = new List<fa_guia_remision_det_Info>();
                EntitiesFacturacion oentities = new EntitiesFacturacion();
                var consulta = from q in oentities.vwfa_guia_remision_det
                               where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                               && q.IdGuiaRemision == IdGuia
                               select q;

                foreach (var item in consulta)
                {
                    fa_guia_remision_det_Info temp = new fa_guia_remision_det_Info();
                    temp.Secuencia = item.Secuencia;
                    temp.IdProducto = item.IdProducto;
                    temp.gi_cantidad = item.gi_cantidad;
                    temp.gi_costo = item.gi_costo;
                    temp.gi_DescUnitario = item.gi_DescUnitario;
                    temp.gi_detallexItems = item.gi_detallexItems;
                    temp.gi_iva = item.gi_iva;
                    temp.gi_PorDescUnitario = item.gi_PorDescUnitario;
                    temp.gi_Precio = item.gi_Precio;
                    temp.gi_PrecioFinal = item.gi_PrecioFinal;
                    if (item.gi_tieneIVA == "S")
                        temp.TieneIva = true;
                    else
                        temp.TieneIva = false;
                    temp.gi_total = item.gi_total;
                    temp.Subtotal = item.gi_Subtotal;
                    temp.gi_peso = item.gi_peso;
                    temp.pr_codigo = item.pr_codigo;
                    temp.pr_descripcion = item.pr_descripcion;
                    lst.Add(temp);
                }
                return lst;
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
   
    }
}
