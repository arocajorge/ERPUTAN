using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Winform.SeguridadAcceso;

namespace Core.Erp.Winform.Controles
{
    public partial class UCSeg_Propiedades : UserControl
    {

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        String MensajeError = String.Empty;

        //--Info
        public seg_Menu_Categoria_Info Info_Menu_Categoria_Seleccionado = new seg_Menu_Categoria_Info();
        public seg_Menu_Pagina_Info Info_seg_Menu_Pagina_Seleccionado = new seg_Menu_Pagina_Info();
        public seg_Menu_Grupo_Info Info_seg_Menu_Grupo_Seleccionado = new seg_Menu_Grupo_Info();
        public seg_Menu_Item_Info Info_seg_Menu_Item_Seleccionado = new seg_Menu_Item_Info();
        
        //--Bus
        seg_Menu_Item_Bus BusItem = new seg_Menu_Item_Bus();
        seg_Menu_Pagina_Bus BusPagina = new seg_Menu_Pagina_Bus();
        seg_Menu_Grupo_Bus BusGrupo = new seg_Menu_Grupo_Bus();
        seg_Menu_Categoria_Bus BusCategoria = new seg_Menu_Categoria_Bus();

        List<string> List_Formularios = new List<string>();
        tb_sis_reporte_Bus busReporte = new tb_sis_reporte_Bus();
        List<tb_sis_reporte_Info> List_Reportes = new List<tb_sis_reporte_Info>();
        #endregion       

        public UCSeg_Propiedades()
        {
            InitializeComponent();            
        }       

