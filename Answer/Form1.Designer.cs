namespace Answer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.numericUpDownBeforeTemp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAfterTemp = new System.Windows.Forms.NumericUpDown();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelBeforeTemp = new System.Windows.Forms.Label();
            this.labelAfterTemp = new System.Windows.Forms.Label();
            this.treeViewAnswer = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeforeTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAfterTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBeforeTemp
            // 
            this.numericUpDownBeforeTemp.Location = new System.Drawing.Point(12, 33);
            this.numericUpDownBeforeTemp.Name = "numericUpDownBeforeTemp";
            this.numericUpDownBeforeTemp.Size = new System.Drawing.Size(175, 19);
            this.numericUpDownBeforeTemp.TabIndex = 0;
            this.numericUpDownBeforeTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownAfterTemp
            // 
            this.numericUpDownAfterTemp.Location = new System.Drawing.Point(222, 33);
            this.numericUpDownAfterTemp.Name = "numericUpDownAfterTemp";
            this.numericUpDownAfterTemp.Size = new System.Drawing.Size(175, 19);
            this.numericUpDownAfterTemp.TabIndex = 0;
            this.numericUpDownAfterTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(12, 71);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "計算実行";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelBeforeTemp
            // 
            this.labelBeforeTemp.AutoSize = true;
            this.labelBeforeTemp.Location = new System.Drawing.Point(12, 18);
            this.labelBeforeTemp.Name = "labelBeforeTemp";
            this.labelBeforeTemp.Size = new System.Drawing.Size(87, 12);
            this.labelBeforeTemp.TabIndex = 3;
            this.labelBeforeTemp.Text = "現在の設定温度";
            // 
            // labelAfterTemp
            // 
            this.labelAfterTemp.AutoSize = true;
            this.labelAfterTemp.Location = new System.Drawing.Point(220, 18);
            this.labelAfterTemp.Name = "labelAfterTemp";
            this.labelAfterTemp.Size = new System.Drawing.Size(81, 12);
            this.labelAfterTemp.TabIndex = 3;
            this.labelAfterTemp.Text = "設定したい温度";
            // 
            // treeViewAnswer
            // 
            this.treeViewAnswer.Location = new System.Drawing.Point(12, 100);
            this.treeViewAnswer.Name = "treeViewAnswer";
            this.treeViewAnswer.Size = new System.Drawing.Size(385, 250);
            this.treeViewAnswer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 362);
            this.Controls.Add(this.treeViewAnswer);
            this.Controls.Add(this.labelAfterTemp);
            this.Controls.Add(this.labelBeforeTemp);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.numericUpDownAfterTemp);
            this.Controls.Add(this.numericUpDownBeforeTemp);
            this.Name = "Form1";
            this.Text = "Answer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeforeTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAfterTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownBeforeTemp;
        private System.Windows.Forms.NumericUpDown numericUpDownAfterTemp;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelBeforeTemp;
        private System.Windows.Forms.Label labelAfterTemp;
        private System.Windows.Forms.TreeView treeViewAnswer;
    }
}

