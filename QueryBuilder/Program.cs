using System;
using System.Text;

Console.WriteLine("=== 기본 쿼리 ===");
QueryBuilder qb1 = new QueryBuilder()
     .Select("*")
     .From("Users");
Console.WriteLine(qb1);

Console.WriteLine("=== 조건 쿼리 ===");
QueryBuilder qb2 = new QueryBuilder()
     .Select("Name, Age")
     .From("Users")
     .Where("Age > 18");
Console.WriteLine(qb2);

Console.WriteLine("=== 정렬 쿼리 ===");
QueryBuilder qb3 = new QueryBuilder()
     .Select("*")
     .From("Products")
     .Where("Price > 1000")
     .OrderBy("Price");
Console.WriteLine(qb3);

class QueryBuilder

{
    private string _select = "";
    private string _from = "";
    private string _where = "";
    private string _orderBy = "";
    public QueryBuilder Select(string columns)
    {
        _select = $"SELECT {columns}";

        return this;
    }
    public QueryBuilder From(string table)
    {
        _from = $"FROM {table}";

        return this;
    }
    public QueryBuilder Where(string condition)
    {
        _where = $"WHERE {condition}";

        return this;
    }
    public QueryBuilder OrderBy(string columns)
    {
        _orderBy = $"ORDER BY {columns}";
        return this;
    }
    public string Build()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("SELECT ");
        sb.Append(_select);

        sb.Append(" FROM ");
        sb.Append(_from);

        if (!string.IsNullOrEmpty(_where))
        {
            sb.Append(" WHERE ");
            sb.Append(_where);
        }

        if (!string.IsNullOrEmpty(_where))
        {
            sb.Append(" WHERE ");
            sb.Append(_where);
        }
    }
}