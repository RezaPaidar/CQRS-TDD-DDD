
using MediatR;

namespace PublicWebApp
{
    public class CreateCommandHandlers : IRequestHandler<CreateCustomerCommand, CustomerResponse>
    {
        public Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
