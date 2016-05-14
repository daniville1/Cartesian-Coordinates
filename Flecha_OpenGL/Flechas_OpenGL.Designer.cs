namespace Flechas_OpenGL
{
    partial class Flechas_OpenGL
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flechas_OpenGL));
            this.gl = new OpenTK.GLControl();
            this.btn_xDer = new System.Windows.Forms.Button();
            this.btn_xIzq = new System.Windows.Forms.Button();
            this.btn_yIzq = new System.Windows.Forms.Button();
            this.btn_yDer = new System.Windows.Forms.Button();
            this.btn_zIzq = new System.Windows.Forms.Button();
            this.btn_zDer = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.lbl_acercaDe = new System.Windows.Forms.Label();
            this.gbox_coordenadas = new System.Windows.Forms.GroupBox();
            this.lbl_valorZ = new System.Windows.Forms.Label();
            this.lbl_valorY = new System.Windows.Forms.Label();
            this.lbl_valorX = new System.Windows.Forms.Label();
            this.lbl_z = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.btn_efecto1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_efecto11 = new System.Windows.Forms.Button();
            this.btn_efecto10 = new System.Windows.Forms.Button();
            this.btn_efecto9 = new System.Windows.Forms.Button();
            this.btn_efecto6 = new System.Windows.Forms.Button();
            this.btn_efecto3 = new System.Windows.Forms.Button();
            this.btn_efecto8 = new System.Windows.Forms.Button();
            this.btn_efecto2 = new System.Windows.Forms.Button();
            this.btn_efecto7 = new System.Windows.Forms.Button();
            this.btn_efecto4 = new System.Windows.Forms.Button();
            this.btn_efecto5 = new System.Windows.Forms.Button();
            this.tmrRedraw = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox_coordenadas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gl
            // 
            this.gl.BackColor = System.Drawing.Color.Black;
            this.gl.Location = new System.Drawing.Point(12, 38);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(731, 381);
            this.gl.TabIndex = 0;
            this.gl.VSync = false;
            this.gl.Load += new System.EventHandler(this.gl_Load);
            this.gl.Paint += new System.Windows.Forms.PaintEventHandler(this.gl_Paint);
            // 
            // btn_xDer
            // 
            this.btn_xDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_xDer.Location = new System.Drawing.Point(93, 425);
            this.btn_xDer.Name = "btn_xDer";
            this.btn_xDer.Size = new System.Drawing.Size(75, 23);
            this.btn_xDer.TabIndex = 4;
            this.btn_xDer.Text = "X =>";
            this.btn_xDer.UseVisualStyleBackColor = false;
            this.btn_xDer.Click += new System.EventHandler(this.btn_xDer_Click);
            // 
            // btn_xIzq
            // 
            this.btn_xIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_xIzq.Location = new System.Drawing.Point(12, 425);
            this.btn_xIzq.Name = "btn_xIzq";
            this.btn_xIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_xIzq.TabIndex = 3;
            this.btn_xIzq.Text = "<= X";
            this.btn_xIzq.UseVisualStyleBackColor = false;
            this.btn_xIzq.Click += new System.EventHandler(this.btn_xIzq_Click);
            // 
            // btn_yIzq
            // 
            this.btn_yIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_yIzq.Location = new System.Drawing.Point(297, 425);
            this.btn_yIzq.Name = "btn_yIzq";
            this.btn_yIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_yIzq.TabIndex = 5;
            this.btn_yIzq.Text = "<= Y";
            this.btn_yIzq.UseVisualStyleBackColor = false;
            this.btn_yIzq.Click += new System.EventHandler(this.btn_yIzq_Click);
            // 
            // btn_yDer
            // 
            this.btn_yDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_yDer.Location = new System.Drawing.Point(378, 425);
            this.btn_yDer.Name = "btn_yDer";
            this.btn_yDer.Size = new System.Drawing.Size(75, 23);
            this.btn_yDer.TabIndex = 6;
            this.btn_yDer.Text = "Y =>";
            this.btn_yDer.UseVisualStyleBackColor = false;
            this.btn_yDer.Click += new System.EventHandler(this.btn_yDer_Click);
            // 
            // btn_zIzq
            // 
            this.btn_zIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_zIzq.Location = new System.Drawing.Point(587, 425);
            this.btn_zIzq.Name = "btn_zIzq";
            this.btn_zIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_zIzq.TabIndex = 7;
            this.btn_zIzq.Text = "<= Z";
            this.btn_zIzq.UseVisualStyleBackColor = false;
            this.btn_zIzq.Click += new System.EventHandler(this.btn_zIzq_Click);
            // 
            // btn_zDer
            // 
            this.btn_zDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_zDer.Location = new System.Drawing.Point(668, 425);
            this.btn_zDer.Name = "btn_zDer";
            this.btn_zDer.Size = new System.Drawing.Size(75, 23);
            this.btn_zDer.TabIndex = 8;
            this.btn_zDer.Text = "Z =>";
            this.btn_zDer.UseVisualStyleBackColor = false;
            this.btn_zDer.Click += new System.EventHandler(this.btn_zDer_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar.Location = new System.Drawing.Point(144, 99);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar.TabIndex = 9;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // lbl_acercaDe
            // 
            this.lbl_acercaDe.AutoSize = true;
            this.lbl_acercaDe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_acercaDe.Location = new System.Drawing.Point(595, 583);
            this.lbl_acercaDe.Name = "lbl_acercaDe";
            this.lbl_acercaDe.Size = new System.Drawing.Size(148, 13);
            this.lbl_acercaDe.TabIndex = 0;
            this.lbl_acercaDe.Text = "por Iván Daniel Villegas Rojas";
            // 
            // gbox_coordenadas
            // 
            this.gbox_coordenadas.BackColor = System.Drawing.Color.Transparent;
            this.gbox_coordenadas.Controls.Add(this.lbl_valorZ);
            this.gbox_coordenadas.Controls.Add(this.lbl_valorY);
            this.gbox_coordenadas.Controls.Add(this.lbl_valorX);
            this.gbox_coordenadas.Controls.Add(this.lbl_z);
            this.gbox_coordenadas.Controls.Add(this.lbl_y);
            this.gbox_coordenadas.Controls.Add(this.lbl_x);
            this.gbox_coordenadas.Controls.Add(this.btn_restaurar);
            this.gbox_coordenadas.Location = new System.Drawing.Point(12, 455);
            this.gbox_coordenadas.Name = "gbox_coordenadas";
            this.gbox_coordenadas.Size = new System.Drawing.Size(360, 125);
            this.gbox_coordenadas.TabIndex = 10;
            this.gbox_coordenadas.TabStop = false;
            this.gbox_coordenadas.Text = "Coordenadas del ojo";
            // 
            // lbl_valorZ
            // 
            this.lbl_valorZ.AutoSize = true;
            this.lbl_valorZ.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valorZ.Location = new System.Drawing.Point(31, 66);
            this.lbl_valorZ.Name = "lbl_valorZ";
            this.lbl_valorZ.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorZ.TabIndex = 0;
            this.lbl_valorZ.Text = "-";
            // 
            // lbl_valorY
            // 
            this.lbl_valorY.AutoSize = true;
            this.lbl_valorY.ForeColor = System.Drawing.Color.Red;
            this.lbl_valorY.Location = new System.Drawing.Point(31, 42);
            this.lbl_valorY.Name = "lbl_valorY";
            this.lbl_valorY.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorY.TabIndex = 0;
            this.lbl_valorY.Text = "-";
            // 
            // lbl_valorX
            // 
            this.lbl_valorX.AutoSize = true;
            this.lbl_valorX.ForeColor = System.Drawing.Color.Orange;
            this.lbl_valorX.Location = new System.Drawing.Point(31, 19);
            this.lbl_valorX.Name = "lbl_valorX";
            this.lbl_valorX.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorX.TabIndex = 0;
            this.lbl_valorX.Text = "-";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.ForeColor = System.Drawing.Color.Blue;
            this.lbl_z.Location = new System.Drawing.Point(7, 66);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(17, 13);
            this.lbl_z.TabIndex = 0;
            this.lbl_z.Text = "Z:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.ForeColor = System.Drawing.Color.Red;
            this.lbl_y.Location = new System.Drawing.Point(7, 42);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(17, 13);
            this.lbl_y.TabIndex = 0;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.ForeColor = System.Drawing.Color.Orange;
            this.lbl_x.Location = new System.Drawing.Point(7, 20);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(17, 13);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X:";
            // 
            // btn_efecto1
            // 
            this.btn_efecto1.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto1.Location = new System.Drawing.Point(6, 20);
            this.btn_efecto1.Name = "btn_efecto1";
            this.btn_efecto1.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto1.TabIndex = 10;
            this.btn_efecto1.Text = "Efecto X";
            this.btn_efecto1.UseVisualStyleBackColor = false;
            this.btn_efecto1.Click += new System.EventHandler(this.btn_efecto1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_efecto11);
            this.groupBox1.Controls.Add(this.btn_efecto10);
            this.groupBox1.Controls.Add(this.btn_efecto9);
            this.groupBox1.Controls.Add(this.btn_efecto6);
            this.groupBox1.Controls.Add(this.btn_efecto3);
            this.groupBox1.Controls.Add(this.btn_efecto8);
            this.groupBox1.Controls.Add(this.btn_efecto2);
            this.groupBox1.Controls.Add(this.btn_efecto7);
            this.groupBox1.Controls.Add(this.btn_efecto1);
            this.groupBox1.Location = new System.Drawing.Point(383, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Efectos";
            // 
            // btn_efecto11
            // 
            this.btn_efecto11.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto11.Location = new System.Drawing.Point(252, 99);
            this.btn_efecto11.Name = "btn_efecto11";
            this.btn_efecto11.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto11.TabIndex = 18;
            this.btn_efecto11.Text = "Pared Z";
            this.btn_efecto11.UseVisualStyleBackColor = false;
            this.btn_efecto11.Click += new System.EventHandler(this.btn_efecto11_Click);
            // 
            // btn_efecto10
            // 
            this.btn_efecto10.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto10.Location = new System.Drawing.Point(252, 60);
            this.btn_efecto10.Name = "btn_efecto10";
            this.btn_efecto10.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto10.TabIndex = 17;
            this.btn_efecto10.Text = "Pared Y";
            this.btn_efecto10.UseVisualStyleBackColor = false;
            this.btn_efecto10.Click += new System.EventHandler(this.btn_efecto10_Click);
            // 
            // btn_efecto9
            // 
            this.btn_efecto9.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto9.Location = new System.Drawing.Point(252, 20);
            this.btn_efecto9.Name = "btn_efecto9";
            this.btn_efecto9.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto9.TabIndex = 16;
            this.btn_efecto9.Text = "Pared X";
            this.btn_efecto9.UseVisualStyleBackColor = false;
            this.btn_efecto9.Click += new System.EventHandler(this.btn_efecto9_Click);
            // 
            // btn_efecto6
            // 
            this.btn_efecto6.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto6.Location = new System.Drawing.Point(129, 20);
            this.btn_efecto6.Name = "btn_efecto6";
            this.btn_efecto6.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto6.TabIndex = 13;
            this.btn_efecto6.Text = "Efecto Giro XY";
            this.btn_efecto6.UseVisualStyleBackColor = false;
            this.btn_efecto6.Click += new System.EventHandler(this.btn_efecto6_Click);
            // 
            // btn_efecto3
            // 
            this.btn_efecto3.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto3.Location = new System.Drawing.Point(6, 99);
            this.btn_efecto3.Name = "btn_efecto3";
            this.btn_efecto3.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto3.TabIndex = 12;
            this.btn_efecto3.Text = "Efecto Z";
            this.btn_efecto3.UseVisualStyleBackColor = false;
            this.btn_efecto3.Click += new System.EventHandler(this.btn_efecto3_Click);
            // 
            // btn_efecto8
            // 
            this.btn_efecto8.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto8.Location = new System.Drawing.Point(129, 99);
            this.btn_efecto8.Name = "btn_efecto8";
            this.btn_efecto8.Size = new System.Drawing.Size(103, 23);
            this.btn_efecto8.TabIndex = 15;
            this.btn_efecto8.Text = "Efecto Giro YZ";
            this.btn_efecto8.UseVisualStyleBackColor = false;
            this.btn_efecto8.Click += new System.EventHandler(this.btn_efecto8_Click);
            // 
            // btn_efecto2
            // 
            this.btn_efecto2.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto2.Location = new System.Drawing.Point(6, 60);
            this.btn_efecto2.Name = "btn_efecto2";
            this.btn_efecto2.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto2.TabIndex = 11;
            this.btn_efecto2.Text = "Efecto Y";
            this.btn_efecto2.UseVisualStyleBackColor = false;
            this.btn_efecto2.Click += new System.EventHandler(this.btn_efecto2_Click);
            // 
            // btn_efecto7
            // 
            this.btn_efecto7.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto7.Location = new System.Drawing.Point(129, 60);
            this.btn_efecto7.Name = "btn_efecto7";
            this.btn_efecto7.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto7.TabIndex = 14;
            this.btn_efecto7.Text = "Efecto Giro XZ";
            this.btn_efecto7.UseVisualStyleBackColor = false;
            this.btn_efecto7.Click += new System.EventHandler(this.btn_efecto7_Click);
            // 
            // btn_efecto4
            // 
            this.btn_efecto4.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto4.Location = new System.Drawing.Point(88, 9);
            this.btn_efecto4.Name = "btn_efecto4";
            this.btn_efecto4.Size = new System.Drawing.Size(70, 23);
            this.btn_efecto4.TabIndex = 2;
            this.btn_efecto4.Text = "Aumentar";
            this.btn_efecto4.UseVisualStyleBackColor = false;
            this.btn_efecto4.Click += new System.EventHandler(this.btn_efecto4_Click);
            // 
            // btn_efecto5
            // 
            this.btn_efecto5.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto5.Location = new System.Drawing.Point(12, 9);
            this.btn_efecto5.Name = "btn_efecto5";
            this.btn_efecto5.Size = new System.Drawing.Size(70, 23);
            this.btn_efecto5.TabIndex = 1;
            this.btn_efecto5.Text = "Disminuir";
            this.btn_efecto5.UseVisualStyleBackColor = false;
            this.btn_efecto5.Click += new System.EventHandler(this.btn_efecto5_Click);
            // 
            // tmrRedraw
            // 
            this.tmrRedraw.Enabled = true;
            this.tmrRedraw.Interval = 500;
            this.tmrRedraw.Tick += new System.EventHandler(this.tmrRedraw_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Flechas_OpenGL.Properties.Resources.Boton;
            this.pictureBox1.Location = new System.Drawing.Point(635, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 33);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Flechas_OpenGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox_coordenadas);
            this.Controls.Add(this.lbl_acercaDe);
            this.Controls.Add(this.btn_zDer);
            this.Controls.Add(this.btn_efecto5);
            this.Controls.Add(this.btn_yIzq);
            this.Controls.Add(this.btn_zIzq);
            this.Controls.Add(this.btn_xIzq);
            this.Controls.Add(this.btn_efecto4);
            this.Controls.Add(this.btn_yDer);
            this.Controls.Add(this.btn_xDer);
            this.Controls.Add(this.gl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Flechas_OpenGL";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flechas en OpenGL";
            this.gbox_coordenadas.ResumeLayout(false);
            this.gbox_coordenadas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl gl;
        private System.Windows.Forms.Button btn_xDer;
        private System.Windows.Forms.Button btn_xIzq;
        private System.Windows.Forms.Button btn_yIzq;
        private System.Windows.Forms.Button btn_yDer;
        private System.Windows.Forms.Button btn_zIzq;
        private System.Windows.Forms.Button btn_zDer;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Label lbl_acercaDe;
        private System.Windows.Forms.GroupBox gbox_coordenadas;
        private System.Windows.Forms.Label lbl_z;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_valorZ;
        private System.Windows.Forms.Label lbl_valorY;
        private System.Windows.Forms.Label lbl_valorX;
        private System.Windows.Forms.Button btn_efecto1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_efecto3;
        private System.Windows.Forms.Button btn_efecto2;
        private System.Windows.Forms.Button btn_efecto6;
        private System.Windows.Forms.Button btn_efecto5;
        private System.Windows.Forms.Button btn_efecto4;
        private System.Windows.Forms.Button btn_efecto9;
        private System.Windows.Forms.Button btn_efecto8;
        private System.Windows.Forms.Button btn_efecto7;
        private System.Windows.Forms.Button btn_efecto11;
        private System.Windows.Forms.Button btn_efecto10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrRedraw;
    }
}

