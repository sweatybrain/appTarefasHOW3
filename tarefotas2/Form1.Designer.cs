
namespace tarefotas2
{
    partial class Form1
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
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbTarefa = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.lblogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colData,
            this.colTarefa,
            this.colAtivo});
            this.dgvTarefas.Location = new System.Drawing.Point(24, 173);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.Size = new System.Drawing.Size(618, 150);
            this.dgvTarefas.TabIndex = 0;
            this.dgvTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellContentClick);
            this.dgvTarefas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellContentDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 70;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 85;
            // 
            // colTarefa
            // 
            this.colTarefa.HeaderText = "Tarefa";
            this.colTarefa.Name = "colTarefa";
            this.colTarefa.ReadOnly = true;
            this.colTarefa.Width = 350;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 70;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(679, 124);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(89, 39);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdicionar.Location = new System.Drawing.Point(679, 79);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(89, 39);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEditar.Location = new System.Drawing.Point(679, 173);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(89, 39);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeletar.Location = new System.Drawing.Point(679, 218);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(89, 39);
            this.btDeletar.TabIndex = 4;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(62, 121);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 5;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(143, 121);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(89, 20);
            this.tbData.TabIndex = 6;
            // 
            // tbTarefa
            // 
            this.tbTarefa.Location = new System.Drawing.Point(238, 121);
            this.tbTarefa.Name = "tbTarefa";
            this.tbTarefa.Size = new System.Drawing.Size(340, 20);
            this.tbTarefa.TabIndex = 7;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(59, 102);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(22, 16);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "Id:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(140, 105);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(40, 16);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "Data:";
            // 
            // lbTarefa
            // 
            this.lbTarefa.AutoSize = true;
            this.lbTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarefa.Location = new System.Drawing.Point(235, 105);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(51, 16);
            this.lbTarefa.TabIndex = 10;
            this.lbTarefa.Text = "Tarefa:";
            // 
            // lblogo
            // 
            this.lblogo.Location = new System.Drawing.Point(344, 30);
            this.lblogo.Name = "lblogo";
            this.lblogo.Size = new System.Drawing.Size(100, 50);
            this.lblogo.TabIndex = 15;
            this.lblogo.Text = "App de Tarefas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblogo);
            this.Controls.Add(this.lbTarefa);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbTarefa);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.dgvTarefas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbTarefa;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbTarefa;
        private System.Windows.Forms.Label lblogo;
    }
}

