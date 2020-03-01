namespace ejercicio_1_pro2
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.cal1 = new System.Windows.Forms.Button();
            this.lim = new System.Windows.Forms.Button();
            this.sal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero del 1 al 10";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(276, 82);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(139, 20);
            this.num1.TabIndex = 1;
            // 
            // cal1
            // 
            this.cal1.Location = new System.Drawing.Point(25, 203);
            this.cal1.Name = "cal1";
            this.cal1.Size = new System.Drawing.Size(120, 34);
            this.cal1.TabIndex = 2;
            this.cal1.Text = "Calcular ";
            this.cal1.UseVisualStyleBackColor = true;
            this.cal1.Click += new System.EventHandler(this.cal1_Click);
            // 
            // lim
            // 
            this.lim.Location = new System.Drawing.Point(195, 203);
            this.lim.Name = "lim";
            this.lim.Size = new System.Drawing.Size(114, 34);
            this.lim.TabIndex = 3;
            this.lim.Text = "Limpiar";
            this.lim.UseVisualStyleBackColor = true;
            this.lim.Click += new System.EventHandler(this.lim_Click);
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(368, 203);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(115, 34);
            this.sal.TabIndex = 4;
            this.sal.Text = "Salir";
            this.sal.UseVisualStyleBackColor = true;
            this.sal.Click += new System.EventHandler(this.sal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "El numero en romano es:";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(227, 134);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(240, 20);
            this.num2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programa para ingresar un numero entero a romano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.lim);
            this.Controls.Add(this.cal1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button cal1;
        private System.Windows.Forms.Button lim;
        private System.Windows.Forms.Button sal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label3;
    }
}

