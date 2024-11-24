string orig = "Семён Владимирович";
string ё = "ё";
string рови = "рови";
string Tolower = "семён владимирович";
string origcop = "Семён Владимирович";
string onechas = "Семён";
string onechascop = "семён";
string twochas = "Владимирович";

// Операторы == и !=
Console.WriteLine($"orig == Tolower: {orig == Tolower}"); // False (чувствительно к заглавным буквам)
Console.WriteLine($"orig == origcop: {orig == origcop}"); // True
Console.WriteLine($"orig != Tolower: {orig != Tolower}"); // Trueтому что не равно
Console.WriteLine($"orig != origcop: {orig != origcop}"); // False
Console.WriteLine();
// Метод Equals()- аналогичено == но лучше
bool Equales1 = orig.Equals(Tolower);
Console.WriteLine($"orig.Equales(ToLower): {Equales1}");
bool Equales2 = orig.Equals(origcop);
Console.WriteLine($"orig.Equales(origcop): {Equales2}");
Console.WriteLine();
//Compare() - сравнивает первый символ
int result = string.Compare(onechas, twochas);
if (result < 0)
{
    Console.WriteLine($"Строка: {onechas} будет стоять перед строки: {twochas}");
}
else if (result > 0)
{
    Console.WriteLine($"Строка: {onechas} будет стоять после строки: {twochas}");
}
else
{
    Console.WriteLine($"Строка: {onechas} и {twochas} одинаковы");
}
Console.WriteLine();
//Метод CompareOrdinal()- сравнение с учётом заглавных и  строковых букв
int oneandtwo;
oneandtwo = String.CompareOrdinal(onechas, onechascop);  
Console.WriteLine($"onechas и onechascop: {oneandtwo}");
oneandtwo = String.CompareOrdinal(onechas, twochas);
Console.WriteLine($"onechas и twochas: {oneandtwo}");
Console.WriteLine();
//Метод IndexOf()
int loadingё = orig.IndexOf(ё); 
Console.WriteLine($"Буква {ё} находится в :{loadingё} знаке");
int посикрови = orig.IndexOf(рови);
Console.WriteLine($"Фрагмент {рови} начинается с :{посикрови} знака");
Console.WriteLine();
// Метод Contains()
double[] number = { 18.5, 78, 0, -65.2 };

bool естьли18 = number.Contains(18.5);     // true
Console.WriteLine($"В массиве {естьли18} заданное число");

bool естьли60 = number.Contains(60);     // false
Console.WriteLine($"В массиве {естьли60} заданное число");