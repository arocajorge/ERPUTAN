using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Data.Inventario
{
   public class in_devolucion_inven_det_Data
    {

        string mensaje = "";

        public Boolean GuardarDB(in_devolucion_inven_det_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var Address = new in_devolucion_inven_det();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdDev_Inven = info.IdDev_Inven;
                    Address.cantidad_a_devolver = info.cantidad_a_devolver;
                    Address.cantidad_devuelta = info.cantidad_devuelta;
                    Address.cantidad_egresada = info.cantidad_egresada;
                    Address.IdBodega_movi_inv = info.IdBodega_movi_inv;
                    Address.IdDev_Inven = info.IdDev_Inven;
                    Address.IdEmpresa_movi_inv = info.IdEmpresa_movi_inv;
                    Address.IdMovi_inven_tipo_movi_inv = info.IdMovi_inven_tipo_movi_inv;
                    Address.IdNumMovi_movi_inv = info.IdNumMovi_movi_inv;
                    Address.IdSucursal_movi_inv = info.IdSucursal_movi_inv;
                    Address.secuencia = info.secuencia;
                    Address.Secuencia_movi_inv = info.Secuencia_movi_inv;


                    Context.in_devolucion_inven_det.Add(Address);
                    Context.SaveChanges();

                    mensaje = "Grabación ok..";
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<in_devolucion_inven_det_Info> Listinfo, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {

                    foreach (var info in Listinfo)
                    {
                        var Address = new in_devolucion_inven_det();

                        Address.IdEmpresa = info.IdEmpresa;
                        Address.IdDev_Inven = info.IdDev_Inven;
                        Address.IdBodega_movi_inv = info.IdBodega_movi_inv;
                        Address.IdDev_Inven = info.IdDev_Inven;
                        Address.IdEmpresa_movi_inv = info.IdEmpresa_movi_inv;
                        Address.IdMovi_inven_tipo_movi_inv = info.IdMovi_inven_tipo_movi_inv;
                        Address.IdNumMovi_movi_inv = info.IdNumMovi_movi_inv;
                        Address.IdSucursal_movi_inv = info.IdSucursal_movi_inv;
                        Address.secuencia = info.secuencia;
                        Address.Secuencia_movi_inv = info.Secuencia_movi_inv;
                        Address.cantidad_a_devolver = info.cantidad_a_devolver;
                        Address.cantidad_devuelta = info.cantidad_devuelta;
                        Address.cantidad_egresada = info.cantidad_egresada;
                        

                        Context.in_devolucion_inven_det.Add(Address);
                        Context.SaveChanges();    
                    }

                    

                    mensaje = "Grabación ok..";
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdDev_Inven, ref string msgs)
        {
            try
            {

                using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete in_devolucion_inven_det where IdEmpresa = " + IdEmpresa
                        + " and IdDev_Inven = " + IdDev_Inven);

                }
                return true;
               
                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

                msgs = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_devolucion_inven_det_Info> Get_List_in_devolucion_inven_det(int IdEmpresa, decimal IdDev_Inven)
        {
            List<in_devolucion_inven_det_Info> Lst = new List<in_devolucion_inven_det_Info>();
            try
            {
                
                EntitiesInventario oEnti = new EntitiesInventario();



                var Query = from q in oEnti.vwin_devolucion_inven_det
                            where q.IdEmpresa == IdEmpresa
                            && q.IdDev_Inven == IdDev_Inven
                            select q;

                foreach (var item in Query)
                {
                    in_devolucion_inven_det_Info Obj = new in_devolucion_inven_det_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.cantidad_a_devolver = item.cantidad_a_devolver;
                    Obj.cantidad_devuelta = item.cantidad_devuelta;
                    Obj.cantidad_egresada = item.cantidad_egresada;
                    Obj.IdBodega_movi_inv = item.IdBodega_movi_inv;
                    Obj.IdDev_Inven = item.IdDev_Inven;
                    Obj.IdEmpresa_movi_inv = item.IdEmpresa_movi_inv;
                    Obj.IdMovi_inven_tipo_movi_inv = item.IdMovi_inven_tipo_movi_inv;
                    Obj.IdNumMovi_movi_inv = item.IdNumMovi_movi_inv;
                    Obj.IdSucursal_movi_inv = item.IdSucursal_movi_inv;
                    Obj.secuencia = item.secuencia;
                    Obj.Secuencia_movi_inv = item.Secuencia_movi_inv;
                    Obj.nom_punto_cargo = item.nom_punto_cargo;
                    Obj.Checked = true;
                    Obj.nom_producto = item.nom_producto;
                    Obj.cod_producto = item.cod_producto;
                    Obj.cantidad_egresada = item.cantidad_inven;
                    Lst.Add(Obj);

                }

                return Lst;
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

        public in_devolucion_inven_det_Info Get_Info_in_devolucion_inven(int IdEmpresa, decimal IdDev_Inven)
        {
            try
            {
                in_devolucion_inven_det_Info Obj = new in_devolucion_inven_det_Info();
                EntitiesInventario oEnti = new EntitiesInventario();

                var Query = from q in oEnti.vwin_devolucion_inven_det
                            where q.IdEmpresa == IdEmpresa
                            && q.IdDev_Inven == IdDev_Inven
                            select q;
                foreach (var item in Query)
                {


                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.cantidad_a_devolver = item.cantidad_a_devolver;
                    Obj.cantidad_devuelta = item.cantidad_devuelta;
                    Obj.cantidad_egresada = item.cantidad_egresada;
                    Obj.IdBodega_movi_inv = item.IdBodega_movi_inv;
                    Obj.IdDev_Inven = item.IdDev_Inven;
                    Obj.IdEmpresa_movi_inv = item.IdEmpresa_movi_inv;
                    Obj.IdMovi_inven_tipo_movi_inv = item.IdMovi_inven_tipo_movi_inv;
                    Obj.IdNumMovi_movi_inv = item.IdNumMovi_movi_inv;
                    Obj.IdSucursal_movi_inv = item.IdSucursal_movi_inv;
                    Obj.secuencia = item.secuencia;
                    Obj.Secuencia_movi_inv = item.Secuencia_movi_inv;

                    Obj.Checked = true;
                    Obj.nom_producto = item.nom_producto;
                    Obj.cod_producto = item.cod_producto;
                    Obj.cantidad_egresada = item.cantidad_inven;

                }

                return Obj;
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

        public double Get_cantidad_devuelta(int IdEmpresa_movi_inv, int IdSucursal_movi_inv, int IdBodega_movi_inv, int IdMovi_inven_tipo_movi_inv, decimal IdNumMovi_movi_inv
           , int Secuencia_movi_inv)
        {
            try
            {
                double cantidad_devuelta = 0;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_devolucion_inven_det_cantidad_devuelta
                              where IdEmpresa_movi_inv == q.IdEmpresa_movi_inv
                              && IdSucursal_movi_inv == q.IdSucursal_movi_inv
                              && IdBodega_movi_inv == q.IdBodega_movi_inv
                              && IdMovi_inven_tipo_movi_inv == q.IdMovi_inven_tipo_movi_inv
                              && IdNumMovi_movi_inv == q.IdNumMovi_movi_inv
                              && Secuencia_movi_inv == q.Secuencia_movi_inv
                              select q;

                    if (lst.Count() == 0)
                        cantidad_devuelta = 0;
                    else
                        foreach (var item in lst)
                        {
                            cantidad_devuelta = item.cantidad_devuelta == null ? 0 : (double)item.cantidad_devuelta;
                        }
                }

                return cantidad_devuelta;
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

    }
}
