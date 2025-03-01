﻿namespace ShellFiler.UI.Dialog.Option {
    partial class FileOperationClipboardPage {
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
            this.radioButtonQuoteSpace = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSeparatorReturn = new System.Windows.Forms.RadioButton();
            this.radioButtonSeparatorComma = new System.Windows.Forms.RadioButton();
            this.radioButtonSeparatorTab = new System.Windows.Forms.RadioButton();
            this.radioButtonSeparatorSpace = new System.Windows.Forms.RadioButton();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.radioButtonQuoteNone = new System.Windows.Forms.RadioButton();
            this.radioButtonQuoteAlways = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFullPath = new System.Windows.Forms.CheckBox();
            this.radioButtonFix = new System.Windows.Forms.RadioButton();
            this.radioButtonPrev = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonQuoteSpace
            // 
            this.radioButtonQuoteSpace.AutoSize = true;
            this.radioButtonQuoteSpace.Location = new System.Drawing.Point(7, 35);
            this.radioButtonQuoteSpace.Name = "radioButtonQuoteSpace";
            this.radioButtonQuoteSpace.Size = new System.Drawing.Size(136, 16);
            this.radioButtonQuoteSpace.TabIndex = 1;
            this.radioButtonQuoteSpace.TabStop = true;
            this.radioButtonQuoteSpace.Text = "空白を含む場合だけ(&S)";
            this.radioButtonQuoteSpace.UseVisualStyleBackColor = true;
            this.radioButtonQuoteSpace.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSeparatorReturn);
            this.groupBox2.Controls.Add(this.radioButtonSeparatorComma);
            this.groupBox2.Controls.Add(this.radioButtonSeparatorTab);
            this.groupBox2.Controls.Add(this.radioButtonSeparatorSpace);
            this.groupBox2.Location = new System.Drawing.Point(24, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "セパレータ";
            // 
            // radioButtonSeparatorReturn
            // 
            this.radioButtonSeparatorReturn.AutoSize = true;
            this.radioButtonSeparatorReturn.Location = new System.Drawing.Point(7, 71);
            this.radioButtonSeparatorReturn.Name = "radioButtonSeparatorReturn";
            this.radioButtonSeparatorReturn.Size = new System.Drawing.Size(63, 16);
            this.radioButtonSeparatorReturn.TabIndex = 3;
            this.radioButtonSeparatorReturn.TabStop = true;
            this.radioButtonSeparatorReturn.Text = "改行(&R)";
            this.radioButtonSeparatorReturn.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorReturn.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // radioButtonSeparatorComma
            // 
            this.radioButtonSeparatorComma.AutoSize = true;
            this.radioButtonSeparatorComma.Location = new System.Drawing.Point(7, 53);
            this.radioButtonSeparatorComma.Name = "radioButtonSeparatorComma";
            this.radioButtonSeparatorComma.Size = new System.Drawing.Size(66, 16);
            this.radioButtonSeparatorComma.TabIndex = 2;
            this.radioButtonSeparatorComma.TabStop = true;
            this.radioButtonSeparatorComma.Text = "カンマ(&C)";
            this.radioButtonSeparatorComma.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorComma.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // radioButtonSeparatorTab
            // 
            this.radioButtonSeparatorTab.AutoSize = true;
            this.radioButtonSeparatorTab.Location = new System.Drawing.Point(7, 35);
            this.radioButtonSeparatorTab.Name = "radioButtonSeparatorTab";
            this.radioButtonSeparatorTab.Size = new System.Drawing.Size(55, 16);
            this.radioButtonSeparatorTab.TabIndex = 1;
            this.radioButtonSeparatorTab.TabStop = true;
            this.radioButtonSeparatorTab.Text = "タブ(&T)";
            this.radioButtonSeparatorTab.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorTab.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // radioButtonSeparatorSpace
            // 
            this.radioButtonSeparatorSpace.AutoSize = true;
            this.radioButtonSeparatorSpace.Location = new System.Drawing.Point(7, 17);
            this.radioButtonSeparatorSpace.Name = "radioButtonSeparatorSpace";
            this.radioButtonSeparatorSpace.Size = new System.Drawing.Size(62, 16);
            this.radioButtonSeparatorSpace.TabIndex = 0;
            this.radioButtonSeparatorSpace.TabStop = true;
            this.radioButtonSeparatorSpace.Text = "空白(&P)";
            this.radioButtonSeparatorSpace.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorSpace.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // textBoxSample
            // 
            this.textBoxSample.Location = new System.Drawing.Point(26, 170);
            this.textBoxSample.Multiline = true;
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSample.Size = new System.Drawing.Size(377, 82);
            this.textBoxSample.TabIndex = 8;
            // 
            // radioButtonQuoteNone
            // 
            this.radioButtonQuoteNone.AutoSize = true;
            this.radioButtonQuoteNone.Location = new System.Drawing.Point(7, 53);
            this.radioButtonQuoteNone.Name = "radioButtonQuoteNone";
            this.radioButtonQuoteNone.Size = new System.Drawing.Size(58, 16);
            this.radioButtonQuoteNone.TabIndex = 2;
            this.radioButtonQuoteNone.TabStop = true;
            this.radioButtonQuoteNone.Text = "なし(&N)";
            this.radioButtonQuoteNone.UseVisualStyleBackColor = true;
            this.radioButtonQuoteNone.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // radioButtonQuoteAlways
            // 
            this.radioButtonQuoteAlways.AutoSize = true;
            this.radioButtonQuoteAlways.Location = new System.Drawing.Point(7, 17);
            this.radioButtonQuoteAlways.Name = "radioButtonQuoteAlways";
            this.radioButtonQuoteAlways.Size = new System.Drawing.Size(88, 16);
            this.radioButtonQuoteAlways.TabIndex = 0;
            this.radioButtonQuoteAlways.TabStop = true;
            this.radioButtonQuoteAlways.Text = "常につける(&A)";
            this.radioButtonQuoteAlways.UseVisualStyleBackColor = true;
            this.radioButtonQuoteAlways.CheckedChanged += new System.EventHandler(this.RadioButtonSetting_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQuoteNone);
            this.groupBox1.Controls.Add(this.radioButtonQuoteSpace);
            this.groupBox1.Controls.Add(this.radioButtonQuoteAlways);
            this.groupBox1.Location = new System.Drawing.Point(192, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "引用符\" \"";
            // 
            // checkBoxFullPath
            // 
            this.checkBoxFullPath.AutoSize = true;
            this.checkBoxFullPath.Location = new System.Drawing.Point(192, 148);
            this.checkBoxFullPath.Name = "checkBoxFullPath";
            this.checkBoxFullPath.Size = new System.Drawing.Size(119, 16);
            this.checkBoxFullPath.TabIndex = 11;
            this.checkBoxFullPath.Text = "フォルダ名を付加(&F)";
            this.checkBoxFullPath.UseVisualStyleBackColor = true;
            this.checkBoxFullPath.CheckedChanged += new System.EventHandler(this.CheckBoxSetting_CheckedChanged);
            // 
            // radioButtonFix
            // 
            this.radioButtonFix.AutoSize = true;
            this.radioButtonFix.Location = new System.Drawing.Point(3, 47);
            this.radioButtonFix.Name = "radioButtonFix";
            this.radioButtonFix.Size = new System.Drawing.Size(103, 16);
            this.radioButtonFix.TabIndex = 13;
            this.radioButtonFix.TabStop = true;
            this.radioButtonFix.Text = "初期値を指定(&I)";
            this.radioButtonFix.UseVisualStyleBackColor = true;
            this.radioButtonFix.CheckedChanged += new System.EventHandler(this.RadioButtonPrevFix_CheckedChanged);
            // 
            // radioButtonPrev
            // 
            this.radioButtonPrev.AutoSize = true;
            this.radioButtonPrev.Location = new System.Drawing.Point(3, 25);
            this.radioButtonPrev.Name = "radioButtonPrev";
            this.radioButtonPrev.Size = new System.Drawing.Size(243, 16);
            this.radioButtonPrev.TabIndex = 12;
            this.radioButtonPrev.TabStop = true;
            this.radioButtonPrev.Text = "直前に指定された設定を初期値として使用(&R)";
            this.radioButtonPrev.UseVisualStyleBackColor = true;
            this.radioButtonPrev.CheckedChanged += new System.EventHandler(this.RadioButtonPrevFix_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "[形式指定名前コピー]機能の設定を行います（マーク中のファイル名をクリップボードにコピーできます）。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "入力された項目は、形式を指定する画面での初期値として使用されます。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "[ファイル名をコピー]では、この設定にかかわらず、空白区切りのフルパスを必要時のみ\" \"ありでコピーします。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "形式を指定してクリップボードにコピー";
            // 
            // FileOperationClipboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFix);
            this.Controls.Add(this.radioButtonPrev);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxSample);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxFullPath);
            this.Name = "FileOperationClipboardPage";
            this.Size = new System.Drawing.Size(520, 370);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonQuoteSpace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSeparatorReturn;
        private System.Windows.Forms.RadioButton radioButtonSeparatorComma;
        private System.Windows.Forms.RadioButton radioButtonSeparatorTab;
        private System.Windows.Forms.RadioButton radioButtonSeparatorSpace;
        private System.Windows.Forms.TextBox textBoxSample;
        private System.Windows.Forms.RadioButton radioButtonQuoteNone;
        private System.Windows.Forms.RadioButton radioButtonQuoteAlways;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFullPath;
        private System.Windows.Forms.RadioButton radioButtonFix;
        private System.Windows.Forms.RadioButton radioButtonPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}