        #region Asignar Propiedades
        public void Set_Propiedades(seg_Menu_Categoria_Info InfoPropiedades)
        {
            try
            {
                propertyGridControlMenu.SelectedObject = InfoPropiedades;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_Propiedades(seg_Menu_Pagina_Info InfoPropiedades)
        {
            try
            {
                propertyGridControlPagina.SelectedObject = InfoPropiedades;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_Propiedades(seg_Menu_Grupo_Info InfoPropiedades)
        {
            try
            {
                propertyGridControlGrupo.SelectedObject = InfoPropiedades;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_Propiedades(seg_Menu_Item_Info InfoPropiedades)
        {
            try
            {
                propertyGridControlItem.SelectedObject = null;
                propertyGridControlItem.SelectedObject = InfoPropiedades;
                if (InfoPropiedades!=null)
                {
                    if (InfoPropiedades.Tipo == "Formulario")
                    {
                        categoryFormulario.Visible = true;
                        categoryReporte.Visible = false;
                    }
                    else
                    {
                        categoryFormulario.Visible = false;
                        categoryReporte.Visible = true;
                    }
                }
                
                CargarListas();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region Obtener Propiedades
        public seg_Menu_Categoria_Info Get_Propiedades_Categoria { get { return (seg_Menu_Categoria_Info) propertyGridControlMenu.SelectedObject; } }
        public seg_Menu_Pagina_Info Get_Propiedades_Pagina { get { return (seg_Menu_Pagina_Info)propertyGridControlPagina.SelectedObject; } }
        public seg_Menu_Grupo_Info Get_Propiedades_Grupo { get { return (seg_Menu_Grupo_Info)propertyGridControlGrupo.SelectedObject; } }
        public seg_Menu_Item_Info Get_Propiedades_Item { get { return (seg_Menu_Item_Info)propertyGridControlItem.SelectedObject; } }
        #endregion

        #region Mostrar Propiedades
        public void Mostrar_Propiedades(ETipoObjectoSelect Objeto)
        {
            try
            {
                switch (Objeto)
                {
                    case ETipoObjectoSelect.Categoria:
                        if (!TabControlPropiedades.TabPages.Contains(tpMenu))
                            TabControlPropiedades.TabPages.Add(tpMenu);

                        if (TabControlPropiedades.TabPages.Contains(tpPagina))
                            TabControlPropiedades.TabPages.Remove(tpPagina);

                        if (TabControlPropiedades.TabPages.Contains(tpGrupo))
                            TabControlPropiedades.TabPages.Remove(tpGrupo);

                        if (TabControlPropiedades.TabPages.Contains(tpItem))
                            TabControlPropiedades.TabPages.Remove(tpItem);
                        break;
                    case ETipoObjectoSelect.Pagina:
                        if (!TabControlPropiedades.TabPages.Contains(tpPagina))
                            TabControlPropiedades.TabPages.Add(tpPagina);

                        if (TabControlPropiedades.TabPages.Contains(tpMenu))
                            TabControlPropiedades.TabPages.Remove(tpMenu);

                        if (TabControlPropiedades.TabPages.Contains(tpGrupo))
                            TabControlPropiedades.TabPages.Remove(tpGrupo);

                        if (TabControlPropiedades.TabPages.Contains(tpItem))
                            TabControlPropiedades.TabPages.Remove(tpItem);
                        break;
                    case ETipoObjectoSelect.Grupo:
                        if (!TabControlPropiedades.TabPages.Contains(tpGrupo))
                            TabControlPropiedades.TabPages.Add(tpGrupo);

                        if (TabControlPropiedades.TabPages.Contains(tpPagina))
                            TabControlPropiedades.TabPages.Remove(tpPagina);

                        if (TabControlPropiedades.TabPages.Contains(tpMenu))
                            TabControlPropiedades.TabPages.Remove(tpMenu);

                        if (TabControlPropiedades.TabPages.Contains(tpItem))
                            TabControlPropiedades.TabPages.Remove(tpItem);
                        break;
                    case ETipoObjectoSelect.Item:
                        if (!TabControlPropiedades.TabPages.Contains(tpItem))
                            TabControlPropiedades.TabPages.Add(tpItem);

                        if (TabControlPropiedades.TabPages.Contains(tpPagina))
                            TabControlPropiedades.TabPages.Remove(tpPagina);

                        if (TabControlPropiedades.TabPages.Contains(tpGrupo))
                            TabControlPropiedades.TabPages.Remove(tpGrupo);

                        if (TabControlPropiedades.TabPages.Contains(tpMenu))
                            TabControlPropiedades.TabPages.Remove(tpMenu);
                        
                            CargarListas();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region Grabar Propiedades
        private void propertyGridControlMenu_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            try
            {
                Info_Menu_Categoria_Seleccionado = (seg_Menu_Categoria_Info)propertyGridControlMenu.SelectedObject;                
                BusCategoria.ModificarDB(Info_Menu_Categoria_Seleccionado, ref MensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void propertyGridControlPagina_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            try
            {
                Info_seg_Menu_Pagina_Seleccionado = (seg_Menu_Pagina_Info)propertyGridControlPagina.SelectedObject;
                BusPagina.ModificarDB(Info_seg_Menu_Pagina_Seleccionado, ref MensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void propertyGridControlGrupo_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            try
            {
                Info_seg_Menu_Grupo_Seleccionado = (seg_Menu_Grupo_Info)propertyGridControlGrupo.SelectedObject;
                BusGrupo.ModificarDB(Info_seg_Menu_Grupo_Seleccionado, ref MensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void propertyGridControlItem_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            try
            {
                Info_seg_Menu_Item_Seleccionado = (seg_Menu_Item_Info)propertyGridControlItem.SelectedObject;
                BusItem.ModificarDB(Info_seg_Menu_Item_Seleccionado, ref MensajeError);

                if (e.Row == rownom_Asembly_I)
                {
                    CargarListas();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion       

        #region Metodos personalizados
        private void CargarListas()
        {
            try
            {
                List_Formularios.Clear();
                string NombreFormulario = Info_seg_Menu_Item_Seleccionado.nom_Formulario;
                string Nombre_Asamble = Info_seg_Menu_Item_Seleccionado.nom_Asembly;
                string nombre_dll = "";
                if (!string.IsNullOrEmpty(NombreFormulario))
                {
                    nombre_dll = Nombre_Asamble;
                    System.Reflection.Assembly Ensamblado;
                    Ensamblado = System.Reflection.Assembly.LoadFrom(nombre_dll);
                    
                    foreach (Type type in Ensamblado.GetTypes())
                    {
                        List_Formularios.Add(type.FullName);
                    }
                    
                }
                cmb_Formularios.DataSource = List_Formularios;

                List_Reportes = busReporte.Get_list_sis_reporte();
                cmb_Reportes.DataSource = List_Reportes;
                cmb_Reportes.DisplayMember = "Class_NomReporte";
                cmb_Reportes.ValueMember = "CodReporte";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

    }
}
