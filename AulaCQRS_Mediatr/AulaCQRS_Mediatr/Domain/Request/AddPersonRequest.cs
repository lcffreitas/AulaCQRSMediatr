using AulaCQRS_Mediatr.Domain.Response;
using MediatR;

namespace AulaCQRS_Mediatr.Domain.Request
{
    public class AddPersonRequest : IRequest<AddPersonResponse>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
