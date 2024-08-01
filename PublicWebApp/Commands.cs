using MediatR;

namespace PublicWebApp
{
    public class CreateCustomerCommand: IRequest<CustomerResponse>
    {
        public CustomerDTO CustomerDto { get; set; }
    }
}
