namespace QuakeHistory
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Last = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Ndate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Last
            // 
            this.Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Last.Font = new System.Drawing.Font("Koruri Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Last.ForeColor = System.Drawing.Color.White;
            this.Last.Location = new System.Drawing.Point(0, 0);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(459, 41);
            this.Last.TabIndex = 1;
            this.Last.Text = "最後のテスト１０文字震源名での地震";
            this.Last.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.Color.Transparent;
            this.Day.Font = new System.Drawing.Font("Koruri Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Day.ForeColor = System.Drawing.Color.White;
            this.Day.Location = new System.Drawing.Point(0, 41);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(185, 74);
            this.Day.TabIndex = 1;
            this.Day.Text = "1000";
            this.Day.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Koruri Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 57);
            this.label3.TabIndex = 1;
            this.label3.Text = "日前";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Koruri Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(281, 41);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(542, 74);
            this.Date.TabIndex = 1;
            this.Date.Text = "10年10ヶ月10日";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ndate
            // 
            this.Ndate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Ndate.Font = new System.Drawing.Font("Koruri Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ndate.ForeColor = System.Drawing.Color.White;
            this.Ndate.Location = new System.Drawing.Point(458, 0);
            this.Ndate.Name = "Ndate";
            this.Ndate.Size = new System.Drawing.Size(365, 41);
            this.Ndate.TabIndex = 1;
            this.Ndate.Text = "2000/00/00 00:00発生";
            this.Ndate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(824, 117);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ndate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Last);
            this.Name = "Form1";
            this.Text = "LastQuake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Last;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Ndate;
    }
}

