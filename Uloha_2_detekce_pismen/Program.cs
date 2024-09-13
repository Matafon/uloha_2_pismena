Console.WriteLine("Napiš znak.");

char znak = Console.ReadKey().KeyChar;
Console.WriteLine();

if (char.IsLower(znak))
{
    Console.WriteLine($"{znak} patří mezi malá písmena.");
}
else if (char.IsUpper(znak))
{
    Console.WriteLine($"{znak} patří mezi velká písmena.");
}
else if (char.IsDigit(znak))
{
    Console.WriteLine($"{znak} je číslice.");
}
else if (znak == '!')
{
    Console.WriteLine("Vykřičník");
}
else if (znak == '?')
{
    Console.WriteLine("Otazník");
}
else if (znak == '*')
{
    Console.WriteLine("Hvězdička");
}
else if (znak == '@')
{
    Console.WriteLine("Zavináč");
}
else if (znak == '#')
{
    Console.WriteLine("křížek");
}
else
{
    Console.WriteLine("Jiný znak.");
}