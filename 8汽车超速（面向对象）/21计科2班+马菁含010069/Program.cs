using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21计科2班_马菁含010069
{

    public class Car
    {
        public string color;
        public string brand;
        public int speed;
        public event Action<int> SpeedChanged;
        public Car(string color, string brand)
        {
            this.color = color;
            this.brand = brand;
        }
        private Random a = new Random();
        public void GetSpeed()
        {
            speed = a.Next(1, 161);
            string time=DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            Console.WriteLine($"\n当前时间：{time} \n车速： {speed} km/h.");

            if (speed > 90)
            {
                Driver driver1 = new Driver("马菁含", 20, "女");
                Police police1 = new Police();
                police1.alert();
                driver1.response();
            }
            else
            {
                Console.WriteLine("当前车速正常。");
            }

            
        }

        public class Driver
        {
            public string name;
            public int age;
            public string gender;
            public Driver(string name, int age, string gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
            }
            public void response()
            {
                Console.WriteLine("司机回答：好的，我立即减速。");
            }
        }

        public class Police
        {
            public void alert()
            {
                Console.WriteLine("交警提示：您已超速。");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Car a = new Car("black", "aodi");
                a.SpeedChanged += OnSpeedChanged;

                for (int i = 0; i < 10; i++)
                {
                    a.GetSpeed();
                }
                Console.ReadLine();
            }

            private static void OnSpeedChanged(int speed)
            {
                Console.WriteLine($"车速已经改变，当前车速为：{speed} km/h");
            }

        }


    }
}
