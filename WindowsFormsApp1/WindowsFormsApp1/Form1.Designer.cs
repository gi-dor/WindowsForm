namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tboxItem = new System.Windows.Forms.TextBox();
            
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnClickThis);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_clickHere);
            // 
            // tboxItem
            // 
            this.tboxItem.Location = new System.Drawing.Point(299, 36);
            this.tboxItem.Name = "tboxItem";
            this.tboxItem.Size = new System.Drawing.Size(244, 21);
            this.tboxItem.TabIndex = 3;
            this.tboxItem.Text = "sdsd";
            this.tboxItem.TextChanged += new System.EventHandler(this.tboxItem_TextChanged);
         
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(34, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "알림 메세지박스";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(34, 205);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(179, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "확인 취소 박스";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(34, 247);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(179, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "다시시도 박스";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tboxItem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tboxItem;

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
    }
}

