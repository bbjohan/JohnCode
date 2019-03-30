namespace JohnCode
{
    partial class JohnCode
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JohnCode));
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblrighe = new System.Windows.Forms.ToolStripStatusLabel();
            this.nrighe = new System.Windows.Forms.ToolStripStatusLabel();
            this.ApriFile = new System.Windows.Forms.OpenFileDialog();
            this.SalvaFile = new System.Windows.Forms.SaveFileDialog();
            this.files = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovo = new System.Windows.Forms.ToolStripMenuItem();
            this.apri = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaConNome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.esci = new System.Windows.Forms.ToolStripMenuItem();
            this.avviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.AreaTesto = new System.Windows.Forms.RichTextBox();
            this.AHL = new System.Windows.Forms.Label();
            this.ALL = new System.Windows.Forms.Label();
            this.AHB = new System.Windows.Forms.TextBox();
            this.ALB = new System.Windows.Forms.TextBox();
            this.BLB = new System.Windows.Forms.TextBox();
            this.BHB = new System.Windows.Forms.TextBox();
            this.BLL = new System.Windows.Forms.Label();
            this.BHL = new System.Windows.Forms.Label();
            this.CLB = new System.Windows.Forms.TextBox();
            this.CHB = new System.Windows.Forms.TextBox();
            this.CLL = new System.Windows.Forms.Label();
            this.CHL = new System.Windows.Forms.Label();
            this.DLB = new System.Windows.Forms.TextBox();
            this.DHB = new System.Windows.Forms.TextBox();
            this.DLL = new System.Windows.Forms.Label();
            this.DHL = new System.Windows.Forms.Label();
            this.CSL = new System.Windows.Forms.Label();
            this.IPL = new System.Windows.Forms.Label();
            this.SSL = new System.Windows.Forms.Label();
            this.SIL = new System.Windows.Forms.Label();
            this.BPL = new System.Windows.Forms.Label();
            this.SPL = new System.Windows.Forms.Label();
            this.ESL = new System.Windows.Forms.Label();
            this.DSL = new System.Windows.Forms.Label();
            this.DIL = new System.Windows.Forms.Label();
            this.CSB = new System.Windows.Forms.TextBox();
            this.IPB = new System.Windows.Forms.TextBox();
            this.SSB = new System.Windows.Forms.TextBox();
            this.SPB = new System.Windows.Forms.TextBox();
            this.BPB = new System.Windows.Forms.TextBox();
            this.SIB = new System.Windows.Forms.TextBox();
            this.DIB = new System.Windows.Forms.TextBox();
            this.DSB = new System.Windows.Forms.TextBox();
            this.ESB = new System.Windows.Forms.TextBox();
            this.stepbystep = new System.Windows.Forms.CheckBox();
            this.avanti = new System.Windows.Forms.Button();
            this.Indirizzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StackView = new System.Windows.Forms.ListView();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Window;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblrighe,
            this.nrighe});
            this.status.Location = new System.Drawing.Point(0, 518);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(845, 22);
            this.status.TabIndex = 1;
            this.status.Text = "status";
            // 
            // lblrighe
            // 
            this.lblrighe.Name = "lblrighe";
            this.lblrighe.Size = new System.Drawing.Size(97, 17);
            this.lblrighe.Text = "Numero di righe:";
            // 
            // nrighe
            // 
            this.nrighe.Name = "nrighe";
            this.nrighe.Size = new System.Drawing.Size(13, 17);
            this.nrighe.Text = "0";
            // 
            // ApriFile
            // 
            this.ApriFile.DefaultExt = "File John|*.john";
            this.ApriFile.Filter = "File John|*.john";
            // 
            // SalvaFile
            // 
            this.SalvaFile.DefaultExt = "File John|*.john";
            this.SalvaFile.Filter = "File John|*.john";
            // 
            // files
            // 
            this.files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovo,
            this.apri,
            this.salvaConNome,
            this.toolStripSeparator1,
            this.esci});
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(37, 20);
            this.files.Text = "File";
            // 
            // nuovo
            // 
            this.nuovo.Name = "nuovo";
            this.nuovo.Size = new System.Drawing.Size(167, 22);
            this.nuovo.Text = "Nuovo";
            this.nuovo.Click += new System.EventHandler(this.nuovo_Click);
            // 
            // apri
            // 
            this.apri.Name = "apri";
            this.apri.Size = new System.Drawing.Size(167, 22);
            this.apri.Text = "Apri";
            this.apri.Click += new System.EventHandler(this.apri_Click);
            // 
            // salvaConNome
            // 
            this.salvaConNome.Name = "salvaConNome";
            this.salvaConNome.Size = new System.Drawing.Size(167, 22);
            this.salvaConNome.Text = "Salva con nome...";
            this.salvaConNome.Click += new System.EventHandler(this.salvaConNome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // esci
            // 
            this.esci.Name = "esci";
            this.esci.Size = new System.Drawing.Size(167, 22);
            this.esci.Text = "Esci";
            this.esci.Click += new System.EventHandler(this.esci_Click);
            // 
            // avviaToolStripMenuItem
            // 
            this.avviaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Debug});
            this.avviaToolStripMenuItem.Name = "avviaToolStripMenuItem";
            this.avviaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.avviaToolStripMenuItem.Text = "Avvia";
            // 
            // Debug
            // 
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(109, 22);
            this.Debug.Text = "Debug";
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.informazioniToolStripMenuItem.Text = "Informazioni";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Window;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.files,
            this.avviaToolStripMenuItem,
            this.informazioniToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(845, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // AreaTesto
            // 
            this.AreaTesto.Location = new System.Drawing.Point(12, 27);
            this.AreaTesto.Name = "AreaTesto";
            this.AreaTesto.Size = new System.Drawing.Size(463, 487);
            this.AreaTesto.TabIndex = 2;
            this.AreaTesto.Text = "";
            this.AreaTesto.TextChanged += new System.EventHandler(this.AreaTesto_TextChanged);
            // 
            // AHL
            // 
            this.AHL.Location = new System.Drawing.Point(481, 31);
            this.AHL.Name = "AHL";
            this.AHL.Size = new System.Drawing.Size(47, 20);
            this.AHL.TabIndex = 3;
            this.AHL.Text = "AH";
            this.AHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ALL
            // 
            this.ALL.Location = new System.Drawing.Point(674, 31);
            this.ALL.Name = "ALL";
            this.ALL.Size = new System.Drawing.Size(47, 20);
            this.ALL.TabIndex = 4;
            this.ALL.Text = "AL";
            this.ALL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AHB
            // 
            this.AHB.Enabled = false;
            this.AHB.Location = new System.Drawing.Point(534, 31);
            this.AHB.Name = "AHB";
            this.AHB.Size = new System.Drawing.Size(61, 20);
            this.AHB.TabIndex = 5;
            this.AHB.Text = "0";
            // 
            // ALB
            // 
            this.ALB.Enabled = false;
            this.ALB.Location = new System.Drawing.Point(607, 31);
            this.ALB.Name = "ALB";
            this.ALB.Size = new System.Drawing.Size(61, 20);
            this.ALB.TabIndex = 6;
            this.ALB.Text = "0";
            // 
            // BLB
            // 
            this.BLB.Enabled = false;
            this.BLB.Location = new System.Drawing.Point(607, 57);
            this.BLB.Name = "BLB";
            this.BLB.Size = new System.Drawing.Size(61, 20);
            this.BLB.TabIndex = 10;
            this.BLB.Text = "0";
            // 
            // BHB
            // 
            this.BHB.Enabled = false;
            this.BHB.Location = new System.Drawing.Point(534, 57);
            this.BHB.Name = "BHB";
            this.BHB.Size = new System.Drawing.Size(61, 20);
            this.BHB.TabIndex = 9;
            this.BHB.Text = "0";
            // 
            // BLL
            // 
            this.BLL.Location = new System.Drawing.Point(674, 57);
            this.BLL.Name = "BLL";
            this.BLL.Size = new System.Drawing.Size(47, 20);
            this.BLL.TabIndex = 8;
            this.BLL.Text = "BL";
            this.BLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BHL
            // 
            this.BHL.Location = new System.Drawing.Point(481, 57);
            this.BHL.Name = "BHL";
            this.BHL.Size = new System.Drawing.Size(47, 20);
            this.BHL.TabIndex = 7;
            this.BHL.Text = "BH";
            this.BHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLB
            // 
            this.CLB.Enabled = false;
            this.CLB.Location = new System.Drawing.Point(607, 83);
            this.CLB.Name = "CLB";
            this.CLB.Size = new System.Drawing.Size(61, 20);
            this.CLB.TabIndex = 14;
            this.CLB.Text = "0";
            // 
            // CHB
            // 
            this.CHB.Enabled = false;
            this.CHB.Location = new System.Drawing.Point(534, 83);
            this.CHB.Name = "CHB";
            this.CHB.Size = new System.Drawing.Size(61, 20);
            this.CHB.TabIndex = 13;
            this.CHB.Text = "0";
            // 
            // CLL
            // 
            this.CLL.Location = new System.Drawing.Point(674, 83);
            this.CLL.Name = "CLL";
            this.CLL.Size = new System.Drawing.Size(47, 20);
            this.CLL.TabIndex = 12;
            this.CLL.Text = "CL";
            this.CLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHL
            // 
            this.CHL.Location = new System.Drawing.Point(481, 83);
            this.CHL.Name = "CHL";
            this.CHL.Size = new System.Drawing.Size(47, 20);
            this.CHL.TabIndex = 11;
            this.CHL.Text = "CH";
            this.CHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DLB
            // 
            this.DLB.Enabled = false;
            this.DLB.Location = new System.Drawing.Point(607, 109);
            this.DLB.Name = "DLB";
            this.DLB.Size = new System.Drawing.Size(61, 20);
            this.DLB.TabIndex = 18;
            this.DLB.Text = "0";
            // 
            // DHB
            // 
            this.DHB.Enabled = false;
            this.DHB.Location = new System.Drawing.Point(534, 109);
            this.DHB.Name = "DHB";
            this.DHB.Size = new System.Drawing.Size(61, 20);
            this.DHB.TabIndex = 17;
            this.DHB.Text = "0";
            // 
            // DLL
            // 
            this.DLL.Location = new System.Drawing.Point(674, 109);
            this.DLL.Name = "DLL";
            this.DLL.Size = new System.Drawing.Size(47, 20);
            this.DLL.TabIndex = 16;
            this.DLL.Text = "DL";
            this.DLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DHL
            // 
            this.DHL.Location = new System.Drawing.Point(481, 109);
            this.DHL.Name = "DHL";
            this.DHL.Size = new System.Drawing.Size(47, 20);
            this.DHL.TabIndex = 15;
            this.DHL.Text = "DH";
            this.DHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CSL
            // 
            this.CSL.Location = new System.Drawing.Point(480, 163);
            this.CSL.Name = "CSL";
            this.CSL.Size = new System.Drawing.Size(47, 20);
            this.CSL.TabIndex = 19;
            this.CSL.Text = "CS";
            this.CSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPL
            // 
            this.IPL.Location = new System.Drawing.Point(480, 190);
            this.IPL.Name = "IPL";
            this.IPL.Size = new System.Drawing.Size(47, 20);
            this.IPL.TabIndex = 20;
            this.IPL.Text = "IP";
            this.IPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSL
            // 
            this.SSL.Location = new System.Drawing.Point(480, 216);
            this.SSL.Name = "SSL";
            this.SSL.Size = new System.Drawing.Size(47, 20);
            this.SSL.TabIndex = 21;
            this.SSL.Text = "SS";
            this.SSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SIL
            // 
            this.SIL.Location = new System.Drawing.Point(480, 294);
            this.SIL.Name = "SIL";
            this.SIL.Size = new System.Drawing.Size(47, 20);
            this.SIL.TabIndex = 24;
            this.SIL.Text = "SI";
            this.SIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BPL
            // 
            this.BPL.Location = new System.Drawing.Point(480, 268);
            this.BPL.Name = "BPL";
            this.BPL.Size = new System.Drawing.Size(47, 20);
            this.BPL.TabIndex = 23;
            this.BPL.Text = "BP";
            this.BPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPL
            // 
            this.SPL.Location = new System.Drawing.Point(480, 242);
            this.SPL.Name = "SPL";
            this.SPL.Size = new System.Drawing.Size(47, 20);
            this.SPL.TabIndex = 22;
            this.SPL.Text = "SP";
            this.SPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ESL
            // 
            this.ESL.Location = new System.Drawing.Point(481, 372);
            this.ESL.Name = "ESL";
            this.ESL.Size = new System.Drawing.Size(47, 20);
            this.ESL.TabIndex = 27;
            this.ESL.Text = "ES";
            this.ESL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DSL
            // 
            this.DSL.Location = new System.Drawing.Point(481, 346);
            this.DSL.Name = "DSL";
            this.DSL.Size = new System.Drawing.Size(47, 20);
            this.DSL.TabIndex = 26;
            this.DSL.Text = "DS";
            this.DSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DIL
            // 
            this.DIL.Location = new System.Drawing.Point(480, 320);
            this.DIL.Name = "DIL";
            this.DIL.Size = new System.Drawing.Size(47, 20);
            this.DIL.TabIndex = 25;
            this.DIL.Text = "DI";
            this.DIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CSB
            // 
            this.CSB.Enabled = false;
            this.CSB.Location = new System.Drawing.Point(534, 164);
            this.CSB.Name = "CSB";
            this.CSB.Size = new System.Drawing.Size(134, 20);
            this.CSB.TabIndex = 28;
            this.CSB.Text = "0";
            // 
            // IPB
            // 
            this.IPB.Enabled = false;
            this.IPB.Location = new System.Drawing.Point(534, 190);
            this.IPB.Name = "IPB";
            this.IPB.Size = new System.Drawing.Size(134, 20);
            this.IPB.TabIndex = 29;
            this.IPB.Text = "0";
            // 
            // SSB
            // 
            this.SSB.Enabled = false;
            this.SSB.Location = new System.Drawing.Point(534, 216);
            this.SSB.Name = "SSB";
            this.SSB.Size = new System.Drawing.Size(134, 20);
            this.SSB.TabIndex = 30;
            this.SSB.Text = "0";
            // 
            // SPB
            // 
            this.SPB.Enabled = false;
            this.SPB.Location = new System.Drawing.Point(534, 242);
            this.SPB.Name = "SPB";
            this.SPB.Size = new System.Drawing.Size(134, 20);
            this.SPB.TabIndex = 31;
            this.SPB.Text = "0";
            // 
            // BPB
            // 
            this.BPB.Enabled = false;
            this.BPB.Location = new System.Drawing.Point(534, 268);
            this.BPB.Name = "BPB";
            this.BPB.Size = new System.Drawing.Size(134, 20);
            this.BPB.TabIndex = 32;
            this.BPB.Text = "0";
            // 
            // SIB
            // 
            this.SIB.Enabled = false;
            this.SIB.Location = new System.Drawing.Point(534, 295);
            this.SIB.Name = "SIB";
            this.SIB.Size = new System.Drawing.Size(134, 20);
            this.SIB.TabIndex = 33;
            this.SIB.Text = "0";
            // 
            // DIB
            // 
            this.DIB.Enabled = false;
            this.DIB.Location = new System.Drawing.Point(534, 320);
            this.DIB.Name = "DIB";
            this.DIB.Size = new System.Drawing.Size(134, 20);
            this.DIB.TabIndex = 34;
            this.DIB.Text = "0";
            // 
            // DSB
            // 
            this.DSB.Enabled = false;
            this.DSB.Location = new System.Drawing.Point(534, 346);
            this.DSB.Name = "DSB";
            this.DSB.Size = new System.Drawing.Size(134, 20);
            this.DSB.TabIndex = 35;
            this.DSB.Text = "0";
            // 
            // ESB
            // 
            this.ESB.Enabled = false;
            this.ESB.Location = new System.Drawing.Point(534, 372);
            this.ESB.Name = "ESB";
            this.ESB.Size = new System.Drawing.Size(134, 20);
            this.ESB.TabIndex = 36;
            this.ESB.TabStop = false;
            this.ESB.Text = "0";
            // 
            // stepbystep
            // 
            this.stepbystep.Enabled = false;
            this.stepbystep.Location = new System.Drawing.Point(484, 498);
            this.stepbystep.Name = "stepbystep";
            this.stepbystep.Size = new System.Drawing.Size(104, 24);
            this.stepbystep.TabIndex = 37;
            this.stepbystep.Text = "StepByStep";
            this.stepbystep.UseVisualStyleBackColor = true;
            this.stepbystep.CheckedChanged += new System.EventHandler(this.stepbystep_CheckedChanged);
            // 
            // avanti
            // 
            this.avanti.Location = new System.Drawing.Point(594, 498);
            this.avanti.Name = "avanti";
            this.avanti.Size = new System.Drawing.Size(75, 24);
            this.avanti.TabIndex = 38;
            this.avanti.Text = "Avanti";
            this.avanti.UseVisualStyleBackColor = true;
            this.avanti.Click += new System.EventHandler(this.avanti_Click);
            // 
            // Indirizzo
            // 
            this.Indirizzo.Text = "Indirizzo";
            // 
            // Valore
            // 
            this.Valore.Text = "Valore";
            this.Valore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StackView
            // 
            this.StackView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indirizzo,
            this.Valore});
            this.StackView.Location = new System.Drawing.Point(715, 31);
            this.StackView.MultiSelect = false;
            this.StackView.Name = "StackView";
            this.StackView.Size = new System.Drawing.Size(118, 491);
            this.StackView.TabIndex = 39;
            this.StackView.UseCompatibleStateImageBehavior = false;
            this.StackView.View = System.Windows.Forms.View.Tile;
            // 
            // JohnCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 540);
            this.Controls.Add(this.StackView);
            this.Controls.Add(this.avanti);
            this.Controls.Add(this.stepbystep);
            this.Controls.Add(this.ESB);
            this.Controls.Add(this.DSB);
            this.Controls.Add(this.DIB);
            this.Controls.Add(this.SIB);
            this.Controls.Add(this.BPB);
            this.Controls.Add(this.SPB);
            this.Controls.Add(this.SSB);
            this.Controls.Add(this.IPB);
            this.Controls.Add(this.CSB);
            this.Controls.Add(this.ESL);
            this.Controls.Add(this.DSL);
            this.Controls.Add(this.DIL);
            this.Controls.Add(this.SIL);
            this.Controls.Add(this.BPL);
            this.Controls.Add(this.SPL);
            this.Controls.Add(this.SSL);
            this.Controls.Add(this.IPL);
            this.Controls.Add(this.CSL);
            this.Controls.Add(this.DLB);
            this.Controls.Add(this.DHB);
            this.Controls.Add(this.DLL);
            this.Controls.Add(this.DHL);
            this.Controls.Add(this.CLB);
            this.Controls.Add(this.CHB);
            this.Controls.Add(this.CLL);
            this.Controls.Add(this.CHL);
            this.Controls.Add(this.BLB);
            this.Controls.Add(this.BHB);
            this.Controls.Add(this.BLL);
            this.Controls.Add(this.BHL);
            this.Controls.Add(this.ALB);
            this.Controls.Add(this.AHB);
            this.Controls.Add(this.ALL);
            this.Controls.Add(this.AHL);
            this.Controls.Add(this.AreaTesto);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "JohnCode";
            this.Text = "JohnCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblrighe;
        private System.Windows.Forms.ToolStripStatusLabel nrighe;
        private System.Windows.Forms.OpenFileDialog ApriFile;
        private System.Windows.Forms.SaveFileDialog SalvaFile;
        private System.Windows.Forms.ToolStripMenuItem files;
        private System.Windows.Forms.ToolStripMenuItem nuovo;
        private System.Windows.Forms.ToolStripMenuItem apri;
        private System.Windows.Forms.ToolStripMenuItem salvaConNome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem esci;
        private System.Windows.Forms.ToolStripMenuItem avviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.RichTextBox AreaTesto;
        private System.Windows.Forms.Label AHL;
        private System.Windows.Forms.Label ALL;
        private System.Windows.Forms.TextBox AHB;
        private System.Windows.Forms.TextBox ALB;
        private System.Windows.Forms.TextBox BLB;
        private System.Windows.Forms.TextBox BHB;
        private System.Windows.Forms.Label BLL;
        private System.Windows.Forms.Label BHL;
        private System.Windows.Forms.TextBox CLB;
        private System.Windows.Forms.TextBox CHB;
        private System.Windows.Forms.Label CLL;
        private System.Windows.Forms.Label CHL;
        private System.Windows.Forms.TextBox DLB;
        private System.Windows.Forms.TextBox DHB;
        private System.Windows.Forms.Label DLL;
        private System.Windows.Forms.Label DHL;
        private System.Windows.Forms.Label CSL;
        private System.Windows.Forms.Label IPL;
        private System.Windows.Forms.Label SSL;
        private System.Windows.Forms.Label SIL;
        private System.Windows.Forms.Label BPL;
        private System.Windows.Forms.Label SPL;
        private System.Windows.Forms.Label ESL;
        private System.Windows.Forms.Label DSL;
        private System.Windows.Forms.Label DIL;
        private System.Windows.Forms.TextBox CSB;
        private System.Windows.Forms.TextBox IPB;
        private System.Windows.Forms.TextBox SSB;
        private System.Windows.Forms.TextBox SPB;
        private System.Windows.Forms.TextBox BPB;
        private System.Windows.Forms.TextBox SIB;
        private System.Windows.Forms.TextBox DIB;
        private System.Windows.Forms.TextBox DSB;
        private System.Windows.Forms.TextBox ESB;
        private System.Windows.Forms.CheckBox stepbystep;
        private System.Windows.Forms.Button avanti;
        private System.Windows.Forms.ColumnHeader Indirizzo;
        private System.Windows.Forms.ColumnHeader Valore;
        private System.Windows.Forms.ListView StackView;
    }
}

