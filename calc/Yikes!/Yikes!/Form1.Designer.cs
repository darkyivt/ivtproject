namespace Yikes_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bplus = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bsin = new System.Windows.Forms.Button();
            this.btan = new System.Windows.Forms.Button();
            this.bcos = new System.Windows.Forms.Button();
            this.bln = new System.Windows.Forms.Button();
            this.bsquare = new System.Windows.Forms.Button();
            this.bpow = new System.Windows.Forms.Button();
            this.blog = new System.Windows.Forms.Button();
            this.bmod = new System.Windows.Forms.Button();
            this.bexp = new System.Windows.Forms.Button();
            this.bcube = new System.Windows.Forms.Button();
            this.bl10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcsin = new System.Windows.Forms.Button();
            this.barccos = new System.Windows.Forms.Button();
            this.barctan = new System.Windows.Forms.Button();
            this.barcctg = new System.Windows.Forms.Button();
            this.bfivestep = new System.Windows.Forms.Button();
            this.brevers = new System.Windows.Forms.Button();
            this.btanh = new System.Windows.Forms.Button();
            this.bsqrt = new System.Windows.Forms.Button();
            this.brad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bplus
            // 
            this.bplus.Location = new System.Drawing.Point(13, 98);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(75, 23);
            this.bplus.TabIndex = 2;
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            this.bplus.Click += new System.EventHandler(this.rnd_Click2);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(94, 98);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 23);
            this.bdiv.TabIndex = 3;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.rnd_Click2);
            // 
            // bminus
            // 
            this.bminus.Location = new System.Drawing.Point(175, 98);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(75, 23);
            this.bminus.TabIndex = 4;
            this.bminus.Text = "-";
            this.bminus.UseVisualStyleBackColor = true;
            this.bminus.Click += new System.EventHandler(this.rnd_Click2);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(94, 127);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(75, 23);
            this.bmult.TabIndex = 5;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.rnd_Click2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SAMPLE TEXT";
            // 
            // bsin
            // 
            this.bsin.Location = new System.Drawing.Point(13, 178);
            this.bsin.Name = "bsin";
            this.bsin.Size = new System.Drawing.Size(75, 23);
            this.bsin.TabIndex = 7;
            this.bsin.Text = "sin";
            this.bsin.UseVisualStyleBackColor = true;
            this.bsin.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // btan
            // 
            this.btan.Location = new System.Drawing.Point(94, 178);
            this.btan.Name = "btan";
            this.btan.Size = new System.Drawing.Size(75, 23);
            this.btan.TabIndex = 8;
            this.btan.Text = "tan";
            this.btan.UseVisualStyleBackColor = true;
            this.btan.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bcos
            // 
            this.bcos.Location = new System.Drawing.Point(175, 178);
            this.bcos.Name = "bcos";
            this.bcos.Size = new System.Drawing.Size(75, 23);
            this.bcos.TabIndex = 9;
            this.bcos.Text = "cos";
            this.bcos.UseVisualStyleBackColor = true;
            this.bcos.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bln
            // 
            this.bln.Location = new System.Drawing.Point(94, 207);
            this.bln.Name = "bln";
            this.bln.Size = new System.Drawing.Size(75, 23);
            this.bln.TabIndex = 10;
            this.bln.Text = "ln";
            this.bln.UseVisualStyleBackColor = true;
            this.bln.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bsquare
            // 
            this.bsquare.Location = new System.Drawing.Point(13, 207);
            this.bsquare.Name = "bsquare";
            this.bsquare.Size = new System.Drawing.Size(75, 23);
            this.bsquare.TabIndex = 11;
            this.bsquare.Text = "^2";
            this.bsquare.UseVisualStyleBackColor = true;
            this.bsquare.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bpow
            // 
            this.bpow.Location = new System.Drawing.Point(13, 127);
            this.bpow.Name = "bpow";
            this.bpow.Size = new System.Drawing.Size(75, 23);
            this.bpow.TabIndex = 12;
            this.bpow.Text = "^X";
            this.bpow.UseVisualStyleBackColor = true;
            this.bpow.Click += new System.EventHandler(this.rnd_Click2);
            // 
            // blog
            // 
            this.blog.Location = new System.Drawing.Point(175, 127);
            this.blog.Name = "blog";
            this.blog.Size = new System.Drawing.Size(75, 23);
            this.blog.TabIndex = 13;
            this.blog.Text = "logX(Y)";
            this.blog.UseVisualStyleBackColor = true;
            this.blog.Click += new System.EventHandler(this.rnd_Click2);
            // 
            // bmod
            // 
            this.bmod.Location = new System.Drawing.Point(175, 207);
            this.bmod.Name = "bmod";
            this.bmod.Size = new System.Drawing.Size(75, 23);
            this.bmod.TabIndex = 14;
            this.bmod.Text = "[X]";
            this.bmod.UseVisualStyleBackColor = true;
            this.bmod.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bexp
            // 
            this.bexp.Location = new System.Drawing.Point(12, 236);
            this.bexp.Name = "bexp";
            this.bexp.Size = new System.Drawing.Size(75, 23);
            this.bexp.TabIndex = 15;
            this.bexp.Text = "e^(X)";
            this.bexp.UseVisualStyleBackColor = true;
            this.bexp.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bcube
            // 
            this.bcube.Location = new System.Drawing.Point(94, 236);
            this.bcube.Name = "bcube";
            this.bcube.Size = new System.Drawing.Size(75, 23);
            this.bcube.TabIndex = 16;
            this.bcube.Text = "^3";
            this.bcube.UseVisualStyleBackColor = true;
            this.bcube.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bl10
            // 
            this.bl10.Location = new System.Drawing.Point(175, 236);
            this.bl10.Name = "bl10";
            this.bl10.Size = new System.Drawing.Size(75, 23);
            this.bl10.TabIndex = 17;
            this.bl10.Text = "log10(X)";
            this.bl10.UseVisualStyleBackColor = true;
            this.bl10.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "One-Argument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Two-Argument";
            // 
            // barcsin
            // 
            this.barcsin.Location = new System.Drawing.Point(13, 265);
            this.barcsin.Name = "barcsin";
            this.barcsin.Size = new System.Drawing.Size(75, 23);
            this.barcsin.TabIndex = 20;
            this.barcsin.Text = "arcsin";
            this.barcsin.UseVisualStyleBackColor = true;
            this.barcsin.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // barccos
            // 
            this.barccos.Location = new System.Drawing.Point(94, 265);
            this.barccos.Name = "barccos";
            this.barccos.Size = new System.Drawing.Size(75, 23);
            this.barccos.TabIndex = 21;
            this.barccos.Text = "arccos";
            this.barccos.UseVisualStyleBackColor = true;
            this.barccos.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // barctan
            // 
            this.barctan.Location = new System.Drawing.Point(175, 265);
            this.barctan.Name = "barctan";
            this.barctan.Size = new System.Drawing.Size(75, 23);
            this.barctan.TabIndex = 22;
            this.barctan.Text = "arctan";
            this.barctan.UseVisualStyleBackColor = true;
            this.barctan.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // barcctg
            // 
            this.barcctg.Location = new System.Drawing.Point(13, 294);
            this.barcctg.Name = "barcctg";
            this.barcctg.Size = new System.Drawing.Size(75, 23);
            this.barcctg.TabIndex = 23;
            this.barcctg.Text = "arcctg";
            this.barcctg.UseVisualStyleBackColor = true;
            this.barcctg.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bfivestep
            // 
            this.bfivestep.Location = new System.Drawing.Point(94, 294);
            this.bfivestep.Name = "bfivestep";
            this.bfivestep.Size = new System.Drawing.Size(75, 23);
            this.bfivestep.TabIndex = 24;
            this.bfivestep.Text = "x^5";
            this.bfivestep.UseVisualStyleBackColor = true;
            this.bfivestep.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // brevers
            // 
            this.brevers.Location = new System.Drawing.Point(175, 294);
            this.brevers.Name = "brevers";
            this.brevers.Size = new System.Drawing.Size(75, 23);
            this.brevers.TabIndex = 25;
            this.brevers.Text = "1/x";
            this.brevers.UseVisualStyleBackColor = true;
            this.brevers.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // btanh
            // 
            this.btanh.Location = new System.Drawing.Point(13, 323);
            this.btanh.Name = "btanh";
            this.btanh.Size = new System.Drawing.Size(75, 23);
            this.btanh.TabIndex = 26;
            this.btanh.Text = "tanh";
            this.btanh.UseVisualStyleBackColor = true;
            this.btanh.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // bsqrt
            // 
            this.bsqrt.Location = new System.Drawing.Point(97, 323);
            this.bsqrt.Name = "bsqrt";
            this.bsqrt.Size = new System.Drawing.Size(75, 23);
            this.bsqrt.TabIndex = 27;
            this.bsqrt.Text = "x^0,5";
            this.bsqrt.UseVisualStyleBackColor = true;
            this.bsqrt.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // brad
            // 
            this.brad.Location = new System.Drawing.Point(175, 323);
            this.brad.Name = "brad";
            this.brad.Size = new System.Drawing.Size(75, 23);
            this.brad.TabIndex = 28;
            this.brad.Text = "rad";
            this.brad.UseVisualStyleBackColor = true;
            this.brad.Click += new System.EventHandler(this.rnd_Click1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 349);
            this.Controls.Add(this.brad);
            this.Controls.Add(this.bsqrt);
            this.Controls.Add(this.btanh);
            this.Controls.Add(this.brevers);
            this.Controls.Add(this.bfivestep);
            this.Controls.Add(this.barcctg);
            this.Controls.Add(this.barctan);
            this.Controls.Add(this.barccos);
            this.Controls.Add(this.barcsin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bl10);
            this.Controls.Add(this.bcube);
            this.Controls.Add(this.bexp);
            this.Controls.Add(this.bmod);
            this.Controls.Add(this.blog);
            this.Controls.Add(this.bpow);
            this.Controls.Add(this.bsquare);
            this.Controls.Add(this.bln);
            this.Controls.Add(this.bcos);
            this.Controls.Add(this.btan);
            this.Controls.Add(this.bsin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bminus);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bsin;
        private System.Windows.Forms.Button btan;
        private System.Windows.Forms.Button bcos;
        private System.Windows.Forms.Button bln;
        private System.Windows.Forms.Button bsquare;
        private System.Windows.Forms.Button bpow;
        private System.Windows.Forms.Button blog;
        private System.Windows.Forms.Button bmod;
        private System.Windows.Forms.Button bexp;
        private System.Windows.Forms.Button bcube;
        private System.Windows.Forms.Button bl10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button barcsin;
        private System.Windows.Forms.Button barccos;
        private System.Windows.Forms.Button barctan;
        private System.Windows.Forms.Button barcctg;
        private System.Windows.Forms.Button bfivestep;
        private System.Windows.Forms.Button brevers;
        private System.Windows.Forms.Button btanh;
        private System.Windows.Forms.Button bsqrt;
        private System.Windows.Forms.Button brad;
    }
}

