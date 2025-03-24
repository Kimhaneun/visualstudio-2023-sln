
namespace BMI_1205_김한은
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_stature = new System.Windows.Forms.TextBox();
            this.text_weight = new System.Windows.Forms.TextBox();
            this.button_BMI = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "키(cm) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "체중(kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_stature
            // 
            this.text_stature.BackColor = System.Drawing.SystemColors.Window;
            this.text_stature.Location = new System.Drawing.Point(295, 81);
            this.text_stature.Name = "text_stature";
            this.text_stature.Size = new System.Drawing.Size(100, 25);
            this.text_stature.TabIndex = 2;
            // 
            // text_weight
            // 
            this.text_weight.BackColor = System.Drawing.SystemColors.Window;
            this.text_weight.Location = new System.Drawing.Point(295, 136);
            this.text_weight.Name = "text_weight";
            this.text_weight.Size = new System.Drawing.Size(100, 25);
            this.text_weight.TabIndex = 3;
            // 
            // button_BMI
            // 
            this.button_BMI.Location = new System.Drawing.Point(75, 198);
            this.button_BMI.Name = "button_BMI";
            this.button_BMI.Size = new System.Drawing.Size(320, 49);
            this.button_BMI.TabIndex = 4;
            this.button_BMI.Text = "BMI 계산\r\n";
            this.button_BMI.UseVisualStyleBackColor = true;
            this.button_BMI.Click += new System.EventHandler(this.button_BMI_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(72, 290);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(82, 15);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "BMI 결과 : ";
            this.label_result.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_BMI);
            this.Controls.Add(this.text_weight);
            this.Controls.Add(this.text_stature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_stature;
        private System.Windows.Forms.TextBox text_weight;
        private System.Windows.Forms.Button button_BMI;
        private System.Windows.Forms.Label label_result;
    }
}

