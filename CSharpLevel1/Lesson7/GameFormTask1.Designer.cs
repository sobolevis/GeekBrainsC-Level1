namespace Lesson7
{
    partial class GameFormTask1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFormTask1));
            this.buttonEnc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelHiddenValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCurrentValue = new System.Windows.Forms.Label();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnc
            // 
            this.buttonEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnc.Location = new System.Drawing.Point(133, 12);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(70, 32);
            this.buttonEnc.TabIndex = 0;
            this.buttonEnc.Text = "+1";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Я загадал";
            // 
            // LabelHiddenValue
            // 
            this.LabelHiddenValue.AutoEllipsis = true;
            this.LabelHiddenValue.AutoSize = true;
            this.LabelHiddenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHiddenValue.Location = new System.Drawing.Point(3, 22);
            this.LabelHiddenValue.Name = "LabelHiddenValue";
            this.LabelHiddenValue.Size = new System.Drawing.Size(86, 26);
            this.LabelHiddenValue.TabIndex = 2;
            this.LabelHiddenValue.Text = "random";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelCurrentValue);
            this.panel1.Controls.Add(this.LabelHiddenValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 146);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Твое число";
            // 
            // LabelCurrentValue
            // 
            this.LabelCurrentValue.AutoEllipsis = true;
            this.LabelCurrentValue.AutoSize = true;
            this.LabelCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentValue.Location = new System.Drawing.Point(12, 78);
            this.LabelCurrentValue.Name = "LabelCurrentValue";
            this.LabelCurrentValue.Size = new System.Drawing.Size(24, 26);
            this.LabelCurrentValue.TabIndex = 2;
            this.LabelCurrentValue.Text = "0";
            // 
            // buttonMul
            // 
            this.buttonMul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMul.Location = new System.Drawing.Point(133, 50);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(70, 32);
            this.buttonMul.TabIndex = 0;
            this.buttonMul.Text = "х2";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(133, 126);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 32);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(133, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // GameFormTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 170);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonEnc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameFormTask1";
            this.Text = "Удвоитель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyFormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelHiddenValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelCurrentValue;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button1;
    }
}