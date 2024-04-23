//9. 반복문

using System.Diagnostics.CodeAnalysis;

public class Student
{
    public static void Main()
    {
        /*for 반복문 : 10번 반복하는 반복문
        //초기화자; 조건; 증감;
        for(int i = 0; i < 10; i++)
        {

        }*/

        /*foreach 반복문
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach(int number in numbers)
        {

        }*/

        /*while 반복문 : 10번 반복하는 반복문
        int j = 0;
        while (j < 10)
        {
            j++;
        }*/

        /*do-while 반복문 : 최소 한번은 실행되는 반복문
        int z = 0;
        do
        {
            z++;
        } while (z < 10);*/

        //실습1. 0~10까지 반복해서 더한 값을 출력하는 프로그램
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            sum = sum + i; //sum +=i;            
        }
        Console.WriteLine(sum);


        //실습2. 배열의 값을 더하는 프로그램
        int[] numberArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        sum = 0;
        foreach(int number in numberArray) 
        {
            sum += number;            
        }
        Console.WriteLine(sum);
        Console.WriteLine("평균 : " + sum / numberArray.Length);

        sum = 0;
        for (int i = 0; i < numberArray.Length; i++)
        {
            sum += numberArray[i];
        }
        Console.WriteLine(sum);

        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        list.Add(3);
        sum = 0;
        foreach(int number in list)
        {
            sum += number;
        }
        Console.WriteLine("합계 : " + sum + " / 평균 : " + (sum / list.Count));

        /*실습3. 이름 리스트에서 내 이름이 있는지 확인하고, 
        //있다면 찾았습니다.해당이름은 몇번째에 있습니다. 없다면 없습니다. 출력하는 프로그램
        //List<string> names = new List<string>() {};

        List<string> names = new List<string>() { "a", "b", "c", "d", "e", "f", "g" };
        string name = Console.ReadLine();
        bool isExsist = names.Contains(name);
        int index = names.IndexOf(name);
        if(isExsist)
        {
            Console.WriteLine("찾았습니다.");
            Console.WriteLine("해당 이름은 " + index + "번째에 있습니다.");
        }
        else
        {
            Console.WriteLine("없습니다.");
        }

        int g = 0;
        foreach(string name2 in names)
        {
            if(name2 == "a")
            {
                Console.WriteLine("찾았습니다. a는 " + g + "번째에 있습니다.");
            }
            else
            {
                Console.WriteLine("없습니다.");
            }
        }*/

        //반복문 안의 반복문
        //구구단 예
        //2단 2x1=2 / 2x2=4 ... / 2x9=18
        //3단 3x1=3 / 3x2=6 ... / 3x9=27
        //...
        for(int x = 2; x < 10; x++)
        {
            Console.WriteLine(x + "단");
            for(int y = 1; y < 10; y++)
            {
                Console.WriteLine($"{x}단: {x} X {y} = {x*y}");
            }
        }
    }
}