namespace MiPrimerForm.Formularios
{
    partial class FrmProducto
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
            this.tabRegistro = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.CBIva = new System.Windows.Forms.CheckBox();
            this.tabRegistro.SuspendLayout();
            this.tabGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.tabGeneral);
            this.tabRegistro.Controls.Add(this.tabGrid);
            this.tabRegistro.Location = new System.Drawing.Point(12, 12);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.SelectedIndex = 0;
            this.tabRegistro.Size = new System.Drawing.Size(776, 426);
            this.tabRegistro.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(768, 397);
            this.tabGeneral.TabIndex = 2;
            this.tabGeneral.Text = "Datos de producto";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.CBIva);
            this.tabGrid.Controls.Add(this.TbPrecio);
            this.tabGrid.Controls.Add(this.label3);
            this.tabGrid.Controls.Add(this.TbNombre);
            this.tabGrid.Controls.Add(this.TbCodigo);
            this.tabGrid.Controls.Add(this.label2);
            this.tabGrid.Controls.Add(this.label1);
            this.tabGrid.Location = new System.Drawing.Point(4, 25);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(768, 397);
            this.tabGrid.TabIndex = 3;
            this.tabGrid.Text = "Registros guardados";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // TbCodigo
            // 
            this.TbCodigo.Location = new System.Drawing.Point(93, 23);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(100, 22);
            this.TbCodigo.TabIndex = 2;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(93, 64);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(239, 22);
            this.TbNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(93, 114);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(100, 22);
            this.TbPrecio.TabIndex = 5;
            // 
            // CBIva
            // 
            this.CBIva.AutoSize = true;
            this.CBIva.Location = new System.Drawing.Point(73, 165);
            this.CBIva.Name = "CBIva";
            this.CBIva.Size = new System.Drawing.Size(91, 20);
            this.CBIva.TabIndex = 6;
            this.CBIva.Text = "Aplica IVA";
            this.CBIva.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabRegistro);
            this.Name = "FrmProducto";
            this.Text = "Form1";
            this.tabRegistro.ResumeLayout(false);
            this.tabGrid.ResumeLayout(false);
            this.tabGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistro;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.CheckBox CBIva;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}