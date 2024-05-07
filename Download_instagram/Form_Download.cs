using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_instagram
{
    public partial class Form_Download : Form
    {
        public Form_Download()
        {
            InitializeComponent();
            btn_download.Click += btn_download_Click;
        }

        private async void btn_download_Click(object sender, EventArgs e)
        {
            btn_download.Enabled = false;
            string instagramUrl = txt_link.Text.Trim();

            if (!string.IsNullOrEmpty(instagramUrl))
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        // Định dạng lại URL để chứa link bài viết Instagram
                        string apiUrl = "https://instagram-post-downloader.p.rapidapi.com/?url=" + Uri.EscapeDataString(instagramUrl);

                        var request = new HttpRequestMessage
                        {
                            Method = HttpMethod.Get,
                            RequestUri = new Uri(apiUrl),
                            Headers =
                            {
                                { "X-RapidAPI-Key", "your-api-key" },
                                { "X-RapidAPI-Host", "instagram-post-downloader.p.rapidapi.com" },
                            },
                        };

                        using (var response = await client.SendAsync(request))
                        {
                            response.EnsureSuccessStatusCode();
                            string responseBody = await response.Content.ReadAsStringAsync();

                            
                            InstagramResult result = JsonConvert.DeserializeObject<InstagramResult>(responseBody);

                            if (result.Status == "success")
                            {
                                // Lặp qua các mục dữ liệu và tải về ảnh
                                foreach (var data in result.Data)
                                {
                                    string downloadUrl = data.Download;
                                    // Tải về ảnh và lưu vào thư mục cụ thể
                                    await DownloadImage(downloadUrl);
                                }
                                MessageBox.Show("Đã tải về thành công!", "Thông báo");
                                btn_download.Enabled = true;
                                txt_link.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Không thể tải về ảnh từ Instagram.", "Thông báo");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập địa chỉ bài viết từ Instagram!", "Thông báo");
            }
        }

        private async Task DownloadImage(string imageUrl)
        {
            using (WebClient client = new WebClient())
            {
                // Tạo tên file duy nhất từ thời gian hiện tại
                string fileName = DateTime.Now.Ticks + ".jpg";
                // Đường dẫn lưu trữ ảnh
                string filePath = "C:\\Instagram_Pic\\" + fileName; 

                // Tải về ảnh từ đường dẫn imageUrl và lưu vào đường dẫn filePath
                await client.DownloadFileTaskAsync(new Uri(imageUrl), filePath);
            }
        }
    }

    public class InstagramResult
    {
        public string Status { get; set; }
        public List<InstagramData> Data { get; set; }
    }

    public class InstagramData
    {
        public string Thumbnail { get; set; }
        public string Download { get; set; }
    }
}
