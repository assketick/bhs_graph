class Adder: BaseBlock
{
    public Adder() : base(0)
    {
        this.GraphInput = new Slot(this);
        this.GraphOutput = new Slot(this);
        this.InputSlots = new List<Slot>() { new Slot(this), new Slot(this) };
        this.OutputSlots = new List<Slot>() { new Slot(this) };
    }
    public override void Run() 
    {
        int sum = 0;
        foreach (var slot in InputSlots)
        {
            if (slot.Link != null)
            {
                sum += slot.Link.Parent.Number;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        this.Number = sum;
        this.GraphOutput.Link.Parent.Run();
    }
}