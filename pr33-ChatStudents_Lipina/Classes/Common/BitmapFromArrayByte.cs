﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace pr33_ChatStudents_Lipina.Classes.Common
{
    public class BitmapFromArrayByte
    {
        public static BitmapImage LoadImage(byte[] imageData)
        {
            BitmapImage Image = new BitmapImage();
            using (var Stream = new MemoryStream(imageData))
            {
                Stream.Position = 0;
                Image.BeginInit();
                Image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                Image.CacheOption = BitmapCacheOption.OnLoad;
                Image.UriSource = null;
                Image.StreamSource = Stream;
                Image.EndInit();
            }
            Image.Freeze();
            return Image;
        }   
    }
}
