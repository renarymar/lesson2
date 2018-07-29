using System;

namespace Store
{
    class Program
    {
        /// <summary>
        /// Пример создания товара Dress и присвоения товару цены с помощью метода SetPrice()
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            Dress dress = new Dress();
            dress.SetPrice(100);
        }
    }
}
