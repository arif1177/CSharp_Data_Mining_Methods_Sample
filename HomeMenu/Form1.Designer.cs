namespace HomeMenu
{
    partial class frmHomeScreen
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
            this.btnDemoTTest = new System.Windows.Forms.Button();
            this.txtBxOutput = new System.Windows.Forms.RichTextBox();
            this.btnDemoBinClassOptimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemoTTest
            // 
            this.btnDemoTTest.Location = new System.Drawing.Point(17, 16);
            this.btnDemoTTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDemoTTest.Name = "btnDemoTTest";
            this.btnDemoTTest.Size = new System.Drawing.Size(100, 28);
            this.btnDemoTTest.TabIndex = 0;
            this.btnDemoTTest.Text = "Demo t-test";
            this.btnDemoTTest.UseVisualStyleBackColor = true;
            this.btnDemoTTest.Click += new System.EventHandler(this.btnDemoTTest_Click);
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBxOutput.Location = new System.Drawing.Point(0, 103);
            this.txtBxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.Size = new System.Drawing.Size(852, 302);
            this.txtBxOutput.TabIndex = 1;
            this.txtBxOutput.Text = "";
            // 
            // btnDemoBinClassOptimi
            // 
            this.btnDemoBinClassOptimi.Location = new System.Drawing.Point(17, 52);
            this.btnDemoBinClassOptimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDemoBinClassOptimi.Name = "btnDemoBinClassOptimi";
            this.btnDemoBinClassOptimi.Size = new System.Drawing.Size(194, 28);
            this.btnDemoBinClassOptimi.TabIndex = 2;
            this.btnDemoBinClassOptimi.Text = "Demo Binary Classification Optimisation";
            this.btnDemoBinClassOptimi.UseVisualStyleBackColor = true;
            this.btnDemoBinClassOptimi.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 405);
            this.Controls.Add(this.btnDemoBinClassOptimi);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.btnDemoTTest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemoTTest;
        private System.Windows.Forms.RichTextBox txtBxOutput;
        private System.Windows.Forms.Button btnDemoBinClassOptimi;
    }
}

