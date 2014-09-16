﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContentChannelList.ascx.cs" Inherits="RockWeb.Blocks.Cms.ContentChannelList" %>

<asp:UpdatePanel ID="upContentChannels" runat="server">
    <ContentTemplate>
        <Rock:ModalAlert ID="mdGridWarning" runat="server" />
        
        <div class="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-bullhorn"></i> Ad Campaign List</h1>
            </div>
            <div class="panel-body">

                <div class="grid grid-panel">
                    <Rock:Grid ID="gContentChannels" runat="server" AllowSorting="true" OnRowSelected="gContentChannels_Edit">
                        <Columns>
                            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                            <asp:BoundField DataField="EventGroupName" HeaderText="Event Group" SortExpression="EventGroupName" />
                            <asp:BoundField DataField="ContactFullName" HeaderText="Contact" SortExpression="ContactFullName" />
                            <Rock:DeleteField OnClick="gContentChannels_Delete" />
                        </Columns>
                    </Rock:Grid>
                </div>

            </div>
        </div>

    </ContentTemplate>
</asp:UpdatePanel>
