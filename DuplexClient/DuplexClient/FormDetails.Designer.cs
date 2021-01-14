
namespace DuplexClient
{
    partial class FormDetails
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
            this.LabelDetailTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_stopTele = new System.Windows.Forms.Button();
            this.btn_Deorbit = new System.Windows.Forms.Button();
            this.btn_DeployPayload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelDetailTitle
            // 
            this.LabelDetailTitle.AutoSize = true;
            this.LabelDetailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailTitle.Location = new System.Drawing.Point(262, 15);
            this.LabelDetailTitle.Name = "LabelDetailTitle";
            this.LabelDetailTitle.Size = new System.Drawing.Size(225, 29);
            this.LabelDetailTitle.TabIndex = 0;
            this.LabelDetailTitle.Text = "Spacecraft Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Telemetry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStartTele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(258, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 163);
            this.textBox1.TabIndex = 2;
            // 
            // btn_stopTele
            // 
            this.btn_stopTele.Location = new System.Drawing.Point(84, 115);
            this.btn_stopTele.Name = "btn_stopTele";
            this.btn_stopTele.Size = new System.Drawing.Size(128, 23);
            this.btn_stopTele.TabIndex = 3;
            this.btn_stopTele.Text = "Stop Telemetry";
            this.btn_stopTele.UseVisualStyleBackColor = true;
            this.btn_stopTele.Click += new System.EventHandler(this.btnStopTele_Click);
            // 
            // btn_Deorbit
            // 
            this.btn_Deorbit.Location = new System.Drawing.Point(84, 163);
            this.btn_Deorbit.Name = "btn_Deorbit";
            this.btn_Deorbit.Size = new System.Drawing.Size(128, 23);
            this.btn_Deorbit.TabIndex = 4;
            this.btn_Deorbit.Text = "Deorbit";
            this.btn_Deorbit.UseVisualStyleBackColor = true;
            this.btn_Deorbit.Click += new System.EventHandler(this.btn_Deorbit_Click);
            // 
            // btn_DeployPayload
            // 
            this.btn_DeployPayload.Location = new System.Drawing.Point(84, 209);
            this.btn_DeployPayload.Name = "btn_DeployPayload";
            this.btn_DeployPayload.Size = new System.Drawing.Size(128, 23);
            this.btn_DeployPayload.TabIndex = 5;
            this.btn_DeployPayload.Text = "Deploy Payload";
            this.btn_DeployPayload.UseVisualStyleBackColor = true;
            this.btn_DeployPayload.Click += new System.EventHandler(this.btn_DeployPayload_Click);
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 275);
            this.Controls.Add(this.btn_DeployPayload);
            this.Controls.Add(this.btn_Deorbit);
            this.Controls.Add(this.btn_stopTele);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelDetailTitle);
            this.Name = "FormDetails";
            this.Text = "Spacecraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDetailTitle;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_stopTele;
        private System.Windows.Forms.Button btn_Deorbit;
        private System.Windows.Forms.Button btn_DeployPayload;
    }
}