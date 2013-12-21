using System.Drawing;
using Domain.ViewModels;

namespace Domain
{
    public interface IHelper
    {
        bool AreYouHelen(HomeViewModel viewModel);

        byte[] ImageToByteArray(Image imageIn);
        Image ByteArrayToImage(byte[] byteArrayIn);
    }
}