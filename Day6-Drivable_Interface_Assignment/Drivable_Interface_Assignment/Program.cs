using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivable_Interface_Assignment
{

    public interface IDrivable {


        void Start();
        void Stop();
        void Drive();
    
    }

    class car : IDrivable {


        public string Name { get; set; }

        public car(string Name) {
            this.Name = Name;
        }

        public void Stop() {
            Console.WriteLine(Name +" is stop");
        }
        public void Start() {
            Console.WriteLine(Name+"is start");
        
        }
        public void Drive() {
            Console.WriteLine(Name+" is Drive");
        }
    }

    class Bicycle : IDrivable {

        public string Name { get; set; }

        public Bicycle(string Name) {
            this.Name = Name;
        }
        public void Stop()
        {
            Console.WriteLine(Name+" is stop");
        }
        public void Start()
        {
            Console.WriteLine(Name+" is start");

        }
        public void Drive()
        {
            Console.WriteLine(Name+" Bicycle is Drive");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car("TATA");
            car c2 = new car("swift");
            Bicycle b1 = new Bicycle("b1");
            Bicycle b2 = new Bicycle("b2");

            IDrivable[] id = { c1, c2, b1, b2 };

            foreach (var i in id) {
                i.Stop();
                i.Start();
                i.Drive();
            }


        }
    }
}
