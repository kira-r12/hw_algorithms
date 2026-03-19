public class Tokens
{
    public Queue GetTokens()
    {
        Console.WriteLine("Enter:");
        string input = Console.ReadLine();

        Queue Token = new ();
        string Buffer = "";

        foreach (char s in input)
        {
            if (char.IsDigit(s) || char.IsLetter(s))
        { 
            Buffer += s;      
        }
            else if (char.IsWhiteSpace(s))
        {
            if (Buffer != "")
            {
                Token.Enqueue(Buffer);
                Buffer = "";
            }
        }
        else 
        {
            if (Buffer != "")
            {
                Token.Enqueue(Buffer);
                Buffer = ""; 
            } 
            Token.Enqueue(s.ToString());
        }
    }
    if (Buffer != "")
    {
        Token.Enqueue(Buffer);
    }
    return Token;
}
}