package md536e12d92d72287f5eef79806ccab03fa;


public class IconLabelRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.LabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("FormsPlugin.Iconize.Droid.IconLabelRenderer, FormsPlugin.Iconize.Droid", IconLabelRenderer.class, __md_methods);
	}


	public IconLabelRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == IconLabelRenderer.class)
			mono.android.TypeManager.Activate ("FormsPlugin.Iconize.Droid.IconLabelRenderer, FormsPlugin.Iconize.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public IconLabelRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == IconLabelRenderer.class)
			mono.android.TypeManager.Activate ("FormsPlugin.Iconize.Droid.IconLabelRenderer, FormsPlugin.Iconize.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public IconLabelRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == IconLabelRenderer.class)
			mono.android.TypeManager.Activate ("FormsPlugin.Iconize.Droid.IconLabelRenderer, FormsPlugin.Iconize.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
