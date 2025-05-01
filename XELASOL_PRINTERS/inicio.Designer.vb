<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmbarquesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_General, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gridEmbarques)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(858, 529)
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
        Me.gridEmbarques.Size = New System.Drawing.Size(854, 504)
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
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnRptTickets)
        Me.GroupControl2.Controls.Add(Me.btnRptBoletas)
        Me.GroupControl2.Controls.Add(Me.btnRptDocumentos)
        Me.GroupControl2.Controls.Add(Me.btnRptProductos)
        Me.GroupControl2.Location = New System.Drawing.Point(885, 95)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(313, 527)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "IMPRESIONES"
        '
        'btnRptTickets
        '
        Me.btnRptTickets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptTickets.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptTickets.ImageOptions.SvgImage = CType(resources.GetObject("btnRptTickets.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptTickets.Location = New System.Drawing.Point(21, 363)
        Me.btnRptTickets.Name = "btnRptTickets"
        Me.btnRptTickets.Size = New System.Drawing.Size(276, 78)
        Me.btnRptTickets.TabIndex = 3
        Me.btnRptTickets.Text = "LISTADO TICKETS"
        '
        'btnRptBoletas
        '
        Me.btnRptBoletas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptBoletas.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptBoletas.ImageOptions.SvgImage = CType(resources.GetObject("btnRptBoletas.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptBoletas.Location = New System.Drawing.Point(21, 260)
        Me.btnRptBoletas.Name = "btnRptBoletas"
        Me.btnRptBoletas.Size = New System.Drawing.Size(276, 78)
        Me.btnRptBoletas.TabIndex = 2
        Me.btnRptBoletas.Text = "LISTADO BOLETAS"
        '
        'btnRptDocumentos
        '
        Me.btnRptDocumentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptDocumentos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptDocumentos.ImageOptions.SvgImage = CType(resources.GetObject("btnRptDocumentos.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptDocumentos.Location = New System.Drawing.Point(21, 146)
        Me.btnRptDocumentos.Name = "btnRptDocumentos"
        Me.btnRptDocumentos.Size = New System.Drawing.Size(276, 78)
        Me.btnRptDocumentos.TabIndex = 1
        Me.btnRptDocumentos.Text = "LISTA DOCUMENTOS"
        '
        'btnRptProductos
        '
        Me.btnRptProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRptProductos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRptProductos.ImageOptions.SvgImage = CType(resources.GetObject("btnRptProductos.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRptProductos.Location = New System.Drawing.Point(21, 39)
        Me.btnRptProductos.Name = "btnRptProductos"
        Me.btnRptProductos.Size = New System.Drawing.Size(276, 78)
        Me.btnRptProductos.TabIndex = 0
        Me.btnRptProductos.Text = "PICKING PRODUCTOS"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(678, 32)
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
        Me.lbEmbarque.Location = New System.Drawing.Point(678, 53)
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
        Me.GroupControl3.Location = New System.Drawing.Point(12, 9)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(653, 80)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Parametros"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(551, 31)
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
        Me.cmbEmpresas.Location = New System.Drawing.Point(101, 51)
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
        Me.LabelControl2.Location = New System.Drawing.Point(7, 26)
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
        Me.cmbActivo.Location = New System.Drawing.Point(551, 51)
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
        Me.cmbAnio.Location = New System.Drawing.Point(459, 51)
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
        Me.cmbMes.Location = New System.Drawing.Point(332, 51)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 0
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 636)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.lbEmbarque)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicio"
        Me.Text = "inicio"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gridEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmbarquesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_General, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
