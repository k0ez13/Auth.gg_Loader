﻿namespace Auth.GG_Winform_Example
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation3 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.userid = new Siticone.UI.WinForms.SiticoneLabel();
            this.username = new Siticone.UI.WinForms.SiticoneLabel();
            this.email = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.uservariable = new Siticone.UI.WinForms.SiticoneLabel();
            this.userrank = new Siticone.UI.WinForms.SiticoneLabel();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastlogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.registerdate = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(520, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(475, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Loader | Main";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(289, 223);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(255, 27);
            this.siticoneRoundedButton2.TabIndex = 28;
            this.siticoneRoundedButton2.Text = "Inject";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // userid
            // 
            this.userid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userid.Location = new System.Drawing.Point(20, 60);
            this.userid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(69, 14);
            this.userid.TabIndex = 37;
            this.userid.Text = "siticoneLabel1";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(20, 80);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(69, 14);
            this.username.TabIndex = 38;
            this.username.Text = "siticoneLabel2";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.email, Siticone.UI.AnimatorNS.DecorationType.None);
            this.email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(20, 101);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(69, 14);
            this.email.TabIndex = 39;
            this.email.Text = "siticoneLabel3";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.hwid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(20, 121);
            this.hwid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(69, 14);
            this.hwid.TabIndex = 40;
            this.hwid.Text = "siticoneLabel4";
            // 
            // uservariable
            // 
            this.uservariable.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.uservariable, Siticone.UI.AnimatorNS.DecorationType.None);
            this.uservariable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uservariable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uservariable.Location = new System.Drawing.Point(20, 141);
            this.uservariable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uservariable.Name = "uservariable";
            this.uservariable.Size = new System.Drawing.Size(69, 14);
            this.uservariable.TabIndex = 41;
            this.uservariable.Text = "siticoneLabel4";
            // 
            // userrank
            // 
            this.userrank.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userrank, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userrank.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userrank.Location = new System.Drawing.Point(20, 162);
            this.userrank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userrank.Name = "userrank";
            this.userrank.Size = new System.Drawing.Size(69, 14);
            this.userrank.TabIndex = 42;
            this.userrank.Text = "siticoneLabel4";
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.ip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(20, 182);
            this.ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(69, 14);
            this.ip.TabIndex = 43;
            this.ip.Text = "siticoneLabel4";
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.expiry, Siticone.UI.AnimatorNS.DecorationType.None);
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(20, 202);
            this.expiry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(69, 14);
            this.expiry.TabIndex = 44;
            this.expiry.Text = "siticoneLabel4";
            // 
            // lastlogin
            // 
            this.lastlogin.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.lastlogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lastlogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastlogin.Location = new System.Drawing.Point(20, 223);
            this.lastlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastlogin.Name = "lastlogin";
            this.lastlogin.Size = new System.Drawing.Size(69, 14);
            this.lastlogin.TabIndex = 45;
            this.lastlogin.Text = "siticoneLabel4";
            // 
            // registerdate
            // 
            this.registerdate.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.registerdate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerdate.Location = new System.Drawing.Point(20, 243);
            this.registerdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(69, 14);
            this.registerdate.TabIndex = 46;
            this.registerdate.Text = "siticoneLabel4";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(569, 278);
            this.Controls.Add(this.registerdate);
            this.Controls.Add(this.lastlogin);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.userrank);
            this.Controls.Add(this.uservariable);
            this.Controls.Add(this.hwid);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth.GG WInform";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel email;
        private Siticone.UI.WinForms.SiticoneLabel username;
        private Siticone.UI.WinForms.SiticoneLabel userid;
        private Siticone.UI.WinForms.SiticoneLabel registerdate;
        private Siticone.UI.WinForms.SiticoneLabel lastlogin;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private Siticone.UI.WinForms.SiticoneLabel userrank;
        private Siticone.UI.WinForms.SiticoneLabel uservariable;
    }
}