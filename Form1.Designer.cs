namespace PdbBase64
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnToBase64 = new System.Windows.Forms.Button();
            this.btnToTxt = new System.Windows.Forms.Button();
            this.btnToPdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToPdf);
            this.panel1.Controls.Add(this.btnToTxt);
            this.panel1.Controls.Add(this.btnToBase64);
            this.panel1.Controls.Add(this.btnLoadFile);
            this.panel1.Controls.Add(this.txtPathFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 53);
            this.panel1.TabIndex = 0;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(13, 13);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(448, 20);
            this.txtPathFile.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(480, 13);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEditor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 397);
            this.panel2.TabIndex = 1;
            // 
            // txtEditor
            // 
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(1026, 397);
            this.txtEditor.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "Abrir archivo pdf";
            // 
            // btnToBase64
            // 
            this.btnToBase64.Location = new System.Drawing.Point(574, 13);
            this.btnToBase64.Name = "btnToBase64";
            this.btnToBase64.Size = new System.Drawing.Size(75, 23);
            this.btnToBase64.TabIndex = 2;
            this.btnToBase64.Text = "to Base 64";
            this.btnToBase64.UseVisualStyleBackColor = true;
            this.btnToBase64.Click += new System.EventHandler(this.BtnToBase64_Click);
            // 
            // btnToTxt
            // 
            this.btnToTxt.Location = new System.Drawing.Point(655, 12);
            this.btnToTxt.Name = "btnToTxt";
            this.btnToTxt.Size = new System.Drawing.Size(75, 23);
            this.btnToTxt.TabIndex = 3;
            this.btnToTxt.Text = "to txt";
            this.btnToTxt.UseVisualStyleBackColor = true;
            this.btnToTxt.Click += new System.EventHandler(this.BtnToTxt_Click);
            // 
            // btnToPdf
            // 
            this.btnToPdf.Location = new System.Drawing.Point(737, 13);
            this.btnToPdf.Name = "btnToPdf";
            this.btnToPdf.Size = new System.Drawing.Size(75, 23);
            this.btnToPdf.TabIndex = 4;
            this.btnToPdf.Text = "to pdf";
            this.btnToPdf.UseVisualStyleBackColor = true;
            this.btnToPdf.Click += new System.EventHandler(this.BtnToPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnToBase64;
        private System.Windows.Forms.Button btnToTxt;
        private System.Windows.Forms.Button btnToPdf;
    }
}

