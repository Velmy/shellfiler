namespace ShellFiler.UI.Dialog.Option {
    partial class FileListActionPage {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.numericScrollMargin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarWheel = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarDragMax = new System.Windows.Forms.TrackBar();
            this.checkBoxSeparateExt = new System.Windows.Forms.CheckBox();
            this.checkBoxOppositeParent = new System.Windows.Forms.CheckBox();
            this.checkBoxHideDrag = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxResumeCursor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericScrollMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDragMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "スクロールマージン(&M):";
            // 
            // numericScrollMargin
            // 
            this.numericScrollMargin.Location = new System.Drawing.Point(184, 4);
            this.numericScrollMargin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericScrollMargin.Name = "numericScrollMargin";
            this.numericScrollMargin.Size = new System.Drawing.Size(120, 19);
            this.numericScrollMargin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "行";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "マウスホイール回転時の最大速度(&W):";
            // 
            // trackBarWheel
            // 
            this.trackBarWheel.Location = new System.Drawing.Point(226, 77);
            this.trackBarWheel.Maximum = 50;
            this.trackBarWheel.Minimum = 1;
            this.trackBarWheel.Name = "trackBarWheel";
            this.trackBarWheel.Size = new System.Drawing.Size(104, 45);
            this.trackBarWheel.TabIndex = 8;
            this.trackBarWheel.TickFrequency = 5;
            this.trackBarWheel.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "遅く";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "速く";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "ドラッグ中の最大スクロール速度(&D):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "遅く";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "速く";
            // 
            // trackBarDragMax
            // 
            this.trackBarDragMax.Location = new System.Drawing.Point(226, 119);
            this.trackBarDragMax.Maximum = 50;
            this.trackBarDragMax.Minimum = 1;
            this.trackBarDragMax.Name = "trackBarDragMax";
            this.trackBarDragMax.Size = new System.Drawing.Size(104, 45);
            this.trackBarDragMax.TabIndex = 12;
            this.trackBarDragMax.TickFrequency = 5;
            this.trackBarDragMax.Value = 1;
            // 
            // checkBoxSeparateExt
            // 
            this.checkBoxSeparateExt.AutoSize = true;
            this.checkBoxSeparateExt.Location = new System.Drawing.Point(5, 182);
            this.checkBoxSeparateExt.Name = "checkBoxSeparateExt";
            this.checkBoxSeparateExt.Size = new System.Drawing.Size(172, 16);
            this.checkBoxSeparateExt.TabIndex = 15;
            this.checkBoxSeparateExt.Text = "最後の拡張子を離して表示(&E)";
            this.checkBoxSeparateExt.UseVisualStyleBackColor = true;
            // 
            // checkBoxOppositeParent
            // 
            this.checkBoxOppositeParent.AutoSize = true;
            this.checkBoxOppositeParent.Location = new System.Drawing.Point(5, 210);
            this.checkBoxOppositeParent.Name = "checkBoxOppositeParent";
            this.checkBoxOppositeParent.Size = new System.Drawing.Size(183, 16);
            this.checkBoxOppositeParent.TabIndex = 16;
            this.checkBoxOppositeParent.Text = "逆向き←→で親フォルダに戻る(&P)";
            this.checkBoxOppositeParent.UseVisualStyleBackColor = true;
            // 
            // checkBoxHideDrag
            // 
            this.checkBoxHideDrag.AutoSize = true;
            this.checkBoxHideDrag.Location = new System.Drawing.Point(5, 261);
            this.checkBoxHideDrag.Name = "checkBoxHideDrag";
            this.checkBoxHideDrag.Size = new System.Drawing.Size(217, 16);
            this.checkBoxHideDrag.TabIndex = 18;
            this.checkBoxHideDrag.Text = "外部へのドラッグ中にShellFilerを隠す(&O)";
            this.checkBoxHideDrag.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "カーソルを上下に移動したとき、画面の端に達する前にスクロールを開始します。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "設定値の行数が画面端で残ります。";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(471, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "ファイルのドロップ中、ウィンドウ外までカーソルが移動したとき、下にあるウィンドウにドロップできるように";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(444, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "左ウィンドウで←キーを押したとき、右ウィンドウで→キーを押したときに親フォルダに移動します。";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "自動的にウィンドウを隠すことができます。";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(49, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(400, 3);
            this.label14.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(48, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(400, 3);
            this.label15.TabIndex = 14;
            // 
            // checkBoxResumeCursor
            // 
            this.checkBoxResumeCursor.AutoSize = true;
            this.checkBoxResumeCursor.Location = new System.Drawing.Point(5, 322);
            this.checkBoxResumeCursor.Name = "checkBoxResumeCursor";
            this.checkBoxResumeCursor.Size = new System.Drawing.Size(329, 16);
            this.checkBoxResumeCursor.TabIndex = 21;
            this.checkBoxResumeCursor.Text = "フォルダ変更時にカーソル位置を過去にいたファイルに移動する(&R)";
            this.checkBoxResumeCursor.UseVisualStyleBackColor = true;
            // 
            // FileListActionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxResumeCursor);
            this.Controls.Add(this.checkBoxHideDrag);
            this.Controls.Add(this.checkBoxOppositeParent);
            this.Controls.Add(this.checkBoxSeparateExt);
            this.Controls.Add(this.trackBarDragMax);
            this.Controls.Add(this.trackBarWheel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericScrollMargin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FileListActionPage";
            this.Size = new System.Drawing.Size(520, 370);
            ((System.ComponentModel.ISupportInitialize)(this.numericScrollMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDragMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericScrollMargin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarWheel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarDragMax;
        private System.Windows.Forms.CheckBox checkBoxSeparateExt;
        private System.Windows.Forms.CheckBox checkBoxOppositeParent;
        private System.Windows.Forms.CheckBox checkBoxHideDrag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxResumeCursor;


    }
}
