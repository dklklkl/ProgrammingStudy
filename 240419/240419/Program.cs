//11. 클래스 메서드 연습

public class MainClass
{
    public class Calculator
    {
        float inputA = 0;
        float inputB = 0;

        public float Add(float _inputA, float _inputB)
        {
            return _inputA + _inputB;
        }

        public float Subtract(float _inputA, float _inputB)
        {
            return _inputA - _inputB;
        }

        public float Multifly(float _inputA, float _inputB)
        {
            return _inputA * _inputB;
        }

        public float Divide(float _inputA, float _inputB)
        {
            return _inputA / _inputB;
        }

        public float Sin(float _inputA)
        {
            return MathF.Sin(_inputA);
        }

        public float Cos(float _inputA)
        {
            return MathF.Cos(_inputA);
        }

        public float Tan(float _inputA)
        {
            return MathF.Tan(_inputA);
        }

    }
    public static void Main()
    {
        //실습9. 공학용계산기의 삼각함수 기능을 Calculator클래스의 메서드를 이용하여 만들기
        //1. Calculator를 만든다.
        //2. Calculator클래스에 입출력을 위한 변수 선언
        //3. Calculator클래스에 아래와 같은 메서드를 만든다.
        //Add, subtract, Multifly, Divide, Sin, Cos, Tan(MathF 클래스를 참고)

        Calculator calculator = new Calculator();

        Console.WriteLine("첫 번째 숫자를 입력해주세요.");
        string inputA = Console.ReadLine();
        float numberA = float.Parse(inputA);

        Console.WriteLine("연산자(+, -, * ,/) 또는 삼각함수(sin, cos, tan)를 입력해주세요.");
        string oper = Console.ReadLine();
        float result = 0;

        if (oper == "sin" || oper == "cos" || oper == "tan")
        {            
            switch (oper)
            {
                case "sin":
                    result = calculator.Sin(numberA * float.Pi / 180);
                    break;
                case "cos":
                    result = calculator.Cos(numberA * float.Pi / 180);
                    break;
                case "tan":
                    result = calculator.Tan(numberA * float.Pi / 180);
                    break;
            }

            Console.WriteLine("Result: " +  result);
            return;
        }
       
        Console.WriteLine("두 번째 숫자를 입력해주세요.");
        string inputB = Console.ReadLine();
        float numberB = float.Parse(inputB);

        switch (oper)
        {
            case "+":
                result = calculator.Add(numberA, numberB);
                break;
            case "-":
                result = calculator.Subtract(numberA, numberB);
                break;
            case "*":
                result = calculator.Multifly(numberA, numberB);
                break;
            case "/":
                result = calculator.Divide(numberA, numberB);
                break;
        }

        Console.WriteLine("Result: " + result);
        return;
    }

    
}