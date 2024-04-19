//1.코딩 규칙 연습
//내용

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); //한 줄 주석 : Ctrl + K + C
Console.WriteLine("Hello, World!"); //한 줄 주석 해제 : Ctrl + K + U
Console.WriteLine("Hello, World!"); //영역 주석 : Ctrl + Shift +/ (주석 해제 동일)

//변수의 이름은 명사, be+형용사
int countNumber = 0; //camelCase : 변수, 중간 앞글자 대문자
int a = 10; //(나쁜 예)변수의 의미 //주석은 최대한 없는 게 좋음
int totalNumber = 10;
bool isActive = true;

//함수의 이름은 동사
//함수(function) : 클래스 외에 사용시
//메서드(method) : 클래스 내부에서 사용시
void Move()
{

}

void LoopSystem() //PascalCase : 함수, 앞글자마다 대문자
{
    
}

if(countNumber == 0) //괄호같은 거 tab 누르면 자동입력
{
    //tab : 들여쓰기, shift + tab : 들여쓰기 없어짐

    for(int i = 0; i < a; i++)
    {
        countNumber++;
    }

    for (int i=0; i < totalNumber; i++)
    {
        countNumber++; 
    }
}