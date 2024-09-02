namespace async_await
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnWalk = new Button();
            lblWalk = new Label();
            lblPhone = new Label();
            btnPhone = new Button();
            lblTalk = new Label();
            btnTalk = new Button();
            lbAll = new ListBox();
            btnAll = new Button();
            SuspendLayout();
            // 
            // btnWalk
            // 
            btnWalk.Location = new Point(12, 12);
            btnWalk.Name = "btnWalk";
            btnWalk.Size = new Size(114, 50);
            btnWalk.TabIndex = 0;
            btnWalk.Text = "걷기";
            btnWalk.UseVisualStyleBackColor = true;
            btnWalk.Click += btnWalk_Click;
            // 
            // lblWalk
            // 
            lblWalk.AutoSize = true;
            lblWalk.Location = new Point(132, 25);
            lblWalk.Name = "lblWalk";
            lblWalk.Size = new Size(60, 25);
            lblWalk.TabIndex = 1;
            lblWalk.Text = "label1";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(132, 93);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(60, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "label1";
            // 
            // btnPhone
            // 
            btnPhone.Location = new Point(12, 80);
            btnPhone.Name = "btnPhone";
            btnPhone.Size = new Size(114, 50);
            btnPhone.TabIndex = 2;
            btnPhone.Text = "핸드폰";
            btnPhone.UseVisualStyleBackColor = true;
            btnPhone.Click += btnPhone_Click;
            // 
            // lblTalk
            // 
            lblTalk.AutoSize = true;
            lblTalk.Location = new Point(132, 158);
            lblTalk.Name = "lblTalk";
            lblTalk.Size = new Size(60, 25);
            lblTalk.TabIndex = 5;
            lblTalk.Text = "label1";
            // 
            // btnTalk
            // 
            btnTalk.Location = new Point(12, 145);
            btnTalk.Name = "btnTalk";
            btnTalk.Size = new Size(114, 50);
            btnTalk.TabIndex = 4;
            btnTalk.Text = "말하기";
            btnTalk.UseVisualStyleBackColor = true;
            btnTalk.Click += btnTalk_Click;
            // 
            // lbAll
            // 
            lbAll.FormattingEnabled = true;
            lbAll.ItemHeight = 25;
            lbAll.Location = new Point(349, 12);
            lbAll.Name = "lbAll";
            lbAll.Size = new Size(247, 429);
            lbAll.TabIndex = 6;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(229, 12);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(114, 50);
            btnAll.TabIndex = 7;
            btnAll.Text = "전체";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAll);
            Controls.Add(lbAll);
            Controls.Add(lblTalk);
            Controls.Add(btnTalk);
            Controls.Add(lblPhone);
            Controls.Add(btnPhone);
            Controls.Add(lblWalk);
            Controls.Add(btnWalk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWalk;
        private Label lblWalk;
        private Label lblPhone;
        private Button btnPhone;
        private Label lblTalk;
        private Button btnTalk;
        private ListBox lbAll;
        private Button btnAll;
    }
}
