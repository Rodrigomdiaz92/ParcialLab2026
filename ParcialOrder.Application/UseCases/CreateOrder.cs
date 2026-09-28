using ParcialOrder.Application.Dtos;
using ParcialOrder.Application.Interfaces;
using ParcialOrder.Domain.Aggregates;
using ParcialOrder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialOrder.Application.UseCases
{
    public class CreateOrder : ICreateOrder
    {
        private readonly IOrderRepository _repository;
        private readonly HttpClient _httpClient;
        public CreateOrder(IOrderRepository repository, HttpClient httpClient)
        {
            _repository = repository;
            _httpClient = httpClient;
        }
        public async Task<CreateOrderResponse> ExcecuteAsync(CreateOrdenRequestDTO request)
        {
            // obtener los datos necesarios de la orden

            // datos del producto


            //obtener datos del cliente

            //nuevo objeto orden con datos obtenidos
            Order newOrder = new Order();
            //newOrder.Name = request.Name;
            //newOrder.ProductId = request.ProductId;

            //insertar un nuevo registro en un repo
            await _repository.CreateAsync(newOrder);

            //descontar el stock correspondiente

            // retornar ok si se creo la orden correctamente
            return new CreateOrderResponse
            {


            };

            //implementacion crear orden
            throw new NotImplementedException();
        }
    }
}
