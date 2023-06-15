public class Circle : Shape{
    //Private fields
    private double radius;
    //Public methods
    public void setRadius(double r){radius = r;}
    public double getRadius(){return this.radius;}
    public override double getArea(){return this.radius * this.radius * 3.14;}
    //constructor
    public Circle(string _color, double _radius) : base(_color)
    {
        this.radius = _radius;
    }
}