namespace Tomboy
{
	public class GnomeFactory : IPlatformFactory
	{
		// TODO: port settings code to GSettings
		public IPropertyEditor CreatePropertyEditorEntry (string key, Gtk.Entry sourceEntry)
		{
			return new PropertyEditorEntry (key, sourceEntry);
		}

		public IPropertyEditorBool CreatePropertyEditorToggleButton (
		        string key, Gtk.CheckButton sourceButton)
		{
			return new PropertyEditorToggleButton (key, sourceButton);
		}

		public IPreferencesClient CreatePreferencesClient ()
		{
			return new XmlPreferencesClient ();
		}

		public INativeApplication CreateNativeApplication ()
		{
			return new GnomeApplication ();
		}

		public IKeybinder CreateKeybinder ()
		{
			return new XKeybinder ();
		}
	}
}