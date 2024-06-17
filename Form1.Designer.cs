namespace CSharp_GPTB2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.tcka = new System.Windows.Forms.TrackBar();
            this.tckb = new System.Windows.Forms.TrackBar();
            this.tckc = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiai = new System.Windows.Forms.Button();
            this.gbxkq = new System.Windows.Forms.GroupBox();
            this.lblkq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tcka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckc)).BeginInit();
            this.gbxkq.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng Dụng Giải Phương Trình Bậc 2 ";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(72, 113);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(71, 23);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Nhập a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(72, 176);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(72, 23);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "Nhập b";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(73, 240);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(70, 23);
            this.lblc.TabIndex = 3;
            this.lblc.Text = "Nhập c";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(167, 106);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 30);
            this.txta.TabIndex = 4;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(167, 169);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 30);
            this.txtb.TabIndex = 5;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(167, 232);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 30);
            this.txtc.TabIndex = 6;
            // 
            // tcka
            // 
            this.tcka.Location = new System.Drawing.Point(329, 106);
            this.tcka.Maximum = 20;
            this.tcka.Minimum = -20;
            this.tcka.Name = "tcka";
            this.tcka.Size = new System.Drawing.Size(346, 45);
            this.tcka.TabIndex = 7;
            this.tcka.Scroll += new System.EventHandler(this.tcka_Scroll);
            // 
            // tckb
            // 
            this.tckb.Location = new System.Drawing.Point(329, 164);
            this.tckb.Maximum = 20;
            this.tckb.Minimum = -20;
            this.tckb.Name = "tckb";
            this.tckb.Size = new System.Drawing.Size(346, 45);
            this.tckb.TabIndex = 8;
            this.tckb.Scroll += new System.EventHandler(this.tckb_Scroll);
            // 
            // tckc
            // 
            this.tckc.Location = new System.Drawing.Point(329, 222);
            this.tckc.Maximum = 20;
            this.tckc.Minimum = -20;
            this.tckc.Name = "tckc";
            this.tckc.Size = new System.Drawing.Size(346, 45);
            this.tckc.TabIndex = 9;
            this.tckc.Scroll += new System.EventHandler(this.tckc_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = " ax² + bx + c = 0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btngiai
            // 
            this.btngiai.Location = new System.Drawing.Point(329, 344);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(200, 31);
            this.btngiai.TabIndex = 11;
            this.btngiai.Text = "Giải phương trình";
            this.btngiai.UseVisualStyleBackColor = true;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // gbxkq
            // 
            this.gbxkq.Controls.Add(this.lblkq);
            this.gbxkq.Location = new System.Drawing.Point(167, 408);
            this.gbxkq.Name = "gbxkq";
            this.gbxkq.Size = new System.Drawing.Size(421, 196);
            this.gbxkq.TabIndex = 12;
            this.gbxkq.TabStop = false;
            this.gbxkq.Text = "Kết Quả";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(22, 43);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(0, 19);
            this.lblkq.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(802, 642);
            this.Controls.Add(this.gbxkq);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tckc);
            this.Controls.Add(this.tckb);
            this.Controls.Add(this.tcka);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            ((System.ComponentModel.ISupportInitialize)(this.tcka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckc)).EndInit();
            this.gbxkq.ResumeLayout(false);
            this.gbxkq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TrackBar tcka;
        private System.Windows.Forms.TrackBar tckb;
        private System.Windows.Forms.TrackBar tckc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.GroupBox gbxkq;
        private System.Windows.Forms.Label lblkq;
    }
}

