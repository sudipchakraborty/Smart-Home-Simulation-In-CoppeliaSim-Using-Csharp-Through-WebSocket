namespace HomeAutomation_Simulation
{
    partial class frm_main
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
            this.btn_ac_on = new System.Windows.Forms.Button();
            this.btn_fan_on = new System.Windows.Forms.Button();
            this.btn_night_lamp_on = new System.Windows.Forms.Button();
            this.btn_tv_on = new System.Windows.Forms.Button();
            this.btn_ac_off = new System.Windows.Forms.Button();
            this.btn_fan_off = new System.Windows.Forms.Button();
            this.btn_night_lamp_off = new System.Windows.Forms.Button();
            this.btn_tv_off = new System.Windows.Forms.Button();
            this.btn_light_on = new System.Windows.Forms.Button();
            this.btn_light_off = new System.Windows.Forms.Button();
            this.hs_fan_speed = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect_with_home = new System.Windows.Forms.Button();
            this.lst_msg = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_door_open = new System.Windows.Forms.Button();
            this.btn_door_close = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ac_on
            // 
            this.btn_ac_on.ForeColor = System.Drawing.Color.Blue;
            this.btn_ac_on.Location = new System.Drawing.Point(463, 30);
            this.btn_ac_on.Name = "btn_ac_on";
            this.btn_ac_on.Size = new System.Drawing.Size(81, 47);
            this.btn_ac_on.TabIndex = 0;
            this.btn_ac_on.Text = "AC ON";
            this.btn_ac_on.UseVisualStyleBackColor = true;
            this.btn_ac_on.Click += new System.EventHandler(this.btn_ac_on_Click);
            // 
            // btn_fan_on
            // 
            this.btn_fan_on.ForeColor = System.Drawing.Color.Blue;
            this.btn_fan_on.Location = new System.Drawing.Point(127, 30);
            this.btn_fan_on.Name = "btn_fan_on";
            this.btn_fan_on.Size = new System.Drawing.Size(107, 47);
            this.btn_fan_on.TabIndex = 0;
            this.btn_fan_on.Text = "FAN ON";
            this.btn_fan_on.UseVisualStyleBackColor = true;
            this.btn_fan_on.Click += new System.EventHandler(this.btn_fan_on_Click);
            // 
            // btn_night_lamp_on
            // 
            this.btn_night_lamp_on.ForeColor = System.Drawing.Color.Blue;
            this.btn_night_lamp_on.Location = new System.Drawing.Point(240, 30);
            this.btn_night_lamp_on.Name = "btn_night_lamp_on";
            this.btn_night_lamp_on.Size = new System.Drawing.Size(131, 47);
            this.btn_night_lamp_on.TabIndex = 0;
            this.btn_night_lamp_on.Text = "NIGHT LAMP ON";
            this.btn_night_lamp_on.UseVisualStyleBackColor = true;
            this.btn_night_lamp_on.Click += new System.EventHandler(this.btn_night_lamp_on_Click);
            // 
            // btn_tv_on
            // 
            this.btn_tv_on.ForeColor = System.Drawing.Color.Blue;
            this.btn_tv_on.Location = new System.Drawing.Point(377, 30);
            this.btn_tv_on.Name = "btn_tv_on";
            this.btn_tv_on.Size = new System.Drawing.Size(80, 47);
            this.btn_tv_on.TabIndex = 0;
            this.btn_tv_on.Text = "TV ON";
            this.btn_tv_on.UseVisualStyleBackColor = true;
            this.btn_tv_on.Click += new System.EventHandler(this.btn_tv_on_Click);
            // 
            // btn_ac_off
            // 
            this.btn_ac_off.ForeColor = System.Drawing.Color.Blue;
            this.btn_ac_off.Location = new System.Drawing.Point(463, 83);
            this.btn_ac_off.Name = "btn_ac_off";
            this.btn_ac_off.Size = new System.Drawing.Size(81, 47);
            this.btn_ac_off.TabIndex = 0;
            this.btn_ac_off.Text = "AC OFF";
            this.btn_ac_off.UseVisualStyleBackColor = true;
            this.btn_ac_off.Click += new System.EventHandler(this.btn_ac_off_Click);
            // 
            // btn_fan_off
            // 
            this.btn_fan_off.ForeColor = System.Drawing.Color.Blue;
            this.btn_fan_off.Location = new System.Drawing.Point(127, 83);
            this.btn_fan_off.Name = "btn_fan_off";
            this.btn_fan_off.Size = new System.Drawing.Size(107, 47);
            this.btn_fan_off.TabIndex = 0;
            this.btn_fan_off.Text = "FAN OFF";
            this.btn_fan_off.UseVisualStyleBackColor = true;
            this.btn_fan_off.Click += new System.EventHandler(this.btn_fan_off_Click);
            // 
            // btn_night_lamp_off
            // 
            this.btn_night_lamp_off.ForeColor = System.Drawing.Color.Blue;
            this.btn_night_lamp_off.Location = new System.Drawing.Point(240, 83);
            this.btn_night_lamp_off.Name = "btn_night_lamp_off";
            this.btn_night_lamp_off.Size = new System.Drawing.Size(131, 47);
            this.btn_night_lamp_off.TabIndex = 0;
            this.btn_night_lamp_off.Text = "NIGHT LAMP OFF";
            this.btn_night_lamp_off.UseVisualStyleBackColor = true;
            this.btn_night_lamp_off.Click += new System.EventHandler(this.btn_night_lamp_off_Click);
            // 
            // btn_tv_off
            // 
            this.btn_tv_off.ForeColor = System.Drawing.Color.Blue;
            this.btn_tv_off.Location = new System.Drawing.Point(377, 83);
            this.btn_tv_off.Name = "btn_tv_off";
            this.btn_tv_off.Size = new System.Drawing.Size(80, 47);
            this.btn_tv_off.TabIndex = 0;
            this.btn_tv_off.Text = "TV OFF";
            this.btn_tv_off.UseVisualStyleBackColor = true;
            this.btn_tv_off.Click += new System.EventHandler(this.btn_tv_off_Click);
            // 
            // btn_light_on
            // 
            this.btn_light_on.ForeColor = System.Drawing.Color.Blue;
            this.btn_light_on.Location = new System.Drawing.Point(6, 30);
            this.btn_light_on.Name = "btn_light_on";
            this.btn_light_on.Size = new System.Drawing.Size(115, 47);
            this.btn_light_on.TabIndex = 0;
            this.btn_light_on.Text = "LIGHT ON";
            this.btn_light_on.UseVisualStyleBackColor = true;
            this.btn_light_on.Click += new System.EventHandler(this.btn_light_on_Click);
            // 
            // btn_light_off
            // 
            this.btn_light_off.ForeColor = System.Drawing.Color.Blue;
            this.btn_light_off.Location = new System.Drawing.Point(6, 83);
            this.btn_light_off.Name = "btn_light_off";
            this.btn_light_off.Size = new System.Drawing.Size(115, 47);
            this.btn_light_off.TabIndex = 0;
            this.btn_light_off.Text = "LIGHT OFF";
            this.btn_light_off.UseVisualStyleBackColor = true;
            this.btn_light_off.Click += new System.EventHandler(this.btn_light_off_Click);
            // 
            // hs_fan_speed
            // 
            this.hs_fan_speed.Location = new System.Drawing.Point(6, 153);
            this.hs_fan_speed.Name = "hs_fan_speed";
            this.hs_fan_speed.Size = new System.Drawing.Size(601, 30);
            this.hs_fan_speed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOME AUTOMATION SIMULATION";
            // 
            // btn_connect_with_home
            // 
            this.btn_connect_with_home.ForeColor = System.Drawing.Color.Teal;
            this.btn_connect_with_home.Location = new System.Drawing.Point(15, 34);
            this.btn_connect_with_home.Name = "btn_connect_with_home";
            this.btn_connect_with_home.Size = new System.Drawing.Size(187, 47);
            this.btn_connect_with_home.TabIndex = 3;
            this.btn_connect_with_home.Text = "CONNECT";
            this.btn_connect_with_home.UseVisualStyleBackColor = true;
            this.btn_connect_with_home.Click += new System.EventHandler(this.btn_connect_with_home_Click);
            // 
            // lst_msg
            // 
            this.lst_msg.FormattingEnabled = true;
            this.lst_msg.Location = new System.Drawing.Point(6, 29);
            this.lst_msg.Name = "lst_msg";
            this.lst_msg.Size = new System.Drawing.Size(601, 82);
            this.lst_msg.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_msg);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MessageBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hs_fan_speed);
            this.groupBox2.Controls.Add(this.btn_door_open);
            this.groupBox2.Controls.Add(this.btn_ac_on);
            this.groupBox2.Controls.Add(this.btn_door_close);
            this.groupBox2.Controls.Add(this.btn_ac_off);
            this.groupBox2.Controls.Add(this.btn_fan_on);
            this.groupBox2.Controls.Add(this.btn_fan_off);
            this.groupBox2.Controls.Add(this.btn_light_off);
            this.groupBox2.Controls.Add(this.btn_night_lamp_on);
            this.groupBox2.Controls.Add(this.btn_tv_off);
            this.groupBox2.Controls.Add(this.btn_night_lamp_off);
            this.groupBox2.Controls.Add(this.btn_light_on);
            this.groupBox2.Controls.Add(this.btn_tv_on);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 204);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SWITCH";
            // 
            // btn_door_open
            // 
            this.btn_door_open.ForeColor = System.Drawing.Color.Blue;
            this.btn_door_open.Location = new System.Drawing.Point(545, 30);
            this.btn_door_open.Name = "btn_door_open";
            this.btn_door_open.Size = new System.Drawing.Size(95, 47);
            this.btn_door_open.TabIndex = 0;
            this.btn_door_open.Text = "DOOR OPEN";
            this.btn_door_open.UseVisualStyleBackColor = true;
            this.btn_door_open.Click += new System.EventHandler(this.btn_door_open_Click);
            // 
            // btn_door_close
            // 
            this.btn_door_close.ForeColor = System.Drawing.Color.Blue;
            this.btn_door_close.Location = new System.Drawing.Point(545, 83);
            this.btn_door_close.Name = "btn_door_close";
            this.btn_door_close.Size = new System.Drawing.Size(95, 47);
            this.btn_door_close.TabIndex = 0;
            this.btn_door_close.Text = "DOOR CLOSE";
            this.btn_door_close.UseVisualStyleBackColor = true;
            this.btn_door_close.Click += new System.EventHandler(this.btn_door_close_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btn_disconnect);
            this.groupBox3.Controls.Add(this.btn_connect_with_home);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(13, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 104);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONNECTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "STATUS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(467, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.ForeColor = System.Drawing.Color.Teal;
            this.btn_disconnect.Location = new System.Drawing.Point(208, 34);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(187, 47);
            this.btn_disconnect.TabIndex = 3;
            this.btn_disconnect.Text = "DISCONNECT";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(672, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_main";
            this.Text = "Home Automation Simulation";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ac_on;
        private System.Windows.Forms.Button btn_fan_on;
        private System.Windows.Forms.Button btn_night_lamp_on;
        private System.Windows.Forms.Button btn_tv_on;
        private System.Windows.Forms.Button btn_ac_off;
        private System.Windows.Forms.Button btn_fan_off;
        private System.Windows.Forms.Button btn_night_lamp_off;
        private System.Windows.Forms.Button btn_tv_off;
        private System.Windows.Forms.Button btn_light_on;
        private System.Windows.Forms.Button btn_light_off;
        private System.Windows.Forms.HScrollBar hs_fan_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_connect_with_home;
        private System.Windows.Forms.ListBox lst_msg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_door_open;
        private System.Windows.Forms.Button btn_door_close;
    }
}

