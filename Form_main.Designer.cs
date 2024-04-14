
namespace quickSortapp
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.lbl_Tieude = new System.Windows.Forms.Label();
            this.grb_khoitaomang = new System.Windows.Forms.GroupBox();
            this.btn_taomang = new System.Windows.Forms.Button();
            this.nmr_sophantu = new System.Windows.Forms.NumericUpDown();
            this.lbl_sophantu = new System.Windows.Forms.Label();
            this.grb_taogt = new System.Windows.Forms.GroupBox();
            this.lbl_dkgiatri = new System.Windows.Forms.Label();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_nhaptay = new System.Windows.Forms.Button();
            this.btn_readfile = new System.Windows.Forms.Button();
            this.grb_khoitaodulieu = new System.Windows.Forms.GroupBox();
            this.lb_list_code = new System.Windows.Forms.ListBox();
            this.grb_codec = new System.Windows.Forms.GroupBox();
            this.zoomCode = new System.Windows.Forms.TrackBar();
            this.rad_selections_sort = new System.Windows.Forms.RadioButton();
            this.rad_insertion_sort = new System.Windows.Forms.RadioButton();
            this.rad_heapsort = new System.Windows.Forms.RadioButton();
            this.grb_whichsort = new System.Windows.Forms.GroupBox();
            this.rad_mergesort = new System.Windows.Forms.RadioButton();
            this.rad_quicksort = new System.Windows.Forms.RadioButton();
            this.rad_bubblesort = new System.Windows.Forms.RadioButton();
            this.rad_giam = new System.Windows.Forms.RadioButton();
            this.rad_tang = new System.Windows.Forms.RadioButton();
            this.grb_control = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.btn_break = new System.Windows.Forms.Button();
            this.ckb_tungbuoc = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_mangA = new System.Windows.Forms.Label();
            this.lbl_index = new System.Windows.Forms.Label();
            this.lbl_pivot = new System.Windows.Forms.Label();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grb_khoitaomang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_sophantu)).BeginInit();
            this.grb_taogt.SuspendLayout();
            this.grb_khoitaodulieu.SuspendLayout();
            this.grb_codec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomCode)).BeginInit();
            this.grb_whichsort.SuspendLayout();
            this.grb_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tieude
            // 
            this.lbl_Tieude.AutoSize = true;
            this.lbl_Tieude.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_Tieude.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Tieude.Location = new System.Drawing.Point(97, 43);
            this.lbl_Tieude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tieude.Name = "lbl_Tieude";
            this.lbl_Tieude.Size = new System.Drawing.Size(702, 47);
            this.lbl_Tieude.TabIndex = 0;
            this.lbl_Tieude.Text = "Mô phỏng các thuật toán sắp xếp";
            this.lbl_Tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb_khoitaomang
            // 
            this.grb_khoitaomang.Controls.Add(this.btn_taomang);
            this.grb_khoitaomang.Controls.Add(this.nmr_sophantu);
            this.grb_khoitaomang.Controls.Add(this.lbl_sophantu);
            this.grb_khoitaomang.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_khoitaomang.Location = new System.Drawing.Point(0, 37);
            this.grb_khoitaomang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_khoitaomang.Name = "grb_khoitaomang";
            this.grb_khoitaomang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_khoitaomang.Size = new System.Drawing.Size(234, 83);
            this.grb_khoitaomang.TabIndex = 50;
            this.grb_khoitaomang.TabStop = false;
            this.grb_khoitaomang.Text = "Khởi Tạo Mảng A";
            // 
            // btn_taomang
            // 
            this.btn_taomang.Location = new System.Drawing.Point(67, 53);
            this.btn_taomang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_taomang.Name = "btn_taomang";
            this.btn_taomang.Size = new System.Drawing.Size(82, 26);
            this.btn_taomang.TabIndex = 6;
            this.btn_taomang.Text = "Tạo";
            this.btn_taomang.UseVisualStyleBackColor = true;
            this.btn_taomang.Click += new System.EventHandler(this.btn_taomang_Click);
            // 
            // nmr_sophantu
            // 
            this.nmr_sophantu.Location = new System.Drawing.Point(144, 23);
            this.nmr_sophantu.Margin = new System.Windows.Forms.Padding(2);
            this.nmr_sophantu.Name = "nmr_sophantu";
            this.nmr_sophantu.Size = new System.Drawing.Size(82, 20);
            this.nmr_sophantu.TabIndex = 5;
            this.nmr_sophantu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_sophantu
            // 
            this.lbl_sophantu.AutoSize = true;
            this.lbl_sophantu.Location = new System.Drawing.Point(6, 23);
            this.lbl_sophantu.Name = "lbl_sophantu";
            this.lbl_sophantu.Size = new System.Drawing.Size(127, 13);
            this.lbl_sophantu.TabIndex = 4;
            this.lbl_sophantu.Text = "Số phần tử (Max=10):";
            // 
            // grb_taogt
            // 
            this.grb_taogt.Controls.Add(this.lbl_dkgiatri);
            this.grb_taogt.Controls.Add(this.btn_random);
            this.grb_taogt.Controls.Add(this.btn_nhaptay);
            this.grb_taogt.Controls.Add(this.btn_readfile);
            this.grb_taogt.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_taogt.Location = new System.Drawing.Point(0, 124);
            this.grb_taogt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_taogt.Name = "grb_taogt";
            this.grb_taogt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_taogt.Size = new System.Drawing.Size(231, 93);
            this.grb_taogt.TabIndex = 51;
            this.grb_taogt.TabStop = false;
            this.grb_taogt.Text = " Tạo gia trị cho mảng";
            // 
            // lbl_dkgiatri
            // 
            this.lbl_dkgiatri.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dkgiatri.Location = new System.Drawing.Point(5, 24);
            this.lbl_dkgiatri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dkgiatri.Name = "lbl_dkgiatri";
            this.lbl_dkgiatri.Size = new System.Drawing.Size(68, 38);
            this.lbl_dkgiatri.TabIndex = 3;
            this.lbl_dkgiatri.Text = "a[i] >= 0 a[i] < 100";
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(144, 0);
            this.btn_random.Margin = new System.Windows.Forms.Padding(2);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(82, 26);
            this.btn_random.TabIndex = 2;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_nhaptay
            // 
            this.btn_nhaptay.Location = new System.Drawing.Point(144, 35);
            this.btn_nhaptay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nhaptay.Name = "btn_nhaptay";
            this.btn_nhaptay.Size = new System.Drawing.Size(82, 27);
            this.btn_nhaptay.TabIndex = 1;
            this.btn_nhaptay.Text = "Nhập tay";
            this.btn_nhaptay.UseVisualStyleBackColor = true;
            this.btn_nhaptay.Click += new System.EventHandler(this.btn_nhaptay_Click);
            // 
            // btn_readfile
            // 
            this.btn_readfile.Location = new System.Drawing.Point(144, 63);
            this.btn_readfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_readfile.Name = "btn_readfile";
            this.btn_readfile.Size = new System.Drawing.Size(82, 29);
            this.btn_readfile.TabIndex = 0;
            this.btn_readfile.Text = "Đọc file";
            this.btn_readfile.UseVisualStyleBackColor = true;
            this.btn_readfile.Click += new System.EventHandler(this.btn_readfile_Click);
            // 
            // grb_khoitaodulieu
            // 
            this.grb_khoitaodulieu.Controls.Add(this.grb_taogt);
            this.grb_khoitaodulieu.Controls.Add(this.grb_khoitaomang);
            this.grb_khoitaodulieu.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_khoitaodulieu.Location = new System.Drawing.Point(2, 396);
            this.grb_khoitaodulieu.Margin = new System.Windows.Forms.Padding(2);
            this.grb_khoitaodulieu.Name = "grb_khoitaodulieu";
            this.grb_khoitaodulieu.Padding = new System.Windows.Forms.Padding(2);
            this.grb_khoitaodulieu.Size = new System.Drawing.Size(231, 236);
            this.grb_khoitaodulieu.TabIndex = 52;
            this.grb_khoitaodulieu.TabStop = false;
            this.grb_khoitaodulieu.Text = "Dữ liệu";
            // 
            // lb_list_code
            // 
            this.lb_list_code.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_list_code.FormattingEnabled = true;
            this.lb_list_code.ItemHeight = 12;
            this.lb_list_code.Location = new System.Drawing.Point(0, 54);
            this.lb_list_code.Margin = new System.Windows.Forms.Padding(2);
            this.lb_list_code.Name = "lb_list_code";
            this.lb_list_code.Size = new System.Drawing.Size(470, 160);
            this.lb_list_code.TabIndex = 53;
            // 
            // grb_codec
            // 
            this.grb_codec.Controls.Add(this.zoomCode);
            this.grb_codec.Controls.Add(this.lb_list_code);
            this.grb_codec.Controls.Add(this.rad_selections_sort);
            this.grb_codec.Controls.Add(this.rad_insertion_sort);
            this.grb_codec.Controls.Add(this.rad_heapsort);
            this.grb_codec.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_codec.Location = new System.Drawing.Point(241, 399);
            this.grb_codec.Margin = new System.Windows.Forms.Padding(2);
            this.grb_codec.Name = "grb_codec";
            this.grb_codec.Padding = new System.Windows.Forms.Padding(2);
            this.grb_codec.Size = new System.Drawing.Size(457, 214);
            this.grb_codec.TabIndex = 54;
            this.grb_codec.TabStop = false;
            this.grb_codec.Text = "Code C/C++";
            // 
            // zoomCode
            // 
            this.zoomCode.AutoSize = false;
            this.zoomCode.Location = new System.Drawing.Point(0, 30);
            this.zoomCode.Margin = new System.Windows.Forms.Padding(2);
            this.zoomCode.Name = "zoomCode";
            this.zoomCode.Size = new System.Drawing.Size(457, 24);
            this.zoomCode.TabIndex = 54;
            this.zoomCode.Scroll += new System.EventHandler(this.zoomCode_Scroll);
            // 
            // rad_selections_sort
            // 
            this.rad_selections_sort.AutoSize = true;
            this.rad_selections_sort.Location = new System.Drawing.Point(261, 112);
            this.rad_selections_sort.Margin = new System.Windows.Forms.Padding(2);
            this.rad_selections_sort.Name = "rad_selections_sort";
            this.rad_selections_sort.Size = new System.Drawing.Size(138, 21);
            this.rad_selections_sort.TabIndex = 1;
            this.rad_selections_sort.Text = "Selection sort";
            this.rad_selections_sort.UseVisualStyleBackColor = true;
            // 
            // rad_insertion_sort
            // 
            this.rad_insertion_sort.AutoSize = true;
            this.rad_insertion_sort.Location = new System.Drawing.Point(284, 97);
            this.rad_insertion_sort.Margin = new System.Windows.Forms.Padding(2);
            this.rad_insertion_sort.Name = "rad_insertion_sort";
            this.rad_insertion_sort.Size = new System.Drawing.Size(138, 21);
            this.rad_insertion_sort.TabIndex = 2;
            this.rad_insertion_sort.Text = "Insertion sort";
            this.rad_insertion_sort.UseVisualStyleBackColor = true;
            // 
            // rad_heapsort
            // 
            this.rad_heapsort.AutoSize = true;
            this.rad_heapsort.Location = new System.Drawing.Point(338, 154);
            this.rad_heapsort.Margin = new System.Windows.Forms.Padding(2);
            this.rad_heapsort.Name = "rad_heapsort";
            this.rad_heapsort.Size = new System.Drawing.Size(98, 21);
            this.rad_heapsort.TabIndex = 5;
            this.rad_heapsort.Text = "Heap sort";
            this.rad_heapsort.UseVisualStyleBackColor = true;
            // 
            // grb_whichsort
            // 
            this.grb_whichsort.Controls.Add(this.rad_mergesort);
            this.grb_whichsort.Controls.Add(this.rad_quicksort);
            this.grb_whichsort.Controls.Add(this.rad_bubblesort);
            this.grb_whichsort.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_whichsort.Location = new System.Drawing.Point(735, 399);
            this.grb_whichsort.Margin = new System.Windows.Forms.Padding(2);
            this.grb_whichsort.Name = "grb_whichsort";
            this.grb_whichsort.Padding = new System.Windows.Forms.Padding(2);
            this.grb_whichsort.Size = new System.Drawing.Size(161, 216);
            this.grb_whichsort.TabIndex = 55;
            this.grb_whichsort.TabStop = false;
            this.grb_whichsort.Text = "Thuật toán";
            // 
            // rad_mergesort
            // 
            this.rad_mergesort.AutoSize = true;
            this.rad_mergesort.Location = new System.Drawing.Point(15, 114);
            this.rad_mergesort.Margin = new System.Windows.Forms.Padding(2);
            this.rad_mergesort.Name = "rad_mergesort";
            this.rad_mergesort.Size = new System.Drawing.Size(106, 21);
            this.rad_mergesort.TabIndex = 4;
            this.rad_mergesort.Text = "Merge sort";
            this.rad_mergesort.UseVisualStyleBackColor = true;
            this.rad_mergesort.CheckedChanged += new System.EventHandler(this.rad_mergesort_CheckedChanged);
            // 
            // rad_quicksort
            // 
            this.rad_quicksort.AutoSize = true;
            this.rad_quicksort.Location = new System.Drawing.Point(15, 73);
            this.rad_quicksort.Margin = new System.Windows.Forms.Padding(2);
            this.rad_quicksort.Name = "rad_quicksort";
            this.rad_quicksort.Size = new System.Drawing.Size(106, 21);
            this.rad_quicksort.TabIndex = 3;
            this.rad_quicksort.Text = "Quick sort";
            this.rad_quicksort.UseVisualStyleBackColor = true;
            this.rad_quicksort.CheckedChanged += new System.EventHandler(this.rad_quicksort_CheckedChanged);
            // 
            // rad_bubblesort
            // 
            this.rad_bubblesort.AutoSize = true;
            this.rad_bubblesort.Checked = true;
            this.rad_bubblesort.Location = new System.Drawing.Point(15, 35);
            this.rad_bubblesort.Margin = new System.Windows.Forms.Padding(2);
            this.rad_bubblesort.Name = "rad_bubblesort";
            this.rad_bubblesort.Size = new System.Drawing.Size(114, 21);
            this.rad_bubblesort.TabIndex = 0;
            this.rad_bubblesort.TabStop = true;
            this.rad_bubblesort.Text = "Bubble sort";
            this.rad_bubblesort.UseVisualStyleBackColor = true;
            this.rad_bubblesort.CheckedChanged += new System.EventHandler(this.rad_bubblesort_CheckedChanged);
            // 
            // rad_giam
            // 
            this.rad_giam.AutoSize = true;
            this.rad_giam.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_giam.Location = new System.Drawing.Point(12, 54);
            this.rad_giam.Margin = new System.Windows.Forms.Padding(2);
            this.rad_giam.Name = "rad_giam";
            this.rad_giam.Size = new System.Drawing.Size(97, 17);
            this.rad_giam.TabIndex = 1;
            this.rad_giam.Text = "Sắp xếp giảm";
            this.rad_giam.UseVisualStyleBackColor = true;
            // 
            // rad_tang
            // 
            this.rad_tang.AutoSize = true;
            this.rad_tang.Checked = true;
            this.rad_tang.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tang.Location = new System.Drawing.Point(12, 28);
            this.rad_tang.Margin = new System.Windows.Forms.Padding(2);
            this.rad_tang.Name = "rad_tang";
            this.rad_tang.Size = new System.Drawing.Size(97, 17);
            this.rad_tang.TabIndex = 0;
            this.rad_tang.TabStop = true;
            this.rad_tang.Text = "Sắp xếp tăng";
            this.rad_tang.UseVisualStyleBackColor = true;
            this.rad_tang.CheckedChanged += new System.EventHandler(this.rad_tang_CheckedChanged);
            // 
            // grb_control
            // 
            this.grb_control.Controls.Add(this.trackBar1);
            this.grb_control.Controls.Add(this.btn_pause);
            this.grb_control.Controls.Add(this.btn_sapxep);
            this.grb_control.Controls.Add(this.btn_break);
            this.grb_control.Controls.Add(this.rad_giam);
            this.grb_control.Controls.Add(this.rad_tang);
            this.grb_control.Controls.Add(this.ckb_tungbuoc);
            this.grb_control.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_control.Location = new System.Drawing.Point(925, 401);
            this.grb_control.Margin = new System.Windows.Forms.Padding(2);
            this.grb_control.Name = "grb_control";
            this.grb_control.Padding = new System.Windows.Forms.Padding(2);
            this.grb_control.Size = new System.Drawing.Size(192, 214);
            this.grb_control.TabIndex = 56;
            this.grb_control.TabStop = false;
            this.grb_control.Text = "Điều khiển";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(159, 7);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(29, 204);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_pause
            // 
            this.btn_pause.Image = global::quickSortapp.Properties.Resources.img_pause;
            this.btn_pause.Location = new System.Drawing.Point(12, 122);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(40, 44);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Image = global::quickSortapp.Properties.Resources.img_play;
            this.btn_sapxep.Location = new System.Drawing.Point(12, 122);
            this.btn_sapxep.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(40, 44);
            this.btn_sapxep.TabIndex = 4;
            this.btn_sapxep.UseVisualStyleBackColor = true;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // btn_break
            // 
            this.btn_break.Image = global::quickSortapp.Properties.Resources.img_break;
            this.btn_break.Location = new System.Drawing.Point(98, 122);
            this.btn_break.Margin = new System.Windows.Forms.Padding(2);
            this.btn_break.Name = "btn_break";
            this.btn_break.Size = new System.Drawing.Size(57, 44);
            this.btn_break.TabIndex = 3;
            this.btn_break.UseVisualStyleBackColor = true;
            this.btn_break.Click += new System.EventHandler(this.btn_break_Click);
            // 
            // ckb_tungbuoc
            // 
            this.ckb_tungbuoc.AutoSize = true;
            this.ckb_tungbuoc.Checked = true;
            this.ckb_tungbuoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_tungbuoc.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_tungbuoc.Location = new System.Drawing.Point(12, 88);
            this.ckb_tungbuoc.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_tungbuoc.Name = "ckb_tungbuoc";
            this.ckb_tungbuoc.Size = new System.Drawing.Size(110, 17);
            this.ckb_tungbuoc.TabIndex = 0;
            this.ckb_tungbuoc.Text = "Chạy từng bước";
            this.ckb_tungbuoc.UseVisualStyleBackColor = true;
            this.ckb_tungbuoc.CheckedChanged += new System.EventHandler(this.ckb_tungbuoc_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Consolas", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_status.Location = new System.Drawing.Point(311, 7);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(90, 27);
            this.lbl_status.TabIndex = 57;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mangA
            // 
            this.lbl_mangA.AutoSize = true;
            this.lbl_mangA.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mangA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_mangA.Location = new System.Drawing.Point(15, 122);
            this.lbl_mangA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mangA.Name = "lbl_mangA";
            this.lbl_mangA.Size = new System.Drawing.Size(56, 41);
            this.lbl_mangA.TabIndex = 55;
            this.lbl_mangA.Text = "A:";
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.ForeColor = System.Drawing.Color.Red;
            this.lbl_index.Location = new System.Drawing.Point(15, 284);
            this.lbl_index.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(104, 32);
            this.lbl_index.TabIndex = 58;
            this.lbl_index.Text = "index:";
            // 
            // lbl_pivot
            // 
            this.lbl_pivot.AutoSize = true;
            this.lbl_pivot.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pivot.Location = new System.Drawing.Point(861, 26);
            this.lbl_pivot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pivot.Name = "lbl_pivot";
            this.lbl_pivot.Size = new System.Drawing.Size(98, 23);
            this.lbl_pivot.TabIndex = 59;
            this.lbl_pivot.Text = "Status 1";
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_left.Location = new System.Drawing.Point(862, 67);
            this.lbl_left.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(98, 23);
            this.lbl_left.TabIndex = 60;
            this.lbl_left.Text = "Status 2";
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_right.Location = new System.Drawing.Point(862, 110);
            this.lbl_right.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(98, 23);
            this.lbl_right.TabIndex = 61;
            this.lbl_right.Text = "Status 3";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1128, 638);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.lbl_pivot);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.lbl_mangA);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.grb_control);
            this.Controls.Add(this.grb_whichsort);
            this.Controls.Add(this.grb_codec);
            this.Controls.Add(this.grb_khoitaodulieu);
            this.Controls.Add(this.lbl_Tieude);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTL_CDN nhóm 04: Mô phỏng 3 thuật toán sắp xếp Bubble sort, Quicksort, Merge sort" +
    "";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.grb_khoitaomang.ResumeLayout(false);
            this.grb_khoitaomang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_sophantu)).EndInit();
            this.grb_taogt.ResumeLayout(false);
            this.grb_khoitaodulieu.ResumeLayout(false);
            this.grb_codec.ResumeLayout(false);
            this.grb_codec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomCode)).EndInit();
            this.grb_whichsort.ResumeLayout(false);
            this.grb_whichsort.PerformLayout();
            this.grb_control.ResumeLayout(false);
            this.grb_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tieude;
        private System.Windows.Forms.GroupBox grb_khoitaomang;
        private System.Windows.Forms.Label lbl_sophantu;
        private System.Windows.Forms.NumericUpDown nmr_sophantu;
        private System.Windows.Forms.GroupBox grb_taogt;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_nhaptay;
        private System.Windows.Forms.Button btn_readfile;
        private System.Windows.Forms.GroupBox grb_khoitaodulieu;
        private System.Windows.Forms.Button btn_taomang;
        private System.Windows.Forms.ListBox lb_list_code;
        private System.Windows.Forms.GroupBox grb_codec;
        private System.Windows.Forms.GroupBox grb_whichsort;
        private System.Windows.Forms.RadioButton rad_giam;
        private System.Windows.Forms.RadioButton rad_tang;
        private System.Windows.Forms.GroupBox grb_control;
        private System.Windows.Forms.CheckBox ckb_tungbuoc;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_dkgiatri;
        private System.Windows.Forms.Label lbl_mangA;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Label lbl_pivot;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.RadioButton rad_heapsort;
        private System.Windows.Forms.RadioButton rad_mergesort;
        private System.Windows.Forms.RadioButton rad_quicksort;
        private System.Windows.Forms.RadioButton rad_insertion_sort;
        private System.Windows.Forms.RadioButton rad_selections_sort;
        private System.Windows.Forms.RadioButton rad_bubblesort;
        private System.Windows.Forms.Button btn_break;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar zoomCode;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}