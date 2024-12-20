namespace SimpleKVM.GUI
{
    partial class UcSelectMonitorSource
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
            lblMonitorName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cmbSources = new System.Windows.Forms.ComboBox();
            cmbSources1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblMonitorName
            // 
            lblMonitorName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMonitorName.Location = new System.Drawing.Point(14, 8);
            lblMonitorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblMonitorName.Name = "lblMonitorName";
            lblMonitorName.Size = new System.Drawing.Size(197, 15);
            lblMonitorName.TabIndex = 0;
            lblMonitorName.Text = "lblMonitorName";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(215, 8);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Source 1:";
            // 
            // cmbSources
            // 
            cmbSources.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cmbSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSources.FormattingEnabled = true;
            cmbSources.Location = new System.Drawing.Point(268, 6);
            cmbSources.Margin = new System.Windows.Forms.Padding(2);
            cmbSources.Name = "cmbSources";
            cmbSources.Size = new System.Drawing.Size(144, 23);
            cmbSources.TabIndex = 2;
            //
            // cmbSources1
            // 
            cmbSources1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cmbSources1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSources1.FormattingEnabled = true;
            cmbSources1.Location = new System.Drawing.Point(468, 6);
            cmbSources1.Margin = new System.Windows.Forms.Padding(2);
            cmbSources1.Name = "cmbSources1";
            cmbSources1.Size = new System.Drawing.Size(144, 23);
            cmbSources1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(415, 8);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 15);
            label3.TabIndex = 1;
            label3.Text = "Source 2:";
            // 
            // UcSelectMonitorSource
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(cmbSources);
            Controls.Add(cmbSources1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblMonitorName);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "UcSelectMonitorSource";
            Size = new System.Drawing.Size(620, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMonitorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSources;
        private System.Windows.Forms.ComboBox cmbSources1;
    }
}
