namespace _23_radio_checkbox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMoney = new System.Windows.Forms.CheckBox();
            this.chkHonor = new System.Windows.Forms.CheckBox();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.chkPower = new System.Windows.Forms.CheckBox();
            this.radioDestroyer = new System.Windows.Forms.RadioButton();
            this.radioNomal = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.chkLove = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLove);
            this.groupBox1.Controls.Add(this.chkPower);
            this.groupBox1.Controls.Add(this.chkForce);
            this.groupBox1.Controls.Add(this.chkHonor);
            this.groupBox1.Controls.Add(this.chkMoney);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "갖고 싶은 것(2개만 가능)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNomal);
            this.groupBox2.Controls.Add(this.radioDestroyer);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(26, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1106, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "되고 싶은 사람";
            // 
            // chkMoney
            // 
            this.chkMoney.AutoSize = true;
            this.chkMoney.Location = new System.Drawing.Point(19, 61);
            this.chkMoney.Name = "chkMoney";
            this.chkMoney.Size = new System.Drawing.Size(67, 36);
            this.chkMoney.TabIndex = 0;
            this.chkMoney.Text = "돈";
            this.chkMoney.UseVisualStyleBackColor = true;
            // 
            // chkHonor
            // 
            this.chkHonor.AutoSize = true;
            this.chkHonor.Location = new System.Drawing.Point(231, 61);
            this.chkHonor.Name = "chkHonor";
            this.chkHonor.Size = new System.Drawing.Size(100, 36);
            this.chkHonor.TabIndex = 0;
            this.chkHonor.Text = "명예";
            this.chkHonor.UseVisualStyleBackColor = true;
            // 
            // chkForce
            // 
            this.chkForce.AutoSize = true;
            this.chkForce.Location = new System.Drawing.Point(443, 61);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(67, 36);
            this.chkForce.TabIndex = 0;
            this.chkForce.Text = "힘";
            this.chkForce.UseVisualStyleBackColor = true;
            // 
            // chkPower
            // 
            this.chkPower.AutoSize = true;
            this.chkPower.Location = new System.Drawing.Point(655, 61);
            this.chkPower.Name = "chkPower";
            this.chkPower.Size = new System.Drawing.Size(100, 36);
            this.chkPower.TabIndex = 0;
            this.chkPower.Text = "권력";
            this.chkPower.UseVisualStyleBackColor = true;
            // 
            // radioDestroyer
            // 
            this.radioDestroyer.AutoSize = true;
            this.radioDestroyer.Location = new System.Drawing.Point(81, 75);
            this.radioDestroyer.Name = "radioDestroyer";
            this.radioDestroyer.Size = new System.Drawing.Size(583, 36);
            this.radioDestroyer.TabIndex = 0;
            this.radioDestroyer.TabStop = true;
            this.radioDestroyer.Text = "카리스마 무소불위 파괴자(재산20조)";
            this.radioDestroyer.UseVisualStyleBackColor = true;
            // 
            // radioNomal
            // 
            this.radioNomal.AutoSize = true;
            this.radioNomal.Location = new System.Drawing.Point(81, 127);
            this.radioNomal.Name = "radioNomal";
            this.radioNomal.Size = new System.Drawing.Size(609, 36);
            this.radioNomal.TabIndex = 0;
            this.radioNomal.TabStop = true;
            this.radioNomal.Text = "평범하고 가정적인 사람(연봉 5천만원)";
            this.radioNomal.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(469, 543);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(186, 60);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "당신의 선택";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // chkLove
            // 
            this.chkLove.AutoSize = true;
            this.chkLove.Location = new System.Drawing.Point(884, 61);
            this.chkLove.Name = "chkLove";
            this.chkLove.Size = new System.Drawing.Size(100, 36);
            this.chkLove.TabIndex = 0;
            this.chkLove.Text = "사랑";
            this.chkLove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 643);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLove;
        private System.Windows.Forms.CheckBox chkPower;
        private System.Windows.Forms.CheckBox chkForce;
        private System.Windows.Forms.CheckBox chkHonor;
        private System.Windows.Forms.CheckBox chkMoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioNomal;
        private System.Windows.Forms.RadioButton radioDestroyer;
        private System.Windows.Forms.Button btnSelect;
    }
}

