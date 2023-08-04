using Nam;
namespace Circlee;
public class  Circle : IGeometricObject
{    protected double _radius;
     public Circle(double radius)
     {
        _radius=radius;  
     }
     
   public double GetArea(){
       return _radius*_radius*3.14;
     }
    public double Getperimeter(){
          return 2*3.14*_radius;
     }
    }