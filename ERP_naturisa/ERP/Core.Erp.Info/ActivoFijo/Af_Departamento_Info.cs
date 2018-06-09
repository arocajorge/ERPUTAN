using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
  public  class Af_Departamento_Info
    {
        public int IdEmpresa { get; set; }
        public int IdDepartamento { get; set; }
        public string estado { get; set; }
        public string nom_departamento { get; set; }
        public string nom_departamento2 { get; set; }

        public Af_Departamento_Info()
        {

        }

        public Af_Departamento_Info(int _IdEmpresa, int _IdDepartamento, string _estado, string _nom_departamento)
        {
            IdEmpresa = _IdEmpresa;
            IdDepartamento = _IdDepartamento;
            estado = _estado;
            nom_departamento = _nom_departamento;
            nom_departamento2 = "[" + IdDepartamento + "]-" + nom_departamento;
        }

    }
}
