using System;
using Flex.Smoothlake.FlexLib;
using System.Threading.Tasks; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Radio _thisRadio;
        private Slice _thisSlice;
        

        public Form1()
        {
            InitializeComponent();
            
            API.RadioAdded += API_RadioAdded;
            API.RadioRemoved += API_RadioRemoved;
            API.ProgramName = "K1PGV's test Program";
            
            API.Init();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
        }

        private void API_RadioAdded(Radio radio)
        {
           
            _thisRadio = radio;

            modelTextBox.Text = radio.Model;
            serialTextBox.Text += radio.Serial;
            radioIPAddress.Text += radio.IP;
            
            
            // The properties, such as Nickname and Callsign, can't be read
            // successfully until you've received a PropertyChanged event
            // for that property... this is done after connect.
            //
            radio.PropertyChanged += radio_PropertyChanged;

           
        }

        private void radio_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           

            if (e.PropertyName.Equals("Nickname"))
            {
                nickameTextBox.Text = _thisRadio.Nickname;
            }

            if (e.PropertyName.Equals("Callsign"))
            {
                callsignTextBox.Text = _thisRadio.Callsign;
            }
             
        }
       
        private void API_RadioRemoved(Radio radio)
        {
           
           
        }
                     
        private void button1_Click(object sender, EventArgs e)
        {

            _thisRadio.Disconnect();
            Application.Exit();
        }
             

        private void button3_Click(object sender, EventArgs e)
        {
            
            _thisRadio.Connect();
        }
               
       
        private void btnUSB_Click(object sender, EventArgs e)
        {
            _thisRadio.ActiveSlice.DemodMode = "USB";
        }
               

        private void btnMute_Click(object sender, EventArgs e)
        {
            // mute active slice audio
            _thisRadio.ActiveSlice.Mute = true;
            lblMute.Text = "Muted"; 
        }
                

        private void serialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioIPAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

   