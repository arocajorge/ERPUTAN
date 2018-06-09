using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Roles;

namespace Core.Erp.Winform.Controles
{
    public partial class UCRo_Empleado : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Empleado_Bus busEmp = new ro_Empleado_Bus();
        List<ro_Empleado_Info> ListaEmpleados = new List<ro_Empleado_Info>();
        ro_Empleado_Info todos = new ro_Empleado_Info();
        ro_Empleado_Info InfoEmp = new ro_Empleado_Info();
        int idEmpleado = 0;

        public UCRo_Empleado()
        {
            try
            {
                InitializeComponent();
                event_cmbEmpleado_EditValueChanged += UCRo_Empleado_event_cmbEmpleado_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        public void InicializarEmpleado()
        {
            try
            {
                cmbEmpleado.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Visible_cmb_Acciones
        {
            get
            {
                return this.cmb_Acciones.Visible;
            }
            set
            {
                this.cmb_Acciones.Visible = value;
            }
        }

        

        void UCRo_Empleado_event_cmbEmpleado_EditValueChanged(object sender, EventArgs e){}

        public void cargaempleados(Cl_Enumeradores.eTipoFiltro tipo)
        {
            try
            {
                ListaEmpleados = new List<ro_Empleado_Info>();
                if (tipo == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    todos.IdEmpleado = 0;
                    todos.NomCompleto = "Todos";
                    ListaEmpleados.Add(todos);
                    var ListaEmpleadosTemp = busEmp.Obtener_Empleados(param.IdEmpresa);
                    foreach (var item in ListaEmpleadosTemp)
                    {
                        ListaEmpleados.Add(item);
                    }

                    cmbEmpleado.Properties.DataSource = ListaEmpleados;
                    cmbEmpleado.EditValue = 0;
                }
                else if (tipo == Cl_Enumeradores.eTipoFiltro.Normal)
                {
                    ListaEmpleados = busEmp.Obtener_Empleados(param.IdEmpresa);
                    cmbEmpleado.Properties.DataSource = ListaEmpleados;
                
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        
        
        }
        public void CargaEmpleadosxDepxSuc(int idempresa, int idDepartamento, int idSucursal)
        {
            try
            {
                ListaEmpleados = new List<ro_Empleado_Info>();
                if (idDepartamento == 0 && idSucursal == 0)
                {
                    cargaempleados(Cl_Enumeradores.eTipoFiltro.todos);

                }
                else if (idSucursal != 0 && idDepartamento == 0)
                {
                    ListaEmpleados = busEmp.Obtener_Empleados(param.IdEmpresa).FindAll(var => var.IdSucursal == idSucursal);
                    cmbEmpleado.Properties.DataSource = ListaEmpleados;
                }
                else if (idDepartamento != 0 && idSucursal == 0)
                {
                    ListaEmpleados = busEmp.Obtener_Empleados(param.IdEmpresa).FindAll(var => var.IdDepartamento == idDepartamento);
                    cmbEmpleado.Properties.DataSource = ListaEmpleados;

                }
                else
                {

                    ListaEmpleados = busEmp.Obtener_Empleados(param.IdEmpresa).FindAll(
                        var => var.IdDepartamento == idDepartamento && var.IdSucursal == idSucursal);
                    cmbEmpleado.Properties.DataSource = ListaEmpleados;

                }
                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public void setEmpleado(decimal IdEmpleado)
        {
            try
            {
                cmbEmpleado.EditValue = IdEmpleado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        
        
        }
        
        public ro_Empleado_Info getEmpleado()
        {

            try
            {
                ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();

                
                    InfoEmpleado = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                

                return InfoEmpleado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_Empleado_Info();
                
            }
        }

        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                  event_cmbEmpleado_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public delegate void delegate_cmbEmpleado_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbEmpleado_EditValueChanged event_cmbEmpleado_EditValueChanged;

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfoEmp != null && InfoEmp.IdEmpleado != 0)
                {
                    get_EmpleadoInfo();
                    llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                    MessageBox.Show("Seleccione un empleado de la lista", param.Nombre_sistema, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfoEmp != null && InfoEmp.IdEmpleado != 0)
                {
                    get_EmpleadoInfo();
                    llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                    MessageBox.Show("Seleccione un empleado de la lista", param.Nombre_sistema, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                frmRo_Empleado_Mant frm1 = new frmRo_Empleado_Mant();
                frm1.event_frmRo_MantEmpleado_FormClosing += frm1_event_frmRo_MantEmpleado_FormClosing;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm1.set_Empleado(InfoEmp);
                    frm1.set_Accion(Accion);
                }
                else
                    frm1.set_Accion(Accion);

                frm1.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm1_event_frmRo_MantEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaempleados(Cl_Enumeradores.eTipoFiltro.todos);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCRo_Empleado_Load(object sender, EventArgs e)
        {
            try
            {
                cargaempleados(Cl_Enumeradores.eTipoFiltro.Normal);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_EmpleadoInfo(decimal IdEmpleado)
        {
            try
            {
                cmbEmpleado.EditValue = IdEmpleado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ro_Empleado_Info get_EmpleadoInfo()
        {
            try
            {
                InfoEmp = ListaEmpleados.FirstOrDefault(v => v.IdEmpleado == Convert.ToDecimal(cmbEmpleado.EditValue));
                return InfoEmp;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ro_Empleado_Info();
            }

        }

        public int get_IdEmpleado()
        {
            try
            {
                idEmpleado = cmbEmpleado.EditValue=="" ?0 :Convert.ToInt32(cmbEmpleado.EditValue);
                return idEmpleado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }
        }


    }

    
}
