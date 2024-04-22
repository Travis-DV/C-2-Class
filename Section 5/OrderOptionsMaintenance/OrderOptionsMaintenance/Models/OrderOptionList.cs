using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace OrderOptionsMaintenance.Models
{
    public class OrderOptionList
    {
        private List<OrderOption> orderOptionList;

        //STEP 1 CREATE DELEGATE AND EVENT HERE
        public delegate void ChangeHandler(OrderOptionList orderList);
        public event ChangeHandler Changed = null!;

        public OrderOptionList() => orderOptionList = new();

        public int Count => orderOptionList.Count;

        public OrderOption this[int i]
        {
            get
            {
                //STEP 2 DEFINE get HERE
                try
                {
                    return orderOptionList[i];
                }
                catch
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                //STEP 2 DEFINE set HERE
                orderOptionList[i] = value;
                if (Changed != null)
                    Changed(this);
            }
        }

        public void Add(OrderOption item)
        {
            orderOptionList.Add(item);
            if (Changed != null)
                Changed(this);
        }

        //STEP 3 CREATE Add() OVERLOAD HERE
        public void Add(int option, decimal salesTax, decimal firstBookShipping, decimal addBookShipping)
        {
            OrderOption newOrder = new()
            {
                OptionId = option,
                SalesTaxRate = salesTax,
                FirstBookShipCharge = firstBookShipping,
                AdditionalBookShipCharge = addBookShipping
            };
            this.Add(newOrder);
        }

        public void Remove(OrderOption order)
        {
            orderOptionList.Remove(order);
            if (Changed != null)
                Changed(this);
        }

        //STEP 4 CREATE + and - OVERLOADS HERE
        public static OrderOptionList operator +(OrderOptionList orderList, OrderOption orderOption)
        {
            orderList.Add(orderOption);
            return orderList;
        }

        public static OrderOptionList operator -(OrderOptionList orderList, OrderOption orderOption)
        {
            orderList.Remove(orderOption);
            return orderList;
        }
    }
}
