namespace ejemplo1
{
    partial class Form2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechadeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.rbtFerrarri = new System.Windows.Forms.RadioButton();
            this.rbtLamborgini = new System.Windows.Forms.RadioButton();
            this.rbtPorchee = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.numFavorito = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(83, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(79, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 38);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(83, 158);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(138, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Nacimineto:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dtpFechadeNacimiento
            // 
            this.dtpFechadeNacimiento.Location = new System.Drawing.Point(250, 158);
            this.dtpFechadeNacimiento.Name = "dtpFechadeNacimiento";
            this.dtpFechadeNacimiento.Size = new System.Drawing.Size(225, 22);
            this.dtpFechadeNacimiento.TabIndex = 4;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(264, 217);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(171, 20);
            this.ckbChocolate.TabIndex = 5;
            this.ckbChocolate.Text = "Te gusta la Velocidad ?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            this.ckbChocolate.CheckedChanged += new System.EventHandler(this.ckbChocolate_CheckedChanged);
            // 
            // rbtFerrarri
            // 
            this.rbtFerrarri.AutoSize = true;
            this.rbtFerrarri.Location = new System.Drawing.Point(19, 21);
            this.rbtFerrarri.Name = "rbtFerrarri";
            this.rbtFerrarri.Size = new System.Drawing.Size(71, 20);
            this.rbtFerrarri.TabIndex = 6;
            this.rbtFerrarri.TabStop = true;
            this.rbtFerrarri.Text = "Ferrarri";
            this.rbtFerrarri.UseVisualStyleBackColor = true;
            this.rbtFerrarri.CheckedChanged += new System.EventHandler(this.rbtFerrarri_CheckedChanged);
            // 
            // rbtLamborgini
            // 
            this.rbtLamborgini.AutoSize = true;
            this.rbtLamborgini.Location = new System.Drawing.Point(153, 21);
            this.rbtLamborgini.Name = "rbtLamborgini";
            this.rbtLamborgini.Size = new System.Drawing.Size(95, 20);
            this.rbtLamborgini.TabIndex = 7;
            this.rbtLamborgini.TabStop = true;
            this.rbtLamborgini.Text = "Lamborgini";
            this.rbtLamborgini.UseVisualStyleBackColor = true;
            // 
            // rbtPorchee
            // 
            this.rbtPorchee.AutoSize = true;
            this.rbtPorchee.Location = new System.Drawing.Point(304, 21);
            this.rbtPorchee.Name = "rbtPorchee";
            this.rbtPorchee.Size = new System.Drawing.Size(79, 20);
            this.rbtPorchee.TabIndex = 8;
            this.rbtPorchee.TabStop = true;
            this.rbtPorchee.Text = "Porchee";
            this.rbtPorchee.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtFerrarri);
            this.gbxTipo.Controls.Add(this.rbtPorchee);
            this.gbxTipo.Controls.Add(this.rbtLamborgini);
            this.gbxTipo.Location = new System.Drawing.Point(86, 259);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(432, 63);
            this.gbxTipo.TabIndex = 9;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "groupBox1";
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Location = new System.Drawing.Point(86, 349);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(94, 16);
            this.lblColorFavorito.TabIndex = 10;
            this.lblColorFavorito.Text = "Color Favorito:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(205, 341);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(180, 24);
            this.cboColorFavorito.TabIndex = 11;
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(89, 392);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(110, 16);
            this.lblNumeroFavorito.TabIndex = 12;
            this.lblNumeroFavorito.Text = "Numero Favorito:";
            // 
            // numFavorito
            // 
            this.numFavorito.Location = new System.Drawing.Point(205, 390);
            this.numFavorito.Name = "numFavorito";
            this.numFavorito.Size = new System.Drawing.Size(168, 22);
            this.numFavorito.TabIndex = 13;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerPerfil.Location = new System.Drawing.Point(92, 423);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(88, 35);
            this.btnVerPerfil.TabIndex = 14;
            this.btnVerPerfil.Text = "Ver Perfil:";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(89, 478);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(121, 97);
            this.lwElementos.TabIndex = 15;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 595);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 749);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numFavorito);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechadeNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechadeNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.RadioButton rbtFerrarri;
        private System.Windows.Forms.RadioButton rbtLamborgini;
        private System.Windows.Forms.RadioButton rbtPorchee;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lblColorFavorito;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.NumericUpDown numFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Button btnAgregar;
    }
}