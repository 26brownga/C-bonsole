class GetSet
{
    private string _model;
    
    public string Model
    {
        get {return _model;}
    }
}
class Person
{ 
    private string _name;

    public string Name
    {
        get{return _name;}
        set{
                if(!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
           }
    }

    class Short
    {
        public string Cut{get;set;}
    }
}
