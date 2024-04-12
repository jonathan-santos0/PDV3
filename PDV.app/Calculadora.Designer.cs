namespace PDV.app
{
    partial class Calculadora
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
            LBValor1 = new Label();
            BTSomar = new Button();
            LBValor2 = new Label();
            LBResultado = new Label();
            NUDValor2 = new NumericUpDown();
            NUDValor1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NUDValor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDValor1).BeginInit();
            SuspendLayout();
            // 
            // LBValor1
            // 
            LBValor1.AutoSize = true;
            LBValor1.Font = new Font("Segoe UI", 15F);
            LBValor1.Location = new Point(24, 44);
            LBValor1.Name = "LBValor1";
            LBValor1.Size = new Size(68, 28);
            LBValor1.TabIndex = 1;
            LBValor1.Text = "Valor1";
            // 
            // BTSomar
            // 
            BTSomar.Location = new Point(24, 180);
            BTSomar.Name = "BTSomar";
            BTSomar.Size = new Size(75, 23);
            BTSomar.TabIndex = 2;
            BTSomar.Text = "Somar";
            BTSomar.UseVisualStyleBackColor = true;
            BTSomar.Click += BTSomar_Click;
            // 
            // LBValor2
            // 
            LBValor2.AutoSize = true;
            LBValor2.Font = new Font("Segoe UI", 15F);
            LBValor2.Location = new Point(24, 120);
            LBValor2.Name = "LBValor2";
            LBValor2.Size = new Size(68, 28);
            LBValor2.TabIndex = 4;
            LBValor2.Text = "Valor2";
            // 
            // LBResultado
            // 
            LBResultado.AutoSize = true;
            LBResultado.Font = new Font("Segoe UI", 15F);
            LBResultado.Location = new Point(12, 215);
            LBResultado.Name = "LBResultado";
            LBResultado.Size = new Size(102, 28);
            LBResultado.TabIndex = 5;
            LBResultado.Text = "Resultado:";
            // 
            // NUDValor2
            // 
            NUDValor2.Location = new Point(12, 151);
            NUDValor2.Name = "NUDValor2";
            NUDValor2.Size = new Size(120, 23);
            NUDValor2.TabIndex = 6;
            // 
            // NUDValor1
            // 
            NUDValor1.Location = new Point(12, 75);
            NUDValor1.Name = "NUDValor1";
            NUDValor1.Size = new Size(120, 23);
            NUDValor1.TabIndex = 7;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NUDValor1);
            Controls.Add(NUDValor2);
            Controls.Add(LBResultado);
            Controls.Add(LBValor2);
            Controls.Add(BTSomar);
            Controls.Add(LBValor1);
            Name = "Calculadora";
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)NUDValor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDValor1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LBValor1;
        private Button BTSomar;
        private Label LBValor2;
        private Label LBResultado;
        private NumericUpDown NUDValor2;
        private NumericUpDown NUDValor1;
    }
}