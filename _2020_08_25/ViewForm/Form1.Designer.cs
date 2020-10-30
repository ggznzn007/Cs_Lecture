namespace ViewForm
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
            this.btnJang = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJang
            // 
            this.btnJang.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJang.Location = new System.Drawing.Point(23, 24);
            this.btnJang.Name = "btnJang";
            this.btnJang.Size = new System.Drawing.Size(194, 73);
            this.btnJang.TabIndex = 0;
            this.btnJang.Text = "장나라";
            this.btnJang.UseVisualStyleBackColor = true;
            this.btnJang.Click += new System.EventHandler(this.btnJang_Click);
            // 
            // btnDog
            // 
            this.btnDog.Font = new System.Drawing.Font("휴먼편지체", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDog.Location = new System.Drawing.Point(23, 115);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(194, 73);
            this.btnDog.TabIndex = 0;
            this.btnDog.Text = "강아지";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 209);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.btnJang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJang;
        private System.Windows.Forms.Button btnDog;
    }
}

