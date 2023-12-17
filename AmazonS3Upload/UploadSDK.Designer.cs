namespace AmazonS3Upload
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
            label1 = new Label();
            txtBucketName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnChooseFile = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUpload = new Button();
            label3 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Upload S3 using SDK";
            // 
            // txtBucketName
            // 
            txtBucketName.Location = new Point(447, 128);
            txtBucketName.Margin = new Padding(4, 3, 4, 3);
            txtBucketName.Name = "txtBucketName";
            txtBucketName.Size = new Size(154, 31);
            txtBucketName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(446, 282);
            btnChooseFile.Margin = new Padding(4, 3, 4, 3);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(156, 37);
            btnChooseFile.TabIndex = 3;
            btnChooseFile.Text = "Choose";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 4;
            label2.Text = "Bucket name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 287);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 6;
            label4.Text = "Path";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(634, 290);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(327, 378);
            btnUpload.Margin = new Padding(4, 3, 4, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(117, 37);
            btnUpload.TabIndex = 8;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 217);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 10;
            label6.Text = "Key name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(503, 381);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(btnUpload);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnChooseFile);
            Controls.Add(txtBucketName);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBucketName;
        private OpenFileDialog openFileDialog1;
        private Button btnChooseFile;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnUpload;
        private Label label3;
        private Label label6;
        private TextBox textBox1;
    }
}
