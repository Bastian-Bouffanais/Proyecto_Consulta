
namespace CapaGUI_Paciente
{
    partial class Listado_Horas
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
            this.btn_Hora = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Hora
            // 
            this.btn_Hora.Location = new System.Drawing.Point(599, 391);
            this.btn_Hora.Name = "btn_Hora";
            this.btn_Hora.Size = new System.Drawing.Size(147, 36);
            this.btn_Hora.TabIndex = 0;
            this.btn_Hora.Text = "Pedir Hora";
            this.btn_Hora.UseVisualStyleBackColor = true;
            this.btn_Hora.Click += new System.EventHandler(this.btn_Hora_Click);
            // 
            // Listado
            // 
            this.Listado.AutoSize = true;
            this.Listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listado.Location = new System.Drawing.Point(253, 20);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(310, 46);
            this.Listado.TabIndex = 2;
            this.Listado.Text = "Listado Medicos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Listado_Horas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.btn_Hora);
            this.Name = "Listado_Horas";
            this.Text = "Listado_Horas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hora;
        private System.Windows.Forms.Label Listado;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}