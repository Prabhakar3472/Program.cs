using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Method
{
    public interface ICustomer
    {
        string Display();
    }

    public interface IOrders
    {
        string Display();
    }

    public class Tranaction : ICustomer, IOrders
    {

        string ICustomer.Display()
        {
            return "Customer details";
        }

        string IOrders.Display()
        {
            return "Order details";
        }
    }
}
