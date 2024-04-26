namespace PDV.app
{
    partial class Main
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
            LB1 = new Label();
            SuspendLayout();
            // 
            // LB1
            // 
            LB1.AutoSize = true;
            LB1.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            LB1.Location = new Point(108, 77);
            LB1.Name = "LB1";
            LB1.Size = new Size(263, 29);
            LB1.TabIndex = 0;
            LB1.Text = "JANELA DE INÍCIO";
            // 
            // janelaInício
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 344);
            Controls.Add(LB1);
            Name = "janelaInício";
            Text = "janelaInício";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB1;
    }
}