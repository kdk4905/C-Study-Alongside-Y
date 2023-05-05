namespace AnimalShelter
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
            this.ClickCustomer = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.CusFullName1 = new System.Windows.Forms.Label();
            this.CusAge1 = new System.Windows.Forms.Label();
            this.CusAddress1 = new System.Windows.Forms.Label();
            this.CusDescription1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CusDetailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClickCustomer
            // 
            this.ClickCustomer.Location = new System.Drawing.Point(284, 350);
            this.ClickCustomer.Name = "ClickCustomer";
            this.ClickCustomer.Size = new System.Drawing.Size(75, 44);
            this.ClickCustomer.TabIndex = 0;
            this.ClickCustomer.Text = "입양자생성";
            this.ClickCustomer.UseVisualStyleBackColor = true;
            this.ClickCustomer.Click += new System.EventHandler(this.ClickCustomer_Click);
            // 
            // CusDetailPanel
            // 
            this.CusDetailPanel.Controls.Add(this.CusIsQualified);
            this.CusDetailPanel.Controls.Add(this.lable2);
            this.CusDetailPanel.Controls.Add(this.CusDescription);
            this.CusDetailPanel.Controls.Add(this.CusDescription1);
            this.CusDetailPanel.Controls.Add(this.CusAddress);
            this.CusDetailPanel.Controls.Add(this.CusAddress1);
            this.CusDetailPanel.Controls.Add(this.CusAge);
            this.CusDetailPanel.Controls.Add(this.CusAge1);
            this.CusDetailPanel.Controls.Add(this.CusFullName);
            this.CusDetailPanel.Controls.Add(this.CusFullName1);
            this.CusDetailPanel.Location = new System.Drawing.Point(538, 12);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(250, 426);
            this.CusDetailPanel.TabIndex = 1;
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(87, 63);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(29, 12);
            this.CusIsQualified.TabIndex = 11;
            this.CusIsQualified.Text = "이름";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(87, 105);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(29, 12);
            this.CusDescription.TabIndex = 9;
            this.CusDescription.Text = "이름";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(87, 84);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(29, 12);
            this.CusAddress.TabIndex = 7;
            this.CusAddress.Text = "이름";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(87, 39);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(29, 12);
            this.CusAge.TabIndex = 5;
            this.CusAge.Text = "이름";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(87, 16);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(29, 12);
            this.CusFullName.TabIndex = 3;
            this.CusFullName.Text = "이름";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.ClickCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.label1);
            this.CusNewPanel.Controls.Add(this.label4);
            this.CusNewPanel.Controls.Add(this.label2);
            this.CusNewPanel.Controls.Add(this.label5);
            this.CusNewPanel.Controls.Add(this.label3);
            this.CusNewPanel.Location = new System.Drawing.Point(138, 12);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(394, 426);
            this.CusNewPanel.TabIndex = 2;
            // 
            // CusFullName1
            // 
            this.CusFullName1.AutoSize = true;
            this.CusFullName1.Location = new System.Drawing.Point(14, 16);
            this.CusFullName1.Name = "CusFullName1";
            this.CusFullName1.Size = new System.Drawing.Size(37, 12);
            this.CusFullName1.TabIndex = 2;
            this.CusFullName1.Text = "이름 :";
            // 
            // CusAge1
            // 
            this.CusAge1.AutoSize = true;
            this.CusAge1.Location = new System.Drawing.Point(14, 39);
            this.CusAge1.Name = "CusAge1";
            this.CusAge1.Size = new System.Drawing.Size(37, 12);
            this.CusAge1.TabIndex = 4;
            this.CusAge1.Text = "나이 :";
            // 
            // CusAddress1
            // 
            this.CusAddress1.AutoSize = true;
            this.CusAddress1.Location = new System.Drawing.Point(14, 84);
            this.CusAddress1.Name = "CusAddress1";
            this.CusAddress1.Size = new System.Drawing.Size(37, 12);
            this.CusAddress1.TabIndex = 6;
            this.CusAddress1.Text = "주소 :";
            // 
            // CusDescription1
            // 
            this.CusDescription1.AutoSize = true;
            this.CusDescription1.Location = new System.Drawing.Point(14, 105);
            this.CusDescription1.Name = "CusDescription1";
            this.CusDescription1.Size = new System.Drawing.Size(37, 12);
            this.CusDescription1.TabIndex = 8;
            this.CusDescription1.Text = "설명 :";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(14, 63);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(67, 12);
            this.lable2.TabIndex = 10;
            this.lable2.Text = "입양가능? :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "생일 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "설명 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "주소 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "이름 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "성 :";
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(105, 20);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(105, 21);
            this.CusNewFirstName.TabIndex = 17;
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(105, 57);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(105, 21);
            this.CusNewLastName.TabIndex = 18;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(105, 94);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(105, 21);
            this.CusNewBirthday.TabIndex = 19;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(105, 121);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(105, 21);
            this.CusNewAddress.TabIndex = 20;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(105, 158);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(254, 186);
            this.CusNewDescription.TabIndex = 21;
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 12;
            this.CustomerList.Location = new System.Drawing.Point(12, 12);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(120, 424);
            this.CustomerList.TabIndex = 22;
            this.CustomerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDetailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickCustomer;
        private System.Windows.Forms.Panel CusDetailPanel;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label CusDescription1;
        private System.Windows.Forms.Label CusAddress1;
        private System.Windows.Forms.Label CusAge1;
        private System.Windows.Forms.Label CusFullName1;
        private System.Windows.Forms.Panel CusNewPanel;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CustomerList;
    }
}

