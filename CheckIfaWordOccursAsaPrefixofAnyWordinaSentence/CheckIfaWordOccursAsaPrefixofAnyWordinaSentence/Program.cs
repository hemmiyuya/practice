using System;

namespace CheckIfaWordOccursAsaPrefixofAnyWordinaSentence
{
    //文章と検索文字が入力されて、検索文字が文章の何単語目の接頭辞か出力する。
    //例 文章 "this is shizimi" 検索文字 "shiz" この場合、3単語目のshizimiのshizの部分に当たるので、3を出力する
    //例 文章 "this is shizimi" 検索文字 "abc" この場合、接頭辞にあたる部分がないので-1を出力する
    class Program
    {
        static void Main(string[] args)
        {
            var _sampleWord = "this is shizimi";
            var _sampleSearchWord1 = "thi";
            Console.WriteLine(ReturnWordSentence(_sampleWord, _sampleSearchWord1));
        }

        /// <summary>
        /// 入力された文章と検索文字で何単語目の接頭辞か判別し返す
        /// </summary>
        static int ReturnWordSentence(string defaultWord,string searchWord)
        {
            string defaultWordCopy = defaultWord;

            //半角スペースが見つかるまで文字列を取得する
            for(var i=0;i < defaultWord.Length; i++)
            {

            }

            return 0;
        }
    }
}
