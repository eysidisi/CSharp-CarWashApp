
namespace DEICO.CarWash.UI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxStopProgram = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entryConsole = new DEICO.CarWash.UI.UserControls.EntryConsole();
            this.carWashDisplay = new DEICO.CarWash.UI.UserControls.CarWashDisplay();
            this.carPositionSlider = new DEICO.CarWash.UI.UserControls.CarPositionSlider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entry Console";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car Position Simulation";
            // 
            // checkBoxStopProgram
            // 
            this.checkBoxStopProgram.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxStopProgram.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxStopProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxStopProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStopProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxStopProgram.Location = new System.Drawing.Point(241, 767);
            this.checkBoxStopProgram.Name = "checkBoxStopProgram";
            this.checkBoxStopProgram.Size = new System.Drawing.Size(232, 38);
            this.checkBoxStopProgram.TabIndex = 9;
            this.checkBoxStopProgram.Text = "Stop Program";
            this.checkBoxStopProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxStopProgram.UseVisualStyleBackColor = false;
            this.checkBoxStopProgram.CheckedChanged += new System.EventHandler(this.StopProgramClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Car Wash Display";
            // 
            // entryConsole
            // 
            this.entryConsole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entryConsole.Location = new System.Drawing.Point(45, 67);
            this.entryConsole.Name = "entryConsole";
            this.entryConsole.Size = new System.Drawing.Size(300, 500);
            this.entryConsole.TabIndex = 13;
            // 
            // carWashDisplay
            // 
            this.carWashDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carWashDisplay.Location = new System.Drawing.Point(444, 67);
            this.carWashDisplay.Name = "carWashDisplay";
            this.carWashDisplay.Size = new System.Drawing.Size(300, 500);
            this.carWashDisplay.TabIndex = 12;
            // 
            // carPositionSlider
            // 
            this.carPositionSlider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carPositionSlider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.carPositionSlider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carPositionSlider.Location = new System.Drawing.Point(93, 631);
            this.carPositionSlider.Name = "carPositionSlider";
            this.carPositionSlider.Size = new System.Drawing.Size(567, 120);
            this.carPositionSlider.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 832);
            this.Controls.Add(this.entryConsole);
            this.Controls.Add(this.carWashDisplay);
            this.Controls.Add(this.carPositionSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxStopProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Car Wash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxStopProgram;
        private System.Windows.Forms.Label label3;
        private UserControls.CarPositionSlider carPositionSlider;
        private UserControls.CarWashDisplay carWashDisplay;
        private UserControls.EntryConsole entryConsole;
    }
}

