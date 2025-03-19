class PoliceMan : Person
{
    private string _weapons;
    public PoliceMan(string weapons, string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        SetHeight(80);
    }

    public string DisplayPoliceManInfo()
    {
        return $"{_weapons}, Info: {DisplayPersonInfo()}";
    }
}