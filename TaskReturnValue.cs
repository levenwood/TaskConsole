using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskConsole
{
   public  class TaskReturnValue
    {
       class Test
       {
           public string name { get; set; }
           public double value { get; set; }
       }
       public static void Run()
       {
           //Task.Factory提供对用于创建 Task 和 Task<TResult> 实例的工厂方法的访问。
           Task<int> t1 = Task.Factory.StartNew(()=>1);

           Console.WriteLine(t1.Result);
          
           Task<Test> t2 = Task<Test>.Factory.StartNew(()=>{
               string name = ".net";
               double value = 4.0;
               return new Test() { name=name,value=value};
           });
           Console.WriteLine("name:{0},value:{1}", t2.Result.name, t2.Result.value);
           Task<System.IO.FileInfo[]> t3 = Task<System.IO.FileInfo[]>.Factory.StartNew(() => {
               string path = @"C:\Users\wuyanchao\Pictures";
               string[] files = System.IO.Directory.GetFiles(path);
               var result =( from file in files
                            let info = new System.IO.FileInfo(file)
                            where info.Extension!=null
                            select info).ToArray();
               return result;
           });
           foreach (var file in t3.Result)
           {
               Console.WriteLine(file.FullName);
           }
       }
    }
}
