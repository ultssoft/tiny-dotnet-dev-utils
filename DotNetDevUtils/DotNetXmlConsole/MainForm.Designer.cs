namespace DotNetXmlConsole
{
    partial class MainForm
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
            this.splitContainerEx1 = new Ults.Windows.Forms.SplitContainerEx();
            this.comboBoxXPath = new System.Windows.Forms.ComboBox();
            this.buttonOpenRead = new System.Windows.Forms.Button();
            this.buttonDoSelect = new System.Windows.Forms.Button();
            this.textBoxExInput = new Ults.Windows.Forms.TextBoxEx();
            this.textBoxExOutput = new Ults.Windows.Forms.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx1.Name = "splitContainerEx1";
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.comboBoxXPath);
            this.splitContainerEx1.Panel1.Controls.Add(this.buttonOpenRead);
            this.splitContainerEx1.Panel1.Controls.Add(this.buttonDoSelect);
            this.splitContainerEx1.Panel1.Controls.Add(this.textBoxExInput);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.textBoxExOutput);
            this.splitContainerEx1.Size = new System.Drawing.Size(946, 649);
            this.splitContainerEx1.SplitterDistance = 500;
            this.splitContainerEx1.TabIndex = 0;
            // 
            // comboBoxXPath
            // 
            this.comboBoxXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxXPath.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxXPath.FormattingEnabled = true;
            this.comboBoxXPath.Location = new System.Drawing.Point(3, 3);
            this.comboBoxXPath.Name = "comboBoxXPath";
            this.comboBoxXPath.Size = new System.Drawing.Size(494, 26);
            this.comboBoxXPath.TabIndex = 1;
            // 
            // buttonOpenRead
            // 
            this.buttonOpenRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenRead.Location = new System.Drawing.Point(396, 75);
            this.buttonOpenRead.Name = "buttonOpenRead";
            this.buttonOpenRead.Size = new System.Drawing.Size(101, 35);
            this.buttonOpenRead.TabIndex = 3;
            this.buttonOpenRead.Text = "Read";
            this.buttonOpenRead.UseVisualStyleBackColor = true;
            this.buttonOpenRead.Click += new System.EventHandler(this.buttonOpenRead_Click);
            // 
            // buttonDoSelect
            // 
            this.buttonDoSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoSelect.Location = new System.Drawing.Point(364, 34);
            this.buttonDoSelect.Name = "buttonDoSelect";
            this.buttonDoSelect.Size = new System.Drawing.Size(133, 35);
            this.buttonDoSelect.TabIndex = 2;
            this.buttonDoSelect.Text = "SelectNodes";
            this.buttonDoSelect.UseVisualStyleBackColor = true;
            this.buttonDoSelect.Click += new System.EventHandler(this.buttonDoFilter_Click);
            // 
            // textBoxExInput
            // 
            this.textBoxExInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExInput.Location = new System.Drawing.Point(3, 116);
            this.textBoxExInput.MaxLength = 0;
            this.textBoxExInput.Multiline = true;
            this.textBoxExInput.Name = "textBoxExInput";
            this.textBoxExInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExInput.Size = new System.Drawing.Size(494, 533);
            this.textBoxExInput.TabIndex = 4;
            // 
            // textBoxExOutput
            // 
            this.textBoxExOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExOutput.Location = new System.Drawing.Point(3, 3);
            this.textBoxExOutput.MaxLength = 0;
            this.textBoxExOutput.Multiline = true;
            this.textBoxExOutput.Name = "textBoxExOutput";
            this.textBoxExOutput.ReadOnly = true;
            this.textBoxExOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExOutput.Size = new System.Drawing.Size(436, 643);
            this.textBoxExOutput.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 649);
            this.Controls.Add(this.splitContainerEx1);
            this.Name = "MainForm";
            this.Text = "DotNet XPath test console";
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            this.splitContainerEx1.Panel1.PerformLayout();
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            this.splitContainerEx1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ults.Windows.Forms.SplitContainerEx splitContainerEx1;
        private Ults.Windows.Forms.TextBoxEx textBoxExOutput;
        private Ults.Windows.Forms.TextBoxEx textBoxExInput;
        private System.Windows.Forms.Button buttonDoSelect;
        private System.Windows.Forms.Button buttonOpenRead;
        private System.Windows.Forms.ComboBox comboBoxXPath;
    }
}

