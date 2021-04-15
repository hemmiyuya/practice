using System;

/// <summary>
/// ロボットを移動させ、原点に戻ってきているかどうか判別する
/// </summary>
namespace RobotReturnToOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            string _sampleMove = "URL";
            string _sampleMove2 = "UD";
            string _sampleMove3 = "LR";
            string _sampleMove4 = "LRLRLRLRLRLRLRLRUDUDUDUDUDUD";

            Console.WriteLine("Hello World!");
            Console.WriteLine(RobotReturnOriginNow(_sampleMove));
            Console.WriteLine(RobotReturnOriginNow(_sampleMove2));
            Console.WriteLine(RobotReturnOriginNow(_sampleMove3));
            Console.WriteLine(RobotReturnOriginNow(_sampleMove4));
        }

        /// <summary>
        /// 移動と結果
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        static bool RobotReturnOriginNow(string moves)
        {
            bool l_Origin;
            //縦の移動
            int l_verticalLength = 0;
            //横の移動
            int l_sideLength = 0;

            char[] movesArray = moves.ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                switch (movesArray[i].ToString())
                {
                    case "U":
                        l_verticalLength++;
                        break;

                    case "D":
                        l_verticalLength--;
                        break;

                    case "R":
                        l_sideLength++;
                        break;

                    case "L":
                        l_sideLength--;
                        break;
                }
            }

            if (l_sideLength == 0 && l_verticalLength == 0)
            {
                l_Origin= true;
            }
            else
            {
                l_Origin= false;
            }

            return l_Origin;
        }

        /// <summary>
        /// 最短サンプル
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        public bool JudgeCircle(string moves)
        {
            int longitude = 0;
            int latitude = 0;
            for (var i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U') longitude++;
                if (moves[i] == 'D') longitude--;
                if (moves[i] == 'R') latitude++;
                if (moves[i] == 'L') latitude--;
            }

            return longitude == 0 && latitude == 0;
        }

    }
}
