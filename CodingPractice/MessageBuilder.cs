public class MessageBuilder
{
    private string _message = "";

    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;
    }


    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }

    public MessageBuilder AddSpace(string s)
    {
        _message += s;
        return this;
    }

    public MessageBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }

    public MessageBuilder AddNewLine(string s)
    {
        _message += "\n" + s;
        return this;
    }
    public string Build()
    {
        return _message; 
    }
}


