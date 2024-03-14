namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            mtxsenha = new MaskedTextBox();
            label3 = new Label();
            ckbsenha = new CheckBox();
            btologin = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 89);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 140);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(299, 91);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(160, 23);
            txtusuario.TabIndex = 2;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // mtxsenha
            // 
            mtxsenha.Location = new Point(299, 138);
            mtxsenha.Name = "mtxsenha";
            mtxsenha.PasswordChar = '*';
            mtxsenha.Size = new Size(160, 23);
            mtxsenha.TabIndex = 3;
            mtxsenha.VisibleChanged += txtusuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(344, 19);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // ckbsenha
            // 
            ckbsenha.AutoSize = true;
            ckbsenha.Location = new Point(465, 140);
            ckbsenha.Name = "ckbsenha";
            ckbsenha.Size = new Size(61, 19);
            ckbsenha.TabIndex = 5;
            ckbsenha.Text = "revelar";
            ckbsenha.UseVisualStyleBackColor = true;
            ckbsenha.CheckedChanged += ckbsenha_CheckedChanged;
            // 
            // btologin
            // 
            btologin.Location = new Point(344, 186);
            btologin.Name = "btologin";
            btologin.Size = new Size(84, 23);
            btologin.TabIndex = 6;
            btologin.Text = "login";
            btologin.UseVisualStyleBackColor = true;
            btologin.Click += btologin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btologin);
            Controls.Add(ckbsenha);
            Controls.Add(label3);
            Controls.Add(mtxsenha);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private MaskedTextBox mtxsenha;
        private Label label3;
        private CheckBox ckbsenha;
        private Button btologin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
