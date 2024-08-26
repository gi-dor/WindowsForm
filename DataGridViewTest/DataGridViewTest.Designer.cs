namespace Example01
{
    partial class DataGridViewTest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRA_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSelect = new System.Windows.Forms.Button();
            this.dataSelectAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buuttonSelectDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_ID,
            this.USER_NAME,
            this.CUST_ID,
            this.AGY_ID,
            this.COD,
            this.COD_CONT,
            this.BRA_ID,
            this.BRA_NAME});
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(912, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // USER_ID
            // 
            this.USER_ID.HeaderText = "USER_ID";
            this.USER_ID.Name = "USER_ID";
            // 
            // USER_NAME
            // 
            this.USER_NAME.HeaderText = "USER_NAME";
            this.USER_NAME.Name = "USER_NAME";
            // 
            // CUST_ID
            // 
            this.CUST_ID.HeaderText = "CUST_ID";
            this.CUST_ID.Name = "CUST_ID";
            // 
            // AGY_ID
            // 
            this.AGY_ID.HeaderText = "AGY_ID";
            this.AGY_ID.Name = "AGY_ID";
            // 
            // COD
            // 
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            // 
            // COD_CONT
            // 
            this.COD_CONT.HeaderText = "COD_CONT";
            this.COD_CONT.Name = "COD_CONT";
            // 
            // BRA_ID
            // 
            this.BRA_ID.HeaderText = "BRA_ID";
            this.BRA_ID.Name = "BRA_ID";
            // 
            // BRA_NAME
            // 
            this.BRA_NAME.HeaderText = "BRA_NAME";
            this.BRA_NAME.Name = "BRA_NAME";
            // 
            // dataSelect
            // 
            this.dataSelect.Location = new System.Drawing.Point(3, 90);
            this.dataSelect.Name = "dataSelect";
            this.dataSelect.Size = new System.Drawing.Size(161, 39);
            this.dataSelect.TabIndex = 1;
            this.dataSelect.Text = "준비된 값 랜덤 ";
            this.dataSelect.UseVisualStyleBackColor = true;
            this.dataSelect.Click += new System.EventHandler(this.dataSelect_Click);
            // 
            // dataSelectAll
            // 
            this.dataSelectAll.Location = new System.Drawing.Point(200, 90);
            this.dataSelectAll.Name = "dataSelectAll";
            this.dataSelectAll.Size = new System.Drawing.Size(161, 39);
            this.dataSelectAll.TabIndex = 2;
            this.dataSelectAll.Text = "여러건 한번에";
            this.dataSelectAll.UseVisualStyleBackColor = true;
            this.dataSelectAll.Click += new System.EventHandler(this.dataSelectAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(419, 90);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(161, 39);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "모두 삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buuttonSelectDelete
            // 
            this.buuttonSelectDelete.Location = new System.Drawing.Point(628, 90);
            this.buuttonSelectDelete.Name = "buuttonSelectDelete";
            this.buuttonSelectDelete.Size = new System.Drawing.Size(161, 39);
            this.buuttonSelectDelete.TabIndex = 4;
            this.buuttonSelectDelete.Text = "선택된 행 삭제";
            this.buuttonSelectDelete.UseVisualStyleBackColor = true;
            this.buuttonSelectDelete.Click += new System.EventHandler(this.buuttonSelectDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(3, 13);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(161, 38);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "조회";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(200, 13);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(161, 38);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "1건 삽입 ( 미구현 )";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // DataGridViewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 691);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buuttonSelectDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataSelectAll);
            this.Controls.Add(this.dataSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridViewTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRA_ID;
        private System.Windows.Forms.Button dataSelect;
        private System.Windows.Forms.Button dataSelectAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buuttonSelectDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRA_NAME;
        private System.Windows.Forms.Button buttonInsert;
    }
}

