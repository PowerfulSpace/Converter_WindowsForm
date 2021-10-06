using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        #region Поля

        static string url = @"https://www.cbr-xml-daily.ru/daily_json.js";
        static string currencyData;                             // Данные валют
        static JToken currency;                                 // Все валюты спаршенные и привидённые к токену
        static List<Currency> ListCurrency;                     // список валют
        static Dictionary<string, double> currencyRatesAndCode; // Словарь для поиска валюты по коду

        static bool isChangedComboBox1 = true;
        static bool isChangedComboBox2 = true;

        #endregion


        #region Основа

        private string GetRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            var content = new StreamReader(stream).ReadToEnd();

            return content;
        }

        private void UpdateCarrencyData(string url)
        {
            currencyData = GetRequest(url);

            ListCurrency = new List<Currency>();
            currencyRatesAndCode = new Dictionary<string, double>();


            var data = JObject.Parse(currencyData);
            currency = data["Valute"];

            foreach (var valute in currency)
            {
                foreach (var item in valute)
                {
                    Currency currency = new Currency();

                    currency.ID = item["ID"].ToString();
                    currency.NumCode = item["NumCode"].ToString();
                    currency.CharCode = item["CharCode"].ToString();
                    currency.Nominal = Convert.ToInt32(item["Nominal"].ToString());
                    currency.Name = item["Name"].ToString();
                    currency.Value = Convert.ToDouble(item["Value"].ToString());
                    currency.Previous = Convert.ToDouble(item["Previous"].ToString());

                    string charCode = item["CharCode"].ToString();
                    double value = Convert.ToDouble(item["Value"].ToString());

                    ListCurrency.Add(currency);
                    currencyRatesAndCode.Add(charCode, value);

                }
            }

            AddDataToTheComboBox();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void MyConstruct()
        {
            UpdateCarrencyData(url);

        }

        private void AddDataToTheComboBox()
        {
            foreach (var item in ListCurrency)
            {
                comboBox1.Items.Add(item.Name);
                comboBox2.Items.Add(item.Name);
            }
        }

        #endregion



        public Form1()
        {
            InitializeComponent();

            MyConstruct();

        }

        #region Кнопки

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateCarrencyData(url);

            foreach (var item in ListCurrency)
            {
                string text = string.Format("{0,-40} {1}", item.Name, item.Value);
                listBoxUpdate.Items.Add(text);
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

            foreach (var item in ListCurrency)
            {
                listBoxDownload.Items.Add(item.CharCode);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxSearch.Text;

            if (code != null)
            {
                code = code.ToUpper();

                foreach (var valute in currency)
                {
                    foreach (var codeValute in valute)
                    {
                        var charCode = codeValute["CharCode"].ToString();

                        if (charCode == code)
                        {
                            var rates = codeValute["Value"].ToString();

                            listBoxSearch.Items.Add(rates);

                        }
                    }
                }
            }
        }

        #endregion


        #region Конвертация данных

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCurrency2.Text = "";
            textBoxCurrency1.Text = "1";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCurrency1.Text == "") { textBoxCurrency2.Text = ""; }

            int count;

            bool isDigits = int.TryParse(textBoxCurrency1.Text, out count);

            if (isDigits)
            {

                string currencyName1 = comboBox1.Text;
                string currencyName2 = comboBox2.Text;

                double currencyValue1 = 0;
                double currencyValue2 = 0;

                foreach (var item in ListCurrency)
                {
                    if (currencyName1 == item.Name)
                    {
                        currencyValue1 = item.Value;
                    }

                    if (currencyName2 == item.Name)
                    {
                        currencyValue2 = item.Value;
                    }
                }

                try
                {
                    double data = (currencyValue1 / currencyValue2) * count;

                    string dataF = string.Format("{0:F4}", data);
                    textBoxCurrency2.Text = dataF.ToString();
                }
                catch (Exception) { }

            }

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCurrency1.Text = "";
            textBoxCurrency2.Text = "1";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBoxCurrency2.Text == "") { textBoxCurrency1.Text = ""; }

            int count;

            bool isDigits = int.TryParse(textBoxCurrency2.Text, out count);

            if (isDigits)
            {

                string currencyName1 = comboBox1.Text;
                string currencyName2 = comboBox2.Text;

                double currencyValue1 = 0;
                double currencyValue2 = 0;

                foreach (var item in ListCurrency)
                {
                    if (currencyName1 == item.Name)
                    {
                        currencyValue1 = item.Value;
                    }

                    if (currencyName2 == item.Name)
                    {
                        currencyValue2 = item.Value;
                    }
                }

                try
                {
                    double data = (currencyValue2 / currencyValue1) * count;

                    string dataF = string.Format("{0:F4}", data);
                    textBoxCurrency1.Text = dataF.ToString();
                }
                catch (Exception) { }

            }

        }

 
        #endregion

    }
}
