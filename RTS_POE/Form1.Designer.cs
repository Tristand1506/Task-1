namespace RTS_POE
{
    partial class GameWindow
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
            this.lblGridMap = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.rtbUnitInfo = new System.Windows.Forms.RichTextBox();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblGridMap
            // 
            this.lblGridMap.AutoSize = true;
            this.lblGridMap.Location = new System.Drawing.Point(14, 13);
            this.lblGridMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGridMap.Name = "lblGridMap";
            this.lblGridMap.Size = new System.Drawing.Size(113, 13);
            this.lblGridMap.TabIndex = 0;
            this.lblGridMap.Text = "Game Map Goes Here";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(484, 7);
            this.lblRound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(123, 31);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round 1";
            this.lblRound.Click += new System.EventHandler(this.lblRound_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(472, 366);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(134, 40);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // rtbUnitInfo
            // 
            this.rtbUnitInfo.Location = new System.Drawing.Point(472, 43);
            this.rtbUnitInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbUnitInfo.Name = "rtbUnitInfo";
            this.rtbUnitInfo.Size = new System.Drawing.Size(135, 305);
            this.rtbUnitInfo.TabIndex = 3;
            this.rtbUnitInfo.Text = "";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 416);
            this.Controls.Add(this.rtbUnitInfo);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblGridMap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameWindow";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGridMap;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.RichTextBox rtbUnitInfo;
        private System.Windows.Forms.Timer tmrClock;
    }
}

