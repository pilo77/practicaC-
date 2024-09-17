using System.Text.Json;


var hector = new People()
{
    Name ="Carlos Villamil",
    Age=22
};
//PARA PASAR UN OBJETO A UN JSON SE UTILIZAR EL SERIALIZE
string json= JsonSerializer.Serialize(hector);

Console.WriteLine(json);

string myJson = @"{

""Name"":""Carlos Villamil"",
""Age"":22
}";

People juan = JsonSerializer.Deserialize<People>(myJson);   
//PARA PASAR DE UN JSON A UN OBJETO SE UTILIZA EL DESERIALIZE
public class People
{
    public string Name { get; set; }
    public int Age {  get; set; }
    public static String Gete() => "Hola funcion flecha";

}
