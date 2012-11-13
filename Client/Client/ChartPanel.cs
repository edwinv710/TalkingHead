using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Client
{
    public partial class ChartPanel : UserControl
    {
        public ChartPanel()
        {
            InitializeComponent();
            InitialChartPanel();
        }

        private void bt_chartview_Click(object sender, EventArgs e)
        {
            chart_history.Series.Clear();
            string newSerieID = cb_testType.SelectedValue.ToString();
            chart_history.Series.Add(newSerieID);

            switch (cb_chartType.SelectedItem.ToString())
            {
                case "SpLine":
                    chart_history.Series[newSerieID].ChartType = SeriesChartType.Spline;
                    break;
                case "Line":
                    chart_history.Series[newSerieID].ChartType = SeriesChartType.FastLine;
                    break;
            }

            chart_history.Series[newSerieID].LegendText = ((DataTable)cb_testType.DataSource).Rows[cb_testType.SelectedIndex]["TestName"].ToString();

            string startDate = string.Empty;
            string endDate = string.Empty;

            switch (cb_chartPeriod.SelectedIndex)
            {
                case 0:
                    startDate = DateTime.Now.Date.ToString();
                    endDate = DateTime.Now.ToString();
                    break;
                case 1:
                    DayOfWeek wd = DateTime.Now.DayOfWeek;
                    startDate = DateTime.Today.AddDays(-(int)wd).ToString();
                    endDate = DateTime.Now.ToString();
                    break;
                case 2:

                    int md = DateTime.Now.Day;
                    startDate = DateTime.Today.AddDays(-md).ToString();
                    endDate = DateTime.Now.ToString();
                    break;
                case 3:
                    //int yd = DateTime.Now.DayOfYear;
                    int yd = 365;
                    startDate = DateTime.Today.AddDays(-yd).ToString();
                    endDate = DateTime.Now.ToString();
                    break;
            }



            DataSet ds = msgCenter.Objects.TestResultObject.getTestResult(newSerieID, startDate, endDate);
            chart_history.DataSource = ds.Tables[0];
            //chart_history.Series[0].
            chart_history.Series[0].XValueMember = "testTime";
            chart_history.Series[0].YValueMembers = "maxValue";
            chart_history.DataBind();
            chart_history.Series[0].ToolTip = "#VALX: #VALY{D}";
        }

        private void InitialChartPanel()
        {
            DataSet testTypeDS = msgCenter.Objects.TestResultObject.getTestTypes();
            cb_testType.DataSource = testTypeDS.Tables[0];
            cb_testType.DisplayMember = "TestName";
            cb_testType.ValueMember = "ID";
            cb_testType.SelectedIndex = 0;
            cb_chartPeriod.SelectedIndex = 1;
            cb_chartType.SelectedIndex = 0;
        }
    }
}
