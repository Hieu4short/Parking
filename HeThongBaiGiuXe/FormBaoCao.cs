using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace HeThongBaiGiuXe
{
    public partial class FormBaoCao : Form
    {

        public FormBaoCao()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = DateTime.Now;
        }
        Modify modify = new Modify();

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "HeThongBaiGiuXe.Report5.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            string query = "SELECT * FROM ViewLuotGuiXe WHERE ThoiGianTraXe >= '@DauNgay' AND ThoiGianTraXe < '@HomSau'";
            DateTime selectedDatetime = dateTimePicker1.Value;
            DateTime dauNgay = new DateTime(selectedDatetime.Year, selectedDatetime.Month, selectedDatetime.Day);
            query = query.Replace("@DauNgay", dauNgay.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime dauNgayHomSau = dauNgay.AddDays(1);
            query = query.Replace("@HomSau", dauNgayHomSau.ToString("yyyy-MM-dd HH:mm:ss"));
            reportDataSource.Value = modify.Table(query);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            FormBaoCao_Load(null, null);
        }
    }
}
