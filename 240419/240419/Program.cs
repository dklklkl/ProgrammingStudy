//2. 자료형 연습

//변수 선언
//자료형(int) 변수명(number) =(대입연산자) 값(10)
using System;

byte byteA = 0xFF;          //정수형 값을 저장, 8bit
short shortA = 0xFF;        //정수형 값을 저장, 16bit
int number = 10;            //정수형 값을 저장, 32bit
float pi = 3.141592f;       //실수형 값을 저장, 32bit, f를 통해 실수임을 표현(float에서만)
double pi2 = 3.14159265359; //실수형 값을 저장, 32bit, f필요없음
char character = 'a';       //문자형 값을 저장, 16bit
string name = "짱구";       //문자가변형, 여러 문자형 저장
bool isMoving = false;      //부울형, 8bit, 0(false)또는1(true)만 반환

//콘솔에 출력
Console.WriteLine(byteA);
Console.WriteLine(shortA);
Console.WriteLine(number);
Console.WriteLine(pi);
Console.WriteLine(pi2);
Console.WriteLine(character); //한줄복사 : Ctrl + D
Console.WriteLine(name); //한줄복사 : Ctrl + D
Console.WriteLine(isMoving); //한줄복사 : Ctrl + D

