using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_parametros_CusCidersus_Data
    {
        string mensaje = "";
        public List<prd_parametros_CusCidersus_Info> ConsultaGeneral()
	{
		try
		{
			List<prd_parametros_CusCidersus_Info> Lst = new List<prd_parametros_CusCidersus_Info>() ;
            EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
			var Query = from q in oEnti.prd_parametros_CusCidersus
				select q;
			 foreach (var item in Query)
			{
				prd_parametros_CusCidersus_Info Obj = new prd_parametros_CusCidersus_Info() ;
                Obj.IdEmpresa = item.IdEmpresa;
                Obj.IdSucursal_Princ = item.IdSucursal_Princ;
                Obj.IdBodega_Princ = item.IdBodega_Princ;
                Obj.IdSucursal_Produccion = item.IdSucursal_Produccion;
                Obj.IdBodega_Produccion = item.IdBodega_Produccion;
                Obj.IdMovi_inven_tipo_ing_suc_princ = Convert.ToInt32(item.IdMovi_inven_tipo_ing_suc_princ);
                Obj.IdMovi_inven_tipo_egr_suc_princ = Convert.ToInt32(item.IdMovi_inven_tipo_egr_suc_princ);
                Obj.IdMovi_inven_tipo_egr_consumoprod = Convert.ToInt32(item.IdMovi_inven_tipo_egr_consumoprod);
                Obj.IdMovi_inven_tipo_ing_consumoprod = Convert.ToInt32(item.IdMovi_inven_tipo_ing_consumoprod);
                Obj.IdMovi_inven_tipo_ing_ContrlProduccion = Convert.ToInt32(item.IdMovi_inven_tipo_ing_ContrlProduccion);               
                Obj.IdMovi_inven_tipo_egr_ContrlProduccion = Convert.ToInt32(item.IdMovi_inven_tipo_egr_ContrlProduccion);
                Obj.IdMovi_inven_tipo_egr_Conversion = Convert.ToInt32(item.IdMovi_inven_tipo_egr_Conversion);
                Obj.IdMovi_inven_tipo_ing_Conversion =Convert.ToInt32( item.IdMovi_inven_tipo_ing_Conversion);
                Obj.IdMovi_inven_tipo_egr_Ensamblado = Convert.ToInt32(item.IdMovi_inven_tipo_egr_Ensamblado);
                Obj.IdMovi_inven_tipo_ing_Ensamblado = Convert.ToInt32(item.IdMovi_inven_tipo_ing_Ensamblado);
                Obj.IdMovi_inven_tipo_ingxresid_Conversion =Convert.ToInt32( item.IdMovi_inven_tipo_ingxresid_Conversion);
                Obj.IdMovi_invent_tipo_egr_Despacho =Convert.ToInt32(item.IdMovi_invent_tipo_egr_Despacho);
                Obj.IdEstadoAprobacion_x_default = item.IdEstadoAprobacion_x_default;
                Obj.IdProductoTipo_ProdTerm = Convert.ToInt32(item.IdProductoTipo_ProdTerm);
                Obj.IdCategoria_ProdTerm = item.IdCategoria_ProdTerm;
                Obj.IdProveedor_ProdTerm = Convert.ToInt32(item.IdProveedor_ProdTerm);
                Obj.IdMarca_ProdTerm =Convert.ToInt32( item.IdMarca_ProdTerm);
                Obj.idTipo_Produto_Elemento = Convert.ToInt32(item.idTipo_Produto_Elemento);
                Obj.IdProductoTipo_MateriaPrima = Convert.ToInt32(item.IdProductoTipo_MateriaPrima);
                Obj.IdMoviInicio = item.IdMoviInicio;

				Lst.Add(Obj);
		}
			return Lst;
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


	public prd_parametros_CusCidersus_Info ObtenerObjeto(int IdEmpresa)
	{
        EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
		try
		{
			prd_parametros_CusCidersus_Info Info = new prd_parametros_CusCidersus_Info() ;
		    var Objeto = oEnti.prd_parametros_CusCidersus.FirstOrDefault(var => var.IdEmpresa == IdEmpresa);
            if (Objeto != null)
            {
                Info.IdEmpresa = Objeto.IdEmpresa;
                Info.IdSucursal_Princ = Objeto.IdSucursal_Princ;
                Info.IdBodega_Princ = Objeto.IdBodega_Princ;
                Info.IdSucursal_Produccion = Objeto.IdSucursal_Produccion;
                Info.IdBodega_Produccion = Objeto.IdBodega_Produccion;
                Info.IdMovi_inven_tipo_ing_suc_princ = Convert.ToInt32(Objeto.IdMovi_inven_tipo_ing_suc_princ);
                Info.IdMovi_inven_tipo_egr_suc_princ = Convert.ToInt32(Objeto.IdMovi_inven_tipo_egr_suc_princ);
                Info.IdMovi_inven_tipo_egr_consumoprod = Convert.ToInt32(Objeto.IdMovi_inven_tipo_egr_consumoprod);
                Info.IdMovi_inven_tipo_ing_consumoprod = Convert.ToInt32(Objeto.IdMovi_inven_tipo_ing_consumoprod);
                Info.IdMovi_inven_tipo_ing_ContrlProduccion = Convert.ToInt32(Objeto.IdMovi_inven_tipo_ing_ContrlProduccion);
                Info.IdMovi_inven_tipo_egr_ContrlProduccion = Convert.ToInt32(Objeto.IdMovi_inven_tipo_egr_ContrlProduccion);
                Info.IdMovi_inven_tipo_egr_Conversion = Convert.ToInt32(Objeto.IdMovi_inven_tipo_egr_Conversion);
                Info.IdMovi_inven_tipo_ing_Conversion = Convert.ToInt32(Objeto.IdMovi_inven_tipo_ing_Conversion);
                Info.IdMovi_inven_tipo_egr_Ensamblado = Convert.ToInt32(Objeto.IdMovi_inven_tipo_egr_Ensamblado);
                Info.IdMovi_inven_tipo_ing_Ensamblado = Convert.ToInt32(Objeto.IdMovi_inven_tipo_ing_Ensamblado);
                Info.IdMovi_inven_tipo_ingxresid_Conversion = Convert.ToInt32(Objeto.IdMovi_inven_tipo_ingxresid_Conversion);
                Info.IdMovi_invent_tipo_egr_Despacho = Convert.ToInt32(Objeto.IdMovi_invent_tipo_egr_Despacho);
                Info.IdEstadoAprobacion_x_default = Objeto.IdEstadoAprobacion_x_default;
                Info.IdProductoTipo_ProdTerm = Convert.ToInt32(Objeto.IdProductoTipo_ProdTerm);
                Info.IdCategoria_ProdTerm = Objeto.IdCategoria_ProdTerm;
                Info.IdProveedor_ProdTerm = Convert.ToInt32(Objeto.IdProveedor_ProdTerm);
                Info.IdMarca_ProdTerm = Convert.ToInt32(Objeto.IdMarca_ProdTerm);
                Info.idTipo_Produto_Elemento = Convert.ToInt16(Objeto.idTipo_Produto_Elemento);
                Info.IdProductoTipo_MateriaPrima = Convert.ToInt32(Objeto.IdProductoTipo_MateriaPrima);
                Info.IdMoviInicio = Objeto.IdMoviInicio;
            }
				return Info;
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

    public Boolean GuardaroModificar(int idempresa)
    {
        try
        {
            EntitiesProduccion_Cidersus EProdC = new EntitiesProduccion_Cidersus();

            var param = from X in EProdC.prd_parametros_CusCidersus
                        where X.IdEmpresa == idempresa
                        select X;
            if (param.ToList().Count == 0)
                return true;
            else return false ;

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

    public Boolean GuardarDB(prd_parametros_CusCidersus_Info Info)
    {
        try
        {
            List<prd_parametros_CusCidersus_Info> Lst = new List<prd_parametros_CusCidersus_Info>();
            using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
            {
                var Address = new prd_parametros_CusCidersus();

                Address.IdEmpresa = Info.IdEmpresa;
                Address.IdSucursal_Princ = Info.IdSucursal_Princ;
                Address.IdBodega_Princ = Info.IdBodega_Princ;
                Address.IdSucursal_Produccion = Info.IdSucursal_Produccion;
                Address.IdBodega_Produccion = Info.IdBodega_Produccion;
                Address.IdMovi_inven_tipo_ing_suc_princ = Info.IdMovi_inven_tipo_ing_suc_princ;
                Address.IdMovi_inven_tipo_egr_suc_princ = Info.IdMovi_inven_tipo_egr_suc_princ;
                Address.IdMovi_inven_tipo_egr_consumoprod = Info.IdMovi_inven_tipo_egr_consumoprod;
                Address.IdMovi_inven_tipo_ing_consumoprod = Info.IdMovi_inven_tipo_ing_consumoprod;
                Address.IdMovi_inven_tipo_ing_ContrlProduccion = Info.IdMovi_inven_tipo_ing_ContrlProduccion;
                Address.IdMovi_inven_tipo_egr_ContrlProduccion = Info.IdMovi_inven_tipo_egr_ContrlProduccion;
                Address.IdMovi_inven_tipo_egr_Conversion = Info.IdMovi_inven_tipo_egr_Conversion;
                Address.IdMovi_inven_tipo_ing_Conversion = Info.IdMovi_inven_tipo_ing_Conversion;
                Address.IdMovi_inven_tipo_egr_Ensamblado = Info.IdMovi_inven_tipo_egr_Ensamblado;
                Address.IdMovi_inven_tipo_ing_Ensamblado = Info.IdMovi_inven_tipo_ing_Ensamblado;
                Address.IdMovi_inven_tipo_ingxresid_Conversion = Info.IdMovi_inven_tipo_ingxresid_Conversion;
                Address.IdMovi_invent_tipo_egr_Despacho = Info.IdMovi_invent_tipo_egr_Despacho;
                Address.IdEstadoAprobacion_x_default = Info.IdEstadoAprobacion_x_default;
                Address.IdProductoTipo_ProdTerm = Info.IdProductoTipo_ProdTerm;
                Address.IdCategoria_ProdTerm = Info.IdCategoria_ProdTerm;
                Address.IdProveedor_ProdTerm = Info.IdProveedor_ProdTerm;
                Address.IdMarca_ProdTerm = Info.IdMarca_ProdTerm;

                Address.idTipo_Produto_Elemento = Info.idTipo_Produto_Elemento;
                Address.IdProductoTipo_MateriaPrima = Info.IdProductoTipo_MateriaPrima;
                Address.IdMoviInicio = Info.IdMoviInicio;

                Context.prd_parametros_CusCidersus.Add(Address);
                Context.SaveChanges();
            }
            return true;
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

    public Boolean ModificarDB(prd_parametros_CusCidersus_Info Info)
    {
        try
        {
            using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
            {

                var contact = Context.prd_parametros_CusCidersus.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa);
                if (contact != null)
                {
                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdSucursal_Princ = Info.IdSucursal_Princ;
                    contact.IdBodega_Princ = Info.IdBodega_Princ;
                    contact.IdSucursal_Produccion = Info.IdSucursal_Produccion;
                    contact.IdBodega_Produccion = Info.IdBodega_Produccion;
                    contact.IdMovi_inven_tipo_ing_suc_princ = Info.IdMovi_inven_tipo_ing_suc_princ;
                    contact.IdMovi_inven_tipo_egr_suc_princ = Info.IdMovi_inven_tipo_egr_suc_princ;
                    contact.IdMovi_inven_tipo_egr_consumoprod = Info.IdMovi_inven_tipo_egr_consumoprod;
                    contact.IdMovi_inven_tipo_ing_consumoprod = Info.IdMovi_inven_tipo_ing_consumoprod;
                    contact.IdMovi_inven_tipo_ing_ContrlProduccion = Info.IdMovi_inven_tipo_ing_ContrlProduccion;
                    contact.IdMovi_inven_tipo_egr_ContrlProduccion = Info.IdMovi_inven_tipo_egr_ContrlProduccion;
                    contact.IdMovi_inven_tipo_egr_Conversion = Info.IdMovi_inven_tipo_egr_Conversion;
                    contact.IdMovi_inven_tipo_ing_Conversion = Info.IdMovi_inven_tipo_ing_Conversion;
                    contact.IdMovi_inven_tipo_egr_Ensamblado = Info.IdMovi_inven_tipo_egr_Ensamblado;
                    contact.IdMovi_inven_tipo_ing_Ensamblado = Info.IdMovi_inven_tipo_ing_Ensamblado;
                    contact.IdMovi_inven_tipo_ingxresid_Conversion = Info.IdMovi_inven_tipo_ingxresid_Conversion;
                    contact.IdMovi_invent_tipo_egr_Despacho = Info.IdMovi_invent_tipo_egr_Despacho;
                    contact.IdEstadoAprobacion_x_default = Info.IdEstadoAprobacion_x_default;
                    contact.IdProductoTipo_ProdTerm = Info.IdProductoTipo_ProdTerm;
                    contact.IdCategoria_ProdTerm = Info.IdCategoria_ProdTerm;
                    contact.IdProveedor_ProdTerm = Info.IdProveedor_ProdTerm;
                    contact.IdMarca_ProdTerm = Info.IdMarca_ProdTerm;
                    contact.idTipo_Produto_Elemento = Info.idTipo_Produto_Elemento;
                    contact.IdProductoTipo_MateriaPrima = Info.IdProductoTipo_MateriaPrima;
                    contact.IdMoviInicio = Info.IdMoviInicio;

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
            mensaje = ex.ToString() + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.ToString());
        }
    }

    }
}
