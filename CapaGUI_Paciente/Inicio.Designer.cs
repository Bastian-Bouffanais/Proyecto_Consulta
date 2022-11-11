
namespace CapaGUI_Paciente
{
    partial class Inicio
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
            this.Bienvenida = new System.Windows.Forms.Label();
            this.btn_Hora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Cursor = System.Windows.Forms.Cursors.No;
            this.Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.Location = new System.Drawing.Point(83, 88);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(425, 46);
            this.Bienvenida.TabIndex = 1;
            this.Bienvenida.Text = "Bienvenido a PECEPA";
            // 
            // btn_Hora
            // 
            this.btn_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hora.Location = new System.Drawing.Point(126, 266);
            this.btn_Hora.Name = "btn_Hora";
            this.btn_Hora.Size = new System.Drawing.Size(325, 61);
            this.btn_Hora.TabIndex = 2;
            this.btn_Hora.Text = "Tomar Hora";
            this.btn_Hora.UseVisualStyleBackColor = true;
            this.btn_Hora.Click += new System.EventHandler(this.btn_Hora_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 592);
            this.Controls.Add(this.btn_Hora);
            this.Controls.Add(this.Bienvenida);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button btn_Hora;
    }
}