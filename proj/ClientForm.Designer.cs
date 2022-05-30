
namespace projectsamozachet
{
    partial class ClientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_dish = new System.Windows.Forms.DataGridView();
            this.tb_id_dish = new System.Windows.Forms.TextBox();
            this.tb_name_dish = new System.Windows.Forms.TextBox();
            this.tb_type_dish = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.execute_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_price_rub = new System.Windows.Forms.TextBox();
            this.tb_weight_gram = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dish)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dish
            // 
            this.dgv_dish.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dish.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dish.Location = new System.Drawing.Point(4, 4);
            this.dgv_dish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_dish.Name = "dgv_dish";
            this.dgv_dish.RowHeadersWidth = 51;
            this.dgv_dish.RowTemplate.Height = 24;
            this.dgv_dish.Size = new System.Drawing.Size(920, 343);
            this.dgv_dish.TabIndex = 0;
            this.dgv_dish.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dish_CellContentClick);
            // 
            // tb_id_dish
            // 
            this.tb_id_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id_dish.Location = new System.Drawing.Point(230, 354);
            this.tb_id_dish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_id_dish.Name = "tb_id_dish";
            this.tb_id_dish.Size = new System.Drawing.Size(693, 39);
            this.tb_id_dish.TabIndex = 3;
            // 
            // tb_name_dish
            // 
            this.tb_name_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name_dish.Location = new System.Drawing.Point(230, 403);
            this.tb_name_dish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name_dish.Name = "tb_name_dish";
            this.tb_name_dish.Size = new System.Drawing.Size(693, 39);
            this.tb_name_dish.TabIndex = 4;
            // 
            // tb_type_dish
            // 
            this.tb_type_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_type_dish.Location = new System.Drawing.Point(230, 452);
            this.tb_type_dish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_type_dish.Name = "tb_type_dish";
            this.tb_type_dish.Size = new System.Drawing.Size(693, 39);
            this.tb_type_dish.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(952, 371);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(202, 197);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "изменить";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.Location = new System.Drawing.Point(999, 174);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(255, 190);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "удалить";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_insert.Location = new System.Drawing.Point(953, 17);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(246, 150);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "добавить";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "id";
            // 
            // execute_info
            // 
            this.execute_info.AutoSize = true;
            this.execute_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.execute_info.Location = new System.Drawing.Point(1005, 571);
            this.execute_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.execute_info.Name = "execute_info";
            this.execute_info.Size = new System.Drawing.Size(189, 32);
            this.execute_info.TabIndex = 17;
            this.execute_info.Text = "запросов нет";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_price_rub);
            this.panel1.Controls.Add(this.tb_weight_gram);
            this.panel1.Controls.Add(this.dgv_dish);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_id_dish);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_name_dish);
            this.panel1.Controls.Add(this.tb_type_dish);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 598);
            this.panel1.TabIndex = 18;
            // 
            // tb_price_rub
            // 
            this.tb_price_rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_price_rub.Location = new System.Drawing.Point(230, 551);
            this.tb_price_rub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_price_rub.Name = "tb_price_rub";
            this.tb_price_rub.Size = new System.Drawing.Size(693, 39);
            this.tb_price_rub.TabIndex = 15;
            // 
            // tb_weight_gram
            // 
            this.tb_weight_gram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_weight_gram.Location = new System.Drawing.Point(230, 502);
            this.tb_weight_gram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_weight_gram.Name = "tb_weight_gram";
            this.tb_weight_gram.Size = new System.Drawing.Size(693, 39);
            this.tb_weight_gram.TabIndex = 13;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 631);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.execute_info);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dish_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dish)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dish;
        private System.Windows.Forms.TextBox tb_id_dish;
        private System.Windows.Forms.TextBox tb_name_dish;
        private System.Windows.Forms.TextBox tb_type_dish;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label execute_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_price_rub;
        private System.Windows.Forms.TextBox tb_weight_gram;
    }
}