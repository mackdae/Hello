﻿using System; // using키워드 // System(네임스페이스) 사용
using static System.Console; // System의 Console(클래스) 사용
// 상단에 참조를 미리 써두면 하단에 경로 생략 가능
/* 문단주석
(중첩시 에러) */

namespace Hello
{
    class MainApp
    {
        static void Main(string[] args) //string배열타입 사용자 입력값 받음
        // Main 프로그램의 진입점 (실행 시작점)
        // 모든 프로그램은 Main 메소드를 하나 포함해야 함 // 메소드 = 함수
        // static한정자 void반환형식 Main메소드명 ()매개변수 {}코드블록
        {
            if (args.Length == 0) //만약 입력값이 없으면
            {
                Console.WriteLine("사용법 : Hello.exe <이름>"); //사용법 출력
                return; //메소드 종료
            }

            WriteLine("Hello, {0}!", args[0]); //사용자 입력값을 출력
        }
    }
}
// 절차적지향언어: c, c++
// 객체지향언어: c#, 자바, 파이썬

// \n 개행문자(줄바꿈)

// \ 역슬래시 백슬래시
// 마이크로소프트의 기본 한국어 글꼴과 기본 일본어 글꼴은 
// 백슬래시를 각각 원화 기호(₩)와 엔화 기호(¥)로 그려서 국제적인 소통에 혼동을 일으킴
// \(U+005C), ₩(U + 20A9), ¥(U + 00A5)