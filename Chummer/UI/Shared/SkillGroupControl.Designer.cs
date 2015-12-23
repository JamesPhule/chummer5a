﻿namespace Chummer.UI.Shared
{
	partial class SkillGroupControl
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
			this.nudSkill = new System.Windows.Forms.NumericUpDown();
			this.nudKarma = new System.Windows.Forms.NumericUpDown();
			this.lblName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudSkill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudKarma)).BeginInit();
			this.SuspendLayout();
			// 
			// nudSkill
			// 
			this.nudSkill.Location = new System.Drawing.Point(134, 1);
			this.nudSkill.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nudSkill.Name = "nudSkill";
			this.nudSkill.Size = new System.Drawing.Size(40, 20);
			this.nudSkill.TabIndex = 2;
			// 
			// nudKarma
			// 
			this.nudKarma.Location = new System.Drawing.Point(180, 1);
			this.nudKarma.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nudKarma.Name = "nudKarma";
			this.nudKarma.Size = new System.Drawing.Size(40, 20);
			this.nudKarma.TabIndex = 5;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(0, 4);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(66, 13);
			this.lblName.TabIndex = 6;
			this.lblName.Text = "[groupname]";
			// 
			// SkillGroupControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.nudKarma);
			this.Controls.Add(this.nudSkill);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "SkillGroupControl";
			this.Size = new System.Drawing.Size(225, 23);
			this.Load += new System.EventHandler(this.SkillGroupControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudSkill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudKarma)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudSkill;
		private System.Windows.Forms.NumericUpDown nudKarma;
		private System.Windows.Forms.Label lblName;
	}
}