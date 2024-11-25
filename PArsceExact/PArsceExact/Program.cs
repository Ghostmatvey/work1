using System.Globalization;

string zhisla = "12345";
string czapztoi = "123,45"; 
string ctozhkoi = "12345.67";
string data = "2024-10-26";
string datainazhe = "26.10.2024";
string datapropis = "October 26, 2024";

//Parse-для int
int PArce1 = int.Parse(zhisla);
double Parce2 = double.Parse(czapztoi);
decimal Parce3 = decimal.Parse(czapztoi);
Console.WriteLine($"int={PArce1}  Double={Parce2}  decimak={Parce3}");
Console.WriteLine();
//ParseExact() - для DateTime
DateOnly convertdatatire, convertdata;
convertdatatire = DateOnly.ParseExact(data, "yyyy-MM-dd", CultureInfo.InvariantCulture);
Console.WriteLine($"DateTime.ParseExact: {convertdatatire}");
convertdata = DateOnly.ParseExact(datainazhe, "dd.MM.yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"DateTime.ParseExact: {convertdata}");
Console.WriteLine();
// TryParse() - для double
Console.WriteLine("Введите число с запятой:");
string? welcom = Console.ReadLine();

bool chec = double.TryParse(welcom, out var by);
if (chec == true)
    Console.WriteLine($"Преобразование прошло успешно. Число: {by}");
else
    Console.WriteLine("Преобразование завершилось неудачно возможно вы использовали точку вместо запятой");
Console.WriteLine();
// TryParseExact() - для DateTime
chec = DateOnly.TryParseExact(datapropis, "MMMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertdata);
Console.WriteLine($"Из string значения {datapropis} мы получаем {convertdata} в значении DataOnly");
