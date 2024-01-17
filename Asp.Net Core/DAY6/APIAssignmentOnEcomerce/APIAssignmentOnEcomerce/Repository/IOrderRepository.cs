using APIAssignmentOnEcomerce.Models;

namespace APIAssignmentOnEcomerce.Repository
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> GetAll();
        List<Order> PlaceOrderByProduct(int ProductId);
        List<Order> DeleteOrder(int OrderId);
        
    }
}
