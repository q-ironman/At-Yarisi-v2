
namespace At_Yarisi_v2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.horse4 = new System.Windows.Forms.PictureBox();
            this.horse5 = new System.Windows.Forms.PictureBox();
            this.finishline = new System.Windows.Forms.PictureBox();
            this.scoreboard = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(27, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(102, 42);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(27, 60);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(102, 39);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // horse1
            // 
            this.horse1.Image = ((System.Drawing.Image)(resources.GetObject("horse1.Image")));
            this.horse1.Location = new System.Drawing.Point(27, 108);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(100, 50);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse1.TabIndex = 2;
            this.horse1.TabStop = false;
            // 
            // horse2
            // 
            this.horse2.Image = ((System.Drawing.Image)(resources.GetObject("horse2.Image")));
            this.horse2.Location = new System.Drawing.Point(27, 164);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(100, 50);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse2.TabIndex = 3;
            this.horse2.TabStop = false;
            // 
            // horse3
            // 
            this.horse3.Image = ((System.Drawing.Image)(resources.GetObject("horse3.Image")));
            this.horse3.Location = new System.Drawing.Point(27, 220);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(100, 50);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse3.TabIndex = 4;
            this.horse3.TabStop = false;
            this.horse3.Visible = false;
            // 
            // horse4
            // 
            this.horse4.Image = ((System.Drawing.Image)(resources.GetObject("horse4.Image")));
            this.horse4.Location = new System.Drawing.Point(27, 276);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(100, 50);
            this.horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse4.TabIndex = 5;
            this.horse4.TabStop = false;
            this.horse4.Visible = false;
            // 
            // horse5
            // 
            this.horse5.Image = ((System.Drawing.Image)(resources.GetObject("horse5.Image")));
            this.horse5.Location = new System.Drawing.Point(27, 332);
            this.horse5.Name = "horse5";
            this.horse5.Size = new System.Drawing.Size(100, 50);
            this.horse5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse5.TabIndex = 6;
            this.horse5.TabStop = false;
            this.horse5.Visible = false;
            // 
            // finishline
            // 
            this.finishline.Image = ((System.Drawing.Image)(resources.GetObject("finishline.Image")));
            this.finishline.Location = new System.Drawing.Point(628, 108);
            this.finishline.Name = "finishline";
            this.finishline.Size = new System.Drawing.Size(100, 274);
            this.finishline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finishline.TabIndex = 7;
            this.finishline.TabStop = false;
            // 
            // scoreboard
            // 
            this.scoreboard.Location = new System.Drawing.Point(628, 12);
            this.scoreboard.Multiline = true;
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(100, 87);
            this.scoreboard.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(151, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(49, 31);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.finishline);
            this.Controls.Add(this.horse5);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.PictureBox horse4;
        private System.Windows.Forms.PictureBox horse5;
        private System.Windows.Forms.PictureBox finishline;
        private System.Windows.Forms.TextBox scoreboard;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}

