
namespace arduino_deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelbaglanti = new System.Windows.Forms.Label();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.buttonKes = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelmesafe = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPort.Location = new System.Drawing.Point(41, 31);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(44, 15);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "PORT :";
            // 
            // labelbaglanti
            // 
            this.labelbaglanti.AutoSize = true;
            this.labelbaglanti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelbaglanti.Location = new System.Drawing.Point(41, 86);
            this.labelbaglanti.Name = "labelbaglanti";
            this.labelbaglanti.Size = new System.Drawing.Size(130, 15);
            this.labelbaglanti.TabIndex = 1;
            this.labelbaglanti.Text = "BAĞLANTI DURUMU :";
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.BackColor = System.Drawing.Color.Black;
            this.buttonBaglan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBaglan.ForeColor = System.Drawing.Color.White;
            this.buttonBaglan.Location = new System.Drawing.Point(274, 31);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(75, 23);
            this.buttonBaglan.TabIndex = 2;
            this.buttonBaglan.Text = "BAĞLAN";
            this.buttonBaglan.UseVisualStyleBackColor = false;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // buttonKes
            // 
            this.buttonKes.BackColor = System.Drawing.Color.Black;
            this.buttonKes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKes.ForeColor = System.Drawing.Color.White;
            this.buttonKes.Location = new System.Drawing.Point(274, 82);
            this.buttonKes.Name = "buttonKes";
            this.buttonKes.Size = new System.Drawing.Size(75, 23);
            this.buttonKes.TabIndex = 2;
            this.buttonKes.Text = "KES";
            this.buttonKes.UseVisualStyleBackColor = false;
            this.buttonKes.Click += new System.EventHandler(this.buttonKes_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // labelmesafe
            // 
            this.labelmesafe.AutoSize = true;
            this.labelmesafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmesafe.Location = new System.Drawing.Point(171, 165);
            this.labelmesafe.Name = "labelmesafe";
            this.labelmesafe.Size = new System.Drawing.Size(51, 15);
            this.labelmesafe.TabIndex = 1;
            this.labelmesafe.Text = "MESAFE";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 229);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonKes);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.labelbaglanti);
            this.Controls.Add(this.labelmesafe);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "ARDUINO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelbaglanti;
        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.Button buttonKes;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelmesafe;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;

    }
}

