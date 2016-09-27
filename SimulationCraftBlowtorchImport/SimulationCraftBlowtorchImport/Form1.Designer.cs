namespace SimulationCraftBlowtorchImport
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
            this.buttonParseScalingFactors = new System.Windows.Forms.Button();
            this.fbdLogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.labelFolder = new System.Windows.Forms.Label();
            this.buttonParseBonuses = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonParseScalingFactors
            // 
            this.buttonParseScalingFactors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParseScalingFactors.Location = new System.Drawing.Point(816, 13);
            this.buttonParseScalingFactors.Name = "buttonParseScalingFactors";
            this.buttonParseScalingFactors.Size = new System.Drawing.Size(137, 23);
            this.buttonParseScalingFactors.TabIndex = 1;
            this.buttonParseScalingFactors.Text = "Parse Scaling Factors";
            this.buttonParseScalingFactors.UseVisualStyleBackColor = true;
            this.buttonParseScalingFactors.Click += new System.EventHandler(this.buttonParseScalingFactors_Click);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(12, 13);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(89, 23);
            this.buttonSelectFolder.TabIndex = 2;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(107, 18);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(0, 13);
            this.labelFolder.TabIndex = 3;
            // 
            // buttonParseBonuses
            // 
            this.buttonParseBonuses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParseBonuses.Location = new System.Drawing.Point(959, 13);
            this.buttonParseBonuses.Name = "buttonParseBonuses";
            this.buttonParseBonuses.Size = new System.Drawing.Size(101, 23);
            this.buttonParseBonuses.TabIndex = 4;
            this.buttonParseBonuses.Text = "Parse Bonuses";
            this.buttonParseBonuses.UseVisualStyleBackColor = true;
            this.buttonParseBonuses.Click += new System.EventHandler(this.buttonParseBonuses_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(-1, 42);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1072, 613);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 656);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.buttonParseBonuses);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.buttonParseScalingFactors);
            this.Name = "Form1";
            this.Text = "Parse SimulationCraft Blowtorch Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonParseScalingFactors;
        private System.Windows.Forms.FolderBrowserDialog fbdLogFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button buttonParseBonuses;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

