using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem.UserControls
{

    public partial class uc_dashboard : UserControl
    {
        public static uc_dashboard _instance;
        public static uc_dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_dashboard();
                return _instance;
            }
        }

        public void reload()
        {
            myDatabase.Rooms(flp_container);
            myDatabase.getOverview(ci, co, rooms, rev);
        }

        public uc_dashboard()
        {
            InitializeComponent();
        }
    }
}
