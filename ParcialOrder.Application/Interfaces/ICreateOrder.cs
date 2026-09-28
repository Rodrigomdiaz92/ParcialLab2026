using ParcialOrder.Application.Dtos;

namespace ParcialOrder.Application.Interfaces
{
    public interface ICreateOrder
    {
        Task<CreateOrderResponse> ExcecuteAsync(CreateOrdenRequestDTO request);
    }
}