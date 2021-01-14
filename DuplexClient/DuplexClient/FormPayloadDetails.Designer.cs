
namespace DuplexClient
{
    partial class FormPayloadDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StartTelemetry = new System.Windows.Forms.Button();
            this.btn_StopTelemetry = new System.Windows.Forms.Button();
            this.textBox_Tele = new System.Windows.Forms.TextBox();
            this.btn_Decommission = new System.Windows.Forms.Button();
            this.btn_StartData = new System.Windows.Forms.Button();
            this.btn_StopData = new System.Windows.Forms.Button();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payload Details";
            // 
            // btn_StartTelemetry
            // 
            this.btn_StartTelemetry.Location = new System.Drawing.Point(154, 89);
            this.btn_StartTelemetry.Name = "btn_StartTelemetry";
            this.btn_StartTelemetry.Size = new System.Drawing.Size(187, 23);
            this.btn_StartTelemetry.TabIndex = 1;
            this.btn_StartTelemetry.Text = "Start Telemetry";
            this.btn_StartTelemetry.UseVisualStyleBackColor = true;
            this.btn_StartTelemetry.Click += new System.EventHandler(this.btn_StartTelemetry_Click);
            // 
            // btn_StopTelemetry
            // 
            this.btn_StopTelemetry.Location = new System.Drawing.Point(154, 134);
            this.btn_StopTelemetry.Name = "btn_StopTelemetry";
            this.btn_StopTelemetry.Size = new System.Drawing.Size(187, 23);
            this.btn_StopTelemetry.TabIndex = 2;
            this.btn_StopTelemetry.Text = "Stop Telemetry";
            this.btn_StopTelemetry.UseVisualStyleBackColor = true;
            this.btn_StopTelemetry.Click += new System.EventHandler(this.btn_StopTelemetry_Click);
            // 
            // textBox_Tele
            // 
            this.textBox_Tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tele.Location = new System.Drawing.Point(405, 89);
            this.textBox_Tele.Multiline = true;
            this.textBox_Tele.Name = "textBox_Tele";
            this.textBox_Tele.Size = new System.Drawing.Size(342, 120);
            this.textBox_Tele.TabIndex = 3;
            // 
            // btn_Decommission
            // 
            this.btn_Decommission.Location = new System.Drawing.Point(154, 186);
            this.btn_Decommission.Name = "btn_Decommission";
            this.btn_Decommission.Size = new System.Drawing.Size(187, 23);
            this.btn_Decommission.TabIndex = 4;
            this.btn_Decommission.Text = "Decommission";
            this.btn_Decommission.UseVisualStyleBackColor = true;
            this.btn_Decommission.Click += new System.EventHandler(this.btn_Decommission_Click);
            // 
            // btn_StartData
            // 
            this.btn_StartData.Location = new System.Drawing.Point(154, 256);
            this.btn_StartData.Name = "btn_StartData";
            this.btn_StartData.Size = new System.Drawing.Size(187, 23);
            this.btn_StartData.TabIndex = 5;
            this.btn_StartData.Text = "StartData";
            this.btn_StartData.UseVisualStyleBackColor = true;
            this.btn_StartData.Click += new System.EventHandler(this.btn_StartData_Click);
            // 
            // btn_StopData
            // 
            this.btn_StopData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_StopData.Location = new System.Drawing.Point(405, 256);
            this.btn_StopData.Name = "btn_StopData";
            this.btn_StopData.Size = new System.Drawing.Size(187, 23);
            this.btn_StopData.TabIndex = 6;
            this.btn_StopData.Text = "StopData";
            this.btn_StopData.UseVisualStyleBackColor = true;
            this.btn_StopData.Click += new System.EventHandler(this.btn_StopData_Click);
            // 
            // textBox_Data
            // 
            this.textBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Data.Location = new System.Drawing.Point(154, 302);
            this.textBox_Data.Multiline = true;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(204, 258);
            this.textBox_Data.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(405, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 258);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormPayloadDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.btn_StopData);
            this.Controls.Add(this.btn_StartData);
            this.Controls.Add(this.btn_Decommission);
            this.Controls.Add(this.textBox_Tele);
            this.Controls.Add(this.btn_StopTelemetry);
            this.Controls.Add(this.btn_StartTelemetry);
            this.Controls.Add(this.label1);
            this.Name = "FormPayloadDetails";
            this.Text = "PayloadDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_StartTelemetry;
        private System.Windows.Forms.Button btn_StopTelemetry;
        private System.Windows.Forms.Button btn_Decommission;
        private System.Windows.Forms.Button btn_StartData;
        private System.Windows.Forms.Button btn_StopData;
        public System.Windows.Forms.TextBox textBox_Tele;
        public System.Windows.Forms.TextBox textBox_Data;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}