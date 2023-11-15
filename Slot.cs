public class Slot
{
    public Slot Link { get; set; } = null!;
    public BaseBlock Parent { get; set; }
    public Slot(BaseBlock Parent)
    {
        this.Parent = Parent;
    }
}