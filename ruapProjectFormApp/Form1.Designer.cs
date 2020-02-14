namespace ruapProjectFormApp
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblResidualShugar = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbResidualShugar = new System.Windows.Forms.TextBox();
            this.tbAlcohol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(66, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // lblResidualShugar
            // 
            this.lblResidualShugar.AutoSize = true;
            this.lblResidualShugar.Location = new System.Drawing.Point(66, 127);
            this.lblResidualShugar.Name = "lblResidualShugar";
            this.lblResidualShugar.Size = new System.Drawing.Size(105, 13);
            this.lblResidualShugar.TabIndex = 1;
            this.lblResidualShugar.Text = "Residual shugar [g/l]";
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Location = new System.Drawing.Point(66, 168);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(53, 13);
            this.lblAlcohol.TabIndex = 2;
            this.lblAlcohol.Text = "Alcohol %";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(299, 311);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(218, 311);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cbType
            // 
            this.cbType.AllowDrop = true;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "red",
            "white"});
            this.cbType.Location = new System.Drawing.Point(218, 79);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 5;
            this.cbType.Text = "red";
            // 
            // tbResidualShugar
            // 
            this.tbResidualShugar.Location = new System.Drawing.Point(218, 120);
            this.tbResidualShugar.Name = "tbResidualShugar";
            this.tbResidualShugar.Size = new System.Drawing.Size(121, 20);
            this.tbResidualShugar.TabIndex = 6;
            // 
            // tbAlcohol
            // 
            this.tbAlcohol.Location = new System.Drawing.Point(218, 160);
            this.tbAlcohol.Name = "tbAlcohol";
            this.tbAlcohol.Size = new System.Drawing.Size(121, 20);
            this.tbAlcohol.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 346);
            this.Controls.Add(this.tbAlcohol);
            this.Controls.Add(this.tbResidualShugar);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.lblAlcohol);
            this.Controls.Add(this.lblResidualShugar);
            this.Controls.Add(this.lblType);
            this.Name = "Form1";
            this.Text = "Wine Classification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResidualShugar;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbResidualShugar;
        private System.Windows.Forms.TextBox tbAlcohol;
    }
}

