using System.Threading.Tasks.Dataflow;

namespace ArrayEx1 {
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[100];
            int[] bb = new int[100];
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = (i + 1) * 3;

            }
            for (int i = 0; i < bb.Length; i++)
            {
                int tmp = i - 50;
                if (tmp < 0)
                {
                    tmp += 100;
                }
                bb[tmp] = aa[i];

            }
            Console.WriteLine(bb[0]);


            
        }
            
    }
}


