using System;
using System.Collections.Generic;
using System.Text;

namespace GymManager
{
    internal class Gym
    {
        private string _name;
        private List<Membership> _memberships;
        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Memberships { get { return _memberships; } }
        public Gym(string name)
        {
            _name = name;
            _memberships = new();
        }
        public void AddMembership(Membership membership) => _memberships.Add(membership);
        public int TotalIncome() => _memberships.Sum(x => x.TotalCost());
        public Member MostActive() => _memberships.OrderByDescending(x => x.Owner.Visits).First().Owner;
        public Membership BestValue()=>_memberships.OrderBy(x => x.PricePerVisit()).First();
    }
}
