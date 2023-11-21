using ImageUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageUploader.Components.Pages
{
    public partial class Home
    {
        public List<Profile> Profiles { get; set; } = new List<Profile>();
        public List<string> Images { get; set; } = new List<string>();

        protected override async Task OnInitializedAsync()
        {
            if (dbContext.Profiles != null)
            {
                Profiles = await dbContext.Profiles.ToListAsync();

                foreach (var profile in Profiles)
                {
                    string imageData = string.Format("data:image/jpg;base64, {0}", profile.ImgData);
                    Images.Add(imageData);
                }
            }
        }
    }
}