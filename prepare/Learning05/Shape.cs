public abstract class Shape
{

    //Private fields
    private string color;
    private double area;

    //Public methods
    public void setColor(string c){color = c;}
    public string getColor(){return this.color;}
    
    public virtual double getArea(){return this.area;}
    //constructor
    public Shape(string _color)
    {
        this.color = _color;
    }
    
}