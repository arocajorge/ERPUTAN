using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Inventario;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Movil_PteGrua : Form
    {
        public FrmPrd_Movil_PteGrua()
        {
            try
            {
                    InitializeComponent();
                    infoparametros = busParametros.ObtenerObjeto(param.IdEmpresa);
                    iniciar_controles();
                    UCSucursal.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                    cargacombos();

                    gridControlDisponible.DataSource = Prod;
                    cambiacontroles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        void cambiacontroles()
        {
            try
            {
                Font fte = new System.Drawing.Font("Microsoft Sans Serif", 6.5f);

                UCSucursal.cmb_sucursal.Size = new System.Drawing.Size(170, 18);
                UCSucursal.label1.Text = "SUC:";

                UCSucursal.label1.Location = new Point(0, 8);


                UCSucursal.lblBodega.Font = fte;

                UCSucursal.cmb_sucursal.Font = fte;

                //UCObra.UC_Obra.Font = fte;
             //   UCObra.label.Font = fte;
                UCSucursal.cmb_sucursal.Location = new Point(29, 2);
                UCObra.cargaCmb_Obra();
                PanelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
                //UCObra.UC_Obra.Size = new Size(170, 18);
                //UCObra.label.Text = "OB:";
                //UCObra.label.Location = new Point(0, 3);
                //UCObra.UC_Obra.Location = new Point(29, 3);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        //#region variables

        ////instancias de centro de costo
        //UCPrd_Obra UCObra = new UCPrd_Obra();
        //UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
        //prd_MovPteGrua_Info InfoPG = new prd_MovPteGrua_Info(); //esta es para el get
        //prd_PuenteGruaMovilizacion_Bus BusPG = new prd_PuenteGruaMovilizacion_Bus();
        //List<prd_PteGrua_Info> LstPteGrua = new List<prd_PteGrua_Info>();
        //prd_PteGrua_Bus BusPteGrua = new prd_PteGrua_Bus();
        //prd_MovPteGrua_Bus BusMovPteGruaCab = new prd_MovPteGrua_Bus();
        ////instancias de modelo produccion x centro costo
        //prd_ProcesoProductivo_x_prd_obra_Bus BusModeloxCC = new prd_ProcesoProductivo_x_prd_obra_Bus();
        //prd_ProcesoProductivo_x_prd_obra_Info InfoModelo = new prd_ProcesoProductivo_x_prd_obra_Info();

        //prd_parametros_CusCidersus_Info infoparametros = new prd_parametros_CusCidersus_Info();
        //prd_parametros_CusCidersus_Bus busParametros = new prd_parametros_CusCidersus_Bus();
        //prd_EtapaProduccion_Bus BusEta = new prd_EtapaProduccion_Bus();

        ////instancia de orden taller
        //prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();

        //BindingList<prd_MovPteGrua_Det_Info> Prod = new BindingList<prd_MovPteGrua_Det_Info>();
        ////instancia de inventario
        //prd_ControlInventarioProd_Info InfoInv = new prd_ControlInventarioProd_Info();
        //prd_ControlInventarioProd_Bus BusInv = new prd_ControlInventarioProd_Bus();

        //tb_Sucursal_Info _sucursal = new tb_Sucursal_Info();
        ////instancias generales
        //cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        //#endregion 

    
        
       // public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
       // {
       //     try
       //     {
       //         switch (iAccion)
       //         {
       //             case Cl_Enumeradores.eTipo_action.grabar:
       //                 this.btnGrabar.Text = "Grabar Registro";
                        
       //                 txtIdMov.Text = "00000";
       //                 break;
       //             case Cl_Enumeradores.eTipo_action.actualizar:
       //                 this.btnGrabar.Text = "Actualizar Registro";
                        
       //                 bloquearcab();
       //                 break;
       //             case Cl_Enumeradores.eTipo_action.consultar:
       //                 this.btnGrabar.Visible = false;
                        
       //                 bloquearcab();
       //                 break;
       //             default:
       //                 break;
       //         }
       //     }
       //     catch (Exception)
       //     {
                
                
       //     }
       //     Accion = iAccion;
           
       // }

       // void cargacombos()
       // {
       //     try
       //     {
       //         LstPteGrua = BusPteGrua.ConsultaGeneral(param.IdEmpresa, _sucursal.IdSucursal, ref msg);
       //         cmbPteGrua.ValueMember = "IdPteGrua";
       //         cmbPteGrua.DisplayMember = "Descripcion";
       //         cmbPteGrua.DataSource = LstPteGrua;
       //         if (LstPteGrua.Count > 0)
       //             cmbPteGrua.SelectedIndex = 0;
       //     }
       //     catch (Exception ex) { MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); }
        
        
       // }
       // private void bloquearcab()
       // {
       //     try
       //     {

       //     }
       //     catch (Exception)
       //     {
                
       //         throw;
       //     }
        
        
       // }
       // private void iniciar_controles()
       // {
       //     try
       //     {
       //         UCObra.cargaCmb_Obra();
       //         PanelObra.Controls.Add(UCObra);
       //         UCObra.Dock = DockStyle.Fill;
       //         UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
       //         UCObra.UC_Obra.SelectedIndex = 0;
       //         cargaobras();
       //         UCSucursal.cargar_sucursal(param.IdEmpresa);
       //         _sucursal.IdEmpresa = param.IdEmpresa;
       //         _sucursal.IdSucursal = infoparametros.IdSucursal_Produccion;
       //         UCSucursal.set_sucursal(_sucursal);
       //         PanelSuc.Controls.Add(UCSucursal);
       //         UCSucursal.Dock = DockStyle.Fill;
       //         UCSucursal.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted);
                

       //     }
       //     catch (Exception ex) { MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); }
       // }

       // void UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
       // {
       //     gridControlDisponible.DataSource = null;
       // }

       // void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
       // {
       //     cargaobras();
       // }
       //void cargaobras()
       //{

       //    try
       //    {
       //        cmbOrdenTaller.Text = "";
       //        cmbEtInicial.Text = "";
       //        cmbEtFinal.Text = "";
       //        cmbProcProd.Text = "";


       //        if (UCObra.get_item_info() != null)
       //        {
       //            string obra = UCObra.get_item();
       //            InfoModelo = BusModeloxCC.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, obra);
       //            if (InfoModelo.IdProcesoProductivo != 0)
       //            {
       //                cmbProcProd.Value = InfoModelo.IdProcesoProductivo;
       //                CargaDatos(UCObra.get_item(), InfoModelo.IdProcesoProductivo);
       //            }
       //        }

       //    }
       //    catch (Exception)
       //    {


       //    }
       
       //}

       // private void CargaDatos(string CodObra, int IdModelo)
       // {
       //      try
       //     {
                

       //        // InfoModelo = BusModeloxCC.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, IdCentroCosto);
       //        // txtModProd.Text = InfoModelo.NombreModelo;

       //          // ComboEtaInicial
       //         this.cmbEtInicial.DataSource = BusEta.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
       //         this.cmbEtInicial.DisplayMember = "NombreEtapa";
       //         this.cmbEtInicial.ValueMember = "IdEtapa";
       //         this.cmbEtInicial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
       //         this.cmbEtInicial.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
       //         //if (cmbEtInicial.SelectedIndex == -1)
       //         //    cmbEtInicial.SelectedIndex = 0;


       //         this.cmbProcProd.DataSource = BusModeloxCC.ObtenerProcesProductivo_x_CentroCosto(param.IdEmpresa, CodObra);
       //         this.cmbProcProd.DisplayMember = "NombreModelo";
       //         this.cmbProcProd.ValueMember = "IdProcesoProductivo";
       //         this.cmbProcProd.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
       //         this.cmbProcProd.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;

       //          // ComboEtafinal
       //         this.cmbEtFinal.DataSource = BusEta.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
       //         this.cmbEtFinal.DisplayMember = "NombreEtapa";
       //         this.cmbEtFinal.ValueMember = "IdEtapa";
       //         this.cmbEtFinal.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
       //         this.cmbEtFinal.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;

               
                
             
       //         this.cmbOrdenTaller.Properties.DataSource = BusOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, CodObra);
                
               


       //     }
       //     catch (Exception ex)
       //     {
       //     }
        
        
       // }

       // public void LlenarSaldos()
       // {
            
       //     int calculosaldofin = 0;
       

       // }


       // List<prd_MovPteGrua_Det_Info> LstMovPteGruaDet = new List<prd_MovPteGrua_Det_Info>();
       // prd_MovPteGrua_Det_Bus BusMovPteGrua = new prd_MovPteGrua_Det_Bus();
       // string msg = "";
       // public void setCab(prd_MovPteGrua_Info  InfoMovPte)
       // {
       //     try
       //     {
                
       //         txtIdMov.Text = Convert.ToString(InfoMovPte.IdMovPteGrua);
       //         UCSucursal.set_sucursal(_sucursal );
       //         //UCObra.set_item(InfoMovPte.CodObra);
       //         UCObra.UC_Obra.Value = InfoMovPte.CodObra;
       //         CargaDatos(InfoMovPte.CodObra, InfoMovPte.IdModeloProduccion);
       //         cmbProcProd.Value = InfoMovPte.IdModeloProduccion;
       //         cmbEtInicial.Value = InfoMovPte.IdEtapaOrigen;
       //         cmbEtFinal.Value = InfoMovPte.IdEtapaSiguiente;
       //         cmbOrdenTaller.EditValue = InfoMovPte.IdOrdenTaller;
       //         dtPFechaReg.Value = InfoMovPte.Fecha;
       //         txtObservacion.Text = InfoMovPte.Observacion;
       //         txtUniMovidos.Text = Convert.ToString(InfoMovPte.Saldo);
                
                

       //         if (InfoMovPte.Estado == "I")
       //         {
       //             lblAnulado.Visible = true;
       //         }
       //         else
       //             lblAnulado.Visible = false ;

       //         LstMovPteGruaDet = BusMovPteGrua.MovPteGruaDetalle(InfoMovPte.IdEmpresa,
       //             InfoMovPte.IdSucursal, InfoMovPte.IdMovPteGrua, ref msg);
               
       //         foreach (var item in LstMovPteGruaDet)
       //         {
       //             item.pr_descripcion =busProd.Get_Descripcion_Producto(item.IdEmpresa, item.IdProducto);
       //               //string codigo = "";
       //               //      codigo = item.CodigoBarraMaestro;
       //               //      item.CodigoBarraMaestro = item.CodigoBarra;
       //               //      item.CodigoBarra = codigo;
       //         }
       //         Prod = new BindingList<prd_MovPteGrua_Det_Info>(LstMovPteGruaDet);
       //         gridControlDisponible.DataSource = Prod;

               
       //     }
       //     catch (Exception ex){MessageBox.Show("Ha ocurrido un error: "+msg + ex.InnerException.ToString());}
            
        
        
       // }

       // private Boolean grabar()
       // {
       //     try
       //     {
       //         if (validaciones() == false)
       //         {
       //             MessageBox.Show("No se Guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //             return false;
       //         }
       //         else
       //         {
       //             this.txtIdMov.Focus();
       //             getCab();
                   
       //             decimal idgenerada = 0;
       //             switch (Accion)
       //             {
       //                 case Cl_Enumeradores.eTipo_action.grabar:
       //                     if (BusPG.GrabarDB( InfoPG, LstMovPteGruaDet, ref msg, ref idgenerada))
       //                     {
       //                         //txtIdMov.Text = idgenerada.ToString("00000");
       //                         txtIdMov.Text = Convert.ToString(idgenerada);
       //                         set_Accion(Cl_Enumeradores.eTipo_action.consultar);
       //                     }
       //                     MessageBox.Show("Se procedio a grabar el Reg.#"+idgenerada, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
       //                     return true;
                            
       //                 case Cl_Enumeradores.eTipo_action.borrar:
       //                     //BusPG.ModificarDB(param.IdEmpresa, InfoPG, ref msg);
       //                     MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
       //                     return true;
                            
       //                 default:
       //                     return false;
       //             }
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         return false;
       //     }
       // }

       // private void getCab()
       // {
       //     try
       //     {
       //         InfoPG.IdEmpresa = param.IdEmpresa;
       //         InfoPG.IdSucursal = param.IdSucursal ;
                
       //         InfoPG.IdModeloProduccion = Convert.ToInt32(cmbProcProd.Value);
       //         InfoPG.IdEtapaOrigen = Convert.ToInt32(cmbEtInicial.Value);
       //         InfoPG.IdEtapaSiguiente = Convert.ToInt32(cmbEtFinal .Value);
       //         InfoPG.IdOrdenTaller = Convert.ToInt32(cmbOrdenTaller.EditValue);
       //         InfoPG.IdPteGrua = Convert.ToInt32(cmbPteGrua.Value);
       //         InfoPG.Fecha = Convert.ToDateTime(dtPFechaReg.Value.ToShortDateString());
       //         InfoPG.Saldo = Convert.ToInt32(txtUniMovidos.Text);
       //         InfoPG.Observacion = txtObservacion.Text+"Ob:"+UCObra.get_item_info().CodObra
       //             + "OT:" + InfoPG.IdOrdenTaller + "Mov de Et:" + InfoPG.IdEtapaOrigen
       //             + "a Et:" + InfoPG.IdEtapaSiguiente;
       //         InfoPG.IdUsuario = param.IdUsuario;
       //         InfoPG.FechaTransac = param.Fecha_Transac;

       //         LstMovPteGruaDet = new List<prd_MovPteGrua_Det_Info>();
       //         //List<prd_MovPteGrua_Det_Info>DetTem = new List<prd_MovPteGrua_Det_Info>();
                
                
       //         //DetTem = (List<prd_MovPteGrua_Det_Info>)gridVwMovPteGruaDet.DataSource;
       //         //foreach (var item in DetTem)
       //         //{
                    
                      
       //         //}

       //         for (int i = 0; i < gridViewDisponible.RowCount; i++)
       //         {
       //             var Item = (prd_MovPteGrua_Det_Info)gridViewDisponible.GetRow(i);

       //             if (Item != null)
       //             {
       //                 if (Item.CodigoBarra != "" && Item.IdProducto != null && Item.pr_descripcion != "")
       //                 {
       //                     //string codigo = "";
       //                     //codigo = Item.CodigoBarraMaestro;
       //                     //Item.CodigoBarraMaestro = Item.CodigoBarra;
       //                     //Item.CodigoBarra = codigo;

       //                     LstMovPteGruaDet.Add(Item);
       //                 }
       //             }

       //         }

       //         LstMovPteGruaDet.ForEach(var => { var.IdEmpresa = InfoPG.IdEmpresa; var.IdSucursal = InfoPG.IdSucursal; });

       //     }
       //     catch (Exception ex)
       //     {
       //     }
       // }
        
       // private Boolean validaciones()
       // {
       //     try
       //     {

       //         if (UCObra.get_item() == null)
       //         {
       //             MessageBox.Show("Debe seleccionar una Obra", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //             return false;
       //         }
                
       //         else if (this.cmbEtInicial.Value == null)
       //         {
       //             MessageBox.Show("Debe seleccionar una etapa de producción de origen", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //             return false;
       //         }
       //         else if (this.cmbEtFinal .Value == null)
       //         {
       //             MessageBox.Show("Debe seleccionar una etapa de producción siguiente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //             return false;
       //         }
       //         else if (this.cmbOrdenTaller.EditValue == null)
       //         {
       //             MessageBox.Show("Debe seleccionar una Orden de Taller", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //             return false;
       //         }
       //         else if (gridViewDisponible.RowCount < 0)
       //         {
       //             MessageBox.Show("Ingrese los items a mover", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //             return false;

       //         }
              
               
       //         return true;
       //     }
       //     catch (Exception ex)
       //     {
       //         return false;
       //     }
       // }

       // private void btnGrabar_Click(object sender, EventArgs e)
       // {
       //     grabar();
       // }


       // private void mnu_salir_Click(object sender, EventArgs e)
       // {
       //     this.Close();
       // }

       // private Boolean  validar()
       // {
       //     try
       //     {
                
       //             if (UCObra.get_item_info() == null)
       //             {
       //                 MessageBox.Show("Debe seleccionar la Obra Asignada y la Orden de Taller", "Sistema", MessageBoxButtons.OK);
       //                 PanelObra.Focus();
                        

       //             }
       //             else if (UCObra.get_item_info() == null)
       //             {
       //                 MessageBox.Show("Debe seleccionar la Obra Asignada y la Orden de Taller", "Sistema", MessageBoxButtons.OK);
       //                 PanelObra.Focus();
       //                 return false;

       //             }
       //             else if (cmbOrdenTaller.EditValue == null || cmbOrdenTaller.EditValue == "")
       //             {
       //                 MessageBox.Show("Debe seleccionar la Orden de Taller Asignada", "Sistema", MessageBoxButtons.OK);
       //                 cmbOrdenTaller.Focus();
       //                 return false;

       //             }
       //             else if (cmbEtInicial.Value == null)
       //             {
       //                 MessageBox.Show("Debe seleccionar la Etapa Origen", "Sistema", MessageBoxButtons.OK);
       //                 cmbOrdenTaller.Focus();
       //                 return false;

       //             }
       //             else if (cmbEtFinal.Value == null)
       //             {
       //                 MessageBox.Show("Debe seleccionar una Etapa Destino", "Sistema", MessageBoxButtons.OK);
       //                 cmbOrdenTaller.Focus();
       //                 return false;

       //             }
       //             return true;
                   
       //     }

       //     catch (Exception ex)
       //     {
       //         MessageBox.Show(ex.InnerException.ToString()); return false;
       //     }
       // }

  
       // List<vwprd_MovPteGruaSaldo_Info> LstSaldos = new List<vwprd_MovPteGruaSaldo_Info>();
       // in_producto_Bus busProd = new in_producto_Bus(); 
       // prd_OrdenTaller_Bus busOT = new prd_OrdenTaller_Bus();
       // prd_OrdenTaller_Info OT = new prd_OrdenTaller_Info();
       // List<prd_EtapaProduccion_Info> ListEtapas = new List<prd_EtapaProduccion_Info>();
                    
       // private void cmbOrdenTaller_EditValueChanged(object sender, EventArgs e)
       // {
       //     try
       //     {
       //         OT = new prd_OrdenTaller_Info();
       //         if (cmbOrdenTaller.EditValue != null)
       //         {
       //             OT = busOT.ObtenerUnaOT(param.IdEmpresa, _sucursal.IdSucursal,
       //                   Convert.ToDecimal(cmbOrdenTaller.EditValue), UCObra.get_item());

       //             LstSaldos = BusMovPteGruaCab.MovPteGruaSaldo(param.IdEmpresa, Convert.ToInt32(cmbProcProd.Value),
       //                         Convert.ToInt32(cmbEtInicial.Value), OT.IdOrdenTaller, OT.CodObra);
       //             if (LstSaldos != null)
       //                 txtUniMovidos.Text = Convert.ToString(LstSaldos.Count);


       //         }
       //     }
       //     catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); }
       // }

       // private void cmbEtInicial_ValueChanged(object sender, EventArgs e)
       // {
       //     try
       //     {
       //         if (cmbEtInicial.Value != null)
       //         {
       //             prd_EtapaProduccion_Info etaorig = new prd_EtapaProduccion_Info();
       //             etaorig = BusEta.ObtenerEtapa(param.IdEmpresa, Convert.ToInt32(cmbEtInicial.Value), Convert.ToInt32(cmbProcProd.Value));
       //             ListEtapas = BusEta.ObtenerListaEtapas(param.IdEmpresa, Convert.ToInt32(cmbProcProd.Value));

       //             foreach (var item in ListEtapas)
       //             {
       //                 if (etaorig.Posicion + 1 == item.Posicion)
       //                 {
       //                     cmbEtFinal.Value = item.IdEtapa;
       //                     break;
                        
       //                 }
                        
       //             }

       //             LstSaldos = BusMovPteGruaCab.MovPteGruaSaldo(param.IdEmpresa, Convert.ToInt32(cmbProcProd.Value),
       //                        Convert.ToInt32(cmbEtInicial.Value), OT.IdOrdenTaller, OT.CodObra);
       //             if (LstSaldos!= null)
       //                 txtUniMovidos.Text = Convert.ToString(LstSaldos.Count);

       //         }
       //     }
       //     catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); }
       // }

    
       // private void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_Load(object sender, EventArgs e)
       // {
           
       // }



       // List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
       // prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();


       // void buscarenlistado()
       // {
       //     try
       //     {
       //         if (!String.IsNullOrEmpty(txtIngCB.Text) || !String.IsNullOrWhiteSpace(txtIngCB.Text))
       //         {
       //             Boolean Find = false;

       //             if (ListadoDisponible.Count > 0)
       //             {
       //                 var codbarramaestro = BusEnsa.buscacodbarramaestro(param.IdEmpresa, txtIngCB.Text, ref msg);

       //                 prd_MovPteGrua_Det_Info agregado = new prd_MovPteGrua_Det_Info();

       //                 foreach (var item in ListadoDisponible)
       //                 {
       //                     if (codbarramaestro != null)
       //                     {
       //                         if (item.CodigoBarraMaestro == codbarramaestro.CodigoBarra || item.CodigoBarraMaestro == codbarramaestro.CBMaestro)
       //                         {
       //                             item.Checked = true; item.CodigoBarra = codbarramaestro.CodigoBarra;
       //                             string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
       //                             item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
       //                             agregado = item; Find = true;
       //                         }
       //                     }
       //                     else
       //                         if (item.CodigoBarraMaestro == txtIngCB.Text)
       //                         {
       //                             item.Checked = true; item.CodigoBarra = txtIngCB.Text;
       //                             string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
       //                             item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
       //                             agregado = item; Find = true;
       //                         }

       //                 }
       //                 if (Find == true)
       //                 {
       //                     List<prd_MovPteGrua_Det_Info> listatemp = new List<prd_MovPteGrua_Det_Info>();
       //                     foreach (var item in ListadoDisponible)
       //                     {
       //                         if (item.CodigoBarraMaestro != agregado.CodigoBarraMaestro)
       //                             listatemp.Add(item);
       //                     }

       //                     ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
       //                     ListadoDisponible.Add(agregado);
       //                     foreach (var item in listatemp)
       //                     {
       //                         ListadoDisponible.Add(item);
       //                     }

       //                     gridControlDisponible.DataSource = ListadoDisponible;
       //                     gridControlDisponible.RefreshDataSource();
       //                     MessageBox.Show("Agregado");
       //                     txtIngCB.Text = "";

       //                 }
       //                 else if (preguntar == true)
       //                 {
       //                     MessageBox.Show("Código no encontrado");


       //                 }
       //             }
       //         }
       //     }
       //     catch (Exception ex)
       //     {

       //     }

       // }

       // Boolean preguntar = false;
       // private void txtIngCB_KeyPress(object sender, KeyPressEventArgs e)
       // {
       //     var car = e.KeyChar.ToString();
       //     if (e.KeyChar.ToString() == "\r")
       //     { preguntar = true; buscarenlistado(); }
       //     else preguntar = false;
       // }



       // private void gridViewDisponible_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
       // {
       //     try
       //     {
       //         if (e.Column.FieldName == "Checked")
       //         {
       //             gridViewDisponible.SetFocusedRowCellValue("Checked", false);
       //         }
       //     }
       //     catch (Exception ex)
       //     {

       //     }
       // }

        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //instancias de centro de costo
        UCPrd_Obra UCObra = new UCPrd_Obra();
        UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
        prd_MovPteGrua_Info InfoPG = new prd_MovPteGrua_Info(); //esta es para el get
       // prd_PuenteGruaMovilizacion_Bus BusPG = new prd_PuenteGruaMovilizacion_Bus();
        //List<prd_PuenteGruaMovimiento_Info> LstPteGrua = new List<prd_PuenteGruaMovimiento_Info>();
       // prd_PuenteGruaMoviiento_Bus BusPteGrua = new prd_PuenteGruaMoviiento_Bus();
        //instancias de modelo produccion x centro costo
        prd_ProcesoProductivo_x_prd_obra_Bus BusModeloxCC = new prd_ProcesoProductivo_x_prd_obra_Bus();
        prd_ProcesoProductivo_x_prd_obra_Info InfoModelo = new prd_ProcesoProductivo_x_prd_obra_Info();

        prd_parametros_CusCidersus_Info infoparametros = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus busParametros = new prd_parametros_CusCidersus_Bus();
        prd_EtapaProduccion_Bus BusEta = new prd_EtapaProduccion_Bus();

        //instancia de orden taller
        prd_OrdenTaller_Bus BusOT = new prd_OrdenTaller_Bus();

        BindingList<prd_MovPteGrua_Det_Info> Prod = new BindingList<prd_MovPteGrua_Det_Info>();
        BindingList<prd_MovPteGrua_Det_Info> ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
        //instancia de inventario
        prd_ControlInventarioProd_Info InfoInv = new prd_ControlInventarioProd_Info();
        prd_ControlInventarioProd_Bus BusInv = new prd_ControlInventarioProd_Bus();

        tb_Sucursal_Info _sucursal = new tb_Sucursal_Info();
        //instancias generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        #endregion

        void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e) { }
        public delegate void delegate_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing;
        private void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                   event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       txtIdMov.Text = "00000";
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.btnGrabar.Enabled = false;
                        bloquearcab();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            Accion = iAccion;

        }

        void cargacombos()
        {
            try
            {
               // LstPteGrua = BusPteGrua.ConsultaGeneral(param.IdEmpresa, _sucursal.IdSucursal, ref msg);
                cmbPteGrua.Properties.ValueMember = "IdPteGrua";
                cmbPteGrua.Properties.DisplayMember = "Descripcion";
               // cmbPteGrua.Properties.DataSource = LstPteGrua;
              //  if (LstPteGrua.Count > 0)
                    cmbPteGrua.EditValue = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
            }


        }
        private void bloquearcab()
        {
            try
            {
                UCSucursal.cmb_sucursal.Enabled = false;
               // UCObra.UC_Obra.Enabled = false;
                cmbEtFinal.Enabled = false;
                cmbEtInicial.Enabled = false;


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void iniciar_controles()
        {
            try
            {
                UCObra.cargaCmb_Obra();
                PanelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
                UCObra.Event_UCObra_SelectionChanged += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
                //UCObra.UC_Obra.SelectedIndex = 0;
                cargaobras();
                UCSucursal.cargar_sucursal(param.IdEmpresa);
                _sucursal.IdEmpresa = param.IdEmpresa;
                _sucursal.IdSucursal = infoparametros.IdSucursal_Produccion;
                UCSucursal.set_sucursal(_sucursal);
                PanelSuc.Controls.Add(UCSucursal);
                UCSucursal.Dock = DockStyle.Fill;
                UCSucursal.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted);
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString());
            }
        }

        void UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
                gridControlDisponible.DataSource = ListadoDisponible;
                gridControlDisponible.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                     cargaobras();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
  
        }
        void cargaobras()
        {

            try
            {
                cmbOrdenTaller.Text = "";
                cmbEtInicial.Text = "";
                cmbEtFinal.Text = "";
                cmbProcProd.Text = "";


                if (UCObra.get_item_info() != null)
                {
                    string obra = UCObra.get_item();
                    InfoModelo = BusModeloxCC.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, obra);
                    if (InfoModelo.IdProcesoProductivo != 0)
                    {
                        cmbProcProd.EditValue = InfoModelo.IdProcesoProductivo;
                        CargaDatos(UCObra.get_item(), InfoModelo.IdProcesoProductivo);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void CargaDatos(string CodObra, int IdModelo)
        {
            try
            {


                // InfoModelo = BusModeloxCC.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, IdCentroCosto);
                // txtModProd.Text = InfoModelo.NombreModelo;

                // ComboEtaInicial
                this.cmbEtInicial.Properties.DataSource = BusEta.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
                this.cmbEtInicial.Properties.DisplayMember = "NombreEtapa";
                this.cmbEtInicial.Properties.ValueMember = "IdEtapa";
                //this.cmbEtInicial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                //this.cmbEtInicial.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
                //if (cmbEtInicial.SelectedIndex == -1)
                //    cmbEtInicial.SelectedIndex = 0;


                this.cmbProcProd.Properties.DataSource = BusModeloxCC.ObtenerProcesProductivo_x_CentroCosto(param.IdEmpresa, CodObra);
                this.cmbProcProd.Properties.DisplayMember = "NombreModelo";
                this.cmbProcProd.Properties.ValueMember = "IdProcesoProductivo";
                //this.cmbProcProd.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                //this.cmbProcProd.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;

                // ComboEtafinal
                this.cmbEtFinal.Properties.DataSource = BusEta.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
                this.cmbEtFinal.Properties.DisplayMember = "NombreEtapa";
                this.cmbEtFinal.Properties.ValueMember = "IdEtapa";
                //this.cmbEtFinal.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                //this.cmbEtFinal.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;




                this.cmbOrdenTaller.Properties.DataSource = BusOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public void LlenarSaldos()
        {
            try
            {
                   int calculosaldofin = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }




        }

        List<prd_MovPteGrua_Det_Info> LstMovPteGruaDet = new List<prd_MovPteGrua_Det_Info>();
 
        string msg = "";
        public void setCab(prd_MovPteGrua_Info InfoMovPte)
        {
            try
            {

              //  txtIdMov.Text = Convert.ToString(InfoMovPte.IdMovPteGrua);
                UCSucursal.set_sucursal(_sucursal);
                //UCObra.set_item(InfoMovPte.CodObra);
                //UCObra.UC_Obra.Value = InfoMovPte.CodObra;
                //CargaDatos(InfoMovPte.CodObra, InfoMovPte.IdModeloProduccion);
                //cmbProcProd.EditValue = InfoMovPte.IdModeloProduccion;
                //cmbEtInicial.EditValue = InfoMovPte.IdEtapaOrigen;
                //cmbEtFinal.EditValue = InfoMovPte.IdEtapaSiguiente;
                //cmbOrdenTaller.EditValue = InfoMovPte.IdOrdenTaller;
                
                    lblAnulado.Visible = false;


                foreach (var item in LstMovPteGruaDet)
                {
                    item.pr_descripcion = busProd.Get_Descripcion_Producto(item.IdEmpresa, item.IdProducto);
                }
                Prod = new BindingList<prd_MovPteGrua_Det_Info>(LstMovPteGruaDet);
                ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>(LstMovPteGruaDet);
                gridControlDisponible.DataSource = ListadoDisponible;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error: " + msg + ex.InnerException.ToString()); 
            }



        }

        private Boolean grabar()
        {
            try
            {
                if (validaciones() == false)
                {
                    MessageBox.Show("No se Guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    this.txtIdMov.Focus();

                    decimal idgenerada = 0;
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            //if (BusPG.GrabarDB(InfoPG, ref msg))
                            //{
                            //    //txtIdMov.Text = idgenerada.ToString("00000");
                            //    txtIdMov.Text = Convert.ToString(idgenerada);
                            //    set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            //}
                            //MessageBox.Show("Se procedio a grabar el Reg.#" + idgenerada, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //return true;

                        case Cl_Enumeradores.eTipo_action.Anular:
                            //BusPG.ModificarDB(param.IdEmpresa, InfoPG, ref msg);
                            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;

                        default:
                            return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean getCab()
        {
            try
            {
                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean validaciones()
        {
            try
            {

                if (UCObra.get_item() == null)
                {
                    MessageBox.Show("Seleccione una Obra", "SISTEMA", MessageBoxButtons.OK);
                    return false;
                }

                else if (this.cmbEtInicial.EditValue == null)
                {
                    MessageBox.Show("Seleccione Et Origen", "SISTEMA", MessageBoxButtons.OK);
                    return false;
                }
                else if (this.cmbEtFinal.EditValue == null)
                {
                    MessageBox.Show("Seleccione Et Destino", "SISTEMA", MessageBoxButtons.OK);
                    return false;
                }
                else if (this.cmbOrdenTaller.EditValue == null)
                {
                    MessageBox.Show("Seleccione una OT", "SISTEMA", MessageBoxButtons.OK);
                    return false;
                }

                if (!getCab())
                    return false;
                // De una vez se obtiene el detalle a guardar
                LstMovPteGruaDet = new List<prd_MovPteGrua_Det_Info>();

                foreach (var var in ListadoDisponible)
                {
                    if (var.Checked == true)
                    {
                      //  var.IdEmpresa = InfoPG.IdEmpresa; var.IdSucursal = InfoPG.IdSucursal;
                        LstMovPteGruaDet.Add(var);
                    }
                }
                if (LstMovPteGruaDet.Count < 1)
                {
                    MessageBox.Show("Ingrese los items a mover", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGrabar_Click(object sender, EventArgs e)
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

        private void mnu_salir_Click(object sender, EventArgs e)
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

        private Boolean validar()
        {
            try
            {

                if (UCObra.get_item_info() == null|| (UCObra.get_item_info() == null))
                {
                    MessageBox.Show("Seleccione Obra y OT", "Sistema", MessageBoxButtons.OK);
                    PanelObra.Focus();
return false;

                }
                else if (cmbOrdenTaller.EditValue == null || cmbOrdenTaller.EditValue == "")
                {
                    MessageBox.Show("Seleccione OT", "Sistema", MessageBoxButtons.OK);
                    cmbOrdenTaller.Focus();
                    return false;

                }
                else if (cmbEtInicial.EditValue == null)
                {
                    MessageBox.Show("Seleccione Et Origen", "Sistema", MessageBoxButtons.OK);
                    cmbOrdenTaller.Focus();
                    return false;

                }
                else if (cmbEtFinal.EditValue == null)
                {
                    MessageBox.Show("Seleccione Et Destino", "Sistema", MessageBoxButtons.OK);
                    cmbOrdenTaller.Focus();
                    return false;

                }
                return true;

            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); return false;
            }
        }

        List<vwprd_MovPteGruaSaldo_Info> LstSaldos = new List<vwprd_MovPteGruaSaldo_Info>();
        in_producto_Bus busProd = new in_producto_Bus();
        prd_OrdenTaller_Bus busOT = new prd_OrdenTaller_Bus();
        prd_OrdenTaller_Info OT = new prd_OrdenTaller_Info();
        List<prd_EtapaProduccion_Info> ListEtapas = new List<prd_EtapaProduccion_Info>();

        private void cmbOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                OT = new prd_OrdenTaller_Info();
                if (cmbOrdenTaller.EditValue != null)
                {
                    OT = busOT.ObtenerUnaOT(param.IdEmpresa, _sucursal.IdSucursal,
                          Convert.ToDecimal(cmbOrdenTaller.EditValue), UCObra.get_item());

                  //  LstSaldos = BusMovPteGruaCab.MovPteGruaSaldo(param.IdEmpresa, Convert.ToInt32(cmbProcProd.EditValue),
                               // Convert.ToInt32(cmbEtInicial.EditValue), OT.IdOrdenTaller, OT.CodObra);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }

        private void cmbEtInicial_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEtInicial.EditValue != null)
                {
                    prd_EtapaProduccion_Info etaorig = new prd_EtapaProduccion_Info();
                    etaorig = BusEta.ObtenerEtapa(param.IdEmpresa, Convert.ToInt32(cmbEtInicial.EditValue), Convert.ToInt32(cmbProcProd.EditValue));
                    ListEtapas = BusEta.ObtenerListaEtapas(param.IdEmpresa, Convert.ToInt32(cmbProcProd.EditValue));
                    Boolean etapafinal = true;
                    foreach (var item in ListEtapas)
                    {
                        if (etaorig.Posicion + 1 == item.Posicion)
                        {
                            cmbEtFinal.EditValue = item.IdEtapa; etapafinal = false;
                            break;


                        }

                    }
                    if (etapafinal == false)
                    {
                        ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
                      //  LstSaldos = BusMovPteGruaCab.MovPteGruaSaldo(param.IdEmpresa, Convert.ToInt32(cmbProcProd.EditValue),
                                  // Convert.ToInt32(cmbEtInicial.EditValue), OT.IdOrdenTaller, OT.CodObra);

                        foreach (var item in LstSaldos)
                        {
                            prd_MovPteGrua_Det_Info info = new prd_MovPteGrua_Det_Info();
                            var Prodaaa = busProd.Get_info_Product(param.IdEmpresa, item.IdProducto);
                            info.CodigoBarraMaestro = item.CodigoBarra;
                            info.pr_descripcion = Prodaaa.pr_descripcion;
                            info.IdProducto = item.IdProducto;
                            info.Cantidad = 1;
                            ListadoDisponible.Add(info);
                        }
                        gridControlDisponible.DataSource = ListadoDisponible;
                        gridControlDisponible.RefreshDataSource();
                    }
                    else
                    {
                        ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
                        gridControlDisponible.DataSource = ListadoDisponible;
                        cmbEtFinal.Text = "";
                        gridControlDisponible.RefreshDataSource();
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void FrmPrd_PuenteGruaMovilizacion_Mantenimiento_Load(object sender, EventArgs e){}

        List<vwprd_Ensamblado_CabDet_CusCider_Info> LstEnsab = new List<vwprd_Ensamblado_CabDet_CusCider_Info>();
        prd_Ensamblado_CusCider_Bus BusEnsa = new prd_Ensamblado_CusCider_Bus();


        void buscarenlistado()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtIngCB.Text) || !String.IsNullOrWhiteSpace(txtIngCB.Text))
                {
                    Boolean Find = false;

                    if (ListadoDisponible.Count > 0)
                    {
                        var codbarramaestro = BusEnsa.buscacodbarramaestro(param.IdEmpresa, txtIngCB.Text, ref msg);

                        prd_MovPteGrua_Det_Info agregado = new prd_MovPteGrua_Det_Info();

                        foreach (var item in ListadoDisponible)
                        {
                            if (codbarramaestro != null)
                            {
                                if (item.CodigoBarraMaestro == codbarramaestro.CodigoBarra || item.CodigoBarraMaestro == codbarramaestro.CBMaestro)
                                {
                                    item.Checked = true; item.CodigoBarra = txtIngCB.Text;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
                                    agregado = item; Find = true;
                                }
                            }
                            else
                                if (item.CodigoBarraMaestro == txtIngCB.Text)
                                {
                                    item.Checked = true; item.CodigoBarra = txtIngCB.Text;
                                    string[] Time = DateTime.Now.ToString("hh:mm").Split(':');
                                    item.Hora = new TimeSpan(Convert.ToInt32(Time[0]), Convert.ToInt32(Time[1]), 0);
                                    agregado = item; Find = true;
                                }

                        }
                        if (Find == true)
                        {
                            List<prd_MovPteGrua_Det_Info> listatemp = new List<prd_MovPteGrua_Det_Info>();
                            foreach (var item in ListadoDisponible)
                            {
                                if (item.CodigoBarraMaestro != agregado.CodigoBarraMaestro)
                                    listatemp.Add(item);
                            }

                            ListadoDisponible = new BindingList<prd_MovPteGrua_Det_Info>();
                            ListadoDisponible.Add(agregado);
                            foreach (var item in listatemp)
                            {
                                ListadoDisponible.Add(item);
                            }

                            gridControlDisponible.DataSource = ListadoDisponible;
                            gridControlDisponible.RefreshDataSource();
                            MessageBox.Show("Agregado","Sistema");
                            txtIngCB.Text = "";

                        }
                        else if (preguntar == true)
                        {
                            MessageBox.Show("Código no encontrado","Sistema");


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        Boolean preguntar = false;
        private void txtIngCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var car = e.KeyChar.ToString();
                if (e.KeyChar.ToString() == "\r")
                { preguntar = true; buscarenlistado(); }
                else preguntar = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        
        private void gridViewDisponible_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Checked")
                {
                    KeyPressEventArgs v = new KeyPressEventArgs(Convert.ToChar("\r"));

                    //
                    if (Convert.ToBoolean(e.CellValue) == true)
                    {
                        gridViewDisponible.SetFocusedRowCellValue("Checked", false);
                    }
                    else
                    {

                        var reg = (prd_MovPteGrua_Det_Info)gridViewDisponible.GetFocusedRow();
                        if (reg != null && reg.CodigoBarraMaestro != null)
                        { txtIngCB.Text = reg.CodigoBarraMaestro; txtIngCB_KeyPress(sender, v); }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }





      
    }
}
