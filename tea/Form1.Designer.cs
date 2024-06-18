namespace tea
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
            btnEncode = new Button();
            tbStr = new TextBox();
            tbEncryptedStr = new TextBox();
            tbDecryptedStr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbKey = new Label();
            SuspendLayout();
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(306, 103);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(311, 34);
            btnEncode.TabIndex = 0;
            btnEncode.Text = "Зашифровать";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // tbStr
            // 
            tbStr.Location = new Point(38, 55);
            tbStr.Name = "tbStr";
            tbStr.Size = new Size(841, 31);
            tbStr.TabIndex = 1;
            // 
            // tbEncryptedStr
            // 
            tbEncryptedStr.Location = new Point(38, 281);
            tbEncryptedStr.Name = "tbEncryptedStr";
            tbEncryptedStr.Size = new Size(841, 31);
            tbEncryptedStr.TabIndex = 2;
            // 
            // tbDecryptedStr
            // 
            tbDecryptedStr.Location = new Point(38, 368);
            tbDecryptedStr.Name = "tbDecryptedStr";
            tbDecryptedStr.Size = new Size(841, 31);
            tbDecryptedStr.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 4;
            label1.Text = "Строка для шифрования:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 253);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 5;
            label2.Text = "Зашифрованная строка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 340);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 6;
            label3.Text = "Расшифрованная строка:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 197);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 7;
            label4.Text = "Ключ:";
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.Location = new Point(104, 197);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(19, 25);
            lbKey.TabIndex = 8;
            lbKey.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(lbKey);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDecryptedStr);
            Controls.Add(tbEncryptedStr);
            Controls.Add(tbStr);
            Controls.Add(btnEncode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncode;
        private TextBox tbStr;
        private TextBox tbEncryptedStr;
        private TextBox tbDecryptedStr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbKey;
    }
}
