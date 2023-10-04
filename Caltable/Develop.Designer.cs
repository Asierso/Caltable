namespace Caltable
{
    partial class Develop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Develop));
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.script = new System.Windows.Forms.RichTextBox();
            this.commands = new System.Windows.Forms.TreeView();
            this.vars = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.TreeView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.state = new System.Windows.Forms.Panel();
            this.mailregTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savePrb = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateTxt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.publishCommitTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.publishModelTxt = new System.Windows.Forms.TextBox();
            this.publishBtn = new System.Windows.Forms.Button();
            this.interpretBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(9, 46);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(167, 35);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(9, 87);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(167, 35);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Cargar";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(57, 20);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(119, 20);
            this.modelTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.interpretBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loadBtn);
            this.groupBox1.Controls.Add(this.modelTxt);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fichero";
            // 
            // script
            // 
            this.script.Location = new System.Drawing.Point(194, 6);
            this.script.Name = "script";
            this.script.Size = new System.Drawing.Size(472, 389);
            this.script.TabIndex = 6;
            this.script.Text = "";
            this.script.TextChanged += new System.EventHandler(this.script_TextChanged);
            // 
            // commands
            // 
            this.commands.Location = new System.Drawing.Point(0, 0);
            this.commands.Name = "commands";
            this.commands.Size = new System.Drawing.Size(237, 343);
            this.commands.TabIndex = 0;
            this.commands.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.commands_AfterSelect);
            // 
            // vars
            // 
            this.vars.Location = new System.Drawing.Point(0, 0);
            this.vars.Name = "vars";
            this.vars.Size = new System.Drawing.Size(237, 308);
            this.vars.TabIndex = 0;
            this.vars.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.vars_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "objectapp.png");
            this.imageList1.Images.SetKeyName(1, "print.png");
            this.imageList1.Images.SetKeyName(2, "var.png");
            this.imageList1.Images.SetKeyName(3, "conditional.png");
            this.imageList1.Images.SetKeyName(4, "event.png");
            this.imageList1.Images.SetKeyName(5, "iconmenu2.png");
            this.imageList1.Images.SetKeyName(6, "reset.png");
            this.imageList1.Images.SetKeyName(7, "folder.png");
            this.imageList1.Images.SetKeyName(8, "bs.png");
            this.imageList1.Images.SetKeyName(9, "otherf.png");
            this.imageList1.Images.SetKeyName(10, "csv.png");
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(6, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 29);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Borrar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(117, 309);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(117, 29);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refrescar";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(0, 0);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(237, 303);
            this.directory.TabIndex = 0;
            this.directory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directory_AfterSelect);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.state);
            this.groupBox5.Controls.Add(this.mailregTxt);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.regnameTxt);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(5, 165);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 123);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Licencia";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.state.Location = new System.Drawing.Point(167, 35);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(42, 66);
            this.state.TabIndex = 10;
            // 
            // mailregTxt
            // 
            this.mailregTxt.Location = new System.Drawing.Point(26, 81);
            this.mailregTxt.Name = "mailregTxt";
            this.mailregTxt.ReadOnly = true;
            this.mailregTxt.Size = new System.Drawing.Size(123, 20);
            this.mailregTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Correo registrado";
            // 
            // regnameTxt
            // 
            this.regnameTxt.Location = new System.Drawing.Point(26, 35);
            this.regnameTxt.Name = "regnameTxt";
            this.regnameTxt.ReadOnly = true;
            this.regnameTxt.Size = new System.Drawing.Size(123, 20);
            this.regnameTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre registrado";
            // 
            // savePrb
            // 
            this.savePrb.Location = new System.Drawing.Point(818, 376);
            this.savePrb.Name = "savePrb";
            this.savePrb.Size = new System.Drawing.Size(95, 19);
            this.savePrb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Refresco";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(672, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(245, 369);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commands);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(237, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comandos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateTxt);
            this.tabPage2.Controls.Add(this.vars);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(237, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Variables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateTxt
            // 
            this.updateTxt.Location = new System.Drawing.Point(61, 313);
            this.updateTxt.Name = "updateTxt";
            this.updateTxt.Size = new System.Drawing.Size(126, 24);
            this.updateTxt.TabIndex = 2;
            this.updateTxt.Text = "Actualizar";
            this.updateTxt.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.refreshBtn);
            this.tabPage3.Controls.Add(this.deleteBtn);
            this.tabPage3.Controls.Add(this.directory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(237, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Directorio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.publishBtn);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(237, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Publicar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.publishCommitTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.publishModelTxt);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficha técnica";
            // 
            // publishCommitTxt
            // 
            this.publishCommitTxt.Location = new System.Drawing.Point(78, 58);
            this.publishCommitTxt.Multiline = true;
            this.publishCommitTxt.Name = "publishCommitTxt";
            this.publishCommitTxt.Size = new System.Drawing.Size(122, 88);
            this.publishCommitTxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Comentarios";
            // 
            // publishModelTxt
            // 
            this.publishModelTxt.Location = new System.Drawing.Point(78, 17);
            this.publishModelTxt.Name = "publishModelTxt";
            this.publishModelTxt.Size = new System.Drawing.Size(122, 20);
            this.publishModelTxt.TabIndex = 5;
            // 
            // publishBtn
            // 
            this.publishBtn.Location = new System.Drawing.Point(38, 294);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(169, 35);
            this.publishBtn.TabIndex = 5;
            this.publishBtn.Text = "Enviar para verificar";
            this.publishBtn.UseVisualStyleBackColor = true;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // interpretBtn
            // 
            this.interpretBtn.Location = new System.Drawing.Point(9, 128);
            this.interpretBtn.Name = "interpretBtn";
            this.interpretBtn.Size = new System.Drawing.Size(167, 35);
            this.interpretBtn.TabIndex = 5;
            this.interpretBtn.Text = "Interpretar";
            this.interpretBtn.UseVisualStyleBackColor = true;
            this.interpretBtn.Click += new System.EventHandler(this.interpretBtn_Click);
            // 
            // Develop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.savePrb);
            this.Controls.Add(this.script);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Develop";
            this.Text = "Entorno de desarrollo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Develop_FormClosing);
            this.Load += new System.EventHandler(this.Develop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox script;
        private System.Windows.Forms.TreeView commands;
        private System.Windows.Forms.TreeView vars;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TreeView directory;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel state;
        private System.Windows.Forms.TextBox mailregTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ProgressBar savePrb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updateTxt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox publishCommitTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox publishModelTxt;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.Button interpretBtn;
    }
}