namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtpricefood1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpricefood2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamounttip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsalestxt = new System.Windows.Forms.Label();
            this.lbltipsamount = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lblnetamount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Food1 :";
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(345, 24);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(224, 22);
            this.txtfood1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate Amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 58);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 58);
            this.button3.TabIndex = 21;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtpricefood1
            // 
            this.txtpricefood1.Location = new System.Drawing.Point(345, 68);
            this.txtpricefood1.Name = "txtpricefood1";
            this.txtpricefood1.Size = new System.Drawing.Size(224, 22);
            this.txtpricefood1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter price Food1 :";
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(345, 116);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(224, 22);
            this.txtfood2.TabIndex = 25;
            this.txtfood2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Enter Food2 :";
            // 
            // txtpricefood2
            // 
            this.txtpricefood2.Location = new System.Drawing.Point(345, 159);
            this.txtpricefood2.Name = "txtpricefood2";
            this.txtpricefood2.Size = new System.Drawing.Size(224, 22);
            this.txtpricefood2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter price Food2 :";
            // 
            // txtamounttip
            // 
            this.txtamounttip.Location = new System.Drawing.Point(347, 211);
            this.txtamounttip.Name = "txtamounttip";
            this.txtamounttip.Size = new System.Drawing.Size(224, 22);
            this.txtamounttip.TabIndex = 29;
            this.txtamounttip.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Enter Amount tips :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "Enter net amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 32);
            this.label7.TabIndex = 34;
            this.label7.Text = "Enter Total Amopunt :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "Enter Tips Amount :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "Enter sales text :";
            // 
            // lblsalestxt
            // 
            this.lblsalestxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsalestxt.Location = new System.Drawing.Point(329, 315);
            this.lblsalestxt.Name = "lblsalestxt";
            this.lblsalestxt.Size = new System.Drawing.Size(215, 28);
            this.lblsalestxt.TabIndex = 37;
            this.lblsalestxt.Click += new System.EventHandler(this.lblsalestxt_Click);
            // 
            // lbltipsamount
            // 
            this.lbltipsamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltipsamount.Location = new System.Drawing.Point(329, 359);
            this.lbltipsamount.Name = "lbltipsamount";
            this.lbltipsamount.Size = new System.Drawing.Size(215, 28);
            this.lbltipsamount.TabIndex = 38;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotalamount.Location = new System.Drawing.Point(329, 407);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(215, 28);
            this.lbltotalamount.TabIndex = 39;
            // 
            // lblnetamount
            // 
            this.lblnetamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnetamount.Location = new System.Drawing.Point(329, 450);
            this.lblnetamount.Name = "lblnetamount";
            this.lblnetamount.Size = new System.Drawing.Size(215, 28);
            this.lblnetamount.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.lblnetamount);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbltipsamount);
            this.Controls.Add(this.lblsalestxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtamounttip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpricefood2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpricefood1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfood1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtpricefood1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpricefood2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtamounttip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsalestxt;
        private System.Windows.Forms.Label lbltipsamount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblnetamount;
    }
}

