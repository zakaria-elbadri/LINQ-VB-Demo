<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.getTopFiveOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.readToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.employeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.shippersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.employeeTerritoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.territoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.regionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.customerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.customerDemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.customerDemographicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.orderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.productToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.supplierProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.categoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.queriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.listsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.employeesByHireDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ordersByIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ordersAndDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ordersAndDetailsEntityRefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.singleValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.employeeByIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.orderByIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.orderValueByOrderIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.storedProceduresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.salesByYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tenMostExpensiveProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.writeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.insertOrUpdateCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.deleteCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.menuStrip1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'getTopFiveOrdersToolStripMenuItem
        '
        Me.getTopFiveOrdersToolStripMenuItem.Name = "getTopFiveOrdersToolStripMenuItem"
        Me.getTopFiveOrdersToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.getTopFiveOrdersToolStripMenuItem.Text = "Get Top Five Orders"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.readToolStripMenuItem, Me.writeToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(566, 24)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'readToolStripMenuItem
        '
        Me.readToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tablesToolStripMenuItem, Me.queriesToolStripMenuItem, Me.storedProceduresToolStripMenuItem})
        Me.readToolStripMenuItem.Name = "readToolStripMenuItem"
        Me.readToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.readToolStripMenuItem.Text = "Read"
        '
        'tablesToolStripMenuItem
        '
        Me.tablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.employeesToolStripMenuItem, Me.shippersToolStripMenuItem, Me.ordersToolStripMenuItem, Me.employeeTerritoryToolStripMenuItem, Me.territoryToolStripMenuItem, Me.regionToolStripMenuItem, Me.customerToolStripMenuItem, Me.customerDemoToolStripMenuItem, Me.customerDemographicToolStripMenuItem, Me.orderDetailsToolStripMenuItem, Me.productToolStripMenuItem, Me.supplierProductToolStripMenuItem, Me.categoToolStripMenuItem})
        Me.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem"
        Me.tablesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.tablesToolStripMenuItem.Text = "Tables"
        '
        'employeesToolStripMenuItem
        '
        Me.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem"
        Me.employeesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.employeesToolStripMenuItem.Text = "Employees"
        '
        'shippersToolStripMenuItem
        '
        Me.shippersToolStripMenuItem.Name = "shippersToolStripMenuItem"
        Me.shippersToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.shippersToolStripMenuItem.Text = "Shippers"
        '
        'ordersToolStripMenuItem
        '
        Me.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem"
        Me.ordersToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ordersToolStripMenuItem.Text = "Orders"
        '
        'employeeTerritoryToolStripMenuItem
        '
        Me.employeeTerritoryToolStripMenuItem.Name = "employeeTerritoryToolStripMenuItem"
        Me.employeeTerritoryToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.employeeTerritoryToolStripMenuItem.Text = "Employee Territory"
        '
        'territoryToolStripMenuItem
        '
        Me.territoryToolStripMenuItem.Name = "territoryToolStripMenuItem"
        Me.territoryToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.territoryToolStripMenuItem.Text = "Territory"
        '
        'regionToolStripMenuItem
        '
        Me.regionToolStripMenuItem.Name = "regionToolStripMenuItem"
        Me.regionToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.regionToolStripMenuItem.Text = "Region"
        '
        'customerToolStripMenuItem
        '
        Me.customerToolStripMenuItem.Name = "customerToolStripMenuItem"
        Me.customerToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.customerToolStripMenuItem.Text = "Customer"
        '
        'customerDemoToolStripMenuItem
        '
        Me.customerDemoToolStripMenuItem.Name = "customerDemoToolStripMenuItem"
        Me.customerDemoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.customerDemoToolStripMenuItem.Text = "Customer Demo"
        '
        'customerDemographicToolStripMenuItem
        '
        Me.customerDemographicToolStripMenuItem.Name = "customerDemographicToolStripMenuItem"
        Me.customerDemographicToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.customerDemographicToolStripMenuItem.Text = "Customer Demographic"
        '
        'orderDetailsToolStripMenuItem
        '
        Me.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem"
        Me.orderDetailsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.orderDetailsToolStripMenuItem.Text = "Order Details"
        '
        'productToolStripMenuItem
        '
        Me.productToolStripMenuItem.Name = "productToolStripMenuItem"
        Me.productToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.productToolStripMenuItem.Text = "Product"
        '
        'supplierProductToolStripMenuItem
        '
        Me.supplierProductToolStripMenuItem.Name = "supplierProductToolStripMenuItem"
        Me.supplierProductToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.supplierProductToolStripMenuItem.Text = "Supplier"
        '
        'categoToolStripMenuItem
        '
        Me.categoToolStripMenuItem.Name = "categoToolStripMenuItem"
        Me.categoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.categoToolStripMenuItem.Text = "Category"
        '
        'queriesToolStripMenuItem
        '
        Me.queriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.listsToolStripMenuItem, Me.singleValuesToolStripMenuItem})
        Me.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem"
        Me.queriesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.queriesToolStripMenuItem.Text = "Queries"
        '
        'listsToolStripMenuItem
        '
        Me.listsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.employeesByHireDateToolStripMenuItem, Me.ordersByIdToolStripMenuItem, Me.ordersAndDetailsToolStripMenuItem, Me.ordersAndDetailsEntityRefToolStripMenuItem, Me.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem, Me.getTopFiveOrdersToolStripMenuItem})
        Me.listsToolStripMenuItem.Name = "listsToolStripMenuItem"
        Me.listsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.listsToolStripMenuItem.Text = "Lists"
        '
        'employeesByHireDateToolStripMenuItem
        '
        Me.employeesByHireDateToolStripMenuItem.Name = "employeesByHireDateToolStripMenuItem"
        Me.employeesByHireDateToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.employeesByHireDateToolStripMenuItem.Text = "Employees By Hire Date"
        '
        'ordersByIdToolStripMenuItem
        '
        Me.ordersByIdToolStripMenuItem.Name = "ordersByIdToolStripMenuItem"
        Me.ordersByIdToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.ordersByIdToolStripMenuItem.Text = "Orders By ID"
        '
        'ordersAndDetailsToolStripMenuItem
        '
        Me.ordersAndDetailsToolStripMenuItem.Name = "ordersAndDetailsToolStripMenuItem"
        Me.ordersAndDetailsToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.ordersAndDetailsToolStripMenuItem.Text = "Orders and Details"
        '
        'ordersAndDetailsEntityRefToolStripMenuItem
        '
        Me.ordersAndDetailsEntityRefToolStripMenuItem.Name = "ordersAndDetailsEntityRefToolStripMenuItem"
        Me.ordersAndDetailsEntityRefToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.ordersAndDetailsEntityRefToolStripMenuItem.Text = "Orders and Details (Entity Set)"
        '
        'ordersAndDetailsByOrderIDEntityRefToolStripMenuItem
        '
        Me.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Name = "ordersAndDetailsByOrderIDEntityRefToolStripMenuItem"
        Me.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Size = New System.Drawing.Size(292, 22)
        Me.ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Text = "Orders and Details By Order ID (Entity Set)"
        '
        'singleValuesToolStripMenuItem
        '
        Me.singleValuesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.employeeByIDToolStripMenuItem, Me.orderByIDToolStripMenuItem, Me.orderValueByOrderIDToolStripMenuItem})
        Me.singleValuesToolStripMenuItem.Name = "singleValuesToolStripMenuItem"
        Me.singleValuesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.singleValuesToolStripMenuItem.Text = "Single Values"
        '
        'employeeByIDToolStripMenuItem
        '
        Me.employeeByIDToolStripMenuItem.Name = "employeeByIDToolStripMenuItem"
        Me.employeeByIDToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.employeeByIDToolStripMenuItem.Text = "Employee By ID"
        '
        'orderByIDToolStripMenuItem
        '
        Me.orderByIDToolStripMenuItem.Name = "orderByIDToolStripMenuItem"
        Me.orderByIDToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.orderByIDToolStripMenuItem.Text = "Order By ID"
        '
        'orderValueByOrderIDToolStripMenuItem
        '
        Me.orderValueByOrderIDToolStripMenuItem.Name = "orderValueByOrderIDToolStripMenuItem"
        Me.orderValueByOrderIDToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.orderValueByOrderIDToolStripMenuItem.Text = "Order Value By Order ID"
        '
        'storedProceduresToolStripMenuItem
        '
        Me.storedProceduresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.salesByYearToolStripMenuItem, Me.tenMostExpensiveProductsToolStripMenuItem})
        Me.storedProceduresToolStripMenuItem.Name = "storedProceduresToolStripMenuItem"
        Me.storedProceduresToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.storedProceduresToolStripMenuItem.Text = "Stored Procedures"
        '
        'salesByYearToolStripMenuItem
        '
        Me.salesByYearToolStripMenuItem.Name = "salesByYearToolStripMenuItem"
        Me.salesByYearToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.salesByYearToolStripMenuItem.Text = "Sales By Year"
        '
        'tenMostExpensiveProductsToolStripMenuItem
        '
        Me.tenMostExpensiveProductsToolStripMenuItem.Name = "tenMostExpensiveProductsToolStripMenuItem"
        Me.tenMostExpensiveProductsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.tenMostExpensiveProductsToolStripMenuItem.Text = "Ten Most Expensive Products"
        '
        'writeToolStripMenuItem
        '
        Me.writeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertOrUpdateCustomerToolStripMenuItem, Me.deleteCustomerToolStripMenuItem})
        Me.writeToolStripMenuItem.Name = "writeToolStripMenuItem"
        Me.writeToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.writeToolStripMenuItem.Text = "Insert/Update/Delete"
        '
        'insertOrUpdateCustomerToolStripMenuItem
        '
        Me.insertOrUpdateCustomerToolStripMenuItem.Name = "insertOrUpdateCustomerToolStripMenuItem"
        Me.insertOrUpdateCustomerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.insertOrUpdateCustomerToolStripMenuItem.Text = "Insert or Update Customer"
        '
        'deleteCustomerToolStripMenuItem
        '
        Me.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem"
        Me.deleteCustomerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.deleteCustomerToolStripMenuItem.Text = "Delete Customer"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(566, 388)
        Me.dataGridView1.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 412)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "LINQ To SQL"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents getTopFiveOrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents readToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents employeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents shippersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents employeeTerritoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents territoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents regionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents customerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents customerDemoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents customerDemographicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents orderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents productToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents supplierProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents categoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents queriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents listsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents employeesByHireDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ordersByIdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ordersAndDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ordersAndDetailsEntityRefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ordersAndDetailsByOrderIDEntityRefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents singleValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents employeeByIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents orderByIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents orderValueByOrderIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents storedProceduresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents salesByYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tenMostExpensiveProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents writeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents insertOrUpdateCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents deleteCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView

End Class
