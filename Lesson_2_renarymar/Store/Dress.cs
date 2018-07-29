using System;
namespace Store
{
    /// <summary>
    /// Класс Платья, наследует интерфейс IClothes и имеет реализию методов IItem и IClothes
    /// </summary>
    public class Dress : IClothes
    {
        public void SetColor(Color color)  {}
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
        public void SetSize(Size size) { }
    }
}
