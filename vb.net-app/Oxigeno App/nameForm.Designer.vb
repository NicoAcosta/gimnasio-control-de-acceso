<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nameForm))
        Me.VencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SnarkyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuppyDataSet = New Oxigeno_App.PuppyDataSet()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.EstTextBox = New System.Windows.Forms.TextBox()
        Me.NomApTextBox = New System.Windows.Forms.TextBox()
        Me.ByTagToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TagToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TagToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ByTagToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SnarkyTableAdapter = New Oxigeno_App.PuppyDataSetTableAdapters.SnarkyTableAdapter()
        Me.TableAdapterManager = New Oxigeno_App.PuppyDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.VenLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.SnarkyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuppyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ByTagToolStrip.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VencimientoDateTimePicker
        '
        Me.VencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SnarkyBindingSource, "Vencimiento", True))
        Me.VencimientoDateTimePicker.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VencimientoDateTimePicker.Location = New System.Drawing.Point(594, 830)
        Me.VencimientoDateTimePicker.Name = "VencimientoDateTimePicker"
        Me.VencimientoDateTimePicker.Size = New System.Drawing.Size(718, 54)
        Me.VencimientoDateTimePicker.TabIndex = 4
        '
        'SnarkyBindingSource
        '
        Me.SnarkyBindingSource.DataMember = "Snarky"
        Me.SnarkyBindingSource.DataSource = Me.PuppyDataSet
        '
        'PuppyDataSet
        '
        Me.PuppyDataSet.DataSetName = "PuppyDataSet"
        Me.PuppyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SnarkyBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.EstadoTextBox.Location = New System.Drawing.Point(732, 643)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(465, 64)
        Me.EstadoTextBox.TabIndex = 12
        Me.EstadoTextBox.Text = "estado"
        Me.EstadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EstTextBox
        '
        Me.EstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SnarkyBindingSource, "Est", True))
        Me.EstTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstTextBox.ForeColor = System.Drawing.Color.White
        Me.EstTextBox.Location = New System.Drawing.Point(0, 401)
        Me.EstTextBox.Name = "EstTextBox"
        Me.EstTextBox.Size = New System.Drawing.Size(218, 47)
        Me.EstTextBox.TabIndex = 14
        Me.EstTextBox.Text = "est"
        Me.EstTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomApTextBox
        '
        Me.NomApTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomApTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SnarkyBindingSource, "NomAp", True))
        Me.NomApTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomApTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NomApTextBox.Location = New System.Drawing.Point(438, 533)
        Me.NomApTextBox.Name = "NomApTextBox"
        Me.NomApTextBox.Size = New System.Drawing.Size(1031, 64)
        Me.NomApTextBox.TabIndex = 24
        Me.NomApTextBox.Text = "Nombre Nombre Apellido"
        Me.NomApTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ByTagToolStrip
        '
        Me.ByTagToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TagToolStripLabel, Me.TagToolStripTextBox, Me.ByTagToolStripButton})
        Me.ByTagToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ByTagToolStrip.Name = "ByTagToolStrip"
        Me.ByTagToolStrip.Size = New System.Drawing.Size(1920, 25)
        Me.ByTagToolStrip.TabIndex = 26
        Me.ByTagToolStrip.Text = "ByTagToolStrip"
        '
        'TagToolStripLabel
        '
        Me.TagToolStripLabel.Name = "TagToolStripLabel"
        Me.TagToolStripLabel.Size = New System.Drawing.Size(29, 22)
        Me.TagToolStripLabel.Text = "Tag:"
        '
        'TagToolStripTextBox
        '
        Me.TagToolStripTextBox.Name = "TagToolStripTextBox"
        Me.TagToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ByTagToolStripButton
        '
        Me.ByTagToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ByTagToolStripButton.Name = "ByTagToolStripButton"
        Me.ByTagToolStripButton.Size = New System.Drawing.Size(43, 22)
        Me.ByTagToolStripButton.Text = "ByTag"
        '
        'SnarkyTableAdapter
        '
        Me.SnarkyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SnarkyTableAdapter = Me.SnarkyTableAdapter
        Me.TableAdapterManager.UpdateOrder = Oxigeno_App.PuppyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-428, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(2741, 448)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'VenLabel
        '
        Me.VenLabel.AutoSize = True
        Me.VenLabel.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VenLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.VenLabel.Location = New System.Drawing.Point(864, 763)
        Me.VenLabel.Name = "VenLabel"
        Me.VenLabel.Size = New System.Drawing.Size(199, 38)
        Me.VenLabel.TabIndex = 28
        Me.VenLabel.Text = "Vencimiento:"
        Me.VenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1686, 891)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Desarrollado por"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1552, 919)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(299, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'nameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.VenLabel)
        Me.Controls.Add(Me.ByTagToolStrip)
        Me.Controls.Add(Me.VencimientoDateTimePicker)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(Me.EstTextBox)
        Me.Controls.Add(Me.NomApTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nameForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nameForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SnarkyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuppyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ByTagToolStrip.ResumeLayout(False)
        Me.ByTagToolStrip.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PuppyDataSet As PuppyDataSet
    Friend WithEvents SnarkyBindingSource As BindingSource
    Friend WithEvents SnarkyTableAdapter As PuppyDataSetTableAdapters.SnarkyTableAdapter
    Friend WithEvents TableAdapterManager As PuppyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VencimientoDateTimePicker As DateTimePicker
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents EstTextBox As TextBox
    Friend WithEvents NomApTextBox As TextBox
    Friend WithEvents ByTagToolStrip As ToolStrip
    Friend WithEvents TagToolStripLabel As ToolStripLabel
    Friend WithEvents TagToolStripTextBox As ToolStripTextBox
    Friend WithEvents ByTagToolStripButton As ToolStripButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents VenLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
