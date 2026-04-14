using System.Runtime.CompilerServices;

namespace _019_Cricleclass {
    class Circle {
        private double radius;
        private string? color;
        
        public Circle(double radius, string color){
            this.radius = radius;
            this.color = color;
        }
        public double GetArea() { // 원의 면적
            return 2 * this.radius * 3.14;
        }
        public void PrintInfo() { // 원의 반지름과 색깔
            Console.WriteLine($"원의 반지름: {this.radius}\n색깔: {this.color}\n");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Circle c = new Circle(10, "빨간색");
            Console.WriteLine($"면적: {c.GetArea():F1}");
            c.PrintInfo();
        }
    }
}
