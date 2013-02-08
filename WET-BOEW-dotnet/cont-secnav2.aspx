<%@ Page Title="Content page + Secondary menu 2 - GC Web Usability theme" Language="C#" MasterPageFile="~/App_Master/GCWU-2col.Master" AutoEventWireup="true" CodeBehind="cont-secnav2.aspx.cs" Inherits="WET_BOEW_dotnet.cont_secnav2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPageHeader" runat="server">
Content page + Secondary menu 2 - GC Web Usability theme
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <section><h2>Heading 2 (<code>h2</code>) default appearance</h2>
	<section><h3>Heading 3 (<code>h3</code>) default appearance</h3>
		<section><h4>Heading 4 (<code>h4</code>) default appearance</h4>
			<section><h5>Heading 5 (<code>h5</code>) default appearance</h5>
				<section><h6>Heading 6 (<code>h6</code>) default appearance</h6>
					<p>Paragraph default appearance</p>
				</section>
			</section>
		</section>
	</section>
</section>

<p><a href="#">Link default appearance</a></p>
<p><a href="mailto:"><code>mailto:</code> link default appearance</a></p>
<p><a href="http://www." rel="external">Third party <code>http://www.</code> link default appearance</a></p>
<p><a href=".doc">Link to file downloads based on file type <code>.doc</code>, <code>.psd</code>, <code>.zip</code>, <code>.pdf</code>, <code>.xls</code>, <code>.xlt</code>, <code>.rtf</code> and <code>.txt</code> default appearance</a></p>
<p>Abbreviation default appearance: <abbr title="Treasury Board Secretariat">TBS</abbr>.</p>

<ul>
<li>unordered list (<code>ul</code>) first level default appearance
	<ul>
	<li>unordered list (<code>ul</code>) second level default appearance
		<ul>
		<li>unordered list (<code>ul</code>) third level default appearance</li>
		</ul>
	</li>
	</ul>
</li>
</ul>

<ol>
<li>ordered list (<code>ol</code>) first level default appearance</li>
<li>ordered list (<code>ol</code>) first level default appearance
	<ol>
	<li>ordered list (<code>ol</code>) second level default appearance</li>
	<li>ordered list (<code>ol</code>) second level default appearance
		<ol>
		<li>ordered list (<code>ol</code>) third level default appearance</li>
		<li>ordered list (<code>ol</code>) third level default appearance</li>
		</ol>
	</li>
	</ol>
</li>
</ol>

<table>
<caption>Table caption default appearance</caption>
<thead>
<tr>
<th scope="col">Table header (<code>th</code>) default appearance</th>
<th scope="col">Table header (<code>th</code>) default appearance</th>
</tr>
</thead>
<tbody>
<tr>
<td>Table data (<code>td</code>) default appearance</td>
<td>Table data (<code>td</code>) default appearance</td>
</tr>
</tbody>
</table>

<div class="module-form">
<div><label for="data1">Form input default appearance:</label> <input name="data1" type="text" id="data1" /></div>
<div><label for="data2">Form text area default appearance:</label> <textarea name="data2" cols="15" rows="3" id="data2"></textarea></div>
<div><label for="data4">Form <code>select</code> default appearance:</label> 
<select id="data4" name="data4">
<option value="Option 1">Option 1</option>
<option value="Option 2">Option 2</option>
<option value="Option 3">Option 3</option>
<option value="Option 4">Option 4</option>
</select></div>
<fieldset><legend>Form <code>legend</code>, <code>fieldset</code> and <code>checkbox</code> default appearance</legend>
<div><input name="checkbox" type="checkbox" id="data5" value="checkbox" />&#160;<label for="data5">Option 1</label>&#160;&#160;
<input name="checkbox" type="checkbox" id="data6" value="checkbox" />&#160;<label for="data6">Option 2</label>&#160;&#160;
<input name="checkbox" type="checkbox" id="data7" value="checkbox" />&#160;<label for="data7">Option 3</label>&#160;&#160;
<input name="checkbox" type="checkbox" id="data8" value="checkbox" />&#160;<label for="data8">Option 4</label></div>
</fieldset>
<div>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit default appearance" /><%--<input name="submit" type="submit" id="submit" value="Submit default appearance" />--%>
<input name="reset" type="reset" id="reset" value="Reset default appearance" /></div>
</div>

<blockquote>
<p>&quot;Blockquote default appearance&quot;.</p>
</blockquote>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSecondaryNav" runat="server">
<section><h3 class="top-section"><a href="section4/index-eng.html">Section 4</a></h3>
<div><ul>
<li class="top-level"><a href="#">Item 4a</a></li>
<li class="top-level"><a href="#">Item 4b</a></li>
<li class="top-level"><a href="#">Item 4c</a></li>
</ul></div>
<section><h4><a href="#">Section 4.1</a></h4>
<ul>
<li><a href="#">Item 4.1.1</a></li>
<li><a href="#">Item 4.1.2</a></li>
<li><a href="#">Item 4.1.3</a></li>
</ul>
</section>
<section><h4><a href="#">Section 4.2</a></h4>
<ul>
<li><a href="#">Item 4.2.1</a></li>
<li><a href="#">Item 4.2.2</a></li>
<li><a href="#">Item 4.2.3</a></li>
<li><a href="#">Item 4.2.4</a></li>
</ul>
</section>
<section><h4><a href="section4/section43/index-eng.html">Section 4.3</a></h4>
<ul>
<li><a href="#">Item 4.3.1</a></li>
<li><a href="#">Item 4.3.2</a></li>
</ul>
</section>
<section><h4><a href="#">Section 4.4</a></h4>
<ul>
<li><a href="#">Item 4.4.1</a></li>
<li><a href="#">Item 4.4.2</a></li>
<li><a href="#">Item 4.4.3</a></li>
<li><a href="#">Item 4.4.4</a></li>
</ul>
</section>
</section>

</asp:Content>
