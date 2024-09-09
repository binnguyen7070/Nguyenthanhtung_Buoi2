namespace Nguyenthanhtung_Buoi2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtn = new TextBox();
            txt_kq = new TextBox();
            txt_sntN = new TextBox();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm số nguyên tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 104);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhập n :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 166);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Số vừa nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 218);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 0;
            label4.Text = "Số nguyên tố nhỏ hơn :";
            // 
            // txtn
            // 
            txtn.Location = new Point(244, 101);
            txtn.Name = "txtn";
            txtn.Size = new Size(100, 23);
            txtn.TabIndex = 1;
            txtn.TextChanged += txtn_TextChanged;
            // 
            // txt_kq
            // 
            txt_kq.Location = new Point(264, 163);
            txt_kq.Name = "txt_kq";
            txt_kq.Size = new Size(100, 23);
            txt_kq.TabIndex = 1;
            // 
            // txt_sntN
            // 
            txt_sntN.Location = new Point(314, 215);
            txt_sntN.Name = "txt_sntN";
            txt_sntN.Size = new Size(100, 23);
            txt_sntN.TabIndex = 1;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(405, 103);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát ";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(txt_sntN);
            Controls.Add(txt_kq);
            Controls.Add(txtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtn;
        private TextBox txt_kq;
        private TextBox txt_sntN;
        private Button btnthoat;
    }
}
