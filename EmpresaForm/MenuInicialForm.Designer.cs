namespace EmpresaForm
{
    partial class MenuInicialForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btListagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestão de Funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anna Isabela - 3°A Informática";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.btCadastro.Location = new System.Drawing.Point(52, 164);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(273, 132);
            this.btCadastro.TabIndex = 4;
            this.btCadastro.Text = "Cadastrar Funcionário";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btListagem
            // 
            this.btListagem.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.btListagem.Location = new System.Drawing.Point(371, 164);
            this.btListagem.Name = "btListagem";
            this.btListagem.Size = new System.Drawing.Size(273, 132);
            this.btListagem.TabIndex = 5;
            this.btListagem.Text = "Listar Funcionários";
            this.btListagem.UseVisualStyleBackColor = true;
            this.btListagem.Click += new System.EventHandler(this.btListagem_Click);
            // 
            // MenuInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Controls.Add(this.btListagem);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuInicialForm";
            this.Text = "Menu Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btListagem;
    }
}

