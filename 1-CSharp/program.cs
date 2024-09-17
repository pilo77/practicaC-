//Sale sale = new Sale();
//var sale = new Sale();
//Sale sale = new();
using System.Dynamic;

var sale = new Sale(3);
var message = sale.GetInfo();
Console.WriteLine(message); 

//al final de un decimal colocamo las m
var tax = new SaleWithTax(15,33.3m);
message= tax.GetInfo();
Console.WriteLine(message);
message = tax.GetInfoWithtaxt();   
Console.WriteLine(message);

class SaleWithTax: Sale
{
    public decimal Tax { get; set; }
    public SaleWithTax (decimal total, decimal Tax):base(total)
    {
        this.Tax = Tax; 
    }
    public string GetInfoWithtaxt() 
    {
        return $"el total es {Total} impuesto es: {Tax}" ;
    
    }
    public override String GetInfo() {

        return $"el total es {Total} impuestoooo es: {Tax}";
    }
    // Pueden existir la sobre carga de metodo solo si hay parametros diferentes
    public string GetInfoWithtaxt(string message) { 
        return message ;
    }
}

class Sale
{
    public decimal Total { get; set; }
    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
         return "El total es "+Total;          
    }


}