using OnionUniversity.Domain.Core;
using System;

namespace OnionUniversity.Services.Interfaces
{
    public interface IOrder
    {
        void MakeOrder(Book book);
    }
}
