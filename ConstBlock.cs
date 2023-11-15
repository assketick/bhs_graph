public class ConstBlock: BaseBlock
{
    public ConstBlock(int Number) : base(Number)
    {
        this.OutputSlots = new List<Slot>() { new Slot(this) };
    }

    public override void Run() {}
}