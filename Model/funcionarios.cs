using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class funcionario : IModel
    {
        public int id { get ; set ; }
        public string nome { get ; set ; }
        public string curso { get; set; }
        public string nacionalidade { get; set; }
        public string numeroCelular { get; set; }
        public string nFixo { get; set; }
        public string email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime dataNacimento { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public string endereso { get; set; }
        public string cargo { get; set; }



    }
}
