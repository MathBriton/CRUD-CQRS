using Shop.Domain.Commands.Requests;

namespace Shop.Domain.Commands.Handlers
{

    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        //Verifica se o cliente já está cadastrado
        // Valida os dados
        // Insere o cliente
        // Envia E-mail de boas vindas
        public CreateCustomerResponse Handle (CreateCustomerRequest request) 
        {

            return new CreateCustomerResponse 
            {
                Id = Guid.NewGuid(),
                Name = "Matheus Brito",
                Email = " Brito@brito.com ",
                Date = DateTime.Now
            }

        }
    }
}