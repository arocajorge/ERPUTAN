using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;

namespace Core.Erp.Business.Academico
{
    /// <summary>
    /// Prog: Pedro Salinas
    /// Creación: 03-02-2016
    /// </summary>
   
    public class Aca_Periodo_Bus
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        Aca_Periodo_Data Odata = new Aca_Periodo_Data();
        List<Aca_Periodo_Info> LstPeriodo_Info = new List<Aca_Periodo_Info>();

        public Aca_Periodo_Info _PeriodoInfo = new Aca_Periodo_Info();

        #endregion

        public int getId(int IdInstitucion, int FechaIni, int FechaFin)
        {
            try
            {
                return Odata.getId(IdInstitucion, FechaIni, FechaIni);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(Aca_Periodo_Bus) };
            }
        }

        public List<Aca_Periodo_Info> Get_List_Periodo(int IdInstitucion)
        {
            try
            {
                return Odata.Get_List_Periodo(IdInstitucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(Aca_Periodo_Bus) };
            }
        }

        public List<Aca_Periodo_Info> Get_List_Periodo(int IdInstitucion, int IdPeriodo)
        {
            try
            {
                return Odata.Get_List_Periodo(IdInstitucion, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(Aca_Periodo_Bus) };
            }
        }

        //public List<Aca_Periodo_Info> Get_List_Periodo_x_AnioLectivo(int IdInstitucion, string IdAnioLectivo)
        public List<Aca_Periodo_Info> Get_List_Periodo_x_AnioLectivo(int IdInstitucion, int IdAnioLectivo)
        {
            try
            {
                return Odata.Get_List_Periodo_x_AnioLectivo(IdInstitucion, IdAnioLectivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(Aca_Periodo_Bus) };
            }
        }


        //public List<Aca_Periodo_Info> Get_List_PeriodoActivo_x_AnioLectivo(int IdInstitucion, string IdAnioLectivo)
        public List<Aca_Periodo_Info> Get_List_PeriodoActivo_x_AnioLectivo(int IdInstitucion, int IdAnioLectivo)
        {
            try
            {
                return Odata.Get_List_PeriodoActivo_x_AnioLectivo(IdInstitucion, IdAnioLectivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(Aca_Periodo_Bus) };
            }
        }

        public List<Aca_Periodo_Info> Get_List_Periodo_Pre(int IdInstitucion)
        {
            try
            {
                return Odata.Get_List_Periodo_Pre(IdInstitucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo_Pre", ex.Message), ex) { EntityType = typeof(Aca_Periodo_Info) };
            }
        }

        public Boolean ExistePeriodo(int IdInstitucion, int IdPeriodo)
        {
            try
            {
                return Odata.ExistePeriodo(IdInstitucion, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExistePeriodo", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }

        public Boolean GrabarDB(Aca_Periodo_Info Info, ref string msg)
        {
            try
            {
                return Odata.GrabarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }

        public Boolean ModificarDB(Aca_Periodo_Info Info, ref string msg)
        {
            try
            {
                return Odata.ModificarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }

        public Boolean AnularDB(Aca_Periodo_Info Info, ref string msg)
        {
            try
            {
                return Odata.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }

        public Boolean GrabarDB_Periodos(List<Aca_Periodo_Info> Lst, ref string mensaje)
        {
            try
            {
                return Odata.GrabarDB_Periodos(Lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB_Periodos", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }

        public Boolean ActivarPeriodoSiguiente(vwAca_AnioPeriodo_Activo_Info infoPeriodoActivo, ref string msg)
        {
            bool resultado = false ;
            int num_peridos_x_anio = 0;
            int cont_peridos_x_anio = 0;
            int pos_periodo_activo = 0;
            try
            {
                //_PeriodoInfo = new Aca_Periodo_Info();
                _PeriodoInfo.IdInstitucion = infoPeriodoActivo.IdInstitucion;
                _PeriodoInfo.IdAnioLectivo = infoPeriodoActivo.IdAnioLectivo;
                _PeriodoInfo.IdPeriodo = infoPeriodoActivo.IdPeriodo;
                _PeriodoInfo.pe_FechaIni = infoPeriodoActivo.pe_FechaIni;
                _PeriodoInfo.pe_FechaFin = infoPeriodoActivo.pe_FechaFin;
                _PeriodoInfo.pe_estado = infoPeriodoActivo.pe_estado;
                _PeriodoInfo.Fecha_UltMod = DateTime.Now;
                _PeriodoInfo.IdUsuarioUltMod = param.IdUsuario;
                _PeriodoInfo.est_apertura = "C";


               

                LstPeriodo_Info = this.Get_List_Periodo_x_AnioLectivo(_PeriodoInfo.IdInstitucion, _PeriodoInfo.IdAnioLectivo);
                num_peridos_x_anio = LstPeriodo_Info.Count;

                foreach (var item in LstPeriodo_Info)
                {
                    cont_peridos_x_anio = cont_peridos_x_anio + 1;
                    if (item.IdPeriodo == _PeriodoInfo.IdPeriodo)
                    {
                        pos_periodo_activo = cont_peridos_x_anio;
                        break;
                    }
                }
                cont_peridos_x_anio = 0;

                foreach (var item in LstPeriodo_Info)
                {
                    cont_peridos_x_anio = cont_peridos_x_anio + 1;

                    if (pos_periodo_activo - 1 == cont_peridos_x_anio && pos_periodo_activo - 1 > 0)
                    {
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.est_apertura = "I";
                        resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);
                    }

                    if (pos_periodo_activo == cont_peridos_x_anio && pos_periodo_activo != num_peridos_x_anio)
                    {
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.est_apertura = "C";
                        resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);

                        
                    }

                    if (pos_periodo_activo + 1 == cont_peridos_x_anio  && pos_periodo_activo +1 <= num_peridos_x_anio)
                    {
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.est_apertura = "A";
                        resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);
                    }

                    
                }


                return Odata.ModificarDB(_PeriodoInfo, ref msg);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB_Periodos", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }

        public Boolean ActivarPeriodoAnterior(vwAca_AnioPeriodo_Activo_Info infoPeriodoActivo, ref string msg)
        {
            bool resultado = false;
            int num_peridos_x_anio = 0;
            int cont_peridos_x_anio = 0;
            int pos_periodo_activo = 0;
            try
            {
                //_PeriodoInfo = new Aca_Periodo_Info();
                _PeriodoInfo.IdInstitucion = infoPeriodoActivo.IdInstitucion;
                _PeriodoInfo.IdAnioLectivo = infoPeriodoActivo.IdAnioLectivo;
                _PeriodoInfo.IdPeriodo = infoPeriodoActivo.IdPeriodo;
                _PeriodoInfo.pe_FechaIni = infoPeriodoActivo.pe_FechaIni;
                _PeriodoInfo.pe_FechaFin = infoPeriodoActivo.pe_FechaFin;
                _PeriodoInfo.pe_estado = infoPeriodoActivo.pe_estado;
                _PeriodoInfo.Fecha_UltMod = DateTime.Now;
                _PeriodoInfo.IdUsuarioUltMod = param.IdUsuario;
                _PeriodoInfo.est_apertura = "C";




                LstPeriodo_Info = this.Get_List_Periodo_x_AnioLectivo(_PeriodoInfo.IdInstitucion, _PeriodoInfo.IdAnioLectivo);
                num_peridos_x_anio = LstPeriodo_Info.Count;

                foreach (var item in LstPeriodo_Info)
                {
                    cont_peridos_x_anio = cont_peridos_x_anio + 1;
                    if (item.IdPeriodo == _PeriodoInfo.IdPeriodo)
                    {
                        pos_periodo_activo = cont_peridos_x_anio;
                        break;
                    }
                }
                cont_peridos_x_anio = 0;

                foreach (var item in LstPeriodo_Info)
                {
                    cont_peridos_x_anio = cont_peridos_x_anio + 1;

                    if (pos_periodo_activo - 1 == cont_peridos_x_anio && pos_periodo_activo - 1 > 0)
                    {
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.est_apertura = "A";
                        resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);
                    }

                    if (pos_periodo_activo == cont_peridos_x_anio && pos_periodo_activo != 1)
                    {
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.est_apertura = "I";
                        resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);


                    }
                    if (pos_periodo_activo == cont_peridos_x_anio && pos_periodo_activo == 1)
                    {
                        _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                        _PeriodoInfo.est_apertura = "A";
                        resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);


                    }
                    //if (pos_periodo_activo + 1 == cont_peridos_x_anio && pos_periodo_activo + 1 <= num_peridos_x_anio)
                    //{
                    //    _PeriodoInfo.IdPeriodo = item.IdPeriodo;
                    //    _PeriodoInfo.est_apertura = "I";
                    //    resultado = Odata.ModificarDB(_PeriodoInfo, ref msg);
                    //}


                }


                return Odata.ModificarDB(_PeriodoInfo, ref msg);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB_Periodos", ex.Message), ex) { EntityType = typeof(Boolean) };
            }
        }



    }
}
