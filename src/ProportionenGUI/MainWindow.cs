using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using Proportionen.Model;
using Proportionen.Controller;
using Proportionen.Validator;
using Proportionen.PropException;

namespace ProportionenGUI
{
    class MainWindow : Window
    {
        [UI] private Entry _a_textbx = null;
        [UI] private Entry _b_textbx = null;
        [UI] private Entry _c_textbx = null;

        [UI] private CheckButton _isdirect_chbx = null;
        [UI] private Button _calculateBtn=null;

        [UI] private Label _resultLbl=null;
        [UI] private Label _bottomLeftLbl=null;


        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _calculateBtn.Clicked += OnCalcBtnClick;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }


           protected void OnCalcBtnClick(object sender, EventArgs e)
    {
        
        // Collect the Data from View
        _bottomLeftLbl.Text = "";
        _resultLbl.Text = "";

        PropData data = new PropData();
    
        try
        {
            data.TopLeft = Convert.ToDouble(_a_textbx.Text);
            data.TopRight = Convert.ToDouble(_b_textbx.Text);
            data.BottomLeft = Convert.ToDouble(_c_textbx.Text);
            data.IsDirectProp = _isdirect_chbx.Active;

            PropDataValidator vali = new PropDataValidator();

            PropCalculator calculator = new PropCalculator();
            calculator.CalculateResult(data, vali);

            // write back the results to the view
            _c_textbx.Text = data.BottomLeft.ToString();
            _resultLbl.Text = data.BottomRight.ToString();
            _bottomLeftLbl.Text = _c_textbx.Text;
        }
        catch(PropException pe)
        {
            _resultLbl.Text = "A problem occurred. ErrorCode:" + pe.Error;
        }
        catch (Exception ex)
        {
            _resultLbl.Text = "Invalid Data provided." + ex.Message;
        }

        // Caclulate the Data
        // Write results
        
    }
    }
}
