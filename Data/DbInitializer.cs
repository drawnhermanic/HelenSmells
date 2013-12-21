using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Domain.Entities;

namespace Data
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HelenSmellsContext>
    {
        protected override void Seed(HelenSmellsContext context)
        {            
            var pictures = new List<Picture>
            {
                new Picture{PictureId=1,Description= "Hot", Image = ImageToByteArray(Image.FromFile(@"E:\Workspaces\HelenSmells\HelenSmells\Content\images\Hot.jpg", true)) },
                new Picture{PictureId=2,Description= "Barcelona", Image = ImageToByteArray(Image.FromFile(@"E:\Workspaces\HelenSmells\HelenSmells\Content\images\barcelona.jpg", true)) },
                new Picture{PictureId=3,Description= "Singing tree", Image = ImageToByteArray(Image.FromFile(@"E:\Workspaces\HelenSmells\HelenSmells\Content\images\tree.jpg", true)) },
                new Picture{PictureId=4,Description= "Just the two of us", Image = ImageToByteArray(Image.FromFile(@"E:\Workspaces\HelenSmells\HelenSmells\Content\images\twoofus.jpg", true)) }
            };
            pictures.ForEach(s => context.Pictures.Add(s));
            context.SaveChanges();
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
