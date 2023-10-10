using Imgur.API.Authentication;
using Imgur.API.Endpoints;
using Imgur.API.Models;

namespace ScreenTool.API
{
    public class ImgurAPI
    {
        public async Task<string> GetAPICallback(string filePath)
        {
            var imgurClient = new ApiClient(ScreenshotTool.ImgureClientId, ScreenshotTool.ImgureToken);
            var httpClient = new HttpClient();
            using var fileStream = File.OpenRead(filePath);
            var imageEndpoint = new ImageEndpoint(imgurClient, httpClient);
            var imageUpload = await imageEndpoint.UploadImageAsync(fileStream);
            return imageUpload.Link;
        }
    }
}
