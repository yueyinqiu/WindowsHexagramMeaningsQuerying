namespace 卦辞爻辞查询
{ 
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PaintingBox = new System.Windows.Forms.TextBox();
            this.ByPaintingButton = new System.Windows.Forms.Button();
            this.ByNameButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ByTwoTrigramsButton = new System.Windows.Forms.Button();
            this.LowerBox = new System.Windows.Forms.TextBox();
            this.UpperBox = new System.Windows.Forms.TextBox();
            this.MeaningsBox = new System.Windows.Forms.TextBox();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaintingBox
            // 
            this.PaintingBox.Location = new System.Drawing.Point(32, 33);
            this.PaintingBox.Margin = new System.Windows.Forms.Padding(8);
            this.PaintingBox.Name = "PaintingBox";
            this.PaintingBox.Size = new System.Drawing.Size(292, 44);
            this.PaintingBox.TabIndex = 1;
            // 
            // ByPaintingButton
            // 
            this.ByPaintingButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByPaintingButton.Location = new System.Drawing.Point(344, 33);
            this.ByPaintingButton.Margin = new System.Windows.Forms.Padding(8);
            this.ByPaintingButton.Name = "ByPaintingButton";
            this.ByPaintingButton.Size = new System.Drawing.Size(191, 44);
            this.ByPaintingButton.TabIndex = 2;
            this.ByPaintingButton.Text = "根据卦画查询";
            this.ByPaintingButton.UseVisualStyleBackColor = true;
            this.ByPaintingButton.Click += new System.EventHandler(this.GetByPainting);
            // 
            // ByNameButton
            // 
            this.ByNameButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByNameButton.Location = new System.Drawing.Point(344, 113);
            this.ByNameButton.Margin = new System.Windows.Forms.Padding(8);
            this.ByNameButton.Name = "ByNameButton";
            this.ByNameButton.Size = new System.Drawing.Size(191, 44);
            this.ByNameButton.TabIndex = 4;
            this.ByNameButton.Text = "根据卦名查询";
            this.ByNameButton.UseVisualStyleBackColor = true;
            this.ByNameButton.Click += new System.EventHandler(this.GetByName);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(32, 113);
            this.NameBox.Margin = new System.Windows.Forms.Padding(8);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(292, 44);
            this.NameBox.TabIndex = 3;
            // 
            // ByTwoTrigramsButton
            // 
            this.ByTwoTrigramsButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ByTwoTrigramsButton.Location = new System.Drawing.Point(790, 33);
            this.ByTwoTrigramsButton.Margin = new System.Windows.Forms.Padding(8);
            this.ByTwoTrigramsButton.Name = "ByTwoTrigramsButton";
            this.ByTwoTrigramsButton.Size = new System.Drawing.Size(202, 124);
            this.ByTwoTrigramsButton.TabIndex = 7;
            this.ByTwoTrigramsButton.Text = "根据主客查询";
            this.ByTwoTrigramsButton.UseVisualStyleBackColor = true;
            this.ByTwoTrigramsButton.Click += new System.EventHandler(this.GetByTwoTrigrams);
            // 
            // LowerBox
            // 
            this.LowerBox.Location = new System.Drawing.Point(551, 113);
            this.LowerBox.Margin = new System.Windows.Forms.Padding(8);
            this.LowerBox.Name = "LowerBox";
            this.LowerBox.Size = new System.Drawing.Size(223, 44);
            this.LowerBox.TabIndex = 6;
            // 
            // UpperBox
            // 
            this.UpperBox.Location = new System.Drawing.Point(551, 33);
            this.UpperBox.Margin = new System.Windows.Forms.Padding(8);
            this.UpperBox.Name = "UpperBox";
            this.UpperBox.Size = new System.Drawing.Size(223, 44);
            this.UpperBox.TabIndex = 5;
            // 
            // MeaningsBox
            // 
            this.MeaningsBox.Location = new System.Drawing.Point(32, 186);
            this.MeaningsBox.Margin = new System.Windows.Forms.Padding(8);
            this.MeaningsBox.Multiline = true;
            this.MeaningsBox.Name = "MeaningsBox";
            this.MeaningsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MeaningsBox.Size = new System.Drawing.Size(1068, 338);
            this.MeaningsBox.TabIndex = 8;
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RandomButton.Location = new System.Drawing.Point(1008, 33);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(8);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(92, 124);
            this.RandomButton.TabIndex = 0;
            this.RandomButton.Text = "随机生成";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomHexagram);
            // 
            // MainForm
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
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "卦辞爻辞查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaintingBox;
        private System.Windows.Forms.Button ByPaintingButton;
        private System.Windows.Forms.Button ByNameButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button ByTwoTrigramsButton;
        private System.Windows.Forms.TextBox LowerBox;
        private System.Windows.Forms.TextBox UpperBox;
        private System.Windows.Forms.TextBox MeaningsBox;
        private System.Windows.Forms.Button RandomButton;
    }
}

