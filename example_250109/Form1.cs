using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static example_250109.Form1;

namespace example_250109
{
    public delegate void EventDelegate(string eventname);

    public partial class Form1 : Form
    {
        EventManager eventManager = new EventManager();
        public Form1()
        {
            InitializeComponent();

            eventManager.AddEvent("sts", event1);
            eventManager.EventCall("sts", "메시지!");
        }

        public void event1(string msg)
        {
            MessageBox.Show(msg);
        }

        public void event2(string msg)
        {
            MessageBox.Show(msg);
        }

        #region 버튼
        private void addevent_button_Click(object sender, EventArgs e)
        {
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
        }

        private void callevent_button_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
    public class EventManager
    {
        Dictionary<string, EventDelegate> events = new Dictionary<string, EventDelegate>();

        public void AddEvent(string eventname, EventDelegate e)
        {
            events.Add(eventname, e); // sts, evnet1()
        }

        public void RemoveEvent(string eventname)
        {
            events.Remove(eventname);
        }
        public void EventCall(string eventname, string msg) => events[eventname].Invoke(msg); // sts, msg
    }
}
