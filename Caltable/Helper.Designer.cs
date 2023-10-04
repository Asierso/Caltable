namespace Caltable
{
    partial class Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.regist = new System.Windows.Forms.GroupBox();
            this.aceptCHK = new System.Windows.Forms.CheckBox();
            this.joinBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.regist.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(540, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // regist
            // 
            this.regist.Controls.Add(this.aceptCHK);
            this.regist.Controls.Add(this.joinBtn);
            this.regist.Controls.Add(this.label2);
            this.regist.Controls.Add(this.nameTxt);
            this.regist.Controls.Add(this.label1);
            this.regist.Controls.Add(this.emailTxt);
            this.regist.Location = new System.Drawing.Point(12, 167);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(540, 110);
            this.regist.TabIndex = 1;
            this.regist.TabStop = false;
            this.regist.Text = "Registro";
            // 
            // aceptCHK
            // 
            this.aceptCHK.AutoSize = true;
            this.aceptCHK.Location = new System.Drawing.Point(48, 40);
            this.aceptCHK.Name = "aceptCHK";
            this.aceptCHK.Size = new System.Drawing.Size(137, 30);
            this.aceptCHK.TabIndex = 5;
            this.aceptCHK.Text = "Acepto los terminos \r\ny condiciones de unirse";
            this.aceptCHK.UseVisualStyleBackColor = true;
            this.aceptCHK.CheckedChanged += new System.EventHandler(this.aceptCHK_CheckedChanged);
            // 
            // joinBtn
            // 
            this.joinBtn.Enabled = false;
            this.joinBtn.Location = new System.Drawing.Point(319, 71);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(214, 31);
            this.joinBtn.TabIndex = 4;
            this.joinBtn.Text = "Unirme";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(319, 45);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(215, 20);
            this.nameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(319, 19);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(215, 20);
            this.emailTxt.TabIndex = 0;
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 283);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Helper";
            this.Text = "Unirse";
            this.regist.ResumeLayout(false);
            this.regist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox regist;
        private System.Windows.Forms.CheckBox aceptCHK;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
    }
}