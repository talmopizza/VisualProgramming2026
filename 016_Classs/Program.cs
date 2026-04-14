namespace _016_Classs {
    class Date { 
        // 데이터(필드, 속성 = 변수)      // 필드는 외부에서 수정이 불가능 하도록 private으로 만든다
        private int year, month, day;   // private이 기본으로 숨어있으나 public과 구분하기 위해 명시해주는게 좋다
                                        // 이걸 public으로 사용하면 외부에서 마음대로 값을 바꿔버릴 위험이 있다
        // 동작(메소드 = 함수), 세터(setter), 게터(getter)
        public void SetYear(int year) { // public을 사용해야지 외부에서 사용가능
            this.year = year;           // 함수를 작성할때 조건을 추가하여 받으면 엉뚱한 동작을 막을 수 있다
        }
        public void SetMonth(int month) {
            this.month = month;
        }
        public void SetDay(int day) {
            this.day = day;
        }
        public int GetYear() {
            return this.year;
        }
        public int GetMonth() {
            return this.month;
        }
        public int GetDay() {
            return this.day;
        }
    }
    internal class Program {
        static void Main(string[] args) { // 객체 생성 Random r = new Random(); 
            Date birtyday = new Date();
            //birtyday.year = 2004;       // 보호수준(class 밖에서 안에 있는 데이터를 못 고치는게 기본) 함수를 통해서만 고쳐야함(사용자의 의도를반영)
            //캡슐화 원칙 : class 바깥에서 객체의 필드를 바꾸려면 함수를 통해서한다
            birtyday.SetYear(2004);
            birtyday.SetMonth(8);
            birtyday.SetDay(31);

            // cw + tab
            //Console.WriteLine("나는 {0}년생입니다.", birtyday.year);
            Console.WriteLine("나는 {0}년생입니다.\n나는 {1}월생입니다.\n나는 {2}일생입니다.\n", birtyday.GetYear(), birtyday.GetMonth(), birtyday.GetDay());
        }
    }
    //생성자 함수
    //리턴값이 없고 클래스와 같은 이름을 갖는 메소드
    //객체가 생성될 때 자동으로 생성
    //초기화할때 유리
    //생성자 함수가 있을경우 setter를 사용 할 필요가 없다
    //여러개 사용가능(method overloading)
}
