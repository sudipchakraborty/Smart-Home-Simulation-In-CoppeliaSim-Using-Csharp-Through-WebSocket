using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tools;

namespace HomeAutomation_Simulation
{
    public partial class frm_main : Form
    {
        Websocket_Client client;
        MSG msg;

        public frm_main()
        {
            InitializeComponent();
            client=new Websocket_Client();
            msg=new MSG(lst_msg);
        }

        private void btn_connect_with_home_Click(object sender, EventArgs e)
        {
            if(client.open())
            {
                msg.push("Connected with Home");
            }
            else
            {
                msg.push("Unable to connect with Home");
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_light_on_Click(object sender, EventArgs e)
        {
            client.send("Light on");
        }

        private void btn_light_off_Click(object sender, EventArgs e)
        {
            client.send("Light off");
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
             client.close();
        }

        private void btn_fan_on_Click(object sender, EventArgs e)
        {
            client.send("Fan on");
        }

        private void btn_fan_off_Click(object sender, EventArgs e)
        {
            client.send("Fan off");
        }

        private void btn_night_lamp_on_Click(object sender, EventArgs e)
        {
            client.send("Night Lamp on");
        }

        private void btn_night_lamp_off_Click(object sender, EventArgs e)
        {
            client.send("Night Lamp off");
        }

        private void btn_tv_on_Click(object sender, EventArgs e)
        {
            client.send("TV on");
        }

        private void btn_tv_off_Click(object sender, EventArgs e)
        {
            client.send("TV off");
        }

        private void btn_ac_on_Click(object sender, EventArgs e)
        {
            client.send("AC on");
        }

        private void btn_ac_off_Click(object sender, EventArgs e)
        {
            client.send("AC off");
        }

        private void btn_door_open_Click(object sender, EventArgs e)
        {
            client.send("Door Open");
        }

        private void btn_door_close_Click(object sender, EventArgs e)
        {
            client.send("Door Closed");
        }
    }
}
