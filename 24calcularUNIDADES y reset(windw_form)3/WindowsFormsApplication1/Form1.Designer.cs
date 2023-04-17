namespace WindowsFormsApplication1
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
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.unidad1 = new System.Windows.Forms.Label();
            this.unidad2 = new System.Windows.Forms.Label();
            this.unidad3 = new System.Windows.Forms.Label();
            this.unidad4 = new System.Windows.Forms.Label();
            this.unidad5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(85, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(42, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "nombre";
            this.nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(258, 72);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(43, 13);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "apellido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // unidad1
            // 
            this.unidad1.AutoSize = true;
            this.unidad1.Location = new System.Drawing.Point(82, 253);
            this.unidad1.Name = "unidad1";
            this.unidad1.Size = new System.Drawing.Size(45, 13);
            this.unidad1.TabIndex = 4;
            this.unidad1.Text = "unidad1";
            // 
            // unidad2
            // 
            this.unidad2.AutoSize = true;
            this.unidad2.Location = new System.Drawing.Point(256, 253);
            this.unidad2.Name = "unidad2";
            this.unidad2.Size = new System.Drawing.Size(45, 13);
            this.unidad2.TabIndex = 5;
            this.unidad2.Text = "unidad2";
            // 
            // unidad3
            // 
            this.unidad3.AutoSize = true;
            this.unidad3.Location = new System.Drawing.Point(413, 253);
            this.unidad3.Name = "unidad3";
            this.unidad3.Size = new System.Drawing.Size(45, 13);
            this.unidad3.TabIndex = 6;
            this.unidad3.Text = "unidad3";
            // 
            // unidad4
            // 
            this.unidad4.AutoSize = true;
            this.unidad4.Location = new System.Drawing.Point(585, 253);
            this.unidad4.Name = "unidad4";
            this.unidad4.Size = new System.Drawing.Size(45, 13);
            this.unidad4.TabIndex = 7;
            this.unidad4.Text = "unidad4";
            // 
            // unidad5
            // 
            this.unidad5.AutoSize = true;
            this.unidad5.Location = new System.Drawing.Point(763, 253);
            this.unidad5.Name = "unidad5";
            this.unidad5.Size = new System.Drawing.Size(45, 13);
            this.unidad5.TabIndex = 8;
            this.unidad5.Text = "unidad5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(259, 285);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(416, 284);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(588, 284);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(766, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(908, 268);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(313, 127);
            this.textBox8.TabIndex = 15;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(921, 252);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(50, 13);
            this.resultado.TabIndex = 16;
            this.resultado.Text = "resultado";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(1255, 281);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 17;
            this.result.Text = "resultado";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(1255, 348);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 18;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 708);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.unidad5);
            this.Controls.Add(this.unidad4);
            this.Controls.Add(this.unidad3);
            this.Controls.Add(this.unidad2);
            this.Controls.Add(this.unidad1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label unidad1;
        private System.Windows.Forms.Label unidad2;
        private System.Windows.Forms.Label unidad3;
        private System.Windows.Forms.Label unidad4;
        private System.Windows.Forms.Label unidad5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button reset;
    }
}

