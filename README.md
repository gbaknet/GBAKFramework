# GBAKFramework
GBAKFramework open source database processing http://gbak.net

xml.TModel

<pre>
<code>
&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;root&gt;
&lt;!-- Currently only one server is supported. --&gt;
  &lt;connections&gt;
    &lt;connection Server="" Database="" UserID="" Password="" /&gt;
  &lt;/connections&gt;
  &lt;!-- One or more table name(s) list --&gt;
  &lt;table name="TableName" /&gt;
  &lt;!-- One or more stored procedure(s) list --&gt;
  &lt;sp name="SPName"&gt;
    &lt;Result name="Result1"&gt;
      &lt;!-- Result parameter info (example. "SELECT Result1ParameterName1,Result1ParameterName2,Result1ParameterName3 FROM table;") --&gt;
      &lt;Parameter name="Result1ParameterName1" type="bigint" /&gt;
      &lt;Parameter name="Result1ParameterName2" type="date" /&gt;
      &lt;Parameter name="Result1ParameterName3" /&gt;
    &lt;/Result&gt;
    &lt;!-- If there is more than one return value, you can duplicate "&lt;Result&gt;". --&gt;
    &lt;Result name="Result2"&gt;
      &lt;Parameter name="Result2ParameterName1" type="date" /&gt;
    &lt;/Result&gt;
  &lt;/sp&gt;
&lt;/root&gt;
</code>
</pre>

You should save the file "xml.TModel" after you are done. You should then save the file "TModel.tt".

