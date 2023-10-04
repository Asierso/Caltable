namespace Interpreter
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicatorsPanel = new System.Windows.Forms.Panel();
            this.L4 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.panel1.Controls.Add(this.indicatorsPanel);
            this.panel1.Controls.Add(this.L4);
            this.panel1.Controls.Add(this.L3);
            this.panel1.Controls.Add(this.L2);
            this.panel1.Controls.Add(this.L1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 291);
            this.panel1.TabIndex = 0;
            // 
            // indicatorsPanel
            // 
            this.indicatorsPanel.Location = new System.Drawing.Point(3, 273);
            this.indicatorsPanel.Name = "indicatorsPanel";
            this.indicatorsPanel.Size = new System.Drawing.Size(294, 15);
            this.indicatorsPanel.TabIndex = 4;
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.L4.ForeColor = System.Drawing.SystemColors.Control;
            this.L4.Location = new System.Drawing.Point(-13, 203);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(769, 76);
            this.L4.TabIndex = 3;
            this.L4.Text = "AAAAAAAAAAAAAAAA";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.L3.ForeColor = System.Drawing.SystemColors.Control;
            this.L3.Location = new System.Drawing.Point(-12, 138);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(769, 76);
            this.L3.TabIndex = 2;
            this.L3.Text = "AAAAAAAAAAAAAAAA";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.L2.ForeColor = System.Drawing.SystemColors.Control;
            this.L2.Location = new System.Drawing.Point(-11, 74);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(769, 76);
            this.L2.TabIndex = 1;
            this.L2.Text = "AAAAAAAAAAAAAAAA";
            // 
            // L1
            // 
            this.L1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.L1.ForeColor = System.Drawing.SystemColors.Control;
            this.L1.Location = new System.Drawing.Point(-12, 5);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(769, 76);
            this.L1.TabIndex = 0;
            this.L1.Text = "AAAAAAAAAAAAAAAA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 288);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Interprete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Panel indicatorsPanel;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L1;
    }
}

