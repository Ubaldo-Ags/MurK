namespace MURK_Rentas
{
    partial class Alta_RFID
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxp = new System.Windows.Forms.TextBox();
            this.idUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.mURKDataSet1 = new MURK_Rentas.MURKDataSet1();
            this.vUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_USUARIOSTableAdapter = new MURK_Rentas.MURKDataSet1TableAdapters.V_USUARIOSTableAdapter();
            this.lblPort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mURKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.textBoxp);
            this.panel1.Controls.Add(this.idUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtRFID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 244);
            this.panel1.TabIndex = 13;
            // 
            // textBoxp
            // 
            this.textBoxp.Location = new System.Drawing.Point(314, 48);
            this.textBoxp.Name = "textBoxp";
            this.textBoxp.Size = new System.Drawing.Size(100, 20);
            this.textBoxp.TabIndex = 22;
            this.textBoxp.Text = "1";
            // 
            // idUser
            // 
            this.idUser.AutoSize = true;
            this.idUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.idUser.Location = new System.Drawing.Point(344, 187);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(60, 24);
            this.idUser.TabIndex = 15;
            this.idUser.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pase la Tarjeta RFID por el Lector";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(31, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 20);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Asignar RFID a Usuario";
            // 
            // txtRFID
            // 
            this.txtRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFID.Location = new System.Drawing.Point(280, 94);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(152, 26);
            this.txtRFID.TabIndex = 16;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MURK_Rentas.Properties.Resources.rfid_login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo tarjeta RFID";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM4";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::MURK_Rentas.Properties.Resources.icons8_cerrar_ventana_96;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(472, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mURKDataSet1
            // 
            this.mURKDataSet1.DataSetName = "MURKDataSet1";
            this.mURKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vUSUARIOSBindingSource
            // 
            this.vUSUARIOSBindingSource.DataMember = "V_USUARIOS";
            this.vUSUARIOSBindingSource.DataSource = this.mURKDataSet1;
            // 
            // v_USUARIOSTableAdapter
            // 
            this.v_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(186, 259);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 14;
            this.lblPort.Text = "label3";
            // 
            // Alta_RFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(504, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Alta_RFID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Alta_RFID_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mURKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRFID;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idUser;
        private System.Windows.Forms.Button button2;
        private MURKDataSet1 mURKDataSet1;
        private System.Windows.Forms.BindingSource vUSUARIOSBindingSource;
        private MURKDataSet1TableAdapters.V_USUARIOSTableAdapter v_USUARIOSTableAdapter;
        private System.Windows.Forms.TextBox textBoxp;
        private System.Windows.Forms.Label lblPort;
    }
}