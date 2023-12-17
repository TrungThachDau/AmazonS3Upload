using Amazon;
using Amazon.S3.Model;
using Amazon.S3;
using AWSSDK;
using Amazon.Runtime.SharedInterfaces;
using System.Net;

namespace AmazonS3Upload
{
    public partial class Form1 : Form
    {
        private static IAmazonS3 client;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label3.Text = openFileDialog1.SafeFileName;
            label5.Text = openFileDialog1.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string accessKey = label3.Text;
            string bucketName = txtBucketName.Text;
            string path = label5.Text;
            try
            {
                IAmazonS3 client = new AmazonS3Client(awsAccessKeyId:"AKIAYLKQGU7UMBQPYP72", awsSecretAccessKey: "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", region: RegionEndpoint.APSoutheast1);
            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = accessKey,
                Verb = HttpVerb.PUT,
                Expires = DateTime.UtcNow.AddHours(30),
            };
            var url = client.GetPreSignedURL(request);
            var success = UploadObject(path, url);
               if (success)
            {
                MessageBox.Show("Upload successful.");
                    string link = client.GetPreSignedURL(request);
                    textBox1.Text = link;
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        public static bool UploadObject(string filePath, string url)
        {
            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;
            httpRequest.Method = "PUT";
            using (Stream dataStream = httpRequest.GetRequestStream())
            {
                var buffer = new byte[8000];
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int bytesRead = 0;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        dataStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse;
            return response.StatusCode == HttpStatusCode.OK;
        }
        
    }
}
