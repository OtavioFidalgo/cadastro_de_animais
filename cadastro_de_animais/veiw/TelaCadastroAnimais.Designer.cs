namespace cadastro_de_animais.veiw
{
    partial class TelaCadastroAnimais
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
            cda = new Label();
            nome = new Label();
            raca = new Label();
            cbx_porte = new ComboBox();
            porte = new Label();
            tbx_nome = new TextBox();
            tbx_raca = new TextBox();
            btn_cadastrar = new Button();
            SuspendLayout();
            // 
            // cda
            // 
            cda.AutoSize = true;
            cda.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cda.Location = new Point(260, 91);
            cda.Name = "cda";
            cda.Size = new Size(325, 32);
            cda.TabIndex = 0;
            cda.Text = "Cadastro de Animais";
            cda.Click += label1_Click;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nome.Location = new Point(117, 169);
            nome.Name = "nome";
            nome.Size = new Size(54, 16);
            nome.TabIndex = 1;
            nome.Text = "Nome:";
            // 
            // raca
            // 
            raca.AutoSize = true;
            raca.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raca.Location = new Point(117, 208);
            raca.Name = "raca";
            raca.Size = new Size(47, 16);
            raca.TabIndex = 2;
            raca.Text = "Raça:";
            raca.Click += label3_Click;
            // 
            // cbx_porte
            // 
            cbx_porte.FormattingEnabled = true;
            cbx_porte.Items.AddRange(new object[] { "Mini", "Pequeno", "Médio", "Grande", "Gigante" });
            cbx_porte.Location = new Point(177, 242);
            cbx_porte.Name = "cbx_porte";
            cbx_porte.Size = new Size(170, 23);
            cbx_porte.TabIndex = 3;
            // 
            // porte
            // 
            porte.AutoSize = true;
            porte.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            porte.Location = new Point(117, 245);
            porte.Name = "porte";
            porte.Size = new Size(51, 16);
            porte.TabIndex = 4;
            porte.Text = "Porte:";
            // 
            // tbx_nome
            // 
            tbx_nome.Location = new Point(177, 162);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(365, 23);
            tbx_nome.TabIndex = 5;
            tbx_nome.TextChanged += textBox1_TextChanged;
            // 
            // tbx_raca
            // 
            tbx_raca.Location = new Point(177, 201);
            tbx_raca.Name = "tbx_raca";
            tbx_raca.Size = new Size(365, 23);
            tbx_raca.TabIndex = 6;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.Info;
            btn_cadastrar.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(501, 339);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(123, 41);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // TelaCadastroAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cadastrar);
            Controls.Add(tbx_raca);
            Controls.Add(tbx_nome);
            Controls.Add(porte);
            Controls.Add(cbx_porte);
            Controls.Add(raca);
            Controls.Add(nome);
            Controls.Add(cda);
            MaximizeBox = false;
            Name = "TelaCadastroAnimais";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cadastro de Animais";
            TransparencyKey = Color.DarkGray;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cda;
        private Label nome;
        private Label raca;
        private ComboBox cbx_porte;
        private Label porte;
        private TextBox tbx_nome;
        private TextBox tbx_raca;
        private Button btn_cadastrar;
    }
}