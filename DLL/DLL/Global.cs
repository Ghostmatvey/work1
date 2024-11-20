using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Global
    {
        /// <summary>
        /// Функция приветствует человека и завлекает его 
        /// </summary>
        /// <param name="name"></param>
        public void NameAge(string name)
        {
            string Name;
            int Age, nextAge, Rost,nicerost;
            
            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();
            Console.WriteLine("Теперь введите ваш возраст");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите свой рост в см");
            Rost = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Здравствуйте {Name} я ваш помошник. \n В ваши {Age} лет я помогу вам стать лучше и расчитаю при росте {Rost} примерную идеальную массу тела");
            nextAge = NewAge(Age);
            nicerost= Newhieght(Rost);
            Console.WriteLine($"В {nextAge} вы почувствуете себя моложе и красивее, прийдёте или останитесь в своей идеальной форме с весом в {nicerost}кг");
        }
        /// <summary>
        /// Функция считает возраст человека через 5 лет
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        private int NewAge(int age)
        {
            return age + 5;
        }
        /// <summary>
        /// Рассчитывает примерную идеальную массу тела человека
        /// </summary>
        /// <param name="rost"></param>
        /// <returns></returns>
        public int Newhieght(int rost)
        {
            return rost - 110;
        }
    }
}
