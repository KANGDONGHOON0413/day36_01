
namespace day36_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.INPUT_Nid = new System.Windows.Forms.TextBox();
            this.INPUT_Name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Enter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.INPUT_SEX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(548, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "동적 SQL insert문 처리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            // 
            // INPUT_Nid
            // 
            this.INPUT_Nid.Location = new System.Drawing.Point(579, 110);
            this.INPUT_Nid.Name = "INPUT_Nid";
            this.INPUT_Nid.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Nid.TabIndex = 3;
            // 
            // INPUT_Name
            // 
            this.INPUT_Name.Location = new System.Drawing.Point(579, 143);
            this.INPUT_Name.Name = "INPUT_Name";
            this.INPUT_Name.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Name.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(476, 294);
            this.dataGridView1.TabIndex = 5;
            // 
            // BTN_Enter
            // 
            this.BTN_Enter.Location = new System.Drawing.Point(710, 108);
            this.BTN_Enter.Name = "BTN_Enter";
            this.BTN_Enter.Size = new System.Drawing.Size(78, 62);
            this.BTN_Enter.TabIndex = 11;
            this.BTN_Enter.Text = "입력";
            this.BTN_Enter.UseVisualStyleBackColor = true;
            this.BTN_Enter.Click += new System.EventHandler(this.BTN_Enter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "성별";
            // 
            // INPUT_SEX
            // 
            this.INPUT_SEX.BackColor = System.Drawing.Color.CornflowerBlue;
            this.INPUT_SEX.Location = new System.Drawing.Point(579, 176);
            this.INPUT_SEX.Name = "INPUT_SEX";
            this.INPUT_SEX.Size = new System.Drawing.Size(47, 29);
            this.INPUT_SEX.TabIndex = 5;
            this.INPUT_SEX.Tag = "";
            this.INPUT_SEX.Text = "남";
            this.INPUT_SEX.UseVisualStyleBackColor = false;
            this.INPUT_SEX.Click += new System.EventHandler(this.INPUT_SEX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INPUT_SEX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_Enter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.INPUT_Name);
            this.Controls.Add(this.INPUT_Nid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox INPUT_Nid;
        private System.Windows.Forms.TextBox INPUT_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Enter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button INPUT_SEX;
    }
}

