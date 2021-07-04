Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms



''' <summary>
''' Demonstration Application - this form
''' class is used to test each of the functions
''' and subroutines defined in the Accessor
''' class
''' </summary>
''' <remarks></remarks>
Public Class frmMain

    ' used to support take/skip example
    Private OrderPosition As Integer



#Region "Constructor"


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OrderPosition = 0

    End Sub


#End Region



#Region "Full Table Requests"


    ''' <summary>
    ''' Display full employee table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub employeesToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles employeesToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetEmployeeTable()

    End Sub



    ''' <summary>
    ''' Display full shippers table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub shippersToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles shippersToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetShipperTable()

    End Sub


    ''' <summary>
    ''' Display full orders table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ordersToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles ordersToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetOrderTable()

    End Sub



    ''' <summary>
    ''' Display full employee territory table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub employeeTerritoryToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles employeeTerritoryToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetEmployeeTerritoryTable()

    End Sub



    ''' <summary>
    ''' Display the full territory table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub territoryToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles territoryToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetTerritoryTable()

    End Sub



    ''' <summary>
    ''' Display full region table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub regionToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles regionToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetRegionTable()

    End Sub



    ''' <summary>
    ''' Display full customer table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub customerToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles customerToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetCustomerTable()

    End Sub



    ''' <summary>
    ''' Display the full customer customer demo table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub customerDemoToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles customerDemoToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetCustomerCustomerDemoTable()

    End Sub



    ''' <summary>
    ''' Display the full customer demographic table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub customerDemographicToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles customerDemographicToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetCustomerDemographicTable()

    End Sub



    ''' <summary>
    ''' Display the full order_detail table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub orderDetailsToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles orderDetailsToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetOrderDetailTable()

    End Sub



    ''' <summary>
    ''' Display the full product table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub productToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles productToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetProductTable()

    End Sub



    ''' <summary>
    ''' Display the full supplier table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub supplierProductToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles supplierProductToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetSupplierTable()

    End Sub



    ''' <summary>
    ''' Display the full category table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub categoToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles categoToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetCategoryTable()

    End Sub


#End Region



#Region "Queries"


    ''' <summary>
    ''' Find and display an employee by 
    ''' the employee's ID
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub employeeByIDToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles employeeByIDToolStripMenuItem.Click

        Dim emp As New Employee
        emp = Accessor.GetEmployeeById(1)

        Dim sb As New StringBuilder()
        sb.Append("Employee 1: " + Environment.NewLine)
        sb.Append("Name: " + emp.FirstName + " " + emp.LastName + Environment.NewLine)
        sb.Append("Hire Date: " + emp.HireDate + Environment.NewLine)
        sb.Append("Home Phone: " + emp.HomePhone + Environment.NewLine)

        MessageBox.Show(sb.ToString(), "Employee ID Search")

    End Sub



    ''' <summary>
    ''' Gets an Order by the order ID and
    ''' displays information about the first
    ''' single matching order.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub orderByIDToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles orderByIDToolStripMenuItem.Click

        Dim ord As New Order()
        ord = Accessor.GetOrderById(10248)

        Dim sb As New StringBuilder()
        sb.Append("Order: " + Environment.NewLine)
        sb.Append("Order ID: " + ord.OrderID.ToString() + Environment.NewLine)
        sb.Append("Date Shipped: " + ord.ShippedDate + Environment.NewLine)
        sb.Append("Shipping Address: " + ord.ShipAddress + Environment.NewLine)
        sb.Append("- City: " + ord.ShipCity + Environment.NewLine)
        sb.Append("- Region: " + ord.ShipRegion + Environment.NewLine)
        sb.Append("- Country: " + ord.ShipCountry + Environment.NewLine)
        sb.Append("- Postal Code: " + ord.ShipPostalCode + Environment.NewLine)
        sb.Append("Shipping Name: " + ord.ShipName + Environment.NewLine)

        MessageBox.Show(sb.ToString(), "Shipping Information")

    End Sub



    ''' <summary>
    ''' Displays a list of employeess ordered by
    ''' their dates of hire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub employeesByHireDateToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles employeesByHireDateToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetEmployeesByHireDate()

    End Sub



    ''' <summary>
    ''' Displays all orders that match
    ''' on Order ID
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ordersByIdToolStripMenuItem_Click( _
            ByVal sender As  _
            System.Object, _
            ByVal e As System.EventArgs) _
            Handles ordersByIdToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetOrdersById(10248)

    End Sub



    ''' <summary>
    ''' Returns values based on joining the Order and
    ''' Order_Details tables
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ordersAndDetailsToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles ordersAndDetailsToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.OrdersAndDetails()

    End Sub



    ''' <summary>
    ''' Query across entity set
    ''' This example collections information from the orders table
    ''' and the order_details table through the orders table
    ''' entity reference to orders_details.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ordersAndDetailsEntityRefToolStripMenuItem_Click( _
            ByVal sender _
            As System.Object, _
            ByVal e As System.EventArgs) _
            Handles ordersAndDetailsEntityRefToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetOrderAndPricingInformation()

    End Sub



    ''' <summary>
    ''' Retrieves values across an entity set to 
    ''' display both order and pricing information 
    ''' by filtering for an order ID
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ordersAndDetailsByOrderIDEntityRefToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles ordersAndDetailsByOrderIDEntityRefToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.GetOrderAndPricingInformationByOrderId(10248)

    End Sub



    ''' <summary>
    ''' Displays to total dollar value of the selected order
    ''' by multiplying each order product's unit cost by
    ''' the units ordered, and then summing the total of each
    ''' individual cost.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub orderValueByOrderIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderValueByOrderIDToolStripMenuItem.Click

        ' get the dollar value
        Dim d As Decimal? = Accessor.GetOrderValueByOrderId(10248)

        ' convert the decimal value to currency
        Dim dollarValue As String = String.Format("{0:c}", d)

        ' display the dollar value
        MessageBox.Show("The total dollar value of order 10248 is " & _
                        dollarValue, "Order 10248 Value")
    End Sub



    ''' <summary>
    ''' Displays the top five orders in the order table
    ''' on first selection and then increments up by
    ''' five orders to show the list five orders
    ''' at a time
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub getTopFiveOrdersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getTopFiveOrdersToolStripMenuItem.Click

        Try
            ' get the top five orders starting at the current position
            dataGridView1.DataSource = Accessor.GetTopFiveOrdersById(OrderPosition)

            ' increment the formwide variable used to
            ' keep track of the position within the 
            ' list of orders
            OrderPosition += 5

            ' change the text in the menu strip item
            ' to show that it will retrieve the next
            ' five values after the current position 
            ' of the last value shown in the grid
            getTopFiveOrdersToolStripMenuItem.Text = "Get Next Five Orders"

        Catch

            MessageBox.Show("Cannot increment an higher, starting list over.")
            OrderPosition = 0

        End Try

    End Sub


