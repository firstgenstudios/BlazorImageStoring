using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageUploader.Models;

public class Profile
{
    [Key]
    public int Id { get; set; }

    public string ImgFileName { get; set; } = string.Empty;

    public string ImgData { get; set; } = string.Empty;
}
