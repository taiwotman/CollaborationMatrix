/***
 Author: Taiwo O. Adetiloye, 2012
*****/

namespace ThesisProject
{
    partial class frmData
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
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxB11 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxB12 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxB13 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC21 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC22 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC23 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxC26 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC15 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC16 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC14 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC25 = new System.Windows.Forms.MaskedTextBox();
            this.txtBxC24 = new System.Windows.Forms.MaskedTextBox();
            this.errorPrompt = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrompt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(341, 233);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(46, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter data for the B2B, B2C, C2B, C2C. \r\nData must add up to 100 in each category" +
    ".\r\n";
            // 
            // txtBxB11
            // 
            this.txtBxB11.BackColor = System.Drawing.Color.Khaki;
            this.txtBxB11.Location = new System.Drawing.Point(75, 62);
            this.txtBxB11.Mask = "00";
            this.txtBxB11.Name = "txtBxB11";
            this.txtBxB11.Size = new System.Drawing.Size(37, 20);
            this.txtBxB11.TabIndex = 6;
            // 
            // txtBxB12
            // 
            this.txtBxB12.BackColor = System.Drawing.Color.Khaki;
            this.txtBxB12.Location = new System.Drawing.Point(118, 61);
            this.txtBxB12.Mask = "00";
            this.txtBxB12.Name = "txtBxB12";
            this.txtBxB12.Size = new System.Drawing.Size(37, 20);
            this.txtBxB12.TabIndex = 7;
            // 
            // txtBxB13
            // 
            this.txtBxB13.BackColor = System.Drawing.Color.Khaki;
            this.txtBxB13.Location = new System.Drawing.Point(161, 61);
            this.txtBxB13.Mask = "00";
            this.txtBxB13.Name = "txtBxB13";
            this.txtBxB13.Size = new System.Drawing.Size(37, 20);
            this.txtBxB13.TabIndex = 8;
            // 
            // txtBxC21
            // 
            this.txtBxC21.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC21.Location = new System.Drawing.Point(75, 88);
            this.txtBxC21.Mask = "00";
            this.txtBxC21.Name = "txtBxC21";
            this.txtBxC21.Size = new System.Drawing.Size(37, 20);
            this.txtBxC21.TabIndex = 9;
            // 
            // txtBxC22
            // 
            this.txtBxC22.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC22.Location = new System.Drawing.Point(118, 87);
            this.txtBxC22.Mask = "00";
            this.txtBxC22.Name = "txtBxC22";
            this.txtBxC22.Size = new System.Drawing.Size(37, 20);
            this.txtBxC22.TabIndex = 10;
            // 
            // txtBxC23
            // 
            this.txtBxC23.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC23.Location = new System.Drawing.Point(161, 88);
            this.txtBxC23.Mask = "00";
            this.txtBxC23.Name = "txtBxC23";
            this.txtBxC23.Size = new System.Drawing.Size(37, 20);
            this.txtBxC23.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBxC26);
            this.panel1.Controls.Add(this.txtBxC23);
            this.panel1.Controls.Add(this.txtBxC15);
            this.panel1.Controls.Add(this.txtBxB12);
            this.panel1.Controls.Add(this.txtBxC16);
            this.panel1.Controls.Add(this.txtBxC14);
            this.panel1.Controls.Add(this.txtBxB13);
            this.panel1.Controls.Add(this.txtBxC25);
            this.panel1.Controls.Add(this.txtBxB11);
            this.panel1.Controls.Add(this.txtBxC24);
            this.panel1.Controls.Add(this.txtBxC22);
            this.panel1.Controls.Add(this.txtBxC21);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 144);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(75, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 19);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "En";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "S";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "E";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(222, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 19);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "En";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "E";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Business";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Business";
            // 
            // txtBxC26
            // 
            this.txtBxC26.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC26.Location = new System.Drawing.Point(308, 87);
            this.txtBxC26.Mask = "00";
            this.txtBxC26.Name = "txtBxC26";
            this.txtBxC26.Size = new System.Drawing.Size(37, 20);
            this.txtBxC26.TabIndex = 17;
            // 
            // txtBxC15
            // 
            this.txtBxC15.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC15.Location = new System.Drawing.Point(265, 60);
            this.txtBxC15.Mask = "00";
            this.txtBxC15.Name = "txtBxC15";
            this.txtBxC15.Size = new System.Drawing.Size(37, 20);
            this.txtBxC15.TabIndex = 13;
            // 
            // txtBxC16
            // 
            this.txtBxC16.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC16.Location = new System.Drawing.Point(308, 60);
            this.txtBxC16.Mask = "00";
            this.txtBxC16.Name = "txtBxC16";
            this.txtBxC16.Size = new System.Drawing.Size(37, 20);
            this.txtBxC16.TabIndex = 14;
            // 
            // txtBxC14
            // 
            this.txtBxC14.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC14.Location = new System.Drawing.Point(222, 61);
            this.txtBxC14.Mask = "00";
            this.txtBxC14.Name = "txtBxC14";
            this.txtBxC14.Size = new System.Drawing.Size(37, 20);
            this.txtBxC14.TabIndex = 12;
            // 
            // txtBxC25
            // 
            this.txtBxC25.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC25.Location = new System.Drawing.Point(265, 86);
            this.txtBxC25.Mask = "00";
            this.txtBxC25.Name = "txtBxC25";
            this.txtBxC25.Size = new System.Drawing.Size(37, 20);
            this.txtBxC25.TabIndex = 16;
            // 
            // txtBxC24
            // 
            this.txtBxC24.BackColor = System.Drawing.Color.Khaki;
            this.txtBxC24.Location = new System.Drawing.Point(222, 87);
            this.txtBxC24.Mask = "00";
            this.txtBxC24.Name = "txtBxC24";
            this.txtBxC24.Size = new System.Drawing.Size(37, 20);
            this.txtBxC24.TabIndex = 15;
            // 
            // errorPrompt
            // 
            this.errorPrompt.ContainerControl = this;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(289, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrompt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBxB13;
        private System.Windows.Forms.MaskedTextBox txtBxB12;
        private System.Windows.Forms.MaskedTextBox txtBxB11;
        private System.Windows.Forms.MaskedTextBox txtBxC23;
        private System.Windows.Forms.MaskedTextBox txtBxC22;
        private System.Windows.Forms.MaskedTextBox txtBxC21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBxC26;
        private System.Windows.Forms.MaskedTextBox txtBxC15;
        private System.Windows.Forms.MaskedTextBox txtBxC16;
        private System.Windows.Forms.MaskedTextBox txtBxC14;
        private System.Windows.Forms.MaskedTextBox txtBxC25;
        private System.Windows.Forms.MaskedTextBox txtBxC24;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorPrompt;
        private System.Windows.Forms.Button btnClear;
    }
}