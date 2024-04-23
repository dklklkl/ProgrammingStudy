//10. 클래스

using System.Runtime.CompilerServices;

public class MainClass
{
    //Person Class Template
    public class Person
    {
        //필드 or 멤버변수 or 전역변수, global variable
        public string name;
        public int age;
        public int id;

        //생성자 Constructor : 인스턴싱 시 필드 초기화 or 메서드 실행
        public Person(string _name, int _age, int _id)
        {
            name = _name;
            age = _age;
            id = _id;

            Introduce();
        }

        public Person()
        {
            Introduce();
        }

        //함수X -> 메서드O
        public void Introduce()
        {
            //지역변수, local variable
            int number = 10;
            //this.name = "인삼주"; //전역변수 name 사용
            //Console.WriteLine("저는 " + this.name + "입니다.");

            //string name = "닭고기"; //지역변수 name 사용
            Console.WriteLine(name);
        }

        public void Move()
        {

        }
    }

    public class Book
    {
        public string bookName;
        public string author;
        public string company;
        public int serialNumber;
        public DateTime publicationDate;
        public string location;
        public bool isCheckedOut;

        public Book(string _bookName, string _author, string _company, int _serialNumber, DateTime _publicationDate, string _location, bool _isCheckedOut)
        {
            bookName = _bookName;
            author = _author;
            company = _company;
            serialNumber = _serialNumber;
            publicationDate = _publicationDate;
            location = _location;
            isCheckedOut = _isCheckedOut;
        }


        //객체 생성 용도
        //컨테이너 용도
        public Book(string _bookName, string _location)
        {
            bookName = _bookName;
            location = _location;
        }

        public Book()
        {

        }
    }

    public static void Main()
    {
        Person person1 = new Person(); //instancing, 인스턴스화, 객체화, 메모리 할당
        //person1.name = "삼계탕"; //변수의 초기화, Variable initialization
        //person1.Introduce();

        //실습5. 클래스 생성자를 사용하여 5명의 사람 클래스 인스턴싱
        Person personA = new Person("A", 23, 1156);
        Person personB = new Person("B", 25, 1157);
        Person personC = new Person("C", 21, 1158);
        Person personD = new Person("D", 31, 1159);
        Person personE = new Person("E", 17, 1160);

        List<string> bookList = new List<string>();
        List<Person> personList = new List<Person>();

        //실습7. 아래의 내용으로 도서 클래스 만들고, 라이브러리(Dictionary)에 도서 3권 저장
        //도서명, 저자, 출판사, 일련번호, 출판일, 도서위치, 도서 대여 여부......
        //한번에 많은 정보를 저장 가능
        Book book1 = new Book("짱구는 못말려", "0,1");
        Book book2 = new Book("짱구의 하루", "0,2");
        List<Book> books = new List<Book>();
        books.Add(book1);
        books.Add(book2);
        bool isExist = books.Contains(new Book("짱구는 못말려", ""));
        if (isExist)
            Console.WriteLine("존재합니다.");

        Book bookFound = books.Find(x => x.bookName == "짱구는 못말려");
        Console.WriteLine("이름: " + bookFound.bookName + " / 위치: " + bookFound.location);

        //실습8. 도서관에 책 등록시스템 구성
        //도서의 이름을 입력해주세요.
        //삼국지
        //도서의 위치를 입력해주세요.
        //1,5
        //1번 눌러서 도서 검색(도서이름 또는 위치 검색)
        //(삼국지, 1,5)도서의 정보를 출력

        List<Book> book3 = new List<Book>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("책을 등록하겠습니다.");

            int statusNumber = 7;
            Book book = new Book();

            for (int status = 0; status < statusNumber; status++)
            {
                string input = "";

                switch (status)
                {
                    case 0:
                        Console.WriteLine("도서명을 입력해주세요.");
                        input = Console.ReadLine();
                        book.bookName = input;
                        break;
                    case 1:
                        Console.WriteLine("작가를 입력해주세요.");
                        input = Console.ReadLine();
                        book.author = input;
                        break;
                    case 2:
                        Console.WriteLine("출판사를 입력해주세요.");
                        input = Console.ReadLine();
                        book.company = input;
                        break;
                    case 3:
                        Console.WriteLine("일련번호를 입력해주세요.");
                        input = Console.ReadLine();
                        book.serialNumber = int.Parse(input);
                        break;
                    case 4:
                        Console.WriteLine("출판일을 입력해주세요.");
                        input = Console.ReadLine();
                        book.publicationDate = DateTime.Now;
                        break;
                    case 5:
                        Console.WriteLine("도서위치를 입력해주세요.");
                        input = Console.ReadLine();
                        book.location = input;
                        break;
                    case 6:
                        Console.WriteLine("대여상태를 입력해주세요.");
                        input = Console.ReadLine();
                        book.isCheckedOut = bool.Parse(input);
                        break;
                    case 10:
                        isRunning = false;
                        break;

                }

                Console.WriteLine($"{book.bookName}, {book.author}, {book.company}, {book.serialNumber}, {book.publicationDate}, {book.location}, {book.isCheckedOut}");

                book3.Add(book);
                Console.WriteLine("책 등록이 완료되었습니다.");
            }

            //함수의 오버로드
            //접근제어자 리턴타입 함수의 이름(매개변수 or 인자 or 파라메터)


        }

    }
}