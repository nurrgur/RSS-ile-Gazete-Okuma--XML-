
namespace GazeteXML.ODEV
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
            this.lstMilliyet = new System.Windows.Forms.ListBox();
            this.btnOkU = new System.Windows.Forms.Button();
            this.lstHaberTurk = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lstMilliyet
            // 
            this.lstMilliyet.FormattingEnabled = true;
            this.lstMilliyet.ItemHeight = 20;
            this.lstMilliyet.Location = new System.Drawing.Point(73, 345);
            this.lstMilliyet.Name = "lstMilliyet";
            this.lstMilliyet.Size = new System.Drawing.Size(565, 304);
            this.lstMilliyet.TabIndex = 8;
            this.lstMilliyet.SelectedIndexChanged += new System.EventHandler(this.lstMilliyet_SelectedIndexChanged);
            // 
            // btnOkU
            // 
            this.btnOkU.Location = new System.Drawing.Point(963, 559);
            this.btnOkU.Name = "btnOkU";
            this.btnOkU.Size = new System.Drawing.Size(129, 59);
            this.btnOkU.TabIndex = 7;
            this.btnOkU.Text = "OKU";
            this.btnOkU.UseVisualStyleBackColor = true;
            this.btnOkU.Click += new System.EventHandler(this.btnOkU_Click);
            // 
            // lstHaberTurk
            // 
            this.lstHaberTurk.FormattingEnabled = true;
            this.lstHaberTurk.ItemHeight = 20;
            this.lstHaberTurk.Location = new System.Drawing.Point(73, 12);
            this.lstHaberTurk.Name = "lstHaberTurk";
            this.lstHaberTurk.Size = new System.Drawing.Size(565, 304);
            this.lstHaberTurk.TabIndex = 6;
            this.lstHaberTurk.SelectedIndexChanged += new System.EventHandler(this.lstHaberTurk_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(674, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(481, 508);
            this.webBrowser1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 825);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lstMilliyet);
            this.Controls.Add(this.btnOkU);
            this.Controls.Add(this.lstHaberTurk);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMilliyet;
        private System.Windows.Forms.Button btnOkU;
        private System.Windows.Forms.ListBox lstHaberTurk;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

