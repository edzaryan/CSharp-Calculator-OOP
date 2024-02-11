
public class Calculator 
{
    public static double PerformOperation(double x, double y, char operation)
    {
        Operation op;

        switch(operation) {
            case '+':   
                op = new Addition();
                break;
            case '-':
                op = new Subtraction();
                break;
            case '/':
                op = new Division();
                break;
            case '*':
                op = new Multiplication();
                break;
            case '%':
                op = new Percentage();
                break;
            default:
                throw new ArgumentException("Invalid operation");
        }

        return Operation.Compute(op, x, y);
    }
}