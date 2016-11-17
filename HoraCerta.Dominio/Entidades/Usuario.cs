using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraCerta.Dominio.Entidades
{
    public class Usuario
    {
        public int codUsuario { get; set; }
        public  string Nome { get; set; }
        public  string usuario { get; set; }
        public  string senha { get; set; }
        public DateTime dataCadastro { get; set; }

    }
}
