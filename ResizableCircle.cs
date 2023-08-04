using Resizable;
using Circlee;
public class ResizableCircle:Circle,IResizable{
    public ResizableCircle(double r):base(r)
    {
        
    }
    public double Resize(int f) => f * _radius;
}