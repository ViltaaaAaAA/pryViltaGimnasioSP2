namespace pryViltaGimnasioSP2
{
    partial class FrmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcion));
            txtnombre = new TextBox();
            chkestudiante = new CheckBox();
            cboplan = new ComboBox();
            txtedad = new TextBox();
            lblnombre = new Label();
            grpdatospersonales = new GroupBox();
            lbledad = new Label();
            groupBox1 = new GroupBox();
            chkcasillero = new CheckBox();
            txtmeses = new TextBox();
            cboturno = new ComboBox();
            label1 = new Label();
            lblmeses = new Label();
            lblplan = new Label();
            groupBox2 = new GroupBox();
            rbtefectivo = new RadioButton();
            rbttarjeta = new RadioButton();
            cbocuotas = new ComboBox();
            label2 = new Label();
            btncalcular = new Button();
            btnLimpiar = new Button();
            grpdatospersonales.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(75, 22);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(179, 23);
            txtnombre.TabIndex = 0;
            // 
            // chkestudiante
            // 
            chkestudiante.AutoSize = true;
            chkestudiante.Location = new Point(18, 64);
            chkestudiante.Name = "chkestudiante";
            chkestudiante.Size = new Size(81, 19);
            chkestudiante.TabIndex = 2;
            chkestudiante.Text = "Estudiante";
            chkestudiante.UseVisualStyleBackColor = true;
            // 
            // cboplan
            // 
            cboplan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboplan.FormattingEnabled = true;
            cboplan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboplan.Location = new Point(54, 21);
            cboplan.Name = "cboplan";
            cboplan.Size = new Size(121, 23);
            cboplan.TabIndex = 4;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(351, 22);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(52, 23);
            txtedad.TabIndex = 6;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(18, 25);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 12;
            lblnombre.Text = "Nombre";
            // 
            // grpdatospersonales
            // 
            grpdatospersonales.Controls.Add(lbledad);
            grpdatospersonales.Controls.Add(lblnombre);
            grpdatospersonales.Controls.Add(txtnombre);
            grpdatospersonales.Controls.Add(chkestudiante);
            grpdatospersonales.Controls.Add(txtedad);
            grpdatospersonales.Location = new Point(24, 12);
            grpdatospersonales.Name = "grpdatospersonales";
            grpdatospersonales.Size = new Size(434, 100);
            grpdatospersonales.TabIndex = 13;
            grpdatospersonales.TabStop = false;
            grpdatospersonales.Text = "Datos Personales";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(312, 25);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 13;
            lbledad.Text = "Edad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkcasillero);
            groupBox1.Controls.Add(txtmeses);
            groupBox1.Controls.Add(cboturno);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblmeses);
            groupBox1.Controls.Add(lblplan);
            groupBox1.Controls.Add(cboplan);
            groupBox1.Location = new Point(24, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plan ";
            // 
            // chkcasillero
            // 
            chkcasillero.AutoSize = true;
            chkcasillero.Location = new Point(258, 60);
            chkcasillero.Name = "chkcasillero";
            chkcasillero.Size = new Size(115, 19);
            chkcasillero.TabIndex = 14;
            chkcasillero.Text = "Casillero ($3.000)";
            chkcasillero.UseVisualStyleBackColor = true;
            // 
            // txtmeses
            // 
            txtmeses.Location = new Point(54, 56);
            txtmeses.Name = "txtmeses";
            txtmeses.Size = new Size(65, 23);
            txtmeses.TabIndex = 14;
            // 
            // cboturno
            // 
            cboturno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboturno.FormattingEnabled = true;
            cboturno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboturno.Location = new Point(303, 21);
            cboturno.Name = "cboturno";
            cboturno.Size = new Size(121, 23);
            cboturno.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 17;
            label1.Text = "Turno";
            // 
            // lblmeses
            // 
            lblmeses.AutoSize = true;
            lblmeses.Location = new Point(8, 59);
            lblmeses.Name = "lblmeses";
            lblmeses.Size = new Size(40, 15);
            lblmeses.TabIndex = 15;
            lblmeses.Text = "Meses";
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(8, 24);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(30, 15);
            lblplan.TabIndex = 14;
            lblplan.Text = "Plan";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtefectivo);
            groupBox2.Controls.Add(rbttarjeta);
            groupBox2.Controls.Add(cbocuotas);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(24, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 87);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Forma de Pago";
            // 
            // rbtefectivo
            // 
            rbtefectivo.AutoSize = true;
            rbtefectivo.Location = new Point(8, 27);
            rbtefectivo.Name = "rbtefectivo";
            rbtefectivo.Size = new Size(67, 19);
            rbtefectivo.TabIndex = 23;
            rbtefectivo.TabStop = true;
            rbtefectivo.Text = "Efectivo";
            rbtefectivo.UseVisualStyleBackColor = true;
            // 
            // rbttarjeta
            // 
            rbttarjeta.AutoSize = true;
            rbttarjeta.Location = new Point(166, 27);
            rbttarjeta.Name = "rbttarjeta";
            rbttarjeta.Size = new Size(60, 19);
            rbttarjeta.TabIndex = 22;
            rbttarjeta.TabStop = true;
            rbttarjeta.Text = "Tarjeta";
            rbttarjeta.UseVisualStyleBackColor = true;
            // 
            // cbocuotas
            // 
            cbocuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocuotas.FormattingEnabled = true;
            cbocuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cbocuotas.Location = new Point(303, 26);
            cbocuotas.Name = "cbocuotas";
            cbocuotas.Size = new Size(100, 23);
            cbocuotas.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 29);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 17;
            label2.Text = "Cuotas";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(294, 341);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 22;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(383, 341);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 375);
            Controls.Add(btncalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpdatospersonales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FrmInscripcion_Load;
            grpdatospersonales.ResumeLayout(false);
            grpdatospersonales.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtnombre;
        private CheckBox chkestudiante;
        private ComboBox cboplan;
        private TextBox txtedad;
        private Label lblnombre;
        private GroupBox grpdatospersonales;
        private Label lbledad;
        private GroupBox groupBox1;
        private Label lblmeses;
        private Label lblplan;
        private ComboBox cboturno;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cbocuotas;
        private Label label2;
        private TextBox txtmeses;
        private Button btncalcular;
        private Button btnLimpiar;
        private CheckBox chkcasillero;
        private RadioButton rbtefectivo;
        private RadioButton rbttarjeta;
    }
}
