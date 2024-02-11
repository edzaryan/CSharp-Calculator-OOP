
public abstract class Operation 
{
    public abstract double Execute(double x, double y);

    public static double Compute(Operation type, double x, double y) 
    {
        return type.Execute(x, y);
    }

}