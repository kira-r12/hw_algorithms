public class Calculator
{
    public double Calculate(Queue postfix)
    {
        Stack CalculatorStack = new Stack();
        while (postfix.Count() > 0)
        {
            string t = postfix.Dequeue();
            if (t.Length > 0 && char.IsDigit(t[0]))
            {
                CalculatorStack.Push(t);
            }
            else if (t == "+")
            {
                double right = double.Parse(CalculatorStack.Pop());
                double left = double.Parse(CalculatorStack.Pop());
                double result = left + right;
                CalculatorStack.Push(result.ToString());
            }
            else if (t == "-")
            {
                double right = double.Parse(CalculatorStack.Pop());
                double left = double.Parse(CalculatorStack.Pop());
                double result = left - right;
                CalculatorStack.Push(result.ToString());   
            }
            else if (t == "/")
            {
                double right = double.Parse(CalculatorStack.Pop());
                double left = double.Parse(CalculatorStack.Pop());
                double result = left / right;
                CalculatorStack.Push(result.ToString());
            }
            else if (t == "*")
            {
                double right = double.Parse(CalculatorStack.Pop());
                double left = double.Parse(CalculatorStack.Pop());
                double result = left * right;
                CalculatorStack.Push(result.ToString());
            }
            else if (t == "^")
            {
                double right = double.Parse(CalculatorStack.Pop());
                double left = double.Parse(CalculatorStack.Pop());
                double result = Math.Pow(left, right);
                CalculatorStack.Push(result.ToString());
            }
            else if (t == "sin")
            {
                double num = double.Parse(CalculatorStack.Pop());
                double result = Math.Sin(num);         
                CalculatorStack.Push(result.ToString());       
            }
            else if (t == "cos")
            {
                double num = double.Parse(CalculatorStack.Pop());
                double result = Math.Cos(num);         
                CalculatorStack.Push(result.ToString());       
            }
            else if (t == "max")
            {
                double right = double.Parse(CalculatorStack.Pop());
                double left = double.Parse(CalculatorStack.Pop());
                double result = Math.Max(left, right);
                CalculatorStack.Push(result.ToString());
            }
            else if (t == "x")
            {
                Console.WriteLine("Enter x:");
                string operand = Console.ReadLine();
                CalculatorStack.Push(operand);
                
            }
        }
    string answer = CalculatorStack.Pop();
    return double.Parse(answer);


        
    }
}