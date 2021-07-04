Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Data.Linq
Imports System.Text



''' <summary>
''' This class defines functions used to
''' select, insert, update, and delete data
''' using LINQ to SQL and the defined
''' data context
''' </summary>
''' <remarks></remarks>
Public Class Accessor



#Region "Full Table Queries"

    ' This section contains examples of
    ' pulling back entire tables from
    ' the database

    ''' <summary>
    ''' Returns the Full Employee Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetEmployeeTable() As  _
    System.Data.Linq.Table(Of Employee)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Employee)()

    End Function



    ''' <summary>
    ''' Returns the Full Shipper Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetShipperTable() As  _
    System.Data.Linq.Table(Of Shipper)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Shipper)()

    End Function



    ''' <summary>
    ''' Returns the Full Order Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderTable() As  _
    System.Data.Linq.Table(Of Order)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Order)()

    End Function



    ''' <summary>
    ''' Returns the Full Employee Territory Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetEmployeeTerritoryTable() As  _
        System.Data.Linq.Table(Of EmployeeTerritory)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of EmployeeTerritory)()

    End Function



    ''' <summary>
    ''' Returns the Full Territory Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetTerritoryTable() As  _
        System.Data.Linq.Table(Of Territory)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Territory)()

    End Function



    ''' <summary>
    ''' Returns the Full Region Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetRegionTable() As  _
        System.Data.Linq.Table(Of Region)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Region)()

    End Function



    ''' <summary>
    ''' Returns the Full Customer Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCustomerTable() As  _
        System.Data.Linq.Table(Of Customer)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Customer)()

    End Function



    ''' <summary>
    ''' Returns the Full CustomerCustomerDemo Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCustomerCustomerDemoTable() As  _
        System.Data.Linq.Table(Of CustomerCustomerDemo)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of CustomerCustomerDemo)()

    End Function



    ''' <summary>
    ''' Returns the Full Customer Demographic Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCustomerDemographicTable() As  _
        System.Data.Linq.Table(Of CustomerDemographic)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of CustomerDemographic)()

    End Function



    ''' <summary>
    ''' Returns the Full Order_Detail Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderDetailTable() As  _
        System.Data.Linq.Table(Of Order_Detail)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Order_Detail)()

    End Function



    ''' <summary>
    ''' Returns the Full Product Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetProductTable() As  _
        System.Data.Linq.Table(Of Product)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Product)()

    End Function



    ''' <summary>
    ''' Returns the Full Supplier Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSupplierTable() As  _
    System.Data.Linq.Table(Of Supplier)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Supplier)()

    End Function



    ''' <summary>
    ''' Returns the Full Category Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCategoryTable() As  _
    System.Data.Linq.Table(Of Category)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.GetTable(Of Category)()

    End Function



#End Region



#Region "Queries"

    ' This region contains examples of some
    ' of the sorts of queries that can be
    ' executed using LINQ to SQL

    ''' <summary>
    ''' Example:  Where Clause
    ''' Returns an employee where the
    ''' employee ID matches the value
    ''' passed in as empID
    ''' </summary>
    ''' <param name="empId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetEmployeeById(ByVal empId As Integer) As Employee

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' get the first Employee with and employee ID
        ' matching the employee ID passed in as an 
        ' argument to this function
        Dim retVal = (From e In dc.GetTable(Of Employee)() _
                      Where (e.EmployeeID = empId) _
                      Select e).FirstOrDefault()

        Return retVal

    End Function



    ''' <summary>
    ''' Example:  Select to a single returned object
    ''' using a Where Clause
    ''' 
    ''' Returns the first matching order
    ''' </summary>
    ''' <param name="ordId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderById(ByVal ordId As Integer) As Order

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' return a single value from the orders table
        ' where the order Id match the ordId argument 
        ' passed to this function
        Dim retVal = (From ord In dc.GetTable(Of Order)() _
                      Where (ord.OrderID = ordId) _
                      Select ord).FirstOrDefault()

        Return retVal

    End Function



    ''' <summary>
    ''' Example:  Select to a typed List
    ''' using a Where Clause
    ''' </summary>
    ''' <param name="ordId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrdersById(ByVal ordId As Integer) As List(Of Order)

        ' get the context
        Dim dc As New NorthwindDataClassesDataContext()

        ' get a list of Orders where the Order ID matches
        ' the ordId argument and return the collection as
        ' a list of type Order
        Dim retVal = (From ord In dc.GetTable(Of Order)() _
                      Where (ord.OrderID = ordId) _
                      Select ord).ToList()

        Return retVal

    End Function



    ''' <summary>
    ''' Example:  Return an ordered list
    ''' 
    ''' Converts the returned value to a List
    ''' of type Employee; the list is ordered
    ''' by hire date
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetEmployeesByHireDate() As List(Of Employee)

        ' get the context
        Dim dc As New NorthwindDataClassesDataContext()

        ' get the Employee table, order it by HireDate
        ' and return the result as a list of type Employee
        Dim retVal = (From emp In dc.GetTable(Of Employee)() _
                      Order By emp.HireDate Ascending _
                      Select emp).ToList()

        Return retVal

    End Function



    ''' <summary>
    ''' This class is used to define the return type
    ''' for the next function - OrdersAndDetails
    ''' 
    ''' When results are extracted from multiple tables
    ''' you can either return the results as anonymous
    ''' or as a type; this class defines the return
    ''' type used by OrdersAndDetails
    ''' </summary>
    ''' <remarks></remarks>
    Public Class OrdersAndDetailsResult

        Private mCustomerID As String
        Private mOrderDate As Nullable(Of DateTime)
        Private mRequiredDate As Nullable(Of DateTime)
        Private mShipAddress As String
        Private mShipCity As String
        Private mShipCountry As String
        Private mShipZip As String
        Private mShippedTo As String
        Private mOrderID As Integer
        Private mNameOfProduct As String
        Private mQtyPerUnit As String
        Private mPrice As Nullable(Of Decimal)
        Private mQtyOrdered As Int16
        Private mDiscount As Single


        Public Property CustomerID() As String
            Get
                Return mCustomerID
            End Get
            Set(ByVal value As String)
                mCustomerID = value
            End Set
        End Property


        Public Property OrderDate() As Nullable(Of DateTime)
            Get
                Return mOrderDate
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                mOrderDate = value
            End Set
        End Property


        Public Property RequiredDate() As Nullable(Of DateTime)
            Get
                Return mRequiredDate
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                mRequiredDate = value
            End Set
        End Property


        Public Property ShipAddress() As String
            Get
                Return mShipAddress
            End Get
            Set(ByVal value As String)
                mShipAddress = value
            End Set
        End Property


        Public Property ShipCity() As String
            Get
                Return mShipCity
            End Get
            Set(ByVal value As String)
                mShipCity = value
            End Set
        End Property

        Public Property ShipCountry() As String
            Get
                Return mShipCountry
            End Get
            Set(ByVal value As String)
                mShipCountry = value
            End Set
        End Property


        Public Property ShipZip() As String
            Get
                Return mShipZip
            End Get
            Set(ByVal value As String)
                mShipZip = value
            End Set
        End Property


        Public Property ShippedTo() As String
            Get
                Return mShippedTo
            End Get
            Set(ByVal value As String)
                mShippedTo = value
            End Set
        End Property


        Public Property OrderID() As Integer
            Get
                Return mOrderID
            End Get
            Set(ByVal value As Integer)
                mOrderID = value
            End Set
        End Property


        Public Property NameOfProduct() As String
            Get
                Return mNameOfProduct
            End Get
            Set(ByVal value As String)
                mNameOfProduct = value
            End Set
        End Property


        Public Property QtyPerUnit() As String
            Get
                Return mQtyPerUnit
            End Get
            Set(ByVal value As String)
                mQtyPerUnit = value
            End Set
        End Property


        Public Property Price() As Nullable(Of Decimal)
            Get
                Return mPrice
            End Get
            Set(ByVal value As Nullable(Of Decimal))
                mPrice = value
            End Set
        End Property


        Public Property QtyOrdered() As Int16
            Get
                Return mQtyOrdered
            End Get
            Set(ByVal value As Int16)
                mQtyOrdered = value
            End Set
        End Property


        Public Property Discount() As Single
            Get
                Return mDiscount
            End Get
            Set(ByVal value As Single)
                mDiscount = value
            End Set
        End Property


    End Class



    ''' <summary>
    ''' Example:  Joins
    ''' Joining using the join keyword
    ''' 
    ''' The values are set to each of the
    ''' properties contained in the 
    ''' OrdersAndDetailsResult class
    ''' 
    ''' The value returned is converted
    ''' to a list of the specified type
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function OrdersAndDetails() As List(Of OrdersAndDetailsResult)

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' join Orders on Order_Details, order the list
        ' by CustomerID and select the results into a new
        ' instance of OrdersAndDetailsResults, return the
        ' collection as a list of that type
        Dim rtnVal = (From ords In dc.GetTable(Of Order)() _
                      Join dets In dc.GetTable(Of Order_Detail)() _
                      On ords.OrderID Equals dets.OrderID _
                      Order By ords.CustomerID Ascending _
                      Select New OrdersAndDetailsResult With { _
                        .CustomerID = ords.CustomerID, _
                        .OrderDate = ords.OrderDate, _
                        .RequiredDate = ords.RequiredDate, _
                        .ShipAddress = ords.ShipAddress, _
                        .ShipCity = ords.ShipCity, _
                        .ShipCountry = ords.ShipCountry, _
                        .ShipZip = ords.ShipPostalCode, _
                        .ShippedTo = ords.ShipName, _
                        .OrderID = ords.OrderID, _
                        .NameOfProduct = dets.Product.ProductName, _
                        .QtyPerUnit = dets.Product.QuantityPerUnit, _
                        .Price = dets.UnitPrice, _
                        .QtyOrdered = dets.Quantity, _
                        .Discount = dets.Discount}).ToList()

        Return rtnVal

    End Function



    ''' <summary>
    ''' Defined to support following function:
    ''' GetOrderAndPricingInformation - this class
    ''' supplies the return type for that function
    ''' </summary>
    ''' <remarks></remarks>
    Public Class OrderAndPricingResult

        Private mOrderID As Int32
        Private mCompany As String
        Private mOrderCountry As String
        Private mProductName As String
        Private mUnitPrice As Nullable(Of Decimal)
        Private mUnitsOrder As Int16
        Private mShipperName As String
        Private mSalesFirstName As String
        Private mSalesLastName As String
        Private mSalesTitle As String


        Public Property OrderID() As Int32
            Get
                Return mOrderID
            End Get
            Set(ByVal value As Int32)
                mOrderID = value
            End Set
        End Property


        Public Property Company() As String
            Get
                Return mCompany
            End Get
            Set(ByVal value As String)
                mCompany = value
            End Set
        End Property


        Public Property OrderCountry() As String
            Get
                Return mOrderCountry
            End Get
            Set(ByVal value As String)
                mOrderCountry = value
            End Set
        End Property


        Public Property ProductName() As String
            Get
                Return mProductName
            End Get
            Set(ByVal value As String)
                mProductName = value
            End Set
        End Property


        Public Property UnitPrice() As Nullable(Of Decimal)
            Get
                Return mUnitPrice
            End Get
            Set(ByVal value As Nullable(Of Decimal))
                mUnitPrice = value
            End Set
        End Property


        Public Property UnitsOrder() As Int16
            Get
                Return mUnitsOrder
            End Get
            Set(ByVal value As Int16)
                mUnitsOrder = value
            End Set
        End Property


        Public Property ShipperName() As String
            Get
                Return mShipperName
            End Get
            Set(ByVal value As String)
                mShipperName = value
            End Set
        End Property


        Public Property SalesFirstName() As String
            Get
                Return mSalesFirstName
            End Get
            Set(ByVal value As String)
                mSalesFirstName = value
            End Set
        End Property


        Public Property SalesLastName() As String
            Get
                Return mSalesLastName
            End Get
            Set(ByVal value As String)
                mSalesLastName = value
            End Set
        End Property


        Public Property SalesTitle() As String
            Get
                Return mSalesTitle
            End Get
            Set(ByVal value As String)
                mSalesTitle = value
            End Set
        End Property

    End Class



    ''' <summary>
    ''' Example:  Query across an entity ref
    ''' This example collections information from the orders table
    ''' and the order_details table through the orders table
    ''' entity association to the orders_details table.  
    ''' 
    ''' An entity is a representation in the model of a table
    ''' in the database, foreign key relationships are maintained
    ''' as entity references to the related tables in the model.
    ''' It is possible to query across tables through this
    ''' relationship in LINQ to SQL
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderAndPricingInformation() As List(Of OrderAndPricingResult)

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' select values from the Orders and Order_Details
        ' tables into a new instance of OrderAndPricingResult
        ' and return the collection as a list of that type
        Dim rtnVal = (From ords In dc.Orders _
                      From dets In ords.Order_Details _
                      Select New OrderAndPricingResult With { _
                      .OrderID = ords.OrderID, _
                      .Company = ords.Customer.CompanyName, _
                      .OrderCountry = ords.Customer.Country, _
                      .ProductName = dets.Product.ProductName, _
                      .UnitPrice = dets.Product.UnitPrice, _
                      .UnitsOrder = dets.Quantity, _
                      .ShipperName = ords.Shipper.CompanyName, _
                      .SalesFirstName = ords.Employee.FirstName, _
                      .SalesLastName = ords.Employee.LastName, _
                      .SalesTitle = ords.Employee.Title}).ToList()

        Return rtnVal

    End Function



    ''' <summary>
    ''' Example:  Query across entity ref with Where class
    ''' Same as previous function with added where clause
    ''' 
    ''' An entity is a representation in the model of a table
    ''' in the database, foreign key relationships are maintained
    ''' as entity references to the related tables in the model.
    ''' It is possible to query across tables through this
    ''' relationship in LINQ to SQL
    ''' </summary>
    ''' <param name="ordId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderAndPricingInformationByOrderId(ByVal ordId As Integer) As List(Of OrderAndPricingResult)

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' select values from the Orders and Order_Details
        ' tables into a new instance of OrderAndPricingResult
        ' and then return the collection as a list of
        ' that type
        Dim rtnVal = (From ords In dc.Orders _
                      From dets In ords.Order_Details _
                      Where ords.OrderID = ordId _
                      Select New OrderAndPricingResult With { _
                      .OrderID = ords.OrderID, _
                      .Company = ords.Customer.CompanyName, _
                      .OrderCountry = ords.Customer.Country, _
                      .ProductName = dets.Product.ProductName, _
                      .UnitPrice = dets.Product.UnitPrice, _
                      .UnitsOrder = dets.Quantity, _
                      .ShipperName = ords.Shipper.CompanyName, _
                      .SalesFirstName = ords.Employee.FirstName, _
                      .SalesLastName = ords.Employee.LastName, _
                      .SalesTitle = ords.Employee.Title}).ToList()

        Return rtnVal

    End Function



    ''' <summary>
    ''' Example:  Aggregation
    ''' 
    ''' Returns the total sum of the order 
    ''' selected by order ID by selecting
    ''' unit price multiplied by quantity
    ''' ordered and then calling sum for 
    ''' the total
    ''' </summary>
    ''' <param name="orderId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetOrderValueByOrderId(ByVal orderId As Integer) As Decimal?

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' get the order with a matching order ID and then
        ' multiply the unit price by the quantity, when
        ' all matching order items have been calculated
        ' individually into a collection, sum the total of 
        ' that collection and return the value
        Dim rtnVal = (From od In dc.GetTable(Of Order_Detail)() _
                      Where od.OrderID = orderId _
                      Select (od.Product.UnitPrice * od.Quantity)).Sum()

        Return rtnVal

    End Function



    ''' <summary>
    ''' Example:  Using Take to get a limited
    ''' number of returned values for display and 
    ''' using Skip to sequence to a different 
    ''' starting point within the returned values -
    ''' can be used to navigate through a large
    ''' list
    ''' </summary>
    ''' <param name="SkipNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetTopFiveOrdersById(ByVal SkipNumber As Integer)

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' order the table by Order ID
        ' and then skip down the SkipNumber of records and
        ' take the next file records, covert that to 
        ' a list and return it
        Dim rtnVal = (From ord In dc.GetTable(Of Order)() _
                      Order By ord.OrderID Ascending _
                      Select ord).Skip(SkipNumber).Take(5).ToList()

        Return rtnVal

    End Function


#End Region



#Region "Insert Update Delete"


    ' This sections contains examples of
    ' inserting, updating, and deleting data

    ''' <summary>
    ''' Insert a customer if the customer does not exist, or
    ''' update the customer if it does exist
    ''' </summary>
    ''' <param name="customerId"></param>
    ''' <param name="companyName"></param>
    ''' <param name="contactName"></param>
    ''' <param name="contactTitle"></param>
    ''' <param name="address"></param>
    ''' <param name="city"></param>
    ''' <param name="region"></param>
    ''' <param name="postalCode"></param>
    ''' <param name="country"></param>
    ''' <param name="phone"></param>
    ''' <param name="fax"></param>
    ''' <remarks></remarks>
    Public Shared Sub InsertOrUpdateCustomer(ByVal customerId As String, _
                                             ByVal companyName As String, _
                                             ByVal contactName As String, _
                                             ByVal contactTitle As String, _
                                             ByVal address As String, _
                                             ByVal city As String, _
                                             ByVal region As String, _
                                             ByVal postalCode As String, _
                                             ByVal country As String, _
                                             ByVal phone As String, _
                                             ByVal fax As String)

        Dim dc As New NorthwindDataClassesDataContext()

        ' Look for an existing customer with the
        ' customer ID
        Dim matchedCustomer = (From c In dc.GetTable(Of Customer)() _
                               Where c.CustomerID = customerId _
                               Select c).SingleOrDefault()

        If (matchedCustomer Is Nothing) Then

            ' there was not matching customer
            Try
                ' create a new customer record since the customer ID
                ' does not exist
                Dim customers As Table(Of Customer) = Accessor.GetCustomerTable()

                Dim cust As New Customer With { _
                .CustomerID = customerId, _
                .CompanyName = companyName, _
                .ContactName = contactName, _
                .ContactTitle = contactTitle, _
                .Address = address, _
                .City = city, _
                .Region = region, _
                .PostalCode = postalCode, _
                .Country = country, _
                .Phone = phone, _
                .Fax = fax}

                ' add the new customer to the database
                customers.InsertOnSubmit(cust)
                customers.Context.SubmitChanges()

            Catch ex As Exception
                Throw ex
            End Try

        Else
            ' the customer already exists, so update
            ' the customer with new information
            Try
                matchedCustomer.CompanyName = companyName
                matchedCustomer.ContactName = contactName
                matchedCustomer.ContactTitle = contactTitle
                matchedCustomer.Address = address
                matchedCustomer.City = city
                matchedCustomer.Region = region
                matchedCustomer.PostalCode = postalCode
                matchedCustomer.Country = country
                matchedCustomer.Phone = phone
                matchedCustomer.Fax = fax

                ' submit the changes to the database
                dc.SubmitChanges()

            Catch ex As Exception
                Throw ex
            End Try

        End If

    End Sub




    ''' <summary>
    ''' Delete a customer by customer ID
    ''' </summary>
    ''' <param name="customerID"></param>
    ''' <remarks></remarks>
    Public Shared Sub DeleteCustomer(ByVal customerID As String)

        ' get the data context
        Dim dc As New NorthwindDataClassesDataContext()

        ' find the customer with a matching customer ID
        Dim matchedCustomer = (From c In dc.GetTable(Of Customer)() _
                               Where c.CustomerID = customerID _
                               Select c).SingleOrDefault()

        Try
            ' delete the matching customer
            dc.Customers.DeleteOnSubmit(matchedCustomer)
            dc.SubmitChanges()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region



#Region "Stored Prodedures"


    ''' <summary>
    ''' Stored Procedure:  Sales By Year
    ''' </summary>
    ''' <param name="beginningDate"></param>
    ''' <param name="endingDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function SalesByYear(ByVal beginningDate As DateTime?, ByVal endingDate As DateTime?) _
    As List(Of Sales_by_YearResult)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.Sales_by_Year(beginningDate, endingDate).ToList()

    End Function



    ''' <summary>
    ''' Stored Procedure:  Ten Most Expenisve Products
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TenMostExpensiveProducts() As List(Of Ten_Most_Expensive_ProductsResult)

        Dim dc As New NorthwindDataClassesDataContext()
        Return dc.Ten_Most_Expensive_Products().ToList()

    End Function


#End Region



End Class
