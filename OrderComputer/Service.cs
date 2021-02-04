using OrderComputer.BLL;
using OrderComputer.ErrorHandlers;
using OrderComputer.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderComputer
{
    public class Service
    {
        IErrorHandler _errorHandler;
        IOrderHandler _orderHandler;
        IRepository _repository;
        public Service()
        {
            _errorHandler = new ErrorHandlerByWeb();
            _orderHandler = new OrderHandler();
            _repository = new SqlRepository();
        }

        public void Run()
        {
            try
            {
                var unprocessedOrders = _repository.GetUnprocessedOrderItems().Result;
                unprocessedOrders.ForEach(orderItem =>
                {
                    if (_orderHandler.Compute(ref orderItem))
                        _repository.UpdateOrderItem(orderItem); 
                });
            }
            catch (Exception ex)
            {
                _errorHandler.WriteAsync(ex.Message);
            }
        }
    }
}
