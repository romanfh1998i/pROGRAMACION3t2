namespace Tarea2
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
            this.ISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo_Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISR,
            this.ASR,
            this.Total_Descuento,
            this.AFP,
            this.Sueldo_Neto});
            this.dataGridView1.Location = new System.Drawing.Point(25, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(682, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ISR
            // 
            this.ISR.HeaderText = "ISR";
            this.ISR.MinimumWidth = 6;
            this.ISR.Name = "ISR";
            this.ISR.Width = 125;
            // 
            // ASR
            // 
            this.ASR.HeaderText = "ASR";
            this.ASR.MinimumWidth = 6;
            this.ASR.Name = "ASR";
            this.ASR.Width = 125;
            // 
            // Total_Descuento
            // 
            this.Total_Descuento.HeaderText = "Total Descuento";
            this.Total_Descuento.MinimumWidth = 6;
            this.Total_Descuento.Name = "Total_Descuento";
            this.Total_Descuento.Width = 125;
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.MinimumWidth = 6;
            this.AFP.Name = "AFP";
            this.AFP.Width = 125;
            // 
            // Sueldo_Neto
            // 
            this.Sueldo_Neto.HeaderText = "Sueldo Neto";
            this.Sueldo_Neto.MinimumWidth = 6;
            this.Sueldo_Neto.Name = "Sueldo_Neto";
            this.Sueldo_Neto.Width = 125;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(185, 36);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(125, 27);
            this.txtSueldo.TabIndex = 1;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sueldo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(563, 344);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn ASR;
        private DataGridViewTextBoxColumn Total_Descuento;
        private DataGridViewTextBoxColumn AFP;
        private DataGridViewTextBoxColumn Sueldo_Neto;
        private TextBox txtSueldo;
        private Label label1;
        private Button btnCalcular;
    }
}