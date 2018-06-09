using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
   public class tb_sis_formulario_Data
    {

        string mensaje = "";

        public Boolean GuardarDB(tb_sis_formulario_Info Info)
        {
            try
            {
                List<tb_sis_formulario_Info> Lst = new List<tb_sis_formulario_Info>();
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = new tb_sis_formulario();

                    Address.IdFormulario = Info.IdFormulario ="Frm"+ Info.CodModulo + "_"+Get_Numero(Info.CodModulo);

                    Address.cod_Formulario = (Info.cod_Formulario == "" || Info.cod_Formulario == null) ? Address.IdFormulario : Info.cod_Formulario;

                    Address.nom_Formulario = Info.nom_Formulario;
                    Address.CodModulo = Info.CodModulo;
                    Address.Text = Info.Text;
                    Address.observacion = Info.observacion;
                    Address.estado = Info.estado;
                    Address.nom_Asembly = Info.nom_Asembly;

                    Context.tb_sis_formulario.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_sis_formulario_Info> Get_List_formulario()
        {
            try
            {
                List<tb_sis_formulario_Info> Lst = new List<tb_sis_formulario_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_formulario
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_formulario_Info Obj = new tb_sis_formulario_Info();

                    Obj.IdFormulario = item.IdFormulario;
                    Obj.cod_Formulario = item.cod_Formulario;


                    Obj.nom_Formulario = item.nom_Formulario;
                    Obj.CodModulo = item.CodModulo;
                    Obj.Text = item.Text;
                    Obj.observacion = item.observacion;
                    Obj.estado = item.estado;
                    Obj.nom_Asembly = item.nom_Asembly;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_sis_formulario_Info> Get_List_formulario_x_Modulo(List<tb_modulo_Info> lstModulo)
        {
            try
            {
                List<tb_sis_formulario_Info> Lst = new List<tb_sis_formulario_Info>();
                var list = new List<string>();
                foreach (var item in lstModulo)
                {
                    list.Add(item.CodModulo);
                }
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_formulario
                            where list.Contains(q.CodModulo)
                            select q;


                foreach (var item in Query)
                {
                    tb_sis_formulario_Info Obj = new tb_sis_formulario_Info();


                    Obj.IdFormulario = item.IdFormulario;
                    Obj.cod_Formulario = item.cod_Formulario;
                    Obj.nom_Formulario = item.nom_Formulario;
                    Obj.CodModulo = item.CodModulo;
                    Obj.Text = item.Text;
                    Obj.observacion = item.observacion;
                    Obj.estado = item.estado;
                    Obj.nom_Asembly = item.nom_Asembly;


                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_sis_formulario_Info> Get_List_formulario(string CodModulo)
        {
            try
            {
                List<tb_sis_formulario_Info> Lst = new List<tb_sis_formulario_Info>();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                var Query = from q in oEnti.tb_sis_formulario
                            where q.CodModulo == CodModulo
                            select q;

                foreach (var item in Query)
                {
                    tb_sis_formulario_Info Obj = new tb_sis_formulario_Info();

                    Obj.IdFormulario = item.IdFormulario;
                    Obj.cod_Formulario = item.cod_Formulario;
                    Obj.nom_Formulario = item.nom_Formulario;
                    Obj.CodModulo = item.CodModulo;
                    Obj.Text = item.Text;
                    Obj.observacion = item.observacion;
                    Obj.estado = item.estado;
                    Obj.nom_Asembly = item.nom_Asembly;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return new List<tb_sis_formulario_Info>();
            }
        }

        public tb_sis_formulario_Info Get_Info_formulario(string IdFormulario)
        {
            EntitiesGeneral oEnti = new EntitiesGeneral();
            try
            {
                tb_sis_formulario_Info Info = new tb_sis_formulario_Info();
                var Objeto = oEnti.tb_sis_formulario.FirstOrDefault(var => var.IdFormulario == IdFormulario);
                if (Objeto != null)
                {

                    Info.IdFormulario = Objeto.IdFormulario;
                    Info.cod_Formulario = Objeto.cod_Formulario;
                    Info.nom_Formulario = Objeto.nom_Formulario;
                    Info.CodModulo = Objeto.CodModulo;
                    Info.Text = Objeto.Text;
                    Info.observacion = Objeto.observacion;
                    Info.estado = Objeto.estado;
                    Info.nom_Asembly = Objeto.nom_Asembly;


                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Numero(string CodModulo)
        {
            try
            {
                string num = "";
                EntitiesGeneral oEnti = new EntitiesGeneral();

                var c = oEnti.Database.SqlQuery<int>("select max(substring(IdFormulario,LEN(IdFormulario)-2,3) )+1 from tb_sis_formulario where CodModulo='" + CodModulo + "' ");
                try
                {
                    var c2 = c.First();
                    if (c2 == null)
                        num = "001";
                    else if (Convert.ToDecimal(c2) < 10)
                        num = "00" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 99)
                        num = "0" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 999)
                        num = Convert.ToString(c2);
                    else
                        num = null;
                }
                catch (Exception)
                {
                    return "001";
                }
                return num;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_sis_formulario_Info info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_formulario.FirstOrDefault(minfo => minfo.IdFormulario == info.IdFormulario);
                    if (contact != null)
                    {
                        contact.cod_Formulario = info.cod_Formulario;
                        contact.nom_Formulario = info.nom_Formulario;
                        contact.CodModulo = info.CodModulo;
                        contact.Text = info.Text;
                        contact.observacion = info.observacion;
                        contact.estado = info.estado;
                        contact.nom_Asembly = info.nom_Asembly;

                        
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
