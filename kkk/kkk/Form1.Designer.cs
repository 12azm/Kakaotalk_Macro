
namespace kkk
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
            this.roomList = new System.Windows.Forms.ListBox();
            this.imButton = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.CheckBox();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.timeSelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // roomList
            // 
            this.roomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.roomList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomList.ForeColor = System.Drawing.Color.White;
            this.roomList.FormattingEnabled = true;
            this.roomList.ItemHeight = 15;
            this.roomList.Location = new System.Drawing.Point(12, 12);
            this.roomList.Name = "roomList";
            this.roomList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.roomList.Size = new System.Drawing.Size(429, 92);
            this.roomList.TabIndex = 0;
            // 
            // imButton
            // 
            this.imButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.imButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imButton.Location = new System.Drawing.Point(343, 110);
            this.imButton.Name = "imButton";
            this.imButton.Size = new System.Drawing.Size(98, 27);
            this.imButton.TabIndex = 1;
            this.imButton.Text = "Import";
            this.imButton.UseVisualStyleBackColor = true;
            this.imButton.Click += new System.EventHandler(this.imButton_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Content.ForeColor = System.Drawing.Color.White;
            this.Content.Location = new System.Drawing.Point(12, 143);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(429, 122);
            this.Content.TabIndex = 2;
            this.Content.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.sendButton.AutoSize = true;
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.sendButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Location = new System.Drawing.Point(398, 271);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(43, 25);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.CheckedChanged += new System.EventHandler(this.sendButton_CheckedChanged);
            // 
            // time
            // 
            this.time.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.time.Location = new System.Drawing.Point(12, 273);
            this.time.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 23);
            this.time.TabIndex = 4;
            this.time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeSelector
            // 
            this.timeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeSelector.FormattingEnabled = true;
            this.timeSelector.Items.AddRange(new object[] {
            "초",
            "분",
            "시"});
            this.timeSelector.Location = new System.Drawing.Point(138, 273);
            this.timeSelector.Name = "timeSelector";
            this.timeSelector.Size = new System.Drawing.Size(76, 23);
            this.timeSelector.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(286, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "5번 보내기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(453, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeSelector);
            this.Controls.Add(this.time);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.imButton);
            this.Controls.Add(this.roomList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "kakaotalk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox roomList;
        private System.Windows.Forms.Button imButton;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.CheckBox sendButton;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.ComboBox timeSelector;
        private System.Windows.Forms.Button button1;
    }
}

