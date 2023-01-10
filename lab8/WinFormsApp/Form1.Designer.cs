namespace WinFormsApp
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
            this.showAllBtn = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.quartBtn = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.TextBox();
            this.coordsLabel = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(151, 262);
            this.showAllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(162, 54);
            this.showAllBtn.TabIndex = 0;
            this.showAllBtn.Text = "Показать все многоугольники";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(151, 348);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(708, 301);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(410, 262);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(163, 54);
            this.sortBtn.TabIndex = 3;
            this.sortBtn.Text = "Отсортировать по площади";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // quartBtn
            // 
            this.quartBtn.Location = new System.Drawing.Point(625, 262);
            this.quartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quartBtn.Name = "quartBtn";
            this.quartBtn.Size = new System.Drawing.Size(234, 54);
            this.quartBtn.TabIndex = 4;
            this.quartBtn.Text = "Показать фигуры, расположенные в 1 плоскости";
            this.quartBtn.UseVisualStyleBackColor = true;
            this.quartBtn.Click += new System.EventHandler(this.quartBtn_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(151, 110);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(121, 27);
            this.colorLabel.TabIndex = 5;
            // 
            // coordsLabel
            // 
            this.coordsLabel.Location = new System.Drawing.Point(401, 110);
            this.coordsLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(187, 27);
            this.coordsLabel.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(714, 110);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(144, 25);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить фигуру";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Цвет фигуры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Координаты точек\r\n(вводить через пробел)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 706);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.quartBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.showAllBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Polygons App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showAllBtn;
        private RichTextBox richTextBox;
        private Button sortBtn;
        private Button quartBtn;
        private TextBox colorLabel;
        private TextBox coordsLabel;
        private Button addBtn;
        private Label label1;
        private Label label2;
    }
}