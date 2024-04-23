namespace UltraBarCodePrint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrint = new System.Windows.Forms.Button();
            this.ultraQRCodeBarcode1 = new Infragistics.Win.DataVisualization.UltraQRCodeBarcode();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(187, 359);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 21);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // ultraQRCodeBarcode1
            // 
            this.ultraQRCodeBarcode1.Data = "http://infragistics.com";
            this.ultraQRCodeBarcode1.ErrorMessageText = "無効な値です。ヘルプを参照して、有効なバーコードの Data プロパティ値構造を確認してください。";
            this.ultraQRCodeBarcode1.Location = new System.Drawing.Point(72, 12);
            this.ultraQRCodeBarcode1.Name = "ultraQRCodeBarcode1";
            this.ultraQRCodeBarcode1.Size = new System.Drawing.Size(300, 300);
            this.ultraQRCodeBarcode1.TabIndex = 2;
            this.ultraQRCodeBarcode1.XDimension = 0.265D;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 406);
            this.Controls.Add(this.ultraQRCodeBarcode1);
            this.Controls.Add(this.buttonPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPrint;
        private Infragistics.Win.DataVisualization.UltraQRCodeBarcode ultraQRCodeBarcode1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
