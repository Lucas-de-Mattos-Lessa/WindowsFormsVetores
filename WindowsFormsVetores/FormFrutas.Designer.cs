namespace WindowsFormsVetores
{
    partial class FormFrutas
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.tbxFrutas = new System.Windows.Forms.TextBox();
            this.lbxFrutas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(236, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(236, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblFrutas
            // 
            this.lblFrutas.AutoSize = true;
            this.lblFrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrutas.Location = new System.Drawing.Point(58, 76);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(166, 25);
            this.lblFrutas.TabIndex = 5;
            this.lblFrutas.Text = "Insira uma fruta:";
            // 
            // tbxFrutas
            // 
            this.tbxFrutas.Location = new System.Drawing.Point(74, 121);
            this.tbxFrutas.Name = "tbxFrutas";
            this.tbxFrutas.Size = new System.Drawing.Size(137, 20);
            this.tbxFrutas.TabIndex = 6;
            // 
            // lbxFrutas
            // 
            this.lbxFrutas.FormattingEnabled = true;
            this.lbxFrutas.Location = new System.Drawing.Point(83, 182);
            this.lbxFrutas.Name = "lbxFrutas";
            this.lbxFrutas.Size = new System.Drawing.Size(120, 95);
            this.lbxFrutas.TabIndex = 7;
            // 
            // FormFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 413);
            this.Controls.Add(this.lbxFrutas);
            this.Controls.Add(this.tbxFrutas);
            this.Controls.Add(this.lblFrutas);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormFrutas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFrutas;
        private System.Windows.Forms.TextBox tbxFrutas;
        private System.Windows.Forms.ListBox lbxFrutas;
    }
}

