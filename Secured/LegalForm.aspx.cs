using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;//
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ListItem = iText.Layout.Element.ListItem;
using Table = iText.Layout.Element.Table;


namespace DivorceLaw.Secured
{
    public partial class LegalForm : System.Web.UI.Page
    {
        private String strConnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public static readonly string DEST = "Secured/simple_table.pdf";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string userName = string.Empty;
                userName = HttpContext.Current.User.Identity.Name;

                string constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("LF_A_1_CRUD", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Action", "SELECT");
                        cmd.Parameters.AddWithValue("@F_1", "");
                        cmd.Parameters.AddWithValue("@F_2", "");
                        cmd.Parameters.AddWithValue("@F_3", "");
                        cmd.Parameters.AddWithValue("@F_4", "");
                        cmd.Parameters.AddWithValue("@Name", "");
                        cmd.Parameters.AddWithValue("@Address", "");
                        cmd.Parameters.AddWithValue("@City", "");
                        cmd.Parameters.AddWithValue("@Home_Phone", "");
                        cmd.Parameters.AddWithValue("@Date_Birth", "");
                        cmd.Parameters.AddWithValue("@Occupation", "");
                        cmd.Parameters.AddWithValue("@Employer", "");
                        cmd.Parameters.AddWithValue("@Employer_Adress", "");
                        cmd.Parameters.AddWithValue("@Employer_Phone", "");
                        cmd.Parameters.AddWithValue("@Children1_Name", "");
                        cmd.Parameters.AddWithValue("@Children1_Date", "");
                        cmd.Parameters.AddWithValue("@Children2_Name", "");
                        cmd.Parameters.AddWithValue("@Children2_Date", "");
                        cmd.Parameters.AddWithValue("@Children3_Name", "");
                        cmd.Parameters.AddWithValue("@Children3_Date", "");
                        cmd.Parameters.AddWithValue("@Children4_Name", "");
                        cmd.Parameters.AddWithValue("@Children4_Date", "");
                        cmd.Parameters.AddWithValue("@Children5_Name", "");
                        cmd.Parameters.AddWithValue("@Children5_Date", "");
                        cmd.Parameters.AddWithValue("@Children6_Name", "");
                        cmd.Parameters.AddWithValue("@Children6_Date", "");
                        cmd.Parameters.AddWithValue("@F_2_1", "");
                        cmd.Parameters.AddWithValue("@F_2_2", "");
                        cmd.Parameters.AddWithValue("@F_2_3", "");
                        cmd.Parameters.AddWithValue("@F_2_4", "");
                        cmd.Parameters.AddWithValue("@F_2_5", "");
                        cmd.Parameters.AddWithValue("@F_2_6", "");
                        cmd.Parameters.AddWithValue("@F_2_7", "");
                        cmd.Parameters.AddWithValue("@F_2_8", "");
                        cmd.Parameters.AddWithValue("@F_2_9", "");
                        cmd.Parameters.AddWithValue("@F_2_10", "");
                        cmd.Parameters.AddWithValue("@F_2_11", "");
                        cmd.Parameters.AddWithValue("@F_2_12", "");
                        cmd.Parameters.AddWithValue("@F_2_13", "");
                        cmd.Parameters.AddWithValue("@F_2_14", "");
                        cmd.Parameters.AddWithValue("@F_2_15", "");
                        cmd.Parameters.AddWithValue("@F_2_16", "");
                        cmd.Parameters.AddWithValue("@F_2_17", "");
                        cmd.Parameters.AddWithValue("@F_2_18", "");
                        cmd.Parameters.AddWithValue("@F_2_19", "");
                        cmd.Parameters.AddWithValue("@F_2_20", "");

                        cmd.Parameters.AddWithValue("@F_3_1_1", "");
                        cmd.Parameters.AddWithValue("@F_3_1_2", "");
                        cmd.Parameters.AddWithValue("@F_3_2_1", "");
                        cmd.Parameters.AddWithValue("@F_3_2_2", "");
                        cmd.Parameters.AddWithValue("@F_3_3_1", "");
                        cmd.Parameters.AddWithValue("@F_3_3_2", "");
                        cmd.Parameters.AddWithValue("@F_3_4_1", "");
                        cmd.Parameters.AddWithValue("@F_3_4_2", "");
                        cmd.Parameters.AddWithValue("@F_3_5_1", "");
                        cmd.Parameters.AddWithValue("@F_3_5_2", "");
                        cmd.Parameters.AddWithValue("@F_3_6_1", "");
                        cmd.Parameters.AddWithValue("@F_3_6_2", "");
                        cmd.Parameters.AddWithValue("@F_3_7_1", "");
                        cmd.Parameters.AddWithValue("@F_3_7_2", "");
                        cmd.Parameters.AddWithValue("@F_3_8_1", "");
                        cmd.Parameters.AddWithValue("@F_3_8_2", "");
                        cmd.Parameters.AddWithValue("@F_3_9_1", "");
                        cmd.Parameters.AddWithValue("@F_3_9_2", "");
                        cmd.Parameters.AddWithValue("@F_3_10_1", "");
                        cmd.Parameters.AddWithValue("@F_3_10_2", "");
                        cmd.Parameters.AddWithValue("@F_3_11_1", "");
                        cmd.Parameters.AddWithValue("@F_3_11_2", "");
                        cmd.Parameters.AddWithValue("@F_3_12_1", "");
                        cmd.Parameters.AddWithValue("@F_3_12_2", "");
                        cmd.Parameters.AddWithValue("@F_3_13_1", "");
                        cmd.Parameters.AddWithValue("@F_3_13_2", "");
                        cmd.Parameters.AddWithValue("@F_3_14_1", "");
                        cmd.Parameters.AddWithValue("@F_3_14_2", "");
                        cmd.Parameters.AddWithValue("@F_3_15_1", "");
                        cmd.Parameters.AddWithValue("@F_3_15_2", "");
                        cmd.Parameters.AddWithValue("@F_3_16_1", "");
                        cmd.Parameters.AddWithValue("@F_3_16_2", "");
                        cmd.Parameters.AddWithValue("@F_3_17_1", "");
                        cmd.Parameters.AddWithValue("@F_3_17_2", "");
                        cmd.Parameters.AddWithValue("@F_3_18_1", "");
                        cmd.Parameters.AddWithValue("@F_3_18_2", "");
                        cmd.Parameters.AddWithValue("@F_3_19_1", "");
                        cmd.Parameters.AddWithValue("@F_3_19_2", "");
                        cmd.Parameters.AddWithValue("@F_3_20_1", "");
                        cmd.Parameters.AddWithValue("@F_3_20_2", "");
                        cmd.Parameters.AddWithValue("@F_3_21_1", "");
                        cmd.Parameters.AddWithValue("@F_3_21_2", "");
                        cmd.Parameters.AddWithValue("@F_3_22_1", "");
                        cmd.Parameters.AddWithValue("@F_3_22_2", "");
                        cmd.Parameters.AddWithValue("@F_3_23_1", "");
                        cmd.Parameters.AddWithValue("@F_3_23_2", "");
                        cmd.Parameters.AddWithValue("@F_3_24_1", "");
                        cmd.Parameters.AddWithValue("@F_3_24_2", "");
                        cmd.Parameters.AddWithValue("@F_3_25_1", "");
                        cmd.Parameters.AddWithValue("@F_3_25_2", "");
                        cmd.Parameters.AddWithValue("@F_3_26_1", "");
                        cmd.Parameters.AddWithValue("@F_3_26_2", "");
                        cmd.Parameters.AddWithValue("@F_3_27_1", "");
                        cmd.Parameters.AddWithValue("@F_3_27_2", "");
                        cmd.Parameters.AddWithValue("@F_3_28_1", "");
                        cmd.Parameters.AddWithValue("@F_3_28_2", "");
                        cmd.Parameters.AddWithValue("@F_3_29_1", "");
                        cmd.Parameters.AddWithValue("@F_3_29_2", "");
                        cmd.Parameters.AddWithValue("@F_3_30_1", "");
                        cmd.Parameters.AddWithValue("@F_3_30_2", "");
                        cmd.Parameters.AddWithValue("@F_3_31_1", "");
                        cmd.Parameters.AddWithValue("@F_3_31_2", "");
                        cmd.Parameters.AddWithValue("@F_3_32_1", "");
                        cmd.Parameters.AddWithValue("@F_3_32_2", "");
                        cmd.Parameters.AddWithValue("@F_3_33_1", "");
                        cmd.Parameters.AddWithValue("@F_3_33_2", "");
                        cmd.Parameters.AddWithValue("@F_3_34_1", "");
                        cmd.Parameters.AddWithValue("@F_3_34_2", "");
                        cmd.Parameters.AddWithValue("@F_3_35_1", "");
                        cmd.Parameters.AddWithValue("@F_3_35_2", "");
                        cmd.Parameters.AddWithValue("@F_3_36_1", "");
                        cmd.Parameters.AddWithValue("@F_3_36_2", "");
                        cmd.Parameters.AddWithValue("@F_3_37_1", "");
                        cmd.Parameters.AddWithValue("@F_3_37_2", "");
                        cmd.Parameters.AddWithValue("@F_3_38_1", "");
                        cmd.Parameters.AddWithValue("@F_3_38_2", "");
                        cmd.Parameters.AddWithValue("@F_3_39_1", "");
                        cmd.Parameters.AddWithValue("@F_3_39_2", "");
                        cmd.Parameters.AddWithValue("@F_3_40_1", "");
                        cmd.Parameters.AddWithValue("@F_3_40_2", "");
                        cmd.Parameters.AddWithValue("@F_3_41_1", "");
                        cmd.Parameters.AddWithValue("@F_3_41_2", "");
                        cmd.Parameters.AddWithValue("@F_3_42_1", "");
                        cmd.Parameters.AddWithValue("@F_3_42_2", "");
                        cmd.Parameters.AddWithValue("@F_3_43_1", "");
                        cmd.Parameters.AddWithValue("@F_3_43_2", "");
                        cmd.Parameters.AddWithValue("@F_3_44_1", "");
                        cmd.Parameters.AddWithValue("@F_3_44_2", "");
                        cmd.Parameters.AddWithValue("@F_3_45_1", "");
                        cmd.Parameters.AddWithValue("@F_3_45_2", "");

                        cmd.Parameters.AddWithValue("@UserName", userName);
                        con.Open();


                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            if (sdr.HasRows)
                            {
                                txtF_1.Text = sdr["F_1"].ToString();
                                txtF_2.Text = sdr["F_2"].ToString();
                                txtF_3.Text = sdr["F_3"].ToString();
                                txtF_4.Text = sdr["F_4"].ToString();
                                txtName.Text = sdr["Name"].ToString();
                                txtAdress.Text = sdr["Address"].ToString();
                                txtCity.Text = sdr["City"].ToString();
                                txtHome_Phone.Text = sdr["Home_Phone"].ToString();
                                txtDate_Birth.Text = sdr["Date_Birth"].ToString();
                                txtOccupation.Text = sdr["Occupation"].ToString();
                                txtEmployer.Text = sdr["Employer"].ToString();
                                txtEmployer_Adress.Text = sdr["Employer_Adress"].ToString();
                                txtEmplyer_Phone.Text = sdr["Employer_Phone"].ToString();
                                txtChildren1_Name.Text = sdr["Children1_Name"].ToString();
                                txtChildren1_Date.Text = sdr["Children1_Date"].ToString();
                                txtChildren2_Name.Text = sdr["Children2_Name"].ToString();
                                txtChildren2_Date.Text = sdr["Children2_Date"].ToString();
                                txtChildren3_Name.Text = sdr["Children3_Name"].ToString();
                                txtChildren3_Date.Text = sdr["Children3_Date"].ToString();
                                txtChildren4_Name.Text = sdr["Children4_Name"].ToString();
                                txtChildren4_Date.Text = sdr["Children4_Date"].ToString();
                                txtChildren5_Name.Text = sdr["Children5_Name"].ToString();
                                txtChildren5_Date.Text = sdr["Children5_Date"].ToString();
                                txtChildren6_Name.Text = sdr["Children6_Name"].ToString();
                                txtChildren6_Date.Text = sdr["Children6_Date"].ToString();

                                txtF_2_1.Text = sdr["F_2_1"].ToString();
                                txtF_2_2.Text = sdr["F_2_2"].ToString();
                                txtF_2_3.Text = sdr["F_2_3"].ToString();
                                txtF_2_4.Text = sdr["F_2_4"].ToString();
                                txtF_2_5.Text = sdr["F_2_5"].ToString();
                                txtF_2_6.Text = sdr["F_2_6"].ToString();
                                txtF_2_7.Text = sdr["F_2_7"].ToString();
                                txtF_2_8.Text = sdr["F_2_8"].ToString();
                                txtF_2_9.Text = sdr["F_2_9"].ToString();
                                txtF_2_10.Text = sdr["F_2_10"].ToString();
                                txtF_2_11.Text = sdr["F_2_11"].ToString();
                                txtF_2_12.Text = sdr["F_2_12"].ToString();
                                txtF_2_13.Text = sdr["F_2_13"].ToString();
                                txtF_2_14.Text = sdr["F_2_14"].ToString();
                                txtF_2_15.Text = sdr["F_2_15"].ToString();
                                txtF_2_16.Text = sdr["F_2_16"].ToString();
                                txtF_2_17.Text = sdr["F_2_17"].ToString();
                                txtF_2_18.Text = sdr["F_2_18"].ToString();
                                txtF_2_19.Text = sdr["F_2_19"].ToString();
                                txtF_2_20.Text = sdr["F_2_20"].ToString();

                                txtF_3_1_1.Text = sdr["F_3_1_1"].ToString();
                                txtF_3_1_2.Text = sdr["F_3_1_2"].ToString();
                                txtF_3_2_1.Text = sdr["F_3_2_1"].ToString();
                                txtF_3_2_2.Text = sdr["F_3_2_2"].ToString();
                                txtF_3_3_1.Text = sdr["F_3_3_1"].ToString();
                                txtF_3_3_2.Text = sdr["F_3_3_2"].ToString(); 
                                txtF_3_4_1.Text = sdr["F_3_4_1"].ToString();
                                txtF_3_4_2.Text = sdr["F_3_4_2"].ToString();
                                txtF_3_5_1.Text = sdr["F_3_5_1"].ToString();
                                txtF_3_5_2.Text = sdr["F_3_5_2"].ToString();
                                txtF_3_6_1.Text = sdr["F_3_6_1"].ToString();
                                txtF_3_6_2.Text = sdr["F_3_6_2"].ToString();
                                txtF_3_7_1.Text = sdr["F_3_7_1"].ToString();
                                txtF_3_7_2.Text = sdr["F_3_7_2"].ToString();
                                txtF_3_8_1.Text = sdr["F_3_8_1"].ToString();
                                txtF_3_8_2.Text = sdr["F_3_8_2"].ToString();
                                txtF_3_9_1.Text = sdr["F_3_9_1"].ToString();
                                txtF_3_9_2.Text = sdr["F_3_9_2"].ToString();
                                txtF_3_10_1.Text = sdr["F_3_10_1"].ToString();
                                txtF_3_10_2.Text = sdr["F_3_10_2"].ToString();
                                txtF_3_11_1.Text = sdr["F_3_11_1"].ToString();
                                txtF_3_11_2.Text = sdr["F_3_11_2"].ToString();
                                txtF_3_12_1.Text = sdr["F_3_12_1"].ToString();
                                txtF_3_12_2.Text = sdr["F_3_12_2"].ToString();
                                txtF_3_13_1.Text = sdr["F_3_13_1"].ToString();
                                txtF_3_13_2.Text = sdr["F_3_13_2"].ToString();
                                txtF_3_14_1.Text = sdr["F_3_14_1"].ToString();
                                txtF_3_14_2.Text = sdr["F_3_14_2"].ToString();
                                txtF_3_15_1.Text = sdr["F_3_15_1"].ToString();
                                txtF_3_15_2.Text = sdr["F_3_15_2"].ToString();
                                txtF_3_16_1.Text = sdr["F_3_16_1"].ToString();
                                txtF_3_16_2.Text = sdr["F_3_16_2"].ToString();
                                txtF_3_17_1.Text = sdr["F_3_17_1"].ToString();
                                txtF_3_17_2.Text = sdr["F_3_17_2"].ToString();
                                txtF_3_18_1.Text = sdr["F_3_18_1"].ToString();
                                txtF_3_18_2.Text = sdr["F_3_18_2"].ToString();
                                txtF_3_19_1.Text = sdr["F_3_19_1"].ToString();
                                txtF_3_19_2.Text = sdr["F_3_19_2"].ToString();
                                txtF_3_20_1.Text = sdr["F_3_20_1"].ToString();
                                txtF_3_20_2.Text = sdr["F_3_20_2"].ToString();
                                txtF_3_21_1.Text = sdr["F_3_21_1"].ToString();
                                txtF_3_21_2.Text = sdr["F_3_21_2"].ToString();
                                txtF_3_22_1.Text = sdr["F_3_22_1"].ToString();
                                txtF_3_22_2.Text = sdr["F_3_22_2"].ToString();
                                txtF_3_23_1.Text = sdr["F_3_23_1"].ToString();
                                txtF_3_23_2.Text = sdr["F_3_23_2"].ToString();
                                txtF_3_24_1.Text = sdr["F_3_24_1"].ToString();
                                txtF_3_24_2.Text = sdr["F_3_24_2"].ToString();
                                txtF_3_25_1.Text = sdr["F_3_25_1"].ToString();
                                txtF_3_25_2.Text = sdr["F_3_25_2"].ToString();
                                txtF_3_26_1.Text = sdr["F_3_26_1"].ToString();
                                txtF_3_26_2.Text = sdr["F_3_26_2"].ToString();
                                txtF_3_27_1.Text = sdr["F_3_27_1"].ToString();
                                txtF_3_27_2.Text = sdr["F_3_27_2"].ToString();
                                txtF_3_28_1.Text = sdr["F_3_28_1"].ToString();
                                txtF_3_28_2.Text = sdr["F_3_28_2"].ToString();
                                txtF_3_29_1.Text = sdr["F_3_29_1"].ToString();
                                txtF_3_29_2.Text = sdr["F_3_29_2"].ToString();
                                txtF_3_30_1.Text = sdr["F_3_30_1"].ToString();
                                txtF_3_30_2.Text = sdr["F_3_30_2"].ToString();
                                txtF_3_31_1.Text = sdr["F_3_31_1"].ToString();
                                txtF_3_31_2.Text = sdr["F_3_31_2"].ToString();
                                txtF_3_32_1.Text = sdr["F_3_32_1"].ToString();
                                txtF_3_32_2.Text = sdr["F_3_32_2"].ToString();
                                txtF_3_33_1.Text = sdr["F_3_33_1"].ToString();
                                txtF_3_33_2.Text = sdr["F_3_33_2"].ToString();
                                txtF_3_34_1.Text = sdr["F_3_34_1"].ToString();
                                txtF_3_34_2.Text = sdr["F_3_34_2"].ToString();
                                txtF_3_35_1.Text = sdr["F_3_35_1"].ToString();
                                txtF_3_35_2.Text = sdr["F_3_35_2"].ToString();
                                txtF_3_36_1.Text = sdr["F_3_36_1"].ToString();
                                txtF_3_36_2.Text = sdr["F_3_36_2"].ToString();
                                txtF_3_37_1.Text = sdr["F_3_37_1"].ToString();
                                txtF_3_37_2.Text = sdr["F_3_37_2"].ToString();
                                txtF_3_38_1.Text = sdr["F_3_38_1"].ToString();
                                txtF_3_38_2.Text = sdr["F_3_38_2"].ToString();
                                txtF_3_39_1.Text = sdr["F_3_39_1"].ToString();
                                txtF_3_39_2.Text = sdr["F_3_39_2"].ToString();
                                txtF_3_40_1.Text = sdr["F_3_40_1"].ToString();
                                txtF_3_40_2.Text = sdr["F_3_40_2"].ToString();
                                txtF_3_41_1.Text = sdr["F_3_41_1"].ToString();
                                txtF_3_41_1.Text = sdr["F_3_41_2"].ToString();
                                txtF_3_42_1.Text = sdr["F_3_42_1"].ToString();
                                txtF_3_42_2.Text = sdr["F_3_42_2"].ToString();
                                txtF_3_43_1.Text = sdr["F_3_43_1"].ToString();
                                txtF_3_43_2.Text = sdr["F_3_43_2"].ToString();
                                txtF_3_44_1.Text = sdr["F_3_44_1"].ToString();
                                txtF_3_44_2.Text = sdr["F_3_44_2"].ToString();
                                txtF_3_45_1.Text = sdr["F_3_45_1"].ToString();
                                txtF_3_45_2.Text = sdr["F_3_45_2"].ToString();


                            }
                            else
                            { 
                            }
                        }


