using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace TextExtractor
{
    internal class TextReader
    {
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public string Extract()
        {
            string text = "";
            try
            {
                using (var engine = new TesseractEngine(@"C:\Program Files\Tesseract-OCR\tessdata", "eng", EngineMode.Default))
                {
                    // Use the TesseractEngine to process the image
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            // Get the recognized text
                            text = page.GetText();
                            if(text.Length <= 0)
                            {
                                return text;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return text;
        }
    }
}
