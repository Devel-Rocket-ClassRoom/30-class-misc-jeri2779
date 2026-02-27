using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 기본 쿼리 ===");
QueryBuilder qb = new QueryBuilder()
     .Select("*")
     .From("Users")
     .Where("Age > 18")
     .OrderBy("Name");
Console.WriteLine(qb);

class QueryBuilder

{
    private string _message = "";
    public QueryBuilder Select(string columns)
    {
        _message = columns;
        return this;
    }
    public QueryBuilder From(string table)
    {
        _message = table;
        return this; 
    }
    public QueryBuilder Where(string condition)
    {
        _message = condition;
        return this;
    }
    public QueryBuilder OrderBy(string columns)
    {
         
        _message = columns;
        return this;
    }
    public string Build()
    {
        return _message;
    }
}