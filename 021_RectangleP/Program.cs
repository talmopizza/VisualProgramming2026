namespace _021_RectangleP {
    class Rectangle {
        public int Width {  get; set; } // 속성(일반적으로 대문자 시작) public 변수와 함수의 중간 역할
        public int Height { get; set; } 
        public int GetArea() {
            return Width * Height;
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 10;
            Console.WriteLine($"면적 = {r.GetArea()}");
        }
    }
}
