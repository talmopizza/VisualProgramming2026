namespace _020_Calculator {
    class Calculator {
        public static double Add(double x, double y) {
            return x + y;
        }
        public static double Subtract(double x, double y) { 
            return x - y; 
        }
        public static double Multiply(double x, double y) { 
            return x * y; 
        }
        public static double Divide(double x, double y) { 
            if ( y == 0 ) {
                Console.WriteLine("0으로 나눌 수 없습니다");
                return 0;
            } else {
                return x / y;
            }
        }
    }
    internal class Program {
        static void Main(string[] args) { // static은 객체이름이 아닌 클래스 이름으로 쓴다
            double num1 = 3.5;
            double num2 = 6.7;
            double sum = Calculator.Add(num1, num2);
            double diff = Calculator.Subtract(num1, num2);
            double prod = Calculator.Multiply(num1, num2);
            double quot = Calculator.Divide(num1, num2);
            Console.WriteLine($"덧셈: {sum}\n뺄셈: {diff}\n곱셈: {prod}\n나눗셈: {quot:F4}\n"); // cw("나눗셈 : {0:F4}", quot);
        }
    }
}
