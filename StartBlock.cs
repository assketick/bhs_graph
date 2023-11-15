class StartBlock: BaseBlock
{
    public StartBlock(): base(0)
    {
        this.GraphOutput = new Slot(this);
    }

    public override void Run()
    {
        if (this.GraphOutput == null) 
        { 
            throw new NullReferenceException(); 
        }
        else if (this.GraphOutput.Link == null) 
        { 
            throw new NullReferenceException(); 
        }
        this.GraphOutput.Link.Parent.Run();
    }
}