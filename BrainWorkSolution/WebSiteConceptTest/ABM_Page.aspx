<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ABM_Page.aspx.vb" Inherits="ABM_Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
     
    <div>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
               <table id="SearchTable" runat="server" width="100%">
                   <tr>
                       <td>col 1</td>
                       <td>col 2<asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                       <asp:ModalPopupExtender ID="MPE" runat="server"
    TargetControlID="LinkButton1"
    PopupControlID="Panel1"
    BackgroundCssClass="modalBackground" 
    DropShadow="true" 
    OkControlID="OkButton" 
    OnOkScript="onOk()"
    CancelControlID="CancelButton" 
    PopupDragHandleControlID="Panel2" />
                       </td>
                   </tr>
               </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
            <asp:Button ID="OkButton" runat="server" Text="OkButton" />
            <asp:Button ID="CancelButton"
                runat="server" Text="CancelButton" />
        </asp:Panel>
    
        <br />
    
    </div>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            Cargando....
        </ProgressTemplate>
    </asp:UpdateProgress>
    </form>
</body>
</html>
