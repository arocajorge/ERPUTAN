using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
using System.ComponentModel;


namespace Core.Erp.Data.Academico
{
   public class Aca_Rubro_x_Aca_Periodo_Lectivo_Data
    {
       string mensaje = "";

       #region "Get"

       public BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Get_List_rubro_x_periodo(int IdIstitucuion, int IdRubro)
        {
            BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> ListRubroxPeriodo = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
            Aca_Rubro_x_Aca_Periodo_Lectivo_Info RubroxPeriodo_Info;
            try
            {
                using (Entities_Academico db = new Entities_Academico())
                {
                    var estudiante_alergia = from e in db.vwAca_Rubro_x_Aca_Periodo_Lectivo
                                             where e.IdInstitucion == IdIstitucuion
                                             && e.IdRubro == IdRubro
                                             orderby e.IdPeriodoLectivo
                                             select e;
                    foreach (var item in estudiante_alergia)
                    {
                        RubroxPeriodo_Info = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();

                        RubroxPeriodo_Info.IdInstitucion_per = item.IdInstitucion;

                        RubroxPeriodo_Info.IdAnioLectivo = item.IdAnioLectivo;

                        RubroxPeriodo_Info.IdPeriodo = item.IdPeriodoLectivo;
                        RubroxPeriodo_Info.IdRubro = item.IdRubro;
                        RubroxPeriodo_Info.Valor = Convert.ToDouble(item.Valor);
                        RubroxPeriodo_Info.Estado = item.Estado;
                        RubroxPeriodo_Info.Existe_en_Base = item.Existe_en_Base;
                        RubroxPeriodo_Info.FechaInicio = item.pe_FechaIni;
                        RubroxPeriodo_Info.FechaFin = item.pe_FechaFin;
                        RubroxPeriodo_Info.FechaCreacion = item.FechaCreacion;
                        RubroxPeriodo_Info.UsuarioCreacion = item.UsuarioCreacion;
                        if (RubroxPeriodo_Info.Estado == "A")
                            RubroxPeriodo_Info.chequeo = true;

                        ListRubroxPeriodo.Add(RubroxPeriodo_Info);
                    }
                }
                return ListRubroxPeriodo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
        }


       public Aca_Rubro_x_Aca_Periodo_Lectivo_Info Get_Rubro_x_PeriodoLectivo(decimal IdRubro)
       {
           try
           {
               Aca_Rubro_x_Aca_Periodo_Lectivo_Info PeriodoxRubro_Info = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var RubroxPeriodo = from e in Base.vwAca_Rubro_x_Aca_Periodo_Lectivo
                                            where e.IdRubro == IdRubro
                                            orderby e.IdPeriodoLectivo
                                            select e;                   
                   foreach (var item in RubroxPeriodo)
                   {
                       //PREGUNTAR X EL CAMPO IdInstitutcion_per
                       PeriodoxRubro_Info.IdInstitucion_per = item.IdInstitucion;
                       PeriodoxRubro_Info.IdAnioLectivo = item.IdAnioLectivo;
                       PeriodoxRubro_Info.IdPeriodo = Convert.ToInt32(item.IdPeriodoLectivo);
                       PeriodoxRubro_Info.IdRubro = item.IdRubro;
                       PeriodoxRubro_Info.Valor = Convert.ToDouble(item.Valor);
                       PeriodoxRubro_Info.Estado = item.Estado;                      
                   }
               }
               return PeriodoxRubro_Info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       #endregion

       #region "Grabar,Actualizar"

       public bool GrabarDB(BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> lstRubroxPeriodo, ref string msj)
        {
            try
            {
                Aca_estudiante_x_Alergia addressAlergia = new Aca_estudiante_x_Alergia();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    Aca_Rubro_x_Aca_Periodo_Lectivo PeriodoxRubro_Info = new Aca_Rubro_x_Aca_Periodo_Lectivo();
                    foreach (var item in lstRubroxPeriodo)
                    {
                        PeriodoxRubro_Info = new Aca_Rubro_x_Aca_Periodo_Lectivo();
                        PeriodoxRubro_Info.IdInstitucion_rub = item.IdInstitucion_rub;

                        //PREGUNTAR X EL CAMPO IdInstitutcion_per
                        PeriodoxRubro_Info.IdInstitucion_per = item.IdInstitucion_rub;
                        PeriodoxRubro_Info.IdAnioLectivo = item.IdAnioLectivo;

                        PeriodoxRubro_Info.IdPeriodo = Convert.ToInt32(item.IdPeriodo);
                        PeriodoxRubro_Info.IdRubro = item.IdRubro;
                        PeriodoxRubro_Info.Valor = Convert.ToDouble(item.Valor);
                        PeriodoxRubro_Info.Estado = item.Estado;
                        PeriodoxRubro_Info.FechaCreacion = DateTime.Now;
                        PeriodoxRubro_Info.UsuarioCreacion = item.UsuarioCreacion;

                        Base.Aca_Rubro_x_Aca_Periodo_Lectivo.Add(PeriodoxRubro_Info);
                        Base.SaveChanges();
                    }
                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item_validaciones in item.ValidationErrors)
                    {
                        mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                    }
                }
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

       public bool EliminarDB(int IdInstitucion, int IdRubro, ref string msj)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    string sqldel = "delete from Aca_Rubro_x_Aca_Periodo_Lectivo where IdInstitucion_rub= " + IdInstitucion+ " and IdRubro=" + IdRubro;
                    var Consulta = context.Database.ExecuteSqlCommand(sqldel);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       #endregion

    }
}
