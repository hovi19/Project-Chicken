namespace WFA_ProjectChicken
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMusk = new System.Windows.Forms.CheckBox();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.pbChicken = new System.Windows.Forms.PictureBox();
            this.pbCock = new System.Windows.Forms.PictureBox();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.pbScafander = new System.Windows.Forms.PictureBox();
            this.pbSpaceship = new System.Windows.Forms.PictureBox();
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbCock = new System.Windows.Forms.CheckBox();
            this.cbFood = new System.Windows.Forms.CheckBox();
            this.cbScafander = new System.Windows.Forms.CheckBox();
            this.cbSpaceship = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScafander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceship)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "What We need:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(337, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Or:";
            // 
            // cbMusk
            // 
            this.cbMusk.AutoSize = true;
            this.cbMusk.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMusk.Location = new System.Drawing.Point(342, 67);
            this.cbMusk.Name = "cbMusk";
            this.cbMusk.Size = new System.Drawing.Size(307, 27);
            this.cbMusk.TabIndex = 2;
            this.cbMusk.Text = "Talk with Elon Musk and He Will Do it";
            this.cbMusk.UseVisualStyleBackColor = true;
            this.cbMusk.CheckedChanged += new System.EventHandler(this.cbMusk_CheckedChanged);
            // 
            // btnTakeOff
            // 
            this.btnTakeOff.Enabled = false;
            this.btnTakeOff.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTakeOff.Location = new System.Drawing.Point(342, 195);
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.Size = new System.Drawing.Size(231, 32);
            this.btnTakeOff.TabIndex = 3;
            this.btnTakeOff.Text = "Take Off!";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            this.btnTakeOff.Click += new System.EventHandler(this.btnTakeOff_Click);
            // 
            // pbChicken
            // 
            this.pbChicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbChicken.Image = global::WFA_ProjectChicken.Properties.Resources.Chicken;
            this.pbChicken.Location = new System.Drawing.Point(38, 313);
            this.pbChicken.Name = "pbChicken";
            this.pbChicken.Size = new System.Drawing.Size(100, 100);
            this.pbChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChicken.TabIndex = 4;
            this.pbChicken.TabStop = false;
            this.pbChicken.Visible = false;
            // 
            // pbCock
            // 
            this.pbCock.Image = global::WFA_ProjectChicken.Properties.Resources.Cock;
            this.pbCock.Location = new System.Drawing.Point(155, 313);
            this.pbCock.Name = "pbCock";
            this.pbCock.Size = new System.Drawing.Size(100, 100);
            this.pbCock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCock.TabIndex = 5;
            this.pbCock.TabStop = false;
            this.pbCock.Visible = false;
            // 
            // pbFood
            // 
            this.pbFood.Image = global::WFA_ProjectChicken.Properties.Resources.Food;
            this.pbFood.Location = new System.Drawing.Point(273, 313);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(100, 100);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 6;
            this.pbFood.TabStop = false;
            this.pbFood.Visible = false;
            // 
            // pbScafander
            // 
            this.pbScafander.Image = global::WFA_ProjectChicken.Properties.Resources.Helmet;
            this.pbScafander.Location = new System.Drawing.Point(414, 313);
            this.pbScafander.Name = "pbScafander";
            this.pbScafander.Size = new System.Drawing.Size(100, 100);
            this.pbScafander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScafander.TabIndex = 7;
            this.pbScafander.TabStop = false;
            this.pbScafander.Visible = false;
            // 
            // pbSpaceship
            // 
            this.pbSpaceship.Image = global::WFA_ProjectChicken.Properties.Resources.Spaceship;
            this.pbSpaceship.Location = new System.Drawing.Point(549, 313);
            this.pbSpaceship.Name = "pbSpaceship";
            this.pbSpaceship.Size = new System.Drawing.Size(100, 100);
            this.pbSpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpaceship.TabIndex = 8;
            this.pbSpaceship.TabStop = false;
            this.pbSpaceship.Visible = false;
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbChicken.Location = new System.Drawing.Point(38, 67);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(93, 27);
            this.cbChicken.TabIndex = 9;
            this.cbChicken.Text = "Chicken";
            this.cbChicken.UseVisualStyleBackColor = true;
            this.cbChicken.CheckedChanged += new System.EventHandler(this.cbChicken_CheckedChanged);
            // 
            // cbCock
            // 
            this.cbCock.AutoSize = true;
            this.cbCock.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCock.Location = new System.Drawing.Point(38, 100);
            this.cbCock.Name = "cbCock";
            this.cbCock.Size = new System.Drawing.Size(229, 27);
            this.cbCock.TabIndex = 10;
            this.cbCock.Text = "Cock (for not to be lonely)";
            this.cbCock.UseVisualStyleBackColor = true;
            this.cbCock.CheckedChanged += new System.EventHandler(this.cbCock_CheckedChanged);
            // 
            // cbFood
            // 
            this.cbFood.AutoSize = true;
            this.cbFood.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFood.Location = new System.Drawing.Point(38, 133);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(162, 27);
            this.cbFood.TabIndex = 11;
            this.cbFood.Text = "Food (like seeds)";
            this.cbFood.UseVisualStyleBackColor = true;
            this.cbFood.CheckedChanged += new System.EventHandler(this.cbFood_CheckedChanged);
            // 
            // cbScafander
            // 
            this.cbScafander.AutoSize = true;
            this.cbScafander.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbScafander.Location = new System.Drawing.Point(38, 166);
            this.cbScafander.Name = "cbScafander";
            this.cbScafander.Size = new System.Drawing.Size(111, 27);
            this.cbScafander.TabIndex = 12;
            this.cbScafander.Text = "Scafander";
            this.cbScafander.UseVisualStyleBackColor = true;
            this.cbScafander.CheckedChanged += new System.EventHandler(this.cbScafander_CheckedChanged);
            // 
            // cbSpaceship
            // 
            this.cbSpaceship.AutoSize = true;
            this.cbSpaceship.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSpaceship.Location = new System.Drawing.Point(38, 200);
            this.cbSpaceship.Name = "cbSpaceship";
            this.cbSpaceship.Size = new System.Drawing.Size(113, 27);
            this.cbSpaceship.TabIndex = 13;
            this.cbSpaceship.Text = "SpaceShip";
            this.cbSpaceship.UseVisualStyleBackColor = true;
            this.cbSpaceship.CheckedChanged += new System.EventHandler(this.cbSpaceship_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.cbSpaceship);
            this.Controls.Add(this.cbScafander);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbCock);
            this.Controls.Add(this.cbChicken);
            this.Controls.Add(this.pbSpaceship);
            this.Controls.Add(this.pbScafander);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.pbCock);
            this.Controls.Add(this.pbChicken);
            this.Controls.Add(this.btnTakeOff);
            this.Controls.Add(this.cbMusk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Project Chicken";
            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScafander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMusk;
        private System.Windows.Forms.Button btnTakeOff;
        private System.Windows.Forms.PictureBox pbChicken;
        private System.Windows.Forms.PictureBox pbCock;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.PictureBox pbScafander;
        private System.Windows.Forms.PictureBox pbSpaceship;
        private System.Windows.Forms.CheckBox cbChicken;
        private System.Windows.Forms.CheckBox cbCock;
        private System.Windows.Forms.CheckBox cbFood;
        private System.Windows.Forms.CheckBox cbScafander;
        private System.Windows.Forms.CheckBox cbSpaceship;
    }
}

