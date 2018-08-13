using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTNZ;

namespace Boundary
{
    public partial class Form1 : Form
    {
       private VTNZ_station _objvtnz;
        public Form1()
        {
            InitializeComponent();
            _objvtnz = new VTNZ_station("VTNZ NORTH HARBOUR","3-5Saturn Place,ALbany",
                "0000","Mon- Fri - 7:30am - 5:30 pm");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Header.Text = _objvtnz.ShowStationDetail();
           // //2.show the list od servicelist
           //IServiceItem singleService = new CarWrap("WOF",200M);
           // _objvtnz.AddSingleServiceIntoList(singleService);
           // singleService = new CarWrap("Car inspection",300M);
           // _objvtnz.AddSingleServiceIntoList(singleService);
           // singleService = new CarWrap("Fitness of CheckUp", 250M);
           // _objvtnz.AddSingleServiceIntoList(singleService);

           // for (int i = 0; i < _objvtnz.ObjServiceList.Count;i++)
           // {
           //     listBox_SerciceList.Items.Add(_objvtnz.ObjServiceList.ElementAt(i).ServiceName+" "+
           //         Convert.ToString(_objvtnz.ObjServiceList.ElementAt(i).ServicePrice));
           // }

        }

        private void Button_Request_Click(object sender, EventArgs e)
        {
                int selctedIndexNo = listBox_SerciceList.SelectedIndex;
                if (selctedIndexNo == -1)
                {
                    MessageBox.Show("Please select a service type111", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                IServiceItem selectedServiceItemFromTheList = _objvtnz.ObjServiceList.ElementAt(selctedIndexNo);
                _objvtnz.ShowSelectedService(selectedServiceItemFromTheList);

                label_PromptDetails.Text = _objvtnz.GetAllServiceDetail();
                label_PromptTotalPrice.Text = _objvtnz.GetTotalPrice();
                label_PromptTotalNumber.Text = _objvtnz.GetTotalNUmberService();


                }
        }

        private void radioButton_Car_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_Car.Checked)
                {
                    //2.show the list od servicelist
                    IServiceItem singleService = new CarWrap("WOF", 200M);
                    _objvtnz.AddSingleServiceIntoList(singleService);
                    singleService = new CarWrap("Car inspection", 300M);
                    _objvtnz.AddSingleServiceIntoList(singleService);
                    singleService = new CarWrap("Fitness of CheckUp", 250M);
                    _objvtnz.AddSingleServiceIntoList(singleService);

                    for (int i = 0; i < _objvtnz.ObjServiceList.Count; i++)
                    {
                        listBox_SerciceList.Items.Add(_objvtnz.ObjServiceList.ElementAt(i).ServiceName + " " +
                            Convert.ToString(_objvtnz.ObjServiceList.ElementAt(i).ServicePrice));
                    }

                }
                if (radioButton_Truck.Checked)
                {
                    //2.show the list od servicelist
                    IServiceItem singleService = new CarWrap("WOF", 200M);
                    _objvtnz.AddSingleServiceIntoList(singleService);
                    singleService = new CarWrap("Car inspection", 300M);
                    _objvtnz.AddSingleServiceIntoList(singleService);
                    singleService = new CarWrap("Fitness of CheckUp", 250M);
                    _objvtnz.AddSingleServiceIntoList(singleService);

                    for (int i = 0; i < _objvtnz.ObjServiceList.Count; i++)
                    {
                        listBox_SerciceList.Items.Add(_objvtnz.ObjServiceList.ElementAt(i).ServiceName + " " +
                            Convert.ToString(_objvtnz.ObjServiceList.ElementAt(i).ServicePrice));
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exceeding 24 hours");

            }
        }
    }
}
