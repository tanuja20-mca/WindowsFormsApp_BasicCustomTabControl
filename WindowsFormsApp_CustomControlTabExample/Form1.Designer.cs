
namespace WindowsFormsApp_CustomControlTabExample
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
            this.tabControlZ1 = new TabControlZ.TabControlZ();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlZ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlZ1
            // 
            this.tabControlZ1.ActiveTabEndColor = System.Drawing.Color.DarkOrange;
            this.tabControlZ1.ActiveTabStartColor = System.Drawing.Color.Yellow;
            this.tabControlZ1.CloseButtonColor = System.Drawing.Color.Red;
            this.tabControlZ1.Controls.Add(this.tabPage1);
            this.tabControlZ1.Controls.Add(this.tabPage2);
            this.tabControlZ1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlZ1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlZ1.GradientAngle = 90;
            this.tabControlZ1.Location = new System.Drawing.Point(98, 12);
            this.tabControlZ1.Name = "tabControlZ1";
            this.tabControlZ1.NonActiveTabEndColor = System.Drawing.Color.DarkBlue;
            this.tabControlZ1.NonActiveTabStartColor = System.Drawing.Color.LightGreen;
            this.tabControlZ1.Padding = new System.Drawing.Point(22, 4);
            this.tabControlZ1.SelectedIndex = 0;
            this.tabControlZ1.Size = new System.Drawing.Size(488, 316);
            this.tabControlZ1.TabIndex = 0;
            this.tabControlZ1.TextColor = System.Drawing.Color.Navy;
            this.tabControlZ1.Transparent1 = 150;
            this.tabControlZ1.Transparent2 = 150;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlZ1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlZ1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControlZ.TabControlZ tabControlZ1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

