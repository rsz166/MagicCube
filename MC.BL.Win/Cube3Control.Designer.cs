namespace MC.BL.Win
{
    partial class Cube3Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideB = new MC.BL.Win.SideControl();
            this.sideR = new MC.BL.Win.SideControl();
            this.sideF = new MC.BL.Win.SideControl();
            this.sideL = new MC.BL.Win.SideControl();
            this.sideD = new MC.BL.Win.SideControl();
            this.sideU = new MC.BL.Win.SideControl();
            this.SuspendLayout();
            // 
            // sideB
            // 
            this.sideB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideB.Location = new System.Drawing.Point(312, 89);
            this.sideB.Name = "sideB";
            this.sideB.Side = null;
            this.sideB.SideLength = 3;
            this.sideB.Size = new System.Drawing.Size(97, 80);
            this.sideB.TabIndex = 0;
            // 
            // sideR
            // 
            this.sideR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideR.Location = new System.Drawing.Point(209, 89);
            this.sideR.Name = "sideR";
            this.sideR.Side = null;
            this.sideR.SideLength = 3;
            this.sideR.Size = new System.Drawing.Size(97, 80);
            this.sideR.TabIndex = 0;
            // 
            // sideF
            // 
            this.sideF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideF.Location = new System.Drawing.Point(106, 89);
            this.sideF.Name = "sideF";
            this.sideF.Side = null;
            this.sideF.SideLength = 3;
            this.sideF.Size = new System.Drawing.Size(97, 80);
            this.sideF.TabIndex = 0;
            // 
            // sideL
            // 
            this.sideL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideL.Location = new System.Drawing.Point(3, 89);
            this.sideL.Name = "sideL";
            this.sideL.Side = null;
            this.sideL.SideLength = 3;
            this.sideL.Size = new System.Drawing.Size(97, 80);
            this.sideL.TabIndex = 0;
            // 
            // sideD
            // 
            this.sideD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideD.Location = new System.Drawing.Point(106, 175);
            this.sideD.Name = "sideD";
            this.sideD.Side = null;
            this.sideD.SideLength = 3;
            this.sideD.Size = new System.Drawing.Size(97, 80);
            this.sideD.TabIndex = 0;
            // 
            // sideU
            // 
            this.sideU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideU.Location = new System.Drawing.Point(106, 3);
            this.sideU.Name = "sideU";
            this.sideU.Side = null;
            this.sideU.SideLength = 3;
            this.sideU.Size = new System.Drawing.Size(97, 80);
            this.sideU.TabIndex = 0;
            // 
            // Cube3Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideB);
            this.Controls.Add(this.sideR);
            this.Controls.Add(this.sideU);
            this.Controls.Add(this.sideD);
            this.Controls.Add(this.sideF);
            this.Controls.Add(this.sideL);
            this.Name = "Cube3Control";
            this.Size = new System.Drawing.Size(412, 258);
            this.ResumeLayout(false);

        }

        #endregion

        private SideControl sideL;
        private SideControl sideF;
        private SideControl sideR;
        private SideControl sideB;
        private SideControl sideD;
        private SideControl sideU;
    }
}
