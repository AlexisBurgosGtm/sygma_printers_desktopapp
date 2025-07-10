<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gridEmbarques = New DevExpress.XtraGrid.GridControl()
        Me.TblEmbarquesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_General = New XELASOL_PRINTERS.DS_General()
        Me.GridViewEmbarques = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODEMBARQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODREPARTIDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMEMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.checkAgrupar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnRptTickets = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRptBoletas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRptDocumentos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRptProductos = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbEmbarque = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbEmpresas = New System.Windows.Forms.ComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbActivo = New System.Windows.Forms.ComboBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btnLimpiarEmbarques = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmbarquesAgrupados = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnRptProductosAgrupados = New DevExpress.XtraEditors.SimpleButton()
        Me.NavigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NP_MENU = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnInventarios = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEmbarques = New DevExpress.XtraEditors.SimpleButton()
        Me.NP_EMBARQUES = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.imgBtnAtrasEmbarques = New System.Windows.Forms.PictureBox()
        Me.NP_INVENTARIOS = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.btnExportarInventario = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimirInventario = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbSucursalInventarios = New System.Windows.Forms.ComboBox()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.gridInventarios = New DevExpress.XtraGrid.GridControl()
        Me.TblinventariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODPROD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESPROD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODMARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESMARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTALUNIDADES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTALCOSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUXC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCAJAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDADES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.imgBtnAtrasInventarios = New System.Windows.Forms.PictureBox()
        Me.TblinventariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmbarquesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_General, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAgrupar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.NavigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame.SuspendLayout()
        Me.NP_MENU.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NP_EMBARQUES.SuspendLayout()
        CType(Me.imgBtnAtrasEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NP_INVENTARIOS.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.gridInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblinventariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBtnAtrasInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblinventariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gridEmbarques)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 106)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(758, 573)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "LISTA GENERAL DE EMBARQUES"
        '
        'gridEmbarques
        '
        Me.gridEmbarques.DataSource = Me.TblEmbarquesBindingSource
        Me.gridEmbarques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEmbarques.Location = New System.Drawing.Point(2, 23)
        Me.gridEmbarques.MainView = Me.GridViewEmbarques
        Me.gridEmbarques.Name = "gridEmbarques"
        Me.gridEmbarques.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.checkAgrupar})
        Me.gridEmbarques.Size = New System.Drawing.Size(754, 548)
        Me.gridEmbarques.TabIndex = 0
        Me.gridEmbarques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewEmbarques})
        '
        'TblEmbarquesBindingSource
        '
        Me.TblEmbarquesBindingSource.DataMember = "tblEmbarques"
        Me.TblEmbarquesBindingSource.DataSource = Me.DS_General
        '
        'DS_General
        '
        Me.DS_General.DataSetName = "DS_General"
        Me.DS_General.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridViewEmbarques
        '
        Me.GridViewEmbarques.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewEmbarques.Appearance.Row.Options.UseBackColor = True
        Me.GridViewEmbarques.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODEMBARQUE, Me.colDESCRIPCION, Me.colCODREPARTIDOR, Me.colNOMEMPLEADO, Me.colFECHA})
        Me.GridViewEmbarques.GridControl = Me.gridEmbarques
        Me.GridViewEmbarques.Name = "GridViewEmbarques"
        Me.GridViewEmbarques.OptionsBehavior.Editable = False
        Me.GridViewEmbarques.OptionsView.ShowAutoFilterRow = True
        '
        'colCODEMBARQUE
        '
        Me.colCODEMBARQUE.Caption = "CODIGO EMB"
        Me.colCODEMBARQUE.FieldName = "CODEMBARQUE"
        Me.colCODEMBARQUE.Name = "colCODEMBARQUE"
        Me.colCODEMBARQUE.Visible = True
        Me.colCODEMBARQUE.VisibleIndex = 0
        Me.colCODEMBARQUE.Width = 187
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        Me.colDESCRIPCION.Width = 328
        '
        'colCODREPARTIDOR
        '
        Me.colCODREPARTIDOR.FieldName = "CODREPARTIDOR"
        Me.colCODREPARTIDOR.Name = "colCODREPARTIDOR"
        Me.colCODREPARTIDOR.Width = 96
        '
        'colNOMEMPLEADO
        '
        Me.colNOMEMPLEADO.Caption = "REPARTIDOR"
        Me.colNOMEMPLEADO.FieldName = "NOMEMPLEADO"
        Me.colNOMEMPLEADO.Name = "colNOMEMPLEADO"
        Me.colNOMEMPLEADO.Visible = True
        Me.colNOMEMPLEADO.VisibleIndex = 2
        Me.colNOMEMPLEADO.Width = 216
        '
        'colFECHA
        '
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 3
        Me.colFECHA.Width = 100
        '
        'checkAgrupar
        '
        Me.checkAgrupar.AutoHeight = False
        Me.checkAgrupar.Name = "checkAgrupar"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnRptTickets)
        Me.GroupControl2.Controls.Add(Me.btnRptBoletas)
        Me.GroupControl2.Controls.Add(Me.btnRptDocumentos)
        Me.GroupControl2.Controls.Add(Me.btnRptProductos)
        Me.GroupControl2.Location = New System.Drawing.Point(1045, 106)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(248, 573)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "IMPRESIONES"
        '
        'btnRptTickets
        '
        Me.btnRptTickets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptTickets.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptTickets.ImageOptions.SvgImage = CType(resources.GetObject("btnRptTickets.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptTickets.Location = New System.Drawing.Point(24, 317)
        Me.btnRptTickets.Name = "btnRptTickets"
        Me.btnRptTickets.Size = New System.Drawing.Size(195, 64)
        Me.btnRptTickets.TabIndex = 3
        Me.btnRptTickets.Text = "LISTADO TICKETS"
        '
        'btnRptBoletas
        '
        Me.btnRptBoletas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptBoletas.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptBoletas.ImageOptions.SvgImage = CType(resources.GetObject("btnRptBoletas.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptBoletas.Location = New System.Drawing.Point(24, 227)
        Me.btnRptBoletas.Name = "btnRptBoletas"
        Me.btnRptBoletas.Size = New System.Drawing.Size(195, 64)
        Me.btnRptBoletas.TabIndex = 2
        Me.btnRptBoletas.Text = "LISTADO BOLETAS"
        '
        'btnRptDocumentos
        '
        Me.btnRptDocumentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptDocumentos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptDocumentos.ImageOptions.SvgImage = CType(resources.GetObject("btnRptDocumentos.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptDocumentos.Location = New System.Drawing.Point(24, 134)
        Me.btnRptDocumentos.Name = "btnRptDocumentos"
        Me.btnRptDocumentos.Size = New System.Drawing.Size(195, 64)
        Me.btnRptDocumentos.TabIndex = 1
        Me.btnRptDocumentos.Text = "LISTA DOCUMENTOS"
        '
        'btnRptProductos
        '
        Me.btnRptProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptProductos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptProductos.ImageOptions.SvgImage = CType(resources.GetObject("btnRptProductos.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptProductos.Location = New System.Drawing.Point(24, 40)
        Me.btnRptProductos.Name = "btnRptProductos"
        Me.btnRptProductos.Size = New System.Drawing.Size(195, 64)
        Me.btnRptProductos.TabIndex = 0
        Me.btnRptProductos.Text = "PICKING PRODUCTOS"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(713, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Embarque Seleccionado:"
        '
        'lbEmbarque
        '
        Me.lbEmbarque.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmbarque.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbEmbarque.Appearance.Options.UseFont = True
        Me.lbEmbarque.Appearance.Options.UseForeColor = True
        Me.lbEmbarque.Location = New System.Drawing.Point(713, 64)
        Me.lbEmbarque.Name = "lbEmbarque"
        Me.lbEmbarque.Size = New System.Drawing.Size(6, 18)
        Me.lbEmbarque.TabIndex = 3
        Me.lbEmbarque.Text = "-"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.cmbEmpresas)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.cmbActivo)
        Me.GroupControl3.Controls.Add(Me.cmbAnio)
        Me.GroupControl3.Controls.Add(Me.cmbMes)
        Me.GroupControl3.Location = New System.Drawing.Point(138, 16)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(554, 80)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Parametros"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(461, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "FINALIZADO:"
        '
        'cmbEmpresas
        '
        Me.cmbEmpresas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpresas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpresas.FormattingEnabled = True
        Me.cmbEmpresas.Location = New System.Drawing.Point(11, 51)
        Me.cmbEmpresas.Name = "cmbEmpresas"
        Me.cmbEmpresas.Size = New System.Drawing.Size(225, 21)
        Me.cmbEmpresas.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(301, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Modulo de Impresion de Documentos"
        '
        'cmbActivo
        '
        Me.cmbActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivo.FormattingEnabled = True
        Me.cmbActivo.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmbActivo.Location = New System.Drawing.Point(461, 51)
        Me.cmbActivo.Name = "cmbActivo"
        Me.cmbActivo.Size = New System.Drawing.Size(81, 21)
        Me.cmbActivo.TabIndex = 2
        '
        'cmbAnio
        '
        Me.cmbAnio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAnio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Items.AddRange(New Object() {"2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.cmbAnio.Location = New System.Drawing.Point(369, 51)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(85, 21)
        Me.cmbAnio.TabIndex = 1
        '
        'cmbMes
        '
        Me.cmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(242, 51)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.btnLimpiarEmbarques)
        Me.GroupControl4.Controls.Add(Me.txtEmbarquesAgrupados)
        Me.GroupControl4.Controls.Add(Me.LabelControl4)
        Me.GroupControl4.Controls.Add(Me.btnRptProductosAgrupados)
        Me.GroupControl4.Location = New System.Drawing.Point(777, 106)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(260, 573)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "AGRUPAR"
        '
        'btnLimpiarEmbarques
        '
        Me.btnLimpiarEmbarques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarEmbarques.ImageOptions.Image = CType(resources.GetObject("btnLimpiarEmbarques.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLimpiarEmbarques.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLimpiarEmbarques.Location = New System.Drawing.Point(214, 138)
        Me.btnLimpiarEmbarques.Name = "btnLimpiarEmbarques"
        Me.btnLimpiarEmbarques.Size = New System.Drawing.Size(28, 26)
        Me.btnLimpiarEmbarques.TabIndex = 6
        '
        'txtEmbarquesAgrupados
        '
        Me.txtEmbarquesAgrupados.Location = New System.Drawing.Point(16, 180)
        Me.txtEmbarquesAgrupados.Multiline = True
        Me.txtEmbarquesAgrupados.Name = "txtEmbarquesAgrupados"
        Me.txtEmbarquesAgrupados.Size = New System.Drawing.Size(230, 164)
        Me.txtEmbarquesAgrupados.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(16, 141)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(182, 19)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Embarques a Agrupar:"
        '
        'btnRptProductosAgrupados
        '
        Me.btnRptProductosAgrupados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptProductosAgrupados.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptProductosAgrupados.ImageOptions.SvgImage = CType(resources.GetObject("btnRptProductosAgrupados.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptProductosAgrupados.Location = New System.Drawing.Point(30, 40)
        Me.btnRptProductosAgrupados.Name = "btnRptProductosAgrupados"
        Me.btnRptProductosAgrupados.Size = New System.Drawing.Size(195, 64)
        Me.btnRptProductosAgrupados.TabIndex = 1
        Me.btnRptProductosAgrupados.Text = "PICKING AGRUPADO"
        '
        'NavigationFrame
        '
        Me.NavigationFrame.Controls.Add(Me.NP_MENU)
        Me.NavigationFrame.Controls.Add(Me.NP_EMBARQUES)
        Me.NavigationFrame.Controls.Add(Me.NP_INVENTARIOS)
        Me.NavigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame.Location = New System.Drawing.Point(0, 0)
        Me.NavigationFrame.Name = "NavigationFrame"
        Me.NavigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NP_MENU, Me.NP_EMBARQUES, Me.NP_INVENTARIOS})
        Me.NavigationFrame.SelectedPage = Me.NP_MENU
        Me.NavigationFrame.Size = New System.Drawing.Size(1300, 687)
        Me.NavigationFrame.TabIndex = 6
        Me.NavigationFrame.Text = "NavigationFrame"
        Me.NavigationFrame.TransitionAnimationProperties.FrameCount = 500
        Me.NavigationFrame.TransitionAnimationProperties.FrameInterval = 5000
        '
        'NP_MENU
        '
        Me.NP_MENU.Caption = "NP_MENU"
        Me.NP_MENU.Controls.Add(Me.PictureBox1)
        Me.NP_MENU.Controls.Add(Me.LabelControl5)
        Me.NP_MENU.Controls.Add(Me.btnInventarios)
        Me.NP_MENU.Controls.Add(Me.btnEmbarques)
        Me.NP_MENU.Name = "NP_MENU"
        Me.NP_MENU.Size = New System.Drawing.Size(1300, 687)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.XELASOL_PRINTERS.My.Resources.Resources.favicon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(140, 185)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(260, 25)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "SELECCIONE UNA OPCION:"
        '
        'btnInventarios
        '
        Me.btnInventarios.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventarios.Appearance.Options.UseFont = True
        Me.btnInventarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventarios.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnInventarios.ImageOptions.SvgImage = CType(resources.GetObject("btnInventarios.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnInventarios.Location = New System.Drawing.Point(477, 404)
        Me.btnInventarios.Name = "btnInventarios"
        Me.btnInventarios.Size = New System.Drawing.Size(339, 141)
        Me.btnInventarios.TabIndex = 1
        Me.btnInventarios.Text = "INVENTARIOS"
        '
        'btnEmbarques
        '
        Me.btnEmbarques.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmbarques.Appearance.Options.UseFont = True
        Me.btnEmbarques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmbarques.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnEmbarques.ImageOptions.SvgImage = CType(resources.GetObject("btnEmbarques.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnEmbarques.Location = New System.Drawing.Point(477, 185)
        Me.btnEmbarques.Name = "btnEmbarques"
        Me.btnEmbarques.Size = New System.Drawing.Size(339, 141)
        Me.btnEmbarques.TabIndex = 0
        Me.btnEmbarques.Text = "EMBARQUES / PICKING"
        '
        'NP_EMBARQUES
        '
        Me.NP_EMBARQUES.Caption = "NP_EMBARQUES"
        Me.NP_EMBARQUES.Controls.Add(Me.imgBtnAtrasEmbarques)
        Me.NP_EMBARQUES.Controls.Add(Me.GroupControl3)
        Me.NP_EMBARQUES.Controls.Add(Me.GroupControl4)
        Me.NP_EMBARQUES.Controls.Add(Me.GroupControl1)
        Me.NP_EMBARQUES.Controls.Add(Me.GroupControl2)
        Me.NP_EMBARQUES.Controls.Add(Me.lbEmbarque)
        Me.NP_EMBARQUES.Controls.Add(Me.LabelControl1)
        Me.NP_EMBARQUES.Name = "NP_EMBARQUES"
        Me.NP_EMBARQUES.Size = New System.Drawing.Size(1300, 687)
        '
        'imgBtnAtrasEmbarques
        '
        Me.imgBtnAtrasEmbarques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgBtnAtrasEmbarques.Image = Global.XELASOL_PRINTERS.My.Resources.Resources.favicon
        Me.imgBtnAtrasEmbarques.Location = New System.Drawing.Point(13, 16)
        Me.imgBtnAtrasEmbarques.Name = "imgBtnAtrasEmbarques"
        Me.imgBtnAtrasEmbarques.Size = New System.Drawing.Size(104, 76)
        Me.imgBtnAtrasEmbarques.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBtnAtrasEmbarques.TabIndex = 6
        Me.imgBtnAtrasEmbarques.TabStop = False
        '
        'NP_INVENTARIOS
        '
        Me.NP_INVENTARIOS.Caption = "NP_INVENTARIOS"
        Me.NP_INVENTARIOS.Controls.Add(Me.btnExportarInventario)
        Me.NP_INVENTARIOS.Controls.Add(Me.btnImprimirInventario)
        Me.NP_INVENTARIOS.Controls.Add(Me.cmbSucursalInventarios)
        Me.NP_INVENTARIOS.Controls.Add(Me.GroupControl5)
        Me.NP_INVENTARIOS.Controls.Add(Me.LabelControl6)
        Me.NP_INVENTARIOS.Controls.Add(Me.imgBtnAtrasInventarios)
        Me.NP_INVENTARIOS.Name = "NP_INVENTARIOS"
        Me.NP_INVENTARIOS.Size = New System.Drawing.Size(1300, 687)
        '
        'btnExportarInventario
        '
        Me.btnExportarInventario.ImageOptions.SvgImage = CType(resources.GetObject("btnExportarInventario.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnExportarInventario.Location = New System.Drawing.Point(653, 38)
        Me.btnExportarInventario.Name = "btnExportarInventario"
        Me.btnExportarInventario.Size = New System.Drawing.Size(164, 50)
        Me.btnExportarInventario.TabIndex = 13
        Me.btnExportarInventario.Text = "EXPORTAR"
        '
        'btnImprimirInventario
        '
        Me.btnImprimirInventario.ImageOptions.SvgImage = CType(resources.GetObject("btnImprimirInventario.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnImprimirInventario.Location = New System.Drawing.Point(434, 38)
        Me.btnImprimirInventario.Name = "btnImprimirInventario"
        Me.btnImprimirInventario.Size = New System.Drawing.Size(164, 50)
        Me.btnImprimirInventario.TabIndex = 12
        Me.btnImprimirInventario.Text = "IMPRIMIR"
        '
        'cmbSucursalInventarios
        '
        Me.cmbSucursalInventarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSucursalInventarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSucursalInventarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursalInventarios.FormattingEnabled = True
        Me.cmbSucursalInventarios.Location = New System.Drawing.Point(142, 67)
        Me.cmbSucursalInventarios.Name = "cmbSucursalInventarios"
        Me.cmbSucursalInventarios.Size = New System.Drawing.Size(242, 21)
        Me.cmbSucursalInventarios.TabIndex = 11
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.gridInventarios)
        Me.GroupControl5.Location = New System.Drawing.Point(34, 103)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1233, 557)
        Me.GroupControl5.TabIndex = 9
        Me.GroupControl5.Text = "Existencias"
        '
        'gridInventarios
        '
        Me.gridInventarios.DataSource = Me.TblinventariosBindingSource1
        Me.gridInventarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridInventarios.Location = New System.Drawing.Point(2, 23)
        Me.gridInventarios.MainView = Me.GridView1
        Me.gridInventarios.Name = "gridInventarios"
        Me.gridInventarios.Size = New System.Drawing.Size(1229, 532)
        Me.gridInventarios.TabIndex = 0
        Me.gridInventarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TblinventariosBindingSource1
        '
        Me.TblinventariosBindingSource1.DataMember = "tbl_inventarios"
        Me.TblinventariosBindingSource1.DataSource = Me.DS_General
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODPROD, Me.colDESPROD, Me.colCODMARCA, Me.colDESMARCA, Me.colTOTALUNIDADES, Me.colTOTALCOSTO, Me.colUXC, Me.colCAJAS, Me.colUNIDADES})
        Me.GridView1.GridControl = Me.gridInventarios
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colCODPROD
        '
        Me.colCODPROD.Caption = "CODIGO"
        Me.colCODPROD.FieldName = "CODPROD"
        Me.colCODPROD.Name = "colCODPROD"
        Me.colCODPROD.Visible = True
        Me.colCODPROD.VisibleIndex = 0
        Me.colCODPROD.Width = 167
        '
        'colDESPROD
        '
        Me.colDESPROD.Caption = "PRODUCTO"
        Me.colDESPROD.FieldName = "DESPROD"
        Me.colDESPROD.Name = "colDESPROD"
        Me.colDESPROD.Visible = True
        Me.colDESPROD.VisibleIndex = 1
        Me.colDESPROD.Width = 411
        '
        'colCODMARCA
        '
        Me.colCODMARCA.FieldName = "CODMARCA"
        Me.colCODMARCA.Name = "colCODMARCA"
        Me.colCODMARCA.Width = 152
        '
        'colDESMARCA
        '
        Me.colDESMARCA.Caption = "MARCA"
        Me.colDESMARCA.FieldName = "DESMARCA"
        Me.colDESMARCA.Name = "colDESMARCA"
        Me.colDESMARCA.Visible = True
        Me.colDESMARCA.VisibleIndex = 2
        Me.colDESMARCA.Width = 225
        '
        'colTOTALUNIDADES
        '
        Me.colTOTALUNIDADES.FieldName = "TOTALUNIDADES"
        Me.colTOTALUNIDADES.Name = "colTOTALUNIDADES"
        Me.colTOTALUNIDADES.Width = 136
        '
        'colTOTALCOSTO
        '
        Me.colTOTALCOSTO.FieldName = "TOTALCOSTO"
        Me.colTOTALCOSTO.Name = "colTOTALCOSTO"
        '
        'colUXC
        '
        Me.colUXC.FieldName = "UXC"
        Me.colUXC.Name = "colUXC"
        Me.colUXC.Visible = True
        Me.colUXC.VisibleIndex = 3
        Me.colUXC.Width = 116
        '
        'colCAJAS
        '
        Me.colCAJAS.FieldName = "CAJAS"
        Me.colCAJAS.Name = "colCAJAS"
        Me.colCAJAS.Visible = True
        Me.colCAJAS.VisibleIndex = 4
        Me.colCAJAS.Width = 129
        '
        'colUNIDADES
        '
        Me.colUNIDADES.FieldName = "UNIDADES"
        Me.colUNIDADES.Name = "colUNIDADES"
        Me.colUNIDADES.Visible = True
        Me.colUNIDADES.VisibleIndex = 5
        Me.colUNIDADES.Width = 158
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(142, 22)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(138, 29)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Inventarios"
        '
        'imgBtnAtrasInventarios
        '
        Me.imgBtnAtrasInventarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgBtnAtrasInventarios.Image = Global.XELASOL_PRINTERS.My.Resources.Resources.favicon
        Me.imgBtnAtrasInventarios.Location = New System.Drawing.Point(12, 12)
        Me.imgBtnAtrasInventarios.Name = "imgBtnAtrasInventarios"
        Me.imgBtnAtrasInventarios.Size = New System.Drawing.Size(104, 76)
        Me.imgBtnAtrasInventarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBtnAtrasInventarios.TabIndex = 7
        Me.imgBtnAtrasInventarios.TabStop = False
        '
        'TblinventariosBindingSource
        '
        Me.TblinventariosBindingSource.DataMember = "tbl_inventarios"
        Me.TblinventariosBindingSource.DataSource = Me.DS_General
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 687)
        Me.Controls.Add(Me.NavigationFrame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gridEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmbarquesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_General, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAgrupar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.NavigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame.ResumeLayout(False)
        Me.NP_MENU.ResumeLayout(False)
        Me.NP_MENU.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NP_EMBARQUES.ResumeLayout(False)
        Me.NP_EMBARQUES.PerformLayout()
        CType(Me.imgBtnAtrasEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NP_INVENTARIOS.ResumeLayout(False)
        Me.NP_INVENTARIOS.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.gridInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblinventariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBtnAtrasInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblinventariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridEmbarques As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewEmbarques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbEmbarque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents cmbAnio As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TblEmbarquesBindingSource As BindingSource
    Friend WithEvents DS_General As DS_General
    Friend WithEvents colCODEMBARQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODREPARTIDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMEMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbEmpresas As ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRptBoletas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRptDocumentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRptProductos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRptTickets As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkAgrupar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRptProductosAgrupados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLimpiarEmbarques As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmbarquesAgrupados As TextBox
    Friend WithEvents NavigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NP_MENU As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnInventarios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEmbarques As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NP_EMBARQUES As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NP_INVENTARIOS As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents imgBtnAtrasEmbarques As PictureBox
    Friend WithEvents imgBtnAtrasInventarios As PictureBox
    Friend WithEvents cmbSucursalInventarios As ComboBox
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExportarInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimirInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TblinventariosBindingSource As BindingSource
    Friend WithEvents gridInventarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents TblinventariosBindingSource1 As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODPROD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESPROD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODMARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESMARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTALUNIDADES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTALCOSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUXC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCAJAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDADES As DevExpress.XtraGrid.Columns.GridColumn
End Class
