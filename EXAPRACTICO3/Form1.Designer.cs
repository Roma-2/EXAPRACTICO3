
namespace EXAPRACTICO3
{
    partial class Form1
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.buttonControlLED = new System.Windows.Forms.Button();
            this.labelLEDStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(104, 66);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.Text = "Nombre";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(231, 65);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.textBoxFecha.TabIndex = 1;
            this.textBoxFecha.Text = "Fecha";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(104, 124);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(62, 13);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.Text = "labelCelsius";
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(231, 124);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(79, 13);
            this.labelFahrenheit.TabIndex = 3;
            this.labelFahrenheit.Text = "labelFarenheint";
            // 
            // buttonControlLED
            // 
            this.buttonControlLED.Location = new System.Drawing.Point(116, 173);
            this.buttonControlLED.Name = "buttonControlLED";
            this.buttonControlLED.Size = new System.Drawing.Size(75, 23);
            this.buttonControlLED.TabIndex = 4;
            this.buttonControlLED.Text = "control led";
            this.buttonControlLED.UseVisualStyleBackColor = true;
            this.buttonControlLED.Click += new System.EventHandler(this.buttonControlLED_Click);
            // 
            // labelLEDStatus
            // 
            this.labelLEDStatus.AutoSize = true;
            this.labelLEDStatus.Location = new System.Drawing.Point(231, 173);
            this.labelLEDStatus.Name = "labelLEDStatus";
            this.labelLEDStatus.Size = new System.Drawing.Size(58, 13);
            this.labelLEDStatus.TabIndex = 5;
            this.labelLEDStatus.Text = "estatus led";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 333);
            this.Controls.Add(this.labelLEDStatus);
            this.Controls.Add(this.buttonControlLED);
            this.Controls.Add(this.labelFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxNombre);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label labelFahrenheit;
        private System.Windows.Forms.Button buttonControlLED;
        private System.Windows.Forms.Label labelLEDStatus;
    }
}

