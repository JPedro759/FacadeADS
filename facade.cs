using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selecione seu combo: ");
        Console.WriteLine("1. Combo Master;");
        Console.WriteLine("2. Super Combo;");
        Console.Write("Sua escolha: ");
        int op = int.Parse(Console.ReadLine());
        
        Combo combo = new();
        combo.createCombo(op);
        
        combo.displayCombo();
    }
}

public class Combo {
    private Burguer burguer = new();
    private Dessert dessert = new();
    private Drink drink = new();
    
    public void createCombo(int op){
        if(op == 1) {
            this.burguer.Description = "3 X-Bacon";
            this.burguer.Price = 16.00;
            this.burguer.Grams = 400;
            
            this.dessert.Description = "Pudim de leite condensado";
            this.dessert.Price = 7.00;
            this.dessert.Size = 500;
            
            this.drink.Description = "Coca cola";
            this.drink.Price = 10.00;
            this.drink.Milliliter = 1000;
        } else {
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
    
    public void displayCombo() => Console.WriteLine($"COMBO:\n{burguer.Description}, R${burguer.Price}, {burguer.Grams}g\n{dessert.Description}, R${dessert.Price}, {dessert.Size}\n{drink.Description}, R${drink.Price}, {drink.Milliliter}");
}

public class Product{
    private string _description;
    private double _price;
    
    public string Description { get => _description; set => _description = value; }
    public double Price { get => _price; set => _price = value; }
}

public class Burguer : Product{
    private int _grams;
    
    public int Grams { get => _grams; set => _grams = value; }
    
}

public class Dessert : Product{
    private int _size;
    
    public int Size { get => _size; set => _size = value; }
}

public class Drink : Product{
    private int _milliliter;
    
    public int Milliliter { get => _milliliter; set => _milliliter = value; }
}
