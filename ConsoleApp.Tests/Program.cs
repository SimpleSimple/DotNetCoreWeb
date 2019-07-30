using System;
using System.Collections.Generic;

namespace ConsoleApp.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = new List<People>
            {
                new People{ ID=1,Age=12,Remark=new RemarkDetail { Remark="0.01",Weight=110.0} },
                new People{ ID=2,Age=20,Remark=new RemarkDetail { Remark="0.02",Weight=120.0} },
                new People{ ID=3,Age=30,Remark=new RemarkDetail { Remark="0.03",Weight=140.0} },
            };
            peoples.ForEach(q =>
            {
                if (q.Age <= 18)
                {
                    q.Remark.Remark = "青年";
                    q.Remark.Weight = 120.0;
                }
                else if (q.Age >= 30)
                {
                    q.Remark.Remark = "壮年";
                    q.Remark.Weight = 160.0;
                }
                else
                {
                    q.Remark.Remark = "未知";
                    q.Remark.Weight = 0.0;
                }
            });

            peoples.ForEach(q => Console.WriteLine(q.ID + " " + q.Age + " " + q.Remark.Remark + " " + q.Remark.Weight));
        }

        internal class People
        {
            public int ID { get; set; }
            public int Age { get; set; }
            public RemarkDetail Remark { get; set; }
        }

        internal class RemarkDetail
        {
            public int ID { get; set; }
            public string Remark { get; set; }
            public double Weight { get; set; }
        }
    }


}
