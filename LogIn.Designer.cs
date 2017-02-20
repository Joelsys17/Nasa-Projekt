namespace NasaProjekt
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.LogInRegisterButton = new ns1.BunifuFlatButton();
            this.slide1 = new System.Windows.Forms.Panel();
            this.labelreg = new System.Windows.Forms.Label();
            this.LogInEmailLabel = new ns1.BunifuCustomLabel();
            this.RegInPasswordLabel = new ns1.BunifuCustomLabel();
            this.LogInUsernameLabel = new ns1.BunifuCustomLabel();
            this.regemailadress = new ns1.BunifuMetroTextbox();
            this.regpassword = new ns1.BunifuMetroTextbox();
            this.regusername = new ns1.BunifuMetroTextbox();
            this.LogInRegisterLabel = new ns1.BunifuCustomLabel();
            this.UserLoginPass = new ns1.BunifuMetroTextbox();
            this.slide2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.LogInPasswordLabel = new ns1.BunifuCustomLabel();
            this.UseNameEmailLabel = new ns1.BunifuCustomLabel();
            this.LogInLogInButton = new ns1.BunifuFlatButton();
            this.UserLogin = new ns1.BunifuMetroTextbox();
            this.LogInLabel = new ns1.BunifuCustomLabel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogInNasaInformationServiceLabel = new ns1.BunifuCustomLabel();
            this.LogInRegisterScreenButton = new ns1.BunifuFlatButton();
            this.LogInLogInScreenButton = new ns1.BunifuFlatButton();
            this.Minimize = new ns1.BunifuImageButton();
            this.ExitButton = new ns1.BunifuImageButton();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.slide1.SuspendLayout();
            this.slide2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LogInRegisterButton
            // 
            this.LogInRegisterButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInRegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInRegisterButton.BorderRadius = 0;
            this.LogInRegisterButton.ButtonText = "Register";
            this.LogInRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.LogInRegisterButton, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.LogInRegisterButton, BunifuAnimatorNS.DecorationType.None);
            this.LogInRegisterButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogInRegisterButton.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInRegisterButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogInRegisterButton.Iconimage = null;
            this.LogInRegisterButton.Iconimage_right = null;
            this.LogInRegisterButton.Iconimage_right_Selected = null;
            this.LogInRegisterButton.Iconimage_Selected = null;
            this.LogInRegisterButton.IconMarginLeft = 0;
            this.LogInRegisterButton.IconMarginRight = 0;
            this.LogInRegisterButton.IconRightVisible = true;
            this.LogInRegisterButton.IconRightZoom = 0D;
            this.LogInRegisterButton.IconVisible = true;
            this.LogInRegisterButton.IconZoom = 90D;
            this.LogInRegisterButton.IsTab = true;
            this.LogInRegisterButton.Location = new System.Drawing.Point(160, 346);
            this.LogInRegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInRegisterButton.Name = "LogInRegisterButton";
            this.LogInRegisterButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInRegisterButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInRegisterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogInRegisterButton.selected = false;
            this.LogInRegisterButton.Size = new System.Drawing.Size(113, 37);
            this.LogInRegisterButton.TabIndex = 1;
            this.LogInRegisterButton.Text = "Register";
            this.LogInRegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInRegisterButton.Textcolor = System.Drawing.Color.White;
            this.LogInRegisterButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInRegisterButton.Click += new System.EventHandler(this.RegisterButton2);
            // 
            // slide1
            // 
            this.slide1.Controls.Add(this.labelreg);
            this.slide1.Controls.Add(this.LogInEmailLabel);
            this.slide1.Controls.Add(this.RegInPasswordLabel);
            this.slide1.Controls.Add(this.LogInUsernameLabel);
            this.slide1.Controls.Add(this.regemailadress);
            this.slide1.Controls.Add(this.regpassword);
            this.slide1.Controls.Add(this.LogInRegisterButton);
            this.slide1.Controls.Add(this.regusername);
            this.slide1.Controls.Add(this.LogInRegisterLabel);
            this.bunifuTransition2.SetDecoration(this.slide1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.slide1, BunifuAnimatorNS.DecorationType.None);
            this.slide1.Location = new System.Drawing.Point(23, 90);
            this.slide1.Name = "slide1";
            this.slide1.Size = new System.Drawing.Size(460, 410);
            this.slide1.TabIndex = 4;
            this.slide1.Paint += new System.Windows.Forms.PaintEventHandler(this.Slide1);
            // 
            // labelreg
            // 
            this.labelreg.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelreg, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.labelreg, BunifuAnimatorNS.DecorationType.None);
            this.labelreg.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreg.ForeColor = System.Drawing.Color.White;
            this.labelreg.Location = new System.Drawing.Point(36, 322);
            this.labelreg.Name = "labelreg";
            this.labelreg.Size = new System.Drawing.Size(0, 22);
            this.labelreg.TabIndex = 7;
            // 
            // LogInEmailLabel
            // 
            this.LogInEmailLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.LogInEmailLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.LogInEmailLabel, BunifuAnimatorNS.DecorationType.None);
            this.LogInEmailLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInEmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInEmailLabel.Location = new System.Drawing.Point(32, 247);
            this.LogInEmailLabel.Name = "LogInEmailLabel";
            this.LogInEmailLabel.Size = new System.Drawing.Size(56, 22);
            this.LogInEmailLabel.TabIndex = 6;
            this.LogInEmailLabel.Text = "Email";
            this.LogInEmailLabel.Click += new System.EventHandler(this.SmallLabel2);
            // 
            // RegInPasswordLabel
            // 
            this.RegInPasswordLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.RegInPasswordLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.RegInPasswordLabel, BunifuAnimatorNS.DecorationType.None);
            this.RegInPasswordLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegInPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegInPasswordLabel.Location = new System.Drawing.Point(32, 164);
            this.RegInPasswordLabel.Name = "RegInPasswordLabel";
            this.RegInPasswordLabel.Size = new System.Drawing.Size(83, 22);
            this.RegInPasswordLabel.TabIndex = 4;
            this.RegInPasswordLabel.Text = "Password";
            this.RegInPasswordLabel.Click += new System.EventHandler(this.SmallLabel3);
            // 
            // LogInUsernameLabel
            // 
            this.LogInUsernameLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.LogInUsernameLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.LogInUsernameLabel, BunifuAnimatorNS.DecorationType.None);
            this.LogInUsernameLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInUsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInUsernameLabel.Location = new System.Drawing.Point(32, 78);
            this.LogInUsernameLabel.Name = "LogInUsernameLabel";
            this.LogInUsernameLabel.Size = new System.Drawing.Size(87, 22);
            this.LogInUsernameLabel.TabIndex = 3;
            this.LogInUsernameLabel.Text = "Username";
            this.LogInUsernameLabel.Click += new System.EventHandler(this.SmallLabel1);
            // 
            // regemailadress
            // 
            this.regemailadress.BorderColorFocused = System.Drawing.Color.Silver;
            this.regemailadress.BorderColorIdle = System.Drawing.Color.Silver;
            this.regemailadress.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.regemailadress.BorderThickness = 3;
            this.regemailadress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.regemailadress, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.regemailadress, BunifuAnimatorNS.DecorationType.None);
            this.regemailadress.Font = new System.Drawing.Font("Garamond", 10F);
            this.regemailadress.ForeColor = System.Drawing.Color.White;
            this.regemailadress.isPassword = false;
            this.regemailadress.Location = new System.Drawing.Point(36, 270);
            this.regemailadress.Margin = new System.Windows.Forms.Padding(4);
            this.regemailadress.Name = "regemailadress";
            this.regemailadress.Size = new System.Drawing.Size(387, 44);
            this.regemailadress.TabIndex = 3;
            this.regemailadress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.regemailadress.OnValueChanged += new System.EventHandler(this.TextBox3);
            // 
            // regpassword
            // 
            this.regpassword.BorderColorFocused = System.Drawing.Color.Silver;
            this.regpassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.regpassword.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.regpassword.BorderThickness = 3;
            this.regpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.regpassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.regpassword, BunifuAnimatorNS.DecorationType.None);
            this.regpassword.Font = new System.Drawing.Font("Garamond", 10F);
            this.regpassword.ForeColor = System.Drawing.Color.White;
            this.regpassword.isPassword = true;
            this.regpassword.Location = new System.Drawing.Point(36, 187);
            this.regpassword.Margin = new System.Windows.Forms.Padding(4);
            this.regpassword.Name = "regpassword";
            this.regpassword.Size = new System.Drawing.Size(387, 44);
            this.regpassword.TabIndex = 2;
            this.regpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.regpassword.OnValueChanged += new System.EventHandler(this.TextBox2);
            // 
            // regusername
            // 
            this.regusername.BorderColorFocused = System.Drawing.Color.Silver;
            this.regusername.BorderColorIdle = System.Drawing.Color.Silver;
            this.regusername.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.regusername.BorderThickness = 3;
            this.regusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.regusername, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.regusername, BunifuAnimatorNS.DecorationType.None);
            this.regusername.Font = new System.Drawing.Font("Garamond", 10F);
            this.regusername.ForeColor = System.Drawing.Color.White;
            this.regusername.isPassword = false;
            this.regusername.Location = new System.Drawing.Point(36, 103);
            this.regusername.Margin = new System.Windows.Forms.Padding(4);
            this.regusername.Name = "regusername";
            this.regusername.Size = new System.Drawing.Size(387, 44);
            this.regusername.TabIndex = 1;
            this.regusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.regusername.OnValueChanged += new System.EventHandler(this.TextBox1);
            // 
            // LogInRegisterLabel
            // 
            this.LogInRegisterLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.LogInRegisterLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.LogInRegisterLabel, BunifuAnimatorNS.DecorationType.None);
            this.LogInRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInRegisterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInRegisterLabel.Location = new System.Drawing.Point(154, 27);
            this.LogInRegisterLabel.Name = "LogInRegisterLabel";
            this.LogInRegisterLabel.Size = new System.Drawing.Size(134, 36);
            this.LogInRegisterLabel.TabIndex = 0;
            this.LogInRegisterLabel.Text = "Register";
            this.LogInRegisterLabel.Click += new System.EventHandler(this.BigLabel2);
            // 
            // UserLoginPass
            // 
            this.UserLoginPass.BorderColorFocused = System.Drawing.Color.Silver;
            this.UserLoginPass.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserLoginPass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.UserLoginPass.BorderThickness = 3;
            this.UserLoginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.UserLoginPass, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.UserLoginPass, BunifuAnimatorNS.DecorationType.None);
            this.UserLoginPass.Font = new System.Drawing.Font("Garamond", 10F);
            this.UserLoginPass.ForeColor = System.Drawing.Color.White;
            this.UserLoginPass.isPassword = true;
            this.UserLoginPass.Location = new System.Drawing.Point(48, 244);
            this.UserLoginPass.Margin = new System.Windows.Forms.Padding(4);
            this.UserLoginPass.Name = "UserLoginPass";
            this.UserLoginPass.Size = new System.Drawing.Size(387, 44);
            this.UserLoginPass.TabIndex = 5;
            this.UserLoginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserLoginPass.OnValueChanged += new System.EventHandler(this.TextBox5);
            // 
            // slide2
            // 
            this.slide2.Controls.Add(this.label2);
            this.slide2.Controls.Add(this.bunifuCustomLabel10);
            this.slide2.Controls.Add(this.label1);
            this.slide2.Controls.Add(this.bunifuCustomLabel9);
            this.slide2.Controls.Add(this.LogInPasswordLabel);
            this.slide2.Controls.Add(this.UserLoginPass);
            this.slide2.Controls.Add(this.UseNameEmailLabel);
            this.slide2.Controls.Add(this.LogInLogInButton);
            this.slide2.Controls.Add(this.UserLogin);
            this.slide2.Controls.Add(this.LogInLabel);
            this.bunifuTransition2.SetDecoration(this.slide2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.slide2, BunifuAnimatorNS.DecorationType.None);
            this.slide2.Location = new System.Drawing.Point(609, 90);
            this.slide2.Name = "slide2";
            this.slide2.Size = new System.Drawing.Size(460, 410);
            this.slide2.TabIndex = 5;
            this.slide2.Paint += new System.Windows.Forms.PaintEventHandler(this.Slide2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 9;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(59, 307);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(0, 22);
            this.bunifuCustomLabel10.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 7;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(167, 303);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(0, 37);
            this.bunifuCustomLabel9.TabIndex = 6;
            // 
            // LogInPasswordLabel
            // 
            this.LogInPasswordLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.LogInPasswordLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.LogInPasswordLabel, BunifuAnimatorNS.DecorationType.None);
            this.LogInPasswordLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInPasswordLabel.Location = new System.Drawing.Point(44, 221);
            this.LogInPasswordLabel.Name = "LogInPasswordLabel";
            this.LogInPasswordLabel.Size = new System.Drawing.Size(83, 22);
            this.LogInPasswordLabel.TabIndex = 4;
            this.LogInPasswordLabel.Text = "Password";
            this.LogInPasswordLabel.Click += new System.EventHandler(this.SmallLabel5);
            // 
            // UseNameEmailLabel
            // 
            this.UseNameEmailLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.UseNameEmailLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.UseNameEmailLabel, BunifuAnimatorNS.DecorationType.None);
            this.UseNameEmailLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseNameEmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UseNameEmailLabel.Location = new System.Drawing.Point(44, 83);
            this.UseNameEmailLabel.Name = "UseNameEmailLabel";
            this.UseNameEmailLabel.Size = new System.Drawing.Size(143, 22);
            this.UseNameEmailLabel.TabIndex = 3;
            this.UseNameEmailLabel.Text = "Username/Email";
            this.UseNameEmailLabel.Click += new System.EventHandler(this.SmallLabel4);
            // 
            // LogInLogInButton
            // 
            this.LogInLogInButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInLogInButton.BorderRadius = 0;
            this.LogInLogInButton.ButtonText = "Log In";
            this.LogInLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.LogInLogInButton, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.LogInLogInButton, BunifuAnimatorNS.DecorationType.None);
            this.LogInLogInButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogInLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLogInButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogInLogInButton.Iconimage = null;
            this.LogInLogInButton.Iconimage_right = null;
            this.LogInLogInButton.Iconimage_right_Selected = null;
            this.LogInLogInButton.Iconimage_Selected = null;
            this.LogInLogInButton.IconMarginLeft = 0;
            this.LogInLogInButton.IconMarginRight = 0;
            this.LogInLogInButton.IconRightVisible = true;
            this.LogInLogInButton.IconRightZoom = 0D;
            this.LogInLogInButton.IconVisible = true;
            this.LogInLogInButton.IconZoom = 90D;
            this.LogInLogInButton.IsTab = false;
            this.LogInLogInButton.Location = new System.Drawing.Point(183, 346);
            this.LogInLogInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInLogInButton.Name = "LogInLogInButton";
            this.LogInLogInButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogInLogInButton.selected = false;
            this.LogInLogInButton.Size = new System.Drawing.Size(109, 37);
            this.LogInLogInButton.TabIndex = 1;
            this.LogInLogInButton.Text = "Log In";
            this.LogInLogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInLogInButton.Textcolor = System.Drawing.Color.White;
            this.LogInLogInButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLogInButton.Click += new System.EventHandler(this.LogInButton2);
            // 
            // UserLogin
            // 
            this.UserLogin.BorderColorFocused = System.Drawing.Color.Silver;
            this.UserLogin.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserLogin.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.UserLogin.BorderThickness = 3;
            this.UserLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.UserLogin, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.UserLogin, BunifuAnimatorNS.DecorationType.None);
            this.UserLogin.Font = new System.Drawing.Font("Garamond", 10F);
            this.UserLogin.ForeColor = System.Drawing.Color.White;
            this.UserLogin.isPassword = false;
            this.UserLogin.Location = new System.Drawing.Point(48, 106);
            this.UserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(387, 44);
            this.UserLogin.TabIndex = 1;
            this.UserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserLogin.OnValueChanged += new System.EventHandler(this.TextBox4);
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.LogInLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.LogInLabel, BunifuAnimatorNS.DecorationType.None);
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInLabel.Location = new System.Drawing.Point(176, 27);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(105, 36);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "Log In";
            this.LogInLabel.Click += new System.EventHandler(this.BigLabel3);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // LogInNasaInformationServiceLabel
            // 
            this.LogInNasaInformationServiceLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.LogInNasaInformationServiceLabel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.LogInNasaInformationServiceLabel, BunifuAnimatorNS.DecorationType.None);
            this.LogInNasaInformationServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInNasaInformationServiceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInNasaInformationServiceLabel.Location = new System.Drawing.Point(85, 9);
            this.LogInNasaInformationServiceLabel.Name = "LogInNasaInformationServiceLabel";
            this.LogInNasaInformationServiceLabel.Size = new System.Drawing.Size(371, 36);
            this.LogInNasaInformationServiceLabel.TabIndex = 6;
            this.LogInNasaInformationServiceLabel.Text = "Nasa Information Service";
            this.LogInNasaInformationServiceLabel.Click += new System.EventHandler(this.BigLabel1);
            // 
            // LogInRegisterScreenButton
            // 
            this.LogInRegisterScreenButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogInRegisterScreenButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogInRegisterScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInRegisterScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInRegisterScreenButton.BorderRadius = 0;
            this.LogInRegisterScreenButton.ButtonText = "Register";
            this.LogInRegisterScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.LogInRegisterScreenButton, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.LogInRegisterScreenButton, BunifuAnimatorNS.DecorationType.None);
            this.LogInRegisterScreenButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogInRegisterScreenButton.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInRegisterScreenButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogInRegisterScreenButton.Iconimage = null;
            this.LogInRegisterScreenButton.Iconimage_right = null;
            this.LogInRegisterScreenButton.Iconimage_right_Selected = null;
            this.LogInRegisterScreenButton.Iconimage_Selected = null;
            this.LogInRegisterScreenButton.IconMarginLeft = 0;
            this.LogInRegisterScreenButton.IconMarginRight = 0;
            this.LogInRegisterScreenButton.IconRightVisible = true;
            this.LogInRegisterScreenButton.IconRightZoom = 0D;
            this.LogInRegisterScreenButton.IconVisible = true;
            this.LogInRegisterScreenButton.IconZoom = 90D;
            this.LogInRegisterScreenButton.IsTab = false;
            this.LogInRegisterScreenButton.Location = new System.Drawing.Point(164, 49);
            this.LogInRegisterScreenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInRegisterScreenButton.Name = "LogInRegisterScreenButton";
            this.LogInRegisterScreenButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInRegisterScreenButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.LogInRegisterScreenButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogInRegisterScreenButton.selected = false;
            this.LogInRegisterScreenButton.Size = new System.Drawing.Size(79, 34);
            this.LogInRegisterScreenButton.TabIndex = 7;
            this.LogInRegisterScreenButton.Text = "Register";
            this.LogInRegisterScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInRegisterScreenButton.Textcolor = System.Drawing.Color.White;
            this.LogInRegisterScreenButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInRegisterScreenButton.Click += new System.EventHandler(this.RegisterButton1);
            // 
            // LogInLogInScreenButton
            // 
            this.LogInLogInScreenButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogInLogInScreenButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogInLogInScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInLogInScreenButton.BorderRadius = 0;
            this.LogInLogInScreenButton.ButtonText = "Log In";
            this.LogInLogInScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.LogInLogInScreenButton, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.LogInLogInScreenButton, BunifuAnimatorNS.DecorationType.None);
            this.LogInLogInScreenButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogInLogInScreenButton.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLogInScreenButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogInLogInScreenButton.Iconimage = null;
            this.LogInLogInScreenButton.Iconimage_right = null;
            this.LogInLogInScreenButton.Iconimage_right_Selected = null;
            this.LogInLogInScreenButton.Iconimage_Selected = null;
            this.LogInLogInScreenButton.IconMarginLeft = 0;
            this.LogInLogInScreenButton.IconMarginRight = 0;
            this.LogInLogInScreenButton.IconRightVisible = true;
            this.LogInLogInScreenButton.IconRightZoom = 0D;
            this.LogInLogInScreenButton.IconVisible = true;
            this.LogInLogInScreenButton.IconZoom = 90D;
            this.LogInLogInScreenButton.IsTab = false;
            this.LogInLogInScreenButton.Location = new System.Drawing.Point(249, 49);
            this.LogInLogInScreenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInLogInScreenButton.Name = "LogInLogInScreenButton";
            this.LogInLogInScreenButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInScreenButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LogInLogInScreenButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogInLogInScreenButton.selected = false;
            this.LogInLogInScreenButton.Size = new System.Drawing.Size(59, 34);
            this.LogInLogInScreenButton.TabIndex = 8;
            this.LogInLogInScreenButton.Text = "Log In";
            this.LogInLogInScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogInLogInScreenButton.Textcolor = System.Drawing.Color.White;
            this.LogInLogInScreenButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLogInScreenButton.Click += new System.EventHandler(this.LogInButton);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTransition2.SetDecoration(this.Minimize, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Minimize, BunifuAnimatorNS.DecorationType.None);
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageActive = null;
            this.Minimize.Location = new System.Drawing.Point(449, 15);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 21);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 9;
            this.Minimize.TabStop = false;
            this.Minimize.Zoom = 10;
            this.Minimize.Click += new System.EventHandler(this.MinimizeWindow);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTransition2.SetDecoration(this.ExitButton, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.ExitButton, BunifuAnimatorNS.DecorationType.None);
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageActive = null;
            this.ExitButton.Location = new System.Drawing.Point(476, 15);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(21, 21);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 10;
            this.ExitButton.TabStop = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.CloseWindow);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(551, 561);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.LogInLogInScreenButton);
            this.Controls.Add(this.LogInRegisterScreenButton);
            this.Controls.Add(this.LogInNasaInformationServiceLabel);
            this.Controls.Add(this.slide2);
            this.Controls.Add(this.slide1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.MainWindow);
            this.slide1.ResumeLayout(false);
            this.slide1.PerformLayout();
            this.slide2.ResumeLayout(false);
            this.slide2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuFlatButton LogInRegisterButton;
        private System.Windows.Forms.Panel slide1;
        private ns1.BunifuCustomLabel RegInPasswordLabel;
        private ns1.BunifuCustomLabel LogInUsernameLabel;
        private ns1.BunifuMetroTextbox regpassword;
        private ns1.BunifuMetroTextbox regusername;
        private ns1.BunifuCustomLabel LogInRegisterLabel;
        private System.Windows.Forms.Panel slide2;
        private ns1.BunifuCustomLabel LogInPasswordLabel;
        private ns1.BunifuCustomLabel UseNameEmailLabel;
        private ns1.BunifuMetroTextbox regemailadress;
        private ns1.BunifuFlatButton LogInLogInButton;
        private ns1.BunifuMetroTextbox UserLogin;
        private ns1.BunifuCustomLabel LogInLabel;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private ns1.BunifuCustomLabel LogInNasaInformationServiceLabel;
        private ns1.BunifuCustomLabel LogInEmailLabel;
        private ns1.BunifuMetroTextbox UserLoginPass;
        private ns1.BunifuFlatButton LogInLogInScreenButton;
        private ns1.BunifuFlatButton LogInRegisterScreenButton;
        private ns1.BunifuImageButton ExitButton;
        private ns1.BunifuImageButton Minimize;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelreg;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

