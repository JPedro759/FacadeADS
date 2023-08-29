import java.util.Scanner;

public class HelloWorld {
    public static void main(String[] args) {
        System.out.println("Selecione seu combo: ");
        System.out.println("1. Combo Master;");
        System.out.println("2. Super Combo;");
        System.out.print("Sua escolha: ");
        
        Scanner scanner = new Scanner(System.in);
        int op = scanner.nextInt();
        
        Combo combo = new Combo();
        combo.createCombo(op);
        
        combo.displayCombo();
    }
}

class Combo {
    private Burguer burguer = new Burguer();
    private Dessert dessert = new Dessert();
    private Drink drink = new Drink();
    
    public void createCombo(int op){
        if(op == 1) {
            this.burguer.setDescription("3 X-Bacon");
            this.burguer.setPrice(16.00);
            this.burguer.setGrams(400);
            
            this.dessert.setDescription("Pudim de leite condensado");
            this.dessert.setPrice(7.00);
            this.dessert.setSize(500);
            
            this.drink.setDescription("Coca cola");
            this.drink.setPrice(10.00);
            this.drink.setMilliliter(1000);
        } else {
            this.burguer.setDescription("2 X-Salada");
            this.burguer.setPrice(18.00);
            this.burguer.setGrams(400);
            
            this.dessert.setDescription("Sorvete de chocolate");
            this.dessert.setPrice(4.00);
            this.dessert.setSize(500);
            
            this.drink.setDescription("Guaraná Antarctica");
            this.drink.setPrice(5.00);
            this.drink.setMilliliter(600);
        }
    }
    
    public void displayCombo() {
        System.out.println("COMBO:");
        System.out.println(burguer.getDescription() + ", R$" + burguer.getPrice() + ", " + burguer.getGrams() + "g");
        System.out.println(dessert.getDescription() + ", R$" + dessert.getPrice() + ", " + dessert.getSize());
        System.out.println(drink.getDescription() + ", R$" + drink.getPrice() + ", " + drink.getMilliliter());
    }
}

class Product {
    private String description;
    private double price;
    
    public String getDescription() {
        return description;
    }
    
    public void setDescription(String description) {
        this.description = description;
    }
    
    public double getPrice() {
        return price;
    }
    
    public void setPrice(double price) {
        this.price = price;
    }
}

class Burguer extends Product {
    private int grams;
    
    public int getGrams() {
        return grams;
    }
    
    public void setGrams(int grams) {
        this.grams = grams;
    }
}

class Dessert extends Product {
    private int size;
    
    public int getSize() {
        return size;
    }
    
    public void setSize(int size) {
        this.size = size;
    }
}

class Drink extends Product {
    private int milliliter;
    
    public int getMilliliter() {
        return milliliter;
    }
    
    public void setMilliliter(int milliliter) {
        this.milliliter = milliliter;
    }
}
