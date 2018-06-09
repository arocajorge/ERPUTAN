using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Prestamos_ImportacionWizard : Form
    {
        public frmRo_Prestamos_ImportacionWizard()
        {
            InitializeComponent();
        }

        #region variables

                        int periodo = 0;
                        double cuota2 = 0;
                        double saldoInicial = 0;
                        double  abonoCapital = 0;
                        double  totalPago =0;
                        double  saldo =0;


        BindingList<ro_prestamo_Info> lista_prestamos = new BindingList<ro_prestamo_Info>();
        BindingList<ro_prestamo_detalle_Info> lista_prestamos_detalle = new BindingList<ro_prestamo_detalle_Info>();

        List<ro_Nomina_Tipoliqui_Info> lista_nomina_liq = new List<ro_Nomina_Tipoliqui_Info>();
        List<ro_Nomina_Tipo_Info> lista_nomina = new List<ro_Nomina_Tipo_Info>();
        List<ro_Empleado_Info> listaEmpleado = new List<ro_Empleado_Info>();
        List<ro_Catalogo_Info> lista_catalogo = new List<ro_Catalogo_Info>();
        List<ro_rubro_tipo_Info> listaRubro = new List<ro_rubro_tipo_Info>();
        ro_prestamo_Bus bus_prestamos = new ro_prestamo_Bus();
        ro_Nomina_Tipo_Bus bus_nomina = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus bus_nomina_tipo_liq = new ro_Nomina_Tipoliqui_Bus();
        ro_Empleado_Bus busEmpleado = new ro_Empleado_Bus();
        ro_Catalogo_Bus BusPrestamo_Pago = new ro_Catalogo_Bus();
        ro_rubro_tipo_Bus bus_rubro = new ro_rubro_tipo_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                if (e.Page.Name == "PageEmpleado")// generar detalle
                {
                    foreach (var item in lista_prestamos)
                    {
                        if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "SEM")
                        {


                            this.CalculoPrestamoSinInteres(item,7,  item.Tipo_Calculo);
                            
                        }
                        
                    }
                }
              
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_Prestamos_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;

                }
            }
            catch (Exception ex)
            {
                
            }
        }
        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });

                ro_prestamo_Info newRow = new ro_prestamo_Info();
                if (rowData.Count() >= 3) //return false;          
                {


                    string Cedula = Convert.ToString(rowData[0]);
                    double MontoSolicitado = Convert.ToDouble(rowData[2]);
                    double NumCuota = Convert.ToDouble(rowData[3]);
                    string MetodoCalculo = Convert.ToString(rowData[4]);  
                    DateTime FechaPrimerPago = Convert.ToDateTime(rowData[5]);
                    string Observacion = Convert.ToString(rowData[6]);

                    if (Cedula.Length < 10)
                        Cedula = "0" + Cedula;
                    ro_Empleado_Info info_empleado = new ro_Empleado_Info();
                    info_empleado = listaEmpleado.Where(v => v.pe_cedulaRuc == Cedula).FirstOrDefault();

                    if (!string.IsNullOrWhiteSpace(Cedula.ToString()))
                    {
                        ro_prestamo_Info Info_prestamo = new ro_prestamo_Info();
                        if (fx_Verificar_Reg_Repetidos(Info_prestamo, false, 0))
                        {

                            newRow.IdEmpresa = param.IdEmpresa;
                            newRow.IdNomina_Tipo =Convert.ToInt32( cmbnomina.EditValue);
                            newRow.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                            newRow.MontoSol = MontoSolicitado;
                            newRow.Fecha_PriPago = FechaPrimerPago;
                            newRow.Observacion = Observacion;
                            newRow.Tipo_Calculo = MetodoCalculo;
                           

                        }
                        else
                        {
                            //  MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                            return false;
                        }



                        lista_prestamos.Add(newRow);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                        return false;

                    }

                }
                gridControl_Prestamos.DataSource = lista_prestamos;
                gridControl_Prestamos.RefreshDataSource();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        private Boolean fx_Verificar_Reg_Repetidos(ro_prestamo_Info Info_det, Boolean eliminar, int tipo)
        {
            try
            {/*
                int cont = 0;



                if (banderaCargaBatch)
                {
                    cont = (from C in BindList_Ing_egr_inve_det
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }
                else
                {
                    cont = (from C in lista_IngEgrInv
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }


                if (cont == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                        MessageBox.Show("El producto con la misma cantidad y costo  ya se encuentra ingresado, se procederá con su eliminación.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra ingresado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return false;

                }
              * */

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listaEmpleado=busEmpleado.Get_List_Empleado_x_Nomina(param.IdEmpresa,Convert.ToInt32(cmbnomina.EditValue));

                lista_nomina_liq = bus_nomina_tipo_liq.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = lista_nomina_liq;

                cmb_empleadoAprueba.Properties.DataSource = listaEmpleado;



                listaRubro = bus_rubro.ConsultaRubrosPrestamo(param.IdEmpresa);
                cmb_Rubro.Properties.DataSource = listaRubro;

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void CargarCombo()
        {
            try
            {
                cmbnomina.Properties.DataSource = bus_nomina.Get_List_Nomina_Tipo(param.IdEmpresa);
                // Cargando combo Periodo de pago
                lista_catalogo = BusPrestamo_Pago.Get_List_CatalogoTipoPago();
                this.cmbPeriodoPago.Properties.DataSource = lista_catalogo;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_Prestamos_ImportacionWizard_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void CalculoPrestamoSinInteres(ro_prestamo_Info info_Prestamo, int numero, string tipoCalculo)
        {
            try
            {


                DateTime fechaPago=info_Prestamo.Fecha_PriPago;

              
                for (int i = 1; i <= periodo; i++)
                {
                    ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();
                    //para interes = 0
                    if (tipoCalculo=="CUOTA")
                    {
                        cuota2 = info_Prestamo.MontoSol / periodo;
                    }
                    else
                    {
                        cuota2 = Convert.ToDouble(info_Prestamo.NumCuotas);
                    }
                    if (i == 1)
                    {
                        saldoInicial = info_Prestamo.MontoSol;
                        abonoCapital = 0;
                        totalPago = Math.Round(cuota2, 2);
                        saldo = Math.Round((saldoInicial - totalPago), 2);
                    }
                    else
                    {
                        if (i > 1 && i <= periodo - 1)
                        {
                            saldoInicial = Math.Round(saldo, 2);
                            abonoCapital = 0;
                            totalPago = Math.Round(cuota2, 2);
                            saldo = Math.Round((saldoInicial - totalPago), 2);
                        }

                        else
                        {
                            if (i == periodo)
                            {
                                saldoInicial = Math.Round(saldo, 2);
                                abonoCapital = 0;
                                totalPago = Math.Round(cuota2, 2);
                                saldo = Math.Round((saldoInicial - totalPago), 2);

                                if (saldo <= 1)
                                {
                                    totalPago = totalPago + saldo;
                                    saldo = 0;
                                }
                                else
                                {// si el saldo es mayor ha uno

                                    i = i - 1;


                                }

                            }
                        }
                    }

                    item.NumCuota = i;
                    item.SaldoInicial = saldoInicial;
                    item.AbonoCapital = abonoCapital;
                    if (saldo < 1 && saldo > 0)
                    {
                        totalPago = totalPago + saldo;
                    }


                    item.TotalCuota = totalPago;
                    item.Saldo = saldo;
                    item.EstadoPago = "PEN";
                    item.FechaPago = fechaPago;
                    item.Observacion_det = "";
                    item.Estado = "A";
                    item.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);

                    lista_prestamos_detalle.Add(item);
                    fechaPago = fechaPago.AddDays(numero);

                    if (i == periodo)
                    {
                        if (saldo < 1)
                        {
                            item.Saldo = 0;
                        }
                        else
                        {
                            periodo = periodo + 1;
                        }
                    }
                }
                this.gridControl_Prestamos.DataSource = lista_prestamos_detalle;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
