using DevIO.Bussines.Interfaces;
using DevIO.Bussines.Models;
using DevIO.Bussines.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace DevIO.Bussines.Services
{
    public abstract class BaseService
    {

        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            //Propagar esse erro até a camada de apresentação
            _notificador.Handle(new Notificacao(mensagem));

        }

        protected bool ExecutarValidacao<TV, TE>(TV validaca, TE entidade) where TV: AbstractValidator<TE> where TE: Entity
        {
            var validator = validaca.Validate(entidade);
            
            if (validator.IsValid) return true;

            Notificar(validator);
            return false;
        }

    }

}
