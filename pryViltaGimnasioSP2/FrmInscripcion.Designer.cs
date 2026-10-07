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
            txtxnombre = new TextBox();
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
            btmcalcular = new Button();
            btmLimpiar = new Button();
            grpdatospersonales.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtxnombre
            // 
            txtxnombre.Location = new Point(86, 29);
            txtxnombre.Margin = new Padding(3, 4, 3, 4);
            txtxnombre.Name = "txtxnombre";
            txtxnombre.Size = new Size(204, 27);
            txtxnombre.TabIndex = 0;
            // 
            // chkestudiante
            // 
            chkestudiante.AutoSize = true;
            chkestudiante.Location = new Point(21, 85);
            chkestudiante.Margin = new Padding(3, 4, 3, 4);
            chkestudiante.Name = "chkestudiante";
            chkestudiante.Size = new Size(100, 24);
            chkestudiante.TabIndex = 2;
            chkestudiante.Text = "Estudiante";
            chkestudiante.UseVisualStyleBackColor = true;
            // 
            // cboplan
            // 
            cboplan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboplan.FormattingEnabled = true;
            cboplan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboplan.Location = new Point(62, 28);
            cboplan.Margin = new Padding(3, 4, 3, 4);
            cboplan.Name = "cboplan";
            cboplan.Size = new Size(138, 28);
            cboplan.TabIndex = 4;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(450, 29);
            txtedad.Margin = new Padding(3, 4, 3, 4);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(59, 27);
            txtedad.TabIndex = 6;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(21, 33);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(64, 20);
            lblnombre.TabIndex = 12;
            lblnombre.Text = "Nombre";
            // 
            // grpdatospersonales
            // 
            grpdatospersonales.Controls.Add(lbledad);
            grpdatospersonales.Controls.Add(lblnombre);
            grpdatospersonales.Controls.Add(txtxnombre);
            grpdatospersonales.Controls.Add(chkestudiante);
            grpdatospersonales.Controls.Add(txtedad);
            grpdatospersonales.Location = new Point(27, 16);
            grpdatospersonales.Margin = new Padding(3, 4, 3, 4);
            grpdatospersonales.Name = "grpdatospersonales";
            grpdatospersonales.Padding = new Padding(3, 4, 3, 4);
            grpdatospersonales.Size = new Size(531, 133);
            grpdatospersonales.TabIndex = 13;
            grpdatospersonales.TabStop = false;
            grpdatospersonales.Text = "Datos Personales";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(385, 33);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(43, 20);
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
            groupBox1.Location = new Point(27, 172);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(531, 133);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plan ";
            // 
            // chkcasillero
            // 
            chkcasillero.AutoSize = true;
            chkcasillero.Location = new Point(295, 80);
            chkcasillero.Margin = new Padding(3, 4, 3, 4);
            chkcasillero.Name = "chkcasillero";
            chkcasillero.Size = new Size(145, 24);
            chkcasillero.TabIndex = 14;
            chkcasillero.Text = "Casillero ($3.000)";
            chkcasillero.UseVisualStyleBackColor = true;
            // 
            // txtmeses
            // 
            txtmeses.Location = new Point(62, 75);
            txtmeses.Margin = new Padding(3, 4, 3, 4);
            txtmeses.Name = "txtmeses";
            txtmeses.Size = new Size(74, 27);
            txtmeses.TabIndex = 14;
            // 
            // cboturno
            // 
            cboturno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboturno.FormattingEnabled = true;
            cboturno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboturno.Location = new Point(346, 28);
            cboturno.Margin = new Padding(3, 4, 3, 4);
            cboturno.Name = "cboturno";
            cboturno.Size = new Size(138, 28);
            cboturno.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 32);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 17;
            label1.Text = "Turno";
            // 
            // lblmeses
            // 
            lblmeses.AutoSize = true;
            lblmeses.Location = new Point(9, 79);
            lblmeses.Name = "lblmeses";
            lblmeses.Size = new Size(50, 20);
            lblmeses.TabIndex = 15;
            lblmeses.Text = "Meses";
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(9, 32);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(37, 20);
            lblplan.TabIndex = 14;
            lblplan.Text = "Plan";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtefectivo);
            groupBox2.Controls.Add(rbttarjeta);
            groupBox2.Controls.Add(cbocuotas);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(27, 328);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(531, 116);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Forma de Pago";
            // 
            // rbtefectivo
            // 
            rbtefectivo.AutoSize = true;
            rbtefectivo.Location = new Point(9, 36);
            rbtefectivo.Margin = new Padding(3, 4, 3, 4);
            rbtefectivo.Name = "rbtefectivo";
            rbtefectivo.Size = new Size(83, 24);
            rbtefectivo.TabIndex = 23;
            rbtefectivo.TabStop = true;
            rbtefectivo.Text = "Efectivo";
            rbtefectivo.UseVisualStyleBackColor = true;
            // 
            // rbttarjeta
            // 
            rbttarjeta.AutoSize = true;
            rbttarjeta.Location = new Point(190, 36);
            rbttarjeta.Margin = new Padding(3, 4, 3, 4);
            rbttarjeta.Name = "rbttarjeta";
            rbttarjeta.Size = new Size(74, 24);
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
            cbocuotas.Location = new Point(346, 35);
            cbocuotas.Margin = new Padding(3, 4, 3, 4);
            cbocuotas.Name = "cbocuotas";
            cbocuotas.Size = new Size(138, 28);
            cbocuotas.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 39);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 17;
            label2.Text = "Cuotas";
            // 
            // btmcalcular
            // 
            btmcalcular.Location = new Point(368, 455);
            btmcalcular.Margin = new Padding(3, 4, 3, 4);
            btmcalcular.Name = "btmcalcular";
            btmcalcular.Size = new Size(86, 31);
            btmcalcular.TabIndex = 22;
            btmcalcular.Text = "Calcular";
            btmcalcular.UseVisualStyleBackColor = true;
            // 
            // btmLimpiar
            // 
            btmLimpiar.Location = new Point(473, 455);
            btmLimpiar.Margin = new Padding(3, 4, 3, 4);
            btmLimpiar.Name = "btmLimpiar";
            btmLimpiar.Size = new Size(86, 31);
            btmLimpiar.TabIndex = 20;
            btmLimpiar.Text = "Limpiar";
            btmLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 501);
            Controls.Add(btmcalcular);
            Controls.Add(btmLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpdatospersonales);
            Margin = new Padding(3, 4, 3, 4);
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

        private TextBox txtxnombre;
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
        private Button btmcalcular;
        private Button btmLimpiar;
        private CheckBox chkcasillero;
        private RadioButton rbtefectivo;
        private RadioButton rbttarjeta;
    }
}
