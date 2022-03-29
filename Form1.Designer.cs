
namespace Proyecto_de_Cátedra_PED
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.indicator = new Bunifu.UI.WinForms.BunifuShapes();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAulas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDocentes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAlumnos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMaterias = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlAbrirForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAbrirForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.pnlHeader.Controls.Add(this.bunifuPictureBox1);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.bunifuImageButton1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(732, 99);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 38;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(54, 11);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(77, 77);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universidad Don Bosco";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(31, 31);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(51, 51);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(669, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(51, 51);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 90F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.bunifuShapes2.BorderThickness = 2;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(119, 48);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(77, 219);
            this.bunifuShapes2.TabIndex = 6;
            this.bunifuShapes2.Text = "bunifuShapes2";
            // 
            // indicator
            // 
            this.indicator.Angle = 0F;
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(229)))));
            this.indicator.BorderThickness = 3;
            this.indicator.FillColor = System.Drawing.Color.Transparent;
            this.indicator.FillShape = true;
            this.indicator.Location = new System.Drawing.Point(148, 48);
            this.indicator.Name = "indicator";
            this.indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.indicator.Sides = 5;
            this.indicator.Size = new System.Drawing.Size(18, 18);
            this.indicator.TabIndex = 5;
            this.indicator.Text = "bunifuShapes1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAlumnos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnNotas);
            this.panel1.Controls.Add(this.btnAulas);
            this.panel1.Controls.Add(this.btnDocentes);
            this.panel1.Controls.Add(this.btnMaterias);
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.bunifuShapes2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 384);
            this.panel1.TabIndex = 7;
            // 
            // btnNotas
            // 
            this.btnNotas.AllowAnimations = true;
            this.btnNotas.AllowMouseEffects = true;
            this.btnNotas.AllowToggling = false;
            this.btnNotas.AnimationSpeed = 200;
            this.btnNotas.AutoGenerateColors = false;
            this.btnNotas.AutoRoundBorders = false;
            this.btnNotas.AutoSizeLeftIcon = true;
            this.btnNotas.AutoSizeRightIcon = true;
            this.btnNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnNotas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotas.BackgroundImage")));
            this.btnNotas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotas.ButtonText = "Notas";
            this.btnNotas.ButtonTextMarginLeft = 0;
            this.btnNotas.ColorContrastOnClick = 45;
            this.btnNotas.ColorContrastOnHover = 45;
            this.btnNotas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.btnNotas.CustomizableEdges = borderEdges16;
            this.btnNotas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNotas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNotas.IconMarginLeft = 11;
            this.btnNotas.IconPadding = 10;
            this.btnNotas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNotas.IconSize = 25;
            this.btnNotas.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotas.IdleBorderRadius = 1;
            this.btnNotas.IdleBorderThickness = 1;
            this.btnNotas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotas.IdleIconLeftImage = null;
            this.btnNotas.IdleIconRightImage = null;
            this.btnNotas.IndicateFocus = false;
            this.btnNotas.Location = new System.Drawing.Point(19, 244);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotas.OnDisabledState.BorderRadius = 1;
            this.btnNotas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotas.OnDisabledState.BorderThickness = 1;
            this.btnNotas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotas.OnDisabledState.IconLeftImage = null;
            this.btnNotas.OnDisabledState.IconRightImage = null;
            this.btnNotas.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnNotas.onHoverState.BorderRadius = 1;
            this.btnNotas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotas.onHoverState.BorderThickness = 1;
            this.btnNotas.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnNotas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNotas.onHoverState.IconLeftImage = null;
            this.btnNotas.onHoverState.IconRightImage = null;
            this.btnNotas.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotas.OnIdleState.BorderRadius = 1;
            this.btnNotas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotas.OnIdleState.BorderThickness = 1;
            this.btnNotas.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNotas.OnIdleState.IconLeftImage = null;
            this.btnNotas.OnIdleState.IconRightImage = null;
            this.btnNotas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNotas.OnPressedState.BorderRadius = 1;
            this.btnNotas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotas.OnPressedState.BorderThickness = 1;
            this.btnNotas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNotas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNotas.OnPressedState.IconLeftImage = null;
            this.btnNotas.OnPressedState.IconRightImage = null;
            this.btnNotas.Size = new System.Drawing.Size(112, 41);
            this.btnNotas.TabIndex = 11;
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotas.TextMarginLeft = 0;
            this.btnNotas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNotas.UseDefaultRadiusAndThickness = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.AllowAnimations = true;
            this.btnAulas.AllowMouseEffects = true;
            this.btnAulas.AllowToggling = false;
            this.btnAulas.AnimationSpeed = 200;
            this.btnAulas.AutoGenerateColors = false;
            this.btnAulas.AutoRoundBorders = false;
            this.btnAulas.AutoSizeLeftIcon = true;
            this.btnAulas.AutoSizeRightIcon = true;
            this.btnAulas.BackColor = System.Drawing.Color.Transparent;
            this.btnAulas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAulas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAulas.BackgroundImage")));
            this.btnAulas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAulas.ButtonText = "Aulas";
            this.btnAulas.ButtonTextMarginLeft = 0;
            this.btnAulas.ColorContrastOnClick = 45;
            this.btnAulas.ColorContrastOnHover = 45;
            this.btnAulas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges17.BottomLeft = true;
            borderEdges17.BottomRight = true;
            borderEdges17.TopLeft = true;
            borderEdges17.TopRight = true;
            this.btnAulas.CustomizableEdges = borderEdges17;
            this.btnAulas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAulas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAulas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAulas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAulas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAulas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAulas.ForeColor = System.Drawing.Color.White;
            this.btnAulas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAulas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAulas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAulas.IconMarginLeft = 11;
            this.btnAulas.IconPadding = 10;
            this.btnAulas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAulas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAulas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAulas.IconSize = 25;
            this.btnAulas.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAulas.IdleBorderRadius = 1;
            this.btnAulas.IdleBorderThickness = 1;
            this.btnAulas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAulas.IdleIconLeftImage = null;
            this.btnAulas.IdleIconRightImage = null;
            this.btnAulas.IndicateFocus = false;
            this.btnAulas.Location = new System.Drawing.Point(19, 190);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAulas.OnDisabledState.BorderRadius = 1;
            this.btnAulas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAulas.OnDisabledState.BorderThickness = 1;
            this.btnAulas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAulas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAulas.OnDisabledState.IconLeftImage = null;
            this.btnAulas.OnDisabledState.IconRightImage = null;
            this.btnAulas.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAulas.onHoverState.BorderRadius = 1;
            this.btnAulas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAulas.onHoverState.BorderThickness = 1;
            this.btnAulas.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnAulas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAulas.onHoverState.IconLeftImage = null;
            this.btnAulas.onHoverState.IconRightImage = null;
            this.btnAulas.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAulas.OnIdleState.BorderRadius = 1;
            this.btnAulas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAulas.OnIdleState.BorderThickness = 1;
            this.btnAulas.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAulas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAulas.OnIdleState.IconLeftImage = null;
            this.btnAulas.OnIdleState.IconRightImage = null;
            this.btnAulas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAulas.OnPressedState.BorderRadius = 1;
            this.btnAulas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAulas.OnPressedState.BorderThickness = 1;
            this.btnAulas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAulas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAulas.OnPressedState.IconLeftImage = null;
            this.btnAulas.OnPressedState.IconRightImage = null;
            this.btnAulas.Size = new System.Drawing.Size(112, 41);
            this.btnAulas.TabIndex = 10;
            this.btnAulas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAulas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAulas.TextMarginLeft = 0;
            this.btnAulas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAulas.UseDefaultRadiusAndThickness = true;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.AllowAnimations = true;
            this.btnDocentes.AllowMouseEffects = true;
            this.btnDocentes.AllowToggling = false;
            this.btnDocentes.AnimationSpeed = 200;
            this.btnDocentes.AutoGenerateColors = false;
            this.btnDocentes.AutoRoundBorders = false;
            this.btnDocentes.AutoSizeLeftIcon = true;
            this.btnDocentes.AutoSizeRightIcon = true;
            this.btnDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnDocentes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocentes.BackgroundImage")));
            this.btnDocentes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocentes.ButtonText = "Docentes";
            this.btnDocentes.ButtonTextMarginLeft = 0;
            this.btnDocentes.ColorContrastOnClick = 45;
            this.btnDocentes.ColorContrastOnHover = 45;
            this.btnDocentes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.btnDocentes.CustomizableEdges = borderEdges18;
            this.btnDocentes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDocentes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDocentes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDocentes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDocentes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDocentes.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDocentes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDocentes.IconMarginLeft = 11;
            this.btnDocentes.IconPadding = 10;
            this.btnDocentes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocentes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDocentes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDocentes.IconSize = 25;
            this.btnDocentes.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocentes.IdleBorderRadius = 1;
            this.btnDocentes.IdleBorderThickness = 1;
            this.btnDocentes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocentes.IdleIconLeftImage = null;
            this.btnDocentes.IdleIconRightImage = null;
            this.btnDocentes.IndicateFocus = false;
            this.btnDocentes.Location = new System.Drawing.Point(19, 138);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDocentes.OnDisabledState.BorderRadius = 1;
            this.btnDocentes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocentes.OnDisabledState.BorderThickness = 1;
            this.btnDocentes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDocentes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDocentes.OnDisabledState.IconLeftImage = null;
            this.btnDocentes.OnDisabledState.IconRightImage = null;
            this.btnDocentes.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDocentes.onHoverState.BorderRadius = 1;
            this.btnDocentes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocentes.onHoverState.BorderThickness = 1;
            this.btnDocentes.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnDocentes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.onHoverState.IconLeftImage = null;
            this.btnDocentes.onHoverState.IconRightImage = null;
            this.btnDocentes.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocentes.OnIdleState.BorderRadius = 1;
            this.btnDocentes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocentes.OnIdleState.BorderThickness = 1;
            this.btnDocentes.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocentes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.OnIdleState.IconLeftImage = null;
            this.btnDocentes.OnIdleState.IconRightImage = null;
            this.btnDocentes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDocentes.OnPressedState.BorderRadius = 1;
            this.btnDocentes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocentes.OnPressedState.BorderThickness = 1;
            this.btnDocentes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDocentes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.OnPressedState.IconLeftImage = null;
            this.btnDocentes.OnPressedState.IconRightImage = null;
            this.btnDocentes.Size = new System.Drawing.Size(112, 41);
            this.btnDocentes.TabIndex = 9;
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocentes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDocentes.TextMarginLeft = 0;
            this.btnDocentes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDocentes.UseDefaultRadiusAndThickness = true;
            this.btnDocentes.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.AllowAnimations = true;
            this.btnAlumnos.AllowMouseEffects = true;
            this.btnAlumnos.AllowToggling = false;
            this.btnAlumnos.AnimationSpeed = 200;
            this.btnAlumnos.AutoGenerateColors = false;
            this.btnAlumnos.AutoRoundBorders = false;
            this.btnAlumnos.AutoSizeLeftIcon = true;
            this.btnAlumnos.AutoSizeRightIcon = true;
            this.btnAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnAlumnos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlumnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.BackgroundImage")));
            this.btnAlumnos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlumnos.ButtonText = "Alumnos";
            this.btnAlumnos.ButtonTextMarginLeft = 0;
            this.btnAlumnos.ColorContrastOnClick = 45;
            this.btnAlumnos.ColorContrastOnHover = 45;
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges19.BottomLeft = true;
            borderEdges19.BottomRight = true;
            borderEdges19.TopLeft = true;
            borderEdges19.TopRight = true;
            this.btnAlumnos.CustomizableEdges = borderEdges19;
            this.btnAlumnos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAlumnos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlumnos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlumnos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlumnos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAlumnos.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAlumnos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAlumnos.IconMarginLeft = 11;
            this.btnAlumnos.IconPadding = 10;
            this.btnAlumnos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlumnos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAlumnos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAlumnos.IconSize = 25;
            this.btnAlumnos.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlumnos.IdleBorderRadius = 1;
            this.btnAlumnos.IdleBorderThickness = 1;
            this.btnAlumnos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlumnos.IdleIconLeftImage = null;
            this.btnAlumnos.IdleIconRightImage = null;
            this.btnAlumnos.IndicateFocus = false;
            this.btnAlumnos.Location = new System.Drawing.Point(19, 44);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlumnos.OnDisabledState.BorderRadius = 1;
            this.btnAlumnos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlumnos.OnDisabledState.BorderThickness = 1;
            this.btnAlumnos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlumnos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlumnos.OnDisabledState.IconLeftImage = null;
            this.btnAlumnos.OnDisabledState.IconRightImage = null;
            this.btnAlumnos.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnAlumnos.onHoverState.BorderRadius = 1;
            this.btnAlumnos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlumnos.onHoverState.BorderThickness = 1;
            this.btnAlumnos.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnAlumnos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.onHoverState.IconLeftImage = null;
            this.btnAlumnos.onHoverState.IconRightImage = null;
            this.btnAlumnos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlumnos.OnIdleState.BorderRadius = 1;
            this.btnAlumnos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlumnos.OnIdleState.BorderThickness = 1;
            this.btnAlumnos.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlumnos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.OnIdleState.IconLeftImage = null;
            this.btnAlumnos.OnIdleState.IconRightImage = null;
            this.btnAlumnos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAlumnos.OnPressedState.BorderRadius = 1;
            this.btnAlumnos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlumnos.OnPressedState.BorderThickness = 1;
            this.btnAlumnos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAlumnos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.OnPressedState.IconLeftImage = null;
            this.btnAlumnos.OnPressedState.IconRightImage = null;
            this.btnAlumnos.Size = new System.Drawing.Size(112, 41);
            this.btnAlumnos.TabIndex = 8;
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlumnos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlumnos.TextMarginLeft = 0;
            this.btnAlumnos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAlumnos.UseDefaultRadiusAndThickness = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.AllowAnimations = true;
            this.btnMaterias.AllowMouseEffects = true;
            this.btnMaterias.AllowToggling = false;
            this.btnMaterias.AnimationSpeed = 200;
            this.btnMaterias.AutoGenerateColors = false;
            this.btnMaterias.AutoRoundBorders = false;
            this.btnMaterias.AutoSizeLeftIcon = true;
            this.btnMaterias.AutoSizeRightIcon = true;
            this.btnMaterias.BackColor = System.Drawing.Color.Transparent;
            this.btnMaterias.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaterias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaterias.BackgroundImage")));
            this.btnMaterias.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaterias.ButtonText = "Materias";
            this.btnMaterias.ButtonTextMarginLeft = 0;
            this.btnMaterias.ColorContrastOnClick = 45;
            this.btnMaterias.ColorContrastOnHover = 45;
            this.btnMaterias.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges20.BottomLeft = true;
            borderEdges20.BottomRight = true;
            borderEdges20.TopLeft = true;
            borderEdges20.TopRight = true;
            this.btnMaterias.CustomizableEdges = borderEdges20;
            this.btnMaterias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaterias.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMaterias.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMaterias.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMaterias.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMaterias.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMaterias.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMaterias.IconMarginLeft = 11;
            this.btnMaterias.IconPadding = 10;
            this.btnMaterias.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaterias.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMaterias.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMaterias.IconSize = 25;
            this.btnMaterias.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaterias.IdleBorderRadius = 1;
            this.btnMaterias.IdleBorderThickness = 1;
            this.btnMaterias.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaterias.IdleIconLeftImage = null;
            this.btnMaterias.IdleIconRightImage = null;
            this.btnMaterias.IndicateFocus = false;
            this.btnMaterias.Location = new System.Drawing.Point(19, 91);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMaterias.OnDisabledState.BorderRadius = 1;
            this.btnMaterias.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaterias.OnDisabledState.BorderThickness = 1;
            this.btnMaterias.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMaterias.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMaterias.OnDisabledState.IconLeftImage = null;
            this.btnMaterias.OnDisabledState.IconRightImage = null;
            this.btnMaterias.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnMaterias.onHoverState.BorderRadius = 1;
            this.btnMaterias.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaterias.onHoverState.BorderThickness = 1;
            this.btnMaterias.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnMaterias.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.onHoverState.IconLeftImage = null;
            this.btnMaterias.onHoverState.IconRightImage = null;
            this.btnMaterias.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaterias.OnIdleState.BorderRadius = 1;
            this.btnMaterias.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaterias.OnIdleState.BorderThickness = 1;
            this.btnMaterias.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaterias.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.OnIdleState.IconLeftImage = null;
            this.btnMaterias.OnIdleState.IconRightImage = null;
            this.btnMaterias.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMaterias.OnPressedState.BorderRadius = 1;
            this.btnMaterias.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaterias.OnPressedState.BorderThickness = 1;
            this.btnMaterias.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMaterias.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMaterias.OnPressedState.IconLeftImage = null;
            this.btnMaterias.OnPressedState.IconRightImage = null;
            this.btnMaterias.Size = new System.Drawing.Size(112, 41);
            this.btnMaterias.TabIndex = 7;
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaterias.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMaterias.TextMarginLeft = 0;
            this.btnMaterias.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMaterias.UseDefaultRadiusAndThickness = true;
            this.btnMaterias.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // pnlAbrirForm
            // 
            this.pnlAbrirForm.Controls.Add(this.label2);
            this.pnlAbrirForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbrirForm.Location = new System.Drawing.Point(200, 99);
            this.pnlAbrirForm.Name = "pnlAbrirForm";
            this.pnlAbrirForm.Size = new System.Drawing.Size(532, 384);
            this.pnlAbrirForm.TabIndex = 8;
            this.pnlAbrirForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAbrirForm_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido al programa!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario Logeado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 483);
            this.Controls.Add(this.pnlAbrirForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAbrirForm.ResumeLayout(false);
            this.pnlAbrirForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNotas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAulas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDocentes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMaterias;
        private System.Windows.Forms.Panel pnlAbrirForm;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAlumnos;
    }
}

