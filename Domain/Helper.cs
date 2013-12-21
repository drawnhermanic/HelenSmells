using System;
using System.Drawing;
using System.IO;
using Domain.ViewModels;

namespace Domain
{
    public class Helper : IHelper
    {
        public bool AreYouHelen(HomeViewModel viewModel)
        {
            return viewModel.YourName == "Helen" && viewModel.DateOfBirth == new DateTime(1983, 3, 27);
        }

        public byte[] ImageToByteArray(Image imageIn)
        {            
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

    }
}
