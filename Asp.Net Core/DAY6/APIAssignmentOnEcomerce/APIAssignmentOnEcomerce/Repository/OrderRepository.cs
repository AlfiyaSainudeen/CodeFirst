using APIAssignmentOnEcomerce.Models;

namespace APIAssignmentOnEcomerce.Repository
{
    public class OrderRepository : IOrderRepository
    {
        List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            try
            {
                orders.Add(order);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> DeleteOrder(int OrderId)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> GetAll()
        {
            try
            {
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> PlaceOrderByProduct(int ProductId)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
