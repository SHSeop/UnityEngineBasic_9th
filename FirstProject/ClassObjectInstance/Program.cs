namespace ClassObjectInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //지역변수
            //특정 지역 내에서만 사용되는 변수 (일반적으로 함수, 접근자 내에서)
            int num;

            //new 키워드
            //동적 할당 키워드
            //클래스 생성자 앞에 사용하면, 해당 클래스를 힙 영역에다가 동적할당

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Luke";
            human2.name = "Karl";

            human1.SayName();
            human2.SayName();

            // . 멤버 접근 연산자
            Console.WriteLine(human1.age);

        }
    }

    // class 키워드
    // 클래스를 정의
    // 형식 :
    // class 클래스이름
    // {
    //      멤버들(변수, 함수, 다른 사용자정의 자료형)을 정의
    // }
    // 사용자 정의 자료형
    // 클래스는 캡슐화를 위해 탄생했다..!
    // 외부로부터 일반적으로는 멤버들에게 접근하지 못하도록 보호하는 컨셉

    // 접근 제한자
    // private - 외부접근 일절 불가
    // public - 외부 접근 가능
    // protected - 상속자(자식)만 접근 가능
    // internal - 동일 어셈블리 내에서 접근 가능

    class Human
    {
        public int age;
        private float height;
        private double weight;
        private char gender;
        public String name;

        //생성자
        //메모리공간에 해당 클래스타입의 객체를 할당하는 (생성하는) 함수

        public Human()
        {

        }

        //소멸자
        // 객체를  메모리에서 해제하는 함수
        ~Human()
        {

        }

        public void SayName()
        {
            Console.WriteLine(name);
        }

    }
}






