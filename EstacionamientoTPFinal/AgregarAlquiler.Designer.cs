namespace EstacionamientoTPFinal
{
    partial class AgregarAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAlquiler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnumeroCochera = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoAlquiler = new System.Windows.Forms.Label();
            this.radioButtonHora = new System.Windows.Forms.RadioButton();
            this.radioButtonMes = new System.Windows.Forms.RadioButton();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.comboBoxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.maskedTextBoxPatente = new System.Windows.Forms.MaskedTextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.lblCantidadMeses = new System.Windows.Forms.Label();
            this.numericUpDownCantMeses = new System.Windows.Forms.NumericUpDown();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.lblImporte = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.textBoxVencimiento = new System.Windows.Forms.TextBox();
            this.btnDesocupar = new System.Windows.Forms.Button();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantMeses)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.lblnumeroCochera);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblnumeroCochera
            // 
            this.lblnumeroCochera.AutoSize = true;
            this.lblnumeroCochera.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroCochera.ForeColor = System.Drawing.Color.Snow;
            this.lblnumeroCochera.Location = new System.Drawing.Point(319, 6);
            this.lblnumeroCochera.Name = "lblnumeroCochera";
            this.lblnumeroCochera.Size = new System.Drawing.Size(39, 42);
            this.lblnumeroCochera.TabIndex = 3;
            this.lblnumeroCochera.Text = "0";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(484, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 41);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(526, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 41);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 56);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Alquiler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoAlquiler
            // 
            this.lblTipoAlquiler.AutoSize = true;
            this.lblTipoAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAlquiler.Location = new System.Drawing.Point(170, 73);
            this.lblTipoAlquiler.Name = "lblTipoAlquiler";
            this.lblTipoAlquiler.Size = new System.Drawing.Size(244, 24);
            this.lblTipoAlquiler.TabIndex = 1;
            this.lblTipoAlquiler.Text = "Seleccione Tipo de Alquiler";
            // 
            // radioButtonHora
            // 
            this.radioButtonHora.AutoSize = true;
            this.radioButtonHora.Checked = true;
            this.radioButtonHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHora.Location = new System.Drawing.Point(174, 109);
            this.radioButtonHora.Name = "radioButtonHora";
            this.radioButtonHora.Size = new System.Drawing.Size(62, 24);
            this.radioButtonHora.TabIndex = 2;
            this.radioButtonHora.TabStop = true;
            this.radioButtonHora.Text = "Hora";
            this.radioButtonHora.UseVisualStyleBackColor = true;
            this.radioButtonHora.CheckedChanged += new System.EventHandler(this.radioButtonHora_CheckedChanged);
            this.radioButtonHora.Click += new System.EventHandler(this.radioButtonHora_Click);
            // 
            // radioButtonMes
            // 
            this.radioButtonMes.AutoSize = true;
            this.radioButtonMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMes.Location = new System.Drawing.Point(365, 109);
            this.radioButtonMes.Name = "radioButtonMes";
            this.radioButtonMes.Size = new System.Drawing.Size(57, 24);
            this.radioButtonMes.TabIndex = 3;
            this.radioButtonMes.Text = "Mes";
            this.radioButtonMes.UseVisualStyleBackColor = true;
            this.radioButtonMes.CheckedChanged += new System.EventHandler(this.radioButtonMes_CheckedChanged);
            this.radioButtonMes.Click += new System.EventHandler(this.radioButtonMes_Click);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(13, 165);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(130, 20);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 561;
            this.lineShape1.Y1 = 142;
            this.lineShape1.Y2 = 142;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(564, 530);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -5;
            this.lineShape3.X2 = 557;
            this.lineShape3.Y1 = 94;
            this.lineShape3.Y2 = 94;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -1;
            this.lineShape2.X2 = 561;
            this.lineShape2.Y1 = 246;
            this.lineShape2.Y2 = 246;
            // 
            // comboBoxTipoVehiculo
            // 
            this.comboBoxTipoVehiculo.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoVehiculo.FormattingEnabled = true;
            this.comboBoxTipoVehiculo.Items.AddRange(new object[] {
            "Moto",
            "Auto",
            "Camioneta"});
            this.comboBoxTipoVehiculo.Location = new System.Drawing.Point(174, 165);
            this.comboBoxTipoVehiculo.Name = "comboBoxTipoVehiculo";
            this.comboBoxTipoVehiculo.Size = new System.Drawing.Size(123, 21);
            this.comboBoxTipoVehiculo.TabIndex = 6;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(13, 206);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(69, 20);
            this.lblPatente.TabIndex = 7;
            this.lblPatente.Text = "Patente:";
            // 
            // maskedTextBoxPatente
            // 
            this.maskedTextBoxPatente.Location = new System.Drawing.Point(174, 209);
            this.maskedTextBoxPatente.Mask = "LLL000";
            this.maskedTextBoxPatente.Name = "maskedTextBoxPatente";
            this.maskedTextBoxPatente.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxPatente.TabIndex = 10;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(322, 165);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(322, 206);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 20);
            this.lblModelo.TabIndex = 12;
            this.lblModelo.Text = "Modelo:";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Audi ",
            "BMW ",
            "Chevrolet",
            "Citroën",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "MINI",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.comboBoxMarca.Location = new System.Drawing.Point(443, 165);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(109, 21);
            this.comboBoxMarca.TabIndex = 13;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(443, 209);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(109, 20);
            this.textBoxModelo.TabIndex = 14;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(13, 265);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(56, 20);
            this.lblTitular.TabIndex = 15;
            this.lblTitular.Text = "Titular:";
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.Location = new System.Drawing.Point(174, 265);
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitular.TabIndex = 16;
            // 
            // lblCantidadMeses
            // 
            this.lblCantidadMeses.AutoSize = true;
            this.lblCantidadMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMeses.Location = new System.Drawing.Point(322, 262);
            this.lblCantidadMeses.Name = "lblCantidadMeses";
            this.lblCantidadMeses.Size = new System.Drawing.Size(150, 20);
            this.lblCantidadMeses.TabIndex = 17;
            this.lblCantidadMeses.Text = "Cantidad de meses:";
            // 
            // numericUpDownCantMeses
            // 
            this.numericUpDownCantMeses.Location = new System.Drawing.Point(507, 265);
            this.numericUpDownCantMeses.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownCantMeses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantMeses.Name = "numericUpDownCantMeses";
            this.numericUpDownCantMeses.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownCantMeses.TabIndex = 18;
            this.numericUpDownCantMeses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantMeses.ValueChanged += new System.EventHandler(this.numericUpDownCantMeses_ValueChanged);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.btnAlquilar.FlatAppearance.BorderSize = 0;
            this.btnAlquilar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAlquilar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilar.ForeColor = System.Drawing.Color.Black;
            this.btnAlquilar.Location = new System.Drawing.Point(36, 466);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(150, 40);
            this.btnAlquilar.TabIndex = 19;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(14, 307);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(68, 20);
            this.lblImporte.TabIndex = 20;
            this.lblImporte.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Location = new System.Drawing.Point(174, 308);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.ReadOnly = true;
            this.textBoxImporte.Size = new System.Drawing.Size(121, 20);
            this.textBoxImporte.TabIndex = 21;
            this.textBoxImporte.TextChanged += new System.EventHandler(this.textBoxImporte_TextChanged);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(322, 307);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(101, 20);
            this.lblVencimiento.TabIndex = 22;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // textBoxVencimiento
            // 
            this.textBoxVencimiento.Location = new System.Drawing.Point(443, 307);
            this.textBoxVencimiento.Name = "textBoxVencimiento";
            this.textBoxVencimiento.ReadOnly = true;
            this.textBoxVencimiento.Size = new System.Drawing.Size(115, 20);
            this.textBoxVencimiento.TabIndex = 23;
            this.textBoxVencimiento.TextChanged += new System.EventHandler(this.textBoxVencimiento_TextChanged);
            // 
            // btnDesocupar
            // 
            this.btnDesocupar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.btnDesocupar.FlatAppearance.BorderSize = 0;
            this.btnDesocupar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDesocupar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesocupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesocupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesocupar.ForeColor = System.Drawing.Color.Black;
            this.btnDesocupar.Location = new System.Drawing.Point(381, 466);
            this.btnDesocupar.Name = "btnDesocupar";
            this.btnDesocupar.Size = new System.Drawing.Size(150, 40);
            this.btnDesocupar.TabIndex = 24;
            this.btnDesocupar.Text = "Desocupar";
            this.btnDesocupar.UseVisualStyleBackColor = false;
            this.btnDesocupar.Click += new System.EventHandler(this.btnDesocupar_Click);
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.btnRenovar.FlatAppearance.BorderSize = 0;
            this.btnRenovar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRenovar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovar.ForeColor = System.Drawing.Color.Black;
            this.btnRenovar.Location = new System.Drawing.Point(208, 466);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(150, 40);
            this.btnRenovar.TabIndex = 25;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Visible = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tarifas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mensual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(94, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "$1500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(323, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(377, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Moto: $40";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(377, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Auto: $80";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(377, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Camioneta: $120";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(0, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 93);
            this.panel3.TabIndex = 33;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(568, 93);
            this.shapeContainer2.TabIndex = 33;
            this.shapeContainer2.TabStop = false;
            // 
            // AgregarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnDesocupar);
            this.Controls.Add(this.textBoxVencimiento);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.numericUpDownCantMeses);
            this.Controls.Add(this.lblCantidadMeses);
            this.Controls.Add(this.textBoxTitular);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.maskedTextBoxPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.comboBoxTipoVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.radioButtonMes);
            this.Controls.Add(this.radioButtonHora);
            this.Controls.Add(this.lblTipoAlquiler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAlquiler";
            this.Text = "AgregarAlquiler";
            this.Load += new System.EventHandler(this.AgregarAlquiler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantMeses)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblTipoAlquiler;
        private System.Windows.Forms.RadioButton radioButtonHora;
        private System.Windows.Forms.RadioButton radioButtonMes;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox comboBoxTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPatente;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.Label lblCantidadMeses;
        private System.Windows.Forms.NumericUpDown numericUpDownCantMeses;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox textBoxVencimiento;
        private System.Windows.Forms.Button btnDesocupar;
        private System.Windows.Forms.Label lblnumeroCochera;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}