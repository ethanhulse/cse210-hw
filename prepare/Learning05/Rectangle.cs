public class Rectangle : Shape {
    //Private fields
    private double width;
    private double height;
    //Public methods
    public void setWidth(double w){width = w;}
    public double getWidth(){return this.width;}
    public void setHeight(double h){height = h;}
    public double getHeight(){return this.height;}
    public override double getArea(){return this.width * this.height;}
    //constructor
    public Rectangle(string _color, double _width, double _height) : base(_color)
    {
        this.width = _width;
        this.height = _height;
    }
}