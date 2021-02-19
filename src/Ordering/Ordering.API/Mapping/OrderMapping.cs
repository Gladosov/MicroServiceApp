using AutoMapper;
using EventBusRabbitMQ.Events;
using Ordering.API.DTOs;
using Ordering.Core.Entities;
using System;

namespace Ordering.API.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            global::System.Object p = CreateMap<Order, OrderResponse>();
            global::System.Object p1 = CreateMap<BasketCheckoutEvent, Order>();
        }
    }
}
