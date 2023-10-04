namespace Caltable
{
    partial class Metadata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metadata));
            this.label1 = new System.Windows.Forms.Label();
            this.indexUPC = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.treenode = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shownameTxt = new System.Windows.Forms.Label();
            this.fnameUPC = new System.Windows.Forms.NumericUpDown();
            this.changenameBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.memoryBar = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.memoryTxt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.indexUPC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnameUPC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indice";
            // 
            // indexUPC
            // 
            this.indexUPC.Location = new System.Drawing.Point(54, 19);
            this.indexUPC.Name = "indexUPC";
            this.indexUPC.Size = new System.Drawing.Size(120, 20);
            this.indexUPC.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 45);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(159, 26);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.treenode);
            this.groupBox1.Controls.Add(this.indexUPC);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partes del archivo";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(94, 74);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(80, 26);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Borrar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(15, 74);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(80, 26);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Resetear";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // treenode
            // 
            this.treenode.Location = new System.Drawing.Point(15, 106);
            this.treenode.Name = "treenode";
            this.treenode.Size = new System.Drawing.Size(159, 175);
            this.treenode.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shownameTxt);
            this.groupBox2.Controls.Add(this.fnameUPC);
            this.groupBox2.Controls.Add(this.changenameBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(212, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivo";
            // 
            // shownameTxt
            // 
            this.shownameTxt.AutoSize = true;
            this.shownameTxt.Location = new System.Drawing.Point(18, 74);
            this.shownameTxt.Name = "shownameTxt";
            this.shownameTxt.Size = new System.Drawing.Size(56, 13);
            this.shownameTxt.TabIndex = 4;
            this.shownameTxt.Text = "Nombre: 1";
            // 
            // fnameUPC
            // 
            this.fnameUPC.Location = new System.Drawing.Point(60, 19);
            this.fnameUPC.Name = "fnameUPC";
            this.fnameUPC.Size = new System.Drawing.Size(120, 20);
            this.fnameUPC.TabIndex = 2;
            this.fnameUPC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // changenameBtn
            // 
            this.changenameBtn.Location = new System.Drawing.Point(21, 45);
            this.changenameBtn.Name = "changenameBtn";
            this.changenameBtn.Size = new System.Drawing.Size(159, 26);
            this.changenameBtn.TabIndex = 3;
            this.changenameBtn.Text = "Cambiar";
            this.changenameBtn.UseVisualStyleBackColor = true;
            this.changenameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "app.png");
            this.imageList1.Images.SetKeyName(1, "objectapp.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.memoryBar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.memoryTxt);
            this.groupBox3.Location = new System.Drawing.Point(212, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memoria";
            // 
            // memoryBar
            // 
            this.memoryBar.Location = new System.Drawing.Point(21, 45);
            this.memoryBar.Maximum = 110;
            this.memoryBar.Name = "memoryBar";
            this.memoryBar.Size = new System.Drawing.Size(164, 28);
            this.memoryBar.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Cantidad";
            // 
            // memoryTxt
            // 
            this.memoryTxt.Location = new System.Drawing.Point(77, 19);
            this.memoryTxt.Name = "memoryTxt";
            this.memoryTxt.Size = new System.Drawing.Size(103, 20);
            this.memoryTxt.TabIndex = 31;
            this.memoryTxt.Text = "10B";
            this.memoryTxt.TextChanged += new System.EventHandler(this.memoryTxt_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.generateBtn);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.resultTxt);
            this.groupBox4.Location = new System.Drawing.Point(212, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Codificado";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(21, 47);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(164, 26);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = "Generar";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Resultado";
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(77, 21);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.Size = new System.Drawing.Size(103, 20);
            this.resultTxt.TabIndex = 31;
            // 
            // Metadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 308);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Metadata";
            this.Text = "Metadatos";
            this.Load += new System.EventHandler(this.Metadata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indexUPC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnameUPC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown indexUPC;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treenode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown fnameUPC;
        private System.Windows.Forms.Button changenameBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label shownameTxt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox memoryTxt;
        private System.Windows.Forms.ProgressBar memoryBar;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}