using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество градусов угла");
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество минут угла");
            double minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество секунд угла");
            double seconds = double.Parse(Console.ReadLine());

            Angle angle = new Angle(grade, minutes, seconds);  //создание объекта класса Angle

            Console.WriteLine("Значение  угла в радианах=" + angle.ToRadians());
            Console.ReadKey();
        }

        public class Angle      //объявление класса Angle
        {
            double grade;
            double minutes;
            double seconds;
        }
        public double Grade     //свойство для поля
        {
            get
            {
                return grade;
            }
            set
            {
                if (value >= 0 && value < 360)
                    grade = value;
                else
                    grade = 0;
            }
        }
        public double Minutes       //свойство для поля
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else
                    minutes = 0;
            }
        }
        public double Seconds       //свойство для поля
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value >= 0 && value < 60)
                    seconds = value;
                else
                    seconds = 0;
            }
        }
        public Angle(double grade_, double minutes_, double seconds_)
        {
            Grade = grade_;
            Minutes = minutes_;
            Seconds = seconds_;
        }


        public double ToRadians()      //метод перевода в радианы
        {
            var radians = (Grade + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
            return radians;

        }
    }
}