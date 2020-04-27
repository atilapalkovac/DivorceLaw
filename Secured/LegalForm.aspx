<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LegalForm.aspx.cs" Inherits="DivorceLaw.Secured.LegalForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p>
    <asp:Table ID="Table1" class="table table-hover"
            runat="server" 
            Width="1050" 
            Font-Names="Palatino"
            BorderColor="DarkRed"
            BorderWidth="2"
            CellPadding="5"
            CellSpacing="5"
            >
            <asp:TableHeaderRow 
                runat="server" 
                Font-Bold="true"
                >
                <asp:TableHeaderCell>Exhibit A</asp:TableHeaderCell>
                <asp:TableHeaderCell>Description</asp:TableHeaderCell>
                <asp:TableHeaderCell>Text</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow 
                ID="TableRow1" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>In the chancery court of</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow2" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Plaintiff</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow3" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Cause number</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow4" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Defendant</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_4" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

         <asp:TableFooterRow 
                runat="server" 
                >
                <asp:TableCell 
                    ColumnSpan="4" 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="Button1" OnClick= "Save_LF_A_1"  runat="server" Text="Save data" />
                </asp:TableCell>
                <asp:TableCell 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="Button2" OnClick= "Print_LF_A_1"  runat="server" Text="Create PDF" />
                </asp:TableCell>

            </asp:TableFooterRow>
        </asp:Table>



        <asp:Table ID="Table2" class="table table-hover"
            runat="server" 
            Width="1050" 
            Font-Names="Palatino"
            BorderColor="DarkRed"
            BorderWidth="2"
            CellPadding="5"
            CellSpacing="5"
            >
            <asp:TableHeaderRow 
                runat="server" 
                Font-Bold="true"
                >
                <asp:TableHeaderCell>General information</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableHeaderRow>

            <asp:TableRow 
                ID="TableRow6" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Name:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow7" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Address:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow8" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>City, State and ZIP Code:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow9" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Home Telephone:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtHome_Phone" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow10" 
                runat="server" 
                >
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
                runat="server" 
                >
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
                runat="server" 
                >
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
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Employer's Address:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmployer_Adress" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow14" 
                runat="server" 
                >
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
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Minor children</asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow15" 
                runat="server" 
                >
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
                runat="server" 
                >
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
                runat="server" 
                >
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
                runat="server" 
                >
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
                runat="server" 
                >
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
                runat="server" 
                >
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


            <asp:TableFooterRow 
                runat="server" 
                >
                <asp:TableCell 
                    ColumnSpan="4" 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="btn_SaveLF_A_1" OnClick= "Save_LF_A_1"  runat="server" Text="Save data" />
                </asp:TableCell>
                <asp:TableCell 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="btn_Create_PDF" OnClick= "Print_LF_A_1"  runat="server" Text="Create PDF" />
                </asp:TableCell>

            </asp:TableFooterRow>
        </asp:Table>


        <asp:Table ID="Table3" class="table table-hover"
            runat="server" 
            Width="1050" 
            Font-Names="Palatino"
            BorderColor="DarkRed"
            BorderWidth="2"
            CellPadding="5"
            CellSpacing="5"
            >
            <asp:TableHeaderRow 
                runat="server" 
                Font-Bold="true"
                >
                <asp:TableHeaderCell>Income statement</asp:TableHeaderCell>
                <asp:TableHeaderCell>Gross monthly income</asp:TableHeaderCell>
                <asp:TableHeaderCell>Amount</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableHeaderRow>

            <asp:TableRow 
                ID="TableRow5" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>1. Salary and Wages, including commissions bonuses,
                                allowance and overtime NOTE: To arrive at a monthly
                                income figure if paid weekly, multiply weekly income by
                                4.3, if paid biweekly, multiply income by 2.16:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow22" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>2. Pensions and retirements</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_2" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow23" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>3. Social Security</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_3" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow24" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>4. Disability and unemployment insurance</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_4" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow25" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>5. Public Assistance (welfare, AFDC payments, etc.):</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_5" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow26" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>6. Dividends and interest</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_6" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow27" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>7. Rental Income</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_7" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow28" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>8. Other Income</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_8" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow29" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>9. Total Monthly Income</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_9" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow30" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Itemized Monthly Deductions:</asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>


            <asp:TableRow 
                ID="TableRow31" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>1. State Income Tax</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_10" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow32" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>2. Federal Income Tax</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_11" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow33" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>3. Social Security</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_12" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow34" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>4. Mandatory Insurance</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_13" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow35" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>5. Mandatory Retirement</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_14" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow36" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>6. Union or other dues</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_15" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow37" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>7. Other: (Specify)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_16" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow38" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>8. Other:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_17" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow39" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>9. Total Monthly Deductions</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_18" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow40" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>10. Number of exemptions</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_19" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow41" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>11. Net monthly pay</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_2_20" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableFooterRow 
                runat="server" 
                >
                <asp:TableCell 
                    ColumnSpan="2" 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="Button3" OnClick= "Save_LF_A_1"  runat="server" Text="Save data" />
                </asp:TableCell>
                <asp:TableCell 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="Button4" OnClick= "Print_LF_A_1"  runat="server" Text="Create PDF" />
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableFooterRow>
        </asp:Table>


        <asp:Table ID="Table4" class="table table-hover"
            runat="server" 
            Width="1050" 
            Font-Names="Palatino"
            BorderColor="DarkRed"
            BorderWidth="2"
            CellPadding="5"
            CellSpacing="5"
            >
            <asp:TableHeaderRow 
                runat="server" 
                Font-Bold="true"
                >
                <asp:TableHeaderCell>Expenses statement</asp:TableHeaderCell>
                <asp:TableHeaderCell>A. Living Expense</asp:TableHeaderCell>
                <asp:TableHeaderCell>Self</asp:TableHeaderCell>
                <asp:TableHeaderCell>Children</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableHeaderRow>

            <asp:TableRow 
                ID="TableRow42" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>1. Rent/Mortgage (Residence)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_1_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_1_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
                        <asp:TableRow 
                ID="TableRow43" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>2. Real Property Taxes</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_2_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_2_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow44" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>3. Real Property Insurance</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_3_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_3_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow45" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>4. Maintenance (Residence)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_4_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_4_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow46" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>5. Foood/household Supplies</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_5_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_5_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow47" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>6. Water, Sewer, Etc</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_6_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_6_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow48" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>7. Electricity</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_7_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_7_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow49" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>8. Gas (Residence)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_8_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_8_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow50" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>9. Telephone</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_9_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_9_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow51" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>10. Laundry and Cleaning</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_10_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_10_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow52" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>11. Clothing</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_11_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_11_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow53" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>12. Insurance (Not Payroll Deducted)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_12_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_12_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow54" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>13. Medical</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_13_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_13_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow55" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>14. Dental</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_14_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_14_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow56" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>15. Child Care</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_15_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_15_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow57" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>16. Children’s Allowance</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_16_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_16_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow58" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>17. Payment of child Support/alimony (Prior Marriage)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_17_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_17_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow59" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>18. School Expenses</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_18_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_18_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow60" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>19. Entertainment</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_19_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_19_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow61" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>20. Incidentals & Misc.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_20_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_20_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow62" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>21. Transportation Other than Vehicle</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_21_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_21_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow63" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>22. Gasoline & Oil (Auto)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_22_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_22_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow64" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>23. Repair (Auto)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_23_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_23_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow65" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>24. Insurance (Auto)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_24_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_24_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow66" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>25. Auto Payments</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_25_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_25_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow67" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>26. Church Donations</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_26_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_26_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow68" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>27. Charitable Donations</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_27_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_27_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow69" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>28. Newspaper/magazine</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_28_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_28_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow70" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>29. Cable tv</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_29_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_29_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow71" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>30. Rent/Mortgage (Residence)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_30_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_30_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow72" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>31. Yard Expenses</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_31_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_31_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow73" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>32. Maid</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_32_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_32_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow74" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>33. Retirement (Ira, Etc)</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_33_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_33_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow75" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>34. Pest Control</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_34_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_34_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow76" 
                font-bold="true"
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>B. Total Living Expenses</asp:TableCell>
                <asp:TableCell>
                </asp:TableCell>
                <asp:TableHeaderCell>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow77" 
                font-bold="true"
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>35. Installment Payments</asp:TableCell>
                <asp:TableCell>Self</asp:TableCell>
                <asp:TableHeaderCell>Children</asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow78" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Notes, Loans, Charge Accounts, Etc.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_35_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_35_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>


            <asp:TableRow 
                ID="TableRow79" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>36.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_36_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_36_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow80" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>37.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_37_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_37_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow81" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>38.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_38_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_38_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>


            <asp:TableRow 
                ID="TableRow82" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>39. Other Expenses</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_39_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_39_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow83" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>40.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_40_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_40_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow84" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>41.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_41_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_41_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow85" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>42.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_42_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_42_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>
            <asp:TableRow 
                ID="TableRow86" 
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>43.</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_43_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_43_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow87" 
                font-bold="true"
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Total Installment Payments:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_44_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_44_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow 
                ID="TableRow88" 
                font-bold="true"
                runat="server" 
                >
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Combined Total Expenses: Total Line 1-43</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtF_3_45_1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableHeaderCell>
                    <asp:TextBox ID="txtF_3_45_2" runat="server"></asp:TextBox>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableFooterRow 
                runat="server" 
                >
                <asp:TableCell 
                    ColumnSpan="2" 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="Button5" OnClick= "Save_LF_A_1"  runat="server" Text="Save data" />
                </asp:TableCell>
                <asp:TableCell 
                    HorizontalAlign="Right"
                    Font-Italic="true"
                    >
                    <asp:Button ID="Button6" OnClick= "Print_LF_A_1"  runat="server" Text="Create PDF" />
                </asp:TableCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
                <asp:TableHeaderCell></asp:TableHeaderCell>
            </asp:TableFooterRow>
        </asp:Table>


</asp:Content>
