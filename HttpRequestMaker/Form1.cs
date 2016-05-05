using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;
using System.Drawing.Imaging;

namespace HttpRequestMaker
{
    public partial class Form1 : Form
    {
        public static string SettingsFileName = "settings.config";

        List<MyRequest> requestHistory;
        MyRequest lastRequest;
        MyRequest currentRequest;

        public Form1()
        {
            InitializeComponent();

            TryLoadSettings();

            requestHistory = new List<MyRequest>();
            currentRequest = new MyRequest(URLTextBox.Text); 
        }

        private void UpdateHeadersList()
        {
            HeadersListBox.Items.Clear();

            for (int i = 0; i < currentRequest.headers.Count; i++)
            {
                string key = currentRequest.headers.ElementAt(i).Key;
                HeadersListBox.Items.Add(key + " = " + currentRequest.headers[key]);
            }
        }
        private void UpdateContentList()
        {
            ContentListBox.Items.Clear();

            for (int i = 0; i < currentRequest.content.Count; i++)
            {
                string key = currentRequest.content.ElementAt(i).Key;
                ContentListBox.Items.Add(key + " = " + currentRequest.content[key]);
            }
        }
        private void UpdateFileList()
        {
            FilesListBox.Items.Clear();

            for (int i = 0; i < currentRequest.files.Count; i++)
            {
                string key = currentRequest.files.ElementAt(i).Key;
                FilesListBox.Items.Add(key + " = " + currentRequest.files[key]);
            }
        }
        private void UpdateHistoryList()
        {
            HistoryListBox.Items.Clear();

            for (int i = 0; i < requestHistory.Count; i++)
            {
                string line = requestHistory[i].URL;
                if (line.Length > 20)
                {
                    line = "..." + line.Substring(requestHistory[i].URL.Length - 20 + 3);
                }
                HistoryListBox.Items.Add(line);
            }
        }
        private void RefreshResponseView()
        {
            //Switch to a different tab and back to make the
            //tab auto refresh it's content to the new response data
            int indexWas = ResponseTabControl.SelectedIndex;
            if (indexWas == 1)
            {
                ResponseTabControl.SelectTab(0);
                ResponseTabControl.SelectTab(indexWas);
            }
            else
            {
                ResponseTabControl.SelectTab(1);
                ResponseTabControl.SelectTab(indexWas);
            }
        }
        private void SaveSettings()
        {
            using (StreamWriter writer = new StreamWriter(SettingsFileName))
            {
                writer.WriteLine("URL:" + URLTextBox.Text);
                if (OpenDialog != null && OpenDialog.FileName != null && OpenDialog.FileName != "")
                {
                    writer.WriteLine("FOLDER:" + Path.GetDirectoryName(Path.GetFullPath(OpenDialog.FileName)));
                }
            }
        }
        private void TryLoadSettings()
        {
            if (!File.Exists(SettingsFileName))
                return;

            using (StreamReader reader = new StreamReader(SettingsFileName))
            {
                string line = reader.ReadLine();

                while (line != "" && line != null)
                {
                    if (line.Length > 4 && line.Substring(0, 4) == "URL:")
                    {
                        this.URLTextBox.Text = line.Substring(4);
                    }
                    if (line.Length > 7 && line.Substring(0, 7) == "FOLDER:")
                    {
                        this.OpenDialog.InitialDirectory = line.Substring(7);
                    }

                    line = reader.ReadLine();
                }
            }
        }
        private void AddToHistory(MyRequest request)
        {
            MyRequest newItem = request.Copy();
            
            requestHistory.Insert(0, newItem);
            while (requestHistory.Count > 16)
            {
                requestHistory.RemoveAt(16);
            }

            UpdateHistoryList();

            HistoryListBox.SelectedIndex = 0;
        }
        private void LoadFromRequest(MyRequest request)
        {
            this.currentRequest = new MyRequest(request.URL);
            this.currentRequest.requestFunction = request.requestFunction;
            for (int i = 0; i < request.headers.Count; i++)
            {
                string key = request.headers.ElementAt(i).Key;
                this.currentRequest.headers.Add(key, request.headers[key]);
            }
            for (int i = 0; i < request.content.Count; i++)
            {
                string key = request.content.ElementAt(i).Key;
                this.currentRequest.content.Add(key, request.content[key]);
            }
            for (int i = 0; i < request.files.Count; i++)
            {
                string key = request.files.ElementAt(i).Key;
                this.currentRequest.files.Add(key, request.files[key]);
            }

            UpdateHeadersList();
            UpdateContentList();
            UpdateFileList();
            URLTextBox.Text = this.currentRequest.URL;
            FunctionComboBox.SelectedIndex = (this.currentRequest.requestFunction == "GET" ? 0 : 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            if (URLTextBox.Text == "")
            {
                InvalidNotice("Must enter a URL");
                return;
            }

            lastRequest = currentRequest.Copy();

            lastRequest.URL = URLTextBox.Text;
            lastRequest.requestFunction = FunctionComboBox.Text;

            lastRequest.Request();

            AddToHistory(lastRequest);
        }
        private void UploadFilesButton_Click(object sender, EventArgs e)
        {
            if (currentRequest.files.Count == 0)
            {
                InvalidNotice("There are no files to upload");
            }

            lastRequest = currentRequest.Copy();

            lastRequest.URL = URLTextBox.Text;
            lastRequest.requestFunction = FunctionComboBox.Text;

            lastRequest.UploadAll();

            AddToHistory(lastRequest);
        }

        private void HeaderAddButton_Click(object sender, EventArgs e)
        {
            if (HeaderNameBox.Text == "")
            {
                InvalidNotice("Header Name Box must be filled.");
                return;
            }

            if (currentRequest.headers.ContainsKey(HeaderNameBox.Text))
            {
                currentRequest.headers[HeaderNameBox.Text] = HeaderValueBox.Text;
            }
            else
            {
                currentRequest.headers.Add(HeaderNameBox.Text, HeaderValueBox.Text);
            }

            UpdateHeadersList();

            HeaderNameBox.Text = "";
            HeaderValueBox.Text = "";
            HeaderNameBox.Focus();
        }
        private void ContentAddButton_Click(object sender, EventArgs e)
        {
            if (ContentNameBox.Text == "")
            {
                InvalidNotice("Content Name Box must be filled.");
                return;
            }
            if (ContentValueBox.Text == "")
            {
                InvalidNotice("Content Value Box must be filled.");
                return;
            }

            if (currentRequest.content.ContainsKey(ContentNameBox.Text))
            {
                currentRequest.content[ContentNameBox.Text] = ContentValueBox.Text;
            }
            else
            {
                currentRequest.content.Add(ContentNameBox.Text, ContentValueBox.Text);
            }

            UpdateContentList();

            ContentNameBox.Text = "";
            ContentValueBox.Text = "";
            ContentNameBox.Focus();
        }

        private void HeadersListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && HeadersListBox.SelectedIndex != -1)
            {
                string selectedItem = (string)HeadersListBox.SelectedItem;
                int indexOfEquals = selectedItem.IndexOf(" = ");
                string varName = selectedItem.Substring(0, indexOfEquals);
                string varValue = selectedItem.Substring(indexOfEquals + 3);

                //since we just filled the boxes when you click on an item we
                //will auto clear it for ease of use if it hasn't been changed
                if (HeaderNameBox.Text == varName &&
                    HeaderValueBox.Text == varValue)
                {
                    HeaderNameBox.Text = "";
                    HeaderValueBox.Text = "";
                }

                HeadersListBox.Items.RemoveAt(HeadersListBox.SelectedIndex);

                if (this.currentRequest.headers.ContainsKey(varName))
                    this.currentRequest.headers.Remove(varName);
            }
        }
        private void ContentListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && ContentListBox.SelectedIndex != -1)
            {
                string selectedItem = (string)ContentListBox.SelectedItem;
                int indexOfEquals = selectedItem.IndexOf(" = ");
                string varName = selectedItem.Substring(0, indexOfEquals);
                string varValue = selectedItem.Substring(indexOfEquals + 3);

                //since we just filled the boxes when you click on an item we
                //will auto clear it for ease of use if it hasn't been changed
                if (ContentNameBox.Text == varName &&
                    ContentValueBox.Text == varValue)
                {
                    ContentNameBox.Text = "";
                    ContentValueBox.Text = "";
                }

                ContentListBox.Items.RemoveAt(ContentListBox.SelectedIndex);

                if (this.currentRequest.content.ContainsKey(varName))
                    this.currentRequest.content.Remove(varName);
            }
        }
        private void FilesListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && FilesListBox.SelectedIndex != -1)
            {
                string selectedItem = (string)FilesListBox.SelectedItem;
                int indexOfEquals = selectedItem.IndexOf(" = ");
                string fileName = selectedItem.Substring(0, indexOfEquals);

                //since we just filled the boxes when you click on an item we
                //will auto clear it for ease of use if it hasn't been changed
                if (FileNameBox.Text == fileName)
                {
                    FileNameBox.Text = "";
                }

                FilesListBox.Items.RemoveAt(FilesListBox.SelectedIndex);

                if (this.currentRequest.files.ContainsKey(fileName))
                    this.currentRequest.files.Remove(fileName);
            }
        }

        private void HeadersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HeadersListBox.SelectedIndex == -1)
                return;

            string selectedItem = (string)HeadersListBox.SelectedItem;
            int indexOfEquals = selectedItem.IndexOf(" = ");

            HeaderNameBox.Text = selectedItem.Substring(0, indexOfEquals);
            HeaderValueBox.Text = selectedItem.Substring(indexOfEquals + 3);
        }
        private void ContentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContentListBox.SelectedIndex == -1)
                return;

            string selectedItem = (string)ContentListBox.SelectedItem;
            int indexOfEquals = selectedItem.IndexOf(" = ");

            ContentNameBox.Text = selectedItem.Substring(0, indexOfEquals);
            ContentValueBox.Text = selectedItem.Substring(indexOfEquals + 3);
        }
        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedIndex == -1)
                return;

            string selectedItem = (string)FilesListBox.SelectedItem;
            int indexOfEquals = selectedItem.IndexOf(" = ");

            FileNameBox.Text = selectedItem.Substring(0, indexOfEquals);
        }

        private void InvalidNotice(string message)
        {
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK);
        }

        private void ContentValueBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ContentAddButton.PerformClick();
            }
        }
        private void HeaderValueBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HeaderAddButton.PerformClick();
            }
        }

        ///<summary>Change tab event</summary>
        private void ResponseTabControl_Selected(object sender, TabControlEventArgs e)
        {
            MyRequest viewingRequest = (HistoryListBox.SelectedIndex != -1 ? requestHistory[HistoryListBox.SelectedIndex] : null);
            switch (e.TabPageIndex)
            {
                case 0://Raw
                    if (viewingRequest != null && viewingRequest.HasRequested)
                    {
                        if (viewingRequest.responseString != "")
                        {
                            RawTextBox.Text = viewingRequest.responseString;
                        }
                        else
                        {
                            RawTextBox.Text = "No response string was obtained";
                        }
                    }
                    else
                    {
                        RawTextBox.Text = "No response selected";
                    }
                    break;
                case 1://JSON
                    if (viewingRequest != null && viewingRequest.HasRequested)
                    {
                        if (viewingRequest.responseString != "")
                        {
                            JSONTextBox.Text = viewingRequest.responseString;
                            TryFormat();
                        }
                        else
                        {
                            JSONTextBox.Text = "No response string was obtained";
                        }
                    }
                    else
                    {
                        RawTextBox.Text = "No response selected";
                    }
                    break;
                case 2://Image
                    if (viewingRequest != null && viewingRequest.HasRequested)
                    {
                        if (viewingRequest.responseBytes != null && viewingRequest.responseBytes.Length > 0)
                        {
                            try
                            {
                                using (var memStream = new MemoryStream(viewingRequest.responseBytes))
                                {
                                    ImageBox.Image = Image.FromStream(memStream);
                                }
                            }
                            catch (Exception ex)
                            {
                                ImageBox.Image = Image.FromFile("corruptImage.png");
                            }
                        }
                        else
                        {
                            ImageBox.Image = Image.FromFile("noImage.png");
                        }
                    }
                    else
                    {
                        ImageBox.Image = Image.FromFile("noImage.png");
                    }
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        ///<summary>Suppressed annoying error sound effect when pressing enter</summary>
        private void SuppressEnterSound(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void JSONFormatButton_Click(object sender, EventArgs e)
        {
            TryFormat();
        }
        private void TryFormat()
        {
            try
            {
                object jsonObject = JsonConvert.DeserializeObject(JSONTextBox.Text);
                string formattedJSON = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);//we want this formatting
                JSONTextBox.Text = formattedJSON;
                JSONTextBox.ForeColor = Color.Black;
            }
            catch
            {
                JSONTextBox.ForeColor = Color.DarkRed;
            }
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (FileNameBox.Text == "")
            {
                InvalidNotice("Must enter a name/identifier for the file");
                return;
            }

            DialogResult dialogResult = OpenDialog.ShowDialog();

            if (dialogResult != DialogResult.OK)
                return;

            string filePath = OpenDialog.FileName;

            if (currentRequest.files.ContainsKey(FileNameBox.Text))
            {
                currentRequest.files[FileNameBox.Text] = filePath;
            }
            else
            {
                currentRequest.files.Add(FileNameBox.Text, filePath);
            }

            UpdateFileList();
        }

        private void ImageSaveButton_Click(object sender, EventArgs e)
        {
            //currently just saves with .png extension
            ImageBox.Image.Save("image.png");
        }

        private void FunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionComboBox.Text == "GET")
            {
                ContentAddButton.Enabled = false;
                ContentListBox.Enabled = false;
                ContentListBox.BackColor = Color.LightGray;
                ContentNameBox.Enabled = false;
                ContentValueBox.Enabled = false;
            }
            else
            {
                ContentAddButton.Enabled = true;
                ContentListBox.Enabled = true;
                ContentListBox.BackColor = Color.White;
                ContentNameBox.Enabled = true;
                ContentValueBox.Enabled = true;
            }
        }

        private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HistoryListBox.SelectedIndex == -1)
            {
                HistoryLoadButton.Enabled = false;
            }
            else
            {
                HistoryLoadButton.Enabled = true;
            }

            RefreshResponseView();
        }
        private void HistoryLoadButton_Click(object sender, EventArgs e)
        {
            //neither of those should really happen but just to be safe
            if (HistoryListBox.SelectedIndex != -1 && HistoryListBox.SelectedIndex < requestHistory.Count)
            {
                LoadFromRequest(requestHistory[HistoryListBox.SelectedIndex]);
            }
        }
    }

    public class MyRequest
    {
        public string URL;
        public string requestFunction;
        public string responseString;
        public byte[] responseBytes;
        public Dictionary<string, string> headers;
        public Dictionary<string, string> content;
        public Dictionary<string, string> files;

        protected bool hasRequested;

        public bool HasRequested { get { return this.hasRequested; } }

        public MyRequest(string URL = "")
        {
            this.URL = URL;
            this.requestFunction = "POST";
            this.headers = new Dictionary<string, string>();
            this.content = new Dictionary<string, string>();
            this.files = new Dictionary<string, string>();
            this.responseString = "";
            this.hasRequested = false;
        }

        public MyRequest Copy()
        {
            MyRequest newRequest = new MyRequest(this.URL);
            for (int i = 0; i < this.headers.Count; i++)
            {
                string key = this.headers.ElementAt(i).Key;
                newRequest.headers.Add(key, this.headers[key]);
            }
            for (int i = 0; i < this.content.Count; i++)
            {
                string key = this.content.ElementAt(i).Key;
                newRequest.content.Add(key, this.content[key]);
            }
            for (int i = 0; i < this.files.Count; i++)
            {
                string key = this.files.ElementAt(i).Key;
                newRequest.files.Add(key, this.files[key]);
            }

            newRequest.requestFunction = this.requestFunction;
            newRequest.responseBytes = this.responseBytes;
            newRequest.responseString = this.responseString;
            newRequest.hasRequested = this.hasRequested;

            return newRequest;
        }

        /// <summary>
        /// Does not (really) support different methods.
        /// Changing method to GET will not pass content.
        /// </summary>
        public void Request()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    //Add headers
                    for (int i = 0; i < this.headers.Count; i++)
                    {
                        string key = headers.ElementAt(i).Key;
                        if (client.Headers.AllKeys.Contains(key))
                            client.Headers[key] = this.headers[key];
                        else
                            client.Headers.Add(key, this.headers[key]);
                    }

                    if (this.requestFunction != "GET")
                    {
                        //Add Content vars
                        NameValueCollection nameValues = new NameValueCollection();
                        for (int i = 0; i < this.content.Count; i++)
                        {
                            string key = this.content.ElementAt(i).Key;
                            nameValues.Add(key, this.content[key]);
                        }

                        this.responseBytes = client.UploadValues(this.URL, nameValues);

                        this.responseString = Encoding.ASCII.GetString(this.responseBytes);
                    }
                    else
                    {
                        this.responseBytes = client.DownloadData(this.URL);

                        this.responseString = Encoding.ASCII.GetString(this.responseBytes);
                    }
                }
            }
            catch (Exception ex)
            {
                responseString = "Exception occured while requesting:\n" + ex.ToString();
            }

            hasRequested = true;
        }

        /// <summary>
        /// Does not support file identifiers. Uses WebClient.UploadFile
        /// function and concats the results of multiple requests into a
        /// single response string
        /// </summary>
        public void UploadOneByOne()
        {
            //check to make sure the files are there and openable
            for (int i = 0; i < this.files.Count; i++)
            {
                string key = this.files.ElementAt(i).Key;

                try
                {
                    Stream stream = File.OpenRead(this.files[key]);
                    stream.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(this.files[key] + " was not found.", "File Not Found", MessageBoxButtons.OK);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occured while opening: " + this.files[key], "Couldn't Open File", MessageBoxButtons.OK);
                    return;
                }
            }

            try
            {
                using (WebClient client = new WebClient())
                {
                    //Add headers
                    for (int i = 0; i < this.headers.Count; i++)
                    {
                        string key = headers.ElementAt(i).Key;
                        if (client.Headers.AllKeys.Contains(key))
                            client.Headers[key] = this.headers[key];
                        else
                            client.Headers.Add(key, this.headers[key]);
                    }

                    //Add Content vars
                    NameValueCollection nameValues = new NameValueCollection();
                    for (int i = 0; i < this.content.Count; i++)
                    {
                        string key = this.content.ElementAt(i).Key;
                        nameValues.Add(key, this.content[key]);
                    }

                    List<byte> allBytes = new List<byte>();
                    for (int i = 0; i < this.files.Count; i++)
                    {
                        allBytes.AddRange(client.UploadFile(this.URL, this.requestFunction, files.ElementAt(i).Value));
                    }

                    this.responseBytes = allBytes.ToArray();

                    this.responseString = Encoding.ASCII.GetString(this.responseBytes);
                }
            }
            catch (Exception ex)
            {
                responseString = "Exception occured while uploading:\n" + ex.ToString();
            }

            hasRequested = true;
        }

        /// <summary>
        /// Does not support headers
        /// Uses a special function to support file identifiers 
        /// and multiple files in one request
        /// </summary>
        public void UploadAll()
        {
            //check to make sure the files are there and openable
            for (int i = 0; i < this.files.Count; i++)
            {
                string key = this.files.ElementAt(i).Key;

                try
                {
                    Stream stream = File.OpenRead(this.files[key]);
                    stream.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(this.files[key] + " was not found.", "File Not Found", MessageBoxButtons.OK);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occured while opening: " + this.files[key], "Couldn't Open File", MessageBoxButtons.OK);
                    return;
                }
            }

            try
            {
                using (WebClient client = new WebClient())
                {
                    //Add Content vars
                    NameValueCollection nameValues = new NameValueCollection();
                    for (int i = 0; i < this.content.Count; i++)
                    {
                        string key = this.content.ElementAt(i).Key;
                        nameValues.Add(key, this.content[key]);
                    }

                    List<UploadFile> uploads = new List<UploadFile>();
                    for (int i = 0; i < files.Count; i++)
                    {
                        string key = files.ElementAt(i).Key;
                        uploads.Add(new UploadFile()
                        {
                            Name = key,
                            Filename = files[key],
                            Stream = File.OpenRead(files[key]),
                        });
                    }

                    this.responseBytes = UploadFiles(this.URL, uploads, nameValues);

                    this.responseString = Encoding.ASCII.GetString(this.responseBytes);

                    for (int i = 0; i < uploads.Count; i++)
                    {
                        uploads[i].Stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                responseString = "Exception occured while uploading:\n" + ex.ToString();
            }

            hasRequested = true;
        }
        private byte[] UploadFiles(string address, IEnumerable<UploadFile> files, NameValueCollection values)
        {
            var request = WebRequest.Create(address);
            request.Method = "POST";
            var boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x", NumberFormatInfo.InvariantInfo);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            boundary = "--" + boundary;

            using (var requestStream = request.GetRequestStream())
            {
                // Write the values
                foreach (string name in values.Keys)
                {
                    var buffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.ASCII.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"{1}{1}", name, Environment.NewLine));
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.UTF8.GetBytes(values[name] + Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                }

                // Write the files
                foreach (var file in files)
                {
                    var buffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.UTF8.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"{2}", file.Name, file.Filename, Environment.NewLine));
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.ASCII.GetBytes(string.Format("Content-Type: {0}{1}{1}", file.ContentType, Environment.NewLine));
                    requestStream.Write(buffer, 0, buffer.Length);
                    file.Stream.CopyTo(requestStream);
                    buffer = Encoding.ASCII.GetBytes(Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                }

                var boundaryBuffer = Encoding.ASCII.GetBytes(boundary + "--");
                requestStream.Write(boundaryBuffer, 0, boundaryBuffer.Length);
            }

            using (var response = request.GetResponse())
            using (var responseStream = response.GetResponseStream())
            using (var stream = new MemoryStream())
            {
                responseStream.CopyTo(stream);
                return stream.ToArray();
            }
        }
    }
}

