namespace MC.Win
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
            this.cube3Control1 = new MC.BL.Win.Cube3Control();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.tb_rotate = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cube3Control1
            // 
            this.cube3Control1.Cube = null;
            this.cube3Control1.Location = new System.Drawing.Point(12, 12);
            this.cube3Control1.Name = "cube3Control1";
            this.cube3Control1.Size = new System.Drawing.Size(412, 258);
            this.cube3Control1.TabIndex = 0;
            // 
            // btn_rotate
            // 
            this.btn_rotate.Location = new System.Drawing.Point(118, 276);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(75, 23);
            this.btn_rotate.TabIndex = 1;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // tb_rotate
            // 
            this.tb_rotate.Location = new System.Drawing.Point(12, 279);
            this.tb_rotate.Name = "tb_rotate";
            this.tb_rotate.Size = new System.Drawing.Size(100, 20);
            this.tb_rotate.TabIndex = 2;
            this.tb_rotate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_rotate_KeyDown);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(199, 276);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 314);
            this.Controls.Add(this.tb_rotate);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_rotate);
            this.Controls.Add(this.cube3Control1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BL.Win.Cube3Control cube3Control1;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.TextBox tb_rotate;
        private System.Windows.Forms.Button btn_reset;
    }
}

