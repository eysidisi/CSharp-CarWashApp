
namespace DEICO.CarWash.UI.UserControls
{
    partial class CarWashDisplay
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
            this.buttonWashVacant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxElapsedTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelIndicators = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonWashVacant
            // 
            this.buttonWashVacant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWashVacant.Enabled = false;
            this.buttonWashVacant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWashVacant.Location = new System.Drawing.Point(50, 29);
            this.buttonWashVacant.Name = "buttonWashVacant";
            this.buttonWashVacant.Size = new System.Drawing.Size(200, 23);
            this.buttonWashVacant.TabIndex = 0;
            this.buttonWashVacant.Text = "Wash Vacant";
            this.buttonWashVacant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wash Entry";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Wash Indicators";
            // 
            // textBoxElapsedTime
            // 
            this.textBoxElapsedTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxElapsedTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxElapsedTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxElapsedTime.Enabled = false;
            this.textBoxElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxElapsedTime.Location = new System.Drawing.Point(150, 462);
            this.textBoxElapsedTime.Name = "textBoxElapsedTime";
            this.textBoxElapsedTime.ReadOnly = true;
            this.textBoxElapsedTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxElapsedTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elapsed Time";
            // 
            // tableLayoutPanelIndicators
            // 
            this.tableLayoutPanelIndicators.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIndicators.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanelIndicators.ColumnCount = 1;
            this.tableLayoutPanelIndicators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelIndicators.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanelIndicators.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tableLayoutPanelIndicators.Location = new System.Drawing.Point(53, 93);
            this.tableLayoutPanelIndicators.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelIndicators.Name = "tableLayoutPanelIndicators";
            this.tableLayoutPanelIndicators.RowCount = 1;
            this.tableLayoutPanelIndicators.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelIndicators.Size = new System.Drawing.Size(200, 350);
            this.tableLayoutPanelIndicators.TabIndex = 5;
            // 
            // CarWashDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanelIndicators);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxElapsedTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWashVacant);
            this.Name = "CarWashDisplay";
            this.Size = new System.Drawing.Size(300, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWashVacant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxElapsedTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIndicators;
    }
}
