namespace GymManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new("John Doe", 25, false);
            Member member2 = new("Jane Smith", 20, true);
            Member member3 = new("Bob Johnson", 30, false);
            Console.WriteLine($"{member1.Name}, {member1.Age}, {member1.IsStudent}");
            Console.WriteLine($"{member2.Name}, {member2.Age}, {member2.IsStudent}");
            Console.WriteLine($"{member3.Name}, {member3.Age}, {member3.IsStudent}");
            member1.CheckIn();
            member2.CheckIn();
            member2.CheckIn();
            member3.CheckIn();
            member3.CheckIn();
            member3.CheckIn();
            Console.WriteLine(member1.Describe());
            Console.WriteLine(member2.Describe());
            Console.WriteLine(member3.Describe());
            Membership ms1 = new(member1, 50, 12);
            Membership ms2 = new(member2, 50, 6);
            Console.WriteLine($"{ms1.TotalCost()}, {ms2.TotalCost()}");
            ms2.Extend(6);
            Console.WriteLine($"{ms2.TotalCost()}");
            Gym gym = new("Gym");
            gym.AddMembership(ms1);
            gym.AddMembership(ms2);
            gym.AddMembership(new(new("a", 10, false), 50, 12));
            gym.AddMembership(new(new("b",11,false), 50, 12));
            Console.WriteLine(gym.TotalIncome());
            Console.WriteLine(gym.MostActive().Describe());
        }
    }
}
