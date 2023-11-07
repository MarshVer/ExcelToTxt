namespace ExcelToTxt
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_lookforshare = new System.Windows.Forms.Button();
            this.excel_folder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dhFiler = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transform = new System.Windows.Forms.Button();
            this.openFiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lookforshare
            // 
            this.btn_lookforshare.Image = ((System.Drawing.Image)(resources.GetObject("btn_lookforshare.Image")));
            this.btn_lookforshare.Location = new System.Drawing.Point(445, 4);
            this.btn_lookforshare.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lookforshare.Name = "btn_lookforshare";
            this.btn_lookforshare.Size = new System.Drawing.Size(40, 37);
            this.btn_lookforshare.TabIndex = 11;
            this.btn_lookforshare.UseVisualStyleBackColor = true;
            this.btn_lookforshare.Click += new System.EventHandler(this.btn_lookforshare_Click_1);
            // 
            // excel_folder
            // 
            this.excel_folder.Location = new System.Drawing.Point(86, 13);
            this.excel_folder.Margin = new System.Windows.Forms.Padding(2);
            this.excel_folder.Name = "excel_folder";
            this.excel_folder.Size = new System.Drawing.Size(346, 21);
            this.excel_folder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Excel文件：";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(445, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dhFiler
            // 
            this.dhFiler.Location = new System.Drawing.Point(86, 50);
            this.dhFiler.Margin = new System.Windows.Forms.Padding(2);
            this.dhFiler.Name = "dhFiler";
            this.dhFiler.Size = new System.Drawing.Size(346, 21);
            this.dhFiler.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "DH文件夹：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(47, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "注:若Excel文件后缀为xls,请先打开并将文件另存为后缀为xlsx的Excel文件";
            // 
            // transform
            // 
            this.transform.Location = new System.Drawing.Point(136, 97);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(75, 37);
            this.transform.TabIndex = 12;
            this.transform.Text = "转换";
            this.transform.UseVisualStyleBackColor = true;
            this.transform.Click += new System.EventHandler(this.transform_Click);
            // 
            // openFiler
            // 
            this.openFiler.Location = new System.Drawing.Point(288, 97);
            this.openFiler.Name = "openFiler";
            this.openFiler.Size = new System.Drawing.Size(99, 37);
            this.openFiler.TabIndex = 20;
            this.openFiler.Text = "查看DH文件夹";
            this.openFiler.UseVisualStyleBackColor = true;
            this.openFiler.Click += new System.EventHandler(this.openFiler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 170);
            this.Controls.Add(this.openFiler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dhFiler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.btn_lookforshare);
            this.Controls.Add(this.excel_folder);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Excel转Txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lookforshare;
        private System.Windows.Forms.TextBox excel_folder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dhFiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transform;
        private System.Windows.Forms.Button openFiler;
    }
}

