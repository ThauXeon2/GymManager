using System;
using System.Collections.Generic;
using System.Text;

namespace GymManager
{
    internal class Membership
    {
        private Member _owner;
        private int _monthlyprice;
        private int _months;
        public Member Owner { get { return _owner; } set { _owner = value; } }
        public int MonthlyPrice { get { return _monthlyprice; } set { _monthlyprice = value; } }
        public int Months { get { return _months; } set { _months = value; } }
        public Membership(Member owner, int monthlyPrice, int months)
        {
            Owner = owner;
            MonthlyPrice = monthlyPrice;
            Months = months;
        }
        public int TotalCost()
        {
            if(Owner.IsStudent)
            {
                return (int)(MonthlyPrice * Months * .8);
            }
            else
            {
                return MonthlyPrice * Months;
            }
        }
        public void Extend(int months) => Months += months;
        public int PricePerVisit() => (int)TotalCost() / Owner.Visits;
    }
}
