using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Common.Utility {
    public class PhotoTool {
        public async Task ResizePhotoToJpeg(Stream stream) {
            var img = SKBitmap.Decode(stream);
            var width = img.Width;
            var height = img.Height / (img.Width / 1280);
            img.Resize(new SKImageInfo(1280, height), SKFilterQuality.None);
            var img_data = img.Encode(SKEncodedImageFormat.Jpeg, 75);
            //tg_img.Save(stream, ImageFormat.Jpeg);
            var img_arr = img_data.ToArray();
        }
    }
}
