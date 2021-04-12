
namespace DEICO.CarWash.UI.UserControls
{
    partial class EntryConsole
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelWashOptions = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wash Options";
            // 
            // tableLayoutPanelWashOptions
            // 
            this.tableLayoutPanelWashOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelWashOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanelWashOptions.ColumnCount = 1;
            this.tableLayoutPanelWashOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWashOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanelWashOptions.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tableLayoutPanelWashOptions.Location = new System.Drawing.Point(42, 41);
            this.tableLayoutPanelWashOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelWashOptions.Name = "tableLayoutPanelWashOptions";
            this.tableLayoutPanelWashOptions.RowCount = 1;
            this.tableLayoutPanelWashOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelWashOptions.Size = new System.Drawing.Size(200, 234);
            this.tableLayoutPanelWashOptions.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(110, 400);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 36);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // EntryConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanelWashOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Name = "EntryConsole";
            this.Size = new System.Drawing.Size(300, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWashOptions;
        private System.Windows.Forms.Button buttonStart;
    }
}
