
namespace DuplexClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.ServiceNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfigTextBox = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.BtnViewDetail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PayloadNum = new System.Windows.Forms.TextBox();
            this.btn_ViewPayload = new System.Windows.Forms.Button();
            this.dataGridView_Payload = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payload)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Launch  Spacecraft";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exeClick);
            // 
            // ServiceNum
            // 
            this.ServiceNum.Location = new System.Drawing.Point(243, 155);
            this.ServiceNum.Name = "ServiceNum";
            this.ServiceNum.ReadOnly = true;
            this.ServiceNum.Size = new System.Drawing.Size(71, 20);
            this.ServiceNum.TabIndex = 7;
            this.ServiceNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected Spacecraft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Configuration file";
            // 
            // ConfigTextBox
            // 
            this.ConfigTextBox.Location = new System.Drawing.Point(136, 85);
            this.ConfigTextBox.Name = "ConfigTextBox";
            this.ConfigTextBox.Size = new System.Drawing.Size(521, 20);
            this.ConfigTextBox.TabIndex = 10;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(515, 111);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(142, 23);
            this.btnConfig.TabIndex = 11;
            this.btnConfig.Text = "Browse Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // BtnViewDetail
            // 
            this.BtnViewDetail.Location = new System.Drawing.Point(529, 152);
            this.BtnViewDetail.Name = "BtnViewDetail";
            this.BtnViewDetail.Size = new System.Drawing.Size(128, 23);
            this.BtnViewDetail.TabIndex = 12;
            this.BtnViewDetail.Text = "View Details";
            this.BtnViewDetail.UseVisualStyleBackColor = true;
            this.BtnViewDetail.Click += new System.EventHandler(this.btnViewDetails_click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Deep Space Network";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Author:   Chongke Wu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contact: chongkewu@email.arziona.edu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Selected Payload";
            // 
            // textBox_PayloadNum
            // 
            this.textBox_PayloadNum.Location = new System.Drawing.Point(232, 413);
            this.textBox_PayloadNum.Name = "textBox_PayloadNum";
            this.textBox_PayloadNum.ReadOnly = true;
            this.textBox_PayloadNum.Size = new System.Drawing.Size(67, 20);
            this.textBox_PayloadNum.TabIndex = 19;
            this.textBox_PayloadNum.Text = "0";
            // 
            // btn_ViewPayload
            // 
            this.btn_ViewPayload.Location = new System.Drawing.Point(139, 464);
            this.btn_ViewPayload.Name = "btn_ViewPayload";
            this.btn_ViewPayload.Size = new System.Drawing.Size(160, 23);
            this.btn_ViewPayload.TabIndex = 20;
            this.btn_ViewPayload.Text = "View Selected Payload";
            this.btn_ViewPayload.UseVisualStyleBackColor = true;
            this.btn_ViewPayload.Click += new System.EventHandler(this.btn_ViewPayload_Click);
            // 
            // dataGridView_Payload
            // 
            this.dataGridView_Payload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payload.Location = new System.Drawing.Point(417, 413);
            this.dataGridView_Payload.Name = "dataGridView_Payload";
            this.dataGridView_Payload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Payload.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_Payload.TabIndex = 21;
            this.dataGridView_Payload.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Payload_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 685);
            this.Controls.Add(this.dataGridView_Payload);
            this.Controls.Add(this.btn_ViewPayload);
            this.Controls.Add(this.textBox_PayloadNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnViewDetail);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.ConfigTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceNum);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DSN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfigTextBox;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button BtnViewDetail;
        public System.Windows.Forms.TextBox ServiceNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ViewPayload;
        private System.Windows.Forms.DataGridView dataGridView_Payload;
        public System.Windows.Forms.TextBox textBox_PayloadNum;
    }
}

