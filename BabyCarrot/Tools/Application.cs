using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyCarrot.Tools
{
    //프로젝트의 폴더 위치를 반환하는 클래스
    public static class Application
    {
        public static string Root 
        {
            get 
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
