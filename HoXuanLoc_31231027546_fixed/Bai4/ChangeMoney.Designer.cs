﻿namespace Bai4
{
    partial class ChangeMoney
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVNDtoUSD = new System.Windows.Forms.Button();
            this.btnVNDtoEUR = new System.Windows.Forms.Button();
            this.btnUSDtoVND = new System.Windows.Forms.Button();
            this.btnEURtoVND = new System.Windows.Forms.Button();
            this.lblUSDRate = new System.Windows.Forms.Label();
            this.lblEURRate = new System.Windows.Forms.Label();
            this.txtUSDRate = new System.Windows.Forms.TextBox();
            this.txtEURRate = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(337, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền qui đổi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(301, 118);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(353, 22);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(301, 348);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.ReadOnly = true;
            this.lblKetQua.Size = new System.Drawing.Size(353, 22);
            this.lblKetQua.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnVNDtoUSD
            // 
            this.btnVNDtoUSD.Location = new System.Drawing.Point(175, 183);
            this.btnVNDtoUSD.Name = "btnVNDtoUSD";
            this.btnVNDtoUSD.Size = new System.Drawing.Size(109, 29);
            this.btnVNDtoUSD.TabIndex = 5;
            this.btnVNDtoUSD.Text = "VNDtoUSD";
            this.btnVNDtoUSD.UseVisualStyleBackColor = true;
            this.btnVNDtoUSD.Click += new System.EventHandler(this.btnVNDtoUSD_Click);
            // 
            // btnVNDtoEUR
            // 
            this.btnVNDtoEUR.Location = new System.Drawing.Point(322, 183);
            this.btnVNDtoEUR.Name = "btnVNDtoEUR";
            this.btnVNDtoEUR.Size = new System.Drawing.Size(109, 28);
            this.btnVNDtoEUR.TabIndex = 6;
            this.btnVNDtoEUR.Text = "VNDtoEUR";
            this.btnVNDtoEUR.UseVisualStyleBackColor = true;
            this.btnVNDtoEUR.Click += new System.EventHandler(this.btnVNDtoEUR_Click);
            // 
            // btnUSDtoVND
            // 
            this.btnUSDtoVND.Location = new System.Drawing.Point(468, 183);
            this.btnUSDtoVND.Name = "btnUSDtoVND";
            this.btnUSDtoVND.Size = new System.Drawing.Size(109, 29);
            this.btnUSDtoVND.TabIndex = 7;
            this.btnUSDtoVND.Text = "USDtoVND";
            this.btnUSDtoVND.UseVisualStyleBackColor = true;
            this.btnUSDtoVND.Click += new System.EventHandler(this.btnUSDtoVND_Click);
            // 
            // btnEURtoVND
            // 
            this.btnEURtoVND.Location = new System.Drawing.Point(607, 184);
            this.btnEURtoVND.Name = "btnEURtoVND";
            this.btnEURtoVND.Size = new System.Drawing.Size(109, 28);
            this.btnEURtoVND.TabIndex = 8;
            this.btnEURtoVND.Text = "EURtoVND";
            this.btnEURtoVND.UseVisualStyleBackColor = true;
            this.btnEURtoVND.Click += new System.EventHandler(this.btnEURtoVND_Click);
            // 
            // lblUSDRate
            // 
            this.lblUSDRate.AutoSize = true;
            this.lblUSDRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSDRate.Location = new System.Drawing.Point(137, 251);
            this.lblUSDRate.Name = "lblUSDRate";
            this.lblUSDRate.Size = new System.Drawing.Size(158, 20);
            this.lblUSDRate.TabIndex = 9;
            this.lblUSDRate.Text = "Tỷ giá USD (VND): ";
            // 
            // lblEURRate
            // 
            this.lblEURRate.AutoSize = true;
            this.lblEURRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEURRate.Location = new System.Drawing.Point(137, 295);
            this.lblEURRate.Name = "lblEURRate";
            this.lblEURRate.Size = new System.Drawing.Size(157, 20);
            this.lblEURRate.TabIndex = 10;
            this.lblEURRate.Text = "Tỷ giá EUR (VND): ";
            // 
            // txtUSDRate
            // 
            this.txtUSDRate.BackColor = System.Drawing.SystemColors.Info;
            this.txtUSDRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUSDRate.Location = new System.Drawing.Point(301, 249);
            this.txtUSDRate.Name = "txtUSDRate";
            this.txtUSDRate.Size = new System.Drawing.Size(353, 22);
            this.txtUSDRate.TabIndex = 11;
            this.txtUSDRate.Text = "17861";
            this.txtUSDRate.TextChanged += new System.EventHandler(this.txtUSDRate_TextChanged);
            // 
            // txtEURRate
            // 
            this.txtEURRate.BackColor = System.Drawing.SystemColors.Info;
            this.txtEURRate.Location = new System.Drawing.Point(301, 295);
            this.txtEURRate.Name = "txtEURRate";
            this.txtEURRate.Size = new System.Drawing.Size(353, 22);
            this.txtEURRate.TabIndex = 12;
            this.txtEURRate.Text = "27043";
            this.txtEURRate.TextChanged += new System.EventHandler(this.txtEURRate_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ChangeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEURRate);
            this.Controls.Add(this.txtUSDRate);
            this.Controls.Add(this.lblEURRate);
            this.Controls.Add(this.lblUSDRate);
            this.Controls.Add(this.btnEURtoVND);
            this.Controls.Add(this.btnUSDtoVND);
            this.Controls.Add(this.btnVNDtoEUR);
            this.Controls.Add(this.btnVNDtoUSD);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeMoney";
            this.Text = "Change Money";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeMoney_FormClosing);
            this.Load += new System.EventHandler(this.ChangeMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox lblKetQua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEURtoVND;
        private System.Windows.Forms.Button btnUSDtoVND;
        private System.Windows.Forms.Button btnVNDtoEUR;
        private System.Windows.Forms.Button btnVNDtoUSD;
        private System.Windows.Forms.Label lblEURRate;
        private System.Windows.Forms.Label lblUSDRate;
        private System.Windows.Forms.TextBox txtEURRate;
        private System.Windows.Forms.TextBox txtUSDRate;
        private System.Windows.Forms.Button btnClear;
    }
}

