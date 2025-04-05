abstract class TrackableItem
{
    public string Name { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public abstract void DisplayInfo();
}