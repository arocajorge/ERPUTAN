using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Registro_Dias_Faltados_Mant : Form
    {


        #region Declaracion de variables

        
       


        string MensError = "";
        decimal IDNovedad = 0;


          ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();



        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ro_Empleado_Info> ListaEmpleado = new List<ro_Empleado_Info>();
        List<ro_Catalogo_Info> ListCatalogo = new List<ro_Catalogo_Info>();

        ro_Catalogo_Info InfoCatalogo = new ro_Catalogo_Info();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ro_HistoricoSueldo_Bus BusSueldo = new ro_HistoricoSueldo_Bus();
        ro_Catalogo_Bus BusCatalogo = new ro_Catalogo_Bus();
        ro_DiasFaltados_x_Empleado_Info InfoGrabar = new ro_DiasFaltados_x_Empleado_Info();
        ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();
        ro_DiasFaltados_x_Empleado_Info InfoGeneral = new ro_DiasFaltados_x_Empleado_Info();
        ro_DiasFaltados_x_Empleado_Bus BusDiasFaltados = new ro_DiasFaltados_x_Empleado_Bus();


        ro_Empleado_Novedad_Info InfoNovedadCab = new ro_Empleado_Novedad_Info();
        ro_Empleado_Novedad_Det_Info InfoNovedadDet = new ro_Empleado_Novedad_Det_Info();

        ro_Empleado_Novedad_Bus BusNovedaCab = new ro_Empleado_Novedad_Bus();
        ro_Empleado_Novedad_Det_Bus BusNovedadDet = new ro_Empleado_Novedad_Det_Bus();

        #endregion




        public frmRo_Registro_Dias_Faltados_Mant()
        {
            try
            {
                InitializeComponent();
                CargarCombo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frmRo_Registro_Dias_Faltados_Mant_Event_frmRo_Registro_Dias_Faltados_Mant(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Event_frmRo_Registro_Dias_Faltados_Mant +=frmRo_Registro_Dias_Faltados_Mant_Event_frmRo_Registro_Dias_Faltados_Mant;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpObservacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRo_Registro_Dias_Faltados_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {

                    case Cl_Enumeradores.eTipo_action.grabar:
                          TxtValorDesc.Visible = false;
                          TxtDiasDescuenta.Visible = false;
                          LbValor.Visible = false;
                          LbDiasDescontar.Visible = false;
                          TxtDiasDescuenta.Visible = false;


                 txtValorhora.Properties.ReadOnly=true;
                 TxtValorDesc.Properties.ReadOnly = true;
                 TxtDepartamento.Properties.ReadOnly = true;
                 TxtCargo.Properties.ReadOnly = true;
                 TxtCedula.Properties.ReadOnly = true;
                 txtValorhora.Properties.ReadOnly = true;
                 TxtDiasDescuenta.EditValue = 0;


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;


                         listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void Cmbempleados_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                InfoEmpleado = (ro_Empleado_Info)Cmbempleados.Properties.View.GetFocusedRow();
                if (InfoEmpleado == null)
                {
                    InfoEmpleado = ListaEmpleado.Where(q => q.IdEmpleado == InfoGeneral.IdEmpleado).FirstOrDefault();

                }
                

                double Sueldo = BusSueldo.GetSueldoActual(param.IdEmpresa, InfoEmpleado.IdEmpleado);
                TxtCedula.Text = InfoEmpleado.InfoPersona.pe_cedulaRuc;
                TxtCargo.Text = InfoEmpleado.cargo_Descripcion;

                txtValorhora.Text = Convert.ToString(Math.Round(Sueldo / 240, 2));
                TxtDepartamento.Text = InfoEmpleado.de_descripcion;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public Cl_Enumeradores.eTipo_action  Accion { get; set; }
        public void SetAccion(Cl_Enumeradores.eTipo_action Acc)
        {
            try
            {
                Accion = Acc;

                switch (Acc)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }


        public bool Get()
        {
            try
            {
                InfoGrabar.IdEmpresa = param.IdEmpresa;
                InfoGrabar.IdEmpleado =(int) InfoEmpleado.IdEmpleado;
                InfoGrabar.CodCatalogo = InfoCatalogo.CodCatalogo;
                InfoGrabar.FechaFaltaDesde = dtpFechadesde.Value;
                InfoGrabar.FechaFaltaHasta = dtpFechaHasta.Value;
                InfoGrabar.DiasFaltados = CmbdiasFaltas.Text;
                if (InfoCatalogo.IdCatalogo == 218)
                {
                    InfoGrabar.ValorDescuentaRol =Convert.ToDecimal( TxtValorDesc.Text);
                    InfoGrabar.FechaDescuentaRol = dtp_Fecha_descuento.Value;
                    InfoGrabar.DiasFaltados = CmbdiasFaltas.Text;
                    InfoGrabar.DiasDescuento =Convert.ToInt32( TxtDiasDescuenta.Text);
                }

                if (InfoCatalogo.IdCatalogo == 219)
                {

                    InfoGrabar.DiasFaltados = CmbdiasFaltas.Text;
                    InfoGrabar.DiasDescuento = Convert.ToInt32(TxtDiasDescuenta.Text);
                }
                InfoGrabar.IdUsuario = param.IdUsuario;
                InfoGrabar.estado = "A";
                InfoGrabar.FechaFaltaDesde = dtpFechadesde.Value;
                InfoGrabar.FechaFaltaHasta = dtpFechaHasta.Value;
                InfoGrabar.Observacion = TxtObservacion.Text;
                InfoGrabar.Fecha_Transac = DateTime.Now;
                InfoGrabar.CatalogoDescripcion = InfoCatalogo.ca_descripcion;
                // cabecera de la Novedad

                if (InfoCatalogo.IdCatalogo ==218)
                {
                    InfoNovedadCab.IdEmpresa = param.IdEmpresa;
                    InfoNovedadCab.IdEmpleado = InfoEmpleado.IdEmpleado;
                    InfoNovedadCab.IdNomina_Tipo = InfoEmpleado.IdNomina_Tipo;
                    if (InfoEmpleado.IdNomina_Tipo == 2)
                    {
                        InfoNovedadCab.IdNomina_TipoLiqui = 1;
                    }
                    else
                    {
                     InfoNovedadCab.IdNomina_TipoLiqui = 2;
                    }
                    InfoNovedadCab.Fecha =  dtp_Fecha_descuento.Value;
                    InfoNovedadCab.TotalValor =Convert.ToDouble( TxtValorDesc.Text);
                    InfoNovedadCab.Fecha_PrimerPago =  dtp_Fecha_descuento.Value;
                    InfoNovedadCab.Fecha_Transac = DateTime.Now;
                    InfoNovedadCab.IdUsuario = param.IdUsuario;
                    InfoNovedadCab.Estado = "A";

                    // DETALLE DE LA NOVEDAD

                    InfoNovedadDet.IdEmpresa = param.IdEmpresa;
                    InfoNovedadDet.IdEmpleado = InfoEmpleado.IdEmpleado;
                    InfoNovedadDet.IdRubro = "1";
                    InfoNovedadDet.FechaPago =  dtp_Fecha_descuento.Value; 
                    InfoNovedadDet.Valor = Convert.ToDouble(TxtValorDesc.Text);
                    InfoNovedadDet.EstadoCobro = "PEN";
                    InfoNovedadDet.Observacion = TxtObservacion.Text;
                    InfoNovedadDet.Estado = "A";


                }



                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }



        public void Set( ro_DiasFaltados_x_Empleado_Info Info)
        {
            try
            {
                InfoGeneral = Info;
                string DiasDescuento = "";
                Cmbempleados.EditValue = Info.IdEmpleado;
                CmbCatalogoDiasFaltados.EditValue = Info.CodCatalogo;
                dtpFechadesde.Value = Info.FechaFaltaDesde;
                dtpFechaHasta.Value = Info.FechaFaltaHasta;
                TxtObservacion.Text = Info.Observacion;
                if (Info.CodCatalogo == "218")
                {
                    TxtValorDesc.Text =Convert.ToString(Info.ValorDescuentaRol);
                    CmbdiasFaltas.Text = Info.DiasFaltados;
                    DiasDescuento=Convert.ToString(Info.DiasDescuento);
                    TxtDiasDescuenta.EditValue = DiasDescuento;
                }

                if (Info.CodCatalogo == "219")
                {

                    CmbdiasFaltas.Text = Info.DiasFaltados;
                    TxtDiasDescuenta.Text =Convert.ToString( Info.DiasDescuento);
                }

                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void CmbCatalogoDiasFaltados_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoCatalogo = (ro_Catalogo_Info)CmbCatalogoDiasFaltados.Properties.View.GetFocusedRow();

                if (InfoCatalogo == null)
                {
                    InfoCatalogo = ListCatalogo.Where(q=>q.CodCatalogo==InfoGeneral.CodCatalogo).FirstOrDefault();
                }
               
                if (InfoCatalogo.IdCatalogo == 218)
                {
                    TxtValorDesc.Visible = true;
                    LbDiasDescontar.Visible = true;
                    LbValor.Visible = true;
                    TxtDiasDescuenta.Visible = true;
                }
                else if (InfoCatalogo.IdCatalogo == 219)
                {
                    TxtDiasDescuenta.Visible = true;
                    LbDiasDescontar.Visible = true;



                    TxtValorDesc.Visible = false;
                   
                    LbValor.Visible = false;

                }


                else
                {
                    TxtValorDesc.Visible = false;
                    txtValorhora.Visible = false;
                    TxtDiasDescuenta.Visible = false;
                    LbValor.Visible = false;
                    LbDiasDescontar.Visible = false;
                    TxtDiasDescuenta.Visible = false;

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtDiasDescuenta_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (TxtDiasDescuenta.Text != "")
                {
                    try
                    {
                        double ValorDescontar = Math.Round((Convert.ToDouble(txtValorhora.Text) * Convert.ToDouble(TxtDiasDescuenta.Text)) * 8, 2);
                        TxtValorDesc.Text = Convert.ToString(ValorDescontar);
                    }
                    catch (Exception)
                    {
                        
                        
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        public void Grbar()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (!Validar())
                        {
                            return;
                        }

                        Get();
                        

                        
                            if (InfoCatalogo.IdCatalogo == 218)
                            {
                                if (BusNovedaCab.GrabarDB(InfoNovedadCab, ref IDNovedad, ref MensError))// grabo cab novedad
                                {
                                    InfoNovedadDet.IdNovedad = IDNovedad;
                                    if (BusNovedadDet.GrabarDB(InfoNovedadDet, ref MensError))// grabo detale novedad
                                    {
                                       InfoGrabar.IdNovedad= (int)IDNovedad;
                                        if (BusDiasFaltados.GuardarDB(InfoGrabar))// grabo reg dias faltados
                                        {

                                            MessageBox.Show("Se Guardo Correctamente la Informacion", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.None);
                                            Limpiar();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al Guardar la Informacion ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                        }
                                    }
                                   
                                }

                        }
                        else
                        {

                            if (BusDiasFaltados.GuardarDB(InfoGrabar))// grabo reg dias faltados
                            {
                                MessageBox.Show("Se Guardo Correctamente la Informacion", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Limpiar();
                            
                            }
                            else
                            {
                                MessageBox.Show("Error al Guardar la Informacion ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        break;


                    case Cl_Enumeradores.eTipo_action.actualizar:
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Get();

                        FrmGe_MotivoAnulacion Frm = new FrmGe_MotivoAnulacion();

                        Frm.ShowDialog();
                        InfoGrabar.MotiAnula = Frm.motivoAnulacion;
                        InfoNovedadCab.MotiAnula = Frm.motivoAnulacion;
                        

                        // seteo datos de anulacion
                        InfoGrabar.IdUsuarioUltAnu = param.IdUsuario;
                        InfoGrabar.Fecha_UltAnu = DateTime.Now;

                        InfoNovedadCab.IdUsuarioUltAnu = param.IdUsuario;
                        InfoNovedadCab.Fecha_UltAnu = DateTime.Now;
                        InfoNovedadCab.Estado = "I";

                        InfoNovedadDet.Estado = "I";

                        InfoGrabar.IdFalta = InfoGeneral.IdFalta;
                        if (InfoGeneral.IdNovedad > 0)
                        {
                            InfoNovedadCab.IdNovedad = (int)InfoGeneral.IdNovedad;
                        }
                        if (InfoCatalogo.IdCatalogo == 218)
                        {
                            if (BusNovedaCab.AnularDB(InfoNovedadCab))// anulo cab novedad
                            {
                                InfoNovedadDet.IdNovedad =(int) InfoGeneral.IdNovedad;
                                if (BusNovedadDet.AnularDB(InfoNovedadDet))// anulo detale novedad
                                {
                                    if (BusDiasFaltados.Anular(InfoGrabar))// anulo reg dias faltados
                                    {

                                        MessageBox.Show("Se Guardo Correctamente la Informacion", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.None);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Guardar la Informacion ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                    }
                                }

                            }


                        }
                        else
                        {
                            if (BusDiasFaltados.Anular(InfoGrabar))
                            {
                                MessageBox.Show("Se Anulo Correctamente el Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.None);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se Pudo Anular el Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grbar();
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                {
                    return;
                }


                Grbar();
                this.Close();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }


        public void CargarCombo()
        {
            try
            {
                ListaEmpleado = BusEmpleado.Get_List_Empleado_x_Nomina(param.IdEmpresa);
                Cmbempleados.Properties.DataSource = ListaEmpleado;


                ListCatalogo = BusCatalogo.Get_List_Catalogo_x_DiasFalta(param.IdEmpresa);
                CmbCatalogoDiasFaltados.Properties.DataSource = ListCatalogo;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        public bool Validar()
        { 
            bool BanderaSiCorrcto = true;
            try
            {
                if (Cmbempleados.EditValue ==null || Cmbempleados.Text == "")
                {
                    MessageBox.Show("Seleccione un empleado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BanderaSiCorrcto = false;
                    return BanderaSiCorrcto;
                }


                if (CmbCatalogoDiasFaltados.EditValue == null || CmbCatalogoDiasFaltados.Text == "")
                {
                    MessageBox.Show("Selecione un Motivo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BanderaSiCorrcto = false;
                    return BanderaSiCorrcto;
                }

                if (InfoCatalogo.IdCatalogo == 218)
                {
                    if (TxtDiasDescuenta.Text == "")
                    {
                        MessageBox.Show("ingrese los dias a Descontar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BanderaSiCorrcto = false;
                        return BanderaSiCorrcto;
                    }
                }


                if (CmbdiasFaltas.Text == "")
                {
                    MessageBox.Show("Sellcione los dias de Falta", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BanderaSiCorrcto = false;
                    return BanderaSiCorrcto;
                }



                if (TxtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese una Observacion", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BanderaSiCorrcto = false;
                    return BanderaSiCorrcto;
                }

                return BanderaSiCorrcto;
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grbar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Registro_Dias_Faltados_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //frmRo_Registro_Dias_Faltados_Mant_Event_frmRo_Registro_Dias_Faltados_Mant(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }



        public void Limpiar()
        {
            try
            {
                Cmbempleados.EditValue = null;
                Cmbempleados.Properties.DataSource = ListaEmpleado;
                txtValorhora.Text = "";
                TxtValorDesc.Text = "";
                TxtValorDesc.Text = "";
                TxtDepartamento.Text = "";
                TxtCargo.Text = "";
                TxtCedula.Text = "";
                TxtObservacion.Text = "";
                TxtDiasDescuenta.Text="";

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            
           try
           {
               ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
               cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

           }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
             try
           {
                 }
           catch (System.Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
    }
}
