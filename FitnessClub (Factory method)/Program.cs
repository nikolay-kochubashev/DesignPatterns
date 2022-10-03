using FitnessClub.Domain;
using FitnessClub.Factory;

class Program
{
    static void Main()
    {
        Console.WriteLine(">>> Welcome to FitnessClub");
        Console.WriteLine("> Enter the membership type you would like to issue: ");
        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym + Pool");
        Console.WriteLine("> T - Personal training");

        string membershiptype = Console.ReadLine();
        MembershipFactory factory = GetFactory(membershiptype);
        IMembership membership = factory.GetMembership();
        Console.WriteLine("\n> Membership you'va just created: \n");
        Console.WriteLine(
            $"\tName:\t\t{membership.Name}\n" +
            $"\tDescription:\t{membership.Description}\n" +
            $"\tPrice:\t\t{membership.GetPrice()}");
    }

    private static MembershipFactory GetFactory(string membershiptype) =>
        membershiptype.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic membership"),
            "p" => new GymPlusSwimmingpoolMembershipFactory(250, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
            _ => null
        };
}