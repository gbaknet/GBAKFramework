# GBAKFramework
GBAKFramework open source database processing http://gbak.net

xml.TModel

<pre>
<code>
&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;root&gt;
&lt;!-- There are more than one server support. --&gt;
  &lt;connections&gt;
    &lt;connection name="MyConnection1" Server="127.0.0.1" Database="DatabaseName" UserID="UserName" Password="Password" /&gt;
	&lt;connection name="MyConnection2" Server="" Database="" UserID="" Password="" /&gt;
  &lt;/connections&gt;
  &lt;database name="MyConnection1"&gt;
	  &lt;!-- One or more table name(s) list --&gt;
	  &lt;table name="TableName1" /&gt;
	  &lt;table name="TableName2" /&gt;
	  &lt;table name="TableName3" /&gt;
	  &lt;!-- (For Automatic Column Entry) For procedures that return a single table. --&gt;
	  &lt;sp name="SPName1" Result="Result1" /&gt;
	  &lt;sp name="SPName2" Result="Result1" /&gt;
	  &lt;!-- (For Automatic Column Entry) For procedures that return two or more tables. --&gt;
	  &lt;sp name="SPName1"&gt;
		&lt;Result name="Result1" /&gt;
		&lt;Result name="Result2" /&gt;
	  &lt;/sp&gt;
	  &lt;!-- (For Manual Column Entry) One or more stored procedure(s) list --&gt;
	  &lt;sp name="SPName1"&gt;
		&lt;Result name="Result1"&gt;
		  &lt;!-- Result parameter info (example. "SELECT Result1ParameterName1,Result1ParameterName2,Result1ParameterName3 FROM table;") --&gt;
		  &lt;Parameter name="Result1ParameterName1" type="bigint" /&gt;
		  &lt;Parameter name="Result1ParameterName2" type="date" /&gt;
		  &lt;Parameter name="Result1ParameterName3" /&gt;
		&lt;/Result&gt;
		&lt;!-- If there are more than one return value, you can duplicate "&lt;Result&gt;". --&gt;
		&lt;Result name="Result2"&gt;
		  &lt;Parameter name="Result2ParameterName1" type="date" /&gt;
		&lt;/Result&gt;
	  &lt;/sp&gt;
  &lt;/database&gt;
  &lt;database name="MyConnection2"&gt;
	&lt;!-- ... --&gt;
  &lt;/database&gt;
&lt;/root&gt;
</code>
</pre>

You should save the file "xml.TModel" after you are done. You should then save the file "TModel.tt".

