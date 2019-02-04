using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AS1ProjectTeam08
{
    public partial class FormHousePurchase : Form
    {

        List<House> houseList = new List<House>();


        public FormHousePurchase()
        {

            InitializeComponent();


            OpenFileDialog openFileDialogCSV = new OpenFileDialog();
            openFileDialogCSV.InitialDirectory = ".";

            StreamReader inputFile;

            if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialogCSV.FileName);

            }
            else return;

            int tempInteger;
            string tempString;
            while (inputFile.EndOfStream == false)
            {

                string input = inputFile.ReadLine();
                string[] fields = input.Trim().Split(',');
                tempInteger = Int32.Parse(fields[3]);  //temporary integer so that it may be easily put in currency format
                tempString = String.Format("{0:c0}", tempInteger); //temporary string to be used in the currency format
                houseList.Add(new House(fields[0], fields[1], fields[2], tempString, fields[4]));


            }


        }

        private void buttonGetListings_Click(object sender, EventArgs e)
        {
            string s;

            var result1 = houseList.OrderBy(a => a.HouseType).ThenBy(a => a.Price.Length).ThenBy(a => a.Price); //sorts by house type then price length and then price. so i don't have to convert to integer.
            var result2 = (from n in houseList select n).Count(); //count
            var result3 = (from n in houseList select int.Parse(n.Price, NumberStyles.Currency)).Average(); //average removes currency format so it can calculate

            foreach (House house in result1)
            {

                house.AddToGridView(dataGridViewAllListings);
            }

            s = String.Format("{0:c0}", result3);
            labelListingsAverageNum.Text = s;
            labelListingsCountNum.Text = result2.ToString();
        }

        private void buttonFindHouses_Click(object sender, EventArgs e)
        {

            //checking for radio button status to change the string
            string hType = "";
            if (radioButtonTownHouse.Checked)
                hType = "TownHouse";
            else if (radioButtonCondo.Checked)
                hType = "Condo";
            else if (radioButtonHouse.Checked)
                hType = "House";
            else return;

            int numOfBedrooms = int.Parse(textBoxBedrooms.Text);
            int maximumPrice = int.Parse(textBoxMaxPrice.Text);
            string s;

            var result1 = from n in houseList where ((n.HouseType == hType) && (n.Bedrooms == numOfBedrooms.ToString()) && int.Parse(n.Price, NumberStyles.Currency) <= maximumPrice) select n;
            //where conditions are for radio button to house type, number of bedrooms equal the input and the max price being equal or less than the input.


            var filteredHouses = result1.OrderBy(a => a.Price.Length).ThenBy(a => a.Price); //ordering for string of only numbers.

            var result2 = (from n in filteredHouses select n).Count();

            if (result2 == 0)
            {
                return; //won't crash if no houses found
            }
            else
            {

                var result3 = (from n in filteredHouses select int.Parse(n.Price, NumberStyles.Currency)).Average();

                foreach (House house in filteredHouses)
                {
                    house.AddToGridView(dataGridViewFiltered);
                }

                //format for currency with no decimals
                s = String.Format("{0:c0}", result3);
                labelFilteredAverageNum.Text = s;
                labelFilteredCountNum.Text = result2.ToString();


            }


        }
    }

    public class House
    {
        //private string[] houseData;

        /*public string HouseCode { get{return houseData[0];} set{ houseData[0] = value;} }
        public string HouseType { get{return houseData[1];} set{ houseData[1] = value;} }
        public string Neighborhood { get{return houseData[2];} set{ houseData[2] = value;} }
        public string Price { get { return houseData[3]; } set { houseData[3] = value; } }
        public string Bedrooms { get { return houseData[4]; } set { houseData[4] = value; } }*/

        public string HouseCode
        {
            get;
            set;
        }
        public string HouseType
        {
            get;
            set;
        }
        public string Neighborhood
        {
            get;
            set;
        }
        public string Price
        {
            get;
            set;
        }
        public string Bedrooms
        {
            get;
            set;
        }

        public House(string houseCode, string houseType, string neighborhood, string price, string bedrooms)
        {
            this.HouseCode = houseCode;
            this.HouseType = houseType;
            this.Neighborhood = neighborhood;
            this.Price = price;
            this.Bedrooms = bedrooms;
        }

        /*public House(string[] fields)
        {
            houseData = fields;
        }*/

        public void AddToGridView(DataGridView dgv)
        {
            dgv.Rows.Add(HouseCode, HouseType, Neighborhood, Price, Bedrooms);
        }

    }

    public class Buyer
    {
        //private string[] buyerData;

        public string MaxPrice
        {
            get;
            set;
        }
        public string HouseType
        {
            get;
            set;
        }
        public string Bedrooms
        {
            get;
            set;
        }

        public Buyer(string maxPrice, string houseType, string bedrooms)
        {
            this.MaxPrice = maxPrice;
            this.HouseType = houseType;
            this.Bedrooms = bedrooms;
        }

    }
}