
namespace Calculadora1
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
            this.cmdResultado = new System.Windows.Forms.Button();
            this.cbxOperacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdResultado
            // 
            this.cmdResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResultado.Location = new System.Drawing.Point(636, 208);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(106, 28);
            this.cmdResultado.TabIndex = 0;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = false;
            this.cmdResultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxOperacion
            // 
            this.cbxOperacion.FormattingEnabled = true;
            this.cbxOperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbxOperacion.Location = new System.Drawing.Point(636, 128);
            this.cbxOperacion.Name = "cbxOperacion";
            this.cbxOperacion.Size = new System.Drawing.Size(128, 21);
            this.cbxOperacion.TabIndex = 1;
            this.cbxOperacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operacion";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.Teal;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(656, 172);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(19, 20);
            this.lblres.TabIndex = 3;
            this.lblres.Text = "0";
            this.lblres.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.BackColor = System.Drawing.Color.Green;
            this.lblv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblv1.Location = new System.Drawing.Point(475, 44);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(61, 18);
            this.lblv1.TabIndex = 4;
            this.lblv1.Text = "Valor 1";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.BackColor = System.Drawing.Color.Green;
            this.lblv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblv2.Location = new System.Drawing.Point(475, 78);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(61, 18);
            this.lblv2.TabIndex = 5;
            this.lblv2.Text = "Valor 2";
            this.lblv2.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(547, 44);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(100, 20);
            this.txtv1.TabIndex = 6;
            this.txtv1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(547, 76);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(100, 20);
            this.txtv2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 268);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxOperacion);
            this.Controls.Add(this.cmdResultado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.ComboBox cbxOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
    }
}