#End Region



#Region "Insert Update Delete"



    ''' <summary>
    ''' Insert or Update a Customer into
    ''' the Customer Table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub insertOrUpdateCustomerToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles insertOrUpdateCustomerToolStripMenuItem.Click


        Try

            ' insert or update customer
            Accessor.InsertOrUpdateCustomer("AAAAA", "BXSW", _
                                            "Mookie Carbunkle", "Chieftain", _
                                            "122 North Main Street", "Wamucka", _
                                            "DC", "78888", "USA", _
                                            "244-233-8977", "244-438-2933")

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error")

        End Try


    End Sub



    ''' <summary>
    ''' Delete an existing customer from
    ''' the customer table if the customer
    ''' ID matches
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub deleteCustomerToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles deleteCustomerToolStripMenuItem.Click

        Try

            Accessor.DeleteCustomer("AAAAA")

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error")

        End Try

    End Sub


#End Region



#Region "Stored Procedures"


    ''' <summary>
    ''' Execute the Sales by Year stored
    ''' procedure and display the results
    ''' in the datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub salesByYearToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles salesByYearToolStripMenuItem.Click

        ' define a starting and ending date
        Dim startDate As New DateTime(1990, 1, 1)
        Dim endDate As New DateTime(2000, 1, 1)

        dataGridView1.DataSource = Accessor.SalesByYear(startDate, endDate)

    End Sub



    ''' <summary>
    ''' Execute the Ten Most Expensive Products
    ''' stored procedure and display the
    ''' results in the datagri
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tenMostExpensiveProductsToolStripMenuItem_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles tenMostExpensiveProductsToolStripMenuItem.Click

        dataGridView1.DataSource = Accessor.TenMostExpensiveProducts()

    End Sub

#End Region



#Region "Housekeeping"

    Private Sub exitToolStripMenuItem_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) _
        Handles exitToolStripMenuItem.Click

        Application.Exit()

    End Sub

#End Region



End Class
