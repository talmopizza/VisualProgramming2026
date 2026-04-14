using System.Drawing;

namespace _017_Rectangle { // namespace와 internal은 없어도 상관없다
    class Rectangle {
        private int width, height;

        public Rectangle(int w, int h) { // 생성자
            this.width = w;
            this.height = h;
        }

        public int GetArea() {
            return width * height;
        }

        public int GetPerimeter() {
            return (width + height) * 2;
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Rectangle rect = new Rectangle(5, 3);
            int area = rect.GetArea();
            int perimeter = rect.GetPerimeter();

            // Console.WriteLine("넓이: " + area);
            // Console.WriteLine("둘레: " + perimeter);

            //Console.WriteLine("면적 : {0}\n둘레 : {1}\n", area, perimeter);
            Console.WriteLine($"면적 : {area}\n둘레 : {perimeter}\n");

        }
    }
}
