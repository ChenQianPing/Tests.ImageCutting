using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ImageCutting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Start GetPart...");

            var pPath = @"E:\10001003\1d.jpg";
            var pSavedPath = @"E:\10001003\";
            var pPartStartPointX = 0;
            var pPartStartPointY = 0;

            var x = 81;
            var y = 977;
            var width = 899;
            var height = 237;


            ImageHelper.GetPart(pPath, pSavedPath, pPartStartPointX, pPartStartPointY,
                width, height, x, y);

            Console.Write("End...");

            Console.ReadLine();
        }
    }
}
