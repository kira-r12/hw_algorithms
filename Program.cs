Tokens token = new Tokens();
Queue tokensQueue = token.GetTokens();
Dijkstra dijkstra = new Dijkstra();
Queue postfixQ = dijkstra.Change(tokensQueue);


Calculator calculator = new Calculator();
double result = calculator.Calculate(postfixQ);

Console.WriteLine($"result: {result}");
