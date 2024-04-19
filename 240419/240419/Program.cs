//3. 배열 연습

int number1;
int number2;
int number3;

int[] numbers = new int[3]; //배열의 크기를 정의

//배열의 초기화 방법1
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

int[] numbers2 = { 4, 5, 6 };           //배열의 초기화 방법2
int[] numbers3 = new int[3]{ 4, 5, 6 }; //배열의 초기화 방법3

//배열의 길이 출력
int length = numbers.Length;
Console.WriteLine("배열의 길이 : " + numbers.Length);

numbers.Reverse(); //배열을 역순으로

//3X3 배열의 2차원 선언
int[,] coordinates = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};
Console.WriteLine("0,1의 값 : " + coordinates[0, 1]);
Console.WriteLine("2,1의 값 : " + coordinates[2, 1]);
Console.WriteLine("배열의 길이 : " + coordinates.Length);

//실습1. 가로3칸, 세로2칸 책꽂이에 문자열형 책 이름을 넣고
//2번째 줄의 3번째 칸의 책 이름을 출력한다.

string[,] bookShelf =
{
    {"짱구", "철수", "맹구"},
    {"훈이", "유리", "짱아"}
};

bookShelf[1, 2] = "흰둥이";

Console.WriteLine("1,2의 책 이름 : " + bookShelf[1, 2]); //인덱스는 0부터 시작

//실습2. 두 개의 숫자, 연산자 입력을 받아 사칙연산계산기 만들기
Console.WriteLine("첫 번째 숫자 입력");
string strA = Console.ReadLine();
float numberA = float.Parse(strA);
Console.WriteLine("연산자 입력(+,-,*,/)");
string oper = Console.ReadLine();
Console.WriteLine("두 번째 숫자 입력");
string strB = Console.ReadLine();
float numberB = float.Parse(strB);

float result = 0;

switch(oper)
{
    case "+":
        result = numberA + numberB;
        break;
    
    case "-":
        result = numberA - numberB;
        break;

    case "*":
        result = numberA * numberB;
        break;

    case "/":
        result = numberA / numberB;
        break;
        //result = numberA / (float)numberB; //명시적 형변환 //A,B를 int로 받았을 때
}


Console.WriteLine("결과 : " + result);