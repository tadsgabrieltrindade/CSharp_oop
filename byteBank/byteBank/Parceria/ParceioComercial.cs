using byteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Parceria
{
    public class ParceioComercial:IAutenticavel
    {
       

        public string senha { get; set; }

   

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
