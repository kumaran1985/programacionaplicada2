<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Sales_Currency.aspx.vb" Inherits="Sales_Currency" %>
    
<%@ Register assembly="BrainWork.Utils.Web" namespace="BrainWork.Utils.Web.WebControls" tagprefix="cc1" %>

<%@ Register assembly="BrainWork.Utils.Web" namespace="BrainWork.Utils.Web.ControlTest" tagprefix="cc2" %>

<%@ Register assembly="BrainWork.Utils.Web" namespace="BrainWork.Utils.Web.WebControls.Data" tagprefix="cc3" %>

<%@ Register assembly="BrainWork.Utils.Web" namespace="BrainWork.Utils.Web.Components.CustomControls" tagprefix="cc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript">
    
    
    </script>
    <link href="Styles/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:right ">
    Alta de Monedas
    </div>
    
    <div>
    
        <asp:Panel ID="pnlViewRead" runat="server" Visible="False">
         <div style="width:600px">
    <fieldset>
    <legend>Nombre</legend>
    <table width="95%">
        <tr>
            <td>
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
                    IsEnableField="False" Text="Hola" 
                />
            </td>    
            <td>
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
            </td>
        </tr>
        
        <tr>
            <td>
                 <cc1:CustomTextBox 
                    ID="_Name"
                    runat="server" 
                    PropertyName="Name" 
                    EntityClassContainer="EntSales_Currency" 
                    FieldName="Name" 
                    FieldDescription="Currency name. - Unique nonclustered index." 
                    FieldType="Field" 
                    MainTable="[Sales].[Currency]" 
                    DbType="Int32" 
             
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
            </td>    
            <td>
            </td>
        </tr>
        
        <tr>
            <td>
            </td>    
            <td>
            </td>
        </tr>
        
    </table>
    
    
    
   
    
   
    
    </fieldset>
    </div>
        </asp:Panel>
        <asp:Button ID="btnAdd" runat="server" Text="Agregar" />
    
    </div>
     
            <asp:Panel ID="pnlGrid" runat="server">
                <div>
                    <table width="95%">
                        <tr>
                            <td>
                                Search
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <br />
                                <br />
                                <cc3:GridView ID="GridView1" runat="server">
                                </cc3:GridView>
                                <br />
                                <cc3:SearchControl ID="SearchControl1" runat="server" />
                                <br />
                            </td>
                        </tr>
                    </table>
                </div>
            </asp:Panel>
         
    </form>
</body>
</html>
