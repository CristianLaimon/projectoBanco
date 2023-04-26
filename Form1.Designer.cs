namespace projectoBanco
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRetirar100 = new System.Windows.Forms.Button();
            this.buttonAbonar100 = new System.Windows.Forms.Button();
            this.buttonRetirarTodos = new System.Windows.Forms.Button();
            this.buttonCorteCaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEvitarAdvertencias = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column8,
            this.Column6,
            this.Column7,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. De Cuenta";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nip";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo De Cuenta";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Saldo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Numero De Operaciones";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Limite de Credito";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Disponible";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tasa De Intereses";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // buttonRetirar100
            // 
            this.buttonRetirar100.Location = new System.Drawing.Point(201, 521);
            this.buttonRetirar100.Name = "buttonRetirar100";
            this.buttonRetirar100.Size = new System.Drawing.Size(145, 49);
            this.buttonRetirar100.TabIndex = 1;
            this.buttonRetirar100.Text = "Retirar 100";
            this.buttonRetirar100.UseVisualStyleBackColor = true;
            this.buttonRetirar100.Click += new System.EventHandler(this.buttonRetirar100_Click);
            // 
            // buttonAbonar100
            // 
            this.buttonAbonar100.Location = new System.Drawing.Point(400, 521);
            this.buttonAbonar100.Name = "buttonAbonar100";
            this.buttonAbonar100.Size = new System.Drawing.Size(145, 49);
            this.buttonAbonar100.TabIndex = 2;
            this.buttonAbonar100.Text = "Abonar 100";
            this.buttonAbonar100.UseVisualStyleBackColor = true;
            this.buttonAbonar100.Click += new System.EventHandler(this.buttonAbonar100_Click);
            // 
            // buttonRetirarTodos
            // 
            this.buttonRetirarTodos.Location = new System.Drawing.Point(588, 521);
            this.buttonRetirarTodos.Name = "buttonRetirarTodos";
            this.buttonRetirarTodos.Size = new System.Drawing.Size(145, 49);
            this.buttonRetirarTodos.TabIndex = 3;
            this.buttonRetirarTodos.Text = "Retirar (Todos)";
            this.buttonRetirarTodos.UseVisualStyleBackColor = true;
            this.buttonRetirarTodos.Click += new System.EventHandler(this.buttonRetirarTodos_Click);
            // 
            // buttonCorteCaja
            // 
            this.buttonCorteCaja.Location = new System.Drawing.Point(772, 521);
            this.buttonCorteCaja.Name = "buttonCorteCaja";
            this.buttonCorteCaja.Size = new System.Drawing.Size(145, 49);
            this.buttonCorteCaja.TabIndex = 4;
            this.buttonCorteCaja.Text = "Corte de Caja";
            this.buttonCorteCaja.UseVisualStyleBackColor = true;
            this.buttonCorteCaja.Click += new System.EventHandler(this.buttonCorteCaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hecho por: Diana Yulissa Sesma Santiago y Kristan Ruíz Limón";
            // 
            // checkBoxEvitarAdvertencias
            // 
            this.checkBoxEvitarAdvertencias.AutoSize = true;
            this.checkBoxEvitarAdvertencias.Location = new System.Drawing.Point(14, 632);
            this.checkBoxEvitarAdvertencias.Name = "checkBoxEvitarAdvertencias";
            this.checkBoxEvitarAdvertencias.Size = new System.Drawing.Size(187, 24);
            this.checkBoxEvitarAdvertencias.TabIndex = 6;
            this.checkBoxEvitarAdvertencias.Text = "Desactivar advertencias";
            this.checkBoxEvitarAdvertencias.UseVisualStyleBackColor = true;
            this.checkBoxEvitarAdvertencias.CheckedChanged += new System.EventHandler(this.checkBoxEvitarAdvertencias_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 668);
            this.Controls.Add(this.checkBoxEvitarAdvertencias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCorteCaja);
            this.Controls.Add(this.buttonRetirarTodos);
            this.Controls.Add(this.buttonAbonar100);
            this.Controls.Add(this.buttonRetirar100);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Banamex DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonRetirar100;
        private Button buttonAbonar100;
        private Button buttonRetirarTodos;
        private Button buttonCorteCaja;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private Label label1;
        private CheckBox checkBoxEvitarAdvertencias;
    }
}