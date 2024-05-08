namespace PIM_III
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private PictureBox pictureBox6;
        private Panel panel2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox7;

     

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            this.panel1 = new Panel();
            this.pictureBox3 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.label1 = new Label();
            this.pictureBox4 = new PictureBox();
            this.pictureBox5 = new PictureBox();
            this.textBox1 = new TextBox();
            this.pictureBox6 = new PictureBox();
            this.dataGridView1 = new DataGridView();
            this.panel2 = new Panel();
            this.pictureBox7 = new PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = Color.FromArgb(52, 78, 65);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1481, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = Properties.Resources.LOGO;
            this.pictureBox3.Location = new Point(83, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(286, 50);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = Properties.Resources.logo_image;
            this.pictureBox2.Location = new Point(3, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(77, 50);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            this.pictureBox1.Cursor = Cursors.Hand;
            this.pictureBox1.Image = Properties.Resources.icon_verde;
            this.pictureBox1.Location = new Point(1270, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(58, 49);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.label1.ForeColor = Color.Snow;
            this.label1.Location = new Point(1187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olá,Fulano";
            this.label1.Click += new EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = Cursors.Hand;
            this.pictureBox4.Image = Properties.Resources.adicionar;
            this.pictureBox4.Location = new Point(32, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(127, 45);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = Cursors.Hand;
            this.pictureBox5.Image = Properties.Resources.editar;
            this.pictureBox5.Location = new Point(165, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(93, 45);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = AnchorStyles.Right;
            this.textBox1.BackColor = SystemColors.ButtonHighlight;
            this.textBox1.ForeColor = SystemColors.InfoText;
            this.textBox1.Location = new Point(766, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Buscar....";
            this.textBox1.Size = new Size(379, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = AnchorStyles.Right;
            this.pictureBox6.BackColor = Color.Transparent;
            this.pictureBox6.Cursor = Cursors.Hand;
            this.pictureBox6.Image = Properties.Resources.lupa;
            this.pictureBox6.Location = new Point(1128, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(17, 23);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new EventHandler(this.pictureBox6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = Color.FromArgb(163, 177, 138);
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(88, 129, 87);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(88, 129, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = Color.FromArgb(163, 177, 138);
            this.dataGridView1.Location = new Point(16, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(218, 215, 205);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(218, 215, 205);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new Size(1285, 568);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.panel2.BackColor = Color.FromArgb(163, 177, 138);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new Point(27, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1291, 622);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = Cursors.Hand;
            this.pictureBox7.Image = Properties.Resources.delete;
            this.pictureBox7.Location = new Point(275, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(101, 47);
            this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new EventHandler(this.pictureBox7_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImageLayout = ImageLayout.None;
            this.ClientSize = new Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
