﻿using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt030_Data
    {
        public List<XINV_Rpt030_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdTransferencia)
        {
            try
            {
                List<XINV_Rpt030_Info> Lista = new List<XINV_Rpt030_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    var lst = Context.vwINV_Rpt030.Where(q=> q.IdEmpresa == IdEmpresa && q.IdSucursalOrigen == IdSucursal && q.IdBodegaOrigen == IdBodega && q.IdTransferencia == IdTransferencia).ToList();

                    foreach (var item in lst)
                    {
                        XINV_Rpt030_Info itemInfo = new XINV_Rpt030_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursalOrigen = item.IdSucursalOrigen;
                        itemInfo.IdBodegaOrigen = item.IdBodegaOrigen;
                        itemInfo.IdProducto = Convert.ToDecimal(item.IdProducto);
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.IdTransferencia = item.IdTransferencia;
                        itemInfo.dt_secuencia = item.dt_secuencia;
                        itemInfo.dt_cantidad = item.dt_cantidad;
                        itemInfo.IdEstablecimiento = item.IdEstablecimiento;
                        itemInfo.IdPuntoEmision = item.IdPuntoEmision;
                        itemInfo.NumDocumento_Guia = item.NumDocumento_Guia;
                        itemInfo.NumeroAutorizacion = item.NumeroAutorizacion;
                        itemInfo.FechaAutorizacion = item.FechaAutorizacion;
                        itemInfo.IdentificacionTransportista = item.IdentificacionTransportista;
                        itemInfo.NombreTransportista = item.NombreTransportista;
                        itemInfo.MotivoGuia = item.MotivoGuia;
                        itemInfo.Direc_sucu_Llegada = item.Direc_sucu_Llegada;
                        itemInfo.Direc_sucu_Partida = item.Direc_sucu_Partida;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.Nombre = item.Nombre;
                        itemInfo.NombreDestinatario = item.NombreDestinatario;
                        itemInfo.IdentificacionDestinatario = item.IdentificacionDestinatario;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.Su_Direccion = item.Su_Direccion;
                        itemInfo.NombreEmpresa = item.NombreEmpresa;
                        itemInfo.NumeroContribuyente = item.NumeroContribuyente;
                        itemInfo.em_ruc = item.em_ruc;
                        Lista.Add(itemInfo);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
