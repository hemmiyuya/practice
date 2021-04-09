using System;

namespace ReverseString
{
    /// <summary>
    /// 入力された文字列を反転して返するプログラム
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string defaultString = "HelloWorld!";
            Console.WriteLine(defaultString);
            Console.WriteLine(program.Reverse(defaultString));
        }

        /// <summary>
        /// 反転する
        /// </summary>
        /// <param name="defaultString"></param>
        /// <returns></returns>
        public string Reverse(string defaultString)
        {
            //一文字ずつひっくり返して結合
            Console.WriteLine("");
            string l_ReverseString = null;
            for (int i = defaultString.Length-1; i >=0 ; i--)
            {
                l_ReverseString= l_ReverseString+defaultString.Substring(i, 1);
            }

            return l_ReverseString;
        }

    }
}
