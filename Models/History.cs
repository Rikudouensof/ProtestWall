using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProtestWall.Models
{
  public class History
  {
    [Key]
    public int Id { get; set; }
    public DateTime DateViewed { get; set; }

    //Relationship

    public File File { get; set; }
    public int? FileId { get; set; }


    public User User { get; set; }

    [Required]
    public string UserId { get; set; }
  }
}
