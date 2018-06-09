using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Parametro : Form
    {
        #region Declaración de Variables
        com_Catalogo_Bus Catalogo_bus = new com_Catalogo_Bus();
        in_movi_inven_tipo_Bus MoviTipoBus = new in_movi_inven_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_parametro_Bus ParaBus = new com_parametro_Bus();
        com_parametro_Info Info_parametro = new com_parametro_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        bool B_siExiste = true;
        #endregion
       
        public FrmCom_Parametro()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant.event_btnGuardar_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;

        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }            
        }

        Boolean validar(com_parametro_Info Info_Param)
        {
            try
            {

                if (Info_Param.IdEmpresa == 0)
                {
                    MessageBox.Show("No tiene IdEmpresa el Info",param.nom_pc,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }


                if (Info_Param.IdEstadoAnulacion_OC == "" || Info_Param.IdEstadoAnulacion_OC == null)
                {
                    MessageBox.Show("No tiene el estado de Anulacion de Orden de Compra", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (Info_Param.IdEstadoAprobacion_OC == "" || Info_Param.IdEstadoAprobacion_OC == null)
                {
                    MessageBox.Show("No tiene el estado de Aprobacion de Orden de Compra", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (Info_Param.IdEstadoAprobacion_SolCompra == "" || Info_Param.IdEstadoAprobacion_SolCompra == null)
                {
                    MessageBox.Show("No tiene el estado de Aprobacion de la Solicitud de Compra", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (Info_Param.IdMovi_inven_tipo_dev_compra == 0 || Info_Param.IdMovi_inven_tipo_dev_compra == null)
                {
                    MessageBox.Show("No tiene el tipo de movimiento de devolucion de compra", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (Info_Param.IdMovi_inven_tipo_OC == 0 || Info_Param.IdMovi_inven_tipo_OC == null)
                {
                    MessageBox.Show("No tiene el tipo de movimiento de inventario por orden de compra", param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }



                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
                
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                get_info();
                Boolean res;

                if (validar(Info_parametro)==false)
                { return; }


                if (B_siExiste == false)
                {
                   res= ParaBus.GuardarDB(Info_parametro, ref mensaje);
                }
                else
                {
                   res= ParaBus.ModificarDB(Info_parametro, ref mensaje);
                }

                if (res)
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk);
                    ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                }
                else
                {
                    MessageBox.Show("Parametros de Compras no pueden ser Ingresados");
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        private void cargar_parametros()
        {
            try
            {
                List<com_parametro_Info> listParam = new List<com_parametro_Info>();
                listParam = ParaBus.Get_List_parametro(param.IdEmpresa);
                if (listParam.Count() == 0)
                {
                    B_siExiste = false;
                }
                else
                {
                    B_siExiste = true;

                    

                }

                foreach (var item in listParam)
                {
                    cmb_estado_cierre_oc.EditValue = item.IdEstado_cierre;
                    cmb_estado_anulacion.EditValue = item.IdEstadoAnulacion_OC;
                    cmb_estado_aprobacion.EditValue = item.IdEstadoAprobacion_OC;
                    cmbestadoAprobacion_solCom.EditValue = item.IdEstadoAprobacion_SolCompra;
                    cmbTipoMovInven_x_devCom.EditValue = item.IdMovi_inven_tipo_dev_compra;
                    cmb_tipo_movi_inven_x_oc.EditValue = item.IdMovi_inven_tipo_OC;
                    cmb_sucursalxaprobacionsc.set_SucursalInfo(item.IdSucursal_x_Aprob_x_SolComp);
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {

        }

        private void get_info()
        {

            try
            {

                Info_parametro = new com_parametro_Info();

                ucGe_Menu_Superior_Mant.Focus();

                    Info_parametro.IdEmpresa = param.IdEmpresa;
                    Info_parametro.IdEstadoAprobacion_OC = (cmb_estado_aprobacion.EditValue==null)? null: Convert.ToString(cmb_estado_aprobacion.EditValue);
                    Info_parametro.IdMovi_inven_tipo_OC = (cmb_tipo_movi_inven_x_oc.EditValue==null)?0: Convert.ToInt32(cmb_tipo_movi_inven_x_oc.EditValue);
                    Info_parametro.IdEstadoAnulacion_OC = (cmb_estado_anulacion.EditValue==null)?null: Convert.ToString(cmb_estado_anulacion.EditValue);
                    Info_parametro.IdMovi_inven_tipo_dev_compra = (cmbTipoMovInven_x_devCom.EditValue==null)?0:Convert.ToInt32(cmbTipoMovInven_x_devCom.EditValue);
                    Info_parametro.IdEstadoAprobacion_SolCompra = (cmbestadoAprobacion_solCom.EditValue==null)?null:Convert.ToString(cmbestadoAprobacion_solCom.EditValue);
                    Info_parametro.IdSucursal_x_Aprob_x_SolComp = (cmb_sucursalxaprobacionsc.get_SucursalInfo().IdSucursal==null)?0:Convert.ToInt32(cmb_sucursalxaprobacionsc.get_SucursalInfo().IdSucursal);
                    Info_parametro.IdEstado_cierre = (cmb_estado_cierre_oc.EditValue==null)?null:Convert.ToString(cmb_estado_cierre_oc.EditValue);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        
        }

        private void FrmCom_Parametro_Load(object sender, EventArgs e)
        {
            try
            {

                cargar_combos();
                cargar_parametros();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void cargar_combos()
        {

            try
            {
                List<com_Catalogo_Info> listEstaAprob = new List<com_Catalogo_Info>();
                listEstaAprob = Catalogo_bus.Get_ListEstadoAprobacion();
                cmb_estado_aprobacion.Properties.DataSource = listEstaAprob;
                

                List<in_movi_inven_tipo_Info> ListMoviInven_tipo = new List<in_movi_inven_tipo_Info>();
                ListMoviInven_tipo = MoviTipoBus.Get_list_movi_inven_tipo(param.IdEmpresa, "+", "", "");
                cmb_tipo_movi_inven_x_oc.Properties.DataSource = ListMoviInven_tipo;
        

                List<com_Catalogo_Info> listEstaAnulacion = new List<com_Catalogo_Info>();
                listEstaAnulacion = Catalogo_bus.Get_ListEstadoAnulacion();
                cmb_estado_anulacion.Properties.DataSource = listEstaAnulacion;


                List<in_movi_inven_tipo_Info> ListMoviInven_tipo_devCom = new List<in_movi_inven_tipo_Info>();
                ListMoviInven_tipo_devCom = MoviTipoBus.Get_list_movi_inven_tipo(param.IdEmpresa, "+", "", "");
                cmbTipoMovInven_x_devCom.Properties.DataSource = ListMoviInven_tipo_devCom;
                cmbTipoMovInven_x_devCom.Properties.DisplayMember = "tm_descripcion2";
                cmbTipoMovInven_x_devCom.Properties.ValueMember = "IdMovi_inven_tipo";


                List<com_Catalogo_Info> listEstaAprob_solicitud_compra = new List<com_Catalogo_Info>();
                listEstaAprob_solicitud_compra = Catalogo_bus.Get_ListEstadoAprobacion_solicitud_compra();
                cmbestadoAprobacion_solCom.Properties.DataSource = listEstaAprob_solicitud_compra;


                com_estado_cierre_Bus EstadoCierBus = new com_estado_cierre_Bus();

                List<com_estado_cierre_Info> listEstadoCierre = new List<com_estado_cierre_Info>();
                listEstadoCierre = EstadoCierBus.Get_List_estado_cierre();
                cmb_estado_cierre_oc.Properties.DataSource = listEstadoCierre;






            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

    }
}
