
public class Calculator 
{
    public static double PerformOperation(double x, double y, char operation)
    {
        double result;

        switch(operation) {
            case '+':   
                result = Operation.Compute(new Addition(), x, y);
                break;
            case '-':
                result = Operation.Compute(new Subtraction(), x, y);
                break;
            case '/':
                result = Operation.Compute(new Division(), x, y);
                break;
            case '*':
                result = Operation.Compute(new Multiplication(), x, y);
                break;
            case '%':
                result = Operation.Compute(new Percentage(), x, y);
                break;
            default:
                throw new ArgumentException("Invalid operation");
        }

        return result;
    }
}