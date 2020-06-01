using System;
using Gtk;
using Proportionen.Controller;
using Proportionen.Model;
using Proportionen.PropException;
using Proportionen.Validator;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnCalcBtnClick(object sender, EventArgs e)
    {
        // Collect the Data from View
        BottomLeftLbl.Text = "";
        resultLbl.Text = "";

        PropData data = new PropData();
        try
        {
            data.TopLeft = Convert.ToDouble(TopLeftTxf.Text);
            data.TopRight = Convert.ToDouble(TopRightTxf.Text);
            data.BottomLeft = Convert.ToDouble(BottomLeftTxf.Text);
            data.IsDirectProp = IsdirectPropCbx.Active;

            PropDataValidator vali = new PropDataValidator();

            PropCalculator calculator = new PropCalculator();
            calculator.CalculateResult(data, vali);

            // write back the results to the view
            BottomLeftLbl.Text = data.BottomLeft.ToString();
            resultLbl.Text = data.BottomRight.ToString();
        }
        catch(PropException pe)
        {
            resultLbl.Text = "A problem occurred. ErrorCode:" + pe.Error;
        }
        catch (Exception ex)
        {
            resultLbl.Text = "Invalid Data provided." + ex.Message;
        }

        // Caclulate the Data
        // Write results
    }
}
