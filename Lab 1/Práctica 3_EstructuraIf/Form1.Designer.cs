namespace Pract_3___EstructuraIf
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
            this.lblIngresaValores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbtnSuma = new System.Windows.Forms.RadioButton();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblSignoIgual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresaValores
            // 
            this.lblIngresaValores.AutoSize = true;
            this.lblIngresaValores.Location = new System.Drawing.Point(63, 37);
            this.lblIngresaValores.Name = "lblIngresaValores";
            this.lblIngresaValores.Size = new System.Drawing.Size(269, 16);
            this.lblIngresaValores.TabIndex = 0;
            this.lblIngresaValores.Text = "Ingresa los valores y selecciona una opción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDivision);
            this.groupBox1.Controls.Add(this.rbtnMultiplicacion);
            this.groupBox1.Controls.Add(this.rbtnResta);
            this.groupBox1.Controls.Add(this.rbtnSuma);
            this.groupBox1.Location = new System.Drawing.Point(69, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBox1";
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(20, 157);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(76, 20);
            this.rbtnDivision.TabIndex = 7;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "División";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.CheckedChanged += new System.EventHandler(this.rbtnDivision_CheckedChanged);
            // 
            // rbtnMultiplicacion
            // 
            this.rbtnMultiplicacion.AutoSize = true;
            this.rbtnMultiplicacion.Location = new System.Drawing.Point(20, 118);
            this.rbtnMultiplicacion.Name = "rbtnMultiplicacion";
            this.rbtnMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbtnMultiplicacion.TabIndex = 6;
            this.rbtnMultiplicacion.TabStop = true;
            this.rbtnMultiplicacion.Text = "Multiplicación";
            this.rbtnMultiplicacion.UseVisualStyleBackColor = true;
            this.rbtnMultiplicacion.CheckedChanged += new System.EventHandler(this.rbtnMultiplicacion_CheckedChanged);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(20, 77);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(64, 20);
            this.rbtnResta.TabIndex = 5;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Resta";
            this.rbtnResta.UseVisualStyleBackColor = true;
            this.rbtnResta.CheckedChanged += new System.EventHandler(this.rbtnResta_CheckedChanged);
            // 
            // rbtnSuma
            // 
            this.rbtnSuma.AutoSize = true;
            this.rbtnSuma.Location = new System.Drawing.Point(20, 37);
            this.rbtnSuma.Name = "rbtnSuma";
            this.rbtnSuma.Size = new System.Drawing.Size(63, 20);
            this.rbtnSuma.TabIndex = 4;
            this.rbtnSuma.TabStop = true;
            this.rbtnSuma.Text = "Suma";
            this.rbtnSuma.UseVisualStyleBackColor = true;
            this.rbtnSuma.CheckedChanged += new System.EventHandler(this.rbtnSuma_CheckedChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(71, 102);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(345, 102);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(625, 102);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 6;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(233, 105);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(14, 16);
            this.lblSigno.TabIndex = 7;
            this.lblSigno.Text = "+";
            // 
            // lblSignoIgual
            // 
            this.lblSignoIgual.AutoSize = true;
            this.lblSignoIgual.Location = new System.Drawing.Point(529, 107);
            this.lblSignoIgual.Name = "lblSignoIgual";
            this.lblSignoIgual.Size = new System.Drawing.Size(14, 16);
            this.lblSignoIgual.TabIndex = 8;
            this.lblSignoIgual.Text = "=";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(271, 404);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(438, 404);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSignoIgual);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIngresaValores);
            this.Name = "Form1";
            this.Text = "PRÁCTICA DE ESTRUCTURA IF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresaValores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.RadioButton rbtnMultiplicacion;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbtnSuma;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblSignoIgual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

