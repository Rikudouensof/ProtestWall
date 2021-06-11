using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProtestWall.Models
{
  public class File
  {
    [Key]
    public int Id { get; set; }


    public string Title { get; set; }

    public string ThumbnailName { get; set; }

    public string FileName { get; set; }

    public int Views { get; set; }

    public string filesuration { get; set; }

    public DateTime PublishedOn { get; set; }

    public string Description { get; set; }

    //Relationships




  }
}
