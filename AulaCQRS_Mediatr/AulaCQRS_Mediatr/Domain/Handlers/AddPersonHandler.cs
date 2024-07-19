using AulaCQRS_Mediatr.Domain.Request;
using AulaCQRS_Mediatr.Domain.Response;
using MediatR;

namespace AulaCQRS_Mediatr.Domain.Handlers
{
    public class AddPersonHandler : IRequestHandler<AddPersonRequest, AddPersonResponse>
    {
        public Task<AddPersonResponse> Handle(AddPersonRequest request, CancellationToken cancellationToken)
        {
            var result = new AddPersonResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Age = 18,
                TaxId = "123456"
            };

            return Task.FromResult(result);
        }

        /*
        public AddPersonResponse Handler(AddPersonRequest request)
        {
            // Verifica se a pessoa existe
            // Valida os dados
            // Inserir e Adicionar a pessoa
            // Notifica
            return new AddPersonResponse
            {
                Id = Guid.NewGuid(),
                Name = "Lucas",
                Age = 18,
                TaxId = "123456"
            };
        }
        */
    }
}
