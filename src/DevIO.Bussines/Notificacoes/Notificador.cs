using DevIO.Bussines.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace DevIO.Bussines.Notificacoes
{
    public class Notificador : INotificador
    {
        //fica "viva" duarante todo o request
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
