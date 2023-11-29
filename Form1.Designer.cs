namespace Magic_8_Ball
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            InputText = new TextBox();
            Dialog = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(Dialog, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.86957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.130434F));
            tableLayoutPanel1.Size = new Size(444, 230);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.41525F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.58475F));
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Controls.Add(InputText, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 189);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(438, 38);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(363, 3);
            button1.Name = "button1";
            button1.Size = new Size(72, 32);
            button1.TabIndex = 0;
            button1.Text = "Shake";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ShakeTheBall;
            // 
            // InputText
            // 
            InputText.Dock = DockStyle.Fill;
            InputText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            InputText.Location = new Point(3, 3);
            InputText.Name = "InputText";
            InputText.Size = new Size(354, 32);
            InputText.TabIndex = 1;
            // 
            // Dialog
            // 
            Dialog.Dock = DockStyle.Fill;
            Dialog.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Dialog.Location = new Point(3, 3);
            Dialog.Name = "Dialog";
            Dialog.Size = new Size(438, 180);
            Dialog.TabIndex = 1;
            Dialog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 230);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Magic 8-Ball chat";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private TextBox InputText;
        private ListBox listBox1;
        private RichTextBox Dialog;
    }
}