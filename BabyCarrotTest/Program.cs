using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyCarrot.Tools;

namespace BabyCarrotTest
{
    /// <summary>
    /// BabyCarrot 라이브러리를
    /// 테스트 하는 프로젝트
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 사용방법 1
            // using BabyCarrot.Tools;
            // 정적메소드 Application.Root 호출

            // 사용방법 2
            // Console.WriteLine(BabyCarrot.Tools.Application.Root);
            Console.WriteLine(Application.Root);
            Console.ReadLine();
        }
    }
}
