using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ImageCutting
{
    public class ImageHelper
    {
        /// <summary>
        /// 获取图片的某个区域
        /// </summary>
        /// <param name="pPath">图片路径</param>
        /// <param name="pPartStartPointX">目标图片开始绘制处的坐标X值(通常为0)</param>
        /// <param name="pPartStartPointY">目标图片开始绘制处的坐标Y值(通常为0)</param>
        /// <param name="pPartWidth">目标图片的宽度</param>
        /// <param name="pPartHeight">目标图片的高度</param>
        /// <param name="pOrigStartPointX">原始图片开始截取处的坐标X值</param>
        /// <param name="pOrigStartPointY">原始图片开始截取处的坐标Y值</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap GetPart(string pPath, int pPartStartPointX, int pPartStartPointY, int pPartWidth, int pPartHeight, int pOrigStartPointX, int pOrigStartPointY)
        {
            var originalImg = System.Drawing.Image.FromFile(pPath);

            var partImg = new System.Drawing.Bitmap(pPartWidth, pPartHeight);
            var graphics = System.Drawing.Graphics.FromImage(partImg);
            var destRect = new System.Drawing.Rectangle(new System.Drawing.Point(pPartStartPointX, pPartStartPointY), new System.Drawing.Size(pPartWidth, pPartHeight)); // 目标位置
            var origRect = new System.Drawing.Rectangle(new System.Drawing.Point(pOrigStartPointX, pOrigStartPointY), new System.Drawing.Size(pPartWidth, pPartHeight)); // 原图位置（默认从原图中截取的图片大小等于目标图片的大小）

            graphics.DrawImage(originalImg, destRect, origRect, System.Drawing.GraphicsUnit.Pixel);

            return partImg;
        }

        /// <summary>
        /// 获取图片指定部分
        /// </summary>
        /// <param name="pPath">图片路径</param>
        /// <param name="pSavedPath">保存路径</param>
        /// <param name="pPartStartPointX"></param>
        /// <param name="pPartStartPointY"></param>
        /// <param name="pPartWidth"></param>
        /// <param name="pPartHeight"></param>
        /// <param name="pOrigStartPointX"></param>
        /// <param name="pOrigStartPointY"></param>
        public static void GetPart(string pPath, string pSavedPath, int pPartStartPointX, int pPartStartPointY, int pPartWidth, int pPartHeight, int pOrigStartPointX, int pOrigStartPointY)
        {
            var originalImg = Image.FromFile(pPath);

            var partImg = new Bitmap(pPartWidth, pPartHeight);
            var graphics = Graphics.FromImage(partImg);
            var destRect = new Rectangle(new Point(pPartStartPointX, pPartStartPointY), new Size(pPartWidth, pPartHeight)); // 目标位置
            var origRect = new Rectangle(new Point(pOrigStartPointX, pOrigStartPointY), new Size(pPartWidth, pPartHeight)); // 原图位置（默认从原图中截取的图片大小等于目标图片的大小）

            graphics.DrawImage(originalImg, destRect, origRect, GraphicsUnit.Pixel);
            partImg.Save(pSavedPath + "\\part.jpg", ImageFormat.Jpeg);
        }
    }
}
