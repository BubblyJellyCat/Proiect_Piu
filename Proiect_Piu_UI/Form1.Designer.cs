namespace Proiect_Piu_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCautaSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(301, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 58);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(301, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 61);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adauga Intrebare";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(301, 364);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(194, 60);
            this.btnCauta.TabIndex = 2;
            this.btnCauta.Text = "Cauta Intrebari";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIntrebare.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrebare.Location = new System.Drawing.Point(124, 45);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(560, 99);
            this.lblIntrebare.TabIndex = 3;
            this.lblIntrebare.Text = "Aici apar intrebarile\r\n";
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntrebare.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(301, 340);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 62);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Raspunde";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(596, 354);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(155, 70);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Inapoi la main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Visible = false;
            this.btnMainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Introduceti numarul intrebarii pe care o cautati:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // btnCautaSubmit
            // 
            this.btnCautaSubmit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaSubmit.Location = new System.Drawing.Point(301, 327);
            this.btnCautaSubmit.Name = "btnCautaSubmit";
            this.btnCautaSubmit.Size = new System.Drawing.Size(194, 75);
            this.btnCautaSubmit.TabIndex = 9;
            this.btnCautaSubmit.Text = "Cauta";
            this.btnCautaSubmit.UseVisualStyleBackColor = true;
            this.btnCautaSubmit.Visible = false;
            this.btnCautaSubmit.Click += new System.EventHandler(this.btnCautaSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Proiect_Piu_UI.Properties.Resources.Poza2;
            this.pictureBox1.Location = new System.Drawing.Point(273, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 176);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCautaSubmit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quiz Copii";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCautaSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

