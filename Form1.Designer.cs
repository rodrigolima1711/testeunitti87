﻿namespace testeunitti87
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGitar
            // 
            this.BtnGitar.Location = new System.Drawing.Point(333, 128);
            this.BtnGitar.Name = "BtnGitar";
            this.BtnGitar.Size = new System.Drawing.Size(81, 24);
            this.BtnGitar.TabIndex = 0;
            this.BtnGitar.Text = "Gitar";
            this.BtnGitar.UseVisualStyleBackColor = true;
            this.BtnGitar.Click += new System.EventHandler(this.BtnGitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGitar;
    }
}

