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

    [Display(Name = "Title")]
    public string Title { get; set; }

    [Display(Name = "Display Image")]
    public string ThumbnailName { get; set; }

    [Display(Name = "File Name")]
    public string FileName { get; set; }

    [Display(Name = "Number of Views")]
    public int Views { get; set; }


    [Display(Name = "File Duration")]
    public string filesDuration { get; set; }


    [Display(Name = "Date uploaded")]
    public DateTime PublishedOn { get; set; }



    [Display(Name = "File Description")]
    public string Description { get; set; }



    [Display(Name = "Blog Article Body")]
    public string Article { get; set; }

    //Relationships

    public Category Category { get; set; }
    public int? CategoryId { get; set; }


    public FileType FileType { get; set; }

    public int? FileTypeId { get; set; }


    public User User { get; set; }

    [Required]
    public string  UserId { get; set; } 



  }
}
