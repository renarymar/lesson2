using System;
namespace Lesson_2_renarymar
{
    /// <summary>
    /// Абстрактный класс с базовыми виртуальными методами
    /// </summary>
    public abstract class OrderRepository
    {
        public virtual Order Load(int orderId) 
        {
            Order order = new Order();
            return order;       
        }
        public virtual void Save(Order order) { }
        public virtual void Update(Order order) { }
        public virtual void Delete(Order order) { }
    }

    /// <summary>
    /// Класс SQLRepo насдедуется от OrderRepository и имеет собственную реализацию методов базового класса
    /// </summary>
    public class MySQLRepo : OrderRepository
    {
        public override Order Load(int orderId)
        {
            return base.Load(orderId);
        }
        public override void Save(Order order) { }
        public override void Update(Order order) { }
        public override void Delete(Order order) { }
    }

    /// <summary>
    /// Класс APIRepo насдедуется от OrderRepository и имеет собственную реализацию методов базового класса.
    /// </summary>
    public class APIRepo : OrderRepository
    {
        public override Order Load(int orderId)
        {
            return base.Load(orderId);
        }
        public override void Save(Order order) { }
        public override void Update(Order order) { }
        public override void Delete(Order order) { }
    }
}
