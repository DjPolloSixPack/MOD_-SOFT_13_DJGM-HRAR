namespace IntegradorBB
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.btnISIni = new System.Windows.Forms.Button();
            this.txtISUsu = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISCon = new System.Windows.Forms.TextBox();
            this.btnISSal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnISIni
            // 
            this.btnISIni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnISIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnISIni.Location = new System.Drawing.Point(12, 271);
            this.btnISIni.Name = "btnISIni";
            this.btnISIni.Size = new System.Drawing.Size(246, 40);
            this.btnISIni.TabIndex = 0;
            this.btnISIni.Text = "Iniciar Sesión";
            this.btnISIni.UseVisualStyleBackColor = true;
            this.btnISIni.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtISUsu
            // 
            this.txtISUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISUsu.Location = new System.Drawing.Point(12, 150);
            this.txtISUsu.Name = "txtISUsu";
            this.txtISUsu.Size = new System.Drawing.Size(246, 26);
            this.txtISUsu.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(77, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtISCon
            // 
            this.txtISCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISCon.Location = new System.Drawing.Point(12, 225);
            this.txtISCon.Name = "txtISCon";
            this.txtISCon.PasswordChar = '*';
            this.txtISCon.Size = new System.Drawing.Size(246, 26);
            this.txtISCon.TabIndex = 6;
            this.txtISCon.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnISSal
            // 
            this.btnISSal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnISSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnISSal.Location = new System.Drawing.Point(97, 317);
            this.btnISSal.Name = "btnISSal";
            this.btnISSal.Size = new System.Drawing.Size(75, 23);
            this.btnISSal.TabIndex = 8;
            this.btnISSal.Text = "Salir";
            this.btnISSal.UseVisualStyleBackColor = true;
            this.btnISSal.Click += new System.EventHandler(this.btnISSal_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(270, 344);
            this.Controls.Add(this.btnISSal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtISUsu);
            this.Controls.Add(this.btnISIni);
            this.Name = "InicioSesion";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnISIni;
        private System.Windows.Forms.TextBox txtISUsu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISCon;
        private System.Windows.Forms.Button btnISSal;
    }
}

