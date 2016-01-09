using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskConsole
{
    public delegate void Del(string message);
    class Program
    {
        static void Main(string[] args)
        {
            //Del del = DelegateMethod;
            //del("this is delegage");
            //MethodWithCallBack(1,2,del);

            /*多项委托
                MethodClass obj = new MethodClass();
                Del d1 = obj.method1;
                Del d2 = obj.method2;
                Del d3 = DelegateMethod;
                Del allmehtodDel = d1 + d2;
                allmehtodDel += d3;
                allmehtodDel("");
             */
          //  Task t = Task.Factory.StartNew(()=>Console.WriteLine("0"));
            TaskReturnValue.Run();

            Console.Read();
        }
        public static void DelegateMethod(string mes)
        {
            Console.WriteLine("method3");
        }

        public static void MethodWithCallBack(int para1, int para2, Del callback)
        {
            callback("The number is:" + (para1 + para2).ToString());
        }
    }
    class MethodClass
    {
        public void method1(string mess) { Console.WriteLine("method1"); }
        public void method2(string mess) { Console.WriteLine("method2"); }
    }
}
