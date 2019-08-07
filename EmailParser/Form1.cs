using EAGetMail;
using EmailParser.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace EmailParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvEmailHeaders.AutoGenerateColumns = false;
        }

        private void btnReceiveEmail_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Email Address and password!");
                return;
            }

            dgvEmailHeaders.Columns.Clear();

            DataGridViewTextBoxColumn columnSubject = new DataGridViewTextBoxColumn();
            columnSubject.HeaderText = "Subject";
            columnSubject.DataPropertyName = "Subject";
            columnSubject.Width = 600;
            dgvEmailHeaders.Columns.Add(columnSubject);

            DataGridViewTextBoxColumn columnReceivedDate = new DataGridViewTextBoxColumn();
            columnReceivedDate.HeaderText = "Received";
            columnReceivedDate.DataPropertyName = "ReceivedDateTime";
            dgvEmailHeaders.Columns.Add(columnReceivedDate);

            DataGridViewTextBoxColumn columnFrom = new DataGridViewTextBoxColumn();
            columnFrom.HeaderText = "From";
            columnFrom.DataPropertyName = "From";
            columnFrom.Width = 260;
            dgvEmailHeaders.Columns.Add(columnFrom);

            DataGridViewButtonColumn columnCommand = new DataGridViewButtonColumn();
            columnCommand.HeaderText = "Retrieve Detail";
            columnCommand.Name = "ColumnCommand";
            columnCommand.Text = "Detail";
            columnCommand.UseColumnTextForButtonValue = true;
            dgvEmailHeaders.Columns.Add(columnCommand);


            DateTime startDate = dtSince.Value;
            EmailRepository repo = new EmailRepository( txtEmail.Text, txtPassword.Text);

            List<MailPreview> mailPreviews = repo.GetMailPreviews(startDate ,txtFrom.Text.Trim()).ToList();

            dgvEmailHeaders.DataSource = mailPreviews;

            webBrowserEmailBody.DocumentText = "";
            txtPONumber.Text = "";
            txtQuantity.Text = "";
            txtInvoiceDate.Text = "";
            txtPrice.Text = "";
            txtItemNumber.Text = "";
            txtShipTo.Text = "";
            txtCompany.Text = "";

            btnScrap.Enabled = false;
            btnExport.Enabled = false;
        }

        private void dgvEmailHeaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvEmailHeaders.Columns["ColumnCommand"].Index)
            {
                txtPONumber.Text = "";
                txtQuantity.Text = "";
                txtInvoiceDate.Text = "";
                txtPrice.Text = "";
                txtShipTo.Text = "";
                txtItemNumber.Text = "";
                txtCompany.Text = "";

                MailPreview selectedMailPreview = (MailPreview)dgvEmailHeaders.Rows[e.RowIndex].DataBoundItem;
                txtInvoiceDate.Text =  selectedMailPreview.ReceivedDateTime.ToShortDateString();

                MailInfo mailInfoSelected = selectedMailPreview.MailInfo;
                EmailRepository repo = new EmailRepository(txtEmail.Text, txtPassword.Text);
                Mail mailDetail = repo.GetMailDetail(mailInfoSelected);

                webBrowserEmailBody.DocumentText = mailDetail.HtmlBody;
                btnScrap.Enabled = true;
                btnExport.Enabled = false;
            }
        }

        private void btnScrap_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            try
            {

                bool autoForward = cbIsAutoForwarded.Checked;
                document.LoadHtml(webBrowserEmailBody.DocumentText);
                HtmlNode[] nodes = document.DocumentNode.SelectNodes("//table[@class='MsoNormalTable']").ToArray();

                HtmlNode nodeTable1 = nodes[4];
                HtmlNode[] trNodes1 = nodeTable1.ChildNodes.ToArray();
                HtmlNode[] tdNodes1 = trNodes1[1].ChildNodes.ToArray();

                string poNumber;
                string soldOn;
                string mustShipBy;
                string shipMethod;
                string deliveryType;
                string paymentMethod;
                if (autoForward)
                {
                    poNumber = tdNodes1[0].InnerText.Trim();
                    soldOn = tdNodes1[2].InnerText.Trim();
                    mustShipBy = tdNodes1[4].InnerText.Trim();
                    shipMethod = tdNodes1[6].InnerText.Trim();
                    deliveryType = tdNodes1[8].InnerText.Trim();
                    paymentMethod = tdNodes1[10].InnerText.Trim();

                }
                else
                {
                    poNumber = tdNodes1[0].InnerText.Trim();
                    soldOn = tdNodes1[1].InnerText.Trim();
                    mustShipBy = tdNodes1[2].InnerText.Trim();
                    shipMethod = tdNodes1[3].InnerText.Trim();
                    deliveryType = tdNodes1[4].InnerText.Trim();
                    paymentMethod = tdNodes1[5].InnerText.Trim();

                }

                HtmlNode nodeTable2 = nodes[7];
                HtmlNode[] trNodes2 = nodeTable2.ChildNodes.ToArray();
                HtmlNode[] tdNodes2 = trNodes2[1].ChildNodes.ToArray();

                string shipFrom;
                string shipToFull;

                if (autoForward)
                {
                    shipFrom = tdNodes2[4].InnerText.Trim();
                    shipToFull = tdNodes2[8].Descendants("span").FirstOrDefault().Descendants("span").FirstOrDefault().InnerHtml;

                }
                else
                {
                    shipFrom = tdNodes2[2].InnerText.Trim();
                    shipToFull = tdNodes2[3].Descendants("span").FirstOrDefault().InnerHtml;
                }


                string[] shipToFullComponents = shipToFull.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries);
                string shipTo = shipToFullComponents[0];

                string Customer = tdNodes2[4].InnerText.Trim();

                HtmlNode nodeTable3 = nodes[11];
                List<HtmlNode> table3Rows = nodeTable3.ChildNodes.ToList().Skip(1).ToList();
                table3Rows.RemoveAt(table3Rows.Count - 1);

                int totalQuantity = 0;
                decimal totalPrice = 0.0m;
                string priceBreakdown = "";
                string totalItemInfo = "";
                foreach(HtmlNode trNode in table3Rows)
                {
                    HtmlNode[] tdNodes3 = trNode.ChildNodes.ToArray();

                    int itemQuantity = Convert.ToInt32(tdNodes3[0].InnerText.Trim());
                    totalQuantity += itemQuantity;

                    decimal itemPrice = Convert.ToDecimal(tdNodes3[autoForward ? 8 : 4].InnerText.Replace("$", "").Trim());
                    totalPrice += itemPrice;
                    priceBreakdown += " " + string.Format("{0} X {1}", (itemPrice/ itemQuantity).ToString("C"), itemQuantity) + "," ;


                    string itemText = autoForward ? tdNodes3[2].Descendants("span").FirstOrDefault().Descendants("span").FirstOrDefault().InnerHtml : tdNodes3[1].Descendants("span").FirstOrDefault().InnerHtml;
                    string[] itemTextComponents = itemText.Split(new string[] { "<br>", "<o:p></o:p>" }, StringSplitOptions.RemoveEmptyEntries);
                    string itemNumberSingle = itemTextComponents[0];

                    string itemNumberQuantity = string.Format("({0}) X {1},", itemNumberSingle, itemQuantity);
                    totalItemInfo += " " + itemNumberQuantity;
                }


                totalItemInfo = totalItemInfo.Remove(totalItemInfo.Length - 1, 1);
                priceBreakdown = priceBreakdown.Remove(priceBreakdown.Length - 1, 1);

                txtPONumber.Text = poNumber;
                txtQuantity.Text = totalQuantity.ToString();
                txtPrice.Text = totalPrice.ToString("C");
                txtShipTo.Text = shipTo;
                txtItemNumber.Text = totalItemInfo;
                txtCompany.Text = shipFrom;
                txtPriceBreakdown.Text = priceBreakdown;
                btnExport.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory() +"\\Output";
                saveFileDialog.Filter = "excel file (*.xlsx) | *.xlsx|All files(*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;


                if(saveFileDialog.ShowDialog()==     DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb;
                    Worksheet ws;
                    if (File.Exists(filePath))
                    {
                        wb = excel.Workbooks.Open(filePath);
                        ws = wb.Worksheets[1];
                        int lastRow = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing).Row;
                        for(int i=2; i<=lastRow; i++)
                        {
                            if(ws.Cells[i, 1].Value2 == txtPONumber.Text)
                            {
                                MessageBox.Show("PO Number " + txtPONumber.Text + " Already inserted!");
                                wb.Close();
                                return;
                            }
                        }

                        ws.Cells[lastRow + 1, 1].Value2 = txtPONumber.Text;
                        ws.Cells[lastRow + 1, 2].Value2 = txtQuantity.Text;
                        ws.Cells[lastRow + 1, 4].Value2 = txtInvoiceDate.Text;
                        ws.Cells[lastRow + 1, 5].Value2 = txtPrice.Text;
                        ws.Cells[lastRow + 1, 6].Value2 = txtShipTo.Text;
                        ws.Cells[lastRow + 1, 7].Value2 = txtItemNumber.Text;
                        ws.Cells[lastRow + 1, 8].Value2 = txtCompany.Text;
                        ws.Cells[lastRow + 1, 9].Value2 = txtPriceBreakdown.Text;
                        ws.Columns.AutoFit();
                        wb.Save();
                    }
                    else
                    {
                        wb = excel.Workbooks.Add();
                        ws = wb.Worksheets[1];
                        //Add Headers
                        ws.Cells[1, 1].Value2 = "PO Number";
                        ws.Cells[1, 2].Value2 = "Quantity";
                        ws.Cells[1, 3].Value2 = "Invoice #";
                        ws.Cells[1, 4].Value2 = "Invoice Date";
                        ws.Cells[1, 5].Value2 = "Price";
                        ws.Cells[1, 6].Value2 = "Ship To";
                        ws.Cells[1, 7].Value2 = "Item #";
                        ws.Cells[1, 8].Value2 = "Company";
                        ws.Cells[1, 9].Value2 = "Price Breakdown";
                        int lastRow = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell,Type.Missing).Row;

                        ws.Cells[lastRow + 1, 1].Value2 = txtPONumber.Text;
                        ws.Cells[lastRow + 1, 2].Value2 = txtQuantity.Text;
                        ws.Cells[lastRow + 1, 4].Value2 = txtInvoiceDate.Text;
                        ws.Cells[lastRow + 1, 5].Value2 = txtPrice.Text;
                        ws.Cells[lastRow + 1, 6].Value2 = txtShipTo.Text;
                        ws.Cells[lastRow + 1, 7].Value2 = txtItemNumber.Text;
                        ws.Cells[lastRow + 1, 8].Value2 = txtCompany.Text;
                        ws.Cells[lastRow + 1, 9].Value2 = txtPriceBreakdown.Text;
                        ws.Columns.AutoFit();

                        wb.SaveAs(filePath);
                    }

                    wb.Close();
                    //                    ws.Cells[1, 1].Value2 = "Hello";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtSince.Value = DateTime.Now.AddDays(-7);
        }
    }
}
