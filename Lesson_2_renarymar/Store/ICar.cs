using System;
namespace Store
{
    /// <summary>
    /// Интерфейс автомобилей
    /// </summary>
    public interface ICar : IItem
    {
        void SetBrand(Brand brand);
        void SetColor(Color color);
    }

    public class Brand {}
}
