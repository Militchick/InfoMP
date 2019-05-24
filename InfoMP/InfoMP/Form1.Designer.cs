using System.Windows.Forms;

namespace InfoMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titulotext = new System.Windows.Forms.TextBox();
            this.artistatext = new System.Windows.Forms.TextBox();
            this.albumtext = new System.Windows.Forms.TextBox();
            this.anyotext = new System.Windows.Forms.TextBox();
            this.pistatext = new System.Windows.Forms.TextBox();
            this.generotext = new System.Windows.Forms.TextBox();
            this.comtext = new System.Windows.Forms.TextBox();
            this.comptext = new System.Windows.Forms.TextBox();
            this.numtext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cm = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.abrirbtn = new System.Windows.Forms.Button();
            this.guardarbtn = new System.Windows.Forms.Button();
            this.ayudabtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.vistalista = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Compositor del Disco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pista:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Género:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero de Disco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Comentario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Caratula:";
            // 
            // titulotext
            // 
            this.titulotext.Location = new System.Drawing.Point(38, 48);
            this.titulotext.Name = "titulotext";
            this.titulotext.Size = new System.Drawing.Size(153, 20);
            this.titulotext.TabIndex = 10;
            this.titulotext.TextChanged += new System.EventHandler(this.titulotext_TextChanged);
            // 
            // artistatext
            // 
            this.artistatext.Location = new System.Drawing.Point(38, 87);
            this.artistatext.Name = "artistatext";
            this.artistatext.Size = new System.Drawing.Size(153, 20);
            this.artistatext.TabIndex = 11;
            this.artistatext.TextChanged += new System.EventHandler(this.artistatext_TextChanged);
            // 
            // albumtext
            // 
            this.albumtext.Location = new System.Drawing.Point(38, 126);
            this.albumtext.Name = "albumtext";
            this.albumtext.Size = new System.Drawing.Size(153, 20);
            this.albumtext.TabIndex = 12;
            this.albumtext.TextChanged += new System.EventHandler(this.albumtext_TextChanged);
            // 
            // anyotext
            // 
            this.anyotext.Location = new System.Drawing.Point(38, 165);
            this.anyotext.Name = "anyotext";
            this.anyotext.Size = new System.Drawing.Size(60, 20);
            this.anyotext.TabIndex = 13;
            this.anyotext.TextChanged += new System.EventHandler(this.anyotext_TextChanged);
            // 
            // pistatext
            // 
            this.pistatext.Location = new System.Drawing.Point(123, 165);
            this.pistatext.Name = "pistatext";
            this.pistatext.Size = new System.Drawing.Size(68, 20);
            this.pistatext.TabIndex = 14;
            this.pistatext.TextChanged += new System.EventHandler(this.pistatext_TextChanged);
            // 
            // generotext
            // 
            this.generotext.Location = new System.Drawing.Point(38, 204);
            this.generotext.Name = "generotext";
            this.generotext.Size = new System.Drawing.Size(153, 20);
            this.generotext.TabIndex = 15;
            this.generotext.TextChanged += new System.EventHandler(this.generotext_TextChanged);
            // 
            // comtext
            // 
            this.comtext.Location = new System.Drawing.Point(38, 243);
            this.comtext.Name = "comtext";
            this.comtext.Size = new System.Drawing.Size(153, 20);
            this.comtext.TabIndex = 16;
            this.comtext.TextChanged += new System.EventHandler(this.comtext_TextChanged);
            // 
            // comptext
            // 
            this.comptext.Location = new System.Drawing.Point(38, 282);
            this.comptext.Name = "comptext";
            this.comptext.Size = new System.Drawing.Size(153, 20);
            this.comptext.TabIndex = 17;
            this.comptext.TextChanged += new System.EventHandler(this.comptext_TextChanged);
            // 
            // numtext
            // 
            this.numtext.Location = new System.Drawing.Point(38, 321);
            this.numtext.Name = "numtext";
            this.numtext.Size = new System.Drawing.Size(89, 20);
            this.numtext.TabIndex = 18;
            this.numtext.TextChanged += new System.EventHandler(this.numtext_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenu = this.cm;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cm
            // 
            this.cm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Añadir Caratula";
            this.menuItem1.Click += new System.EventHandler(this.anyadir_Caratula);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Borrar Caratula";
            this.menuItem2.Click += new System.EventHandler(this.borrar_Caratula);
            // 
            // abrirbtn
            // 
            this.abrirbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.abrirbtn.Location = new System.Drawing.Point(509, 47);
            this.abrirbtn.Name = "abrirbtn";
            this.abrirbtn.Size = new System.Drawing.Size(156, 128);
            this.abrirbtn.TabIndex = 21;
            this.abrirbtn.Text = "Abrir";
            this.abrirbtn.UseVisualStyleBackColor = true;
            this.abrirbtn.Click += new System.EventHandler(this.abrirbtn_Click);
            // 
            // guardarbtn
            // 
            this.guardarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardarbtn.Location = new System.Drawing.Point(509, 212);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(155, 131);
            this.guardarbtn.TabIndex = 22;
            this.guardarbtn.Text = "Guardar";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // ayudabtn
            // 
            this.ayudabtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ayudabtn.Location = new System.Drawing.Point(509, 366);
            this.ayudabtn.Name = "ayudabtn";
            this.ayudabtn.Size = new System.Drawing.Size(155, 127);
            this.ayudabtn.TabIndex = 23;
            this.ayudabtn.Text = "Ayuda";
            this.ayudabtn.UseVisualStyleBackColor = true;
            this.ayudabtn.Click += new System.EventHandler(this.ayudabtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(509, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 10);
            this.progressBar1.TabIndex = 24;
            // 
            // vistalista
            // 
            this.vistalista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vistalista.FullRowSelect = true;
            this.vistalista.Location = new System.Drawing.Point(235, 48);
            this.vistalista.Name = "vistalista";
            this.vistalista.Size = new System.Drawing.Size(252, 455);
            this.vistalista.TabIndex = 25;
            this.vistalista.UseCompatibleStateImageBehavior = false;
            this.vistalista.View = System.Windows.Forms.View.Details;
            this.vistalista.SelectedIndexChanged += new System.EventHandler(this.vistalista_SelectedIndexChanged);
            this.vistalista.DoubleClick += new System.EventHandler(this.vistalista_DobleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.vistalista);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ayudabtn);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.abrirbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numtext);
            this.Controls.Add(this.comptext);
            this.Controls.Add(this.comtext);
            this.Controls.Add(this.generotext);
            this.Controls.Add(this.pistatext);
            this.Controls.Add(this.anyotext);
            this.Controls.Add(this.albumtext);
            this.Controls.Add(this.artistatext);
            this.Controls.Add(this.titulotext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 780);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Text = "InfoMP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox titulotext;
        private System.Windows.Forms.TextBox artistatext;
        private System.Windows.Forms.TextBox albumtext;
        private System.Windows.Forms.TextBox anyotext;
        private System.Windows.Forms.TextBox pistatext;
        private System.Windows.Forms.TextBox generotext;
        private System.Windows.Forms.TextBox comtext;
        private System.Windows.Forms.TextBox comptext;
        private System.Windows.Forms.TextBox numtext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button abrirbtn;
        private System.Windows.Forms.Button guardarbtn;
        private System.Windows.Forms.Button ayudabtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView vistalista;
        private ContextMenu cm;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
    }
}

