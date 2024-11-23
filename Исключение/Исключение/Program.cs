using System.Text.RegularExpressions;

double? one = null, two = null;
string? znak = null ;
Console.WriteLine("Введите значения первого числа");
            one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак дейстия (+ * - / )");
            znak = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите значения первого числа");
            two = Convert.ToDouble(Console.ReadLine());
    if (znak == "+")
            {
                Console.WriteLine($"Ответ:{one + two}");
            }
            else
            {
                if (znak == "-")
                {
                    Console.WriteLine($"Ответ:{one - two}");
                }
                else
                {
                    if (znak == "*")
                    {
                        Console.WriteLine($"Ответ:{one * two}");
                    }
                    else
                    {
                        if (znak == "/")
                        {
                if(two == 0)
                {
                    Console.WriteLine("Вторая переменная не может принимать значение 0 при делении");
                }
                else Console.WriteLine($"Ответ:{one / two}");
                        }
                    }
                }
            }
    try 
    { 
        if (IsValidznak(znak)){}
            else Console.WriteLine("Знак введён неверно");

    }     
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Некорректный формат числа. Используйте точку ',' в качестве десятичного разделителя.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Вот ваше уравнени {one}{znak}{two}");
        }
    
    static bool IsValidznak(string znak)
        {
        string patern = @"[\+\-\*\/]";
        return Regex.IsMatch(znak, patern);
        }
