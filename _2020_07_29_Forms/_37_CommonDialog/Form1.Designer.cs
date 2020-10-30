namespace _37_CommonDialog
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
            this.btnOpenFlie = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFlie
            // 
            this.btnOpenFlie.Location = new System.Drawing.Point(53, 41);
            this.btnOpenFlie.Name = "btnOpenFlie";
            this.btnOpenFlie.Size = new System.Drawing.Size(238, 96);
            this.btnOpenFlie.TabIndex = 0;
            this.btnOpenFlie.Text = "파일 열기 상자";
            this.btnOpenFlie.UseVisualStyleBackColor = true;
            this.btnOpenFlie.Click += new System.EventHandler(this.btnOpenFlie_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(53, 158);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(238, 96);
            this.btnSaveFile.TabIndex = 0;
            this.btnSaveFile.Text = "파일 저장 상자";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(53, 277);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(238, 96);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "폰트 선택 상자";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(53, 396);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(238, 96);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "컬러 선택 상자";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 516);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFlie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFlie;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
    }
}

