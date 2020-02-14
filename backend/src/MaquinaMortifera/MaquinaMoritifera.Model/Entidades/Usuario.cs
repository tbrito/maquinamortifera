using System;

namespace MaquinaMoritifera.Model.Entidades
{
    public class Usuario : Entidade
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }
    }
}
