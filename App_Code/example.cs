using System;
using System.Web.UI.WebControls;

//namespace ArtLebedevStudio
//{
	public class Example: System.Web.UI.Page
	{
		protected TextBox Input;
		protected Button Proceed;
		protected Literal Output;
	
		private void Page_Load (object sender, System.EventArgs e)
		{			
		}

		protected void Proceed_OnClick (object sender, EventArgs e)
		{
            ArtLebedevStudio.RemoteTypograf remoteTypograf = new ArtLebedevStudio.RemoteTypograf();

			remoteTypograf.xmlEntities();
			remoteTypograf.br (true);
			remoteTypograf.p (true);
			remoteTypograf.nobr (3);

			Output.Text = remoteTypograf.ProcessText (Input.Text);
		}

/*		#region inits
		override protected void OnInit (EventArgs e)
		{
			InitializeComponent();
			base.OnInit (e);
		}
		
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler (this.Page_Load);
		}
		#endregion */
	}
//}
