namespace Práctica1_Descuento
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
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.lblDescuentoDolares = new System.Windows.Forms.Label();
            this.lblDescuentoPorcentaje = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuentoDolares = new System.Windows.Forms.TextBox();
            this.txtDescuentoPorcentaje = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(97, 93);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(77, 16);
            this.lblValorVenta.TabIndex = 0;
            this.lblValorVenta.Text = "Valor Venta";
            // 
            // lblDescuentoDolares
            // 
            this.lblDescuentoDolares.AutoSize = true;
            this.lblDescuentoDolares.Location = new System.Drawing.Point(97, 188);
            this.lblDescuentoDolares.Name = "lblDescuentoDolares";
            this.lblDescuentoDolares.Size = new System.Drawing.Size(82, 16);
            this.lblDescuentoDolares.TabIndex = 1;
            this.lblDescuentoDolares.Text = "Descuento $";
            this.lblDescuentoDolares.Click += new System.EventHandler(this.lblDescuentodolares_Click);
            // 
            // lblDescuentoPorcentaje
            // 
            this.lblDescuentoPorcentaje.AutoSize = true;
            this.lblDescuentoPorcentaje.Location = new System.Drawing.Point(97, 276);
            this.lblDescuentoPorcentaje.Name = "lblDescuentoPorcentaje";
            this.lblDescuentoPorcentaje.Size = new System.Drawing.Size(87, 16);
            this.lblDescuentoPorcentaje.TabIndex = 2;
            this.lblDescuentoPorcentaje.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(97, 359);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(74, 16);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(267, 93);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(100, 22);
            this.txtValorVenta.TabIndex = 4;
            // 
            // txtDescuentoDolares
            // 
            this.txtDescuentoDolares.Location = new System.Drawing.Point(267, 188);
            this.txtDescuentoDolares.Name = "txtDescuentoDolares";
            this.txtDescuentoDolares.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoDolares.TabIndex = 5;
            // 
            // txtDescuentoPorcentaje
            // 
            this.txtDescuentoPorcentaje.Location = new System.Drawing.Point(267, 276);
            this.txtDescuentoPorcentaje.Name = "txtDescuentoPorcentaje";
            this.txtDescuentoPorcentaje.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoPorcentaje.TabIndex = 6;
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(267, 359);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.Size = new System.Drawing.Size(100, 22);
            this.txtVentaFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(549, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(549, 181);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(611, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtDescuentoPorcentaje);
            this.Controls.Add(this.txtDescuentoDolares);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblDescuentoPorcentaje);
            this.Controls.Add(this.lblDescuentoDolares);
            this.Controls.Add(this.lblValorVenta);
            this.Name = "Form1";
            this.Text = "Descuentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.Label lblDescuentoDolares;
        private System.Windows.Forms.Label lblDescuentoPorcentaje;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuentoDolares;
        private System.Windows.Forms.TextBox txtDescuentoPorcentaje;
        private System.Windows.Forms.TextBox txtVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

