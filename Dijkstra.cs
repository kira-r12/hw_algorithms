public class Dijkstra
    {
        private int PrioritiesOfOperator(string operators)
        {
            if (operators == "+" || operators == "-")
        {
            return 1;
        }
            if (operators == "/" || operators == "*")
        {
            return 2;
        }
            if (operators == "^")
        {
            return 3;
        }
            return 0;
        }
        public Queue Change(Queue input)
    {
        Queue output = new Queue();
        Stack stack = new Stack();

        while (input.Count() > 0)
        {
            string token = input.Dequeue();

            if (token.Length > 0 && char.IsDigit(token[0]) || token == "x")
            {
                output.Enqueue(token);
            }

            else if (token == "sin" || token == "cos" || token == "max")
            {
                stack.Push(token);
            }

            else if (token == "+" || token == "-" || token == "*" || token == "/" || token == "^")
            {
                int currentPrioritet = PrioritiesOfOperator(token);
                while (stack.Peek() != null && stack.Peek() != "(")
                {
                    string top = stack.Peek();
                    int topPrioritet = PrioritiesOfOperator(top);

                    if (token != "^" && currentPrioritet <= topPrioritet)
                    {
                        output.Enqueue(stack.Pop());

                    }
                    else if (token == "^" && currentPrioritet < topPrioritet)
                    {
                        output.Enqueue(stack.Pop());
                        
                    }
                    else
                    {
                        break;
                    }
                }
                stack.Push(token);
            }
        
            else if (token == "(")
            {
                stack.Push(token);
            
            }
            else if (token == ")")
            {
                while (stack.Peek() != null && stack.Peek() != "(")
                {
                    output.Enqueue(stack.Pop());
                }
                if (stack.Peek() == "(")
                {
                    stack.Pop();
                }
                if (stack.Peek() == "sin" || stack.Peek() == "cos" || stack.Peek() == "max")
                {
                    
                output.Enqueue(stack.Pop());
                }
            }
            else if (token == ",")
            {
                while (stack.Peek() != "(" && stack.Peek() != null)
                {
                    output.Enqueue(stack.Pop());
                }
            }
        }

        while (stack.Peek() != null)
        {
            output.Enqueue(stack.Pop());
        }
        return output;
    }
    }
