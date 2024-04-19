//4. 컬렉션 연습

//배열 : 고정형
string[] names = { "짱구", "짱아", "철수" };

//리스트 : 가변형
List<string> names2 = new List<string>()
{
    "짱구",
    "짱아",
    "철수"
};

Console.WriteLine(names[0]);
Console.WriteLine(names2[0]);
names2.Add("훈이");
Console.WriteLine(names2[3]);

for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

for(int i = 0;i < names2.Count; i++)
{
    Console.WriteLine(names2[i]);
}

//리스트에서 이름 찾기
int index = names2.IndexOf("철수");
Console.WriteLine("철수는 " + index + "번째에 있습니다.");

//존재여부확인
bool isExsist = names2.Contains("짱구");
if(isExsist)
{
    Console.WriteLine("존재합니다."); //한줄일 때는 중괄호 없어도 됨
}

//리스트를 정렬
names2.Sort();
for(int i = 0; i < names2.Count(); i++)
{
    Console.WriteLine(names2[i]);
}

//딕셔너리: "example"(key), 5번째(value)
Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("book", 0);
dictionary.Add("computer", 1);
dictionary.Add("mouse", 2);

index = dictionary["mouse"];
Console.WriteLine("mouse는 " + index + "번째에 있습니다.");
bool isContaing = dictionary.ContainsKey("book");

if(isContaing)
    Console.WriteLine("book이 존재합니다.");

//실습2 : 도서관 검색 서비스
// 1. 도서관에 가로3, 세로2의 책꽂이가 있다.
//미리 책꽂이에 책들을 꽂아놓은 상태
// 2. 특정 책의 이름을 입력받아 책의 일련번호(위치)를 출력하는 책꽂이 시스템 제작

//예시
//도서의 이름을 입력해주세요.
//_
//도서의 위치는 (2,1)입니다.

//버튼을 눌러주세요. 등록(0), 검색(1), 제거(2)


Dictionary<string, string> bookShelf = new Dictionary<string, string>();
bookShelf.Add("짱구", "0,0");
bookShelf.Add("철수", "0,1");
bookShelf.Add("맹구", "0,2");
bookShelf.Add("훈이", "1,0");
bookShelf.Add("유리", "1,1");
bookShelf.Add("짱아", "1,2");


Console.WriteLine("도서의 이름을 입력해주세요.");
string bookName = Console.ReadLine();
string location = bookShelf[bookName];
Console.WriteLine("도서의 위치는 " + location + "입니다.");

