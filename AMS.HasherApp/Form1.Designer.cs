
namespace AMS.HasherApp
{
    partial class Form1
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.md5Label = new System.Windows.Forms.Label();
            this.md5Textbox = new System.Windows.Forms.TextBox();
            this.md4Textbox = new System.Windows.Forms.TextBox();
            this.md4Label = new System.Windows.Forms.Label();
            this.base64Textbox = new System.Windows.Forms.TextBox();
            this.base64Label = new System.Windows.Forms.Label();
            this.sha1Textbox = new System.Windows.Forms.TextBox();
            this.sha1Label = new System.Windows.Forms.Label();
            this.sha256Textbox = new System.Windows.Forms.TextBox();
            this.sha256Label = new System.Windows.Forms.Label();
            this.sha512Textbox = new System.Windows.Forms.TextBox();
            this.sha512Label = new System.Windows.Forms.Label();
            this.whirlpoolTextbox = new System.Windows.Forms.TextBox();
            this.whirlpoolLabel = new System.Windows.Forms.Label();
            this.rot13Textbox = new System.Windows.Forms.TextBox();
            this.rot13Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(38, 15);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input:";
            // 
            // inputTextbox
            // 
            this.inputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextbox.Location = new System.Drawing.Point(56, 6);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(286, 23);
            this.inputTextbox.TabIndex = 1;
            this.inputTextbox.TextChanged += new System.EventHandler(this.inputTextbox_TextChanged);
            // 
            // md5Label
            // 
            this.md5Label.AutoSize = true;
            this.md5Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.md5Label.Location = new System.Drawing.Point(12, 115);
            this.md5Label.Name = "md5Label";
            this.md5Label.Size = new System.Drawing.Size(28, 15);
            this.md5Label.TabIndex = 2;
            this.md5Label.Text = "MD5";
            // 
            // md5Textbox
            // 
            this.md5Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md5Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.md5Textbox.Location = new System.Drawing.Point(88, 112);
            this.md5Textbox.Name = "md5Textbox";
            this.md5Textbox.ReadOnly = true;
            this.md5Textbox.Size = new System.Drawing.Size(254, 21);
            this.md5Textbox.TabIndex = 3;
            // 
            // md4Textbox
            // 
            this.md4Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md4Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.md4Textbox.Location = new System.Drawing.Point(88, 83);
            this.md4Textbox.Name = "md4Textbox";
            this.md4Textbox.ReadOnly = true;
            this.md4Textbox.Size = new System.Drawing.Size(254, 21);
            this.md4Textbox.TabIndex = 5;
            // 
            // md4Label
            // 
            this.md4Label.AutoSize = true;
            this.md4Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.md4Label.Location = new System.Drawing.Point(12, 86);
            this.md4Label.Name = "md4Label";
            this.md4Label.Size = new System.Drawing.Size(28, 15);
            this.md4Label.TabIndex = 4;
            this.md4Label.Text = "MD4";
            // 
            // base64Textbox
            // 
            this.base64Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base64Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.base64Textbox.Location = new System.Drawing.Point(88, 54);
            this.base64Textbox.Name = "base64Textbox";
            this.base64Textbox.ReadOnly = true;
            this.base64Textbox.Size = new System.Drawing.Size(254, 21);
            this.base64Textbox.TabIndex = 7;
            // 
            // base64Label
            // 
            this.base64Label.AutoSize = true;
            this.base64Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.base64Label.Location = new System.Drawing.Point(12, 57);
            this.base64Label.Name = "base64Label";
            this.base64Label.Size = new System.Drawing.Size(49, 15);
            this.base64Label.TabIndex = 6;
            this.base64Label.Text = "Base64";
            // 
            // sha1Textbox
            // 
            this.sha1Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha1Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sha1Textbox.Location = new System.Drawing.Point(88, 141);
            this.sha1Textbox.Name = "sha1Textbox";
            this.sha1Textbox.ReadOnly = true;
            this.sha1Textbox.Size = new System.Drawing.Size(254, 21);
            this.sha1Textbox.TabIndex = 9;
            // 
            // sha1Label
            // 
            this.sha1Label.AutoSize = true;
            this.sha1Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sha1Label.Location = new System.Drawing.Point(12, 144);
            this.sha1Label.Name = "sha1Label";
            this.sha1Label.Size = new System.Drawing.Size(35, 15);
            this.sha1Label.TabIndex = 8;
            this.sha1Label.Text = "SHA1";
            // 
            // sha256Textbox
            // 
            this.sha256Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha256Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sha256Textbox.Location = new System.Drawing.Point(88, 170);
            this.sha256Textbox.Name = "sha256Textbox";
            this.sha256Textbox.ReadOnly = true;
            this.sha256Textbox.Size = new System.Drawing.Size(254, 21);
            this.sha256Textbox.TabIndex = 11;
            // 
            // sha256Label
            // 
            this.sha256Label.AutoSize = true;
            this.sha256Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sha256Label.Location = new System.Drawing.Point(12, 173);
            this.sha256Label.Name = "sha256Label";
            this.sha256Label.Size = new System.Drawing.Size(49, 15);
            this.sha256Label.TabIndex = 10;
            this.sha256Label.Text = "SHA256";
            // 
            // sha512Textbox
            // 
            this.sha512Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha512Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sha512Textbox.Location = new System.Drawing.Point(88, 199);
            this.sha512Textbox.Name = "sha512Textbox";
            this.sha512Textbox.ReadOnly = true;
            this.sha512Textbox.Size = new System.Drawing.Size(254, 21);
            this.sha512Textbox.TabIndex = 13;
            // 
            // sha512Label
            // 
            this.sha512Label.AutoSize = true;
            this.sha512Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sha512Label.Location = new System.Drawing.Point(12, 202);
            this.sha512Label.Name = "sha512Label";
            this.sha512Label.Size = new System.Drawing.Size(49, 15);
            this.sha512Label.TabIndex = 12;
            this.sha512Label.Text = "SHA512";
            // 
            // whirlpoolTextbox
            // 
            this.whirlpoolTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whirlpoolTextbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whirlpoolTextbox.Location = new System.Drawing.Point(88, 228);
            this.whirlpoolTextbox.Name = "whirlpoolTextbox";
            this.whirlpoolTextbox.ReadOnly = true;
            this.whirlpoolTextbox.Size = new System.Drawing.Size(254, 21);
            this.whirlpoolTextbox.TabIndex = 15;
            // 
            // whirlpoolLabel
            // 
            this.whirlpoolLabel.AutoSize = true;
            this.whirlpoolLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whirlpoolLabel.Location = new System.Drawing.Point(12, 231);
            this.whirlpoolLabel.Name = "whirlpoolLabel";
            this.whirlpoolLabel.Size = new System.Drawing.Size(70, 15);
            this.whirlpoolLabel.TabIndex = 14;
            this.whirlpoolLabel.Text = "Whirlpool";
            // 
            // rot13Textbox
            // 
            this.rot13Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rot13Textbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rot13Textbox.Location = new System.Drawing.Point(88, 257);
            this.rot13Textbox.Name = "rot13Textbox";
            this.rot13Textbox.ReadOnly = true;
            this.rot13Textbox.Size = new System.Drawing.Size(254, 21);
            this.rot13Textbox.TabIndex = 17;
            // 
            // rot13Label
            // 
            this.rot13Label.AutoSize = true;
            this.rot13Label.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rot13Label.Location = new System.Drawing.Point(12, 260);
            this.rot13Label.Name = "rot13Label";
            this.rot13Label.Size = new System.Drawing.Size(42, 15);
            this.rot13Label.TabIndex = 16;
            this.rot13Label.Text = "ROT13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 291);
            this.Controls.Add(this.rot13Textbox);
            this.Controls.Add(this.rot13Label);
            this.Controls.Add(this.whirlpoolTextbox);
            this.Controls.Add(this.whirlpoolLabel);
            this.Controls.Add(this.sha512Textbox);
            this.Controls.Add(this.sha512Label);
            this.Controls.Add(this.sha256Textbox);
            this.Controls.Add(this.sha256Label);
            this.Controls.Add(this.sha1Textbox);
            this.Controls.Add(this.sha1Label);
            this.Controls.Add(this.base64Textbox);
            this.Controls.Add(this.base64Label);
            this.Controls.Add(this.md4Textbox);
            this.Controls.Add(this.md4Label);
            this.Controls.Add(this.md5Textbox);
            this.Controls.Add(this.md5Label);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.inputLabel);
            this.MinimumSize = new System.Drawing.Size(370, 330);
            this.Name = "Form1";
            this.Text = "Hasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label md5Label;
        private System.Windows.Forms.TextBox md5Textbox;
        private System.Windows.Forms.TextBox md4Textbox;
        private System.Windows.Forms.Label md4Label;
        private System.Windows.Forms.TextBox base64Textbox;
        private System.Windows.Forms.Label base64Label;
        private System.Windows.Forms.TextBox sha1Textbox;
        private System.Windows.Forms.Label sha1Label;
        private System.Windows.Forms.TextBox sha256Textbox;
        private System.Windows.Forms.Label sha256Label;
        private System.Windows.Forms.TextBox sha512Textbox;
        private System.Windows.Forms.Label sha512Label;
        private System.Windows.Forms.TextBox whirlpoolTextbox;
        private System.Windows.Forms.Label whirlpoolLabel;
        private System.Windows.Forms.TextBox rot13Textbox;
        private System.Windows.Forms.Label rot13Label;
    }
}

