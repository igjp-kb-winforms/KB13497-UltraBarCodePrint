namespace UltraBarCodePrint
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Drawing.Printing;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            this.InitializeComponent();

            ultraQRCodeBarcode1.Data = "This is a test QR code.";
        }

        private void buttonPrint_Click(object sender, System.EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image;
            using (MemoryStream ms = new MemoryStream())
            {
                // バーコードをMemoryStreamに保存する
                ultraQRCodeBarcode1.SaveTo(ms, ImageFormat.Bmp);
                // MemoryStreamからImageを生成する
                image = Image.FromStream(ms);
            }

            //画像を描画する
            e.Graphics.DrawImage(image, new Point(0, 0));
            e.HasMorePages = false;
            image.Dispose();
        }
    }
}
