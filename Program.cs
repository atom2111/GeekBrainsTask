using System;

namespace GeekBrains_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Алгоритм задачи с друзьями и собакой.
            //Нужно узнать какое кол-во раз собака пройдет от 1 друга до 2

            int count = 0;
            int distance = 10000;
            int firstFriendSpeed = 1;
            int secondFriendSpeed = 2;
            int dogSpeed = 5;
            int friend = 2;

            while (distance > 10)
            {
                if (friend == 1)
                {
                    var time = distance / (firstFriendSpeed + dogSpeed);
                    friend = 2;
                    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
                    count++;
                }
                else if (friend == 2)
                {
                    var time = distance / (secondFriendSpeed + dogSpeed);
                    friend = 1;
                    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
                    count++;
                }
            }
            Console.WriteLine($"Собака пробежала {count} раз.");
        }
    } 
}
