<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LegalFormDeafult.aspx.cs" Inherits="DivorceLaw.Secured.LegalFormDeafult" MaintainScrollPositionOnPostback="true" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">


        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }

            return true;
        }

    </script>

    <p></p>
    <a id="lnkRegister" visible="false" runat="server" href="~/Account/Register">
        <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
        Register new User
    </a>
    <p></p>
    <p></p>
    <p>Prepare Rule 8.05 Financial Statement</p>
    <p></p>

    <asp:Table ID="Table2" class="table table-hover"
        runat="server"
        Width="1050"
        Font-Names="Palatino"
        BorderColor="DarkBlue"
        BorderWidth="2"
        CellPadding="5"
        CellSpacing="5">
        <asp:TableHeaderRow
            runat="server"
            Font-Bold="true"
            class="bg-info">
            <asp:TableHeaderCell Width="150">Exhibit A</asp:TableHeaderCell>
            <asp:TableHeaderCell Width="180">Description</asp:TableHeaderCell>
            <asp:TableHeaderCell Width="180">Text</asp:TableHeaderCell>
            <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
            <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
        </asp:TableHeaderRow>

        <asp:TableRow
            ID="TableRow5"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>In the chancery court of</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="txtF_1_1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCounty_SelectedIndexChanged" ToolTip="Company "></asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow
            ID="TableRow6"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>Plaintiff</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_2" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow
            ID="TableRow7"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>Cause number</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_3" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow
            ID="TableRow8"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>Defendant</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_4" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableFooterRow
            runat="server">
            <asp:TableCell
                ColumnSpan="4"
                HorizontalAlign="Right"
                Font-Italic="true">
                <asp:Button ID="btnSaveHeader" OnClick="Save_LF" runat="server" Text="Save data" />
            </asp:TableCell>
            <asp:TableCell
                HorizontalAlign="Right"
                Font-Italic="true">
                <asp:Button ID="Button4" OnClick="Print_LF_A_1" runat="server" Text="Create PDF" />
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>

    <p class="bg-info">Click on the titles bellow to fill details for Exhibit "A".</p>

    <ajaxToolkit:Accordion ID="Accordion1" runat="server" RequireOpenedPane="false" SelectedIndex="-1">
        <Panes>
            <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">General information</abbr>
                </Header>
                <Content>
                    <b><u></u></b>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Table ID="Table1" class="table table-hover"
                                runat="server"
                                Width="1050"
                                Font-Names="Palatino"
                                BorderColor="DarkBlue"
                                BorderWidth="2"
                                CellPadding="5"
                                CellSpacing="5">
                                <asp:TableHeaderRow
                                    runat="server"
                                    Font-Bold="true"
                                    class="bg-info">
                                    <asp:TableHeaderCell Width="150px">General information</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180px"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180px"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180px"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180px"></asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                                <asp:TableRow
                                    ID="TableRow1"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow2"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Address:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow3"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>City, State and ZIP Code:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow9"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Home Telephone:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtHome_Phone" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow10"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Date of Birth:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtDate_Birth" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow11"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Occupation:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtOccupation" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow12"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Employer</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtEmployer" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow13"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Employer's Address:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtEmployer_Adress" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow222"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Employer's City, State and ZIP code:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtEmployer_City" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>


                                <asp:TableRow
                                    ID="TableRow14"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Employer's Telephone:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtEmplyer_Phone" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow21"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Minor children</asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow15"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren1_Name" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>Date of Birth::</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren1_Date" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow16"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren2_Name" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>Date of Birth::</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren2_Date" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow17"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren3_Name" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>Date of Birth::</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren3_Date" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow18"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren4_Name" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>Date of Birth::</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren4_Date" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow19"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren5_Name" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>Date of Birth::</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren5_Date" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow20"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Name:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren6_Name" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>Date of Birth::</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtChildren6_Date" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>


                            </asp:Table>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </Content>
            </ajaxToolkit:AccordionPane>





            <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Income Statement</abbr>
                </Header>
                <Content>
                    <b><u></u></b>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>



                            <asp:Table ID="Table3" class="table table-hover"
                                runat="server"
                                Width="1050"
                                Font-Names="Palatino"
                                BorderColor="DarkBlue"
                                BorderWidth="2"
                                CellPadding="5"
                                CellSpacing="5">
                                <asp:TableHeaderRow
                                    runat="server"
                                    Font-Bold="true"
                                    class="bg-info">
                                    <asp:TableHeaderCell Width="150">Income statement</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180">Gross monthly income</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180">Amount</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                                </asp:TableHeaderRow>

                                <asp:TableRow
                                    ID="TableRow4"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>1. Salary and Wages, including commissions bonuses,allowance and overtime 
                    NOTE: To arrive at a monthly income figure if paid weekly, 
                    multiply weekly income by 4.3, if paid biweekly, 
                    multiply income by 2.16:</asp:TableCell>
                                    <asp:TableCell ID="Cell_F_2_2">
                                        <asp:TextBox ID="txtF_2_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow22"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>2. Pensions and retirements</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow23"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>3. Social Security</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_3" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_3_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow24"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>4. Disability and unemployment insurance</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_4" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_4_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow25"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>5. Public Assistance (welfare, AFDC payments, etc.):</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_5" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_5_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow26"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>6. Dividends and interest</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_6" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_6_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow27"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>7. Rental Income</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_7" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_7_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow28"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>8. Other Income</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_8" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_8_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow29"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>9. Total Monthly Income</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_9" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow30"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Itemized Monthly Deductions:</asp:TableCell>
                                    <asp:TableCell ForeColor="Red">All values is treated as negative</asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow31"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>1. State Income Tax</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_10" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_10_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow32"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>2. Federal Income Tax</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_11" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_11_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow33"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>3. Social Security</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_12" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_12_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow34"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>4. Mandatory Insurance</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_13" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_13_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow35"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>5. Mandatory Retirement</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_14" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_14_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow36"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>6. Union or other dues</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_15" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_15_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow37"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>7. Other: (Specify)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_16" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_16_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow38"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>8. Other:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_17" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_2_17_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow39"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>9. Total Monthly Deductions</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_18" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow40"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>10. Number of exemptions</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:DropDownList ID="txt_F_2_19" runat="server" AutoPostBack="True" ToolTip="Exemption"></asp:DropDownList>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow41"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>11. Net monthly pay</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_2_20" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                               
                            </asp:Table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </Content>
            </ajaxToolkit:AccordionPane>

            <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Expenses Statement</abbr>
                </Header>
                <Content>
                    <b><u></u></b>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:Table ID="Table4" class="table table-hover"
                                runat="server"
                                Width="1050"
                                Font-Names="Palatino"
                                BorderColor="DarkBlue"
                                BorderWidth="2"
                                CellPadding="5"
                                CellSpacing="5">
                                <asp:TableHeaderRow
                                    runat="server"
                                    Font-Bold="true"
                                    class="bg-info">
                                    <asp:TableHeaderCell Width="150">Expenses statement</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180">A. Living Expense</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180">Self</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180">Children</asp:TableHeaderCell>
                                    <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                                </asp:TableHeaderRow>

                                <asp:TableRow
                                    ID="TableRow42"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>1. Rent/Mortgage (Residence)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_1_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_1_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_1_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_1_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow43"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>2. Real Property Taxes</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_2_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_2_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_2_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_2_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow44"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>3. Real Property Insurance</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_3_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_3_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_3_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_3_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableHeaderCell></asp:TableHeaderCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow45"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>4. Maintenance (Residence)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_4_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_4_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_4_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_4_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow46"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>5. Foood/household Supplies</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_5_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_5_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_5_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_5_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow47"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>6. Water, Sewer, Etc</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_6_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_6_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_6_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_6_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow48"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>7. Electricity</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_7_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_7_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_7_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_7_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow49"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>8. Gas (Residence)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_8_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_8_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_8_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_8_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow50"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>9. Telephone</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_9_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_9_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_9_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_9_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow51"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>10. Laundry and Cleaning</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_10_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_10_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_10_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_10_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow52"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>11. Clothing</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_11_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_11_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_11_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_11_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow53"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>12. Insurance (Not Payroll Deducted)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_12_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_12_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_12_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_12_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow54"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>13. Medical</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_13_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_13_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_13_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_13_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow55"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>14. Dental</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_14_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_14_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_14_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_14_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow56"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>15. Child Care</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_15_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_15_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_15_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_15_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow57"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>16. Children’s Allowance</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_16_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_16_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_16_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_16_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow58"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>17. Payment of child Support/alimony (Prior Marriage)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_17_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_17_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_17_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_17_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow59"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>18. School Expenses</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_18_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_18_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_18_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_18_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow60"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>19. Entertainment</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_19_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_19_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_19_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_19_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow61"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>20. Incidentals & Misc.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_20_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_20_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_20_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_20_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow62"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>21. Transportation Other than Vehicle</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_21_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_21_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_21_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_21_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow63"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>22. Gasoline & Oil (Auto)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_22_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_22_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_22_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_22_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow64"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>23. Repair (Auto)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_23_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_23_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_23_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_23_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow65"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>24. Insurance (Auto)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_24_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_24_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_24_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_24_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow66"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>25. Auto Payments</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_25_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_25_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_25_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_25_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow67"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>26. Church Donations</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_26_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_26_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_26_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_26_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow68"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>27. Charitable Donations</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_27_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_27_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_27_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_27_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow69"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>28. Newspaper/magazine</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_28_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_28_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_28_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_28_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow70"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>29. Cable tv</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_29_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_29_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_29_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_29_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow71"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>30. Rent/Mortgage (Residence)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_30_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_30_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_30_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_30_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow72"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>31. Yard Expenses</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_31_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_31_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_31_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_31_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow73"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>32. Maid</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_32_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_32_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_32_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_32_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow74"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>33. Retirement (Ira, Etc)</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_33_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_33_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_33_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_33_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow75"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>34. Pest Control</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_34_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_34_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_34_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_34_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow76"
                                    Font-Bold="true"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>B. Total Living Expenses</asp:TableCell>
                                    <asp:TableCell>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow77"
                                    Font-Bold="true"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>35. Installment Payments</asp:TableCell>
                                    <asp:TableCell>Self</asp:TableCell>
                                    <asp:TableCell>Children</asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow78"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Notes, Loans, Charge Accounts, Etc.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_35_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_35_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_35_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_35_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>


                                <asp:TableRow
                                    ID="TableRow79"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>36.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_36_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_36_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_36_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_36_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow80"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>37.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_37_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_37_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_37_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_37_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow81"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>38.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_38_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_38_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_38_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_38_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>


                                <asp:TableRow
                                    ID="TableRow82"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>39. Other Expenses</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_39_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_39_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_39_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_39_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow83"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>40.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_40_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_40_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_40_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_40_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow84"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>41.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_41_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_41_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_41_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_41_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow85"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>42.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_42_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_42_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_42_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_42_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow86"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>43.</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_43_1" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_43_1_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_43_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_3_43_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow87"
                                    Font-Bold="true"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Total Installment Payments:</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_44_1" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_44_2" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow88"
                                    Font-Bold="true"
                                    runat="server">
                                    <asp:TableCell></asp:TableCell>
                                    <asp:TableCell>Combined Total Expenses: Total Line 1-43</asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_45_1" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_3_45_2" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell></asp:TableCell>
                                </asp:TableRow>

                              
                            </asp:Table>







                        </ContentTemplate>
                    </asp:UpdatePanel>

                </Content>
            </ajaxToolkit:AccordionPane>



        </Panes>

    </ajaxToolkit:Accordion>

    <p>
    </p>


    <asp:Table ID="Table5" class="table table-hover"
        runat="server"
        Width="1050"
        Font-Names="Palatino"
        BorderColor="DarkBlue"
        BorderWidth="2"
        CellPadding="5"
        CellSpacing="5">
        <asp:TableHeaderRow
            runat="server"
            Font-Bold="true"
            class="bg-info">
            <asp:TableHeaderCell>Exhibit B</asp:TableHeaderCell>
            <asp:TableHeaderCell>Statement of Assets</asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>

    <p class="bg-info">Click on the titles bellow to fill details for Exhibit "B".</p>

    <ajaxToolkit:Accordion ID="Accordion2" runat="server" RequireOpenedPane="false" SelectedIndex="-1">
        <Panes>
            <ajaxToolkit:AccordionPane ID="AccordionPane5" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Real Estate</abbr>
                </Header>
                <Content>
                    <b><u></u></b>



                    <asp:Table ID="Table6" class="table table-hover"
                        runat="server"
                        Width="1050"
                        Font-Names="Palatino"
                        BorderColor="DarkBlue"
                        BorderWidth="2"
                        CellPadding="5"
                        CellSpacing="5">
                        <asp:TableHeaderRow
                            runat="server"
                            Font-Bold="true"
                            class="bg-info">
                            <asp:TableHeaderCell Width="150"></asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180">Description</asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180">Text</asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow
                            ID="TableRow89"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>1. Tile in the name of:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow90"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Address:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow91"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow92"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Who paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow93"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>How cost paid:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow94"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Value:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow95"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Mortgage Balance</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow96"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Equity:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow97"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>2. Title in the name of:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow98"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Address:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow99"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_11" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow100"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Who paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_12" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow101"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>How paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_13" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow102"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Value:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_14" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow103"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Mortgage Balance:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_15" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow104"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Equity:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_16" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow105"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>3. Title in the name of:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_17" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow106"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Address:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_18" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow107"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_19" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow108"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Who paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_20" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow109"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>How cost paid:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_21" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow110"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Value:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_22" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow111"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Mortgage Balance:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_23" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow112"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Equity:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_1_24" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                       
                    </asp:Table>


                </Content>
            </ajaxToolkit:AccordionPane>






            <ajaxToolkit:AccordionPane ID="AccordionPane7" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Motor Vehicles</abbr>
                </Header>
                <Content>
                    <b><u></u></b>



                    <asp:Table ID="Table7" class="table table-hover"
                        runat="server"
                        Width="1050"
                        Font-Names="Palatino"
                        BorderColor="DarkBlue"
                        BorderWidth="2"
                        CellPadding="5"
                        CellSpacing="5">
                        <asp:TableHeaderRow
                            runat="server"
                            Font-Bold="true"
                            class="bg-info">
                            <asp:TableHeaderCell Width="150"></asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180">Description</asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180">Text</asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                            <asp:TableHeaderCell Width="180"></asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow
                            ID="TableRow113"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>1. Registered in the name of:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow114"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Year:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow115"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Model:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow116"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Mileage:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow117"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Who paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow118"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>How cost paid:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow119"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Value:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow120"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Loan Balance:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow121"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Equity:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>


                        <asp:TableRow
                            ID="TableRow122"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>2. Registered in the name of:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow123"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Year:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_11" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow124"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Model:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_12" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow125"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Mileage:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_13" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow126"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Who paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_14" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow127"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>How cost paid:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_15" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow128"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Value:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_16" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow129"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Loan Balance:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_17" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow130"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Equity:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_18" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>



                        <asp:TableRow
                            ID="TableRow131"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>3. Registered in the name of:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_19" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow132"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Year:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_20" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow133"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Model:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_21" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow134"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Mileage:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_22" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow135"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Who paid cost:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_23" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow136"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>How cost paid:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_24" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow137"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Value:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_25" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow138"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Loan Balance:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_26" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow139"
                            runat="server">
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell>Equity:</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_2_27" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableRow>



                       
                    </asp:Table>


                </Content>
            </ajaxToolkit:AccordionPane>






            <ajaxToolkit:AccordionPane ID="AccordionPane8" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Other Personal Property</abbr>
                </Header>
                <Content>
                    <b><u></u></b>
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>


                            <asp:Table ID="Table8" class="table table-hover"
                                runat="server"
                                Width="1050"
                                Font-Names="Palatino"
                                BorderColor="DarkBlue"
                                BorderWidth="2"
                                CellPadding="5"
                                CellSpacing="5">
                                <asp:TableHeaderRow
                                    runat="server"
                                    Font-Bold="true"
                                    class="bg-info">
                                    <asp:TableHeaderCell>Property Listing</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Estimated Value</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Property Listing</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Estimated Value</asp:TableHeaderCell>
                                </asp:TableHeaderRow>

                                <asp:TableRow
                                    ID="TableRow140"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_1" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_2" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_2_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_3" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_4" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_4_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow141"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_5" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_6" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_6_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_7" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_8" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_8_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow142"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_9" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_10" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_10_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_11" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_12" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_12_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow143"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_13" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_14" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_14_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_15" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_16" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_16_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow144"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_17" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_18" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_18_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_19" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_20" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_20_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow145"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_21" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_22" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_22_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_23" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_24" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_24_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow146"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_25" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_26" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_26_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_27" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_28" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_28_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow147"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_29" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_30" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_30_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_31" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_32" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_32_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow148"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_33" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_34" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_34_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_35" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_36" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_36_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow149"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_37" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_38" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_38_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_39" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_40" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_40_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow150"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_41" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_42" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_42_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_43" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_44" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_44_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow151"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_45" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_46" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_46_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_47" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_48" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_48_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow152"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_49" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_50" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_50_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_51" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_52" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_52_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow153"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_53" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_54" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_54_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_55" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_56" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_56_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow154"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_57" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_58" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_58_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_59" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_60" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_60_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow155"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_61" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_62" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_62_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_63" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_64" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_64_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow156"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_65" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_66" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_66_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_67" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_68" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_68_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow157"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_69" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_70" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_70_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_71" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_72" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_72_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow158"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_73" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_74" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_74_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_75" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_76" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_76_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow159"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_77" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_78" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_78_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_79" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_80" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_3_80_TextChanged"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow160"
                                    runat="server">
                                    <asp:TableCell>
                                        Total
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_81" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        Total
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_3_82" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>

                                </asp:TableRow>



                               
                            </asp:Table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </Content>
            </ajaxToolkit:AccordionPane>




            <ajaxToolkit:AccordionPane ID="AccordionPane9" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Checking/Savings</abbr>
                </Header>
                <Content>
                    <b><u></u></b>
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>


                            <asp:Table ID="Table9" class="table table-hover"
                                runat="server"
                                Width="1050"
                                Font-Names="Palatino"
                                BorderColor="DarkBlue"
                                BorderWidth="2"
                                CellPadding="5"
                                CellSpacing="5">
                                <asp:TableHeaderRow
                                    runat="server"
                                    Font-Bold="true"
                                    class="bg-info">
                                    <asp:TableHeaderCell>Names of Account</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Bank Name</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Account Number</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Type of Account</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Balance</asp:TableHeaderCell>
                                </asp:TableHeaderRow>

                                <asp:TableRow
                                    ID="TableRow161"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_1" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_2" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_3" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_4" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_5" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_5_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow162"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_6" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_7" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_8" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_9" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_10" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_10_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow163"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_11" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_12" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_13" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_14" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_15" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_15_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow164"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_16" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_17" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_18" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_19" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_20" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_20_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow165"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_21" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_22" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_23" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_24" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_25" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_25_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow166"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_26" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_27" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_28" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_29" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_30" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_30_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow167"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_31" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_32" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_33" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_34" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_35" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_35_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow168"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_36" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_37" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_38" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_39" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_40" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_40_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow169"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_41" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_42" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_43" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_44" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_45" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_45_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow
                                    ID="TableRow170"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_46" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_47" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_48" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_49" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_50" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_50_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow171"
                                    runat="server">
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_51" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_52" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_53" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_54" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_55" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_4_55_TextChanged"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow
                                    ID="TableRow172"
                                    runat="server">
                                    <asp:TableCell>
                    **********
                                    </asp:TableCell>
                                    <asp:TableCell>
                    **********
                                    </asp:TableCell>
                                    <asp:TableCell>
                    **********
                                    </asp:TableCell>
                                    <asp:TableCell>
                    Total
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtF_4_4_56" runat="server" ReadOnly="true"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>



                                
                            </asp:Table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </Content>
            </ajaxToolkit:AccordionPane>


            <ajaxToolkit:AccordionPane ID="AccordionPane10" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Other Investments (IRA'S, Stock(s), mutual funds, pension plans, etc.</abbr>
                </Header>
                <Content>
                    <b><u></u></b>



                    <asp:Table ID="Table10" class="table table-hover"
                        runat="server"
                        Width="1050"
                        Font-Names="Palatino"
                        BorderColor="DarkBlue"
                        BorderWidth="2"
                        CellPadding="5"
                        CellSpacing="5">
                        <asp:TableHeaderRow
                            runat="server"
                            Font-Bold="true"
                            class="bg-info">
                            <asp:TableHeaderCell>Bank/Account No:</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Type of Investment</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Balance</asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow
                            ID="TableRow173"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_3" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_3_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow174"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_6" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_6_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow175"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_9" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_9_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow176"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_11" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_12" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_12_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow177"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_13" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_14" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_15" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_15_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow178"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_16" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_17" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_18" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_18_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow179"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_19" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_20" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_21" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_21_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow180"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_22" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_23" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_24" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_24_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow181"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_25" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_26" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_27" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_27_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow182"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_28" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_29" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_30" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_5_30_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow183"
                            runat="server">
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                            <asp:TableCell>
                    Total
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_5_31" runat="server" ReadOnly="true"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>



                      
                    </asp:Table>

                </Content>
            </ajaxToolkit:AccordionPane>




            <ajaxToolkit:AccordionPane ID="AccordionPane11" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Life Insurance (Exclude children)</abbr>
                </Header>
                <Content>
                    <b><u></u></b>



                    <asp:Table ID="Table11" class="table table-hover"
                        runat="server"
                        Width="1050"
                        Font-Names="Palatino"
                        BorderColor="DarkBlue"
                        BorderWidth="2"
                        CellPadding="5"
                        CellSpacing="5">
                        <asp:TableHeaderRow
                            runat="server"
                            Font-Bold="true"
                            class="bg-info">
                            <asp:TableHeaderCell>Insured</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Company</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Face amount less any loans</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Cash</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Beneficiary</asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow
                            ID="TableRow184"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_3" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_3_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_4" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_4_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow185"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_8" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_8_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_9" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_9_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow186"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_11" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_12" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_13" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_13_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_14" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_14_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_15" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow187"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_16" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_17" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_18" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_18_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_19" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_19_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_20" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow188"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_21" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_22" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_23" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_23_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_24" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_24_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_25" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow189"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_26" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_27" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_28" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_28_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_29" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_29_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_30" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow190"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_31" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_32" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_33" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_33_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_34" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_34_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_35" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow191"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_36" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_37" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_38" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_38_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_39" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_6_39_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_40" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow192"
                            runat="server">
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                            <asp:TableCell>
                    Total
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_41" runat="server" ReadOnly="true"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_6_42" runat="server" ReadOnly="true"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                        </asp:TableRow>


                       
                    </asp:Table>

                </Content>
            </ajaxToolkit:AccordionPane>


            <ajaxToolkit:AccordionPane ID="AccordionPane12" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">All other Assets</abbr>
                </Header>
                <Content>
                    <b><u></u></b>



                    <asp:Table ID="Table12" class="table table-hover"
                        runat="server"
                        Width="1050"
                        Font-Names="Palatino"
                        BorderColor="DarkBlue"
                        BorderWidth="2"
                        CellPadding="5"
                        CellSpacing="5">
                        <asp:TableHeaderRow
                            runat="server"
                            Font-Bold="true"
                            class="bg-info">
                            <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Date Purchased</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Value(Assets)</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Liens</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Equity</asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow
                            ID="TableRow193"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_5" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow194"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_10" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow195"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_11" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_12" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_13" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_14" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_15" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow196"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_16" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_17" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_18" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_19" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_20" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow197"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_21" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_22" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_23" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_24" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_25" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow198"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_26" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_27" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_28" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_29" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_30" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow199"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_31" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_32" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_33" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_34" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_35" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow200"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_36" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_37" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_38" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_39" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_40" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow202"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_41" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_42" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_43" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_44" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_45" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow203"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_46" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_47" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_48" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_49" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_50" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow204"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_51" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_52" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_53" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_54" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_55" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow205"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_56" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_57" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_58" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_59" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_60" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_4_7_5_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow201"
                            runat="server">
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                            <asp:TableCell>
                    Total
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_4_7_61" runat="server" ReadOnly="true"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>


                       
                    </asp:Table>

                </Content>
            </ajaxToolkit:AccordionPane>

        </Panes>
    </ajaxToolkit:Accordion>


    <ajaxToolkit:Accordion ID="Accordion3" runat="server" RequireOpenedPane="false" SelectedIndex="-1">
        <Panes>
            <ajaxToolkit:AccordionPane ID="AccordionPane4" runat="server">
                <Header>
                    <span class="glyphicon glyphicon-hand-right" aria-hidden="true"></span>
                    <abbr title="Click here to fill details">Statement of Liabilities</abbr>
                </Header>
                <Content>
                    <b>
                        <u>Liabilities</u>
                        <u>(Include mortgages, car loans, credit cards, personal loans.) (Include also under35-44 of EXHIBIT “A” )</u>
                    </b>

                    <asp:Table ID="Table13" class="table table-hover"
                        runat="server"
                        Width="1050"
                        Font-Names="Palatino"
                        BorderColor="DarkBlue"
                        BorderWidth="2"
                        CellPadding="5"
                        CellSpacing="5">
                        <asp:TableHeaderRow
                            runat="server"
                            Font-Bold="true"
                            class="bg-info">
                            <asp:TableHeaderCell>Creditor</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Whose Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Current Balance Due</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Monthly</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Who pays</asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow
                            ID="TableRow206"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_3" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_3_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_4" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_4_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow207"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_8" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_8_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_9" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_9_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow208"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_11" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_12" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_13" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_13_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_14" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_14_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_15" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow209"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_16" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_17" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_18" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_18_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_19" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_19_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_20" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow210"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_21" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_22" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_23" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_23_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_24" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_24_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_25" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow211"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_26" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_27" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_28" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_28_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_29" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_29_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_30" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow212"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_31" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_32" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_33" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_33_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_34" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_34_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_35" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow213"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_36" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_37" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_38" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_38_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_39" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_39_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_40" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow214"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_41" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_42" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_43" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_43_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_44" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_44_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_45" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow215"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_46" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_47" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_48" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_48_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_49" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_49_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_50" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow
                            ID="TableRow216"
                            runat="server">
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_51" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_52" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_53" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_53_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_54" onkeypress="return isNumberKey(event)" runat="server" AutoPostBack="true" onkeydown="return (event.keyCode!=13)" OnTextChanged="txtF_5_54_TextChanged"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_55" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow
                            ID="TableRow218"
                            runat="server">
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                            <asp:TableCell>
                    Total Liabilities
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_56" runat="server" ReadOnly="true"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtF_5_57" runat="server" ReadOnly="true"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>
                    **********
                            </asp:TableCell>
                        </asp:TableRow>


                       
                    </asp:Table>





                </Content>
            </ajaxToolkit:AccordionPane>
        </Panes>
    </ajaxToolkit:Accordion>



    <p></p>
    <asp:Table ID="Table14" class="table table-hover"
        runat="server"
        Width="1050"
        Font-Names="Palatino"
        BorderColor="DarkBlue"
        BorderWidth="2"
        CellPadding="5"
        CellSpacing="5">
        <asp:TableHeaderRow
            runat="server"
            Font-Bold="true"
            class="bg-info">
            <asp:TableHeaderCell>Exhibit C</asp:TableHeaderCell>
            <asp:TableHeaderCell>Description</asp:TableHeaderCell>
            <asp:TableHeaderCell>Text</asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow
            ID="TableRow217"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>In the chancery court of</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_5" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow
            ID="TableRow219"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>Plaintiff</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_6" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow
            ID="TableRow220"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>Civil action number</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_7" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow
            ID="TableRow221"
            runat="server">
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>Defendant</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtF_8" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell></asp:TableHeaderCell>
        </asp:TableRow>
       
    </asp:Table>

    <p>This site is using ©2020 iText7 Community under AGPL license.</p>
    <p>Disclose any modifications made to iText is not legal.</p>
    <p>The source code is downloadable on https://github.com/atilapalkovac/DivorceLaw </p>



</asp:Content>
