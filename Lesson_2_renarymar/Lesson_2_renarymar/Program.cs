using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_renarymar
{
    class Program
    {
        /// <summary>
        /// Пример работы с классами APIRepo и MySQLRepo и их конкретными методами
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            OrderRepository orderRepositorySQL = new MySQLRepo();
            Order orderSQL = orderRepositorySQL.Load(1534);
            orderRepositorySQL.Save(orderSQL);
            orderRepositorySQL.Update(orderSQL);
            orderRepositorySQL.Delete(orderSQL);

            OrderRepository orderRepositoryAPI = new APIRepo();
            Order orderAPI = orderRepositoryAPI.Load(2345);
            orderRepositoryAPI.Save(orderAPI);
            orderRepositoryAPI.Update(orderAPI);
            orderRepositoryAPI.Delete(orderAPI);
        }
    }
}
