using System;
using System.Collections;

namespace Yield
{
    class MyEnumerator // 나열
    {
        int[] numbers = { 1, 2, 3, 4 };

        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3]; // 실행되지 않음 break땜시
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}
