<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Sales_Currency.aspx.vb" Inherits="Sales_Currency" %>
    
<%@ Register assembly="BrainWork.Utils.Web" namespace="BrainWork.Utils.Web.WebControls" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <cc1:CustomTextBox 
        ID="_CurrencyCode"
        runat="server" 
        PropertyName="CurrencyCode" 
        EntityClassContainer="EntCurrency" 
        FieldName="CurrencyCode" 
        FieldDescription="Clustered index created by a primary key constraint. - The ISO code for the Currency." 
        FieldType="PrimaryKey" 
        ForeingTable="Currency" 
        MainTable="[Sales].[Currency]" 
        DbType="String" 
 
        ParameterName="CurrencyCode" 
        SourceColumn="CurrencyCode" 
 
        Precision="0" 
        Scale="0" 
        Size="3" 
        ForeingCRUD="ABM_Currency" 
        Order="1" 
        RelationType="TextBox" 
        Visibility="Normal" 
        TypeName="String" 
        MaxValue="3" 
        MinValue="0" 
        IsDescription="False" 
        IsDefaultOrderBy="True" 
        IsEnableField="False" 
    />
    <cc1:CustomTextBox 
        ID="_ModifiedDate"
        runat="server" 
        PropertyName="ModifiedDate" 
        EntityClassContainer="EntSales_Currency" 
        FieldName="ModifiedDate" 
        FieldDescription="Date and time the record was last updated." 
        FieldType="Field" 
        DefaultValue="(getdate())" 
        MainTable="[Sales].[Currency]" 
        DbType="DateTime" 
 
        ParameterName="ModifiedDate" 
        SourceColumn="ModifiedDate" 
 
        Precision="0" 
        Scale="0" 
        Size="0" 
        Order="3" 
        RelationType="TextBox" 
        Visibility="Normal" 
        TypeName="DateTime" 
        MaxValue="0" 
        MinValue="0" 
        IsDescription="False" 
        IsDefaultOrderBy="False" 
        IsEnableField="False" 
    />
    <cc1:CustomTextBox 
        ID="_Name"
        runat="server" 
        PropertyName="Name" 
        EntityClassContainer="EntSales_Currency" 
        FieldName="Name" 
        FieldDescription="Currency name. - Unique nonclustered index." 
        FieldType="Field" 
        MainTable="[Sales].[Currency]" 
        DbType="String" 
 
        ParameterName="Name" 
        SourceColumn="Name" 
 
        Precision="0" 
        Scale="0" 
        Size="50" 
        Order="2" 
        RelationType="TextBox" 
        Visibility="Normal" 
        TypeName="String" 
        MaxValue="50" 
        MinValue="0" 
        IsDescription="False" 
        IsDefaultOrderBy="False" 
        IsEnableField="False" 
    />

       
    
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Agregar" />

       
    
    </div>
    </form>
</body>
</html>
