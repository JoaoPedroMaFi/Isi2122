using Dashboard.Methods;
using Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Final_dash : Form
    {
        public Final_dash()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {

            var response = await RestHelper.Get_counties();
            Bx_response.Clear();
            Bx_response = RestHelper.BeautyJson(response, Bx_response);

        }

        private async void show_dates_Click(object sender, EventArgs e)
        {
            string date_begin;
            string date_end;

            date_begin = dateTimeBegin.Value.ToString("dd-MM-yyyy");
            date_end = dateTimeEnd.Value.ToString("dd-MM-yyyy");

            var response = await RestHelper.Get_Entry_Two_Dates(date_begin, date_end);
            Bx_One_Date.Clear();
            Bx_One_Date = RestHelper.BeautyJsonDate(response, Bx_One_Date);
        }

        private async void ButtonOnlyDate_Click(object sender, EventArgs e)
        {
            string date_begin;

            date_begin = dateTimePickerOnlyDate.Value.ToString("dd-MM-yyyy");

            var response = await RestHelper.Get_Entry_One_Date(date_begin);
            BoxOnlyDate.Clear();
            BoxOnlyDate = RestHelper.BeautyJsonDate(response, BoxOnlyDate);

        }

        private async void ButtonTwoCounties_Click(object sender, EventArgs e)
        {
            string date_begin;
            string date_end;

            date_begin = dateTimePickerBeginCounties.Value.ToString("dd-MM-yyyy");
            date_end = dateTimePickerEndCounties.Value.ToString("dd-MM-yyyy");

            var response = await RestHelper.Get_Entry_Counties(date_begin, date_end);
            Bx_TwoCounties.Clear();
            Bx_TwoCounties = RestHelper.BeautyJsonCounties(response, Bx_TwoCounties);

        }

        private async void OnEspecificCounty_Click(object sender, EventArgs e)
        {
            string date_begin;
            string date_end;
            string county;
            county = bx_county.Text.ToUpper();
            date_begin = dtpOnecountyBegin.Value.ToString("dd-MM-yyyy");
            date_end = dtpOnecountyEnd.Value.ToString("dd-MM-yyyy");

            var response = await RestHelper.Get_Entry_One_County(date_begin, date_end, county);
            Bx_OneCounty.Clear();
            Bx_OneCounty = RestHelper.BeautyJsonCounties(response, Bx_OneCounty);
        }

        private async void ShowStatusApi_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Get_StatusApi();
            Bx_statusApi.Clear();
            Bx_statusApi = RestHelper.BeautyJsonStatus(response, Bx_statusApi);
        }
    }
}
