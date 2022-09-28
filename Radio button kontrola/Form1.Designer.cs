namespace Radio_button_kontrola
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
            this.GrpBox = new System.Windows.Forms.GroupBox();
            this.RBtnVlastiti = new System.Windows.Forms.RadioButton();
            this.RBtnAutobus = new System.Windows.Forms.RadioButton();
            this.RBtnAvion = new System.Windows.Forms.RadioButton();
            this.BtnRezerviraj = new System.Windows.Forms.Button();
            this.TxtOdabir = new System.Windows.Forms.TextBox();
            this.GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBox
            // 
            this.GrpBox.Controls.Add(this.RBtnVlastiti);
            this.GrpBox.Controls.Add(this.RBtnAutobus);
            this.GrpBox.Controls.Add(this.RBtnAvion);
            this.GrpBox.Location = new System.Drawing.Point(76, 27);
            this.GrpBox.Name = "GrpBox";
            this.GrpBox.Size = new System.Drawing.Size(200, 100);
            this.GrpBox.TabIndex = 0;
            this.GrpBox.TabStop = false;
            this.GrpBox.Text = "Odaberite vrstu prijevoza";
            // 
            // RBtnVlastiti
            // 
            this.RBtnVlastiti.AutoSize = true;
            this.RBtnVlastiti.Location = new System.Drawing.Point(19, 67);
            this.RBtnVlastiti.Name = "RBtnVlastiti";
            this.RBtnVlastiti.Size = new System.Drawing.Size(94, 17);
            this.RBtnVlastiti.TabIndex = 2;
            this.RBtnVlastiti.TabStop = true;
            this.RBtnVlastiti.Text = "Vlastiti prijevoz";
            this.RBtnVlastiti.UseVisualStyleBackColor = true;
            // 
            // RBtnAutobus
            // 
            this.RBtnAutobus.AutoSize = true;
            this.RBtnAutobus.Location = new System.Drawing.Point(19, 44);
            this.RBtnAutobus.Name = "RBtnAutobus";
            this.RBtnAutobus.Size = new System.Drawing.Size(64, 17);
            this.RBtnAutobus.TabIndex = 1;
            this.RBtnAutobus.TabStop = true;
            this.RBtnAutobus.Text = "Autobus";
            this.RBtnAutobus.UseVisualStyleBackColor = true;
            // 
            // RBtnAvion
            // 
            this.RBtnAvion.AutoSize = true;
            this.RBtnAvion.Location = new System.Drawing.Point(19, 20);
            this.RBtnAvion.Name = "RBtnAvion";
            this.RBtnAvion.Size = new System.Drawing.Size(52, 17);
            this.RBtnAvion.TabIndex = 0;
            this.RBtnAvion.TabStop = true;
            this.RBtnAvion.Text = "Avion";
            this.RBtnAvion.UseVisualStyleBackColor = true;
            // 
            // BtnRezerviraj
            // 
            this.BtnRezerviraj.Location = new System.Drawing.Point(95, 155);
            this.BtnRezerviraj.Name = "BtnRezerviraj";
            this.BtnRezerviraj.Size = new System.Drawing.Size(152, 23);
            this.BtnRezerviraj.TabIndex = 1;
            this.BtnRezerviraj.Text = "Rezerviraj";
            this.BtnRezerviraj.UseVisualStyleBackColor = true;
            this.BtnRezerviraj.Click += new System.EventHandler(this.BtnRezerviraj_Click);
            // 
            // TxtOdabir
            // 
            this.TxtOdabir.Location = new System.Drawing.Point(95, 239);
            this.TxtOdabir.Multiline = true;
            this.TxtOdabir.Name = "TxtOdabir";
            this.TxtOdabir.ReadOnly = true;
            this.TxtOdabir.Size = new System.Drawing.Size(152, 58);
            this.TxtOdabir.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 334);
            this.Controls.Add(this.TxtOdabir);
            this.Controls.Add(this.BtnRezerviraj);
            this.Controls.Add(this.GrpBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpBox.ResumeLayout(false);
            this.GrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox;
        private System.Windows.Forms.RadioButton RBtnVlastiti;
        private System.Windows.Forms.RadioButton RBtnAutobus;
        private System.Windows.Forms.RadioButton RBtnAvion;
        private System.Windows.Forms.Button BtnRezerviraj;
        private System.Windows.Forms.TextBox TxtOdabir;
    }
}

