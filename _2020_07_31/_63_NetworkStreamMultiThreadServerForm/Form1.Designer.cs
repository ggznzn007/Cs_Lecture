﻿namespace _63_NetworkStreamMultiThreadServerForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.Font = new System.Drawing.Font("문체부 돋음체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 27;
            this.lbLog.Location = new System.Drawing.Point(12, 98);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(776, 409);
            this.lbLog.TabIndex = 0;
            
            // 
            // tbPort
            // 
            this.tbPort.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tbPort.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPort.Location = new System.Drawing.Point(110, 12);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(204, 50);
            this.tbPort.TabIndex = 1;
            this.tbPort.Text = "9000";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "port";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("궁서", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(333, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("궁서", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.Location = new System.Drawing.Point(493, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(144, 50);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("궁서", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(643, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 671);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
    }
}

