
namespace ScreenBlindfold
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
            this.components = new System.ComponentModel.Container();
            this.toggleButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleButton
            // 
            this.toggleButton.BackColor = System.Drawing.Color.Red;
            this.toggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton.ForeColor = System.Drawing.Color.White;
            this.toggleButton.Location = new System.Drawing.Point(16, 15);
            this.toggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(391, 130);
            this.toggleButton.TabIndex = 0;
            this.toggleButton.Text = "ScreenBlindfold Disabled";
            this.toggleButton.UseVisualStyleBackColor = false;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(352, 144);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(72, 26);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(16, 149);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(172, 17);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Click the button to enable.";
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconMain.BalloonTipText = "ScreenBlindfold has been minimized to the system tray and is running in the backg" +
    "round.";
            this.notifyIconMain.BalloonTipTitle = "ScreenBlindfold Window Hidden";
            this.notifyIconMain.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.notifyIconMain.Text = "ScreenBlindfold";
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleToolStripMenuItem,
            this.toolStripSeparator1,
            this.showWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(233, 82);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.toggleToolStripMenuItem.Text = "Enable ScreenBlindfold";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.showWindowToolStripMenuItem.Text = "Show...";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(424, 171);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.toggleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ScreenBlindfold";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
    }
}

