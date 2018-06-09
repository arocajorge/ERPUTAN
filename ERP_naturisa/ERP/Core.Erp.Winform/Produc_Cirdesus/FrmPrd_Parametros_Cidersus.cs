using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus ;
using Core.Erp.Business.Produc_Cirdesus ;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Inventario ;
using Core.Erp.Business.Inventario ;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Parametros_Cidersus : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_parametros_CusCidersus_Info Parametros = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus BusParametros = new prd_parametros_CusCidersus_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        in_movi_inven_tipo_Bus BusTipMov = new in_movi_inven_tipo_Bus();
        com_Catalogo_Bus BusEstadoApr = new com_Catalogo_Bus();
        in_ProductoTipo_Bus BusTipProd = new in_ProductoTipo_Bus();
        in_marca_bus BusMarca = new in_marca_bus();
        in_categorias_bus BusCate = new in_categorias_bus();
        cp_proveedor_Bus BusProvee = new cp_proveedor_Bus();
        #endregion

        public FrmPrd_Parametros_Cidersus()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                cargacombos();
                SetInfo();
                //cmbBodPrinc.DataBindings = bodPrinc;
                //cmbBodProd = bodProd;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        
        void cargamovimprod()
        {

            try
            {
                cmbIConv.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "+", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) 
            { 
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
            try
            {
                cmbIEnsam.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "+", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

            try
            {
                cmbIResConv.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "+", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            try
            {
                cmbIProd.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "+", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbICtrlProd.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "+", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbECtrlProd.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "-", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbEConv.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "-", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbEDesp.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "-", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbEEnsam.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "-", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbEProd.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucProd.EditValue), Convert.ToInt32(cmbBodProd.EditValue),
                "-", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
        }

        void cargamovimprinc()
        {
            try
            {
                cmbISucPrinc.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                param.IdEmpresa, Convert.ToInt32(cmbSucPrinc.EditValue), Convert.ToInt32(cmbBodPrinc.EditValue),
                "+", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
            try
            {
                cmbESucPrinc.Properties.DataSource = BusTipMov.Get_list_movi_inven_tipo_x_bodega(
                    param.IdEmpresa, Convert.ToInt32(cmbSucPrinc.EditValue), Convert.ToInt32(cmbBodPrinc.EditValue),
                    "-", "").FindAll(var => var.Estado == "A");
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
        }

        void cargabodegaprinc()
        {

            try
            {

                List<tb_Bodega_Info> LstBod = new List<tb_Bodega_Info>();
                LstBod = BusBod.Get_List_Bodega(param.IdEmpresa);
                if (LstBod != null)
                {
                    List<tb_Bodega_Info> LstBodPrin = new List<tb_Bodega_Info>();
                    foreach (var item in LstBod)
                    {
                        if (item.IdSucursal == Convert.ToInt32(cmbSucPrinc.EditValue) && item.Estado == true)
                            LstBodPrin.Add(item);
                    }
                    if (LstBodPrin != null)
                    {
                        try
                        {
                            LstBodPrin = LstBodPrin.FindAll(var => var.Estado == true);//?se caera
                            cmbBodPrinc.Properties.DataSource = LstBodPrin;
                        }
                        catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        void cargabodegasprod()
        {
            try
            {
                List<tb_Bodega_Info> LstBod = new List<tb_Bodega_Info>();
                LstBod = BusBod.Get_List_Bodega(param.IdEmpresa);
                if (LstBod != null)
                {
                    List<tb_Bodega_Info> LstBodProd = new List<tb_Bodega_Info>();
                    foreach (var item in LstBod)
                    {
                        //tb_Bodega_Info bodega = new tb_Bodega_Info();

                        if (item.IdSucursal == Convert.ToInt32(cmbBodProd.EditValue) && item.Estado == true)
                            LstBodProd.Add(item);

                    }

                    if (LstBodProd != null)
                    {
                        try
                        {

                            LstBodProd = LstBodProd.FindAll(var => var.Estado == true); //?se caera
                            cmbBodProd.Properties.DataSource = LstBodProd;
                            //cargamovimprod();
                        }
                        catch (Exception ex)
                        {
                            Log_Error_bus.Log_Error(ex.ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        void cargacombos()
        {
            try
            {
                List<tb_Sucursal_Info> LstSuc = new List<tb_Sucursal_Info>();
                LstSuc = BusSuc.Get_List_Sucursal(param.IdEmpresa);
                if (LstSuc != null&&LstSuc.Count != 0)
                {
                    cmbSucPrinc.Properties.DataSource = LstSuc;
                    cmbSucProd.Properties.DataSource = LstSuc;
                    cmbSucPrinc.EditValue = LstSuc[0].IdSucursal;
                    cmbSucProd.EditValue = LstSuc[0].IdSucursal;

                    List<tb_Bodega_Info> LstBod = new List<tb_Bodega_Info>();
                    LstBod = BusBod.Get_List_Bodega(param.IdEmpresa);
                    if (LstBod != null)
                    {
                        List<tb_Bodega_Info> LstBodPrin = new List<tb_Bodega_Info>();
                        List<tb_Bodega_Info> LstBodProd = new List<tb_Bodega_Info>();
                        foreach (var item in LstBod)
                        {
                            //tb_Bodega_Info bodega = new tb_Bodega_Info();
                            if (item.IdSucursal == Convert.ToInt32(cmbSucPrinc.EditValue)&& item.Estado == true)
                                LstBodPrin.Add(item);
                            if (item.IdSucursal == Convert.ToInt32(cmbSucProd.EditValue) && item.Estado == true)
                                LstBodProd.Add(item);

                        }
                        if (LstBodPrin != null)
                        {
                            try
                            {   LstBodPrin = LstBodPrin.FindAll(var => var.Estado == true);//?se caera
                                
                                cmbBodPrinc.Properties.DataSource = LstBodPrin;
                                cmbBodPrinc.EditValue = LstBodPrin[0].IdBodega;
                                cargamovimprinc();
                               }
                            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
                            
                
                        }
                        if (LstBodProd != null)
                        {
                            try
                            {
                                LstBodProd = LstBodProd.FindAll(var => var.Estado == true); //?se caera
                                cmbBodProd.EditValue = LstBodProd[0].IdBodega;
                                cmbBodProd.Properties.DataSource = LstBodProd;
                                cargamovimprod();
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());
                            }

                        }
                    }
                }
                string estadoAprob = "";
                List<com_Catalogo_Info> listEstaAprob = new List<com_Catalogo_Info>();
                listEstaAprob = BusEstadoApr.Get_ListEstadoAprobacion();
                cmbEstadoAprob.Properties.DataSource = listEstaAprob;
                cmbEstadoAprob.EditValue = listEstaAprob.FirstOrDefault().IdCatalogocompra;
                com_parametro_Info InfoComDev = new com_parametro_Info();
                com_parametro_Bus Bus_Param = new com_parametro_Bus();
                InfoComDev = Bus_Param.Get_Info_parametro(param.IdEmpresa);
                estadoAprob = InfoComDev.IdEstadoAprobacion_OC;
                cmbEstadoAprob.EditValue = estadoAprob;
              
                try { cmbTipPrMP.Properties.DataSource = BusTipProd.Obtener_ProductosTipos(param.IdEmpresa).FindAll(var => var.Estado == "A"); }
                catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
                try { cmbTipPrPT.Properties.DataSource = BusTipProd.Obtener_ProductosTipos(param.IdEmpresa).FindAll(var => var.Estado == "A"); }
                catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
                try { cmbCatPT.Properties.DataSource = BusCate.Get_List_categorias(param.IdEmpresa).FindAll(var => var.Estado == "A"); }
                catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); }
                try{cmbMarcaPT.Properties.DataSource = BusMarca.Get_list_Marca (param.IdEmpresa).FindAll(var => var.Estado == "A");
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        }

        private Boolean GetInfo()
        {
            try
            {
                Parametros = new prd_parametros_CusCidersus_Info();
                Parametros.IdBodega_Princ = Convert.ToInt32(cmbBodPrinc.EditValue);
                Parametros.IdBodega_Produccion = Convert.ToInt32(cmbBodProd.EditValue);
                Parametros.IdSucursal_Princ = Convert.ToInt32(cmbSucPrinc.EditValue);
                Parametros.IdSucursal_Produccion = Convert.ToInt32(cmbSucProd.EditValue);
                Parametros.IdEmpresa = param.IdEmpresa;
                Parametros.IdMarca_ProdTerm = Convert.ToInt32(cmbMarcaPT.EditValue);
                Parametros.IdProveedor_ProdTerm = cmbProveePT.get_ProveedorInfo().IdProveedor;
                Parametros.IdEstadoAprobacion_x_default = Convert.ToString(cmbEstadoAprob.EditValue);
                Parametros.IdCategoria_ProdTerm = Convert.ToString(cmbCatPT.EditValue);
                Parametros.IdMovi_inven_tipo_egr_consumoprod = Convert.ToInt32(cmbEProd.EditValue);
                Parametros.IdMovi_inven_tipo_egr_ContrlProduccion = Convert.ToInt32(cmbECtrlProd.EditValue);
                Parametros.IdMovi_inven_tipo_egr_Conversion = Convert.ToInt32(cmbEConv.EditValue);
                Parametros.IdMovi_inven_tipo_egr_Ensamblado  = Convert.ToInt32(cmbEEnsam.EditValue);
                Parametros.IdMovi_inven_tipo_egr_suc_princ = Convert.ToInt32(cmbESucPrinc.EditValue);
                Parametros.IdMovi_invent_tipo_egr_Despacho = Convert.ToInt32(cmbEDesp.EditValue);
                Parametros.IdMovi_inven_tipo_ing_consumoprod = Convert.ToInt32(cmbIProd.EditValue);
                Parametros.IdMovi_inven_tipo_ing_ContrlProduccion = Convert.ToInt32(cmbICtrlProd.EditValue);
                Parametros.IdMovi_inven_tipo_ing_Conversion = Convert.ToInt32(cmbIConv.EditValue);
                Parametros.IdMovi_inven_tipo_ing_Ensamblado = Convert.ToInt32(cmbIEnsam.EditValue);
                Parametros.IdMovi_inven_tipo_ing_suc_princ = Convert.ToInt32(cmbISucPrinc.EditValue);
                Parametros.IdMovi_inven_tipo_ingxresid_Conversion = Convert.ToInt32(cmbIResConv.EditValue);
                Parametros.IdProductoTipo_ProdTerm = Convert.ToInt32(cmbTipPrPT.EditValue);
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;

            }
        }

        private void SetInfo()
        {
            try
            {
                Parametros = BusParametros.ObtenerObjeto(param.IdEmpresa);
                cmbSucPrinc.EditValue = Parametros.IdSucursal_Princ;
                cmbSucProd.EditValue = Parametros.IdSucursal_Produccion;
                cmbBodPrinc.EditValue = Parametros.IdBodega_Princ;
                cmbBodProd.EditValue = Parametros.IdBodega_Produccion;
                cmbMarcaPT.EditValue = Parametros.IdMarca_ProdTerm;
                cmbProveePT.set_ProveedorInfo(Convert.ToDecimal(Parametros.IdProveedor_ProdTerm));
                cmbCatPT.EditValue = Parametros.IdCategoria_ProdTerm;
                cmbEstadoAprob.EditValue = Parametros.IdEstadoAprobacion_x_default;
                cmbEProd.EditValue = Parametros.IdMovi_inven_tipo_egr_consumoprod;
                cmbECtrlProd.EditValue = Parametros.IdMovi_inven_tipo_egr_ContrlProduccion;
                cmbEConv.EditValue = Parametros.IdMovi_inven_tipo_egr_Conversion;
                cmbEEnsam.EditValue = Parametros.IdMovi_inven_tipo_egr_Ensamblado;
                cmbESucPrinc.EditValue = Parametros.IdMovi_inven_tipo_egr_suc_princ;
                cmbEDesp.EditValue = Parametros.IdMovi_invent_tipo_egr_Despacho;
                cmbIProd.EditValue = Parametros.IdMovi_inven_tipo_ing_consumoprod;
                cmbICtrlProd.EditValue = Parametros.IdMovi_inven_tipo_ing_ContrlProduccion;
                cmbIConv.EditValue = Parametros.IdMovi_inven_tipo_ing_Conversion;
                cmbIEnsam.EditValue = Parametros.IdMovi_inven_tipo_ing_Ensamblado;
                cmbISucPrinc.EditValue = Parametros.IdMovi_inven_tipo_ing_suc_princ;
                cmbIResConv.EditValue = Parametros.IdMovi_inven_tipo_ingxresid_Conversion;
                cmbTipPrPT.EditValue = Parametros.IdProductoTipo_ProdTerm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        
        
        }
        
        void grabar()
        {
            try
            {
                if (validaciones())
                {
                    GetInfo();

                    if (BusParametros.GuardaroModificar(param.IdEmpresa))
                    {
                        if (BusParametros.GuardarDB(Parametros))

                            MessageBox.Show("Grabado con éxito");
                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;

                    }
                    else
                    {
                        if (BusParametros.ModificarDB(Parametros))

                            MessageBox.Show("Grabado con éxito");
                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        
        }
       
        private Boolean validaciones()
        {
            try
            {
                if (cmbSucPrinc.EditValue == null || cmbSucPrinc.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar la Sucursal Principal", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSucPrinc.Focus();
                    return false;

                }
                if (cmbSucProd.EditValue == null || cmbSucProd.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar la Bodega de Producción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSucProd.Focus();
                    return false;

                }
                if (cmbBodPrinc.EditValue == null || cmbBodPrinc.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar la Bodega Principal", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbBodPrinc.Focus();
                    return false;

                }
                if (cmbBodProd.EditValue == null || cmbBodProd.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar la Bodega de Producción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbBodProd.Focus();
                    return false;

                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
             grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void cmbSucPrinc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              setearxsucprinc();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        private void cmbSucProd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                  setearxsucprod();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }

        void setearxsucprinc()
        {
            try
            {
                if (cmbSucPrinc.EditValue != null)
                {
                    cargabodegaprinc();
                    cmbISucPrinc.Properties.DataSource = null;
                    cmbESucPrinc.Properties.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void setearxsucprod()
        {
            try
            {
                if (cmbSucProd.EditValue != null)
                {
                    cargabodegasprod();

                }
                cmbIConv.Properties.DataSource = null;
                cmbEConv.Properties.DataSource = null;
                cmbIEnsam.Properties.DataSource = null;
                cmbEEnsam.Properties.DataSource = null;
                cmbIProd.Properties.DataSource = null;
                cmbEProd.Properties.DataSource = null;
                cmbIResConv.Properties.DataSource = null;
                cmbEDesp.Properties.DataSource = null;
                cmbICtrlProd.Properties.DataSource = null;
                cmbECtrlProd.Properties.DataSource = null;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void cmbBodPrinc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBodPrinc.EditValue != null)
                {
                    cargamovimprinc();

                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbBodProd_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBodProd.EditValue != null)
                {
                    cargamovimprod();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
    }
}
