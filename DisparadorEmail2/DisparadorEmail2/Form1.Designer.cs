namespace DisparadorEmail2
{
    partial class Form1
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
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnAbrirPlanilha = new System.Windows.Forms.Button();
            this.btnAbrirDiretorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblExcelNomeArquivo = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblRotuloFolder = new System.Windows.Forms.Label();
            this.lblRotuloExcelNomeArquivo = new System.Windows.Forms.Label();
            this.cbxExcelAba = new System.Windows.Forms.ComboBox();
            this.lblRotuloExcelAba = new System.Windows.Forms.Label();
            this.lblRotuloPularLinha = new System.Windows.Forms.Label();
            this.cbxPularLinha = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviarEmail.Location = new System.Drawing.Point(205, 229);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(142, 23);
            this.btnEnviarEmail.TabIndex = 3;
            this.btnEnviarEmail.Text = "Enviar E-Mail";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnAbrirPlanilha
            // 
            this.btnAbrirPlanilha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbrirPlanilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPlanilha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirPlanilha.Location = new System.Drawing.Point(205, 171);
            this.btnAbrirPlanilha.Name = "btnAbrirPlanilha";
            this.btnAbrirPlanilha.Size = new System.Drawing.Size(142, 23);
            this.btnAbrirPlanilha.TabIndex = 1;
            this.btnAbrirPlanilha.Text = "Abrir Planilha";
            this.btnAbrirPlanilha.UseVisualStyleBackColor = false;
            this.btnAbrirPlanilha.Click += new System.EventHandler(this.btnAbrirPlanilha_Click);
            // 
            // btnAbrirDiretorio
            // 
            this.btnAbrirDiretorio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbrirDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirDiretorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirDiretorio.Location = new System.Drawing.Point(205, 200);
            this.btnAbrirDiretorio.Name = "btnAbrirDiretorio";
            this.btnAbrirDiretorio.Size = new System.Drawing.Size(142, 23);
            this.btnAbrirDiretorio.TabIndex = 2;
            this.btnAbrirDiretorio.Text = "Abrir Diretório";
            this.btnAbrirDiretorio.UseVisualStyleBackColor = false;
            this.btnAbrirDiretorio.Click += new System.EventHandler(this.btnAbrirDiretorio_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(205, 258);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblExcelNomeArquivo
            // 
            this.lblExcelNomeArquivo.AutoSize = true;
            this.lblExcelNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcelNomeArquivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExcelNomeArquivo.Location = new System.Drawing.Point(12, 35);
            this.lblExcelNomeArquivo.Name = "lblExcelNomeArquivo";
            this.lblExcelNomeArquivo.Size = new System.Drawing.Size(194, 16);
            this.lblExcelNomeArquivo.TabIndex = 4;
            this.lblExcelNomeArquivo.Text = "lblExcelNomeArquivoShow";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFolder.Location = new System.Drawing.Point(12, 105);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(107, 16);
            this.lblFolder.TabIndex = 5;
            this.lblFolder.Text = "lblFolderShow";
            // 
            // lblRotuloFolder
            // 
            this.lblRotuloFolder.AutoSize = true;
            this.lblRotuloFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotuloFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRotuloFolder.Location = new System.Drawing.Point(12, 79);
            this.lblRotuloFolder.Name = "lblRotuloFolder";
            this.lblRotuloFolder.Size = new System.Drawing.Size(72, 16);
            this.lblRotuloFolder.TabIndex = 7;
            this.lblRotuloFolder.Text = "Diretório:";
            // 
            // lblRotuloExcelNomeArquivo
            // 
            this.lblRotuloExcelNomeArquivo.AutoSize = true;
            this.lblRotuloExcelNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotuloExcelNomeArquivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRotuloExcelNomeArquivo.Location = new System.Drawing.Point(12, 9);
            this.lblRotuloExcelNomeArquivo.Name = "lblRotuloExcelNomeArquivo";
            this.lblRotuloExcelNomeArquivo.Size = new System.Drawing.Size(117, 16);
            this.lblRotuloExcelNomeArquivo.TabIndex = 6;
            this.lblRotuloExcelNomeArquivo.Text = "Nome do Exce:l";
            // 
            // cbxExcelAba
            // 
            this.cbxExcelAba.FormattingEnabled = true;
            this.cbxExcelAba.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxExcelAba.Location = new System.Drawing.Point(15, 162);
            this.cbxExcelAba.Name = "cbxExcelAba";
            this.cbxExcelAba.Size = new System.Drawing.Size(69, 21);
            this.cbxExcelAba.TabIndex = 4;
            // 
            // lblRotuloExcelAba
            // 
            this.lblRotuloExcelAba.AutoSize = true;
            this.lblRotuloExcelAba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotuloExcelAba.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRotuloExcelAba.Location = new System.Drawing.Point(12, 142);
            this.lblRotuloExcelAba.Name = "lblRotuloExcelAba";
            this.lblRotuloExcelAba.Size = new System.Drawing.Size(104, 16);
            this.lblRotuloExcelAba.TabIndex = 9;
            this.lblRotuloExcelAba.Text = "Aba do Excel:";
            // 
            // lblRotuloPularLinha
            // 
            this.lblRotuloPularLinha.AutoSize = true;
            this.lblRotuloPularLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotuloPularLinha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRotuloPularLinha.Location = new System.Drawing.Point(12, 200);
            this.lblRotuloPularLinha.Name = "lblRotuloPularLinha";
            this.lblRotuloPularLinha.Size = new System.Drawing.Size(97, 16);
            this.lblRotuloPularLinha.TabIndex = 10;
            this.lblRotuloPularLinha.Text = "Pular Linhas:";
            // 
            // cbxPularLinha
            // 
            this.cbxPularLinha.FormattingEnabled = true;
            this.cbxPularLinha.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxPularLinha.Location = new System.Drawing.Point(15, 219);
            this.cbxPularLinha.Name = "cbxPularLinha";
            this.cbxPularLinha.Size = new System.Drawing.Size(69, 21);
            this.cbxPularLinha.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 293);
            this.Controls.Add(this.cbxPularLinha);
            this.Controls.Add(this.lblRotuloPularLinha);
            this.Controls.Add(this.lblRotuloExcelAba);
            this.Controls.Add(this.cbxExcelAba);
            this.Controls.Add(this.lblRotuloFolder);
            this.Controls.Add(this.lblRotuloExcelNomeArquivo);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblExcelNomeArquivo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbrirPlanilha);
            this.Controls.Add(this.btnAbrirDiretorio);
            this.Controls.Add(this.btnEnviarEmail);
            this.Name = "Form1";
            this.Text = "Disparador de E-Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnAbrirDiretorio;
        private System.Windows.Forms.Button btnAbrirPlanilha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblExcelNomeArquivo;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblRotuloFolder;
        private System.Windows.Forms.Label lblRotuloExcelNomeArquivo;
        private System.Windows.Forms.ComboBox cbxExcelAba;
        private System.Windows.Forms.Label lblRotuloExcelAba;
        private System.Windows.Forms.Label lblRotuloPularLinha;
        private System.Windows.Forms.ComboBox cbxPularLinha;
    }
}

