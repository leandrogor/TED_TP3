﻿namespace TED_TP3
{
    partial class LoginJugar
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblBienvenida.Location = new System.Drawing.Point(496, 124);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(289, 39);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "¡¡¡BIENVENIDO!!!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(478, 63);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "A TODO QUÍMICA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJugar
            // 
            this.btnJugar.AutoSize = true;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnJugar.ForeColor = System.Drawing.Color.Black;
            this.btnJugar.Location = new System.Drawing.Point(571, 256);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(116, 44);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(49, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tu nombre: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(280, 263);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = global::TED_TP3.Properties.Resources.Salir;
            this.btnVolver.Location = new System.Drawing.Point(669, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 44);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // LoginJugar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginJugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnVolver;
    }
}