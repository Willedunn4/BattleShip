
using System;

namespace BattleshipSimulator
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
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.EnemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.W1 = new System.Windows.Forms.Button();
            this.W2 = new System.Windows.Forms.Button();
            this.W3 = new System.Windows.Forms.Button();
            this.W4 = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.Button();
            this.X2 = new System.Windows.Forms.Button();
            this.X3 = new System.Windows.Forms.Button();
            this.X4 = new System.Windows.Forms.Button();
            this.Z1 = new System.Windows.Forms.Button();
            this.Z2 = new System.Windows.Forms.Button();
            this.Z3 = new System.Windows.Forms.Button();
            this.Z4 = new System.Windows.Forms.Button();
            this.Y1 = new System.Windows.Forms.Button();
            this.Y2 = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.Button();
            this.Y4 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.ForeColor = System.Drawing.Color.White;
            this.txtPlayer.Location = new System.Drawing.Point(398, 123);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(41, 29);
            this.txtPlayer.TabIndex = 2;
            this.txtPlayer.Text = "00";
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnemy.ForeColor = System.Drawing.Color.White;
            this.txtEnemy.Location = new System.Drawing.Point(1012, 123);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(49, 32);
            this.txtEnemy.TabIndex = 2;
            this.txtEnemy.Text = "00";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.BackColor = System.Drawing.Color.Transparent;
            this.txtRounds.Location = new System.Drawing.Point(559, 207);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(74, 17);
            this.txtRounds.TabIndex = 2;
            this.txtRounds.Text = "Round: 10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(999, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "A1";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtHelp.Location = new System.Drawing.Point(103, 615);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(308, 17);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "Click on 3 differnet locations from above to start";
            // 
            // EnemyLocationListBox
            // 
            this.EnemyLocationListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnemyLocationListBox.DropDownWidth = 95;
            this.EnemyLocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyLocationListBox.ForeColor = System.Drawing.Color.Lime;
            this.EnemyLocationListBox.FormattingEnabled = true;
            this.EnemyLocationListBox.Location = new System.Drawing.Point(190, 28);
            this.EnemyLocationListBox.Name = "EnemyLocationListBox";
            this.EnemyLocationListBox.Size = new System.Drawing.Size(121, 39);
            this.EnemyLocationListBox.TabIndex = 3;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(67, 66);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(102, 32);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.AttackButtonEvent);
            // 
            // W1
            // 
            this.W1.BackColor = System.Drawing.Color.White;
            this.W1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.W1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W1.Location = new System.Drawing.Point(106, 246);
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(94, 79);
            this.W1.TabIndex = 4;
            this.W1.Text = "W1";
            this.W1.UseVisualStyleBackColor = false;
            this.W1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // W2
            // 
            this.W2.BackColor = System.Drawing.Color.White;
            this.W2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.W2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W2.Location = new System.Drawing.Point(215, 246);
            this.W2.Name = "W2";
            this.W2.Size = new System.Drawing.Size(94, 79);
            this.W2.TabIndex = 4;
            this.W2.Text = "W2";
            this.W2.UseVisualStyleBackColor = false;
            this.W2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // W3
            // 
            this.W3.BackColor = System.Drawing.Color.White;
            this.W3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.W3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W3.Location = new System.Drawing.Point(315, 246);
            this.W3.Name = "W3";
            this.W3.Size = new System.Drawing.Size(94, 79);
            this.W3.TabIndex = 4;
            this.W3.Text = "W3";
            this.W3.UseVisualStyleBackColor = false;
            this.W3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // W4
            // 
            this.W4.BackColor = System.Drawing.Color.White;
            this.W4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.W4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W4.Location = new System.Drawing.Point(415, 246);
            this.W4.Name = "W4";
            this.W4.Size = new System.Drawing.Size(94, 79);
            this.W4.TabIndex = 4;
            this.W4.Text = "W4";
            this.W4.UseVisualStyleBackColor = false;
            this.W4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // X1
            // 
            this.X1.BackColor = System.Drawing.Color.White;
            this.X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1.Location = new System.Drawing.Point(104, 331);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(94, 79);
            this.X1.TabIndex = 4;
            this.X1.Text = "X1";
            this.X1.UseVisualStyleBackColor = false;
            this.X1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // X2
            // 
            this.X2.BackColor = System.Drawing.Color.White;
            this.X2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2.Location = new System.Drawing.Point(213, 331);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(94, 79);
            this.X2.TabIndex = 4;
            this.X2.Text = "X2";
            this.X2.UseVisualStyleBackColor = false;
            this.X2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // X3
            // 
            this.X3.BackColor = System.Drawing.Color.White;
            this.X3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X3.Location = new System.Drawing.Point(313, 331);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(94, 79);
            this.X3.TabIndex = 4;
            this.X3.Text = "X3";
            this.X3.UseVisualStyleBackColor = false;
            this.X3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // X4
            // 
            this.X4.BackColor = System.Drawing.Color.White;
            this.X4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.X4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X4.Location = new System.Drawing.Point(413, 331);
            this.X4.Name = "X4";
            this.X4.Size = new System.Drawing.Size(94, 79);
            this.X4.TabIndex = 4;
            this.X4.Text = "X4";
            this.X4.UseVisualStyleBackColor = false;
            this.X4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Z1
            // 
            this.Z1.BackColor = System.Drawing.Color.White;
            this.Z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z1.Location = new System.Drawing.Point(104, 500);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(94, 79);
            this.Z1.TabIndex = 4;
            this.Z1.Text = "Z1";
            this.Z1.UseVisualStyleBackColor = false;
            this.Z1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Z2
            // 
            this.Z2.BackColor = System.Drawing.Color.White;
            this.Z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2.Location = new System.Drawing.Point(213, 500);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(94, 79);
            this.Z2.TabIndex = 4;
            this.Z2.Text = "Z2";
            this.Z2.UseVisualStyleBackColor = false;
            this.Z2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Z3
            // 
            this.Z3.BackColor = System.Drawing.Color.White;
            this.Z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z3.Location = new System.Drawing.Point(313, 500);
            this.Z3.Name = "Z3";
            this.Z3.Size = new System.Drawing.Size(94, 79);
            this.Z3.TabIndex = 4;
            this.Z3.Text = "Z3";
            this.Z3.UseVisualStyleBackColor = false;
            this.Z3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Z4
            // 
            this.Z4.BackColor = System.Drawing.Color.White;
            this.Z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z4.Location = new System.Drawing.Point(413, 500);
            this.Z4.Name = "Z4";
            this.Z4.Size = new System.Drawing.Size(94, 79);
            this.Z4.TabIndex = 4;
            this.Z4.Text = "Z4";
            this.Z4.UseVisualStyleBackColor = false;
            this.Z4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Y1
            // 
            this.Y1.BackColor = System.Drawing.Color.White;
            this.Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y1.Location = new System.Drawing.Point(106, 415);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(94, 79);
            this.Y1.TabIndex = 4;
            this.Y1.Text = "Y1";
            this.Y1.UseVisualStyleBackColor = false;
            this.Y1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Y2
            // 
            this.Y2.BackColor = System.Drawing.Color.White;
            this.Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y2.Location = new System.Drawing.Point(215, 415);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(94, 79);
            this.Y2.TabIndex = 4;
            this.Y2.Text = "Y2";
            this.Y2.UseVisualStyleBackColor = false;
            this.Y2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Y3
            // 
            this.Y3.BackColor = System.Drawing.Color.White;
            this.Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y3.Location = new System.Drawing.Point(315, 415);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(94, 79);
            this.Y3.TabIndex = 4;
            this.Y3.Text = "Y3";
            this.Y3.UseVisualStyleBackColor = false;
            this.Y3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // Y4
            // 
            this.Y4.BackColor = System.Drawing.Color.White;
            this.Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y4.Location = new System.Drawing.Point(415, 415);
            this.Y4.Name = "Y4";
            this.Y4.Size = new System.Drawing.Size(94, 79);
            this.Y4.TabIndex = 4;
            this.Y4.Text = "Y4";
            this.Y4.UseVisualStyleBackColor = false;
            this.Y4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.White;
            this.A1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(672, 246);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(94, 79);
            this.A1.TabIndex = 4;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = false;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.White;
            this.B1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(670, 331);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(94, 79);
            this.B1.TabIndex = 4;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = false;
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.White;
            this.D1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Location = new System.Drawing.Point(670, 500);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(94, 79);
            this.D1.TabIndex = 4;
            this.D1.Text = "D1";
            this.D1.UseVisualStyleBackColor = false;
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.White;
            this.C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(672, 415);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(94, 79);
            this.C1.TabIndex = 4;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = false;
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.White;
            this.A2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(781, 246);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(94, 79);
            this.A2.TabIndex = 4;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = false;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.White;
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(779, 331);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(94, 79);
            this.B2.TabIndex = 4;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = false;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.White;
            this.D2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.D2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2.Location = new System.Drawing.Point(779, 500);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(94, 79);
            this.D2.TabIndex = 4;
            this.D2.Text = "D2";
            this.D2.UseVisualStyleBackColor = false;
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.White;
            this.C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(781, 415);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(94, 79);
            this.C2.TabIndex = 4;
            this.C2.Text = "C2";
            this.C2.UseVisualStyleBackColor = false;
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.White;
            this.A3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(881, 246);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(94, 79);
            this.A3.TabIndex = 4;
            this.A3.Text = "A3";
            this.A3.UseVisualStyleBackColor = false;
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.White;
            this.B3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(879, 331);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(94, 79);
            this.B3.TabIndex = 4;
            this.B3.Text = "B3";
            this.B3.UseVisualStyleBackColor = false;
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.White;
            this.D3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.D3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D3.Location = new System.Drawing.Point(879, 500);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(94, 79);
            this.D3.TabIndex = 4;
            this.D3.Text = "D3";
            this.D3.UseVisualStyleBackColor = false;
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.White;
            this.C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(881, 415);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(94, 79);
            this.C3.TabIndex = 4;
            this.C3.Text = "C3";
            this.C3.UseVisualStyleBackColor = false;
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.White;
            this.A4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.Location = new System.Drawing.Point(981, 246);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(94, 79);
            this.A4.TabIndex = 4;
            this.A4.Text = "A4";
            this.A4.UseVisualStyleBackColor = false;
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.White;
            this.B4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(979, 331);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(94, 79);
            this.B4.TabIndex = 4;
            this.B4.Text = "B4";
            this.B4.UseVisualStyleBackColor = false;
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.White;
            this.D4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.D4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D4.Location = new System.Drawing.Point(979, 500);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(94, 79);
            this.D4.TabIndex = 4;
            this.D4.Text = "D4";
            this.D4.UseVisualStyleBackColor = false;
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.Color.White;
            this.C4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C4.Location = new System.Drawing.Point(981, 415);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(94, 79);
            this.C4.TabIndex = 4;
            this.C4.Text = "C4";
            this.C4.UseVisualStyleBackColor = false;
            // 
            // EnemyPlayTimer
            // 
            this.EnemyPlayTimer.Interval = 1000;
            this.EnemyPlayTimer.Tick += new System.EventHandler(this.EnemyPlayTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleshipSimulator.Properties.Resources.BattleShip_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 656);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.Y4);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.Z4);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.X4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.W4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.Z3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.W3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.W2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Z1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.W1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.EnemyLocationListBox);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.txtHelp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.ComboBox EnemyLocationListBox;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button W1;
        private System.Windows.Forms.Button W2;
        private System.Windows.Forms.Button W3;
        private System.Windows.Forms.Button W4;
        private System.Windows.Forms.Button X1;
        private System.Windows.Forms.Button X2;
        private System.Windows.Forms.Button X3;
        private System.Windows.Forms.Button X4;
        private System.Windows.Forms.Button Z1;
        private System.Windows.Forms.Button Z2;
        private System.Windows.Forms.Button Z3;
        private System.Windows.Forms.Button Z4;
        private System.Windows.Forms.Button Y1;
        private System.Windows.Forms.Button Y2;
        private System.Windows.Forms.Button Y3;
        private System.Windows.Forms.Button Y4;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button D1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button D2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button D3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button A4;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button D4;
        private System.Windows.Forms.Button C4;
        private System.Windows.Forms.Timer EnemyPlayTimer;
    }
}

