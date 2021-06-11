using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProtestWall.Models
{
  public class FileType
  {
    [Key]
    public int Id { get; set; }


    [Display(Name = "Name of File Type")]
    public string Name { get; set; }


  }
}
