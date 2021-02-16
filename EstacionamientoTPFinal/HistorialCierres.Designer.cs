namespace EstacionamientoTPFinal
{
    partial class HistorialCierres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCierres));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCierres = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSourceCierre = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotalCierres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxIngresosCierres = new System.Windows.Forms.ListBox();
            this.listBoxEgresosCierres = new System.Windows.Forms.ListBox();
            this.bindingSourceIngresosCierres = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEgresosCierres = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIngresosCierres = new System.Windows.Forms.TextBox();
            this.textBoxEgresosCierres = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngresosCierres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEgresosCierres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 56);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1022, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 56);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial de Cierres";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1063, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(78, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cierres";
            // 
            // listBoxCierres
            // 
            this.listBoxCierres.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxCierres.FormattingEnabled = true;
            this.listBoxCierres.HorizontalScrollbar = true;
            this.listBoxCierres.Location = new System.Drawing.Point(37, 128);
            this.listBoxCierres.Name = "listBoxCierres";
            this.listBoxCierres.Size = new System.Drawing.Size(184, 329);
            this.listBoxCierres.TabIndex = 3;
            this.listBoxCierres.SelectedValueChanged += new System.EventHandler(this.listBoxCierres_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(405, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(31, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Cierre:";
            // 
            // textBoxTotalCierres
            // 
            this.textBoxTotalCierres.Location = new System.Drawing.Point(56, 540);
            this.textBoxTotalCierres.Name = "textBoxTotalCierres";
            this.textBoxTotalCierres.ReadOnly = true;
            this.textBoxTotalCierres.Size = new System.Drawing.Size(141, 20);
            this.textBoxTotalCierres.TabIndex = 7;
            this.textBoxTotalCierres.TextChanged += new System.EventHandler(this.textBoxTotalCierres_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(824, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Egresos";
            // 
            // listBoxIngresosCierres
            // 
            this.listBoxIngresosCierres.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxIngresosCierres.FormattingEnabled = true;
            this.listBoxIngresosCierres.HorizontalExtent = 750;
            this.listBoxIngresosCierres.HorizontalScrollbar = true;
            this.listBoxIngresosCierres.Location = new System.Drawing.Point(254, 128);
            this.listBoxIngresosCierres.Name = "listBoxIngresosCierres";
            this.listBoxIngresosCierres.Size = new System.Drawing.Size(403, 329);
            this.listBoxIngresosCierres.TabIndex = 9;
            // 
            // listBoxEgresosCierres
            // 
            this.listBoxEgresosCierres.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxEgresosCierres.FormattingEnabled = true;
            this.listBoxEgresosCierres.HorizontalExtent = 750;
            this.listBoxEgresosCierres.HorizontalScrollbar = true;
            this.listBoxEgresosCierres.Location = new System.Drawing.Point(677, 128);
            this.listBoxEgresosCierres.Name = "listBoxEgresosCierres";
            this.listBoxEgresosCierres.Size = new System.Drawing.Size(403, 329);
            this.listBoxEgresosCierres.TabIndex = 10;
            this.listBoxEgresosCierres.SelectedIndexChanged += new System.EventHandler(this.listBoxEgresosCierres_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(352, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Ingresos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(787, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Egresos:";
            // 
            // textBoxIngresosCierres
            // 
            this.textBoxIngresosCierres.Location = new System.Drawing.Point(398, 540);
            this.textBoxIngresosCierres.Name = "textBoxIngresosCierres";
            this.textBoxIngresosCierres.ReadOnly = true;
            this.textBoxIngresosCierres.Size = new System.Drawing.Size(141, 20);
            this.textBoxIngresosCierres.TabIndex = 13;
            // 
            // textBoxEgresosCierres
            // 
            this.textBoxEgresosCierres.Location = new System.Drawing.Point(829, 540);
            this.textBoxEgresosCierres.Name = "textBoxEgresosCierres";
            this.textBoxEgresosCierres.ReadOnly = true;
            this.textBoxEgresosCierres.Size = new System.Drawing.Size(141, 20);
            this.textBoxEgresosCierres.TabIndex = 14;
            // 
            // HistorialCierres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 600);
            this.Controls.Add(this.textBoxEgresosCierres);
            this.Controls.Add(this.textBoxIngresosCierres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxEgresosCierres);
            this.Controls.Add(this.listBoxIngresosCierres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotalCierres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCierres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialCierres";
            this.Text = "HistorialCierres";
            this.Load += new System.EventHandler(this.HistorialCierres_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceIngresosCierres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEgresosCierres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCierres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSourceCierre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotalCierres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxIngresosCierres;
        private System.Windows.Forms.ListBox listBoxEgresosCierres;
        private System.Windows.Forms.BindingSource bindingSourceIngresosCierres;
        private System.Windows.Forms.BindingSource bindingSourceEgresosCierres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIngresosCierres;
        private System.Windows.Forms.TextBox textBoxEgresosCierres;
    }
}