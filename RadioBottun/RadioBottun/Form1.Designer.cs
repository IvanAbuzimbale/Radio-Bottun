namespace RadioBottun
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
            this.grupniBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVlastiti = new System.Windows.Forms.RadioButton();
            this.radioButtonAutobus = new System.Windows.Forms.RadioButton();
            this.radioButtonAvion = new System.Windows.Forms.RadioButton();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.TextPrijevoz = new System.Windows.Forms.TextBox();
            this.grupniBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupniBox1
            // 
            this.grupniBox1.Controls.Add(this.radioButtonVlastiti);
            this.grupniBox1.Controls.Add(this.radioButtonAutobus);
            this.grupniBox1.Controls.Add(this.radioButtonAvion);
            this.grupniBox1.Location = new System.Drawing.Point(65, 56);
            this.grupniBox1.Name = "grupniBox1";
            this.grupniBox1.Size = new System.Drawing.Size(200, 100);
            this.grupniBox1.TabIndex = 0;
            this.grupniBox1.TabStop = false;
            this.grupniBox1.Text = "Odaberite vrstu prijevoza";
            this.grupniBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonVlastiti
            // 
            this.radioButtonVlastiti.AutoSize = true;
            this.radioButtonVlastiti.Location = new System.Drawing.Point(6, 62);
            this.radioButtonVlastiti.Name = "radioButtonVlastiti";
            this.radioButtonVlastiti.Size = new System.Drawing.Size(94, 17);
            this.radioButtonVlastiti.TabIndex = 2;
            this.radioButtonVlastiti.TabStop = true;
            this.radioButtonVlastiti.Text = "Vlastiti prijevoz";
            this.radioButtonVlastiti.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutobus
            // 
            this.radioButtonAutobus.AutoSize = true;
            this.radioButtonAutobus.Location = new System.Drawing.Point(6, 39);
            this.radioButtonAutobus.Name = "radioButtonAutobus";
            this.radioButtonAutobus.Size = new System.Drawing.Size(64, 17);
            this.radioButtonAutobus.TabIndex = 1;
            this.radioButtonAutobus.TabStop = true;
            this.radioButtonAutobus.Text = "Autobus";
            this.radioButtonAutobus.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvion
            // 
            this.radioButtonAvion.AutoSize = true;
            this.radioButtonAvion.Location = new System.Drawing.Point(6, 16);
            this.radioButtonAvion.Name = "radioButtonAvion";
            this.radioButtonAvion.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAvion.TabIndex = 0;
            this.radioButtonAvion.TabStop = true;
            this.radioButtonAvion.Text = "Avion";
            this.radioButtonAvion.UseVisualStyleBackColor = true;
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.Location = new System.Drawing.Point(125, 162);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.buttonRezerviraj.TabIndex = 1;
            this.buttonRezerviraj.Text = "Rezerviraj";
            this.buttonRezerviraj.UseVisualStyleBackColor = true;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // TextPrijevoz
            // 
            this.TextPrijevoz.Location = new System.Drawing.Point(71, 251);
            this.TextPrijevoz.Multiline = true;
            this.TextPrijevoz.Name = "TextPrijevoz";
            this.TextPrijevoz.Size = new System.Drawing.Size(194, 132);
            this.TextPrijevoz.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextPrijevoz);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.grupniBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grupniBox1.ResumeLayout(false);
            this.grupniBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupniBox1;
        private System.Windows.Forms.RadioButton radioButtonVlastiti;
        private System.Windows.Forms.RadioButton radioButtonAutobus;
        private System.Windows.Forms.RadioButton radioButtonAvion;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.TextBox TextPrijevoz;
    }
}

