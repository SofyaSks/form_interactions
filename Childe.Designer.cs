namespace form_interactions
{
    partial class Childe
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
            this.label_childe = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_childe
            // 
            this.label_childe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_childe.ForeColor = System.Drawing.Color.Black;
            this.label_childe.Location = new System.Drawing.Point(222, 87);
            this.label_childe.Name = "label_childe";
            this.label_childe.Size = new System.Drawing.Size(277, 75);
            this.label_childe.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(270, 264);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(138, 84);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Childe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_childe);
            this.Name = "Childe";
            this.Text = "Childe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_childe;
        private System.Windows.Forms.Button button_close;
    }
}