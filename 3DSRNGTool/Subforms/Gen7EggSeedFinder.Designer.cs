﻿namespace Pk3DSRNGTool
{
    partial class Gen7EggSeedFinder
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
            this.Magikarp = new System.Windows.Forms.GroupBox();
            this.L_Magikarp = new System.Windows.Forms.Label();
            this.RTB_EggSeed = new System.Windows.Forms.RichTextBox();
            this.B_EggSeed127 = new System.Windows.Forms.Button();
            this.GB_TinyFinder = new System.Windows.Forms.GroupBox();
            this.B_DelNature = new System.Windows.Forms.Button();
            this.NatureInput = new System.Windows.Forms.ComboBox();
            this.L_Progress7 = new System.Windows.Forms.Label();
            this.Gen7PBar = new System.Windows.Forms.ProgressBar();
            this.EggSeedList = new System.Windows.Forms.ListBox();
            this.L_NatureList = new System.Windows.Forms.Label();
            this.NatureList = new System.Windows.Forms.TextBox();
            this.B_Abort7 = new System.Windows.Forms.Button();
            this.B_TinySearch = new System.Windows.Forms.Button();
            this.Magikarp.SuspendLayout();
            this.GB_TinyFinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Magikarp
            // 
            this.Magikarp.Controls.Add(this.L_Magikarp);
            this.Magikarp.Controls.Add(this.RTB_EggSeed);
            this.Magikarp.Controls.Add(this.B_EggSeed127);
            this.Magikarp.Location = new System.Drawing.Point(12, 9);
            this.Magikarp.Name = "Magikarp";
            this.Magikarp.Size = new System.Drawing.Size(300, 244);
            this.Magikarp.TabIndex = 105;
            this.Magikarp.TabStop = false;
            // 
            // L_Magikarp
            // 
            this.L_Magikarp.AutoSize = true;
            this.L_Magikarp.Location = new System.Drawing.Point(13, 188);
            this.L_Magikarp.Name = "L_Magikarp";
            this.L_Magikarp.Size = new System.Drawing.Size(0, 13);
            this.L_Magikarp.TabIndex = 119;
            // 
            // RTB_EggSeed
            // 
            this.RTB_EggSeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_EggSeed.Location = new System.Drawing.Point(11, 19);
            this.RTB_EggSeed.Name = "RTB_EggSeed";
            this.RTB_EggSeed.Size = new System.Drawing.Size(280, 160);
            this.RTB_EggSeed.TabIndex = 103;
            this.RTB_EggSeed.Text = "";
            // 
            // B_EggSeed127
            // 
            this.B_EggSeed127.Location = new System.Drawing.Point(219, 207);
            this.B_EggSeed127.Name = "B_EggSeed127";
            this.B_EggSeed127.Size = new System.Drawing.Size(72, 27);
            this.B_EggSeed127.TabIndex = 29;
            this.B_EggSeed127.Text = "Go!";
            this.B_EggSeed127.UseVisualStyleBackColor = true;
            this.B_EggSeed127.Click += new System.EventHandler(this.B_EggSeed127_Click);
            // 
            // GB_TinyFinder
            // 
            this.GB_TinyFinder.Controls.Add(this.B_DelNature);
            this.GB_TinyFinder.Controls.Add(this.NatureInput);
            this.GB_TinyFinder.Controls.Add(this.L_Progress7);
            this.GB_TinyFinder.Controls.Add(this.Gen7PBar);
            this.GB_TinyFinder.Controls.Add(this.EggSeedList);
            this.GB_TinyFinder.Controls.Add(this.L_NatureList);
            this.GB_TinyFinder.Controls.Add(this.NatureList);
            this.GB_TinyFinder.Controls.Add(this.B_Abort7);
            this.GB_TinyFinder.Controls.Add(this.B_TinySearch);
            this.GB_TinyFinder.Location = new System.Drawing.Point(318, 9);
            this.GB_TinyFinder.Name = "GB_TinyFinder";
            this.GB_TinyFinder.Size = new System.Drawing.Size(308, 244);
            this.GB_TinyFinder.TabIndex = 106;
            this.GB_TinyFinder.TabStop = false;
            // 
            // B_DelNature
            // 
            this.B_DelNature.Location = new System.Drawing.Point(163, 68);
            this.B_DelNature.Name = "B_DelNature";
            this.B_DelNature.Size = new System.Drawing.Size(61, 25);
            this.B_DelNature.TabIndex = 118;
            this.B_DelNature.Text = "删去";
            this.B_DelNature.UseVisualStyleBackColor = true;
            this.B_DelNature.Click += new System.EventHandler(this.B_DelNature_Click);
            // 
            // NatureInput
            // 
            this.NatureInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NatureInput.Location = new System.Drawing.Point(9, 70);
            this.NatureInput.Name = "NatureInput";
            this.NatureInput.Size = new System.Drawing.Size(90, 21);
            this.NatureInput.TabIndex = 93;
            this.NatureInput.SelectedIndexChanged += new System.EventHandler(this.NatureInput_SelectedIndexChanged);
            // 
            // L_Progress7
            // 
            this.L_Progress7.AutoSize = true;
            this.L_Progress7.Location = new System.Drawing.Point(260, 108);
            this.L_Progress7.Name = "L_Progress7";
            this.L_Progress7.Size = new System.Drawing.Size(36, 13);
            this.L_Progress7.TabIndex = 116;
            this.L_Progress7.Text = "0.00%";
            // 
            // Gen7PBar
            // 
            this.Gen7PBar.Location = new System.Drawing.Point(9, 105);
            this.Gen7PBar.Name = "Gen7PBar";
            this.Gen7PBar.Size = new System.Drawing.Size(240, 18);
            this.Gen7PBar.TabIndex = 98;
            // 
            // EggSeedList
            // 
            this.EggSeedList.FormattingEnabled = true;
            this.EggSeedList.Location = new System.Drawing.Point(9, 145);
            this.EggSeedList.Name = "EggSeedList";
            this.EggSeedList.Size = new System.Drawing.Size(290, 82);
            this.EggSeedList.TabIndex = 29;
            // 
            // L_NatureList
            // 
            this.L_NatureList.AutoSize = true;
            this.L_NatureList.Location = new System.Drawing.Point(6, 35);
            this.L_NatureList.Name = "L_NatureList";
            this.L_NatureList.Size = new System.Drawing.Size(55, 13);
            this.L_NatureList.TabIndex = 27;
            this.L_NatureList.Text = "性格序列";
            // 
            // NatureList
            // 
            this.NatureList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NatureList.Location = new System.Drawing.Point(82, 32);
            this.NatureList.Name = "NatureList";
            this.NatureList.Size = new System.Drawing.Size(210, 22);
            this.NatureList.TabIndex = 24;
            // 
            // B_Abort7
            // 
            this.B_Abort7.Location = new System.Drawing.Point(233, 68);
            this.B_Abort7.Name = "B_Abort7";
            this.B_Abort7.Size = new System.Drawing.Size(61, 25);
            this.B_Abort7.TabIndex = 99;
            this.B_Abort7.Text = "中断";
            this.B_Abort7.UseVisualStyleBackColor = true;
            this.B_Abort7.Visible = false;
            this.B_Abort7.Click += new System.EventHandler(this.B_Abort7_Click);
            // 
            // B_TinySearch
            // 
            this.B_TinySearch.Location = new System.Drawing.Point(233, 68);
            this.B_TinySearch.Name = "B_TinySearch";
            this.B_TinySearch.Size = new System.Drawing.Size(61, 25);
            this.B_TinySearch.TabIndex = 26;
            this.B_TinySearch.Text = "检索";
            this.B_TinySearch.UseVisualStyleBackColor = true;
            this.B_TinySearch.Click += new System.EventHandler(this.B_TinySearch_Click);
            // 
            // Gen7EggSeedFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 262);
            this.Controls.Add(this.GB_TinyFinder);
            this.Controls.Add(this.Magikarp);
            this.MaximumSize = new System.Drawing.Size(650, 300);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Gen7EggSeedFinder";
            this.Text = "Gen7EggSeedFinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gen7EggSeedFinder_FormClosing);
            this.Magikarp.ResumeLayout(false);
            this.Magikarp.PerformLayout();
            this.GB_TinyFinder.ResumeLayout(false);
            this.GB_TinyFinder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Magikarp;
        private System.Windows.Forms.RichTextBox RTB_EggSeed;
        private System.Windows.Forms.Button B_EggSeed127;
        private System.Windows.Forms.GroupBox GB_TinyFinder;
        private System.Windows.Forms.Button B_DelNature;
        private System.Windows.Forms.ComboBox NatureInput;
        private System.Windows.Forms.Label L_Progress7;
        private System.Windows.Forms.ProgressBar Gen7PBar;
        private System.Windows.Forms.ListBox EggSeedList;
        private System.Windows.Forms.Label L_NatureList;
        private System.Windows.Forms.TextBox NatureList;
        private System.Windows.Forms.Button B_TinySearch;
        private System.Windows.Forms.Button B_Abort7;
        private System.Windows.Forms.Label L_Magikarp;
    }
}