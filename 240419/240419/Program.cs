//8. 열거형

public enum Option
{
    RegisterBook = 5,
    SearchBook,
    RegisterMember,
    SearchMember,
    MakeReservation
}

public class Student
{
    public static void Main()
    {
        //사용을 위해 선언
        Option op = Option.RegisterBook;

        switch (op) 
        { 
            case Option.RegisterBook:
                break;
            case Option.SearchBook:
                break;
            case Option.RegisterMember:
                break;
            case Option.MakeReservation:
                break;
        }

        if (op == Option.RegisterBook) 
        {
            
        }
    }
}