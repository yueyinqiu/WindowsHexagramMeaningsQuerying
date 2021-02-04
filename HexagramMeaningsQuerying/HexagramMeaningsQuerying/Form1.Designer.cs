
namespace HexagramMeaningsQuerying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MeaningsBox = new System.Windows.Forms.TextBox();
            this.UpperBox = new System.Windows.Forms.TextBox();
            this.ByTwoTrigramsButton = new System.Windows.Forms.Button();
            this.LowerBox = new System.Windows.Forms.TextBox();
            this.ByNameButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ByPaintingButton = new System.Windows.Forms.Button();
            this.PaintingBox = new System.Windows.Forms.TextBox();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeaningsBox
            // 
            this.MeaningsBox.Location = new System.Drawing.Point(30, 185);
            this.MeaningsBox.Margin = new System.Windows.Forms.Padding(8);
            this.MeaningsBox.Multiline = true;
            this.MeaningsBox.Name = "MeaningsBox";
            this.MeaningsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MeaningsBox.Size = new System.Drawing.Size(1068, 338);
            this.MeaningsBox.TabIndex = 16;
            // 
            // UpperBox
            // 
            this.UpperBox.Location = new System.Drawing.Point(549, 32);
            this.UpperBox.Margin = new System.Windows.Forms.Padding(8);
            this.UpperBox.Name = "UpperBox";
            this.UpperBox.Size = new System.Drawing.Size(223, 44);
            this.UpperBox.TabIndex = 13;
            this.UpperBox.TabStop = false;
            // 
            // ByTwoTrigramsButton
            // 
            this.ByTwoTrigramsButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByTwoTrigramsButton.Location = new System.Drawing.Point(788, 32);
            this.ByTwoTrigramsButton.Margin = new System.Windows.Forms.Padding(8);
            this.ByTwoTrigramsButton.Name = "ByTwoTrigramsButton";
            this.ByTwoTrigramsButton.Size = new System.Drawing.Size(202, 124);
            this.ByTwoTrigramsButton.TabIndex = 15;
            this.ByTwoTrigramsButton.TabStop = false;
            this.ByTwoTrigramsButton.Text = "根据主客查询";
            this.ByTwoTrigramsButton.UseVisualStyleBackColor = true;
            this.ByTwoTrigramsButton.Click += new System.EventHandler(this.GetByTwoTrigrams);
            // 
            // LowerBox
            // 
            this.LowerBox.Location = new System.Drawing.Point(549, 112);
            this.LowerBox.Margin = new System.Windows.Forms.Padding(8);
            this.LowerBox.Name = "LowerBox";
            this.LowerBox.Size = new System.Drawing.Size(223, 44);
            this.LowerBox.TabIndex = 14;
            this.LowerBox.TabStop = false;
            // 
            // ByNameButton
            // 
            this.ByNameButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByNameButton.Location = new System.Drawing.Point(342, 112);
            this.ByNameButton.Margin = new System.Windows.Forms.Padding(8);
            this.ByNameButton.Name = "ByNameButton";
            this.ByNameButton.Size = new System.Drawing.Size(191, 44);
            this.ByNameButton.TabIndex = 12;
            this.ByNameButton.TabStop = false;
            this.ByNameButton.Text = "根据卦名查询";
            this.ByNameButton.UseVisualStyleBackColor = true;
            this.ByNameButton.Click += new System.EventHandler(this.GetByName);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(30, 112);
            this.NameBox.Margin = new System.Windows.Forms.Padding(8);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(292, 44);
            this.NameBox.TabIndex = 11;
            this.NameBox.TabStop = false;
            // 
            // ByPaintingButton
            // 
            this.ByPaintingButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByPaintingButton.Location = new System.Drawing.Point(342, 32);
            this.ByPaintingButton.Margin = new System.Windows.Forms.Padding(8);
            this.ByPaintingButton.Name = "ByPaintingButton";
            this.ByPaintingButton.Size = new System.Drawing.Size(191, 44);
            this.ByPaintingButton.TabIndex = 10;
            this.ByPaintingButton.TabStop = false;
            this.ByPaintingButton.Text = "根据卦画查询";
            this.ByPaintingButton.UseVisualStyleBackColor = true;
            this.ByPaintingButton.Click += new System.EventHandler(this.GetByPainting);
            // 
            // PaintingBox
            // 
            this.PaintingBox.Location = new System.Drawing.Point(30, 32);
            this.PaintingBox.Margin = new System.Windows.Forms.Padding(8);
            this.PaintingBox.Name = "PaintingBox";
            this.PaintingBox.Size = new System.Drawing.Size(292, 44);
            this.PaintingBox.TabIndex = 9;
            this.PaintingBox.TabStop = false;
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RandomButton.Location = new System.Drawing.Point(1006, 32);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(8);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(92, 124);
            this.RandomButton.TabIndex = 17;
            this.RandomButton.Text = "随机生成";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomHexagram);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 555);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.MeaningsBox);
            this.Controls.Add(this.UpperBox);
            this.Controls.Add(this.ByTwoTrigramsButton);
            this.Controls.Add(this.LowerBox);
            this.Controls.Add(this.ByNameButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ByPaintingButton);
            this.Controls.Add(this.PaintingBox);
            this.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hexagram Meanings Querying";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MeaningsBox;
        private System.Windows.Forms.TextBox UpperBox;
        private System.Windows.Forms.Button ByTwoTrigramsButton;
        private System.Windows.Forms.TextBox LowerBox;
        private System.Windows.Forms.Button ByNameButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button ByPaintingButton;
        private System.Windows.Forms.TextBox PaintingBox;
        private System.Windows.Forms.Button RandomButton;
    }
}

