using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_class
{
    partial class TheClass {
        public void show1() {
            Console.WriteLine("show1");
        }

        public virtual void show3(){
            Console.WriteLine("show3");
        }
    }

    partial class TheClass {
        private string _name;
        public string name {
            set { _name = value; }
            get { return _name; }
        }

        public void show2() {
            Console.WriteLine("show2");
        }
    }

    class TheClass2 : TheClass {
        /*public new void show3() {
            Console.WriteLine("show3 again");
        }*/
        public override void show3()
        {
            Console.WriteLine("show3 again");
        }
    }

    abstract class TheClass3 {
        public string name;
        public abstract void show1();
    }
    class TheClass4 : TheClass3 {
        public override void show1() {
            Console.WriteLine("abs override");
        }
    }

    sealed class TheClass5 { 
        public void show(){
            Console.WriteLine("sealed");
        }
    }

    /*class TheClass6 : TheClass5 {
        public void show1() {
            Console.WriteLine("sealed 2");
        }
    }*/

    class base1 {
        public base1(string name) {
            Console.WriteLine("base1 - "+name);
        }
    }
    class son1 : base1 { 
        public son1(string name, string son) : base(name){
            Console.WriteLine("son1 - "+name+","+son);
        }
    }

    public interface IPerson {
        void show();
    }

    public interface IPerson2 : IPerson {
        void show();
        void print();
    }

    class Person : IPerson2 { 
        public void show(){
            Console.WriteLine("show person");
        }
        public void print() {
            Console.WriteLine("print person");
        }
    }
    class Program
    {
        /// <summary>
        /// @William Aiden
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TheClass tc = new TheClass();
            tc.show1();
            tc.show2();

            tc.name = "222";
            Console.WriteLine(tc.name);
            TheClass tc2 = new TheClass2();
            tc2.show3();

            //TheClass3 tc3 = new TheClass3();
            TheClass3 tc3 = new TheClass4();
            tc3.show1();
            tc3.name = "abs";

            TheClass5 tc5 = new TheClass5();
            tc5.show();
           
            son1 s1 = new son1("zhangsan","lisi");
            Console.WriteLine("---------");
            base1 b1 = new son1("wanger","mazi");

            IPerson p1 = new Person();
            p1.show();
            IPerson2 p2 = new Person();
            p2.show();
            p2.print();
        }
    }
}
