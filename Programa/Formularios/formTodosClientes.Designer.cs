namespace Programa.Formularios
{
    partial class formTodosClientes
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
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(12, 135);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(960, 404);
            this.dataGridClientes.TabIndex = 0;
            // 
            // formTodosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 551);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "formTodosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.formTodosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientes;
    }
}