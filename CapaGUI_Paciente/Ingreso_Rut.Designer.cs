
namespace CapaGUI_Paciente
{
    partial class Ingreso_Rut
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
            this.Rut = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.Guia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rut
            // 
            this.Rut.AutoSize = true;
            this.Rut.Cursor = System.Windows.Forms.Cursors.No;
            this.Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rut.Location = new System.Drawing.Point(160, 104);
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(277, 46);
            this.Rut.TabIndex = 2;
            this.Rut.Text = "Ingrese su Rut";
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(73, 255);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(455, 45);
            this.txtRut.TabIndex = 3;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(145, 406);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(325, 61);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Guia
            // 
            this.Guia.AutoSize = true;
            this.Guia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guia.Location = new System.Drawing.Point(164, 182);
            this.Guia.Name = "Guia";
            this.Guia.Size = new System.Drawing.Size(279, 22);
            this.Guia.TabIndex = 5;
            this.Guia.Text = "Sin puntos y con digito verificador";
            // 
            // Ingreso_Rut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 592);
            this.Controls.Add(this.Guia);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.Rut);
            this.Name = "Ingreso_Rut";
            this.Text = "Ingreso_Rut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rut;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label Guia;
    }
}