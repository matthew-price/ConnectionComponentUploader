using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;


namespace ConnectionComponentUploader
{
    public partial class MainDialog : Form
    {
        private OpenFileDialog selectXMLDialog;
        private byte[] zipFileStream;
        private string restApiKey;
        private ConnectionComponent connectionComponent = new ConnectionComponent();
        private string uploadResult;

        public MainDialog()
        {
            InitializeComponent();
        }

        private void selectXMLFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialogform();
        }

        private void LoginToPVWA(string username, string password)
        {
            var client = new RestClient(pvwaTextBox.Text);
            client.Authenticator = new SimpleAuthenticator("username", username, "password", password);

            var request = new RestRequest("PasswordVault/API/auth/Cyberark/Logon", Method.POST, DataFormat.Json);
            IRestResponse response = new RestResponse();
            response = client.Execute(request);
            string restApiResponse = response.Content;
            restApiKey = restApiResponse.Trim('"');
            Console.WriteLine(restApiKey);
        }

        private void PostConnectionComponent()
        {
            var client = new RestClient(pvwaTextBox.Text);
            var request = new RestRequest("PasswordVault/API/ConnectionComponents/Import")
                .AddParameter("Authorization", restApiKey, ParameterType.HttpHeader);
                //.AddParameter("Authorization", "NGFkZDAxNzItYjhhZC00MzhjLWJmNTQtMDE4MDAzYWI5ZWQ0O0YwRkQ1MDRFODdDNEIwQTY7MDAwMDAwMDJDOENFRTA3MDE0NDdFNzBCMzQ0MjBFQUI0NkEzMzgyNzUyNTQ5Nzk0NzFCNzMwODA1MUZFNzNBRDk3OThDMjE2MDAwMDAwMDA7", ParameterType.HttpHeader);
            request.Method = Method.POST;
            request.AddJsonBody(connectionComponent);
            Console.WriteLine("restApiKey value: " + restApiKey);
            IRestResponse response = new RestResponse();
            response = client.Execute(request);
            Console.WriteLine(response.Request.Body.Value);
            Console.WriteLine(response.Content);
            uploadResult = response.Content;
        }

        private void openFileDialogform()
        {
            selectXMLDialog = new OpenFileDialog()
            {
                FileName = "Select a connection component ZIP",
                Filter = "ZIP files (*.zip)|*.zip",
                Title = "Open ZIP file"
            };
            if (selectXMLDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = selectXMLDialog.FileName;

                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] ImageData = new byte[fs.Length];
                    fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();
                    zipFileStream = ImageData;
                    Console.WriteLine(Convert.ToBase64String(zipFileStream));
                    //connectionComponent.ImportFile = Convert.ToBase64String(zipFileStream);
                    connectionComponent.ImportFile = zipFileStream;

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            LoginToPVWA(usernameTextBox.Text, passwordTextBox.Text);
            Console.WriteLine("starting wait");
            //System.Threading.Thread.Sleep(5000);
            Console.WriteLine("finishing wait");
            PostConnectionComponent();
            //System.Threading.Thread.Sleep(5000);
            MessageBox.Show(uploadResult, "Upload result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
