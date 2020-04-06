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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tipoPokemon1 = new System.Windows.Forms.Label();
            this.ataquePokemon1 = new System.Windows.Forms.Label();
            this.especiePokemon = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.ataquePokemon2 = new System.Windows.Forms.Label();
            this.AtaquePokemon3 = new System.Windows.Forms.Label();
            this.AtaquePokemon4 = new System.Windows.Forms.Label();
            this.idPokemon = new System.Windows.Forms.Label();
            this.tipoPokemon2 = new System.Windows.Forms.Label();
            this.areaPokemon = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // izq
            // 
            this.izq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izq.Location = new System.Drawing.Point(212, 315);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(53, 34);
            this.izq.TabIndex = 1;
            this.izq.Text = "<";
            this.izq.UseVisualStyleBackColor = true;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.der.Location = new System.Drawing.Point(285, 315);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(53, 34);
            this.der.TabIndex = 2;
            this.der.Text = ">";
            this.der.UseVisualStyleBackColor = true;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ControlText;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombrePokemon.Location = new System.Drawing.Point(96, 327);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(110, 33);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Click += new System.EventHandler(this.nombrePokemon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Selecciona Pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokedexC_sharp.Properties.Resources.Pokedex2;
            this.pictureBox2.Location = new System.Drawing.Point(28, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(656, 336);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tipoPokemon1
            // 
            this.tipoPokemon1.BackColor = System.Drawing.SystemColors.ControlText;
            this.tipoPokemon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tipoPokemon1.Location = new System.Drawing.Point(409, 294);
            this.tipoPokemon1.Name = "tipoPokemon1";
            this.tipoPokemon1.Size = new System.Drawing.Size(89, 22);
            this.tipoPokemon1.TabIndex = 6;
            // 
            // ataquePokemon1
            // 
            this.ataquePokemon1.BackColor = System.Drawing.SystemColors.Highlight;
            this.ataquePokemon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataquePokemon1.Location = new System.Drawing.Point(409, 233);
            this.ataquePokemon1.Name = "ataquePokemon1";
            this.ataquePokemon1.Size = new System.Drawing.Size(106, 24);
            this.ataquePokemon1.TabIndex = 7;
            // 
            // especiePokemon
            // 
            this.especiePokemon.BackColor = System.Drawing.SystemColors.Desktop;
            this.especiePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiePokemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.especiePokemon.Location = new System.Drawing.Point(409, 327);
            this.especiePokemon.Name = "especiePokemon";
            this.especiePokemon.Size = new System.Drawing.Size(162, 33);
            this.especiePokemon.TabIndex = 8;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Lime;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(409, 153);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(210, 71);
            this.descripcion.TabIndex = 9;
            // 
            // ataquePokemon2
            // 
            this.ataquePokemon2.BackColor = System.Drawing.SystemColors.Highlight;
            this.ataquePokemon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataquePokemon2.Location = new System.Drawing.Point(513, 233);
            this.ataquePokemon2.Name = "ataquePokemon2";
            this.ataquePokemon2.Size = new System.Drawing.Size(106, 24);
            this.ataquePokemon2.TabIndex = 10;
            // 
            // AtaquePokemon3
            // 
            this.AtaquePokemon3.BackColor = System.Drawing.SystemColors.Highlight;
            this.AtaquePokemon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtaquePokemon3.Location = new System.Drawing.Point(409, 257);
            this.AtaquePokemon3.Name = "AtaquePokemon3";
            this.AtaquePokemon3.Size = new System.Drawing.Size(106, 24);
            this.AtaquePokemon3.TabIndex = 11;
            // 
            // AtaquePokemon4
            // 
            this.AtaquePokemon4.BackColor = System.Drawing.SystemColors.Highlight;
            this.AtaquePokemon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtaquePokemon4.Location = new System.Drawing.Point(513, 257);
            this.AtaquePokemon4.Name = "AtaquePokemon4";
            this.AtaquePokemon4.Size = new System.Drawing.Size(106, 24);
            this.AtaquePokemon4.TabIndex = 12;
            // 
            // idPokemon
            // 
            this.idPokemon.BackColor = System.Drawing.SystemColors.Highlight;
            this.idPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPokemon.Location = new System.Drawing.Point(196, 257);
            this.idPokemon.Name = "idPokemon";
            this.idPokemon.Size = new System.Drawing.Size(84, 33);
            this.idPokemon.TabIndex = 13;
            // 
            // tipoPokemon2
            // 
            this.tipoPokemon2.BackColor = System.Drawing.SystemColors.ControlText;
            this.tipoPokemon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tipoPokemon2.Location = new System.Drawing.Point(504, 294);
            this.tipoPokemon2.Name = "tipoPokemon2";
            this.tipoPokemon2.Size = new System.Drawing.Size(92, 22);
            this.tipoPokemon2.TabIndex = 14;
            // 
            // areaPokemon
            // 
            this.areaPokemon.BackColor = System.Drawing.SystemColors.Highlight;
            this.areaPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaPokemon.Location = new System.Drawing.Point(92, 257);
            this.areaPokemon.Name = "areaPokemon";
            this.areaPokemon.Size = new System.Drawing.Size(98, 33);
            this.areaPokemon.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "POKEMONS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buscador
            // 
            this.buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscador.Image = global::PokedexC_sharp.Properties.Resources.lupa__1_;
            this.buscador.Location = new System.Drawing.Point(257, 93);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(69, 51);
            this.buscador.TabIndex = 17;
            this.buscador.UseVisualStyleBackColor = true;
            this.buscador.Click += new System.EventHandler(this.buscador_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 599);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.areaPokemon);
            this.Controls.Add(this.tipoPokemon2);
            this.Controls.Add(this.idPokemon);
            this.Controls.Add(this.AtaquePokemon4);
            this.Controls.Add(this.AtaquePokemon3);
            this.Controls.Add(this.ataquePokemon2);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.especiePokemon);
            this.Controls.Add(this.ataquePokemon1);
            this.Controls.Add(this.tipoPokemon1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label tipoPokemon1;
        private System.Windows.Forms.Label ataquePokemon1;
        private System.Windows.Forms.Label especiePokemon;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label ataquePokemon2;
        private System.Windows.Forms.Label AtaquePokemon3;
        private System.Windows.Forms.Label AtaquePokemon4;
        private System.Windows.Forms.Label idPokemon;
        private System.Windows.Forms.Label tipoPokemon2;
        private System.Windows.Forms.Label areaPokemon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buscador;
    }
}

