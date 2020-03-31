namespace PokedexC_sharp
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.izq = new System.Windows.Forms.Button();
            this.der = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 212);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // izq
            // 
            this.izq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izq.Location = new System.Drawing.Point(73, 265);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(53, 44);
            this.izq.TabIndex = 1;
            this.izq.Text = "<";
            this.izq.UseVisualStyleBackColor = true;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.der.Location = new System.Drawing.Point(152, 265);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(53, 44);
            this.der.TabIndex = 2;
            this.der.Text = ">";
            this.der.UseVisualStyleBackColor = true;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(325, 34);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(154, 39);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Click += new System.EventHandler(this.nombrePokemon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Selecciona Pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button button1;
    }
}

