namespace buscaPalabra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.letra1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letra2 = new System.Windows.Forms.TextBox();
            this.letra3 = new System.Windows.Forms.TextBox();
            this.letra4 = new System.Windows.Forms.TextBox();
            this.letra5 = new System.Windows.Forms.TextBox();
            this.letra6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // letra1
            // 
            this.letra1.Location = new System.Drawing.Point(255, 59);
            this.letra1.Name = "letra1";
            this.letra1.Size = new System.Drawing.Size(30, 26);
            this.letra1.TabIndex = 0;
            this.letra1.Text = "a";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // letra2
            // 
            this.letra2.Location = new System.Drawing.Point(291, 59);
            this.letra2.Name = "letra2";
            this.letra2.Size = new System.Drawing.Size(30, 26);
            this.letra2.TabIndex = 4;
            this.letra2.Text = "b";
            // 
            // letra3
            // 
            this.letra3.Location = new System.Drawing.Point(327, 59);
            this.letra3.Name = "letra3";
            this.letra3.Size = new System.Drawing.Size(30, 26);
            this.letra3.TabIndex = 5;
            this.letra3.Text = "c";
            // 
            // letra4
            // 
            this.letra4.Location = new System.Drawing.Point(363, 59);
            this.letra4.Name = "letra4";
            this.letra4.Size = new System.Drawing.Size(30, 26);
            this.letra4.TabIndex = 7;
            this.letra4.Text = "d";
            // 
            // letra5
            // 
            this.letra5.Location = new System.Drawing.Point(399, 59);
            this.letra5.Name = "letra5";
            this.letra5.Size = new System.Drawing.Size(30, 26);
            this.letra5.TabIndex = 8;
            this.letra5.Text = "e";
            // 
            // letra6
            // 
            this.letra6.Location = new System.Drawing.Point(435, 59);
            this.letra6.Name = "letra6";
            this.letra6.Size = new System.Drawing.Size(30, 26);
            this.letra6.TabIndex = 9;
            this.letra6.Text = "f";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.letra6);
            this.Controls.Add(this.letra5);
            this.Controls.Add(this.letra4);
            this.Controls.Add(this.letra3);
            this.Controls.Add(this.letra2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letra1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letra1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox letra2;
        private System.Windows.Forms.TextBox letra3;
        private System.Windows.Forms.TextBox letra4;
        private System.Windows.Forms.TextBox letra5;
        private System.Windows.Forms.TextBox letra6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

