using System;
namespace Store
{
    /// <summary>
    /// Интерфейс одежды
    /// </summary>
    public interface IClothes : IItem
    {
        void SetColor(Color color);
        void SetSize(Size size);
    }

    public class Color {}
    public class Size {}
}