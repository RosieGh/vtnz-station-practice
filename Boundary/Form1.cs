using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTNZ;

namespace oscar
{
    public partial class Form1 : Form
    {
        private vtnz _objVTNZ;
        public Form1()
        {
            InitializeComponent();
            _objVTNZ = new vtnz("vtnz", "North Harbour 3-5 Saturn Place, Albany", "000", "Mon -Fri - 7.30am - 5pm");
        }

        // the window event is used to preload the information on the window
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1 show station detail
            lblHeader.Text = _objVTNZ.ShowStationDetail();
            
            // 2 Add service list
            IServiceType singleService = new CarWrap("WoF inspection", 50M);
            _objVTNZ.AddService(singleService);
            singleService = new CarWrap("Modified vehicle check-up", 200M);
            _objVTNZ.AddService(singleService);
            singleService = new CarWrap("Pre-purchased Inspection", 150M);
            _objVTNZ.AddService(singleService);
            singleService = new CarWrap("Certificate of Fitness", 210M);
            _objVTNZ.AddService(singleService);

            // 3 put service list to the list box, show the information of the service
            for (int i=0; i< _objVTNZ.ServiceList.Count; i++)
            {
                litInspections.Items.Add(_objVTNZ.ServiceList.ElementAt(i).ServiceName + " " +
                   Convert.ToString(_objVTNZ.ServiceList.ElementAt(i).ServicePrice));
            }

        }

        private void btnInspection_Click(object sender, EventArgs e)
        {
            // 1 find which one do we select from the list box
            int selectedItemIndex = litInspections.SelectedIndex;

            // 2 find the corresponding one in our vtnz service list
            IServiceType selectedService = _objVTNZ.ServiceList.ElementAt(selectedItemIndex);

            // 3 call request to accumulate those three information
            _objVTNZ.Request(selectedService);

            // 4 show all those three information on the control

            lbl_ReqDetailsPrompt.Text = _objVTNZ.ShowAllDetail();

            lbl_reqTotalPricePrompt.Text = _objVTNZ.GetTotalPrice();

            lbl_ReqTotalNumPrompt.Text = _objVTNZ.GetTotalNumber();
        }
    }
}