                        //IDataReader idr = cmd.ExecuteReader();
                        //txtF_1.Text = idr[0].ToString();
                        //txtF_2.Text = idr[1].ToString();

                        //Repeater1.DataSource = idr;
                        //rptCustomers.DataSource = idr;
                        //Repeater1.DataBind();
                        //rptCustomers.DataBind();
                        //idr.Close();
                        con.Close();
                        //int recordCount = Convert.ToInt32(cmd.Parameters["@RecordCount"].Value);
                        //this.PopulatePager(recordCount, pageIndex);
                    }
                }
                //CalculateSum("BAM");
                //    RepeaterItem item = (sender as ImageButton).Parent as RepeaterItem;
                //(TextBox)(Repeater1.FindControl("txt_amount_FC_BAM")) = CalculateSum("BAM");
                //Repeater1.FindControl("txtDocDate"). = s1.ToString();
                //decimal s1 = CalculateSum("EUR", rblTrade_RP.Text.ToString());
                //decimal s2 = CalculateSum("RUB", rblTrade_RP.Text.ToString());
                //decimal s3 = CalculateSum("USD", rblTrade_RP.Text.ToString());
                //decimal s4 = CalculateSum("RON", rblTrade_RP.Text.ToString());
                //decimal s5 = CalculateSum("BAM", rblTrade_RP.Text.ToString());
                //decimal s6 = CalculateSum("RSD", rblTrade_RP.Text.ToString());
                //lblAmount_Eur.Text = s1.ToString();
                //lblAmount_BAM.Text = s5.ToString();
                //lblAmount_RON.Text = s4.ToString();
                //lblAmount_RUB.Text = s2.ToString();
                //lblAmount_USD.Text = s3.ToString();
                //lblAmount_RSD.Text = s6.ToString();
            }
        }
        protected void Save_LF_A_1(object sender, EventArgs e)

        {



            //string idAgencija = lblIDAgencije.Text;
            //int id = RB;
            //int idTemp = RB + 1;

            //string CoCD = _CoCD.Text.ToString();
            //string CompanyName = _CompanyName.Text.ToString();

            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_A_1_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_1","");
                    cmd.Parameters.AddWithValue("@F_2","");
                    cmd.Parameters.AddWithValue("@F_3", "");
                    cmd.Parameters.AddWithValue("@F_4", "");
                    cmd.Parameters.AddWithValue("@Name", "");
                    cmd.Parameters.AddWithValue("@Address", "");
                    cmd.Parameters.AddWithValue("@City", "");
                    cmd.Parameters.AddWithValue("@Home_Phone", "");
                    cmd.Parameters.AddWithValue("@Date_Birth", "");
                    cmd.Parameters.AddWithValue("@Occupation", "");
                    cmd.Parameters.AddWithValue("@Employer", "");
                    cmd.Parameters.AddWithValue("@Employer_Adress", "");
                    cmd.Parameters.AddWithValue("@Employer_Phone", "");
                    cmd.Parameters.AddWithValue("@Children1_Name", "");
                    cmd.Parameters.AddWithValue("@Children1_Date", "");
                    cmd.Parameters.AddWithValue("@Children2_Name", "");
                    cmd.Parameters.AddWithValue("@Children2_Date", "");
                    cmd.Parameters.AddWithValue("@Children3_Name", "");
                    cmd.Parameters.AddWithValue("@Children3_Date", "");
                    cmd.Parameters.AddWithValue("@Children4_Name", "");
                    cmd.Parameters.AddWithValue("@Children4_Date", "");
                    cmd.Parameters.AddWithValue("@Children5_Name", "");
                    cmd.Parameters.AddWithValue("@Children5_Date", "");
                    cmd.Parameters.AddWithValue("@Children6_Name", "");
                    cmd.Parameters.AddWithValue("@Children6_Date", "");
                    cmd.Parameters.AddWithValue("@F_2_1", "");
                    cmd.Parameters.AddWithValue("@F_2_2", "");
                    cmd.Parameters.AddWithValue("@F_2_3", "");
                    cmd.Parameters.AddWithValue("@F_2_4", "");
                    cmd.Parameters.AddWithValue("@F_2_5", "");
                    cmd.Parameters.AddWithValue("@F_2_6", "");
                    cmd.Parameters.AddWithValue("@F_2_7", "");
                    cmd.Parameters.AddWithValue("@F_2_8", "");
                    cmd.Parameters.AddWithValue("@F_2_9", "");
                    cmd.Parameters.AddWithValue("@F_2_10", "");
                    cmd.Parameters.AddWithValue("@F_2_11", "");
                    cmd.Parameters.AddWithValue("@F_2_12", "");
                    cmd.Parameters.AddWithValue("@F_2_13", "");
                    cmd.Parameters.AddWithValue("@F_2_14", "");
                    cmd.Parameters.AddWithValue("@F_2_15", "");
                    cmd.Parameters.AddWithValue("@F_2_16", "");
                    cmd.Parameters.AddWithValue("@F_2_17", "");
                    cmd.Parameters.AddWithValue("@F_2_18", "");
                    cmd.Parameters.AddWithValue("@F_2_19", "");
                    cmd.Parameters.AddWithValue("@F_2_20", "");

                    cmd.Parameters.AddWithValue("@F_3_1_1", "");
                    cmd.Parameters.AddWithValue("@F_3_1_2", "");
                    cmd.Parameters.AddWithValue("@F_3_2_1", "");
                    cmd.Parameters.AddWithValue("@F_3_2_2", "");
                    cmd.Parameters.AddWithValue("@F_3_3_1", "");
                    cmd.Parameters.AddWithValue("@F_3_3_2", "");
                    cmd.Parameters.AddWithValue("@F_3_4_1", "");
                    cmd.Parameters.AddWithValue("@F_3_4_2", "");
                    cmd.Parameters.AddWithValue("@F_3_5_1", "");
                    cmd.Parameters.AddWithValue("@F_3_5_2", "");
                    cmd.Parameters.AddWithValue("@F_3_6_1", "");
                    cmd.Parameters.AddWithValue("@F_3_6_2", "");
                    cmd.Parameters.AddWithValue("@F_3_7_1", "");
                    cmd.Parameters.AddWithValue("@F_3_7_2", "");
                    cmd.Parameters.AddWithValue("@F_3_8_1", "");
                    cmd.Parameters.AddWithValue("@F_3_8_2", "");
                    cmd.Parameters.AddWithValue("@F_3_9_1", "");
                    cmd.Parameters.AddWithValue("@F_3_9_2", "");
                    cmd.Parameters.AddWithValue("@F_3_10_1", "");
                    cmd.Parameters.AddWithValue("@F_3_10_2", "");
                    cmd.Parameters.AddWithValue("@F_3_11_1", "");
                    cmd.Parameters.AddWithValue("@F_3_11_2", "");
                    cmd.Parameters.AddWithValue("@F_3_12_1", "");
                    cmd.Parameters.AddWithValue("@F_3_12_2", "");
                    cmd.Parameters.AddWithValue("@F_3_13_1", "");
                    cmd.Parameters.AddWithValue("@F_3_13_2", "");
                    cmd.Parameters.AddWithValue("@F_3_14_1", "");
                    cmd.Parameters.AddWithValue("@F_3_14_2", "");
                    cmd.Parameters.AddWithValue("@F_3_15_1", "");
                    cmd.Parameters.AddWithValue("@F_3_15_2", "");
                    cmd.Parameters.AddWithValue("@F_3_16_1", "");
                    cmd.Parameters.AddWithValue("@F_3_16_2", "");
                    cmd.Parameters.AddWithValue("@F_3_17_1", "");
                    cmd.Parameters.AddWithValue("@F_3_17_2", "");
                    cmd.Parameters.AddWithValue("@F_3_18_1", "");
                    cmd.Parameters.AddWithValue("@F_3_18_2", "");
                    cmd.Parameters.AddWithValue("@F_3_19_1", "");
                    cmd.Parameters.AddWithValue("@F_3_19_2", "");
                    cmd.Parameters.AddWithValue("@F_3_20_1", "");
                    cmd.Parameters.AddWithValue("@F_3_20_2", "");
                    cmd.Parameters.AddWithValue("@F_3_21_1", "");
                    cmd.Parameters.AddWithValue("@F_3_21_2", "");
                    cmd.Parameters.AddWithValue("@F_3_22_1", "");
                    cmd.Parameters.AddWithValue("@F_3_22_2", "");
                    cmd.Parameters.AddWithValue("@F_3_23_1", "");
                    cmd.Parameters.AddWithValue("@F_3_23_2", "");
                    cmd.Parameters.AddWithValue("@F_3_24_1", "");
                    cmd.Parameters.AddWithValue("@F_3_24_2", "");
                    cmd.Parameters.AddWithValue("@F_3_25_1", "");
                    cmd.Parameters.AddWithValue("@F_3_25_2", "");
                    cmd.Parameters.AddWithValue("@F_3_26_1", "");
                    cmd.Parameters.AddWithValue("@F_3_26_2", "");
                    cmd.Parameters.AddWithValue("@F_3_27_1", "");
                    cmd.Parameters.AddWithValue("@F_3_27_2", "");
                    cmd.Parameters.AddWithValue("@F_3_28_1", "");
                    cmd.Parameters.AddWithValue("@F_3_28_2", "");
                    cmd.Parameters.AddWithValue("@F_3_29_1", "");
                    cmd.Parameters.AddWithValue("@F_3_29_2", "");
                    cmd.Parameters.AddWithValue("@F_3_30_1", "");
                    cmd.Parameters.AddWithValue("@F_3_30_2", "");
                    cmd.Parameters.AddWithValue("@F_3_31_1", "");
                    cmd.Parameters.AddWithValue("@F_3_31_2", "");
                    cmd.Parameters.AddWithValue("@F_3_32_1", "");
                    cmd.Parameters.AddWithValue("@F_3_32_2", "");
                    cmd.Parameters.AddWithValue("@F_3_33_1", "");
                    cmd.Parameters.AddWithValue("@F_3_33_2", "");
                    cmd.Parameters.AddWithValue("@F_3_34_1", "");
                    cmd.Parameters.AddWithValue("@F_3_34_2", "");
                    cmd.Parameters.AddWithValue("@F_3_35_1", "");
                    cmd.Parameters.AddWithValue("@F_3_35_2", "");
                    cmd.Parameters.AddWithValue("@F_3_36_1", "");
                    cmd.Parameters.AddWithValue("@F_3_36_2", "");
                    cmd.Parameters.AddWithValue("@F_3_37_1", "");
                    cmd.Parameters.AddWithValue("@F_3_37_2", "");
                    cmd.Parameters.AddWithValue("@F_3_38_1", "");
                    cmd.Parameters.AddWithValue("@F_3_38_2", "");
                    cmd.Parameters.AddWithValue("@F_3_39_1", "");
                    cmd.Parameters.AddWithValue("@F_3_39_2", "");
                    cmd.Parameters.AddWithValue("@F_3_40_1", "");
                    cmd.Parameters.AddWithValue("@F_3_40_2", "");
                    cmd.Parameters.AddWithValue("@F_3_41_1", "");
                    cmd.Parameters.AddWithValue("@F_3_41_2", "");
                    cmd.Parameters.AddWithValue("@F_3_42_1", "");
                    cmd.Parameters.AddWithValue("@F_3_42_2", "");
                    cmd.Parameters.AddWithValue("@F_3_43_1", "");
                    cmd.Parameters.AddWithValue("@F_3_43_2", "");
                    cmd.Parameters.AddWithValue("@F_3_44_1", "");
                    cmd.Parameters.AddWithValue("@F_3_44_2", "");
                    cmd.Parameters.AddWithValue("@F_3_45_1", "");
                    cmd.Parameters.AddWithValue("@F_3_45_2", "");


                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_A_1_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_1", txtF_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2", txtF_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3", txtF_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4", txtF_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@Address", txtAdress.Text.ToString());
                    cmd.Parameters.AddWithValue("@City", txtCity.Text.ToString());
                    cmd.Parameters.AddWithValue("@Home_Phone", txtHome_Phone.Text.ToString());
                    cmd.Parameters.AddWithValue("@Date_Birth", txtDate_Birth.Text.ToString());
                    cmd.Parameters.AddWithValue("@Occupation", txtOccupation.Text.ToString());
                    cmd.Parameters.AddWithValue("@Employer", txtEmployer.Text.ToString());
                    cmd.Parameters.AddWithValue("@Employer_Adress", txtEmployer_Adress.Text.ToString());
                    cmd.Parameters.AddWithValue("@Employer_Phone", txtEmplyer_Phone.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children1_Name", txtChildren1_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children1_Date", txtChildren1_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children2_Name", txtChildren2_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children2_Date", txtChildren2_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children3_Name", txtChildren3_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children3_Date", txtChildren3_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children4_Name", txtChildren4_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children4_Date", txtChildren4_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children5_Name", txtChildren5_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children5_Date", txtChildren5_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children6_Name", txtChildren6_Name.Text.ToString());
                    cmd.Parameters.AddWithValue("@Children6_Date", txtChildren6_Date.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_1", txtF_2_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_2", txtF_2_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_3", txtF_2_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_4", txtF_2_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_5", txtF_2_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_6", txtF_2_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_7", txtF_2_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_8", txtF_2_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_9", txtF_2_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_10", txtF_2_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_11", txtF_2_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_12", txtF_2_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_13", txtF_2_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_14", txtF_2_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_15", txtF_2_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_16", txtF_2_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_17", txtF_2_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_18", txtF_2_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_19", txtF_2_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_20", txtF_2_20.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_3_1_1", txtF_3_1_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_1_2", txtF_3_1_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_2_1", txtF_3_2_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_2_2", txtF_3_2_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_3_1", txtF_3_3_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_3_2", txtF_3_3_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_4_1", txtF_3_4_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_4_2", txtF_3_4_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_5_1", txtF_3_5_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_5_2", txtF_3_5_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_6_1", txtF_3_6_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_6_2", txtF_3_6_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_7_1", txtF_3_7_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_7_2", txtF_3_7_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_8_1", txtF_3_8_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_8_2", txtF_3_8_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_9_1", txtF_3_9_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_9_2", txtF_3_9_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_10_1", txtF_3_10_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_10_2", txtF_3_10_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_11_1", txtF_3_11_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_11_2", txtF_3_11_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_12_1", txtF_3_12_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_12_2", txtF_3_12_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_13_1", txtF_3_13_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_13_2", txtF_3_13_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_14_1", txtF_3_14_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_14_2", txtF_3_14_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_15_1", txtF_3_15_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_15_2", txtF_3_15_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_16_1", txtF_3_16_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_16_2", txtF_3_16_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_17_1", txtF_3_17_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_17_2", txtF_3_17_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_18_1", txtF_3_18_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_18_2", txtF_3_18_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_19_1", txtF_3_19_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_19_2", txtF_3_19_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_20_1", txtF_3_20_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_20_2", txtF_3_20_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_21_1", txtF_3_21_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_21_2", txtF_3_21_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_22_1", txtF_3_22_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_22_2", txtF_3_22_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_23_1", txtF_3_23_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_23_2", txtF_3_23_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_24_1", txtF_3_24_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_24_2", txtF_3_24_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_25_1", txtF_3_25_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_25_2", txtF_3_25_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_26_1", txtF_3_26_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_26_2", txtF_3_26_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_27_1", txtF_3_27_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_27_2", txtF_3_27_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_28_1", txtF_3_28_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_28_2", txtF_3_28_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_29_1", txtF_3_29_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_29_2", txtF_3_29_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_30_1", txtF_3_30_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_30_2", txtF_3_30_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_31_1", txtF_3_31_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_31_2", txtF_3_31_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_32_1", txtF_3_32_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_32_2", txtF_3_32_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_33_1", txtF_3_33_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_33_2", txtF_3_33_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_34_1", txtF_3_34_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_34_2", txtF_3_34_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_35_1", txtF_3_35_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_35_2", txtF_3_35_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_36_1", txtF_3_36_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_36_2", txtF_3_36_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_37_1", txtF_3_37_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_37_2", txtF_3_37_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_38_1", txtF_3_38_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_38_2", txtF_3_38_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_39_1", txtF_3_39_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_39_2", txtF_3_39_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_40_1", txtF_3_40_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_40_2", txtF_3_40_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_41_1", txtF_3_41_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_41_2", txtF_3_41_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_42_1", txtF_3_42_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_42_2", txtF_3_42_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_43_1", txtF_3_43_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_43_2", txtF_3_43_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_44_1", txtF_3_44_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_44_2", txtF_3_44_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_45_1", txtF_3_45_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3_45_2", txtF_3_45_2.Text.ToString());


                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            //this.BindRepeater();
            //this.EmptyFields();
            //this.CompanyTableFilter(1, ViewState["FilterKolona"].ToString(), ViewState["Filter"].ToString());
        }

        private void ManipulatePdf(String dest)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest));
            Document doc = new Document(pdfDoc);

            Table table = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();

            for (int i = 0; i < 16; i++)
            {
                table.AddCell("hi");
            }

            doc.Add(table);

            doc.Close();
        }


        private string GetContentType(string fileExtension)
        {
            if (string.IsNullOrEmpty(fileExtension))
                return string.Empty;

            string contentType = string.Empty;
            switch (fileExtension)
            {
                case ".htm":
                case ".html":
                    contentType = "text/HTML";
                    break;

                case ".txt":
                    contentType = "text/plain";
                    break;

                case ".doc":
                case ".rtf":
                case ".docx":
                    contentType = "Application/msword";
                    break;

                case ".xls":
                case ".xlsx":
                    contentType = "Application/x-msexcel";
                    break;

                case ".jpg":
                case ".jpeg":
                    contentType = "image/jpeg";
                    break;

                case ".gif":
                    contentType = "image/GIF";
                    break;

                case ".pdf":
                    contentType = "application/pdf";
                    break;
            }

            return contentType;
        }




        protected void Print_LF_A_1(object sender, EventArgs e)
        {

            string fileName = "proba.pdf";
            string fileExtension = ".pdf";

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Server.MapPath("~/Secured/Files/" + fileName)));
            Document doc = new Document(pdfDoc);

            Table table = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth();

            for (int i = 0; i < 16; i++)
            {
                table.AddCell("hi");
            }

            doc.Add(table);

            doc.Close();

            // Set Response.ContentType
            Response.ContentType = GetContentType(fileExtension);

            // Append header
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

            // Write the file to the Response
            Response.TransmitFile(Server.MapPath("~/Secured/Files/" + fileName));
            Response.End();


            //var writer = new PdfWriter("C:\\Users\\Attila\\Desktop\\hello_world.pdf");
            //var pdf = new PdfDocument(writer);
            //var document = new Document(pdf);
            //// Create a PdfFont
            //var font = PdfFontFactory.CreateFont(FontConstants.TIMES_ROMAN);
            //// Add a Paragraph
            //document.Add(new Paragraph("iText is:").SetFont(font));
            //// Create a List
            //List list = new List()
            //    .SetSymbolIndent(12)
            //    .SetListSymbol("u2022")
            //    .SetFont(font);
            //// Add ListItem objects
            //list.Add(new ListItem("Never gonna give you up"))
            //    .Add(new ListItem("Never gonna let you down"))
            //    .Add(new ListItem("Never gonna run around and desert you"))
            //    .Add(new ListItem("Never gonna make you cry"))
            //    .Add(new ListItem("Never gonna say goodbye"))
            //    .Add(new ListItem("Never gonna tell a lie and hurt you"));
            //// Add the list
            //document.Add(list);
            //document.Close();
        }


    }
}