namespace SoulStream2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAddressBar = new TextBox();
            buttonFlowOn = new Button();
            webView21Main = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21Main).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddressBar
            // 
            textBoxAddressBar.Location = new Point(38, 24);
            textBoxAddressBar.Name = "textBoxAddressBar";
            textBoxAddressBar.Size = new Size(1860, 39);
            textBoxAddressBar.TabIndex = 0;
            // 
            // buttonFlowOn
            // 
            buttonFlowOn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonFlowOn.BackColor = Color.FromArgb(255, 192, 192);
            buttonFlowOn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFlowOn.ForeColor = SystemColors.ButtonHighlight;
            buttonFlowOn.Location = new Point(1904, 24);
            buttonFlowOn.Name = "buttonFlowOn";
            buttonFlowOn.Size = new Size(167, 39);
            buttonFlowOn.TabIndex = 1;
            buttonFlowOn.Text = "Flow On!";
            buttonFlowOn.UseVisualStyleBackColor = false;
            buttonFlowOn.Click += buttonFlowOn_Click;
            // 
            // webView21Main
            // 
            webView21Main.AllowExternalDrop = true;
            webView21Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21Main.CreationProperties = null;
            webView21Main.DefaultBackgroundColor = Color.White;
            webView21Main.Location = new Point(51, 110);
            webView21Main.Name = "webView21Main";
            webView21Main.Size = new Size(1945, 740);
            webView21Main.Source = new Uri("https://www.google.com", UriKind.Absolute);
            webView21Main.TabIndex = 2;
            webView21Main.ZoomFactor = 1D;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(2083, 940);
            Controls.Add(webView21Main);
            Controls.Add(buttonFlowOn);
            Controls.Add(textBoxAddressBar);
            Name = "FormMain";
            Text = "Soul Stream";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)webView21Main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddressBar;
        private Button buttonFlowOn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21Main;
    }
}
