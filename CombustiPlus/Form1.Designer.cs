namespace CombustiPlus;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        grpNuevo = new GroupBox();
        lblPlaca = new Label();
        txtPlaca = new TextBox();
        lblCombustible = new Label();
        cmbCombustible = new ComboBox();
        lblGalones = new Label();
        nudGalones = new NumericUpDown();
        lblPago = new Label();
        cmbPago = new ComboBox();
        btnCotizar = new Button();
        btnDespachar = new Button();
        grpDetalle = new GroupBox();
        lstDetalle = new ListBox();
        grpDespachos = new GroupBox();
        lstDespachos = new ListBox();
        btnPorCombustible = new Button();
        lblResumen = new Label();
        grpNuevo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
        grpDetalle.SuspendLayout();
        grpDespachos.SuspendLayout();
        SuspendLayout();
        //
        // grpNuevo
        //
        grpNuevo.Controls.Add(lblPlaca);
        grpNuevo.Controls.Add(txtPlaca);
        grpNuevo.Controls.Add(lblCombustible);
        grpNuevo.Controls.Add(cmbCombustible);
        grpNuevo.Controls.Add(lblGalones);
        grpNuevo.Controls.Add(nudGalones);
        grpNuevo.Controls.Add(lblPago);
        grpNuevo.Controls.Add(cmbPago);
        grpNuevo.Controls.Add(btnCotizar);
        grpNuevo.Controls.Add(btnDespachar);
        grpNuevo.Location = new Point(12, 12);
        grpNuevo.Name = "grpNuevo";
        grpNuevo.Size = new Size(360, 234);
        grpNuevo.TabIndex = 0;
        grpNuevo.TabStop = false;
        grpNuevo.Text = "Nuevo despacho";
        //
        // lblPlaca
        //
        lblPlaca.AutoSize = true;
        lblPlaca.Location = new Point(14, 36);
        lblPlaca.Name = "lblPlaca";
        lblPlaca.Size = new Size(43, 20);
        lblPlaca.TabIndex = 0;
        lblPlaca.Text = "Placa:";
        //
        // txtPlaca
        //
        txtPlaca.Location = new Point(110, 32);
        txtPlaca.Name = "txtPlaca";
        txtPlaca.Size = new Size(230, 27);
        txtPlaca.TabIndex = 1;
        //
        // lblCombustible
        //
        lblCombustible.AutoSize = true;
        lblCombustible.Location = new Point(14, 76);
        lblCombustible.Name = "lblCombustible";
        lblCombustible.Size = new Size(90, 20);
        lblCombustible.TabIndex = 2;
        lblCombustible.Text = "Combustible:";
        //
        // cmbCombustible
        //
        cmbCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCombustible.FormattingEnabled = true;
        cmbCombustible.Location = new Point(110, 72);
        cmbCombustible.Name = "cmbCombustible";
        cmbCombustible.Size = new Size(230, 28);
        cmbCombustible.TabIndex = 3;
        //
        // lblGalones
        //
        lblGalones.AutoSize = true;
        lblGalones.Location = new Point(14, 116);
        lblGalones.Name = "lblGalones";
        lblGalones.Size = new Size(64, 20);
        lblGalones.TabIndex = 4;
        lblGalones.Text = "Galones:";
        //
        // nudGalones
        //
        nudGalones.DecimalPlaces = 1;
        nudGalones.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
        nudGalones.Location = new Point(110, 112);
        nudGalones.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudGalones.Name = "nudGalones";
        nudGalones.Size = new Size(100, 27);
        nudGalones.TabIndex = 5;
        //
        // lblPago
        //
        lblPago.AutoSize = true;
        lblPago.Location = new Point(14, 156);
        lblPago.Name = "lblPago";
        lblPago.Size = new Size(42, 20);
        lblPago.TabIndex = 6;
        lblPago.Text = "Pago:";
        //
        // cmbPago
        //
        cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPago.FormattingEnabled = true;
        cmbPago.Location = new Point(110, 152);
        cmbPago.Name = "cmbPago";
        cmbPago.Size = new Size(230, 28);
        cmbPago.TabIndex = 7;
        //
        // btnCotizar
        //
        btnCotizar.Location = new Point(14, 192);
        btnCotizar.Name = "btnCotizar";
        btnCotizar.Size = new Size(160, 32);
        btnCotizar.TabIndex = 8;
        btnCotizar.Text = "Cotizar";
        btnCotizar.UseVisualStyleBackColor = true;
        btnCotizar.Click += btnCotizar_Click;
        //
        // btnDespachar
        //
        btnDespachar.Location = new Point(180, 192);
        btnDespachar.Name = "btnDespachar";
        btnDespachar.Size = new Size(160, 32);
        btnDespachar.TabIndex = 9;
        btnDespachar.Text = "Despachar";
        btnDespachar.UseVisualStyleBackColor = true;
        btnDespachar.Click += btnDespachar_Click;
        //
        // grpDetalle
        //
        grpDetalle.Controls.Add(lstDetalle);
        grpDetalle.Location = new Point(12, 254);
        grpDetalle.Name = "grpDetalle";
        grpDetalle.Size = new Size(360, 156);
        grpDetalle.TabIndex = 1;
        grpDetalle.TabStop = false;
        grpDetalle.Text = "Detalle";
        //
        // lstDetalle
        //
        lstDetalle.Font = new Font("Consolas", 10F);
        lstDetalle.FormattingEnabled = true;
        lstDetalle.ItemHeight = 16;
        lstDetalle.Location = new Point(12, 24);
        lstDetalle.Name = "lstDetalle";
        lstDetalle.Size = new Size(336, 116);
        lstDetalle.TabIndex = 0;
        //
        // grpDespachos
        //
        grpDespachos.Controls.Add(lstDespachos);
        grpDespachos.Controls.Add(btnPorCombustible);
        grpDespachos.Location = new Point(384, 12);
        grpDespachos.Name = "grpDespachos";
        grpDespachos.Size = new Size(644, 346);
        grpDespachos.TabIndex = 2;
        grpDespachos.TabStop = false;
        grpDespachos.Text = "Despachos del día";
        //
        // lstDespachos
        //
        lstDespachos.Font = new Font("Consolas", 10F);
        lstDespachos.FormattingEnabled = true;
        lstDespachos.ItemHeight = 16;
        lstDespachos.Location = new Point(12, 24);
        lstDespachos.Name = "lstDespachos";
        lstDespachos.Size = new Size(620, 260);
        lstDespachos.TabIndex = 0;
        //
        // btnPorCombustible
        //
        btnPorCombustible.Location = new Point(12, 296);
        btnPorCombustible.Name = "btnPorCombustible";
        btnPorCombustible.Size = new Size(200, 36);
        btnPorCombustible.TabIndex = 1;
        btnPorCombustible.Text = "Galones por combustible";
        btnPorCombustible.UseVisualStyleBackColor = true;
        btnPorCombustible.Click += btnPorCombustible_Click;
        //
        // lblResumen
        //
        lblResumen.Location = new Point(384, 366);
        lblResumen.Name = "lblResumen";
        lblResumen.Size = new Size(644, 44);
        lblResumen.TabIndex = 3;
        lblResumen.Text = "0 despachos";
        //
        // Form1
        //
        AcceptButton = btnDespachar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1040, 422);
        Controls.Add(grpNuevo);
        Controls.Add(grpDetalle);
        Controls.Add(grpDespachos);
        Controls.Add(lblResumen);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CombustiPlus — Estación Bávaro";
        grpNuevo.ResumeLayout(false);
        grpNuevo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
        grpDetalle.ResumeLayout(false);
        grpDespachos.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpNuevo;
    private Label lblPlaca;
    private TextBox txtPlaca;
    private Label lblCombustible;
    private ComboBox cmbCombustible;
    private Label lblGalones;
    private NumericUpDown nudGalones;
    private Label lblPago;
    private ComboBox cmbPago;
    private Button btnCotizar;
    private Button btnDespachar;
    private GroupBox grpDetalle;
    private ListBox lstDetalle;
    private GroupBox grpDespachos;
    private ListBox lstDespachos;
    private Button btnPorCombustible;
    private Label lblResumen;
}
