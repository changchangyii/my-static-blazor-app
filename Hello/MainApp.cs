using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                Console.WriteLine(i + "*" + j + "=" + i*j );
            }
            WriteLine("Hello!"); // Hello, World를 프롬프트에 출력
        }
    }
}
