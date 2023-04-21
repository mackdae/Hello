using System;
using static System.Console;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, C# World!");
            WriteLine("");
            WriteLine("여러분, 안녕하세요?");
            WriteLine("반갑습니다.");
            WriteLine("");
            WriteLine("C# 어렵지 않아요~");
            WriteLine("우리 같이!");
            WriteLine("익숙해져봅시다~");

            //변수: 데이터를 담는 일정 크기의 공간
            int x; //변수선언
            x = 100; //데이터할당 //초기화: 최초의 데이터할당
            int y = 100;
            //int데이터형식, y식별자(변수명), =대입연산자, 100리터럴(데이터값), ;종료

            //기본 데이터 형식 / 복합 데이터 형식: 구조체, 클래스, 배열 등
            //값형식(스택) / 참조형식(힙)
            //스택은 다 쓴 데이터 자진수거, 힙은 불필요 데이터 가비지컬렉터로 수거

            // 값형식 - 스택 메모리 - short, int, long, ..., 구조체(Struct)
            // 참조형식 - 힙 메모리 - 복합 데이터 형식, 클래스(Class)
        }
    }
}