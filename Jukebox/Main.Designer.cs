namespace Jukebox
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tlpSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.JUKEBOX = new System.Windows.Forms.Label();
            this.tlpGeral = new System.Windows.Forms.TableLayoutPanel();
            this.lblB = new System.Windows.Forms.Label();
            this.lstB = new System.Windows.Forms.ListBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lblA = new System.Windows.Forms.Label();
            this.tmr_Geral = new System.Windows.Forms.Timer(this.components);
            this.tlpInferior = new System.Windows.Forms.TableLayoutPanel();
            this.lblQtdeMusicas = new System.Windows.Forms.Label();
            this.lblTocandoAgora = new System.Windows.Forms.Label();
            this.pcbGifNotasMusicais = new System.Windows.Forms.PictureBox();
            this.PicBox_LadoB = new System.Windows.Forms.PictureBox();
            this.PicBox_LadoA = new System.Windows.Forms.PictureBox();
            this.picBox_Jeroguix = new System.Windows.Forms.PictureBox();
            this.lblMusicPlaying = new System.Windows.Forms.Label();
            this.tlpSuperior.SuspendLayout();
            this.tlpGeral.SuspendLayout();
            this.tlpInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGifNotasMusicais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_LadoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_LadoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Jeroguix)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSuperior
            // 
            this.tlpSuperior.BackColor = System.Drawing.Color.Gold;
            this.tlpSuperior.ColumnCount = 4;
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.79171F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.45327F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.95976F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.79525F));
            this.tlpSuperior.Controls.Add(this.lbl_Data, 3, 1);
            this.tlpSuperior.Controls.Add(this.lbl_Hora, 3, 0);
            this.tlpSuperior.Controls.Add(this.JUKEBOX, 2, 0);
            this.tlpSuperior.Controls.Add(this.picBox_Jeroguix, 0, 0);
            this.tlpSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpSuperior.Name = "tlpSuperior";
            this.tlpSuperior.RowCount = 2;
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSuperior.Size = new System.Drawing.Size(1319, 72);
            this.tlpSuperior.TabIndex = 0;
            // 
            // lbl_Data
            // 
            this.lbl_Data.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(1222, 36);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(94, 36);
            this.lbl_Data.TabIndex = 16;
            this.lbl_Data.Text = "DATA: 27/06/18";
            this.lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(1166, 6);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(150, 23);
            this.lbl_Hora.TabIndex = 17;
            this.lbl_Hora.Text = "HORA: 12:06:23";
            this.lbl_Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JUKEBOX
            // 
            this.JUKEBOX.Font = new System.Drawing.Font("Broadway", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUKEBOX.Location = new System.Drawing.Point(388, 0);
            this.JUKEBOX.Name = "JUKEBOX";
            this.tlpSuperior.SetRowSpan(this.JUKEBOX, 2);
            this.JUKEBOX.Size = new System.Drawing.Size(771, 72);
            this.JUKEBOX.TabIndex = 0;
            this.JUKEBOX.Text = "JUKEBOX";
            this.JUKEBOX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpGeral
            // 
            this.tlpGeral.BackColor = System.Drawing.Color.Black;
            this.tlpGeral.ColumnCount = 5;
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.552822F));
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.87894F));
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.587856F));
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.87894F));
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.1014514F));
            this.tlpGeral.Controls.Add(this.lblB, 3, 2);
            this.tlpGeral.Controls.Add(this.lstB, 3, 3);
            this.tlpGeral.Controls.Add(this.PicBox_LadoB, 3, 1);
            this.tlpGeral.Controls.Add(this.PicBox_LadoA, 1, 1);
            this.tlpGeral.Controls.Add(this.lstA, 1, 3);
            this.tlpGeral.Controls.Add(this.lblA, 1, 2);
            this.tlpGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeral.Location = new System.Drawing.Point(0, 72);
            this.tlpGeral.Name = "tlpGeral";
            this.tlpGeral.RowCount = 5;
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.406155F));
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28678F));
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.614133F));
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28678F));
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.406155F));
            this.tlpGeral.Size = new System.Drawing.Size(1319, 646);
            this.tlpGeral.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Gold;
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblB.Location = new System.Drawing.Point(688, 301);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(625, 42);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "CD - B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstB
            // 
            this.lstB.BackColor = System.Drawing.Color.Silver;
            this.lstB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 32;
            this.lstB.Location = new System.Drawing.Point(688, 346);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(625, 286);
            this.lstB.TabIndex = 1;
            this.lstB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstB_KeyDown);
            this.lstB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstB_KeyPress);
            // 
            // lstA
            // 
            this.lstA.BackColor = System.Drawing.Color.Silver;
            this.lstA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstA.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 32;
            this.lstA.Location = new System.Drawing.Point(23, 346);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(625, 286);
            this.lstA.Sorted = true;
            this.lstA.TabIndex = 0;
            this.lstA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstA_KeyDown);
            this.lstA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstA_KeyPress);
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.Color.Gold;
            this.lblA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(23, 301);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(625, 42);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "CD - A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_Geral
            // 
            this.tmr_Geral.Enabled = true;
            this.tmr_Geral.Tick += new System.EventHandler(this.tmr_Geral_Tick);
            // 
            // tlpInferior
            // 
            this.tlpInferior.BackColor = System.Drawing.Color.Gold;
            this.tlpInferior.ColumnCount = 4;
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.9593F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.893458F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.60491F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.54233F));
            this.tlpInferior.Controls.Add(this.lblMusicPlaying, 2, 0);
            this.tlpInferior.Controls.Add(this.lblQtdeMusicas, 3, 0);
            this.tlpInferior.Controls.Add(this.lblTocandoAgora, 0, 0);
            this.tlpInferior.Controls.Add(this.pcbGifNotasMusicais, 1, 0);
            this.tlpInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpInferior.Location = new System.Drawing.Point(0, 671);
            this.tlpInferior.Name = "tlpInferior";
            this.tlpInferior.RowCount = 1;
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInferior.Size = new System.Drawing.Size(1319, 47);
            this.tlpInferior.TabIndex = 2;
            // 
            // lblQtdeMusicas
            // 
            this.lblQtdeMusicas.BackColor = System.Drawing.Color.Gold;
            this.lblQtdeMusicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdeMusicas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeMusicas.Location = new System.Drawing.Point(944, 0);
            this.lblQtdeMusicas.Name = "lblQtdeMusicas";
            this.lblQtdeMusicas.Size = new System.Drawing.Size(372, 47);
            this.lblQtdeMusicas.TabIndex = 6;
            this.lblQtdeMusicas.Text = "Musicas Selecionadas:  000";
            this.lblQtdeMusicas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTocandoAgora
            // 
            this.lblTocandoAgora.BackColor = System.Drawing.Color.Gold;
            this.lblTocandoAgora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTocandoAgora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTocandoAgora.Location = new System.Drawing.Point(3, 0);
            this.lblTocandoAgora.Name = "lblTocandoAgora";
            this.lblTocandoAgora.Size = new System.Drawing.Size(138, 47);
            this.lblTocandoAgora.TabIndex = 5;
            this.lblTocandoAgora.Text = "TOCANDO AGORA:";
            this.lblTocandoAgora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbGifNotasMusicais
            // 
            this.pcbGifNotasMusicais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbGifNotasMusicais.Image = global::Jukebox.Properties.Resources.gif;
            this.pcbGifNotasMusicais.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbGifNotasMusicais.InitialImage")));
            this.pcbGifNotasMusicais.Location = new System.Drawing.Point(147, 3);
            this.pcbGifNotasMusicais.Name = "pcbGifNotasMusicais";
            this.pcbGifNotasMusicais.Size = new System.Drawing.Size(98, 41);
            this.pcbGifNotasMusicais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGifNotasMusicais.TabIndex = 7;
            this.pcbGifNotasMusicais.TabStop = false;
            // 
            // PicBox_LadoB
            // 
            this.PicBox_LadoB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox_LadoB.Location = new System.Drawing.Point(688, 12);
            this.PicBox_LadoB.Name = "PicBox_LadoB";
            this.PicBox_LadoB.Size = new System.Drawing.Size(625, 286);
            this.PicBox_LadoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_LadoB.TabIndex = 1;
            this.PicBox_LadoB.TabStop = false;
            // 
            // PicBox_LadoA
            // 
            this.PicBox_LadoA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox_LadoA.Location = new System.Drawing.Point(23, 12);
            this.PicBox_LadoA.Name = "PicBox_LadoA";
            this.PicBox_LadoA.Size = new System.Drawing.Size(625, 286);
            this.PicBox_LadoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_LadoA.TabIndex = 0;
            this.PicBox_LadoA.TabStop = false;
            // 
            // picBox_Jeroguix
            // 
            this.picBox_Jeroguix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_Jeroguix.Image = global::Jukebox.Properties.Resources.LogoJeroguix;
            this.picBox_Jeroguix.Location = new System.Drawing.Point(3, 3);
            this.picBox_Jeroguix.Name = "picBox_Jeroguix";
            this.tlpSuperior.SetRowSpan(this.picBox_Jeroguix, 2);
            this.picBox_Jeroguix.Size = new System.Drawing.Size(149, 66);
            this.picBox_Jeroguix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Jeroguix.TabIndex = 18;
            this.picBox_Jeroguix.TabStop = false;
            // 
            // lblMusicPlaying
            // 
            this.lblMusicPlaying.BackColor = System.Drawing.Color.Gold;
            this.lblMusicPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMusicPlaying.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicPlaying.Location = new System.Drawing.Point(251, 0);
            this.lblMusicPlaying.Name = "lblMusicPlaying";
            this.lblMusicPlaying.Size = new System.Drawing.Size(687, 47);
            this.lblMusicPlaying.TabIndex = 8;
            this.lblMusicPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 718);
            this.Controls.Add(this.tlpInferior);
            this.Controls.Add(this.tlpGeral);
            this.Controls.Add(this.tlpSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpSuperior.ResumeLayout(false);
            this.tlpSuperior.PerformLayout();
            this.tlpGeral.ResumeLayout(false);
            this.tlpGeral.PerformLayout();
            this.tlpInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGifNotasMusicais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_LadoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_LadoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Jeroguix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tlpSuperior;
        public System.Windows.Forms.Label JUKEBOX;
        private System.Windows.Forms.TableLayoutPanel tlpGeral;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.PictureBox PicBox_LadoB;
        private System.Windows.Forms.PictureBox PicBox_LadoA;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer tmr_Geral;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TableLayoutPanel tlpInferior;
        private System.Windows.Forms.Label lblQtdeMusicas;
        private System.Windows.Forms.Label lblTocandoAgora;
        private System.Windows.Forms.PictureBox picBox_Jeroguix;
        private System.Windows.Forms.PictureBox pcbGifNotasMusicais;
        private System.Windows.Forms.Label lblMusicPlaying;
    }
}

