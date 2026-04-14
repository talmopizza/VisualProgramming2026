namespace _018_Student { // C는 함수 C#은 클래스
    class Student { // 필드는 private setter,getter 대신 생성자, 함수 만들어 사용하기
        private string name, major; // string으로 변수를 만들때 string?으로 nullable로 만들면 좀더 안전하다
        private int age;
        public Student(string name, int age, string major) { // 생성자 !매우중요! 생성될때 자동으로 실행(객체가 생성될 때 자동으로 호출), 리턴 값이 없고 클래스와 같은 이름을 갖는 메소드(함수)
            this.name = name;
            this.age = age;
            this.major = major;
        }
        public void DisplayInfo() { // 메소드 = 함수
            Console.WriteLine($"이름: {this.name}\n나이: {this.age}\n전공: {this.major}\n");
            //Console.WriteLine("이름: {0}\n나이: {1}\n전공: {2}\n", this.name, this.age, this.major);
            string s = string.Format("이름: {0}\n나이: {1}\n전공: {2}\n", this.name, this.age, this.major);
            string t = string.Format($"이름: {this.name}\n나이: {this.age}\n전공: {this.major}\n");
            //Console.WriteLine(s);
            //Console.WriteLine(t);
            //WindowForm에서는 string.Format사용    콘솔에서는 그냥 출력하면 끝이지만 Forms에서는 저장 시켜놓고 쓰는 경향이 더 강해서
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Student stu = new Student("김도우", 23, "의료IT공학");
            stu.DisplayInfo();
        }
    }
}
