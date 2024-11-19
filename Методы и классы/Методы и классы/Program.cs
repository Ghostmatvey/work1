Person Matvey = new Person();
string personName = Matvey.name;
int personAge = Matvey.age;
string personId=Matvey.id;
int personRost=Matvey.rost;
string personPol=Matvey.pol;
Console.WriteLine($"Имя: {personName}  \n Возраст {personAge} \n ID:{personId} \n Рост:{personRost} \n Пол:{personPol}");
Matvey.name = "Матвей";
Matvey.age = 18;
Matvey.id="mokrousov4";
Matvey.rost = 178;
Matvey.pol = "М";
Matvey.Print();
class Person
{
    public string name = "Undefined";  
    public int age;                   
    public string id;
    public int rost;
    public string pol;

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  \n Возраст: {age} \n ID:{id} \n Рост:{rost} \n Пол:{pol}");
    }
}
public class Perso
{
    string name="Matvey";
    public Perso(string name)
    {
        this.name = name;
    }
    public void Print() => Console.WriteLine($"Name: {name}");
    private string DoublesToString(string a, string b, string c)
    {
        return a + b+c;
        c= $"Имя: {a} Фамилия: {b} Отчёство: {a + b}";
    }
}






