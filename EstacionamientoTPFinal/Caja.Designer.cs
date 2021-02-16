namespace EstacionamientoTPFinal
{
    partial class Caja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxEgresos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.listBoxIngresos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownImporteConcepto = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarEgreso = new System.Windows.Forms.Button();
            this.bindingSourceIngresos = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEgresos = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIngresos = new System.Windows.Forms.TextBox();
            this.textBoxEgresos = new System.Windows.Forms.TextBox();
            this.textBoxTotalCaja = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImporteConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(712, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(753, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 56);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caja";
            // 
            // listBoxEgresos
            // 
            this.listBoxEgresos.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxEgresos.FormattingEnabled = true;
            this.listBoxEgresos.HorizontalScrollbar = true;
            this.listBoxEgresos.Location = new System.Drawing.Point(64, 385);
            this.listBoxEgresos.Name = "listBoxEgresos";
            this.listBoxEgresos.Size = new System.Drawing.Size(702, 95);
            this.listBoxEgresos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(59, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(62, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Egresos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(52, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Realice un Egreso ";
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.btnCerrarCaja.FlatAppearance.BorderSize = 0;
            this.btnCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarCaja.Location = new System.Drawing.Point(329, 598);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(208, 40);
            this.btnCerrarCaja.TabIndex = 20;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // listBoxIngresos
            // 
            this.listBoxIngresos.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxIngresos.FormattingEnabled = true;
            this.listBoxIngresos.HorizontalScrollbar = true;
            this.listBoxIngresos.Location = new System.Drawing.Point(64, 228);
            this.listBoxIngresos.Name = "listBoxIngresos";
            this.listBoxIngresos.Size = new System.Drawing.Size(702, 95);
            this.listBoxIngresos.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(53, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Concepto:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(169, 129);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(100, 20);
            this.txtConcepto.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(334, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Importe:";
            // 
            // numericUpDownImporteConcepto
            // 
            this.numericUpDownImporteConcepto.Location = new System.Drawing.Point(417, 129);
            this.numericUpDownImporteConcepto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownImporteConcepto.Name = "numericUpDownImporteConcepto";
            this.numericUpDownImporteConcepto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownImporteConcepto.TabIndex = 25;
            // 
            // btnGenerarEgreso
            // 
            this.btnGenerarEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.btnGenerarEgreso.FlatAppearance.BorderSize = 0;
            this.btnGenerarEgreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGenerarEgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarEgreso.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarEgreso.Location = new System.Drawing.Point(565, 116);
            this.btnGenerarEgreso.Name = "btnGenerarEgreso";
            this.btnGenerarEgreso.Size = new System.Drawing.Size(174, 33);
            this.btnGenerarEgreso.TabIndex = 26;
            this.btnGenerarEgreso.Text = "Generar Egreso";
            this.btnGenerarEgreso.UseVisualStyleBackColor = false;
            this.btnGenerarEgreso.Click += new System.EventHandler(this.btnGenerarEgreso_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(62, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total Ingresos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(348, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total Egresos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(579, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total Caja:";
            // 
            // textBoxIngresos
            // 
            this.textBoxIngresos.Location = new System.Drawing.Point(83, 544);
            this.textBoxIngresos.Name = "textBoxIngresos";
            this.textBoxIngresos.ReadOnly = true;
            this.textBoxIngresos.Size = new System.Drawing.Size(100, 20);
            this.textBoxIngresos.TabIndex = 30;
            // 
            // textBoxEgresos
            // 
            this.textBoxEgresos.Location = new System.Drawing.Point(372, 544);
            this.textBoxEgresos.Name = "textBoxEgresos";
            this.textBoxEgresos.ReadOnly = true;
            this.textBoxEgresos.Size = new System.Drawing.Size(100, 20);
            this.textBoxEgresos.TabIndex = 31;
            // 
            // textBoxTotalCaja
            // 
            this.textBoxTotalCaja.Location = new System.Drawing.Point(584, 544);
            this.textBoxTotalCaja.Name = "textBoxTotalCaja";
            this.textBoxTotalCaja.ReadOnly = true;
            this.textBoxTotalCaja.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalCaja.TabIndex = 32;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.textBoxTotalCaja);
            this.Controls.Add(this.textBoxEgresos);
            this.Controls.Add(this.textBoxIngresos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxEgresos);
            this.Controls.Add(this.btnGenerarEgreso);
            this.Controls.Add(this.numericUpDownImporteConcepto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxIngresos);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImporteConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEgresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.ListBox listBoxIngresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownImporteConcepto;
        private System.Windows.Forms.Button btnGenerarEgreso;
        private System.Windows.Forms.BindingSource bindingSourceIngresos;
        private System.Windows.Forms.BindingSource bindingSourceEgresos;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIngresos;
        private System.Windows.Forms.TextBox textBoxEgresos;
        private System.Windows.Forms.TextBox textBoxTotalCaja;
    }
}