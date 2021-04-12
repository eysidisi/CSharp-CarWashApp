
namespace DEICO.CarWash.UI.UserControls
{
    partial class CarWashIndicator
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
            this.pictureBoxLamp = new System.Windows.Forms.PictureBox();
            this.labelIndicatorName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLamp
            // 
            this.pictureBoxLamp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBoxLamp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLamp.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLamp.Name = "pictureBoxLamp";
            this.pictureBoxLamp.Size = new System.Drawing.Size(65, 19);
            this.pictureBoxLamp.TabIndex = 0;
            this.pictureBoxLamp.TabStop = false;
            // 
            // labelIndicatorName
            // 
            this.labelIndicatorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIndicatorName.AutoSize = true;
            this.labelIndicatorName.Location = new System.Drawing.Point(74, 6);
            this.labelIndicatorName.Name = "labelIndicatorName";
            this.labelIndicatorName.Size = new System.Drawing.Size(117, 13);
            this.labelIndicatorName.TabIndex = 1;
            this.labelIndicatorName.Text = "placeholderplaceholder";
            this.labelIndicatorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxLamp);
            this.flowLayoutPanel1.Controls.Add(this.labelIndicatorName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 25);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // CarWashIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CarWashIndicator";
            this.Size = new System.Drawing.Size(200, 31);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLamp;
        private System.Windows.Forms.Label labelIndicatorName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
