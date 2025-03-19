class Program
{
    public static void Main (string[] args)
    {
        Person myperson = new Person("bob", "bubba", 97);

        Console.WriteLine(myperson.DisplayPersonInfo());

        PoliceMan myPoliceMan = new PoliceMan("Tazer","Joe","Mama");
        Console.WriteLine(${myPoliceMan.DisplayPoliceManInfo()});
        Console.WriteLine(${myPoliceman.DisplayPersonInfo()});
    }
}