using System; //  รวมคลาสและฟังก์ชันทั้งหมดภายใต้ System namespace เพื่อที่จะนำมาใช้ในโปรแกรม

namespace demoOne // Note: actual namespace depends on the project name.
{
    class Program
    {   
        static void Main()
        {
                int[] array  = {1,2,3,4,5};
                // int number = 4;
                int number = 5;

           for (int n = 0; n < array.Length; n++)
           {
            for (int b = n + 1; b < array.Length; b++)
            {
                if(array[n] +  array[b] == number)
                {
                    Console.Write(array[n] + "," + array[b] + "\n" );
                }
            }
           }
        }
    }
}
