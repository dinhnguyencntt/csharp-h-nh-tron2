namespace csharp_hình_tron2
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
            this.btnchuvi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.btndientich = new System.Windows.Forms.Button();
            this.gpbchucnang1 = new System.Windows.Forms.GroupBox();
            this.gpbchucnang = new System.Windows.Forms.GroupBox();
            this.chcchuvi = new System.Windows.Forms.CheckBox();
            this.chbdientich = new System.Windows.Forms.CheckBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.btnloai1 = new System.Windows.Forms.Button();
            this.btnloai2 = new System.Windows.Forms.Button();
            this.gpbchucnang1.SuspendLayout();
            this.gpbchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(29, 206);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 0;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "bán kính";
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(160, 30);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 2;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(52, 125);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 3;
            this.lblkq.Text = "kết quả";
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(29, 287);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(75, 23);
            this.btndientich.TabIndex = 4;
            this.btndientich.Text = "diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // gpbchucnang1
            // 
            this.gpbchucnang1.Controls.Add(this.rdbdientich);
            this.gpbchucnang1.Controls.Add(this.rdbchuvi);
            this.gpbchucnang1.Location = new System.Drawing.Point(392, 67);
            this.gpbchucnang1.Name = "gpbchucnang1";
            this.gpbchucnang1.Size = new System.Drawing.Size(135, 223);
            this.gpbchucnang1.TabIndex = 5;
            this.gpbchucnang1.TabStop = false;
            this.gpbchucnang1.Text = "chọn chức năng";
            // 
            // gpbchucnang
            // 
            this.gpbchucnang.Controls.Add(this.chbdientich);
            this.gpbchucnang.Controls.Add(this.chcchuvi);
            this.gpbchucnang.Location = new System.Drawing.Point(589, 67);
            this.gpbchucnang.Name = "gpbchucnang";
            this.gpbchucnang.Size = new System.Drawing.Size(135, 223);
            this.gpbchucnang.TabIndex = 6;
            this.gpbchucnang.TabStop = false;
            this.gpbchucnang.Text = "chọn chức năng";
            // 
            // chcchuvi
            // 
            this.chcchuvi.AutoSize = true;
            this.chcchuvi.Location = new System.Drawing.Point(23, 44);
            this.chcchuvi.Name = "chcchuvi";
            this.chcchuvi.Size = new System.Drawing.Size(55, 17);
            this.chcchuvi.TabIndex = 0;
            this.chcchuvi.Text = "chu vi";
            this.chcchuvi.UseVisualStyleBackColor = true;
            // 
            // chbdientich
            // 
            this.chbdientich.AutoSize = true;
            this.chbdientich.Location = new System.Drawing.Point(23, 92);
            this.chbdientich.Name = "chbdientich";
            this.chbdientich.Size = new System.Drawing.Size(68, 17);
            this.chbdientich.TabIndex = 0;
            this.chbdientich.Text = "diện tích";
            this.chbdientich.UseVisualStyleBackColor = true;
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(27, 35);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(54, 17);
            this.rdbchuvi.TabIndex = 0;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(25, 103);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(67, 17);
            this.rdbdientich.TabIndex = 1;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // btnloai1
            // 
            this.btnloai1.Location = new System.Drawing.Point(392, 322);
            this.btnloai1.Name = "btnloai1";
            this.btnloai1.Size = new System.Drawing.Size(75, 23);
            this.btnloai1.TabIndex = 7;
            this.btnloai1.Text = "tính loại 1";
            this.btnloai1.UseVisualStyleBackColor = true;
            this.btnloai1.Click += new System.EventHandler(this.btnloai1_Click);
            // 
            // btnloai2
            // 
            this.btnloai2.Location = new System.Drawing.Point(589, 322);
            this.btnloai2.Name = "btnloai2";
            this.btnloai2.Size = new System.Drawing.Size(75, 23);
            this.btnloai2.TabIndex = 8;
            this.btnloai2.Text = "tính loại 2";
            this.btnloai2.UseVisualStyleBackColor = true;
            this.btnloai2.Click += new System.EventHandler(this.btnloai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnloai2);
            this.Controls.Add(this.btnloai1);
            this.Controls.Add(this.gpbchucnang);
            this.Controls.Add(this.gpbchucnang1);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchuvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbchucnang1.ResumeLayout(false);
            this.gpbchucnang1.PerformLayout();
            this.gpbchucnang.ResumeLayout(false);
            this.gpbchucnang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.GroupBox gpbchucnang1;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.GroupBox gpbchucnang;
        private System.Windows.Forms.CheckBox chbdientich;
        private System.Windows.Forms.CheckBox chcchuvi;
        private System.Windows.Forms.Button btnloai1;
        private System.Windows.Forms.Button btnloai2;
    }
}

