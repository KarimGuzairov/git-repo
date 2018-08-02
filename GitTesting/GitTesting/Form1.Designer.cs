namespace GitTesting
{
    partial class PowerShellButtons
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
            this.StopServiceButton = new System.Windows.Forms.Button();
            this.GetServiceButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.StartServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StopServiceButton
            // 
            this.StopServiceButton.Location = new System.Drawing.Point(37, 394);
            this.StopServiceButton.Name = "StopServiceButton";
            this.StopServiceButton.Size = new System.Drawing.Size(75, 44);
            this.StopServiceButton.TabIndex = 0;
            this.StopServiceButton.Text = "Stop Service";
            this.StopServiceButton.UseVisualStyleBackColor = true;
            this.StopServiceButton.Click += new System.EventHandler(this.StopServiceButton_Click);
            // 
            // GetServiceButton
            // 
            this.GetServiceButton.Location = new System.Drawing.Point(235, 394);
            this.GetServiceButton.Name = "GetServiceButton";
            this.GetServiceButton.Size = new System.Drawing.Size(75, 44);
            this.GetServiceButton.TabIndex = 1;
            this.GetServiceButton.Text = "Get Service";
            this.GetServiceButton.UseVisualStyleBackColor = true;
            this.GetServiceButton.Click += new System.EventHandler(this.GetServiceButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(329, 394);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 44);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(37, 24);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(206, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Hello, user! Use buttons to deal two works";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // StartServiceButton
            // 
            this.StartServiceButton.Location = new System.Drawing.Point(137, 394);
            this.StartServiceButton.Name = "StartServiceButton";
            this.StartServiceButton.Size = new System.Drawing.Size(75, 44);
            this.StartServiceButton.TabIndex = 4;
            this.StartServiceButton.Text = "Start Service";
            this.StartServiceButton.UseVisualStyleBackColor = true;
            this.StartServiceButton.Click += new System.EventHandler(this.StartServiceButton_Click);
            // 
            // PowerShellButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.StartServiceButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GetServiceButton);
            this.Controls.Add(this.StopServiceButton);
            this.Name = "PowerShellButtons";
            this.Text = "Powershell Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StopServiceButton;
        private System.Windows.Forms.Button GetServiceButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button StartServiceButton;
    }
}

