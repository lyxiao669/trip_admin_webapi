using MediatR;

namespace MiniApi.Application
{
    public class CreateOrderCommand : IRequest<CreateOrderResult>
    {
        // public int UserId { get; set; }
        public int SpotId { get; set; }
        // public int Status { get; set; }
    }

    public class CreateOrderResult
    {
        public int OrderId { get; set; }
        public string Message { get; set; }
    }
}
