﻿<%@ Page Language="C#" MasterPageFile="~/MasterPages/GCIntranet.Master" AutoEventWireup="true" CodeBehind="content-en.aspx.cs" Inherits="GCIntranetTheme.content_en" %>
<%--<%@ MasterType virtualpath="~/MasterPages/GCIntranet.Master" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h2>Heading&#32;2&#32;(<code>h2</code>)</h2>
        <section>
            <h3>Heading&#32;3&#32;(<code>h3</code>)</h3>
            <section>
                <h4>Heading&#32;4&#32;(<code>h4</code>)</h4>
                <section>
                    <h5>Heading&#32;5&#32;(<code>h5</code>)</h5>
                    <section>
                        <h6>Heading&#32;6&#32;(<code>h6</code>)</h6>
                        <p>Paragraph - default appearance</p>
                    </section>
                </section>
            </section>
        </section>
    </section>
    <p><a href="#">Link</a></p>
    <ul>
        <li>unordered list&#32;(<code>ul</code>) - level&#32;1
            <ul>
                <li>unordered list&#32;(<code>ul</code>) - level&#32;2
                    <ul>
                        <li>unordered list&#32;(<code>ul</code>) - level&#32;3</li>
                    </ul>
                </li>
            </ul>
        </li>
    </ul>
    <ol>
        <li>ordered list&#32;(<code>ol</code>) - level&#32;1</li>
        <li>ordered list&#32;(<code>ol</code>) - level&#32;1
            <ol>
                <li>ordered list&#32;(<code>ol</code>) - level&#32;2</li>
                <li>ordered list&#32;(<code>ol</code>) - level&#32;2
                    <ol>
                        <li>ordered list&#32;(<code>ol</code>) - level&#32;3</li>
                        <li>ordered list&#32;(<code>ol</code>) - level&#32;3</li>
                    </ol>
                </li>
            </ol>
        </li>
    </ol>
    <table class="table table-striped">
        <caption>Table caption</caption>
        <thead>
            <tr>
                <th scope="col">Table header&#32;(<code>th</code>)</th>
                <th scope="col">Table header&#32;(<code>th</code>)</th>
                <th scope="col">Table header&#32;(<code>th</code>)</th>
                <th scope="col">Table header&#32;(<code>th</code>)</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
            </tr>
            <tr>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
            </tr>
            <tr>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
                <td>Table data&#32;(<code>td</code>)</td>
            </tr>
        </tbody>
    </table>
    <form method="post" action="#" class="form-horizontal">
        <div class="form-group">
            <label for="data1" class="col-sm-3 control-label">Form&#32;<code>input</code></label>
            <div class="col-sm-9">
                <input type="text" id="data1" name="data1" class="form-control">
            </div>
        </div>
        <div class="form-group">
            <label for="data2" class="col-sm-3 control-label">Form&#32;<code>textarea</code></label>
            <div class="col-sm-9">
                <textarea id="data2" rows="3" cols="15" name="data2" class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label for="data4" class="col-sm-3 control-label">Form&#32;<code>select</code></label>
            <div class="col-sm-9">
                <select name="data4" id="data4" class="form-control">
                    <option value="1">Option&#32;1</option>
                    <option value="2">Option&#32;2</option>
                    <option value="3">Option&#32;3</option>
                    <option value="4">Option&#32;4</option>
                </select>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-3 col-sm-9">
                <button type="submit" class="btn btn-primary">Submit</button>
            </div>
        </div>
    </form>
    <blockquote>
        <p>"<code>blockquote</code>"</p>
    </blockquote>
</asp:Content>
