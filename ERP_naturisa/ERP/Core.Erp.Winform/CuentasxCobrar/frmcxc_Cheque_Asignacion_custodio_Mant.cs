using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Caja;

using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Cheque_Asignacion_custodio_Mant : Form
    {

        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_EstadoCobro_Bus Bus_EstadoCobro = new cxc_EstadoCobro_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Banco_Cuenta_Bus Bus_Banco = new ba_Banco_Cuenta_Bus();
        vwcxc_cobros_x_cheque_deposito_Bus Bus_VWCustodioCheque = new vwcxc_cobros_x_cheque_deposito_Bus();
        cxc_cobro_x_EstadoCobro_Bus Bus_Cobro = new cxc_cobro_x_EstadoCobro_Bus();
        cxc_cobro_Bus Bus_Cobr = new cxc_cobro_Bus();
       
        //Listas
        List<cxc_EstadoCobro_Info> Lista_EstadoCobro = new List<cxc_EstadoCobro_Info>();
        List<ba_Banco_Cuenta_Info> lista_Banco = new List<ba_Banco_Cuenta_Info>();
        List<caj_Caja_Movimiento_Info> List_Mov_Caja = new List<caj_Caja_Movimiento_Info>();

        //Infos
        List<cxc_cobro_x_EstadoCobro_Info> List_Cobro = new List<cxc_cobro_x_EstadoCobro_Info>();

        //BindingList
        BindingList<vwcxc_cobros_x_cheque_deposito_Info> Obj_Det_Asg_Ch = new BindingList<vwcxc_cobros_x_cheque_deposito_Info>(); //YYanten 19/03/2014
                      
        //Variables
        int bandera = 0;
        int i;//bandera para controlar check
        int j;//bandera para validar si se esta selccionando un check

        public frmCxc_Cheque_Asignacion_custodio_Mant()

        {
            try
            {
                  InitializeComponent();

                    event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing+=frmcxc_Cheque_Asignacion_custodio_Mant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
       }

          Cl_Enumeradores.eTipo_action enu= new Cl_Enumeradores.eTipo_action();

          public frmCxc_Cheque_Asignacion_custodio_Mant(Cl_Enumeradores.eTipo_action Numerador)
              : this()
             {
                    try
                    {
                        enu = Numerador;
                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                    }

            
                }

        private void frmcxc_Cheque_Asignacion_custodio_Mant_Load(object sender, EventArgs e)
        {
           
            try
            {
                dteFec_Desde.EditValue = param.Fecha_Transac.AddDays(-30);
                dteFec_Hasta.EditValue = param.Fecha_Transac.AddDays(+30);
                carga_Combos();
                
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                       // lblAnulado.Visible = false;                       
                        //  gridColumnEstadoPago.OptionsColumn.AllowEdit = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                       
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        btnGrabar.Text = "Anular";
                      
                        this.btnGrabarySalir.Visible = false;

                       // SETINFO();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        this.btnGrabar.Visible = false;
                        this.btnGrabarySalir.Visible = false;
                        

                       // SETINFO();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 

        }

        void carga_Combos()
        {
            try
            {
                Lista_EstadoCobro = Bus_EstadoCobro.Get_List_EstadoCobro();
                cmbEstadoCobro.Properties.DataSource = Lista_EstadoCobro;

                lista_Banco = Bus_Banco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.Properties.DataSource = lista_Banco;
                
                int d=0;
                // Carga de Grid
                Obj_Det_Asg_Ch = new BindingList<vwcxc_cobros_x_cheque_deposito_Info>(Bus_VWCustodioCheque.Get_List_cobros_x_cheque_deposito_x_Depositar(param.IdEmpresa));
                

                this.gridChequesAsignados.DataSource = Obj_Det_Asg_Ch;

                repositoryItemSearchLookUpEdit1.DataSource = Bus_Banco.Get_list_Banco_Cuenta(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        
        
        }


        void frmcxc_Cheque_Asignacion_custodio_Mant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        public delegate void delegate_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing;

        private void frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void grvChequeAsignados_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //bandera = 0;
                //vwcxc_cobros_x_cheque_deposito_Info row = (vwcxc_cobros_x_cheque_deposito_Info)grvChequeAsignados.GetFocusedRow();

                //ba_Banco_Cuenta_Info Verif_Banco = new ba_Banco_Cuenta_Info();

                //Verif_Banco = (ba_Banco_Cuenta_Info)repositoryItemSearchLookUpEdit1.View.OptionsView..GetFocusedRow();

                //if (Verif_Banco.IdCtaCble == null)
                //{
                //    MessageBox.Show("Selecciono un banco sin Cta Ctble. Por favor elija otro Banco");
                //    cmbBanco.Properties.DataSource = lista_Banco;
                //}

                //if (row != null)

                //    if (row.Check == true)
                //    {
                //        dteFec_Desde.Focus();
                //    }
                //    else
                //    {

                //    }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Carga de Grid
                Obj_Det_Asg_Ch = new BindingList<vwcxc_cobros_x_cheque_deposito_Info>(Bus_VWCustodioCheque.Get_List_cobros_x_cheque_deposito_x_Depositados(param.IdEmpresa));
                this.gridChequesAsignados.DataSource = Obj_Det_Asg_Ch;

                colBanco_deposito.OptionsColumn.ReadOnly = true;
                colFecha_dep.OptionsColumn.ReadOnly = true;
                cmbBanco.Properties.ReadOnly = true;
                checkAplicar.Enabled = false;
                btnGrabar.Visible = false;
                btnGrabarySalir.Visible = false;
                checkAplicar.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void rdbXDepositar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Carga de Grid x Depositar
                Obj_Det_Asg_Ch = new BindingList<vwcxc_cobros_x_cheque_deposito_Info>(Bus_VWCustodioCheque.Get_List_cobros_x_cheque_deposito_x_Depositar(param.IdEmpresa));
                this.gridChequesAsignados.DataSource = Obj_Det_Asg_Ch;

                colBanco_deposito.OptionsColumn.ReadOnly = false;
                colFecha_dep.OptionsColumn.ReadOnly = false;
                cmbBanco.Properties.ReadOnly = false;
                checkAplicar.Enabled = true;
                btnGrabarySalir.Visible = true;
                btnGrabar.Visible = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        int contador = 0;

        private void checkAplicar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBanco.EditValue == null)
                {
                    MessageBox.Show("Primero debe elegir el Banco que desea Asignar");
                    checkAplicar.Checked = false;
                }
                else
                {
                    if (checkAplicar.Checked == true)
                    {
                        foreach (var item in Obj_Det_Asg_Ch)
                        {
                            item.Check = true;
                            grvChequeAsignados.SetRowCellValue(contador, colBanco_deposito, cmbBanco.EditValue);
                            //grvChequeAsignados.SetFocusedRowCellValue(colBanco_deposito, cmbBanco.EditValue);
                            //repositoryItemSearchLookUpEdit1. = cmbBanco.SelectedText;
                            contador++;
                            j = 1;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            foreach (var item in Obj_Det_Asg_Ch)
                            {
                                item.Check = false;
                                contador = 0;
                            }
                        }
                        i = 0;
                        j = 0;
                    }

                    gridChequesAsignados.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstadoCobro.EditValue == null )
                {
                    MessageBox.Show("Primero Seleccione un Tipo de Cobro para poder filtrar");
                }
                else
                {
                    var a = ucIn_Sucursal_Bodega1.get_sucursal();

                    checkAplicar.Checked = false;
                    // Carga de Grid
                    Obj_Det_Asg_Ch = new BindingList<vwcxc_cobros_x_cheque_deposito_Info>(Bus_VWCustodioCheque.Get_List_cobros_x_cheque_deposito_x_Depositar(param.IdEmpresa, Convert.ToDateTime(dteFec_Desde.EditValue), Convert.ToDateTime(dteFec_Hasta.EditValue), cmbEstadoCobro.EditValue.ToString(), a.IdSucursal));
                    this.gridChequesAsignados.DataSource = Obj_Det_Asg_Ch;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkAplicar.Focus();
                if (Validar())
                {
                    Depositar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }    
        }

        public Boolean Validar()
        {
            try
            {

                foreach (var item in Obj_Det_Asg_Ch)
                {
                    if (item.Check == true)
                    {
                        if (item.IdBanco_dep == null)
                        {
                            MessageBox.Show("No se puede depositar si no a elegido el banco de destino previamente.");
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public Boolean Depositar()
        {
            try
            {
                string mensaje = "";
                List_Cobro = new List<cxc_cobro_x_EstadoCobro_Info>();
                List_Mov_Caja = new List<caj_Caja_Movimiento_Info>();
                
                //Seleccion de los que estan chequeados en la grilla
                var SeleccionalosChequeados = Obj_Det_Asg_Ch.ToList();
                SeleccionalosChequeados = SeleccionalosChequeados.FindAll(q => q.Check == true);

                // Agrupando por los Bancos y por Fecha
                var AgrupaXIDBanco = from C in SeleccionalosChequeados
                        group C by new { C.IdBanco_dep , C.Fecha_dep}
                            into grouping
                            select new { grouping.Key };

                //Recorriendo la agrupación
                foreach (var item2 in AgrupaXIDBanco)
                {
                    // Recorriendo la lista seleccionada para obtener los infos
                    foreach (var item in SeleccionalosChequeados)
                    {
                        if (item2.Key.IdBanco_dep == item.IdBanco_dep && item2.Key.Fecha_dep == item.Fecha_dep)
                        {

                            if (item.IdEstadoCobro == "PORC")
                            {
                                cxc_cobro_x_EstadoCobro_Info Info_Cobro = new cxc_cobro_x_EstadoCobro_Info();
                                caj_Caja_Movimiento_Info Info_Mov_Caj = new caj_Caja_Movimiento_Info();

                                // Info de Cobro
                                Info_Cobro.IdEmpresa = param.IdEmpresa;
                                Info_Cobro.IdSucursal = item.IdSucursal;
                                Info_Cobro.IdCobro = item.IdCobro;
                                Info_Cobro.IdEstadoCobro = "COBR";
                                Info_Cobro.IdCobro_tipo = item.IdCobro_tipo;
                                Info_Cobro.observacion = "";
                                Info_Cobro.Fecha = DateTime.Now;
                                Info_Cobro.IdUsuario = param.IdUsuario;
                                Info_Cobro.nom_pc = param.nom_pc;
                                Info_Cobro.ip = param.ip;

                                List_Cobro.Add(Info_Cobro);

                                // MOVIMIENTO DE CAJA
                                Info_Mov_Caj.IdEmpresa = item.IdEmpresa;
                                Info_Mov_Caj.IdCaja = (item.IdCaja == null) ? 0 : Convert.ToInt32(item.IdCaja);
                                Info_Mov_Caj.CodMoviCaja = item.CodCaja;
                                Info_Mov_Caj.IdCbteCble = Convert.ToDecimal(item.mcj_IdCbteCble);
                                Info_Mov_Caj.IdTipocbte = Convert.ToInt32(item.mcj_IdTipocbte);

                                List_Mov_Caja.Add(Info_Mov_Caj);

                            }
                        }
                    }
                    // Cambio de estado del Cobro
                    if (Bus_Cobro.GuardarDB_Verifica_si_es_Protestado(List_Cobro, ref mensaje))
                    {
                        // Creando el movimiento contable
                        if (Bus_Cobr.Registra_Contabiliza_MovCaja_x_Cobro_enDeposito(List_Mov_Caja, Convert.ToInt32(item2.Key.IdBanco_dep), Convert.ToDateTime(item2.Key.Fecha_dep), ref mensaje))
                        {
                            List_Cobro = new List<cxc_cobro_x_EstadoCobro_Info>();
                            List_Mov_Caja = new List<caj_Caja_Movimiento_Info>();
                        }
                        else
                        {
                            MessageBox.Show("Error al tratar de registrar el Movimiento de Caja");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de actualizar el estado del cobro");
                        return false;
                    }
                }
                MessageBox.Show("Se Guardo el Deposito correctamente");
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        int flag = 0;
        private void cmbBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                ba_Banco_Cuenta_Info Verif_Banco = new ba_Banco_Cuenta_Info();

                Verif_Banco = (ba_Banco_Cuenta_Info)cmbBanco.Properties.View.GetFocusedRow();

                if (Verif_Banco.IdCtaCble == null)
                {
                    if (flag == 0)
                    {
                        flag = 1;
                        MessageBox.Show("Selecciono un banco sin Cta Ctble. Por favor elija otro Banco");
                        cmbBanco.Text = "";
                    }else
                        flag = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void grvChequeAsignados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colBanco_deposito)
                {
                    if (e.Value != null)
                    {
                        foreach (var item in Obj_Det_Asg_Ch)
                        {
                            if (item.IdBanco_dep != null)
                            {
                                var obtBanco = lista_Banco.First(q => q.IdBanco == Convert.ToInt32(item.IdBanco_dep));

                                if (obtBanco.IdCtaCble == null)
                                {
                                    MessageBox.Show("Selecciono un banco sin Cta Ctble. Por favor elija otro Banco");
                                    item.IdBanco_dep = null;
                                }
                            }
                        }
                    }       
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbBanco_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
    }
}
