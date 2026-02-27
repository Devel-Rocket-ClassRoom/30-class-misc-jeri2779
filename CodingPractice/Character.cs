using System;


public partial class Character
{
    private readonly string _name;
    private int _health;
    private int _level;

    public string Name { get { return _name; } }
    public int Health { get { return _health; } }
    public int Level { get { return _level; } }

    public Character(string name)
    {
        _name = name;
        _health = 100;
        _level = 1;
    }
}
public partial class Character
{
    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0)
        {
            _health = 0;
        }
        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입음. 남은 체력: {_health}");
    }
    public void Heal(int amount)
    {
        _health += amount;
        Console.WriteLine($"{_name}이(가) {amount}만큼 회복함. 현재 체력: {_health}");
    }
}


