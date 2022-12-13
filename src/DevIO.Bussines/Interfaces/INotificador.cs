using DevIO.Bussines.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Bussines.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);


    }
}
