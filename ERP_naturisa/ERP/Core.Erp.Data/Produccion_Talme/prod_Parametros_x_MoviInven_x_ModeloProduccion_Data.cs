using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
   public class prod_Parametros_x_MoviInven_x_ModeloProduccion_Data
    {
       string mensaje = "";
       public List<prod_Parametros_x_MoviInven_x_ModeloProduccion_Info> ConsultaGeneral(int IdEmpresa)
	{
			List<prod_Parametros_x_MoviInven_x_ModeloProduccion_Info> Lst = new List<prod_Parametros_x_MoviInven_x_ModeloProduccion_Info>() ;
			EntitiesProduccion oEnti= new EntitiesProduccion();
		try
		{
			var Query = from q in oEnti.prod_Parametros_x_MoviInven_x_ModeloProduccion
                        where q.IdEmpresa == IdEmpresa
				select q;
			 foreach (var item in Query)
			{
				prod_Parametros_x_MoviInven_x_ModeloProduccion_Info Obj = new prod_Parametros_x_MoviInven_x_ModeloProduccion_Info() ;
					Obj.IdEmpresa= item.IdEmpresa;
					Obj.IdModeloProd= item.IdModeloProd;
					Obj.Secuencia= item.Secuencia;
					Obj.IdSucursal_IngxProducTermi= item.IdSucursal_IngxProducTermi;
					Obj.IdBodega_IngxProducTermi= item.IdBodega_IngxProducTermi;
					Obj.IdMovi_inven_tipo_x_IngxProduc_ProdTermi= item.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
					Obj.IdSucursal_EgrxMateriaPrima= item.IdSucursal_EgrxMateriaPrima;
					Obj.IdBodega_EgrxMateriaPrima= item.IdBodega_EgrxMateriaPrima;
					Obj.IdMovi_inven_tipo_x_EgrxProduc_MatPri= item.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
					Obj.IdProducto_ParaIngreso= item.IdProducto_ParaIngreso;
					Obj.IdProducto_ParaEgreso= item.IdProducto_ParaEgreso;
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


	public prod_Parametros_x_MoviInven_x_ModeloProduccion_Info ObtenerObjeto(int IdEmpresa,int IdModeloProd)
	{
			EntitiesProduccion oEnti= new EntitiesProduccion();
            prod_Parametros_x_MoviInven_x_ModeloProduccion_Info Info = new prod_Parametros_x_MoviInven_x_ModeloProduccion_Info() ;
		try
		{
				
			 var Objeto = oEnti.prod_Parametros_x_MoviInven_x_ModeloProduccion.First(var => var.IdEmpresa == IdEmpresa && var.IdModeloProd == IdModeloProd);
					Info.IdEmpresa= Objeto.IdEmpresa;
					Info.IdModeloProd= Objeto.IdModeloProd;
					Info.Secuencia= Objeto.Secuencia;
					Info.IdSucursal_IngxProducTermi= Objeto.IdSucursal_IngxProducTermi;
					Info.IdBodega_IngxProducTermi= Objeto.IdBodega_IngxProducTermi;
					Info.IdMovi_inven_tipo_x_IngxProduc_ProdTermi= Objeto.IdMovi_inven_tipo_x_IngxProduc_ProdTermi;
					Info.IdSucursal_EgrxMateriaPrima= Objeto.IdSucursal_EgrxMateriaPrima;
					Info.IdBodega_EgrxMateriaPrima= Objeto.IdBodega_EgrxMateriaPrima;
					Info.IdMovi_inven_tipo_x_EgrxProduc_MatPri= Objeto.IdMovi_inven_tipo_x_EgrxProduc_MatPri;
					Info.IdProducto_ParaIngreso= Objeto.IdProducto_ParaIngreso;
					Info.IdProducto_ParaEgreso= Objeto.IdProducto_ParaEgreso;
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
    }
}
