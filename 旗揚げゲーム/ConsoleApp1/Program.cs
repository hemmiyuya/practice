using System;

namespace ConsoleApp1
{
    class Program
    {
        static int _redFlag=0;
        static int _whiteFlag = 0;

        static string[] sample = new string[3];

        const string _simonName = "Simon";
        const string _aliceName = "Alice";

        const string _whiteUp = "WU";
        const string _whiteDown = "WD";
        const string _redUp = "RU";
        const string _redDown = "RD";

        const string _Up = "U";
        const string _Down = "D";

        static int _winPlayer = 0;

        static void Main(string[] args)
        {
            sample[0] = "RU";
            sample[1] = "WU";
            sample[2] = "WD";
            FlagUpGame(sample);
            EndGame(_winPlayer);
        }

        /// <summary>
        /// 旗揚げゲーム
        /// </summary>
        /// <param name="s"></param>
        static void FlagUpGame(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]== _whiteUp)
                {
                    if (_whiteFlag == 0)
                    {
                        _whiteFlag = 1;
                    }
                    else if (_whiteFlag == 1)
                    {
                        _winPlayer = 1;
                    }
                    continue;
                }

                if (s[i] == _whiteDown)
                {
                    if (_whiteFlag == 0)
                    {
                        _winPlayer = 1;
                    }
                    else if (_whiteFlag == 1)
                    {
                        _whiteFlag = 0;
                    }
                    continue;
                }

                if (s[i] == _redUp)
                {
                    if (_redFlag == 0)
                    {
                        _redFlag = 1;
                    }
                    else if (_redFlag == 1)
                    {
                        _winPlayer = 1;
                    }
                    continue;
                }

                if (s[i] == _redDown)
                {
                    if (_redFlag == 0)
                    {
                        _winPlayer = 1;
                    }
                    else if (_redFlag == 1)
                    {
                        _redFlag = 0;
                    }
                    continue;
                }
            }
        }

        static void EndGame(int winPlayer)
        {
            //シモンの勝ち
            if (winPlayer == 0)
            {
                Console.WriteLine(_simonName);
                if (_redFlag == 1)
                {
                    Console.Write(_Up);
                }
                else
                {
                    Console.Write(_Down);
                }

                if (_whiteFlag == 1)
                {
                    Console.Write(_Up);
                }
                else
                {
                    Console.Write(_Down);
                }
            }
            //アリスの勝ち
            else
            {
                Console.WriteLine(_aliceName);
            }
        }
    }
}
