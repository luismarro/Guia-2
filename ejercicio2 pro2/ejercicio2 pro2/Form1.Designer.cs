namespace ejercicio2_pro2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lim = new System.Windows.Forms.Button();
            this.sal = new System.Windows.Forms.Button();
            this.txtcan = new System.Windows.Forms.TextBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txttot = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.des20 = new System.Windows.Forms.RadioButton();
            this.des15 = new System.Windows.Forms.RadioButton();
            this.des10 = new System.Windows.Forms.RadioButton();
            this.des5 = new System.Windows.Forms.RadioButton();
            this.des0 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio: ";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(128, 130);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 35);
            this.cal.TabIndex = 2;
            this.cal.Text = "Calcular";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // lim
            // 
            this.lim.Location = new System.Drawing.Point(51, 268);
            this.lim.Name = "lim";
            this.lim.Size = new System.Drawing.Size(103, 42);
            this.lim.TabIndex = 5;
            this.lim.Text = "Limpiar";
            this.lim.UseVisualStyleBackColor = true;
            this.lim.Click += new System.EventHandler(this.lim_Click);
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(184, 268);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(100, 42);
            this.sal.TabIndex = 6;
            this.sal.Text = "Salir";
            this.sal.UseVisualStyleBackColor = true;
            this.sal.Click += new System.EventHandler(this.sal_Click);
            // 
            // txtcan
            // 
            this.txtcan.Location = new System.Drawing.Point(107, 50);
            this.txtcan.Name = "txtcan";
            this.txtcan.Size = new System.Drawing.Size(132, 20);
            this.txtcan.TabIndex = 7;
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(107, 86);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(132, 20);
            this.txtpre.TabIndex = 8;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(116, 185);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(123, 20);
            this.txtdes.TabIndex = 9;
            // 
            // txttot
            // 
            this.txttot.Location = new System.Drawing.Point(89, 224);
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(123, 20);
            this.txttot.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.des20);
            this.groupBox1.Controls.Add(this.des15);
            this.groupBox1.Controls.Add(this.des10);
            this.groupBox1.Controls.Add(this.des5);
            this.groupBox1.Controls.Add(this.des0);
            this.groupBox1.Location = new System.Drawing.Point(321, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 187);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuentos";
            // 
            // des20
            // 
            this.des20.AutoSize = true;
            this.des20.Location = new System.Drawing.Point(7, 132);
            this.des20.Name = "des20";
            this.des20.Size = new System.Drawing.Size(45, 17);
            this.des20.TabIndex = 4;
            this.des20.TabStop = true;
            this.des20.Text = "20%";
            this.des20.UseVisualStyleBackColor = true;
            // 
            // des15
            // 
            this.des15.AutoSize = true;
            this.des15.Location = new System.Drawing.Point(7, 108);
            this.des15.Name = "des15";
            this.des15.Size = new System.Drawing.Size(45, 17);
            this.des15.TabIndex = 3;
            this.des15.TabStop = true;
            this.des15.Text = "15%";
            this.des15.UseVisualStyleBackColor = true;
            // 
            // des10
            // 
            this.des10.AutoSize = true;
            this.des10.Location = new System.Drawing.Point(7, 84);
            this.des10.Name = "des10";
            this.des10.Size = new System.Drawing.Size(45, 17);
            this.des10.TabIndex = 2;
            this.des10.TabStop = true;
            this.des10.Text = "10%";
            this.des10.UseVisualStyleBackColor = true;
            // 
            // des5
            // 
            this.des5.AutoSize = true;
            this.des5.Location = new System.Drawing.Point(7, 60);
            this.des5.Name = "des5";
            this.des5.Size = new System.Drawing.Size(39, 17);
            this.des5.TabIndex = 1;
            this.des5.TabStop = true;
            this.des5.Text = "5%";
            this.des5.UseVisualStyleBackColor = true;
            // 
            // des0
            // 
            this.des0.AutoSize = true;
            this.des0.Location = new System.Drawing.Point(7, 36);
            this.des0.Name = "des0";
            this.des0.Size = new System.Drawing.Size(39, 17);
            this.des0.TabIndex = 0;
            this.des0.TabStop = true;
            this.des0.Text = "0%";
            this.des0.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(172, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.txtcan);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.lim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lim;
        private System.Windows.Forms.Button sal;
        private System.Windows.Forms.TextBox txtcan;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton des20;
        private System.Windows.Forms.RadioButton des15;
        private System.Windows.Forms.RadioButton des10;
        private System.Windows.Forms.RadioButton des5;
        private System.Windows.Forms.RadioButton des0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

