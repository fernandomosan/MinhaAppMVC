using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Notificacoes
{
    public class Notificacao
    {
        public string Menssagem { get; }

        public Notificacao(string menssagem)
        {
            Menssagem = menssagem;
        }
    }
}
