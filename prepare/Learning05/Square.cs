public class Square : Shape {

    //Private fields
    private double side;

    //Public methods
    public void setSide(double s){side = s;}
    public double getSide(){return this.side;}
    
    public override double getArea(){return this.side * this.side;}
    //constructor
    public Square(string _color, double _side) : base(_color)
    {
        this.side = _side;
    }
}