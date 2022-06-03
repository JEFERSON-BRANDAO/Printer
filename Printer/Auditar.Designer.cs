namespace Printer
{
    partial class Auditar
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
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lbAviso = new System.Windows.Forms.Label();
            this.lbSeria = new System.Windows.Forms.Label();
            this.lbRodape = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTOPa = new System.Windows.Forms.RadioButton();
            this.rdbBOTa = new System.Windows.Forms.RadioButton();
            this.rdbBOTb = new System.Windows.Forms.RadioButton();
            this.rdbTOPb = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(12, 126);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(289, 35);
            this.txtSerial.TabIndex = 13;
            this.txtSerial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyUp);
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.Color.Transparent;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Red;
            this.lbAviso.Location = new System.Drawing.Point(8, 214);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(51, 20);
            this.lbAviso.TabIndex = 17;
            this.lbAviso.Text = "label1";
            // 
            // lbSeria
            // 
            this.lbSeria.AutoSize = true;
            this.lbSeria.BackColor = System.Drawing.Color.Transparent;
            this.lbSeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeria.ForeColor = System.Drawing.Color.White;
            this.lbSeria.Location = new System.Drawing.Point(12, 103);
            this.lbSeria.Name = "lbSeria";
            this.lbSeria.Size = new System.Drawing.Size(49, 20);
            this.lbSeria.TabIndex = 16;
            this.lbSeria.Text = "Serial";
            // 
            // lbRodape
            // 
            this.lbRodape.AutoSize = true;
            this.lbRodape.BackColor = System.Drawing.Color.Transparent;
            this.lbRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodape.ForeColor = System.Drawing.Color.White;
            this.lbRodape.Location = new System.Drawing.Point(8, 367);
            this.lbRodape.Name = "lbRodape";
            this.lbRodape.Size = new System.Drawing.Size(51, 20);
            this.lbRodape.TabIndex = 15;
            this.lbRodape.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 127);
            this.panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbTOPb);
            this.groupBox1.Controls.Add(this.rdbBOTb);
            this.groupBox1.Controls.Add(this.rdbTOPa);
            this.groupBox1.Controls.Add(this.rdbBOTa);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 119);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRINTER";
            // 
            // rdbTOPa
            // 
            this.rdbTOPa.AutoSize = true;
            this.rdbTOPa.Location = new System.Drawing.Point(4, 65);
            this.rdbTOPa.Name = "rdbTOPa";
            this.rdbTOPa.Size = new System.Drawing.Size(14, 13);
            this.rdbTOPa.TabIndex = 1;
            this.rdbTOPa.UseVisualStyleBackColor = true;
            // 
            // rdbBOTa
            // 
            this.rdbBOTa.AutoSize = true;
            this.rdbBOTa.Checked = true;
            this.rdbBOTa.Location = new System.Drawing.Point(6, 19);
            this.rdbBOTa.Name = "rdbBOTa";
            this.rdbBOTa.Size = new System.Drawing.Size(14, 13);
            this.rdbBOTa.TabIndex = 0;
            this.rdbBOTa.TabStop = true;
            this.rdbBOTa.UseVisualStyleBackColor = true;
            // 
            // rdbBOTb
            // 
            this.rdbBOTb.AutoSize = true;
            this.rdbBOTb.Location = new System.Drawing.Point(6, 42);
            this.rdbBOTb.Name = "rdbBOTb";
            this.rdbBOTb.Size = new System.Drawing.Size(14, 13);
            this.rdbBOTb.TabIndex = 2;
            this.rdbBOTb.UseVisualStyleBackColor = true;
            // 
            // rdbTOPb
            // 
            this.rdbTOPb.AutoSize = true;
            this.rdbTOPb.Location = new System.Drawing.Point(4, 88);
            this.rdbTOPb.Name = "rdbTOPb";
            this.rdbTOPb.Size = new System.Drawing.Size(14, 13);
            this.rdbTOPb.TabIndex = 3;
            this.rdbTOPb.UseVisualStyleBackColor = true;
            // 
            // Auditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Printer.Properties.Resources.logoPreto;
            this.ClientSize = new System.Drawing.Size(618, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.lbSeria);
            this.Controls.Add(this.lbRodape);
            this.Controls.Add(this.txtSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Auditar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer V1.0.1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbSeria;
        private System.Windows.Forms.Label lbRodape;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTOPa;
        private System.Windows.Forms.RadioButton rdbBOTa;
        private System.Windows.Forms.RadioButton rdbBOTb;
        private System.Windows.Forms.RadioButton rdbTOPb;
    }
}

