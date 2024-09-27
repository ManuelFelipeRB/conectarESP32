namespace conectarESP32
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_puerto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_conectaIP = new System.Windows.Forms.Button();
            this.comboBox_ip = new System.Windows.Forms.ComboBox();
            this.desconexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_puerto
            // 
            this.comboBox_puerto.FormattingEnabled = true;
            this.comboBox_puerto.Items.AddRange(new object[] {
            "80",
            "8013",
            "8080"});
            this.comboBox_puerto.Location = new System.Drawing.Point(37, 139);
            this.comboBox_puerto.Name = "comboBox_puerto";
            this.comboBox_puerto.Size = new System.Drawing.Size(138, 21);
            this.comboBox_puerto.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Seleccione direccion IP y Puerto";
            // 
            // but_conectaIP
            // 
            this.but_conectaIP.Location = new System.Drawing.Point(233, 9);
            this.but_conectaIP.Name = "but_conectaIP";
            this.but_conectaIP.Size = new System.Drawing.Size(90, 45);
            this.but_conectaIP.TabIndex = 25;
            this.but_conectaIP.Text = "Conectar";
            this.but_conectaIP.UseVisualStyleBackColor = true;
            this.but_conectaIP.Click += new System.EventHandler(this.but_conectaIP_Click);
            // 
            // comboBox_ip
            // 
            this.comboBox_ip.FormattingEnabled = true;
            this.comboBox_ip.Items.AddRange(new object[] {
            "192.168.164.1"});
            this.comboBox_ip.Location = new System.Drawing.Point(37, 109);
            this.comboBox_ip.Name = "comboBox_ip";
            this.comboBox_ip.Size = new System.Drawing.Size(138, 21);
            this.comboBox_ip.TabIndex = 24;
            // 
            // desconexion
            // 
            this.desconexion.Location = new System.Drawing.Point(233, 65);
            this.desconexion.Name = "desconexion";
            this.desconexion.Size = new System.Drawing.Size(90, 45);
            this.desconexion.TabIndex = 23;
            this.desconexion.Text = "Desconectar";
            this.desconexion.UseVisualStyleBackColor = true;
            this.desconexion.Click += new System.EventHandler(this.desconexion_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Digital", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 66);
            this.label1.TabIndex = 22;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(233, 121);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(90, 45);
            this.button_salir.TabIndex = 21;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.label2.Font = new System.Drawing.Font("Digital", 16F);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "gr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(336, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_puerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_conectaIP);
            this.Controls.Add(this.comboBox_ip);
            this.Controls.Add(this.desconexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_salir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_puerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_conectaIP;
        private System.Windows.Forms.ComboBox comboBox_ip;
        private System.Windows.Forms.Button desconexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Label label2;
    }
}

