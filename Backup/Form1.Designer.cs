
namespace Backup
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
      this.cancel = new System.Windows.Forms.Button();
      this.save = new System.Windows.Forms.Button();
      this.restore = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cancel
      // 
      this.cancel.AllowDrop = true;
      this.cancel.Location = new System.Drawing.Point(24, 22);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(105, 39);
      this.cancel.TabIndex = 0;
      this.cancel.Text = "Отменить";
      this.cancel.UseVisualStyleBackColor = true;
      this.cancel.Click += new System.EventHandler(this.cancel_Click);
      // 
      // save
      // 
      this.save.Location = new System.Drawing.Point(147, 22);
      this.save.Name = "save";
      this.save.Size = new System.Drawing.Size(104, 39);
      this.save.TabIndex = 1;
      this.save.Text = "Сохранить";
      this.save.UseVisualStyleBackColor = true;
      this.save.Click += new System.EventHandler(this.save_Click);
      // 
      // restore
      // 
      this.restore.Location = new System.Drawing.Point(272, 22);
      this.restore.Name = "restore";
      this.restore.Size = new System.Drawing.Size(187, 39);
      this.restore.TabIndex = 2;
      this.restore.Text = "Загрузить последнее сохранение";
      this.restore.UseVisualStyleBackColor = true;
      this.restore.Click += new System.EventHandler(this.restore_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.restore);
      this.Controls.Add(this.save);
      this.Controls.Add(this.cancel);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cancel;
    private System.Windows.Forms.Button save;
    private System.Windows.Forms.Button restore;
  }
}

