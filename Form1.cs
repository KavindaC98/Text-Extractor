namespace TextExtractor
{
    public partial class Form1 : Form
    {
        TextReader reader = new TextReader();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = openFileDialog1.FileName;
                reader.ImagePath= openFileDialog1.FileName;
            }

        }

        private void button_recognize_Click(object sender, EventArgs e)
        {
            string extractedText = reader.Extract();
            if (extractedText == null || extractedText.Length <= 0)
            {
                outputTextBox.Text = "Hooray! your image is text free!";
            }
            else
            {
                outputTextBox.Text = extractedText;
            }
        }
    }
}