using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selecione seu combo: ");
        Console.WriteLine("1. Combo Master;");
        Console.WriteLine("2. Super Combo;");
        Console.Write("Sua escolha: ");

        int op = Convert.ToInt32(Console.ReadLine());

        Combo combo = new Combo();
        combo.CreateCombo(op);

        combo.DisplayCombo();
    }
}

class Combo
{
    private Burguer burguer = new Burguer();
    private Dessert dessert = new Dessert();
    private Drink drink = new Drink();

    public void CreateCombo(int op)
    {
        if (op == 1)
        {
            this.burguer.Description = "3 X-Bacon";
            this.burguer.Price = 16.00;
            this.burguer.Grams = 400;

            this.dessert.Description = "Pudim de leite condensado";
            this.dessert.Price = 7.00;
            this.dessert.Size = 500;

            this.drink.Description = "Coca cola";
            this.drink.Price = 10.00;
            this.drink.Milliliter = 1000;
        }
        else
        {
            this.burguer.Description = "2 X-Salada";
            this.burguer.Price = 18.00;
            this.burguer.Grams = 400;

            this.dessert.Description = "Sorvete de chocolate";
            this.dessert.Price = 4.00;
            this.dessert.Size = 500;

            this.drink.Description = "Guaraná Antarctica";
            this.drink.Price = 5.00;
            this.drink.Milliliter = 600;
        }
    }

    public void DisplayCombo()
    {
        Console.WriteLine("COMBO:");
        Console.WriteLine($"{burguer.Description}, R${burguer.Price}, {burguer.Grams}g");
        Console.WriteLine($"{dessert.Description}, R${dessert.Price}, {dessert.Size}");
        Console.WriteLine($"{drink.Description}, R${drink.Price}, {drink.Milliliter}");
    }
}

class Product
{
    public string Description { get; set; }
    public double Price { get; set; }
}

class Burguer : Product
{
    public int Grams { get; set; }
}

class Dessert : Product
{
    public int Size { get; set; }
}

class Drink : Product
{
    public int Milliliter { get; set; }
}
