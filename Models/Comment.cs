using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProtestWall.Models
{
  public class Comment
  {
    [Key]
    public int Id { get; set; }


    [Display(Name = "Comment message")]
    public string Content { get; set; }

    [Display(Name = "Time Posted")]
    public DateTime TimeofPost { get; set; }

    //Relationships
    public File File { get; set; }

    public int? FileId { get; set; }



    public Comment RepliedPost { get; set; }

    public int? RepliedPostId { get; set; }

    public User User { get; set; }

    [Required]
    public string UserId { get; set; }


  



  }
}
