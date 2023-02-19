using byteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.SistemaInterno
{
    public interface IAutenticavel

    {

        public string senha { get; set; }


        public abstract bool Autenticar(string senha);
        

    }
}
