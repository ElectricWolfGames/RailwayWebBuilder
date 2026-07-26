namespace RailwayWebBuilderCore._SiteData;

public static class GoogleAdsHelper
{
    // Only 1 in 4 ad slots actually render (75% reduction), shared across
    // every AdsBanner/AddSideAd call so the cut applies site-wide.
    private static int _adCounter;

    public static string AdsBanner
    {
        get
        {
            if (!ShouldShow())
                return string.Empty;

            string adsresp = @"
<script async src='//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js'></script>
<!-- VintageFilmsResponzive -->
<ins class='adsbygoogle'
     style='display:block'
     data-ad-client='ca-pub-5100298817928604'
     data-ad-slot='4349315263'
     data-ad-format='auto'></ins>
<script>
(adsbygoogle = window.adsbygoogle || []).push({});
</script>";
            return adsresp;
        }
    }

    internal static string AddSideAd()
    {
        if (!ShouldShow())
            return string.Empty;

        // VintageFilmsSide
        string adsresp = @"<script async src='//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js'></script>
<!--VintageFilmsSide-->
<ins class='adsbygoogle'
     style='display:block'
     data-ad-client='ca-pub-5100298817928604'
     data-ad-slot='5959737064'
     data-ad-format='auto'
     data-full-width-responsive='true'></ins>
<script>
(adsbygoogle = window.adsbygoogle || []).push({ });
</script>";
        return adsresp;
    }

    private static bool ShouldShow()
    {
        _adCounter++;
        return _adCounter % 4 == 0;
    }
}