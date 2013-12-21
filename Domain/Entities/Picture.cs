using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Picture
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PictureId { get; set; }

        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
