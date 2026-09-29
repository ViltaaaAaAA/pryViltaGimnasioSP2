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
            textBox2 = new TextBox();
            cb = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkBox2 = new CheckBox();
            txtedad = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            lblnombre = new Label();
            grpdatospersonales = new GroupBox();
            lbledad = new Label();
            groupBox1 = new GroupBox();
            lblplan = new Label();
            comboBox4 = new ComboBox();
            lblmeses = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox5 = new ComboBox();
            grpdatospersonales.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtxnombre
            // 
            txtxnombre.Location = new Point(75, 22);
            txtxnombre.Name = "txtxnombre";
            txtxnombre.Size = new Size(179, 23);
            txtxnombre.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(673, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Location = new Point(18, 64);
            cb.Name = "cb";
            cb.Size = new Size(81, 19);
            cb.TabIndex = 2;
            cb.Text = "Estudiante";
            cb.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(521, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(54, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(99, 386);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(394, 22);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(52, 23);
            txtedad.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(649, 210);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(637, 246);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(622, 415);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(475, 248);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(698, 151);
            button2.Name = "button2";
            button2.Size = new Size(65, 31);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            grpdatospersonales.Controls.Add(txtxnombre);
            grpdatospersonales.Controls.Add(cb);
            grpdatospersonales.Controls.Add(txtedad);
            grpdatospersonales.Location = new Point(24, 12);
            grpdatospersonales.Name = "grpdatospersonales";
            grpdatospersonales.Size = new Size(546, 100);
            grpdatospersonales.TabIndex = 13;
            grpdatospersonales.TabStop = false;
            grpdatospersonales.Text = "Datos Personales";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(337, 25);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 13;
            lbledad.Text = "Edad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblmeses);
            groupBox1.Controls.Add(lblplan);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(24, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plan ";
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(18, 24);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(30, 15);
            lblplan.TabIndex = 14;
            lblplan.Text = "Plan";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(652, 302);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 15;
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
            // textBox1
            // 
            textBox1.Location = new Point(54, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 14;
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
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(303, 21);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox4);
            Controls.Add(checkBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpdatospersonales);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Gimnasio";
            grpdatospersonales.ResumeLayout(false);
            grpdatospersonales.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtxnombre;
        private TextBox textBox2;
        private CheckBox cb;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private CheckBox checkBox2;
        private TextBox txtedad;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
        private Label lblnombre;
        private GroupBox grpdatospersonales;
        private Label lbledad;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label lblmeses;
        private Label lblplan;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label1;
    }
}