/*
 *          try
            {
                string url = BaseURLTextBox.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.ContentType = "application/json; charset=UTF-8";
                request.Accept = "application/json";
                request.Method = MethodComboBox.Text;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";


                using (WebClient client = new WebClient())
                {
                    byte[] respBytes = client.UploadValues(BaseURLTextBox.Text, new NameValueCollection()
                    {
                        { "username" , "tdr" },
                        { "password" , "prgm4life" },
                    });

                    string respString = Encoding.ASCII.GetString(respBytes);
                    ResponseTextBox.Text = respString;
                    return;
                }

                if (AuthTokenTextBox.Text != "")
                {
                    request.Headers.Add("authToken", AuthTokenTextBox.Text);
                }

                if (request.Method != "GET") //GET methods don't have bodies apparently
                {
                    string json = "{";

                    for (int i = 0; i < parameters.Count; i++)
                    {
                        if (i != 0)
                            json = json + ",";

                        string addition =
                            "\"" + parameters.ElementAt(i).Key + "\":" +
                            "\"" + parameters.ElementAt(i).Value + "\"";

                        json = json + addition;
                    }
                    json = json + "}";

                    byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
                    request.ContentLength = jsonBytes.Length;

                    Console.WriteLine("Sending request: {0}", json);

                    Stream requestStream = request.GetRequestStream();

                    requestStream.Write(jsonBytes, 0, jsonBytes.Length);
                    requestStream.Close();
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                for (int i = 0; i < response.Headers.Count; i++)
                {
                    string header = response.Headers[i];
                    string value = response.GetResponseHeader(header);
                    Console.WriteLine("Header {0} is {1}", header, value);
                }

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseText = reader.ReadToEnd();
                    Console.WriteLine("Got response: {0}", responseText);

                    ResponseTextBox.Text = responseText;
                    responseBytes = Encoding.ASCII.GetBytes(responseText);

                    try
                    {
                        //we're going to try and format the text as json using Newtonsoft.Json
                        object jsonObject = JsonConvert.DeserializeObject(responseText);
                        string formattedJSON = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);//we want this formatting
                        ResponseTextBox.Text = "";
                        ResponseTextBox.AppendText(formattedJSON);
                    }
                    catch (Exception ex)
                    {
                        //ResponseTextBox.Text = "Failure: " + ex.ToString();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hit an exception while requesting: {0}", exception);

                ResponseTextBox.Text = "An exception ocurred while requesting " + BaseURLTextBox.Text + ": " + exception;
            }
 * */
