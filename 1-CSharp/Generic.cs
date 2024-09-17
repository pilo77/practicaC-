
using System.Security.Cryptography;

var numbers = new MyList<int>(3);
var names = new MyList<string>(3);
var beers = new MyList<Beer>(3);
var persons=new MyList<Person>(3);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
names.Add("Carlos");
names.Add("dayana");
names.Add("maluma");
names.Add("Jbalvin");
persons.Add(new Person(){
    Id =1,
    Name = "Carlos"
    ,LastName = "Villamil"
});

beers.Add(new Beer(){
    Name = "Carlos Villamil",
    Price=5.5m, 
    age=12
});
beers.Add(new Beer(){
    Name = "Dussan",
    Price=5.5m, 
    age=12
});
beers.Add(new Beer(){
    Name = "losada",
    Price=59m, 
    age=19
});

Console.WriteLine(beers.GetContent());
Console.WriteLine(numbers); // Esto ahora funcionará correctamente
Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(persons.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);

        }

    }
    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ", ";

        }
        return content;
    }



}
public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int age{ get; set; }
    public override string ToString()
    {
        return $"el nombre {Name}+ price: + {Price} \n";
    }
}
public class Person
{ 
    public int Id { get; set;}
    public string Name { get; set; }
    public string LastName{ get; set; }

    public override string ToString()
    {
        return $"Se identifica con{Id} y tu nombre es {Name} y tua apellido es {LastName}";
    }


}


