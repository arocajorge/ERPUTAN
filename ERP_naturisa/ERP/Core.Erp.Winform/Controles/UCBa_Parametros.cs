using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar ;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{    
    public partial class UCBa_Parametros : UserControl
    {
        #region declaraciones

        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();    
        ct_Cbtecble_tipo_Bus Tipo_comprobante_contable_bus = new ct_Cbtecble_tipo_Bus();
        ct_Plancta_Bus busCuenta = new ct_Plancta_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BusPara = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cxc_cobro_tipo_Bus busTipCob = new cxc_cobro_tipo_Bus();
        vwBA_Sucursal_x_TipoCobro_Bus busSuc_x_Tipo = new vwBA_Sucursal_x_TipoCobro_Bus();
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus busParam = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();
        tb_Ciudad_Bus Bus_ciudad = new tb_Ciudad_Bus();
        ba_tipo_nota_Bus tipo_nota_bus = new ba_tipo_nota_Bus();

        string MensajeError = "";

        //Listas
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listaBancoParam = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_parametros_Info InfoBancoOtroParam = new ba_parametros_Info();
        ba_parametros_Bus BusOtrosPara = new ba_parametros_Bus();

        List<ct_Plancta_Info> lmCuenta = new List<ct_Plancta_Info>();
        

        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> lista = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        List<tb_ciudad_Info> Lista_Ciudad = new List<tb_ciudad_Info>();
        List<ba_tipo_nota_Info> listas_tipos_notas = new List<ba_tipo_nota_Info>();
        //Infos
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

        //BindingList
        BindingList<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> ListaBind;
        
        BindingList<vwBA_Sucursal_x_TipoCobro_Info> BindLstCobro = new BindingList<vwBA_Sucursal_x_TipoCobro_Info>();
            
        public Boolean ocultarBotones = true;
        #endregion
    
        public UCBa_Parametros()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
                     
        private void UCBa_Parametros_Load(object sender, EventArgs e)
        { 
            try
            {


                ct_Cbtecble_tipo_Bus BusTipoCbte = new ct_Cbtecble_tipo_Bus();
                List<ct_Cbtecble_tipo_Info> listTipoCbte = new List<ct_Cbtecble_tipo_Info>();
                listTipoCbte = BusTipoCbte.Get_list_Cbtecble_tipo(param.IdEmpresa, ref MensajeError);
                    
                cmbTipoCbte_grid.DataSource=listTipoCbte;
                cmbTipoCbteAnu_grid.DataSource = listTipoCbte;


                //carga de grid Otros Parametros
                ba_parametros_Info infoBoanOtros;
                infoBoanOtros=new ba_parametros_Info();
                ba_parametros_Info InfoParam_x_Banco = new ba_parametros_Info();
                InfoParam_x_Banco = BusOtrosPara.Get_Info_Banco_Otros_Parametros(param.IdEmpresa);

                Lista_Ciudad = new List<tb_ciudad_Info>();
                Lista_Ciudad = Bus_ciudad.Get_List_Ciudad("");
                cmbCiudad_Cheques.Properties.DataSource = Lista_Ciudad;
                cmbCiudad_Cheques.EditValue = InfoParam_x_Banco.CiudadDefaultParaCrearCheques;


                lmCuenta = busCuenta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmbCtaCbte_grid.DataSource = lmCuenta;
                cmbCtaCbte_grid.DisplayMember = "pc_Cuenta2";
                cmbCtaCbte_grid.ValueMember = "IdCtaCble";


                chkDiarioModi.Checked = InfoParam_x_Banco.El_Diario_Contable_es_modificable;
                txt_rutaDescarga_file_preAvisoChq.Text = InfoParam_x_Banco.Ruta_descarga_fila_x_PreAviso_cheq;
                cmbTipoCbteCble_x_Presta.set_TipoCbteCble(Convert.ToInt32(InfoParam_x_Banco.IdTipoCbte_x_Prestamo));
                cmbTipoNotaDeb_x_Pres.set_TipoNotaInfo(Convert.ToInt32(InfoParam_x_Banco.IdTipoNota_ND_Can_Cuotas));
                if (InfoParam_x_Banco.IdCtaCble_Interes != null)
                    ucCon_PlanCtaCmb.set_PlanCtarInfo(InfoParam_x_Banco.IdCtaCble_Interes);


                if (InfoParam_x_Banco.IdCtaCble_prestamos != null)
                    cmb_prestamos.set_PlanCtarInfo(InfoParam_x_Banco.IdCtaCble_prestamos);

                ListaBind = new BindingList<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>(BusPara.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa));
                gridControlBancoParam.DataSource = ListaBind;
                
                 

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }   
        }
     
      

        public Boolean grabar()
        {
            try
            {
                if (!Validar()) { return false; }
                

                listaBancoParam.Clear();
                
                getGrid();

                if (BusPara.ModificarDB(listaBancoParam, param.IdEmpresa))
                {
                    if (!BusOtrosPara.ModificarDB(InfoBancoOtroParam, param.IdEmpresa))
                     MessageBox.Show("No se pudo Guardar los Otros parametros de Bancos");
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar los parametros de Bancos"); return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }        
        }
       
        public void getGrid()
        {
                try
                {
                    listaBancoParam = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();

                       int focus = this.gridViewBancoParam.FocusedRowHandle;
                        gridViewBancoParam.FocusedRowHandle = focus + 1; 
                    
                        foreach (var item in ListaBind)
                        {

                            ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
                            info.IdEmpresa = param.IdEmpresa;
                            info.IdTipoCbteCble = item.IdTipoCbteCble;
                            info.IdTipoCbteCble_Anu = item.IdTipoCbteCble_Anu;
                            info.IdCtaCble = item.IdCtaCble;
                            info.Tipo_DebCred = item.Tipo_DebCred == "Débito"?"D":"C";
                            info.CodTipoCbteBan = item.CodTipoCbteBan;
                          
                            listaBancoParam.Add(info);     
                      
                            

                        }


                        InfoBancoOtroParam = new ba_parametros_Info();
                        InfoBancoOtroParam.IdEmpresa = param.IdEmpresa;
                        InfoBancoOtroParam.El_Diario_Contable_es_modificable = chkDiarioModi.Checked;
                        InfoBancoOtroParam.CiudadDefaultParaCrearCheques = cmbCiudad_Cheques.EditValue.ToString();
                        InfoBancoOtroParam.IdTipoCbte_x_Prestamo = cmbTipoCbteCble_x_Presta.get_TipoCbteCble().IdTipoCbte;
                        InfoBancoOtroParam.IdTipoNota_ND_Can_Cuotas = cmbTipoNotaDeb_x_Pres.get_TipoNotaInfo().IdTipoNota;
                        InfoBancoOtroParam.Ruta_descarga_fila_x_PreAviso_cheq = txt_rutaDescarga_file_preAvisoChq.Text;
                      if(ucCon_PlanCtaCmb.get_PlanCtaInfo().IdCtaCble!=null)
                        InfoBancoOtroParam.IdCtaCble_Interes = ucCon_PlanCtaCmb.get_PlanCtaInfo().IdCtaCble;

                      if (cmb_prestamos.get_PlanCtaInfo().IdCtaCble != null)
                          InfoBancoOtroParam.IdCtaCble_prestamos = cmb_prestamos.get_PlanCtaInfo().IdCtaCble;

                }
                catch (Exception ex)
                {
                    string NameMetodo =  System.Reflection.MethodBase.GetCurrentMethod().Name;
                    MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                }
        }
                                         
        public Boolean Validar() 
        {
            try
            {
                int focus = this.gridViewBancoParam.FocusedRowHandle;
                gridViewBancoParam.FocusedRowHandle = focus + 1;
                
                foreach (var item in ListaBind)
                {
                    if (item.IdTipoCbteCble == null || Convert.ToInt32(item.IdTipoCbteCble) == 0)
                    {
                        MessageBox.Show("Ingrese Correctamente el Cbt Contable a Contabilizar \n **CAMPOS OBLIGATORIOS**");
                        return false;                   
                    }

                    if (item.IdTipoCbteCble_Anu == null || Convert.ToInt32(item.IdTipoCbteCble_Anu) == 0)
                    {
                        MessageBox.Show("Ingrese Correctamente el Cbt Contable para Anular  \n **CAMPOS OBLIGATORIOS**");
                        return false;
                    }

                    //if (item.IdCtaCble == null || Convert.ToString(item.IdCtaCble) == "")
                    //{
                    //    MessageBox.Show("Ingrese la Cuenta Predeterminada Correcta");
                    //    return false;
                    //}

                    if (item.Tipo_DebCred == null || Convert.ToString(item.Tipo_DebCred) == "")
                    {                      
                        MessageBox.Show("Ingrese la Naturaleza");
                        return false;
                    }
                }
                                                            
                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
       
        //public Boolean guardartip()
        //{
        //    try
        //    {
        //        //List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> ListaGrabarTipoCobro = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
        //        //foreach (var item in BindLstCobro)
        //        //{
        //        //    if (!String.IsNullOrEmpty(item.IdCobro_tipo) && (!String.IsNullOrEmpty(item.IdCtaCble_Credito) || !String.IsNullOrEmpty(item.IdCtaCble_Deudora)))
        //        //    {
        //        //        cxc_cobro_tipo_Param_conta_x_sucursal_Info info = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
        //        //        info.IdEmpresa = param.IdEmpresa;
        //        //        info.IdSucursal = item.IdSucursal;
        //        //        info.IdCobro_tipo = item.IdCobro_tipo;
        //        //        info.IdCtaCble = item.IdCtaCble_Deudora;

        //        //        ListaGrabarTipoCobro.Add(info);
        //        //    }
        //        //}

        //        //if (busParam.GuardarDB(ListaGrabarTipoCobro, param.IdEmpresa))
        //        //{
                    
        //        //    //cargaParCont_x_Suc(); return true;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //    return false;
        //}
   
        private void gridViewvwBA_Sucursal_x_TipoCobro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void btn_Refrescar_Click(object sender, EventArgs e)
        {
            try
            {
             //cargaParCont_x_Suc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridControlBancoParam_Click(object sender, EventArgs e)
        {

        }

        private void txt_rutaDescarga_file_preAvisoChq_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a folder";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {

                        txt_rutaDescarga_file_preAvisoChq.Text = dlg.SelectedPath + @"\";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }        
    }
}
