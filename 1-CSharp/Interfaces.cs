
var valor = new Valor();
var beer=new Beer();

Some(valor);
Some(beer);  

void Some( ISave save) { 

    save.Save();    
}

interface ISale
{
    decimal Total { get; set; }
}

interface ISave
{
    public void Save();
}

public class Valor : ISale, ISave
{ 
    public decimal Total { get; set; }

    public void Save() 
    {
        Console.WriteLine("se aguardado correctamente");
    
    } 
}

public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("se aguardado correctamente");

    }
}