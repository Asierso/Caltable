namespace Caltable
{
    partial class Utility
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utility));
            this.models = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reposTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadBinBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.certPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.statePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.treeMain = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // models
            // 
            this.models.FormattingEnabled = true;
            this.models.Location = new System.Drawing.Point(82, 15);
            this.models.Name = "models";
            this.models.Size = new System.Drawing.Size(121, 21);
            this.models.TabIndex = 0;
            this.models.SelectedIndexChanged += new System.EventHandler(this.models_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.models);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reposTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.downloadBinBtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descarga";
            // 
            // reposTxt
            // 
            this.reposTxt.Location = new System.Drawing.Point(82, 19);
            this.reposTxt.Name = "reposTxt";
            this.reposTxt.Size = new System.Drawing.Size(121, 20);
            this.reposTxt.TabIndex = 4;
            this.reposTxt.Text = "asierso.github.io";
            this.reposTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repositorio";
            // 
            // downloadBinBtn
            // 
            this.downloadBinBtn.Location = new System.Drawing.Point(15, 45);
            this.downloadBinBtn.Name = "downloadBinBtn";
            this.downloadBinBtn.Size = new System.Drawing.Size(188, 30);
            this.downloadBinBtn.TabIndex = 4;
            this.downloadBinBtn.Text = "Descargar binarios";
            this.downloadBinBtn.UseVisualStyleBackColor = true;
            this.downloadBinBtn.Click += new System.EventHandler(this.downloadBinBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.certPanel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.statePanel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.treeMain);
            this.groupBox3.Location = new System.Drawing.Point(232, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 272);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repositorio";
            // 
            // certPanel
            // 
            this.certPanel.BackColor = System.Drawing.Color.LightCoral;
            this.certPanel.Location = new System.Drawing.Point(69, 240);
            this.certPanel.Name = "certPanel";
            this.certPanel.Size = new System.Drawing.Size(155, 23);
            this.certPanel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Certificado";
            // 
            // statePanel
            // 
            this.statePanel.BackColor = System.Drawing.Color.Lime;
            this.statePanel.Location = new System.Drawing.Point(69, 211);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(155, 23);
            this.statePanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // treeMain
            // 
            this.treeMain.Location = new System.Drawing.Point(6, 19);
            this.treeMain.Name = "treeMain";
            this.treeMain.Size = new System.Drawing.Size(230, 186);
            this.treeMain.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CaltableIcon.png");
            this.imageList1.Images.SetKeyName(1, "iconmenu5.png");
            this.imageList1.Images.SetKeyName(2, "exist.png");
            this.imageList1.Images.SetKeyName(3, "nexist.png");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(8, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 119);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(177, 94);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 288);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Utility";
            this.Text = "Utilidades";
            this.Load += new System.EventHandler(this.Utility_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox models;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button downloadBinBtn;
        private System.Windows.Forms.TextBox reposTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel certPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label label3;
    }
}