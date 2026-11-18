namespace Laba4TSR.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty; // Имя покупателя
        public int ProductId { get; set; } // ID товара, который заказали
        public int Quantity { get; set; } // Количество
        public DateTime OrderDate { get; set; } = DateTime.Now; // Дата заказа
    }
}