using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Security;
using System.Windows.Forms;
using ListItem = iText.Layout.Element.ListItem;
using Table = iText.Layout.Element.Table;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using Control = System.Web.UI.Control;

namespace DivorceLaw.Secured
{
    public partial class LegalFormDeafult : System.Web.UI.Page
    {
        private String strConnString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public static readonly string DEST = "Secured/simple_table.pdf";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtF_2_1.Style.Add("text-align", "right");
            this.txtF_2_2.Style.Add("text-align", "right");
            this.txtF_2_3.Style.Add("text-align", "right");
            this.txtF_2_4.Style.Add("text-align", "right");
            this.txtF_2_5.Style.Add("text-align", "right");
            this.txtF_2_6.Style.Add("text-align", "right");
            this.txtF_2_7.Style.Add("text-align", "right");
            this.txtF_2_8.Style.Add("text-align", "right");
            this.txtF_2_9.Style.Add("text-align", "right");
            this.txtF_2_10.Style.Add("text-align", "right");
            this.txtF_2_11.Style.Add("text-align", "right");
            this.txtF_2_12.Style.Add("text-align", "right");
            this.txtF_2_13.Style.Add("text-align", "right");
            this.txtF_2_14.Style.Add("text-align", "right");
            this.txtF_2_15.Style.Add("text-align", "right");
            this.txtF_2_16.Style.Add("text-align", "right");
            this.txtF_2_17.Style.Add("text-align", "right");
            this.txtF_2_18.Style.Add("text-align", "right");
            this.txt_F_2_19.Style.Add("text-align", "right");
            this.txtF_2_20.Style.Add("text-align", "right");

            this.txtF_3_1_1.Style.Add("text-align", "right");
            this.txtF_3_1_2.Style.Add("text-align", "right");
            this.txtF_3_2_1.Style.Add("text-align", "right");
            this.txtF_3_2_2.Style.Add("text-align", "right");
            this.txtF_3_3_1.Style.Add("text-align", "right");
            this.txtF_3_3_2.Style.Add("text-align", "right");
            this.txtF_3_4_1.Style.Add("text-align", "right");
            this.txtF_3_4_2.Style.Add("text-align", "right");
            this.txtF_3_5_1.Style.Add("text-align", "right");
            this.txtF_3_5_2.Style.Add("text-align", "right");
            this.txtF_3_6_1.Style.Add("text-align", "right");
            this.txtF_3_6_2.Style.Add("text-align", "right");
            this.txtF_3_7_1.Style.Add("text-align", "right");
            this.txtF_3_7_2.Style.Add("text-align", "right");
            this.txtF_3_8_1.Style.Add("text-align", "right");
            this.txtF_3_8_2.Style.Add("text-align", "right");
            this.txtF_3_9_1.Style.Add("text-align", "right");
            this.txtF_3_9_2.Style.Add("text-align", "right");
            this.txtF_3_10_1.Style.Add("text-align", "right");
            this.txtF_3_10_2.Style.Add("text-align", "right");
            this.txtF_3_11_1.Style.Add("text-align", "right");
            this.txtF_3_11_2.Style.Add("text-align", "right");
            this.txtF_3_12_1.Style.Add("text-align", "right");
            this.txtF_3_12_2.Style.Add("text-align", "right");
            this.txtF_3_13_1.Style.Add("text-align", "right");
            this.txtF_3_13_2.Style.Add("text-align", "right");
            this.txtF_3_14_1.Style.Add("text-align", "right");
            this.txtF_3_14_2.Style.Add("text-align", "right");
            this.txtF_3_15_1.Style.Add("text-align", "right");
            this.txtF_3_15_2.Style.Add("text-align", "right");
            this.txtF_3_16_1.Style.Add("text-align", "right");
            this.txtF_3_16_2.Style.Add("text-align", "right");
            this.txtF_3_17_1.Style.Add("text-align", "right");
            this.txtF_3_17_2.Style.Add("text-align", "right");
            this.txtF_3_18_1.Style.Add("text-align", "right");
            this.txtF_3_18_2.Style.Add("text-align", "right");
            this.txtF_3_19_1.Style.Add("text-align", "right");
            this.txtF_3_19_2.Style.Add("text-align", "right");
            this.txtF_3_20_1.Style.Add("text-align", "right");
            this.txtF_3_20_2.Style.Add("text-align", "right");
            this.txtF_3_21_1.Style.Add("text-align", "right");
            this.txtF_3_21_2.Style.Add("text-align", "right");
            this.txtF_3_22_1.Style.Add("text-align", "right");
            this.txtF_3_22_2.Style.Add("text-align", "right");
            this.txtF_3_23_1.Style.Add("text-align", "right");
            this.txtF_3_23_2.Style.Add("text-align", "right");
            this.txtF_3_24_1.Style.Add("text-align", "right");
            this.txtF_3_24_2.Style.Add("text-align", "right");
            this.txtF_3_25_1.Style.Add("text-align", "right");
            this.txtF_3_25_2.Style.Add("text-align", "right");
            this.txtF_3_26_1.Style.Add("text-align", "right");
            this.txtF_3_26_2.Style.Add("text-align", "right");
            this.txtF_3_27_1.Style.Add("text-align", "right");
            this.txtF_3_27_2.Style.Add("text-align", "right");
            this.txtF_3_28_1.Style.Add("text-align", "right");
            this.txtF_3_28_2.Style.Add("text-align", "right");
            this.txtF_3_29_1.Style.Add("text-align", "right");
            this.txtF_3_29_2.Style.Add("text-align", "right");
            this.txtF_3_30_1.Style.Add("text-align", "right");
            this.txtF_3_30_2.Style.Add("text-align", "right");
            this.txtF_3_31_1.Style.Add("text-align", "right");
            this.txtF_3_31_2.Style.Add("text-align", "right");
            this.txtF_3_32_1.Style.Add("text-align", "right");
            this.txtF_3_32_2.Style.Add("text-align", "right");
            this.txtF_3_33_1.Style.Add("text-align", "right");
            this.txtF_3_33_2.Style.Add("text-align", "right");
            this.txtF_3_34_1.Style.Add("text-align", "right");
            this.txtF_3_34_2.Style.Add("text-align", "right");
            this.txtF_3_35_1.Style.Add("text-align", "right");
            this.txtF_3_35_2.Style.Add("text-align", "right");
            this.txtF_3_36_1.Style.Add("text-align", "right");
            this.txtF_3_36_2.Style.Add("text-align", "right");
            this.txtF_3_37_1.Style.Add("text-align", "right");
            this.txtF_3_37_2.Style.Add("text-align", "right");
            this.txtF_3_38_1.Style.Add("text-align", "right");
            this.txtF_3_38_2.Style.Add("text-align", "right");
            this.txtF_3_39_1.Style.Add("text-align", "right");
            this.txtF_3_39_2.Style.Add("text-align", "right");
            this.txtF_3_40_1.Style.Add("text-align", "right");
            this.txtF_3_40_2.Style.Add("text-align", "right");
            this.txtF_3_41_1.Style.Add("text-align", "right");
            this.txtF_3_41_2.Style.Add("text-align", "right");
            this.txtF_3_42_1.Style.Add("text-align", "right");
            this.txtF_3_42_2.Style.Add("text-align", "right");
            this.txtF_3_43_1.Style.Add("text-align", "right");
            this.txtF_3_43_2.Style.Add("text-align", "right");
            this.txtF_3_44_1.Style.Add("text-align", "right");
            this.txtF_3_44_2.Style.Add("text-align", "right");
            this.txtF_3_45_1.Style.Add("text-align", "right");
            this.txtF_3_45_2.Style.Add("text-align", "right");

            this.txtF_4_3_2.Style.Add("text-align", "right");
            this.txtF_4_3_4.Style.Add("text-align", "right");
            this.txtF_4_3_6.Style.Add("text-align", "right");
            this.txtF_4_3_8.Style.Add("text-align", "right");
            this.txtF_4_3_10.Style.Add("text-align", "right");
            this.txtF_4_3_12.Style.Add("text-align", "right");
            this.txtF_4_3_14.Style.Add("text-align", "right");
            this.txtF_4_3_16.Style.Add("text-align", "right");
            this.txtF_4_3_18.Style.Add("text-align", "right");
            this.txtF_4_3_20.Style.Add("text-align", "right");
            this.txtF_4_3_22.Style.Add("text-align", "right");
            this.txtF_4_3_24.Style.Add("text-align", "right");
            this.txtF_4_3_26.Style.Add("text-align", "right");
            this.txtF_4_3_28.Style.Add("text-align", "right");
            this.txtF_4_3_30.Style.Add("text-align", "right");
            this.txtF_4_3_32.Style.Add("text-align", "right");
            this.txtF_4_3_34.Style.Add("text-align", "right");
            this.txtF_4_3_36.Style.Add("text-align", "right");
            this.txtF_4_3_38.Style.Add("text-align", "right");
            this.txtF_4_3_40.Style.Add("text-align", "right");
            this.txtF_4_3_42.Style.Add("text-align", "right");
            this.txtF_4_3_44.Style.Add("text-align", "right");
            this.txtF_4_3_46.Style.Add("text-align", "right");
            this.txtF_4_3_48.Style.Add("text-align", "right");
            this.txtF_4_3_50.Style.Add("text-align", "right");
            this.txtF_4_3_52.Style.Add("text-align", "right");
            this.txtF_4_3_54.Style.Add("text-align", "right");
            this.txtF_4_3_56.Style.Add("text-align", "right");
            this.txtF_4_3_58.Style.Add("text-align", "right");
            this.txtF_4_3_60.Style.Add("text-align", "right");
            this.txtF_4_3_62.Style.Add("text-align", "right");
            this.txtF_4_3_64.Style.Add("text-align", "right");
            this.txtF_4_3_66.Style.Add("text-align", "right");
            this.txtF_4_3_68.Style.Add("text-align", "right");
            this.txtF_4_3_70.Style.Add("text-align", "right");
            this.txtF_4_3_72.Style.Add("text-align", "right");
            this.txtF_4_3_74.Style.Add("text-align", "right");
            this.txtF_4_3_76.Style.Add("text-align", "right");
            this.txtF_4_3_78.Style.Add("text-align", "right");
            this.txtF_4_3_80.Style.Add("text-align", "right");
            this.txtF_4_3_82.Style.Add("text-align", "right");

            this.txtF_4_4_5.Style.Add("text-align", "right");
            this.txtF_4_4_10.Style.Add("text-align", "right");
            this.txtF_4_4_15.Style.Add("text-align", "right");
            this.txtF_4_4_20.Style.Add("text-align", "right");
            this.txtF_4_4_25.Style.Add("text-align", "right");
            this.txtF_4_4_30.Style.Add("text-align", "right");
            this.txtF_4_4_35.Style.Add("text-align", "right");
            this.txtF_4_4_40.Style.Add("text-align", "right");
            this.txtF_4_4_45.Style.Add("text-align", "right");
            this.txtF_4_4_50.Style.Add("text-align", "right");
            this.txtF_4_4_55.Style.Add("text-align", "right");
            this.txtF_4_4_56.Style.Add("text-align", "right");

            this.txtF_4_5_3.Style.Add("text-align", "right");
            this.txtF_4_5_6.Style.Add("text-align", "right");
            this.txtF_4_5_9.Style.Add("text-align", "right");
            this.txtF_4_5_12.Style.Add("text-align", "right");
            this.txtF_4_5_15.Style.Add("text-align", "right");
            this.txtF_4_5_18.Style.Add("text-align", "right");
            this.txtF_4_5_21.Style.Add("text-align", "right");
            this.txtF_4_5_24.Style.Add("text-align", "right");
            this.txtF_4_5_27.Style.Add("text-align", "right");
            this.txtF_4_5_30.Style.Add("text-align", "right");
            this.txtF_4_5_31.Style.Add("text-align", "right");

            this.txtF_4_6_3.Style.Add("text-align", "right");
            this.txtF_4_6_8.Style.Add("text-align", "right");
            this.txtF_4_6_13.Style.Add("text-align", "right");
            this.txtF_4_6_18.Style.Add("text-align", "right");
            this.txtF_4_6_23.Style.Add("text-align", "right");
            this.txtF_4_6_28.Style.Add("text-align", "right");
            this.txtF_4_6_33.Style.Add("text-align", "right");
            this.txtF_4_6_38.Style.Add("text-align", "right");

            this.txtF_4_6_4.Style.Add("text-align", "right");
            this.txtF_4_6_9.Style.Add("text-align", "right");
            this.txtF_4_6_14.Style.Add("text-align", "right");
            this.txtF_4_6_19.Style.Add("text-align", "right");
            this.txtF_4_6_24.Style.Add("text-align", "right");
            this.txtF_4_6_29.Style.Add("text-align", "right");
            this.txtF_4_6_34.Style.Add("text-align", "right");
            this.txtF_4_6_39.Style.Add("text-align", "right");
            
            this.txtF_4_6_41.Style.Add("text-align", "right");
            this.txtF_4_6_42.Style.Add("text-align", "right");

            this.txtF_4_7_5.Style.Add("text-align", "right");
            this.txtF_4_7_10.Style.Add("text-align", "right");
            this.txtF_4_7_15.Style.Add("text-align", "right");
            this.txtF_4_7_20.Style.Add("text-align", "right");
            this.txtF_4_7_25.Style.Add("text-align", "right");
            this.txtF_4_7_30.Style.Add("text-align", "right");
            this.txtF_4_7_35.Style.Add("text-align", "right");
            this.txtF_4_7_40.Style.Add("text-align", "right");
            this.txtF_4_7_45.Style.Add("text-align", "right");
            this.txtF_4_7_50.Style.Add("text-align", "right");
            this.txtF_4_7_55.Style.Add("text-align", "right");
            this.txtF_4_7_60.Style.Add("text-align", "right");
            this.txtF_4_7_61.Style.Add("text-align", "right");

            this.txtF_5_3.Style.Add("text-align", "right");
            this.txtF_5_8.Style.Add("text-align", "right");
            this.txtF_5_13.Style.Add("text-align", "right");
            this.txtF_5_18.Style.Add("text-align", "right");
            this.txtF_5_23.Style.Add("text-align", "right");
            this.txtF_5_28.Style.Add("text-align", "right");
            this.txtF_5_33.Style.Add("text-align", "right");
            this.txtF_5_38.Style.Add("text-align", "right");
            this.txtF_5_43.Style.Add("text-align", "right");
            this.txtF_5_48.Style.Add("text-align", "right");
            this.txtF_5_53.Style.Add("text-align", "right");
            this.txtF_5_56.Style.Add("text-align", "right");

            this.txtF_5_4.Style.Add("text-align", "right");
            this.txtF_5_9.Style.Add("text-align", "right");
            this.txtF_5_14.Style.Add("text-align", "right");
            this.txtF_5_19.Style.Add("text-align", "right");
            this.txtF_5_24.Style.Add("text-align", "right");
            this.txtF_5_29.Style.Add("text-align", "right");
            this.txtF_5_34.Style.Add("text-align", "right");
            this.txtF_5_39.Style.Add("text-align", "right");
            this.txtF_5_44.Style.Add("text-align", "right");
            this.txtF_5_49.Style.Add("text-align", "right");
            this.txtF_5_54.Style.Add("text-align", "right");
            this.txtF_5_57.Style.Add("text-align", "right");


            if (!this.IsPostBack)
            {
                string userName = string.Empty;
                userName = HttpContext.Current.User.Identity.Name;

                if (userName == "david@gmail.com")
                {
                    lnkRegister.Visible = true;
                }

                string constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT County FROM County"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            sda.Fill(ds);
                            txtF_1_1.DataSource = ds.Tables[0];
                            txtF_1_1.DataTextField = "County";
                            //ddlCompany.DataValueField = "CoCD";
                            txtF_1_1.DataBind();
                        }
                    }
                }

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Exemption FROM Exemption"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            sda.Fill(ds);
                            txt_F_2_19.DataSource = ds.Tables[0];
                            txt_F_2_19.DataTextField = "Exemption";
                            //ddlCompany.DataValueField = "CoCD";
                            txt_F_2_19.DataBind();
                        }
                    }
                }



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
                        cmd.Parameters.AddWithValue("@Employer_City", "");
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

                        cmd.Parameters.AddWithValue("@F_4_1_1", "");
                        cmd.Parameters.AddWithValue("@F_4_1_2", "");
                        cmd.Parameters.AddWithValue("@F_4_1_3", "");
                        cmd.Parameters.AddWithValue("@F_4_1_4", "");
                        cmd.Parameters.AddWithValue("@F_4_1_5", "");
                        cmd.Parameters.AddWithValue("@F_4_1_6", "");
                        cmd.Parameters.AddWithValue("@F_4_1_7", "");
                        cmd.Parameters.AddWithValue("@F_4_1_8", "");
                        cmd.Parameters.AddWithValue("@F_4_1_9", "");
                        cmd.Parameters.AddWithValue("@F_4_1_10", "");
                        cmd.Parameters.AddWithValue("@F_4_1_11", "");
                        cmd.Parameters.AddWithValue("@F_4_1_12", "");
                        cmd.Parameters.AddWithValue("@F_4_1_13", "");
                        cmd.Parameters.AddWithValue("@F_4_1_14", "");
                        cmd.Parameters.AddWithValue("@F_4_1_15", "");
                        cmd.Parameters.AddWithValue("@F_4_1_16", "");
                        cmd.Parameters.AddWithValue("@F_4_1_17", "");
                        cmd.Parameters.AddWithValue("@F_4_1_18", "");
                        cmd.Parameters.AddWithValue("@F_4_1_19", "");
                        cmd.Parameters.AddWithValue("@F_4_1_20", "");
                        cmd.Parameters.AddWithValue("@F_4_1_21", "");
                        cmd.Parameters.AddWithValue("@F_4_1_22", "");
                        cmd.Parameters.AddWithValue("@F_4_1_23", "");
                        cmd.Parameters.AddWithValue("@F_4_1_24", "");

                        cmd.Parameters.AddWithValue("@F_4_2_1", "");
                        cmd.Parameters.AddWithValue("@F_4_2_2", "");
                        cmd.Parameters.AddWithValue("@F_4_2_3", "");
                        cmd.Parameters.AddWithValue("@F_4_2_4", "");
                        cmd.Parameters.AddWithValue("@F_4_2_5", "");
                        cmd.Parameters.AddWithValue("@F_4_2_6", "");
                        cmd.Parameters.AddWithValue("@F_4_2_7", "");
                        cmd.Parameters.AddWithValue("@F_4_2_8", "");
                        cmd.Parameters.AddWithValue("@F_4_2_9", "");
                        cmd.Parameters.AddWithValue("@F_4_2_10", "");
                        cmd.Parameters.AddWithValue("@F_4_2_11", "");
                        cmd.Parameters.AddWithValue("@F_4_2_12", "");
                        cmd.Parameters.AddWithValue("@F_4_2_13", "");
                        cmd.Parameters.AddWithValue("@F_4_2_14", "");
                        cmd.Parameters.AddWithValue("@F_4_2_15", "");
                        cmd.Parameters.AddWithValue("@F_4_2_16", "");
                        cmd.Parameters.AddWithValue("@F_4_2_17", "");
                        cmd.Parameters.AddWithValue("@F_4_2_18", "");
                        cmd.Parameters.AddWithValue("@F_4_2_19", "");
                        cmd.Parameters.AddWithValue("@F_4_2_20", "");
                        cmd.Parameters.AddWithValue("@F_4_2_21", "");
                        cmd.Parameters.AddWithValue("@F_4_2_22", "");
                        cmd.Parameters.AddWithValue("@F_4_2_23", "");
                        cmd.Parameters.AddWithValue("@F_4_2_24", "");
                        cmd.Parameters.AddWithValue("@F_4_2_25", "");
                        cmd.Parameters.AddWithValue("@F_4_2_26", "");
                        cmd.Parameters.AddWithValue("@F_4_2_27", "");

                        cmd.Parameters.AddWithValue("@F_4_3_1", "");
                        cmd.Parameters.AddWithValue("@F_4_3_2", "");
                        cmd.Parameters.AddWithValue("@F_4_3_3", "");
                        cmd.Parameters.AddWithValue("@F_4_3_4", "");
                        cmd.Parameters.AddWithValue("@F_4_3_5", "");
                        cmd.Parameters.AddWithValue("@F_4_3_6", "");
                        cmd.Parameters.AddWithValue("@F_4_3_7", "");
                        cmd.Parameters.AddWithValue("@F_4_3_8", "");
                        cmd.Parameters.AddWithValue("@F_4_3_9", "");
                        cmd.Parameters.AddWithValue("@F_4_3_10", "");
                        cmd.Parameters.AddWithValue("@F_4_3_11", "");
                        cmd.Parameters.AddWithValue("@F_4_3_12", "");
                        cmd.Parameters.AddWithValue("@F_4_3_13", "");
                        cmd.Parameters.AddWithValue("@F_4_3_14", "");
                        cmd.Parameters.AddWithValue("@F_4_3_15", "");
                        cmd.Parameters.AddWithValue("@F_4_3_16", "");
                        cmd.Parameters.AddWithValue("@F_4_3_17", "");
                        cmd.Parameters.AddWithValue("@F_4_3_18", "");
                        cmd.Parameters.AddWithValue("@F_4_3_19", "");
                        cmd.Parameters.AddWithValue("@F_4_3_20", "");
                        cmd.Parameters.AddWithValue("@F_4_3_21", "");
                        cmd.Parameters.AddWithValue("@F_4_3_22", "");
                        cmd.Parameters.AddWithValue("@F_4_3_23", "");
                        cmd.Parameters.AddWithValue("@F_4_3_24", "");
                        cmd.Parameters.AddWithValue("@F_4_3_25", "");
                        cmd.Parameters.AddWithValue("@F_4_3_26", "");
                        cmd.Parameters.AddWithValue("@F_4_3_27", "");
                        cmd.Parameters.AddWithValue("@F_4_3_28", "");
                        cmd.Parameters.AddWithValue("@F_4_3_29", "");
                        cmd.Parameters.AddWithValue("@F_4_3_30", "");
                        cmd.Parameters.AddWithValue("@F_4_3_31", "");
                        cmd.Parameters.AddWithValue("@F_4_3_32", "");
                        cmd.Parameters.AddWithValue("@F_4_3_33", "");
                        cmd.Parameters.AddWithValue("@F_4_3_34", "");
                        cmd.Parameters.AddWithValue("@F_4_3_35", "");
                        cmd.Parameters.AddWithValue("@F_4_3_36", "");
                        cmd.Parameters.AddWithValue("@F_4_3_37", "");
                        cmd.Parameters.AddWithValue("@F_4_3_38", "");
                        cmd.Parameters.AddWithValue("@F_4_3_39", "");
                        cmd.Parameters.AddWithValue("@F_4_3_40", "");
                        cmd.Parameters.AddWithValue("@F_4_3_41", "");
                        cmd.Parameters.AddWithValue("@F_4_3_42", "");
                        cmd.Parameters.AddWithValue("@F_4_3_43", "");
                        cmd.Parameters.AddWithValue("@F_4_3_44", "");
                        cmd.Parameters.AddWithValue("@F_4_3_45", "");
                        cmd.Parameters.AddWithValue("@F_4_3_46", "");
                        cmd.Parameters.AddWithValue("@F_4_3_47", "");
                        cmd.Parameters.AddWithValue("@F_4_3_48", "");
                        cmd.Parameters.AddWithValue("@F_4_3_49", "");
                        cmd.Parameters.AddWithValue("@F_4_3_50", "");
                        cmd.Parameters.AddWithValue("@F_4_3_51", "");
                        cmd.Parameters.AddWithValue("@F_4_3_52", "");
                        cmd.Parameters.AddWithValue("@F_4_3_53", "");
                        cmd.Parameters.AddWithValue("@F_4_3_54", "");
                        cmd.Parameters.AddWithValue("@F_4_3_55", "");
                        cmd.Parameters.AddWithValue("@F_4_3_56", "");
                        cmd.Parameters.AddWithValue("@F_4_3_57", "");
                        cmd.Parameters.AddWithValue("@F_4_3_58", "");
                        cmd.Parameters.AddWithValue("@F_4_3_59", "");
                        cmd.Parameters.AddWithValue("@F_4_3_60", "");
                        cmd.Parameters.AddWithValue("@F_4_3_61", "");
                        cmd.Parameters.AddWithValue("@F_4_3_62", "");
                        cmd.Parameters.AddWithValue("@F_4_3_63", "");
                        cmd.Parameters.AddWithValue("@F_4_3_64", "");
                        cmd.Parameters.AddWithValue("@F_4_3_65", "");
                        cmd.Parameters.AddWithValue("@F_4_3_66", "");
                        cmd.Parameters.AddWithValue("@F_4_3_67", "");
                        cmd.Parameters.AddWithValue("@F_4_3_68", "");
                        cmd.Parameters.AddWithValue("@F_4_3_69", "");
                        cmd.Parameters.AddWithValue("@F_4_3_70", "");
                        cmd.Parameters.AddWithValue("@F_4_3_71", "");
                        cmd.Parameters.AddWithValue("@F_4_3_72", "");
                        cmd.Parameters.AddWithValue("@F_4_3_73", "");
                        cmd.Parameters.AddWithValue("@F_4_3_74", "");
                        cmd.Parameters.AddWithValue("@F_4_3_75", "");
                        cmd.Parameters.AddWithValue("@F_4_3_76", "");
                        cmd.Parameters.AddWithValue("@F_4_3_77", "");
                        cmd.Parameters.AddWithValue("@F_4_3_78", "");
                        cmd.Parameters.AddWithValue("@F_4_3_79", "");
                        cmd.Parameters.AddWithValue("@F_4_3_80", "");
                        cmd.Parameters.AddWithValue("@F_4_3_81", "");
                        cmd.Parameters.AddWithValue("@F_4_3_82", "");

                        cmd.Parameters.AddWithValue("@F_4_4_1", "");
                        cmd.Parameters.AddWithValue("@F_4_4_2", "");
                        cmd.Parameters.AddWithValue("@F_4_4_3", "");
                        cmd.Parameters.AddWithValue("@F_4_4_4", "");
                        cmd.Parameters.AddWithValue("@F_4_4_5", "");
                        cmd.Parameters.AddWithValue("@F_4_4_6", "");
                        cmd.Parameters.AddWithValue("@F_4_4_7", "");
                        cmd.Parameters.AddWithValue("@F_4_4_8", "");
                        cmd.Parameters.AddWithValue("@F_4_4_9", "");
                        cmd.Parameters.AddWithValue("@F_4_4_10", "");
                        cmd.Parameters.AddWithValue("@F_4_4_11", "");
                        cmd.Parameters.AddWithValue("@F_4_4_12", "");
                        cmd.Parameters.AddWithValue("@F_4_4_13", "");
                        cmd.Parameters.AddWithValue("@F_4_4_14", "");
                        cmd.Parameters.AddWithValue("@F_4_4_15", "");
                        cmd.Parameters.AddWithValue("@F_4_4_16", "");
                        cmd.Parameters.AddWithValue("@F_4_4_17", "");
                        cmd.Parameters.AddWithValue("@F_4_4_18", "");
                        cmd.Parameters.AddWithValue("@F_4_4_19", "");
                        cmd.Parameters.AddWithValue("@F_4_4_20", "");
                        cmd.Parameters.AddWithValue("@F_4_4_21", "");
                        cmd.Parameters.AddWithValue("@F_4_4_22", "");
                        cmd.Parameters.AddWithValue("@F_4_4_23", "");
                        cmd.Parameters.AddWithValue("@F_4_4_24", "");
                        cmd.Parameters.AddWithValue("@F_4_4_25", "");
                        cmd.Parameters.AddWithValue("@F_4_4_26", "");
                        cmd.Parameters.AddWithValue("@F_4_4_27", "");
                        cmd.Parameters.AddWithValue("@F_4_4_28", "");
                        cmd.Parameters.AddWithValue("@F_4_4_29", "");
                        cmd.Parameters.AddWithValue("@F_4_4_30", "");
                        cmd.Parameters.AddWithValue("@F_4_4_31", "");
                        cmd.Parameters.AddWithValue("@F_4_4_32", "");
                        cmd.Parameters.AddWithValue("@F_4_4_33", "");
                        cmd.Parameters.AddWithValue("@F_4_4_34", "");
                        cmd.Parameters.AddWithValue("@F_4_4_35", "");
                        cmd.Parameters.AddWithValue("@F_4_4_36", "");
                        cmd.Parameters.AddWithValue("@F_4_4_37", "");
                        cmd.Parameters.AddWithValue("@F_4_4_38", "");
                        cmd.Parameters.AddWithValue("@F_4_4_39", "");
                        cmd.Parameters.AddWithValue("@F_4_4_40", "");
                        cmd.Parameters.AddWithValue("@F_4_4_41", "");
                        cmd.Parameters.AddWithValue("@F_4_4_42", "");
                        cmd.Parameters.AddWithValue("@F_4_4_43", "");
                        cmd.Parameters.AddWithValue("@F_4_4_44", "");
                        cmd.Parameters.AddWithValue("@F_4_4_45", "");
                        cmd.Parameters.AddWithValue("@F_4_4_46", "");
                        cmd.Parameters.AddWithValue("@F_4_4_47", "");
                        cmd.Parameters.AddWithValue("@F_4_4_48", "");
                        cmd.Parameters.AddWithValue("@F_4_4_49", "");
                        cmd.Parameters.AddWithValue("@F_4_4_50", "");
                        cmd.Parameters.AddWithValue("@F_4_4_51", "");
                        cmd.Parameters.AddWithValue("@F_4_4_52", "");
                        cmd.Parameters.AddWithValue("@F_4_4_53", "");
                        cmd.Parameters.AddWithValue("@F_4_4_54", "");
                        cmd.Parameters.AddWithValue("@F_4_4_55", "");
                        cmd.Parameters.AddWithValue("@F_4_4_56", "");


                        cmd.Parameters.AddWithValue("@F_4_5_1", "");
                        cmd.Parameters.AddWithValue("@F_4_5_2", "");
                        cmd.Parameters.AddWithValue("@F_4_5_3", "");
                        cmd.Parameters.AddWithValue("@F_4_5_4", "");
                        cmd.Parameters.AddWithValue("@F_4_5_5", "");
                        cmd.Parameters.AddWithValue("@F_4_5_6", "");
                        cmd.Parameters.AddWithValue("@F_4_5_7", "");
                        cmd.Parameters.AddWithValue("@F_4_5_8", "");
                        cmd.Parameters.AddWithValue("@F_4_5_9", "");
                        cmd.Parameters.AddWithValue("@F_4_5_10", "");
                        cmd.Parameters.AddWithValue("@F_4_5_11", "");
                        cmd.Parameters.AddWithValue("@F_4_5_12", "");
                        cmd.Parameters.AddWithValue("@F_4_5_13", "");
                        cmd.Parameters.AddWithValue("@F_4_5_14", "");
                        cmd.Parameters.AddWithValue("@F_4_5_15", "");
                        cmd.Parameters.AddWithValue("@F_4_5_16", "");
                        cmd.Parameters.AddWithValue("@F_4_5_17", "");
                        cmd.Parameters.AddWithValue("@F_4_5_18", "");
                        cmd.Parameters.AddWithValue("@F_4_5_19", "");
                        cmd.Parameters.AddWithValue("@F_4_5_20", "");
                        cmd.Parameters.AddWithValue("@F_4_5_21", "");
                        cmd.Parameters.AddWithValue("@F_4_5_22", "");
                        cmd.Parameters.AddWithValue("@F_4_5_23", "");
                        cmd.Parameters.AddWithValue("@F_4_5_24", "");
                        cmd.Parameters.AddWithValue("@F_4_5_25", "");
                        cmd.Parameters.AddWithValue("@F_4_5_26", "");
                        cmd.Parameters.AddWithValue("@F_4_5_27", "");
                        cmd.Parameters.AddWithValue("@F_4_5_28", "");
                        cmd.Parameters.AddWithValue("@F_4_5_29", "");
                        cmd.Parameters.AddWithValue("@F_4_5_30", "");
                        cmd.Parameters.AddWithValue("@F_4_5_31", "");

                        cmd.Parameters.AddWithValue("@F_4_6_1", "");
                        cmd.Parameters.AddWithValue("@F_4_6_2", "");
                        cmd.Parameters.AddWithValue("@F_4_6_3", "");
                        cmd.Parameters.AddWithValue("@F_4_6_4", "");
                        cmd.Parameters.AddWithValue("@F_4_6_5", "");
                        cmd.Parameters.AddWithValue("@F_4_6_6", "");
                        cmd.Parameters.AddWithValue("@F_4_6_7", "");
                        cmd.Parameters.AddWithValue("@F_4_6_8", "");
                        cmd.Parameters.AddWithValue("@F_4_6_9", "");
                        cmd.Parameters.AddWithValue("@F_4_6_10", "");
                        cmd.Parameters.AddWithValue("@F_4_6_11", "");
                        cmd.Parameters.AddWithValue("@F_4_6_12", "");
                        cmd.Parameters.AddWithValue("@F_4_6_13", "");
                        cmd.Parameters.AddWithValue("@F_4_6_14", "");
                        cmd.Parameters.AddWithValue("@F_4_6_15", "");
                        cmd.Parameters.AddWithValue("@F_4_6_16", "");
                        cmd.Parameters.AddWithValue("@F_4_6_17", "");
                        cmd.Parameters.AddWithValue("@F_4_6_18", "");
                        cmd.Parameters.AddWithValue("@F_4_6_19", "");
                        cmd.Parameters.AddWithValue("@F_4_6_20", "");
                        cmd.Parameters.AddWithValue("@F_4_6_21", "");
                        cmd.Parameters.AddWithValue("@F_4_6_22", "");
                        cmd.Parameters.AddWithValue("@F_4_6_23", "");
                        cmd.Parameters.AddWithValue("@F_4_6_24", "");
                        cmd.Parameters.AddWithValue("@F_4_6_25", "");
                        cmd.Parameters.AddWithValue("@F_4_6_26", "");
                        cmd.Parameters.AddWithValue("@F_4_6_27", "");
                        cmd.Parameters.AddWithValue("@F_4_6_28", "");
                        cmd.Parameters.AddWithValue("@F_4_6_29", "");
                        cmd.Parameters.AddWithValue("@F_4_6_30", "");
                        cmd.Parameters.AddWithValue("@F_4_6_31", "");
                        cmd.Parameters.AddWithValue("@F_4_6_32", "");
                        cmd.Parameters.AddWithValue("@F_4_6_33", "");
                        cmd.Parameters.AddWithValue("@F_4_6_34", "");
                        cmd.Parameters.AddWithValue("@F_4_6_35", "");
                        cmd.Parameters.AddWithValue("@F_4_6_36", "");
                        cmd.Parameters.AddWithValue("@F_4_6_37", "");
                        cmd.Parameters.AddWithValue("@F_4_6_38", "");
                        cmd.Parameters.AddWithValue("@F_4_6_39", "");
                        cmd.Parameters.AddWithValue("@F_4_6_40", "");
                        cmd.Parameters.AddWithValue("@F_4_6_41", "");
                        cmd.Parameters.AddWithValue("@F_4_6_42", "");

                        cmd.Parameters.AddWithValue("@F_4_7_1", "");
                        cmd.Parameters.AddWithValue("@F_4_7_2", "");
                        cmd.Parameters.AddWithValue("@F_4_7_3", "");
                        cmd.Parameters.AddWithValue("@F_4_7_4", "");
                        cmd.Parameters.AddWithValue("@F_4_7_5", "");
                        cmd.Parameters.AddWithValue("@F_4_7_6", "");
                        cmd.Parameters.AddWithValue("@F_4_7_7", "");
                        cmd.Parameters.AddWithValue("@F_4_7_8", "");
                        cmd.Parameters.AddWithValue("@F_4_7_9", "");
                        cmd.Parameters.AddWithValue("@F_4_7_10", "");
                        cmd.Parameters.AddWithValue("@F_4_7_11", "");
                        cmd.Parameters.AddWithValue("@F_4_7_12", "");
                        cmd.Parameters.AddWithValue("@F_4_7_13", "");
                        cmd.Parameters.AddWithValue("@F_4_7_14", "");
                        cmd.Parameters.AddWithValue("@F_4_7_15", "");
                        cmd.Parameters.AddWithValue("@F_4_7_16", "");
                        cmd.Parameters.AddWithValue("@F_4_7_17", "");
                        cmd.Parameters.AddWithValue("@F_4_7_18", "");
                        cmd.Parameters.AddWithValue("@F_4_7_19", "");
                        cmd.Parameters.AddWithValue("@F_4_7_20", "");
                        cmd.Parameters.AddWithValue("@F_4_7_21", "");
                        cmd.Parameters.AddWithValue("@F_4_7_22", "");
                        cmd.Parameters.AddWithValue("@F_4_7_23", "");
                        cmd.Parameters.AddWithValue("@F_4_7_24", "");
                        cmd.Parameters.AddWithValue("@F_4_7_25", "");
                        cmd.Parameters.AddWithValue("@F_4_7_26", "");
                        cmd.Parameters.AddWithValue("@F_4_7_27", "");
                        cmd.Parameters.AddWithValue("@F_4_7_28", "");
                        cmd.Parameters.AddWithValue("@F_4_7_29", "");
                        cmd.Parameters.AddWithValue("@F_4_7_30", "");
                        cmd.Parameters.AddWithValue("@F_4_7_31", "");
                        cmd.Parameters.AddWithValue("@F_4_7_32", "");
                        cmd.Parameters.AddWithValue("@F_4_7_33", "");
                        cmd.Parameters.AddWithValue("@F_4_7_34", "");
                        cmd.Parameters.AddWithValue("@F_4_7_35", "");
                        cmd.Parameters.AddWithValue("@F_4_7_36", "");
                        cmd.Parameters.AddWithValue("@F_4_7_37", "");
                        cmd.Parameters.AddWithValue("@F_4_7_38", "");
                        cmd.Parameters.AddWithValue("@F_4_7_39", "");
                        cmd.Parameters.AddWithValue("@F_4_7_40", "");
                        cmd.Parameters.AddWithValue("@F_4_7_41", "");
                        cmd.Parameters.AddWithValue("@F_4_7_42", "");
                        cmd.Parameters.AddWithValue("@F_4_7_43", "");
                        cmd.Parameters.AddWithValue("@F_4_7_44", "");
                        cmd.Parameters.AddWithValue("@F_4_7_45", "");
                        cmd.Parameters.AddWithValue("@F_4_7_46", "");
                        cmd.Parameters.AddWithValue("@F_4_7_47", "");
                        cmd.Parameters.AddWithValue("@F_4_7_48", "");
                        cmd.Parameters.AddWithValue("@F_4_7_49", "");
                        cmd.Parameters.AddWithValue("@F_4_7_50", "");
                        cmd.Parameters.AddWithValue("@F_4_7_51", "");
                        cmd.Parameters.AddWithValue("@F_4_7_52", "");
                        cmd.Parameters.AddWithValue("@F_4_7_53", "");
                        cmd.Parameters.AddWithValue("@F_4_7_54", "");
                        cmd.Parameters.AddWithValue("@F_4_7_55", "");
                        cmd.Parameters.AddWithValue("@F_4_7_56", "");
                        cmd.Parameters.AddWithValue("@F_4_7_57", "");
                        cmd.Parameters.AddWithValue("@F_4_7_58", "");
                        cmd.Parameters.AddWithValue("@F_4_7_59", "");
                        cmd.Parameters.AddWithValue("@F_4_7_60", "");
                        cmd.Parameters.AddWithValue("@F_4_7_61", "");

                        cmd.Parameters.AddWithValue("@F_5_1", "");
                        cmd.Parameters.AddWithValue("@F_5_2", "");
                        cmd.Parameters.AddWithValue("@F_5_3", "");
                        cmd.Parameters.AddWithValue("@F_5_4", "");
                        cmd.Parameters.AddWithValue("@F_5_5", "");
                        cmd.Parameters.AddWithValue("@F_5_6", "");
                        cmd.Parameters.AddWithValue("@F_5_7", "");
                        cmd.Parameters.AddWithValue("@F_5_8", "");
                        cmd.Parameters.AddWithValue("@F_5_9", "");
                        cmd.Parameters.AddWithValue("@F_5_10", "");
                        cmd.Parameters.AddWithValue("@F_5_11", "");
                        cmd.Parameters.AddWithValue("@F_5_12", "");
                        cmd.Parameters.AddWithValue("@F_5_13", "");
                        cmd.Parameters.AddWithValue("@F_5_14", "");
                        cmd.Parameters.AddWithValue("@F_5_15", "");
                        cmd.Parameters.AddWithValue("@F_5_16", "");
                        cmd.Parameters.AddWithValue("@F_5_17", "");
                        cmd.Parameters.AddWithValue("@F_5_18", "");
                        cmd.Parameters.AddWithValue("@F_5_19", "");
                        cmd.Parameters.AddWithValue("@F_5_20", "");
                        cmd.Parameters.AddWithValue("@F_5_21", "");
                        cmd.Parameters.AddWithValue("@F_5_22", "");
                        cmd.Parameters.AddWithValue("@F_5_23", "");
                        cmd.Parameters.AddWithValue("@F_5_24", "");
                        cmd.Parameters.AddWithValue("@F_5_25", "");
                        cmd.Parameters.AddWithValue("@F_5_26", "");
                        cmd.Parameters.AddWithValue("@F_5_27", "");
                        cmd.Parameters.AddWithValue("@F_5_28", "");
                        cmd.Parameters.AddWithValue("@F_5_29", "");
                        cmd.Parameters.AddWithValue("@F_5_30", "");
                        cmd.Parameters.AddWithValue("@F_5_31", "");
                        cmd.Parameters.AddWithValue("@F_5_32", "");
                        cmd.Parameters.AddWithValue("@F_5_33", "");
                        cmd.Parameters.AddWithValue("@F_5_34", "");
                        cmd.Parameters.AddWithValue("@F_5_35", "");
                        cmd.Parameters.AddWithValue("@F_5_36", "");
                        cmd.Parameters.AddWithValue("@F_5_37", "");
                        cmd.Parameters.AddWithValue("@F_5_38", "");
                        cmd.Parameters.AddWithValue("@F_5_39", "");
                        cmd.Parameters.AddWithValue("@F_5_40", "");
                        cmd.Parameters.AddWithValue("@F_5_41", "");
                        cmd.Parameters.AddWithValue("@F_5_42", "");
                        cmd.Parameters.AddWithValue("@F_5_43", "");
                        cmd.Parameters.AddWithValue("@F_5_44", "");
                        cmd.Parameters.AddWithValue("@F_5_45", "");
                        cmd.Parameters.AddWithValue("@F_5_46", "");
                        cmd.Parameters.AddWithValue("@F_5_47", "");
                        cmd.Parameters.AddWithValue("@F_5_48", "");
                        cmd.Parameters.AddWithValue("@F_5_49", "");
                        cmd.Parameters.AddWithValue("@F_5_50", "");
                        cmd.Parameters.AddWithValue("@F_5_51", "");
                        cmd.Parameters.AddWithValue("@F_5_52", "");
                        cmd.Parameters.AddWithValue("@F_5_53", "");
                        cmd.Parameters.AddWithValue("@F_5_54", "");
                        cmd.Parameters.AddWithValue("@F_5_55", "");
                        cmd.Parameters.AddWithValue("@F_5_56", "");
                        cmd.Parameters.AddWithValue("@F_5_57", "");

                        cmd.Parameters.AddWithValue("@F_5", "");
                        cmd.Parameters.AddWithValue("@F_6", "");
                        cmd.Parameters.AddWithValue("@F_7", "");
                        cmd.Parameters.AddWithValue("@F_8", "");

                        cmd.Parameters.AddWithValue("@UserName", userName);
                        con.Open();


                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            if (sdr.HasRows)
                            {
                                txtF_1_1.Text = sdr["F_1"].ToString();
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
                                txtEmployer_City.Text = sdr["Employer_City"].ToString();
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
                                txt_F_2_19.Text = sdr["F_2_19"].ToString();
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

                                txtF_4_1_1.Text = sdr["F_4_1_1"].ToString();
                                txtF_4_1_2.Text = sdr["F_4_1_2"].ToString();
                                txtF_4_1_3.Text = sdr["F_4_1_3"].ToString();
                                txtF_4_1_4.Text = sdr["F_4_1_4"].ToString();
                                txtF_4_1_5.Text = sdr["F_4_1_5"].ToString();
                                txtF_4_1_6.Text = sdr["F_4_1_6"].ToString();
                                txtF_4_1_7.Text = sdr["F_4_1_7"].ToString();
                                txtF_4_1_8.Text = sdr["F_4_1_8"].ToString();
                                txtF_4_1_9.Text = sdr["F_4_1_9"].ToString();
                                txtF_4_1_10.Text = sdr["F_4_1_10"].ToString();
                                txtF_4_1_11.Text = sdr["F_4_1_11"].ToString();
                                txtF_4_1_12.Text = sdr["F_4_1_12"].ToString();
                                txtF_4_1_13.Text = sdr["F_4_1_13"].ToString();
                                txtF_4_1_14.Text = sdr["F_4_1_14"].ToString();
                                txtF_4_1_15.Text = sdr["F_4_1_15"].ToString();
                                txtF_4_1_16.Text = sdr["F_4_1_16"].ToString();
                                txtF_4_1_17.Text = sdr["F_4_1_17"].ToString();
                                txtF_4_1_18.Text = sdr["F_4_1_18"].ToString();
                                txtF_4_1_19.Text = sdr["F_4_1_19"].ToString();
                                txtF_4_1_20.Text = sdr["F_4_1_20"].ToString();
                                txtF_4_1_21.Text = sdr["F_4_1_21"].ToString();
                                txtF_4_1_22.Text = sdr["F_4_1_22"].ToString();
                                txtF_4_1_23.Text = sdr["F_4_1_23"].ToString();
                                txtF_4_1_24.Text = sdr["F_4_1_24"].ToString();

                                txtF_4_2_1.Text = sdr["F_4_2_1"].ToString();
                                txtF_4_2_2.Text = sdr["F_4_2_2"].ToString();
                                txtF_4_2_3.Text = sdr["F_4_2_3"].ToString();
                                txtF_4_2_4.Text = sdr["F_4_2_4"].ToString();
                                txtF_4_2_5.Text = sdr["F_4_2_5"].ToString();
                                txtF_4_2_6.Text = sdr["F_4_2_6"].ToString();
                                txtF_4_2_7.Text = sdr["F_4_2_7"].ToString();
                                txtF_4_2_8.Text = sdr["F_4_2_8"].ToString();
                                txtF_4_2_9.Text = sdr["F_4_2_9"].ToString();
                                txtF_4_2_10.Text = sdr["F_4_2_10"].ToString();
                                txtF_4_2_11.Text = sdr["F_4_2_11"].ToString();
                                txtF_4_2_12.Text = sdr["F_4_2_12"].ToString();
                                txtF_4_2_13.Text = sdr["F_4_2_13"].ToString();
                                txtF_4_2_14.Text = sdr["F_4_2_14"].ToString();
                                txtF_4_2_15.Text = sdr["F_4_2_15"].ToString();
                                txtF_4_2_16.Text = sdr["F_4_2_16"].ToString();
                                txtF_4_2_17.Text = sdr["F_4_2_17"].ToString();
                                txtF_4_2_18.Text = sdr["F_4_2_18"].ToString();
                                txtF_4_2_19.Text = sdr["F_4_2_19"].ToString();
                                txtF_4_2_20.Text = sdr["F_4_2_20"].ToString();
                                txtF_4_2_21.Text = sdr["F_4_2_21"].ToString();
                                txtF_4_2_22.Text = sdr["F_4_2_22"].ToString();
                                txtF_4_2_23.Text = sdr["F_4_2_23"].ToString();
                                txtF_4_2_24.Text = sdr["F_4_2_24"].ToString();
                                txtF_4_2_25.Text = sdr["F_4_2_25"].ToString();
                                txtF_4_2_26.Text = sdr["F_4_2_26"].ToString();
                                txtF_4_2_27.Text = sdr["F_4_2_27"].ToString();

                                txtF_4_3_1.Text = sdr["F_4_3_1"].ToString();
                                txtF_4_3_2.Text = sdr["F_4_3_2"].ToString();
                                txtF_4_3_3.Text = sdr["F_4_3_3"].ToString();
                                txtF_4_3_4.Text = sdr["F_4_3_4"].ToString();
                                txtF_4_3_5.Text = sdr["F_4_3_5"].ToString();
                                txtF_4_3_6.Text = sdr["F_4_3_6"].ToString();
                                txtF_4_3_7.Text = sdr["F_4_3_7"].ToString();
                                txtF_4_3_8.Text = sdr["F_4_3_8"].ToString();
                                txtF_4_3_9.Text = sdr["F_4_3_9"].ToString();
                                txtF_4_3_10.Text = sdr["F_4_3_10"].ToString();
                                txtF_4_3_11.Text = sdr["F_4_3_11"].ToString();
                                txtF_4_3_12.Text = sdr["F_4_3_12"].ToString();
                                txtF_4_3_13.Text = sdr["F_4_3_13"].ToString();
                                txtF_4_3_14.Text = sdr["F_4_3_14"].ToString();
                                txtF_4_3_15.Text = sdr["F_4_3_15"].ToString();
                                txtF_4_3_16.Text = sdr["F_4_3_16"].ToString();
                                txtF_4_3_17.Text = sdr["F_4_3_17"].ToString();
                                txtF_4_3_18.Text = sdr["F_4_3_18"].ToString();
                                txtF_4_3_19.Text = sdr["F_4_3_19"].ToString();
                                txtF_4_3_20.Text = sdr["F_4_3_20"].ToString();
                                txtF_4_3_21.Text = sdr["F_4_3_21"].ToString();
                                txtF_4_3_22.Text = sdr["F_4_3_22"].ToString();
                                txtF_4_3_23.Text = sdr["F_4_3_23"].ToString();
                                txtF_4_3_24.Text = sdr["F_4_3_24"].ToString();
                                txtF_4_3_25.Text = sdr["F_4_3_25"].ToString();
                                txtF_4_3_26.Text = sdr["F_4_3_26"].ToString();
                                txtF_4_3_27.Text = sdr["F_4_3_27"].ToString();
                                txtF_4_3_28.Text = sdr["F_4_3_28"].ToString();
                                txtF_4_3_29.Text = sdr["F_4_3_29"].ToString();
                                txtF_4_3_30.Text = sdr["F_4_3_30"].ToString();
                                txtF_4_3_31.Text = sdr["F_4_3_31"].ToString();
                                txtF_4_3_32.Text = sdr["F_4_3_32"].ToString();
                                txtF_4_3_33.Text = sdr["F_4_3_33"].ToString();
                                txtF_4_3_34.Text = sdr["F_4_3_34"].ToString();
                                txtF_4_3_35.Text = sdr["F_4_3_35"].ToString();
                                txtF_4_3_36.Text = sdr["F_4_3_36"].ToString();
                                txtF_4_3_37.Text = sdr["F_4_3_37"].ToString();
                                txtF_4_3_38.Text = sdr["F_4_3_38"].ToString();
                                txtF_4_3_39.Text = sdr["F_4_3_39"].ToString();
                                txtF_4_3_40.Text = sdr["F_4_3_40"].ToString();
                                txtF_4_3_41.Text = sdr["F_4_3_41"].ToString();
                                txtF_4_3_42.Text = sdr["F_4_3_42"].ToString();
                                txtF_4_3_43.Text = sdr["F_4_3_43"].ToString();
                                txtF_4_3_44.Text = sdr["F_4_3_44"].ToString();
                                txtF_4_3_45.Text = sdr["F_4_3_45"].ToString();
                                txtF_4_3_46.Text = sdr["F_4_3_46"].ToString();
                                txtF_4_3_47.Text = sdr["F_4_3_47"].ToString();
                                txtF_4_3_48.Text = sdr["F_4_3_48"].ToString();
                                txtF_4_3_49.Text = sdr["F_4_3_49"].ToString();
                                txtF_4_3_50.Text = sdr["F_4_3_50"].ToString();
                                txtF_4_3_51.Text = sdr["F_4_3_51"].ToString();
                                txtF_4_3_52.Text = sdr["F_4_3_52"].ToString();
                                txtF_4_3_53.Text = sdr["F_4_3_53"].ToString();
                                txtF_4_3_54.Text = sdr["F_4_3_54"].ToString();
                                txtF_4_3_55.Text = sdr["F_4_3_55"].ToString();
                                txtF_4_3_56.Text = sdr["F_4_3_56"].ToString();
                                txtF_4_3_57.Text = sdr["F_4_3_57"].ToString();
                                txtF_4_3_58.Text = sdr["F_4_3_58"].ToString();
                                txtF_4_3_59.Text = sdr["F_4_3_59"].ToString();
                                txtF_4_3_60.Text = sdr["F_4_3_60"].ToString();
                                txtF_4_3_61.Text = sdr["F_4_3_61"].ToString();
                                txtF_4_3_62.Text = sdr["F_4_3_62"].ToString();
                                txtF_4_3_63.Text = sdr["F_4_3_63"].ToString();
                                txtF_4_3_64.Text = sdr["F_4_3_64"].ToString();
                                txtF_4_3_65.Text = sdr["F_4_3_65"].ToString();
                                txtF_4_3_66.Text = sdr["F_4_3_66"].ToString();
                                txtF_4_3_67.Text = sdr["F_4_3_67"].ToString();
                                txtF_4_3_68.Text = sdr["F_4_3_68"].ToString();
                                txtF_4_3_69.Text = sdr["F_4_3_69"].ToString();
                                txtF_4_3_37.Text = sdr["F_4_3_70"].ToString();
                                txtF_4_3_71.Text = sdr["F_4_3_71"].ToString();
                                txtF_4_3_72.Text = sdr["F_4_3_72"].ToString();
                                txtF_4_3_73.Text = sdr["F_4_3_73"].ToString();
                                txtF_4_3_74.Text = sdr["F_4_3_74"].ToString();
                                txtF_4_3_75.Text = sdr["F_4_3_75"].ToString();
                                txtF_4_3_76.Text = sdr["F_4_3_76"].ToString();
                                txtF_4_3_77.Text = sdr["F_4_3_77"].ToString();
                                txtF_4_3_78.Text = sdr["F_4_3_78"].ToString();
                                txtF_4_3_79.Text = sdr["F_4_3_79"].ToString();
                                txtF_4_3_80.Text = sdr["F_4_3_80"].ToString();
                                txtF_4_3_81.Text = sdr["F_4_3_81"].ToString();
                                txtF_4_3_82.Text = sdr["F_4_3_82"].ToString();

                                txtF_4_4_1.Text = sdr["F_4_4_1"].ToString();
                                txtF_4_4_2.Text = sdr["F_4_4_2"].ToString();
                                txtF_4_4_3.Text = sdr["F_4_4_3"].ToString();
                                txtF_4_4_4.Text = sdr["F_4_4_4"].ToString();
                                txtF_4_4_5.Text = sdr["F_4_4_5"].ToString();
                                txtF_4_4_6.Text = sdr["F_4_4_6"].ToString();
                                txtF_4_4_7.Text = sdr["F_4_4_7"].ToString();
                                txtF_4_4_8.Text = sdr["F_4_4_8"].ToString();
                                txtF_4_4_9.Text = sdr["F_4_4_9"].ToString();
                                txtF_4_4_10.Text = sdr["F_4_4_10"].ToString();
                                txtF_4_4_11.Text = sdr["F_4_4_11"].ToString();
                                txtF_4_4_12.Text = sdr["F_4_4_12"].ToString();
                                txtF_4_4_13.Text = sdr["F_4_4_13"].ToString();
                                txtF_4_4_14.Text = sdr["F_4_4_14"].ToString();
                                txtF_4_4_15.Text = sdr["F_4_4_15"].ToString();
                                txtF_4_4_16.Text = sdr["F_4_4_16"].ToString();
                                txtF_4_4_17.Text = sdr["F_4_4_17"].ToString();
                                txtF_4_4_18.Text = sdr["F_4_4_18"].ToString();
                                txtF_4_4_19.Text = sdr["F_4_4_19"].ToString();
                                txtF_4_4_20.Text = sdr["F_4_4_20"].ToString();
                                txtF_4_4_21.Text = sdr["F_4_4_21"].ToString();
                                txtF_4_4_22.Text = sdr["F_4_4_22"].ToString();
                                txtF_4_4_23.Text = sdr["F_4_4_23"].ToString();
                                txtF_4_4_24.Text = sdr["F_4_4_24"].ToString();
                                txtF_4_4_25.Text = sdr["F_4_4_25"].ToString();
                                txtF_4_4_26.Text = sdr["F_4_4_26"].ToString();
                                txtF_4_4_27.Text = sdr["F_4_4_27"].ToString();
                                txtF_4_4_28.Text = sdr["F_4_4_28"].ToString();
                                txtF_4_4_29.Text = sdr["F_4_4_29"].ToString();
                                txtF_4_4_30.Text = sdr["F_4_4_30"].ToString();
                                txtF_4_4_31.Text = sdr["F_4_4_31"].ToString();
                                txtF_4_4_32.Text = sdr["F_4_4_32"].ToString();
                                txtF_4_4_33.Text = sdr["F_4_4_33"].ToString();
                                txtF_4_4_34.Text = sdr["F_4_4_34"].ToString();
                                txtF_4_4_35.Text = sdr["F_4_4_35"].ToString();
                                txtF_4_4_36.Text = sdr["F_4_4_36"].ToString();
                                txtF_4_4_37.Text = sdr["F_4_4_37"].ToString();
                                txtF_4_4_38.Text = sdr["F_4_4_38"].ToString();
                                txtF_4_4_39.Text = sdr["F_4_4_39"].ToString();
                                txtF_4_4_40.Text = sdr["F_4_4_40"].ToString();
                                txtF_4_4_41.Text = sdr["F_4_4_41"].ToString();
                                txtF_4_4_42.Text = sdr["F_4_4_42"].ToString();
                                txtF_4_4_43.Text = sdr["F_4_4_43"].ToString();
                                txtF_4_4_44.Text = sdr["F_4_4_44"].ToString();
                                txtF_4_4_45.Text = sdr["F_4_4_45"].ToString();
                                txtF_4_4_46.Text = sdr["F_4_4_46"].ToString();
                                txtF_4_4_47.Text = sdr["F_4_4_47"].ToString();
                                txtF_4_4_48.Text = sdr["F_4_4_48"].ToString();
                                txtF_4_4_49.Text = sdr["F_4_4_49"].ToString();
                                txtF_4_4_50.Text = sdr["F_4_4_50"].ToString();
                                txtF_4_4_51.Text = sdr["F_4_4_51"].ToString();
                                txtF_4_4_52.Text = sdr["F_4_4_52"].ToString();
                                txtF_4_4_53.Text = sdr["F_4_4_53"].ToString();
                                txtF_4_4_54.Text = sdr["F_4_4_54"].ToString();
                                txtF_4_4_55.Text = sdr["F_4_4_55"].ToString();
                                txtF_4_4_56.Text = sdr["F_4_4_56"].ToString();

                                txtF_4_5_1.Text = sdr["F_4_5_1"].ToString();
                                txtF_4_5_2.Text = sdr["F_4_5_2"].ToString();
                                txtF_4_5_3.Text = sdr["F_4_5_3"].ToString();
                                txtF_4_5_4.Text = sdr["F_4_5_4"].ToString();
                                txtF_4_5_5.Text = sdr["F_4_5_5"].ToString();
                                txtF_4_5_6.Text = sdr["F_4_5_6"].ToString();
                                txtF_4_5_7.Text = sdr["F_4_5_7"].ToString();
                                txtF_4_5_8.Text = sdr["F_4_5_8"].ToString();
                                txtF_4_5_9.Text = sdr["F_4_5_9"].ToString();
                                txtF_4_5_10.Text = sdr["F_4_5_10"].ToString();
                                txtF_4_5_11.Text = sdr["F_4_5_11"].ToString();
                                txtF_4_5_12.Text = sdr["F_4_5_12"].ToString();
                                txtF_4_5_13.Text = sdr["F_4_5_13"].ToString();
                                txtF_4_5_14.Text = sdr["F_4_5_14"].ToString();
                                txtF_4_5_15.Text = sdr["F_4_5_15"].ToString();
                                txtF_4_5_16.Text = sdr["F_4_5_16"].ToString();
                                txtF_4_5_17.Text = sdr["F_4_5_17"].ToString();
                                txtF_4_5_18.Text = sdr["F_4_5_18"].ToString();
                                txtF_4_5_19.Text = sdr["F_4_5_19"].ToString();
                                txtF_4_5_20.Text = sdr["F_4_5_20"].ToString();
                                txtF_4_5_21.Text = sdr["F_4_5_21"].ToString();
                                txtF_4_5_22.Text = sdr["F_4_5_22"].ToString();
                                txtF_4_5_23.Text = sdr["F_4_5_23"].ToString();
                                txtF_4_5_24.Text = sdr["F_4_5_24"].ToString();
                                txtF_4_5_25.Text = sdr["F_4_5_25"].ToString();
                                txtF_4_5_26.Text = sdr["F_4_5_26"].ToString();
                                txtF_4_5_27.Text = sdr["F_4_5_27"].ToString();
                                txtF_4_5_28.Text = sdr["F_4_5_28"].ToString();
                                txtF_4_5_29.Text = sdr["F_4_5_29"].ToString();
                                txtF_4_5_30.Text = sdr["F_4_5_30"].ToString();
                                txtF_4_5_31.Text = sdr["F_4_5_31"].ToString();


                                txtF_4_6_1.Text = sdr["F_4_6_1"].ToString();
                                txtF_4_6_2.Text = sdr["F_4_6_2"].ToString();
                                txtF_4_6_3.Text = sdr["F_4_6_3"].ToString();
                                txtF_4_6_4.Text = sdr["F_4_6_4"].ToString();
                                txtF_4_6_5.Text = sdr["F_4_6_5"].ToString();
                                txtF_4_6_6.Text = sdr["F_4_6_6"].ToString();
                                txtF_4_6_7.Text = sdr["F_4_6_7"].ToString();
                                txtF_4_6_8.Text = sdr["F_4_6_8"].ToString();
                                txtF_4_6_9.Text = sdr["F_4_6_9"].ToString();
                                txtF_4_6_10.Text = sdr["F_4_6_10"].ToString();
                                txtF_4_6_11.Text = sdr["F_4_6_11"].ToString();
                                txtF_4_6_12.Text = sdr["F_4_6_12"].ToString();
                                txtF_4_6_13.Text = sdr["F_4_6_13"].ToString();
                                txtF_4_6_14.Text = sdr["F_4_6_14"].ToString();
                                txtF_4_6_15.Text = sdr["F_4_6_15"].ToString();
                                txtF_4_6_16.Text = sdr["F_4_6_16"].ToString();
                                txtF_4_6_17.Text = sdr["F_4_6_17"].ToString();
                                txtF_4_6_18.Text = sdr["F_4_6_18"].ToString();
                                txtF_4_6_19.Text = sdr["F_4_6_19"].ToString();
                                txtF_4_6_20.Text = sdr["F_4_6_20"].ToString();
                                txtF_4_6_21.Text = sdr["F_4_6_21"].ToString();
                                txtF_4_6_22.Text = sdr["F_4_6_22"].ToString();
                                txtF_4_6_23.Text = sdr["F_4_6_23"].ToString();
                                txtF_4_6_24.Text = sdr["F_4_6_24"].ToString();
                                txtF_4_6_25.Text = sdr["F_4_6_25"].ToString();
                                txtF_4_6_26.Text = sdr["F_4_6_26"].ToString();
                                txtF_4_6_27.Text = sdr["F_4_6_27"].ToString();
                                txtF_4_6_28.Text = sdr["F_4_6_28"].ToString();
                                txtF_4_6_29.Text = sdr["F_4_6_29"].ToString();
                                txtF_4_6_30.Text = sdr["F_4_6_30"].ToString();
                                txtF_4_6_31.Text = sdr["F_4_6_31"].ToString();
                                txtF_4_6_32.Text = sdr["F_4_6_32"].ToString();
                                txtF_4_6_33.Text = sdr["F_4_6_33"].ToString();
                                txtF_4_6_34.Text = sdr["F_4_6_34"].ToString();
                                txtF_4_6_35.Text = sdr["F_4_6_35"].ToString();
                                txtF_4_6_36.Text = sdr["F_4_6_36"].ToString();
                                txtF_4_6_37.Text = sdr["F_4_6_37"].ToString();
                                txtF_4_6_38.Text = sdr["F_4_6_38"].ToString();
                                txtF_4_6_39.Text = sdr["F_4_6_39"].ToString();
                                txtF_4_6_40.Text = sdr["F_4_6_40"].ToString();
                                txtF_4_6_41.Text = sdr["F_4_6_41"].ToString();
                                txtF_4_6_42.Text = sdr["F_4_6_42"].ToString();

                                txtF_4_7_1.Text = sdr["F_4_7_1"].ToString();
                                txtF_4_7_2.Text = sdr["F_4_7_2"].ToString();
                                txtF_4_7_3.Text = sdr["F_4_7_3"].ToString();
                                txtF_4_7_4.Text = sdr["F_4_7_4"].ToString();
                                txtF_4_7_5.Text = sdr["F_4_7_5"].ToString();
                                txtF_4_7_6.Text = sdr["F_4_7_6"].ToString();
                                txtF_4_7_7.Text = sdr["F_4_7_7"].ToString();
                                txtF_4_7_8.Text = sdr["F_4_7_8"].ToString();
                                txtF_4_7_9.Text = sdr["F_4_7_9"].ToString();
                                txtF_4_7_10.Text = sdr["F_4_7_10"].ToString();
                                txtF_4_7_11.Text = sdr["F_4_7_11"].ToString();
                                txtF_4_7_12.Text = sdr["F_4_7_12"].ToString();
                                txtF_4_7_13.Text = sdr["F_4_7_13"].ToString();
                                txtF_4_7_14.Text = sdr["F_4_7_14"].ToString();
                                txtF_4_7_15.Text = sdr["F_4_7_15"].ToString();
                                txtF_4_7_16.Text = sdr["F_4_7_16"].ToString();
                                txtF_4_7_17.Text = sdr["F_4_7_17"].ToString();
                                txtF_4_7_18.Text = sdr["F_4_7_18"].ToString();
                                txtF_4_7_19.Text = sdr["F_4_7_19"].ToString();
                                txtF_4_7_20.Text = sdr["F_4_7_20"].ToString();
                                txtF_4_7_21.Text = sdr["F_4_7_21"].ToString();
                                txtF_4_7_22.Text = sdr["F_4_7_22"].ToString();
                                txtF_4_7_23.Text = sdr["F_4_7_23"].ToString();
                                txtF_4_7_24.Text = sdr["F_4_7_24"].ToString();
                                txtF_4_7_25.Text = sdr["F_4_7_25"].ToString();
                                txtF_4_7_26.Text = sdr["F_4_7_26"].ToString();
                                txtF_4_7_27.Text = sdr["F_4_7_27"].ToString();
                                txtF_4_7_28.Text = sdr["F_4_7_28"].ToString();
                                txtF_4_7_29.Text = sdr["F_4_7_29"].ToString();
                                txtF_4_7_30.Text = sdr["F_4_7_30"].ToString();
                                txtF_4_7_31.Text = sdr["F_4_7_31"].ToString();
                                txtF_4_7_32.Text = sdr["F_4_7_32"].ToString();
                                txtF_4_7_33.Text = sdr["F_4_7_33"].ToString();
                                txtF_4_7_34.Text = sdr["F_4_7_34"].ToString();
                                txtF_4_7_35.Text = sdr["F_4_7_35"].ToString();
                                txtF_4_7_36.Text = sdr["F_4_7_36"].ToString();
                                txtF_4_7_37.Text = sdr["F_4_7_37"].ToString();
                                txtF_4_7_38.Text = sdr["F_4_7_38"].ToString();
                                txtF_4_7_39.Text = sdr["F_4_7_39"].ToString();
                                txtF_4_7_40.Text = sdr["F_4_7_40"].ToString();
                                txtF_4_7_41.Text = sdr["F_4_7_41"].ToString();
                                txtF_4_7_42.Text = sdr["F_4_7_42"].ToString();
                                txtF_4_7_43.Text = sdr["F_4_7_43"].ToString();
                                txtF_4_7_44.Text = sdr["F_4_7_44"].ToString();
                                txtF_4_7_45.Text = sdr["F_4_7_45"].ToString();
                                txtF_4_7_46.Text = sdr["F_4_7_46"].ToString();
                                txtF_4_7_47.Text = sdr["F_4_7_47"].ToString();
                                txtF_4_7_48.Text = sdr["F_4_7_48"].ToString();
                                txtF_4_7_49.Text = sdr["F_4_7_49"].ToString();
                                txtF_4_7_50.Text = sdr["F_4_7_50"].ToString();
                                txtF_4_7_51.Text = sdr["F_4_7_51"].ToString();
                                txtF_4_7_52.Text = sdr["F_4_7_52"].ToString();
                                txtF_4_7_53.Text = sdr["F_4_7_53"].ToString();
                                txtF_4_7_54.Text = sdr["F_4_7_54"].ToString();
                                txtF_4_7_55.Text = sdr["F_4_7_55"].ToString();
                                txtF_4_7_56.Text = sdr["F_4_7_56"].ToString();
                                txtF_4_7_57.Text = sdr["F_4_7_57"].ToString();
                                txtF_4_7_58.Text = sdr["F_4_7_58"].ToString();
                                txtF_4_7_59.Text = sdr["F_4_7_59"].ToString();
                                txtF_4_7_60.Text = sdr["F_4_7_60"].ToString();
                                txtF_4_7_61.Text = sdr["F_4_7_61"].ToString();

                                txtF_5_1.Text = sdr["F_5_1"].ToString();
                                txtF_5_2.Text = sdr["F_5_2"].ToString();
                                txtF_5_3.Text = sdr["F_5_3"].ToString();
                                txtF_5_4.Text = sdr["F_5_4"].ToString();
                                txtF_5_5.Text = sdr["F_5_5"].ToString();
                                txtF_5_6.Text = sdr["F_5_6"].ToString();
                                txtF_5_7.Text = sdr["F_5_7"].ToString();
                                txtF_5_8.Text = sdr["F_5_8"].ToString();
                                txtF_5_9.Text = sdr["F_5_9"].ToString();
                                txtF_5_10.Text = sdr["F_5_10"].ToString();
                                txtF_5_11.Text = sdr["F_5_11"].ToString();
                                txtF_5_12.Text = sdr["F_5_12"].ToString();
                                txtF_5_13.Text = sdr["F_5_13"].ToString();
                                txtF_5_14.Text = sdr["F_5_14"].ToString();
                                txtF_5_15.Text = sdr["F_5_15"].ToString();
                                txtF_5_16.Text = sdr["F_5_16"].ToString();
                                txtF_5_17.Text = sdr["F_5_17"].ToString();
                                txtF_5_18.Text = sdr["F_5_18"].ToString();
                                txtF_5_19.Text = sdr["F_5_19"].ToString();
                                txtF_5_20.Text = sdr["F_5_20"].ToString();
                                txtF_5_21.Text = sdr["F_5_21"].ToString();
                                txtF_5_22.Text = sdr["F_5_22"].ToString();
                                txtF_5_23.Text = sdr["F_5_23"].ToString();
                                txtF_5_24.Text = sdr["F_5_24"].ToString();
                                txtF_5_25.Text = sdr["F_5_25"].ToString();
                                txtF_5_26.Text = sdr["F_5_26"].ToString();
                                txtF_5_27.Text = sdr["F_5_27"].ToString();
                                txtF_5_28.Text = sdr["F_5_28"].ToString();
                                txtF_5_29.Text = sdr["F_5_29"].ToString();
                                txtF_5_30.Text = sdr["F_5_30"].ToString();
                                txtF_5_31.Text = sdr["F_5_31"].ToString();
                                txtF_5_32.Text = sdr["F_5_32"].ToString();
                                txtF_5_33.Text = sdr["F_5_33"].ToString();
                                txtF_5_34.Text = sdr["F_5_34"].ToString();
                                txtF_5_35.Text = sdr["F_5_35"].ToString();
                                txtF_5_36.Text = sdr["F_5_36"].ToString();
                                txtF_5_37.Text = sdr["F_5_37"].ToString();
                                txtF_5_38.Text = sdr["F_5_38"].ToString();
                                txtF_5_39.Text = sdr["F_5_39"].ToString();
                                txtF_5_40.Text = sdr["F_5_40"].ToString();
                                txtF_5_41.Text = sdr["F_5_41"].ToString();
                                txtF_5_42.Text = sdr["F_5_42"].ToString();
                                txtF_5_43.Text = sdr["F_5_43"].ToString();
                                txtF_5_44.Text = sdr["F_5_44"].ToString();
                                txtF_5_45.Text = sdr["F_5_45"].ToString();
                                txtF_5_46.Text = sdr["F_5_46"].ToString();
                                txtF_5_47.Text = sdr["F_5_47"].ToString();
                                txtF_5_48.Text = sdr["F_5_48"].ToString();
                                txtF_5_49.Text = sdr["F_5_49"].ToString();
                                txtF_5_50.Text = sdr["F_5_50"].ToString();
                                txtF_5_51.Text = sdr["F_5_51"].ToString();
                                txtF_5_52.Text = sdr["F_5_52"].ToString();
                                txtF_5_53.Text = sdr["F_5_53"].ToString();
                                txtF_5_54.Text = sdr["F_5_54"].ToString();
                                txtF_5_55.Text = sdr["F_5_55"].ToString();
                                txtF_5_56.Text = sdr["F_5_56"].ToString();
                                txtF_5_57.Text = sdr["F_5_57"].ToString();

                                txtF_5.Text = sdr["F_5"].ToString();
                                txtF_6.Text = sdr["F_6"].ToString();
                                txtF_7.Text = sdr["F_7"].ToString();
                                txtF_8.Text = sdr["F_8"].ToString();


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

                //double F_2_1 = Convert.ToDouble(txtF_2_1.Text);
                //double F_2_2 = Convert.ToDouble(txtF_2_2.Text);
                //double F_2_3 = Convert.ToDouble(txtF_2_3.Text);
                //double F_2_4 = Convert.ToDouble(txtF_2_4.Text);
                //double F_2_5 = Convert.ToDouble(txtF_2_5.Text);
                //double F_2_6 = Convert.ToDouble(txtF_2_6.Text);
                //double F_2_7 = Convert.ToDouble(txtF_2_7.Text);
                //double F_2_8 = Convert.ToDouble(txtF_2_8.Text);
                //double F_2_9 = F_2_1 + F_2_2 + F_2_3 + F_2_4 + F_2_5 + F_2_6 + F_2_7 + F_2_8;
                //txtF_2_9.Text = F_2_9.ToString();



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

        protected void Save_LF_Header(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_Header_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_1", "");
                    cmd.Parameters.AddWithValue("@F_2", "");
                    cmd.Parameters.AddWithValue("@F_3", "");
                    cmd.Parameters.AddWithValue("@F_4", "");
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_Header_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_1", txtF_1_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2", txtF_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_3", txtF_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4", txtF_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        protected void Save_LF_GeneralInformation(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_GeneralInformation_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_GeneralInformation_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        protected void Save_LF_IncomeStatement(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_IncomeStatement_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_IncomeStatement_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
                    cmd.Parameters.AddWithValue("@F_2_19", txt_F_2_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_2_20", txtF_2_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


        protected void Save_LF_ExpensesStatement(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_ExpensesStatement_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
                using (SqlCommand cmd = new SqlCommand("LF_ExpensesStatement_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
        }

        protected void Save_LF_StatementOfassets_A(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_StatementOfAssets_A_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_4_1_1", "");
                    cmd.Parameters.AddWithValue("@F_4_1_2", "");
                    cmd.Parameters.AddWithValue("@F_4_1_3", "");
                    cmd.Parameters.AddWithValue("@F_4_1_4", "");
                    cmd.Parameters.AddWithValue("@F_4_1_5", "");
                    cmd.Parameters.AddWithValue("@F_4_1_6", "");
                    cmd.Parameters.AddWithValue("@F_4_1_7", "");
                    cmd.Parameters.AddWithValue("@F_4_1_8", "");
                    cmd.Parameters.AddWithValue("@F_4_1_9", "");
                    cmd.Parameters.AddWithValue("@F_4_1_10", "");
                    cmd.Parameters.AddWithValue("@F_4_1_11", "");
                    cmd.Parameters.AddWithValue("@F_4_1_12", "");
                    cmd.Parameters.AddWithValue("@F_4_1_13", "");
                    cmd.Parameters.AddWithValue("@F_4_1_14", "");
                    cmd.Parameters.AddWithValue("@F_4_1_15", "");
                    cmd.Parameters.AddWithValue("@F_4_1_16", "");
                    cmd.Parameters.AddWithValue("@F_4_1_17", "");
                    cmd.Parameters.AddWithValue("@F_4_1_18", "");
                    cmd.Parameters.AddWithValue("@F_4_1_19", "");
                    cmd.Parameters.AddWithValue("@F_4_1_20", "");
                    cmd.Parameters.AddWithValue("@F_4_1_21", "");
                    cmd.Parameters.AddWithValue("@F_4_1_22", "");
                    cmd.Parameters.AddWithValue("@F_4_1_23", "");
                    cmd.Parameters.AddWithValue("@F_4_1_24", "");
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_StatementOfAssets_A_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_4_1_1", txtF_4_1_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_2", txtF_4_1_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_3", txtF_4_1_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_4", txtF_4_1_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_5", txtF_4_1_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_6", txtF_4_1_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_7", txtF_4_1_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_8", txtF_4_1_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_9", txtF_4_1_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_10", txtF_4_1_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_11", txtF_4_1_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_12", txtF_4_1_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_13", txtF_4_1_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_14", txtF_4_1_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_15", txtF_4_1_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_16", txtF_4_1_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_17", txtF_4_1_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_18", txtF_4_1_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_19", txtF_4_1_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_20", txtF_4_1_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_21", txtF_4_1_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_22", txtF_4_1_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_23", txtF_4_1_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_24", txtF_4_1_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


        protected void Save_LF_StatementOfassets_B(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_StatementOfAssets_B_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_4_2_1", "");
                    cmd.Parameters.AddWithValue("@F_4_2_2", "");
                    cmd.Parameters.AddWithValue("@F_4_2_3", "");
                    cmd.Parameters.AddWithValue("@F_4_2_4", "");
                    cmd.Parameters.AddWithValue("@F_4_2_5", "");
                    cmd.Parameters.AddWithValue("@F_4_2_6", "");
                    cmd.Parameters.AddWithValue("@F_4_2_7", "");
                    cmd.Parameters.AddWithValue("@F_4_2_8", "");
                    cmd.Parameters.AddWithValue("@F_4_2_9", "");
                    cmd.Parameters.AddWithValue("@F_4_2_10", "");
                    cmd.Parameters.AddWithValue("@F_4_2_11", "");
                    cmd.Parameters.AddWithValue("@F_4_2_12", "");
                    cmd.Parameters.AddWithValue("@F_4_2_13", "");
                    cmd.Parameters.AddWithValue("@F_4_2_14", "");
                    cmd.Parameters.AddWithValue("@F_4_2_15", "");
                    cmd.Parameters.AddWithValue("@F_4_2_16", "");
                    cmd.Parameters.AddWithValue("@F_4_2_17", "");
                    cmd.Parameters.AddWithValue("@F_4_2_18", "");
                    cmd.Parameters.AddWithValue("@F_4_2_19", "");
                    cmd.Parameters.AddWithValue("@F_4_2_20", "");
                    cmd.Parameters.AddWithValue("@F_4_2_21", "");
                    cmd.Parameters.AddWithValue("@F_4_2_22", "");
                    cmd.Parameters.AddWithValue("@F_4_2_23", "");
                    cmd.Parameters.AddWithValue("@F_4_2_24", "");
                    cmd.Parameters.AddWithValue("@F_4_2_25", "");
                    cmd.Parameters.AddWithValue("@F_4_2_26", "");
                    cmd.Parameters.AddWithValue("@F_4_2_27", "");
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_StatementOfAssets_B_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_4_2_1", txtF_4_2_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_2", txtF_4_2_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_3", txtF_4_2_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_4", txtF_4_2_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_5", txtF_4_2_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_6", txtF_4_2_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_7", txtF_4_2_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_8", txtF_4_2_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_9", txtF_4_2_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_10", txtF_4_2_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_11", txtF_4_2_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_12", txtF_4_2_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_13", txtF_4_2_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_14", txtF_4_2_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_15", txtF_4_2_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_16", txtF_4_2_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_17", txtF_4_2_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_18", txtF_4_2_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_19", txtF_4_2_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_20", txtF_4_2_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_21", txtF_4_2_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_22", txtF_4_2_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_23", txtF_4_2_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_24", txtF_4_2_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_25", txtF_4_2_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_26", txtF_4_2_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_27", txtF_4_2_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        protected void Save_LF_StatementOfassets_C(object sender, EventArgs e)

        {
            string userName = string.Empty;

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_StatementOfAssets_C_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_4_3_1", "");
                    cmd.Parameters.AddWithValue("@F_4_3_2", "");
                    cmd.Parameters.AddWithValue("@F_4_3_3", "");
                    cmd.Parameters.AddWithValue("@F_4_3_4", "");
                    cmd.Parameters.AddWithValue("@F_4_3_5", "");
                    cmd.Parameters.AddWithValue("@F_4_3_6", "");
                    cmd.Parameters.AddWithValue("@F_4_3_7", "");
                    cmd.Parameters.AddWithValue("@F_4_3_8", "");
                    cmd.Parameters.AddWithValue("@F_4_3_9", "");
                    cmd.Parameters.AddWithValue("@F_4_3_10", "");
                    cmd.Parameters.AddWithValue("@F_4_3_11", "");
                    cmd.Parameters.AddWithValue("@F_4_3_12", "");
                    cmd.Parameters.AddWithValue("@F_4_3_13", "");
                    cmd.Parameters.AddWithValue("@F_4_3_14", "");
                    cmd.Parameters.AddWithValue("@F_4_3_15", "");
                    cmd.Parameters.AddWithValue("@F_4_3_16", "");
                    cmd.Parameters.AddWithValue("@F_4_3_17", "");
                    cmd.Parameters.AddWithValue("@F_4_3_18", "");
                    cmd.Parameters.AddWithValue("@F_4_3_19", "");
                    cmd.Parameters.AddWithValue("@F_4_3_20", "");
                    cmd.Parameters.AddWithValue("@F_4_3_21", "");
                    cmd.Parameters.AddWithValue("@F_4_3_22", "");
                    cmd.Parameters.AddWithValue("@F_4_3_23", "");
                    cmd.Parameters.AddWithValue("@F_4_3_24", "");
                    cmd.Parameters.AddWithValue("@F_4_3_25", "");
                    cmd.Parameters.AddWithValue("@F_4_3_26", "");
                    cmd.Parameters.AddWithValue("@F_4_3_27", "");
                    cmd.Parameters.AddWithValue("@F_4_3_28", "");
                    cmd.Parameters.AddWithValue("@F_4_3_29", "");
                    cmd.Parameters.AddWithValue("@F_4_3_30", "");
                    cmd.Parameters.AddWithValue("@F_4_3_31", "");
                    cmd.Parameters.AddWithValue("@F_4_3_32", "");
                    cmd.Parameters.AddWithValue("@F_4_3_33", "");
                    cmd.Parameters.AddWithValue("@F_4_3_34", "");
                    cmd.Parameters.AddWithValue("@F_4_3_35", "");
                    cmd.Parameters.AddWithValue("@F_4_3_36", "");
                    cmd.Parameters.AddWithValue("@F_4_3_37", "");
                    cmd.Parameters.AddWithValue("@F_4_3_38", "");
                    cmd.Parameters.AddWithValue("@F_4_3_39", "");
                    cmd.Parameters.AddWithValue("@F_4_3_40", "");
                    cmd.Parameters.AddWithValue("@F_4_3_41", "");
                    cmd.Parameters.AddWithValue("@F_4_3_42", "");
                    cmd.Parameters.AddWithValue("@F_4_3_43", "");
                    cmd.Parameters.AddWithValue("@F_4_3_44", "");
                    cmd.Parameters.AddWithValue("@F_4_3_45", "");
                    cmd.Parameters.AddWithValue("@F_4_3_46", "");
                    cmd.Parameters.AddWithValue("@F_4_3_47", "");
                    cmd.Parameters.AddWithValue("@F_4_3_48", "");
                    cmd.Parameters.AddWithValue("@F_4_3_49", "");
                    cmd.Parameters.AddWithValue("@F_4_3_50", "");
                    cmd.Parameters.AddWithValue("@F_4_3_51", "");
                    cmd.Parameters.AddWithValue("@F_4_3_52", "");
                    cmd.Parameters.AddWithValue("@F_4_3_53", "");
                    cmd.Parameters.AddWithValue("@F_4_3_54", "");
                    cmd.Parameters.AddWithValue("@F_4_3_55", "");
                    cmd.Parameters.AddWithValue("@F_4_3_56", "");
                    cmd.Parameters.AddWithValue("@F_4_3_57", "");
                    cmd.Parameters.AddWithValue("@F_4_3_58", "");
                    cmd.Parameters.AddWithValue("@F_4_3_59", "");
                    cmd.Parameters.AddWithValue("@F_4_3_60", "");
                    cmd.Parameters.AddWithValue("@F_4_3_61", "");
                    cmd.Parameters.AddWithValue("@F_4_3_62", "");
                    cmd.Parameters.AddWithValue("@F_4_3_63", "");
                    cmd.Parameters.AddWithValue("@F_4_3_64", "");
                    cmd.Parameters.AddWithValue("@F_4_3_65", "");
                    cmd.Parameters.AddWithValue("@F_4_3_66", "");
                    cmd.Parameters.AddWithValue("@F_4_3_67", "");
                    cmd.Parameters.AddWithValue("@F_4_3_68", "");
                    cmd.Parameters.AddWithValue("@F_4_3_69", "");
                    cmd.Parameters.AddWithValue("@F_4_3_70", "");
                    cmd.Parameters.AddWithValue("@F_4_3_71", "");
                    cmd.Parameters.AddWithValue("@F_4_3_72", "");
                    cmd.Parameters.AddWithValue("@F_4_3_73", "");
                    cmd.Parameters.AddWithValue("@F_4_3_74", "");
                    cmd.Parameters.AddWithValue("@F_4_3_75", "");
                    cmd.Parameters.AddWithValue("@F_4_3_76", "");
                    cmd.Parameters.AddWithValue("@F_4_3_77", "");
                    cmd.Parameters.AddWithValue("@F_4_3_78", "");
                    cmd.Parameters.AddWithValue("@F_4_3_79", "");
                    cmd.Parameters.AddWithValue("@F_4_3_80", "");
                    cmd.Parameters.AddWithValue("@F_4_3_81", "");
                    cmd.Parameters.AddWithValue("@F_4_3_82", "");
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_StatementOfAssets_C_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
                    cmd.Parameters.AddWithValue("@F_4_3_1", txtF_4_3_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_2", txtF_4_3_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_3", txtF_4_3_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_4", txtF_4_3_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_5", txtF_4_3_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_6", txtF_4_3_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_7", txtF_4_3_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_8", txtF_4_3_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_9", txtF_4_3_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_10", txtF_4_3_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_11", txtF_4_3_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_12", txtF_4_3_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_13", txtF_4_3_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_14", txtF_4_3_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_15", txtF_4_3_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_16", txtF_4_3_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_17", txtF_4_3_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_18", txtF_4_3_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_19", txtF_4_3_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_20", txtF_4_3_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_21", txtF_4_3_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_22", txtF_4_3_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_23", txtF_4_3_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_24", txtF_4_3_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_25", txtF_4_3_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_26", txtF_4_3_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_27", txtF_4_3_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_28", txtF_4_3_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_29", txtF_4_3_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_30", txtF_4_3_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_31", txtF_4_3_31.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_32", txtF_4_3_32.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_33", txtF_4_3_33.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_34", txtF_4_3_34.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_35", txtF_4_3_35.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_36", txtF_4_3_36.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_37", txtF_4_3_37.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_38", txtF_4_3_38.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_39", txtF_4_3_39.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_40", txtF_4_3_40.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_41", txtF_4_3_41.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_42", txtF_4_3_42.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_43", txtF_4_3_43.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_44", txtF_4_3_44.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_45", txtF_4_3_45.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_46", txtF_4_3_46.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_47", txtF_4_3_47.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_48", txtF_4_3_48.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_49", txtF_4_3_49.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_50", txtF_4_3_50.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_51", txtF_4_3_51.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_52", txtF_4_3_52.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_53", txtF_4_3_53.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_54", txtF_4_3_54.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_55", txtF_4_3_55.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_56", txtF_4_3_56.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_57", txtF_4_3_57.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_58", txtF_4_3_58.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_59", txtF_4_3_59.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_60", txtF_4_3_60.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_61", txtF_4_3_61.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_62", txtF_4_3_62.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_63", txtF_4_3_63.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_64", txtF_4_3_64.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_65", txtF_4_3_65.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_66", txtF_4_3_66.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_67", txtF_4_3_67.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_68", txtF_4_3_68.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_69", txtF_4_3_69.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_70", txtF_4_3_70.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_71", txtF_4_3_71.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_72", txtF_4_3_72.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_73", txtF_4_3_73.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_74", txtF_4_3_74.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_75", txtF_4_3_75.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_76", txtF_4_3_76.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_77", txtF_4_3_77.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_78", txtF_4_3_78.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_79", txtF_4_3_79.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_80", txtF_4_3_80.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_81", txtF_4_3_81.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_82", txtF_4_3_82.Text.ToString());
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        protected void Save_LF(object sender, EventArgs e)

        {
            string userName = string.Empty;
            //string m_txtF_1;
            //double a = Convert.ToDouble(txtF_2_1.Text);

            userName = HttpContext.Current.User.Identity.Name;

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("LF_A_1_CRUD"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    //cmd.Parameters.AddWithValue("@idAgencija", idAgencija);
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
                    cmd.Parameters.AddWithValue("@Employer_City", "");
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

                    cmd.Parameters.AddWithValue("@F_4_1_1", "");
                    cmd.Parameters.AddWithValue("@F_4_1_2", "");
                    cmd.Parameters.AddWithValue("@F_4_1_3", "");
                    cmd.Parameters.AddWithValue("@F_4_1_4", "");
                    cmd.Parameters.AddWithValue("@F_4_1_5", "");
                    cmd.Parameters.AddWithValue("@F_4_1_6", "");
                    cmd.Parameters.AddWithValue("@F_4_1_7", "");
                    cmd.Parameters.AddWithValue("@F_4_1_8", "");
                    cmd.Parameters.AddWithValue("@F_4_1_9", "");
                    cmd.Parameters.AddWithValue("@F_4_1_10", "");
                    cmd.Parameters.AddWithValue("@F_4_1_11", "");
                    cmd.Parameters.AddWithValue("@F_4_1_12", "");
                    cmd.Parameters.AddWithValue("@F_4_1_13", "");
                    cmd.Parameters.AddWithValue("@F_4_1_14", "");
                    cmd.Parameters.AddWithValue("@F_4_1_15", "");
                    cmd.Parameters.AddWithValue("@F_4_1_16", "");
                    cmd.Parameters.AddWithValue("@F_4_1_17", "");
                    cmd.Parameters.AddWithValue("@F_4_1_18", "");
                    cmd.Parameters.AddWithValue("@F_4_1_19", "");
                    cmd.Parameters.AddWithValue("@F_4_1_20", "");
                    cmd.Parameters.AddWithValue("@F_4_1_21", "");
                    cmd.Parameters.AddWithValue("@F_4_1_22", "");
                    cmd.Parameters.AddWithValue("@F_4_1_23", "");
                    cmd.Parameters.AddWithValue("@F_4_1_24", "");

                    cmd.Parameters.AddWithValue("@F_4_2_1", "");
                    cmd.Parameters.AddWithValue("@F_4_2_2", "");
                    cmd.Parameters.AddWithValue("@F_4_2_3", "");
                    cmd.Parameters.AddWithValue("@F_4_2_4", "");
                    cmd.Parameters.AddWithValue("@F_4_2_5", "");
                    cmd.Parameters.AddWithValue("@F_4_2_6", "");
                    cmd.Parameters.AddWithValue("@F_4_2_7", "");
                    cmd.Parameters.AddWithValue("@F_4_2_8", "");
                    cmd.Parameters.AddWithValue("@F_4_2_9", "");
                    cmd.Parameters.AddWithValue("@F_4_2_10", "");
                    cmd.Parameters.AddWithValue("@F_4_2_11", "");
                    cmd.Parameters.AddWithValue("@F_4_2_12", "");
                    cmd.Parameters.AddWithValue("@F_4_2_13", "");
                    cmd.Parameters.AddWithValue("@F_4_2_14", "");
                    cmd.Parameters.AddWithValue("@F_4_2_15", "");
                    cmd.Parameters.AddWithValue("@F_4_2_16", "");
                    cmd.Parameters.AddWithValue("@F_4_2_17", "");
                    cmd.Parameters.AddWithValue("@F_4_2_18", "");
                    cmd.Parameters.AddWithValue("@F_4_2_19", "");
                    cmd.Parameters.AddWithValue("@F_4_2_20", "");
                    cmd.Parameters.AddWithValue("@F_4_2_21", "");
                    cmd.Parameters.AddWithValue("@F_4_2_22", "");
                    cmd.Parameters.AddWithValue("@F_4_2_23", "");
                    cmd.Parameters.AddWithValue("@F_4_2_24", "");
                    cmd.Parameters.AddWithValue("@F_4_2_25", "");
                    cmd.Parameters.AddWithValue("@F_4_2_26", "");
                    cmd.Parameters.AddWithValue("@F_4_2_27", "");

                    cmd.Parameters.AddWithValue("@F_4_3_1", "");
                    cmd.Parameters.AddWithValue("@F_4_3_2", "");
                    cmd.Parameters.AddWithValue("@F_4_3_3", "");
                    cmd.Parameters.AddWithValue("@F_4_3_4", "");
                    cmd.Parameters.AddWithValue("@F_4_3_5", "");
                    cmd.Parameters.AddWithValue("@F_4_3_6", "");
                    cmd.Parameters.AddWithValue("@F_4_3_7", "");
                    cmd.Parameters.AddWithValue("@F_4_3_8", "");
                    cmd.Parameters.AddWithValue("@F_4_3_9", "");
                    cmd.Parameters.AddWithValue("@F_4_3_10", "");
                    cmd.Parameters.AddWithValue("@F_4_3_11", "");
                    cmd.Parameters.AddWithValue("@F_4_3_12", "");
                    cmd.Parameters.AddWithValue("@F_4_3_13", "");
                    cmd.Parameters.AddWithValue("@F_4_3_14", "");
                    cmd.Parameters.AddWithValue("@F_4_3_15", "");
                    cmd.Parameters.AddWithValue("@F_4_3_16", "");
                    cmd.Parameters.AddWithValue("@F_4_3_17", "");
                    cmd.Parameters.AddWithValue("@F_4_3_18", "");
                    cmd.Parameters.AddWithValue("@F_4_3_19", "");
                    cmd.Parameters.AddWithValue("@F_4_3_20", "");
                    cmd.Parameters.AddWithValue("@F_4_3_21", "");
                    cmd.Parameters.AddWithValue("@F_4_3_22", "");
                    cmd.Parameters.AddWithValue("@F_4_3_23", "");
                    cmd.Parameters.AddWithValue("@F_4_3_24", "");
                    cmd.Parameters.AddWithValue("@F_4_3_25", "");
                    cmd.Parameters.AddWithValue("@F_4_3_26", "");
                    cmd.Parameters.AddWithValue("@F_4_3_27", "");
                    cmd.Parameters.AddWithValue("@F_4_3_28", "");
                    cmd.Parameters.AddWithValue("@F_4_3_29", "");
                    cmd.Parameters.AddWithValue("@F_4_3_30", "");
                    cmd.Parameters.AddWithValue("@F_4_3_31", "");
                    cmd.Parameters.AddWithValue("@F_4_3_32", "");
                    cmd.Parameters.AddWithValue("@F_4_3_33", "");
                    cmd.Parameters.AddWithValue("@F_4_3_34", "");
                    cmd.Parameters.AddWithValue("@F_4_3_35", "");
                    cmd.Parameters.AddWithValue("@F_4_3_36", "");
                    cmd.Parameters.AddWithValue("@F_4_3_37", "");
                    cmd.Parameters.AddWithValue("@F_4_3_38", "");
                    cmd.Parameters.AddWithValue("@F_4_3_39", "");
                    cmd.Parameters.AddWithValue("@F_4_3_40", "");
                    cmd.Parameters.AddWithValue("@F_4_3_41", "");
                    cmd.Parameters.AddWithValue("@F_4_3_42", "");
                    cmd.Parameters.AddWithValue("@F_4_3_43", "");
                    cmd.Parameters.AddWithValue("@F_4_3_44", "");
                    cmd.Parameters.AddWithValue("@F_4_3_45", "");
                    cmd.Parameters.AddWithValue("@F_4_3_46", "");
                    cmd.Parameters.AddWithValue("@F_4_3_47", "");
                    cmd.Parameters.AddWithValue("@F_4_3_48", "");
                    cmd.Parameters.AddWithValue("@F_4_3_49", "");
                    cmd.Parameters.AddWithValue("@F_4_3_50", "");
                    cmd.Parameters.AddWithValue("@F_4_3_51", "");
                    cmd.Parameters.AddWithValue("@F_4_3_52", "");
                    cmd.Parameters.AddWithValue("@F_4_3_53", "");
                    cmd.Parameters.AddWithValue("@F_4_3_54", "");
                    cmd.Parameters.AddWithValue("@F_4_3_55", "");
                    cmd.Parameters.AddWithValue("@F_4_3_56", "");
                    cmd.Parameters.AddWithValue("@F_4_3_57", "");
                    cmd.Parameters.AddWithValue("@F_4_3_58", "");
                    cmd.Parameters.AddWithValue("@F_4_3_59", "");
                    cmd.Parameters.AddWithValue("@F_4_3_60", "");
                    cmd.Parameters.AddWithValue("@F_4_3_61", "");
                    cmd.Parameters.AddWithValue("@F_4_3_62", "");
                    cmd.Parameters.AddWithValue("@F_4_3_63", "");
                    cmd.Parameters.AddWithValue("@F_4_3_64", "");
                    cmd.Parameters.AddWithValue("@F_4_3_65", "");
                    cmd.Parameters.AddWithValue("@F_4_3_66", "");
                    cmd.Parameters.AddWithValue("@F_4_3_67", "");
                    cmd.Parameters.AddWithValue("@F_4_3_68", "");
                    cmd.Parameters.AddWithValue("@F_4_3_69", "");
                    cmd.Parameters.AddWithValue("@F_4_3_70", "");
                    cmd.Parameters.AddWithValue("@F_4_3_71", "");
                    cmd.Parameters.AddWithValue("@F_4_3_72", "");
                    cmd.Parameters.AddWithValue("@F_4_3_73", "");
                    cmd.Parameters.AddWithValue("@F_4_3_74", "");
                    cmd.Parameters.AddWithValue("@F_4_3_75", "");
                    cmd.Parameters.AddWithValue("@F_4_3_76", "");
                    cmd.Parameters.AddWithValue("@F_4_3_77", "");
                    cmd.Parameters.AddWithValue("@F_4_3_78", "");
                    cmd.Parameters.AddWithValue("@F_4_3_79", "");
                    cmd.Parameters.AddWithValue("@F_4_3_80", "");
                    cmd.Parameters.AddWithValue("@F_4_3_81", "");
                    cmd.Parameters.AddWithValue("@F_4_3_82", "");

                    cmd.Parameters.AddWithValue("@F_4_4_1", "");
                    cmd.Parameters.AddWithValue("@F_4_4_2", "");
                    cmd.Parameters.AddWithValue("@F_4_4_3", "");
                    cmd.Parameters.AddWithValue("@F_4_4_4", "");
                    cmd.Parameters.AddWithValue("@F_4_4_5", "");
                    cmd.Parameters.AddWithValue("@F_4_4_6", "");
                    cmd.Parameters.AddWithValue("@F_4_4_7", "");
                    cmd.Parameters.AddWithValue("@F_4_4_8", "");
                    cmd.Parameters.AddWithValue("@F_4_4_9", "");
                    cmd.Parameters.AddWithValue("@F_4_4_10", "");
                    cmd.Parameters.AddWithValue("@F_4_4_11", "");
                    cmd.Parameters.AddWithValue("@F_4_4_12", "");
                    cmd.Parameters.AddWithValue("@F_4_4_13", "");
                    cmd.Parameters.AddWithValue("@F_4_4_14", "");
                    cmd.Parameters.AddWithValue("@F_4_4_15", "");
                    cmd.Parameters.AddWithValue("@F_4_4_16", "");
                    cmd.Parameters.AddWithValue("@F_4_4_17", "");
                    cmd.Parameters.AddWithValue("@F_4_4_18", "");
                    cmd.Parameters.AddWithValue("@F_4_4_19", "");
                    cmd.Parameters.AddWithValue("@F_4_4_20", "");
                    cmd.Parameters.AddWithValue("@F_4_4_21", "");
                    cmd.Parameters.AddWithValue("@F_4_4_22", "");
                    cmd.Parameters.AddWithValue("@F_4_4_23", "");
                    cmd.Parameters.AddWithValue("@F_4_4_24", "");
                    cmd.Parameters.AddWithValue("@F_4_4_25", "");
                    cmd.Parameters.AddWithValue("@F_4_4_26", "");
                    cmd.Parameters.AddWithValue("@F_4_4_27", "");
                    cmd.Parameters.AddWithValue("@F_4_4_28", "");
                    cmd.Parameters.AddWithValue("@F_4_4_29", "");
                    cmd.Parameters.AddWithValue("@F_4_4_30", "");
                    cmd.Parameters.AddWithValue("@F_4_4_31", "");
                    cmd.Parameters.AddWithValue("@F_4_4_32", "");
                    cmd.Parameters.AddWithValue("@F_4_4_33", "");
                    cmd.Parameters.AddWithValue("@F_4_4_34", "");
                    cmd.Parameters.AddWithValue("@F_4_4_35", "");
                    cmd.Parameters.AddWithValue("@F_4_4_36", "");
                    cmd.Parameters.AddWithValue("@F_4_4_37", "");
                    cmd.Parameters.AddWithValue("@F_4_4_38", "");
                    cmd.Parameters.AddWithValue("@F_4_4_39", "");
                    cmd.Parameters.AddWithValue("@F_4_4_40", "");
                    cmd.Parameters.AddWithValue("@F_4_4_41", "");
                    cmd.Parameters.AddWithValue("@F_4_4_42", "");
                    cmd.Parameters.AddWithValue("@F_4_4_43", "");
                    cmd.Parameters.AddWithValue("@F_4_4_44", "");
                    cmd.Parameters.AddWithValue("@F_4_4_45", "");
                    cmd.Parameters.AddWithValue("@F_4_4_46", "");
                    cmd.Parameters.AddWithValue("@F_4_4_47", "");
                    cmd.Parameters.AddWithValue("@F_4_4_48", "");
                    cmd.Parameters.AddWithValue("@F_4_4_49", "");
                    cmd.Parameters.AddWithValue("@F_4_4_50", "");
                    cmd.Parameters.AddWithValue("@F_4_4_51", "");
                    cmd.Parameters.AddWithValue("@F_4_4_52", "");
                    cmd.Parameters.AddWithValue("@F_4_4_53", "");
                    cmd.Parameters.AddWithValue("@F_4_4_54", "");
                    cmd.Parameters.AddWithValue("@F_4_4_55", "");
                    cmd.Parameters.AddWithValue("@F_4_4_56", "");


                    cmd.Parameters.AddWithValue("@F_4_5_1", "");
                    cmd.Parameters.AddWithValue("@F_4_5_2", "");
                    cmd.Parameters.AddWithValue("@F_4_5_3", "");
                    cmd.Parameters.AddWithValue("@F_4_5_4", "");
                    cmd.Parameters.AddWithValue("@F_4_5_5", "");
                    cmd.Parameters.AddWithValue("@F_4_5_6", "");
                    cmd.Parameters.AddWithValue("@F_4_5_7", "");
                    cmd.Parameters.AddWithValue("@F_4_5_8", "");
                    cmd.Parameters.AddWithValue("@F_4_5_9", "");
                    cmd.Parameters.AddWithValue("@F_4_5_10", "");
                    cmd.Parameters.AddWithValue("@F_4_5_11", "");
                    cmd.Parameters.AddWithValue("@F_4_5_12", "");
                    cmd.Parameters.AddWithValue("@F_4_5_13", "");
                    cmd.Parameters.AddWithValue("@F_4_5_14", "");
                    cmd.Parameters.AddWithValue("@F_4_5_15", "");
                    cmd.Parameters.AddWithValue("@F_4_5_16", "");
                    cmd.Parameters.AddWithValue("@F_4_5_17", "");
                    cmd.Parameters.AddWithValue("@F_4_5_18", "");
                    cmd.Parameters.AddWithValue("@F_4_5_19", "");
                    cmd.Parameters.AddWithValue("@F_4_5_20", "");
                    cmd.Parameters.AddWithValue("@F_4_5_21", "");
                    cmd.Parameters.AddWithValue("@F_4_5_22", "");
                    cmd.Parameters.AddWithValue("@F_4_5_23", "");
                    cmd.Parameters.AddWithValue("@F_4_5_24", "");
                    cmd.Parameters.AddWithValue("@F_4_5_25", "");
                    cmd.Parameters.AddWithValue("@F_4_5_26", "");
                    cmd.Parameters.AddWithValue("@F_4_5_27", "");
                    cmd.Parameters.AddWithValue("@F_4_5_28", "");
                    cmd.Parameters.AddWithValue("@F_4_5_29", "");
                    cmd.Parameters.AddWithValue("@F_4_5_30", "");
                    cmd.Parameters.AddWithValue("@F_4_5_31", "");

                    cmd.Parameters.AddWithValue("@F_4_6_1", "");
                    cmd.Parameters.AddWithValue("@F_4_6_2", "");
                    cmd.Parameters.AddWithValue("@F_4_6_3", "");
                    cmd.Parameters.AddWithValue("@F_4_6_4", "");
                    cmd.Parameters.AddWithValue("@F_4_6_5", "");
                    cmd.Parameters.AddWithValue("@F_4_6_6", "");
                    cmd.Parameters.AddWithValue("@F_4_6_7", "");
                    cmd.Parameters.AddWithValue("@F_4_6_8", "");
                    cmd.Parameters.AddWithValue("@F_4_6_9", "");
                    cmd.Parameters.AddWithValue("@F_4_6_10", "");
                    cmd.Parameters.AddWithValue("@F_4_6_11", "");
                    cmd.Parameters.AddWithValue("@F_4_6_12", "");
                    cmd.Parameters.AddWithValue("@F_4_6_13", "");
                    cmd.Parameters.AddWithValue("@F_4_6_14", "");
                    cmd.Parameters.AddWithValue("@F_4_6_15", "");
                    cmd.Parameters.AddWithValue("@F_4_6_16", "");
                    cmd.Parameters.AddWithValue("@F_4_6_17", "");
                    cmd.Parameters.AddWithValue("@F_4_6_18", "");
                    cmd.Parameters.AddWithValue("@F_4_6_19", "");
                    cmd.Parameters.AddWithValue("@F_4_6_20", "");
                    cmd.Parameters.AddWithValue("@F_4_6_21", "");
                    cmd.Parameters.AddWithValue("@F_4_6_22", "");
                    cmd.Parameters.AddWithValue("@F_4_6_23", "");
                    cmd.Parameters.AddWithValue("@F_4_6_24", "");
                    cmd.Parameters.AddWithValue("@F_4_6_25", "");
                    cmd.Parameters.AddWithValue("@F_4_6_26", "");
                    cmd.Parameters.AddWithValue("@F_4_6_27", "");
                    cmd.Parameters.AddWithValue("@F_4_6_28", "");
                    cmd.Parameters.AddWithValue("@F_4_6_29", "");
                    cmd.Parameters.AddWithValue("@F_4_6_30", "");
                    cmd.Parameters.AddWithValue("@F_4_6_31", "");
                    cmd.Parameters.AddWithValue("@F_4_6_32", "");
                    cmd.Parameters.AddWithValue("@F_4_6_33", "");
                    cmd.Parameters.AddWithValue("@F_4_6_34", "");
                    cmd.Parameters.AddWithValue("@F_4_6_35", "");
                    cmd.Parameters.AddWithValue("@F_4_6_36", "");
                    cmd.Parameters.AddWithValue("@F_4_6_37", "");
                    cmd.Parameters.AddWithValue("@F_4_6_38", "");
                    cmd.Parameters.AddWithValue("@F_4_6_39", "");
                    cmd.Parameters.AddWithValue("@F_4_6_40", "");
                    cmd.Parameters.AddWithValue("@F_4_6_41", "");
                    cmd.Parameters.AddWithValue("@F_4_6_42", "");

                    cmd.Parameters.AddWithValue("@F_4_7_1", "");
                    cmd.Parameters.AddWithValue("@F_4_7_2", "");
                    cmd.Parameters.AddWithValue("@F_4_7_3", "");
                    cmd.Parameters.AddWithValue("@F_4_7_4", "");
                    cmd.Parameters.AddWithValue("@F_4_7_5", "");
                    cmd.Parameters.AddWithValue("@F_4_7_6", "");
                    cmd.Parameters.AddWithValue("@F_4_7_7", "");
                    cmd.Parameters.AddWithValue("@F_4_7_8", "");
                    cmd.Parameters.AddWithValue("@F_4_7_9", "");
                    cmd.Parameters.AddWithValue("@F_4_7_10", "");
                    cmd.Parameters.AddWithValue("@F_4_7_11", "");
                    cmd.Parameters.AddWithValue("@F_4_7_12", "");
                    cmd.Parameters.AddWithValue("@F_4_7_13", "");
                    cmd.Parameters.AddWithValue("@F_4_7_14", "");
                    cmd.Parameters.AddWithValue("@F_4_7_15", "");
                    cmd.Parameters.AddWithValue("@F_4_7_16", "");
                    cmd.Parameters.AddWithValue("@F_4_7_17", "");
                    cmd.Parameters.AddWithValue("@F_4_7_18", "");
                    cmd.Parameters.AddWithValue("@F_4_7_19", "");
                    cmd.Parameters.AddWithValue("@F_4_7_20", "");
                    cmd.Parameters.AddWithValue("@F_4_7_21", "");
                    cmd.Parameters.AddWithValue("@F_4_7_22", "");
                    cmd.Parameters.AddWithValue("@F_4_7_23", "");
                    cmd.Parameters.AddWithValue("@F_4_7_24", "");
                    cmd.Parameters.AddWithValue("@F_4_7_25", "");
                    cmd.Parameters.AddWithValue("@F_4_7_26", "");
                    cmd.Parameters.AddWithValue("@F_4_7_27", "");
                    cmd.Parameters.AddWithValue("@F_4_7_28", "");
                    cmd.Parameters.AddWithValue("@F_4_7_29", "");
                    cmd.Parameters.AddWithValue("@F_4_7_30", "");
                    cmd.Parameters.AddWithValue("@F_4_7_31", "");
                    cmd.Parameters.AddWithValue("@F_4_7_32", "");
                    cmd.Parameters.AddWithValue("@F_4_7_33", "");
                    cmd.Parameters.AddWithValue("@F_4_7_34", "");
                    cmd.Parameters.AddWithValue("@F_4_7_35", "");
                    cmd.Parameters.AddWithValue("@F_4_7_36", "");
                    cmd.Parameters.AddWithValue("@F_4_7_37", "");
                    cmd.Parameters.AddWithValue("@F_4_7_38", "");
                    cmd.Parameters.AddWithValue("@F_4_7_39", "");
                    cmd.Parameters.AddWithValue("@F_4_7_40", "");
                    cmd.Parameters.AddWithValue("@F_4_7_41", "");
                    cmd.Parameters.AddWithValue("@F_4_7_42", "");
                    cmd.Parameters.AddWithValue("@F_4_7_43", "");
                    cmd.Parameters.AddWithValue("@F_4_7_44", "");
                    cmd.Parameters.AddWithValue("@F_4_7_45", "");
                    cmd.Parameters.AddWithValue("@F_4_7_46", "");
                    cmd.Parameters.AddWithValue("@F_4_7_47", "");
                    cmd.Parameters.AddWithValue("@F_4_7_48", "");
                    cmd.Parameters.AddWithValue("@F_4_7_49", "");
                    cmd.Parameters.AddWithValue("@F_4_7_50", "");
                    cmd.Parameters.AddWithValue("@F_4_7_51", "");
                    cmd.Parameters.AddWithValue("@F_4_7_52", "");
                    cmd.Parameters.AddWithValue("@F_4_7_53", "");
                    cmd.Parameters.AddWithValue("@F_4_7_54", "");
                    cmd.Parameters.AddWithValue("@F_4_7_55", "");
                    cmd.Parameters.AddWithValue("@F_4_7_56", "");
                    cmd.Parameters.AddWithValue("@F_4_7_57", "");
                    cmd.Parameters.AddWithValue("@F_4_7_58", "");
                    cmd.Parameters.AddWithValue("@F_4_7_59", "");
                    cmd.Parameters.AddWithValue("@F_4_7_60", "");
                    cmd.Parameters.AddWithValue("@F_4_7_61", "");

                    cmd.Parameters.AddWithValue("@F_5_1", "");
                    cmd.Parameters.AddWithValue("@F_5_2", "");
                    cmd.Parameters.AddWithValue("@F_5_3", "");
                    cmd.Parameters.AddWithValue("@F_5_4", "");
                    cmd.Parameters.AddWithValue("@F_5_5", "");
                    cmd.Parameters.AddWithValue("@F_5_6", "");
                    cmd.Parameters.AddWithValue("@F_5_7", "");
                    cmd.Parameters.AddWithValue("@F_5_8", "");
                    cmd.Parameters.AddWithValue("@F_5_9", "");
                    cmd.Parameters.AddWithValue("@F_5_10", "");
                    cmd.Parameters.AddWithValue("@F_5_11", "");
                    cmd.Parameters.AddWithValue("@F_5_12", "");
                    cmd.Parameters.AddWithValue("@F_5_13", "");
                    cmd.Parameters.AddWithValue("@F_5_14", "");
                    cmd.Parameters.AddWithValue("@F_5_15", "");
                    cmd.Parameters.AddWithValue("@F_5_16", "");
                    cmd.Parameters.AddWithValue("@F_5_17", "");
                    cmd.Parameters.AddWithValue("@F_5_18", "");
                    cmd.Parameters.AddWithValue("@F_5_19", "");
                    cmd.Parameters.AddWithValue("@F_5_20", "");
                    cmd.Parameters.AddWithValue("@F_5_21", "");
                    cmd.Parameters.AddWithValue("@F_5_22", "");
                    cmd.Parameters.AddWithValue("@F_5_23", "");
                    cmd.Parameters.AddWithValue("@F_5_24", "");
                    cmd.Parameters.AddWithValue("@F_5_25", "");
                    cmd.Parameters.AddWithValue("@F_5_26", "");
                    cmd.Parameters.AddWithValue("@F_5_27", "");
                    cmd.Parameters.AddWithValue("@F_5_28", "");
                    cmd.Parameters.AddWithValue("@F_5_29", "");
                    cmd.Parameters.AddWithValue("@F_5_30", "");
                    cmd.Parameters.AddWithValue("@F_5_31", "");
                    cmd.Parameters.AddWithValue("@F_5_32", "");
                    cmd.Parameters.AddWithValue("@F_5_33", "");
                    cmd.Parameters.AddWithValue("@F_5_34", "");
                    cmd.Parameters.AddWithValue("@F_5_35", "");
                    cmd.Parameters.AddWithValue("@F_5_36", "");
                    cmd.Parameters.AddWithValue("@F_5_37", "");
                    cmd.Parameters.AddWithValue("@F_5_38", "");
                    cmd.Parameters.AddWithValue("@F_5_39", "");
                    cmd.Parameters.AddWithValue("@F_5_40", "");
                    cmd.Parameters.AddWithValue("@F_5_41", "");
                    cmd.Parameters.AddWithValue("@F_5_42", "");
                    cmd.Parameters.AddWithValue("@F_5_43", "");
                    cmd.Parameters.AddWithValue("@F_5_44", "");
                    cmd.Parameters.AddWithValue("@F_5_45", "");
                    cmd.Parameters.AddWithValue("@F_5_46", "");
                    cmd.Parameters.AddWithValue("@F_5_47", "");
                    cmd.Parameters.AddWithValue("@F_5_48", "");
                    cmd.Parameters.AddWithValue("@F_5_49", "");
                    cmd.Parameters.AddWithValue("@F_5_50", "");
                    cmd.Parameters.AddWithValue("@F_5_51", "");
                    cmd.Parameters.AddWithValue("@F_5_52", "");
                    cmd.Parameters.AddWithValue("@F_5_53", "");
                    cmd.Parameters.AddWithValue("@F_5_54", "");
                    cmd.Parameters.AddWithValue("@F_5_55", "");
                    cmd.Parameters.AddWithValue("@F_5_56", "");
                    cmd.Parameters.AddWithValue("@F_5_57", "");

                    cmd.Parameters.AddWithValue("@F_5", "");
                    cmd.Parameters.AddWithValue("@F_6", "");
                    cmd.Parameters.AddWithValue("@F_7", "");
                    cmd.Parameters.AddWithValue("@F_8", "");

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
                    cmd.Parameters.AddWithValue("@F_1", txtF_1_1.Text.ToString());
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
                    cmd.Parameters.AddWithValue("@Employer_City", txtEmployer_City.Text.ToString());
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
                    cmd.Parameters.AddWithValue("@F_2_19", txt_F_2_19.Text.ToString());
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
                    cmd.Parameters.AddWithValue("@F_3_31_2", txtF_3_31_1.Text.ToString());
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

                    cmd.Parameters.AddWithValue("@F_4_1_1", txtF_4_1_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_2", txtF_4_1_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_3", txtF_4_1_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_4", txtF_4_1_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_5", txtF_4_1_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_6", txtF_4_1_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_7", txtF_4_1_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_8", txtF_4_1_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_9", txtF_4_1_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_10", txtF_4_1_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_11", txtF_4_1_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_12", txtF_4_1_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_13", txtF_4_1_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_14", txtF_4_1_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_15", txtF_4_1_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_16", txtF_4_1_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_17", txtF_4_1_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_18", txtF_4_1_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_19", txtF_4_1_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_20", txtF_4_1_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_21", txtF_4_1_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_22", txtF_4_1_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_23", txtF_4_1_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_1_24", txtF_4_1_24.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_4_2_1", txtF_4_2_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_2", txtF_4_2_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_3", txtF_4_2_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_4", txtF_4_2_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_5", txtF_4_2_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_6", txtF_4_2_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_7", txtF_4_2_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_8", txtF_4_2_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_9", txtF_4_2_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_10", txtF_4_2_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_11", txtF_4_2_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_12", txtF_4_2_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_13", txtF_4_2_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_14", txtF_4_2_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_15", txtF_4_2_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_16", txtF_4_2_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_17", txtF_4_2_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_18", txtF_4_2_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_19", txtF_4_2_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_20", txtF_4_2_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_21", txtF_4_2_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_22", txtF_4_2_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_23", txtF_4_2_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_24", txtF_4_2_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_25", txtF_4_2_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_26", txtF_4_2_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_2_27", txtF_4_2_27.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_4_3_1", txtF_4_3_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_2", txtF_4_3_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_3", txtF_4_3_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_4", txtF_4_3_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_5", txtF_4_3_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_6", txtF_4_3_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_7", txtF_4_3_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_8", txtF_4_3_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_9", txtF_4_3_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_10", txtF_4_3_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_11", txtF_4_3_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_12", txtF_4_3_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_13", txtF_4_3_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_14", txtF_4_3_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_15", txtF_4_3_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_16", txtF_4_3_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_17", txtF_4_3_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_18", txtF_4_3_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_19", txtF_4_3_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_20", txtF_4_3_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_21", txtF_4_3_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_22", txtF_4_3_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_23", txtF_4_3_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_24", txtF_4_3_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_25", txtF_4_3_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_26", txtF_4_3_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_27", txtF_4_3_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_28", txtF_4_3_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_29", txtF_4_3_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_30", txtF_4_3_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_31", txtF_4_3_31.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_32", txtF_4_3_32.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_33", txtF_4_3_33.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_34", txtF_4_3_34.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_35", txtF_4_3_35.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_36", txtF_4_3_36.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_37", txtF_4_3_37.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_38", txtF_4_3_38.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_39", txtF_4_3_39.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_40", txtF_4_3_40.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_41", txtF_4_3_41.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_42", txtF_4_3_42.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_43", txtF_4_3_43.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_44", txtF_4_3_44.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_45", txtF_4_3_45.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_46", txtF_4_3_46.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_47", txtF_4_3_47.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_48", txtF_4_3_48.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_49", txtF_4_3_49.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_50", txtF_4_3_50.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_51", txtF_4_3_51.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_52", txtF_4_3_52.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_53", txtF_4_3_53.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_54", txtF_4_3_54.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_55", txtF_4_3_55.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_56", txtF_4_3_56.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_57", txtF_4_3_57.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_58", txtF_4_3_58.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_59", txtF_4_3_59.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_60", txtF_4_3_60.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_61", txtF_4_3_61.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_62", txtF_4_3_62.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_63", txtF_4_3_63.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_64", txtF_4_3_64.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_65", txtF_4_3_65.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_66", txtF_4_3_66.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_67", txtF_4_3_67.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_68", txtF_4_3_68.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_69", txtF_4_3_69.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_70", txtF_4_3_70.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_71", txtF_4_3_71.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_72", txtF_4_3_72.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_73", txtF_4_3_73.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_74", txtF_4_3_74.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_75", txtF_4_3_75.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_76", txtF_4_3_76.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_77", txtF_4_3_77.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_78", txtF_4_3_78.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_79", txtF_4_3_79.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_80", txtF_4_3_80.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_81", txtF_4_3_81.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_3_82", txtF_4_3_82.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_4_4_1", txtF_4_4_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_2", txtF_4_4_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_3", txtF_4_4_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_4", txtF_4_4_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_5", txtF_4_4_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_6", txtF_4_4_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_7", txtF_4_4_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_8", txtF_4_4_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_9", txtF_4_4_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_10", txtF_4_4_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_11", txtF_4_4_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_12", txtF_4_4_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_13", txtF_4_4_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_14", txtF_4_4_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_15", txtF_4_4_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_16", txtF_4_4_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_17", txtF_4_4_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_18", txtF_4_4_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_19", txtF_4_4_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_20", txtF_4_4_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_21", txtF_4_4_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_22", txtF_4_4_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_23", txtF_4_4_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_24", txtF_4_4_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_25", txtF_4_4_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_26", txtF_4_4_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_27", txtF_4_4_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_28", txtF_4_4_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_29", txtF_4_4_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_30", txtF_4_4_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_31", txtF_4_4_31.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_32", txtF_4_4_32.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_33", txtF_4_4_33.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_34", txtF_4_4_34.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_35", txtF_4_4_35.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_36", txtF_4_4_36.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_37", txtF_4_4_37.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_38", txtF_4_4_38.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_39", txtF_4_4_39.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_40", txtF_4_4_40.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_41", txtF_4_4_41.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_42", txtF_4_4_42.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_43", txtF_4_4_43.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_44", txtF_4_4_44.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_45", txtF_4_4_45.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_46", txtF_4_4_46.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_47", txtF_4_4_47.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_48", txtF_4_4_48.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_49", txtF_4_4_49.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_50", txtF_4_4_50.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_51", txtF_4_4_51.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_52", txtF_4_4_52.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_53", txtF_4_4_53.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_54", txtF_4_4_54.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_55", txtF_4_4_55.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_4_56", txtF_4_4_56.Text.ToString());


                    cmd.Parameters.AddWithValue("@F_4_5_1", txtF_4_5_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_2", txtF_4_5_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_3", txtF_4_5_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_4", txtF_4_5_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_5", txtF_4_5_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_6", txtF_4_5_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_7", txtF_4_5_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_8", txtF_4_5_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_9", txtF_4_5_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_10", txtF_4_5_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_11", txtF_4_5_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_12", txtF_4_5_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_13", txtF_4_5_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_14", txtF_4_5_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_15", txtF_4_5_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_16", txtF_4_5_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_17", txtF_4_5_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_18", txtF_4_5_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_19", txtF_4_5_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_20", txtF_4_5_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_21", txtF_4_5_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_22", txtF_4_5_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_23", txtF_4_5_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_24", txtF_4_5_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_25", txtF_4_5_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_26", txtF_4_5_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_27", txtF_4_5_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_28", txtF_4_5_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_29", txtF_4_5_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_30", txtF_4_5_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_5_31", txtF_4_5_31.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_4_6_1", txtF_4_6_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_2", txtF_4_6_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_3", txtF_4_6_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_4", txtF_4_6_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_5", txtF_4_6_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_6", txtF_4_6_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_7", txtF_4_6_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_8", txtF_4_6_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_9", txtF_4_6_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_10", txtF_4_6_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_11", txtF_4_6_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_12", txtF_4_6_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_13", txtF_4_6_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_14", txtF_4_6_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_15", txtF_4_6_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_16", txtF_4_6_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_17", txtF_4_6_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_18", txtF_4_6_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_19", txtF_4_6_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_20", txtF_4_6_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_21", txtF_4_6_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_22", txtF_4_6_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_23", txtF_4_6_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_24", txtF_4_6_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_25", txtF_4_6_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_26", txtF_4_6_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_27", txtF_4_6_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_28", txtF_4_6_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_29", txtF_4_6_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_30", txtF_4_6_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_31", txtF_4_6_31.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_32", txtF_4_6_32.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_33", txtF_4_6_33.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_34", txtF_4_6_34.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_35", txtF_4_6_35.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_36", txtF_4_6_36.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_37", txtF_4_6_37.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_38", txtF_4_6_38.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_39", txtF_4_6_39.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_40", txtF_4_6_40.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_41", txtF_4_6_41.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_6_42", txtF_4_6_42.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_4_7_1", txtF_4_7_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_2", txtF_4_7_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_3", txtF_4_7_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_4", txtF_4_7_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_5", txtF_4_7_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_6", txtF_4_7_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_7", txtF_4_7_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_8", txtF_4_7_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_9", txtF_4_7_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_10", txtF_4_7_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_11", txtF_4_7_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_12", txtF_4_7_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_13", txtF_4_7_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_14", txtF_4_7_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_15", txtF_4_7_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_16", txtF_4_7_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_17", txtF_4_7_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_18", txtF_4_7_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_19", txtF_4_7_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_20", txtF_4_7_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_21", txtF_4_7_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_22", txtF_4_7_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_23", txtF_4_7_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_24", txtF_4_7_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_25", txtF_4_7_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_26", txtF_4_7_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_27", txtF_4_7_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_28", txtF_4_7_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_29", txtF_4_7_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_30", txtF_4_7_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_31", txtF_4_7_31.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_32", txtF_4_7_32.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_33", txtF_4_7_33.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_34", txtF_4_7_34.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_35", txtF_4_7_35.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_36", txtF_4_7_36.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_37", txtF_4_7_37.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_38", txtF_4_7_38.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_39", txtF_4_7_39.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_40", txtF_4_7_40.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_41", txtF_4_7_41.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_42", txtF_4_7_42.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_43", txtF_4_7_43.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_44", txtF_4_7_44.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_45", txtF_4_7_45.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_46", txtF_4_7_46.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_47", txtF_4_7_47.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_48", txtF_4_7_48.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_49", txtF_4_7_49.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_50", txtF_4_7_50.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_51", txtF_4_7_51.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_52", txtF_4_7_52.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_53", txtF_4_7_53.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_54", txtF_4_7_54.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_55", txtF_4_7_55.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_56", txtF_4_7_56.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_57", txtF_4_7_57.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_58", txtF_4_7_58.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_59", txtF_4_7_59.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_60", txtF_4_7_60.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_4_7_61", txtF_4_7_61.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_5_1", txtF_5_1.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_2", txtF_5_2.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_3", txtF_5_3.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_4", txtF_5_4.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_5", txtF_5_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_6", txtF_5_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_7", txtF_5_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_8", txtF_5_8.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_9", txtF_5_9.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_10", txtF_5_10.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_11", txtF_5_11.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_12", txtF_5_12.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_13", txtF_5_13.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_14", txtF_5_14.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_15", txtF_5_15.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_16", txtF_5_16.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_17", txtF_5_17.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_18", txtF_5_18.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_19", txtF_5_19.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_20", txtF_5_20.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_21", txtF_5_21.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_22", txtF_5_22.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_23", txtF_5_23.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_24", txtF_5_24.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_25", txtF_5_25.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_26", txtF_5_26.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_27", txtF_5_27.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_28", txtF_5_28.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_29", txtF_5_29.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_30", txtF_5_30.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_31", txtF_5_31.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_32", txtF_5_32.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_33", txtF_5_33.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_34", txtF_5_34.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_35", txtF_5_35.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_36", txtF_5_36.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_37", txtF_5_37.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_38", txtF_5_38.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_39", txtF_5_39.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_40", txtF_5_40.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_41", txtF_5_41.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_42", txtF_5_42.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_43", txtF_5_43.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_44", txtF_5_44.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_45", txtF_5_45.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_46", txtF_5_46.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_47", txtF_5_47.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_48", txtF_5_48.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_49", txtF_5_49.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_50", txtF_5_50.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_51", txtF_5_51.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_52", txtF_5_52.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_53", txtF_5_53.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_54", txtF_5_54.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_55", txtF_5_55.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_56", txtF_5_56.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_5_57", txtF_5_57.Text.ToString());

                    cmd.Parameters.AddWithValue("@F_5", txtF_5.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_6", txtF_6.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_7", txtF_7.Text.ToString());
                    cmd.Parameters.AddWithValue("@F_8", txtF_8.Text.ToString());


                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string message = "Your details have been saved successfully.";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

                    //string message = "Record has been inserted successfully";
                    //string script = "window.onload = function(){ alert('";
                    //script += message;
                    //script += "')};";
                    //Page page = (Page)HttpContext.Current.CurrentHandler;
                    //ScriptManager.RegisterStartupScript(page, typeof(Page), "ApprovalHistory", script, true);

                    //ShowMessage();    
                    //Response.Write("<script LANGUAGE='JavaScript' >alert('Login Successful')</script>");
                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('This alert from code behind');", true);
                }
            }
        }

        protected void ShowMessage()
        {
            string message = "Your details have been saved successfully.";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "')};";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }


        protected void Print_LF_A_1(object sender, EventArgs e)
        {

            string m_txtF_1="";
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
                    cmd.Parameters.AddWithValue("@Employer_City", "");
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

                    cmd.Parameters.AddWithValue("@F_4_1_1", "");
                    cmd.Parameters.AddWithValue("@F_4_1_2", "");
                    cmd.Parameters.AddWithValue("@F_4_1_3", "");
                    cmd.Parameters.AddWithValue("@F_4_1_4", "");
                    cmd.Parameters.AddWithValue("@F_4_1_5", "");
                    cmd.Parameters.AddWithValue("@F_4_1_6", "");
                    cmd.Parameters.AddWithValue("@F_4_1_7", "");
                    cmd.Parameters.AddWithValue("@F_4_1_8", "");
                    cmd.Parameters.AddWithValue("@F_4_1_9", "");
                    cmd.Parameters.AddWithValue("@F_4_1_10", "");
                    cmd.Parameters.AddWithValue("@F_4_1_11", "");
                    cmd.Parameters.AddWithValue("@F_4_1_12", "");
                    cmd.Parameters.AddWithValue("@F_4_1_13", "");
                    cmd.Parameters.AddWithValue("@F_4_1_14", "");
                    cmd.Parameters.AddWithValue("@F_4_1_15", "");
                    cmd.Parameters.AddWithValue("@F_4_1_16", "");
                    cmd.Parameters.AddWithValue("@F_4_1_17", "");
                    cmd.Parameters.AddWithValue("@F_4_1_18", "");
                    cmd.Parameters.AddWithValue("@F_4_1_19", "");
                    cmd.Parameters.AddWithValue("@F_4_1_20", "");
                    cmd.Parameters.AddWithValue("@F_4_1_21", "");
                    cmd.Parameters.AddWithValue("@F_4_1_22", "");
                    cmd.Parameters.AddWithValue("@F_4_1_23", "");
                    cmd.Parameters.AddWithValue("@F_4_1_24", "");

                    cmd.Parameters.AddWithValue("@F_4_2_1", "");
                    cmd.Parameters.AddWithValue("@F_4_2_2", "");
                    cmd.Parameters.AddWithValue("@F_4_2_3", "");
                    cmd.Parameters.AddWithValue("@F_4_2_4", "");
                    cmd.Parameters.AddWithValue("@F_4_2_5", "");
                    cmd.Parameters.AddWithValue("@F_4_2_6", "");
                    cmd.Parameters.AddWithValue("@F_4_2_7", "");
                    cmd.Parameters.AddWithValue("@F_4_2_8", "");
                    cmd.Parameters.AddWithValue("@F_4_2_9", "");
                    cmd.Parameters.AddWithValue("@F_4_2_10", "");
                    cmd.Parameters.AddWithValue("@F_4_2_11", "");
                    cmd.Parameters.AddWithValue("@F_4_2_12", "");
                    cmd.Parameters.AddWithValue("@F_4_2_13", "");
                    cmd.Parameters.AddWithValue("@F_4_2_14", "");
                    cmd.Parameters.AddWithValue("@F_4_2_15", "");
                    cmd.Parameters.AddWithValue("@F_4_2_16", "");
                    cmd.Parameters.AddWithValue("@F_4_2_17", "");
                    cmd.Parameters.AddWithValue("@F_4_2_18", "");
                    cmd.Parameters.AddWithValue("@F_4_2_19", "");
                    cmd.Parameters.AddWithValue("@F_4_2_20", "");
                    cmd.Parameters.AddWithValue("@F_4_2_21", "");
                    cmd.Parameters.AddWithValue("@F_4_2_22", "");
                    cmd.Parameters.AddWithValue("@F_4_2_23", "");
                    cmd.Parameters.AddWithValue("@F_4_2_24", "");
                    cmd.Parameters.AddWithValue("@F_4_2_25", "");
                    cmd.Parameters.AddWithValue("@F_4_2_26", "");
                    cmd.Parameters.AddWithValue("@F_4_2_27", "");

                    cmd.Parameters.AddWithValue("@F_4_3_1", "");
                    cmd.Parameters.AddWithValue("@F_4_3_2", "");
                    cmd.Parameters.AddWithValue("@F_4_3_3", "");
                    cmd.Parameters.AddWithValue("@F_4_3_4", "");
                    cmd.Parameters.AddWithValue("@F_4_3_5", "");
                    cmd.Parameters.AddWithValue("@F_4_3_6", "");
                    cmd.Parameters.AddWithValue("@F_4_3_7", "");
                    cmd.Parameters.AddWithValue("@F_4_3_8", "");
                    cmd.Parameters.AddWithValue("@F_4_3_9", "");
                    cmd.Parameters.AddWithValue("@F_4_3_10", "");
                    cmd.Parameters.AddWithValue("@F_4_3_11", "");
                    cmd.Parameters.AddWithValue("@F_4_3_12", "");
                    cmd.Parameters.AddWithValue("@F_4_3_13", "");
                    cmd.Parameters.AddWithValue("@F_4_3_14", "");
                    cmd.Parameters.AddWithValue("@F_4_3_15", "");
                    cmd.Parameters.AddWithValue("@F_4_3_16", "");
                    cmd.Parameters.AddWithValue("@F_4_3_17", "");
                    cmd.Parameters.AddWithValue("@F_4_3_18", "");
                    cmd.Parameters.AddWithValue("@F_4_3_19", "");
                    cmd.Parameters.AddWithValue("@F_4_3_20", "");
                    cmd.Parameters.AddWithValue("@F_4_3_21", "");
                    cmd.Parameters.AddWithValue("@F_4_3_22", "");
                    cmd.Parameters.AddWithValue("@F_4_3_23", "");
                    cmd.Parameters.AddWithValue("@F_4_3_24", "");
                    cmd.Parameters.AddWithValue("@F_4_3_25", "");
                    cmd.Parameters.AddWithValue("@F_4_3_26", "");
                    cmd.Parameters.AddWithValue("@F_4_3_27", "");
                    cmd.Parameters.AddWithValue("@F_4_3_28", "");
                    cmd.Parameters.AddWithValue("@F_4_3_29", "");
                    cmd.Parameters.AddWithValue("@F_4_3_30", "");
                    cmd.Parameters.AddWithValue("@F_4_3_31", "");
                    cmd.Parameters.AddWithValue("@F_4_3_32", "");
                    cmd.Parameters.AddWithValue("@F_4_3_33", "");
                    cmd.Parameters.AddWithValue("@F_4_3_34", "");
                    cmd.Parameters.AddWithValue("@F_4_3_35", "");
                    cmd.Parameters.AddWithValue("@F_4_3_36", "");
                    cmd.Parameters.AddWithValue("@F_4_3_37", "");
                    cmd.Parameters.AddWithValue("@F_4_3_38", "");
                    cmd.Parameters.AddWithValue("@F_4_3_39", "");
                    cmd.Parameters.AddWithValue("@F_4_3_40", "");
                    cmd.Parameters.AddWithValue("@F_4_3_41", "");
                    cmd.Parameters.AddWithValue("@F_4_3_42", "");
                    cmd.Parameters.AddWithValue("@F_4_3_43", "");
                    cmd.Parameters.AddWithValue("@F_4_3_44", "");
                    cmd.Parameters.AddWithValue("@F_4_3_45", "");
                    cmd.Parameters.AddWithValue("@F_4_3_46", "");
                    cmd.Parameters.AddWithValue("@F_4_3_47", "");
                    cmd.Parameters.AddWithValue("@F_4_3_48", "");
                    cmd.Parameters.AddWithValue("@F_4_3_49", "");
                    cmd.Parameters.AddWithValue("@F_4_3_50", "");
                    cmd.Parameters.AddWithValue("@F_4_3_51", "");
                    cmd.Parameters.AddWithValue("@F_4_3_52", "");
                    cmd.Parameters.AddWithValue("@F_4_3_53", "");
                    cmd.Parameters.AddWithValue("@F_4_3_54", "");
                    cmd.Parameters.AddWithValue("@F_4_3_55", "");
                    cmd.Parameters.AddWithValue("@F_4_3_56", "");
                    cmd.Parameters.AddWithValue("@F_4_3_57", "");
                    cmd.Parameters.AddWithValue("@F_4_3_58", "");
                    cmd.Parameters.AddWithValue("@F_4_3_59", "");
                    cmd.Parameters.AddWithValue("@F_4_3_60", "");
                    cmd.Parameters.AddWithValue("@F_4_3_61", "");
                    cmd.Parameters.AddWithValue("@F_4_3_62", "");
                    cmd.Parameters.AddWithValue("@F_4_3_63", "");
                    cmd.Parameters.AddWithValue("@F_4_3_64", "");
                    cmd.Parameters.AddWithValue("@F_4_3_65", "");
                    cmd.Parameters.AddWithValue("@F_4_3_66", "");
                    cmd.Parameters.AddWithValue("@F_4_3_67", "");
                    cmd.Parameters.AddWithValue("@F_4_3_68", "");
                    cmd.Parameters.AddWithValue("@F_4_3_69", "");
                    cmd.Parameters.AddWithValue("@F_4_3_70", "");
                    cmd.Parameters.AddWithValue("@F_4_3_71", "");
                    cmd.Parameters.AddWithValue("@F_4_3_72", "");
                    cmd.Parameters.AddWithValue("@F_4_3_73", "");
                    cmd.Parameters.AddWithValue("@F_4_3_74", "");
                    cmd.Parameters.AddWithValue("@F_4_3_75", "");
                    cmd.Parameters.AddWithValue("@F_4_3_76", "");
                    cmd.Parameters.AddWithValue("@F_4_3_77", "");
                    cmd.Parameters.AddWithValue("@F_4_3_78", "");
                    cmd.Parameters.AddWithValue("@F_4_3_79", "");
                    cmd.Parameters.AddWithValue("@F_4_3_80", "");
                    cmd.Parameters.AddWithValue("@F_4_3_81", "");
                    cmd.Parameters.AddWithValue("@F_4_3_82", "");

                    cmd.Parameters.AddWithValue("@F_4_4_1", "");
                    cmd.Parameters.AddWithValue("@F_4_4_2", "");
                    cmd.Parameters.AddWithValue("@F_4_4_3", "");
                    cmd.Parameters.AddWithValue("@F_4_4_4", "");
                    cmd.Parameters.AddWithValue("@F_4_4_5", "");
                    cmd.Parameters.AddWithValue("@F_4_4_6", "");
                    cmd.Parameters.AddWithValue("@F_4_4_7", "");
                    cmd.Parameters.AddWithValue("@F_4_4_8", "");
                    cmd.Parameters.AddWithValue("@F_4_4_9", "");
                    cmd.Parameters.AddWithValue("@F_4_4_10", "");
                    cmd.Parameters.AddWithValue("@F_4_4_11", "");
                    cmd.Parameters.AddWithValue("@F_4_4_12", "");
                    cmd.Parameters.AddWithValue("@F_4_4_13", "");
                    cmd.Parameters.AddWithValue("@F_4_4_14", "");
                    cmd.Parameters.AddWithValue("@F_4_4_15", "");
                    cmd.Parameters.AddWithValue("@F_4_4_16", "");
                    cmd.Parameters.AddWithValue("@F_4_4_17", "");
                    cmd.Parameters.AddWithValue("@F_4_4_18", "");
                    cmd.Parameters.AddWithValue("@F_4_4_19", "");
                    cmd.Parameters.AddWithValue("@F_4_4_20", "");
                    cmd.Parameters.AddWithValue("@F_4_4_21", "");
                    cmd.Parameters.AddWithValue("@F_4_4_22", "");
                    cmd.Parameters.AddWithValue("@F_4_4_23", "");
                    cmd.Parameters.AddWithValue("@F_4_4_24", "");
                    cmd.Parameters.AddWithValue("@F_4_4_25", "");
                    cmd.Parameters.AddWithValue("@F_4_4_26", "");
                    cmd.Parameters.AddWithValue("@F_4_4_27", "");
                    cmd.Parameters.AddWithValue("@F_4_4_28", "");
                    cmd.Parameters.AddWithValue("@F_4_4_29", "");
                    cmd.Parameters.AddWithValue("@F_4_4_30", "");
                    cmd.Parameters.AddWithValue("@F_4_4_31", "");
                    cmd.Parameters.AddWithValue("@F_4_4_32", "");
                    cmd.Parameters.AddWithValue("@F_4_4_33", "");
                    cmd.Parameters.AddWithValue("@F_4_4_34", "");
                    cmd.Parameters.AddWithValue("@F_4_4_35", "");
                    cmd.Parameters.AddWithValue("@F_4_4_36", "");
                    cmd.Parameters.AddWithValue("@F_4_4_37", "");
                    cmd.Parameters.AddWithValue("@F_4_4_38", "");
                    cmd.Parameters.AddWithValue("@F_4_4_39", "");
                    cmd.Parameters.AddWithValue("@F_4_4_40", "");
                    cmd.Parameters.AddWithValue("@F_4_4_41", "");
                    cmd.Parameters.AddWithValue("@F_4_4_42", "");
                    cmd.Parameters.AddWithValue("@F_4_4_43", "");
                    cmd.Parameters.AddWithValue("@F_4_4_44", "");
                    cmd.Parameters.AddWithValue("@F_4_4_45", "");
                    cmd.Parameters.AddWithValue("@F_4_4_46", "");
                    cmd.Parameters.AddWithValue("@F_4_4_47", "");
                    cmd.Parameters.AddWithValue("@F_4_4_48", "");
                    cmd.Parameters.AddWithValue("@F_4_4_49", "");
                    cmd.Parameters.AddWithValue("@F_4_4_50", "");
                    cmd.Parameters.AddWithValue("@F_4_4_51", "");
                    cmd.Parameters.AddWithValue("@F_4_4_52", "");
                    cmd.Parameters.AddWithValue("@F_4_4_53", "");
                    cmd.Parameters.AddWithValue("@F_4_4_54", "");
                    cmd.Parameters.AddWithValue("@F_4_4_55", "");
                    cmd.Parameters.AddWithValue("@F_4_4_56", "");


                    cmd.Parameters.AddWithValue("@F_4_5_1", "");
                    cmd.Parameters.AddWithValue("@F_4_5_2", "");
                    cmd.Parameters.AddWithValue("@F_4_5_3", "");
                    cmd.Parameters.AddWithValue("@F_4_5_4", "");
                    cmd.Parameters.AddWithValue("@F_4_5_5", "");
                    cmd.Parameters.AddWithValue("@F_4_5_6", "");
                    cmd.Parameters.AddWithValue("@F_4_5_7", "");
                    cmd.Parameters.AddWithValue("@F_4_5_8", "");
                    cmd.Parameters.AddWithValue("@F_4_5_9", "");
                    cmd.Parameters.AddWithValue("@F_4_5_10", "");
                    cmd.Parameters.AddWithValue("@F_4_5_11", "");
                    cmd.Parameters.AddWithValue("@F_4_5_12", "");
                    cmd.Parameters.AddWithValue("@F_4_5_13", "");
                    cmd.Parameters.AddWithValue("@F_4_5_14", "");
                    cmd.Parameters.AddWithValue("@F_4_5_15", "");
                    cmd.Parameters.AddWithValue("@F_4_5_16", "");
                    cmd.Parameters.AddWithValue("@F_4_5_17", "");
                    cmd.Parameters.AddWithValue("@F_4_5_18", "");
                    cmd.Parameters.AddWithValue("@F_4_5_19", "");
                    cmd.Parameters.AddWithValue("@F_4_5_20", "");
                    cmd.Parameters.AddWithValue("@F_4_5_21", "");
                    cmd.Parameters.AddWithValue("@F_4_5_22", "");
                    cmd.Parameters.AddWithValue("@F_4_5_23", "");
                    cmd.Parameters.AddWithValue("@F_4_5_24", "");
                    cmd.Parameters.AddWithValue("@F_4_5_25", "");
                    cmd.Parameters.AddWithValue("@F_4_5_26", "");
                    cmd.Parameters.AddWithValue("@F_4_5_27", "");
                    cmd.Parameters.AddWithValue("@F_4_5_28", "");
                    cmd.Parameters.AddWithValue("@F_4_5_29", "");
                    cmd.Parameters.AddWithValue("@F_4_5_30", "");
                    cmd.Parameters.AddWithValue("@F_4_5_31", "");

                    cmd.Parameters.AddWithValue("@F_4_6_1", "");
                    cmd.Parameters.AddWithValue("@F_4_6_2", "");
                    cmd.Parameters.AddWithValue("@F_4_6_3", "");
                    cmd.Parameters.AddWithValue("@F_4_6_4", "");
                    cmd.Parameters.AddWithValue("@F_4_6_5", "");
                    cmd.Parameters.AddWithValue("@F_4_6_6", "");
                    cmd.Parameters.AddWithValue("@F_4_6_7", "");
                    cmd.Parameters.AddWithValue("@F_4_6_8", "");
                    cmd.Parameters.AddWithValue("@F_4_6_9", "");
                    cmd.Parameters.AddWithValue("@F_4_6_10", "");
                    cmd.Parameters.AddWithValue("@F_4_6_11", "");
                    cmd.Parameters.AddWithValue("@F_4_6_12", "");
                    cmd.Parameters.AddWithValue("@F_4_6_13", "");
                    cmd.Parameters.AddWithValue("@F_4_6_14", "");
                    cmd.Parameters.AddWithValue("@F_4_6_15", "");
                    cmd.Parameters.AddWithValue("@F_4_6_16", "");
                    cmd.Parameters.AddWithValue("@F_4_6_17", "");
                    cmd.Parameters.AddWithValue("@F_4_6_18", "");
                    cmd.Parameters.AddWithValue("@F_4_6_19", "");
                    cmd.Parameters.AddWithValue("@F_4_6_20", "");
                    cmd.Parameters.AddWithValue("@F_4_6_21", "");
                    cmd.Parameters.AddWithValue("@F_4_6_22", "");
                    cmd.Parameters.AddWithValue("@F_4_6_23", "");
                    cmd.Parameters.AddWithValue("@F_4_6_24", "");
                    cmd.Parameters.AddWithValue("@F_4_6_25", "");
                    cmd.Parameters.AddWithValue("@F_4_6_26", "");
                    cmd.Parameters.AddWithValue("@F_4_6_27", "");
                    cmd.Parameters.AddWithValue("@F_4_6_28", "");
                    cmd.Parameters.AddWithValue("@F_4_6_29", "");
                    cmd.Parameters.AddWithValue("@F_4_6_30", "");
                    cmd.Parameters.AddWithValue("@F_4_6_31", "");
                    cmd.Parameters.AddWithValue("@F_4_6_32", "");
                    cmd.Parameters.AddWithValue("@F_4_6_33", "");
                    cmd.Parameters.AddWithValue("@F_4_6_34", "");
                    cmd.Parameters.AddWithValue("@F_4_6_35", "");
                    cmd.Parameters.AddWithValue("@F_4_6_36", "");
                    cmd.Parameters.AddWithValue("@F_4_6_37", "");
                    cmd.Parameters.AddWithValue("@F_4_6_38", "");
                    cmd.Parameters.AddWithValue("@F_4_6_39", "");
                    cmd.Parameters.AddWithValue("@F_4_6_40", "");
                    cmd.Parameters.AddWithValue("@F_4_6_41", "");
                    cmd.Parameters.AddWithValue("@F_4_6_42", "");

                    cmd.Parameters.AddWithValue("@F_4_7_1", "");
                    cmd.Parameters.AddWithValue("@F_4_7_2", "");
                    cmd.Parameters.AddWithValue("@F_4_7_3", "");
                    cmd.Parameters.AddWithValue("@F_4_7_4", "");
                    cmd.Parameters.AddWithValue("@F_4_7_5", "");
                    cmd.Parameters.AddWithValue("@F_4_7_6", "");
                    cmd.Parameters.AddWithValue("@F_4_7_7", "");
                    cmd.Parameters.AddWithValue("@F_4_7_8", "");
                    cmd.Parameters.AddWithValue("@F_4_7_9", "");
                    cmd.Parameters.AddWithValue("@F_4_7_10", "");
                    cmd.Parameters.AddWithValue("@F_4_7_11", "");
                    cmd.Parameters.AddWithValue("@F_4_7_12", "");
                    cmd.Parameters.AddWithValue("@F_4_7_13", "");
                    cmd.Parameters.AddWithValue("@F_4_7_14", "");
                    cmd.Parameters.AddWithValue("@F_4_7_15", "");
                    cmd.Parameters.AddWithValue("@F_4_7_16", "");
                    cmd.Parameters.AddWithValue("@F_4_7_17", "");
                    cmd.Parameters.AddWithValue("@F_4_7_18", "");
                    cmd.Parameters.AddWithValue("@F_4_7_19", "");
                    cmd.Parameters.AddWithValue("@F_4_7_20", "");
                    cmd.Parameters.AddWithValue("@F_4_7_21", "");
                    cmd.Parameters.AddWithValue("@F_4_7_22", "");
                    cmd.Parameters.AddWithValue("@F_4_7_23", "");
                    cmd.Parameters.AddWithValue("@F_4_7_24", "");
                    cmd.Parameters.AddWithValue("@F_4_7_25", "");
                    cmd.Parameters.AddWithValue("@F_4_7_26", "");
                    cmd.Parameters.AddWithValue("@F_4_7_27", "");
                    cmd.Parameters.AddWithValue("@F_4_7_28", "");
                    cmd.Parameters.AddWithValue("@F_4_7_29", "");
                    cmd.Parameters.AddWithValue("@F_4_7_30", "");
                    cmd.Parameters.AddWithValue("@F_4_7_31", "");
                    cmd.Parameters.AddWithValue("@F_4_7_32", "");
                    cmd.Parameters.AddWithValue("@F_4_7_33", "");
                    cmd.Parameters.AddWithValue("@F_4_7_34", "");
                    cmd.Parameters.AddWithValue("@F_4_7_35", "");
                    cmd.Parameters.AddWithValue("@F_4_7_36", "");
                    cmd.Parameters.AddWithValue("@F_4_7_37", "");
                    cmd.Parameters.AddWithValue("@F_4_7_38", "");
                    cmd.Parameters.AddWithValue("@F_4_7_39", "");
                    cmd.Parameters.AddWithValue("@F_4_7_40", "");
                    cmd.Parameters.AddWithValue("@F_4_7_41", "");
                    cmd.Parameters.AddWithValue("@F_4_7_42", "");
                    cmd.Parameters.AddWithValue("@F_4_7_43", "");
                    cmd.Parameters.AddWithValue("@F_4_7_44", "");
                    cmd.Parameters.AddWithValue("@F_4_7_45", "");
                    cmd.Parameters.AddWithValue("@F_4_7_46", "");
                    cmd.Parameters.AddWithValue("@F_4_7_47", "");
                    cmd.Parameters.AddWithValue("@F_4_7_48", "");
                    cmd.Parameters.AddWithValue("@F_4_7_49", "");
                    cmd.Parameters.AddWithValue("@F_4_7_50", "");
                    cmd.Parameters.AddWithValue("@F_4_7_51", "");
                    cmd.Parameters.AddWithValue("@F_4_7_52", "");
                    cmd.Parameters.AddWithValue("@F_4_7_53", "");
                    cmd.Parameters.AddWithValue("@F_4_7_54", "");
                    cmd.Parameters.AddWithValue("@F_4_7_55", "");
                    cmd.Parameters.AddWithValue("@F_4_7_56", "");
                    cmd.Parameters.AddWithValue("@F_4_7_57", "");
                    cmd.Parameters.AddWithValue("@F_4_7_58", "");
                    cmd.Parameters.AddWithValue("@F_4_7_59", "");
                    cmd.Parameters.AddWithValue("@F_4_7_60", "");
                    cmd.Parameters.AddWithValue("@F_4_7_61", "");

                    cmd.Parameters.AddWithValue("@F_5_1", "");
                    cmd.Parameters.AddWithValue("@F_5_2", "");
                    cmd.Parameters.AddWithValue("@F_5_3", "");
                    cmd.Parameters.AddWithValue("@F_5_4", "");
                    cmd.Parameters.AddWithValue("@F_5_5", "");
                    cmd.Parameters.AddWithValue("@F_5_6", "");
                    cmd.Parameters.AddWithValue("@F_5_7", "");
                    cmd.Parameters.AddWithValue("@F_5_8", "");
                    cmd.Parameters.AddWithValue("@F_5_9", "");
                    cmd.Parameters.AddWithValue("@F_5_10", "");
                    cmd.Parameters.AddWithValue("@F_5_11", "");
                    cmd.Parameters.AddWithValue("@F_5_12", "");
                    cmd.Parameters.AddWithValue("@F_5_13", "");
                    cmd.Parameters.AddWithValue("@F_5_14", "");
                    cmd.Parameters.AddWithValue("@F_5_15", "");
                    cmd.Parameters.AddWithValue("@F_5_16", "");
                    cmd.Parameters.AddWithValue("@F_5_17", "");
                    cmd.Parameters.AddWithValue("@F_5_18", "");
                    cmd.Parameters.AddWithValue("@F_5_19", "");
                    cmd.Parameters.AddWithValue("@F_5_20", "");
                    cmd.Parameters.AddWithValue("@F_5_21", "");
                    cmd.Parameters.AddWithValue("@F_5_22", "");
                    cmd.Parameters.AddWithValue("@F_5_23", "");
                    cmd.Parameters.AddWithValue("@F_5_24", "");
                    cmd.Parameters.AddWithValue("@F_5_25", "");
                    cmd.Parameters.AddWithValue("@F_5_26", "");
                    cmd.Parameters.AddWithValue("@F_5_27", "");
                    cmd.Parameters.AddWithValue("@F_5_28", "");
                    cmd.Parameters.AddWithValue("@F_5_29", "");
                    cmd.Parameters.AddWithValue("@F_5_30", "");
                    cmd.Parameters.AddWithValue("@F_5_31", "");
                    cmd.Parameters.AddWithValue("@F_5_32", "");
                    cmd.Parameters.AddWithValue("@F_5_33", "");
                    cmd.Parameters.AddWithValue("@F_5_34", "");
                    cmd.Parameters.AddWithValue("@F_5_35", "");
                    cmd.Parameters.AddWithValue("@F_5_36", "");
                    cmd.Parameters.AddWithValue("@F_5_37", "");
                    cmd.Parameters.AddWithValue("@F_5_38", "");
                    cmd.Parameters.AddWithValue("@F_5_39", "");
                    cmd.Parameters.AddWithValue("@F_5_40", "");
                    cmd.Parameters.AddWithValue("@F_5_41", "");
                    cmd.Parameters.AddWithValue("@F_5_42", "");
                    cmd.Parameters.AddWithValue("@F_5_43", "");
                    cmd.Parameters.AddWithValue("@F_5_44", "");
                    cmd.Parameters.AddWithValue("@F_5_45", "");
                    cmd.Parameters.AddWithValue("@F_5_46", "");
                    cmd.Parameters.AddWithValue("@F_5_47", "");
                    cmd.Parameters.AddWithValue("@F_5_48", "");
                    cmd.Parameters.AddWithValue("@F_5_49", "");
                    cmd.Parameters.AddWithValue("@F_5_50", "");
                    cmd.Parameters.AddWithValue("@F_5_51", "");
                    cmd.Parameters.AddWithValue("@F_5_52", "");
                    cmd.Parameters.AddWithValue("@F_5_53", "");
                    cmd.Parameters.AddWithValue("@F_5_54", "");
                    cmd.Parameters.AddWithValue("@F_5_55", "");
                    cmd.Parameters.AddWithValue("@F_5_56", "");
                    cmd.Parameters.AddWithValue("@F_5_57", "");

                    cmd.Parameters.AddWithValue("@F_5", "");
                    cmd.Parameters.AddWithValue("@F_6", "");
                    cmd.Parameters.AddWithValue("@F_7", "");
                    cmd.Parameters.AddWithValue("@F_8", "");

                    cmd.Parameters.AddWithValue("@UserName", userName);
                    con.Open();


                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        if (sdr.HasRows)
                        {
                            m_txtF_1 = sdr["F_1"].ToString();
                            string fileName = "Rule 8_05 Financial Statement.pdf";
                            string fileExtension = ".pdf";

                            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Server.MapPath("~/Secured/Files/" + fileName)));
                            Document doc = new Document(pdfDoc);

                            Div d = new Div();
                            Paragraph p = new Paragraph("Rule 8.05 Financial Statement");
                            d.Add(p);
                            doc.Add(d);

                            Div d1 = new Div();
                            //Div d = new Div();
                            d1.SetWidth(1000);
                            //d1.SetHeight(100);
                            d1.SetTextAlignment(TextAlignment.CENTER);
                            p = new Paragraph("EXHIBIT “A”");
                            d1.Add(p);
                            doc.Add(d1);

                            Div d2 = new Div();
                            string tekst = "IN THE CHANCERY COURT OF " + sdr["F_1"].ToString() + " COUNTY, MISSISSIPPI";
                            d2.SetWidth(1000);
                            //d2.SetHeight(100);
                            //d2.SetUnderline(1.5f, -1);
                            d2.SetTextAlignment(TextAlignment.CENTER);
                            p = new Paragraph(tekst);
                            d2.Add(p);
                            doc.Add(d2);

                            Div d3 = new Div();
                            tekst = "Plaintiff:               "+ sdr["F_2"].ToString();
                            d3.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d3.Add(p);
                            doc.Add(d3);

                            Div d4 = new Div();
                            tekst ="V.     Cause number:     " + sdr["F_3"].ToString();
                            d4.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d4.Add(p);
                            doc.Add(d4);

                            Div d5 = new Div();
                            tekst = "Defendant:               " + sdr["F_4"].ToString();
                            d5.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d5.Add(p);
                            doc.Add(d5);

                            Div d6 = new Div();
                            tekst = "***********************************************************************************************";
                            d6.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d6.Add(p);
                            doc.Add(d6);

                            Div d7 = new Div();
                            tekst = "I. General Information"; 
                            d7.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d7.Add(p);
                            doc.Add(d7);

                            Div d8= new Div();
                            tekst = "Name                     " + sdr["Name"].ToString();
                            d8.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d8.Add(p);
                            doc.Add(d8);

                            Div d9 = new Div();
                            tekst = "Address:                 " + sdr["Address"].ToString();
                            d9.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d9.Add(p);
                            doc.Add(d9);

                            Div d10 = new Div();
                            tekst = "City, State and Zip Code: " + sdr["City"].ToString();
                            d10.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d10.Add(p);
                            doc.Add(d10);

                            Div d11 = new Div();
                            tekst = "Home Telephone:           " + sdr["Home_Phone"].ToString();
                            d11.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d11.Add(p);
                            doc.Add(d11);

                            Div d12 = new Div();
                            tekst = "Date of birth:           " + sdr["Date_Birth"].ToString();
                            d12.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d12.Add(p);
                            doc.Add(d12);

                            Div d13 = new Div();
                            tekst = "Occupation:              " + sdr["Occupation"].ToString();
                            d13.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d13.Add(p);
                            doc.Add(d13);

                            Div d14 = new Div();
                            tekst = "Employer:                " + sdr["Employer"].ToString();
                            d14.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d14.Add(p);
                            doc.Add(d14);

                            Div d15 = new Div();
                            tekst = "Employer's Address:      " + sdr["Employer_Adress"].ToString();
                            d15.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d15.Add(p);
                            doc.Add(d15);

                            Div d15_1 = new Div();
                            tekst = "Employer's City, State and ZIP code:      " + sdr["Employer_City"].ToString();
                            d15_1.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d15_1.Add(p);
                            doc.Add(d15_1);


                            Div d16 = new Div();
                            tekst = "Employer's Telephone     " + sdr["Employer_Phone"].ToString();
                            d16.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d16.Add(p);
                            doc.Add(d16);

                            Div d17 = new Div();
                            tekst = "                                                     ";
                            d17.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d17.Add(p);
                            doc.Add(d17);

                            Div d18 = new Div();
                            tekst = "                                                     ";
                            d18.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d18.Add(p);
                            doc.Add(d18);

                            //Div d19 = new Div();
                            //d19.SetWidth(1000);
                            //d19.SetTextAlignment(TextAlignment.CENTER);
                            //p = new Paragraph("Minor Children");
                            //d19.Add(p);
                            //doc.Add(d19);

                            //Div d20 = new Div();
                            //d20.SetWidth(1000);
                            //d20.SetTextAlignment(TextAlignment.CENTER);
                            //p = new Paragraph("Name                           Date of Birth");
                            //d20.Add(p);
                            //doc.Add(d20);

                            //ad  new table
                            //Table table = new Table(new float[2]).UseAllAvailableWidth();
                            float[] columnWidths = { 1, 1 };
                            Table table = new Table(UnitValue.CreatePercentArray(columnWidths));
                            table.SetMarginTop(0);
                            table.SetMarginBottom(0);
                            table.SetWidth(500);

                            // first row
                            Cell cell = new Cell(1, 2).Add(new Paragraph("Minor children"));
                            cell.SetTextAlignment(TextAlignment.CENTER);
                            cell.SetPadding(5);
                            //cell.SetBackgroundColor(new DeviceRgb(230, 230, 230));
                            table.AddCell(cell);

                            table.AddCell("Name").SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell("Date of Birth").SetTextAlignment(TextAlignment.CENTER); ;

                            string exp_1 = "";
                            string exp_2 = "";

                            for (int i = 1; i <= 6; i++)
                            {
                                exp_1 = "Children" + i.ToString() + "_Name";
                                exp_2 = "Children" + i.ToString() + "_Date";
                                table.AddCell(sdr[exp_1].ToString());
                                table.AddCell(sdr[exp_2].ToString());
                            }

                            doc.Add(table);

                            //Add page 2
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d21= new Div();
                            tekst = "II. Income Statement";
                            d21.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d21.Add(p);
                            doc.Add(d21);

                            //ad  new table
                            float[] columnWidths1 = { 3, 1 };
                            Table table1 = new Table(UnitValue.CreatePercentArray(columnWidths1));
                            table1.SetMarginTop(0);
                            table1.SetMarginBottom(0);
                            table1.SetWidth(500);

                            // first row
                            Cell cell1 = new Cell(1, 1).Add(new Paragraph("Gross Monthly Income"));
                            cell1.SetTextAlignment(TextAlignment.LEFT);
                            cell1.SetPadding(5);
                            table1.AddCell(cell1);
                            //cell1.SetBackgroundColor(new DeviceRgb(140, 221, 8));
                            Cell cell2 = new Cell(1, 2).Add(new Paragraph("Amount"));
                            cell2.SetTextAlignment(TextAlignment.RIGHT);
                            cell2.SetPadding(5);
                            table1.AddCell(cell2);

                            //table1.AddCell("Gross Monthly Income");
                            //table1.AddCell("Amount").SetTextAlignment(TextAlignment.RIGHT); 
                            Cell cell21 = new Cell(1, 1).Add(new Paragraph("1. Salary and Wages, including commissions bonuses,allowance and overtime. NOTE:To arrive at a monthly income figure if paid weekly, multiply weekly income by 4.3, if paid biweekly, multiply income by 2.16"));
                            cell21.SetTextAlignment(TextAlignment.LEFT);
                            cell21.SetPadding(5);
                            table1.AddCell(cell21);
                            Cell cell_f21 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_1"].ToString()));
                            cell_f21.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f21.SetPadding(5);
                            table1.AddCell(cell_f21);

                            Cell cell22 = new Cell(1, 1).Add(new Paragraph("2. Pensions and retirements"));
                            cell22.SetTextAlignment(TextAlignment.LEFT);
                            cell22.SetPadding(5);
                            table1.AddCell(cell22);
                            Cell cell_f22 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_2"].ToString()));
                            cell_f22.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f22.SetPadding(5);
                            table1.AddCell(cell_f22);

                            Cell cell23 = new Cell(1, 1).Add(new Paragraph("3. Social Security"));
                            cell23.SetTextAlignment(TextAlignment.LEFT);
                            cell23.SetPadding(5);
                            table1.AddCell(cell23);
                            Cell cell_f23 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_3"].ToString()));
                            cell_f23.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f23.SetPadding(5);
                            table1.AddCell(cell_f23);

                            Cell cell24 = new Cell(1, 1).Add(new Paragraph("4. Disability and unemployment insurance"));
                            cell24.SetTextAlignment(TextAlignment.LEFT);
                            cell24.SetPadding(5);
                            table1.AddCell(cell24);
                            Cell cell_f24 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_4"].ToString()));
                            cell_f24.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f24.SetPadding(5);
                            table1.AddCell(cell_f24);

                            Cell cell25 = new Cell(1, 1).Add(new Paragraph("5. Public Assistance (welfare, AFDC payments, etc."));
                            cell25.SetTextAlignment(TextAlignment.LEFT);
                            cell25.SetPadding(5);
                            table1.AddCell(cell25);
                            Cell cell_f25 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_5"].ToString()));
                            cell_f25.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f25.SetPadding(5);
                            table1.AddCell(cell_f25);

                            Cell cell26 = new Cell(1, 1).Add(new Paragraph("6. Dividends and interest"));
                            cell26.SetTextAlignment(TextAlignment.LEFT);
                            cell26.SetPadding(5);
                            table1.AddCell(cell26);
                            Cell cell_f26 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_6"].ToString()));
                            cell_f26.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f26.SetPadding(5);
                            table1.AddCell(cell_f26);

                            Cell cell27 = new Cell(1, 1).Add(new Paragraph("7. Rental Income"));
                            cell27.SetTextAlignment(TextAlignment.LEFT);
                            cell27.SetPadding(5);
                            table1.AddCell(cell27);
                            Cell cell_f27 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_7"].ToString()));
                            cell_f27.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f27.SetPadding(5);
                            table1.AddCell(cell_f27);

                            Cell cell28 = new Cell(1, 1).Add(new Paragraph("8. Other Income"));
                            cell28.SetTextAlignment(TextAlignment.LEFT);
                            cell28.SetPadding(5);
                            table1.AddCell(cell28);
                            Cell cell_f28 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_8"].ToString()));
                            cell_f28.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f28.SetPadding(5);
                            table1.AddCell(cell_f28);

                            table1.AddCell("-");
                            table1.AddCell("");
                            table1.AddCell("-");
                            table1.AddCell("");

                            table1.AddCell("9. TOTAL MONTHLY INCOME");
                            cell.SetTextAlignment(TextAlignment.CENTER);
                            cell.SetBold();
                            Cell cell_f29 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_9"].ToString()));
                            cell_f29.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f29.SetPadding(5);
                            table1.AddCell(cell_f29);

                            table1.AddCell(".");
                            table1.AddCell("");
                            table1.AddCell("ITEMIZED MONTHLY DEDUCTIONS:");
                            cell.SetTextAlignment(TextAlignment.CENTER);
                            cell.SetBold();
                            table1.AddCell("");


                            Cell cell210 = new Cell(1, 1).Add(new Paragraph("1. State Income Tax"));
                            cell210.SetTextAlignment(TextAlignment.LEFT);
                            cell210.SetPadding(5);
                            table1.AddCell(cell210);
                            Cell cell_f210 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_10"].ToString()));
                            cell_f210.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f210.SetPadding(5);
                            table1.AddCell(cell_f210);
                            //table1.AddCell("1. State Income Tax").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_10"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell211 = new Cell(1, 1).Add(new Paragraph("2. Federal Income Tax"));
                            cell211.SetTextAlignment(TextAlignment.LEFT);
                            cell211.SetPadding(5);
                            table1.AddCell(cell211);
                            Cell cell_f211 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_11"].ToString()));
                            cell_f211.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f211.SetPadding(5);
                            table1.AddCell(cell_f211);
                            //table1.AddCell("2. Federal Income Tax").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_11"].ToString()).SetTextAlignment(TextAlignment.RIGHT);



                            Cell cell212 = new Cell(1, 1).Add(new Paragraph("3. Social Security"));
                            cell212.SetTextAlignment(TextAlignment.LEFT);
                            cell212.SetPadding(5);
                            table1.AddCell(cell212);
                            Cell cell_f212 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_12"].ToString()));
                            cell_f212.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f212.SetPadding(5);
                            table1.AddCell(cell_f212);
                            //table1.AddCell("3. Social Security").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_12"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell213 = new Cell(1, 1).Add(new Paragraph("4. Mandatory Insurance"));
                            cell213.SetTextAlignment(TextAlignment.LEFT);
                            cell213.SetPadding(5);
                            table1.AddCell(cell213);
                            Cell cell_f213 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_13"].ToString()));
                            cell_f213.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f213.SetPadding(5);
                            table1.AddCell(cell_f213);
                            //table1.AddCell("4. Mandatory Insurance").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_13"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell214 = new Cell(1, 1).Add(new Paragraph("5.Mandatory Retirement"));
                            cell214.SetTextAlignment(TextAlignment.LEFT);
                            cell214.SetPadding(5);
                            table1.AddCell(cell214);
                            Cell cell_f214 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_14"].ToString()));
                            cell_f214.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f214.SetPadding(5);
                            table1.AddCell(cell_f214);
                            //table1.AddCell("5. Mandatory Retirement").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_14"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell215 = new Cell(1, 1).Add(new Paragraph("6. Union or other dues"));
                            cell215.SetTextAlignment(TextAlignment.LEFT);
                            cell215.SetPadding(5);
                            table1.AddCell(cell215);
                            Cell cell_f215 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_15"].ToString()));
                            cell_f215.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f215.SetPadding(5);
                            table1.AddCell(cell_f215);
                            //table1.AddCell("6. Union or other dues").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_15"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell216 = new Cell(1, 1).Add(new Paragraph("7. Other: (Specify)"));
                            cell216.SetTextAlignment(TextAlignment.LEFT);
                            cell216.SetPadding(5);
                            table1.AddCell(cell216);
                            Cell cell_f216 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_16"].ToString()));
                            cell_f216.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f216.SetPadding(5);
                            table1.AddCell(cell_f216);
                            //table1.AddCell("7. Other: (Specify)").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_16"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell217 = new Cell(1, 1).Add(new Paragraph("8. Other:"));
                            cell217.SetTextAlignment(TextAlignment.LEFT);
                            cell217.SetPadding(5);
                            table1.AddCell(cell217);
                            Cell cell_f217 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_17"].ToString()));
                            cell_f217.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f217.SetPadding(5);
                            table1.AddCell(cell_f217);
                            //table1.AddCell("8. Other:").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_17"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell218 = new Cell(1, 1).Add(new Paragraph("9. Total Monthly Deductions"));
                            cell218.SetTextAlignment(TextAlignment.LEFT);
                            cell218.SetPadding(5);
                            table1.AddCell(cell218);
                            Cell cell_f218 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_18"].ToString()));
                            cell_f218.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f218.SetPadding(5);
                            table1.AddCell(cell_f218);
                            //table1.AddCell("9. TOTAL MONTHLY DEDUCTIONS");
                            //table1.AddCell("-" + sdr["F_2_18"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell219 = new Cell(1, 1).Add(new Paragraph("10. Number of Exemptions"));
                            cell219.SetTextAlignment(TextAlignment.LEFT);
                            cell219.SetPadding(5);
                            table1.AddCell(cell219);
                            Cell cell_f219 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_19"].ToString()));
                            cell_f219.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f219.SetPadding(5);
                            table1.AddCell(cell_f219);
                            //table1.AddCell("10. NUMBER OF EXEMPTIONS").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_19"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            Cell cell220 = new Cell(1, 1).Add(new Paragraph("11. Net Monthly Pay"));
                            cell220.SetTextAlignment(TextAlignment.LEFT);
                            cell220.SetPadding(5);
                            table1.AddCell(cell220);
                            Cell cell_f220 = new Cell(1, 2).Add(new Paragraph(sdr["F_2_20"].ToString()));
                            cell_f220.SetTextAlignment(TextAlignment.RIGHT);
                            cell_f220.SetPadding(5);
                            table1.AddCell(cell_f220);
                            //table1.AddCell("11. NET MONTHLY PAY").SetTextAlignment(TextAlignment.LEFT);
                            //table1.AddCell("-" + sdr["F_2_20"].ToString()).SetTextAlignment(TextAlignment.RIGHT);

                            doc.Add(table1);

                            //Add page 3
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d22 = new Div();
                            tekst = "III. Expenses Statement";
                            d22.SetWidth(1000);
                            p = new Paragraph(tekst);
                            d22.Add(p);
                            doc.Add(d22);

                            //ad  new table
                            float[] columnWidths2 = { 3, 1, 1 };
                            Table table2 = new Table(UnitValue.CreatePercentArray(columnWidths2));
                            table2.SetMarginTop(0);
                            table2.SetMarginBottom(0);
                            table2.SetWidth(500);

                            // first row
                            table2.AddCell("A. LIVING EXPENSES");
                            table2.AddCell("Self");
                            table2.AddCell("Children");

                            table2.AddCell("1. Rent/Mortgage (Residence)");
                            table2.AddCell(sdr["F_3_1_1"].ToString());
                            table2.AddCell(sdr["F_3_1_2"].ToString());

                            table2.AddCell("2. Real Property Taxes");
                            table2.AddCell(sdr["F_3_2_1"].ToString());
                            table2.AddCell(sdr["F_3_2_2"].ToString());

                            table2.AddCell("3. Real Property Insurance");
                            table2.AddCell(sdr["F_3_3_1"].ToString());
                            table2.AddCell(sdr["F_3_3_2"].ToString());

                            table2.AddCell("4. Maintenance (Residence)");
                            table2.AddCell(sdr["F_3_4_1"].ToString());
                            table2.AddCell(sdr["F_3_4_2"].ToString());

                            table2.AddCell("5. Food/household Supplies");
                            table2.AddCell(sdr["F_3_5_1"].ToString());
                            table2.AddCell(sdr["F_3_5_2"].ToString());

                            table2.AddCell("6. Water, Sewer, Etc.");
                            table2.AddCell(sdr["F_3_6_1"].ToString());
                            table2.AddCell(sdr["F_3_6_2"].ToString());

                            table2.AddCell("7. Electricity)");
                            table2.AddCell(sdr["F_3_7_1"].ToString());
                            table2.AddCell(sdr["F_3_7_2"].ToString());

                            table2.AddCell("8. Gas (Residence)");
                            table2.AddCell(sdr["F_3_8_1"].ToString());
                            table2.AddCell(sdr["F_3_8_2"].ToString());

                            table2.AddCell("9. Telephone");
                            table2.AddCell(sdr["F_3_9_1"].ToString());
                            table2.AddCell(sdr["F_3_9_2"].ToString());

                            table2.AddCell("10. Laundry and Cleaning");
                            table2.AddCell(sdr["F_3_10_1"].ToString());
                            table2.AddCell(sdr["F_3_10_2"].ToString());

                            table2.AddCell("11. Clothing");
                            table2.AddCell(sdr["F_3_11_1"].ToString());
                            table2.AddCell(sdr["F_3_11_2"].ToString());

                            table2.AddCell("12. Insurance (Not Payroll Deducted)");
                            table2.AddCell(sdr["F_3_12_1"].ToString());
                            table2.AddCell(sdr["F_3_12_2"].ToString());

                            table2.AddCell("13. Medical");
                            table2.AddCell(sdr["F_3_13_1"].ToString());
                            table2.AddCell(sdr["F_3_13_2"].ToString());

                            table2.AddCell("14. Dental");
                            table2.AddCell(sdr["F_3_14_1"].ToString());
                            table2.AddCell(sdr["F_3_14_2"].ToString());

                            table2.AddCell("15. Child Care");
                            table2.AddCell(sdr["F_3_15_1"].ToString());
                            table2.AddCell(sdr["F_3_15_2"].ToString());

                            table2.AddCell("16. Children’s Allowance");
                            table2.AddCell(sdr["F_3_16_1"].ToString());
                            table2.AddCell(sdr["F_3_16_2"].ToString());

                            table2.AddCell("17. Payment of Child Support/alimony (Prior Marriage)");
                            table2.AddCell(sdr["F_3_17_1"].ToString());
                            table2.AddCell(sdr["F_3_17_2"].ToString());

                            table2.AddCell("18. School Expenses");
                            table2.AddCell(sdr["F_3_18_1"].ToString());
                            table2.AddCell(sdr["F_3_18_2"].ToString());

                            table2.AddCell("19. Entertainment");
                            table2.AddCell(sdr["F_3_19_1"].ToString());
                            table2.AddCell(sdr["F_3_19_2"].ToString());

                            table2.AddCell("20. Incidentals & Misc.");
                            table2.AddCell(sdr["F_3_20_1"].ToString());
                            table2.AddCell(sdr["F_3_20_2"].ToString());

                            table2.AddCell("21. Transportation Other than Vehicle");
                            table2.AddCell(sdr["F_3_21_1"].ToString());
                            table2.AddCell(sdr["F_3_21_2"].ToString());

                            table2.AddCell("22. Gasoline & Oil (Auto)");
                            table2.AddCell(sdr["F_3_22_1"].ToString());
                            table2.AddCell(sdr["F_3_22_2"].ToString());

                            table2.AddCell("23. Repair (Auto)");
                            table2.AddCell(sdr["F_3_23_1"].ToString());
                            table2.AddCell(sdr["F_3_23_2"].ToString());

                            table2.AddCell("24. Insurance (Auto)");
                            table2.AddCell(sdr["F_3_24_1"].ToString());
                            table2.AddCell(sdr["F_3_24_2"].ToString());

                            table2.AddCell("25. Auto Payments");
                            table2.AddCell(sdr["F_3_25_1"].ToString());
                            table2.AddCell(sdr["F_3_25_2"].ToString());

                            table2.AddCell("26. Church Donations");
                            table2.AddCell(sdr["F_3_26_1"].ToString());
                            table2.AddCell(sdr["F_3_26_2"].ToString());

                            doc.Add(table2);

                            //Add page 4
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            //ad  new table
                            float[] columnWidths3 = { 3, 1 , 1 };
                            Table table3 = new Table(UnitValue.CreatePercentArray(columnWidths3));
                            table3.SetMarginTop(0);
                            table3.SetMarginBottom(0);
                            table3.SetWidth(500);

                            table3.AddCell("27. Charitable Donations");
                            table3.AddCell(sdr["F_3_27_1"].ToString());
                            table3.AddCell(sdr["F_3_27_2"].ToString());

                            table3.AddCell("28. Newspaper/magazine");
                            table3.AddCell(sdr["F_3_28_1"].ToString());
                            table3.AddCell(sdr["F_3_28_2"].ToString());

                            table3.AddCell("29. Cable tv");
                            table3.AddCell(sdr["F_3_29_1"].ToString());
                            table3.AddCell(sdr["F_3_2_2"].ToString());

                            table3.AddCell("30. Pet Expenses");
                            table3.AddCell(sdr["F_3_30_1"].ToString());
                            table3.AddCell(sdr["F_3_30_2"].ToString());

                            table3.AddCell("31. Yard Expenses");
                            table3.AddCell(sdr["F_3_31_1"].ToString());
                            table3.AddCell(sdr["F_3_31_2"].ToString());

                            table3.AddCell("32. Maid");
                            table3.AddCell(sdr["F_3_32_1"].ToString());
                            table3.AddCell(sdr["F_3_32_2"].ToString());

                            table3.AddCell("33. Retirement (Ira, Etc.)");
                            table3.AddCell(sdr["F_3_33_1"].ToString());
                            table3.AddCell(sdr["F_3_33_2"].ToString());

                            table3.AddCell("34. Pest Control");
                            table3.AddCell(sdr["F_3_34_1"].ToString());
                            table3.AddCell(sdr["F_3_34_2"].ToString());

                            table3.AddCell(".");
                            table3.AddCell("");
                            table3.AddCell("");

                            table3.AddCell("B. TOTAL LIVING EXPENSES");
                            table3.AddCell(sdr["F_3_35_1"].ToString());
                            table3.AddCell(sdr["F_3_35_2"].ToString());

                            table3.AddCell("35. INSTALLMENT PAYMENTS");
                            table3.AddCell("Self");
                            table3.AddCell("Children");

                            table3.AddCell("Notes, Loans, Charge Accounts, Etc.");
                            table3.AddCell("");
                            table3.AddCell("");

                            table3.AddCell("36.");
                            table3.AddCell(sdr["F_3_36_1"].ToString());
                            table3.AddCell(sdr["F_3_36_2"].ToString());

                            table3.AddCell("37.");
                            table3.AddCell(sdr["F_3_37_1"].ToString());
                            table3.AddCell(sdr["F_3_37_2"].ToString());

                            table3.AddCell("38.");
                            table3.AddCell(sdr["F_3_38_1"].ToString());
                            table3.AddCell(sdr["F_3_38_2"].ToString());

                            table3.AddCell("39. Other Expenses");
                            table3.AddCell(sdr["F_3_39_1"].ToString());
                            table3.AddCell(sdr["F_3_39_2"].ToString());

                            table3.AddCell("40.");
                            table3.AddCell(sdr["F_3_40_1"].ToString());
                            table3.AddCell(sdr["F_3_40_2"].ToString());

                            table3.AddCell("41.");
                            table3.AddCell(sdr["F_3_41_1"].ToString());
                            table3.AddCell(sdr["F_3_41_2"].ToString());

                            table3.AddCell("42.");
                            table3.AddCell(sdr["F_3_42_1"].ToString());
                            table3.AddCell(sdr["F_3_42_2"].ToString());

                            table3.AddCell("43.");
                            table3.AddCell(sdr["F_3_43_1"].ToString());
                            table3.AddCell(sdr["F_3_43_2"].ToString());

                            table3.AddCell("Total Installments Payments:");
                            table3.AddCell(sdr["F_3_44_1"].ToString());
                            table3.AddCell(sdr["F_3_44_2"].ToString());

                            table3.AddCell("Combined Total Expenses: Total Line 1-43");
                            table3.AddCell(sdr["F_3_45_1"].ToString());
                            table3.AddCell(sdr["F_3_45_2"].ToString());

                            doc.Add(table3);


                            //Add page 5
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d23 = new Div();
                            d23.SetWidth(1000);
                            d23.SetTextAlignment(TextAlignment.CENTER);
                            d23.SetMarginLeft(5);
                            p = new Paragraph("EXHIBIT “B”");
                            d23.Add(p);
                            doc.Add(d23);

                            Div d24 = new Div();
                            string tekst24 = "IV.     STATEMENT OF ASSETS";
                            d24.SetWidth(1000);
                            p = new Paragraph(tekst24);
                            d24.Add(p);
                            doc.Add(d24);

                            Div d25 = new Div();
                            string tekst25 = "A.   Real Estate";
                            d25.SetWidth(1000);
                            d25.SetMarginLeft(15);
                            p = new Paragraph(tekst25);
                            d25.Add(p);
                            doc.Add(d25);

                            Div d26 = new Div();
                            string tekst26 = "1.     Title in the name of:" +  sdr["F_4_1_1"].ToString();
                            d26.SetWidth(1000);
                            d26.SetMarginLeft(15);
                            p = new Paragraph(tekst26);
                            d26.Add(p);
                            doc.Add(d26);

                            Div d27 = new Div();
                            string tekst27 = "Address:" + sdr["F_4_1_2"].ToString() + "  " + sdr["F_4_1_3"].ToString();
                            d27.SetMarginLeft(25);
                            d27.SetWidth(1000);
                            p = new Paragraph(tekst27);
                            d27.Add(p);
                            doc.Add(d27);

                            //Div d28 = new Div();
                            //string tekst28 = "" + sdr["F_4_1_3"].ToString();
                            //d28.SetMarginLeft(25);
                            //d28.SetUnderline();
                            //d28.SetWidth(1000);
                            //p = new Paragraph(tekst28);
                            //d28.Add(p);
                            //doc.Add(d28);

                            Div d29= new Div();
                            string tekst29 = "Who paid cost:" + sdr["F_4_1_4"].ToString();
                            d29.SetMarginLeft(25);
                            d29.SetWidth(1000);
                            p = new Paragraph(tekst29);
                            d29.Add(p);
                            doc.Add(d29);

                            Div d30 = new Div();
                            string tekst30 = "How cost paid:" + sdr["F_4_1_5"].ToString();
                            d30.SetMarginLeft(25);
                            d30.SetWidth(1000);
                            p = new Paragraph(tekst30);
                            d30.Add(p);
                            doc.Add(d30);

                            Div d31 = new Div();
                            string tekst31 = "Value:" + sdr["F_4_1_6"].ToString();
                            d31.SetMarginLeft(35);
                            d31.SetWidth(1000);
                            p = new Paragraph(tekst31);
                            d31.Add(p);
                            doc.Add(d31);

                            Div d32 = new Div();
                            string tekst32 = "Mortgage Balance:" + sdr["F_4_1_7"].ToString();
                            d32.SetMarginLeft(35);
                            d32.SetWidth(1000);
                            p = new Paragraph(tekst32);
                            d32.Add(p);
                            doc.Add(d32);

                            Div d33 = new Div();
                            string tekst33 = "Equity:" + sdr["F_4_1_8"].ToString();
                            d33.SetWidth(1000);
                            d33.SetMarginLeft(35);
                            p = new Paragraph(tekst33);
                            d33.Add(p);
                            doc.Add(d33);



                            Div d34 = new Div();
                            string tekst34 = "2.     Title in the name of::" + sdr["F_4_1_9"].ToString();
                            d34.SetWidth(1000);
                            d34.SetMarginLeft(15);
                            p = new Paragraph(tekst34);
                            d34.Add(p);
                            doc.Add(d34);

                            Div d35 = new Div();
                            string tekst35 = "Address:" + sdr["F_4_1_10"].ToString() + "  " + sdr["F_4_1_11"].ToString();
                            d35.SetMarginLeft(25);
                            d35.SetWidth(1000);
                            p = new Paragraph(tekst35);
                            d35.Add(p);
                            doc.Add(d35);

                            //Div d36 = new Div();
                            //string tekst36 = "" + sdr["F_4_1_11"].ToString();
                            //d36.SetUnderline();
                            //d36.SetMarginLeft(25);
                            //d36.SetWidth(1000);
                            //p = new Paragraph(tekst36);
                            //d36.Add(p);
                            //doc.Add(d36);

                            Div d37 = new Div();
                            string tekst37 = "Who paid cost:" + sdr["F_4_1_12"].ToString();
                            d37.SetWidth(1000);
                            d37.SetMarginLeft(25);
                            p = new Paragraph(tekst37);
                            d37.Add(p);
                            doc.Add(d37);

                            Div d38 = new Div();
                            string tekst38 = "How cost paid:" + sdr["F_4_1_13"].ToString();
                            d38.SetWidth(1000);
                            d38.SetMarginLeft(25);
                            p = new Paragraph(tekst38);
                            d38.Add(p);
                            doc.Add(d38);

                            Div d39 = new Div();
                            string tekst39 = "Value:" + sdr["F_4_1_14"].ToString();
                            d39.SetMarginLeft(35);
                            d39.SetWidth(1000);
                            p = new Paragraph(tekst39);
                            d39.Add(p);
                            doc.Add(d39);

                            Div d40 = new Div();
                            string tekst40 = "Mortgage Balance:" + sdr["F_4_1_15"].ToString();
                            d40.SetMarginLeft(35);
                            d40.SetWidth(1000);
                            p = new Paragraph(tekst40);
                            d40.Add(p);
                            doc.Add(d40);

                            Div d41 = new Div();
                            string tekst41 = "Equity:" + sdr["F_4_1_16"].ToString();
                            d41.SetMarginLeft(35);
                            d41.SetWidth(1000);
                            p = new Paragraph(tekst41);
                            d41.Add(p);
                            doc.Add(d41);



                            Div d42 = new Div();
                            string tekst42 = "3.     Title in the name of::" + sdr["F_4_1_17"].ToString();
                            d42.SetWidth(1000);
                            d42.SetMarginLeft(15);
                            p = new Paragraph(tekst42);
                            d42.Add(p);
                            doc.Add(d42);





                            Div d43 = new Div();
                            string tekst43 = "Address:" + sdr["F_4_1_18"].ToString() + "  " + sdr["F_4_1_19"].ToString();
                            d43.SetMarginLeft(25);
                            d43.SetWidth(1000);
                            p = new Paragraph(tekst43);
                            d43.Add(p);
                            doc.Add(d43);

                            //Div d44 = new Div();
                            //string tekst44 = "" + sdr["F_4_1_19"].ToString();
                            //d44.SetUnderline();
                            //d44.SetWidth(1000);
                            //d44.SetMarginLeft(25);
                            //p = new Paragraph(tekst44);
                            //d44.Add(p);
                            //doc.Add(d44);

                            Div d45 = new Div();
                            string tekst45 = "Who paid cost:" + sdr["F_4_1_20"].ToString();
                            d45.SetWidth(1000);
                            d45.SetMarginLeft(25);
                            p = new Paragraph(tekst45);
                            d45.Add(p);
                            doc.Add(d45);

                            Div d46 = new Div();
                            string tekst46 = "How cost paid:" + sdr["F_4_1_21"].ToString();
                            d46.SetWidth(1000);
                            d46.SetMarginLeft(25);
                            p = new Paragraph(tekst46);
                            d46.Add(p);
                            doc.Add(d46);

                            Div d47 = new Div();
                            string tekst47 = "Value:" + sdr["F_4_1_22"].ToString();
                            d47.SetMarginLeft(35);
                            d47.SetWidth(1000);
                            p = new Paragraph(tekst47);
                            d47.Add(p);
                            doc.Add(d47);

                            Div d48 = new Div();
                            string tekst48 = "Mortgage Balance:" + sdr["F_4_1_23"].ToString();
                            d48.SetMarginLeft(35);
                            d48.SetWidth(1000);
                            p = new Paragraph(tekst48);
                            d48.Add(p);
                            doc.Add(d48);

                            Div d49 = new Div();
                            string tekst49 = "Equity:" + sdr["F_4_1_24"].ToString();
                            d49.SetWidth(1000);
                            d49.SetMarginLeft(35);
                            p = new Paragraph(tekst49);
                            d49.Add(p);
                            doc.Add(d49);


                            //Add page 6
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));


                            Div d50 = new Div();
                            string tekst50 = "B. Motor Vehicles";
                            d50.SetWidth(1000);
                            p = new Paragraph(tekst50);
                            d50.Add(p);
                            doc.Add(d50);

                            Div d51= new Div();
                            string tekst51 = "1.        Registered in the name of:" + sdr["F_4_2_1"].ToString();
                            d51.SetWidth(1000);
                            p = new Paragraph(tekst51);
                            d51.Add(p);
                            doc.Add(d51);

                            Div d52 = new Div();
                            string tekst52 = "Year:" + sdr["F_4_2_2"].ToString() + "          Model:" + sdr["F_4_2_3"].ToString()+ "          Mileage:" + sdr["F_4_2_4"].ToString();
                            d52.SetMarginLeft(100);
                            d52.SetWidth(1000);
                            p = new Paragraph(tekst52);
                            d52.Add(p);
                            doc.Add(d52);

                            Div d53 = new Div();
                            string tekst53 = "Who paid cost:" + sdr["F_4_2_5"].ToString() + "                    How cost paid:" + sdr["F_4_2_6"].ToString();
                            d53.SetMarginLeft(100);
                            d53.SetWidth(1000);
                            p = new Paragraph(tekst53);
                            d53.Add(p);
                            doc.Add(d53);

                            Div d54 = new Div();
                            string tekst54 = "Value:" + sdr["F_4_2_7"].ToString();
                            d54.SetMarginLeft(150);
                            d54.SetWidth(1000);
                            p = new Paragraph(tekst54);
                            d54.Add(p);
                            doc.Add(d54);

                            Div d55 = new Div();
                            string tekst55 = "Loan Balance:" + sdr["F_4_2_8"].ToString();
                            d55.SetMarginLeft(150);                            
                            d55.SetWidth(1000);
                            p = new Paragraph(tekst55);
                            d55.Add(p);
                            doc.Add(d55);

                            Div d56 = new Div();
                            string tekst56 = "Equity:" + sdr["F_4_2_9"].ToString();
                            d56.SetMarginLeft(150);
                            d56.SetWidth(1000);
                            p = new Paragraph(tekst56);
                            d56.Add(p);
                            doc.Add(d56);


                            Div d57 = new Div();
                            string tekst57 = "2.        Registered in the name of:" + sdr["F_4_2_10"].ToString();
                            d57.SetWidth(1000);
                            p = new Paragraph(tekst57);
                            d57.Add(p);
                            doc.Add(d57);

                            Div d58 = new Div();
                            string tekst58 = "Year:" + sdr["F_4_2_11"].ToString() + "          Model:" + sdr["F_4_2_12"].ToString() + "          Mileage:" + sdr["F_4_2_13"].ToString();
                            d58.SetMarginLeft(100);
                            d58.SetWidth(1000);
                            p = new Paragraph(tekst58);
                            d58.Add(p);
                            doc.Add(d58);

                            Div d60 = new Div();
                            string tekst60 = "Who paid cost:" + sdr["F_4_2_14"].ToString() + "                    How cost paid:" + sdr["F_4_2_15"].ToString();
                            d60.SetMarginLeft(100);
                            d60.SetWidth(1000);
                            p = new Paragraph(tekst60);
                            d60.Add(p);
                            doc.Add(d60);

                            Div d61 = new Div();
                            string tekst61 = "Value:" + sdr["F_4_2_16"].ToString();
                            d61.SetMarginLeft(150);
                            d61.SetWidth(1000);
                            p = new Paragraph(tekst61);
                            d61.Add(p);
                            doc.Add(d61);

                            Div d62 = new Div();
                            string tekst62 = "Loan Balance:" + sdr["F_4_2_17"].ToString();
                            d62.SetMarginLeft(150);
                            d62.SetWidth(1000);
                            p = new Paragraph(tekst62);
                            d62.Add(p);
                            doc.Add(d62);

                            Div d63 = new Div();
                            string tekst63 = "Equity:" + sdr["F_4_2_18"].ToString();
                            d63.SetMarginLeft(150);
                            d63.SetWidth(1000);
                            p = new Paragraph(tekst63);
                            d63.Add(p);
                            doc.Add(d63);




                            Div d64 = new Div();
                            string tekst64 = "3.        Registered in the name of:" + sdr["F_4_2_19"].ToString();
                            d64.SetWidth(1000);
                            p = new Paragraph(tekst64);
                            d64.Add(p);
                            doc.Add(d64);

                            Div d65 = new Div();
                            string tekst65 = "Year:" + sdr["F_4_2_20"].ToString() + "          Model:" + sdr["F_4_2_21"].ToString() + "          Mileage:" + sdr["F_4_2_22"].ToString();
                            d65.SetMarginLeft(100);
                            d65.SetWidth(1000);
                            p = new Paragraph(tekst65);
                            d65.Add(p);
                            doc.Add(d65);

                            Div d66 = new Div();
                            string tekst66 = "Who paid cost:" + sdr["F_4_2_23"].ToString() + "                    How cost paid:" + sdr["F_4_2_24"].ToString();
                            d66.SetMarginLeft(100);
                            d66.SetWidth(1000);
                            p = new Paragraph(tekst66);
                            d66.Add(p);
                            doc.Add(d66);

                            Div d67 = new Div();
                            string tekst67 = "Value:" + sdr["F_4_2_25"].ToString();
                            d67.SetMarginLeft(150);
                            d67.SetWidth(1000);
                            p = new Paragraph(tekst67);
                            d67.Add(p);
                            doc.Add(d67);

                            Div d68 = new Div();
                            string tekst68 = "Loan Balance:" + sdr["F_4_2_26"].ToString();
                            d68.SetMarginLeft(150);
                            d68.SetWidth(1000);
                            p = new Paragraph(tekst68);
                            d68.Add(p);
                            doc.Add(d68);

                            Div d69 = new Div();
                            string tekst69 = "Equity:" + sdr["F_4_2_27"].ToString();
                            d69.SetMarginLeft(150);
                            d69.SetWidth(1000);
                            p = new Paragraph(tekst69);
                            d69.Add(p);
                            doc.Add(d69);



                            //Add page 7
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d70 = new Div();
                            string tekst70 = "C. OTHER PERSONAL PROPERTY";
                            d70.SetWidth(1000);
                            p = new Paragraph(tekst70);
                            d70.Add(p);
                            doc.Add(d70);

                            Div d71 = new Div();
                            string tekst71 = "(Such as home computers, guns, lawnmowers, TVs, jewelry, household furnishings, etc.)";
                            d71.SetWidth(1000);
                            p = new Paragraph(tekst71);
                            d71.Add(p);
                            doc.Add(d71);


                            Table table5 = new Table(new float[4]).UseAllAvailableWidth();
                            table5.SetMarginTop(0);
                            table5.SetMarginBottom(0);
                            table5.SetWidth(500);

                            // first row
                            table5.AddCell("Property Listing");
                            table5.AddCell("Estimated Value");
                            table5.AddCell("Property Listing");
                            table5.AddCell("Estimated Value");


                            string exp_3 = "";
                            string exp_4 = "";
                            string exp_5 = "";
                            string exp_6 = "";

                            for (int i = 1; i <= 76; i+=4)
                            {
                                exp_3 = "F_4_3_" + i.ToString();
                                if (string.IsNullOrEmpty(sdr[exp_3].ToString())) { table5.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table5.AddCell(sdr[exp_3].ToString()); };
//                                table5.AddCell(sdr[exp_3].ToString());
                                exp_4 = "F_4_3_" + (i+1).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_4].ToString())) { table5.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table5.AddCell(sdr[exp_4].ToString()); };
                                //table5.AddCell(sdr[exp_3].ToString());
                                exp_5 = "F_4_3_" + (i+2).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_5].ToString())) { table5.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table5.AddCell(sdr[exp_5].ToString()); };
                                //table5.AddCell(sdr[exp_3].ToString());
                                exp_6 = "F_4_3_" + (i+3).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_6].ToString())) { table5.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table5.AddCell(sdr[exp_6].ToString()); };
                                //table5.AddCell(sdr[exp_3].ToString());
                            }

                            table5.AddCell("Total");
                            table5.AddCell(sdr["F_4_3_81"].ToString());
                            table5.AddCell("Total");
                            table5.AddCell(sdr["F_4_3_82"].ToString());



                            doc.Add(table5);




                            //Add page 8
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d72 = new Div();
                            string tekst72 = "D. CHECKING/SAVINGS";
                            d72.SetWidth(1000);
                            p = new Paragraph(tekst72);
                            d72.Add(p);
                            doc.Add(d72);

                            float[] columnWidths6= { 1, 1 ,1 , 1 , 1 };
                            Table table6 = new Table(UnitValue.CreatePercentArray(columnWidths6));
                            table6.SetMarginTop(0);
                            table6.SetMarginBottom(0);
                            table6.SetWidth(500);

                            // first row
                            table6.AddCell("Names on Account");
                            table6.AddCell("Bank Name");
                            table6.AddCell("Account Number");
                            table6.AddCell("Type of Account");
                            table6.AddCell("Balance");

                            string exp_7 = "";
                            string exp_8 = "";
                            string exp_9 = "";
                            string exp_10 = "";
                            string exp_11 = "";

                            for (int i = 1; i <= 55; i += 5)
                            {
                                exp_7 = "F_4_4_" + i.ToString();
                                if (string.IsNullOrEmpty(sdr[exp_7].ToString())) { table6.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table6.AddCell(sdr[exp_7].ToString()); };
                                //table6.AddCell("1" + sdr[exp_7].ToString());
                                exp_8 = "F_4_4_" + (i + 1).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_8].ToString())) { table6.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table6.AddCell(sdr[exp_8].ToString()); };
                                //table6.AddCell("2" + sdr[exp_8].ToString());
                                exp_9 = "F_4_4_" + (i + 2).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_9].ToString())) { table6.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table6.AddCell(sdr[exp_9].ToString()); };
                                //table6.AddCell("3" + sdr[exp_9].ToString());
                                exp_10 = "F_4_4_" + (i + 3).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_10].ToString())) { table6.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table6.AddCell(sdr[exp_10].ToString()); };
                                //table6.AddCell("4" + sdr[exp_10].ToString());
                                exp_11 = "F_4_4_" + (i + 4).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_11].ToString())) { table6.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table6.AddCell(sdr[exp_11].ToString()); };
                                //table6.AddCell("4" + sdr[exp_11].ToString());

                            }

                            table6.AddCell("*****");
                            table6.AddCell("*****");
                            table6.AddCell("*****");
                            table6.AddCell("Total");
                            table6.AddCell(sdr["F_4_4_56"].ToString());



                            doc.Add(table6);


                            Div d73 = new Div();
                            string tekst73 = "E. Other Investments";
                            d73.SetWidth(1000);
                            p = new Paragraph(tekst73);
                            d73.Add(p);
                            doc.Add(d73);

                            Table table7 = new Table(new float[3]).UseAllAvailableWidth();
                            table7.SetMarginTop(0);
                            table7.SetMarginBottom(0);
                            table7.SetWidth(500);

                            // first row
                            table7.AddCell("Bank Account/No");
                            table7.AddCell("Type of Investment");
                            table7.AddCell("Balance");

                            string exp_12 = "";
                            string exp_13 = "";
                            string exp_14 = "";

                            for (int i = 1; i <= 30; i += 3)
                            {
                                exp_12 = "F_4_5_" + i.ToString();
                                if (string.IsNullOrEmpty(sdr[exp_12].ToString())) { table7.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table7.AddCell(sdr[exp_12].ToString()); };
                                //table7.AddCell(sdr[exp_12].ToString());
                                exp_13 = "F_4_5_" + (i + 1).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_13].ToString())) { table7.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table7.AddCell(sdr[exp_13].ToString()); };
                                //table7.AddCell(sdr[exp_13].ToString());
                                exp_14 = "F_4_5_" + (i + 2).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_14].ToString())) { table7.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table7.AddCell(sdr[exp_14].ToString()); };
                                //table7.AddCell(sdr[exp_14].ToString());
                            }

                            table7.AddCell("*****");
                            table7.AddCell("Total Value");
                            table7.AddCell(sdr["F_4_5_31"].ToString());



                            doc.Add(table7);



                            //Add page 9
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d74 = new Div();
                            string tekst74 = "F. LIFE INSURANCE (EXCLUDE CHILDREN)";
                            d74.SetWidth(1000);
                            p = new Paragraph(tekst74);
                            d74.Add(p);
                            doc.Add(d74);

                            float[] columnWidths8 = { 1, 1, 1, 1, 1 };
                            Table table8 = new Table(UnitValue.CreatePercentArray(columnWidths8));
                            table8.SetMarginTop(0);
                            table8.SetMarginBottom(0);
                            table8.SetWidth(500);

                            // first row
                            table8.AddCell("Insured");
                            table8.AddCell("Company");
                            table8.AddCell("Face amount less any Loans");
                            table8.AddCell("Cash");
                            table8.AddCell("Beneficiary");

                            string exp_15 = "";
                            string exp_16 = "";
                            string exp_17 = "";
                            string exp_18 = "";
                            string exp_19 = "";

                            for (int i = 1; i <= 40; i += 5)
                            {
                                exp_15 = "F_4_6_" + i.ToString();
                                if (string.IsNullOrEmpty(sdr[exp_15].ToString())) { table8.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table8.AddCell(sdr[exp_15].ToString()); };
                                //table8.AddCell("1" + sdr[exp_15].ToString());
                                exp_16 = "F_4_6_" + (i + 1).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_16].ToString())) { table8.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table8.AddCell(sdr[exp_16].ToString()); };
                                //table8.AddCell("2" + sdr[exp_16].ToString());
                                exp_17 = "F_4_6_" + (i + 2).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_17].ToString())) { table8.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table8.AddCell(sdr[exp_17].ToString()); };
                                //table8.AddCell("3" + sdr[exp_17].ToString());
                                exp_18 = "F_4_6_" + (i + 3).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_18].ToString())) { table8.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table8.AddCell(sdr[exp_18].ToString()); };
                                //table8.AddCell("4" + sdr[exp_18].ToString());
                                exp_19 = "F_4_6_" + (i + 4).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_19].ToString())) { table8.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table8.AddCell(sdr[exp_19].ToString()); };
                                //table8.AddCell("4" + sdr[exp_19].ToString());

                            }

                            table8.AddCell("*****");
                            table8.AddCell("Total");
                            table8.AddCell(sdr["F_4_6_41"].ToString());
                            table8.AddCell(sdr["F_4_6_42"].ToString());
                            table8.AddCell("*****");

                            doc.Add(table8);

                            Div d75 = new Div();
                            string tekst75 = "G. ALL OTHER ASSETS";
                            d75.SetWidth(1000);
                            p = new Paragraph(tekst75);
                            d75.Add(p);
                            doc.Add(d75);

                            float[] columnWidths9 = { 1, 1, 1, 1, 1 };
                            Table table9 = new Table(UnitValue.CreatePercentArray(columnWidths9));
                            table9.SetMarginTop(0);
                            table9.SetMarginBottom(0);
                            table9.SetWidth(500);

                            // first row
                            table9.AddCell("Item");
                            table9.AddCell("Date Purchased");
                            table9.AddCell("Value(Assets)");
                            table9.AddCell("Liens");
                            table9.AddCell("Beneficiary");

                            string exp_20 = "";
                            string exp_21 = "";
                            string exp_22 = "";
                            string exp_23 = "";
                            string exp_24 = "";

                            for (int i = 1; i <= 60; i += 5)
                            {
                                exp_20 = "F_4_7_" + i.ToString();
                                if (string.IsNullOrEmpty(sdr[exp_20].ToString())) { table9.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table9.AddCell(sdr[exp_20].ToString()); };
                                //table9.AddCell("1" + sdr[exp_20].ToString());
                                exp_21 = "F_4_7_" + (i + 1).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_21].ToString())) { table9.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table9.AddCell(sdr[exp_21].ToString()); };
                                //table9.AddCell("2" + sdr[exp_21].ToString());
                                exp_22 = "F_4_7_" + (i + 2).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_22].ToString())) { table9.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table9.AddCell(sdr[exp_22].ToString()); };
                                //table9.AddCell("3" + sdr[exp_22].ToString());
                                exp_23 = "F_4_7_" + (i + 3).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_23].ToString())) { table9.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table9.AddCell(sdr[exp_23].ToString()); };
                                //table9.AddCell("4" + sdr[exp_23].ToString());
                                exp_24 = "F_4_7_" + (i + 4).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_24].ToString())) { table9.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table9.AddCell(sdr[exp_24].ToString()); };
                                //table9.AddCell("4" + sdr[exp_24].ToString());

                            }

                            table9.AddCell("*****");
                            table9.AddCell("*****");
                            table9.AddCell("*****");
                            table9.AddCell("Total");
                            table9.AddCell(sdr["F_4_7_61"].ToString());

                            doc.Add(table9);

                            //Add page 10
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d76 = new Div();
                            string tekst76 = "V. Statement of Liabilities";
                            d76.SetWidth(1000);
                            p = new Paragraph(tekst76);
                            d76.Add(p);
                            doc.Add(d76);

                            Div d77 = new Div();
                            string tekst77 = "I. LIABILITIES";
                            d77.SetWidth(1000);
                            p = new Paragraph(tekst77);
                            d77.Add(p);
                            doc.Add(d77);

                            Div d78 = new Div();
                            string tekst78 = "(Include mortgages, car loans, credit cards, personal loans.) (Include also under35-44 of EXHIBIT “A” )";
                            d78.SetWidth(1000);
                            p = new Paragraph(tekst78);
                            d78.Add(p);
                            doc.Add(d78);

                            float[] columnWidths10 = { 1, 1, 1, 1, 1 };
                            Table table10 = new Table(UnitValue.CreatePercentArray(columnWidths10));
                            table10.SetMarginTop(0);
                            table10.SetMarginBottom(0);
                            table10.SetWidth(500);

                            // first row
                            table10.AddCell("Creditor");
                            table10.AddCell("Whose Name");
                            table10.AddCell("Current Balance Due");
                            table10.AddCell("Monthly");
                            table10.AddCell("Who Pays");

                            string exp_25 = "";
                            string exp_26 = "";
                            string exp_27 = "";
                            string exp_28 = "";
                            string exp_29 = "";

                            for (int i = 1; i <= 55; i += 5)
                            {
                                exp_25 = "F_5_" + i.ToString();
                                if (string.IsNullOrEmpty(sdr[exp_25].ToString())) { table10.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table10.AddCell(sdr[exp_25].ToString()); };
                                //table10.AddCell("1" + sdr[exp_25].ToString());
                                exp_26 = "F_5_" + (i + 1).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_26].ToString())) { table10.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table10.AddCell(sdr[exp_26].ToString()); };
                                //table10.AddCell("2" + sdr[exp_26].ToString());
                                exp_27 = "F_5_" + (i + 2).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_27].ToString())) { table10.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table10.AddCell(sdr[exp_27].ToString()); };
                                //table10.AddCell("3" + sdr[exp_27].ToString());
                                exp_28 = "F_5_" + (i + 3).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_28].ToString())) { table10.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table10.AddCell(sdr[exp_28].ToString()); };
                                //table10.AddCell("4" + sdr[exp_28].ToString());
                                exp_29 = "F_5_" + (i + 4).ToString();
                                if (string.IsNullOrEmpty(sdr[exp_29].ToString())) { table10.AddCell("-").SetTextAlignment(TextAlignment.CENTER); } else { table10.AddCell(sdr[exp_29].ToString()); };
                                //table10.AddCell("4" + sdr[exp_29].ToString());

                            }

                            table10.AddCell("*****");
                            table10.AddCell("Total Liabilities");
                            table10.AddCell(sdr["F_5_56"].ToString());
                            table10.AddCell(sdr["F_5_57"].ToString());
                            table10.AddCell("*****");
                            doc.Add(table10);

                            Div d79_1 = new Div();
                            string tekst79_1 = "                                     ";
                            d79_1.SetTextAlignment(TextAlignment.CENTER);
                            d79_1.SetWidth(1000);
                            p = new Paragraph(tekst79_1);
                            d79_1.Add(p);
                            doc.Add(d79_1);


                            Div d79 = new Div();
                            string tekst79 = "ACKNOWLEDGMENT OF TRUTHFULNESS";
                            d79.SetTextAlignment(TextAlignment.CENTER);
                            d79.SetWidth(1000);
                            p = new Paragraph(tekst79);
                            d79.Add(p);
                            doc.Add(d79);

                            Div d80 = new Div();
                            string tekst80 = "I declare to the Court that the foregoing financial information, including attachments, is true and";
                            d80.SetWidth(1000);
                            d80.SetMarginLeft(15);
                            p = new Paragraph(tekst80);
                            d80.Add(p);
                            doc.Add(d80);

                            Div d81 = new Div();
                            string tekst81 = "correct and that this declaration was executed on the ________ day of ________, 20__.";
                            d81.SetWidth(1000);
                            p = new Paragraph(tekst81);
                            d81.Add(p);
                            doc.Add(d81);


                            Div d82 = new Div();
                            string tekst82 = "_______________________________________";
                            d82.SetTextAlignment(TextAlignment.RIGHT);
                            d82.SetWidth(1000);
                            p = new Paragraph(tekst82);
                            d82.Add(p);
                            doc.Add(d82);

                            Div d83 = new Div();
                            string tekst83 = "(Plaintiff or Defendant)";
                            d83.SetWidth(1000);
                            d83.SetMarginLeft(300);
                            p = new Paragraph(tekst83);
                            d83.Add(p);
                            doc.Add(d83);



                            //Add page 11
                            doc.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                            Div d84 = new Div();
                            d84.SetWidth(1000);
                            d84.SetTextAlignment(TextAlignment.CENTER);
                            p = new Paragraph("EXHIBIT “C”");
                            d84.Add(p);
                            doc.Add(d84);

                            Div d85 = new Div();
                            string tekst85 = "IN THE CHANCERY COURT OF " + sdr["F_5"].ToString() + " COUNTY, MISSISSIPPI";
                            d85.SetWidth(1000);
                            d85.SetTextAlignment(TextAlignment.CENTER);
                            p = new Paragraph(tekst85);
                            d85.Add(p);
                            doc.Add(d85);

                            Div d86 = new Div();
                            string tekst86 = "Plaintiff:               " + sdr["F_6"].ToString();
                            d86.SetWidth(1000);
                            p = new Paragraph(tekst86);
                            d86.Add(p);
                            doc.Add(d86);

                            Div d87 = new Div();
                            string tekst87 = "V.          Civil Action number:" + sdr["F_7"].ToString();
                            d87.SetWidth(1000);
                            p = new Paragraph(tekst87);
                            d87.Add(p);
                            doc.Add(d87);


                            Div d88 = new Div();
                            string tekst88 = "Defendant:               " + sdr["F_8"].ToString();
                            d88.SetWidth(1000);
                            p = new Paragraph(tekst88);
                            d88.Add(p);
                            doc.Add(d88);

                            Div d89 = new Div();
                            string tekst89 = "--------------------------------------------------------------------------------------";
                            d89.SetWidth(1000);
                            p = new Paragraph(tekst89);
                            d89.Add(p);
                            doc.Add(d89);


                            Div d90 = new Div();
                            string tekst90 = "CERTIFICATE OF COMPLIANCE";
                            d90.SetTextAlignment(TextAlignment.CENTER);
                            d90.SetWidth(1000);
                            p = new Paragraph(tekst90);
                            d90.Add(p);
                            doc.Add(d90);

                            Div d91 = new Div();
                            string tekst91 = "I, (name of party or attorney), do hereby certify that I have this date complied with Rule 8.05 of";
                            d91.SetWidth(1000);
                            d91.SetMarginLeft(15);
                            p = new Paragraph(tekst91);
                            d91.Add(p);
                            doc.Add(d91);

                            Div d92 = new Div();
                            string tekst92 = "the Uniform Chancery Court Rules and that I have mailed and/or delivered a copy of a detailed";
                            d92.SetWidth(1000);
                            p = new Paragraph(tekst92);
                            d92.Add(p);
                            doc.Add(d92);

                            Div d93 = new Div();
                            string tekst93 = " written statement of actual income and expenses and assets and liabilities to the attorney for";
                            d93.SetWidth(1000);
                            p = new Paragraph(tekst93);
                            d93.Add(p);
                            doc.Add(d93);

                            Div d94 = new Div();
                            string tekst94 = "the opposing partyor the opposing party.";
                            d94.SetWidth(1000);
                            p = new Paragraph(tekst94);
                            d94.Add(p);
                            doc.Add(d94);


                            Div d95 = new Div();
                            string tekst95 = "SO CERTIFIED on this the _______________ day of ________________, 20__.";
                            d95.SetMarginLeft(15);
                            d95.SetWidth(1000);
                            p = new Paragraph(tekst95);
                            d95.Add(p);
                            doc.Add(d95);

                            Div d96 = new Div();
                            string tekst96 = "____________________________";
                            d96.SetWidth(1000);
                            d96.SetMarginLeft(250);
                            p = new Paragraph(tekst96);
                            d96.Add(p);
                            doc.Add(d96);

                            Div d97 = new Div();
                            string tekst97 = "________________________________________________________";
                            d97.SetWidth(1000);
                            p = new Paragraph(tekst97);
                            d97.Add(p);
                            doc.Add(d97);

                            Div d98 = new Div();
                            string tekst98 = "Attorney for Opposing Party";
                            d98.SetWidth(1000);
                            p = new Paragraph(tekst98);
                            d98.Add(p);
                            doc.Add(d98);

                            Div d99 = new Div();
                            string tekst99 = "\n\n This pdf file is created with ©2020 iText7 Community under AGPL license.";
                            d99.SetWidth(1000);
                            p = new Paragraph(tekst99);
                            d99.Add(p);
                            doc.Add(d99);



                            //sdr["F_2_1"].ToString()

                            doc.Close();

                            // Set Response.ContentType
                            Response.ContentType = GetContentType(fileExtension);

                            // Append header
                            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);

                            // Write the file to the Response
                            Response.TransmitFile(Server.MapPath("~/Secured/Files/" + fileName));
                            Response.End();




                        }
                        else
                        {
                        }
                    }
                }
            }
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

        protected void ddlCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.txtF_1.Text = ddlCounty.SelectedItem.Text.ToString();
            //lblNazivAgencije.Text = ddlCompany.SelectedItem.Text.ToString();
            //this.GetTradeReceivables(1);

        }

        protected void ddlExemption_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.txtF_1.Text = ddlCounty.SelectedItem.Text.ToString();
            //lblNazivAgencije.Text = ddlCompany.SelectedItem.Text.ToString();
            //this.GetTradeReceivables(1);

        }

        protected void Calculate_F_4_3_81()
        {
            double F_4_3_2;
            double F_4_3_6;
            double F_4_3_10;
            double F_4_3_14;
            double F_4_3_18;
            double F_4_3_22;
            double F_4_3_26;
            double F_4_3_30;
            double F_4_3_34;
            double F_4_3_38;
            double F_4_3_42;
            double F_4_3_46;
            double F_4_3_50;
            double F_4_3_54;
            double F_4_3_58;
            double F_4_3_62;
            double F_4_3_66;
            double F_4_3_70;
            double F_4_3_74;
            double F_4_3_78;

            if (String.IsNullOrEmpty(txtF_4_3_2.Text)) { F_4_3_2 = 0; } else { F_4_3_2 = Convert.ToDouble(txtF_4_3_2.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_6.Text)) { F_4_3_6 = 0; } else { F_4_3_6 = Convert.ToDouble(txtF_4_3_6.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_10.Text)) { F_4_3_10 = 0; } else { F_4_3_10 = Convert.ToDouble(txtF_4_3_10.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_14.Text)) { F_4_3_14 = 0; } else { F_4_3_14 = Convert.ToDouble(txtF_4_3_14.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_18.Text)) { F_4_3_18 = 0; } else { F_4_3_18 = Convert.ToDouble(txtF_4_3_18.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_22.Text)) { F_4_3_22 = 0; } else { F_4_3_22 = Convert.ToDouble(txtF_4_3_22.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_26.Text)) { F_4_3_26 = 0; } else { F_4_3_26 = Convert.ToDouble(txtF_4_3_26.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_30.Text)) { F_4_3_30 = 0; } else { F_4_3_30 = Convert.ToDouble(txtF_4_3_30.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_34.Text)) { F_4_3_34 = 0; } else { F_4_3_34 = Convert.ToDouble(txtF_4_3_34.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_38.Text)) { F_4_3_38 = 0; } else { F_4_3_38 = Convert.ToDouble(txtF_4_3_38.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_42.Text)) { F_4_3_42 = 0; } else { F_4_3_42 = Convert.ToDouble(txtF_4_3_42.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_46.Text)) { F_4_3_46 = 0; } else { F_4_3_46 = Convert.ToDouble(txtF_4_3_46.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_50.Text)) { F_4_3_50 = 0; } else { F_4_3_50 = Convert.ToDouble(txtF_4_3_50.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_54.Text)) { F_4_3_54 = 0; } else { F_4_3_54 = Convert.ToDouble(txtF_4_3_54.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_58.Text)) { F_4_3_58 = 0; } else { F_4_3_58 = Convert.ToDouble(txtF_4_3_58.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_62.Text)) { F_4_3_62 = 0; } else { F_4_3_62 = Convert.ToDouble(txtF_4_3_62.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_66.Text)) { F_4_3_66 = 0; } else { F_4_3_66 = Convert.ToDouble(txtF_4_3_66.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_70.Text)) { F_4_3_70 = 0; } else { F_4_3_70 = Convert.ToDouble(txtF_4_3_70.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_74.Text)) { F_4_3_74 = 0; } else { F_4_3_74 = Convert.ToDouble(txtF_4_3_74.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_78.Text)) { F_4_3_78 = 0; } else { F_4_3_78 = Convert.ToDouble(txtF_4_3_78.Text); };

            double F_4_3_81 = F_4_3_2 + F_4_3_6 + F_4_3_10 + F_4_3_14 + F_4_3_18 + F_4_3_22 + F_4_3_26 + F_4_3_30 + F_4_3_34 + F_4_3_38 + F_4_3_42 +
                    F_4_3_46 + F_4_3_50 + F_4_3_54 + F_4_3_58 + F_4_3_62 + F_4_3_66 + F_4_3_70 + F_4_3_74 + F_4_3_78;
            txtF_4_3_81.Text = F_4_3_81.ToString();
        }

        protected void Calculate_F_4_6()
        {
            double F_4_6_3;
            double F_4_6_4;
            double F_4_6_8;
            double F_4_6_9;
            double F_4_6_13;
            double F_4_6_14;
            double F_4_6_18;
            double F_4_6_19;
            double F_4_6_23;
            double F_4_6_24;
            double F_4_6_28;
            double F_4_6_29;
            double F_4_6_33;
            double F_4_6_34;
            double F_4_6_38;
            double F_4_6_39;
            double F_4_6_41;
            double F_4_6_42;


            if (String.IsNullOrEmpty(txtF_4_6_3.Text)) { F_4_6_3 = 0; } else { F_4_6_3 = Convert.ToDouble(txtF_4_6_3.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_4.Text)) { F_4_6_4 = 0; } else { F_4_6_4 = Convert.ToDouble(txtF_4_6_4.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_8.Text)) { F_4_6_8 = 0; } else { F_4_6_8 = Convert.ToDouble(txtF_4_6_8.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_9.Text)) { F_4_6_9 = 0; } else { F_4_6_9 = Convert.ToDouble(txtF_4_6_9.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_13.Text)) { F_4_6_13 = 0; } else { F_4_6_13 = Convert.ToDouble(txtF_4_6_13.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_14.Text)) { F_4_6_14 = 0; } else { F_4_6_14 = Convert.ToDouble(txtF_4_6_14.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_18.Text)) { F_4_6_18 = 0; } else { F_4_6_18 = Convert.ToDouble(txtF_4_6_18.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_19.Text)) { F_4_6_19 = 0; } else { F_4_6_19 = Convert.ToDouble(txtF_4_6_19.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_23.Text)) { F_4_6_23 = 0; } else { F_4_6_23 = Convert.ToDouble(txtF_4_6_23.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_24.Text)) { F_4_6_24 = 0; } else { F_4_6_24 = Convert.ToDouble(txtF_4_6_24.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_28.Text)) { F_4_6_28 = 0; } else { F_4_6_28 = Convert.ToDouble(txtF_4_6_28.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_29.Text)) { F_4_6_29 = 0; } else { F_4_6_29 = Convert.ToDouble(txtF_4_6_29.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_33.Text)) { F_4_6_33 = 0; } else { F_4_6_33 = Convert.ToDouble(txtF_4_6_33.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_34.Text)) { F_4_6_34 = 0; } else { F_4_6_34 = Convert.ToDouble(txtF_4_6_34.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_38.Text)) { F_4_6_38 = 0; } else { F_4_6_38 = Convert.ToDouble(txtF_4_6_38.Text); };
            if (String.IsNullOrEmpty(txtF_4_6_39.Text)) { F_4_6_39 = 0; } else { F_4_6_39 = Convert.ToDouble(txtF_4_6_39.Text); };

            F_4_6_41 = F_4_6_3 + F_4_6_8 + F_4_6_13 + F_4_6_18 + F_4_6_23 + F_4_6_28 + F_4_6_33 + F_4_6_38;
            F_4_6_42 = F_4_6_4 + F_4_6_9 + F_4_6_14 + F_4_6_19 + F_4_6_24 + F_4_6_29 + F_4_6_34 + F_4_6_39;
            txtF_4_6_41.Text = F_4_6_41.ToString();
            txtF_4_6_42.Text = F_4_6_42.ToString();
        }

        protected void txtF_4_6_3_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_3;
            if (String.IsNullOrEmpty(txtF_4_6_3.Text)) { m_F_4_6_3 = 0; } else { m_F_4_6_3 = Convert.ToDouble(txtF_4_6_3.Text); };

            if (m_F_4_6_3 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_3);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_4);

        }

        protected void txtF_4_6_8_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_8;
            if (String.IsNullOrEmpty(txtF_4_6_8.Text)) { m_F_4_6_8 = 0; } else { m_F_4_6_8 = Convert.ToDouble(txtF_4_6_8.Text); };

            if (m_F_4_6_8< 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_8);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_9);

        }
        protected void txtF_4_6_13_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_13;
            if (String.IsNullOrEmpty(txtF_4_6_13.Text)) { m_F_4_6_13 = 0; } else { m_F_4_6_13 = Convert.ToDouble(txtF_4_6_13.Text); };

            if (m_F_4_6_13 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_13);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_14);

        }
        protected void txtF_4_6_18_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_18;
            if (String.IsNullOrEmpty(txtF_4_6_18.Text)) { m_F_4_6_18 = 0; } else { m_F_4_6_18 = Convert.ToDouble(txtF_4_6_18.Text); };

            if (m_F_4_6_18 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_18);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_19);

        }
        protected void txtF_4_6_23_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_23;
            if (String.IsNullOrEmpty(txtF_4_6_23.Text)) { m_F_4_6_23 = 0; } else { m_F_4_6_23 = Convert.ToDouble(txtF_4_6_23.Text); };
            if (m_F_4_6_23 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_23);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_24);

        }
        protected void txtF_4_6_28_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_28;
            if (String.IsNullOrEmpty(txtF_4_6_28.Text)) { m_F_4_6_28 = 0; } else { m_F_4_6_28 = Convert.ToDouble(txtF_4_6_28.Text); };
            if (m_F_4_6_28 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_28);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_29);

        }
        protected void txtF_4_6_33_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_33;
            if (String.IsNullOrEmpty(txtF_4_6_33.Text)) { m_F_4_6_33 = 0; } else { m_F_4_6_33 = Convert.ToDouble(txtF_4_6_33.Text); };
            if (m_F_4_6_33 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_33);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_34);

        }
        protected void txtF_4_6_38_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_38;
            if (String.IsNullOrEmpty(txtF_4_6_38.Text)) { m_F_4_6_38 = 0; } else { m_F_4_6_38 = Convert.ToDouble(txtF_4_6_38.Text); };
            if (m_F_4_6_38 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_38);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_39);

        }
        protected void txtF_4_6_4_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_4;
            if (String.IsNullOrEmpty(txtF_4_6_4.Text)) { m_F_4_6_4 = 0; } else { m_F_4_6_4 = Convert.ToDouble(txtF_4_6_4.Text); };
            if (m_F_4_6_4 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_4);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_5);

        }
        protected void txtF_4_6_9_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_9;
            if (String.IsNullOrEmpty(txtF_4_6_9.Text)) { m_F_4_6_9 = 0; } else { m_F_4_6_9 = Convert.ToDouble(txtF_4_6_9.Text); };

            if (m_F_4_6_9 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_9);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_10);

        }
        protected void txtF_4_6_14_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_14;
            if (String.IsNullOrEmpty(txtF_4_6_14.Text)) { m_F_4_6_14 = 0; } else { m_F_4_6_14 = Convert.ToDouble(txtF_4_6_14.Text); };

            if (m_F_4_6_14 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_14);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_15);

        }
        protected void txtF_4_6_19_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_19;
            if (String.IsNullOrEmpty(txtF_4_6_19.Text)) { m_F_4_6_19 = 0; } else { m_F_4_6_19 = Convert.ToDouble(txtF_4_6_19.Text); };

            if (m_F_4_6_19 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_19);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_20);

        }
        protected void txtF_4_6_24_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_24;
            if (String.IsNullOrEmpty(txtF_4_6_24.Text)) { m_F_4_6_24 = 0; } else { m_F_4_6_24 = Convert.ToDouble(txtF_4_6_24.Text); };

            if (m_F_4_6_24 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_24);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_25);

        }
        protected void txtF_4_6_29_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_29;
            if (String.IsNullOrEmpty(txtF_4_6_29.Text)) { m_F_4_6_29 = 0; } else { m_F_4_6_29 = Convert.ToDouble(txtF_4_6_29.Text); };

            if (m_F_4_6_29 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_29);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_30);

        }
        protected void txtF_4_6_34_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_34;
            if (String.IsNullOrEmpty(txtF_4_6_34.Text)) { m_F_4_6_34 = 0; } else { m_F_4_6_34 = Convert.ToDouble(txtF_4_6_34.Text); };

            if (m_F_4_6_34 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_34);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_35);

        }
        protected void txtF_4_6_39_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_6_39;
            if (String.IsNullOrEmpty(txtF_4_6_39.Text)) { m_F_4_6_39 = 0; } else { m_F_4_6_39 = Convert.ToDouble(txtF_4_6_39.Text); };

            if (m_F_4_6_39 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_6_39);
                return;
            }

            Calculate_F_4_6();

            SetFocusOnLoad(txtF_4_6_40);

        }

        protected void Calculate_F_5_3()
        {
            double F_5_3;
            double F_5_8;
            double F_5_13;
            double F_5_18;
            double F_5_23;
            double F_5_28;
            double F_5_33;
            double F_5_38;
            double F_5_43;
            double F_5_48;
            double F_5_53;
            double F_5_56;

            if (String.IsNullOrEmpty(txtF_5_3.Text)) { F_5_3 = 0; } else { F_5_3 = Convert.ToDouble(txtF_5_3.Text); };
            if (String.IsNullOrEmpty(txtF_5_8.Text)) { F_5_8 = 0; } else { F_5_8 = Convert.ToDouble(txtF_5_8.Text); };
            if (String.IsNullOrEmpty(txtF_5_13.Text)) { F_5_13 = 0; } else { F_5_13 = Convert.ToDouble(txtF_5_13.Text); };
            if (String.IsNullOrEmpty(txtF_5_18.Text)) { F_5_18 = 0; } else { F_5_18 = Convert.ToDouble(txtF_5_18.Text); };
            if (String.IsNullOrEmpty(txtF_5_23.Text)) { F_5_23 = 0; } else { F_5_23 = Convert.ToDouble(txtF_5_23.Text); };
            if (String.IsNullOrEmpty(txtF_5_28.Text)) { F_5_28 = 0; } else { F_5_28 = Convert.ToDouble(txtF_5_28.Text); };
            if (String.IsNullOrEmpty(txtF_5_33.Text)) { F_5_33 = 0; } else { F_5_33 = Convert.ToDouble(txtF_5_33.Text); };
            if (String.IsNullOrEmpty(txtF_5_38.Text)) { F_5_38 = 0; } else { F_5_38 = Convert.ToDouble(txtF_5_38.Text); };
            if (String.IsNullOrEmpty(txtF_5_43.Text)) { F_5_43 = 0; } else { F_5_43 = Convert.ToDouble(txtF_5_43.Text); };
            if (String.IsNullOrEmpty(txtF_5_48.Text)) { F_5_48 = 0; } else { F_5_48 = Convert.ToDouble(txtF_5_48.Text); };
            if (String.IsNullOrEmpty(txtF_5_53.Text)) { F_5_53 = 0; } else { F_5_53 = Convert.ToDouble(txtF_5_53.Text); };



            F_5_56 = F_5_3 + F_5_8 + F_5_13 + F_5_18 + F_5_23 + F_5_28 + F_5_33 + F_5_38 + F_5_43 + F_5_48 + F_5_53;
            txtF_5_56.Text = F_5_56.ToString();
        }

        protected void txtF_5_3_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_3;
            if (String.IsNullOrEmpty(txtF_5_3.Text)) { m_F_5_3 = 0; } else { m_F_5_3 = Convert.ToDouble(txtF_5_3.Text); };
            if (m_F_5_3 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_3);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_4);

        }

        protected void txtF_5_8_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_8;
            if (String.IsNullOrEmpty(txtF_5_8.Text)) { m_F_5_8 = 0; } else { m_F_5_8 = Convert.ToDouble(txtF_5_8.Text); };
            if (m_F_5_8 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_8);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_9);

        }
        protected void txtF_5_13_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_13;
            if (String.IsNullOrEmpty(txtF_5_13.Text)) { m_F_5_13 = 0; } else { m_F_5_13 = Convert.ToDouble(txtF_5_13.Text); };
            if (m_F_5_13 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_13);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_14);

        }
        protected void txtF_5_18_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_18;
            if (String.IsNullOrEmpty(txtF_5_18.Text)) { m_F_5_18 = 0; } else { m_F_5_18 = Convert.ToDouble(txtF_5_18.Text); };
            if (m_F_5_18 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_18);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_19);

        }
        protected void txtF_5_23_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_23;
            if (String.IsNullOrEmpty(txtF_5_23.Text)) { m_F_5_23 = 0; } else { m_F_5_23 = Convert.ToDouble(txtF_5_23.Text); };
            if (m_F_5_23 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_23);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_24);

        }
        protected void txtF_5_28_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_28;
            if (String.IsNullOrEmpty(txtF_5_28.Text)) { m_F_5_28 = 0; } else { m_F_5_28 = Convert.ToDouble(txtF_5_28.Text); };
            if (m_F_5_28 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_28);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_29);

        }
        protected void txtF_5_33_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_33;
            if (String.IsNullOrEmpty(txtF_5_33.Text)) { m_F_5_33 = 0; } else { m_F_5_33 = Convert.ToDouble(txtF_5_33.Text); };
            if (m_F_5_33 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_33);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_34);

        }
        protected void txtF_5_38_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_38;
            if (String.IsNullOrEmpty(txtF_5_38.Text)) { m_F_5_38 = 0; } else { m_F_5_38 = Convert.ToDouble(txtF_5_38.Text); };
            if (m_F_5_38 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_38);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_39);

        }
        protected void txtF_5_43_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_43;
            if (String.IsNullOrEmpty(txtF_5_43.Text)) { m_F_5_43 = 0; } else { m_F_5_43 = Convert.ToDouble(txtF_5_43.Text); };
            if (m_F_5_43 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_43);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_44);

        }
        protected void txtF_5_48_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_48;
            if (String.IsNullOrEmpty(txtF_5_48.Text)) { m_F_5_48 = 0; } else { m_F_5_48= Convert.ToDouble(txtF_5_48.Text); };
            if (m_F_5_48 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_48);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_49);

        }

        protected void txtF_5_53_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_53;
            if (String.IsNullOrEmpty(txtF_5_53.Text)) { m_F_5_53 = 0; } else { m_F_5_53 = Convert.ToDouble(txtF_5_53.Text); };
            if (m_F_5_53 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_53);
                return;
            }

            Calculate_F_5_3();

            SetFocusOnLoad(txtF_5_54);

        }


        protected void Calculate_F_5_4()
        {
            double F_5_4;
            double F_5_9;
            double F_5_14;
            double F_5_19;
            double F_5_24;
            double F_5_29;
            double F_5_34;
            double F_5_39;
            double F_5_44;
            double F_5_49;
            double F_5_54;
            double F_5_57;

            if (String.IsNullOrEmpty(txtF_5_4.Text)) { F_5_4 = 0; } else { F_5_4 = Convert.ToDouble(txtF_5_4.Text); };
            if (String.IsNullOrEmpty(txtF_5_9.Text)) { F_5_9 = 0; } else { F_5_9 = Convert.ToDouble(txtF_5_9.Text); };
            if (String.IsNullOrEmpty(txtF_5_14.Text)) { F_5_14 = 0; } else { F_5_14 = Convert.ToDouble(txtF_5_14.Text); };
            if (String.IsNullOrEmpty(txtF_5_19.Text)) { F_5_19 = 0; } else { F_5_19 = Convert.ToDouble(txtF_5_19.Text); };
            if (String.IsNullOrEmpty(txtF_5_24.Text)) { F_5_24 = 0; } else { F_5_24 = Convert.ToDouble(txtF_5_24.Text); };
            if (String.IsNullOrEmpty(txtF_5_29.Text)) { F_5_29 = 0; } else { F_5_29 = Convert.ToDouble(txtF_5_29.Text); };
            if (String.IsNullOrEmpty(txtF_5_34.Text)) { F_5_34 = 0; } else { F_5_34 = Convert.ToDouble(txtF_5_34.Text); };
            if (String.IsNullOrEmpty(txtF_5_39.Text)) { F_5_39 = 0; } else { F_5_39 = Convert.ToDouble(txtF_5_39.Text); };
            if (String.IsNullOrEmpty(txtF_5_44.Text)) { F_5_44 = 0; } else { F_5_44 = Convert.ToDouble(txtF_5_44.Text); };
            if (String.IsNullOrEmpty(txtF_5_49.Text)) { F_5_49 = 0; } else { F_5_49 = Convert.ToDouble(txtF_5_49.Text); };
            if (String.IsNullOrEmpty(txtF_5_54.Text)) { F_5_54 = 0; } else { F_5_54 = Convert.ToDouble(txtF_5_54.Text); };



            F_5_57 = F_5_4 + F_5_9 + F_5_14 + F_5_19 + F_5_24 + F_5_29 + F_5_34 + F_5_39 + F_5_44 + F_5_49 + F_5_54;
            txtF_5_57.Text = F_5_57.ToString();
        }

        protected void txtF_5_4_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_4;
            if (String.IsNullOrEmpty(txtF_5_4.Text)) { m_F_5_4 = 0; } else { m_F_5_4 = Convert.ToDouble(txtF_5_4.Text); };
            if (m_F_5_4 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_4);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_5);

        }

        protected void txtF_5_9_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_9;
            if (String.IsNullOrEmpty(txtF_5_9.Text)) { m_F_5_9 = 0; } else { m_F_5_9 = Convert.ToDouble(txtF_5_9.Text); };

            if (m_F_5_9 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_9);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_10);

        }
        protected void txtF_5_14_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_14;
            if (String.IsNullOrEmpty(txtF_5_14.Text)) { m_F_5_14 = 0; } else { m_F_5_14 = Convert.ToDouble(txtF_5_14.Text); };

            if (m_F_5_14 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_14);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_15);

        }
        protected void txtF_5_19_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_19;
            if (String.IsNullOrEmpty(txtF_5_19.Text)) { m_F_5_19 = 0; } else { m_F_5_19 = Convert.ToDouble(txtF_5_19.Text); };

            if (m_F_5_19 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_19);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_20);

        }
        protected void txtF_5_24_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_24;
            if (String.IsNullOrEmpty(txtF_5_24.Text)) { m_F_5_24 = 0; } else { m_F_5_24 = Convert.ToDouble(txtF_5_24.Text); };

            if (m_F_5_24 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_24);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_25);

        }
        protected void txtF_5_29_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_29;
            if (String.IsNullOrEmpty(txtF_5_29.Text)) { m_F_5_29 = 0; } else { m_F_5_29 = Convert.ToDouble(txtF_5_29.Text); };

            if (m_F_5_29 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_29);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_30);

        }
        protected void txtF_5_34_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_34;
            if (String.IsNullOrEmpty(txtF_5_34.Text)) { m_F_5_34 = 0; } else { m_F_5_34 = Convert.ToDouble(txtF_5_34.Text); };

            if (m_F_5_34 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_34);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_35);

        }
        protected void txtF_5_39_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_39;
            if (String.IsNullOrEmpty(txtF_5_39.Text)) { m_F_5_39 = 0; } else { m_F_5_39 = Convert.ToDouble(txtF_5_39.Text); };

            if (m_F_5_39 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_39);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_40);

        }
        protected void txtF_5_44_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_44;
            if (String.IsNullOrEmpty(txtF_5_44.Text)) { m_F_5_44 = 0; } else { m_F_5_44 = Convert.ToDouble(txtF_5_44.Text); };

            if (m_F_5_44 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_44);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_45);

        }
        protected void txtF_5_49_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_49;
            if (String.IsNullOrEmpty(txtF_5_49.Text)) { m_F_5_49 = 0; } else { m_F_5_49 = Convert.ToDouble(txtF_5_49.Text); };

            if (m_F_5_49 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_49);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_50);

        }

        protected void txtF_5_54_TextChanged(object sender, EventArgs e)
        {
            double m_F_5_54;
            if (String.IsNullOrEmpty(txtF_5_54.Text)) { m_F_5_54 = 0; } else { m_F_5_54 = Convert.ToDouble(txtF_5_54.Text); };

            if (m_F_5_54 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_5_54);
                return;
            }

            Calculate_F_5_4();

            SetFocusOnLoad(txtF_5_55);

        }

        protected void Calculate_F_4_7()
        {
            double F_4_7_5;
            double F_4_7_10;
            double F_4_7_15;
            double F_4_7_20;
            double F_4_7_25;
            double F_4_7_30;
            double F_4_7_35;
            double F_4_7_40;
            double F_4_7_45;
            double F_4_7_50;
            double F_4_7_55;
            double F_4_7_60;
            double F_4_7_61;

            if (String.IsNullOrEmpty(txtF_4_7_5.Text)) { F_4_7_5 = 0; } else { F_4_7_5 = Convert.ToDouble(txtF_4_7_5.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_10.Text)) { F_4_7_10 = 0; } else { F_4_7_10 = Convert.ToDouble(txtF_4_7_10.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_15.Text)) { F_4_7_15 = 0; } else { F_4_7_15 = Convert.ToDouble(txtF_4_7_15.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_20.Text)) { F_4_7_20 = 0; } else { F_4_7_20 = Convert.ToDouble(txtF_4_7_20.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_25.Text)) { F_4_7_25 = 0; } else { F_4_7_25 = Convert.ToDouble(txtF_4_7_25.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_30.Text)) { F_4_7_30 = 0; } else { F_4_7_30 = Convert.ToDouble(txtF_4_7_30.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_35.Text)) { F_4_7_35 = 0; } else { F_4_7_35 = Convert.ToDouble(txtF_4_7_35.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_40.Text)) { F_4_7_40 = 0; } else { F_4_7_40 = Convert.ToDouble(txtF_4_7_40.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_45.Text)) { F_4_7_45 = 0; } else { F_4_7_45 = Convert.ToDouble(txtF_4_7_45.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_50.Text)) { F_4_7_50 = 0; } else { F_4_7_50 = Convert.ToDouble(txtF_4_7_50.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_55.Text)) { F_4_7_55 = 0; } else { F_4_7_55 = Convert.ToDouble(txtF_4_7_55.Text); };
            if (String.IsNullOrEmpty(txtF_4_7_60.Text)) { F_4_7_60 = 0; } else { F_4_7_60 = Convert.ToDouble(txtF_4_7_60.Text); };


            F_4_7_61 = F_4_7_5 + F_4_7_10 + F_4_7_15 + F_4_7_20 + F_4_7_25 + F_4_7_30 + F_4_7_35 + F_4_7_40 + F_4_7_45 + F_4_7_50 + F_4_7_55 + F_4_7_60;
            txtF_4_7_61.Text = F_4_7_61.ToString();
        }

        protected void txtF_4_7_5_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_5;
            if (String.IsNullOrEmpty(txtF_4_7_5.Text)) { m_F_4_7_5 = 0; } else { m_F_4_7_5 = Convert.ToDouble(txtF_4_7_5.Text); };
            if (m_F_4_7_5 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_5);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_6);

        }
        protected void txtF_4_7_10_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_10;
            if (String.IsNullOrEmpty(txtF_4_7_10.Text)) { m_F_4_7_10 = 0; } else { m_F_4_7_10 = Convert.ToDouble(txtF_4_7_10.Text); };
            if (m_F_4_7_10 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_10);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_11);

        }

        protected void txtF_4_7_15_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_15;
            if (String.IsNullOrEmpty(txtF_4_7_15.Text)) { m_F_4_7_15 = 0; } else { m_F_4_7_15 = Convert.ToDouble(txtF_4_7_15.Text); };
            if (m_F_4_7_15 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_15);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_16);

        }

        protected void txtF_4_7_20_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_20;
            if (String.IsNullOrEmpty(txtF_4_7_20.Text)) { m_F_4_7_20 = 0; } else { m_F_4_7_20 = Convert.ToDouble(txtF_4_7_20.Text); };
            if (m_F_4_7_20 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_20);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_21);

        }

        protected void txtF_4_7_25_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_25;
            if (String.IsNullOrEmpty(txtF_4_7_25.Text)) { m_F_4_7_25 = 0; } else { m_F_4_7_25 = Convert.ToDouble(txtF_4_7_25.Text); };
            if (m_F_4_7_25 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_25);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_26);

        }

        protected void txtF_4_7_30_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_30;
            if (String.IsNullOrEmpty(txtF_4_7_30.Text)) { m_F_4_7_30 = 0; } else { m_F_4_7_30 = Convert.ToDouble(txtF_4_7_30.Text); };
            if (m_F_4_7_30 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_30);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_31);

        }

        protected void txtF_4_7_35_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_35;
            if (String.IsNullOrEmpty(txtF_4_7_35.Text)) { m_F_4_7_35 = 0; } else { m_F_4_7_35 = Convert.ToDouble(txtF_4_7_35.Text); };
            if (m_F_4_7_35 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_35);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_36);

        }

        protected void txtF_4_7_40_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_40;
            if (String.IsNullOrEmpty(txtF_4_7_40.Text)) { m_F_4_7_40 = 0; } else { m_F_4_7_40 = Convert.ToDouble(txtF_4_7_40.Text); };
            if (m_F_4_7_40 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_40);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_41);

        }

        protected void txtF_4_7_45_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_45;
            if (String.IsNullOrEmpty(txtF_4_7_45.Text)) { m_F_4_7_45 = 0; } else { m_F_4_7_45 = Convert.ToDouble(txtF_4_7_45.Text); };
            if (m_F_4_7_45 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_45);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_46);

        }

        protected void txtF_4_7_50_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_50;
            if (String.IsNullOrEmpty(txtF_4_7_50.Text)) { m_F_4_7_50 = 0; } else { m_F_4_7_50 = Convert.ToDouble(txtF_4_7_50.Text); };
            if (m_F_4_7_50 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_50);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_51);

        }

        protected void txtF_4_7_55_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_55;
            if (String.IsNullOrEmpty(txtF_4_7_55.Text)) { m_F_4_7_55 = 0; } else { m_F_4_7_55 = Convert.ToDouble(txtF_4_7_55.Text); };
            if (m_F_4_7_55 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_55);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_56);

        }
        protected void txtF_4_7_60_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_7_60;
            if (String.IsNullOrEmpty(txtF_4_7_60.Text)) { m_F_4_7_60 = 0; } else { m_F_4_7_60 = Convert.ToDouble(txtF_4_7_60.Text); };
            if (m_F_4_7_60 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_7_60);
                return;
            }

            Calculate_F_4_7();

            SetFocusOnLoad(txtF_4_7_61);

        }

                                    
        protected void Calculate_F_4_5()
        {
            double F_4_5_3;
            double F_4_5_6;
            double F_4_5_9;
            double F_4_5_12;
            double F_4_5_15;
            double F_4_5_18;
            double F_4_5_21;
            double F_4_5_24;
            double F_4_5_27;
            double F_4_5_30;
            double F_4_5_31;

            if (String.IsNullOrEmpty(txtF_4_5_3.Text)) { F_4_5_3 = 0; } else { F_4_5_3 = Convert.ToDouble(txtF_4_5_3.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_6.Text)) { F_4_5_6 = 0; } else { F_4_5_6 = Convert.ToDouble(txtF_4_5_6.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_9.Text)) { F_4_5_9 = 0; } else { F_4_5_9 = Convert.ToDouble(txtF_4_5_9.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_12.Text)) { F_4_5_12 = 0; } else { F_4_5_12 = Convert.ToDouble(txtF_4_5_12.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_15.Text)) { F_4_5_15 = 0; } else { F_4_5_15 = Convert.ToDouble(txtF_4_5_15.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_18.Text)) { F_4_5_18 = 0; } else { F_4_5_18 = Convert.ToDouble(txtF_4_5_18.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_21.Text)) { F_4_5_21 = 0; } else { F_4_5_21 = Convert.ToDouble(txtF_4_5_21.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_24.Text)) { F_4_5_24 = 0; } else { F_4_5_24 = Convert.ToDouble(txtF_4_5_24.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_27.Text)) { F_4_5_27 = 0; } else { F_4_5_27 = Convert.ToDouble(txtF_4_5_27.Text); };
            if (String.IsNullOrEmpty(txtF_4_5_30.Text)) { F_4_5_30 = 0; } else { F_4_5_30 = Convert.ToDouble(txtF_4_5_30.Text); };

            F_4_5_31 = F_4_5_3 + F_4_5_6 + F_4_5_9 + F_4_5_12 + F_4_5_15 + F_4_5_18 + F_4_5_21 + F_4_5_24 + F_4_5_27 + F_4_5_30;
            txtF_4_5_31.Text = F_4_5_31.ToString();
        }

        protected void txtF_4_5_3_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_3;
            if (String.IsNullOrEmpty(txtF_4_5_3.Text)) { m_F_4_5_3 = 0; } else { m_F_4_5_3 = Convert.ToDouble(txtF_4_5_3.Text); };

            if (m_F_4_5_3 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_3);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_4);

        }

        protected void txtF_4_5_6_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_6;
            if (String.IsNullOrEmpty(txtF_4_5_6.Text)) { m_F_4_5_6 = 0; } else { m_F_4_5_6 = Convert.ToDouble(txtF_4_5_6.Text); };

            if (m_F_4_5_6 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_6);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_7);

        }
        protected void txtF_4_5_9_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_9;
            if (String.IsNullOrEmpty(txtF_4_5_9.Text)) { m_F_4_5_9 = 0; } else { m_F_4_5_9 = Convert.ToDouble(txtF_4_5_9.Text); };

            if (m_F_4_5_9 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_9);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_10);

        }
        protected void txtF_4_5_12_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_12;
            if (String.IsNullOrEmpty(txtF_4_5_12.Text)) { m_F_4_5_12 = 0; } else { m_F_4_5_12 = Convert.ToDouble(txtF_4_5_12.Text); };

            if (m_F_4_5_12 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_12);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_13);

        }
        protected void txtF_4_5_15_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_15;
            if (String.IsNullOrEmpty(txtF_4_5_15.Text)) { m_F_4_5_15 = 0; } else { m_F_4_5_15 = Convert.ToDouble(txtF_4_5_15.Text); };

            if (m_F_4_5_15 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_15);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_16);

        }
        protected void txtF_4_5_18_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_18;
            if (String.IsNullOrEmpty(txtF_4_5_18.Text)) { m_F_4_5_18 = 0; } else { m_F_4_5_18 = Convert.ToDouble(txtF_4_5_18.Text); };

            if (m_F_4_5_18 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_18);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_19);

        }
        protected void txtF_4_5_21_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_21;
            if (String.IsNullOrEmpty(txtF_4_5_21.Text)) { m_F_4_5_21 = 0; } else { m_F_4_5_21 = Convert.ToDouble(txtF_4_5_21.Text); };

            if (m_F_4_5_21 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_21);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_22);

        }
        protected void txtF_4_5_24_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_24;
            if (String.IsNullOrEmpty(txtF_4_5_24.Text)) { m_F_4_5_24 = 0; } else { m_F_4_5_24 = Convert.ToDouble(txtF_4_5_24.Text); };

            if (m_F_4_5_24 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_24);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_25);

        }
        protected void txtF_4_5_27_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_27;
            if (String.IsNullOrEmpty(txtF_4_5_27.Text)) { m_F_4_5_27 = 0; } else { m_F_4_5_27 = Convert.ToDouble(txtF_4_5_27.Text); };

            if (m_F_4_5_27 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_27);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_28);

        }
        protected void txtF_4_5_30_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_5_30;
            if (String.IsNullOrEmpty(txtF_4_5_30.Text)) { m_F_4_5_30 = 0; } else { m_F_4_5_30 = Convert.ToDouble(txtF_4_5_30.Text); };

            if (m_F_4_5_30 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_5_30);
                return;
            }

            Calculate_F_4_5();

            SetFocusOnLoad(txtF_4_5_31);

        }

        protected void Calculate_F_4_4()
        {
            double F_4_4_5;
            double F_4_4_15;
            double F_4_4_10;
            double F_4_4_20;
            double F_4_4_25;
            double F_4_4_30;
            double F_4_4_35;
            double F_4_4_40;
            double F_4_4_45;
            double F_4_4_50;
            double F_4_4_55;
            double F_4_4_56;


            if (String.IsNullOrEmpty(txtF_4_4_5.Text)) { F_4_4_5 = 0; } else { F_4_4_5 = Convert.ToDouble(txtF_4_4_5.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_10.Text)) { F_4_4_10 = 0; } else { F_4_4_10 = Convert.ToDouble(txtF_4_4_10.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_15.Text)) { F_4_4_15 = 0; } else { F_4_4_15 = Convert.ToDouble(txtF_4_4_15.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_20.Text)) { F_4_4_20 = 0; } else { F_4_4_20 = Convert.ToDouble(txtF_4_4_20.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_25.Text)) { F_4_4_25 = 0; } else { F_4_4_25 = Convert.ToDouble(txtF_4_4_25.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_30.Text)) { F_4_4_30 = 0; } else { F_4_4_30 = Convert.ToDouble(txtF_4_4_30.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_35.Text)) { F_4_4_35 = 0; } else { F_4_4_35 = Convert.ToDouble(txtF_4_4_35.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_40.Text)) { F_4_4_40 = 0; } else { F_4_4_40 = Convert.ToDouble(txtF_4_4_40.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_45.Text)) { F_4_4_45 = 0; } else { F_4_4_45 = Convert.ToDouble(txtF_4_4_45.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_50.Text)) { F_4_4_50 = 0; } else { F_4_4_50 = Convert.ToDouble(txtF_4_4_50.Text); };
            if (String.IsNullOrEmpty(txtF_4_4_55.Text)) { F_4_4_55 = 0; } else { F_4_4_55 = Convert.ToDouble(txtF_4_4_55.Text); };

            F_4_4_56 = F_4_4_5 + F_4_4_10+ F_4_4_15 + F_4_4_20 + F_4_4_25 + F_4_4_30 + F_4_4_35 + F_4_4_40 + F_4_4_45 + F_4_4_50 + F_4_4_55;
            txtF_4_4_56.Text = F_4_4_56.ToString();
        }


        protected void txtF_4_4_5_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_5;
            if (String.IsNullOrEmpty(txtF_4_4_5.Text)) { m_F_4_4_5 = 0; } else { m_F_4_4_5 = Convert.ToDouble(txtF_4_4_5.Text); };
            if (m_F_4_4_5 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_5);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_6);

        }

        protected void txtF_4_4_10_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_10;
            if (String.IsNullOrEmpty(txtF_4_4_10.Text)) { m_F_4_4_10 = 0; } else { m_F_4_4_10 = Convert.ToDouble(txtF_4_4_10.Text); };
            if (m_F_4_4_10 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_10);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_11);

        }

        protected void txtF_4_4_15_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_15;
            if (String.IsNullOrEmpty(txtF_4_4_15.Text)) { m_F_4_4_15 = 0; } else { m_F_4_4_15 = Convert.ToDouble(txtF_4_4_15.Text); };
            if (m_F_4_4_15 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_15);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_16);

        }
        protected void txtF_4_4_20_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_20;
            if (String.IsNullOrEmpty(txtF_4_4_20.Text)) { m_F_4_4_20 = 0; } else { m_F_4_4_20 = Convert.ToDouble(txtF_4_4_20.Text); };
            if (m_F_4_4_20 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_20);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_21);

        }
        protected void txtF_4_4_25_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_25;
            if (String.IsNullOrEmpty(txtF_4_4_25.Text)) { m_F_4_4_25 = 0; } else { m_F_4_4_25 = Convert.ToDouble(txtF_4_4_25.Text); };
            if (m_F_4_4_25 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_25);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_26);

        }
        protected void txtF_4_4_30_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_30;
            if (String.IsNullOrEmpty(txtF_4_4_30.Text)) { m_F_4_4_30 = 0; } else { m_F_4_4_30 = Convert.ToDouble(txtF_4_4_30.Text); };
            if (m_F_4_4_30 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_30);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_31);

        }
        protected void txtF_4_4_35_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_35;
            if (String.IsNullOrEmpty(txtF_4_4_35.Text)) { m_F_4_4_35 = 0; } else { m_F_4_4_35 = Convert.ToDouble(txtF_4_4_35.Text); };
            if (m_F_4_4_35 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_35);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_36);

        }
        protected void txtF_4_4_40_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_40;
            if (String.IsNullOrEmpty(txtF_4_4_40.Text)) { m_F_4_4_40 = 0; } else { m_F_4_4_40 = Convert.ToDouble(txtF_4_4_40.Text); };
            if (m_F_4_4_40 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_40);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_41);

        }
        protected void txtF_4_4_45_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_45;
            if (String.IsNullOrEmpty(txtF_4_4_45.Text)) { m_F_4_4_45 = 0; } else { m_F_4_4_45 = Convert.ToDouble(txtF_4_4_45.Text); };
            if (m_F_4_4_45 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_45);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_46);

        }
        protected void txtF_4_4_50_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_50;
            if (String.IsNullOrEmpty(txtF_4_4_50.Text)) { m_F_4_4_50 = 0; } else { m_F_4_4_50 = Convert.ToDouble(txtF_4_4_50.Text); };
            if (m_F_4_4_50 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_50);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_51);

        }
        protected void txtF_4_4_55_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_4_55;
            if (String.IsNullOrEmpty(txtF_4_4_55.Text)) { m_F_4_4_55 = 0; } else { m_F_4_4_55 = Convert.ToDouble(txtF_4_4_55.Text); };
            if (m_F_4_4_55 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_4_55);
                return;
            }

            Calculate_F_4_4();

            SetFocusOnLoad(txtF_4_4_56);

        }


        protected void Calculate_F_4_3_82()
        {
            double F_4_3_4;
            double F_4_3_8;
            double F_4_3_12;
            double F_4_3_16;
            double F_4_3_20;
            double F_4_3_24;
            double F_4_3_28;
            double F_4_3_32;
            double F_4_3_36;
            double F_4_3_40;
            double F_4_3_44;
            double F_4_3_48;
            double F_4_3_52;
            double F_4_3_56;
            double F_4_3_60;
            double F_4_3_64;
            double F_4_3_68;
            double F_4_3_72;
            double F_4_3_76;
            double F_4_3_80;

            if (String.IsNullOrEmpty(txtF_4_3_4.Text)) { F_4_3_4 = 0; } else { F_4_3_4 = Convert.ToDouble(txtF_4_3_4.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_8.Text)) { F_4_3_8 = 0; } else { F_4_3_8 = Convert.ToDouble(txtF_4_3_8.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_12.Text)) { F_4_3_12 = 0; } else { F_4_3_12 = Convert.ToDouble(txtF_4_3_12.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_16.Text)) { F_4_3_16 = 0; } else { F_4_3_16 = Convert.ToDouble(txtF_4_3_16.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_20.Text)) { F_4_3_20 = 0; } else { F_4_3_20 = Convert.ToDouble(txtF_4_3_20.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_24.Text)) { F_4_3_24 = 0; } else { F_4_3_24 = Convert.ToDouble(txtF_4_3_24.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_28.Text)) { F_4_3_28 = 0; } else { F_4_3_28 = Convert.ToDouble(txtF_4_3_28.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_32.Text)) { F_4_3_32 = 0; } else { F_4_3_32 = Convert.ToDouble(txtF_4_3_32.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_36.Text)) { F_4_3_36 = 0; } else { F_4_3_36 = Convert.ToDouble(txtF_4_3_36.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_40.Text)) { F_4_3_40 = 0; } else { F_4_3_40 = Convert.ToDouble(txtF_4_3_40.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_44.Text)) { F_4_3_44 = 0; } else { F_4_3_44 = Convert.ToDouble(txtF_4_3_44.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_48.Text)) { F_4_3_48 = 0; } else { F_4_3_48 = Convert.ToDouble(txtF_4_3_48.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_52.Text)) { F_4_3_52 = 0; } else { F_4_3_52 = Convert.ToDouble(txtF_4_3_52.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_56.Text)) { F_4_3_56 = 0; } else { F_4_3_56 = Convert.ToDouble(txtF_4_3_56.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_60.Text)) { F_4_3_60 = 0; } else { F_4_3_60 = Convert.ToDouble(txtF_4_3_60.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_64.Text)) { F_4_3_64 = 0; } else { F_4_3_64 = Convert.ToDouble(txtF_4_3_64.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_68.Text)) { F_4_3_68 = 0; } else { F_4_3_68 = Convert.ToDouble(txtF_4_3_68.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_72.Text)) { F_4_3_72 = 0; } else { F_4_3_72 = Convert.ToDouble(txtF_4_3_72.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_76.Text)) { F_4_3_76 = 0; } else { F_4_3_76 = Convert.ToDouble(txtF_4_3_76.Text); };
            if (String.IsNullOrEmpty(txtF_4_3_80.Text)) { F_4_3_80 = 0; } else { F_4_3_80 = Convert.ToDouble(txtF_4_3_80.Text); };




            double F_4_3_82 = F_4_3_4 + F_4_3_8 + F_4_3_12 + F_4_3_16 + F_4_3_20 + F_4_3_24 + F_4_3_28 + F_4_3_32 + F_4_3_36 + F_4_3_40 + F_4_3_44 +
                    F_4_3_48 + F_4_3_52 + F_4_3_56 + F_4_3_60 + F_4_3_64 + F_4_3_68 + F_4_3_72 + F_4_3_76 + F_4_3_80;
            txtF_4_3_82.Text = F_4_3_82.ToString();
        }



        protected void Calculate_F_3_1_43()
        {
            double F_3_1_1;
            double F_3_2_1;
            double F_3_3_1;
            double F_3_4_1;
            double F_3_5_1;
            double F_3_6_1;
            double F_3_7_1;
            double F_3_8_1;
            double F_3_9_1;
            double F_3_10_1;
            double F_3_11_1;
            double F_3_12_1;
            double F_3_13_1;
            double F_3_14_1;
            double F_3_15_1;
            double F_3_16_1;
            double F_3_17_1;
            double F_3_18_1;
            double F_3_19_1;
            double F_3_20_1;
            double F_3_21_1;
            double F_3_22_1;
            double F_3_23_1;
            double F_3_24_1;
            double F_3_25_1;
            double F_3_26_1;
            double F_3_27_1;
            double F_3_28_1;
            double F_3_29_1;
            double F_3_30_1;
            double F_3_31_1;
            double F_3_32_1;
            double F_3_33_1;
            double F_3_34_1;
            double F_3_35_1;
            double F_3_36_1;
            double F_3_37_1;
            double F_3_38_1;
            double F_3_39_1;
            double F_3_40_1;
            double F_3_41_1;
            double F_3_42_1;
            double F_3_43_1;

            if (String.IsNullOrEmpty(txtF_3_1_1.Text)) { F_3_1_1 = 0; } else { F_3_1_1 = Convert.ToDouble(txtF_3_1_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_2_1.Text)) { F_3_2_1 = 0; } else { F_3_2_1 = Convert.ToDouble(txtF_3_2_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_3_1.Text)) { F_3_3_1 = 0; } else { F_3_3_1 = Convert.ToDouble(txtF_3_3_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_4_1.Text)) { F_3_4_1 = 0; } else { F_3_4_1 = Convert.ToDouble(txtF_3_4_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_5_1.Text)) { F_3_5_1 = 0; } else { F_3_5_1 = Convert.ToDouble(txtF_3_5_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_6_1.Text)) { F_3_6_1 = 0; } else { F_3_6_1 = Convert.ToDouble(txtF_3_6_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_7_1.Text)) { F_3_7_1 = 0; } else { F_3_7_1 = Convert.ToDouble(txtF_3_7_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_8_1.Text)) { F_3_8_1 = 0; } else { F_3_8_1 = Convert.ToDouble(txtF_3_8_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_9_1.Text)) { F_3_9_1 = 0; } else { F_3_9_1 = Convert.ToDouble(txtF_3_9_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_10_1.Text)) { F_3_10_1 = 0; } else { F_3_10_1 = Convert.ToDouble(txtF_3_10_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_11_1.Text)) { F_3_11_1 = 0; } else { F_3_11_1 = Convert.ToDouble(txtF_3_11_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_12_1.Text)) { F_3_12_1 = 0; } else { F_3_12_1 = Convert.ToDouble(txtF_3_12_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_13_1.Text)) { F_3_13_1 = 0; } else { F_3_13_1 = Convert.ToDouble(txtF_3_13_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_14_1.Text)) { F_3_14_1 = 0; } else { F_3_14_1 = Convert.ToDouble(txtF_3_14_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_15_1.Text)) { F_3_15_1 = 0; } else { F_3_15_1 = Convert.ToDouble(txtF_3_15_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_16_1.Text)) { F_3_16_1 = 0; } else { F_3_16_1 = Convert.ToDouble(txtF_3_16_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_17_1.Text)) { F_3_17_1 = 0; } else { F_3_17_1 = Convert.ToDouble(txtF_3_17_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_18_1.Text)) { F_3_18_1 = 0; } else { F_3_18_1 = Convert.ToDouble(txtF_3_18_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_19_1.Text)) { F_3_19_1 = 0; } else { F_3_19_1 = Convert.ToDouble(txtF_3_19_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_20_1.Text)) { F_3_20_1 = 0; } else { F_3_20_1 = Convert.ToDouble(txtF_3_20_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_21_1.Text)) { F_3_21_1 = 0; } else { F_3_21_1 = Convert.ToDouble(txtF_3_21_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_22_1.Text)) { F_3_22_1 = 0; } else { F_3_22_1 = Convert.ToDouble(txtF_3_22_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_23_1.Text)) { F_3_23_1 = 0; } else { F_3_23_1 = Convert.ToDouble(txtF_3_23_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_24_1.Text)) { F_3_24_1 = 0; } else { F_3_24_1 = Convert.ToDouble(txtF_3_24_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_25_1.Text)) { F_3_25_1 = 0; } else { F_3_25_1 = Convert.ToDouble(txtF_3_25_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_26_1.Text)) { F_3_26_1 = 0; } else { F_3_26_1 = Convert.ToDouble(txtF_3_26_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_27_1.Text)) { F_3_27_1 = 0; } else { F_3_27_1 = Convert.ToDouble(txtF_3_27_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_28_1.Text)) { F_3_28_1 = 0; } else { F_3_28_1 = Convert.ToDouble(txtF_3_28_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_29_1.Text)) { F_3_29_1 = 0; } else { F_3_29_1 = Convert.ToDouble(txtF_3_29_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_30_1.Text)) { F_3_30_1 = 0; } else { F_3_30_1 = Convert.ToDouble(txtF_3_30_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_31_1.Text)) { F_3_31_1 = 0; } else { F_3_31_1 = Convert.ToDouble(txtF_3_31_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_32_1.Text)) { F_3_32_1 = 0; } else { F_3_32_1 = Convert.ToDouble(txtF_3_32_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_33_1.Text)) { F_3_33_1 = 0; } else { F_3_33_1 = Convert.ToDouble(txtF_3_33_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_34_1.Text)) { F_3_34_1 = 0; } else { F_3_34_1 = Convert.ToDouble(txtF_3_34_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_35_1.Text)) { F_3_35_1 = 0; } else { F_3_35_1 = Convert.ToDouble(txtF_3_35_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_36_1.Text)) { F_3_36_1 = 0; } else { F_3_36_1 = Convert.ToDouble(txtF_3_36_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_37_1.Text)) { F_3_37_1 = 0; } else { F_3_37_1 = Convert.ToDouble(txtF_3_37_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_38_1.Text)) { F_3_38_1 = 0; } else { F_3_38_1 = Convert.ToDouble(txtF_3_38_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_39_1.Text)) { F_3_39_1 = 0; } else { F_3_39_1 = Convert.ToDouble(txtF_3_39_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_40_1.Text)) { F_3_40_1 = 0; } else { F_3_40_1 = Convert.ToDouble(txtF_3_40_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_41_1.Text)) { F_3_41_1 = 0; } else { F_3_41_1 = Convert.ToDouble(txtF_3_41_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_42_1.Text)) { F_3_42_1 = 0; } else { F_3_42_1 = Convert.ToDouble(txtF_3_42_1.Text); };
            if (String.IsNullOrEmpty(txtF_3_43_1.Text)) { F_3_43_1 = 0; } else { F_3_43_1 = Convert.ToDouble(txtF_3_43_1.Text); };

            double F_3_44_1 = F_3_36_1 + F_3_37_1 + F_3_38_1 + F_3_39_1 + F_3_40_1 + F_3_41_1 + F_3_42_1 + F_3_43_1;
            double F_3_45_1 = F_3_1_1 + F_3_2_1 + F_3_3_1 + F_3_4_1 + F_3_5_1 + F_3_6_1 + F_3_7_1 + F_3_8_1 + F_3_9_1 + F_3_10_1 + F_3_11_1 + F_3_12_1 +
                   F_3_13_1 + F_3_14_1 + F_3_15_1 + F_3_16_1 + F_3_17_1 + F_3_18_1 + F_3_19_1 + F_3_20_1 + F_3_21_1 + F_3_22_1 + F_3_23_1 + F_3_24_1 +
                   F_3_25_1 + F_3_26_1 + F_3_27_1 + F_3_28_1 + F_3_29_1 + F_3_30_1 + F_3_31_1 + F_3_32_1 + F_3_33_1 + F_3_34_1 + F_3_35_1 + F_3_36_1 +
                   F_3_37_1 + F_3_38_1 + F_3_39_1 + F_3_40_1 + F_3_41_1 + F_3_42_1 + F_3_43_1;
            txtF_3_44_1.Text = F_3_44_1.ToString();
            txtF_3_45_1.Text = F_3_45_1.ToString();
        }

        protected void Calculate_F_3_2_43()
        {
            double F_3_1_2;
            double F_3_2_2;
            double F_3_3_2;
            double F_3_4_2;
            double F_3_5_2;
            double F_3_6_2;
            double F_3_7_2;
            double F_3_8_2;
            double F_3_9_2;
            double F_3_10_2;
            double F_3_11_2;
            double F_3_12_2;
            double F_3_13_2;
            double F_3_14_2;
            double F_3_15_2;
            double F_3_16_2;
            double F_3_17_2;
            double F_3_18_2;
            double F_3_19_2;
            double F_3_20_2;
            double F_3_21_2;
            double F_3_22_2;
            double F_3_23_2;
            double F_3_24_2;
            double F_3_25_2;
            double F_3_26_2;
            double F_3_27_2;
            double F_3_28_2;
            double F_3_29_2;
            double F_3_30_2;
            double F_3_31_2;
            double F_3_32_2;
            double F_3_33_2;
            double F_3_34_2;
            double F_3_35_2;
            double F_3_36_2;
            double F_3_37_2;
            double F_3_38_2;
            double F_3_39_2;
            double F_3_40_2;
            double F_3_41_2;
            double F_3_42_2;
            double F_3_43_2;

            if (String.IsNullOrEmpty(txtF_3_1_2.Text)) { F_3_1_2 = 0; } else { F_3_1_2 = Convert.ToDouble(txtF_3_1_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_2_2.Text)) { F_3_2_2 = 0; } else { F_3_2_2 = Convert.ToDouble(txtF_3_2_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_3_2.Text)) { F_3_3_2 = 0; } else { F_3_3_2 = Convert.ToDouble(txtF_3_3_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_4_2.Text)) { F_3_4_2 = 0; } else { F_3_4_2 = Convert.ToDouble(txtF_3_4_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_5_2.Text)) { F_3_5_2 = 0; } else { F_3_5_2 = Convert.ToDouble(txtF_3_5_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_6_2.Text)) { F_3_6_2 = 0; } else { F_3_6_2 = Convert.ToDouble(txtF_3_6_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_7_2.Text)) { F_3_7_2 = 0; } else { F_3_7_2 = Convert.ToDouble(txtF_3_7_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_8_2.Text)) { F_3_8_2 = 0; } else { F_3_8_2 = Convert.ToDouble(txtF_3_8_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_9_2.Text)) { F_3_9_2 = 0; } else { F_3_9_2 = Convert.ToDouble(txtF_3_9_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_10_2.Text)) { F_3_10_2 = 0; } else { F_3_10_2 = Convert.ToDouble(txtF_3_10_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_11_2.Text)) { F_3_11_2 = 0; } else { F_3_11_2 = Convert.ToDouble(txtF_3_11_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_12_2.Text)) { F_3_12_2 = 0; } else { F_3_12_2 = Convert.ToDouble(txtF_3_12_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_13_2.Text)) { F_3_13_2 = 0; } else { F_3_13_2 = Convert.ToDouble(txtF_3_13_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_14_2.Text)) { F_3_14_2 = 0; } else { F_3_14_2 = Convert.ToDouble(txtF_3_14_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_15_2.Text)) { F_3_15_2 = 0; } else { F_3_15_2 = Convert.ToDouble(txtF_3_15_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_16_2.Text)) { F_3_16_2 = 0; } else { F_3_16_2 = Convert.ToDouble(txtF_3_16_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_17_2.Text)) { F_3_17_2 = 0; } else { F_3_17_2 = Convert.ToDouble(txtF_3_17_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_18_2.Text)) { F_3_18_2 = 0; } else { F_3_18_2 = Convert.ToDouble(txtF_3_18_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_19_2.Text)) { F_3_19_2 = 0; } else { F_3_19_2 = Convert.ToDouble(txtF_3_19_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_20_2.Text)) { F_3_20_2 = 0; } else { F_3_20_2 = Convert.ToDouble(txtF_3_20_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_21_2.Text)) { F_3_21_2 = 0; } else { F_3_21_2 = Convert.ToDouble(txtF_3_21_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_22_2.Text)) { F_3_22_2 = 0; } else { F_3_22_2 = Convert.ToDouble(txtF_3_22_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_23_2.Text)) { F_3_23_2 = 0; } else { F_3_23_2 = Convert.ToDouble(txtF_3_23_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_24_2.Text)) { F_3_24_2 = 0; } else { F_3_24_2 = Convert.ToDouble(txtF_3_24_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_25_2.Text)) { F_3_25_2 = 0; } else { F_3_25_2 = Convert.ToDouble(txtF_3_25_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_26_2.Text)) { F_3_26_2 = 0; } else { F_3_26_2 = Convert.ToDouble(txtF_3_26_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_27_2.Text)) { F_3_27_2 = 0; } else { F_3_27_2 = Convert.ToDouble(txtF_3_27_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_28_2.Text)) { F_3_28_2 = 0; } else { F_3_28_2 = Convert.ToDouble(txtF_3_28_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_29_2.Text)) { F_3_29_2 = 0; } else { F_3_29_2 = Convert.ToDouble(txtF_3_29_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_30_2.Text)) { F_3_30_2 = 0; } else { F_3_30_2 = Convert.ToDouble(txtF_3_30_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_31_2.Text)) { F_3_31_2 = 0; } else { F_3_31_2 = Convert.ToDouble(txtF_3_31_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_32_2.Text)) { F_3_32_2 = 0; } else { F_3_32_2 = Convert.ToDouble(txtF_3_32_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_33_2.Text)) { F_3_33_2 = 0; } else { F_3_33_2 = Convert.ToDouble(txtF_3_33_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_34_2.Text)) { F_3_34_2 = 0; } else { F_3_34_2 = Convert.ToDouble(txtF_3_34_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_35_2.Text)) { F_3_35_2 = 0; } else { F_3_35_2 = Convert.ToDouble(txtF_3_35_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_36_2.Text)) { F_3_36_2 = 0; } else { F_3_36_2 = Convert.ToDouble(txtF_3_36_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_37_2.Text)) { F_3_37_2 = 0; } else { F_3_37_2 = Convert.ToDouble(txtF_3_37_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_38_2.Text)) { F_3_38_2 = 0; } else { F_3_38_2 = Convert.ToDouble(txtF_3_38_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_39_2.Text)) { F_3_39_2 = 0; } else { F_3_39_2 = Convert.ToDouble(txtF_3_39_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_40_2.Text)) { F_3_40_2 = 0; } else { F_3_40_2 = Convert.ToDouble(txtF_3_40_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_41_2.Text)) { F_3_41_2 = 0; } else { F_3_41_2 = Convert.ToDouble(txtF_3_41_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_42_2.Text)) { F_3_42_2 = 0; } else { F_3_42_2 = Convert.ToDouble(txtF_3_42_2.Text); };
            if (String.IsNullOrEmpty(txtF_3_43_2.Text)) { F_3_43_2 = 0; } else { F_3_43_2 = Convert.ToDouble(txtF_3_43_2.Text); };



            double F_3_44_2 = F_3_36_2 + F_3_37_2 + F_3_38_2 + F_3_39_2 + F_3_40_2 + F_3_41_2 + F_3_42_2 + F_3_43_2;
            double F_3_45_2 = F_3_1_2 + F_3_2_2 + F_3_3_2 + F_3_4_2 + F_3_5_2 + F_3_6_2 + F_3_7_2 + F_3_8_2 + F_3_9_2 + F_3_10_2 + F_3_11_2 + F_3_12_2 +
                   F_3_13_2 + F_3_14_2 + F_3_15_2 + F_3_16_2 + F_3_17_2 + F_3_18_2 + F_3_19_2 + F_3_20_2 + F_3_21_2 + F_3_22_2 + F_3_23_2 + F_3_24_2 +
                   F_3_25_2 + F_3_26_2 + F_3_27_2 + F_3_28_2 + F_3_29_2 + F_3_30_2 + F_3_31_2 + F_3_32_2 + F_3_33_2 + F_3_34_2 + F_3_35_2 + F_3_36_2 +
                   F_3_37_2+ F_3_38_2 + F_3_39_2 + F_3_40_2 + F_3_41_2 + F_3_42_2 + F_3_43_2;
            txtF_3_44_2.Text = F_3_44_2.ToString();
            txtF_3_45_2.Text = F_3_45_2.ToString();
        }

        protected void txtF_4_3_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_2;
            if (String.IsNullOrEmpty(txtF_4_3_2.Text)) { m_F_4_3_2 = 0; } else { m_F_4_3_2 = Convert.ToDouble(txtF_4_3_2.Text); };

            if (m_F_4_3_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_2);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_3);

        }

        protected void txtF_4_3_6_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_6;
            if (String.IsNullOrEmpty(txtF_4_3_6.Text)) { m_F_4_3_6 = 0; } else { m_F_4_3_6 = Convert.ToDouble(txtF_4_3_6.Text); };

            if (m_F_4_3_6 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_6);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_7);

        }
        protected void txtF_4_3_10_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_10;
            if (String.IsNullOrEmpty(txtF_4_3_10.Text)) { m_F_4_3_10 = 0; } else { m_F_4_3_10 = Convert.ToDouble(txtF_4_3_10.Text); };

            if (m_F_4_3_10 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_10);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_11);

        }
        protected void txtF_4_3_14_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_14;
            if (String.IsNullOrEmpty(txtF_4_3_14.Text)) { m_F_4_3_14 = 0; } else { m_F_4_3_14 = Convert.ToDouble(txtF_4_3_14.Text); };
            if (m_F_4_3_14 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_14);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_15);

        }
        protected void txtF_4_3_18_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_18;
            if (String.IsNullOrEmpty(txtF_4_3_18.Text)) { m_F_4_3_18 = 0; } else { m_F_4_3_18 = Convert.ToDouble(txtF_4_3_18.Text); };
            if (m_F_4_3_18 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_18);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_19);

        }
        protected void txtF_4_3_22_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_22;
            if (String.IsNullOrEmpty(txtF_4_3_22.Text)) { m_F_4_3_22 = 0; } else { m_F_4_3_22 = Convert.ToDouble(txtF_4_3_22.Text); };
            if (m_F_4_3_22 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_22);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_23);

        }
        protected void txtF_4_3_26_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_26;
            if (String.IsNullOrEmpty(txtF_4_3_26.Text)) { m_F_4_3_26 = 0; } else { m_F_4_3_26 = Convert.ToDouble(txtF_4_3_26.Text); };
            if (m_F_4_3_26 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_26);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_27);

        }
        protected void txtF_4_3_30_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_30;
            if (String.IsNullOrEmpty(txtF_4_3_30.Text)) { m_F_4_3_30 = 0; } else { m_F_4_3_30 = Convert.ToDouble(txtF_4_3_30.Text); };
            if (m_F_4_3_30 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_30);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_31);

        }
        protected void txtF_4_3_34_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_34;
            if (String.IsNullOrEmpty(txtF_4_3_34.Text)) { m_F_4_3_34 = 0; } else { m_F_4_3_34 = Convert.ToDouble(txtF_4_3_34.Text); };
            if (m_F_4_3_34 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_34);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_35);

        }
        protected void txtF_4_3_38_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_38;
            if (String.IsNullOrEmpty(txtF_4_3_38.Text)) { m_F_4_3_38 = 0; } else { m_F_4_3_38 = Convert.ToDouble(txtF_4_3_38.Text); };
            if (m_F_4_3_38 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_38);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_39);

        }
        protected void txtF_4_3_42_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_42;
            if (String.IsNullOrEmpty(txtF_4_3_42.Text)) { m_F_4_3_42 = 0; } else { m_F_4_3_42 = Convert.ToDouble(txtF_4_3_42.Text); };
            if (m_F_4_3_42 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_42);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_43);

        }
        protected void txtF_4_3_46_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_46;
            if (String.IsNullOrEmpty(txtF_4_3_46.Text)) { m_F_4_3_46 = 0; } else { m_F_4_3_46 = Convert.ToDouble(txtF_4_3_46.Text); };
            if (m_F_4_3_46 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_46);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_47);

        }
        protected void txtF_4_3_50_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_50;
            if (String.IsNullOrEmpty(txtF_4_3_50.Text)) { m_F_4_3_50 = 0; } else { m_F_4_3_50 = Convert.ToDouble(txtF_4_3_50.Text); };
            if (m_F_4_3_50 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_50);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_51);

        }
        protected void txtF_4_3_54_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_54;
            if (String.IsNullOrEmpty(txtF_4_3_54.Text)) { m_F_4_3_54 = 0; } else { m_F_4_3_54 = Convert.ToDouble(txtF_4_3_54.Text); };
            if (m_F_4_3_54 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_54);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_55);

        }
        protected void txtF_4_3_58_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_58;
            if (String.IsNullOrEmpty(txtF_4_3_58.Text)) { m_F_4_3_58 = 0; } else { m_F_4_3_58 = Convert.ToDouble(txtF_4_3_58.Text); };
            if (m_F_4_3_58 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_58);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_59);

        }
        protected void txtF_4_3_62_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_62;
            if (String.IsNullOrEmpty(txtF_4_3_62.Text)) { m_F_4_3_62 = 0; } else { m_F_4_3_62 = Convert.ToDouble(txtF_4_3_62.Text); };
            if (m_F_4_3_62 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_62);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_63);

        }
        protected void txtF_4_3_66_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_66;
            if (String.IsNullOrEmpty(txtF_4_3_66.Text)) { m_F_4_3_66 = 0; } else { m_F_4_3_66 = Convert.ToDouble(txtF_4_3_66.Text); };
            if (m_F_4_3_66 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_66);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_67);

        }
        protected void txtF_4_3_70_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_70;
            if (String.IsNullOrEmpty(txtF_4_3_70.Text)) { m_F_4_3_70 = 0; } else { m_F_4_3_70 = Convert.ToDouble(txtF_4_3_70.Text); };
            if (m_F_4_3_70 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_70);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_71);

        }
        protected void txtF_4_3_74_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_74;
            if (String.IsNullOrEmpty(txtF_4_3_74.Text)) { m_F_4_3_74 = 0; } else { m_F_4_3_74 = Convert.ToDouble(txtF_4_3_74.Text); };
            if (m_F_4_3_74 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_74);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_75);

        }

        protected void txtF_4_3_78_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_78;
            if (String.IsNullOrEmpty(txtF_4_3_78.Text)) { m_F_4_3_78 = 0; } else { m_F_4_3_78 = Convert.ToDouble(txtF_4_3_78.Text); };
            if (m_F_4_3_78 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_78);
                return;
            }

            Calculate_F_4_3_81();

            SetFocusOnLoad(txtF_4_3_79);

        }


        protected void txtF_4_3_4_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_4;
            if (String.IsNullOrEmpty(txtF_4_3_4.Text)) { m_F_4_3_4 = 0; } else { m_F_4_3_4 = Convert.ToDouble(txtF_4_3_4.Text); };
            if (m_F_4_3_4 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_4);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_5);

        }

        protected void txtF_4_3_8_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_8;
            if (String.IsNullOrEmpty(txtF_4_3_8.Text)) { m_F_4_3_8 = 0; } else { m_F_4_3_8 = Convert.ToDouble(txtF_4_3_8.Text); };
            if (m_F_4_3_8 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_8);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_9);

        }
        protected void txtF_4_3_12_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_12;
            if (String.IsNullOrEmpty(txtF_4_3_12.Text)) { m_F_4_3_12 = 0; } else { m_F_4_3_12 = Convert.ToDouble(txtF_4_3_12.Text); };
            if (m_F_4_3_12 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_12);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_13);

        }
        protected void txtF_4_3_16_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_16;
            if (String.IsNullOrEmpty(txtF_4_3_16.Text)) { m_F_4_3_16 = 0; } else { m_F_4_3_16 = Convert.ToDouble(txtF_4_3_16.Text); };
            if (m_F_4_3_16 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_16);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_17);

        }
        protected void txtF_4_3_20_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_20;
            if (String.IsNullOrEmpty(txtF_4_3_20.Text)) { m_F_4_3_20 = 0; } else { m_F_4_3_20 = Convert.ToDouble(txtF_4_3_20.Text); };
            if (m_F_4_3_20 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_20);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_21);

        }
        protected void txtF_4_3_24_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_24;
            if (String.IsNullOrEmpty(txtF_4_3_24.Text)) { m_F_4_3_24 = 0; } else { m_F_4_3_24 = Convert.ToDouble(txtF_4_3_24.Text); };
            if (m_F_4_3_24 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_24);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_25);

        }
        protected void txtF_4_3_28_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_28;
            if (String.IsNullOrEmpty(txtF_4_3_28.Text)) { m_F_4_3_28 = 0; } else { m_F_4_3_28 = Convert.ToDouble(txtF_4_3_28.Text); };
            if (m_F_4_3_28 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_28);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_29);

        }
        protected void txtF_4_3_32_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_32;
            if (String.IsNullOrEmpty(txtF_4_3_32.Text)) { m_F_4_3_32 = 0; } else { m_F_4_3_32 = Convert.ToDouble(txtF_4_3_32.Text); };
            if (m_F_4_3_32 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_32);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_33);

        }
        protected void txtF_4_3_36_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_36;
            if (String.IsNullOrEmpty(txtF_4_3_36.Text)) { m_F_4_3_36 = 0; } else { m_F_4_3_36 = Convert.ToDouble(txtF_4_3_36.Text); };
            if (m_F_4_3_36 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_36);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_37);

        }
        protected void txtF_4_3_40_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_40;
            if (String.IsNullOrEmpty(txtF_4_3_40.Text)) { m_F_4_3_40 = 0; } else { m_F_4_3_40 = Convert.ToDouble(txtF_4_3_40.Text); };
            if (m_F_4_3_40 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_40);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_41);

        }
        protected void txtF_4_3_44_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_44;
            if (String.IsNullOrEmpty(txtF_4_3_44.Text)) { m_F_4_3_44 = 0; } else { m_F_4_3_44 = Convert.ToDouble(txtF_4_3_44.Text); };
            if (m_F_4_3_44 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_44);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_45);

        }
        protected void txtF_4_3_48_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_48;
            if (String.IsNullOrEmpty(txtF_4_3_48.Text)) { m_F_4_3_48 = 0; } else { m_F_4_3_48 = Convert.ToDouble(txtF_4_3_48.Text); };
            if (m_F_4_3_48 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_48);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_49);

        }
        protected void txtF_4_3_52_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_52;
            if (String.IsNullOrEmpty(txtF_4_3_52.Text)) { m_F_4_3_52 = 0; } else { m_F_4_3_52 = Convert.ToDouble(txtF_4_3_52.Text); };
            if (m_F_4_3_52 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_52);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_53);

        }
        protected void txtF_4_3_56_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_56;
            if (String.IsNullOrEmpty(txtF_4_3_56.Text)) { m_F_4_3_56 = 0; } else { m_F_4_3_56 = Convert.ToDouble(txtF_4_3_56.Text); };
            if (m_F_4_3_56 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_56);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_57);

        }
        protected void txtF_4_3_60_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_60;
            if (String.IsNullOrEmpty(txtF_4_3_60.Text)) { m_F_4_3_60 = 0; } else { m_F_4_3_60 = Convert.ToDouble(txtF_4_3_60.Text); };
            if (m_F_4_3_60 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_60);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_61);

        }
        protected void txtF_4_3_64_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_64;
            if (String.IsNullOrEmpty(txtF_4_3_64.Text)) { m_F_4_3_64 = 0; } else { m_F_4_3_64 = Convert.ToDouble(txtF_4_3_64.Text); };
            if (m_F_4_3_64 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_64);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_65);

        }
        protected void txtF_4_3_68_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_68;
            if (String.IsNullOrEmpty(txtF_4_3_68.Text)) { m_F_4_3_68= 0; } else { m_F_4_3_68 = Convert.ToDouble(txtF_4_3_68.Text); };
            if (m_F_4_3_68 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_68);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_69);

        }
        protected void txtF_4_3_72_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_72;
            if (String.IsNullOrEmpty(txtF_4_3_72.Text)) { m_F_4_3_72 = 0; } else { m_F_4_3_72 = Convert.ToDouble(txtF_4_3_72.Text); };
            if (m_F_4_3_72 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_72);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_73);

        }
        protected void txtF_4_3_76_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_76;
            if (String.IsNullOrEmpty(txtF_4_3_76.Text)) { m_F_4_3_76 = 0; } else { m_F_4_3_76 = Convert.ToDouble(txtF_4_3_76.Text); };
            if (m_F_4_3_76 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_76);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_77);

        }

        protected void txtF_4_3_80_TextChanged(object sender, EventArgs e)
        {
            double m_F_4_3_80;
            if (String.IsNullOrEmpty(txtF_4_3_80.Text)) { m_F_4_3_80 = 0; } else { m_F_4_3_80 = Convert.ToDouble(txtF_4_3_80.Text); };
            if (m_F_4_3_80 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_4_3_80);
                return;
            }

            Calculate_F_4_3_82();

            SetFocusOnLoad(txtF_4_3_81);

        }



        protected void txtF_3_1_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_1_1;
            if (String.IsNullOrEmpty(txtF_3_1_1.Text)) { m_F_3_1_1 = 0; } else { m_F_3_1_1 = Convert.ToDouble(txtF_3_1_1.Text); };

            if (m_F_3_1_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_1_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_1_2);

        }

        protected void txtF_3_2_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_2_1;
            if (String.IsNullOrEmpty(txtF_3_2_1.Text)) { m_F_3_2_1 = 0; } else { m_F_3_2_1 = Convert.ToDouble(txtF_3_2_1.Text); };

            if (m_F_3_2_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_2_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_2_2);

        }
        protected void txtF_3_3_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_3_1;
            if (String.IsNullOrEmpty(txtF_3_3_1.Text)) { m_F_3_3_1 = 0; } else { m_F_3_3_1 = Convert.ToDouble(txtF_3_3_1.Text); };

            if (m_F_3_3_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_3_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_3_2);

        }
        protected void txtF_3_4_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_4_1;
            if (String.IsNullOrEmpty(txtF_3_4_1.Text)) { m_F_3_4_1 = 0; } else { m_F_3_4_1 = Convert.ToDouble(txtF_3_4_1.Text); };

            if (m_F_3_4_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_4_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_4_2);

        }
        protected void txtF_3_5_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_5_1;
            if (String.IsNullOrEmpty(txtF_3_5_1.Text)) { m_F_3_5_1 = 0; } else { m_F_3_5_1 = Convert.ToDouble(txtF_3_5_1.Text); };

            if (m_F_3_5_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_5_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_5_2);

        }
        protected void txtF_3_6_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_6_1;
            if (String.IsNullOrEmpty(txtF_3_6_1.Text)) { m_F_3_6_1 = 0; } else { m_F_3_6_1 = Convert.ToDouble(txtF_3_6_1.Text); };

            if (m_F_3_6_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_6_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_6_2);

        }
        protected void txtF_3_7_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_7_1;
            if (String.IsNullOrEmpty(txtF_3_7_1.Text)) { m_F_3_7_1 = 0; } else { m_F_3_7_1 = Convert.ToDouble(txtF_3_7_1.Text); };

            if (m_F_3_7_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_7_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_7_2);

        }
        protected void txtF_3_8_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_8_1;
            if (String.IsNullOrEmpty(txtF_3_8_1.Text)) { m_F_3_8_1 = 0; } else { m_F_3_8_1 = Convert.ToDouble(txtF_3_8_1.Text); };

            if (m_F_3_8_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_8_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_8_2);

        }
        protected void txtF_3_9_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_9_1;
            if (String.IsNullOrEmpty(txtF_3_9_1.Text)) { m_F_3_9_1 = 0; } else { m_F_3_9_1 = Convert.ToDouble(txtF_3_9_1.Text); };

            if (m_F_3_9_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_9_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_9_2);

        }
        protected void txtF_3_10_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_10_1;
            if (String.IsNullOrEmpty(txtF_3_10_1.Text)) { m_F_3_10_1 = 0; } else { m_F_3_10_1 = Convert.ToDouble(txtF_3_10_1.Text); };

            if (m_F_3_10_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_10_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_10_2);

        }
        protected void txtF_3_11_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_11_1;
            if (String.IsNullOrEmpty(txtF_3_11_1.Text)) { m_F_3_11_1 = 0; } else { m_F_3_11_1 = Convert.ToDouble(txtF_3_11_1.Text); };

            if (m_F_3_11_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_11_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_11_2);

        }
        protected void txtF_3_12_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_12_1;
            if (String.IsNullOrEmpty(txtF_3_12_1.Text)) { m_F_3_12_1 = 0; } else { m_F_3_12_1 = Convert.ToDouble(txtF_3_12_1.Text); };

            if (m_F_3_12_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_12_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_12_2);

        }
        protected void txtF_3_13_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_13_1;
            if (String.IsNullOrEmpty(txtF_3_13_1.Text)) { m_F_3_13_1 = 0; } else { m_F_3_13_1 = Convert.ToDouble(txtF_3_13_1.Text); };

            if (m_F_3_13_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_13_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_13_2);

        }
        protected void txtF_3_14_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_14_1;
            if (String.IsNullOrEmpty(txtF_3_14_1.Text)) { m_F_3_14_1 = 0; } else { m_F_3_14_1 = Convert.ToDouble(txtF_3_14_1.Text); };

            if (m_F_3_14_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_14_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_14_2);

        }
        protected void txtF_3_15_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_15_1;
            if (String.IsNullOrEmpty(txtF_3_15_1.Text)) { m_F_3_15_1 = 0; } else { m_F_3_15_1 = Convert.ToDouble(txtF_3_15_1.Text); };

            if (m_F_3_15_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_15_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_15_2);

        }
        protected void txtF_3_16_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_16_1;
            if (String.IsNullOrEmpty(txtF_3_16_1.Text)) { m_F_3_16_1 = 0; } else { m_F_3_16_1 = Convert.ToDouble(txtF_3_16_1.Text); };

            if (m_F_3_16_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_16_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_16_2);

        }
        protected void txtF_3_17_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_17_1;
            if (String.IsNullOrEmpty(txtF_3_17_1.Text)) { m_F_3_17_1 = 0; } else { m_F_3_17_1 = Convert.ToDouble(txtF_3_17_1.Text); };

            if (m_F_3_17_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_17_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_17_2);

        }
        protected void txtF_3_18_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_18_1;
            if (String.IsNullOrEmpty(txtF_3_18_1.Text)) { m_F_3_18_1 = 0; } else { m_F_3_18_1 = Convert.ToDouble(txtF_3_18_1.Text); };

            if (m_F_3_18_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_18_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_18_2);

        }
        protected void txtF_3_19_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_19_1;
            if (String.IsNullOrEmpty(txtF_3_19_1.Text)) { m_F_3_19_1 = 0; } else { m_F_3_19_1 = Convert.ToDouble(txtF_3_19_1.Text); };

            if (m_F_3_19_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_19_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_19_2);

        }
        protected void txtF_3_20_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_20_1;
            if (String.IsNullOrEmpty(txtF_3_20_1.Text)) { m_F_3_20_1 = 0; } else { m_F_3_20_1 = Convert.ToDouble(txtF_3_20_1.Text); };

            if (m_F_3_20_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_20_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_20_2);

        }
        protected void txtF_3_21_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_21_1;
            if (String.IsNullOrEmpty(txtF_3_21_1.Text)) { m_F_3_21_1 = 0; } else { m_F_3_21_1 = Convert.ToDouble(txtF_3_21_1.Text); };

            if (m_F_3_21_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_21_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_21_2);

        }
        protected void txtF_3_22_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_22_1;
            if (String.IsNullOrEmpty(txtF_3_22_1.Text)) { m_F_3_22_1 = 0; } else { m_F_3_22_1 = Convert.ToDouble(txtF_3_22_1.Text); };

            if (m_F_3_22_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_22_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_22_2);

        }
        protected void txtF_3_23_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_23_1;
            if (String.IsNullOrEmpty(txtF_3_23_1.Text)) { m_F_3_23_1 = 0; } else { m_F_3_23_1 = Convert.ToDouble(txtF_3_23_1.Text); };

            if (m_F_3_23_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_23_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_23_2);

        }
        protected void txtF_3_24_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_24_1;
            if (String.IsNullOrEmpty(txtF_3_24_1.Text)) { m_F_3_24_1 = 0; } else { m_F_3_24_1 = Convert.ToDouble(txtF_3_24_1.Text); };

            if (m_F_3_24_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_24_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_24_2);

        }
        protected void txtF_3_25_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_25_1;
            if (String.IsNullOrEmpty(txtF_3_25_1.Text)) { m_F_3_25_1 = 0; } else { m_F_3_25_1 = Convert.ToDouble(txtF_3_25_1.Text); };

            if (m_F_3_25_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_25_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_25_2);

        }
        protected void txtF_3_26_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_26_1;
            if (String.IsNullOrEmpty(txtF_3_26_1.Text)) { m_F_3_26_1 = 0; } else { m_F_3_26_1 = Convert.ToDouble(txtF_3_26_1.Text); };

            if (m_F_3_26_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_26_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_26_2);

        }
        protected void txtF_3_27_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_27_1;
            if (String.IsNullOrEmpty(txtF_3_27_1.Text)) { m_F_3_27_1 = 0; } else { m_F_3_27_1 = Convert.ToDouble(txtF_3_27_1.Text); };

            if (m_F_3_27_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_27_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_27_2);

        }
        protected void txtF_3_28_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_28_1;
            if (String.IsNullOrEmpty(txtF_3_28_1.Text)) { m_F_3_28_1 = 0; } else { m_F_3_28_1 = Convert.ToDouble(txtF_3_28_1.Text); };

            if (m_F_3_28_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_28_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_28_2);

        }
        protected void txtF_3_29_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_29_1;
            if (String.IsNullOrEmpty(txtF_3_29_1.Text)) { m_F_3_29_1 = 0; } else { m_F_3_29_1 = Convert.ToDouble(txtF_3_29_1.Text); };

            if (m_F_3_29_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_29_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_29_2);

        }
        protected void txtF_3_30_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_30_1;
            if (String.IsNullOrEmpty(txtF_3_30_1.Text)) { m_F_3_30_1 = 0; } else { m_F_3_30_1 = Convert.ToDouble(txtF_3_30_1.Text); };

            if (m_F_3_30_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_30_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_30_2);

        }
        protected void txtF_3_31_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_31_1;
            if (String.IsNullOrEmpty(txtF_3_31_1.Text)) { m_F_3_31_1 = 0; } else { m_F_3_31_1 = Convert.ToDouble(txtF_3_31_1.Text); };

            if (m_F_3_31_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_31_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_31_2);

        }
        protected void txtF_3_32_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_32_1;
            if (String.IsNullOrEmpty(txtF_3_32_1.Text)) { m_F_3_32_1 = 0; } else { m_F_3_32_1 = Convert.ToDouble(txtF_3_32_1.Text); };

            if (m_F_3_32_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_32_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_32_2);

        }
        protected void txtF_3_33_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_33_1;
            if (String.IsNullOrEmpty(txtF_3_33_1.Text)) { m_F_3_33_1 = 0; } else { m_F_3_33_1 = Convert.ToDouble(txtF_3_33_1.Text); };

            if (m_F_3_33_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_33_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_33_2);

        }
        protected void txtF_3_34_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_34_1;
            if (String.IsNullOrEmpty(txtF_3_34_1.Text)) { m_F_3_34_1 = 0; } else { m_F_3_34_1 = Convert.ToDouble(txtF_3_34_1.Text); };

            if (m_F_3_34_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_34_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_34_2);

        }
        protected void txtF_3_35_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_35_1;
            if (String.IsNullOrEmpty(txtF_3_35_1.Text)) { m_F_3_35_1 = 0; } else { m_F_3_35_1 = Convert.ToDouble(txtF_3_35_1.Text); };

            if (m_F_3_35_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_35_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_35_2);

        }
        protected void txtF_3_36_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_36_1;
            if (String.IsNullOrEmpty(txtF_3_36_1.Text)) { m_F_3_36_1 = 0; } else { m_F_3_36_1 = Convert.ToDouble(txtF_3_36_1.Text); };

            if (m_F_3_36_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_36_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_36_2);

        }
        protected void txtF_3_37_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_37_1;
            if (String.IsNullOrEmpty(txtF_3_37_1.Text)) { m_F_3_37_1 = 0; } else { m_F_3_37_1 = Convert.ToDouble(txtF_3_37_1.Text); };

            if (m_F_3_37_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_37_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_37_2);

        }
        protected void txtF_3_38_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_38_1;
            if (String.IsNullOrEmpty(txtF_3_38_1.Text)) { m_F_3_38_1 = 0; } else { m_F_3_38_1 = Convert.ToDouble(txtF_3_38_1.Text); };

            if (m_F_3_38_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_38_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_38_2);

        }
        protected void txtF_3_39_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_39_1;
            if (String.IsNullOrEmpty(txtF_3_39_1.Text)) { m_F_3_39_1 = 0; } else { m_F_3_39_1 = Convert.ToDouble(txtF_3_39_1.Text); };

            if (m_F_3_39_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_39_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_39_2);

        }
        protected void txtF_3_40_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_40_1;
            if (String.IsNullOrEmpty(txtF_3_40_1.Text)) { m_F_3_40_1 = 0; } else { m_F_3_40_1 = Convert.ToDouble(txtF_3_40_1.Text); };

            if (m_F_3_40_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_40_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_40_2);

        }
        protected void txtF_3_41_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_41_1;
            if (String.IsNullOrEmpty(txtF_3_41_1.Text)) { m_F_3_41_1 = 0; } else { m_F_3_41_1 = Convert.ToDouble(txtF_3_41_1.Text); };

            if (m_F_3_41_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_41_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_41_2);

        }
        protected void txtF_3_42_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_42_1;
            if (String.IsNullOrEmpty(txtF_3_42_1.Text)) { m_F_3_42_1 = 0; } else { m_F_3_42_1 = Convert.ToDouble(txtF_3_42_1.Text); };

            if (m_F_3_42_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_42_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_42_2);

        }
        protected void txtF_3_43_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_43_1;
            if (String.IsNullOrEmpty(txtF_3_43_1.Text)) { m_F_3_43_1 = 0; } else { m_F_3_43_1 = Convert.ToDouble(txtF_3_43_1.Text); };

            if (m_F_3_43_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_43_1);
                return;
            }

            Calculate_F_3_1_43();

            SetFocusOnLoad(txtF_3_43_2);

        }

        protected void txtF_3_1_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_1_2;
            if (String.IsNullOrEmpty(txtF_3_1_2.Text)) { m_F_3_1_2 = 0; } else { m_F_3_1_2 = Convert.ToDouble(txtF_3_1_2.Text); };

            if (m_F_3_1_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_1_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_2_1);

        }

        protected void txtF_3_2_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_2_2;
            if (String.IsNullOrEmpty(txtF_3_2_2.Text)) { m_F_3_2_2 = 0; } else { m_F_3_2_2 = Convert.ToDouble(txtF_3_2_2.Text); };


            if (m_F_3_2_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_2_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_3_1);

        }
        protected void txtF_3_3_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_3_2;
            if (String.IsNullOrEmpty(txtF_3_3_2.Text)) { m_F_3_3_2 = 0; } else { m_F_3_3_2 = Convert.ToDouble(txtF_3_3_2.Text); };


            if (m_F_3_3_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_3_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_4_1);

        }
        protected void txtF_3_4_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_4_2;
            if (String.IsNullOrEmpty(txtF_3_4_2.Text)) { m_F_3_4_2 = 0; } else { m_F_3_4_2 = Convert.ToDouble(txtF_3_4_2.Text); };


            if (m_F_3_4_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_4_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_5_1);

        }
        protected void txtF_3_5_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_5_2;
            if (String.IsNullOrEmpty(txtF_3_5_2.Text)) { m_F_3_5_2 = 0; } else { m_F_3_5_2 = Convert.ToDouble(txtF_3_5_2.Text); };


            if (m_F_3_5_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_5_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_6_1);

        }
        protected void txtF_3_6_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_6_2;
            if (String.IsNullOrEmpty(txtF_3_6_2.Text)) { m_F_3_6_2 = 0; } else { m_F_3_6_2 = Convert.ToDouble(txtF_3_6_2.Text); };


            if (m_F_3_6_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_6_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_7_1);

        }
        protected void txtF_3_7_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_7_2;
            if (String.IsNullOrEmpty(txtF_3_7_2.Text)) { m_F_3_7_2 = 0; } else { m_F_3_7_2 = Convert.ToDouble(txtF_3_7_2.Text); };
            
            if (m_F_3_7_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_7_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_8_1);

        }
        protected void txtF_3_8_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_8_2;
            if (String.IsNullOrEmpty(txtF_3_8_2.Text)) { m_F_3_8_2 = 0; } else { m_F_3_8_2 = Convert.ToDouble(txtF_3_8_2.Text); };

            if (m_F_3_8_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_8_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_9_1);

        }
        protected void txtF_3_9_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_9_2;
            if (String.IsNullOrEmpty(txtF_3_9_2.Text)) { m_F_3_9_2 = 0; } else { m_F_3_9_2 = Convert.ToDouble(txtF_3_9_2.Text); };

            if (m_F_3_9_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_9_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_10_1);

        }
        protected void txtF_3_10_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_10_2;
            if (String.IsNullOrEmpty(txtF_3_10_2.Text)) { m_F_3_10_2 = 0; } else { m_F_3_10_2 = Convert.ToDouble(txtF_3_10_2.Text); };

            if (m_F_3_10_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_10_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_11_1);

        }
        protected void txtF_3_11_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_11_2;
            if (String.IsNullOrEmpty(txtF_3_11_2.Text)) { m_F_3_11_2 = 0; } else { m_F_3_11_2 = Convert.ToDouble(txtF_3_11_2.Text); };

            if (m_F_3_11_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_11_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_12_1);

        }
        protected void txtF_3_12_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_12_2;
            if (String.IsNullOrEmpty(txtF_3_12_2.Text)) { m_F_3_12_2 = 0; } else { m_F_3_12_2 = Convert.ToDouble(txtF_3_12_2.Text); };

            if (m_F_3_12_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_12_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_13_1);

        }
        protected void txtF_3_13_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_13_2;
            if (String.IsNullOrEmpty(txtF_3_13_2.Text)) { m_F_3_13_2 = 0; } else { m_F_3_13_2 = Convert.ToDouble(txtF_3_13_2.Text); };

            if (m_F_3_13_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_13_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_14_1);

        }
        protected void txtF_3_14_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_14_2;
            if (String.IsNullOrEmpty(txtF_3_14_2.Text)) { m_F_3_14_2 = 0; } else { m_F_3_14_2 = Convert.ToDouble(txtF_3_14_2.Text); };

            if (m_F_3_14_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_14_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_15_1);

        }
        protected void txtF_3_15_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_15_2;
            if (String.IsNullOrEmpty(txtF_3_15_2.Text)) { m_F_3_15_2 = 0; } else { m_F_3_15_2 = Convert.ToDouble(txtF_3_15_2.Text); };

            if (m_F_3_15_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_15_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_16_1);

        }
        protected void txtF_3_16_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_16_2;
            if (String.IsNullOrEmpty(txtF_3_16_2.Text)) { m_F_3_16_2 = 0; } else { m_F_3_16_2 = Convert.ToDouble(txtF_3_16_2.Text); };

            if (m_F_3_16_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_16_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_17_1);

        }
        protected void txtF_3_17_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_17_2;
            if (String.IsNullOrEmpty(txtF_3_17_2.Text)) { m_F_3_17_2 = 0; } else { m_F_3_17_2 = Convert.ToDouble(txtF_3_17_2.Text); };

            if (m_F_3_17_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_17_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_18_1);

        }
        protected void txtF_3_18_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_18_2;
            if (String.IsNullOrEmpty(txtF_3_18_2.Text)) { m_F_3_18_2 = 0; } else { m_F_3_18_2 = Convert.ToDouble(txtF_3_18_2.Text); };

            if (m_F_3_18_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_18_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_19_1);

        }
        protected void txtF_3_19_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_19_2;
            if (String.IsNullOrEmpty(txtF_3_19_2.Text)) { m_F_3_19_2 = 0; } else { m_F_3_19_2 = Convert.ToDouble(txtF_3_19_2.Text); };

            if (m_F_3_19_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_19_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_20_1);

        }
        protected void txtF_3_20_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_20_2;
            if (String.IsNullOrEmpty(txtF_3_20_2.Text)) { m_F_3_20_2 = 0; } else { m_F_3_20_2 = Convert.ToDouble(txtF_3_20_2.Text); };

            if (m_F_3_20_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_20_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_21_1);

        }
        protected void txtF_3_21_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_21_2;
            if (String.IsNullOrEmpty(txtF_3_21_2.Text)) { m_F_3_21_2 = 0; } else { m_F_3_21_2 = Convert.ToDouble(txtF_3_21_2.Text); };

            if (m_F_3_21_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_21_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_22_1);

        }
        protected void txtF_3_22_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_22_2;
            if (String.IsNullOrEmpty(txtF_3_22_2.Text)) { m_F_3_22_2 = 0; } else { m_F_3_22_2 = Convert.ToDouble(txtF_3_22_2.Text); };

            if (m_F_3_22_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_22_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_23_1);

        }
        protected void txtF_3_23_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_23_2;
            if (String.IsNullOrEmpty(txtF_3_23_2.Text)) { m_F_3_23_2 = 0; } else { m_F_3_23_2 = Convert.ToDouble(txtF_3_23_2.Text); };

            if (m_F_3_23_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_23_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_24_1);

        }
        protected void txtF_3_24_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_24_2;
            if (String.IsNullOrEmpty(txtF_3_24_2.Text)) { m_F_3_24_2 = 0; } else { m_F_3_24_2 = Convert.ToDouble(txtF_3_24_2.Text); };

            if (m_F_3_24_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_24_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_25_1);

        }
        protected void txtF_3_25_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_25_2;
            if (String.IsNullOrEmpty(txtF_3_25_2.Text)) { m_F_3_25_2 = 0; } else { m_F_3_25_2 = Convert.ToDouble(txtF_3_25_2.Text); };

            if (m_F_3_25_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_25_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_26_1);

        }
        protected void txtF_3_26_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_26_2;
            if (String.IsNullOrEmpty(txtF_3_26_2.Text)) { m_F_3_26_2 = 0; } else { m_F_3_26_2 = Convert.ToDouble(txtF_3_26_2.Text); };

            if (m_F_3_26_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_26_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_27_1);

        }
        protected void txtF_3_27_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_27_2;
            if (String.IsNullOrEmpty(txtF_3_27_2.Text)) { m_F_3_27_2 = 0; } else { m_F_3_27_2 = Convert.ToDouble(txtF_3_27_2.Text); };

            if (m_F_3_27_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_27_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_28_1);

        }
        protected void txtF_3_28_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_28_2;
            if (String.IsNullOrEmpty(txtF_3_28_2.Text)) { m_F_3_28_2 = 0; } else { m_F_3_28_2 = Convert.ToDouble(txtF_3_28_2.Text); };

            if (m_F_3_28_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_28_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_29_1);

        }
        protected void txtF_3_29_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_29_2;
            if (String.IsNullOrEmpty(txtF_3_29_2.Text)) { m_F_3_29_2 = 0; } else { m_F_3_29_2 = Convert.ToDouble(txtF_3_29_2.Text); };

            if (m_F_3_29_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_29_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_30_1);

        }
        protected void txtF_3_30_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_30_2;
            if (String.IsNullOrEmpty(txtF_3_30_2.Text)) { m_F_3_30_2 = 0; } else { m_F_3_30_2 = Convert.ToDouble(txtF_3_30_2.Text); };

            if (m_F_3_30_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_30_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_31_1);

        }
        protected void txtF_3_31_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_31_2;
            if (String.IsNullOrEmpty(txtF_3_31_2.Text)) { m_F_3_31_2 = 0; } else { m_F_3_31_2 = Convert.ToDouble(txtF_3_31_2.Text); };

            if (m_F_3_31_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_31_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_32_1);

        }
        protected void txtF_3_32_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_32_2;
            if (String.IsNullOrEmpty(txtF_3_32_2.Text)) { m_F_3_32_2 = 0; } else { m_F_3_32_2 = Convert.ToDouble(txtF_3_32_2.Text); };

            if (m_F_3_32_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_32_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_33_1);

        }
        protected void txtF_3_33_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_33_2;
            if (String.IsNullOrEmpty(txtF_3_33_2.Text)) { m_F_3_33_2 = 0; } else { m_F_3_33_2 = Convert.ToDouble(txtF_3_33_2.Text); };

            if (m_F_3_33_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_33_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_34_1);

        }
        protected void txtF_3_34_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_34_2;
            if (String.IsNullOrEmpty(txtF_3_34_2.Text)) { m_F_3_34_2 = 0; } else { m_F_3_34_2 = Convert.ToDouble(txtF_3_34_2.Text); };

            if (m_F_3_34_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_34_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_35_1);

        }
        protected void txtF_3_35_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_35_2;
            if (String.IsNullOrEmpty(txtF_3_35_2.Text)) { m_F_3_35_2 = 0; } else { m_F_3_35_2 = Convert.ToDouble(txtF_3_35_2.Text); };

            if (m_F_3_35_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_35_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_36_1);

        }
        protected void txtF_3_36_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_36_2;
            if (String.IsNullOrEmpty(txtF_3_36_2.Text)) { m_F_3_36_2 = 0; } else { m_F_3_36_2 = Convert.ToDouble(txtF_3_36_2.Text); };

            if (m_F_3_36_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_36_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_37_1);

        }
        protected void txtF_3_37_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_37_2;
            if (String.IsNullOrEmpty(txtF_3_37_2.Text)) { m_F_3_37_2 = 0; } else { m_F_3_37_2 = Convert.ToDouble(txtF_3_37_2.Text); };

            if (m_F_3_37_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_37_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_38_1);

        }
        protected void txtF_3_38_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_38_2;
            if (String.IsNullOrEmpty(txtF_3_38_2.Text)) { m_F_3_38_2 = 0; } else { m_F_3_38_2 = Convert.ToDouble(txtF_3_38_2.Text); };

            if (m_F_3_38_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_38_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_39_1);

        }
        protected void txtF_3_39_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_39_2;
            if (String.IsNullOrEmpty(txtF_3_39_2.Text)) { m_F_3_39_2 = 0; } else { m_F_3_39_2 = Convert.ToDouble(txtF_3_39_2.Text); };

            if (m_F_3_39_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_39_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_40_1);

        }
        protected void txtF_3_40_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_40_2;
            if (String.IsNullOrEmpty(txtF_3_40_2.Text)) { m_F_3_40_2 = 0; } else { m_F_3_40_2 = Convert.ToDouble(txtF_3_40_2.Text); };

            if (m_F_3_40_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_40_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_41_1);

        }
        protected void txtF_3_41_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_41_2;
            if (String.IsNullOrEmpty(txtF_3_41_2.Text)) { m_F_3_41_2 = 0; } else { m_F_3_41_2 = Convert.ToDouble(txtF_3_41_2.Text); };

            if (m_F_3_41_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_41_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_42_1);

        }
        protected void txtF_3_42_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_42_2;
            if (String.IsNullOrEmpty(txtF_3_42_2.Text)) { m_F_3_42_2 = 0; } else { m_F_3_42_2 = Convert.ToDouble(txtF_3_42_2.Text); };

            if (m_F_3_42_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_42_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_43_1);

        }
        protected void txtF_3_43_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_3_43_2;
            if (String.IsNullOrEmpty(txtF_3_43_2.Text)) { m_F_3_43_2 = 0; } else { m_F_3_43_2 = Convert.ToDouble(txtF_3_43_2.Text); };

            if (m_F_3_43_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_3_43_2);
                return;
            }

            Calculate_F_3_2_43();

            SetFocusOnLoad(txtF_3_44_1);

        }

        protected void Calculate_F_2()
        {

            double F_2_1;
            double F_2_2;
            double F_2_3;
            double F_2_4;
            double F_2_5;
            double F_2_6;
            double F_2_7;
            double F_2_8;
            double F_2_18;
            
            if (String.IsNullOrEmpty(txtF_2_1.Text)) { F_2_1 = 0; } else { F_2_1 = Convert.ToDouble(txtF_2_1.Text); };
            if (String.IsNullOrEmpty(txtF_2_2.Text)) { F_2_2 = 0; } else { F_2_2 = Convert.ToDouble(txtF_2_2.Text); };
            if (String.IsNullOrEmpty(txtF_2_3.Text)) { F_2_3 = 0; } else { F_2_3 = Convert.ToDouble(txtF_2_3.Text); };
            if (String.IsNullOrEmpty(txtF_2_4.Text)) { F_2_4 = 0; } else { F_2_4 = Convert.ToDouble(txtF_2_4.Text); };
            if (String.IsNullOrEmpty(txtF_2_5.Text)) { F_2_5 = 0; } else { F_2_5 = Convert.ToDouble(txtF_2_5.Text); };
            if (String.IsNullOrEmpty(txtF_2_6.Text)) { F_2_6 = 0; } else { F_2_6 = Convert.ToDouble(txtF_2_6.Text); };
            if (String.IsNullOrEmpty(txtF_2_7.Text)) { F_2_7 = 0; } else { F_2_7 = Convert.ToDouble(txtF_2_7.Text); };
            if (String.IsNullOrEmpty(txtF_2_8.Text)) { F_2_8 = 0; } else { F_2_8 = Convert.ToDouble(txtF_2_8.Text); };

            double F_2_9 = F_2_1 + F_2_2 + F_2_3 + F_2_4 + F_2_5 + F_2_6 + F_2_7 + F_2_8;

            if (String.IsNullOrEmpty(txtF_2_18.Text)) { F_2_18 = 0; } else { F_2_18 = Convert.ToDouble(txtF_2_18.Text); };

            double F_2_20 = F_2_9 - F_2_18;
            txtF_2_20.Text = F_2_20.ToString();
            txtF_2_9.Text = F_2_9.ToString();

        }





            protected void txtF_2_1_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_1;
            if (String.IsNullOrEmpty(txtF_2_1.Text)) { m_F_2_1 = 0; } else { m_F_2_1 = Convert.ToDouble(txtF_2_1.Text); };

            if (m_F_2_1 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_1);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_2);

        }

        protected void txtF_2_2_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_2;
            if (String.IsNullOrEmpty(txtF_2_2.Text)) { m_F_2_2 = 0; } else { m_F_2_2 = Convert.ToDouble(txtF_2_2.Text); };

            if (m_F_2_2 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_2);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_3);

        }


        protected void txtF_2_3_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_3;
            if (String.IsNullOrEmpty(txtF_2_3.Text)) { m_F_2_3 = 0; } else { m_F_2_3 = Convert.ToDouble(txtF_2_3.Text); };

            if (m_F_2_3 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_3);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_4);

        }

        protected void txtF_2_4_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_4;
            if (String.IsNullOrEmpty(txtF_2_4.Text)) { m_F_2_4 = 0; } else { m_F_2_4 = Convert.ToDouble(txtF_2_4.Text); };

            if (m_F_2_4 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_4);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_5);

        }

        protected void txtF_2_5_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_5;
            if (String.IsNullOrEmpty(txtF_2_5.Text)) { m_F_2_5 = 0; } else { m_F_2_5 = Convert.ToDouble(txtF_2_5.Text); };

            if (m_F_2_5 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_5);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_6);

        }

        protected void txtF_2_6_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_6;
            if (String.IsNullOrEmpty(txtF_2_6.Text)) { m_F_2_6 = 0; } else { m_F_2_6 = Convert.ToDouble(txtF_2_6.Text); };

            if (m_F_2_6 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_6);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_7);

        }

        protected void txtF_2_7_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_7;
            if (String.IsNullOrEmpty(txtF_2_7.Text)) { m_F_2_7 = 0; } else { m_F_2_7 = Convert.ToDouble(txtF_2_7.Text); };

            if (m_F_2_7 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_7);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_8);

        }

        protected void txtF_2_8_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_8;
            if (String.IsNullOrEmpty(txtF_2_8.Text)) { m_F_2_8 = 0; } else { m_F_2_8 = Convert.ToDouble(txtF_2_8.Text); };

            if (m_F_2_8 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_8);
                return;
            }

            Calculate_F_2();

            SetFocusOnLoad(txtF_2_9);

        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                
                if (c < '0' || c > '9' )
                    return false;
            }

            return true;
        }

        decimal ConvertStringToDecimal(string decimalString, decimal defaultReturnValue)
        {
            decimal result;
            if (decimal.TryParse(decimalString.Trim(), out result))
            {
                return result;
            }

            return defaultReturnValue;
        }

        protected void Calculate_F_2_2()
        {

            double F_2_10;
            double F_2_11;
            double F_2_12;
            double F_2_13;
            double F_2_14;
            double F_2_15;
            double F_2_16;
            double F_2_17;
            double F_2_18;
            double F_2_20;
            double F_2_9;

            if (String.IsNullOrEmpty(txtF_2_10.Text)) { F_2_10 = 0; } else { F_2_10 = Convert.ToDouble(txtF_2_10.Text); };
            if (String.IsNullOrEmpty(txtF_2_11.Text)) { F_2_11 = 0; } else { F_2_11 = Convert.ToDouble(txtF_2_11.Text); };
            if (String.IsNullOrEmpty(txtF_2_12.Text)) { F_2_12 = 0; } else { F_2_12 = Convert.ToDouble(txtF_2_12.Text); };
            if (String.IsNullOrEmpty(txtF_2_13.Text)) { F_2_13 = 0; } else { F_2_13 = Convert.ToDouble(txtF_2_13.Text); };
            if (String.IsNullOrEmpty(txtF_2_14.Text)) { F_2_14 = 0; } else { F_2_14 = Convert.ToDouble(txtF_2_14.Text); };
            if (String.IsNullOrEmpty(txtF_2_15.Text)) { F_2_15 = 0; } else { F_2_15 = Convert.ToDouble(txtF_2_15.Text); };
            if (String.IsNullOrEmpty(txtF_2_16.Text)) { F_2_16 = 0; } else { F_2_16 = Convert.ToDouble(txtF_2_16.Text); };
            if (String.IsNullOrEmpty(txtF_2_17.Text)) { F_2_17 = 0; } else { F_2_17 = Convert.ToDouble(txtF_2_17.Text); };
                       
            F_2_18 = F_2_10 + F_2_11 + F_2_12 + F_2_13 + F_2_14 + F_2_15 + F_2_16 + F_2_17;

            if (String.IsNullOrEmpty(txtF_2_9.Text)) { F_2_9 = 0; } else { F_2_9 = Convert.ToDouble(txtF_2_9.Text); };

            F_2_9 = Convert.ToDouble(txtF_2_9.Text);
            F_2_20 = F_2_9 - F_2_18;

            txtF_2_20.Text = F_2_20.ToString();
            txtF_2_18.Text = F_2_18.ToString();
        }





        protected void txtF_2_10_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_10;
            if (String.IsNullOrEmpty(txtF_2_10.Text)) { m_F_2_10 = 0; } else { m_F_2_10 = Convert.ToDouble(txtF_2_10.Text); };

            if (m_F_2_10 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers") ;
                SetFocusOnLoad(txtF_2_10);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_11);

        }

        protected void txtF_2_11_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_11;
            if (String.IsNullOrEmpty(txtF_2_11.Text)) { m_F_2_11 = 0; } else { m_F_2_11 = Convert.ToDouble(txtF_2_11.Text); };
            
            if (m_F_2_11 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_11);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_12);

        }

        protected void txtF_2_12_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_12;
            if (String.IsNullOrEmpty(txtF_2_12.Text)) { m_F_2_12 = 0; } else { m_F_2_12 = Convert.ToDouble(txtF_2_12.Text); };

            if (m_F_2_12 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_12);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_13);

        }

        protected void txtF_2_13_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_13;
            if (String.IsNullOrEmpty(txtF_2_13.Text)) { m_F_2_13 = 0; } else { m_F_2_13 = Convert.ToDouble(txtF_2_13.Text); };

            if (m_F_2_13 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_13);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_14);

        }

        protected void txtF_2_14_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_14;
            if (String.IsNullOrEmpty(txtF_2_14.Text)) { m_F_2_14 = 0; } else { m_F_2_14= Convert.ToDouble(txtF_2_14.Text); };

            if (m_F_2_14 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_14);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_15);

        }

        protected void txtF_2_15_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_15;
            if (String.IsNullOrEmpty(txtF_2_15.Text)) { m_F_2_15 = 0; } else { m_F_2_15 = Convert.ToDouble(txtF_2_15.Text); };

            if (m_F_2_15 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_15);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_16);

        }

        protected void txtF_2_16_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_16;
            if (String.IsNullOrEmpty(txtF_2_16.Text)) { m_F_2_16 = 0; } else { m_F_2_16 = Convert.ToDouble(txtF_2_16.Text); };

            if (m_F_2_16 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_16);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_17);

        }

        protected void txtF_2_17_TextChanged(object sender, EventArgs e)
        {
            double m_F_2_17;
            if (String.IsNullOrEmpty(txtF_2_17.Text)) { m_F_2_17 = 0; } else { m_F_2_17 = Convert.ToDouble(txtF_2_17.Text); };

            if (m_F_2_17 < 0)
            {
                WebMsgBox.Show("Enter only positive numbers");
                SetFocusOnLoad(txtF_2_17);
                return;
            }

            Calculate_F_2_2();

            SetFocusOnLoad(txtF_2_18);

        }





        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", Justification = "Assembly is not localized")]
        public static void SetFocusOnLoad(Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control", "Control cannot be null!");
            }

            string script =
                "(function() { " +
                    "var fn = function() { " +
                        "var control = $get('" + control.ClientID + "'); " +
                        "if (control && control.focus) { control.focus(); } " +
                        "Sys.Application.remove_load(fn);" +
                    "};" +
                    "Sys.Application.add_load(fn);" +
                "})();";
            ScriptManager.RegisterStartupScript(control.Page, control.GetType(),
                control.ClientID + "_SetFocusOnLoad", script, true);
        }
    }
}
