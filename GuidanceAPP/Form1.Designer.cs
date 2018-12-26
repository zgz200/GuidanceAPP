namespace GuidanceAPP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XMtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RQdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BZCombox = new System.Windows.Forms.ComboBox();
            this.XBcombox = new System.Windows.Forms.ComboBox();
            this.NLlabel = new System.Windows.Forms.Label();
            this.NLtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CFZcomboBox = new System.Windows.Forms.ComboBox();
            this.SFcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CScomboBox = new System.Windows.Forms.ComboBox();
            this.CSlabel = new System.Windows.Forms.Label();
            this.QXcomboBox = new System.Windows.Forms.ComboBox();
            this.QXlabel = new System.Windows.Forms.Label();
            this.DHtextBox = new System.Windows.Forms.TextBox();
            this.DHlabel = new System.Windows.Forms.Label();
            this.MTcomboBox = new System.Windows.Forms.ComboBox();
            this.MTlabel = new System.Windows.Forms.Label();
            this.MTFLcomboBox = new System.Windows.Forms.ComboBox();
            this.MTFLlabel = new System.Windows.Forms.Label();
            this.SFYYcomboBox = new System.Windows.Forms.ComboBox();
            this.SFYYlabel = new System.Windows.Forms.Label();
            this.ZScomboBox = new System.Windows.Forms.ComboBox();
            this.ZSlabel = new System.Windows.Forms.Label();
            this.SFZLtextBox = new System.Windows.Forms.TextBox();
            this.SFZLlabel = new System.Windows.Forms.Label();
            this.DZtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BZtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(854, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(31, 201);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(17, 12);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // XMtextBox
            // 
            this.XMtextBox.Location = new System.Drawing.Point(401, 231);
            this.XMtextBox.Name = "XMtextBox";
            this.XMtextBox.Size = new System.Drawing.Size(100, 21);
            this.XMtextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "编辑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(779, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "性别";
            // 
            // RQdateTimePicker
            // 
            this.RQdateTimePicker.Location = new System.Drawing.Point(63, 231);
            this.RQdateTimePicker.Name = "RQdateTimePicker";
            this.RQdateTimePicker.Size = new System.Drawing.Size(106, 21);
            this.RQdateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "病种";
            // 
            // BZCombox
            // 
            this.BZCombox.FormattingEnabled = true;
            this.BZCombox.Items.AddRange(new object[] {
            "白癜风",
            "银屑病",
            "非色素性疾病"});
            this.BZCombox.Location = new System.Drawing.Point(228, 231);
            this.BZCombox.Name = "BZCombox";
            this.BZCombox.Size = new System.Drawing.Size(106, 20);
            this.BZCombox.TabIndex = 2;
            // 
            // XBcombox
            // 
            this.XBcombox.FormattingEnabled = true;
            this.XBcombox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.XBcombox.Location = new System.Drawing.Point(566, 231);
            this.XBcombox.Name = "XBcombox";
            this.XBcombox.Size = new System.Drawing.Size(44, 20);
            this.XBcombox.TabIndex = 4;
            // 
            // NLlabel
            // 
            this.NLlabel.AutoSize = true;
            this.NLlabel.Location = new System.Drawing.Point(616, 235);
            this.NLlabel.Name = "NLlabel";
            this.NLlabel.Size = new System.Drawing.Size(29, 12);
            this.NLlabel.TabIndex = 15;
            this.NLlabel.Text = "年龄";
            // 
            // NLtextBox
            // 
            this.NLtextBox.Location = new System.Drawing.Point(659, 231);
            this.NLtextBox.Name = "NLtextBox";
            this.NLtextBox.Size = new System.Drawing.Size(40, 21);
            this.NLtextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "初复诊";
            // 
            // CFZcomboBox
            // 
            this.CFZcomboBox.FormattingEnabled = true;
            this.CFZcomboBox.Location = new System.Drawing.Point(779, 231);
            this.CFZcomboBox.Name = "CFZcomboBox";
            this.CFZcomboBox.Size = new System.Drawing.Size(44, 20);
            this.CFZcomboBox.TabIndex = 17;
            this.CFZcomboBox.SelectedIndexChanged += new System.EventHandler(this.CFZcomboBox_SelectedIndexChanged);
            // 
            // SFcomboBox
            // 
            this.SFcomboBox.FormattingEnabled = true;
            this.SFcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SFcomboBox.Location = new System.Drawing.Point(63, 283);
            this.SFcomboBox.Name = "SFcomboBox";
            this.SFcomboBox.Size = new System.Drawing.Size(106, 20);
            this.SFcomboBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "省份";
            // 
            // CScomboBox
            // 
            this.CScomboBox.FormattingEnabled = true;
            this.CScomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CScomboBox.Location = new System.Drawing.Point(228, 283);
            this.CScomboBox.Name = "CScomboBox";
            this.CScomboBox.Size = new System.Drawing.Size(106, 20);
            this.CScomboBox.TabIndex = 21;
            // 
            // CSlabel
            // 
            this.CSlabel.AutoSize = true;
            this.CSlabel.Location = new System.Drawing.Point(190, 287);
            this.CSlabel.Name = "CSlabel";
            this.CSlabel.Size = new System.Drawing.Size(29, 12);
            this.CSlabel.TabIndex = 20;
            this.CSlabel.Text = "城市";
            // 
            // QXcomboBox
            // 
            this.QXcomboBox.FormattingEnabled = true;
            this.QXcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.QXcomboBox.Location = new System.Drawing.Point(401, 283);
            this.QXcomboBox.Name = "QXcomboBox";
            this.QXcomboBox.Size = new System.Drawing.Size(100, 20);
            this.QXcomboBox.TabIndex = 23;
            // 
            // QXlabel
            // 
            this.QXlabel.AutoSize = true;
            this.QXlabel.Location = new System.Drawing.Point(360, 287);
            this.QXlabel.Name = "QXlabel";
            this.QXlabel.Size = new System.Drawing.Size(35, 12);
            this.QXlabel.TabIndex = 22;
            this.QXlabel.Text = "区/县";
            // 
            // DHtextBox
            // 
            this.DHtextBox.Location = new System.Drawing.Point(573, 283);
            this.DHtextBox.Name = "DHtextBox";
            this.DHtextBox.Size = new System.Drawing.Size(153, 21);
            this.DHtextBox.TabIndex = 25;
            // 
            // DHlabel
            // 
            this.DHlabel.AutoSize = true;
            this.DHlabel.Location = new System.Drawing.Point(531, 287);
            this.DHlabel.Name = "DHlabel";
            this.DHlabel.Size = new System.Drawing.Size(29, 12);
            this.DHlabel.TabIndex = 24;
            this.DHlabel.Text = "电话";
            // 
            // MTcomboBox
            // 
            this.MTcomboBox.FormattingEnabled = true;
            this.MTcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.MTcomboBox.Location = new System.Drawing.Point(63, 334);
            this.MTcomboBox.Name = "MTcomboBox";
            this.MTcomboBox.Size = new System.Drawing.Size(106, 20);
            this.MTcomboBox.TabIndex = 27;
            // 
            // MTlabel
            // 
            this.MTlabel.AutoSize = true;
            this.MTlabel.Location = new System.Drawing.Point(31, 338);
            this.MTlabel.Name = "MTlabel";
            this.MTlabel.Size = new System.Drawing.Size(29, 12);
            this.MTlabel.TabIndex = 26;
            this.MTlabel.Text = "媒体";
            // 
            // MTFLcomboBox
            // 
            this.MTFLcomboBox.FormattingEnabled = true;
            this.MTFLcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.MTFLcomboBox.Location = new System.Drawing.Point(244, 334);
            this.MTFLcomboBox.Name = "MTFLcomboBox";
            this.MTFLcomboBox.Size = new System.Drawing.Size(90, 20);
            this.MTFLcomboBox.TabIndex = 29;
            // 
            // MTFLlabel
            // 
            this.MTFLlabel.AutoSize = true;
            this.MTFLlabel.Location = new System.Drawing.Point(185, 338);
            this.MTFLlabel.Name = "MTFLlabel";
            this.MTFLlabel.Size = new System.Drawing.Size(53, 12);
            this.MTFLlabel.TabIndex = 28;
            this.MTFLlabel.Text = "媒体分类";
            // 
            // SFYYcomboBox
            // 
            this.SFYYcomboBox.FormattingEnabled = true;
            this.SFYYcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SFYYcomboBox.Location = new System.Drawing.Point(401, 334);
            this.SFYYcomboBox.Name = "SFYYcomboBox";
            this.SFYYcomboBox.Size = new System.Drawing.Size(100, 20);
            this.SFYYcomboBox.TabIndex = 31;
            // 
            // SFYYlabel
            // 
            this.SFYYlabel.AutoSize = true;
            this.SFYYlabel.Location = new System.Drawing.Point(342, 338);
            this.SFYYlabel.Name = "SFYYlabel";
            this.SFYYlabel.Size = new System.Drawing.Size(53, 12);
            this.SFYYlabel.TabIndex = 30;
            this.SFYYlabel.Text = "是否预约";
            // 
            // ZScomboBox
            // 
            this.ZScomboBox.FormattingEnabled = true;
            this.ZScomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ZScomboBox.Location = new System.Drawing.Point(580, 334);
            this.ZScomboBox.Name = "ZScomboBox";
            this.ZScomboBox.Size = new System.Drawing.Size(100, 20);
            this.ZScomboBox.TabIndex = 33;
            // 
            // ZSlabel
            // 
            this.ZSlabel.AutoSize = true;
            this.ZSlabel.Location = new System.Drawing.Point(531, 338);
            this.ZSlabel.Name = "ZSlabel";
            this.ZSlabel.Size = new System.Drawing.Size(29, 12);
            this.ZSlabel.TabIndex = 32;
            this.ZSlabel.Text = "诊室";
            // 
            // SFZLtextBox
            // 
            this.SFZLtextBox.Location = new System.Drawing.Point(90, 401);
            this.SFZLtextBox.Name = "SFZLtextBox";
            this.SFZLtextBox.Size = new System.Drawing.Size(100, 21);
            this.SFZLtextBox.TabIndex = 35;
            // 
            // SFZLlabel
            // 
            this.SFZLlabel.AutoSize = true;
            this.SFZLlabel.Location = new System.Drawing.Point(31, 405);
            this.SFZLlabel.Name = "SFZLlabel";
            this.SFZLlabel.Size = new System.Drawing.Size(53, 12);
            this.SFZLlabel.TabIndex = 34;
            this.SFZLlabel.Text = "是否治疗";
            // 
            // DZtextBox
            // 
            this.DZtextBox.Location = new System.Drawing.Point(255, 401);
            this.DZtextBox.Name = "DZtextBox";
            this.DZtextBox.Size = new System.Drawing.Size(100, 21);
            this.DZtextBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "导诊";
            // 
            // BZtextBox
            // 
            this.BZtextBox.Location = new System.Drawing.Point(73, 453);
            this.BZtextBox.Name = "BZtextBox";
            this.BZtextBox.Size = new System.Drawing.Size(626, 21);
            this.BZtextBox.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "备注";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 569);
            this.Controls.Add(this.BZtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DZtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SFZLtextBox);
            this.Controls.Add(this.SFZLlabel);
            this.Controls.Add(this.ZScomboBox);
            this.Controls.Add(this.ZSlabel);
            this.Controls.Add(this.SFYYcomboBox);
            this.Controls.Add(this.SFYYlabel);
            this.Controls.Add(this.MTFLcomboBox);
            this.Controls.Add(this.MTFLlabel);
            this.Controls.Add(this.MTcomboBox);
            this.Controls.Add(this.MTlabel);
            this.Controls.Add(this.DHtextBox);
            this.Controls.Add(this.DHlabel);
            this.Controls.Add(this.QXcomboBox);
            this.Controls.Add(this.QXlabel);
            this.Controls.Add(this.CScomboBox);
            this.Controls.Add(this.CSlabel);
            this.Controls.Add(this.SFcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CFZcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NLtextBox);
            this.Controls.Add(this.NLlabel);
            this.Controls.Add(this.XBcombox);
            this.Controls.Add(this.BZCombox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RQdateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.XMtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XMtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker RQdateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BZCombox;
        private System.Windows.Forms.ComboBox XBcombox;
        private System.Windows.Forms.Label NLlabel;
        private System.Windows.Forms.TextBox NLtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CFZcomboBox;
        private System.Windows.Forms.ComboBox SFcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CScomboBox;
        private System.Windows.Forms.Label CSlabel;
        private System.Windows.Forms.ComboBox QXcomboBox;
        private System.Windows.Forms.Label QXlabel;
        private System.Windows.Forms.TextBox DHtextBox;
        private System.Windows.Forms.Label DHlabel;
        private System.Windows.Forms.ComboBox MTcomboBox;
        private System.Windows.Forms.Label MTlabel;
        private System.Windows.Forms.ComboBox MTFLcomboBox;
        private System.Windows.Forms.Label MTFLlabel;
        private System.Windows.Forms.ComboBox SFYYcomboBox;
        private System.Windows.Forms.Label SFYYlabel;
        private System.Windows.Forms.ComboBox ZScomboBox;
        private System.Windows.Forms.Label ZSlabel;
        private System.Windows.Forms.TextBox SFZLtextBox;
        private System.Windows.Forms.Label SFZLlabel;
        private System.Windows.Forms.TextBox DZtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BZtextBox;
        private System.Windows.Forms.Label label9;
    }
}

