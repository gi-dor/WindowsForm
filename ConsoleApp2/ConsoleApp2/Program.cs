

using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine(i);
            Console.WriteLine(++i);
            Console.WriteLine(i); 
            Console.WriteLine(i++);
            Console.WriteLine(i);

            Console.WriteLine();
            int a = 1;
            int b = 2;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            Console.WriteLine();

            String s1 = "Hello";
            String s2 = "Hello";
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine();
            String s3 = new String("Hi");
            String s4 = new String("Hi");
            Console.WriteLine(s3 == s4);
            Console.WriteLine(s3.Equals(s4));
            Console.WriteLine("참조 주소비교 : " + object.ReferenceEquals(s3, s4));
            Console.WriteLine();

            // var 변수 사용하기
            var sample01 = "Hello";
            var sample02 = "Hello";
            var sample03 = 3;
            var sample04 = 4;

            Console.WriteLine("sample01 == sample02 : " + sample01 == sample02);
            //Console.WriteLine("sample03 == sample04 : " + sample03 == sample04);
            Console.WriteLine("sample01.Equals(sample04) : " + sample01.Equals(sample02));
            Console.WriteLine("sample03.Equals(sample04) : " +sample03.Equals(sample04));
            Console.WriteLine("object.ReferenceEquals(sample01,sample02) : "+ object.ReferenceEquals(sample01, sample02));
            Console.WriteLine("object.ReferenceEquals(sample03,sample04) : " + object.ReferenceEquals(sample03, sample04));



            // 값 입력해보기
           // String input;
            //input = Console.ReadLine();
            //Console.WriteLine("입력한 값 : "+input);

            Console.WriteLine();

            Console.WriteLine("비교연산자 7.0 < 5.1 : "  , 7.0 < 5.1);
            Console.WriteLine(5.2 > 6.5);

            Console.WriteLine(" ****** NaN 비교 하기");
            // 비교 연산자 중 피연산자 중 하나가 숫자가 아니라면 false 가 발생한다
            Console.WriteLine("double.NaN > 3.17",double.NaN > 3.17);


            int varInt;
            double varDouble;

            varInt = 17;
            varDouble = 3.14125d;

            Console.WriteLine("varInt : "+ varInt);
            Console.WriteLine("varDouble : "+ varDouble);

            // 문자열 연결
            Console.WriteLine("샘풀1 " + "샘플2 " + "더하기");

            // 더하기 연산자
            int x = 5;
            x += 10;
            // x = 5 + 10
            Console.WriteLine(" x는 5일때 , x += 10 :" + x);


            String text1 = "안녕";
            String text2 = new string("안녕 안녕");
            //object text3 = new object("안녕안녕안녕");
            object text4 = new string("안녕안냥안녕안냥");

            if (text1 == text2)
            {
                Console.WriteLine("text1 == text2");
            }
            else
            {
                Console.WriteLine("Test fail");

            }
            Console.WriteLine("===========================");
            String str1 = new string("123");
            String str2 = new string("321");

            StringBuilder strb1 = new StringBuilder("456");
            StringBuilder strb2 = new StringBuilder("456");

            // 값비교
            if (str1 == str2)
            {
                Console.WriteLine("str1 == str2 True");
            }else
            {
                Console.WriteLine("str1 == str2 False");
            }

            if (object.ReferenceEquals(str1,str2))
            {
                Console.WriteLine("Reference True");
            } else
            {
                Console.WriteLine("Reference False");
            }

            Console.WriteLine("StringBuilder Reference 비교");

            if (object.ReferenceEquals(strb1,strb2))
            {
                Console.WriteLine("StringBuilder Reference Equals True");
            }
            else
            {
                Console.WriteLine("StringBuilder Reference Equals False");
            }
            if (strb1 == strb2)
            {
                Console.WriteLine("StringBuilder True");
            }
            else
            {
                Console.WriteLine("StringBuilder False");
            }




            Console.WriteLine();
            Console.WriteLine("StringBuilder == 연산자 비교하기 ");

            Console.WriteLine();
            Console.WriteLine("===== 삼항 연산자 ====");
            int testSample = 30;
            String result = a == 30 ? "삼십 " : "삼십이 아니다";
            Console.WriteLine(result);

            String 짝홀수 = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine("10 % 2 짝 홀수  : " + 짝홀수);

            Console.WriteLine();
            Console.WriteLine("null 조건부 연산자");

            Foo foo = null;
            int? member = null;
            
            // null 조건연산자를 사용하지 않는 경우
            if(foo == null)
            {
                member = null;
            }
            else
            {
                member = foo.member;
            }
            member = foo?.member;

            Console.WriteLine("foo?.member : " + member);

            // 1. == 연산자 

            ArrayList ab = null;
            // null에 다가 야구 축구를 넣어
            ab?.Add("야구");
            ab?.Add("축구");
            Console.WriteLine($"{ab?[0]}");
            Console.WriteLine($"{ab?[1]}");

            ab = new ArrayList();
            ab?.Add("농구");
            ab?.Add("배구");
            Console.WriteLine($"Count : {ab?.Count}");
            Console.WriteLine($"{ab?[0]}");
            Console.WriteLine($"{ab?[1]}");

            // internal 접근자
            Console.WriteLine();
            Console.WriteLine("==== internal 접근자 =====  ");

            // 다른접근제한자 처럼 클래스명, 필드명 , 메서드명 , 중첩된 클래스명 등에 사용된다
            Console.WriteLine("같은 파일내에서의 Internal선언은 public과 같이 쓰인다");
            Console.WriteLine("내부적인 이라는 사전적 의미");


        }

    }
}
