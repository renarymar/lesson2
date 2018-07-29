using System;
namespace Store
{
    /// <summary>
    /// Базовый интерфейс товара
    /// </summary>
    public interface IItem
    {
        void SetDiscount(double discount); 
        void SetPromocode(string promocode);
        void SetPrice(double price);
    }
}
