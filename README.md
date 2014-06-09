BrowserLinkApiIssue
===================

Test of issue with Browserlink amending Html in web API output

Background:

I ran into a situation where a Web API output was being corrupted if a field in the JSON result contained Html, and the API was called with debugging when BrowserLink was enabled.

BrowserLink interprets any Html content sent in a JSON response as if it were a regular html response and inserts the Browserlink script section (below) before the `</body>` tag. This causes JSON parsing problems.
<pre>
&lt;!-- Visual Studio Browser Link --&gt;
&lt;script type="application/json" id="__browserLink_initializationData"&gt;
    {"appName":"[browser]"}
&lt;/script&gt;
&lt;script type="text/javascript" src="http://localhost:[port]/[ref]/browserLink" async="async"&gt;&lt;/script&gt;
&lt;!-- End Browser Link --&gt;
</pre>

Reported to [Microsoft Connect](https://connect.microsoft.com/VisualStudio/feedback/details/810547/vs2013-rtm-browserlink-inserts-and-corrupts-json-result-in-webapi-containing-html).

** The Connect issue has now been flagged as resolved in Visual Studio 2013 Update 2 **

I have checked this and it does work.
