
public class Division : Operation 
{

    public override double Execute(double x, double y) 
    {
        if (y == 0) {
            throw new DivideByZeroException("Error: Division by zero is not allowed.");
        }

        return x / y;
    }

}