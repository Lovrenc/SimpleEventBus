using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using SimpleEventBus;

namespace SimpleBusTest
{
    public partial class Form1 : Form
    {
        private List<TestClass> testclasses = new List<TestClass>();


        public Form1()
        {
            InitializeComponent();
            MainBus.Instance.Register(this);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainBus.Instance.Post(new ButtonClickBusEvent());
        }

        /// <summary>
        /// Subscribes to click events.
        /// </summary>
        /// <param name="e"></param>
        [Subscribe]
        public void OnButtonClicked(ButtonClickBusEvent e)
        {
            Console.WriteLine("button click event handled in Form1.cs " +
                              (e != null ? e.timeClicked.ToString() : ""));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MainBus.Instance.Post(new TextChangedBusEvent(textBox1.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            testclasses.Add(new TestClass());
            lblNoTestClasses.Text = testclasses.Count().ToString();
        }

        private void btnRemoveTestClasses_Click(object sender, EventArgs e)
        {
            //This is a bit of an odd example, since we are unregistering instances of TestClass from here.
            //Usually objects themselves are controlling when they don't want to listen anymore, but hence, this is onlye
            //an example of how to use SimpleBus implementation.
            testclasses.ForEach(t => t.Dispose());
            testclasses.Clear();
            lblNoTestClasses.Text = "0";
        }
    }
}
