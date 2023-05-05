using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        // static void Main(string[] args) 에서
        // (string[] args)는 매개변수
        // []은 배열의 표시
        // 들어오는 것은 args라는 이름으로 들어온다
        // 코드를 수정한 다음 항상 bulid를 해야 한다.
        {
            Console.WriteLine("Hello C sharp");
            Console.WriteLine("Hello " + args[0]);

            Console.ReadKey();
        }
    }
}
