using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            int blank;
            int star;
            int height;

            Console.WriteLine("수를 입력하세요: ");
            String? str = Console.ReadLine();
            a = Convert.ToInt32(str);
            

            for (int i = 0; i < a; i++)
            {
                height = i + 1; // 높이 번호
                blank = a - height; // 빈칸 개수
                star = 2 * i + 1; // 별표 개수

                for (int j = 0; j < blank; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < star; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // 역삼각형 
            for(int i = 1; i < a; i++)
            {
                height = i + 1; 
                star = (a * 2) - (height * 2 - 1); // 별표 개수

                for(int j = 0; j < i; j++) // 빈칸 출력: (j < i) 조건에 따라 공백 개수가 0,1,2로 증가
                {
                    Console.Write(' ');
                }
                for( int k = 0; k < star; k++) // 별표 출력: (a * 2) - (height * 2 - 1) -> (...,5,3,1)
                {
                    Console.Write("*"); // 별표 개수만큼 k반복
                }
                Console.Write('\n');
            }
        }
    }
}


