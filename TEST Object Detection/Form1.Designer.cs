namespace TEST_Object_Detection
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
            this.source_pbox = new System.Windows.Forms.PictureBox();
            this.result_pbox = new System.Windows.Forms.PictureBox();
            this.detect_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score_txt = new System.Windows.Forms.TextBox();
            this.object_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.source_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // source_pbox
            // 
            this.source_pbox.Location = new System.Drawing.Point(12, 35);
            this.source_pbox.Name = "source_pbox";
            this.source_pbox.Size = new System.Drawing.Size(427, 312);
            this.source_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.source_pbox.TabIndex = 0;
            this.source_pbox.TabStop = false;
            // 
            // result_pbox
            // 
            this.result_pbox.Location = new System.Drawing.Point(459, 35);
            this.result_pbox.Name = "result_pbox";
            this.result_pbox.Size = new System.Drawing.Size(427, 312);
            this.result_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.result_pbox.TabIndex = 0;
            this.result_pbox.TabStop = false;
            // 
            // detect_btn
            // 
            this.detect_btn.Enabled = false;
            this.detect_btn.Location = new System.Drawing.Point(381, 488);
            this.detect_btn.Name = "detect_btn";
            this.detect_btn.Size = new System.Drawing.Size(132, 29);
            this.detect_btn.TabIndex = 1;
            this.detect_btn.Text = "Detect";
            this.detect_btn.UseVisualStyleBackColor = true;
            this.detect_btn.Click += new System.EventHandler(this.detect_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(591, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Result Image to";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "save file name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // score_txt
            // 
            this.score_txt.Location = new System.Drawing.Point(439, 447);
            this.score_txt.Name = "score_txt";
            this.score_txt.ReadOnly = true;
            this.score_txt.Size = new System.Drawing.Size(82, 27);
            this.score_txt.TabIndex = 2;
            // 
            // object_txt
            // 
            this.object_txt.Location = new System.Drawing.Point(473, 414);
            this.object_txt.Name = "object_txt";
            this.object_txt.Size = new System.Drawing.Size(112, 27);
            this.object_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "object You Lokking For";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score_txt);
            this.Controls.Add(this.object_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detect_btn);
            this.Controls.Add(this.result_pbox);
            this.Controls.Add(this.source_pbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.source_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox source_pbox;
        private PictureBox result_pbox;
        private Button detect_btn;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox score_txt;
        private TextBox object_txt;
        private Label label3;
    }
}