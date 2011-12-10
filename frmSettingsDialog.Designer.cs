namespace SOTVVideoUploader
{
    partial class frmSettingsDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.udThumbsNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.udLThumbW = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.udLThumbH = new System.Windows.Forms.NumericUpDown();
            this.udSThumbH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udSThumbW = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.udThumbsStartTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udThumbsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLThumbW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLThumbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSThumbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSThumbW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udThumbsStartTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(196, 133);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(277, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество скриншотов";
            // 
            // udThumbsNum
            // 
            this.udThumbsNum.Location = new System.Drawing.Point(148, 7);
            this.udThumbsNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.udThumbsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udThumbsNum.Name = "udThumbsNum";
            this.udThumbsNum.Size = new System.Drawing.Size(62, 20);
            this.udThumbsNum.TabIndex = 3;
            this.udThumbsNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udThumbsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Разрешение большого скриншота";
            // 
            // udLThumbW
            // 
            this.udLThumbW.Location = new System.Drawing.Point(216, 34);
            this.udLThumbW.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.udLThumbW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLThumbW.Name = "udLThumbW";
            this.udLThumbW.Size = new System.Drawing.Size(57, 20);
            this.udLThumbW.TabIndex = 5;
            this.udLThumbW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udLThumbW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // udLThumbH
            // 
            this.udLThumbH.Location = new System.Drawing.Point(295, 34);
            this.udLThumbH.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.udLThumbH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLThumbH.Name = "udLThumbH";
            this.udLThumbH.Size = new System.Drawing.Size(57, 20);
            this.udLThumbH.TabIndex = 7;
            this.udLThumbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udLThumbH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udSThumbH
            // 
            this.udSThumbH.Location = new System.Drawing.Point(295, 59);
            this.udSThumbH.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.udSThumbH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSThumbH.Name = "udSThumbH";
            this.udSThumbH.Size = new System.Drawing.Size(57, 20);
            this.udSThumbH.TabIndex = 11;
            this.udSThumbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udSThumbH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "x";
            // 
            // udSThumbW
            // 
            this.udSThumbW.Location = new System.Drawing.Point(216, 59);
            this.udSThumbW.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.udSThumbW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSThumbW.Name = "udSThumbW";
            this.udSThumbW.Size = new System.Drawing.Size(57, 20);
            this.udSThumbW.TabIndex = 9;
            this.udSThumbW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udSThumbW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Разрешение маленького скриншота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Начальное время захвата скриншотов, сек";
            // 
            // udThumbsStartTime
            // 
            this.udThumbsStartTime.Location = new System.Drawing.Point(295, 84);
            this.udThumbsStartTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.udThumbsStartTime.Name = "udThumbsStartTime";
            this.udThumbsStartTime.Size = new System.Drawing.Size(56, 20);
            this.udThumbsStartTime.TabIndex = 13;
            this.udThumbsStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udThumbsStartTime.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // frmSettingsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(364, 168);
            this.Controls.Add(this.udThumbsStartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.udSThumbH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.udSThumbW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.udLThumbH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.udLThumbW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udThumbsNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.udThumbsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLThumbW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLThumbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSThumbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSThumbW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udThumbsStartTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udThumbsNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udLThumbW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udLThumbH;
        private System.Windows.Forms.NumericUpDown udSThumbH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udSThumbW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udThumbsStartTime;
    }
}