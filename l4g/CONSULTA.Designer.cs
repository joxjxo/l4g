namespace l4g
{
    partial class CONSULTA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_insertar_apmed = new System.Windows.Forms.Button();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdosisaplicada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpaplicacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ddtmedi = new System.Windows.Forms.DataGridView();
            this.cbmediapi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_citaid = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CBBDOCTORES = new System.Windows.Forms.ComboBox();
            this.CBBEMPLEADOS = new System.Windows.Forms.ComboBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdiag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddtmedi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(187)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.btn_insertar_apmed);
            this.panel1.Controls.Add(this.txtmotivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtdosisaplicada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpaplicacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ddtmedi);
            this.panel1.Controls.Add(this.cbmediapi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(460, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 741);
            this.panel1.TabIndex = 0;
            // 
            // btn_insertar_apmed
            // 
            this.btn_insertar_apmed.Location = new System.Drawing.Point(302, 483);
            this.btn_insertar_apmed.Name = "btn_insertar_apmed";
            this.btn_insertar_apmed.Size = new System.Drawing.Size(75, 23);
            this.btn_insertar_apmed.TabIndex = 9;
            this.btn_insertar_apmed.Text = "Insertar";
            this.btn_insertar_apmed.UseVisualStyleBackColor = true;
            this.btn_insertar_apmed.Click += new System.EventHandler(this.btn_insertar_apmed_Click);
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(20, 353);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(200, 20);
            this.txtmotivo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "MOTIVO";
            // 
            // txtdosisaplicada
            // 
            this.txtdosisaplicada.Location = new System.Drawing.Point(20, 432);
            this.txtdosisaplicada.Name = "txtdosisaplicada";
            this.txtdosisaplicada.Size = new System.Drawing.Size(100, 20);
            this.txtdosisaplicada.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DOSIS APLICADA";
            // 
            // dtpaplicacion
            // 
            this.dtpaplicacion.Location = new System.Drawing.Point(20, 263);
            this.dtpaplicacion.Name = "dtpaplicacion";
            this.dtpaplicacion.Size = new System.Drawing.Size(200, 20);
            this.dtpaplicacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA DE APLICACION";
            // 
            // ddtmedi
            // 
            this.ddtmedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddtmedi.Location = new System.Drawing.Point(147, 91);
            this.ddtmedi.Name = "ddtmedi";
            this.ddtmedi.Size = new System.Drawing.Size(261, 108);
            this.ddtmedi.TabIndex = 2;
            // 
            // cbmediapi
            // 
            this.cbmediapi.FormattingEnabled = true;
            this.cbmediapi.Location = new System.Drawing.Point(20, 91);
            this.cbmediapi.Name = "cbmediapi";
            this.cbmediapi.Size = new System.Drawing.Size(121, 21);
            this.cbmediapi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEDICAMENTO APLICADO";
            // 
            // cbb_citaid
            // 
            this.cbb_citaid.FormattingEnabled = true;
            this.cbb_citaid.Location = new System.Drawing.Point(259, 54);
            this.cbb_citaid.Name = "cbb_citaid";
            this.cbb_citaid.Size = new System.Drawing.Size(121, 21);
            this.cbb_citaid.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbb_citaid);
            this.panel2.Location = new System.Drawing.Point(-17, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 97);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(256, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID de la cita";
            // 
            // CBBDOCTORES
            // 
            this.CBBDOCTORES.FormattingEnabled = true;
            this.CBBDOCTORES.Location = new System.Drawing.Point(63, 214);
            this.CBBDOCTORES.Name = "CBBDOCTORES";
            this.CBBDOCTORES.Size = new System.Drawing.Size(121, 21);
            this.CBBDOCTORES.TabIndex = 3;
            // 
            // CBBEMPLEADOS
            // 
            this.CBBEMPLEADOS.FormattingEnabled = true;
            this.CBBEMPLEADOS.Location = new System.Drawing.Point(214, 214);
            this.CBBEMPLEADOS.Name = "CBBEMPLEADOS";
            this.CBBEMPLEADOS.Size = new System.Drawing.Size(121, 21);
            this.CBBEMPLEADOS.TabIndex = 4;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(63, 302);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(272, 20);
            this.txtdes.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "id del doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "id del paciente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "descripcion ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "diagnostico";
            // 
            // txtdiag
            // 
            this.txtdiag.Location = new System.Drawing.Point(63, 403);
            this.txtdiag.Name = "txtdiag";
            this.txtdiag.Size = new System.Drawing.Size(272, 20);
            this.txtdiag.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Diagnostico";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "volver al menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CONSULTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 515);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdiag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.CBBEMPLEADOS);
            this.Controls.Add(this.CBBDOCTORES);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CONSULTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddtmedi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ddtmedi;
        private System.Windows.Forms.ComboBox cbmediapi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insertar_apmed;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdosisaplicada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpaplicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_citaid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBBDOCTORES;
        private System.Windows.Forms.ComboBox CBBEMPLEADOS;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}