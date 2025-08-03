namespace TawandaSystem
{
    partial class AccessControl
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDonationT = new System.Windows.Forms.Button();
            this.btnDonations = new System.Windows.Forms.Button();
            this.btnChildren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(128, 30);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(297, 25);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "ACCESS MANAGEMENT";
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnBack);
            this.gbSelect.Controls.Add(this.btnDonationT);
            this.gbSelect.Controls.Add(this.btnDonations);
            this.gbSelect.Controls.Add(this.btnChildren);
            this.gbSelect.Location = new System.Drawing.Point(133, 76);
            this.gbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Padding = new System.Windows.Forms.Padding(4);
            this.gbSelect.Size = new System.Drawing.Size(321, 265);
            this.gbSelect.TabIndex = 3;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select Records to Maintain";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(87, 193);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 44);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnDonationT
            // 
            this.btnDonationT.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDonationT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonationT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDonationT.Location = new System.Drawing.Point(87, 146);
            this.btnDonationT.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonationT.Name = "btnDonationT";
            this.btnDonationT.Size = new System.Drawing.Size(155, 44);
            this.btnDonationT.TabIndex = 7;
            this.btnDonationT.Text = "Donation Types";
            this.btnDonationT.UseVisualStyleBackColor = false;
            this.btnDonationT.Click += new System.EventHandler(this.btnDonationT_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonations.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDonations.Location = new System.Drawing.Point(87, 95);
            this.btnDonations.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(155, 44);
            this.btnDonations.TabIndex = 6;
            this.btnDonations.Text = "Donations";
            this.btnDonations.UseVisualStyleBackColor = false;
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // btnChildren
            // 
            this.btnChildren.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildren.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChildren.Location = new System.Drawing.Point(87, 43);
            this.btnChildren.Margin = new System.Windows.Forms.Padding(4);
            this.btnChildren.Name = "btnChildren";
            this.btnChildren.Size = new System.Drawing.Size(155, 44);
            this.btnChildren.TabIndex = 5;
            this.btnChildren.Text = "Children";
            this.btnChildren.UseVisualStyleBackColor = false;
            this.btnChildren.Click += new System.EventHandler(this.btnChildren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // AccessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(583, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccessControl";
            this.Text = "ACCESS CONTROL";
            this.gbSelect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button btnChildren;
        private System.Windows.Forms.Button btnDonationT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnDonations;
    }
}