
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry TopLeftTxf;

	private global::Gtk.Entry TopRightTxf;

	private global::Gtk.CheckButton IsdirectPropCbx;

	private global::Gtk.Entry BottomLeftTxf;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.Label resultLbl;

	private global::Gtk.Label BottomLeftLbl;

	private global::Gtk.Button CalcBtn;

	private global::Gtk.Label label11;

	private global::Gtk.HSeparator hseparator2;

	private global::Gtk.HSeparator hseparator3;

	private global::Gtk.Label label7;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.TopLeftTxf = new global::Gtk.Entry();
		this.TopLeftTxf.CanFocus = true;
		this.TopLeftTxf.Name = "TopLeftTxf";
		this.TopLeftTxf.IsEditable = true;
		this.TopLeftTxf.InvisibleChar = '•';
		this.fixed1.Add(this.TopLeftTxf);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.TopLeftTxf]));
		w1.X = 39;
		w1.Y = 29;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.TopRightTxf = new global::Gtk.Entry();
		this.TopRightTxf.CanFocus = true;
		this.TopRightTxf.Name = "TopRightTxf";
		this.TopRightTxf.IsEditable = true;
		this.TopRightTxf.InvisibleChar = '•';
		this.fixed1.Add(this.TopRightTxf);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.TopRightTxf]));
		w2.X = 339;
		w2.Y = 27;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.IsdirectPropCbx = new global::Gtk.CheckButton();
		this.IsdirectPropCbx.CanFocus = true;
		this.IsdirectPropCbx.Name = "IsdirectPropCbx";
		this.IsdirectPropCbx.Label = global::Mono.Unix.Catalog.GetString("isDirectProp");
		this.IsdirectPropCbx.DrawIndicator = true;
		this.IsdirectPropCbx.UseUnderline = true;
		this.fixed1.Add(this.IsdirectPropCbx);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.IsdirectPropCbx]));
		w3.X = 630;
		w3.Y = 26;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.BottomLeftTxf = new global::Gtk.Entry();
		this.BottomLeftTxf.CanFocus = true;
		this.BottomLeftTxf.Name = "BottomLeftTxf";
		this.BottomLeftTxf.IsEditable = true;
		this.BottomLeftTxf.InvisibleChar = '•';
		this.fixed1.Add(this.BottomLeftTxf);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.BottomLeftTxf]));
		w4.X = 38;
		w4.Y = 75;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.WidthRequest = 550;
		this.hseparator1.Name = "hseparator1";
		this.fixed1.Add(this.hseparator1);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hseparator1]));
		w5.X = 45;
		w5.Y = 117;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.resultLbl = new global::Gtk.Label();
		this.resultLbl.Name = "resultLbl";
		this.resultLbl.LabelProp = global::Mono.Unix.Catalog.GetString("--result--");
		this.fixed1.Add(this.resultLbl);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.resultLbl]));
		w6.X = 343;
		w6.Y = 135;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.BottomLeftLbl = new global::Gtk.Label();
		this.BottomLeftLbl.Name = "BottomLeftLbl";
		this.BottomLeftLbl.LabelProp = global::Mono.Unix.Catalog.GetString("------");
		this.fixed1.Add(this.BottomLeftLbl);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.BottomLeftLbl]));
		w7.X = 44;
		w7.Y = 133;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.CalcBtn = new global::Gtk.Button();
		this.CalcBtn.CanFocus = true;
		this.CalcBtn.Name = "CalcBtn";
		this.CalcBtn.UseUnderline = true;
		this.CalcBtn.Label = global::Mono.Unix.Catalog.GetString("Calculate");
		this.fixed1.Add(this.CalcBtn);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.CalcBtn]));
		w8.X = 633;
		w8.Y = 62;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label11 = new global::Gtk.Label();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Direct/Indirect Proportionscalculator");
		this.fixed1.Add(this.label11);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label11]));
		w9.X = 305;
		w9.Y = 3;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hseparator2 = new global::Gtk.HSeparator();
		this.hseparator2.WidthRequest = 120;
		this.hseparator2.Name = "hseparator2";
		this.fixed1.Add(this.hseparator2);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hseparator2]));
		w10.X = 207;
		w10.Y = 41;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hseparator3 = new global::Gtk.HSeparator();
		this.hseparator3.WidthRequest = 120;
		this.hseparator3.Name = "hseparator3";
		this.fixed1.Add(this.hseparator3);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hseparator3]));
		w11.X = 209;
		w11.Y = 81;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("?");
		this.fixed1.Add(this.label7);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label7]));
		w12.X = 344;
		w12.Y = 71;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 877;
		this.DefaultHeight = 394;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.CalcBtn.Clicked += new global::System.EventHandler(this.OnCalcBtnClick);
	}
}