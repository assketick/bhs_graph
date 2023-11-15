public abstract class BaseBlock {
    public int Number { get; set; }
    public Slot GraphInput = null!; 
    public Slot GraphOutput = null!;
    public List<Slot> InputSlots = null!;
    public List<Slot> OutputSlots = null!;
    public BaseBlock(int Number) 
    {
        this.Number = Number;
    }
    public abstract void Run();
}