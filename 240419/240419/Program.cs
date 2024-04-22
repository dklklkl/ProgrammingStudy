//5.컬렉션 연습2

/*Stack<int> numbers = new Stack<int>();
numbers.Push(10); //값을 쌓아 올린다.
numbers.Push(100);
numbers.Push(1000);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------");

int peekNumber = numbers.Peek();
Console.WriteLine(peekNumber);

bool isExist = numbers.Contains(100);
if (isExist)
    Console.WriteLine("100이 존재합니다.");

int value = numbers.Pop(); //쌓아 올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

value = numbers.Pop(); //쌓아 올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);

value = numbers.Pop(); //쌓아 올린 값을 순서대로 꺼낸다.
Console.WriteLine(value);*/

/*실습1. 작업(파워포인트)를 되돌리기 상태로 만들어주는 예제
//1. 특정 횟수만큼 파워포인트 각 작업을 반복해서 넣고(ReadLine)
//2. (넣는 과정이 끝나면) 1번 입력(되돌리기 버튼)을 누를 경우, 되돌리기 작업의 이름을 출력
//3. 되돌리기 작업과 현재 진행된 작업의 이름을 stack에 쌓인 순서대로 출력
//menu>graph>x-setting>y-setting>insert>change x-setting>change y-setting>delete

Console.WriteLine("-----------");

Stack<string> works = new Stack<string>();
works.Push("menu");
works.Push("graph");
works.Push("x-setting");
works.Push("y-setting");
works.Push("insert");
works.Push("change x-setting");
works.Push("change y-setting");
works.Push("delete");

foreach (string work in works)
{
    Console.WriteLine(work);
}

Console.WriteLine("-----------");

Console.WriteLine("명령을 입력하세요.");

string input = Console.ReadLine();

if (input == "1")
{
    string undoValue = works.Pop();
    Console.WriteLine(undoValue);

    Console.WriteLine("-----------");

    foreach (string work in works)
    {
        Console.WriteLine(work);
    }
}*/

/*Console.WriteLine("-----------");

Queue<string> waitingPeople = new Queue<string>();
waitingPeople.Enqueue("짱구");
waitingPeople.Enqueue("철수");
waitingPeople.Enqueue("맹구");

foreach (string people in waitingPeople)
{
    Console.WriteLine(people);
}

string name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);*/

/*실습2 - Queue
 * 도서관 대출자 대기열
 * 1. 대출자 대기열에 맞춰 대출자의 이름과 도서의 이름을 대기열에 등록
 * 2. 도서관 직원이 대기열에 맞춰 대출목록에 업데이트
 * 
 * 입출력 예시
 * "대출자 이름을 입력해주세요."
 * 짱구
 * "도서 권수를 입력해주세요."
 * 2
 * "대출을 위한 도서 목록을 입력해주세요."
 * 퓨처셀프
 * "대출을 위한 도서 목록을 입력해주세요."
 * 삼국지
 * 
 * "Queue에 들어갈 내용 -> 이름 : 짱구 \n 도서1 : 퓨처셀프 \n 도서2 : 삼국지
 * 
 * "도서가 등록되었습니다."
 * 이름 : 짱구
 * 도서1 : 퓨처셀프
 * 도서2 : 삼국지
 */

Queue<string> libraryQueue = new Queue<string>();
string totalinfo = "";

Console.WriteLine("대출자 이름을 입력해주세요.");
string name = Console.ReadLine();
Console.WriteLine("도서 권수를 입력해주세요.");
string booknumber = Console.ReadLine();
int count = int.Parse(booknumber);

totalinfo = name + "\n" + count + "\n";

for (int i = 0; i < count; i++)
{
    Console.WriteLine("도서 목록을 입력해주세요.");
    string bookname = Console.ReadLine();
    totalinfo += bookname + "\n";
}

Console.WriteLine("입력된 내용은 아래와 같습니다.");
Console.WriteLine(totalinfo);
libraryQueue.Enqueue(totalinfo);
