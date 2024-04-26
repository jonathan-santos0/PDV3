namespace PDV.app
{
    partial class Login
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
            label1 = new Label();
            TBName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            TBPassword = new TextBox();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo ao Venda Fácil";
            // 
            // TBName
            // 
            TBName.Location = new Point(143, 74);
            TBName.Name = "TBName";
            TBName.Size = new Size(184, 23);
            TBName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 56);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Entre com seu nome";
            // 
            // button1
            // 
            button1.Location = new Point(177, 156);
            button1.Name = "button1";
            button1.Size = new Size(104, 27);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(143, 127);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(184, 23);
            TBPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 109);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 5;
            label3.Text = "Entre com sua senha";
            // 
            // button2
            // 
            button2.Location = new Point(177, 189);
            button2.Name = "button2";
            button2.Size = new Size(104, 28);
            button2.TabIndex = 6;
            button2.Text = "INSCREVA-SE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 401);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(TBPassword);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(TBName);
            Controls.Add(label1);
            Name = "Main";
            Text = "PDV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBName;
        private Label label2;
        private Button button1;
        private TextBox TBPassword;
        private Label label3;
        private Button button2;
    }
}