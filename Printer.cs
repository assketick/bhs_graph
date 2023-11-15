class Printer: BaseBlock
{
    public Printer(): base(0)
    {
        this.GraphInput = new Slot(this);
        this.InputSlots = new List<Slot>();
        this.InputSlots.Add(new Slot(this));
    }
    public override void Run()
    {
            Console.WriteLine(this.GraphInput.Link.Parent.Number);
            Console.WriteLine("\n");
    }
}