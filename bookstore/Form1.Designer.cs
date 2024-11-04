namespace bookstore
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
            menuStrip1 = new MenuStrip();
            도서정보관리ToolStripMenuItem = new ToolStripMenuItem();
            도서등록ToolStripMenuItem = new ToolStripMenuItem();
            입고관리ToolStripMenuItem = new ToolStripMenuItem();
            출판사정보관리ToolStripMenuItem = new ToolStripMenuItem();
            출판사추가ToolStripMenuItem = new ToolStripMenuItem();
            출판사검색ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 도서정보관리ToolStripMenuItem, 출판사정보관리ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(723, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 도서정보관리ToolStripMenuItem
            // 
            도서정보관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 도서등록ToolStripMenuItem, 입고관리ToolStripMenuItem });
            도서정보관리ToolStripMenuItem.Name = "도서정보관리ToolStripMenuItem";
            도서정보관리ToolStripMenuItem.Size = new Size(95, 20);
            도서정보관리ToolStripMenuItem.Text = "도서정보 관리";
            // 
            // 도서등록ToolStripMenuItem
            // 
            도서등록ToolStripMenuItem.Name = "도서등록ToolStripMenuItem";
            도서등록ToolStripMenuItem.Size = new Size(180, 22);
            도서등록ToolStripMenuItem.Text = "도서 등록";
            도서등록ToolStripMenuItem.Click += 도서등록ToolStripMenuItem_Click;
            // 
            // 입고관리ToolStripMenuItem
            // 
            입고관리ToolStripMenuItem.Name = "입고관리ToolStripMenuItem";
            입고관리ToolStripMenuItem.Size = new Size(180, 22);
            입고관리ToolStripMenuItem.Text = "입고 관리";
            입고관리ToolStripMenuItem.Click += 입고관리ToolStripMenuItem_Click;
            // 
            // 출판사정보관리ToolStripMenuItem
            // 
            출판사정보관리ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 출판사추가ToolStripMenuItem, 출판사검색ToolStripMenuItem });
            출판사정보관리ToolStripMenuItem.Name = "출판사정보관리ToolStripMenuItem";
            출판사정보관리ToolStripMenuItem.Size = new Size(107, 20);
            출판사정보관리ToolStripMenuItem.Text = "출판사정보 관리";
            // 
            // 출판사추가ToolStripMenuItem
            // 
            출판사추가ToolStripMenuItem.Name = "출판사추가ToolStripMenuItem";
            출판사추가ToolStripMenuItem.Size = new Size(138, 22);
            출판사추가ToolStripMenuItem.Text = "출판사 추가";
            출판사추가ToolStripMenuItem.Click += 출판사추가ToolStripMenuItem_Click;
            // 
            // 출판사검색ToolStripMenuItem
            // 
            출판사검색ToolStripMenuItem.Name = "출판사검색ToolStripMenuItem";
            출판사검색ToolStripMenuItem.Size = new Size(138, 22);
            출판사검색ToolStripMenuItem.Text = "출판사 검색";
            출판사검색ToolStripMenuItem.Click += 출판사검색ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "도서번호 / 도서이름";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(608, 48);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "검색";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(30, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 209);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "도서번호";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "제목";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "저자";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "가격";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "평점";
            Column5.Name = "Column5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "신간목록";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 372);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 도서정보관리ToolStripMenuItem;
        private ToolStripMenuItem 출판사정보관리ToolStripMenuItem;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ToolStripMenuItem 도서등록ToolStripMenuItem;
        private ToolStripMenuItem 입고관리ToolStripMenuItem;
        private ToolStripMenuItem 출판사추가ToolStripMenuItem;
        private ToolStripMenuItem 출판사검색ToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
